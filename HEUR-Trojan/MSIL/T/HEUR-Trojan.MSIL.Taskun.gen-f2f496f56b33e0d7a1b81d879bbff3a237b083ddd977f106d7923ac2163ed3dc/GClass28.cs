using System;

public sealed class GClass28 : GClass9
{
	public GClass28(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		string_2 = Class16.smethod_0(-561826792);
	}

	public int method_24(ref GClass9 gclass9_0)
	{
		double num = 0.1;
		if (gclass97_0.int_6 == 3)
		{
			num += 0.1;
		}
		if (gclass9_0.gclass97_0.int_6 == 3)
		{
			num += 0.1;
		}
		checked
		{
			int num2 = (int)Math.Round((double)gclass9_0.int_3 * num);
			Class24.gclass93_0.int_3 += num2;
			method_17(num2);
			int result = default(int);
			return result;
		}
	}
}
