using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Handyware;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[DebuggerNonUserCode]
internal class Resource1
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Handyware.Resource1", typeof(Resource1).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] genuinewindows_wp
	{
		get
		{
			object @object = ResourceManager.GetObject("genuinewindows_wp", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] monitor
	{
		get
		{
			object @object = ResourceManager.GetObject("monitor", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resource1()
	{
	}
}
