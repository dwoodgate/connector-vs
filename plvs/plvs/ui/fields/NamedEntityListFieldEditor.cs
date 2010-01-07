﻿using System.Collections.Generic;
using System.Windows.Forms;
using Atlassian.plvs.api;

namespace Atlassian.plvs.ui.fields {
    public class NamedEntityListFieldEditor : JiraFieldEditor {
        private readonly ListBox list = new ListBox
                               {
                                   SelectionMode = SelectionMode.MultiExtended,
                                   Height = MULTI_LINE_EDITOR_HEIGHT
                               };

        public NamedEntityListFieldEditor(
            JiraField field, IEnumerable<string> selectedEntityNames, IEnumerable<JiraNamedEntity> entities, FieldValidListener validListener)
            : base(field, validListener) {

            List<JiraNamedEntity> selected = new List<JiraNamedEntity>();

            foreach (JiraNamedEntity entity in entities) {
                foreach (var selectedEntityName in selectedEntityNames) {
                    if (!entity.Name.Equals(selectedEntityName)) continue;
                    selected.Add(entity);
                    break;
                }
                list.Items.Add(entity);
            }
            foreach (JiraNamedEntity sel in selected) {
                list.SelectedItems.Add(sel);
            }
        }

        public override Control Widget {
            get { return list; }
        }

        public override int VerticalSkip {
            get { return list.Height; }
        }

        public override void resizeToWidth(int width) {
            list.Width = width;
        }

        public override List<string> getValues() {
            List<string> sel = new List<string>();
            foreach (var item in list.SelectedItems) {
                sel.Add(((JiraNamedEntity) item).Id.ToString());
            }
            return sel;
        }
    }
}