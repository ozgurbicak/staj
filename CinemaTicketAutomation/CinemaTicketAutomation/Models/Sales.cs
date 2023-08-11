using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Models
{
    public class Sales: BaseClass
    {
        public Sales() {
            creationDate = DateTime.Now.ToString();
        }
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; } 
        public int count { get; set; }  
        public string SessionTime { get; set; }

        public override string ToString()
        {
            return $"{movieName} adlı filmin {SessionTime} seansına {count} adet bilet kesilmiştir. \n Toplam tutar = {totalPrice} TL | \n Satın alınma tarihi = {creationDate}";
        }
    }
}
