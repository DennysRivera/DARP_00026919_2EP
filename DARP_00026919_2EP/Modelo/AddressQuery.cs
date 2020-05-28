using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DARP_00026919_2EP
{
    public static class AddressQuery
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
        
        public static void newAddress(string address, int idUser)
        {
            Connection.ExecuteNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                       $"VALUES({idUser}," +
                                       $" '{address}')");
        }
        
        public static void deleteAddress(int idAddress)
        {
            Connection.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE address = {idAddress}");
        }
        
        public static void updateAddress(string address, int idAddress)
        {
            Connection.ExecuteNonQuery($"UPDATE ADDRESS SET address = '{address}'" +
                                       $"WHERE idAddress = {idAddress}");
        }
    }
}