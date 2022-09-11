using System;
using System.ComponentModel;
using System.Drawing;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public class FormPaintFrameEventArgs : EventArgs
{
	private Graphics graphics_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	internal int int_0;

	public Rectangle Bounds => rectangle_0;

	public Rectangle ClipBounds => rectangle_1;

	public int FrameSize => int_0;

	public Graphics Graphics => graphics_0;

	public FormPaintFrameEventArgs(Graphics Lrv8qZAG2w2KBVzIeslg6kQ8ipHG8SCZAqWmzPAsEM1sFu37y2F9FVwHHFVqN9ZMVs6EYS6nANiSABAN8iSs82MM3tWA2L5ukCwvgW0CNs4RGSMdhhoE9YKlzuvFSSN7TMAMzg07tzwlizB0, Rectangle rectangle_2, Rectangle rectangle_3, int int_1)
	{
		graphics_0 = Lrv8qZAG2w2KBVzIeslg6kQ8ipHG8SCZAqWmzPAsEM1sFu37y2F9FVwHHFVqN9ZMVs6EYS6nANiSABAN8iSs82MM3tWA2L5ukCwvgW0CNs4RGSMdhhoE9YKlzuvFSSN7TMAMzg07tzwlizB0;
		rectangle_0 = rectangle_2;
		rectangle_1 = rectangle_3;
		int num = (int_0 = int_1);
	}
}
