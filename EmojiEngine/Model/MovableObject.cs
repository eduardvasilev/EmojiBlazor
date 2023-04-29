using EmojiEngine.Interfaces;

namespace EmojiEngine.Model;

public abstract class MovableObject : IMovable, IEmojiObject
{
    private int _x;
    private int _y;

    public MovableObject(int x, int y)
    {
        X = x;
        Y = y;
        InitialX = x;
        InitialY = y;
    }

    public abstract string Emoji { get; }

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

    public int InitialX { get; set; }
    public int InitialY { get; set; }

    public int PrevX { get; set; }

    public int PrevY { get; set; }
    public Movement LastMovement { get; set; }
}