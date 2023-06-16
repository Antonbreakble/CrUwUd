using System.ComponentModel;

namespace Domain.Models {
    public record ProductModel {
        
        [DisplayName("Product Id")]
        public int Id { get; set; }
        
        [DisplayName("Product Name")]
        public string Name { get; set; } = string.Empty;
        
        [DisplayName("Product Receipt Date")]
        public DateTime Receiptdate { get; set; }

        [DisplayName("Product Quantity")]
        public int Quantity { get; set; }
        
        [DisplayName("Product Price")]
        public decimal Price { get; set; }

    }
}
