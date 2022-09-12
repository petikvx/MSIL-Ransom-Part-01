using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Kzzdehomtdt.Properties;

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
				resourceMan = new ResourceManager("Kzzdehomtdt.Properties.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap _00_Blanco => (Bitmap)ResourceManager.GetObject("_00_Blanco", resourceCulture);

	internal static Bitmap _01_Smile => (Bitmap)ResourceManager.GetObject("_01_Smile", resourceCulture);

	internal static Bitmap _02_Laugh => (Bitmap)ResourceManager.GetObject("_02_Laugh", resourceCulture);

	internal static Bitmap _03_Silly => (Bitmap)ResourceManager.GetObject("_03_Silly", resourceCulture);

	internal static Bitmap _04_Wink => (Bitmap)ResourceManager.GetObject("_04_Wink", resourceCulture);

	internal static Bitmap _05_Blush => (Bitmap)ResourceManager.GetObject("_05_Blush", resourceCulture);

	internal static Bitmap _06_Sad => (Bitmap)ResourceManager.GetObject("_06_Sad", resourceCulture);

	internal Resources()
	{
	}
}
