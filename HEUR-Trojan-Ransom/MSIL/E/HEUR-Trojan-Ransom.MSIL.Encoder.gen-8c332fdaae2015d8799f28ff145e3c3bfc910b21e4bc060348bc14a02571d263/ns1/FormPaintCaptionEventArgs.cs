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

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Rectangle rectangle_2;

	internal Graphics graphics_0;

	internal MouseState mouseState_2;

	internal bool bool_1;

	internal bool bool_2;

	internal int int_0;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Rectangle rectangle_5;

	public Rectangle Bounds => rectangle_3;

	public Rectangle CloseButtonBounds => rectangle_0;

	public MouseState CloseButtonMouseState => mouseState_2;

	public int FrameSize => int_0;

	public Graphics Graphics => graphics_0;

	public Rectangle IconBounds => rectangle_2;

	public Rectangle MaximizeButtonBounds => rectangle_4;

	public MouseState MaximizeButtonMouseState => mouseState_0;

	public Rectangle MinimizeButtonBounds => rectangle_1;

	public MouseState MinimizeButtonMouseState => mouseState_1;

	public bool RenderCloseButton => bool_1;

	public bool RenderIcon => bool_0;

	public bool RenderMinMaxButtons => bool_2;

	public Rectangle TextBounds => rectangle_5;

	public TextFormatFlags TextFormatFlags => (TextFormatFlags)33554432;

	public FormPaintCaptionEventArgs(Graphics graphics_1, MouseState mouseState_3, MouseState mouseState_4, MouseState mouseState_5, bool bool_3, bool bool_4, bool bool_5, int int_1, Rectangle rectangle_6, Rectangle rectangle_7, Rectangle IJTnQ3vVjXzUJgNoo7lPCIUjp8loDwuxdhIv1fwgX7XXA7Be4M8GkjZFXppLfgH5MUGIDd17klgT3BP7uACEdgiKQ4k6Y0RPSNs3Anx8bfktAzbSSa47LcIgCGIz, Rectangle rectangle_8, Rectangle rectangle_9, Rectangle rectangle_10)
	{
		Graphics val = (graphics_0 = graphics_1);
		MouseState mouseState = (mouseState_2 = mouseState_3);
		mouseState_0 = mouseState_4;
		mouseState_1 = mouseState_5;
		bool_0 = bool_3;
		bool flag = (bool_1 = bool_4);
		bool flag2 = (bool_2 = bool_5);
		int num = (int_0 = int_1);
		Rectangle rectangle = (rectangle_3 = rectangle_6);
		rectangle_0 = rectangle_7;
		Rectangle rectangle2 = (rectangle_4 = IJTnQ3vVjXzUJgNoo7lPCIUjp8loDwuxdhIv1fwgX7XXA7Be4M8GkjZFXppLfgH5MUGIDd17klgT3BP7uACEdgiKQ4k6Y0RPSNs3Anx8bfktAzbSSa47LcIgCGIz);
		rectangle_1 = rectangle_8;
		rectangle_2 = rectangle_9;
		Rectangle rectangle3 = (rectangle_5 = rectangle_10);
	}
}
