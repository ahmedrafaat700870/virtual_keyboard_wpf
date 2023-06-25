using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput.Native;

namespace keyboard.UsersControlls.interfaces
{
    public interface ISenderKey
    {
        public void sendKey(string key);
    }
}
