using Microsoft.Extensions.DependencyInjection;
using Presentation.Interfaces.Common;

namespace Presentation {
    public class ApplicationController : IApplicationController {
        
        public IServiceProvider? ServiceProvider { get; private set; }

        private readonly IServiceCollection _services;
        
        public ApplicationController()
        {
            _services = new ServiceCollection();
            _services.AddSingleton<IApplicationController>(this);
        }
        public IApplicationController RegisterView<TView, TImplementation>() 
            where TView : class, IView 
            where TImplementation : class, TView
        {
            _services.AddSingleton<TView, TImplementation>();
            return this;
        }

        public IApplicationController RegisterScopedService<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService {
            _services.AddScoped<TService, TImplementation>();
            return this;
        }

        public IApplicationController RegisterSingletonService<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService {
            _services.AddSingleton<TService, TImplementation>();
            return this;
        }

        public IApplicationController RegisterInstance<TInstance>(TInstance instance) where TInstance : class
        {
            _services.AddSingleton<TInstance>(instance);
            return this;
        }

        public IApplicationController Build()
        {
            ServiceProvider = _services?.BuildServiceProvider();
            return this;
        }

        public void Run<TPresenter>() where TPresenter : class, IPresenter
        {
            if (ServiceProvider == null) 
                throw new ApplicationException("Presenter is not registered");
            var presenter = ServiceProvider.GetRequiredService<TPresenter>();
            presenter.Run();
        }
    }
}
