using System;

namespace X11;

internal struct MotifWmHints
{
	internal IntPtr flags;

	internal IntPtr functions;

	internal IntPtr decorations;

	internal IntPtr input_mode;

	internal IntPtr status;

	public override string ToString()
	{
		return $"MotifWmHints <flags={(MotifFlags)flags.ToInt32()}, functions={(MotifFunctions)functions.ToInt32()}, decorations={(MotifDecorations)decorations.ToInt32()}, input_mode={(MotifInputMode)input_mode.ToInt32()}, status={status.ToInt32()}";
	}
}
