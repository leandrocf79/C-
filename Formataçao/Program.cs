namespace formatar
{
    class formatacao
    {
        static void Main()
        {
            double x = 20.232;
            Console.WriteLine(x);
            Console.WriteLine(x.ToString("F1"));
            Console.WriteLine(x.ToString("C"));
            Console.WriteLine(x.ToString("P"));
        }
    }
}