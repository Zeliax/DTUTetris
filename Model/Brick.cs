using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris.Model
{
    public class Brick : NotifyBase
    {
        
        private int x;
        public int X { get { return x; } set { x = value; NotifyPropertyChanged("X"); NotifyPropertyChanged("CanvasCenterX"); } }
        private int y;
        public int Y { get { return y; } set { y = value; NotifyPropertyChanged("Y"); NotifyPropertyChanged("CanvasCenterY"); } }
        private int width;
        public int Width { get { return width; } set { width = value; NotifyPropertyChanged("Width"); NotifyPropertyChanged("CenterX"); NotifyPropertyChanged("CanvasCenterX"); } }
        private int height;
        public int Height { get { return height; } set { height = value; NotifyPropertyChanged("Height"); NotifyPropertyChanged("CenterY"); NotifyPropertyChanged("CanvasCenterY"); } }
        
 
        public Brick()
        {

            X = Y = 200;
            Width = Height = 100;
        }

        public void MoveXRight()
        {
            X++;
        }
        public void MoveXLeft()
        {
            X--;
        }
        public void MoveYDown()
        {
            Y++;
        }

        
    }
}
