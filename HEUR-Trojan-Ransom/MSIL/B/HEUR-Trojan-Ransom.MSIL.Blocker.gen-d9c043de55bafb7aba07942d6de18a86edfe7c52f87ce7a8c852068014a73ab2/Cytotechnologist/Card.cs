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
			int num = 1747907991;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x18E18F05u) % 3u)
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
				num = ((int)num2 * -1859426474) ^ -983373772;
			}
		}
	}

	public Card()
	{
		while (true)
		{
			int num = -95711016;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x8B0386A4u) % 3u)
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
				num = (int)(num2 * 428130698) ^ -475166451;
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
