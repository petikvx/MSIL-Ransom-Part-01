using System;
using System.IO;
using System.Text;
using Ionic;

internal class Class2 : Class0
{
	internal ComparisonOperator comparisonOperator_0;

	internal WhichTime whichTime_0;

	internal DateTime dateTime_0;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(whichTime_0.ToString()).Append(" ").Append(Class8.smethod_0(comparisonOperator_0))
			.Append(" ")
			.Append(dateTime_0.ToString("yyyy-MM-dd-HH:mm:ss"));
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		return method_0(whichTime_0 switch
		{
			WhichTime.atime => File.GetLastAccessTime(filename).ToUniversalTime(), 
			WhichTime.mtime => File.GetLastWriteTime(filename).ToUniversalTime(), 
			WhichTime.ctime => File.GetCreationTime(filename).ToUniversalTime(), 
			_ => throw new ArgumentException("Operator"), 
		});
	}

	private bool method_0(DateTime dateTime_1)
	{
		bool flag = false;
		return comparisonOperator_0 switch
		{
			ComparisonOperator.GreaterThan => dateTime_1 > dateTime_0, 
			ComparisonOperator.GreaterThanOrEqualTo => dateTime_1 >= dateTime_0, 
			ComparisonOperator.LesserThan => dateTime_1 < dateTime_0, 
			ComparisonOperator.LesserThanOrEqualTo => dateTime_1 <= dateTime_0, 
			ComparisonOperator.EqualTo => dateTime_1 == dateTime_0, 
			ComparisonOperator.NotEqualTo => dateTime_1 != dateTime_0, 
			_ => throw new ArgumentException("Operator"), 
		};
	}

	internal override bool Evaluate(GClass8 entry)
	{
		return method_0(whichTime_0 switch
		{
			WhichTime.atime => entry.DateTime_2, 
			WhichTime.mtime => entry.DateTime_1, 
			WhichTime.ctime => entry.DateTime_3, 
			_ => throw new ArgumentException("??time"), 
		});
	}
}
