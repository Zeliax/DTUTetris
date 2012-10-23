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
        private bool isActive = true;
        public bool IsActive { get { return isActive; } set { isActive = value; NotifyPropertyChanged("Active"); } } 
        private int x;
        public int X { get { return x; } set { x = value; NotifyPropertyChanged("X"); NotifyPropertyChanged("CanvasCenterX"); } }
        private int y;
        public int Y { get { return y; } set { y = value; NotifyPropertyChanged("Y"); NotifyPropertyChanged("CanvasCenterY"); } }
        private int width;
        public int Width { get { return width; } set { width = value; NotifyPropertyChanged("Width"); NotifyPropertyChanged("CenterX"); NotifyPropertyChanged("CanvasCenterX"); } }
        private int height;
        public int Height { get { return height; } set { height = value; NotifyPropertyChanged("Height"); NotifyPropertyChanged("CenterY"); NotifyPropertyChanged("CanvasCenterY"); } }
        
        public int CanvasCenterX { get { return X + Width / 2; } set { X = value - Width / 2; NotifyPropertyChanged("X"); } }
        public int CanvasCenterY { get { return Y + Height / 2; } set { Y = value - Height / 2; NotifyPropertyChanged("Y"); } }
        public int CenterX { get { return Width / 2; } }
        public int CenterY { get { return Height / 2; } }
 
        public Brick(int x, int y)
        {

            X = x;
            Y = y;
            Width = Height = 35;
        }

        public void MoveXRight()
        {
            X += 35;
        }
        public void MoveXLeft()
        {
            X -= 35;
        }
        public void MoveYDown()
        {
            Y += 35;
            if (Y >= 35*17)
            {
                isActive = false;
            }
        }

        
    }
}
