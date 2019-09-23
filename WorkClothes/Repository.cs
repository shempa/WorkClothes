using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WorkClothes
{
    class Repository:IRepository
    {
        string cs = ConfigurationManager.ConnectionStrings["BDConnection"].ConnectionString;
        public List<ClothesModels> GetClothes()
        {            
            string sqlExpression = "GetClothes";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    List<ClothesModels> clothes = new List<ClothesModels>() { };
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                        while (reader.Read())
                        {
                            ClothesModels clothe = new ClothesModels();
                            clothe.id = Convert.ToInt32(reader["id"]);
                            clothe.name = reader["name"].ToString();
                            clothe.size = Convert.ToInt32(reader["size"]);
                            clothe.quantity = Convert.ToInt32(reader["quantity"]);
                            clothe.ToString();
                            clothes.Add(clothe);
                        }
                    }
                    reader.Close();
                    return clothes;
                }
            }
        }

        public List<ClothesModels> ThisClothes(string This)
        {
            string sqlExpression = "ThisClothes";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter ThisParam = new SqlParameter
                    {
                        ParameterName = "@This",
                        Value = This
                    };
                    command.Parameters.Add(ThisParam);                   
                    List<ClothesModels> clothes = new List<ClothesModels>() { };
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                        while (reader.Read())
                        {
                            ClothesModels clothe = new ClothesModels();
                            clothe.id = Convert.ToInt32(reader["id"]);
                            clothe.name = reader["name"].ToString();
                            clothe.size = Convert.ToInt32(reader["size"]);
                            clothe.quantity = Convert.ToInt32(reader["quantity"]);
                            clothe.ToString();
                            clothes.Add(clothe);
                        }
                    }
                    reader.Close();
                    return clothes;
                }
            }
        }

        public List<ClothesModels> SortFieldClothes(string SortField)
        {
            string sqlExpression = "SortFieldClothes";
            using (SqlConnection connection = new SqlConnection(cs))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlExpression, connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter SortFieldParam = new SqlParameter
                    {
                        ParameterName = "@SortField",
                        Value = SortField
                    };
                    command.Parameters.Add(SortFieldParam);
                    List<ClothesModels> clothes = new List<ClothesModels>() { };
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}\t{3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                        while (reader.Read())
                        {
                            ClothesModels clothe = new ClothesModels();
                            clothe.id = Convert.ToInt32(reader["id"]);
                            clothe.name = reader["name"].ToString();
                            clothe.size = Convert.ToInt32(reader["size"]);
                            clothe.quantity = Convert.ToInt32(reader["quantity"]);
                            clothe.ToString();
                            clothes.Add(clothe);
                        }
                    }
                    reader.Close();
                    return clothes;
                }
            }
        }

    }
}
