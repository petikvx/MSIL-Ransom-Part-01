using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

internal class _32625d8c
{
	internal static object _1ca7ad74;

	internal static Dictionary<int, string> ac2a9dc4;

	internal static string f75043a8(int P_0, int P_1, int P_2)
	{
		string text = default(string);
		string result = default(string);
		while (true)
		{
			int num = -766233641;
			while (true)
			{
				int num2;
				switch ((uint)(num2 = _003CModule_003E._9a3485eb(num)) % 11u)
				{
				case 0u:
					break;
				case 10u:
				{
					int num3 = 0;
					num = (num2 * 559337521) ^ -769640501;
					continue;
				}
				case 6u:
					text = null;
					num = (num2 * -485341898) ^ -1324871490;
					continue;
				case 7u:
					num = (num2 * 14254731) ^ -1105719143;
					continue;
				case 1u:
					result = text;
					num = (num2 * 1004182305) ^ -886704085;
					continue;
				case 3u:
				{
					byte[] array = null;
					num = (num2 * -965786130) ^ -1581780217;
					continue;
				}
				case 5u:
				{
					object obj = null;
					num = (num2 * 17785876) ^ 0x2F9B9607;
					continue;
				}
				case 9u:
				{
					Assembly assembly = null;
					num = (num2 * -284740489) ^ -51534421;
					continue;
				}
				case 2u:
				{
					Stream stream = null;
					num = (num2 * 2119171311) ^ 0x63BDC1D5;
					continue;
				}
				case 8u:
				{
					Random random = null;
					num = (num2 * 623612370) ^ 0x5B1F88E8;
					continue;
				}
				default:
					return result;
				}
				break;
			}
		}
	}

	static _32625d8c()
	{
		ac2a9dc4 = new Dictionary<int, string>();
	}
}
