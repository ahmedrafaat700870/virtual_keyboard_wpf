using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using keyboard.UsersControlls.interfaces;
using WindowsInput.Native;

namespace keyboard.UsersControlls
{
    /// <summary>
    /// Interaction logic for Key.xaml
    /// </summary>
    public partial class Key : UserControl , IKey
    {
        private DispatcherTimer timer = null!;
        private ISenderKey SenderKey { get; set; } = null!;
        public Key()
        {
            InitializeComponent();
            this.MouseLeftButtonDown += mouseLeftButtonDown ;
        }

        private  void mouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            /*timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.1);
            timer.Tick += click_key!;
            timer.Start();*/
        }

        public void  click_key(object sender  , EventArgs e)
        { 
            /*borderMouseEnter();
            timer.Stop();
            borderMouseLeave();*/
        }

        public void clickUpperCase()
        {
            SenderKey.sendKey(this.sing.Text);
        }
        public void clickLowerCase()
        {
            SenderKey.sendKey(this.key.Text);
        }

        public void setMargin(double left , double up , double right , double dowen)
        {
            var thickness = new Thickness();
            thickness.Left = left;
            thickness.Top = up;
            thickness.Right = right;
            thickness.Left = left;
            this.Margin = thickness;
        }
        public void setISenderKey(ISenderKey senderKey)
        {
            SenderKey = senderKey;
        }
        public void setKey(string newKey)
        {
            this.key.Text = newKey;
        }
        public void setSing(string sing)
        {
            this.sing.Text = sing;
        }
        
        public void numberKey()
        {
            this.sing.Style = this.Resources["normal_sing"] as Style;
            this.key.Style = this.Resources["normal_key"] as Style;
        }
        public void keyDowenLeft()
        {
            this.sing.Style = this.Resources["normal_sing"] as Style;
            this.key.Style = this.Resources["normal_key_dowen_left"] as Style;
        }
        public void keyDowenRight()
        {
            this.sing.Style = this.Resources["normal_sing"] as Style;
            this.key.Style = this.Resources["normal_key_dowen_right"] as Style;
        }
        public void singWithKey()
        {
            this.sing.Style = this.Resources["singWithKey"] as Style;
            this.key.Style = this.Resources["singWithKey"] as Style;
        }
        public void toUpperCase()
        {
            if (string.IsNullOrEmpty(this.sing.Text))
                this.key.Text = this.key.Text.ToUpper();
            else
                convertSingWithKey();
        }
        public void toLowerCase()
        {
            if (string.IsNullOrEmpty(this.sing.Text))
                this.key.Text = this.key.Text.ToLower();
            else
                convertSingWithKey();
        }
        private void convertSingWithKey()
        {
            string temp = this.key.Text;
            this.key.Text = this.sing.Text;
            this.sing.Text = temp;
        }
        private void border_key_sing_MouseEnter(object sender, MouseEventArgs e)
        {
            borderMouseEnter();
        }
        private void border_key_sing_MouseLeave(object sender, MouseEventArgs e)
        {
            borderMouseLeave();
        }
        private Task borderMouseEnter()
        {
            border_key_sing.Style = this.Resources["borderStyleMouseEnter"] as Style;
            return null!;
        }
        private Task borderMouseLeave()
        {
            border_key_sing.Style = this.Resources["borderStyle"] as Style;
            return null!;
        }

       
    }
}
