using System.Diagnostics;

namespace ns0;

internal class Class5
{
	private readonly Class3 class3_0;

	public Class5()
	{
		class3_0 = new Class3();
		method_0();
		method_1();
		method_2();
		Delegate117.smethod_0(Class9.smethod_0(44));
	}

	private void method_0()
	{
		new Class3().method_4();
	}

	private void method_1()
	{
		ProcessStartInfo processStartInfo = Delegate38.smethod_0();
		string text = class3_0.method_9(Class4.string_0);
		if (Delegate22.smethod_0(text, Class10.smethod_0(49)))
		{
			Delegate137.smethod_0(processStartInfo, Delegate166.smethod_0(Class10.smethod_0(335), Delegate9.smethod_0(Delegate152.smethod_0(Delegate149.smethod_0())), Class10.smethod_0(223)));
		}
		else
		{
			Delegate137.smethod_0(processStartInfo, Delegate166.smethod_0(Class10.smethod_0(335), text, Class10.smethod_0(223)));
		}
		Delegate160.smethod_0(processStartInfo, (ProcessWindowStyle)Class9.smethod_0(36));
		Delegate131.smethod_0(processStartInfo, (byte)Class9.smethod_0(40) != 0);
		Delegate99.smethod_0(processStartInfo, Class10.smethod_0(388));
		Delegate168.smethod_0(processStartInfo);
	}

	private void method_2()
	{
		class3_0.method_10(Class4.string_0);
	}
}
