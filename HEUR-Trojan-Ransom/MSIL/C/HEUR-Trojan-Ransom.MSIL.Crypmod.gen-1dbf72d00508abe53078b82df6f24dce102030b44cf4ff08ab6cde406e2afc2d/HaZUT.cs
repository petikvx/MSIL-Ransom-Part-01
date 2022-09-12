using System;
using System.Reflection;

internal class HaZUT
{
	public static readonly IntPtr[] HaZUSHaZUS = new IntPtr[7];

	unsafe static HaZUT()
	{
		Module module = typeof(HaZUT).Module;
		int num = sizeof(float) + 1828313739;
		num = (int)((nint)Type.EmptyTypes.LongLength + -1770360639 + num);
		HaZUSHaZUS[0] = module.ResolveMethod(((((35 * num + 29 * num) & 0xB) == 0) ? 158616401 : (sizeof(short) + -913118514)) ^ num)!.MethodHandle.GetFunctionPointer();
		num = (int)((nint)Type.EmptyTypes.LongLength + 320239245 + num);
		num = (int)((nint)Type.EmptyTypes.LongLength + 992337161 + num);
		num = (int)((nint)Type.EmptyTypes.LongLength + 599611533 + num);
		HaZUSHaZUS[1] = module.ResolveMethod((int)((((((num | 0x1E74) + -5896) & 4) != 4) ? (-1238903096) : (((-69 | (num * 2048)) == -69) ? ((nint)Type.EmptyTypes.LongLength + 2137913201) : ((nint)Type.EmptyTypes.LongLength + -1695860662))) ^ num))!.MethodHandle.GetFunctionPointer();
		HaZUSHaZUS[2] = module.ResolveMethod((int)(((nint)Type.EmptyTypes.LongLength + 2137913200) ^ num))!.MethodHandle.GetFunctionPointer();
		HaZUSHaZUS[3] = module.ResolveMethod((sizeof(ulong) + 2137913199) ^ num)!.MethodHandle.GetFunctionPointer();
		HaZUSHaZUS[4] = module.ResolveMethod((int)(((nint)Type.EmptyTypes.LongLength + 2137913206) ^ num))!.MethodHandle.GetFunctionPointer();
		HaZUSHaZUS[5] = module.ResolveMethod(0x7F6DF775 ^ num)!.MethodHandle.GetFunctionPointer();
		HaZUSHaZUS[6] = module.ResolveMethod(0x7F6DF774 ^ num)!.MethodHandle.GetFunctionPointer();
	}
}
