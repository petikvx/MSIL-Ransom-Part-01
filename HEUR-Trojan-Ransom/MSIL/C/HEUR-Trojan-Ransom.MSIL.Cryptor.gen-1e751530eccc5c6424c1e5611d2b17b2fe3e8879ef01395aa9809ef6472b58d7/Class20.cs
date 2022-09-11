using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class20
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class20()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (resourceManager_0 == null)
		{
			resourceManager_0 = new ResourceManager(Class4.smethod_0(-1659687952), typeof(Class20).Assembly);
		}
		return resourceManager_0;
	}

	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}

	internal static byte[] smethod_3()
	{
		return (byte[])smethod_0().GetObject(Class4.smethod_0(-1659687987), cultureInfo_0);
	}

	internal static byte[] smethod_4()
	{
		return (byte[])smethod_0().GetObject(Class4.smethod_0(-1659690926), cultureInfo_0);
	}
}
