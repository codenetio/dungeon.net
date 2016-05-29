using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dungeon.UI.Console
{
    public class GameLog
    {
        #region Fields
        private int _x;
        private int _y;
        private int _textAreaWidth;
        private int _textAreaHeight;

        private List<TextLine> _gameText;

        #endregion

        public GameLog(int x, int y, int textAreaWidth, int textAreaHeight)
        {
            _x = x;
            _y = y;
            _textAreaWidth = textAreaWidth;
            _textAreaHeight = textAreaHeight;

            _gameText = new List<TextLine>();
        }

        public void Write(string text, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            WriteToBuffer(text, backgroundColor, foregroundColor);
            Render();
        }

        public void Write(string text)
        {
            WriteToBuffer(text);
            Render();
        }

        public void WriteToBuffer(string text)
        {
            WriteToBuffer(text, ConsoleColor.Black, ConsoleColor.White);
        }

        public void WriteToBuffer(string text, ConsoleColor backgroundColor, ConsoleColor foregroundColor)
        {
            if (text.Length < _textAreaWidth)
            {
                _gameText.Add(new TextLine
                {
                    BackgroundColor = backgroundColor,
                    ForegroundColor = foregroundColor,
                    Text = text
                });
                return;
            }

            // break up the lines
            var words = text.Split(' ');
            var line = string.Empty;
            foreach (var word in words)
            {
                if (line.Length + word.Length + 1 > _textAreaWidth)
                {
                    _gameText.Add(new TextLine
                    {
                        BackgroundColor = backgroundColor,
                        ForegroundColor = foregroundColor,
                        Text = line.PadRight(_textAreaWidth, ' ')
                    });
                    line = word + ' ';
                }
                else
                {
                    line += word + ' ';
                }
            }

            _gameText.Add(new TextLine
            {
                BackgroundColor = backgroundColor,
                ForegroundColor = foregroundColor,
                Text = line.PadRight(_textAreaWidth, ' ')
            });
        }

        public void Render()
        {
            System.Console.SetCursorPosition(_x, _y);

            // where do we start copying lines from the list to the output?
            var index = 0;
            if (_gameText?.Count > _textAreaHeight)
            {
                index = (_gameText.Count - 1) - _textAreaHeight;
            }

            for (var i = 1; i < _textAreaHeight; i++)
            {
                System.Console.SetCursorPosition(1, i);

                if (index < _gameText?.Count)
                {
                    // write out text if we have it
                    System.Console.ForegroundColor = _gameText[index].ForegroundColor;
                    System.Console.BackgroundColor = _gameText[index].BackgroundColor;
                    System.Console.Write(_gameText[index].Text);
                }
                else
                {
                    // write out spaces if there aren't enough lines to fill the whole text area
                    // this ensures that the whole text area is "refreshed".
                    var text = string.Empty;
                    for (var j = 0; j < _textAreaWidth; j++)
                    {
                        text += " ";
                    }
                    System.Console.Write(text);
                }
                index++;
            }

            // reset console colors.
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
