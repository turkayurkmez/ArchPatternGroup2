using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleResponsibility
{
    public class ProductService
    {
        public int AddProduct(string name, decimal price)
        {
            var connection = "Data Source=(localdb)\\Mssqllocaldb;Initial Catalog=Northwind;Integrated Security=True";
            var commandText = "Insert into Products (ProductName, Unitprice) values (@name,@price)";

            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);
            
            var rowCount = new DbHelper(connection).ExecuteCommand(commandText, parameters);
            

            return rowCount;
        }
    }
}
