using System.Runtime.InteropServices;

namespace ns0;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GStruct1
{
	public int Data1;

	public short Data2;

	public short Data3;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
	public byte[] Data4;
}
