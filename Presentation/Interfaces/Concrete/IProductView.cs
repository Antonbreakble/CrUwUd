using Domain.Models;
using Presentation.Interfaces.Common;

namespace Presentation.Interfaces.Concrete {
    public interface IProductView : IView {
        public string ProductId { get; set; }
        public string NameProduct { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Quantity { get; set; }
        public string ProductPrice { get; set; }
        public bool IsEditMode { get; set; }
        public IList<ProductModel> Products { get; set; }
        public ProductModel? SelectedProduct { get; }

        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        bool ShowWarningDialog(string warningMessage);

    }
}
