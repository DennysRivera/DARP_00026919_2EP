namespace DARP_00026919_2EP
{
    public class Product
    {
        public int idProduct { get; set; }
        public int idBusiness { get; set; }
        public string name { get; set; }

        public Product()
        {
            idProduct = 0;
            idBusiness = 0;
            name = "";
        }
    }
}