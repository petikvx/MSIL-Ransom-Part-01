using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns6;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
[HideModuleName]
[StandardModule]
[DebuggerNonUserCode]
internal sealed class Class7
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Holo.Resources", typeof(Class7).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	internal static byte[] Load
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("Load", cultureInfo_0));
			return (byte[])objectValue;
		}
	}
}
