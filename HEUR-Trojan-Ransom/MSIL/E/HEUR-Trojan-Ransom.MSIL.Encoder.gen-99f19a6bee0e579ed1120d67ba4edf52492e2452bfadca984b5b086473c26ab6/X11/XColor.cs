using System;
using System.Runtime.InteropServices;

namespace X11;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
internal struct XColor
{
	internal IntPtr pixel;

	internal ushort red;

	internal ushort green;

	internal ushort blue;

	internal byte flags;

	internal byte pad;
}
