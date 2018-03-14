using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Security.Cryptography;

namespace HotelBlockBookingSystem
{
    class Decoder
    {
        public delegate void encodeDelegate();
        public static event encodeDelegate encoded;

        public static OrderClass Decrypt(String input, string key)
        {
            Byte[] inputArray = Convert.FromBase64String(input);
            TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider();
            tripleDES.Key = UTF8Encoding.UTF8.GetBytes(key);
            tripleDES.Mode = CipherMode.ECB;
            tripleDES.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tripleDES.CreateDecryptor();
            Byte[] resultArray = cTransform.TransformFinalBlock(inputArray, 0, inputArray.Length);
            tripleDES.Clear();
            string result = UTF8Encoding.UTF8.GetString(resultArray);
            string[] res = result.Split(',');
            DateTime od = Convert.ToDateTime(res[5]);
            OrderClass obj = new OrderClass(res[0], Convert.ToInt32(res[1]), res[2], Convert.ToInt32(res[3]), Convert.ToInt32(res[4]), od);
            return obj;
        }
    }
}
