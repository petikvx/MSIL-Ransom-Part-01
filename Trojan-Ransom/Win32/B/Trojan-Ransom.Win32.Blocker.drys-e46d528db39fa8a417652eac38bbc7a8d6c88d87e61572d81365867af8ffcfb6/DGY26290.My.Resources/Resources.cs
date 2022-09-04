using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace DGY26290.My.Resources;

[StandardModule]
[HideModuleName]
[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static _003F unknown_0
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("DGY26290.Resources", typeof(Resources).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static _003F unknown_1
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static _003F unknown_2 => ((ResourceManager)unknown_0).GetString("ky", resourceCulture);

	internal static _003F unknown_3 => ((ResourceManager)unknown_0).GetString("rn", resourceCulture);

	static int smethod_0()
	{
		/*Error: Unexpected end of block*/;
	}
}
