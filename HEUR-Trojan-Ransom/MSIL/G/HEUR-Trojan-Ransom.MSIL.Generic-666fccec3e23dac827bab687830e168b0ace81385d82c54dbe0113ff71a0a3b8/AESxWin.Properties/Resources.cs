using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace AESxWin.Properties;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("AESxWin.Properties.Resources", typeof(Resources).Assembly));
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

	internal static Bitmap _6hBktkqTURBXy85YmI4NzIwM2RiNGI5YmViNTEyMTI4MGNmMThhYjJmMC5qcGVnkpUCzQPAAMLDlQIAzQPAwsM
	{
		get
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("6hBktkqTURBXy85YmI4NzIwM2RiNGI5YmViNTEyMTI4MGNmMThhYjJmMC5qcGVnkpUCzQPAAMLDlQIAzQPAwsM", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static byte[] nn
	{
		get
		{
			object @object = ResourceManager.GetObject("nn", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static string Nowy_dokument_tekstowy => ResourceManager.GetString("Nowy_dokument_tekstowy", resourceCulture);

	internal Resources()
	{
	}
}
