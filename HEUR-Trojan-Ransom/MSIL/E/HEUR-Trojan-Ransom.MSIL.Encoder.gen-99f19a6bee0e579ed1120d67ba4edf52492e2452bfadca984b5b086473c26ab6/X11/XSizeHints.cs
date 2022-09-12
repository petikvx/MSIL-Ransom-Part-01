using System;

namespace X11;

internal struct XSizeHints
{
	internal IntPtr flags;

	internal int x;

	internal int y;

	internal int width;

	internal int height;

	internal int min_width;

	internal int min_height;

	internal int max_width;

	internal int max_height;

	internal int width_inc;

	internal int height_inc;

	internal int min_aspect_x;

	internal int min_aspect_y;

	internal int max_aspect_x;

	internal int max_aspect_y;

	internal int base_width;

	internal int base_height;

	internal int win_gravity;
}
