using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns2;

internal sealed class Class3
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("A", typeof(Class3).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("Windows", cultureInfo_0));
		return (byte[])objectValue;
	}
}
