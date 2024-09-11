namespace HungryRaccoon;

public class AssessAction : Action 
{
    private List<Outcome> outcomes = new List<Outcome>() {
        new KilledByDogOutcome()
    };    
    public override String Description() {
        return "Stay where you are and assess the situation.";
    }    

    public override List<Outcome> Outcomes() {
        return outcomes;
    }

}