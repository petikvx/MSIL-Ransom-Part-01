using System;
using System.Collections.Generic;

public sealed class GClass67 : GClass9
{
	public static List<GClass97> list_3 = new List<GClass97>();

	public GClass67(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		method_1(3);
		string_2 = Class16.smethod_0(-561781135);
	}

	public override List<GClass97> vmethod_25()
	{
		int num = Class24.smethod_0(1, Math.Min(3, int_5));
		int num2 = vmethod_10();
		List<GClass97> list = new List<GClass97>();
		int num3 = 0;
		checked
		{
			do
			{
				int num4 = Class24.smethod_0(-num2, num2);
				int num5 = Class24.smethod_0(-num2, num2);
				GClass97 gClass = Class24.smethod_2(num4, num5);
				if (gClass != null)
				{
					int num6 = gclass97_0.method_26(ref gClass);
					if (unchecked(gClass.method_19() && num6 > 1 && num6 < num2))
					{
						list.Add(gClass);
						if (list.Count >= num)
						{
							break;
						}
					}
				}
				num3++;
			}
			while (num3 <= 10);
			return list;
		}
	}
}
