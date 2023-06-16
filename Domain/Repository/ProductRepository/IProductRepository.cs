using Domain.Models;

namespace Domain.Repository.ProductRepository {
    public interface IProductRepository {
        void Add(ProductModel product);
        void Edit(ProductModel product);
        void Delete(int id);
        IEnumerable<ProductModel> GetAll();

    }
}
