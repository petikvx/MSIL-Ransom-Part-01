using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DownloadManagerSetup.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("DownloadManagerSetup.Properties.Resources", typeof(Resources).Assembly));
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

	internal static byte[] fnt
	{
		get
		{
			object @object = ResourceManager.GetObject("fnt", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] icon
	{
		get
		{
			object @object = ResourceManager.GetObject("icon", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] Ionic_Zip
	{
		get
		{
			object @object = ResourceManager.GetObject("Ionic_Zip", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] M
	{
		get
		{
			object @object = ResourceManager.GetObject("M", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] uninstall
	{
		get
		{
			object @object = ResourceManager.GetObject("uninstall", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] VideoPerformer
	{
		get
		{
			object @object = ResourceManager.GetObject("VideoPerformer", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
