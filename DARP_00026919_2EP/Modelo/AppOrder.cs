using System;

namespace DARP_00026919_2EP
{
    public class AppOrder
    {
        private int idOrder { get; set; }
        private DateTime createDate { get; set; }
        private int idProduct { get; set; }
        private int idAddress { get; set; }

        public AppOrder()
        {
            idOrder = 0;
            createDate = new DateTime(0);
            idProduct = 0;
            idAddress = 0;
        }
    }
}