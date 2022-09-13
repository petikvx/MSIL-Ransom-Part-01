using System;
using System.IO;
using System.Text;
using Ionic;

internal class Class1 : Class0
{
	internal ComparisonOperator comparisonOperator_0;

	internal long long_0;

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("size ").Append(Class8.smethod_0(comparisonOperator_0)).Append(" ")
			.Append(long_0.ToString());
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		FileInfo fileInfo = new FileInfo(filename);
		return method_0(fileInfo.Length);
	}

	private bool method_0(long long_1)
	{
		bool flag = false;
		return comparisonOperator_0 switch
		{
			ComparisonOperator.GreaterThan => long_1 > long_0, 
			ComparisonOperator.GreaterThanOrEqualTo => long_1 >= long_0, 
			ComparisonOperator.LesserThan => long_1 < long_0, 
			ComparisonOperator.LesserThanOrEqualTo => long_1 <= long_0, 
			ComparisonOperator.EqualTo => long_1 == long_0, 
			ComparisonOperator.NotEqualTo => long_1 != long_0, 
			_ => throw new ArgumentException("Operator"), 
		};
	}

	internal override bool Evaluate(GClass8 entry)
	{
		return method_0(entry.Int64_1);
	}
}
