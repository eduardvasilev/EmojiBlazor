namespace EmojiEngine.Interfaces;

public interface IActionProcessor
{
    void ProcessObjectAction(Level level, IEmojiObject emojiObject, IEmojiObject withObject);
}