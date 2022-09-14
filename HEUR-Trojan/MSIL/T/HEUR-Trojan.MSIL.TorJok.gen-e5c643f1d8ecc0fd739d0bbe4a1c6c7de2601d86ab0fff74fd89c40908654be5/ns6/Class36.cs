using System.IO;
using System.Runtime.CompilerServices;
using ns1;
using ns3;

namespace ns6;

internal sealed class Class36
{
	public int int_0;

	public MemoryStream memoryStream_0;

	public int int_1;

	public Class31 class31_0;

	[CompilerGenerated]
	private Class32 class32_0;

	[SpecialName]
	[CompilerGenerated]
	public Class32 method_0()
	{
		return class32_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Class32 class32_1)
	{
		class32_0 = class32_1;
	}

	public Class36(int int_2, int int_3)
	{
		memoryStream_0 = new MemoryStream();
		class31_0 = new Class31(memoryStream_0);
		method_1(new Class32(class31_0, int_3));
		int_0 = int_2;
	}
}
