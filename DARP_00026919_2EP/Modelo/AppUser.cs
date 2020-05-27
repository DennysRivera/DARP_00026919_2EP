namespace DARP_00026919_2EP
{
    public class AppUser
    {
        public int idUser { get; set; }
        public string fullname { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public bool admin { get; set; }
        
        public AppUser()
        {
            idUser = 0;
            fullname = "";
            username = "";
            password = "";
            admin = false;
        }
    }
}