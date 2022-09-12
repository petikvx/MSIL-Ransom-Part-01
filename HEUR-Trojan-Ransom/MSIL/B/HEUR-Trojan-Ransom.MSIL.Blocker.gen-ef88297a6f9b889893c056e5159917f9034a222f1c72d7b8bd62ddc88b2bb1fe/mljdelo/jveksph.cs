using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace mljdelo;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class jveksph
{
	private static ResourceManager f;

	private static CultureInfo a;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager p
	{
		get
		{
			if (f == null)
			{
				f = new ResourceManager("T.E", typeof(jveksph).Assembly);
			}
			return f;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo h
	{
		get
		{
			return a;
		}
		set
		{
			a = value;
		}
	}

	internal jveksph()
	{
	}
}
