using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keyboard.UsersControlls.interfaces
{
    public interface IKey
    {
        public void clickUpperCase();
        public void clickLowerCase();
        public void setMargin(double left, double up, double right, double dowen);
        public void setISenderKey(ISenderKey senderKey);
        public void setKey(string newKey);
        public void setSing(string sing);
        public void numberKey();
        public void keyDowenLeft();
        public void keyDowenRight();
        public void singWithKey();
        public void toUpperCase();
        public void toLowerCase();
        public void click_key(object sender, EventArgs e);
    }
}
