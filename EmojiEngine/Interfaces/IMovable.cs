using EmojiEngine.Model;

namespace EmojiEngine.Interfaces;

public interface IMovable
{
    public int PrevX { get; set; }
    public int PrevY { get; set; }
    public Movement LastMovement { get; set; }
}