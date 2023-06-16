using Domain.Repository.ProductRepository;
using Microsoft.Extensions.Configuration;
using Presentation;
using Presentation.Interfaces.Concrete;
using Presentation.Presenter;
using UI.View;

namespace UI {
    internal static class Program {

        public static readonly ApplicationContext Context = new();

        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            AppDomain.CurrentDomain.UnhandledException += CurrentDomainOnUnhandledException;
            Application.ThreadException += ApplicationOnThreadException;

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            
            var controller = new ApplicationController()
                .RegisterScopedService<IProductRepository, ProductRepository>()
                .RegisterView<IProductView, ProductView>()
                .RegisterScopedService<BasePresenter<IProductView>, ProductPresenter>()
                .RegisterInstance(Context)
                .RegisterInstance<IConfiguration>(configuration)
                .Build();

            controller.Run<BasePresenter<IProductView>>();
        }

        private static void ApplicationOnThreadException(object sender, ThreadExceptionEventArgs e) {
            MessageBox.Show($"{e.Exception.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private static void CurrentDomainOnUnhandledException(object sender, UnhandledExceptionEventArgs e) {
            if(e.ExceptionObject is not Exception ex)
                return;
            MessageBox.Show($"{ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}