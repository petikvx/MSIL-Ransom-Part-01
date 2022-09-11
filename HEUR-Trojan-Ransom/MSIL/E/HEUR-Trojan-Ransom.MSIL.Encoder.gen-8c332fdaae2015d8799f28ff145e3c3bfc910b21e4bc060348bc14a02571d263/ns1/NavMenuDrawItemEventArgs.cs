using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
public sealed class NavMenuDrawItemEventArgs : EventArgs
{
	private Graphics B8j6iemXk5VRqrzJNvBji36ZJNolk5AZg2Q6NQcxTHqmDpFhUKITKJ4egOAtRY8T7vii8FC1CyaIXPCOn2W7Y0VinC4xo8U656xigKXsU0ar6PqdJx0vmfY2xHgl;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Rectangle rectangle_2;

	private TextFormatFlags CAcGPfX8i8owAuTAqus0giPUkHAGRxQHd6sDJUdCnh8mosdYjXRzMdeeE8BjcAxtGaUuPI6FPKWF7VBguDtTQJruZrNLWu6wepu1X7BFfFXOttlgKxaCeg7fAPr5;

	private NavMenuItem navMenuItem_0;

	internal MouseState mouseState_0;

	internal Rectangle rectangle_3;

	public Rectangle ArrowBounds => rectangle_2;

	public Rectangle Bounds => rectangle_0;

	public Graphics Graphics => B8j6iemXk5VRqrzJNvBji36ZJNolk5AZg2Q6NQcxTHqmDpFhUKITKJ4egOAtRY8T7vii8FC1CyaIXPCOn2W7Y0VinC4xo8U656xigKXsU0ar6PqdJx0vmfY2xHgl;

	public Rectangle ImageBounds => rectangle_3;

	public NavMenuItem Item => navMenuItem_0;

	public MouseState MouseState => mouseState_0;

	public Rectangle TextBounds => rectangle_1;

	public TextFormatFlags TextFormatFlags => CAcGPfX8i8owAuTAqus0giPUkHAGRxQHd6sDJUdCnh8mosdYjXRzMdeeE8BjcAxtGaUuPI6FPKWF7VBguDtTQJruZrNLWu6wepu1X7BFfFXOttlgKxaCeg7fAPr5;

	public NavMenuDrawItemEventArgs(Graphics graphics_0, MouseState mouseState_1, NavMenuItem navMenuItem_1, Rectangle rectangle_4, Rectangle rectangle_5, Rectangle rectangle_6, Rectangle rectangle_7, TextFormatFlags textFormatFlags_0)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		B8j6iemXk5VRqrzJNvBji36ZJNolk5AZg2Q6NQcxTHqmDpFhUKITKJ4egOAtRY8T7vii8FC1CyaIXPCOn2W7Y0VinC4xo8U656xigKXsU0ar6PqdJx0vmfY2xHgl = graphics_0;
		MouseState mouseState = (mouseState_0 = mouseState_1);
		navMenuItem_0 = navMenuItem_1;
		rectangle_0 = rectangle_4;
		Rectangle rectangle = (rectangle_3 = rectangle_5);
		rectangle_2 = rectangle_6;
		rectangle_1 = rectangle_7;
		CAcGPfX8i8owAuTAqus0giPUkHAGRxQHd6sDJUdCnh8mosdYjXRzMdeeE8BjcAxtGaUuPI6FPKWF7VBguDtTQJruZrNLWu6wepu1X7BFfFXOttlgKxaCeg7fAPr5 = textFormatFlags_0;
	}
}
