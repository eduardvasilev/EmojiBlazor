using System.Numerics;
using System;
using System.Text;

namespace EmojiEngine;

public class Level
{
    private readonly IEmojiObject _placeholder;
    private StringBuilder _stringBuilder = new StringBuilder();
    private string[,] _positions;

    public int FieldSize { get; }

    public Level(int fieldSize, IEmojiObject placeholder)
    {
        _placeholder = placeholder;
        FieldSize = fieldSize;
        _positions = new string[fieldSize, fieldSize];
    }

    public List<IEmojiObject> EmojiObjects { get; set; } = new();

    public string DoFrame()
    {
        _stringBuilder.Clear();

        for (int x = 0; x < FieldSize; x++)
        {
            for (int y = 0; y < FieldSize; y++)
            {
                IEmojiObject? emoji = EmojiObjects.FirstOrDefault(emoji => emoji.X == x && emoji.Y == y);

                if (emoji != null)
                {
                    _positions[x, y] = emoji.Emoji;
                }
                else
                {
                    _positions[x, y] = _placeholder.Emoji;
                }

                _stringBuilder.Append(_positions[x, y]);
            }

            _stringBuilder.Append(Environment.NewLine);
        }

        return _stringBuilder.ToString();
    }

}