using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace Tetris.Model
{
    class LineBlock : BaseBlock
    {
        Color LineColor = Colors.Red;
        public LineBlock()
        {
            
            for (int i = 0; i < 3; ++i)
            {
                Block[i] = new Brick(3+i, 0);
            }
        }
    }
}
