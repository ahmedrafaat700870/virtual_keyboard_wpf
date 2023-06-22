using System;
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

namespace keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private KeyBoard keyboard = null!;

        public MainWindow()
        {
            InitializeComponent();
            keyboard = new KeyBoard();
            keyboard.Init();
            this.mainKeyboard.Content = keyboard.Content;
        }
    }
}
