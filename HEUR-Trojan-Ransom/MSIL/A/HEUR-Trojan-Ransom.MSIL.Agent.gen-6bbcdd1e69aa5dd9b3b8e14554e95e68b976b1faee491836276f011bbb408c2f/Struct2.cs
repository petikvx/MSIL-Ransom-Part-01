using System.Runtime.CompilerServices;

internal struct Struct2
{
	public unsafe void* cb7ea338;

	[SpecialName]
	public unsafe static Struct2 smethod_0(void* pVoid_0)
	{
		Struct2 result = default(Struct2);
		result.cb7ea338 = pVoid_0;
		return result;
	}

	[SpecialName]
	public unsafe static void* smethod_1(Struct2 struct2_0)
	{
		return struct2_0.cb7ea338;
	}
}
