using keyboard.UsersControlls.classes;
using keyboard.UsersControlls.interfaces;
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
    /// 
    public partial class KeyBoard : UserControl , IKeyBoard
    {
        public enum LangKeyBoard
        {
            EN , AR
        }
        private ISenderKey senderkey;
        private Dictionary<string  ,IKey> Keys = null!;
        private IInitKeys initkeys = null!;
        private TextBox focusEl = null!;
        private LangKeyBoard lang = LangKeyBoard.EN;
        public void setFocusEl(TextBox el)
        {
            this.focusEl = el;
        }
        public KeyBoard()
        {
            InitializeComponent();
            senderkey = new SendKey();
        }
        private IInitKeys FactoryInitKeys(ISenderKey sender)
        {
            IInitKeys initkeys = null!;
            if (lang== LangKeyBoard.EN)
            {
                initkeys = new InitKyes(sender);
            } else
            {
                initkeys = new InitKeysAR(sender);
            }
            return initkeys;
        }
        public void changLang(LangKeyBoard newLang)
        {
            this.lang = newLang;
        }
        public void Init()
        {
            if(Keys is null)
                Keys = new Dictionary<string, IKey>();
            initkeys = FactoryInitKeys(senderkey);
            initkeys.setFocusEl(focusEl);
            Keys = initkeys.getKeys();
            IntitializeGrid_0();
            IntitializeGrid_1();
            IntitializeGrid_2();
            IntitializeGrid_3();

        }
        private void IntitializeGrid_0()
        {
            row_0_column_0.Children.Clear();
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

            row_0_column_1.Content =  (Keys["back"] as UserControl)!.Content;
            row_0_column_1.MouseLeftButtonDown += (e, ev) => initkeys.click_back();
            row_0_column_2.Children.Clear();

            addChilderToUniGrid(this.row_0_column_2, Keys["7"]);
            addChilderToUniGrid(this.row_0_column_2, Keys["8"]);
            addChilderToUniGrid(this.row_0_column_2, Keys["9"]);

        }
        private void IntitializeGrid_1()
        {

            this.row_1_column_0.Content = (Keys["capsLoock"] as UserControl)!.Content;
            row_1_column_0.MouseLeftButtonDown += (e, ev) => initkeys.click_capslk();

            row_1_column_1.Children.Clear();

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

            this.row_1_column_2.Content = (Keys["enter"] as UserControl)!.Content;
            row_1_column_2.MouseLeftButtonDown += (e, ev) => initkeys.clickEnter();

            row_1_column_3.Children.Clear();

            addChilderToUniGrid(this.row_1_column_3, Keys["4"]);
            addChilderToUniGrid(this.row_1_column_3, Keys["5"]);
            addChilderToUniGrid(this.row_1_column_3, Keys["6"]);

        }
        private void IntitializeGrid_2()
        {

            this.row_2_column_0.Content = (Keys["shift"] as UserControl)!.Content;
            row_2_column_0.MouseLeftButtonDown += (e, ev) => initkeys.click_shift();

            row_2_column_1.Children.Clear();


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

            this.row_2_column_2.Content = (Keys["delete"] as UserControl)!.Content;
            this.row_2_column_2.MouseLeftButtonDown += (e  ,ev) => initkeys.click_delete();

            row_2_column_3.Children.Clear();


            addChilderToUniGrid(this.row_2_column_3, Keys["1"]);
            addChilderToUniGrid(this.row_2_column_3, Keys["2"]);
            addChilderToUniGrid(this.row_2_column_3, Keys["3"]);

        }
        private void IntitializeGrid_3()
        {

            row_3_column_0.Children.Clear();


            addChilderToUniGrid(this.row_3_column_0, Keys["eng"]);
            addChilderToUniGrid(this.row_3_column_0, Keys["ctrl"]);

            this.row_3_column_1.Content = (Keys["space"] as UserControl)!.Content;
            this.row_3_column_1.MouseLeftButtonDown += (e, ev) => initkeys.click_space();

            row_3_column_2.Children.Clear();


            addChilderToUniGrid(this.row_3_column_2 , Keys["left"]);
            addChilderToUniGrid(this.row_3_column_2 , Keys["dowen"]);
            addChilderToUniGrid(this.row_3_column_2 , Keys["right"]);
            addChilderToUniGrid(this.row_3_column_2 , Keys["at_sing"]);

            this.row_3_column_3.Content = (Keys["0"] as UserControl)!.Content;
            this.row_3_column_3.MouseLeftButtonDown += (e , ev) => initkeys.click_zero();
            this.row_3_column_4.Content = (Keys["._algone"] as UserControl)!.Content;
            this.row_3_column_4.MouseLeftButtonDown += (e, ev) => initkeys.click_dot();
       
        }
        private void addChilderToUniGrid(UniformGrid grid ,  IKey? key)
        {
            if (key is null)
                return;
            grid.Children.Add(key as UserControl);
        }
        private void addChilderToUniGrid (UniformGrid grid, IKey? key , int columnSpacn)
        {
            if (key is null)
                return;

        }
        public void SuimolateKeyPress(System.Windows.Input.Key k)
        {
            /*string q = System.Windows.Input.Key.Q.ToString().ToLower();
            IKey _key = k switch
            {
                System.Windows.Input.Key.Q => Keys["q"],
                System.Windows.Input.Key.W => Keys["w"],
                System.Windows.Input.Key.E => Keys["e"],
                System.Windows.Input.Key.R => Keys["r"],
                System.Windows.Input.Key.T => Keys["r"],
                System.Windows.Input.Key.Y => Keys["y"],
                System.Windows.Input.Key.U => Keys["u"],
                System.Windows.Input.Key.I => Keys["i"],
                System.Windows.Input.Key.O => Keys["o"],
                System.Windows.Input.Key.P => Keys["p"],
                _ => null!
            } ;

            if (_key is null) return*/;

            //_key.click_key();

        }
    }
}
