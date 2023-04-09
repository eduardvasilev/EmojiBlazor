namespace EmojiEngine.Interfaces;

public interface IEmojiObject
{
    public string Emoji { get; }

    public int X { get; set; }
    public int Y { get; set; }
}