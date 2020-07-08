using CopyDirectory.Libs.Services;
using Ninject.Modules;
namespace CopyDirectory.IoC
{
    class DependencyModule : NinjectModule
    {
        public override void Load()
        {
            Bind(typeof(Libs.Services.ICopyService)).To(typeof(CopyService));
            //Bind<IApplicationShellView>().To<ApplicationShellView>();

            //Bind<IDocumentController>().To<SpreadsheetController>();
            //Bind<ISpreadsheetView>().To<SpreadsheetView>();
        }
    }
}
