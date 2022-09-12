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
		string result = default(string);
		while (true)
		{
			int num = 1932824295;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x7840719Cu) % 4u)
				{
				case 3u:
					result = Card.smethod_1("{0}{1}{2}", (object)CardTypeNames[Type], (object)((Impact < 0) ? "G" : "B"), (object)Card.smethod_0(Impact));
					num = 365542952;
					continue;
				case 0u:
					num = ((int)num2 * -698528637) ^ -1572890923;
					continue;
				case 2u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public Card()
	{
		while (true)
		{
			int num = -659631674;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF8532EC2u) % 3u)
				{
				case 1u:
					goto IL_0008;
				default:
					return;
				case 2u:
					break;
				case 0u:
					return;
				}
				break;
				IL_0008:
				num = ((int)num2 * -421923331) ^ -805094201;
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
