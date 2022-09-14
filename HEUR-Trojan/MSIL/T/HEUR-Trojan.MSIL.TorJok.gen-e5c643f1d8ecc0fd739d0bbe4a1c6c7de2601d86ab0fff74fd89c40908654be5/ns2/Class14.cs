using System;
using System.IO;
using System.Text;
using Ionic;
using ns5;
using ns9;

namespace ns2;

internal sealed class Class14 : Class9
{
	internal FileAttributes fileAttributes_0;

	internal ComparisonOperator comparisonOperator_0;

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("attributes ").Append(Class6.smethod_44((Enum)comparisonOperator_0)).Append(" ")
			.Append(Class6.smethod_655(this));
		return stringBuilder.ToString();
	}

	internal override bool vmethod_0(string string_0)
	{
		if (Directory.Exists(string_0))
		{
			return comparisonOperator_0 != ComparisonOperator.EqualTo;
		}
		FileAttributes attributes = File.GetAttributes(string_0);
		return Class6.smethod_221(attributes, this);
	}

	internal override bool vmethod_1(GClass0 gclass0_0)
	{
		FileAttributes int_ = (FileAttributes)gclass0_0.int_0;
		return Class6.smethod_221(int_, this);
	}
}
