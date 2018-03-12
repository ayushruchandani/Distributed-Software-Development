using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginIDPasswordGeneratorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            myServiceRef.Service1Client proxy= new myServiceRef.Service1Client();

            int age, id;
            string firstName, lastName, pass;
            Console.WriteLine("Please Enter your first name");
            firstName = Console.ReadLine();
            Console.WriteLine("Please Enter your last name");
            lastName = Console.ReadLine();
            Console.WriteLine("Please Enter your age");
            age = int.Parse(Console.ReadLine());
            pass = proxy.password(firstName, lastName, age);
            id = proxy.loginId(age);

            Console.WriteLine("Your LoginID is " + id + " and your password is " + pass);
            Console.ReadKey();
        }
    }
}
