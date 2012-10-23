using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Tetris.Model
{
    abstract class BaseBlock
    {
        public Brick[] Block = new Brick[4];
        public void MoveRight();
        public void MoveLeft();
        public void RotateRight();
        public void RotateLeft();
        public void DropDown();
        public void StoreBlock();
    
    }
}
