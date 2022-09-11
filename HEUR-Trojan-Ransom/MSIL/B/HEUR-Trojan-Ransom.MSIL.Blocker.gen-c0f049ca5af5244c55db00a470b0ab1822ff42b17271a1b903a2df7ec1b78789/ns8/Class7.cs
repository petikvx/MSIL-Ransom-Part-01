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
	private static ResourceManager G;

	private static CultureInfo m;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager o
	{
		get
		{
			if (G == null)
			{
				G = new ResourceManager("R.f", typeof(Class7).Assembly);
			}
			return G;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo x
	{
		get
		{
			return m;
		}
		set
		{
			m = value;
		}
	}

	internal Class7()
	{
	}
}
