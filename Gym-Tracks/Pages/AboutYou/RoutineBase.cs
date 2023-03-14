using Gym_Tracks.Controllers.ExerciseComponents;
using Microsoft.AspNetCore.Components;
using Execise.Models;

namespace Gym_Tracks.Pages.AboutYou
{
    public class RoutineBase : ComponentBase
    {

        public IEnumerable<ExerciseModel> Workouts { get; set; }

        public IEnumerable<RoutineModel> Routines { get; set; }

        protected override Task OnInitializedAsync()
        {
            LoadWorkouts();
            LoadRoutines();
            return base.OnInitializedAsync();
        }

        private void LoadWorkouts()
        {
            ExerciseModel e1 = new ExerciseModel
            {
                Name = "Bench",
                Sets = 10,
                Reps = 10,
                Weight = 120

            };
            ExerciseModel e2 = new ExerciseModel
            {
                Name = "Deadlift",
                Sets = 3,
                Reps = 10,
                Weight = 200

            };
            ExerciseModel e3 = new ExerciseModel
            {
                Name = "Squat",
                Sets = 3,
                Reps = 8,
                Weight = 300

            };
            ExerciseModel e4 = new ExerciseModel
            {
                Name = "Dumbbell Curl",
                Sets = 3,
                Reps = 10,
                Weight = 30
            };

            Workouts = new List<ExerciseModel> { e1, e2, e3, e4 };
        }
        private void LoadRoutines()
        {
            RoutineModel r1 = new RoutineModel
            {
                Name = "Push-Day"
            };
            RoutineModel r2 = new RoutineModel
            {
                Name = "Pull-Day"
            };
            Routines = new List<RoutineModel> { r1, r2 };


        }
    }
}

