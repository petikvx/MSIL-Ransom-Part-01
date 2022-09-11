using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns9;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class5
{
	private static ResourceManager m_q;

	private static CultureInfo A;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager e
	{
		get
		{
			if (Class5.m_q == null)
			{
				Class5.m_q = new ResourceManager("X.d", typeof(Class5).Assembly);
			}
			return Class5.m_q;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo q
	{
		get
		{
			return A;
		}
		set
		{
			A = value;
		}
	}

	internal Class5()
	{
	}
}
