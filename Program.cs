namespace ConsoleProgram;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        int x=20;

        string xString = x.ToString();

        Console.WriteLine("X'in string değeri: " + xString);

        string s="100";
        x = Convert.ToInt32(s);

        Console.WriteLine ("X'in yeni değeri: " + x);

        DateTime tarih= DateTime.Now;
        Console.WriteLine ("Mevcut tarih: "+ tarih.ToString());

    }
}
