using keyboard.UsersControlls.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace keyboard.UsersControlls.classes
{
    public class InitKeysAR : IInitKeys
    {
        private readonly ISenderKey senderKey = null!;
        private Dictionary<string, IKey> Keys = null!;
        private bool isUpperCase = !true;
        private bool focusShift = false;
        private TextBox focusEl = null!;
        public InitKeysAR(ISenderKey senderkey)
        {
            senderKey = senderkey;
        }
        private void to_upper()
        {
            isUpperCase = !isUpperCase;
            foreach (var key in Keys.Keys)
            {
                IKey k = Keys[key];
                k.toUpperCase();
            }
        }
        private void to_lower()
        {
            isUpperCase = !isUpperCase;
            foreach (var key in Keys.Keys)
            {
                IKey k = Keys[key];
                k.toLowerCase();
            }
        }
        public void click_shift()
        {
            focusShift = !focusShift;
            if (isUpperCase)
            {
                to_lower();
            }
            else
            {
                to_upper();
            }
        }
        public void click_back()
        {
            if (focusEl is null)
                return;
            string text = focusEl.Text;
            if (text.Length == 0)
                return;
            focusEl.Text = text.Remove(text.Length - 1);
        }
        public void click_capslk()
        {
            if (isUpperCase) to_lower();
            else to_upper();
        }
        public void setFocusEl(TextBox el)
        {
            focusEl = el;
        }
        public void clickEnter()
        {
            if (this.focusEl is null) return;

            int caretIndex = this.focusEl.CaretIndex;
            string text = this.focusEl.Text;
            this.focusEl.Text = text.Insert(caretIndex, Environment.NewLine);
            this.focusEl.CaretIndex = caretIndex + Environment.NewLine.Length;
        }
        private void FocusEl()
        {
            if (focusEl != null)
            {
                focusEl.Focus();
            }
        }
        public Dictionary<string, IKey> getKeys()
        {
            if (Keys is null)
                Init();
            return Keys!;
        }
        private void Init()
        {
            Keys = new Dictionary<string, IKey>();

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
        private Key init_key(string _key, string? sing = null!)
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

            return key;
        }
        private Key init_key(string _key, Action<object> action, string sing = null!)
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
            key.MouseLeftButtonDown += (e, ev) => action.Invoke(e);
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
        public void click_delete()
        {
            if (focusEl is null)
                return;

            focusEl.Text = string.Empty;

        }
        public void click_space()
        {
            if (focusEl is null)
                return;
            string text = focusEl.Text + " ";
            focusEl.Text = text;

            focusEl.SelectionStart = text.Length;
        }
        public void click_zero()
        {
            string _key = "0";
            FocusEl();
            senderKey.sendKey(_key);
            if (focusShift)
                click_shift();
        }
        public void click_dot()
        {
            string _key = ".";
            FocusEl();
            senderKey.sendKey(_key);
            if (focusShift)
                click_shift();
        }
        private void clickNormalKey(object sender)
        {
            string _key = string.Empty;
            _key = (sender as Key)!.key.Text;
            FocusEl();
            senderKey.sendKey(_key);
            if (focusShift)
                click_shift();
        }
        private void click_left()
        {
            if (focusEl is null) return;
            int SelectionStart = focusEl.SelectionStart;
            if (SelectionStart <= 0) return;
            focusEl.SelectionStart = SelectionStart - 1;
        }
        private void click_right()
        {
            if (focusEl is null) return;
            int SelectionStart = focusEl.SelectionStart;
            if (SelectionStart >= focusEl.Text.Length) return;
            focusEl.SelectionStart = SelectionStart + 1;
        }
        private void click_up()
        {
            if (focusEl is null) return;

            int caretIndex = this.focusEl.CaretIndex;
            int lineIndex = this.focusEl.GetLineIndexFromCharacterIndex(caretIndex);

            if (lineIndex > 0)
            {
                int previousLineStart = this.focusEl.GetCharacterIndexFromLineIndex(lineIndex - 1);
                this.focusEl.CaretIndex = previousLineStart;
            }
        }
        private void click_down()
        {

            int caretIndex = this.focusEl.CaretIndex;
            int lineIndex = this.focusEl.GetLineIndexFromCharacterIndex(caretIndex);
            int lineCount = this.focusEl.LineCount;

            if (lineIndex < lineCount - 1)
            {
                int nextLineStart = this.focusEl.GetCharacterIndexFromLineIndex(lineIndex + 1);
                this.focusEl.CaretIndex = nextLineStart;
            }
        }

        private Key init_q()
        {
            Key key = init_key("ض", clickNormalKey, string.Empty);

            return key;
        }
        private Key init_w()
        {
            Key key = init_key("ص", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_e()
        {
            Key key = init_key("ث", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_r()
        {
            Key key = init_key("ق", clickNormalKey, string.Empty);

            return key;
        }
        private Key init_t()
        {
            Key key = init_key("ف", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_y()
        {
            Key key = init_key("غ", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_u()
        {
            Key key = init_key("ع", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_i()
        {
            Key key = init_key("ه", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_o()
        {
            Key key = init_key("خ", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_p()
        {
            Key key = init_key("ح", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_keryl_left()
        {
            Key key = init_key("ج", clickNormalKey, "{");
            return key;
        }
        private Key init_keryl_right()
        {
            Key key = init_key("د", clickNormalKey, "}");
            return key;
        }
        private Key init_pipe()
        {
            Key key = init_key("\\", clickNormalKey, "|");
            return key;
        }
        private Key init_back()
        {
            Key key = init_key("Back", click_back);
            return key;
        }
        private Key init_7()
        {
            Key key = init_key("7", clickNormalKey, string.Empty);

            return key;
        }
        private Key init_8()
        {
            Key key = init_key("8", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_9()
        {
            Key key = init_key("9", clickNormalKey, string.Empty);
            return key;
        }

        // first row end  

        // second row start 
        private void init_second_row()
        {
            Keys.Add("capsLoock", init_caps_lock());
            Keys.Add("a", init_a());
            Keys.Add("s", init_s());
            Keys.Add("d", init_d());
            Keys.Add("f", init_f());
            Keys.Add("g", init_g());
            Keys.Add("h", init_h());
            Keys.Add("j", init_j());
            Keys.Add("k", init_k());
            Keys.Add("l", init_l());
            Keys.Add(";", init_simecolen());
            Keys.Add("'", init_singel_qotiation());
            Keys.Add("enter", init_enter());
            Keys.Add("4", init_4());
            Keys.Add("5", init_5());
            Keys.Add("6", init_6());
        }
        private Key init_caps_lock()
        {
            Key key = init_key("caps lock", click_capslk);
            return key;
        }
        private Key init_a()
        {
            Key key = init_key("a", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_s()
        {
            Key key = init_key("s", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_d()
        {
            Key key = init_key("d", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_f()
        {
            Key key = init_key("f", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_g()
        {
            Key key = init_key("g", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_h()
        {
            Key key = init_key("h", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_j()
        {
            Key key = init_key("j", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_k()
        {
            Key key = init_key("k", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_l()
        {
            Key key = init_key("l", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_simecolen()
        {
            Key key = init_key(";", clickNormalKey, ":");
            return key;
        }
        private Key init_singel_qotiation()
        {
            Key key = init_key("'", clickNormalKey, "\"");
            return key;
        }
        private Key init_enter()
        {
            Key key = init_key("Enter", clickEnter, string.Empty);
            return key;
        }



        private Key init_4()
        {
            Key key = init_key("4", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_5()
        {
            Key key = init_key("5", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_6()
        {
            Key key = init_key("6", clickNormalKey, string.Empty);
            return key;
        }

        // second row end

        // start with row 3

        private void init_thired_row()
        {
            Keys.Add("shift", init_shift());
            Keys.Add("z", init_z());
            Keys.Add("x", init_x());
            Keys.Add("c", init_c());
            Keys.Add("v", init_v());
            Keys.Add("b", init_b());
            Keys.Add("n", init_n());
            Keys.Add("m", init_m());
            Keys.Add(".", init_dot());
            Keys.Add("/", init_question_mark());
            Keys.Add(",", init_smarler_than());
            Keys.Add("up", init_up());
            Keys.Add("delete", init_delete());
            Keys.Add("1", init_1());
            Keys.Add("2", init_2());
            Keys.Add("3", init_3());
        }

        private Key init_shift()
        {
            Key key = init_key("shift", click_shift);
            return key;
        }
        private Key init_z()
        {
            Key key = init_key("z", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_x()
        {
            Key key = init_key("x", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_c()
        {
            Key key = init_key("c", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_v()
        {
            Key key = init_key("v", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_b()
        {
            Key key = init_key("b", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_n()
        {
            Key key = init_key("n", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_m()
        {
            Key key = init_key("m", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_dot()
        {
            Key key = init_key(".", clickNormalKey, ">");
            return key;
        }
        private Key init_question_mark()
        {
            Key key = init_key("/", clickNormalKey, "?");
            return key;
        }
        private Key init_smarler_than()
        {
            Key key = init_key(",", clickNormalKey, "<");
            return key;
        }
        private Key init_up()
        {
            Key key = init_key("up", click_up);
            return key;
        }
        private Key init_delete()
        {
            Key key = init_key("delete", click_delete);
            return key;
        }
        private Key init_1()
        {
            Key key = init_key("1", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_2()
        {
            Key key = init_key("2", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_3()
        {
            Key key = init_key("3", clickNormalKey, string.Empty);
            return key;
        }
        // end row 3
        // start with last row
        private void init_fourth_row()
        {
            Keys.Add("eng", init_eng());
            Keys.Add("ctrl", init_ctrl());
            Keys.Add("space", init_space());
            Keys.Add("left", init_left());
            Keys.Add("dowen", init_dowen());
            Keys.Add("right", init_right());
            Keys.Add("at_sing", init_at_sing());
            Keys.Add("0", init_0());
            Keys.Add("._algone", init_dot_along());
        }
        private Key init_eng()
        {
            Key key = init_key("eng", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_ctrl()
        {
            Key key = init_key("ctrl", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_space()
        {
            Key key = init_key(" ", click_space);
            return key;
        }
        private Key init_left()
        {
            Key key = init_key("left", click_left);
            return key;
        }
        private Key init_dowen()
        {
            Key key = init_key("down", click_down);
            return key;
        }
        private Key init_right()
        {
            Key key = init_key("right", click_right);
            return key;
        }
        private Key init_at_sing()
        {
            Key key = init_key("@", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_0()
        {
            Key key = init_key("0", clickNormalKey, string.Empty);
            return key;
        }
        private Key init_dot_along()
        {
            Key key = init_key(".", clickNormalKey, string.Empty);
            return key;
        }

        // end last row
    }
}
