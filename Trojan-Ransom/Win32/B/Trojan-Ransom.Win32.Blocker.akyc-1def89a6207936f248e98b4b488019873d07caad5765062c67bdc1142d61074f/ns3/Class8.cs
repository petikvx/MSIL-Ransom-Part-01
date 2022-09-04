using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns3;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
[StandardModule]
[CompilerGenerated]
internal sealed class Class8
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
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Eddy.Resources", typeof(Class8).Assembly));
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

	internal static byte[] x
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("x", cultureInfo_0));
			return (byte[])objectValue;
		}
	}
}
