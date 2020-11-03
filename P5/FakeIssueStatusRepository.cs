using System.Collections.Generic;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            _IssueStatuses = new List<IssueStatus>();
            _IssueStatuses.Add(new IssueStatus
            { Id = 1, Value = "Open" });
            _IssueStatuses.Add(new IssueStatus
            { Id = 2, Value = "Assigned" });
            _IssueStatuses.Add(new IssueStatus
            { Id = 3, Value = "Fixed" });
            _IssueStatuses.Add(new IssueStatus
            { Id = 4, Value = "Closed - Won't Fix" });
            _IssueStatuses.Add(new IssueStatus
            { Id = 5, Value = "Closed - Fixed" });
            _IssueStatuses.Add(new IssueStatus
            { Id = 6, Value = "Closed - by design" });
        }

        public void Add(int Id, string value)
        {
            throw new System.NotImplementedException();
        }

        public List<IssueStatus> GetAll()
        {
            return _IssueStatuses;
        }

        public int GetIdByStatus(string value)
        {
            foreach(IssueStatus issueStatus in _IssueStatuses)
            {
                if(issueStatus.Value == value)
                {
                    return issueStatus.Id;
                }
            }
            return 0; //code should never reach this point but all paths need a return
        }

        public string GetValueById(int Id)
        {
            foreach (IssueStatus issueStatus in _IssueStatuses)
            {
                if (issueStatus.Id == Id)
                {
                    return issueStatus.Value;
                }
            }
            return null; //code should never reach this point but all paths need a return
        }
    }
}

