
using exercise1;

public class Answer
{
    public static bool AreTwins(string a, string b)
    {
        Twiner twiner = new Twiner();
        return twiner.CheckTwins(a, b);
    }
};

class Program
{
    static void Main()
    {
        bool result = Answer.AreTwins("Mario", "Luigi");
        Console.WriteLine( result ? "Twins" : "bros");
    }
}