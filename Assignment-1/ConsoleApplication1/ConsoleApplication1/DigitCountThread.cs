using System;
using System.Threading.Tasks;
using System.Threading;

public class DigitCountThread
{
    public string str;
    public int count = 0;
    public DigitCountThread(string str)
    {
        this.str = str;
    }

    public void runDigitCountThread()
    {
        char[] charArray = str.ToCharArray();
        for (int i = 0; i < charArray.Length; i++)
        {
            if (Char.IsDigit(charArray[i]))
            {
                count++;
            }
        }
    }

    public int digitCount()
    {
        return count;
    }
}