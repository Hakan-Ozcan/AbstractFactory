using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Abstract Factory sınıfı
    public abstract class KarakterDonanimFabrikasi
    {
        public abstract Silah OlusturSilah();
        public abstract Zirh OlusturZirh();
    }

    // Orman dünyası için fabrika sınıfı
    public class OrmanDonanimFabrikasi : KarakterDonanimFabrikasi
    {
        public override Silah OlusturSilah()
        {
            return new OrmanSilahi();
        }

        public override Zirh OlusturZirh()
        {
            return new OrmanZirhi();
        }
    }

    // Dağ dünyası için fabrika sınıfı
    public class DagDonanimFabrikasi : KarakterDonanimFabrikasi
    {
        public override Silah OlusturSilah()
        {
            return new DagSilahi();
        }

        public override Zirh OlusturZirh()
        {
            return new DagZirhi();
        }
    }

}
