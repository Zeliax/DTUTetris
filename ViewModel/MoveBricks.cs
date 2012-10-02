using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tetris.ViewModel;
using Tetris.Model;
using System.Timers;

namespace Tetris.ViewModel
{
    class MoveBricks
    {
        Brick brick;
        public MoveBricks(Brick brick)
        {
            this.brick = brick;
            Timer timer = new Timer(300);
            timer.Elapsed +=new ElapsedEventHandler(run);
            timer.Start();
        }
        public void run(object sender, ElapsedEventArgs e)
        {
            if (brick.IsActive)
            {
                brick.MoveYDown();
            }
            
        }
    }
}
