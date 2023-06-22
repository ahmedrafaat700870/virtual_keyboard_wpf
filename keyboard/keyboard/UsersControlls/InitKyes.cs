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

        public void Init()
        {
            this.Keys = new Dictionary<string, Key>();

            init_first_row();
            init_second_row();
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
        public Dictionary<string, Key> getKeys()
        {
            if (this.Keys is null)
                Init();
            return this.Keys!;
        }
        public Key init_q()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44 , 43);
            key.setKey("q");
            key.toLowerCase();
            return key;
        }

        public Key init_w()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("w");
            key.toLowerCase();
            return key;
        }

        public Key init_e()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("e");
            key.toLowerCase();
            return key;
        }

        public Key init_r()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("r");
            key.toLowerCase();
            return key;
        }

        public Key init_t()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("t");
            key.toLowerCase();
            return key;
        }

        public Key init_y()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("y");
            key.toLowerCase();
            return key;
        }

        public Key init_u()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("u");
            key.toLowerCase();
            return key;
        }

        public Key init_i()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("i");
            key.toLowerCase();
            return key;
        }

        public Key init_o()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("o");
            key.toLowerCase();
            return key;
        }

        public Key init_p()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("p");
            key.toLowerCase();
            return key;
        }

        public Key init_keryl_left()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("[");
            key.setSing("{");
            key.toLowerCase();
            return key;
        }

        public Key init_keryl_right()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("]");
            key.setSing("}");
            key.toLowerCase();
            return key;
        }

        public Key init_pipe()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("\\");
            key.setSing("|");
            key.toLowerCase();
            return key;
        }

        public Key init_back()
        {
            Key key = new Key();
            key.keyDowenRight();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("Back");
            key.toLowerCase();
            return key;
        }

        public Key init_7()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("7");
            key.toLowerCase();
            return key;
        }

        public Key init_8()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("8");
            key.toLowerCase();
            return key;
        }

        public Key init_9()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("9");
            key.toLowerCase();
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

        public Key init_caps_lock()
        {
            Key key = new Key();
            key.keyDowenLeft();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(74.72, 43);
            key.setKey("caps lock");
            key.toLowerCase();
            return key;
        }

        public Key init_a()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("a");
            key.toLowerCase();
            return key;
        }

        public Key init_s()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("s");
            key.toLowerCase();
            return key;
        }

        public Key init_d()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("d");
            key.toLowerCase();
            return key;
        }

        public Key init_f()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("f");
            key.toLowerCase();
            return key;
        }

        public Key init_g()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("g");
            key.toLowerCase();
            return key;
        }

        public Key init_h()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("h");
            key.toLowerCase();
            return key;
        }

        public Key init_j()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("j");
            key.toLowerCase();
            return key;
        }

        public Key init_k()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("k");
            key.toLowerCase();
            return key;
        }

        public Key init_l()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("l");
            key.toLowerCase();
            return key;
        }

        public Key init_simecolen()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey(";");
            key.setSing(":");
            key.toLowerCase();
            return key;
        }

        public Key init_singel_qotiation()
        {
            Key key = new Key();
            key.singWithKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("'");
            key.setSing("\"");
            key.toLowerCase();
            return key;
        }

        public Key init_enter()
        {
            Key key = new Key();
            key.keyDowenRight();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(94.83, 43);
            key.setKey("Enter");
            key.toLowerCase();
            return key;
        }

        public Key init_4()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("4");
            key.toLowerCase();
            return key;
        }

        public Key init_5()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("5");
            key.toLowerCase();
            return key;
        }

        public Key init_6()
        {
            Key key = new Key();
            key.numberKey();
            key.setISenderKey(senderKey);
            key.setWidthAndHeigth(44, 43);
            key.setKey("6");
            key.toLowerCase();
            return key;
        }

        // second row end







    }
}
