using System;
using System.Runtime.InteropServices;

public static class GClass5
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate13(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		53, 13, 225, 89, 131, 105, 43, 67, 218, 178,
		179, 159, 167, 254, 181, 134, 75, 242, 42, 131,
		126, 228, 154, 199, 165, 46, 16, 197, 214, 133
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		62, 91, 78, 14, 156, 90, 96, 100, 142, 131,
		188, 131, 54, 161, 136, 136, 68, 146, 108, 54,
		34, 191, 177, 241, 206, 41
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class39.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class39.Enum1.flag_0 | Class39.Enum1.flag_1, Class39.Enum2.flag_6);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Delegate13 @delegate = (Delegate13)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(Delegate13));
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
				Class39.VirtualFree(intPtr, 0u, 32768u);
			}
		}
	}
}
