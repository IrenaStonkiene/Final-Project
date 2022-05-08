using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Final_Project
{
    internal class Database
    {
        private static string _connString =
            @$"Server=localhost;Database=OptimalNutrition;Trusted_Connection=True; User Id=NutritionUser;Password=000";

        public List<Product> GetProducts()
        {
            try
            {
                using var connection = new SqlConnection(_connString);
                connection.Open();

                using var command = new SqlCommand("SELECT * FROM Products", connection);

                var products = new List<Product>();

                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var product = new Product
                    {
                        ID = (int)reader["id"],
                        Name = (string)reader["Product"],
                        VitaminAQuantity = Convert.ToDouble(reader["VitaminA"]),
                        VitaminB1Quantity = Convert.ToDouble(reader["VitaminB1"]),
                        VitaminB2Quantity = Convert.ToDouble(reader["VitaminB2"]),
                        VitaminB3Quantity = Convert.ToDouble(reader["VitaminB3"]),
                        VitaminB5Quantity = Convert.ToDouble(reader["VitaminB5"]),
                        VitaminB6Quantity = Convert.ToDouble(reader["VitaminB6"]),
                        VitaminB7Quantity = Convert.ToDouble(reader["VitaminB7"]),
                        VitaminB12Quantity = Convert.ToDouble(reader["VitaminB12"]),
                        VitaminDQuantity = Convert.ToDouble(reader["VitaminD"]),
                        VitaminCQuantity = Convert.ToDouble(reader["VitaminC"]),
                        VitaminEQuantity = Convert.ToDouble(reader["VitaminE"]),
                    };
                    
                    products.Add(product);
                }

                return products;
            }
            catch (Exception ex)
            {
                return new List<Product>();
            }
        }
    }
}
