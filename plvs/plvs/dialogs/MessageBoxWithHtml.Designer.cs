﻿namespace Atlassian.plvs.dialogs {
    partial class MessageBoxWithHtml {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonOk = new System.Windows.Forms.Button();
            this.webContent = new System.Windows.Forms.WebBrowser();
            this.labelIcon = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(377, 151);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // webContent
            // 
            this.webContent.IsWebBrowserContextMenuEnabled = false;
            this.webContent.Location = new System.Drawing.Point(67, 12);
            this.webContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.webContent.Name = "webContent";
            this.webContent.ScriptErrorsSuppressed = true;
            this.webContent.ScrollBarsEnabled = false;
            this.webContent.Size = new System.Drawing.Size(385, 110);
            this.webContent.TabIndex = 1;
            this.webContent.WebBrowserShortcutsEnabled = false;
            this.webContent.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webContent_Navigating);
            // 
            // labelIcon
            // 
            this.labelIcon.Location = new System.Drawing.Point(12, 9);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(49, 54);
            this.labelIcon.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelIcon);
            this.panel1.Controls.Add(this.webContent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 135);
            this.panel1.TabIndex = 3;
            // 
            // MessageBoxWithHtml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 186);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MessageBoxWithHtml";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "MessageBoxWithHtml";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.WebBrowser webContent;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.Panel panel1;
    }
}