using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace zahog;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class nlnbz
{
	private static ResourceManager m_Y;

	private static CultureInfo H;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager Y
	{
		get
		{
			if (nlnbz.m_Y == null)
			{
				nlnbz.m_Y = new ResourceManager("V.O", typeof(nlnbz).Assembly);
			}
			return nlnbz.m_Y;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo L
	{
		get
		{
			return H;
		}
		set
		{
			H = value;
		}
	}

	internal nlnbz()
	{
	}
}
