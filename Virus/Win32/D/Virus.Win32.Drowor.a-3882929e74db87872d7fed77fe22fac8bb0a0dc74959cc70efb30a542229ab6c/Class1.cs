using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Class1 : Panel
{
	private Color color_0;

	private Color color_1;

	private Color color_2;

	private string string_0;

	private Font font_0;

	private SizeF sizeF_0;

	private Color color_3;

	private bool bool_0;

	[SpecialName]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	public void method_1(string string_1)
	{
		string_0 = string_1;
	}

	[SpecialName]
	public bool method_2()
	{
		return bool_0;
	}

	[SpecialName]
	public void method_3(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public Class1()
		: this("")
	{
	}

	public Class1(string string_1)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		string_0 = string_1;
		font_0 = new Font(FontFamily.get_GenericSerif(), 8f);
		color_0 = Color.Green;
		color_1 = Color.Yellow;
		color_2 = Color.Red;
		color_3 = color_0;
		method_3(bool_1: false);
	}

	protected override void OnPaint(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaint(paintEventArgs_0);
		sizeF_0 = paintEventArgs_0.get_Graphics().MeasureString(method_0(), font_0);
		RectangleF visibleClipBounds = paintEventArgs_0.get_Graphics().get_VisibleClipBounds();
		if (method_2())
		{
			paintEventArgs_0.get_Graphics().Clear(color_2);
		}
		else
		{
			paintEventArgs_0.get_Graphics().Clear(color_3);
			paintEventArgs_0.get_Graphics().DrawLine(Pens.get_Blue(), visibleClipBounds.Right - 1f, 0f, visibleClipBounds.Right - 1f, visibleClipBounds.Bottom);
		}
		paintEventArgs_0.get_Graphics().DrawLine(Pens.get_LightGray(), 0f, 0f, visibleClipBounds.Right, 0f);
		paintEventArgs_0.get_Graphics().DrawLine(Pens.get_LightGray(), 0f, visibleClipBounds.Bottom, visibleClipBounds.Right, visibleClipBounds.Bottom);
		paintEventArgs_0.get_Graphics().DrawString(method_0(), font_0, Brushes.get_Black(), visibleClipBounds.Right * 0.5f - sizeF_0.Width * 0.5f, visibleClipBounds.Bottom * 0.5f - sizeF_0.Height * 0.5f);
	}

	private void method_4()
	{
		((Control)this).Invalidate();
	}

	protected override void OnMouseEnter(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
		color_3 = color_1;
		method_4();
	}

	protected override void OnMouseHover(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseHover(eventArgs_0);
		color_3 = color_1;
		method_4();
	}

	protected override void OnMouseDown(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(mouseEventArgs_0);
		if ((int)mouseEventArgs_0.get_Button() == 1048576)
		{
			color_3 = color_2;
			method_4();
		}
	}

	protected override void OnMouseLeave(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
		color_3 = color_0;
		method_4();
	}

	protected override void OnMouseUp(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		color_3 = color_1;
		method_4();
	}
}
