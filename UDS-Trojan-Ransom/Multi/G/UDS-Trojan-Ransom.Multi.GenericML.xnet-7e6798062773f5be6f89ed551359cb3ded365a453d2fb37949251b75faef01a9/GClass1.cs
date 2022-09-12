using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
public sealed class GClass1
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal GClass1()
	{
	}

	public static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(Class7.smethod_0(-1566193265), typeof(GClass1).Assembly));
		}
		return resourceManager_0;
	}

	public static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	public static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}

	public static string smethod_3()
	{
		return smethod_0().GetString(Class7.smethod_0(-1566193256), cultureInfo_0);
	}

	public static string smethod_4()
	{
		return smethod_0().GetString(Class7.smethod_0(-1566193257), cultureInfo_0);
	}

	public static Point smethod_5()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject(Class7.smethod_0(-1566193050), cultureInfo_0));
		return (objectValue != null) ? ((Point)objectValue) : default(Point);
	}
}
