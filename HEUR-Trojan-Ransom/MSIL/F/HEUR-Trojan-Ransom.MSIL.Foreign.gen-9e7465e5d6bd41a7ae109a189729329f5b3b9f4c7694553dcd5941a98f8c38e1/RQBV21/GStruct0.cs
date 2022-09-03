using System.Runtime.InteropServices;

namespace RQBV21;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GStruct0
{
	public int cbSize;

	public int ClauseType;

	public int cbClauseData;

	public int pbClauseData;
}
