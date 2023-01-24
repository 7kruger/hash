using System;
using System.Text;
using SHA3.Net;
using System.Security.Cryptography;

namespace hash
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var hash = Sha3.Sha3256().ComputeHash(Encoding.UTF8.GetBytes("admin"));
			var result = BitConverter.ToString(hash).Replace("-", "").ToLower();
			Console.WriteLine(result);

			using (var sha3 = Sha3.Sha3256())
			{
				var bytes = sha3.ComputeHash(Encoding.UTF8.GetBytes("admin"));
				var res = BitConverter.ToString(bytes).Replace("-","").ToLower();

				Console.WriteLine(res);
			}
		}
	}
}
