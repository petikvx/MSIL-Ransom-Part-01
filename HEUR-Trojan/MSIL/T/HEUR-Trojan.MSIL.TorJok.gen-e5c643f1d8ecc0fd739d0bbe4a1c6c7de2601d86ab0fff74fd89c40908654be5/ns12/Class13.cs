using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Ionic;
using ns5;
using ns9;

namespace ns12;

internal sealed class Class13 : Class9
{
	internal char char_0;

	internal ComparisonOperator comparisonOperator_0;

	[SpecialName]
	internal string method_0()
	{
		return char_0.ToString();
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("type ").Append(Class6.smethod_44((Enum)comparisonOperator_0)).Append(" ")
			.Append(method_0());
		return stringBuilder.ToString();
	}

	internal override bool vmethod_0(string string_0)
	{
		bool flag = ((char_0 == 'D') ? Directory.Exists(string_0) : File.Exists(string_0));
		if (comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool vmethod_1(GClass0 gclass0_0)
	{
		bool flag = ((char_0 == 'D') ? gclass0_0.bool_4 : (!gclass0_0.bool_4));
		if (comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}
}
