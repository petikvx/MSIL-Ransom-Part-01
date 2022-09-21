using System;
using System.Runtime.InteropServices;

public static class GClass9
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		105, 73, 24, 50, 179, 34, 84, 117, 210, 197,
		32, 222, 212, 76, 211, 194, 107, 125, 231, 230,
		178, 234, 51, 35, 19, 193, 78, 146, 38, 46
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		81, 204, 8, 10, 18, 220, 228, 10, 241, 129,
		110, 55, 225, 9, 90, 56, 15, 13, 186, 253,
		45, 191, 58, 102, 85, 10
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class41.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class41.Enum1.flag_0 | Class41.Enum1.flag_1, Class41.Enum2.flag_6);
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
				Class41.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
