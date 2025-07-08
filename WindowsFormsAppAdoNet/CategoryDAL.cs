using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppAdoNet
{
    public class CategoryDAL
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=ProjeGelistirmeDB; Integrated security=True");
        void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public DataTable GetDataTable()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Categories", _connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }
        public void Add(Category category)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Categories values (@Name)", _connection);
            command.Parameters.AddWithValue("@Name", category.CategoryName);
            command.ExecuteNonQuery();
            _connection.Close();
        }
        public void Delete(int Id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("delete from Categories where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", Id);
            command.ExecuteNonQuery();
            _connection.Close();

        }
        public void Update(Category category)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("update Categories set CategoryName=@Name where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", category.Id);
            command.Parameters.AddWithValue("@Name", category.CategoryName);
            
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
