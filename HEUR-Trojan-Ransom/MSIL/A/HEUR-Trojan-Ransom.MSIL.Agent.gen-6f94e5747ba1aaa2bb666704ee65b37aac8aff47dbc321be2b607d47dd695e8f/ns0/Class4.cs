using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class Class4
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceManager_0 == null)
			{
				resourceManager_0 = new ResourceManager("ns0.Class4", typeof(Class4).Assembly);
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static string ExtensionsToEncrypt => ResourceManager.GetString("ExtensionsToEncrypt", cultureInfo_0);

	internal static Bitmap Jigsaw => (Bitmap)ResourceManager.GetObject("Jigsaw", cultureInfo_0);

	internal static string StartModeDebug => ResourceManager.GetString("StartModeDebug", cultureInfo_0);

	internal static string vanityAddresses => ResourceManager.GetString("vanityAddresses", cultureInfo_0);

	internal Class4()
	{
	}
}
