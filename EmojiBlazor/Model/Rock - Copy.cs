using EmojiEngine.Interfaces;

namespace EmojiBlazor.Model;

public class Rock : EmojiObjectBase, ISolid
{
    public Rock(int x, int y) : base(x, y, "🗿")
    {
    }
}