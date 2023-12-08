internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        switch(n)
        {
            case 2 : Console.WriteLine("thu 2");
            break;
            case 3 : Console.WriteLine("thu 3");
            break;
            case 4 : Console.WriteLine("thu 4");
            break;
            case 5 : Console.WriteLine("thu 5");
            break;
            case 6 : Console.WriteLine("thu 6");
            break;
            case 7 : Console.WriteLine("thu 7");
            break;
            case 8 : Console.WriteLine("CN");
            break;
            default : Console.WriteLine("ban nhap khong chinh xac");
            break;
        }
}
}