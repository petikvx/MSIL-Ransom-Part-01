using System;

namespace X11;

internal struct XModifierKeymap
{
	public int max_keypermod;

	public IntPtr modifiermap;
}
