using System.Runtime.CompilerServices;

internal struct Struct0
{
	public unsafe void* c139438d;

	[SpecialName]
	public unsafe static Struct0 smethod_0(void* pVoid_0)
	{
		Struct0 result = default(Struct0);
		result.c139438d = pVoid_0;
		return result;
	}

	[SpecialName]
	public unsafe static void* smethod_1(Struct0 struct0_0)
	{
		return struct0_0.c139438d;
	}
}
