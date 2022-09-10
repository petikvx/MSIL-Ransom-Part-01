using System;

public struct GStruct3 : IComparable<GStruct3>
{
	public int int_0;

	public int int_1;

	public string string_0;

	public string string_1;

	public string string_2;

	public int int_2;

	public int int_3;

	public int method_0(GStruct3 gstruct3_0, GStruct3 gstruct3_1)
	{
		double num = method_1(gstruct3_0);
		double value = method_1(gstruct3_1);
		return num.CompareTo(value);
	}

	private double method_1(GStruct3 gstruct3_0)
	{
		double num = gstruct3_0.int_2 - gstruct3_0.int_0;
		double num2 = gstruct3_0.int_3 - gstruct3_0.int_1;
		return Math.Sqrt(num * num + num2 * num2);
	}

	int IComparable<GStruct3>.CompareTo(GStruct3 other)
	{
		return method_0(this, other);
	}
}
