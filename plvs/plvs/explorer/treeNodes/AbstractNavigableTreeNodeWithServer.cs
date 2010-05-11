﻿using System.Collections.Generic;
using System.Windows.Forms;
using Atlassian.plvs.api.jira;
using Atlassian.plvs.models.jira;
using Atlassian.plvs.ui;
using Atlassian.plvs.ui.jira.issuefilternodes;

namespace Atlassian.plvs.explorer.treeNodes {
    public abstract class AbstractNavigableTreeNodeWithServer : TreeNodeWithJiraServer, NavigableJiraServerEntity {

        protected AbstractNavigableTreeNodeWithServer(JiraIssueListModel model, JiraServerFacade facade, JiraServer server, string name, int imageIdx) 
            : base(name, imageIdx) {
            Model = model;
            Facade = facade;
            Server = server;
        }

        protected JiraIssueListModel Model { get; private set; }
        protected JiraServerFacade Facade { get; private set; }
        public override sealed JiraServer Server { get; set; }

        public abstract string getUrl();
        public abstract void onClick(StatusLabel status);

        public virtual List<ToolStripItem> MenuItems { get { return null; }}
    }
}
