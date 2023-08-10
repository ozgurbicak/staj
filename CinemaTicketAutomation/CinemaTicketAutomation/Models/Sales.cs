using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Models
{
    public class Sales: BaseClass
    {
        public string creationDate { get; set; }
        public decimal totalPrice { get; set; } 
        public int count { get; set; }  
        public string SessionTime { get; set; }
    }
}
