class HaloGeneric { 
    public void SapaUser<T>(T X)
    {
        Console.WriteLine("Halo user: " + X);
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric h = new HaloGeneric();
        string input = Console.ReadLine();
        h.SapaUser<string>(input);
    }
}