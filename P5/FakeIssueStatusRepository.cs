using System.Collections.Generic;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();

        public void Add(int Id, string value)
        {
            throw new System.NotImplementedException();
        }

        public List<IssueStatus> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public int GetIdByStatus(string value)
        {
            throw new System.NotImplementedException();
        }

        public string GetValueById(int Id)
        {
            throw new System.NotImplementedException();
        }
    }
}

