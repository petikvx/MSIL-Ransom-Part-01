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

namespace CyberProt.My.Resources;

[CompilerGenerated]
[DebuggerNonUserCode]
[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager a;

	private static CultureInfo b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(a, null))
			{
				a = new ResourceManager("CyberProt.Resources", typeof(Resources).Assembly);
			}
			return a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return b;
		}
		set
		{
			b = value;
		}
	}

	internal static UnmanagedMemoryStream Allert => ResourceManager.GetStream("Allert", b);

	internal static UnmanagedMemoryStream Click => ResourceManager.GetStream("Click", b);

	internal static UnmanagedMemoryStream Error_ => ResourceManager.GetStream("Error_", b);

	internal static UnmanagedMemoryStream Hoover => ResourceManager.GetStream("Hoover", b);

	internal static Bitmap line1 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("line1", b));

	internal static UnmanagedMemoryStream OK => ResourceManager.GetStream("OK", b);

	internal static byte[] runtime => (byte[])RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("runtime", b));

	internal static UnmanagedMemoryStream slide => ResourceManager.GetStream("slide", b);
}
