using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    class Utils
    {
        public static DataTable Select(string query_string, SqlConnection sql)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(query_string, sql))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static DataTable Select(string query_string, List<SqlParameter> parameters, SqlConnection sql)
        {
            DataTable dataTable = new DataTable();
            using (SqlCommand command = new SqlCommand(query_string, sql))
            {
                command.Parameters.AddRange(parameters.ToArray());
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        public static IEnumerable<T> ExcuteObject<T>(string query_string, SqlConnection sql)
        {
            List<T> items = new List<T>();
            var dataTable = Select(query_string, sql); //this will use the DataTable Select function
            foreach (var row in dataTable.Rows)
            {
                T item = (T)Activator.CreateInstance(typeof(T), row);
                items.Add(item);
            }
            return items;
        }

        public static IEnumerable<T> ExcuteObject<T>(string query_string, List<SqlParameter> parameters, SqlConnection sql)
        {
            List<T> items = new List<T>();
            var dataTable = Select(query_string, parameters, sql); //this will use the DataTable Select function
            foreach (var row in dataTable.Rows)
            {
                T item = (T)Activator.CreateInstance(typeof(T), row);
                items.Add(item);
            }
            return items;
        }
    }
}
