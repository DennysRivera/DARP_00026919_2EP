using System;
using System.Collections.Generic;
using System.Data;

namespace DARP_00026919_2EP
{
    public class ProductQuery
    {
        public static List<Product> getLista()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM PRODUCT");
            List<Product> productList = new List<Product>();

            foreach (DataRow n in dt.Rows)
            {
                Product pr = new Product();
                pr.idProduct = Convert.ToInt32(n[0]);
                pr.idBusiness = Convert.ToInt32(n[1].ToString());
                pr.name = n[2].ToString();

                productList.Add(pr);
            }

            return productList;    
        }
        
        public static void newProduct(int idBusiness, string name)
        {
            Connection.ExecuteNonQuery($"INSERT INTO PRODUCT(idBusiness, name) " +
                                       $"VALUES({idBusiness}," +
                                       $" '{name}')");
        }
        
        public static void deleteProduct(int idProduct)
        {
            Connection.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idProduct = {idProduct}");
        }
        
    }
}