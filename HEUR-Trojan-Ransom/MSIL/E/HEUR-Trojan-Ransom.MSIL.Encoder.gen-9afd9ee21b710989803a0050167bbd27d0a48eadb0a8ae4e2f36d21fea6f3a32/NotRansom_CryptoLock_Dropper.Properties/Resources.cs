using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace NotRansom_CryptoLock_Dropper.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
				resourceMan = new ResourceManager("NotRansom_CryptoLock_Dropper.Properties.Resources", typeof(Resources).Assembly);
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

	internal static string autorun => ResourceManager.GetString("autorun", resourceCulture);

	internal static byte[] d => (byte[])ResourceManager.GetObject("d", resourceCulture);

	internal static byte[] e => (byte[])ResourceManager.GetObject("e", resourceCulture);

	internal static byte[] n => (byte[])ResourceManager.GetObject("n", resourceCulture);

	internal static byte[] w => (byte[])ResourceManager.GetObject("w", resourceCulture);

	internal Resources()
	{
	}
}
