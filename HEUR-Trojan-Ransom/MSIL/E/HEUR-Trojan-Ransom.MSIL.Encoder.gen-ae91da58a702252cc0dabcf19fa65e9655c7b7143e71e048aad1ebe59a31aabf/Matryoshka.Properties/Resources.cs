using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Matryoshka.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
				resourceMan = new ResourceManager("Matryoshka.Properties.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap Matryoshka => (Bitmap)ResourceManager.GetObject("Matryoshka", resourceCulture);

	internal static Bitmap Monero => (Bitmap)ResourceManager.GetObject("Monero", resourceCulture);

	internal static string MsgEn => ResourceManager.GetString("MsgEn", resourceCulture);

	internal static string MsgRu => ResourceManager.GetString("MsgRu", resourceCulture);

	internal static Icon NitroSniper => (Icon)ResourceManager.GetObject("NitroSniper", resourceCulture);

	internal Resources()
	{
	}
}
