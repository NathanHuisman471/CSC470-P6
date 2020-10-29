namespace P5
{
    public class Issue
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Title { get; set; }
        //public struct DateTime DiscoveryDate { get; set; } // Not sure how to implement this correctly according to UML
        public string Discoverer { get; set; }
        public string InitialDescription { get; set; }
        public string Component { get; set; }
        public int IssueStatusId { get; set; }
    }
}
