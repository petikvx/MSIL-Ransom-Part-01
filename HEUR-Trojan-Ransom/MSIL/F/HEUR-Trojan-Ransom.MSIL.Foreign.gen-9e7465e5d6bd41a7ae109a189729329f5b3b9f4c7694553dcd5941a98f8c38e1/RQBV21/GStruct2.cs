using System.Runtime.InteropServices;

namespace RQBV21;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GStruct2
{
	public int cbSize;

	public int szDisplayName;
}
