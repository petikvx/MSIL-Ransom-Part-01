using System.Reflection;

internal struct Struct2
{
	public readonly uint uint_0;

	public readonly uint uint_1;

	public readonly ff656cf5 f8b7206e;

	public unsafe Struct2(ref byte* pByte_0, Module module_0)
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
		f8b7206e = new ff656cf5(ref pByte_0, module_0);
	}
}
