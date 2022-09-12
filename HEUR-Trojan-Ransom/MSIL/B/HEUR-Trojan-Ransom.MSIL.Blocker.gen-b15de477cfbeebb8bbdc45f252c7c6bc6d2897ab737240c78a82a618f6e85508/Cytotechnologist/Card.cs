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
			int num = 1319613183;
			while (true)
			{
				string object_;
				string object_2;
				switch ((uint)(num ^ 0x59F11712) % 3u)
				{
				case 1u:
					object_ = CardTypeNames[Type];
					object_2 = ((Impact < 0) ? "G" : "B");
					goto IL_0029;
				case 2u:
					break;
				default:
					return result;
				}
				break;
				IL_0029:
				result = Card.smethod_1("{0}{1}{2}", (object)object_, (object)object_2, (object)Card.smethod_0(Impact));
				num = 413239475;
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
