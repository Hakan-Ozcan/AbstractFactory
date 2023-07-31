using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Silah sınıfı
    public abstract class Silah
    {
        public abstract string Ad { get; }
    }

    // Zırh sınıfı
    public abstract class Zirh
    {
        public abstract string Ad { get; }
    }
}
