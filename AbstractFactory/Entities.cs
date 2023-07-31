using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
  

    // Orman dünyası için silah sınıfı
    public class ForestWeapon : Weapon
    {
        public override string Name => "Forest Weapon";
    }

    // Orman dünyası için zırh sınıfı
    public class ForestArmor : Armor
    {
        public override string Name => "Forest Armor";
    }

    // Dağ dünyası için silah sınıfı
    public class MountainWeapon : Weapon
    {
        public override string Name => "Mountain Weapon";
    }

    // Dağ dünyası için zırh sınıfı
    public class MountainArmor : Armor
    {
        public override string Name => "Mountain Armor";
    }

}
