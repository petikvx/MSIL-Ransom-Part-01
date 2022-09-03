using System.Threading;

internal static class Class4
{
	public static void smethod_0()
	{
		Thread.Sleep(4500);
		Class9 @class = new Class9();
		GClass3 gClass = new GClass3();
		Class12 class2 = new Class12();
		class2.method_1();
		Class1 @object = new Class1(class2, @class);
		Thread thread = new Thread(@object.method_0);
		thread.Start();
		@class.method_0();
		gClass.method_0();
	}
}
