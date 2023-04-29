using EmojiBlazor.Model;
using EmojiBlazor.Model.Levels;
using EmojiEngine;
using EmojiEngine.Interfaces;

namespace EmojiBlazor.GameLogic;

public class ActionProcessor : IActionProcessor
{
    public void ProcessObjectAction(Level level, IEmojiObject emojiObject, IEmojiObject withObject)
    {
        switch (emojiObject)
        {
            case Player when withObject is DevilEnemy:
            case DevilEnemy when withObject is Player:
                ((level as CandyLevel)!).ReloadLevel();
                break;
            case Player when withObject is Candy:
                ((level as CandyLevel)!).ReplaceCandy(withObject);
                break;

        }
    }
}