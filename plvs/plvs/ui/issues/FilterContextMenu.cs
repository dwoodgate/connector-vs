﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using Atlassian.plvs.api;
using Atlassian.plvs.dialogs;
using Atlassian.plvs.models;

namespace Atlassian.plvs.ui.issues {
    public sealed class FilterContextMenu : ContextMenuStrip {
        private readonly JiraServer server;
        private readonly JiraCustomFilter filter;
        private readonly RunOnEditDialogOk runOnEditDialogOk;

        private readonly ToolStripMenuItem[] items;

        public delegate void RunOnEditDialogOk();

        public FilterContextMenu(JiraServer server, JiraCustomFilter filter, RunOnEditDialogOk runOnEditDialogOk) {
            this.server = server;
            this.filter = filter;
            this.runOnEditDialogOk = runOnEditDialogOk;

            items = new[]
                    {
                        new ToolStripMenuItem("Edit Filter", Resources.edit_in_browser, new EventHandler(editFilter)),
                        new ToolStripMenuItem("View Filter in Browser", Resources.view_in_browser,
                                              new EventHandler(browseFilter)),
                    };

            Items.Add("dummy");

            Opened += filterContextMenuOpened;
        }

        private void filterContextMenuOpened(object sender, EventArgs e) {
            Items.Clear();

            Items.Add(items[0]);
            if (!filter.Empty) {
                Items.Add(items[1]);
            }
        }

        private void browseFilter(object sender, EventArgs e) {
            string url = server.Url;
            try {
                Process.Start(url + filter.getBrowserQueryString());
            }
            catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
        }

        private void editFilter(object sender, EventArgs e) {
            EditCustomFilter ecf = new EditCustomFilter(server, filter);
            ecf.ShowDialog();
            if (ecf.Changed && runOnEditDialogOk != null)
                runOnEditDialogOk();
        }
    }
}