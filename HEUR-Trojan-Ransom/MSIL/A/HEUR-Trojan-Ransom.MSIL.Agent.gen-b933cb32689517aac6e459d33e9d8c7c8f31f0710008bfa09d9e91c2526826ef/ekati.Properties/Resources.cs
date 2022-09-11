using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ekati.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("ekati.Properties.Resources", typeof(Resources).Assembly));
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

	internal static byte[] diamond
	{
		get
		{
			object @object = ResourceManager.GetObject("diamond", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] html
	{
		get
		{
			object @object = ResourceManager.GetObject("html", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] redback
	{
		get
		{
			object @object = ResourceManager.GetObject("redback", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] ruby
	{
		get
		{
			object @object = ResourceManager.GetObject("ruby", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
