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
internal class ZZZZg
{
	private static ResourceManager ZZZZh;

	private static CultureInfo ZZZZi;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ZZZZj
	{
		get
		{
			if (ZZZZh == null)
			{
				ZZZZh = new ResourceManager("Loki.Properties.ZZZZg", typeof(ZZZZg).Assembly);
			}
			return ZZZZh;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo ZZZZk
	{
		get
		{
			return ZZZZi;
		}
		set
		{
			ZZZZi = value;
		}
	}

	internal static Icon ZZZZl => (Icon)ZZZZj.GetObject("_lock", ZZZZi);

	internal static string ZZZZm => ZZZZj.GetString("info_min", ZZZZi);

	internal static byte[] ZZZZn => (byte[])ZZZZj.GetObject("MBR", ZZZZi);

	internal static string ZZZZo => ZZZZj.GetString("update", ZZZZi);

	internal extern ZZZZg();
}
