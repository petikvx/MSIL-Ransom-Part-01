using System;
using System.Runtime.InteropServices;

public static class GClass6
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		20, 61, 140, 76, 13, 240, 9, 42, 126, 182,
		146, 216, 47, 237, 214, 234, 157, 254, 228, 51,
		29, 65, 192, 100, 17, 100, 172, 173, 51, 43
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		48, 37, 223, 211, 43, 76, 4, 11, 75, 72,
		90, 190, 154, 61, 22, 213, 247, 193, 137, 215,
		164, 182, 180, 62, 223, 250
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
