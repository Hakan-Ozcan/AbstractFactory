using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
  

    // Orman dünyası için silah sınıfı
    public class OrmanSilahi : Silah
    {
        public override string Ad => "Orman Silahı";
    }

    // Orman dünyası için zırh sınıfı
    public class OrmanZirhi : Zirh
    {
        public override string Ad => "Orman Zırhı";
    }

    // Dağ dünyası için silah sınıfı
    public class DagSilahi : Silah
    {
        public override string Ad => "Dağ Silahı";
    }

    // Dağ dünyası için zırh sınıfı
    public class DagZirhi : Zirh
    {
        public override string Ad => "Dağ Zırhı";
    }

}
