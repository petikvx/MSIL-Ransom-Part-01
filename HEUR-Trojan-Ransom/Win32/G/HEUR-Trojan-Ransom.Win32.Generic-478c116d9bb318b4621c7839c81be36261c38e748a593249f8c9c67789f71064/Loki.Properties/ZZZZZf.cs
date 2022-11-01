using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Loki.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class ZZZZZf
{
	private static ResourceManager ZZZZZg;

	private static CultureInfo ZZZZZh;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ZZZZZi
	{
		get
		{
			if (ZZZZZg == null)
			{
				ZZZZZg = new ResourceManager("Loki.Properties.ZZZZZf", typeof(ZZZZZf).Assembly);
			}
			return ZZZZZg;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo ZZZZZj
	{
		get
		{
			return ZZZZZh;
		}
		set
		{
			ZZZZZh = value;
		}
	}

	internal static Icon ZZZZZk => (Icon)ZZZZZi.GetObject("_lock", ZZZZZh);

	internal static string ZZZZZl => ZZZZZi.GetString("info_min", ZZZZZh);

	internal static Bitmap ZZZZZm => (Bitmap)ZZZZZi.GetObject("logo", ZZZZZh);

	internal static byte[] ZZZZZn => (byte[])ZZZZZi.GetObject("MBR", ZZZZZh);

	internal static string ZZZZZo => ZZZZZi.GetString("update", ZZZZZh);

	internal extern ZZZZZf();
}
