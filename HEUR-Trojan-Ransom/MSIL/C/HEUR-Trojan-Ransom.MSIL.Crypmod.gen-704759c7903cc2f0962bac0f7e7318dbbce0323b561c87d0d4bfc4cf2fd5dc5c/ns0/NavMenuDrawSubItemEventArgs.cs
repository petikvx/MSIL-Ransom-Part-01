using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuDrawSubItemEventArgs : EventArgs
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 62)]
	private struct Struct1
	{
	}

	private MouseState mouseState_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private static readonly object object_0;

	private static readonly object object_1 = new char[31];

	private static readonly object object_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Graphics graphics_0;

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
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		Graphics val = (graphics_0 = graphics_1);
		mouseState_0 = mouseState_1;
		NavMenuSubItem navMenuSubItem = (navMenuSubItem_0 = navMenuSubItem_1);
		rectangle_0 = rectangle_3;
		rectangle_1 = rectangle_4;
		Rectangle rectangle = (rectangle_2 = rectangle_5);
		TextFormatFlags val2 = (textFormatFlags_0 = textFormatFlags_1);
	}

	static NavMenuDrawSubItemEventArgs()
	{
		char[] array = new char[8];
		array[1] = '⭗';
		array[0] = 'ギ';
		array[2] = 'ό';
		array[7] = '␇';
		array[4] = 'ᐞ';
		array[5] = 'ଭ';
		array[3] = 'ℂ';
		array[6] = 'จ';
		object_2 = new string[4];
		object_0 = array;
	}
}
