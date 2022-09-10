using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuDrawSubItemEventArgs : EventArgs
{
	private Rectangle rectangle_0;

	private TextFormatFlags textFormatFlags_0;

	private NavMenuSubItem navMenuSubItem_0;

	internal Graphics graphics_0;

	internal MouseState mouseState_0;

	internal Rectangle rectangle_1;

	internal Rectangle rectangle_2;

	public Rectangle Bounds => rectangle_0;

	public Graphics Graphics => graphics_0;

	public Rectangle ImageBounds => rectangle_1;

	public NavMenuSubItem Item => navMenuSubItem_0;

	public MouseState MouseState => mouseState_0;

	public Rectangle TextBounds => rectangle_2;

	public TextFormatFlags TextFormatFlags => textFormatFlags_0;

	public NavMenuDrawSubItemEventArgs(Graphics graphics_1, MouseState mouseState_1, NavMenuSubItem navMenuSubItem_1, Rectangle rectangle_3, Rectangle rectangle_4, Rectangle rectangle_5, TextFormatFlags textFormatFlags_1)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = (graphics_0 = graphics_1);
		MouseState mouseState = (mouseState_0 = mouseState_1);
		navMenuSubItem_0 = navMenuSubItem_1;
		rectangle_0 = rectangle_3;
		Rectangle rectangle = (rectangle_1 = rectangle_4);
		Rectangle rectangle2 = (rectangle_2 = rectangle_5);
		textFormatFlags_0 = textFormatFlags_1;
	}
}
