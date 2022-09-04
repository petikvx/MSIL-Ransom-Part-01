using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Cauet_Locker.My.Resources;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[StandardModule]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("Cauet_Locker.Resources", typeof(Resources).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	[SpecialName]
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}

	[SpecialName]
	internal static Bitmap smethod_3()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("background", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_4()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("loading", cultureInfo_0));
		return (Bitmap)objectValue;
	}

	[SpecialName]
	internal static byte[] smethod_5()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("WebCamLib", cultureInfo_0));
		return (byte[])objectValue;
	}
}
