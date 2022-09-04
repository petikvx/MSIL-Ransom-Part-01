using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace O.My.Resources;

[HideModuleName]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal sealed class Class0
{
	private static CultureInfo cultureInfo_0;

	private static ResourceManager resourceManager_0;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static object Object_0
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

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static object Object_1
	{
		get
		{
			if (GClass2.DRV.smethod_0<object, object>(resourceManager_0, null, 992, 1002))
			{
				resourceManager_0 = new ResourceManager(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﺣﻂﺾﺉﺟﺃﺙﺞﺏﺉﺟ", 59249), 60862), 62509), Class3.smethod_0(typeof(Class0), 'ɝ', 'ɞ'));
			}
			return resourceManager_0;
		}
	}
}
