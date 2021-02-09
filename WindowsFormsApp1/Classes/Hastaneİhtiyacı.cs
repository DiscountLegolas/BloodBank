using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace BloodBank.Classes
{
    interface Observable
    {
        void AddObserver(Observer observer);
        void NotifyObservers();
    }
    public class Acilİhtiyaç : Observable
    {
        public Hastane Hastane { get; set; }
        public BloodType BloodType { get; set; }
        public Acilİhtiyaç(BloodType bloodType,Hastane hastane)
        {
            this.Hastane = hastane;
            this.BloodType = bloodType;
            Observers = new List<Observer>();
            Donörler.BilgilendirilecekDonörler.Where(x => x.İlçe == Hastane.İlçe && bloodType.GetAvaliableBloodTypes().Any(p => p.KanGrubu == x.BloodType.KanGrubu && p.Rhfaktörü == x.BloodType.Rhfaktörü)).ToList().ForEach(t => AddObserver(t));
        }
        private List<Observer> Observers { get; set; }
        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }
        public void NotifyObservers()
        {
            foreach (var item in Observers)
            {
                item.Notify(Hastane.İsim);
            }
        }
    }
}
