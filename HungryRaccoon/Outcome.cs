namespace HungryRaccoon;

public interface Outcome
{
    double Probability();
    String Description();
    GameState NextState();
}