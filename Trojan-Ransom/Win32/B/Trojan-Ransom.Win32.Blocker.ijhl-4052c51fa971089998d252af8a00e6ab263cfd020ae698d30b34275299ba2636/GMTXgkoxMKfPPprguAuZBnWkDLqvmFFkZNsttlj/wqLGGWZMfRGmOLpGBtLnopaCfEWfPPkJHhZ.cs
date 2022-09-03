using System.Globalization;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GMTXgkoxMKfPPprguAuZBnWkDLqvmFFkZNsttlj;

[StandardModule]
internal sealed class wqLGGWZMfRGmOLpGBtLnopaCfEWfPPkJHhZ
{
	public static string IcNbGlYsHAulrpCjvQKoWbCYVdMJLMlrdwqle(string nDXrmTGCSwJwjMMdtbDPuniKAQnEcvQvnVvWkN)
	{
		string text = nDXrmTGCSwJwjMMdtbDPuniKAQnEcvQvnVvWkN;
		string text2 = "";
		string text3 = "";
		if (text.StartsWith("0x"))
		{
			text = text.Substring(2);
		}
		for (int i = 0; i < text.Length; i += 2)
		{
			text3 = text.Substring(i, 2);
			text2 += Conversions.ToString(Strings.ChrW((int)ushort.Parse(text3, NumberStyles.HexNumber)));
		}
		return text2;
	}
}
