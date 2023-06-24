using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace keyboard.UsersControlls
{
    public class InitKyes
    {
        private readonly ISenderKey senderKey = null!;
        private Dictionary<string, Key> Keys = null!;
        private bool isUpperCase  = !true;
        private bool focusShift = false;
        private TextBox focusEl = null!;
        public InitKyes(ISenderKey senderkey) 
        {
            this.senderKey = senderkey;
            
        }

        private void to_upper()
        {
            isUpperCase = !isUpperCase;
            foreach(var key in Keys.Keys)
            {
                Key k = Keys[key];
                k.toUpperCase();
            }
        }
        private void to_lower()
        {
            isUpperCase = !isUpperCase;
            foreach (var key in Keys.Keys)
            {
                Key k = Keys[key];
                k.toLowerCase();
            }
        }
        public void click_shift()
        {
            focusShift = !focusShift; 
            if(isUpperCase)
            {
                to_lower();
            } else
            {
                to_upper();
            }
        }
        public void click_back()
        {
            if (focusEl is null)
                return;
            string text = focusEl.Text;
            focusEl.Text = text.Remove(text.Length-1);
        }
        public void click_capslk()
        {
            if (isUpperCase) to_lower();
            else to_upper();
        }

        public void setFocusEl(TextBox el)
        {
            this.focusEl = el;
        }
        private void FocusEl()
        {
            if(focusEl != null)
            {
                this.focusEl.Focus();
            }
        }
        public Dictionary<string, Key> getKeys()
        {
            if (this.Keys is null)
                Init();
            return this.Keys!;
        }
        private void Init()
        {
            this.Keys = new Dictionary<string, Key>();

            init_first_row();
            init_second_row();
            init_thired_row();
            init_fourth_row();
        }
        private void init_first_row()
        {
            // first row 
            Keys.Add("q", init_q());
            Keys.Add("w", init_w());
            Keys.Add("e", init_e());
            Keys.Add("r", init_r());
            Keys.Add("t", init_t());

            Keys.Add("y", init_y());
            Keys.Add("u", init_u());
            Keys.Add("i", init_i());
            Keys.Add("o", init_o());
            Keys.Add("p", init_p());


            Keys.Add("{", init_keryl_left());
            Keys.Add("}", init_keryl_right());
            Keys.Add("|", init_pipe());
            Keys.Add("back", init_back());
            Keys.Add("7", init_7());

            Keys.Add("8", init_8());
            Keys.Add("9", init_9());
        }

        private Key init_key(string _key , string? sing = null!)
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.Focusable = false;
            key.setKey(_key);
            if(sing is not null)
                key.setSing(sing);
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            
            return key;
        }
        private Key init_key(string _key,  Action<object> action , string sing = null!)
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.Focusable = false;
            key.setKey(_key);
            if (sing is not null)
                key.setSing(sing);
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            key.MouseLeftButtonDown += (e , ev) => action.Invoke(e);
            return key;
        }
        private Key init_key(string _key, Action action, string sing = null!)
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.Focusable = false;
            key.setKey(_key);
            if (sing is not null)
                key.setSing(sing);
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            key.MouseLeftButtonDown += (e, ev) => action.Invoke();
            return key;
        }


        private void clickNormalKey(object sender)
        {

            string _key = string.Empty;
            if(focusShift)
                click_shift();
            _key = (sender as Key)!.key.Text;
            FocusEl();
            senderKey.sendKey(_key);
        }

        private Key init_q()
        {
            Key key = init_key("q" , clickNormalKey);
            
            return key;
        }

        private void click_delete()
        {
            if (focusEl is null)
                return;

            focusEl.Text = string.Empty;

        }
      

        private Key init_w()
        {
            Key key = init_key("w" , clickNormalKey);
            return key;
        }
        private Key init_e()
        {
            Key key = init_key("e" , clickNormalKey);
            return key;
        }
        private Key init_r()
        {
            Key key = init_key("r" , clickNormalKey);

            return key;
        }
        private Key init_t()
        {
            Key key = init_key("t" , clickNormalKey);
            return key;
        }
        private Key init_y()
        {
            Key key = init_key("y" , clickNormalKey);
            return key;
        }
        private Key init_u()
        {
            Key key = init_key("u" , clickNormalKey);
            return key;
        }
        private Key init_i()
        {
            Key key = init_key("i" , clickNormalKey);
            return key;
        }
        private Key init_o()
        {
            Key key = init_key("o" , clickNormalKey);
            return key;
        }
        private Key init_p()
        {
            Key key = init_key("p" , clickNormalKey);
            return key;
        }
        private Key init_keryl_left()
        {
            Key key = init_key("[" , clickNormalKey, "{" );
            return key;
        }
        private Key init_keryl_right()
        {
            Key key = init_key("]", clickNormalKey, "}");
            return key;
        }
        private Key init_pipe()
        {
            Key key = init_key("\\", clickNormalKey, "|");
            return key;
        }
        private Key init_back()
        {
            Key key = init_key("Back" , click_back);
            return key;
        }
        private Key init_7()
        {
            Key key = init_key("7" , clickNormalKey);

            return key;
        }
        private Key init_8()
        {
            Key key = init_key("8" , clickNormalKey);
            return key;
        }
        private Key init_9()
        {
            Key key = init_key("9" , clickNormalKey);
            return key;
        }

        // first row end  

        // second row start 
        private void init_second_row()
        {
            this.Keys.Add("capsLoock" , init_caps_lock());
            this.Keys.Add("a" , init_a());
            this.Keys.Add("s" , init_s());
            this.Keys.Add("d" , init_d());
            this.Keys.Add("f" , init_f());
            this.Keys.Add("g" , init_g());
            this.Keys.Add("h" , init_h());
            this.Keys.Add("j" , init_j());
            this.Keys.Add("k" , init_k());
            this.Keys.Add("l" , init_l());
            this.Keys.Add(";" , init_simecolen());
            this.Keys.Add("'" , init_singel_qotiation());
            this.Keys.Add("enter" , init_enter());
            this.Keys.Add("4" , init_4());
            this.Keys.Add("5" , init_5());
            this.Keys.Add("6" , init_6());
        }
        private Key init_caps_lock()
        {
            Key key = init_key("caps lock" , click_capslk);
            return key;
        }
        private Key init_a()
        {
            Key key = init_key("a" , clickNormalKey);
            return key;
        }
        private Key init_s()
        {
            Key key = init_key("s" , clickNormalKey);
            return key;
        }
        private Key init_d()
        {
            Key key = init_key("d" , clickNormalKey);
            return key;
        }
        private Key init_f()
        {
            Key key = init_key("f" , clickNormalKey);
            return key;
        }
        private Key init_g()
        {
            Key key = init_key("g" , clickNormalKey);
            return key;
        }
        private Key init_h()
        {
            Key key = init_key("h" , clickNormalKey);
            return key;
        }
        private Key init_j()
        {
            Key key = init_key("j" , clickNormalKey);
            return key;
        }
        private Key init_k()
        {
            Key key = init_key("k" , clickNormalKey);
            return key;
        }
        private Key init_l()
        {
            Key key = init_key("l" , clickNormalKey);
            return key;
        }
        private Key init_simecolen()
        {
            Key key = init_key(";" , clickNormalKey, ":");
            return key;
        }
        private Key init_singel_qotiation()
        {
            Key key = init_key("'"  , clickNormalKey, "\"");
            return key;
        }
        private Key init_enter()
        {
            Key key = init_key("Enter" , clickNormalKey);
            return key;
        }
        private Key init_4()
        {
            Key key = init_key("4" , clickNormalKey);
            return key;
        }
        private Key init_5()
        {
            Key key = init_key("5" , clickNormalKey);
            return key;
        }
        private Key init_6()
        {
            Key key = init_key("6" , clickNormalKey);
            return key;
        }

        // second row end

        // start with row 3

        private void init_thired_row()
        {
            this.Keys.Add("shift" , init_shift());
            this.Keys.Add("z" , init_z());
            this.Keys.Add("x" , init_x());
            this.Keys.Add("c" , init_c());
            this.Keys.Add("v" , init_v());
            this.Keys.Add("b" , init_b());
            this.Keys.Add("n" , init_n());
            this.Keys.Add("m" , init_m());
            this.Keys.Add("." , init_dot());
            this.Keys.Add("/", init_question_mark());
            this.Keys.Add(",", init_smarler_than());
            this.Keys.Add("up", init_up());
            this.Keys.Add("delete", init_delete());
            this.Keys.Add("1", init_1());
            this.Keys.Add("2", init_2());
            this.Keys.Add("3", init_3());
        }
        private Key init_shift()
        {
            Key key = init_key("shift" , click_shift);
            return key;
        }
        private Key init_z()
        {
            Key key = init_key("z" , clickNormalKey);
            return key;
        }
        private Key init_x()
        {
            Key key = init_key("x" , clickNormalKey);
            return key;
        }
        private Key init_c()
        {
            Key key = init_key("c" , clickNormalKey);
            return key;
        }
        private Key init_v()
        {
            Key key = init_key("v", clickNormalKey);
            return key;
        }
        private Key init_b()
        {
            Key key = init_key("b" , clickNormalKey);
            return key;
        }
        private Key init_n()
        {
            Key key = init_key("n" , clickNormalKey);
            return key;
        }
        private Key init_m()
        {
            Key key = init_key("m" , clickNormalKey);
            return key;
        }
        private Key init_dot()
        {
            Key key = init_key("." , clickNormalKey , ">");
            return key;
        }
        private Key init_question_mark()
        {
            Key key = init_key("/" ,  clickNormalKey ,"?") ;
            return key;
        }
        private Key init_smarler_than()
        {
            Key key = init_key(","  , clickNormalKey, "<");
            return key;
        }
        private Key init_up()
        {
            Key key = init_key("up" , clickNormalKey);
            return key;
        }
        private Key init_delete()
        {
            Key key = init_key("delete"  , click_delete);
            return key;
        }
        private Key init_1()
        {
            Key key = init_key("1" , clickNormalKey);
            return key;
        }
        private Key init_2()
        {
            Key key = init_key("2" , clickNormalKey);
            return key;
        }
        private Key init_3()
        {
            Key key = init_key("3" , clickNormalKey);
            return key;
        }
        // end row 3
        // start with last row
        private void init_fourth_row()
        {
            this.Keys.Add("eng" , init_eng());
            this.Keys.Add("ctrl" , init_ctrl());
            this.Keys.Add("space" , init_space());
            this.Keys.Add("left" , init_left());
            this.Keys.Add("dowen" , init_dowen());
            this.Keys.Add("right" , init_right());
            this.Keys.Add("at_sing" , init_at_sing());
            this.Keys.Add("0" , init_0());
            this.Keys.Add("._algone" , init_dot_along());
        }
        private Key init_eng()
        {
            Key key = init_key("eng" , clickNormalKey);
            return key;
        }
        private Key init_ctrl()
        {
            Key key = init_key("ctrl" , clickNormalKey);
            return key;
        }
        private Key init_space()
        {
            Key key = init_key(" " , clickNormalKey);
            return key;
        }
        private Key init_left()
        {
            Key key = init_key("left" , clickNormalKey);
            return key;
        }
        private Key init_dowen()
        {
            Key key = init_key("down" , clickNormalKey);
            return key;
        }
        private Key init_right()
        {
            Key key = init_key("right" , clickNormalKey);
            return key;
        }
        private Key init_at_sing()
        {
            Key key = init_key("@" , clickNormalKey);
            return key;
        }
        private Key init_0()
        {
            Key key = init_key("0" , clickNormalKey);
            return key;
        }
        private Key init_dot_along()
        {
            Key key = init_key("." , clickNormalKey);
            return key;
        }

        // end last row
    }
}
