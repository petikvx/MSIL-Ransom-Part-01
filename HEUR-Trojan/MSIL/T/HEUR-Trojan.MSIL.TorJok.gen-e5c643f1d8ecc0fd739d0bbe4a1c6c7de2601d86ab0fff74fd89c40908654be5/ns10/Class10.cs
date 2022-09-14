using System;
using System.IO;
using System.Text;
using Ionic;
using ns5;
using ns9;

namespace ns10;

internal sealed class Class10 : Class9
{
	internal ComparisonOperator comparisonOperator_0;

	internal long long_0;

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("size ").Append(Class6.smethod_44((Enum)comparisonOperator_0)).Append(" ")
			.Append(long_0.ToString());
		return stringBuilder.ToString();
	}

	internal override bool vmethod_0(string string_0)
	{
		FileInfo fileInfo = new FileInfo(string_0);
		return Class6.smethod_229(this, fileInfo.Length);
	}

	internal override bool vmethod_1(GClass0 gclass0_0)
	{
		return Class6.smethod_229(this, gclass0_0.long_2);
	}
}
