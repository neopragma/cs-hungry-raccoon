namespace HungryRaccoon;

public class GameOverState : GameState
{
    private String description = String.Join(
            Environment.NewLine,
            "Game Over. ",
            "Thanks for playing!",
            "");

    private List<Action> actions = new List<Action>();

    public override String Description()
    {   
        return description;
    }

    public override List<Action> Actions() {
        return actions;
    }
}