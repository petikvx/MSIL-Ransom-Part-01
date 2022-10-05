using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace clown.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
				resourceMan = new ResourceManager("clown.Properties.Resources", typeof(Resources).Assembly);
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

	internal static byte[] bgImg => (byte[])ResourceManager.GetObject("bgImg", resourceCulture);

	internal static byte[] bsod => (byte[])ResourceManager.GetObject("bsod", resourceCulture);

	internal static byte[] clownForm => (byte[])ResourceManager.GetObject("clownForm", resourceCulture);

	internal static byte[] csCreepy => (byte[])ResourceManager.GetObject("csCreepy", resourceCulture);

	internal static byte[] draw => (byte[])ResourceManager.GetObject("draw", resourceCulture);

	internal static byte[] regvbs => (byte[])ResourceManager.GetObject("regvbs", resourceCulture);

	internal static byte[] turnOff => (byte[])ResourceManager.GetObject("turnOff", resourceCulture);

	internal Resources()
	{
	}
}
