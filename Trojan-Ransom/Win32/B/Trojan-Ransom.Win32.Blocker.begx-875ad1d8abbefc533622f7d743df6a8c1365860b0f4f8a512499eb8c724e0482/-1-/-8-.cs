using System;
using System.Reflection;
using System.Security;

namespace _003F1_003F;

internal sealed class _003F8_003F
{
	[SecuritySafeCritical]
	static _003F8_003F()
	{
		//Discarded unreachable code: IL_0006
		_003F2_003F._003F3_003F._003F29_003F();
	}

	[SecuritySafeCritical]
	internal static object _003F1_003F(MethodBase P_0, object P_1, object[] P_2, int P_3, int P_4)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
		//IL_0094: Incompatible stack heights: 0 vs 1
		//IL_00b7: Incompatible stack heights: 0 vs 1
		//IL_00c1: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = ((/*Error near IL_0047: Stack underflow*/ ^ P_3) - 96) switch
			{
				0 => 5, 
				_ => 6, 
			};
			while (true)
			{
				switch (/*Error near IL_002f: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					_ = 2;
					num = (int)/*Error near IL_007e: Stack underflow*/;
					continue;
				case 2L:
					break;
				case 4L:
				case 6L:
					num = 2;
					continue;
				case 0L:
				case 5L:
				case 7L:
					return P_0.Invoke(P_1, P_2);
				case 3L:
					num = 2;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static Type _003F6_003F(Exception P_0, int P_1, int P_2)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected I4, but got Unknown
		//IL_0091: Incompatible stack heights: 0 vs 1
		//IL_00b4: Incompatible stack heights: 0 vs 1
		//IL_00be: Incompatible stack heights: 0 vs 1
		while (true)
		{
			int num = ((/*Error near IL_0047: Stack underflow*/ ^ P_1) - 14) switch
			{
				0 => 7, 
				_ => 3, 
			};
			while (true)
			{
				switch (/*Error near IL_002f: Stack underflow*/)
				{
				default:
					/*OpCode not supported: LdMemberToken*/;
					_ = 0;
					num = (int)/*Error near IL_007c: Stack underflow*/;
					continue;
				case 0L:
					break;
				case 3L:
					num = 0;
					continue;
				case 7L:
					return P_0.GetType();
				case 6L:
					num = 0;
					continue;
				}
				break;
			}
		}
	}

	[SecuritySafeCritical]
	internal static bool _003F23_003F(Assembly P_0, Assembly P_1, int P_2, int P_3)
	{
		//Discarded unreachable code: IL_0029, IL_0054
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		//IL_0059: Incompatible stack heights: 0 vs 1
		//IL_005e: Incompatible stack heights: 0 vs 1
		//IL_0063: Incompatible stack heights: 0 vs 1
		while (true)
		{
			switch ((/*Error near IL_000b: Stack underflow*/ ^ /*Error near IL_000b: Stack underflow*/) - 115)
			{
			case 0:
				return (Assembly?)/*Error near IL_0028: Stack underflow*/ != P_1;
			}
		}
	}
}
