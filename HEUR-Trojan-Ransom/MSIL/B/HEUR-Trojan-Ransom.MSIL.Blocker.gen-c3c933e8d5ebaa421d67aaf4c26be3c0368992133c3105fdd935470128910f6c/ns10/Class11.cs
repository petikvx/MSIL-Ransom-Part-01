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
	private static ResourceManager m_c;

	private static CultureInfo G;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager F
	{
		get
		{
			if (Class11.m_c == null)
			{
				Class11.m_c = new ResourceManager("I.i", typeof(Class11).Assembly);
			}
			return Class11.m_c;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo c
	{
		get
		{
			return G;
		}
		set
		{
			G = value;
		}
	}

	internal Class11()
	{
	}
}
