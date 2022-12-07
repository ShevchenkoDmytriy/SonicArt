using System.Windows.Media;

namespace Animation1
{
    public class GameElement
    {
        public TranslateTransform RenderTransform { get; internal set; }
        public int PositionX { get; internal set; }
    }
}