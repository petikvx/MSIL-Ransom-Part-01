using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace clinn.My.Resources;

[DebuggerNonUserCode]
[HideModuleName]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[CompilerGenerated]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (object.ReferenceEquals(resourceManager_0, null))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0("\ufe08\ufe07\ufe02\ufe05\ufe05﹅︹\ufe0e︘\ufe04\ufe1e︙\ufe08\ufe0e︘", 61865), 59202), 59583), typeof(Resources).Assembly));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
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

	internal static byte[] Byte_0
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager_0.GetObject(Class6.smethod_0(Class8.smethod_0(Class10.smethod_0("\ue414\ue422\ue435\ue431\ue422\ue435", 61878), 60739), 63610), cultureInfo_0));
			return (byte[])objectValue;
		}
	}
}
