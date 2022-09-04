using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace dLadvAgB.My.Resources;

[CompilerGenerated]
[DebuggerNonUserCode]
[HideModuleName]
[StandardModule]
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("dLadvAgB.Resources", typeof(Resources).Assembly));
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

	internal static _003F unknown_3
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(((ResourceManager)unknown_0).GetObject("rsc", resourceCulture));
			return (byte[])objectValue;
		}
	}

	static void u15()
	{
		/*Error: Unexpected end of block*/;
	}
}
