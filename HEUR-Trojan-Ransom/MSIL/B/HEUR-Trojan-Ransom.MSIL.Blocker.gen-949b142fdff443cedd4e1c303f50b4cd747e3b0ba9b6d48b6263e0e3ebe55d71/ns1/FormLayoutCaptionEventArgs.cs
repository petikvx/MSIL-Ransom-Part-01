using System;
using System.ComponentModel;
using System.Drawing;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class FormLayoutCaptionEventArgs : EventArgs
{
	private int int_0;

	private Rectangle rectangle_0;

	internal Rectangle rectangle_1;

	internal Rectangle rectangle_2;

	internal Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Rectangle rectangle_5;

	public Rectangle Bounds => rectangle_1;

	public Rectangle CloseButtonBounds
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			Rectangle rectangle = (rectangle_2 = value);
		}
	}

	public int FrameSize => int_0;

	public Rectangle IconBounds
	{
		get
		{
			return rectangle_0;
		}
		set
		{
			rectangle_0 = value;
		}
	}

	public Rectangle MaximizeButtonBounds
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			Rectangle rectangle = (rectangle_3 = value);
		}
	}

	public Rectangle MinimizeButtonBounds
	{
		get
		{
			return rectangle_4;
		}
		set
		{
			Rectangle rectangle = (rectangle_4 = value);
		}
	}

	public Rectangle TextBounds
	{
		get
		{
			return rectangle_5;
		}
		set
		{
			Rectangle rectangle = (rectangle_5 = value);
		}
	}

	public FormLayoutCaptionEventArgs(int int_1, Rectangle rectangle_6, Rectangle rectangle_7, Rectangle rectangle_8, Rectangle rectangle_9, Rectangle rectangle_10, Rectangle rectangle_11)
	{
		int_0 = int_1;
		Rectangle rectangle = (rectangle_1 = rectangle_6);
		Rectangle rectangle2 = (rectangle_2 = rectangle_7);
		Rectangle rectangle3 = (rectangle_3 = rectangle_8);
		Rectangle rectangle4 = (rectangle_4 = rectangle_9);
		rectangle_0 = rectangle_10;
		Rectangle rectangle5 = (rectangle_5 = rectangle_11);
	}
}
