namespace WorkoutAppWebApi.Models
{
    public class workout_exercises
    {
        public int workout_exercise_id { get; set; }
        public int workout_id { get; set; }
        public int exercise_id { get; set; }
        public int reps { get; set; }
        public int sets { get; set; }
        public int weight { get; set; }
        public int duration { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
    }
}
