using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Main.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
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
				resourceMan = new ResourceManager("Main.Properties.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap _5a52207f2f93c7a8d5137fd4 => (Bitmap)ResourceManager.GetObject("5a52207f2f93c7a8d5137fd4", resourceCulture);

	internal static Bitmap always_encrypted => (Bitmap)ResourceManager.GetObject("always_encrypted", resourceCulture);

	internal static Bitmap BC_Logo_ => (Bitmap)ResourceManager.GetObject("BC_Logo_", resourceCulture);

	internal static Bitmap Bitcoin => (Bitmap)ResourceManager.GetObject("Bitcoin", resourceCulture);

	internal static string ExtensionsToEncrypt => ResourceManager.GetString("ExtensionsToEncrypt", resourceCulture);

	internal static Bitmap Jigsaw => (Bitmap)ResourceManager.GetObject("Jigsaw", resourceCulture);

	internal static string StartModeDebug => ResourceManager.GetString("StartModeDebug", resourceCulture);

	internal static string vanityAddresses => ResourceManager.GetString("vanityAddresses", resourceCulture);

	internal Resources()
	{
	}
}
