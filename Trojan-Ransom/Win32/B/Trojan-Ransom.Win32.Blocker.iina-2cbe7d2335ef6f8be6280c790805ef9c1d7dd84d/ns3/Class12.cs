using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns3;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal sealed class Class12
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class12()
	{
	}

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("ns3.Class12", typeof(Class12).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static byte[] smethod_1()
	{
		object @object = smethod_0().GetObject("Sender", cultureInfo_0);
		return (byte[])@object;
	}
}
