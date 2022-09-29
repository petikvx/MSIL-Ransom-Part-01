using System;
using System.Runtime.InteropServices;

public static class GClass9
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate160(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		85, 139, 236, 83, 87, 139, 69, 8, 15, 162,
		139, 125, 12, 137, 7, 137, 95, 4, 137, 79,
		8, 137, 87, 12, 95, 91, 139, 229, 93, 195
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		83, 73, 137, 208, 137, 200, 15, 162, 65, 137,
		64, 0, 65, 137, 88, 4, 65, 137, 72, 8,
		65, 137, 80, 12, 91, 195
	};

	public static int[] smethod_0(int int_0)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			byte[] array = ((IntPtr.Size == 4) ? byte_0 : byte_1);
			intPtr = Class41.VirtualAlloc(IntPtr.Zero, new UIntPtr((uint)array.Length), Class41.Enum1.flag_0 | Class41.Enum1.flag_1, Class41.Enum2.flag_6);
			Marshal.Copy(array, 0, intPtr, array.Length);
			Delegate160 @delegate = (Delegate160)Marshal.GetDelegateForFunctionPointer(intPtr, typeof(Delegate160));
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
