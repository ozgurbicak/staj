using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor.Models
{

    internal class Class1
    {
        public Class1()
        {
            CreatedDate = DateTime.Now;
        }
        public Class1(string productName1)
        {
            CreatedDate = DateTime.Now;
            productName = productName1;
        }
    public string productName { get; set; }
    public DateTime CreatedDate { get; set; }


    }
}
