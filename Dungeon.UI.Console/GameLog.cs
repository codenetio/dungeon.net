using System.Collections.Generic;
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

        private List<string> _gameText;

        #endregion

        public GameLog(int x, int y, int textAreaWidth, int textAreaHeight)
        {
            _x = x;
            _y = y;
            _textAreaWidth = textAreaWidth;
            _textAreaHeight = textAreaHeight;

            _gameText = new List<string>();
        }

        public void Write(string text)
        {
            _gameText.Add(text);
            Render();
        }

        public void WriteToBuffer(string text)
        {
            _gameText.Add(text);
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
                    var text = _gameText[index].PadRight(_textAreaWidth, ' ');
                    System.Console.Write(text);
                }
                else
                {
                    var text = string.Empty;
                    for (var j = 0; j < _textAreaWidth; j++)
                    {
                        text += " ";
                    }
                    System.Console.Write(text);
                }
                index++;
            }
        }
    }
}
