using System;
using System.Text;
using Ionic;
using ns5;
using ns9;

namespace ns1;

internal sealed class Class15 : Class9
{
	internal LogicalConjunction logicalConjunction_0;

	internal Class9 class9_0;

	internal Class9 class9_1;

	internal override bool vmethod_0(string string_0)
	{
		bool flag = class9_0.vmethod_0(string_0);
		switch (logicalConjunction_0)
		{
		default:
			throw new ArgumentException("Conjunction");
		case LogicalConjunction.AND:
			if (flag)
			{
				flag = class9_1.vmethod_0(string_0);
			}
			break;
		case LogicalConjunction.OR:
			if (!flag)
			{
				flag = class9_1.vmethod_0(string_0);
			}
			break;
		case LogicalConjunction.XOR:
			flag ^= class9_1.vmethod_0(string_0);
			break;
		}
		return flag;
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(").Append((class9_0 != null) ? class9_0.ToString() : "null").Append(" ")
			.Append(logicalConjunction_0.ToString())
			.Append(" ")
			.Append((class9_1 != null) ? class9_1.ToString() : "null")
			.Append(")");
		return stringBuilder.ToString();
	}

	internal override bool vmethod_1(GClass0 gclass0_0)
	{
		bool flag = class9_0.vmethod_1(gclass0_0);
		switch (logicalConjunction_0)
		{
		case LogicalConjunction.AND:
			if (flag)
			{
				flag = class9_1.vmethod_1(gclass0_0);
			}
			break;
		case LogicalConjunction.OR:
			if (!flag)
			{
				flag = class9_1.vmethod_1(gclass0_0);
			}
			break;
		case LogicalConjunction.XOR:
			flag ^= class9_1.vmethod_1(gclass0_0);
			break;
		}
		return flag;
	}
}
