using SHA3.Net;
using System.Text;

namespace sha3;

public class Program
{
    public static void Main()
    {
        var hash = Sha3.Sha3256().ComputeHash(Encoding.UTF8.GetBytes("123"));
        var res = Convert.ToHexString(hash).ToLower();
        Console.WriteLine(res);
    }
}
