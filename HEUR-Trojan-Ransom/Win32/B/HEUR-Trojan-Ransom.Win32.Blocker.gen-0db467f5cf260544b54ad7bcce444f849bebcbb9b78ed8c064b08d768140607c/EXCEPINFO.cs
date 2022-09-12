using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
[ComConversionLoss]
[TypeLibType(512)]
public struct EXCEPINFO
{
	public ushort wCode;

	public ushort wReserved;

	[MarshalAs(UnmanagedType.BStr)]
	public string bstrSource;

	[MarshalAs(UnmanagedType.BStr)]
	public string bstrDescription;

	[MarshalAs(UnmanagedType.BStr)]
	public string bstrHelpFile;

	public uint dwHelpContext;

	[ComConversionLoss]
	public IntPtr pvReserved;

	[ComConversionLoss]
	public IntPtr pfnDeferredFillIn;

	[MarshalAs(UnmanagedType.Error)]
	public int scode;
}
