using EmojiEngine.Interfaces;
using EmojiEngine.Model;

namespace EmojiBlazor.Model;

public class DevilEnemy : MovableObject, IEmojiObject
{
    private readonly Func<int> _borderLimitFunc;

    public DevilEnemy(int x, int y, Func<int> borderLimitFunc) : base(x, y)
    {
        _borderLimitFunc = borderLimitFunc;
        X = 3;
        Y = 3;
    }

    private void Down()
    {
        if (X < _borderLimitFunc())
        {
            X++;
        }
    }

    private void Up()
    {
        if (X > 0)
        {
            X--;
        }
    }

    private void Left()
    {
        if (Y > 0)
        {
            Y--;
        }
    }

    private void Right()
    {
        if (Y < _borderLimitFunc())
        {
            Y++;
        }
    }


    public void MoveEnemy()
    {
        Random random = new Random();
        int move = random.Next(0, 100);

        if (move < 25)
        {
            Right();
        }
        else if (move < 50)
        {
            Left();
        }
        else if (move < 75)
        {
            Down();
        }
        else
        {
            Up();
        }
    }

    public override string Emoji { get => "😈"; }
}