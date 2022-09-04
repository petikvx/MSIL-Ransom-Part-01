using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace SteamStealer.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static CultureInfo cultureInfo_0;

	private static ResourceManager resourceManager_0;

	internal static CultureInfo smethod_0()
	{
		return cultureInfo_0;
	}

	internal static void smethod_1(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}

	internal static ResourceManager smethod_2()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("SteamStealer.Properties.Resources", typeof(Resources).Assembly));
		}
		return resourceManager_0;
	}
}
