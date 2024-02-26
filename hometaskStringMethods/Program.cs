namespace hometaskStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //correctFormat:
            //Console.WriteLine("Calculator:");
            //Console.WriteLine("==============");
            //Console.WriteLine("Ilk ededi daxil edin:");
            //bool isNumber=double.TryParse(Console.ReadLine(),out double num);
            //if (!isNumber)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    Console.WriteLine("=======================");
            //    goto correctFormat;
            //}

            //Console.WriteLine("========================");
            //Console.WriteLine("Ikinci ededi daxil edin:");
            //if (!isNumber)
            //{
            //    Console.WriteLine("Duzgun eded daxil edin");
            //    Console.WriteLine("=======================");
            //    goto correctFormat;
            //}
            //bool isNumber2=double.TryParse(Console.ReadLine(),out double num2);

            //Console.WriteLine("=========================");
            //Console.WriteLine("Icra etmek istediyiniz emeliyyatin simvolunu daxil edin:");
            //char symbol=Convert.ToChar(Console.ReadLine());



            //calculator(num, num2, symbol);
            #endregion


        }
        static void calculator(double num, double num2, char symbol)
        {
            switch (symbol)
            {
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cavab: 0-a bolmek mumkun deyil");
                        break;
                    }
                    else
                        Console.WriteLine("Cavab: " + num / num2);
                    break;
                case '*':
                    Console.WriteLine("Cavab: " + num * num2);
                    break;
                case '+':
                    Console.WriteLine("Cavab: " + (num + num2));
                    break;
                case '-':
                    Console.WriteLine("Cavab: " + (num - num2));
                    break;
                default:
                    Console.WriteLine("Duzgun simvol daxil edin");                  
                    break;

            }
        }



    }
}
