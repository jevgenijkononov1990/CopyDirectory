using CopyDirectory.IoC;
using System;
using System.Windows.Forms;

namespace CopyDirectory
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new DependencyModule());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(CompositionRoot.Resolve<Main>());
        }
    }
}
