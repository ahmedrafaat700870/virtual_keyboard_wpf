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

        public void Init()
        {
            Keys = new Dictionary<string, Key>();
            InitKyes initkeys = new InitKyes(senderkey);
            Keys = initkeys.getKeys();
            IntitializeGrid_0();
            IntitializeGrid_1();
            IntitializeGrid_2();
            IntitializeGrid_3();
        }
        private void IntitializeGrid_0()
        {
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
            addChilderToUniGrid(this.grid_0, Keys["8"]);
            addChilderToUniGrid(this.grid_0, Keys["9"]);

        }
        private void IntitializeGrid_1()
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
        private void IntitializeGrid_2()
        {

            addChilderToUniGrid(this.grid_2, Keys["shift"]);
            addChilderToUniGrid(this.grid_2, Keys["z"]);
            addChilderToUniGrid(this.grid_2, Keys["x"]);
            addChilderToUniGrid(this.grid_2, Keys["c"]);
            addChilderToUniGrid(this.grid_2, Keys["v"]);
            addChilderToUniGrid(this.grid_2, Keys["b"]);
            addChilderToUniGrid(this.grid_2, Keys["n"]);
            addChilderToUniGrid(this.grid_2, Keys["m"]);
            addChilderToUniGrid(this.grid_2, Keys["."]);
            addChilderToUniGrid(this.grid_2, Keys["/"]);
            addChilderToUniGrid(this.grid_2, Keys[","]);
            addChilderToUniGrid(this.grid_2, Keys["up"]);
            addChilderToUniGrid(this.grid_2, Keys["delete"]);
            addChilderToUniGrid(this.grid_2, Keys["1"]);
            addChilderToUniGrid(this.grid_2, Keys["2"]);
            addChilderToUniGrid(this.grid_2, Keys["3"]);

        }
        private void IntitializeGrid_3()
        {
            addChilderToUniGrid(this.grid_3 , Keys["eng"]);
            addChilderToUniGrid(this.grid_3 , Keys["ctrl"]);
            addChilderToUniGrid(this.grid_3 , Keys["space"]);
            addChilderToUniGrid(this.grid_3 , Keys["left"]);
            addChilderToUniGrid(this.grid_3, Keys["dowen"]);
            addChilderToUniGrid(this.grid_3, Keys["right"]);
            addChilderToUniGrid(this.grid_3, Keys["at_sing"]);
            addChilderToUniGrid(this.grid_3, Keys["0"]);
            addChilderToUniGrid(this.grid_3, Keys["._algone"]);
        }
        private void addChilderToUniGrid(UniformGrid grid ,  Key? key)
        {
            if (key is null)
                return;
            grid.Children.Add(key);
        }

        private void addChilderToUniGrid (UniformGrid grid, Key? key , int columnSpacn)
        {
            if (key is null)
                return;

        }



    }
}
