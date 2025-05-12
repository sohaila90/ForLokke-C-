namespace Loops;

public class Class3
{
    public void Run()
    {
        bool rounds = true;
        int i = 0;
        while (rounds)
        {
            if (i < 10)
            {
                Console.WriteLine("Round number " + i);
                i++;
            }
            else
            {
                rounds = false;
            }
        }
    }
}
   
