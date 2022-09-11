using System;
using System.ComponentModel;
using System.Drawing;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public class FormPaintFrameEventArgs : EventArgs
{
	private Graphics graphics_0;

	internal Rectangle rectangle_0;

	internal Rectangle rectangle_1;

	internal int int_0;

	public Rectangle Bounds => rectangle_0;

	public Rectangle ClipBounds => rectangle_1;

	public int FrameSize => int_0;

	public Graphics Graphics => graphics_0;

	public FormPaintFrameEventArgs(Graphics graphics_1, Rectangle rectangle_2, Rectangle rectangle_3, int int_1)
	{
		graphics_0 = graphics_1;
		Rectangle rectangle = (rectangle_0 = rectangle_2);
		Rectangle rectangle2 = (rectangle_1 = rectangle_3);
		int num = (int_0 = int_1);
	}
}
