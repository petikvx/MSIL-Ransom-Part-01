using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns2;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal class Class2
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class2()
	{
	}

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		bool flag;
		if (!(flag = !object.ReferenceEquals(resourceManager_0, null)))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns2.Class2", typeof(Class2).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static string smethod_1()
	{
		return smethod_0().GetString("String1", cultureInfo_0);
	}
}
