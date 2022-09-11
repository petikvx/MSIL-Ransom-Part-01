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
	private static ResourceManager I;

	private static CultureInfo x;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager U
	{
		get
		{
			if (I == null)
			{
				I = new ResourceManager("I.S", typeof(Class11).Assembly);
			}
			return I;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo p
	{
		get
		{
			return x;
		}
		set
		{
			x = value;
		}
	}

	internal Class11()
	{
	}
}
