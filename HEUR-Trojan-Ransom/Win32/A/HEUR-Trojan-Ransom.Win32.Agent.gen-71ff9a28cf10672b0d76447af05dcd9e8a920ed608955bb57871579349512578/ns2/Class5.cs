using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns2;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[DebuggerNonUserCode]
internal sealed class Class5
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("تلغيم_صوره.Resources", typeof(Class5).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("paltalk", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static Bitmap smethod_2()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("shma", cultureInfo_0));
		return (Bitmap)objectValue;
	}
}
