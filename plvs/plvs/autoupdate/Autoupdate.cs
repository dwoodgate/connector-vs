﻿using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Xml.XPath;
using Atlassian.plvs.dialogs;
using Atlassian.plvs.windows;
using Timer=System.Timers.Timer;

namespace Atlassian.plvs.autoupdate {
    public class Autoupdate {
        private static readonly Autoupdate INSTANCE = new Autoupdate();
        private bool initialized;

        private const int ONE_HOUR = 1000 * 60 * 60;

        public delegate void UpdateAction();

        public static Autoupdate Instance {
            get { return INSTANCE; }
        }

        private const string STABLE_URL = "http://update.atlassian.com/atlassian-vs-plugin/latestStableVersion.xml";
        private const string SNAPSHOT_URL = "http://docs.atlassian.com/atlassian-vs-plugin/latestPossibleVersion.xml";

        public string NewVersionNumber { get; private set; }
        public string UpdateUrl { get; private set; }
        public string BlurbText { get; private set; }
        public string ReleaseNotesUrl { get; private set; }

        private Timer timer;

        private Autoupdate() {}

        public void initialize() {
            if (initialized) return;

            initialized = true;

            timer = new Timer { AutoReset = false, Interval = 20000 };
            timer.Elapsed += initialTimer;
            timer.Start();
        }

        private void initialTimer(object sender, ElapsedEventArgs e) {
            runUpdateWorkerThread(null, null);
            timer.AutoReset = true;
            timer.Elapsed -= initialTimer;
            timer.Elapsed += runUpdateWorkerThread;
            timer.Interval = ONE_HOUR;
            timer.Start();
        }

        private void runUpdateWorkerThread(object sender, ElapsedEventArgs e) {
            if (!GlobalSettings.AutoupdateEnabled) {
                return;
            }
            string url = GlobalSettings.AutoupdateSnapshots ? SNAPSHOT_URL : STABLE_URL;
            if (GlobalSettings.ReportUsage) {
                url = getUsageReportingUrl(url);
            }

            Thread t = new Thread(() => runSingleUpdateQuery(url, true));
            t.Start();
        }

        public void shutdown() {
            if (!initialized) {
                return;
            }
            initialized = false;
            timer.Stop();
            timer.Dispose();
        }

        public void reschedule() {
            shutdown();
            initialize();
        }

        public void runManualUpdate(bool stableOnly) {
            string url = stableOnly ? STABLE_URL : SNAPSHOT_URL;
            if (GlobalSettings.ReportUsage) {
                url = getUsageReportingUrl(url);
            }
//            Thread t = new Thread(new ThreadStart(delegate { 
//                if (runSingleUpdateQuery(url, false)) {
//                    Invoke(new MethodInvoker(delegate {

//                                             }));
//                } 
//            }));
        }

        private void showUpdateDialog() {
            AutoUpdateDialog dialog = new AutoUpdateDialog(NewVersionNumber, UpdateUrl, BlurbText, ReleaseNotesUrl);
            dialog.ShowDialog();
        }

        private bool runSingleUpdateQuery(string url, bool updateToolWindowButton) {
            IssueListWindow issueListWindow = IssueListWindow.Instance;
            try {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);

                req.Timeout = 5000;
                req.ReadWriteTimeout = 20000;
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream str = resp.GetResponseStream();

                XPathDocument doc = new XPathDocument(str);
                XPathNavigator nav = doc.CreateNavigator();
                XPathExpression expr = nav.Compile("/response/version/number");
                XPathNodeIterator it = nav.Select(expr);
                it.MoveNext();
                NewVersionNumber = it.Current.Value;

                Regex versionPattern = new Regex(@"(\d+\.\d+\.\d+)-(.+)-(\d+-\d+)");
                if (!versionPattern.IsMatch(NewVersionNumber)) {
                    return false;
                }
                string stamp = versionPattern.Match(NewVersionNumber).Groups[3].Value;
                if (NewVersionNumber == null) return false;

                expr = nav.Compile("/response/version/downloadUrl");
                it = nav.Select(expr);
                it.MoveNext();
                UpdateUrl = it.Current.Value.Trim();
                expr = nav.Compile("/response/version/releaseNotes");
                it = nav.Select(expr);
                it.MoveNext();
                BlurbText = it.Current.Value.Trim();
                expr = nav.Compile("/response/version/releaseNotesUrl");
                it = nav.Select(expr);
                it.MoveNext();
                ReleaseNotesUrl = it.Current.Value.Trim();

                if (PlvsVersionInfo.Stamp.CompareTo(stamp) < 0) {
                    if (issueListWindow != null && updateToolWindowButton) {
                        issueListWindow.setAutoupdateAvailable(showUpdateDialog);
                    }
                    return true;
                }
            } catch (Exception ex) {
                if (issueListWindow != null && updateToolWindowButton) {
                    issueListWindow.setAutoupdateUnavailable(ex);
                }
            }
            return false;
        }

        private string getUsageReportingUrl(string url) {
            return url;
        }
    }
}