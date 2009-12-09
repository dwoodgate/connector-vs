﻿using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Atlassian.plvs.dialogs {
    public partial class About : Form {
        private bool pageLoaded;

        public About() {
            InitializeComponent();

            picture.Image = Resources.atlassian_538x235;
            browser.DocumentText = string.Format(Resources.about_html, PlvsVersionInfo.Version);
            browser.ScrollBarsEnabled = false;

            StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e) {
            if (!pageLoaded) return;
            string url = e.Url.ToString();
            Process.Start(url);
            e.Cancel = true;
        }

        private void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {
            pageLoaded = true;
        }

        private void About_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar.Equals(Keys.Escape)) {
                Close();
            }
        }
    }
}