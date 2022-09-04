using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace System_Maintenance_Installer.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("System_Maintenance_Installer.Properties.Resources", typeof(Resources).Assembly));
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

	internal static Bitmap _378
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("378", resourceCulture);
			return (Bitmap)@object;
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

	internal static byte[] notify1
	{
		get
		{
			object @object = ResourceManager.GetObject("notify1", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static Bitmap Progress_bar
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("Progress_bar", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static byte[] System_Maintenance
	{
		get
		{
			object @object = ResourceManager.GetObject("System_Maintenance", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] System_Maintenance_Updater
	{
		get
		{
			object @object = ResourceManager.GetObject("System_Maintenance_Updater", resourceCulture);
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

	internal static byte[] upToDate1
	{
		get
		{
			object @object = ResourceManager.GetObject("upToDate1", resourceCulture);
			return (byte[])@object;
		}
	}

	internal Resources()
	{
	}
}
