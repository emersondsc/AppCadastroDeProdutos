using Microsoft.Data.SqlClient;
using ProvaExperimentalForms.Entities;
using System.Windows.Forms;


namespace ProvaExperimentalForms.DataBase
{
    internal class ProductDAL
    {
        

        public void AddProduct(Product product)
        {
            using var connection = new Connection().ObtainConnection();
            connection.Open();
            string sql = "INSERT INTO Products (Name, Description, Price, IsAvailableForSale) VALUES (@name, @description, @price, @isAvailableForSale)";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@description", product.Description);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@isAvailableForSale", product.IsAvailableForSale);

            int retorno = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {retorno}");
            connection.Close();
        }

        public void DeleteProduct(int productId)
        {
            using var connection = new Connection().ObtainConnection();
            connection.Open();

            string sql = "DELETE FROM Products WHERE Id = @productId";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@productId", productId);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {rowsAffected}");

            if (rowsAffected == 0)
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public void UpdateProduct(Product product)
        {
            using var connection = new Connection().ObtainConnection();
            connection.Open();

            string sql = "UPDATE Products SET Name = @name, Description = @description, Price = @price, IsAvailableForSale = @isAvailableForSale WHERE Id = @productId";
            SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@productId", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@description", product.Description);
            command.Parameters.AddWithValue("@price", product.Price);
            command.Parameters.AddWithValue("@isAvailableForSale", product.IsAvailableForSale);

            int rowsAffected = command.ExecuteNonQuery();
            Console.WriteLine($"Linhas afetadas: {rowsAffected}");

            if (rowsAffected == 0)
            {
                Console.WriteLine("Produto não encontrado.");
            }
        }

        public List<Product> ListProducts()
        {
            using var connection = new Connection().ObtainConnection();
            connection.Open();

            string sql = "SELECT * FROM Products";
            SqlCommand command = new SqlCommand(sql, connection);

            var products = new List<Product>();
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string description = reader.GetString(2);
                decimal price = reader.GetDecimal(3);
                bool isAvailableForSale = reader.GetBoolean(4);

                products.Add(new Product(name, description, (double)price, isAvailableForSale));
            }

            return products;
        }

        
    }
}
