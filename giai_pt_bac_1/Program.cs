internal class Program
{
    private static void Main(string[] args)
    {
        float a,b;
        float x;
        Console.WriteLine("nhap gia tri a va b");
        a = float.Parse(Console.ReadLine());
        b = float.Parse(Console.ReadLine());
        if(a!=0)
        {
            Console.WriteLine("vay x = "+ -b/a);
        }else
        {
            if(b==0)
            {
                Console.WriteLine("phuong trinh vo so nghiem");
            }else
            {
                Console.WriteLine("phuong trinh vo nghiem");
            }
        }
}
}