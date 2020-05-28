using System;
using System.Collections.Generic;
using System.Data;

namespace DARP_00026919_2EP
{
    public static class AppOrderQuery
    {
        public static List<AppOrder> getLista()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM APPORDER");
            List<AppOrder> orderList = new List<AppOrder>();

            foreach (DataRow n in dt.Rows)
            {
                AppOrder ao = new AppOrder();
                ao.idOrder = Convert.ToInt32(n[0]);
                ao.createDate = Convert.ToDateTime(n[1].ToString());
                ao.idProduct = Convert.ToInt32(n[2]);
                ao.idAddress = Convert.ToInt32(n[3]);

                orderList.Add(ao);
            }

            return orderList;    
        }
        
        public static void newOrder(DateTime createDate, int idProduct, int idAddress)
        {
            Connection.ExecuteNonQuery($"INSERT INTO APPORDER(createDate, idProduct, idAddress) " +
                                       $"VALUES({createDate}," +
                                       $"{idProduct}," +
                                       $"{idAddress})");
        }
        
        public static void deleteOrder(int idOrder)
        {
            Connection.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idOrder = {idOrder}");
        }
    }
}