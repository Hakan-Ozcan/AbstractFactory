using AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        // Orman dünyası için fabrikayı kullanarak karakter donanımını yaratma
        CharacterStaffFactory forestFactory = new ForestStaffFactory();
        Weapon forestweapon = forestFactory.CreateWeapon();
        Armor forestarmor = forestFactory.CreateArmor();

        Console.WriteLine("Forest world character gear:");
        Console.WriteLine("Weapon: " + forestweapon.Name);
        Console.WriteLine("Armor: " + forestarmor.Name);

        Console.WriteLine();

        // Dağ dünyası için fabrikayı kullanarak karakter donanımını yaratma
        CharacterStaffFactory mountainFactory = new MountainStaffFactory();
        Weapon mountainweapon = mountainFactory.CreateWeapon();
        Armor mountainarmor = mountainFactory.CreateArmor();

        Console.WriteLine("Mountain world character gear:");
        Console.WriteLine("Weapon: " + mountainweapon.Name);
        Console.WriteLine("Armor: " + mountainarmor.Name);
    }
}
