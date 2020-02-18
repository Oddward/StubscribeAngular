namespace StubscribeAngular.API.Models
{
    public class Member
    {
        public int id { get; set; }
        public string name { get; set; }
        // public string sub { get; set; }
        public int balance { get; set; }
        public string colour { get; set; }

        public int SubscriptionId { get; set; }
        public Subscription Subscription { get; set; }
    }
}