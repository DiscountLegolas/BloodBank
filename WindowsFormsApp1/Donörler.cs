using BloodBank.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Donörler
    {
        private static List<DtN> bilgilendirilecekdonörler;
        public static List<DtN> BilgilendirilecekDonörler
        {
            get
            {
                if (bilgilendirilecekdonörler==null)
                {
                    bilgilendirilecekdonörler = new List<DtN>();
                }
                return bilgilendirilecekdonörler;
            }
        }
        private static List<Donör> normaldonörler;
        public static List<Donör> NormalDonörler
        {
            get
            {
                if (normaldonörler==null)
                {
                    normaldonörler = new List<Donör>();
                }
                return normaldonörler;
            }
        }
    }
}
