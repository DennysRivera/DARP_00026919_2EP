using System;
using System.Collections.Generic;
using System.Data;

namespace DARP_00026919_2EP
{
    public class AddressQuery
    {
        public static List<Address> getLista()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM ADDRESS");
            List<Address> addressList = new List<Address>();

            foreach (DataRow n in dt.Rows)
            {
                Address ad = new Address();
                ad.idAddress = Convert.ToInt32(n[0]);
                ad.idUser = Convert.ToInt32(n[1]);
                ad.address = n[2].ToString();

                addressList.Add(ad);
            }

            return addressList;    
        }
        
        public static void newAddress(Address nuevo)
        {
            Connection.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                       $"VALUES({nuevo.idUser}," +
                                       $" '{nuevo.address}')");
        }
        
        public static void deleteAddress(string address, int idAddress)
        {
            Connection.ExecuteNonQuery($"DELETE FROM APPORDER WHERE idAddress = {idAddress}" +
                                       $"DELETE FROM ADDRESS WHERE address = '{address}'");
        }
        
        public static void updateAddress(string address, string idAddress)
        {
            Connection.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{address}'" +
                                       $"WHERE idAddress = {idAddress}");
        }
    }
}