using Xunit;
using System;

namespace HungryRaccoon.Tests;

public class GameStateChanges
{
    [Fact]
    public void Game_starts_in_InitialState_by_default()
    {
        GameRunner gameRunner = new GameRunner();
        Assert.Equal(typeof(InitialState), gameRunner.CurrentState().GetType());
    }
}