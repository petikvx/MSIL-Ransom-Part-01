using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXComboBox : ComboBox
{
	private int int_0;

	private Color color_0 = Color.FromArgb(55, 55, 55);

	public int StartIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			try
			{
				((ComboBox)this).set_SelectedIndex(value);
			}
			catch
			{
			}
			((Control)this).Invalidate();
		}
	}

	public Color ItemHighlightColor
	{
		get
		{
			return color_0;
		}
		set
		{
			((Control)this).Invalidate();
		}
	}

	internal static void smethod_0(byte[] byte_0, byte[] byte_1, int int_1)
	{
		byte_0[int_1] = Class6.smethod_0(byte_0, byte_1, int_1);
	}

	public void method_0(object sender, DrawItemEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		e.DrawBackground();
		try
		{
			if ((e.get_State() & 1) == 1)
			{
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(color_0), e.get_Bounds());
				LinearGradientBrush val = new LinearGradientBrush(e.get_Bounds(), Color.FromArgb(30, Color.White), Color.FromArgb(0, Color.White), 90f);
				e.get_Graphics().FillRectangle((Brush)(object)val, new Rectangle(new Point(e.get_Bounds().X, e.get_Bounds().Y), new Size(e.get_Bounds().Width, e.get_Bounds().Height)));
				Graphics graphics = e.get_Graphics();
				Pen val2 = new Pen(Color.FromArgb(90, Color.Black));
				val2.set_DashStyle((DashStyle)0);
				graphics.DrawRectangle(val2, new Rectangle(e.get_Bounds().X, e.get_Bounds().Y, e.get_Bounds().Width - 1, e.get_Bounds().Height - 1));
			}
			else
			{
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(40, 40, 40)), e.get_Bounds());
			}
			SolidBrush val3 = new SolidBrush(Color.Silver);
			try
			{
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		catch
		{
		}
		e.DrawFocusRectangle();
	}

	protected void method_1(Color color_1, Point point_0, Point point_1, Point point_2, Point point_3, Point point_4, Point point_5, Graphics graphics_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		List<Point> list = new List<Point>();
		list.Add(point_0);
		list.Add(point_1);
		list.Add(point_2);
		graphics_0.FillPolygon((Brush)new SolidBrush(color_1), list.ToArray());
		graphics_0.DrawPolygon(new Pen((Brush)new SolidBrush(Color.FromArgb(25, 25, 25))), list.ToArray());
		List<Point> list2 = new List<Point>();
		list2.Add(point_3);
		list2.Add(point_4);
		list2.Add(point_5);
		graphics_0.FillPolygon((Brush)new SolidBrush(color_1), list2.ToArray());
		graphics_0.DrawPolygon(new Pen((Brush)new SolidBrush(Color.FromArgb(25, 25, 25))), list2.ToArray());
	}

	internal static byte smethod_1(byte[] byte_0, byte[] byte_1, int int_1)
	{
		return (byte)(byte_0[int_1] ^ byte_1[int_1 % byte_1.Length]);
	}

	public LXComboBox()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)75794, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.Silver);
		((Control)this).set_Font(new Font(" ", 8f, (FontStyle)0));
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Size(new Size(((Control)this).get_Width(), 21));
		((ComboBox)this).set_ItemHeight(16);
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0296: Expected O, but got Unknown
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		val2.Clear(((Control)this).get_BackColor());
		new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2), Color.FromArgb(40, 40, 40), Color.FromArgb(40, 40, 40), 90f);
		LinearGradientBrush val3 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3), Color.FromArgb(40, 40, 40), Color.FromArgb(40, 40, 40), 90f);
		val2.DrawPath(new Pen((Brush)(object)val3), Class7.smethod_0(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4), 3));
		val2.DrawPath(new Pen(Color.FromArgb(20, 20, 20)), Class7.smethod_0(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 3));
		val2.DrawPath(new Pen(Color.FromArgb(55, 55, 55)), Class7.smethod_0(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3), 3));
		method_1(Color.FromArgb(60, 60, 60), new Point(((Control)this).get_Width() - 14, 12), new Point(((Control)this).get_Width() - 7, 12), new Point(((Control)this).get_Width() - 11, 16), new Point(((Control)this).get_Width() - 14, 10), new Point(((Control)this).get_Width() - 7, 10), new Point(((Control)this).get_Width() - 11, 5), val2);
		val2.DrawLine(new Pen(Color.FromArgb(45, 45, 45)), new Point(((Control)this).get_Width() - 21, 2), new Point(((Control)this).get_Width() - 21, ((Control)this).get_Height() - 3));
		val2.DrawLine(new Pen(Color.FromArgb(55, 55, 55)), new Point(((Control)this).get_Width() - 20, 1), new Point(((Control)this).get_Width() - 20, ((Control)this).get_Height() - 3));
		val2.DrawLine(new Pen(Color.FromArgb(45, 45, 45)), new Point(((Control)this).get_Width() - 19, 2), new Point(((Control)this).get_Width() - 19, ((Control)this).get_Height() - 3));
		try
		{
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val4 = new SolidBrush(((Control)this).get_ForeColor());
			RectangleF rectangleF = new Rectangle(5, 0, ((Control)this).get_Width() - 20, ((Control)this).get_Height());
			StringFormat val5 = new StringFormat();
			val5.set_LineAlignment((StringAlignment)1);
			val5.set_Alignment((StringAlignment)0);
			val2.DrawString(text, font, (Brush)val4, rectangleF, val5);
		}
		catch
		{
		}
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
