namespace StubscribeAngular.API.Models
{
    public class Subscription
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isActive { get; set; }
        public string datetime_created { get; set; }
        public string datetime_next_renewal { get; set; }
        public float price { get; set; }

        public string PlanTypeId { get; set; }
        public int UserId { get; set; }
        public System.Collections.Generic.List<Member> Members { get; set; }
    }
}