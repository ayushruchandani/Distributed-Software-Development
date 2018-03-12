using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Please Enter the input string:");

            // read a string for analysis
            str = Console.ReadLine();

            DigitCountThread dc = new DigitCountThread(str);
            UpperCountThread uc = new UpperCountThread(str);
            IsPalindromeThread ip = new IsPalindromeThread(str);

            // create threads
            Thread t_dc = new Thread(dc.runDigitCountThread);
            Thread t_uc = new Thread(uc.runUpperCountThread);
            Thread t_ip = new Thread(ip.runIsPalindromeThread);

            // start each thread
            t_dc.Start();
            t_uc.Start();
            t_ip.Start();

            // wait until all the threads are done
            t_dc.Join();
            t_uc.Join();
            t_ip.Join();
            int digitCount = dc.digitCount();
            int upperCount = uc.getUpperCount();
            bool isPal = ip.isPalindrome();

            // Display the string analysis results
            Console.WriteLine("Number of digits=" + digitCount);
            Console.WriteLine("Number of Upper Count=" + upperCount);
            Console.WriteLine("Palindrome String?:" + isPal);
            Console.ReadKey();
        }
    }

   
}
