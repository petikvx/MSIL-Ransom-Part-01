using System.Reflection;

internal struct Struct3
{
	public readonly uint e2541d3c;

	public readonly uint uint_0;

	public readonly Class62 b47905ce;

	public unsafe Struct3(ref byte* pByte_0, Module module_0)
	{
		e2541d3c = *(uint*)pByte_0;
		pByte_0 += 4;
		if (e2541d3c != 0)
		{
			uint_0 = *(uint*)pByte_0;
			pByte_0 += 4;
		}
		else
		{
			uint_0 = 0u;
		}
		b47905ce = new Class62(ref pByte_0, module_0);
	}
}
