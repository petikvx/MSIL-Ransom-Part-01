using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class FormPaintCaptionEventArgs : EventArgs
{
	private Graphics graphics_0;

	private bool bool_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	internal MouseState mouseState_0;

	internal MouseState mouseState_1;

	internal MouseState mouseState_2;

	internal bool bool_1;

	internal bool bool_2;

	internal int int_0;

	internal Rectangle rectangle_2;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Rectangle rectangle_5;

	public Rectangle Bounds => rectangle_2;

	public Rectangle CloseButtonBounds => rectangle_3;

	public MouseState CloseButtonMouseState => mouseState_0;

	public int FrameSize => int_0;

	public Graphics Graphics => graphics_0;

	public Rectangle IconBounds => rectangle_5;

	public Rectangle MaximizeButtonBounds => rectangle_0;

	public MouseState MaximizeButtonMouseState => mouseState_1;

	public Rectangle MinimizeButtonBounds => rectangle_4;

	public MouseState MinimizeButtonMouseState => mouseState_2;

	public bool RenderCloseButton => bool_2;

	public bool RenderIcon => bool_1;

	public bool RenderMinMaxButtons => bool_0;

	public Rectangle TextBounds => rectangle_1;

	public TextFormatFlags TextFormatFlags => (TextFormatFlags)33554432;

	public FormPaintCaptionEventArgs(Graphics graphics_1, MouseState mouseState_3, MouseState mouseState_4, MouseState mouseState_5, bool bool_3, bool bool_4, bool bool_5, int int_1, Rectangle rectangle_6, Rectangle rectangle_7, Rectangle rectangle_8, Rectangle rectangle_9, Rectangle rectangle_10, Rectangle rectangle_11)
	{
		graphics_0 = graphics_1;
		MouseState mouseState = (mouseState_0 = mouseState_3);
		MouseState mouseState2 = (mouseState_1 = mouseState_4);
		MouseState mouseState3 = (mouseState_2 = mouseState_5);
		bool flag = (bool_1 = bool_3);
		bool flag2 = (bool_2 = bool_4);
		bool_0 = bool_5;
		int num = (int_0 = int_1);
		Rectangle rectangle = (rectangle_2 = rectangle_6);
		Rectangle rectangle2 = (rectangle_3 = rectangle_7);
		rectangle_0 = rectangle_8;
		Rectangle rectangle3 = (rectangle_4 = rectangle_9);
		Rectangle rectangle4 = (rectangle_5 = rectangle_10);
		rectangle_1 = rectangle_11;
	}
}
