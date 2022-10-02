using System;
using System.Runtime.InteropServices;

public static class GClass6
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		175, 120, 45, 119, 134, 239, 35, 158, 39, 126,
		67, 50, 236, 34, 255, 254, 151, 112, 239, 185,
		130, 9, 221, 23, 0, 163, 107, 88, 189, 206
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		130, 91, 223, 94, 37, 81, 89, 33, 133, 223,
		217, 249, 101, 64, 162, 0, 30, 238, 57, 130,
		75, 185, 99, 163, 250, 84
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class40.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class40.Enum1.flag_0 | Class40.Enum1.flag_1, Class40.Enum2.flag_6);
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
				Class40.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
