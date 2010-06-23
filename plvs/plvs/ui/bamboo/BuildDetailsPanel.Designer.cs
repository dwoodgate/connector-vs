﻿namespace Atlassian.plvs.ui.bamboo {
    partial class BuildDetailsPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.webSummary = new System.Windows.Forms.WebBrowser();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.webLog = new System.Windows.Forms.WebBrowser();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.buttonViewInBrowser = new System.Windows.Forms.ToolStripButton();
            this.buttonRun = new System.Windows.Forms.ToolStripButton();
            this.buttonClose = new System.Windows.Forms.ToolStripButton();
            this.tabTests = new System.Windows.Forms.TabPage();
            this.buttonDebugTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textMethod = new System.Windows.Forms.TextBox();
            this.textClassName = new System.Windows.Forms.TextBox();
            this.buttonRunTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textNamespace = new System.Windows.Forms.TextBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabTests.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(666, 205);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(666, 252);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(666, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 0;
            // 
            // labelStatus
            // 
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabSummary);
            this.tabControl.Controls.Add(this.tabLog);
            this.tabControl.Controls.Add(this.tabTests);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(663, 199);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabSummary
            // 
            this.tabSummary.Controls.Add(this.webSummary);
            this.tabSummary.Location = new System.Drawing.Point(4, 22);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(655, 173);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "Summary";
            this.tabSummary.UseVisualStyleBackColor = true;
            // 
            // webSummary
            // 
            this.webSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webSummary.IsWebBrowserContextMenuEnabled = false;
            this.webSummary.Location = new System.Drawing.Point(3, 3);
            this.webSummary.MinimumSize = new System.Drawing.Size(20, 20);
            this.webSummary.Name = "webSummary";
            this.webSummary.ScriptErrorsSuppressed = true;
            this.webSummary.Size = new System.Drawing.Size(649, 167);
            this.webSummary.TabIndex = 0;
            this.webSummary.WebBrowserShortcutsEnabled = false;
            this.webSummary.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webSummary_Navigating);
            this.webSummary.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webSummary_DocumentCompleted);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.webLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabLog.Size = new System.Drawing.Size(655, 173);
            this.tabLog.TabIndex = 1;
            this.tabLog.Text = "Build Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // webLog
            // 
            this.webLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webLog.IsWebBrowserContextMenuEnabled = false;
            this.webLog.Location = new System.Drawing.Point(3, 3);
            this.webLog.MinimumSize = new System.Drawing.Size(20, 20);
            this.webLog.Name = "webLog";
            this.webLog.ScriptErrorsSuppressed = true;
            this.webLog.Size = new System.Drawing.Size(649, 167);
            this.webLog.TabIndex = 0;
            this.webLog.WebBrowserShortcutsEnabled = false;
            this.webLog.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webLog_Navigating);
            this.webLog.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webLog_DocumentCompleted);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonViewInBrowser,
            this.buttonRun,
            this.buttonClose});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(72, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // buttonViewInBrowser
            // 
            this.buttonViewInBrowser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonViewInBrowser.Image = global::Atlassian.plvs.Resources.view_in_browser;
            this.buttonViewInBrowser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonViewInBrowser.Name = "buttonViewInBrowser";
            this.buttonViewInBrowser.Size = new System.Drawing.Size(23, 22);
            this.buttonViewInBrowser.Text = "View In Browser";
            this.buttonViewInBrowser.Click += new System.EventHandler(this.buttonViewInBrowser_Click);
            // 
            // buttonRun
            // 
            this.buttonRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRun.Image = global::Atlassian.plvs.Resources.run_build;
            this.buttonRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(23, 22);
            this.buttonRun.Text = "Run Build";
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonClose.Image = global::Atlassian.plvs.Resources.close;
            this.buttonClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(23, 22);
            this.buttonClose.Text = "Close";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // tabTests
            // 
            this.tabTests.Controls.Add(this.label3);
            this.tabTests.Controls.Add(this.textNamespace);
            this.tabTests.Controls.Add(this.buttonDebugTest);
            this.tabTests.Controls.Add(this.label2);
            this.tabTests.Controls.Add(this.label1);
            this.tabTests.Controls.Add(this.textMethod);
            this.tabTests.Controls.Add(this.textClassName);
            this.tabTests.Controls.Add(this.buttonRunTest);
            this.tabTests.Location = new System.Drawing.Point(4, 22);
            this.tabTests.Name = "tabTests";
            this.tabTests.Size = new System.Drawing.Size(655, 173);
            this.tabTests.TabIndex = 2;
            this.tabTests.Text = "Tests";
            this.tabTests.UseVisualStyleBackColor = true;
            // 
            // buttonDebugTest
            // 
            this.buttonDebugTest.Enabled = false;
            this.buttonDebugTest.Location = new System.Drawing.Point(81, 113);
            this.buttonDebugTest.Name = "buttonDebugTest";
            this.buttonDebugTest.Size = new System.Drawing.Size(75, 23);
            this.buttonDebugTest.TabIndex = 12;
            this.buttonDebugTest.Text = "Debug Test";
            this.buttonDebugTest.UseVisualStyleBackColor = true;
            this.buttonDebugTest.Click += new System.EventHandler(this.buttonDebugTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Class";
            // 
            // textMethod
            // 
            this.textMethod.Location = new System.Drawing.Point(97, 56);
            this.textMethod.Name = "textMethod";
            this.textMethod.Size = new System.Drawing.Size(282, 20);
            this.textMethod.TabIndex = 9;
            // 
            // textClassName
            // 
            this.textClassName.Location = new System.Drawing.Point(97, 30);
            this.textClassName.Name = "textClassName";
            this.textClassName.Size = new System.Drawing.Size(282, 20);
            this.textClassName.TabIndex = 8;
            // 
            // buttonRunTest
            // 
            this.buttonRunTest.Location = new System.Drawing.Point(81, 83);
            this.buttonRunTest.Name = "buttonRunTest";
            this.buttonRunTest.Size = new System.Drawing.Size(75, 23);
            this.buttonRunTest.TabIndex = 7;
            this.buttonRunTest.Text = "Run Test";
            this.buttonRunTest.UseVisualStyleBackColor = true;
            this.buttonRunTest.Click += new System.EventHandler(this.buttonRunTest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Namespace";
            // 
            // textNamespace
            // 
            this.textNamespace.Location = new System.Drawing.Point(97, 4);
            this.textNamespace.Name = "textNamespace";
            this.textNamespace.Size = new System.Drawing.Size(282, 20);
            this.textNamespace.TabIndex = 13;
            // 
            // BuildDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "BuildDetailsPanel";
            this.Size = new System.Drawing.Size(666, 252);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabTests.ResumeLayout(false);
            this.tabTests.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton buttonClose;
        private System.Windows.Forms.ToolStripStatusLabel labelStatus;
        private System.Windows.Forms.WebBrowser webSummary;
        private System.Windows.Forms.WebBrowser webLog;
        private System.Windows.Forms.ToolStripButton buttonViewInBrowser;
        private System.Windows.Forms.ToolStripButton buttonRun;
        private System.Windows.Forms.TabPage tabTests;
        private System.Windows.Forms.Button buttonDebugTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textMethod;
        private System.Windows.Forms.TextBox textClassName;
        private System.Windows.Forms.Button buttonRunTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNamespace;
    }
}
