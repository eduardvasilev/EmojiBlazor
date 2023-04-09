using System.Text;
using EmojiEngine.Interfaces;
using EmojiEngine.Model;

namespace EmojiEngine;

public class Level
{
    private readonly IActionProcessor _actionProcessor;
    private readonly IEmojiObject _placeholder;
    private StringBuilder _stringBuilder = new();
    private IEmojiObject[,] _positions;

    public int FieldSize { get; }

    public Level(IActionProcessor actionProcessor, int fieldSize, IEmojiObject placeholder)
    {
        _actionProcessor = actionProcessor;
        _placeholder = placeholder;
        FieldSize = fieldSize;
        _positions = new IEmojiObject[fieldSize, fieldSize];
    }

    public List<IEmojiObject> EmojiObjects { get; set; } = new();

    public virtual string DoFrame()
    {
        _stringBuilder.Clear();

        for (int x = 0; x < FieldSize; x++)
        {
            for (int y = 0; y < FieldSize; y++)
            {
                IEmojiObject? emoji = EmojiObjects.FirstOrDefault(emoji => emoji.X == x && emoji.Y == y);

                if (emoji == null)
                {
                    emoji = _placeholder;
                }

                if (emoji is IMovable movable)
                {
                    if (_positions[x, y] is not ISolid)
                    {
                        _actionProcessor.ProcessObjectAction(this, emoji, _positions[x, y]);
                        _positions[x, y] = emoji;
                    }
                    else
                    {
                        if (movable.LastMovement == Movement.Horizontal)
                        {
                            emoji.X = movable.PrevX;
                        }
                        else
                        {
                            emoji.Y = movable.PrevY;
                        }

                        _positions[emoji.X, emoji.Y] = emoji;
                    }
                }
                else
                {
                    _positions[x, y] = emoji;
                }
            }

        }

        for (int x = 0; x < FieldSize; x++)
        {
            for (int y = 0; y < FieldSize; y++)
            {
                _stringBuilder.Append(_positions[x, y].Emoji);
            }

            _stringBuilder.Append(Environment.NewLine);
        }

        return _stringBuilder.ToString();
    }

}