namespace HungryRaccoon;

public class InitialState : GameState
{
    private String description = String.Join(
            Environment.NewLine,
            "You are a hungry raccoon. ",
            "You are standing by the side of a road next to the woods. ",
            "On the other side of the road are some houses. ", 
            "You can smell the garbage cans behind the houses.",
            "The scent is intoxicating.");

    private List<Action> actions = new List<Action>() {
        new AssessAction()
    };        

    public override String Description()
    {   
        return description;
    }

    public override List<Action> Actions() {
        return actions;
    }
}