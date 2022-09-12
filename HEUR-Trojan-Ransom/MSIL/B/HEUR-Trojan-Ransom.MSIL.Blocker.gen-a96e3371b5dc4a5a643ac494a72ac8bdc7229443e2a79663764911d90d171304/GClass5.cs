using System;
using System.Runtime.InteropServices;

public static class GClass5
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		193, 114, 111, 110, 32, 44, 173, 72, 3, 221,
		221, 131, 249, 4, 59, 88, 188, 63, 117, 156,
		99, 155, 72, 215, 29, 117, 17, 121, 124, 197
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		118, 170, 242, 132, 88, 2, 195, 214, 236, 35,
		125, 87, 162, 236, 44, 27, 129, 85, 154, 79,
		58, 240, 167, 242, 249, 80
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
