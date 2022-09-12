using System.Reflection;

internal struct Struct5
{
	public readonly uint uint_0;

	public readonly uint a645929e;

	public readonly Class68 b7d05965;

	public unsafe Struct5(ref byte* pByte_0, Module module_0)
	{
		uint_0 = *(uint*)pByte_0;
		pByte_0 += 4;
		if (uint_0 != 0)
		{
			a645929e = *(uint*)pByte_0;
			pByte_0 += 4;
		}
		else
		{
			a645929e = 0u;
		}
		b7d05965 = new Class68(ref pByte_0, module_0);
	}
}
