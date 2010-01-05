﻿using System.Windows.Forms;

namespace Atlassian.plvs.ui.fields {
    public class TextLineFieldEditor : JiraFieldEditor {
        private readonly Control editor = new TextBox();

        public TextLineFieldEditor(string value) {
            if (value != null) {
                editor.Text = value;
            }
        }

        public override Control Widget {
            get { return editor; }
        }

        public override int VerticalSkip {
            get { return editor.Height; }
        }

        public override void resizeToWidth(int width) {
            editor.Width = width;
        }
    }
}