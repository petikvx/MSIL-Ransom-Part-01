using System.Reflection;

internal struct Struct3
{
	public readonly uint f55f66d5;

	public readonly uint c00d0a30;

	public readonly Class71 class71_0;

	public unsafe Struct3(ref byte* pByte_0, Module module_0)
	{
		f55f66d5 = *(uint*)pByte_0;
		pByte_0 += 4;
		if (f55f66d5 != 0)
		{
			c00d0a30 = *(uint*)pByte_0;
			pByte_0 += 4;
		}
		else
		{
			c00d0a30 = 0u;
		}
		class71_0 = new Class71(ref pByte_0, module_0);
	}
}
