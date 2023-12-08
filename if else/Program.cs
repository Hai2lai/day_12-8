internal class Program
{
    private static void Main(string[] args)
    {
        int n;
        n = int.Parse(Console.ReadLine());
        if(n>0)
        {
            Console.WriteLine("so duong");
        }else if(n<0)
        {
            Console.WriteLine("so am");
        }else
        {
            Console.WriteLine("so 0");
        }
}
}