using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuDrawItemEventArgs : EventArgs
{
	private Graphics graphics_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Rectangle rectangle_2;

	internal MouseState mouseState_0;

	internal Rectangle rectangle_3;

	internal TextFormatFlags textFormatFlags_0;

	internal NavMenuItem navMenuItem_0;

	public Rectangle ArrowBounds => rectangle_3;

	public Rectangle Bounds => rectangle_0;

	public Graphics Graphics => graphics_0;

	public Rectangle ImageBounds => rectangle_1;

	public NavMenuItem Item => navMenuItem_0;

	public MouseState MouseState => mouseState_0;

	public Rectangle TextBounds => rectangle_2;

	public TextFormatFlags TextFormatFlags => textFormatFlags_0;

	public NavMenuDrawItemEventArgs(Graphics graphics_1, MouseState mouseState_1, NavMenuItem navMenuItem_1, Rectangle rectangle_4, Rectangle rectangle_5, Rectangle rectangle_6, Rectangle rectangle_7, TextFormatFlags textFormatFlags_1)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		graphics_0 = graphics_1;
		MouseState mouseState = (mouseState_0 = mouseState_1);
		NavMenuItem navMenuItem = (navMenuItem_0 = navMenuItem_1);
		rectangle_0 = rectangle_4;
		rectangle_1 = rectangle_5;
		Rectangle rectangle = (rectangle_3 = rectangle_6);
		rectangle_2 = rectangle_7;
		TextFormatFlags val = (textFormatFlags_0 = textFormatFlags_1);
	}
}
