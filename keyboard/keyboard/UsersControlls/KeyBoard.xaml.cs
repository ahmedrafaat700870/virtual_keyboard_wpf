using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace keyboard.UsersControlls
{
    /// <summary>
    /// Interaction logic for KeyBoard.xaml
    /// </summary>
    public partial class KeyBoard : UserControl
    {
        private ISenderKey senderkey;

        private Dictionary<string  ,Key> Keys = null!;
        public KeyBoard()
        {
            InitializeComponent();
            senderkey = new SendKey();
            InitKyes initKyes = new InitKyes(this.senderkey);
        }

        

        public void IntitializeGrid_0()
        {
            this.grid_0.Children.Clear();

            addChilderToUniGrid(this.grid_0 ,Keys["q"]);
            addChilderToUniGrid(this.grid_0  ,Keys["w"]);
            addChilderToUniGrid(this.grid_0 ,Keys["e"]);
            addChilderToUniGrid(this.grid_0, Keys["r"]);
            addChilderToUniGrid(this.grid_0, Keys["t"]);
            addChilderToUniGrid(this.grid_0, Keys["y"]);
            addChilderToUniGrid(this.grid_0, Keys["u"]);
            addChilderToUniGrid(this.grid_0, Keys["i"]);
            addChilderToUniGrid(this.grid_0, Keys["o"]);
            addChilderToUniGrid(this.grid_0, Keys["p"]);
            addChilderToUniGrid(this.grid_0, Keys["{"]);
            addChilderToUniGrid(this.grid_0, Keys["}"]);
            addChilderToUniGrid(this.grid_0, Keys["|"]);
            addChilderToUniGrid(this.grid_0, Keys["back"]);
            addChilderToUniGrid(this.grid_0, Keys["7"]);
            addChilderToUniGrid(this.grid_0, Keys["7"]);
            addChilderToUniGrid(this.grid_0, Keys["8"]);
            addChilderToUniGrid(this.grid_0, Keys["9"]);

        }
       
        public void addChilderToUniGrid(UniformGrid grid ,  Key? key)
        {
            if (key is null)
                return;
            grid.Children.Add(key);
        }

        public void IntitializeGrid_1()
        {
            
            addChilderToUniGrid(this.grid_1, Keys["capsLoock"]);
            addChilderToUniGrid(this.grid_1, Keys["a"]);
            addChilderToUniGrid(this.grid_1, Keys["s"]);
            addChilderToUniGrid(this.grid_1, Keys["d"]);
            addChilderToUniGrid(this.grid_1, Keys["f"]);
            addChilderToUniGrid(this.grid_1, Keys["g"]);
            addChilderToUniGrid(this.grid_1, Keys["h"]);
            addChilderToUniGrid(this.grid_1, Keys["j"]);
            addChilderToUniGrid(this.grid_1, Keys["k"]);
            addChilderToUniGrid(this.grid_1, Keys["l"]);
            addChilderToUniGrid(this.grid_1, Keys[";"]);
            addChilderToUniGrid(this.grid_1, Keys["'"]);
            addChilderToUniGrid(this.grid_1, Keys["enter"]);
            addChilderToUniGrid(this.grid_1, Keys["4"]);
            addChilderToUniGrid(this.grid_1, Keys["5"]);
            addChilderToUniGrid(this.grid_1, Keys["6"]);
        }

        

        public void IntitializeGrid_2()
        {

        }

        public void IntitializeGrid_3()
        {

        }
    }
}
