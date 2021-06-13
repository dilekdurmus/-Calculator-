using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            bool flagForClosingApp = false;

            Console.WriteLine("****************** HESAP MAKİNESİ ********************");

            do
            {
                string input;
                int firstNo, secondNo;
            firstNumber:
                Console.Write("İlk sayısal değeri girin ve enter tuşuna tıklayın: ");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out firstNo))
                {
                    Console.WriteLine("\nNumara giriniz...\n");
                    goto firstNumber;
                }

            trans:
                Console.Write("\nİşlem girin ve enter tuşuna tıklayın: ");
                string transaction = Console.ReadLine();
                if (transaction != "+" && transaction != "-" && transaction != "*" && transaction != "/")
                {
                    Console.WriteLine("\nLütfen ( + - * / ) değerlerinden birini giriniz");
                    goto trans;
                }

            secondNumber:
                Console.Write("\nİkinci sayısal değeri girin ve enter tuşuna tıklayın: ");
                input = Console.ReadLine();
                if (!Int32.TryParse(input, out secondNo))
                {
                    Console.WriteLine("\nNumara giriniz...");
                    goto secondNumber;
                }

                switch (transaction)
                {
                    case "+":
                        result = Operation.Pluses(firstNo, secondNo);
                        break;
                    case "-":
                        result = Operation.Minuses(firstNo, secondNo);
                        break;
                    case "*":
                        result = Operation.Multiplys(firstNo, secondNo);
                        break;
                    case "/":
                        if (secondNo == 0)
                        {
                            Console.WriteLine("\nSayı sıfıra bölünmez, sıfır dışında bir sayı giriniz.");
                            goto secondNumber;
                        }
                        result = Operation.Divides(firstNo, secondNo);
                        break;
                    default:
                        Console.WriteLine("Doğru değer giriniz.");
                        break;
                }
                Console.WriteLine($"\nSonuç {firstNo} {transaction} {secondNo} = {result}");
            loop:
                Console.WriteLine("\nDevam etmek istiyorsanız 'e', istemiyorsanız 'h' tıklayın ve entera tıklayın.");
                string eh = Console.ReadLine().ToLower();

                if (eh == "e")
                {
                    flagForClosingApp = true;
                }
                else if (eh == "h")
                {
                    flagForClosingApp = false;
                }
                else
                {
                    Console.WriteLine("\nLütfen doğru değerleri giriniz.");
                    goto loop;
                }

                if (flagForClosingApp)
                    Console.Clear();

            } while (flagForClosingApp);
        }
    }
}
