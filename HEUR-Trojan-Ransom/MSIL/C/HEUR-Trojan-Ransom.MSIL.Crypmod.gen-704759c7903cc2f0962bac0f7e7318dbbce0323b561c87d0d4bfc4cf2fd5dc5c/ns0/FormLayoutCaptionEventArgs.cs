using System;
using System.ComponentModel;
using System.Drawing;

namespace ns0;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class FormLayoutCaptionEventArgs : EventArgs
{
	private int int_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Rectangle rectangle_2;

	private Rectangle rectangle_3;

	internal Rectangle rectangle_4;

	internal Rectangle rectangle_5;

	public Rectangle Bounds => rectangle_0;

	public Rectangle CloseButtonBounds
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

	public int FrameSize => int_0;

	public Rectangle IconBounds
	{
		get
		{
			return rectangle_2;
		}
		set
		{
			rectangle_2 = value;
		}
	}

	public Rectangle MaximizeButtonBounds
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

	public Rectangle MinimizeButtonBounds
	{
		get
		{
			return rectangle_1;
		}
		set
		{
			rectangle_1 = value;
		}
	}

	public Rectangle TextBounds
	{
		get
		{
			return rectangle_3;
		}
		set
		{
			rectangle_3 = value;
		}
	}

	public FormLayoutCaptionEventArgs(int int_1, Rectangle rectangle_6, Rectangle rectangle_7, Rectangle rectangle_8, Rectangle rectangle_9, Rectangle rectangle_10, Rectangle rectangle_11)
	{
		int_0 = int_1;
		rectangle_0 = rectangle_6;
		Rectangle rectangle = (rectangle_4 = rectangle_7);
		Rectangle rectangle2 = (rectangle_5 = rectangle_8);
		rectangle_1 = rectangle_9;
		rectangle_2 = rectangle_10;
		rectangle_3 = rectangle_11;
	}
}
