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
internal class ZZZZl
{
	private static ResourceManager ZZZZm;

	private static CultureInfo ZZZZn;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ZZZZo
	{
		get
		{
			if (ZZZZm == null)
			{
				ZZZZm = new ResourceManager("Loki.Properties.ZZZZl", typeof(ZZZZl).Assembly);
			}
			return ZZZZm;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo ZZZZp
	{
		get
		{
			return ZZZZn;
		}
		set
		{
			ZZZZn = value;
		}
	}

	internal static Icon ZZZZq => (Icon)ZZZZo.GetObject("_lock", ZZZZn);

	internal static string ZZZZr => ZZZZo.GetString("info_min", ZZZZn);

	internal static byte[] ZZZZs => (byte[])ZZZZo.GetObject("MBR", ZZZZn);

	internal static string ZZZZt => ZZZZo.GetString("update", ZZZZn);

	internal extern ZZZZl();
}
