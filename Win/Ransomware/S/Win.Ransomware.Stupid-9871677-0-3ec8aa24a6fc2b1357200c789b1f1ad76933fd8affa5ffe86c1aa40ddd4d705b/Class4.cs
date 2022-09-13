using System;
using System.IO;
using System.Text;
using Ionic;

internal class Class4 : Class0
{
	private char char_0;

	internal ComparisonOperator comparisonOperator_0;

	internal string String_0
	{
		get
		{
			return char_0.ToString();
		}
		set
		{
			if (value.Length != 1 || (value[0] != 'D' && value[0] != 'F'))
			{
				throw new ArgumentException("Specify a single character: either D or F");
			}
			char_0 = value[0];
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("type ").Append(Class8.smethod_0(comparisonOperator_0)).Append(" ")
			.Append(String_0);
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		bool flag = ((char_0 == 'D') ? Directory.Exists(filename) : File.Exists(filename));
		if (comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool Evaluate(GClass8 entry)
	{
		bool flag = ((char_0 == 'D') ? entry.Boolean_4 : (!entry.Boolean_4));
		if (comparisonOperator_0 != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}
}
