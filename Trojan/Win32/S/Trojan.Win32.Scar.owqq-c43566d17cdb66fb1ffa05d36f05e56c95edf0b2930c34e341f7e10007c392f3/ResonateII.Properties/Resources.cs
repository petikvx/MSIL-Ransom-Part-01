using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ResonateII.Properties;

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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("ResonateII.Properties.Resources", typeof(Resources).Assembly));
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

	internal static byte[] favicon
	{
		get
		{
			object @object = ResourceManager.GetObject("favicon", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] final_countdown
	{
		get
		{
			object @object = ResourceManager.GetObject("final_countdown", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] g
	{
		get
		{
			object @object = ResourceManager.GetObject("g", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static Bitmap logo
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("logo", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}
