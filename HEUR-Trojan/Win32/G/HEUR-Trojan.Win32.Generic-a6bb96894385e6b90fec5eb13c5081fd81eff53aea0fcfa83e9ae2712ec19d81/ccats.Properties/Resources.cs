using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ccats.Properties;

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
				resourceMan = new ResourceManager("ccats.Properties.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap asd => (Bitmap)ResourceManager.GetObject("asd", resourceCulture);

	internal static string ExtensionsToEncrypt => ResourceManager.GetString("ExtensionsToEncrypt", resourceCulture);

	internal static Bitmap f307d2546dfa425c6df994a787f2f540 => (Bitmap)ResourceManager.GetObject("f307d2546dfa425c6df994a787f2f540", resourceCulture);

	internal static string StartModeDebug => ResourceManager.GetString("StartModeDebug", resourceCulture);

	internal static string vanityAddresses => ResourceManager.GetString("vanityAddresses", resourceCulture);

	internal Resources()
	{
	}
}
