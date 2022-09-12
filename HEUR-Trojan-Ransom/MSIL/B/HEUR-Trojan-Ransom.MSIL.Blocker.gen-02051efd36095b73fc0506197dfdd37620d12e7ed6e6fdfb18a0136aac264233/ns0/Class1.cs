using System;
using System.Windows.Forms;
using ns1;

namespace ns0;

internal class Class1
{
	private static readonly Class3 class3_0 = new Class3();

	public static int int_0 = Class9.smethod_0(8);

	public static void Main(string[] args)
	{
		smethod_3();
		smethod_0();
		if (Delegate22.smethod_0(Delegate240.smethod_0(class3_0.method_0(Class3.string_0), Class9.smethod_0(0)), Class10.smethod_0(22)))
		{
			smethod_2();
		}
		else
		{
			smethod_4();
		}
	}

	private static void smethod_0()
	{
		if (!class3_0.method_12(Class3.string_1, Class10.smethod_0(31)))
		{
			new Class11().method_1();
		}
	}

	public static void smethod_1()
	{
		new Class11().method_0();
	}

	public static void smethod_2()
	{
		new Class5();
	}

	private static void smethod_3()
	{
		new Class4();
	}

	[STAThread]
	private static void smethod_4()
	{
		class3_0.method_5(Class3.string_1, Class10.smethod_0(31), (byte)Class9.smethod_0(4) != 0);
		if (Delegate22.smethod_0(class3_0.method_11(Class3.string_1, Class10.smethod_0(46)), Class10.smethod_0(49)))
		{
			Class3 @class = class3_0;
			string string_ = Class3.string_1;
			string string_2 = Class10.smethod_0(46);
			DateTime dateTime_ = Delegate80.smethod_0();
			@class.method_7(string_, string_2, Class17.smethod_0(Delegate129.smethod_0(ref dateTime_)));
		}
		MainWindow form_ = Delegate201.smethod_0();
		Delegate222.smethod_0();
		Delegate176.smethod_0((Form)(object)form_);
	}
}
