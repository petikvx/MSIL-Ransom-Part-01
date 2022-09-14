using System.Globalization;
using System.Text;

namespace NuGet.Common;

public class vZhHY12zyN
{
	private string Gi5EDR3HBh;

	private int Whk3VNLWFU;

	public vZhHY12zyN(string text)
	{
		Gi5EDR3HBh = text;
		Whk3VNLWFU = 0;
	}

	public EFeFgFVY05 Bqdaa4WLbV()
	{
		if (Whk3VNLWFU >= Gi5EDR3HBh.Length)
		{
			return null;
		}
		if (Gi5EDR3HBh[Whk3VNLWFU] == '$')
		{
			Whk3VNLWFU++;
			return _0Ue51vGycI();
		}
		return kCZ5mgtmtF();
	}

	private static bool pcjgDYpB7d(char _2EBpencA7a)
	{
		UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(_2EBpencA7a);
		if (unicodeCategory != UnicodeCategory.LowercaseLetter && unicodeCategory != 0 && unicodeCategory != UnicodeCategory.TitlecaseLetter && unicodeCategory != UnicodeCategory.OtherLetter && unicodeCategory != UnicodeCategory.ModifierLetter && unicodeCategory != UnicodeCategory.DecimalDigitNumber)
		{
			return unicodeCategory == UnicodeCategory.ConnectorPunctuation;
		}
		return true;
	}

	private EFeFgFVY05 _0Ue51vGycI()
	{
		StringBuilder stringBuilder = new StringBuilder();
		while (Whk3VNLWFU < Gi5EDR3HBh.Length)
		{
			char c = Gi5EDR3HBh[Whk3VNLWFU];
			if (c == '$')
			{
				Whk3VNLWFU++;
				if (stringBuilder.Length == 0)
				{
					return new EFeFgFVY05(VFKEVC1drT.Text, "$");
				}
				return new EFeFgFVY05(VFKEVC1drT.Variable, stringBuilder.ToString());
			}
			if (pcjgDYpB7d(c))
			{
				stringBuilder.Append(c);
				Whk3VNLWFU++;
				continue;
			}
			stringBuilder.Insert(0, '$');
			stringBuilder.Append(c);
			Whk3VNLWFU++;
			return new EFeFgFVY05(VFKEVC1drT.Text, stringBuilder.ToString());
		}
		stringBuilder.Insert(0, '$');
		return new EFeFgFVY05(VFKEVC1drT.Text, stringBuilder.ToString());
	}

	private EFeFgFVY05 kCZ5mgtmtF()
	{
		StringBuilder stringBuilder = new StringBuilder();
		while (Whk3VNLWFU < Gi5EDR3HBh.Length && Gi5EDR3HBh[Whk3VNLWFU] != '$')
		{
			stringBuilder.Append(Gi5EDR3HBh[Whk3VNLWFU]);
			Whk3VNLWFU++;
		}
		return new EFeFgFVY05(VFKEVC1drT.Text, stringBuilder.ToString());
	}
}
