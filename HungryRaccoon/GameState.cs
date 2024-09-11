namespace HungryRaccoon;

public abstract class GameState
{
    public virtual String Description()
    {
        return "No description";
    }
    public virtual List<Action> Actions()
    {
        return new List<Action>();
    }
    private String choice;

    public GameState ProcessAction() {
        PromptForChoice();
        choice = Console.ReadLine();
        if (choice.ToUpper()[0] == 'Q') {
            return new GameOverState();
        }
        Action selectedAction;
        int choiceNumber;
        if (Int32.TryParse(choice, out choiceNumber))
        {
            if (choiceNumber > 0 && choiceNumber <= Actions().Count())
            {
                selectedAction = Actions()[choiceNumber-1];
                Outcome outcome = selectedAction.Outcomes()[0];
                Console.WriteLine(outcome.Description());
                return outcome.NextState();
            }
        }
        else
        {
            Console.WriteLine($"Please enter a number from 1 to {Actions().Count()} or Q to quit.");
        }
        return this;
    }

    public void PromptForChoice() {
        if (Actions().Count() < 1)
        {
            return;
        }
        Console.WriteLine("");
        Console.WriteLine("You:");
        int choiceNumber = 1;
        foreach (Action action in Actions())
        {
            Console.Write($"({choiceNumber}) ");
            Console.WriteLine(action.Description());
        }
        Console.WriteLine("(Q or q to end the game)");
        Console.Write("==> ");
    }
}