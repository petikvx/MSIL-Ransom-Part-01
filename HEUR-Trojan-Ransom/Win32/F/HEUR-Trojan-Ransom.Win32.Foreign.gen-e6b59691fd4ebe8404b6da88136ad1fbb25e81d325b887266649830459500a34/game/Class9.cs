using System;

namespace game;

internal class Class9
{
	public readonly int int_0;

	public readonly int int_1;

	public Class9(int int_2, int int_3)
	{
		int_0 = int_2;
		int_1 = int_3;
	}

	public override string vmethod_0()
	{
		return int_0 + "," + int_1;
	}

	public override bool vmethod_1(object object_0)
	{
		if (!(object_0 is Class9))
		{
			return false;
		}
		Class9 @class = object_0 as Class9;
		return int_0 == @class.int_0 && int_1 == @class.int_1;
	}

	public override int vmethod_2()
	{
		int num = int_0;
		int num2 = num.GetHashCode() * 31;
		num = int_1;
		return num2 + num.GetHashCode();
	}

	public int method_0(int int_2, int int_3)
	{
		return (int)Math.Sqrt(Math.Pow(int_0 - int_2, 2.0) + Math.Pow(int_1 - int_3, 2.0));
	}

	public int method_1(Class9 class9_0)
	{
		return method_0(class9_0.int_0, class9_0.int_1);
	}
}
