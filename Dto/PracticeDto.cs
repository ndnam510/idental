using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using idental.Const;
namespace idental
{
    class PracticeDto
    {
        public string PracticeName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string BankAccount { get; set; }

        public string CustomerID { get; set; }
        
        public Int64 ZipCodeID { get; set; }
        
        public string PhotoLink { get; set; }
    }
}
