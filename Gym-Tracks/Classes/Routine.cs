public class Routine {

    string name;
    public List<Exercise> exercises;

    public Routine(string name)
    {
        this.name = name;
        this.exercises = new List<Exercise>();
    }
    public void addExercise(Exercise exercise)
    {
        exercises.Add(exercise);
    }
    public string getRoutineName() { return this.name; } 

}
