using System;
using System.Collections.Generic;
using System.Data;

namespace DARP_00026919_2EP
{
    public class BusinessQuery
    {
        public static List<Business> getLista()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM BUSINESS");
            List<Business> businessList = new List<Business>();

            foreach (DataRow n in dt.Rows)
            {
                Business bu = new Business();
                bu.idBusiness = Convert.ToInt32(n[0]);
                bu.name = n[1].ToString();
                bu.description = n[2].ToString();

                businessList.Add(bu);
            }

            return businessList;
        }
        
        public static void newBusiness(Business nuevo)
        {
            Connection.ExecuteNonQuery($"INSERT INTO BUSINESS(name, description) " +
                                       $"VALUES('{nuevo.name}'," +
                                       $"'{nuevo.description}')");
        }
        
        public static void deleteBusiness(string name, int idBusiness)
        {
            Connection.ExecuteNonQuery($"DELETE FROM PRODUCT WHERE idUser = {idBusiness}" +
                                       $"DELETE FROM BUSINESS WHERE name = '{name}'");
        }
    }
}