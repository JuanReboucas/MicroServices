namespace Microservice.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int StatusId { get; set; }

        public User User { get; set; }
        public Status Status { get; set; }
    }
}
