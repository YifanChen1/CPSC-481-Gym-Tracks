
public class Exercise{

    

    string name;
    public List<Set> sets;


    public Exercise(string name){
        this.name = name;
        this.sets = new List<Set>();
    }

    public void addSet (Set set){
        sets.Add(set);
    }

    public void updateSetReps(int reps, int index){
        if (sets.Count >= index){
            this.sets[index].setReps(reps);
        }
        else {
            Set newSet = new Set(reps, 0);
            sets.Add(newSet);
        }
    }

    public void updateSetWeight(int weight, int index){
        if (sets.Count >= index){
            this.sets[index].setWeight(weight);
        }
        else {
            Set newSet = new Set(0, weight);
            sets.Add(newSet);
        }
    }
    public void completeSet(int default_reps, int default_weight){
        for (int i = 0; i < sets.Count; i++){
            if(!sets[i].isComplete()){      // if not complete
                sets[i].completeSet(default_reps, default_weight);
                break;
            }
        }
        sets.Add(new Set());
    }

    public string getExerciseName(){
        return this.name;
    }

    public List<Set> getSets(){
        return this.sets;
    }

    public int getReps(int index){
        return this.sets[index].getReps();
    }

    public int getWeight(int index){
        return this.sets[index].getWeight();
    }



}