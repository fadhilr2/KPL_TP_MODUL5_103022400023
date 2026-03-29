class DataGeneric<T>
{
    private T data;

    public DataGeneric(T d){
        this.data = d;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + data);
    }

}


class Program
{
    public static void Main(String[] args)
    {
        Console.Write("Masukkan NIM: ");
        string input = Console.ReadLine();
        DataGeneric<string> dataGeneric = new DataGeneric<string>(input);

        dataGeneric.PrintData();
    }
}