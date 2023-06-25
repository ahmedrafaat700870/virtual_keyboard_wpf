using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static keyboard.UsersControlls.KeyBoard;

namespace keyboard.UsersControlls.interfaces
{
    public interface IKeyBoard
    {
        public void Init();
        public void setFocusEl(TextBox el);
        public void SuimolateKeyPress(System.Windows.Input.Key k);
        public void changLang(LangKeyBoard newLang);
    }
}
