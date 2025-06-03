using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string[] args = Environment.GetCommandLineArgs();

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string imageFolderPath = Path.Combine(desktopPath, "ImagesFolder");

            
            
                Application.Run(new datainsertion());
            
            
            
                Application.Run(new Form1(imageFolderPath));
            
        }
    }
}
