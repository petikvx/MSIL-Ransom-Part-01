using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Creep.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Creep.Properties.Resources", typeof(Resources).Assembly));
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

	internal static byte[] _000
	{
		get
		{
			object @object = ResourceManager.GetObject("_000", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] one
	{
		get
		{
			object @object = ResourceManager.GetObject("one", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] street
	{
		get
		{
			object @object = ResourceManager.GetObject("street", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] subox
	{
		get
		{
			object @object = ResourceManager.GetObject("subox", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] texticon
	{
		get
		{
			object @object = ResourceManager.GetObject("texticon", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] txt
	{
		get
		{
			object @object = ResourceManager.GetObject("txt", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] windl
	{
		get
		{
			object @object = ResourceManager.GetObject("windl", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
