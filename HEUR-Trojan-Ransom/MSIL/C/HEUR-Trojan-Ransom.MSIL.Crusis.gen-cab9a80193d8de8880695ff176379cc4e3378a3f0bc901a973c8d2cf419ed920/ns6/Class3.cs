using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns6;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class3
{
	private static ResourceManager v;

	private static CultureInfo O;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager g
	{
		get
		{
			if (v == null)
			{
				v = new ResourceManager("h.h", typeof(Class3).Assembly);
			}
			return v;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo I
	{
		get
		{
			return O;
		}
		set
		{
			O = value;
		}
	}

	internal Class3()
	{
	}
}
