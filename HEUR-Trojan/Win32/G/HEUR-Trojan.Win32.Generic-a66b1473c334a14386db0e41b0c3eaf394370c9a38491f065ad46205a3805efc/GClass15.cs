using System;
using System.Runtime.InteropServices;

public static class GClass15
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		110, 231, 39, 223, 251, 43, 126, 16, 168, 46,
		59, 93, 242, 127, 171, 246, 137, 113, 212, 52,
		48, 123, 193, 77, 164, 161, 37, 252, 97, 148
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		236, 60, 225, 144, 23, 119, 42, 153, 233, 21,
		250, 44, 56, 184, 37, 64, 160, 189, 212, 244,
		176, 206, 89, 245, 150, 24
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class43.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class43.Enum1.flag_0 | Class43.Enum1.flag_1, Class43.Enum2.flag_6);
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
				Class43.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
