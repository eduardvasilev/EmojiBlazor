using EmojiEngine.Interfaces;
using EmojiEngine.Model;

namespace EmojiEngine;

public class Player : IEmojiObject, IMovable
{
    private readonly Func<int> _borderLimitFunc;
    private string _emoji;
    private int _x;
    private int _y;
    private int _prevX;

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

    public string Emoji => _emoji;

    public int X
    {
        get => _x;
        set
        {
            PrevX = _x;
            LastMovement = Movement.Horizontal;
            _x = value;
        }
    }

    public int Y
    {
        get => _y;
        set
        {
            PrevY = _y;
            LastMovement = Movement.Vertical;
            _y = value;
        }
    }

    public int PrevX
    {
        get => _prevX;
        set { _prevX = value; }
    }

    public int PrevY { get; set; }
    public Movement LastMovement { get; set; }
}