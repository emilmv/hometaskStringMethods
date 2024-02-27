using System.Text;
using System.Threading.Channels;

namespace hometaskStringMethods;

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

        //string word = "salam necesen emil  salam necesen";

        //sumOfWords(word);


        #endregion

        #region Task4

        //int num = 12345;
        //Console.WriteLine(sumOfDigits(num));

        #endregion

        #region Task5

        //double num = -2;
        //double power = 3;
        //Console.WriteLine(powerOfDigit(num, power));

        #endregion

        #region Task6

        //int[] arr = { 1, -4, 9, -8 };

        //convertToPos(ref arr);




        #endregion

        #region Task7

        //string word = "salam";
        //Console.WriteLine(reverseString(word));

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
        count = word.Length - count;
        return count;
    }

    static void sumOfWords(string word)
    {
        char[] separators = { ' ', '.', ',', '!', '?' };
        word.Trim();
        int count = 1;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == ' ' && word[i + 1] != ' ')
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }

    static int sumOfDigits(int num)
    {
        int sum = 0;
        string num2 = Convert.ToString(num);
        for (int i = 0;i<num2.Length;i++)
        {
            sum = sum + int.Parse(num2[i].ToString());
        }
        return sum;
    }

    static double powerOfDigit(double num, double power)
    {
        double result = Math.Pow(num, power);
        return result;
    }

    static void convertToPos(ref int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                arr[i] = -arr[i];
            }
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

    }
    
    static StringBuilder reverseString(string word)
    {
        StringBuilder result= new StringBuilder();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            result.Append(word[i]);
        }
        return result;
    }
}
