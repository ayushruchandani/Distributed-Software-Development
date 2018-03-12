using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class IsPalindromeThread
    {
        public String str;
        public String reverse = "";
        public IsPalindromeThread(String str)
        {
            this.str = str;
        }
        public void runIsPalindromeThread()
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
        }

        public bool isPalindrome()
        {
            String orig_str = str.ToLower();
            String reverse_str = reverse.ToLower();
            if (orig_str.Equals(reverse_str))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
