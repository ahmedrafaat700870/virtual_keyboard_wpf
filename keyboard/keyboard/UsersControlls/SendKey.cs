using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsInput;
using WindowsInput.Native;

namespace keyboard.UsersControlls
{
    public class SendKey : ISenderKey
    {
        private readonly InputSimulator InputSimulator;
        public SendKey()
        {
            this.InputSimulator = new InputSimulator();
        }
        public void sendKey(string key)
        {
            InputSimulator.Keyboard.TextEntry(key);
        }

        
    }
}
