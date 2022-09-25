using System.Text;

namespace Stealer;

internal class Coding
{
	public static string GetUTF8(string text)
	{
		Encoding encoding = Encoding.GetEncoding("UTF-8");
		Encoding encoding2 = Encoding.GetEncoding("Windows-1251");
		byte[] bytes = encoding2.GetBytes(text);
		byte[] bytes2 = Encoding.Convert(encoding, encoding2, bytes);
		return encoding2.GetString(bytes2);
	}
}
