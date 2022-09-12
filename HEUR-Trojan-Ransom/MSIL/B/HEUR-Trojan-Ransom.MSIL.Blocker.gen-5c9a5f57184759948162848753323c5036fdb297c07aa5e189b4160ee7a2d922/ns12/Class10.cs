using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns12;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Class10
{
	private static ResourceManager R;

	private static CultureInfo b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager C
	{
		get
		{
			if (R == null)
			{
				R = new ResourceManager("v.q", typeof(Class10).Assembly);
			}
			return R;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo g
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

	internal Class10()
	{
	}
}
