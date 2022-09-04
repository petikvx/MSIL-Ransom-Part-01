using System;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;

[SuppressIldasm]
internal sealed class Class2
{
	internal static ResourceManager resourceManager_0;

	internal static byte[] byte_0;

	[NonSerialized]
	internal static GDelegate0 gdelegate0_0;

	static Class2()
	{
		GClass1.smethod_0(typeof(Class2));
		resourceManager_0 = new ResourceManager(gdelegate0_0(209), typeof(Class2).Assembly);
		byte_0 = Encoding.UTF8.GetBytes(gdelegate0_0(222));
	}
}
