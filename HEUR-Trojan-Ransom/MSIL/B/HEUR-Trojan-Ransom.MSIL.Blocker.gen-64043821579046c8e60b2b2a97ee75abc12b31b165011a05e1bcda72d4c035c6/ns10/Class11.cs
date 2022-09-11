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
	private static ResourceManager w;

	private static CultureInfo I;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager m
	{
		get
		{
			if (w == null)
			{
				w = new ResourceManager("p.V", typeof(Class11).Assembly);
			}
			return w;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo i
	{
		get
		{
			return I;
		}
		set
		{
			I = value;
		}
	}

	internal Class11()
	{
	}
}
