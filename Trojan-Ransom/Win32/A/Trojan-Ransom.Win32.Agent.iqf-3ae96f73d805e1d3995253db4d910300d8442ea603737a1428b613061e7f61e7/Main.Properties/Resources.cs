using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Main.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static extern ResourceManager ResourceManager { get; }

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static extern CultureInfo Culture { get; set; }

	internal static extern string ExtensionsToEncrypt { get; }

	internal static extern Bitmap Jigsaw { get; }

	internal static extern string StartModeDebug { get; }

	internal static extern string vanityAddresses { get; }

	internal extern Resources();
}
