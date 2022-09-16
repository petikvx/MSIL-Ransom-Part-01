public sealed class GClass90
{
	private string string_0;

	public GClass0 gclass0_0;

	public GClass0 gclass0_1;

	public GClass0 gclass0_2;

	public GClass0 gclass0_3;

	public GClass0 gclass0_4;

	public GClass0 gclass0_5;

	public GClass0 gclass0_6;

	public GClass0 gclass0_7;

	public GClass0 gclass0_8;

	public GClass0 gclass0_9;

	public GClass0 gclass0_10;

	public GClass0 gclass0_11;

	public GClass0 gclass0_12;

	public GClass0 gclass0_13;

	public GClass0 gclass0_14;

	public GClass0 gclass0_15;

	public GClass0 gclass0_16;

	public GClass0 gclass0_17;

	public GClass0 gclass0_18;

	public GClass0 gclass0_19;

	public GClass1 gclass1_0;

	public GClass1 gclass1_1;

	public GClass1 gclass1_2;

	public bool bool_0;

	public GClass90()
	{
		string_0 = string.Empty;
		gclass0_0 = new GClass0(Class16.smethod_0(-561792538));
		gclass0_1 = new GClass0(Class16.smethod_0(-561793023));
		gclass0_2 = new GClass0(Class16.smethod_0(-561792994));
		gclass0_3 = new GClass0(Class16.smethod_0(-561792968));
		gclass0_4 = new GClass0(Class16.smethod_0(-561792931));
		gclass0_5 = new GClass0(Class16.smethod_0(-561792892));
		gclass0_6 = new GClass0(Class16.smethod_0(-561792860));
		gclass0_7 = new GClass0(Class16.smethod_0(-561792818));
		gclass0_8 = new GClass0(Class16.smethod_0(-561792796));
		gclass0_9 = new GClass0(Class16.smethod_0(-561792770));
		gclass0_10 = new GClass0(Class16.smethod_0(-561792229));
		gclass0_11 = new GClass0(Class16.smethod_0(-561792199));
		gclass0_12 = new GClass0(string.Empty);
		gclass0_13 = new GClass0(Class16.smethod_0(-561792715));
		gclass0_14 = new GClass0(Class16.smethod_0(-561792175));
		gclass0_15 = new GClass0(Class16.smethod_0(-561792136));
		gclass0_16 = new GClass0(Class16.smethod_0(-561792101));
		gclass0_17 = new GClass0(Class16.smethod_0(-561792076));
		gclass0_18 = new GClass0(Class16.smethod_0(-561792048));
		gclass0_19 = new GClass0(string.Empty);
		gclass1_0 = new GClass1(Class16.smethod_0(-561792023));
		gclass1_1 = new GClass1(Class16.smethod_0(-561792505));
		gclass1_2 = new GClass1(Class16.smethod_0(-561792472));
		bool_0 = false;
	}

	public void method_0()
	{
		bool_0 = false;
		string_0 = string.Empty;
		gclass0_0.method_2();
		gclass0_1.method_2();
		gclass0_2.method_2();
		gclass0_3.method_2();
		gclass0_4.method_2();
		gclass0_5.method_2();
		gclass0_6.method_2();
		gclass0_7.method_2();
		gclass0_8.method_2();
		gclass0_9.method_2();
		gclass0_10.method_2();
		gclass0_11.method_2();
		gclass0_12.method_2();
		gclass0_13.method_2();
		gclass0_14.method_2();
		gclass0_15.method_2();
		gclass0_17.method_2();
		gclass0_16.method_2();
		gclass0_18.method_2();
		gclass0_19.method_2();
		gclass1_0.method_2();
		gclass1_1.method_2();
		gclass1_2.method_2();
	}

	public void method_1(string string_1, bool bool_1)
	{
		if (string_1.Length > 0)
		{
			bool_0 = true;
			string_0 += string_1;
		}
		if (bool_1 & bool_0)
		{
			string_0 += Class16.smethod_0(-561781492);
			bool_0 = false;
		}
	}

	public override string ToString()
	{
		method_1(gclass0_19.ToString(), bool_1: true);
		method_1(gclass1_0.ToString(), bool_1: false);
		method_1(gclass1_1.ToString(), bool_1: false);
		method_1(gclass1_2.ToString(), bool_1: true);
		method_1(gclass0_1.ToString(), bool_1: false);
		method_1(gclass0_2.ToString(), bool_1: true);
		method_1(gclass0_3.ToString(), bool_1: false);
		method_1(gclass0_4.ToString(), bool_1: false);
		method_1(gclass0_5.ToString(), bool_1: false);
		method_1(gclass0_6.ToString(), bool_1: true);
		method_1(gclass0_8.ToString(), bool_1: false);
		method_1(gclass0_7.ToString(), bool_1: true);
		method_1(gclass0_13.ToString(), bool_1: false);
		method_1(gclass0_14.ToString(), bool_1: false);
		method_1(gclass0_15.ToString(), bool_1: false);
		method_1(gclass0_17.ToString(), bool_1: false);
		method_1(gclass0_16.ToString(), bool_1: false);
		method_1(gclass0_18.ToString(), bool_1: true);
		method_1(gclass0_12.ToString(), bool_1: false);
		method_1(gclass0_0.ToString(), bool_1: false);
		method_1(gclass0_11.ToString(), bool_1: true);
		method_1(gclass0_10.ToString(), bool_1: false);
		method_1(gclass0_9.ToString(), bool_1: true);
		return string_0;
	}
}
