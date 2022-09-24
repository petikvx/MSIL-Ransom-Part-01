using System;
using System.Runtime.InteropServices;

public static class GClass5
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		221, 192, 106, 157, 184, 220, 98, 217, 85, 229,
		37, 58, 138, 33, 111, 0, 87, 245, 35, 39,
		110, 187, 156, 20, 192, 123, 26, 108, 178, 89
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		81, 170, 90, 28, 200, 115, 131, 122, 133, 95,
		127, 157, 163, 89, 69, 129, 186, 54, 1, 154,
		38, 38, 147, 51, 147, 80
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class38.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class38.Enum1.flag_0 | Class38.Enum1.flag_1, Class38.Enum2.flag_6);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Delegate0 @delegate = (Delegate0)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(Delegate0));
			GCHandle gCHandle = default(GCHandle);
			int[] array2 = new int[4];
			try
			{
				gCHandle = GCHandle.Alloc(array2, GCHandleType.Pinned);
				@delegate(int_0, array2);
			}
			finally
			{
				if (gCHandle != default(GCHandle))
				{
					gCHandle.Free();
				}
			}
			return array2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class38.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
