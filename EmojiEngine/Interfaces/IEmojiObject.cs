namespace EmojiEngine.Interfaces;

public interface IEmojiObject
{
    public string Emoji { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public int InitialX { get; set; }
    public int InitialY { get; set; }

    void SetInitial()
    {
        X = InitialX;
        Y = InitialY;
    } 
}