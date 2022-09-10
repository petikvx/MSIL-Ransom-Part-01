using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
[DebuggerNonUserCode]
[HideModuleName]
internal sealed class Class0
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal static ResourceManager smethod_0()
	{
		ResourceManager resourceManager = default(ResourceManager);
		int num;
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			resourceManager = new ResourceManager(Class2.smethod_0("\udd9d躟\uf0a1솣향잧\udfa9\udeab춭햯솱", 3), typeof(Class0).Assembly);
			num = 0;
			goto IL_002e;
		}
		goto IL_0036;
		IL_002e:
		if (num == 0)
		{
			resourceManager_0 = resourceManager;
			goto IL_0036;
		}
		ResourceManager result = default(ResourceManager);
		return result;
		IL_0036:
		result = resourceManager_0;
		num = 1;
		goto IL_002e;
	}

	internal static byte[] smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject(Class2.smethod_0("펢", 8), cultureInfo_0));
		byte[] result = default(byte[]);
		for (int num = 0; num == 0; num = 1)
		{
			result = (byte[])objectValue;
		}
		return result;
	}
}
