using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    static class Program
    {
        // main entry point into the application

        [STAThread] // to make sure UI functions correctly
        static void Main()
        {
            Application.EnableVisualStyles(); //enabling visual styles
            Application.SetCompatibleTextRenderingDefault(false); // improves text rendering quality
            Application.Run(new MainForm()); // starting the application loop
        }
    }
}
