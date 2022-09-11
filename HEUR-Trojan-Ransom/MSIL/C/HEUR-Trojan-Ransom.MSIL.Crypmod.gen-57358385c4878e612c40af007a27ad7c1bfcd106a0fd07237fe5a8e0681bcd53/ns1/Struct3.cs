using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns1;

[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 522)]
internal struct Struct3
{
	static void smethod_0()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Expected I4, but got Unknown
		System.Runtime.CompilerServices.Unsafe.SkipInit(out bool flag);
		while (true)
		{
			_003F val = /*Error near IL_0003: Stack underflow*// flag;
			flag = (byte)(int)val != 0;
			if ((int)val == 0)
			{
				break;
			}
			while ((int)/*Error near IL_0009: Stack underflow*/ != 0)
			{
			}
		}
		while ((int)/*Error near IL_000e: Stack underflow*/ != 0)
		{
		}
		try
		{
		}
		finally
		{
			goto IL_0012;
		}
		IL_0012:
		while (true)
		{
		}
	}
}
