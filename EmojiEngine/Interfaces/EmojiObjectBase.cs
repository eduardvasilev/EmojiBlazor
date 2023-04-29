namespace EmojiEngine.Interfaces;

public class EmojiObjectBase : IEmojiObject
{
    public EmojiObjectBase(int x, int y, string emoji)
    {
        X = x;
        InitialX = x;
        Y = y;
        Emoji = emoji;
        InitialY = y;
    }
    public virtual string Emoji { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public int InitialX { get; set; }
    public int InitialY { get; set; }
}