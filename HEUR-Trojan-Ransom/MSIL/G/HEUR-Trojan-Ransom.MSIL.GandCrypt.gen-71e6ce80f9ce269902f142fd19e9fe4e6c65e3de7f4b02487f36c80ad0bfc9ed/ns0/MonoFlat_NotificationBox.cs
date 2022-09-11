using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace ns0;

public class MonoFlat_NotificationBox : Control
{
	public enum Type
	{
		Notice,
		Success,
		Warning,
		Error
	}

	private GraphicsPath graphicsPath_0;

	private string string_0;

	private Type type_0;

	private bool bool_0;

	private bool bool_1;

	private Size size_0;

	internal Point point_0;

	internal bool bool_2;

	internal int int_0 = 8;

	internal Image image_0;

	public Type NotificationType
	{
		get
		{
			return type_0;
		}
		set
		{
			type_0 = value;
			((Control)this).Invalidate();
		}
	}

	public bool RoundCorners
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((Control)this).Invalidate();
		}
	}

	public bool ShowCloseButton
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((Control)this).Invalidate();
		}
	}

	public int BorderCurve
	{
		get
		{
			return int_0;
		}
		set
		{
			int num = (int_0 = value);
			((Control)this).Invalidate();
		}
	}

	public Image Image
	{
		get
		{
			return image_0;
		}
		set
		{
			if (value == null)
			{
				size_0 = Size.Empty;
			}
			else
			{
				size_0 = value.get_Size();
			}
			Image val = (image_0 = value);
			((Control)this).Invalidate();
		}
	}

	protected Size ImageSize => size_0;

	protected override void vmethod_0(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
		if (mouseEventArgs_0.get_X() >= ((Control)this).get_Width() - 19 && mouseEventArgs_0.get_X() <= ((Control)this).get_Width() - 10 && mouseEventArgs_0.get_Y() > point_0.Y && mouseEventArgs_0.get_Y() < point_0.Y + 12)
		{
			bool_2 = true;
		}
		else
		{
			bool_2 = false;
		}
		((Control)this).Invalidate();
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
		if (bool_1 && bool_2)
		{
			((Component)this).Dispose();
		}
	}

	internal GraphicsPath method_0(Rectangle rectangle_0, int int_1)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			graphicsPath_0 = new GraphicsPath((FillMode)1);
			graphicsPath_0.AddArc(rectangle_0.X, rectangle_0.Y, int_1, int_1, 180f, 90f);
			graphicsPath_0.AddArc(rectangle_0.Right - int_1, rectangle_0.Y, int_1, int_1, 270f, 90f);
			graphicsPath_0.AddArc(rectangle_0.Right - int_1, rectangle_0.Bottom - int_1, int_1, int_1, 0f, 90f);
			graphicsPath_0.AddArc(rectangle_0.X, rectangle_0.Bottom - int_1, int_1, int_1, 90f, 90f);
			graphicsPath_0.CloseFigure();
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + Environment.NewLine + Environment.NewLine + "Value must be either '1' or higher", "Invalid Integer", (MessageBoxButtons)0, (MessageBoxIcon)48);
			int_0 = 8;
			BorderCurve = 8;
		}
		return graphicsPath_0;
	}

	public MonoFlat_NotificationBox()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)139282, true);
		((Control)this).set_Font(new Font("Tahoma", 9f));
		((Control)this).set_MinimumSize(new Size(100, 40));
		RoundCorners = false;
		ShowCloseButton = true;
	}

	protected override void vmethod_2(PaintEventArgs paintEventArgs_0)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Expected O, but got Unknown
		//IL_0343: Expected O, but got Unknown
		//IL_0343: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		Color color = default(Color);
		Color color2 = default(Color);
		Color color3 = default(Color);
		Font val = new Font(((Control)this).get_Font().get_FontFamily(), ((Control)this).get_Font().get_Size(), (FontStyle)1);
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
		GraphicsPath val2 = method_0(rectangle, int_0);
		graphics.set_SmoothingMode((SmoothingMode)2);
		graphics.set_TextRenderingHint((TextRenderingHint)5);
		graphics.Clear(((Control)this).get_Parent().get_BackColor());
		switch (type_0)
		{
		case Type.Notice:
			color2 = Color.FromArgb(111, 177, 199);
			color3 = Color.FromArgb(111, 177, 199);
			color = Color.White;
			break;
		case Type.Success:
			color2 = Color.FromArgb(91, 195, 162);
			color3 = Color.FromArgb(91, 195, 162);
			color = Color.White;
			break;
		case Type.Warning:
			color2 = Color.FromArgb(254, 209, 108);
			color3 = Color.FromArgb(254, 209, 108);
			color = Color.DimGray;
			break;
		case Type.Error:
			color2 = Color.FromArgb(217, 103, 93);
			color3 = Color.FromArgb(217, 103, 93);
			color = Color.White;
			break;
		}
		if (bool_0)
		{
			graphics.FillPath((Brush)new SolidBrush(color2), val2);
			graphics.DrawPath(new Pen(color3), val2);
		}
		else
		{
			graphics.FillRectangle((Brush)new SolidBrush(color2), rectangle);
			graphics.DrawRectangle(new Pen(color3), rectangle);
		}
		switch (type_0)
		{
		case Type.Notice:
			string_0 = "  ";
			break;
		case Type.Success:
			string_0 = "  ";
			break;
		case Type.Warning:
			string_0 = "  ";
			break;
		case Type.Error:
			string_0 = "  ";
			break;
		}
		if (Image == null)
		{
			graphics.DrawString(string_0, val, (Brush)new SolidBrush(color), (PointF)new Point(10, 5));
			graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(color), (RectangleF)new Rectangle(10, 21, ((Control)this).get_Width() - 17, ((Control)this).get_Height() - 5));
		}
		else
		{
			graphics.DrawImage(image_0, 12, 4, 16, 16);
			graphics.DrawString(string_0, val, (Brush)new SolidBrush(color), (PointF)new Point(30, 5));
			graphics.DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), (Brush)new SolidBrush(color), (RectangleF)new Rectangle(10, 21, ((Control)this).get_Width() - 17, ((Control)this).get_Height() - 5));
		}
		Point point = (point_0 = new Point(((Control)this).get_Width() - 26, 4));
		if (bool_1)
		{
			Font val3 = new Font("Marlett", 7f, (FontStyle)0);
			SolidBrush val4 = new SolidBrush(Color.FromArgb(130, 130, 130));
			RectangleF rectangleF = new Rectangle(((Control)this).get_Width() - 20, 10, ((Control)this).get_Width(), ((Control)this).get_Height());
			StringFormat val5 = new StringFormat();
			val5.set_Alignment((StringAlignment)0);
			val5.set_LineAlignment((StringAlignment)0);
			graphics.DrawString("r", val3, (Brush)val4, rectangleF, val5);
		}
		val2.Dispose();
	}
}
