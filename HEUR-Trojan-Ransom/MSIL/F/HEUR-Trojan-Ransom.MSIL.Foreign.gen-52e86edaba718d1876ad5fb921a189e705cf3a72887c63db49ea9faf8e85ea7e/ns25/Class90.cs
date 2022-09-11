using System;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns12;
using ns13;
using ns14;

namespace ns25;

internal sealed class Class90 : Class87
{
	[NonSerialized]
	internal static GetString getString_0;

	public override void vmethod_0()
	{
		base.Column.Type = Enum49.const_7;
		base.Column.ClrType = typeof(decimal);
		delegate1_0 = method_0;
	}

	private object method_0(byte[] byte_0)
	{
		int num = byte_0[0];
		byte b = byte_0[^1];
		string empty = string.Empty;
		string text = string.Empty;
		switch (b)
		{
		case 192:
			empty = getString_0(107406809);
			goto IL_0098;
		case 208:
			empty = getString_0(107409083);
			goto IL_0098;
		default:
			{
				if ((b & 0xF) == 12)
				{
					empty = getString_0(107406809);
					text = (b >> 4).ToString();
				}
				else
				{
					if ((b & 0xF) != 13)
					{
						throw new FormatException(Class122.InvalidDecimalFormat);
					}
					empty = getString_0(107409083);
					text = (b >> 4).ToString();
				}
				goto IL_0098;
			}
			IL_0098:
			for (int i = 1; i < byte_0.Length - 1; i++)
			{
				empty += byte_0[i].ToString(getString_0(107406804));
			}
			empty += text;
			empty = empty.Insert(empty.Length - num, getString_0(107397412));
			return decimal.Parse(empty);
		}
	}

	static Class90()
	{
		Strings.CreateGetStringDelegate(typeof(Class90));
	}
}
