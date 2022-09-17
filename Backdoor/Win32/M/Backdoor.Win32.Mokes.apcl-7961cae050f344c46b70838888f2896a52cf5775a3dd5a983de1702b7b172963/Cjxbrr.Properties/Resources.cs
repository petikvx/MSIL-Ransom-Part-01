using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Cjxbrr.Properties;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal class Resources
{
	private static ResourceManager uimp;

	private static CultureInfo uimq;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager xwsw
	{
		get
		{
			if (uimp == null)
			{
				ResourceManager resourceManager = (uimp = new ResourceManager("Cjxbrr.Properties.Resources", typeof(Resources).Assembly));
			}
			return uimp;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo xwsx
	{
		get
		{
			return uimq;
		}
		set
		{
			uimq = value;
		}
	}

	internal Resources()
	{
	}
}
