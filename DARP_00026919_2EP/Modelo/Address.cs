namespace DARP_00026919_2EP
{
    public class Address
    {
        private int idAddress { get; set; }
        private int idUser { get; set; }
        private string address { get; set; }

        public Address()
        {
            idAddress = 0;
            idUser = 0;
            address = "";
        }
    }
}