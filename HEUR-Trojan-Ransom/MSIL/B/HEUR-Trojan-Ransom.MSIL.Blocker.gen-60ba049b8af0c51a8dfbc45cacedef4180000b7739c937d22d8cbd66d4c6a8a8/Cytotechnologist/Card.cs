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
			int num = -110434439;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xFA093CFEu) % 4u)
				{
				case 3u:
					result = Card.smethod_1("{0}{1}{2}", (object)CardTypeNames[Type], (object)((Impact < 0) ? "G" : "B"), (object)Card.smethod_0(Impact));
					num = -697921038;
					continue;
				case 0u:
					num = (int)((num2 * 1152931189) ^ 0x217F6BD3);
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
			int num = -1296494098;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xF18559F0u) % 3u)
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
				num = (int)((num2 * 77487591) ^ 0x60335B7B);
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
