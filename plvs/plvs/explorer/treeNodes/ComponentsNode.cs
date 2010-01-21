﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Atlassian.plvs.api.jira;
using Atlassian.plvs.ui;

namespace Atlassian.plvs.explorer.treeNodes {
    public class ComponentsNode : AbstractNavigableTreeNodeWithServer {
        private readonly Control parent;
        private readonly JiraProject project;

        private bool componentsLoaded;

        public ComponentsNode(Control parent, JiraServer server, JiraProject project) : base(server, "Components", 0) {
            this.parent = parent;
            this.project = project;
        }

        public override string getUrl(string authString) {
            return Server.Url + "/browse/" + project.Key 
                + "?" + authString 
                + "#selectedTab=com.atlassian.jira.plugin.system.project%3Acomponents-panel"; 
        }

        public override void onClick(JiraServerFacade facade, StatusLabel status) {
            if (componentsLoaded) return;
            componentsLoaded = true;
            Thread t = new Thread(() => loadComponents(facade, status));
            t.Start();
        }

        private void loadComponents(JiraServerFacade facade, StatusLabel status) {
            try {
                List<JiraNamedEntity> components = facade.getComponents(Server, project);
                parent.Invoke(new MethodInvoker(() => populateComponents(components)));
            } catch (Exception e) {
                status.setError("Unable to retrieve component list", e);
            }
        }

        private void populateComponents(List<JiraNamedEntity> components) {
            components.Reverse();
            foreach (JiraNamedEntity comp in components) {
                Nodes.Add(new ComponentNode(Server, project, comp));
            }
        }

    }
}
