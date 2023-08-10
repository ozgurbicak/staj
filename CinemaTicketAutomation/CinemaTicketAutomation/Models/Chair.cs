using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketAutomation.Models
{
    public class Chair
    {
        public Chair(string _row,string _number) {
            row = _row;
            number = _number;

        }
        public string row { get; set; }
        public string number { get; set; }
        public bool   status { get; set; }  
    }
}
