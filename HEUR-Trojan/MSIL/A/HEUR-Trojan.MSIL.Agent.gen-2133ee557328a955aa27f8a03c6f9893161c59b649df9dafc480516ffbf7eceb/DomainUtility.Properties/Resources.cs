using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DomainUtility.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
				resourceMan = new ResourceManager("DomainUtility.Properties.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap favicon22 => (Bitmap)ResourceManager.GetObject("favicon22", resourceCulture);

	internal static Bitmap favicon4 => (Bitmap)ResourceManager.GetObject("favicon4", resourceCulture);

	internal static Bitmap file => (Bitmap)ResourceManager.GetObject("file", resourceCulture);

	internal static Bitmap qr => (Bitmap)ResourceManager.GetObject("qr", resourceCulture);

	internal Resources()
	{
	}
}
