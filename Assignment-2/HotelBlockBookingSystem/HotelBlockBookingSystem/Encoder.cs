using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Threading;

namespace HotelBlockBookingSystem
{
    class Encoder
    {
        public delegate void encodeDelegate();
        public static event encodeDelegate encoded;

        public static string Encrypt(OrderClass obj, String key)
        {
            string input;
            input = obj.getOrder();
            byte[] inputArray = UTF8Encoding.UTF8.GetBytes(input);
            String result = "";
            try
            {
                TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
                tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
                tripleDES.Mode = CipherMode.ECB;
                tripleDES.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tripleDES.CreateEncryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
                tripleDES.Clear();
                result = Convert.ToBase64String(resultArray, 0, resultArray.Length);
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
            }
            return result;
        }
    }
}
