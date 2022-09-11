using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns8;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class7
{
	private static ResourceManager I;

	private static CultureInfo f;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager k
	{
		get
		{
			if (I == null)
			{
				I = new ResourceManager("n.e", typeof(Class7).Assembly);
			}
			return I;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo x
	{
		get
		{
			return f;
		}
		set
		{
			f = value;
		}
	}

	internal Class7()
	{
	}
}
