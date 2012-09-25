using Tetris.Model;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Tetris.ViewModel
{
    class MainViewModel
    {
        public ObservableCollection<Brick> Bricks { get; set; }
        public MainViewModel()
        {


            Bricks = new ObservableCollection<Brick>();
            Brick brick1 = new Brick();
            brick1.X = 0;
            brick1.Y = 0;

            //Brick brick2 = new Brick();
            //brick2.X = 100;
            //brick2.Y = -550;

            Bricks.Add(brick1);
            //  Bricks.Add(brick2);
            MoveBricks BrickMover = new MoveBricks(brick1);
        }
    }

}
