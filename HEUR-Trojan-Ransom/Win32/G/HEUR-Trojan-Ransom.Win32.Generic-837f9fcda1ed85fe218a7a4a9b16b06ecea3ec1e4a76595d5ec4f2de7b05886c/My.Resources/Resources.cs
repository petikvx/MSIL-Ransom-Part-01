using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace My.Resources;

internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("App", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	internal static byte[] Microsoft
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Microsoft", resourceCulture));
			return (byte[])objectValue;
		}
	}
}
