using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal class LegionLocker4__0_Properties_Resources_002D1
{
	private static ResourceManager resourceMan_002D0;

	private static CultureInfo resourceCulture_002D1;

	internal static ResourceManager ResourceManager_002D0
	{
		get
		{
			if (resourceMan_002D0 == null)
			{
				ResourceManager resourceManager = (resourceMan_002D0 = new ResourceManager(_Constants_Generated_002D5.Field_716_002Dyb, typeof(LegionLocker4__0_Properties_Resources_002D1).Assembly));
			}
			return resourceMan_002D0;
		}
	}

	internal static CultureInfo Culture_002D1 => resourceCulture_002D1;

	internal static CultureInfo Culture_002D2
	{
		set
		{
			resourceCulture_002D1 = value;
		}
	}

	internal static byte[] wp_002D3
	{
		get
		{
			object @object = ResourceManager_002D0.GetObject(_Constants_Generated_002D5.Field_717_002Dzb, resourceCulture_002D1);
			return (byte[])@object;
		}
	}

	internal LegionLocker4__0_Properties_Resources_002D1()
	{
	}
}
