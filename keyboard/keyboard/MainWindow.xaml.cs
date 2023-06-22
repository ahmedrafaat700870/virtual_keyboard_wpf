using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WindowsInput.Native;
using WindowsInput;
using System.Runtime.InteropServices;

namespace keyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //private InputSimulator InputSimulator = new InputSimulator();
        public MainWindow()
        {
            InitializeComponent();
            MakeDraggable(this, this);
        }
        // Import the user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        // Declare some keyboard keys as constants with its respective code
        // See Virtual Code Keys: https://msdn.microsoft.com/en-us/library/dd375731(v=vs.85).aspx
        public   int KEYEVENTF_EXTENDEDKEY { get; set; } = 0x0001; //Key down flag
        public  const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public  const int VK_RCONTROL = 0xA3; //Right Control key code

        // Simulate a key press event
       

        public void MakeDraggable(System.Windows.UIElement moveThisElement, System.Windows.UIElement movedByElement)
        {
            keybd_event(VK_RCONTROL, 0, KEYEVENTF_EXTENDEDKEY, 0);
            keybd_event(VK_RCONTROL, 0, KEYEVENTF_KEYUP, 0);
            bool isMousePressed = false;
            System.Windows.Media.TranslateTransform transform = new System.Windows.Media.TranslateTransform(0, 0);
            moveThisElement.RenderTransform = transform;
            System.Windows.Point originalPoint = new System.Windows.Point(0, 0), currentPoint;

            movedByElement.MouseLeftButtonDown += (a, b) =>
            {
                isMousePressed = true;
                originalPoint = ((System.Windows.Input.MouseEventArgs)b).GetPosition(moveThisElement);
            };

            movedByElement.MouseLeftButtonUp += (a, b) => isMousePressed = false;
            movedByElement.MouseLeave += (a, b) => isMousePressed = false;
            movedByElement.MouseMove += (a, b) =>
            {
                if (!isMousePressed) return;

                currentPoint = ((System.Windows.Input.MouseEventArgs)b).GetPosition(moveThisElement);

                transform.X += currentPoint.X - originalPoint.X;
                transform.Y += currentPoint.Y - originalPoint.Y;
            };
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {
            InputSimulator oInputSimulator = new InputSimulator();
            oInputSimulator.Keyboard.TextEntry("A");
            oInputSimulator.Keyboard.KeyPress(VirtualKeyCode.VK_H);
            /*_simulator.Keyboard.TextEntry("ahmed rafata abdel rahamnaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            InputSimulator oInputSimulator = new InputSimulator();*/
            //InputSimulator.Keyboard.TextEntry("ahmed");

            //simulateTypingText("a");
        }

        private void a_Click(object sender, RoutedEventArgs e)
        {
            /*string _k = "a";
            _simulator.Keyboard.TextEntry(_k);*/
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
           /* string _k = "b";
            var x = _simulator.Keyboard.TextEntry(_k);*/
        }

        private void simulateTypingText(string Text, int typingDelay = 100, int startDelay = 0)
        {
            InputSimulator sim = new InputSimulator();

            // Wait the start delay time
            sim.Keyboard.Sleep(startDelay);

            // Split the text in lines in case it has
            string[] lines = Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

            // Some flags to calculate the percentage
            int maximum = lines.Length;
            int current = 1;

            foreach (string line in lines)
            {
                // Split line into characters
                char[] words = line.ToCharArray();

                // Simulate typing of the char i.e: a, e , i ,o ,u etc
                // Apply immediately the typing delay
                foreach (char word in words)
                {
                    sim.Keyboard.TextEntry(word).Sleep(typingDelay);
                }

                float percentage = ((float)current / (float)maximum) * 100;

                current++;

                // Add a new line by pressing ENTER
                // Return to start of the line in your editor with HOME
                sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                sim.Keyboard.KeyPress(VirtualKeyCode.HOME);

                // Show the percentage in the console
                Console.WriteLine("Percent : {0}", percentage.ToString());
            }
        }
    }
}
