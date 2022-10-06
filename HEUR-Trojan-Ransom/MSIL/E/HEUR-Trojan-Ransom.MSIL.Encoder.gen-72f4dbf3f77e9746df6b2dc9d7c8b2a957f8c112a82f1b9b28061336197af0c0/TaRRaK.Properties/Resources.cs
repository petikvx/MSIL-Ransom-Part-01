using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TaRRaK.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
				resourceMan = new ResourceManager("TaRRaK.Properties.Resources", typeof(Resources).Assembly);
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

	internal static string extensions => ResourceManager.GetString("extensions", resourceCulture);

	internal static string Note_fom_TaRRaK => ResourceManager.GetString("Note_fom_TaRRaK", resourceCulture);

	internal static Icon tarrak => (Icon)ResourceManager.GetObject("tarrak", resourceCulture);

	internal static Bitmap wallpaper => (Bitmap)ResourceManager.GetObject("wallpaper", resourceCulture);

	internal Resources()
	{
	}
}
