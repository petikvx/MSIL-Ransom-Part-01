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
			int num = -220723878;
			while (true)
			{
				string object_;
				string object_2;
				switch ((uint)(num ^ -302839048) % 3u)
				{
				case 2u:
					object_ = CardTypeNames[Type];
					object_2 = ((Impact < 0) ? "G" : "B");
					goto IL_0029;
				case 0u:
					break;
				default:
					return result;
				}
				break;
				IL_0029:
				result = Card.smethod_1("{0}{1}{2}", (object)object_, (object)object_2, (object)Card.smethod_0(Impact));
				num = -2004904951;
			}
		}
	}

	public Card()
	{
		while (true)
		{
			int num = -2015051836;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0xED5B5A87u) % 3u)
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
				num = ((int)num2 * -277841221) ^ -607925363;
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
