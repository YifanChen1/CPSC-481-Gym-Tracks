


public interface IAppService
{
    void Print();
    void AddExercise(string exerciseName);
    void AddRoutine(string routineName);
    void RemoveExercise(string exerciseName);
    void RemoveRoutine(string routineName);
    List<Exercise> GetExercises();
    List<Routine> GetRoutines();
    bool HasExercise(string exerciseName);
    bool HasRoutine(string routineName);

    void addRepData(string exerciseName, int reps, int setNum);
    void addWeightData(string exerciseName, int weight, int setNum);
    int GetExerciseIndex(string exerciseName);
    Exercise GetExercise(string exerciseName);
    void CompleteSet(string exerciseName, int default_reps, int default_weight);




    // void AddSet(string exerciseName, int reps, int weight);
}

public class AppService : IAppService
{

    
    // Exercise test = new Exercise("Bench Press");
    public List<Exercise> Exercises = new List<Exercise>();

    // Routines go here.
    public List<Routine> Routines= new List<Routine>();


    public void addRepData(string exerciseName, int reps, int setNum)
    {
        Console.WriteLine("AddRepData!");
        int index = Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
        Exercises[index].updateSetReps(reps, setNum);
        Console.WriteLine("AddRepData!");
    }

    public void addWeightData(string exerciseName, int weight, int setNum)
    {
        Console.WriteLine("AddWeiughtData!");
        int index = Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
        Exercises[index].updateSetWeight(weight, setNum);
        Console.WriteLine("AddWeiughtData!");
    }

    // public void UpdateSet(string exerciseName, int reps, int weight)
    // {
    //     int index = Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
    //     Exercises[index];
    // }
    public bool HasExercise(string exerciseName)
    {
        return Exercises.Any(e => e.getExerciseName().Equals(exerciseName));
    }

    public bool HasRoutine(string routineName)
    {
        return Routines.Any(e => e.getRoutineName().Equals(routineName));
    }

    public void AddExercise(string exerciseName)
    {
        Exercise newExercise = new Exercise(exerciseName);
        newExercise.addSet(new Set());
        Exercises.Add(newExercise);
    }
    public void AddRoutine(string routineName)
    {
        Routine newRoutine = new Routine(routineName);
        newRoutine.addExercise(new Exercise("temp"));
        Routines.Add(newRoutine);
    }

    public void RemoveExercise(string exerciseName)
    {
        Console.WriteLine("Remove Exercise");           
        int index = Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
        Exercises.RemoveAt(index);
    }
    public void RemoveRoutine(string routineName)
    {
        int index = Routines.FindIndex(routine => routine.getRoutineName().Equals(routineName));
        Routines.RemoveAt(index);
    }
    public List<Exercise> GetExercises()
    {
        return Exercises;
    }
    public List<Routine> GetRoutines() {
        return Routines;
    }
    public int GetExerciseIndex(string exerciseName)
    {
        return Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
    }

    public Exercise GetExercise(string exerciseName)
    {
        int index = Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
        return Exercises[index];
    }

    public void CompleteSet(string exerciseName, int default_reps, int default_weight)
    {
        int index = Exercises.FindIndex(exercise => exercise.getExerciseName().Equals(exerciseName));
        Exercises[index].completeSet(default_reps, default_weight);
    }

    public void Print()
    {
        Console.WriteLine("Print");
    }

 
}
