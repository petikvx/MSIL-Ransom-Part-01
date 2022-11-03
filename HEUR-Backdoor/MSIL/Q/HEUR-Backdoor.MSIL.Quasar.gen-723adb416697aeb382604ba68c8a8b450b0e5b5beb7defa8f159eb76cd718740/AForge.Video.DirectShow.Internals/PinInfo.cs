using System.Runtime.InteropServices;

namespace AForge.Video.DirectShow.Internals;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 1)]
[ComVisible(false)]
internal struct PinInfo
{
	public IBaseFilter Filter;

	public PinDirection Direction;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
	public string Name;
}
