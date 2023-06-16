using System.Globalization;
using Domain.Models;
using Domain.Repository.ProductRepository;
using Domain.Validation;
using FluentValidation;
using Presentation.Interfaces.Common;
using Presentation.Interfaces.Concrete;

namespace Presentation.Presenter {
    public class ProductPresenter : BasePresenter<IProductView> {
        private readonly IProductRepository _productRepository;
        public ProductPresenter(IApplicationController applicationController,
                                IProductView productView,
                                IProductRepository productRepository) : base(applicationController, productView)
        {
            _productRepository = productRepository;
            SetupEvents();

            LoadAllProduct();
        }

        private void LoadAllProduct()
        {
            var products = _productRepository.GetAll();
            View.Products = products.ToList();
        }

        private void SetupEvents()
        {
            View.AddNewEvent += ViewOnAddNewEvent;
            View.DeleteEvent += ViewOnDeleteEvent;
            View.EditEvent += ViewOnEditEvent;
            View.SaveEvent += ViewOnSaveEvent;
            View.CancelEvent += ViewOnCancelEvent;
        }

        private void ViewOnCancelEvent(object? sender, EventArgs e) {
            CleanDetails();
            View.IsEditMode = false;
        }

        private void CleanDetails() {
            View.ProductId = string.Empty;
            View.NameProduct = string.Empty;
            View.Quantity = string.Empty;
            View.ProductPrice = string.Empty;
            View.ReceiptDate = DateTime.Now;
        }

        private void ViewOnSaveEvent(object? sender, EventArgs e)
        {
            var model = new ProductModel() {
                Id = int.Parse(View.ProductId),
                Name = View.NameProduct,
                Price = decimal.Parse(View.ProductPrice),
                Quantity =  int.Parse(View.Quantity),
                Receiptdate = View.ReceiptDate,
            };
            
            new ProductValidation().ValidateAndThrow(model);
            
            if(View.IsEditMode)
                _productRepository.Edit(model);
            else
                _productRepository.Add(model);
            
            LoadAllProduct();
        }

        private void ViewOnEditEvent(object? sender, EventArgs e)
        {
            if (View.SelectedProduct is not { } model) 
                return;
            View.ProductId = model.Id.ToString();
            View.NameProduct = model.Name;
            View.Quantity = model.Quantity.ToString();
            View.ReceiptDate = model.Receiptdate;
            View.ProductPrice = model.Price.ToString(CultureInfo.InvariantCulture);

            View.IsEditMode = true;
        }

        private void ViewOnDeleteEvent(object? sender, EventArgs e)
        {
            if (View.SelectedProduct == null) 
                return;
            
            if(!View.ShowWarningDialog("Are you sure you want to delete selected product?"))
                return;
            
            _productRepository.Delete(View.SelectedProduct.Id);
            
            LoadAllProduct();
        }

        private void ViewOnAddNewEvent(object? sender, EventArgs e) {
            View.IsEditMode = false;
            CleanDetails();
        }
    }
}
