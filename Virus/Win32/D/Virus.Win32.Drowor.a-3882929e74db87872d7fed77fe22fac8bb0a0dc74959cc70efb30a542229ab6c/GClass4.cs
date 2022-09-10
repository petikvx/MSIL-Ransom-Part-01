using System;
using System.Runtime.CompilerServices;

[Serializable]
public class GClass4
{
	private GClass8 gclass8_0;

	private double double_0;

	[SpecialName]
	public double method_0()
	{
		return double_0;
	}

	[SpecialName]
	public GClass8 method_1()
	{
		if (gclass8_0 == null)
		{
			gclass8_0 = new GClass8();
		}
		return gclass8_0;
	}

	public GClass4()
	{
		gclass8_0 = new GClass8();
		double_0 = GClass3.double_1;
	}
}
