﻿using System;
using System.Windows.Forms;
using Atlassian.plvs.ui.jira.issuefilternodes;

namespace Atlassian.plvs.ui.jira.issues.menus {
    public sealed class PresetFilterContextMenu: ContextMenuStrip {
        private readonly JiraPresetFilterTreeNode filterNode;
        private readonly MenuSelectionAction setAction;
        private readonly MenuSelectionAction clearAction;

        private readonly ToolStripMenuItem[] items;

        public delegate void MenuSelectionAction(JiraPresetFilterTreeNode filterNode);

        public PresetFilterContextMenu(JiraPresetFilterTreeNode filterNode, MenuSelectionAction setAction, MenuSelectionAction clearAction) {
            this.filterNode = filterNode;
            this.setAction = setAction;
            this.clearAction = clearAction;

            items = new[]
                    {
                        new ToolStripMenuItem("Set project", Resources.plus, new EventHandler(setProject)),
                        new ToolStripMenuItem("Clear Project", Resources.minus, new EventHandler(clearProject)), 
                    };

            Items.Add("dummy");

            Opened += filterContextMenuOpened;
        }

        private void filterContextMenuOpened(object sender, EventArgs e) {
            Items.Clear();

            Items.Add(items[0]);
            Items.Add(items[1]);
        }

        private void setProject(object sender, EventArgs e) {
            setAction(filterNode);
        }

        private void clearProject(object sender, EventArgs e) {
            clearAction(filterNode);
        }
    }
}