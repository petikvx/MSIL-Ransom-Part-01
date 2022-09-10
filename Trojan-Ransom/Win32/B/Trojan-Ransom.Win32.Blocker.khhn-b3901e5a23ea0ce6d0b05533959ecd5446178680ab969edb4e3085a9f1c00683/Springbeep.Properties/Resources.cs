using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Springbeep.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[CompilerGenerated]
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
				resourceMan = new ResourceManager("Springbeep.Properties.Resources", typeof(Resources).Assembly);
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

	internal static byte[] blackwall => (byte[])ResourceManager.GetObject("blackwall", resourceCulture);

	internal static byte[] mode => (byte[])ResourceManager.GetObject("mode", resourceCulture);

	internal static byte[] sbeicon => (byte[])ResourceManager.GetObject("sbeicon", resourceCulture);

	internal static byte[] sbpicon => (byte[])ResourceManager.GetObject("sbpicon", resourceCulture);

	internal static byte[] winload => (byte[])ResourceManager.GetObject("winload", resourceCulture);

	internal Resources()
	{
	}
}
