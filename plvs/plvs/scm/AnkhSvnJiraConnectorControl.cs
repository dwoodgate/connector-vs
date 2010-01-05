﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ankh.ExtensionPoints.IssueTracker;
using Atlassian.plvs.util;

namespace Atlassian.plvs.scm {
    public partial class AnkhSvnJiraConnectorControl : UserControl {
        public AnkhSvnJiraConnectorControl() {
            InitializeComponent();
        }

        private readonly MySettings settings = new MySettings("jira");

        public IssueRepositorySettings Settings {
            get { return settings; }
            set {
                if (value.CustomProperties == null) return;
                foreach (KeyValuePair<string, object> property in value.CustomProperties) {
                    settings.CustomProperties[property.Key] = property.Value;
                }
            }
        }

        public event EventHandler<ConfigPageEventArgs> PageChanged;

        private void InvokePageChanged(ConfigPageEventArgs e) {
            EventHandler<ConfigPageEventArgs> handler = PageChanged;
            if (handler != null) {
                handler(this, e);
            }
        }

        private class MySettings : IssueRepositorySettings {
            private readonly Dictionary<string, object> customProperties;

            public MySettings(string connectorName) : base(connectorName) {
                customProperties = new Dictionary<string, object>();
            }

            public override Uri RepositoryUri {
                get { return new Uri("http://www.atlassian.com/software/jira"); }
            }

            public override IDictionary<string, object> CustomProperties {
                get { return customProperties; }
            }
        }

        private void checkIntegrate_CheckedChanged(object sender, EventArgs e) {
            settings.CustomProperties[Constants.INTEGRATE_WITH_ANKH] = checkIntegrate.Checked ? "1" : "0";
            InvokePageChanged(new ConfigPageEventArgs { IsComplete = true });
        }
    }
}