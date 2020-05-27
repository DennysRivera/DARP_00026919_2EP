using System;
using System.Collections.Generic;
using System.Data;

namespace DARP_00026919_2EP
{
    public class AppUserQuery
    {
        public static List<AppUser> getLista()
        {
            var dt = Connection.ExecuteQuery($"SELECT * FROM APPUSER");
            List<AppUser> userList = new List<AppUser>();

            foreach (DataRow n in dt.Rows)
            {
                AppUser au = new AppUser();
                au.idUser = Convert.ToInt32(n[0]);
                au.fullname = n[1].ToString();
                au.username = n[2].ToString();
                au.password = n[3].ToString();
                au.admin = Convert.ToBoolean(n[4].ToString());
                
                userList.Add(au);
            }

            return userList;    
        }
        
        public static void newUser(AppUser nuevo)
        {
            Connection.ExecuteNonQuery($"INSERT INTO USUARIO(fullname, username, password, userType) " +
                                     $"VALUES('{nuevo.fullname}'," +
                                     $" '{nuevo.username}'," +
                                     $"'{nuevo.password}'," +
                                     $"{nuevo.admin})");
        }
        
        public static void deleteUser(string userName, int idUser)
        {
            Connection.ExecuteNonQuery($"DELETE FROM ADDRESS WHERE idUser = {idUser}" +
                                     $"DELETE FROM APPUSER WHERE username = '{userName}'");
        }
        
        public static void updatePass(string username, string newPass)
        {
            Connection.ExecuteNonQuery($"UPDATE APPUSER SET password = '{newPass}'" +
                                       $"WHERE username = '{username}'");
        }
    }
}