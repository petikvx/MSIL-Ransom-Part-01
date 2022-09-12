using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace fuck_rats_antivirus.My.Resources;

[DebuggerNonUserCode]
[StandardModule]
[CompilerGenerated]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				resourceMan = new ResourceManager("fuck_rats_antivirus.Resources", typeof(Resources).Assembly);
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

	internal static Bitmap d9zp1s9_d7d0a4e4_240a_413d_a6f6_460c2451a278 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("d9zp1s9-d7d0a4e4-240a-413d-a6f6-460c2451a278", resourceCulture));

	internal static Bitmap H_alternate_3 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("H_alternate_3", resourceCulture));

	internal static UnmanagedMemoryStream tfr => ResourceManager.GetStream("tfr", resourceCulture);
}
