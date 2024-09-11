namespace HungryRaccoon;

public class KilledByDogOutcome : Outcome
{
    public double Probability()
    {
        return 100.0;
    }
    public String Description()
    {
        return "You are killed by a dog.";
    }
    public GameState NextState() 
    {
        return new GameOverState();
    }
}