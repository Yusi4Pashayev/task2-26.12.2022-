namespace task2_26._12._2022_
{
    internal class Program
    {
        static void Main(string[] args)
       
        {
            //2.Rəqəmlər və sıra nömrələri
            //Daxil edilən ədədin rəqəmləri və onların sıra nömrələrinə olan hasilinin cəmini hesablayan proqram 
            //Giriş:
            //2345
            //Çıxış: 40
            //Izahi: 1 * 2 + 3 * 2 + 3 * 4 + 4 * 5 =
            //40

            int sum = 0,b,c=0;
            Console.Write("Eded daxil edin:");
            int a=int.Parse(Console.ReadLine());


            for (int i = 10; i >0 ; i=i*10)
            {
                b = a / i;
                if (b >= 10) ;
                else
                {
                    for (int j = i; j >1 ; j=j/10)
                    {
                        c++;
                        b = a / j;
                        b = b % 10;
                        sum = sum + b * c;
                    }
                    c++;
                    sum = sum + (a % 10) * c;
                    Console.WriteLine(sum);
                    break;
                }
                
                
            }

        }
    }
}