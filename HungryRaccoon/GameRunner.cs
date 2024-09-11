namespace HungryRaccoon;

using System;

public class GameRunner
{
    private GameState currentState;

    public GameRunner() : this(new InitialState()) {}    
    public GameRunner(GameState initialState)
    {
        currentState = initialState;
    }

    public void RunGame() 
    {
        Console.Write(currentState.Description());
        while (currentState.GetType() != typeof(GameOverState))
        {
            currentState = currentState.ProcessAction();
            Console.Write(currentState.Description());
        }
    }

    public GameState CurrentState() 
    {
        return currentState;
    }
}