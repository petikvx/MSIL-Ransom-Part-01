using System;
using System.Runtime.InteropServices;

public static class GClass5
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		74, 16, 126, 65, 11, 121, 184, 112, 37, 170,
		177, 172, 109, 65, 51, 233, 209, 185, 121, 1,
		80, 0, 130, 136, 227, 223, 218, 212, 96, 67
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		116, 230, 19, 235, 160, 125, 238, 80, 235, 122,
		228, 0, 188, 215, 98, 173, 59, 207, 147, 35,
		155, 155, 62, 177, 227, 53
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
