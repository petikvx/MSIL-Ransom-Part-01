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
			int num = 2033689723;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x601DF58Du) % 3u)
				{
				case 1u:
					goto IL_003e;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_003e:
				num = (int)((num2 * 459842591) ^ 0x3E0A6525);
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
