namespace WorkoutAppWebApi.Models
{
    public class Client
    {
        public int client_id { get; set; }
        public String username { get; set; }
        public String client_pass { get; set; }
        public String email { get; set; }
        public String phone_number { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
