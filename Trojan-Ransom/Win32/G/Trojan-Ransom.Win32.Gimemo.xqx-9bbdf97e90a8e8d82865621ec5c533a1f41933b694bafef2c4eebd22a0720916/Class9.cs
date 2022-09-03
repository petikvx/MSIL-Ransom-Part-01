using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
internal sealed class Class9
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("cssrss.Resources", typeof(Class9).Assembly));
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
}
