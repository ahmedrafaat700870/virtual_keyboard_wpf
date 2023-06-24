﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsInput.Native;
using WindowsInput;
using System.Runtime.InteropServices;
using keyboard.UsersControlls;
using System.Windows.Input;

namespace keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private KeyBoard keyboard = null!;

        private bool isDragging = false;

        private Point dragStartPosition;

        private readonly double screenWidth = System.Windows.SystemParameters.PrimaryScreenWidth;
       
        public MainWindow()
        {
            InitializeComponent();
            int width = Convert.ToInt32( screenWidth * 0.75);
            this.Width = width;
            keyboard = new KeyBoard();
            keyboard.setFocusEl(El);
            keyboard.Init();
            this.mainKeyboard.Content = keyboard.Content;
        }

        private void exit_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Hide();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            isDragging = true;
            dragStartPosition = e.GetPosition(this);
            CaptureMouse();
        }

        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            isDragging = false;
            ReleaseMouseCapture();
        }
        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentPosition = e.GetPosition(this);
                double deltaX = currentPosition.X - dragStartPosition.X;
                double deltaY = currentPosition.Y - dragStartPosition.Y;

                Left += deltaX;
                Top += deltaY;
            }
        }
    }
}
