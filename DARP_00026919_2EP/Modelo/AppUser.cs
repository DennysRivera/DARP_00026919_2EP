namespace DARP_00026919_2EP
{
    public class AppUser
    {
        private int idUser { get; set; }
        private string fullname { get; set; }
        private string username { get; set; }
        private string password { get; set; }
        private bool admin { get; set; }
        
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