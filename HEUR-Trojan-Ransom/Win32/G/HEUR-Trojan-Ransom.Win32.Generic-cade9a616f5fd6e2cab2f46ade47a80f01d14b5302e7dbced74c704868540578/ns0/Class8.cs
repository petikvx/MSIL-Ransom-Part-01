using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
internal sealed class Class8
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager_0
	{
		get
		{
			if (Class3.Class7.smethod_1<object, object>(resourceManager_0, null, 315, 369))
			{
				ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Ⴓ.ႣႥ", Class3.smethod_7(typeof(Class8), 428, 'ǩ')));
			}
			return resourceManager_0;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo CultureInfo_0
	{
		get
		{
			return (CultureInfo)(IFormatProvider)cultureInfo_0;
		}
		set
		{
			cultureInfo_0 = value;
		}
	}

	[SpecialName]
	internal static byte[] smethod_0()
	{
		return (byte[])Class3.Class5.smethod_3(Class3.smethod_8(ResourceManager_0, "Server", cultureInfo_0, 955, 937), 847, 797);
	}
}
