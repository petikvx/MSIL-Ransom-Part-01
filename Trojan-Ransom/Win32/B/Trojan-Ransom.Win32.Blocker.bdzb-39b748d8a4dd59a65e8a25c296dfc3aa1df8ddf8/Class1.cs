using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;
using ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class1()
	{
		Class5.smethod_11();
	}

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("stub_2.netrsrc", typeof(Class1).Assembly));
		}
		ResourceManager result = resourceManager_0;
		Class5.smethod_7();
		return result;
	}

	internal static byte[] smethod_1()
	{
		byte[] result = (byte[])smethod_0().GetObject("f", cultureInfo_0);
		Class5.smethod_10();
		return result;
	}
}
