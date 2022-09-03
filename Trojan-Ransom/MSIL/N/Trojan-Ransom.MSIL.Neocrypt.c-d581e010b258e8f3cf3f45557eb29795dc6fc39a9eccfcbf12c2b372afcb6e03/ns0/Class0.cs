using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

internal class Class0
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class0()
	{
	}

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns0.Class0", typeof(Class0).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		object @object = smethod_0().GetObject("Release", cultureInfo_0);
		return (byte[])@object;
	}
}
