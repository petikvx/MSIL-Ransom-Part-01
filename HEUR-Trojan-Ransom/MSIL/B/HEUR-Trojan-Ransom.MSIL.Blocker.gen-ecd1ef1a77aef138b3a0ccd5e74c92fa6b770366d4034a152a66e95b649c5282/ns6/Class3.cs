using System;
using ns5;
using ns8;

namespace ns6;

internal sealed class Class3
{
	internal static char[] char_0;

	private static bool bool_0;

	static Class3()
	{
		smethod_0();
	}

	internal static void smethod_0()
	{
		int num = 0;
		int num2 = default(int);
		int[] int32_ = default(int[]);
		int num3 = default(int);
		while (true)
		{
			if (num == 16)
			{
				num2 = int32_[175] - 24110;
				num = 17;
			}
			if (num == 5)
			{
				if (num3 == 4)
				{
					goto IL_0097;
				}
				num = 6;
			}
			if (num == 12)
			{
				num = 13;
			}
			if (num == 11)
			{
				goto IL_00ca;
			}
			goto IL_00ea;
			IL_0036:
			num3 = 4;
			num = 9;
			goto IL_003b;
			IL_00d0:
			bool_0 = true;
			num = 15;
			goto IL_00df;
			IL_00df:
			if (num == 0)
			{
				num = 1;
			}
			if (num != 17)
			{
				continue;
			}
			goto IL_00ca;
			IL_0097:
			num2 = 5;
			num = 11;
			goto IL_004c;
			IL_0094:
			if (num3 == 0)
			{
				goto IL_0097;
			}
			num = 5;
			goto IL_00a0;
			IL_00ca:
			if (num2 == 2)
			{
				goto IL_00d0;
			}
			num = 12;
			goto IL_00ea;
			IL_004c:
			switch (num)
			{
			case 2:
				int32_ = GClass0.Int32_0;
				num = 3;
				break;
			case 7:
			case 13:
				return;
			}
			if (num == 15)
			{
				AppDomain.CurrentDomain.ResourceResolve += Class5.Class6.smethod_0;
				num = 16;
			}
			if (num == 9)
			{
				goto IL_0094;
			}
			if (num == 1)
			{
				num = 2;
			}
			if (num == 3)
			{
				num3 = 1;
				num = 4;
			}
			if (num == 14)
			{
				goto IL_00d0;
			}
			goto IL_00df;
			IL_00ea:
			if (num == 4)
			{
				goto IL_0094;
			}
			goto IL_00a0;
			IL_00a0:
			if (num == 8)
			{
				goto IL_0036;
			}
			goto IL_003b;
			IL_003b:
			if (num == 6)
			{
				if (!bool_0)
				{
					goto IL_0036;
				}
				num = 7;
			}
			if (num != 10)
			{
				goto IL_004c;
			}
			goto IL_0097;
		}
	}
}
