using Dapper;
using Domain.Models;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;

namespace Domain.Repository.ProductRepository {
    public class ProductRepository : IProductRepository {
        protected string ConnectionString;
        private const string TableName = "products";
        public ProductRepository(IConfiguration config)
        {
            ConnectionString = config.GetConnectionString("Default") 
                               ?? throw new ApplicationException("Connection string not found");
            CreateTableIfNotExist();
        }
        public void Add(ProductModel product)
        {
            using var connection = new SqliteConnection(ConnectionString);
            const string query = @$"INSERT INTO {TableName} (name, receiptdate, quantity, price) 
                                    VALUES (@name, @receiptdate, @quantity, @price)";
            connection.Execute(query, new {
                name = product.Name,
                receiptdate = product.Receiptdate,
                quantity = product.Quantity,
                price = product.Price,
            });
        }

        public void Edit(ProductModel product)
        {
            using var connection = new SqliteConnection(ConnectionString);
            const string query = @$"UPDATE {TableName} 
                                    SET name = @name, receiptdate = @receiptdate, quantity = @quantity, price = @price 
                                    WHERE id = @id";
            connection.Execute(query, new {
                id = product.Id,
                name = product.Name,
                receiptdate = product.Receiptdate,
                quantity = product.Quantity,
                price = product.Price,
            });
        }

        public void Delete(int id) {
            using var connection = new SqliteConnection(ConnectionString);
            connection.Execute(@$"DELETE FROM {TableName} where id = @id", new { id });
        }

        public IEnumerable<ProductModel> GetAll()
        {
            using var connection = new SqliteConnection(ConnectionString);
            return connection.Query<ProductModel>($"SELECT * FROM {TableName} order by id");
        }

        private void CreateTableIfNotExist() {
            using var connection = new SqliteConnection(ConnectionString);
            const string query = $@"CREATE TABLE IF NOT EXISTS {TableName} 
                                   (id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    name TEXT NOT NULL,
                                    receiptdate DATETIME NOT NULL,
                                    quantity INTEGER NOT NULL,
                                    price NUMERIC NOT NULL)";
            var affecter = connection.Execute(query);
        }
    }
}
