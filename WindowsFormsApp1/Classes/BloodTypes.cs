using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Classes
{
    public enum Rhfaktörü
    {
        RhNegatif,
        RhPozitif,
    }
    public enum KanGrubu
    {
        AB,
        A,
        B,
        O,
    }
    public class BloodType
    {
        private List<BloodType> bloodTypes;
        private List<BloodType> BloodTypes
        {
            get
            {
                if (bloodTypes==null)
                {
                    bloodTypes = new List<BloodType>();
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhPozitif, KanGrubu.A));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhNegatif, KanGrubu.A));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhPozitif, KanGrubu.AB));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhNegatif, KanGrubu.AB));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhPozitif, KanGrubu.B));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhNegatif, KanGrubu.B));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhPozitif, KanGrubu.O));
                    bloodTypes.Add(new BloodType(Rhfaktörü.RhPozitif, KanGrubu.O));
                }
                return bloodTypes;
            }
        }
        public KanGrubu KanGrubu { get; set; }
        public Rhfaktörü Rhfaktörü { get; set; }
        public BloodType(Rhfaktörü rhfaktörü,KanGrubu kanGrubu)
        {
            this.Rhfaktörü = rhfaktörü;
            this.KanGrubu = kanGrubu;
        }
        public List<BloodType> GetAvaliableBloodTypes()
        {
            switch (Rhfaktörü)
            {
                case Rhfaktörü.RhNegatif:
                    BloodTypes.RemoveAll(x => x.Rhfaktörü == Rhfaktörü.RhPozitif);
                    break;
                case Rhfaktörü.RhPozitif:
                    break;
                default:
                    break;
            }
            switch (KanGrubu)
            {
                case KanGrubu.AB:
                    break;
                case KanGrubu.A:
                    BloodTypes.RemoveAll(x => x.KanGrubu == KanGrubu.B || x.KanGrubu == KanGrubu.AB);
                    break;
                case KanGrubu.B:
                    BloodTypes.RemoveAll(x => x.KanGrubu == KanGrubu.A || x.KanGrubu == KanGrubu.AB);
                    break;
                case KanGrubu.O:
                    BloodTypes.RemoveAll(x => x.KanGrubu!=KanGrubu.O);
                    break;
                default:
                    break;
            }
            return BloodTypes;
        }
    }
}
