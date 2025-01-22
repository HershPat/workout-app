namespace WorkoutAppWebApi.Models
{
    public class workouts
    {
        public int workout_id { get; set; }
        public int user_id { get; set; }
        public String workout_name { get; set; }
        public int workout_date { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
