using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Iprzvlwlyurz;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class Class2
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class2()
	{
	}

	internal static ResourceManager smethod_0()
	{
		if (resourceManager_0 == null)
		{
			resourceManager_0 = new ResourceManager("Iprzvlwlyurz.Properties.Resources", typeof(Class2).Assembly);
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
		return (byte[])smethod_0().GetObject("Rhzokguyrumtm", cultureInfo_0);
	}

	internal static byte[] smethod_4()
	{
		return (byte[])smethod_0().GetObject("Bkfyzxhmexs", cultureInfo_0);
	}
}
