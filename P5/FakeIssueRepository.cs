using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";

        private static List<Issue> _Issues = new List<Issue>();

        public FakeIssueRepository()
        {
            _Issues = new List<Issue>();
            _Issues.Add(new Issue
            {
                Id = 1,
                ProjectId = 1,
                Title = "First Issue",
                DiscoveryDate = DateTime.MinValue,
                Discoverer = "Bishop, Dave",
                InitialDescription = "The first issue ever created.",
                Component = "FormMain",
                IssueStatusId = 1
            });
            _Issues.Add(new Issue
            {
                Id = 2,
                ProjectId = 1,
                Title = "Minor Problem",
                DiscoveryDate = DateTime.MaxValue,
                Discoverer = "Bishop, Dave",
                InitialDescription = "This is a minor issue.",
                Component = "FormCreateProject",
                IssueStatusId = 2
            });
            _Issues.Add(new Issue
            {
                Id = 3,
                ProjectId = 1,
                Title = "Mediocre Problem",
                DiscoveryDate = DateTime.Now,
                Discoverer = "Bishop, Dave",
                InitialDescription = "This is a medicore issue.",
                Component = "FormModifyProject",
                IssueStatusId = 3
            });

        }
        private string ValidateIssue(Issue issue)
        {
            //The following are placeholders for testing and running purposes
            string a = "";
            return a;
        }
        private bool IsDupliclate(string title)
        {
            bool isDuplicate = false;
            foreach(Issue i in _Issues)
            {
                if(title == i.Title)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }

        public string Add(Issue issue)
        {
            //int Id = issue.Id;
            string newIssueName = issue.Title.Trim();
            if (IsDupliclate(newIssueName))
            {
                return "Issue name already exists";
            }
            if (newIssueName == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if(issue.Discoverer == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            if(issue.DiscoveryDate == null)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if(issue.DiscoveryDate > DateTime.Now)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            int currentMaxId = 0;
            foreach(Issue l in _Issues)
            {
                currentMaxId = l.Id;
            }
            ++currentMaxId;

            _Issues = new List<Issue>();
            _Issues.Add(new Issue
            {
                Id = currentMaxId,
                ProjectId = 1,
                Title = issue.Title,
                DiscoveryDate = issue.DiscoveryDate,
                Discoverer = issue.Discoverer,
                InitialDescription = issue.InitialDescription,
                Component = issue.Component,
                IssueStatusId = issue.IssueStatusId
            });

            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectId)
        {
            return _Issues;
        }

        public bool Remove(Issue issue)
        {
            throw new System.NotImplementedException();
        }

        public string Modify(Issue issue)
        {
            if (IsDupliclate(issue.Title))
            {
                return "There is already an issue with this title.";
            }
            if(issue.Title.Trim() == "")
            {
                return EMPTY_TITLE_ERROR;
            }
            if(issue.Discoverer.Trim() == "")
            {
                return EMPTY_DISCOVERER_ERROR;
            }
            // Must also add an if statement for an empty discovery date

            int index = 0;
            foreach (Issue i in _Issues)
            {
                if(i.Id == issue.Id)
                {
                    _Issues[index] = issue;
                    return NO_ERROR;
                }
                index++;
            }
            return "No issue found.";

        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int total = 0;
            foreach(Issue issue in _Issues)
            {
                if(issue.ProjectId == ProjectId)
                {
                    total++;
                }
            }
            return total;
        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {
            //var groupedByMonthIssues = _Issues.GroupBy(u => u.DiscoveryDate).Select(grp => grp.ToList()).ToList();
            //var groupedByMonthIssues = _Issues.GroupBy(p => p.DiscoveryDate).Select(group => new { metric = group.Key, Count = group.Count() }).OrderBy(x => x.metric).ToList();
            //return groupedByMonthIssues;
            throw new System.NotImplementedException();
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            throw new System.NotImplementedException();
        }

        public Issue GetIssueById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}