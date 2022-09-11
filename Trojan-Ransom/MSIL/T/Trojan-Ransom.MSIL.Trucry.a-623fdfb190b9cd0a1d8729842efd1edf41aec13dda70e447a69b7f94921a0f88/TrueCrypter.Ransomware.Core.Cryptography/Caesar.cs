using System.Linq;

namespace TrueCrypter.Ransomware.Core.Cryptography;

public static class Caesar
{
	public static char Encrypt(char ch, int code)
	{
		if (!char.IsLetter(ch))
		{
			return ch;
		}
		char c = (char.IsUpper(ch) ? 'A' : 'a');
		return (char)((ch + code - c) % 26 + c);
	}

	public static string Encrypt(string input, int code)
	{
		return new string((from ch in input.ToCharArray()
			select Encrypt(ch, code)).ToArray());
	}

	public static string Decrypt(string input, int code)
	{
		return Encrypt(input, 26 - code);
	}
}
