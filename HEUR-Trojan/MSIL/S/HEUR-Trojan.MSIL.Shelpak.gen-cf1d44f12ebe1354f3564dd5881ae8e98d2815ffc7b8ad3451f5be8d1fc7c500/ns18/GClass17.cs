using System.Collections.Generic;

namespace ns18;

public class GClass17
{
	private List<GClass18> list_0;

	private GClass18 gclass18_0;

	public GClass18 this[int int_0] => list_0[int_0];

	public int Int32_0 => list_0.Count;

	public GClass17(GClass18 gclass18_1, List<GClass18> list_1)
	{
		gclass18_0 = gclass18_1;
		list_0 = list_1;
	}

	public GClass18 method_0()
	{
		return gclass18_0.method_7();
	}

	public GClass18 method_1(string string_0)
	{
		GClass18 gClass = gclass18_0.method_7();
		gClass.String_0 = string_0;
		return gClass;
	}

	public GClass18 method_2(long long_0)
	{
		GClass18 gClass = gclass18_0.method_7();
		gClass.method_10(long_0);
		return gClass;
	}

	public GClass18 method_3(double double_0)
	{
		GClass18 gClass = gclass18_0.method_7();
		gClass.method_27(double_0);
		return gClass;
	}
}
