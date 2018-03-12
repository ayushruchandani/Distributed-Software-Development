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
        char[] charArray = str.toCharArray();
        for (int i = 0; i < charArray.length; i++)
        {
            if (Character.isDigit(charArray[i]))
            {
                count++;
            }
        }
        return count;
    }
}
