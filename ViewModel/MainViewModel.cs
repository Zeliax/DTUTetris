using Tetris.Command;
using Tetris.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System;
using System.ComponentModel;


namespace Tetris.ViewModel
{
    class MainViewModel : ViewModelBase
    {
    
        private UndoRedoController undoRedoController = UndoRedoController.GetInstance();
        public ObservableCollection<Brick> Bricks { get; set; }
        public ICommand UndoCommand { get; private set; }
        public ICommand RedoCommand { get; private set; }
        public ICommand MoveBrickCommand { get; private set; }

        
        public MainViewModel()
        {
            MoveBrickCommand = new RelayCommand<KeyEventArgs>(Move);
            Bricks = new ObservableCollection<Brick>() ;
            Brick brick1 = new Brick(200,200);
            Bricks.Add(brick1);
            MoveBricks BrickMover = new MoveBricks(brick1);
            UndoCommand = new RelayCommand(undoRedoController.Undo, undoRedoController.CanUndo);
            RedoCommand = new RelayCommand(undoRedoController.Redo, undoRedoController.CanRedo);
        }
            public void Move(KeyEventArgs e)
            {
               
               if(e.Key == Key.Left) 
               {
                   this.Bricks[0].MoveXLeft();
               }
               if (e.Key == Key.Right)
               {
                   this.Bricks[0].MoveXRight();
               }

            }
    
            
        }
    }

