using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns9;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[DebuggerNonUserCode]
internal sealed class Class6
{
	private static ResourceManager m_T;

	private static CultureInfo P;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager w
	{
		get
		{
			if (Class6.m_T == null)
			{
				Class6.m_T = new ResourceManager("u.M", typeof(Class6).Assembly);
			}
			return Class6.m_T;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo T
	{
		get
		{
			return P;
		}
		set
		{
			P = value;
		}
	}

	internal Class6()
	{
	}
}
