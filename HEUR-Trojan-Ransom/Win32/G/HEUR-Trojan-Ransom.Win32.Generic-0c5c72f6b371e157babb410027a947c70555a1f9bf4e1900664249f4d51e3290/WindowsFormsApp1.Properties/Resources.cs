using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Resources()
	{
	}

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (resourceManager_0 == null)
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("WindowsFormsApp1.Properties.Resources", typeof(Resources).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	[SpecialName]
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}
}
