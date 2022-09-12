using System;

namespace X11;

internal struct XIMPreeditDrawCallbackStruct
{
	public int Caret;

	public int ChangeFirst;

	public int ChangeLength;

	public IntPtr Text;
}
