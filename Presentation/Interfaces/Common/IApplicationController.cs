namespace Presentation.Interfaces.Common {
    public interface IApplicationController
    {
        IApplicationController RegisterView<TView, TImplementation>()
            where TImplementation : class, TView
            where TView : class, IView;

        IApplicationController RegisterScopedService<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;
        IApplicationController RegisterSingletonService<TService, TImplementation>()
            where TService : class
            where TImplementation : class, TService;

        IApplicationController RegisterInstance<TInstance>(TInstance instance) where TInstance : class;

        IApplicationController Build();

        void Run<TPresenter>() where TPresenter : class, IPresenter;

    }
}
