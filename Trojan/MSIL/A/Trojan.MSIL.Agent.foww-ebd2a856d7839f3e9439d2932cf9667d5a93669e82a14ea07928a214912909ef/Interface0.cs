using System.Runtime.InteropServices;

[ComImport]
[Guid("C6E13370-30AC-11d0-A18C-00A0C9118956")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface Interface0
{
	[PreserveSig]
	int GetRange([In] GEnum10 Property, out int pMin, out int pMax, out int pSteppingDelta, out int pDefault, out GEnum11 pCapsFlags);

	[PreserveSig]
	int Set([In] GEnum10 Property, [In] int lValue, [In] GEnum11 Flags);

	[PreserveSig]
	int Get([In] GEnum10 Property, out int lValue, out GEnum11 Flags);
}
