using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class FormPaintCaptionEventArgs : EventArgs
{
	private MouseState mouseState_0;

	private MouseState mouseState_1;

	private bool bool_0;

	private bool bool_1;

	private int int_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Rectangle rectangle_2;

	internal Graphics graphics_0;

	internal MouseState mouseState_2;

	internal bool bool_2;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Rectangle rectangle_5;

	public Rectangle Bounds => rectangle_0;

	public Rectangle CloseButtonBounds => rectangle_3;

	public MouseState CloseButtonMouseState => mouseState_0;

	public int FrameSize => int_0;

	public Graphics Graphics => graphics_0;

	public Rectangle IconBounds => rectangle_5;

	public Rectangle MaximizeButtonBounds => rectangle_4;

	public MouseState MaximizeButtonMouseState => mouseState_2;

	public Rectangle MinimizeButtonBounds => rectangle_1;

	public MouseState MinimizeButtonMouseState => mouseState_1;

	public bool RenderCloseButton => bool_1;

	public bool RenderIcon => bool_0;

	public bool RenderMinMaxButtons => bool_2;

	public Rectangle TextBounds => rectangle_2;

	public TextFormatFlags TextFormatFlags => (TextFormatFlags)33554432;

	public FormPaintCaptionEventArgs(Graphics graphics_1, MouseState mouseState_3, MouseState mouseState_4, MouseState mouseState_5, bool bool_3, bool bool_4, bool bool_5, int int_1, Rectangle rectangle_6, Rectangle rectangle_7, Rectangle rectangle_8, Rectangle rectangle_9, Rectangle rectangle_10, Rectangle rectangle_11)
	{
		Graphics val = (graphics_0 = graphics_1);
		mouseState_0 = mouseState_3;
		MouseState mouseState = (mouseState_2 = mouseState_4);
		mouseState_1 = mouseState_5;
		bool_0 = bool_3;
		bool_1 = bool_4;
		bool flag = (bool_2 = bool_5);
		int_0 = int_1;
		rectangle_0 = rectangle_6;
		Rectangle rectangle = (rectangle_3 = rectangle_7);
		Rectangle rectangle2 = (rectangle_4 = rectangle_8);
		rectangle_1 = rectangle_9;
		Rectangle rectangle3 = (rectangle_5 = rectangle_10);
		rectangle_2 = rectangle_11;
	}
}
