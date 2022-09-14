using System;
using System.IO;
using System.Text;
using Ionic;
using ns5;
using ns9;

namespace ns11;

internal sealed class Class11 : Class9
{
	internal ComparisonOperator comparisonOperator_0;

	internal WhichTime whichTime_0;

	internal DateTime dateTime_0;

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(whichTime_0.ToString()).Append(" ").Append(Class6.smethod_44((Enum)comparisonOperator_0))
			.Append(" ")
			.Append(dateTime_0.ToString("yyyy-MM-dd-HH:mm:ss"));
		return stringBuilder.ToString();
	}

	internal override bool vmethod_0(string string_0)
	{
		return Class6.smethod_154(this, whichTime_0 switch
		{
			WhichTime.atime => File.GetLastAccessTime(string_0).ToUniversalTime(), 
			WhichTime.mtime => File.GetLastWriteTime(string_0).ToUniversalTime(), 
			WhichTime.ctime => File.GetCreationTime(string_0).ToUniversalTime(), 
			_ => throw new ArgumentException("Operator"), 
		});
	}

	internal override bool vmethod_1(GClass0 gclass0_0)
	{
		return Class6.smethod_154(this, whichTime_0 switch
		{
			WhichTime.atime => gclass0_0.dateTime_2, 
			WhichTime.mtime => gclass0_0.dateTime_1, 
			WhichTime.ctime => gclass0_0.dateTime_3, 
			_ => throw new ArgumentException("??time"), 
		});
	}
}
