using tpmodul5_1302210024;

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama = "praktikan";
        halo.SapaUser(nama);

        DataGeneric<string> data = new DataGeneric<string>("");

        Console.Write("Masukkan NIM: ");
        string nim = Console.ReadLine();
        data = new DataGeneric<string>(nim);

        data.PrintData();

        Console.ReadKey();
    }
}