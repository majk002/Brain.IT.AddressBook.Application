using SourceData.Utilities;
using System;
using System.IO;
using System.Windows.Forms;

namespace SourceData
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
			AppDomain.CurrentDomain.SetData("DataDirectory", AppContext.BaseDirectory);

            if (!File.Exists(Path.Combine(AppContext.BaseDirectory, DatabaseCreator.mdfFilePath)))
            {
                DatabaseCreator.Create();
            }

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
