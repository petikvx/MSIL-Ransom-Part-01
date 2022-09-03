using System.Runtime.InteropServices;

namespace ns0;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
public struct GStruct0
{
	public int cbSize;

	public int dwModifiers;

	public int szRootCA;

	public int szIssuer;

	public int szPublisher;

	public int szProgramName;
}
