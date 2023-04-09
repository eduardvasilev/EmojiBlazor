using EmojiEngine.Interfaces;
using EmojiEngine.Model;

namespace EmojiEngine;

public class Player : MovableObject, IMovable
{
    private readonly Func<int> _borderLimitFunc;
    private string _emoji;

    public Player(string emoji, Func<int> borderLimitFunc)
    {
        _emoji = emoji;
        _borderLimitFunc = borderLimitFunc;
    }

    public void SetPosition(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void Down()
    {
        if (X < _borderLimitFunc())
        {
            X++;
        }
    }

    public void Up()
    {
        if (X > 0)
        {
            X--;
        }
    }

    public void Left()
    {
        if (Y > 0)
        {
            Y--;
        }
    }

    public void Right()
    {
        if (Y < _borderLimitFunc())
        {
            Y++;
        }
    }

    public override string Emoji => _emoji;
}