using EmojiEngine.Interfaces;

namespace EmojiBlazor.Model;

public class Rock : IEmojiObject, ISolid
{
    public string Emoji => "🗿";
    public int X { get; set; }
    public int Y { get; set; }
}