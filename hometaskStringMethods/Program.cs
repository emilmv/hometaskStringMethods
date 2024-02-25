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

            #region Task2


            //string word = "!?Necesen!!!!!!!?";
            
            //Console.WriteLine(sumOfSymbols(word,alphabet));


            #endregion

            #region Task3

            string word = "salam necesen salam necesen";

            Console.WriteLine(sumOfSymbols(word));


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

        static int sumOfSymbols(string word)
        {
            word = word.ToLower();

            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            int count = 0;

            foreach (char c in word)
            {
                if (alphabet.Contains(c))
                {
                    count++;
                }
            }
            count=word.Length - count;
            return count;
        }

        static int sumOfWords(string word)
        {
            int wordCount = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsWhiteSpace(word[i]))
                {
                    wordCount++;
                }
                if(i == word.Length-1)
                {
                    wordCount++;
                }
            }
            


            return wordCount;
        }

    }
}
