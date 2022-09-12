using System.Runtime.CompilerServices;

internal struct Struct1
{
	public unsafe void* f3077d6d;

	[SpecialName]
	public unsafe static Struct1 d9a770c4(void* pVoid_0)
	{
		Struct1 result = default(Struct1);
		result.f3077d6d = pVoid_0;
		return result;
	}

	[SpecialName]
	public unsafe static void* d9a770c4(Struct1 struct1_0)
	{
		return struct1_0.f3077d6d;
	}
}
