using System.Diagnostics;
using System.Globalization;
using System.Resources;

[DebuggerNonUserCode]
internal sealed class Class1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class1()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(GClass4.smethod_0(167), typeof(Class1).Assembly));
		}
		return resourceManager_0;
	}

	internal static byte[] smethod_1()
	{
		object @object = smethod_0().GetObject(GClass4.smethod_0(188), cultureInfo_0);
		return (byte[])@object;
	}
}
