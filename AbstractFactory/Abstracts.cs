using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Silah sınıfı
    public abstract class Weapon
    {
        public abstract string Name { get; }
    }

    // Zırh sınıfı
    public abstract class Armor
    {
        public abstract string Name { get; }
    }
}
