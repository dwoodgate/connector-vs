﻿using System.Collections.Generic;
using Atlassian.plvs.api;
using Atlassian.plvs.Atlassian.plvs.api.soap.service;

namespace Atlassian.plvs.models.fields {
    public class SummaryFiller : FieldFiller {
        public List<string> getFieldValues(string field, JiraIssue issue, object soapIssueObject) {
            RemoteIssue ri = soapIssueObject as RemoteIssue;
            if (ri == null) {
                return null;
            }
            List<string> result = new List<string> { ri.summary };
            return result;
        }
    }
}