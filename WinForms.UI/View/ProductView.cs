using System.Diagnostics;
using Domain.Models;
using Presentation.Interfaces.Concrete;

namespace UI.View {
    public partial class ProductView : Form, IProductView{
        
        private readonly ApplicationContext _context;
        public ProductView(ApplicationContext context) {
            _context = context;
            InitializeComponent();

            MainTabControl.TabPages.Remove(DetailTab);

            SetupViewEvents();
        }

        private void SetupViewEvents()
        {
            AddButton.Click += (sender, args) =>
            {
                SwitchTab(DetailTab);
                AddNewEvent?.Invoke(sender, args);
            };
            EditButton.Click += (sender, args) =>
            {
                SwitchTab(DetailTab);
                EditEvent?.Invoke(sender, args);
            };
            DeleteButton.Click += (sender, args) =>
            {
                DeleteEvent?.Invoke(sender, args);
            };
            SaveButton.Click += (sender, args) =>
            {
                SaveEvent?.Invoke(sender, args);
                SwitchTab(ProductsTab);
            };
            CancelButton.Click += (sender, args) =>
            {
                CancelEvent?.Invoke(sender, args);
                SwitchTab(ProductsTab);
            };
        }

        #region Properties

        public string ProductId {
            get => string.IsNullOrEmpty(ProductIdTextBox.Text)  ? "0" : ProductIdTextBox.Text;
            set => ProductIdTextBox.Text = value;
        }

        public string NameProduct {
            get => ProductNameTextBox.Text;
            set => ProductNameTextBox.Text = value;
        }

        public DateTime ReceiptDate {
            get => DateTimePicker.Value;
            set => DateTimePicker.Value = value;
        }

        public string Quantity {
            get => QuentityTextBox.Text;
            set => QuentityTextBox.Text = value;
        }

        public string ProductPrice {
            get => PriceTextBox.Text;
            set => PriceTextBox.Text = value;
        }

        public bool IsEditMode { get; set; }

        public IList<ProductModel> Products {
            get => ProductGridView.DataSource as IList<ProductModel> ?? throw new InvalidOperationException(); 
            set => ProductGridView.DataSource = value;
        }

        public ProductModel? SelectedProduct {
            get {
                if (ProductGridView.SelectedRows[0].DataBoundItem is ProductModel product) {
                    return product;
                }

                return default;
            }
        }

        #endregion


        #region Events
        
        public event EventHandler? AddNewEvent;
        public event EventHandler? DeleteEvent;
        public event EventHandler? EditEvent;
        public event EventHandler? SaveEvent;
        public event EventHandler? CancelEvent;

        #endregion


        #region Methods
        
        public new void Show() {
            _context.MainForm = this;
            Application.Run(_context);
        }
        
        public bool ShowWarningDialog(string warningMessage) {
            var dialogResult =
                MessageBox.Show(warningMessage,
                    "Warning",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
            return dialogResult == DialogResult.Yes;
        }
        
        private void SwitchTab(TabPage tabPage) {
            if (tabPage == null)
                throw new ArgumentNullException(nameof(tabPage));
            MainTabControl.TabPages.Remove(MainTabControl.SelectedTab);
            MainTabControl.TabPages.Add(tabPage);
        }
        
        #endregion

    }
}
