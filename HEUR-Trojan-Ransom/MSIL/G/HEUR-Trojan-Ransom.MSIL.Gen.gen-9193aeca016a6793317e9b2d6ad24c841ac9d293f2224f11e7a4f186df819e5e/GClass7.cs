using System;
using System.Runtime.InteropServices;

public static class GClass7
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		198, 3, 109, 138, 115, 251, 245, 144, 157, 208,
		137, 237, 141, 188, 159, 249, 234, 89, 187, 101,
		70, 9, 204, 185, 237, 86, 172, 225, 156, 175
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		121, 90, 11, 42, 117, 65, 5, 198, 235, 1,
		3, 227, 109, 30, 0, 126, 186, 64, 93, 177,
		222, 51, 223, 243, 61, 181
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class42.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class42.Enum1.flag_0 | Class42.Enum1.flag_1, Class42.Enum2.flag_6);
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
				Class42.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
