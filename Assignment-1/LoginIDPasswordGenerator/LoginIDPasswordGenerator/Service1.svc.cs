using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoginIDPasswordGenerator
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
      
        public string password(string firstName, string lastName, int age)
        {
            string final_password;
            string pass_firstName="";
            int pass_age = age % 5;
            //string pass_lastname = lastName.Substring(0, 2);
            string pass_lastName =!String.IsNullOrWhiteSpace(lastName) && lastName.Length >= 2
                                    ? lastName.Substring(0, 2)
                                    : lastName;
            if (firstName.Length >= 2)
            {
                pass_firstName = firstName.Substring(firstName.Length - 2);
            }
            final_password = pass_lastName + pass_firstName + pass_age;
            return final_password;
        }

        public int loginId(int age)
        {
            Random rnd = new Random();
            int id;
            int val = rnd.Next(100, 200);
            id = age * val;
            return id;
        }

    }
}
