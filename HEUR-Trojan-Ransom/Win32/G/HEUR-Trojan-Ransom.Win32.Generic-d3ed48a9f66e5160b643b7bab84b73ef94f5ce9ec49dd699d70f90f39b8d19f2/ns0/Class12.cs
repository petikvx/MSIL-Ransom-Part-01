using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Class12
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
				resourceManager_0 = Delegate121.smethod_0("ns0.Class12", Delegate124.smethod_0(Delegate165.smethod_0(typeof(Class12).TypeHandle)));
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

	internal static string ExtensionsToEncrypt => Delegate125.smethod_0(ResourceManager, "ExtensionsToEncrypt", cultureInfo_0);

	internal static Bitmap pic1 => (Bitmap)Delegate221.smethod_0(ResourceManager, "pic1", cultureInfo_0);

	internal static string StartModeDebug => Delegate125.smethod_0(ResourceManager, "StartModeDebug", cultureInfo_0);

	internal static string vanityAddresses => Delegate125.smethod_0(ResourceManager, "vanityAddresses", cultureInfo_0);

	internal Class12()
	{
	}
}
