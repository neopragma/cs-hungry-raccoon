namespace HungryRaccoon;

public abstract class Action
{
    public virtual String Description()
    {
        return "No description";
    }
    public virtual List<Outcome> Outcomes()
    {
        return new List<Outcome>();
    }

 }