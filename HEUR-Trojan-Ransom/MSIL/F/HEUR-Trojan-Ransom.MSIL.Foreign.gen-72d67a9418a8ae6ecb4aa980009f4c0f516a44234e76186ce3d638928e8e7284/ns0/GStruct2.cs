using System.Runtime.InteropServices;

namespace ns0;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GStruct2
{
	public int cbSize;

	public int dwModifiers;

	public int szFilePath;
}
