using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Classes
{
    public class Hastane
    {
        public string İsim { get; set; }
        public İlçeler İlçe { get; set; }
        public Hastane(string name,İlçeler ilçe)
        {
            this.İlçe = ilçe;
            this.İsim = name;
        }
    }
}
