using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    // Abstract Factory sınıfı
    public abstract class CharacterStaffFactory
    {
        public abstract Weapon CreateWeapon();
        public abstract Armor CreateArmor();
    }

    // Orman dünyası için fabrika sınıfı
    public class ForestStaffFactory : CharacterStaffFactory
    {
        public override Weapon CreateWeapon()
        {
            return new ForestWeapon();
        }

        public override Armor CreateArmor()
        {
            return new ForestArmor();
        }
    }

    // Dağ dünyası için fabrika sınıfı
    public class MountainStaffFactory : CharacterStaffFactory
    {
        public override Weapon CreateWeapon()
        {
            return new MountainWeapon();
        }

        public override Armor CreateArmor()
        {
            return new MountainArmor();
        }
    }

}
