namespace WorkoutAppWebApi.Models
{
    public class excercises
    {
        public int excercise_id { get; set; }
        public String excercise_name { get; set; }
        public String category { get; set; }
        public String difficulty { get; set; }
        public String muscle_group { get; set; }
        public String exercise_description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
