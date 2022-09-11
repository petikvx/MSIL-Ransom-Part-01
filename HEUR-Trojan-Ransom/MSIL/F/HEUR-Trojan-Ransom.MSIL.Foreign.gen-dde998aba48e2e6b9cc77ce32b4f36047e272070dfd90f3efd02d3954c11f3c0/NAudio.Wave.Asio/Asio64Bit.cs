using System.Runtime.InteropServices;

namespace NAudio.Wave.Asio;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct Asio64Bit
{
	public uint hi;

	public uint lo;
}
