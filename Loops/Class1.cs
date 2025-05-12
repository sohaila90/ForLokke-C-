namespace Loops;

public class Class1
{
    public void Run()
    {
        string[] args = new string[] { "Terje er kul" };
        for (var i = 0; i < 5; i++)
        {
            if (i < 5)
                Console.WriteLine("Terje er kul");
        }
    }
}