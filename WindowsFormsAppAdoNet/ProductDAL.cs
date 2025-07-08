using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Security.AccessControl;

namespace WindowsFormsAppAdoNet
{
    public class ProductDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=ProjeGelistirmeDB; Integrated security=True");
        void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Products values (@Name,@Price,@Stock)", _connection);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update Products set Product_Name=@Name,Product_Price=@Price,Product_Stock=@Stock where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.Parameters.AddWithValue("@Name", product.Name);
            command.Parameters.AddWithValue("@Price", product.Price);
            command.Parameters.AddWithValue("@Stock", product.Stock);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("delete from Products where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public List<Product> GetProducts()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Product_Name"].ToString(),
                    Price = Convert.ToDecimal(reader["Product_Price"]),
                    Stock = Convert.ToInt32(reader["Product_Stock"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }
        public DataTable GetDataTable() 
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
    }
}
