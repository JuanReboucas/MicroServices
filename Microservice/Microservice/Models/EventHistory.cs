namespace Microservice.Models
{
    public class EventHistory
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SubscriptionId { get; set; }

        public Subscription Subscription { get; set; }
    }
}
