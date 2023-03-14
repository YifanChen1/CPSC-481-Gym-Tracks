public class Set
{
    public int reps;
    public int weight;
    private bool complete; 

    public Set(int reps, int weight){
        this.reps = reps;
        this.weight = weight;
    }

    public Set(){
        this.reps = 0;
        this.weight = 0;
    }

    public void setReps(int val){
        this.reps = val;
    }

    public void setWeight(int val){
        this.weight = val;
    } 

    public int getWeight(){
        return this.weight;
    }

    public int getReps(){
        return this.reps;
    }

    public void completeSet(){
        this.complete = true;
    }

    public void completeSet(int reps, int weight){
        if (this.reps == 0){
            this.reps = reps;
        }

        if (this.weight == 0) {
            this.weight = weight;
        }
        this.complete = true;
    }

    public bool isComplete(){
        return complete;
    }


}