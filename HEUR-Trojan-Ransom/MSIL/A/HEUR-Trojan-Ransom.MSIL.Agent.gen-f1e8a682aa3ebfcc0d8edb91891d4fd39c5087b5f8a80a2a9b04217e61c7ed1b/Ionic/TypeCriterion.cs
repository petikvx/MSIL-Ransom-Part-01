using System;
using System.IO;
using System.Text;
using Ionic.Zip;

namespace Ionic;

internal class TypeCriterion : SelectionCriterion
{
	private char ObjectType;

	internal ComparisonOperator Operator;

	internal string AttributeString
	{
		get
		{
			return ObjectType.ToString();
		}
		set
		{
			if (value.Length != 1 || (value[0] != 'D' && value[0] != 'F'))
			{
				throw new ArgumentException("Specify a single character: either D or F");
			}
			ObjectType = value[0];
		}
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("type ").Append(EnumUtil.GetDescription(Operator)).Append(" ")
			.Append(AttributeString);
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(string filename)
	{
		bool flag = ((ObjectType == 'D') ? Directory.Exists(filename) : File.Exists(filename));
		if (Operator != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}

	internal override bool Evaluate(ZipEntry entry)
	{
		bool flag = ((ObjectType == 'D') ? entry.IsDirectory : (!entry.IsDirectory));
		if (Operator != ComparisonOperator.EqualTo)
		{
			flag = !flag;
		}
		return flag;
	}
}
