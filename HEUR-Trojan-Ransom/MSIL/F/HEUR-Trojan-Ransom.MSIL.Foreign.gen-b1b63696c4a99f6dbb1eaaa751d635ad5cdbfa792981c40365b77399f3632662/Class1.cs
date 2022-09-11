using System;

internal static class Class1
{
	static Class1()
	{
		GClass0.smethod_0();
	}

	[STAThread]
	private static void Main()
	{
		if (DateTime.Now > new DateTime(636869974854526095L))
		{
			throw new Exception();
		}
		DateTime dateTime = default(DateTime).AddYears(2018).AddMonths(2).AddDays(0.403541666666667);
		if ((dateTime - DateTime.Now).TotalDays >= 0.0)
		{
		}
		new GClass4().method_0();
	}
}
