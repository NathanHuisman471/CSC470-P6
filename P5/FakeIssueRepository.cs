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
        private string ValidateIssue(Issue issue)
        {

        }
        private bool IsDupliclate(string title)
        {

        }
    }
}