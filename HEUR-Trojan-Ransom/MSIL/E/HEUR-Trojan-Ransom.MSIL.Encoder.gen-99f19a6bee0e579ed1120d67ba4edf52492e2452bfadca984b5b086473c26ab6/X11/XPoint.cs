using System;
using System.Runtime.InteropServices;

namespace X11;

[Serializable]
[StructLayout(LayoutKind.Sequential)]
internal class XPoint
{
	public short X;

	public short Y;
}
