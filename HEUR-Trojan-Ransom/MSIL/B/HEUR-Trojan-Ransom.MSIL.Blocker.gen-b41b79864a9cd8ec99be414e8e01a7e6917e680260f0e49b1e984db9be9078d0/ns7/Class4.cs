using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns7;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class4
{
	private static ResourceManager S;

	private static CultureInfo f;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager b
	{
		get
		{
			if (S == null)
			{
				S = new ResourceManager("V.K", typeof(Class4).Assembly);
			}
			return S;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo G
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

	internal Class4()
	{
	}
}
