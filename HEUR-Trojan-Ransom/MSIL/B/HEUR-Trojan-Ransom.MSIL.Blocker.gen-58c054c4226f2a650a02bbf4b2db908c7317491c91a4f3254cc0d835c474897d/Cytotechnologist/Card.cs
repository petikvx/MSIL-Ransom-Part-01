using System;

namespace Cytotechnologist;

public class Card
{
	public static readonly string[] CardTypeNames = new string[5] { "F", "M", "T", "C", "E" };

	public const int EconomicsIndex = 4;

	public int Type;

	public int Impact;

	public override string ToString()
	{
		string result = Card.smethod_1("{0}{1}{2}", (object)CardTypeNames[Type], (object)((Impact < 0) ? "G" : "B"), (object)Card.smethod_0(Impact));
		while (true)
		{
			int num = 1981646790;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x23516EF2u) % 3u)
				{
				case 2u:
					goto IL_003e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_003e:
				num = (int)(num2 * 419700488) ^ -1045072434;
			}
		}
	}

	public Card()
	{
		while (true)
		{
			int num = 1544602884;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x1F9B59C8u) % 3u)
				{
				case 2u:
					goto IL_0008;
				default:
					return;
				case 0u:
					break;
				case 1u:
					return;
				}
				break;
				IL_0008:
				num = (int)(num2 * 1597415123) ^ -1251709783;
			}
		}
	}

	static int smethod_0(int int_0)
	{
		return Math.Abs(int_0);
	}

	static string smethod_1(string string_0, object object_0, object object_1, object object_2)
	{
		return string.Format(string_0, object_0, object_1, object_2);
	}
}
