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

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private NavMenuSubItem navMenuSubItem_0;

	internal Rectangle rectangle_2;

	internal TextFormatFlags textFormatFlags_0;

	public Rectangle Bounds => rectangle_2;

	public Graphics Graphics => graphics_0;

	public Rectangle ImageBounds => rectangle_0;

	public NavMenuSubItem Item => navMenuSubItem_0;

	public MouseState MouseState => mouseState_0;

	public Rectangle TextBounds => rectangle_1;

	public TextFormatFlags TextFormatFlags => textFormatFlags_0;

	public NavMenuDrawSubItemEventArgs(Graphics graphics_1, MouseState mouseState_1, NavMenuSubItem navMenuSubItem_1, Rectangle rectangle_3, Rectangle rectangle_4, Rectangle rectangle_5, TextFormatFlags textFormatFlags_1)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		graphics_0 = graphics_1;
		mouseState_0 = mouseState_1;
		navMenuSubItem_0 = navMenuSubItem_1;
		Rectangle rectangle = (rectangle_2 = rectangle_3);
		rectangle_0 = rectangle_4;
		rectangle_1 = rectangle_5;
		TextFormatFlags val = (textFormatFlags_0 = textFormatFlags_1);
	}
}
