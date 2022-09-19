using System;
using System.Net.Sockets;
using System.Runtime.InteropServices;

public static class GClass29
{
	internal struct Struct12
	{
		internal uint uint_0;

		internal uint uint_1;

		internal uint uint_2;
	}

	public static void SetKeepAliveEx(this Socket socket, uint keepAliveInterval, uint keepAliveTime)
	{
		Struct12 @struct = default(Struct12);
		@struct.uint_0 = 1u;
		@struct.uint_2 = keepAliveInterval;
		@struct.uint_1 = keepAliveTime;
		Struct12 struct2 = @struct;
		int num = Marshal.SizeOf((object)struct2);
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr((object)struct2, intPtr, fDeleteOld: true);
		byte[] array = new byte[num];
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		socket.IOControl(IOControlCode.KeepAliveValues, array, null);
	}
}
