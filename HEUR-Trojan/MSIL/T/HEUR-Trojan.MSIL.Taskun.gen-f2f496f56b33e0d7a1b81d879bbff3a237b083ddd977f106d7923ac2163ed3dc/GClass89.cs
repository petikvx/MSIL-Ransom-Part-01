using System.Collections.Generic;

public sealed class GClass89 : GClass9
{
	public static List<GClass97> list_3 = new List<GClass97>();

	public GClass89(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		method_1(3);
		string_2 = Class16.smethod_0(-561781135);
	}

	public void method_24(ref GClass97 gclass97_1)
	{
		if (!list_3.Contains(gclass97_1))
		{
			list_3.Add(gclass97_1);
		}
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		method_24(ref gclass97_0);
	}

	public override List<GClass97> vmethod_25()
	{
		List<GClass97> list = new List<GClass97>();
		checked
		{
			int num = list_3.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass97 gClass = gclass97_0;
				List<GClass97> list2;
				int index;
				GClass97 value = (list2 = list_3)[index = i];
				int num2 = gClass.method_26(ref value);
				list2[index] = value;
				int num3 = num2;
				if ((num3 > 0) & (num3 <= vmethod_10()))
				{
					list.Add(list_3[i]);
				}
			}
			return list;
		}
	}

	public override void vmethod_35()
	{
		if (!method_16())
		{
			list_3.Remove(gclass97_0);
			base.vmethod_35();
		}
	}
}
