using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns9;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal sealed class Class5
{
	private static ResourceManager h;

	private static CultureInfo M;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager w
	{
		get
		{
			if (h == null)
			{
				h = new ResourceManager("T.Y", typeof(Class5).Assembly);
			}
			return h;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo w
	{
		get
		{
			return M;
		}
		set
		{
			M = value;
		}
	}

	internal Class5()
	{
	}
}
