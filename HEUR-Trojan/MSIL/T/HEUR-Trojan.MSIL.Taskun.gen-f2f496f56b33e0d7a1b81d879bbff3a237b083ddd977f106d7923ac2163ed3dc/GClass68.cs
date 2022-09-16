using System.Collections.Generic;

public sealed class GClass68 : GClass9
{
	public List<GClass97> list_3;

	public GClass68(int int_22, int int_23, int int_24, int int_25 = 16)
		: base(int_22, int_23, int_24, int_25)
	{
		list_3 = new List<GClass97>();
		string_2 = Class16.smethod_0(-561781135);
	}

	public override void vmethod_13(int int_22, ref GClass91 gclass91_1)
	{
		if ((int_22 == 5) & gclass97_0.bool_0)
		{
			base.vmethod_13(int_22, ref gclass91_1);
		}
	}

	public void method_24()
	{
		List<GClass97> list = gclass97_0.method_40();
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				List<GClass97> list2;
				int index;
				GClass97 gclass97_ = (list2 = list)[index = i];
				method_26(ref gclass97_);
				list2[index] = gclass97_;
			}
		}
	}

	public void method_25(ref GClass97 gclass97_1)
	{
		if (!list_3.Contains(gclass97_1) & !gclass97_1.Equals(gclass97_0))
		{
			list_3.Add(gclass97_1);
		}
	}

	public override void vmethod_20()
	{
		base.vmethod_20();
		method_24();
		Class24.list_0[int_10].list_3.Add(this);
	}

	public void method_26(ref GClass97 gclass97_1)
	{
		if ((gclass97_1.int_6 != 4) | (gclass97_1.int_3 > 0))
		{
			return;
		}
		gclass97_1.int_3 = 1;
		List<GClass97> list = gclass97_1.method_40();
		checked
		{
			int num = list.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass97 gclass97_2 = list[i];
				if (gclass97_2.int_6 == 4)
				{
					method_26(ref gclass97_2);
				}
				else
				{
					method_25(ref gclass97_2);
				}
			}
		}
	}

	public List<GClass97> method_27(bool bool_0)
	{
		List<GClass97> list = new List<GClass97>();
		checked
		{
			int num = list_3.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass97 gClass = list_3[i];
				if (gClass.method_19() == bool_0)
				{
					list.Add(gClass);
				}
			}
			return list;
		}
	}

	public override List<GClass97> vmethod_25()
	{
		return method_27(bool_0: true);
	}

	public override bool vmethod_29(ref GClass97 gclass97_1)
	{
		List<GClass97> list = method_27(bool_0: false);
		return list.Contains(gclass97_1);
	}

	public override void vmethod_35()
	{
		Class24.list_0[int_10].list_3.Remove(this);
		base.vmethod_35();
	}
}
