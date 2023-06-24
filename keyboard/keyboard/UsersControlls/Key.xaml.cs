using System;
using System.Collections.Generic;
using System.Linq;
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
using WindowsInput.Native;

namespace keyboard.UsersControlls
{
    /// <summary>
    /// Interaction logic for Key.xaml
    /// </summary>
    public partial class Key : UserControl
    {

        private ISenderKey SenderKey { get; set; } = null!;
        public Key()
        {
            InitializeComponent();
        }


        public void click_key()
        {
            borderMouseEnter();
            Thread.Sleep(200);
            borderMouseLeave();

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
            this.key.Text = this.key.Text.ToUpper();
        }
        public void toLowerCase()
        {
            this.key.Text = this.key.Text.ToLower();
        }

        private void border_key_sing_MouseEnter(object sender, MouseEventArgs e)
        {
            borderMouseEnter();
        }

        private void border_key_sing_MouseLeave(object sender, MouseEventArgs e)
        {
            borderMouseLeave();
        }

        private void borderMouseEnter()
        {
            border_key_sing.Style = this.Resources["borderStyleMouseEnter"] as Style;
        }
        private void borderMouseLeave()
        {
            border_key_sing.Style = this.Resources["borderStyle"] as Style;
        }

        

        private void border_key_sing_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            SenderKey.sendKey("j");
        }
    }
}
