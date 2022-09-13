using System;
using System.Text;
using Ionic;

internal class Class6 : Class0
{
	internal LogicalConjunction logicalConjunction_0;

	internal Class0 class0_0;

	private Class0 class0_1;

	internal Class0 Class0_0
	{
		get
		{
			return class0_1;
		}
		set
		{
			class0_1 = value;
			if (value == null)
			{
				logicalConjunction_0 = LogicalConjunction.NONE;
			}
			else if (logicalConjunction_0 == LogicalConjunction.NONE)
			{
				logicalConjunction_0 = LogicalConjunction.AND;
			}
		}
	}

	internal override bool Evaluate(string filename)
	{
		bool flag = class0_0.Evaluate(filename);
		switch (logicalConjunction_0)
		{
		default:
			throw new ArgumentException("Conjunction");
		case LogicalConjunction.AND:
			if (flag)
			{
				flag = Class0_0.Evaluate(filename);
			}
			break;
		case LogicalConjunction.OR:
			if (!flag)
			{
				flag = Class0_0.Evaluate(filename);
			}
			break;
		case LogicalConjunction.XOR:
			flag ^= Class0_0.Evaluate(filename);
			break;
		}
		return flag;
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("(").Append((class0_0 != null) ? class0_0.ToString() : "null").Append(" ")
			.Append(logicalConjunction_0.ToString())
			.Append(" ")
			.Append((Class0_0 != null) ? Class0_0.ToString() : "null")
			.Append(")");
		return stringBuilder.ToString();
	}

	internal override bool Evaluate(GClass8 entry)
	{
		bool flag = class0_0.Evaluate(entry);
		switch (logicalConjunction_0)
		{
		case LogicalConjunction.AND:
			if (flag)
			{
				flag = Class0_0.Evaluate(entry);
			}
			break;
		case LogicalConjunction.OR:
			if (!flag)
			{
				flag = Class0_0.Evaluate(entry);
			}
			break;
		case LogicalConjunction.XOR:
			flag ^= Class0_0.Evaluate(entry);
			break;
		}
		return flag;
	}
}
