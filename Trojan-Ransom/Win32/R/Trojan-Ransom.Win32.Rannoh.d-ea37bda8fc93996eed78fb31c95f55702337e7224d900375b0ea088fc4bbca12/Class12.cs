using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[HideModuleName]
[StandardModule]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class12
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Rechnung.exe.Resources", typeof(Class12).Assembly));
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
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("Rechnung", cultureInfo_0));
		return (byte[])objectValue;
	}

	internal static byte[] smethod_4()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("Rechnung1", cultureInfo_0));
		return (byte[])objectValue;
	}
}
