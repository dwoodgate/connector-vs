﻿using System;
using System.Collections.Generic;
using System.Linq;
using Atlassian.plvs.api.jira;
using Atlassian.plvs.Atlassian.plvs.api.soap.service;

namespace Atlassian.plvs.models.jira.fields {
    public class CustomFieldFiller : FieldFiller {
        public List<string> getFieldValues(String field, JiraIssue issue, object soapIssueObject) {
            RemoteIssue ri = soapIssueObject as RemoteIssue;
            if (ri == null) {
                return null;
            }
            RemoteCustomFieldValue[] customFields = ri.customFieldValues;
            foreach (RemoteCustomFieldValue customField in customFields) {
                if (customField.customfieldId.Equals(field)) {
                    return customField.values.ToList();
                }
            }
            return null;
        }
    }
}