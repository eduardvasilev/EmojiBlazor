using EmojiEngine.Interfaces;

namespace EmojiBlazor.Model;

public class Tree : IEmojiObject
{
    public string Emoji => "🌳";
    public int X { get; set; }
    public int Y { get; set; }
    public int InitialX { get; set; }
    public int InitialY { get; set; }
}