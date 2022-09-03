using System;

namespace setup;

internal class AgeUtil
{
	public static int GetAge(string birthDate)
	{
		return GetAge(birthDate, DateTime.Now.ToString("yyyyMMdd"));
	}

	public static int GetAge(string birthDate, string date)
	{
		string s = birthDate.Substring(0, 4);
		string s2 = birthDate.Substring(4, 4);
		string s3 = date.Substring(0, 4);
		string s4 = date.Substring(4, 4);
		int num = int.Parse(s3) - int.Parse(s);
		if (int.Parse(s2) > int.Parse(s4))
		{
			num--;
		}
		return num;
	}

	public static int GetAgeWareki(string birthDate)
	{
		return GetAge(GetADDate(birthDate), DateTime.Now.ToString("yyyyMMdd"));
	}

	public static int GetAgeWareki(string birthDate, string date)
	{
		return GetAge(GetADDate(birthDate), GetADDate(date));
	}

	private static string GetADDate(string s)
	{
		int num = int.Parse(s.Substring(1, 2));
		int num2 = 0;
		switch (s[0])
		{
		case '4':
		case 'H':
		case 'h':
			num2 = 1988 + num;
			break;
		case '3':
		case 'S':
		case 's':
			num2 = 1925 + num;
			break;
		case '2':
		case 'T':
		case 't':
			num2 = 1911 + num;
			break;
		case '1':
		case 'M':
		case 'm':
			num2 = 1867 + num;
			break;
		}
		return num2 + s.Substring(3, 4);
	}
}
