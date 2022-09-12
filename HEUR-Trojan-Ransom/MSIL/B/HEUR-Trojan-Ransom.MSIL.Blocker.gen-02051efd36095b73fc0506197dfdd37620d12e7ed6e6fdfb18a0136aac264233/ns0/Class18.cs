using System;

namespace ns0;

internal class Class18
{
	private DateTime dateTime_0;

	private Class3 class3_0;

	public void method_0()
	{
		class3_0 = new Class3();
		DateTime dateTime = Delegate52.smethod_0(Class17.smethod_1(class3_0.method_11(Class3.string_1, Class10.smethod_0(46))));
		dateTime_0 = Delegate225.smethod_0(ref dateTime, Class1.int_0);
	}

	public double method_1()
	{
		TimeSpan timeSpan_ = Delegate69.smethod_0(ref dateTime_0, Delegate80.smethod_0());
		return Delegate91.smethod_0(Delegate141.smethod_0(ref timeSpan_));
	}
}
