using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal class Class1
{
	public bool method_0(string string_0)
	{
		return Process.GetProcessesByName(string_0).Length > 0;
	}

	private string method_1(string string_0)
	{
		FileStream fileStream = File.OpenRead(string_0);
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(fileStream);
		fileStream.Close();
		return BitConverter.ToString(array).Replace(GClass0.smethod_0(","), GClass0.smethod_0("")).ToUpper();
	}

	public string method_2(string string_0)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		byte[] array = mD.ComputeHash(Encoding.Default.GetBytes(string_0));
		string text = BitConverter.ToString(array).Replace(GClass0.smethod_0(","), GClass0.smethod_0("")).ToLower();
		return text.ToUpper();
	}

	public string method_3(int int_0)
	{
		Random random = new Random();
		string text = GClass0.smethod_0("_şɟ\u035fџ՟\u065fݟ\u085fय़\u0a5fୟ\u0c5fൟ\u0e5fཟ\u105fᅟ\u125f\u135fᑟᕟᙟ\u175fᡟᥟ\u1a65᭡ᱡᵥṥὙ⁙⅕≕⍑\u2451╕♕❙⡙⥅⩅⭁ⱁⵅ⹅⽙すㅕ㉕㍑㐺㔸㘺㜴㠲㤰㨲㬴㰺㴸");
		string text2 = string.Empty;
		for (int i = 0; i < int_0; i++)
		{
			text2 += text.Substring(random.Next(0, text.Length), 1);
		}
		return text2;
	}

	public bool method_4(string string_0)
	{
		if (!File.Exists(string_0))
		{
			return false;
		}
		if (method_1(string_0) != method_1(Process.GetCurrentProcess().MainModule!.FileName))
		{
			File.Delete(string_0);
			return false;
		}
		return true;
	}
}
