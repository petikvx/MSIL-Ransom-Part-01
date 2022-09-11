using System;
using System.Reflection;

internal class q
{
	public static readonly IntPtr[] a = new IntPtr[4];

	unsafe static q()
	{
		Module module = typeof(q).Module;
		int num = (int)((nint)Type.EmptyTypes.LongLength + 1854126288);
		IntPtr[] array = a;
		nint num3;
		if (((uint)num >> 25) + 18178048 != (uint)num % 168693468u >> 17)
		{
			int num2;
			if (((307757056 * num) | 0x57F) - 16441344 == -(num & 0x24D0) << 11)
			{
				num2 = -1426512527;
				num3 = num2;
			}
			else if ((((uint)(num * 264 + num * 1784) >> 5 >> 6) & 1) == (uint)(1 & -num))
			{
				if ((((uint)(7364 + (num << 29)) >> 29) & 2) == (uint)((~num - 2958) & 2))
				{
					num3 = ((((((uint)(num * -1073741824) >> 10) ^ (uint)(num * 57 + 7 * num)) & 0x39) == 0) ? ((nint)Type.EmptyTypes.LongLength + 1686354129) : ((nint)Type.EmptyTypes.LongLength + 695708289));
				}
				else
				{
					num2 = -1636090519;
					num3 = num2;
				}
			}
			else
			{
				num3 = sizeof(Guid) + 829527825;
			}
		}
		else
		{
			num3 = -649831216;
		}
		array[0] = module.ResolveMethod((int)(num3 ^ num))!.MethodHandle.GetFunctionPointer();
		a[1] = module.ResolveMethod(0x6483B8D2 ^ num)!.MethodHandle.GetFunctionPointer();
		a[2] = module.ResolveMethod(0x6483B8D3 ^ num)!.MethodHandle.GetFunctionPointer();
		IntPtr[] array2 = a;
		int num4 = 1686354132;
		array2[3] = module.ResolveMethod(num4 ^ num)!.MethodHandle.GetFunctionPointer();
		num = -1331400319 + num;
		num = (int)((nint)Type.EmptyTypes.LongLength + -563971714 + num);
	}
}
