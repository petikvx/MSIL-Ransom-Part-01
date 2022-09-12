using System.Reflection;

internal struct Struct4
{
	public readonly uint uint_0;

	public readonly uint uint_1;

	public readonly Class61 class61_0;

	public unsafe Struct4(ref byte* pByte_0, Module module_0)
	{
		uint_0 = *(uint*)pByte_0;
		pByte_0 += 4;
		if (uint_0 != 0)
		{
			uint_1 = *(uint*)pByte_0;
			pByte_0 += 4;
		}
		else
		{
			uint_1 = 0u;
		}
		class61_0 = new Class61(ref pByte_0, module_0);
	}
}
