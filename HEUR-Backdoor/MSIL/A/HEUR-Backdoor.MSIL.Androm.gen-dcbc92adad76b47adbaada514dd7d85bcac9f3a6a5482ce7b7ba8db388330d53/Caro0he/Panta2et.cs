using System.Globalization;
using System.Text;
using Dru44ers;
using ns16;

namespace Caro0he;

public class Panta2et
{
	private string Zemstv3;

	private int Co7veyers;

	public Panta2et(string text)
	{
		Zemstv3 = text;
		Co7veyers = 0;
	}

	public Wh7ff7ng Sava6in6()
	{
		if (Co7veyers >= Zemstv3.Length)
		{
			return null;
		}
		if (Zemstv3[Co7veyers] == '$')
		{
			Co7veyers++;
			return Aggadi5();
		}
		return Oncolog4c();
	}

	private static bool T7ngelo(char Reaw0ke)
	{
		UnicodeCategory unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(Reaw0ke);
		if (unicodeCategory != UnicodeCategory.LowercaseLetter && unicodeCategory != 0 && unicodeCategory != UnicodeCategory.TitlecaseLetter && unicodeCategory != UnicodeCategory.OtherLetter && unicodeCategory != UnicodeCategory.ModifierLetter && unicodeCategory != UnicodeCategory.DecimalDigitNumber)
		{
			return unicodeCategory == UnicodeCategory.ConnectorPunctuation;
		}
		return true;
	}

	private Wh7ff7ng Aggadi5()
	{
		StringBuilder stringBuilder = new StringBuilder();
		char c;
		while (true)
		{
			if (Co7veyers < Zemstv3.Length)
			{
				c = Zemstv3[Co7veyers];
				if (c != '$')
				{
					if (!T7ngelo(c))
					{
						break;
					}
					stringBuilder.Append(c);
					Co7veyers++;
					continue;
				}
				Co7veyers++;
				if (stringBuilder.Length == 0)
				{
					return new Wh7ff7ng(P3cketb33k.Text, "$");
				}
				return new Wh7ff7ng(P3cketb33k.Variable, stringBuilder.ToString());
			}
			stringBuilder.Insert(0, '$');
			return new Wh7ff7ng(P3cketb33k.Text, stringBuilder.ToString());
		}
		stringBuilder.Insert(0, '$');
		stringBuilder.Append(c);
		Co7veyers++;
		return new Wh7ff7ng(P3cketb33k.Text, stringBuilder.ToString());
	}

	private Wh7ff7ng Oncolog4c()
	{
		StringBuilder stringBuilder = new StringBuilder();
		while (Co7veyers < Zemstv3.Length && Zemstv3[Co7veyers] != '$')
		{
			stringBuilder.Append(Zemstv3[Co7veyers]);
			Co7veyers++;
		}
		return new Wh7ff7ng(P3cketb33k.Text, stringBuilder.ToString());
	}
}
