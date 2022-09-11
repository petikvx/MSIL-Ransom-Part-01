using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuDrawSubItemEventArgs : EventArgs
{
	private Graphics graphics_0;

	private MouseState mouseState_0;

	internal Rectangle rectangle_0;

	internal Rectangle rectangle_1;

	internal Rectangle rectangle_2;

	internal TextFormatFlags textFormatFlags_0;

	internal NavMenuSubItem navMenuSubItem_0;

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
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		graphics_0 = graphics_1;
		mouseState_0 = mouseState_1;
		NavMenuSubItem navMenuSubItem = (navMenuSubItem_0 = navMenuSubItem_1);
		Rectangle rectangle = (rectangle_0 = rectangle_3);
		Rectangle rectangle2 = (rectangle_1 = rectangle_4);
		Rectangle rectangle3 = (rectangle_2 = rectangle_5);
		TextFormatFlags val = (textFormatFlags_0 = textFormatFlags_1);
	}
}
