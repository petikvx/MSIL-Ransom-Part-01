using System;

namespace X11;

internal struct XGCValues
{
	internal GXFunction function;

	internal IntPtr plane_mask;

	internal IntPtr foreground;

	internal IntPtr background;

	internal int line_width;

	internal GCLineStyle line_style;

	internal GCCapStyle cap_style;

	internal GCJoinStyle join_style;

	internal GCFillStyle fill_style;

	internal GCFillRule fill_rule;

	internal GCArcMode arc_mode;

	internal IntPtr tile;

	internal IntPtr stipple;

	internal int ts_x_origin;

	internal int ts_y_origin;

	internal IntPtr font;

	internal GCSubwindowMode subwindow_mode;

	internal bool graphics_exposures;

	internal int clip_x_origin;

	internal int clib_y_origin;

	internal IntPtr clip_mask;

	internal int dash_offset;

	internal byte dashes;
}
