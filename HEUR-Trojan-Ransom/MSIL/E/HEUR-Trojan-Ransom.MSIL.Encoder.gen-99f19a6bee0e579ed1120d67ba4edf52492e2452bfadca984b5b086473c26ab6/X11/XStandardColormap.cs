using System;

namespace X11;

internal struct XStandardColormap
{
	internal IntPtr colormap;

	internal IntPtr red_max;

	internal IntPtr red_mult;

	internal IntPtr green_max;

	internal IntPtr green_mult;

	internal IntPtr blue_max;

	internal IntPtr blue_mult;

	internal IntPtr base_pixel;

	internal IntPtr visualid;

	internal IntPtr killid;
}
