using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
[TypeLibType(512)]
[ComConversionLoss]
public struct DISPPARAMS
{
	[ComConversionLoss]
	public IntPtr rgvarg;

	[ComConversionLoss]
	public IntPtr rgdispidNamedArgs;

	public uint cArgs;

	public uint cNamedArgs;
}
