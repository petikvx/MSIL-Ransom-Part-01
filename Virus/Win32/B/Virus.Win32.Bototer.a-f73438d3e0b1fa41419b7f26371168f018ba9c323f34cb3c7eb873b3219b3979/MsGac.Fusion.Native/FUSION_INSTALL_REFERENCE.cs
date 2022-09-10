using System;
using System.Runtime.InteropServices;

namespace MsGac.Fusion.Native;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal struct FUSION_INSTALL_REFERENCE
{
	public uint cbSize;

	public uint dwFlags;

	public Guid guidScheme;

	public string szIdentifier;

	public string szNonCannonicalData;
}
