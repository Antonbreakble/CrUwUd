using Presentation.Interfaces.Common;

namespace Presentation.Presenter {
    public class BasePresenter<TView> : IPresenter where TView : IView
    {

        protected readonly IApplicationController Controller;
        protected readonly TView View;

        public BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }
        
        public void Run()
        {
            View.Show();
        }
    }
}
