using AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        // Orman dünyası için fabrikayı kullanarak karakter donanımını yaratma
        KarakterDonanimFabrikasi ormanFabrikasi = new OrmanDonanimFabrikasi();
        Silah ormanSilahi = ormanFabrikasi.OlusturSilah();
        Zirh ormanZirhi = ormanFabrikasi.OlusturZirh();

        Console.WriteLine("Orman dünyası karakter donanımı:");
        Console.WriteLine("Silah: " + ormanSilahi.Ad);
        Console.WriteLine("Zırh: " + ormanZirhi.Ad);

        Console.WriteLine();

        // Dağ dünyası için fabrikayı kullanarak karakter donanımını yaratma
        KarakterDonanimFabrikasi dagFabrikasi = new DagDonanimFabrikasi();
        Silah dagSilahi = dagFabrikasi.OlusturSilah();
        Zirh dagZirhi = dagFabrikasi.OlusturZirh();

        Console.WriteLine("Dağ dünyası karakter donanımı:");
        Console.WriteLine("Silah: " + dagSilahi.Ad);
        Console.WriteLine("Zırh: " + dagZirhi.Ad);
    }
}
