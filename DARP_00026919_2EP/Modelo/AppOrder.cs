using System;

namespace DARP_00026919_2EP
{
    public class AppOrder
    {
        public int idOrder { get; set; }
        public DateTime createDate { get; set; }
        public int idProduct { get; set; }
        public int idAddress { get; set; }

        public AppOrder()
        {
            idOrder = 0;
            createDate = new DateTime(0);
            idProduct = 0;
            idAddress = 0;
        }
    }
}