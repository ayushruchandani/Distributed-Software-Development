using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class UpperCountThread
    {
        public String str;
        public int upperCount;

        public UpperCountThread(String str)
        {
            this.str = str;
        }

        public void runUpperCountThread()
        {
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (Char.IsUpper(charArray[i]))
                {
                    upperCount++;
                }
            }
        }

        public int getUpperCount()
        {
            return upperCount;
        }
    }
}
