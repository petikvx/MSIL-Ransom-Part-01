using System.Runtime.InteropServices;

namespace MsGac.Fusion.Native;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct ASSEMBLY_INFO
{
	public uint cbAssemblyInfo;

	public uint dwAssemblyFlags;

	public ulong uliAssemblySizeInKB;

	public string pszCurrentAssemblyPathBuf;

	public uint cchBuf;
}
