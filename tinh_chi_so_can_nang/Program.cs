internal class Program
{
    private static void Main(string[] args)
    {
        float a;
        float b;
        Console.WriteLine("nhap can nang va chieu cao cua ban : ");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        double x = a/Math.Pow(b,2);
        x = Math.Round(x,1);
        Console.WriteLine(""+x);
        if(x<18)
        {
            Console.WriteLine("thieu can");
        }else if(x<25)
        {
            Console.WriteLine("binh thuong");
        }else if(x<30)
        {
            Console.WriteLine("thua can");
        }else
        {
            Console.WriteLine("beo phi");
        }
}
}