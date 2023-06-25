using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace keyboard.UsersControlls.interfaces
{
    public interface IInitKeys
    {
        public void click_shift();
        public void click_back();
        public void click_capslk();
        public void setFocusEl(TextBox el);
        public Dictionary<string, Key> getKeys();
        public void click_delete();
        public void click_space();
        public void click_zero();
        public void click_dot();

    }
}
