using System;

namespace X11;

internal struct XIMText
{
	public ushort Length;

	public IntPtr Feedback;

	public bool EncodingIsWChar;

	public IntPtr String;
}
