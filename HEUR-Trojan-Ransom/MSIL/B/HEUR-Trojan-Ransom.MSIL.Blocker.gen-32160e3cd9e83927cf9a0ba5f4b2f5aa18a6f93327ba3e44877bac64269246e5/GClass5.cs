using System;
using System.Runtime.InteropServices;

public static class GClass5
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void Delegate0(int int_0, int[] int_1);

	private static readonly byte[] byte_0 = new byte[30]
	{
		224, 89, 238, 176, 235, 27, 189, 19, 60, 245,
		233, 105, 253, 170, 66, 85, 48, 16, 122, 158,
		48, 127, 150, 7, 98, 6, 209, 20, 95, 30
	};

	private static readonly byte[] byte_1 = new byte[26]
	{
		109, 241, 211, 157, 188, 145, 222, 160, 28, 255,
		161, 176, 22, 116, 81, 219, 215, 39, 190, 65,
		4, 69, 141, 226, 161, 212
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
