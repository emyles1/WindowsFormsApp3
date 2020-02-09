using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD:WindowsFormsApp3/WindowsFormsApp3/Program.cs
            Application.Run(new btnCreateAdminDB());
           Application.Run(new Login());
            Application.Run(new Game());
            Application.Run(new AddStudent());
            
=======
           // Application.Run(new btnCreateAdminDB());
            Application.Run(new Login());
            //Application.Run(new Game());
            //Application.Run(new AddStudent());
      
      


>>>>>>> 03b448acc5fcb2d6ff1d5a5fc3221d8e4563f1c0:WindowsFormsApp3/Program.cs
        }
    }
}
