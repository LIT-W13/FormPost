using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication10.Models
{
    public class FurnitureItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }

    public class FurnitureDb
    {
        private string _connectionString;

        public FurnitureDb(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Add(FurnitureItem furnitureItem)
        {
            SqlConnection conn = new SqlConnection(_connectionString);
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Furniture (Name, Color, Price, QuantityInStock) 
            VALUES (@name, @color, @price, @qty)";
            cmd.Parameters.AddWithValue("@name", furnitureItem.Name);
            cmd.Parameters.AddWithValue("@color", furnitureItem.Color);
            cmd.Parameters.AddWithValue("@price", furnitureItem.Price);
            cmd.Parameters.AddWithValue("@qty", furnitureItem.QuantityInStock);
            conn.Open();
            cmd.ExecuteNonQuery();
        }
    }
}