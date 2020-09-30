namespace MessagingService.Controllers
{
    public class PatchRequest
    {
        public const string MarkAsRead = "MarkAsRead";

        public string Operation { get; set; }
        public string Id { get; set; }
    }
}
