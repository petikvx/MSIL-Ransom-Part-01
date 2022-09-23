using System;
using System.Runtime.InteropServices;

public static class GClass11
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		246, 28, 62, 192, 122, 212, 72, 138, 159, 92,
		130, 216, 157, 116, 245, 131, 8, 172, 202, 66,
		61, 212, 220, 124, 211, 185, 54, 224, 157, 63
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		159, 197, 173, 103, 63, 223, 16, 77, 207, 67,
		184, 120, 113, 144, 126, 34, 175, 63, 17, 185,
		179, 244, 151, 27, 215, 5
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class46.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class46.Enum1.flag_0 | Class46.Enum1.flag_1, Class46.Enum2.flag_6);
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
				Class46.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
