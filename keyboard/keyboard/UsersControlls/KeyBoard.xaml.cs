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
            addChilderToUniGrid(this.row_0_column_0, Keys["q"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["w"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["e"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["r"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["t"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["y"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["u"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["i"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["o"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["p"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["{"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["}"]);
            addChilderToUniGrid(this.row_0_column_0, Keys["|"]);
            row_0_column_1.Content =  Keys["back"].Content;
            addChilderToUniGrid(this.row_0_column_2, Keys["7"]);
            addChilderToUniGrid(this.row_0_column_2, Keys["8"]);
            addChilderToUniGrid(this.row_0_column_2, Keys["9"]);

           

        }
        private void IntitializeGrid_1()
        {
            this.row_1_column_0.Content = Keys["capsLoock"];
            
            addChilderToUniGrid(this.row_1_column_1, Keys["a"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["s"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["d"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["f"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["g"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["h"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["j"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["k"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["l"]);
            addChilderToUniGrid(this.row_1_column_1, Keys[";"]);
            addChilderToUniGrid(this.row_1_column_1, Keys["'"]);
            this.row_1_column_2.Content = Keys["enter"].Content;

            addChilderToUniGrid(this.row_1_column_3, Keys["4"]);
            addChilderToUniGrid(this.row_1_column_3, Keys["5"]);
            addChilderToUniGrid(this.row_1_column_3, Keys["6"]);

        }
        private void IntitializeGrid_2()
        {

            this.row_2_column_0.Content = Keys["shift"].Content;

            addChilderToUniGrid(this.row_2_column_1, Keys["z"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["x"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["c"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["v"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["b"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["n"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["m"]);
            addChilderToUniGrid(this.row_2_column_1, Keys["."]);
            addChilderToUniGrid(this.row_2_column_1, Keys["/"]);
            addChilderToUniGrid(this.row_2_column_1, Keys[","]);
            addChilderToUniGrid(this.row_2_column_1, Keys["up"]);

            this.row_2_column_2.Content = Keys["delete"].Content;

            addChilderToUniGrid(this.row_2_column_3, Keys["1"]);
            addChilderToUniGrid(this.row_2_column_3, Keys["2"]);
            addChilderToUniGrid(this.row_2_column_3, Keys["3"]);

        }
        private void IntitializeGrid_3()
        {
            addChilderToUniGrid(this.row_3_column_0, Keys["eng"]);
            addChilderToUniGrid(this.row_3_column_0, Keys["ctrl"]);

            this.row_3_column_1.Content = Keys["space"].Content;

            addChilderToUniGrid(this.row_3_column_2 , Keys["left"]);
            addChilderToUniGrid(this.row_3_column_2 , Keys["dowen"]);
            addChilderToUniGrid(this.row_3_column_2 , Keys["right"]);
            addChilderToUniGrid(this.row_3_column_2 , Keys["at_sing"]);

            this.row_3_column_3.Content = Keys["0"].Content;

            this.row_3_column_4.Content = Keys["._algone"].Content;
       
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
