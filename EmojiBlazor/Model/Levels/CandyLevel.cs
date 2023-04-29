using EmojiEngine;
using EmojiEngine.Interfaces;

namespace EmojiBlazor.Model.Levels;

public class CandyLevel : Level
{
    public CandyLevel(IActionProcessor actionProcessor, int fieldSize, IEmojiObject placeholder) : base(actionProcessor, fieldSize, placeholder)
    {
        
    }

    public int Score { get; set; }
    public int RecordScore { get; set; }

    public override void ReloadLevel()
    {
        base.ReloadLevel();
        if (RecordScore <= Score)
        {
            RecordScore = Score;
        }
        Score = 0;
    }

    public void ReplaceCandy(IEmojiObject candy)
    {
        Score++;
        var x = new Random().Next(0, FieldSize);
        var y = new Random().Next(0, FieldSize);

        if (_positions[x, y] is ISolid)
        {
            ReplaceCandy(candy);
        }
        else
        {
            candy.X = x;
            candy.Y = y;
        }
    }
}