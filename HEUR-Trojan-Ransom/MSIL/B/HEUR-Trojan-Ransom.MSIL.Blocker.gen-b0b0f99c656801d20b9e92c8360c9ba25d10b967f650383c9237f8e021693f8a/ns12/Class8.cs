using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns12;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class8
{
	private static ResourceManager e;

	private static CultureInfo L;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager d
	{
		get
		{
			if (e == null)
			{
				e = new ResourceManager("M.P", typeof(Class8).Assembly);
			}
			return e;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo K
	{
		get
		{
			return L;
		}
		set
		{
			L = value;
		}
	}

	internal Class8()
	{
	}
}
