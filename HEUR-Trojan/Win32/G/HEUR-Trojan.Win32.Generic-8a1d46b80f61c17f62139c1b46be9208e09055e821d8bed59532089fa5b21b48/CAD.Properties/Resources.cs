using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace CAD.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("CAD.Properties.Resources", typeof(Resources).Assembly));
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

	internal static byte[] CADdecryptor
	{
		get
		{
			object @object = ResourceManager.GetObject("CADdecryptor", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static string CADMessage => ResourceManager.GetString("CADMessage", resourceCulture);

	internal static string CryptoJokerMessage => ResourceManager.GetString("CryptoJokerMessage", resourceCulture);

	internal Resources()
	{
	}
}
