using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard.UsersControlls
{
    public class InitKyes
    {
        private readonly ISenderKey senderKey = null!;
        private Dictionary<string, Key> Keys = null!;
        public InitKyes(ISenderKey senderkey) 
        {
            this.senderKey = senderkey;
            
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
        // first row start 
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
        private Key init_q()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
               
            key.setKey("q");
            key.toLowerCase();
            key.setMargin( 6 , 0 , 0 , 0);
            return key;
        }
        private Key init_w()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setMargin(6, 0, 0, 0);
            key.setKey("w");
            key.toLowerCase();
            return key;
        }
        private Key init_e()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("e");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_r()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("r");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_t()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("t");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_y()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("y");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_u()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("u");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_i()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("i");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_o()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("o");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_p()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("p");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_keryl_left()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
             
            key.setKey("[");
            key.setSing("{");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_keryl_right()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
             
            key.setKey("]");
            key.setSing("}");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_pipe()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
             
            key.setKey("\\");
            key.setSing("|");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_back()
        {
            Key key = new Key();
            key.keyDowenRight();
            key.setISenderKey(senderKey);
             
            key.setKey("Back");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_7()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("7");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_8()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("8");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_9()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
             
            key.setKey("9");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
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
            Key key = new Key();
            key.keyDowenLeft();
            key.setISenderKey(senderKey);
            key.setKey("caps lock");
            key.toLowerCase();
            key.setMargin(0, 0, 0, 0);
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_a()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setKey("a");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_s()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("s");
            key.toLowerCase();
            return key;
        }
        private Key init_d()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("d");
            key.toLowerCase();
            return key;
        }
        private Key init_f()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("f");
            key.toLowerCase();
            return key;
        }
        private Key init_g()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("g");
            key.toLowerCase();
            return key;
        }
        private Key init_h()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("h");
            key.toLowerCase();
            return key;
        }
        private Key init_j()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("j");
            key.toLowerCase();
            return key;
        }
        private Key init_k()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("k");
            key.toLowerCase();
            return key;
        }
        private Key init_l()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("l");
            key.toLowerCase();
            return key;
        }
        private Key init_simecolen()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey(";");
            key.setSing(":");
            key.toLowerCase();
            return key;
        }
        private Key init_singel_qotiation()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("'");
            key.setSing("\"");
            key.toLowerCase();
            return key;
        }
        private Key init_enter()
        {
            Key key = new Key();
            key.keyDowenRight();
            key.setISenderKey(senderKey);
            key.setKey("Enter");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_4()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("4");
            key.toLowerCase();
            return key;
        }
        private Key init_5()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("5");
            key.toLowerCase();
            return key;
        }
        private Key init_6()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("6");
            key.toLowerCase();
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
            Key key = new Key();
            key.keyDowenLeft();
            key.setISenderKey(senderKey);
            key.setKey("shift");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_z()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setKey("z");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_x()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("x");
            key.toLowerCase();
            return key;
        }
        private Key init_c()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("c");
            key.toLowerCase();
            return key;
        }
        private Key init_v()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("v");
            key.toLowerCase();
            return key;
        }
        private Key init_b()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("b");
            key.toLowerCase();
            return key;
        }
        private Key init_n()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("n");
            key.toLowerCase();
            return key;
        }
        private Key init_m()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("m");
            key.toLowerCase();
            return key;
        }
        private Key init_dot()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey(".");
            key.setSing(">");
            key.toLowerCase();
            return key;
        }
        private Key init_question_mark()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("/");
            key.setSing("?");
            key.toLowerCase();
            return key;
        }
        private Key init_smarler_than()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey(",");
            key.setSing("<");
            key.toLowerCase();
            return key;
        }
        private Key init_up()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("up");
            key.toLowerCase();
            return key;
        }
        private Key init_delete()
        {
            Key key = new Key();
            key.keyDowenRight();
            key.setISenderKey(senderKey);
            key.setKey("delete");
            key.toLowerCase();
            key.setMargin(6, 0, 0, 0);
            return key;
        }
        private Key init_1()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("1");
            key.toLowerCase();
            return key;
        }
        private Key init_2()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("2");
            key.toLowerCase();
            return key;
        }
        private Key init_3()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("3");
            key.toLowerCase();
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
            Key key = new Key();
            key.keyDowenLeft();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("Eng");
            //key.toLowerCase();
            return key;
        }
        private Key init_ctrl()
        {
            Key key = new Key();
            key.keyDowenLeft();
            key.setISenderKey(senderKey);
            key.setKey("Ctrl");
            key.setMargin(6, 0, 0, 0);
            //key.toLowerCase();
            return key;
        }
        private Key init_space()
        {
            Key key = new Key();
            key.keyDowenLeft();
            key.setISenderKey(senderKey);
            key.setKey(" ");
            key.setMargin(6, 0, 0, 0);
            //key.toLowerCase();
            return key;
        }
        private Key init_left()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("left");
            key.toLowerCase();
            return key;
        }
        private Key init_dowen()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("dowen");
            key.toLowerCase();
            return key;
        }
        private Key init_right()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("right");
            key.toLowerCase();
            return key;
        }
        private Key init_at_sing()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("@");
            key.toLowerCase();
            return key;
        }
        private Key init_0()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey("0");
            key.toLowerCase();
            return key;
        }
        private Key init_dot_along()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setMargin(6, 0, 0, 0);
            key.setKey(".");
            key.toLowerCase();
            return key;
        }

        // end last row
    }
}
