using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns10;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class11
{
	private static ResourceManager d;

	private static CultureInfo W;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager S
	{
		get
		{
			if (d == null)
			{
				d = new ResourceManager("t.J", typeof(Class11).Assembly);
			}
			return d;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo f
	{
		get
		{
			return W;
		}
		set
		{
			W = value;
		}
	}

	internal Class11()
	{
	}
}
