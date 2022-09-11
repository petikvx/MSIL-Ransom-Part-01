using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class Control0 : TabControl
{
	private bool bool_0;

	private Pen pen_0;

	private StringAlignment stringAlignment_0;

	private Rectangle rectangle_0;

	private Rectangle rectangle_1;

	private Pen pen_1;

	private Pen pen_2;

	private SolidBrush solidBrush_0;

	private SolidBrush UmMlmewhPD;

	private SolidBrush solidBrush_1;

	private object object_0;

	private object object_1;

	private TabPage tabPage_0;

	private StringFormat stringFormat_0;

	private int int_0;

	private Size size_0;

	private Rectangle rectangle_2;

	private object object_2;

	private Graphics graphics_0;

	private int int_1;

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	public void method_1(bool bool_1)
	{
		bool_0 = bool_1;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public Color method_2()
	{
		return pen_0.get_Color();
	}

	[SpecialName]
	public void method_3(Color color_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		pen_0 = new Pen(color_0);
		((Control)this).Invalidate();
	}

	[SpecialName]
	public StringAlignment method_4()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return stringAlignment_0;
	}

	[SpecialName]
	public void method_5(StringAlignment stringAlignment_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		stringAlignment_0 = stringAlignment_1;
		((Control)this).Invalidate();
	}

	public Control0()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((TabControl)this)._002Ector();
		pen_0 = Pens.get_Black();
		stringAlignment_0 = (StringAlignment)0;
		rectangle_2 = default(Rectangle);
		int_1 = -1;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((TabControl)this).set_SizeMode((TabSizeMode)2);
		((TabControl)this).set_Alignment((TabAlignment)2);
		((TabControl)this).set_ItemSize(new Size(50, 50));
		((Control)this).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3));
		((TabControl)this).set_DrawMode((TabDrawMode)1);
		pen_1 = new Pen(Color.FromArgb(94, 94, 94));
		pen_2 = new Pen(Color.FromArgb(17, 17, 17));
		solidBrush_0 = new SolidBrush(Color.FromArgb(38, 38, 38));
		UmMlmewhPD = new SolidBrush(Color.FromArgb(35, 35, 35));
		solidBrush_1 = new SolidBrush(Color.FromArgb(5, Color.White));
		stringFormat_0 = new StringFormat();
		stringFormat_0.set_LineAlignment((StringAlignment)1);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TabPage val = (TabPage)enumerator.Current;
				val.set_BackColor(Color.FromArgb(242, 242, 242));
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	protected override void OnControlAdded(ControlEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (e.get_Control() is TabPage)
		{
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((Control)this).get_Controls().GetEnumerator();
				while (enumerator.MoveNext())
				{
					_ = (TabPage)enumerator.Current;
					new TabPage();
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			e.get_Control().set_BackColor(Color.FromArgb(242, 242, 242));
		}
		((Control)this).OnControlAdded(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b4: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3);
		graphics_0 = e.get_Graphics();
		graphics_0.set_TextRenderingHint((TextRenderingHint)5);
		graphics_0.set_SmoothingMode((SmoothingMode)4);
		graphics_0.Clear(Color.FromArgb(242, 242, 242));
		checked
		{
			int_0 = ((TabControl)this).get_ItemSize().Height + 2;
			graphics_0.FillRectangle((Brush)(object)solidBrush_0, 0, 0, int_0, ((Control)this).get_Height());
			graphics_0.DrawRectangle(Pens.get_Black(), 0, 0, int_0, ((Control)this).get_Height());
			SolidBrush val = new SolidBrush(Color.FromArgb(51, 51, 51));
			Pen val2 = new Pen((Brush)(object)val);
			int num = ((TabControl)this).get_TabCount() - 1;
			for (int i = 0; i <= num; i++)
			{
				rectangle_0 = ((TabControl)this).GetTabRect(i);
				rectangle_0.Y--;
				rectangle_0.Width++;
				rectangle_0.X--;
				tabPage_0 = ((TabControl)this).get_TabPages().get_Item(i);
				if (((TabControl)this).get_SelectedIndex() == i)
				{
					LinearGradientBrush val3 = new LinearGradientBrush(rectangle_0, Color.FromArgb(26, 26, 26), Color.FromArgb(17, 17, 17), 90f);
					try
					{
						ColorBlend val4 = new ColorBlend();
						val4.set_Colors(new Color[3]
						{
							Color.FromArgb(25, 25, 25),
							Color.FromArgb(17, 17, 17),
							Color.FromArgb(25, 25, 25)
						});
						val4.set_Positions(new float[3] { 0f, 0.5f, 1f });
						val3.set_InterpolationColors(val4);
						graphics_0.FillRectangle((Brush)(object)val3, rectangle_0);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
					graphics_0.DrawLine(val2, rectangle_0.Left, rectangle_0.Y - 1, rectangle_0.Width + 1, rectangle_0.Y - 1);
					if (int_1 == i)
					{
						graphics_0.FillRectangle((Brush)(object)solidBrush_1, rectangle_0);
					}
					rectangle_0.X += 5;
					rectangle_0.Width -= 14;
					rectangle_1 = rectangle_0;
					rectangle_1.Y++;
					rectangle_1.X++;
					stringFormat_0.set_Alignment(stringAlignment_0);
					graphics_0.DrawString(tabPage_0.get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (RectangleF)new Rectangle(rectangle_1.Left + 33, rectangle_1.Top - 1, rectangle_1.Width - 43, rectangle_1.Height), stringFormat_0);
					try
					{
						graphics_0.DrawImage(((TabControl)this).get_ImageList().get_Images().get_Item(((TabControl)this).get_TabPages().get_Item(i).get_ImageIndex()), rectangle_0.X + 1, rectangle_0.Y + 11, 32, 32);
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				else
				{
					SolidBrush val5 = new SolidBrush(Color.FromArgb(38, 38, 38));
					rectangle_0.Y--;
					graphics_0.FillRectangle((Brush)(object)val5, rectangle_0);
					graphics_0.DrawLine(val2, rectangle_0.X, rectangle_0.Y, rectangle_0.Right, rectangle_0.Y);
					if (int_1 == i)
					{
						graphics_0.FillRectangle((Brush)(object)solidBrush_1, rectangle_0);
					}
					new SolidBrush(Color.FromArgb(140, Color.Black));
					graphics_0.DrawLine(pen_2, rectangle_0.X, rectangle_0.Bottom - 1, rectangle_0.Right, rectangle_0.Bottom - 1);
					rectangle_0.X += 5;
					rectangle_0.Width -= 14;
					rectangle_1 = rectangle_0;
					rectangle_1.Y++;
					rectangle_1.X++;
					stringFormat_0.set_Alignment(stringAlignment_0);
					graphics_0.DrawString(tabPage_0.get_Text(), ((Control)this).get_Font(), Brushes.get_Gray(), (RectangleF)new Rectangle(rectangle_1.Left + 33, rectangle_1.Top - 1, rectangle_1.Width - 43, rectangle_1.Height), stringFormat_0);
					try
					{
						graphics_0.DrawImage(((TabControl)this).get_ImageList().get_Images().get_Item(((TabControl)this).get_TabPages().get_Item(i).get_ImageIndex()), rectangle_0.X + 2, rectangle_0.Y + 11, 32, 32);
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				graphics_0.DrawLine(val2, rectangle_0.Right + 8, rectangle_0.Top, rectangle_0.Right + 8, rectangle_0.Bottom - 3);
			}
			graphics_0.DrawLine(Pens.get_Black(), 0, 0, rectangle_1.Height - 9, 0);
			graphics_0.DrawLine(pen_0, int_0, 0, int_0, ((Control)this).get_Height());
			graphics_0.DrawLine(val2, rectangle_0.Left - 5, ((TabControl)this).get_ItemSize().Width * ((TabControl)this).get_TabCount(), rectangle_0.Right + 8, ((TabControl)this).get_ItemSize().Width * ((TabControl)this).get_TabCount());
			if (bool_0)
			{
				graphics_0.DrawLine(pen_0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
			}
			graphics_0.DrawLine(val2, rectangle_0.Left - 5, ((TabControl)this).get_TabCount() * (rectangle_0.Width + 12) + ((TabControl)this).get_TabCount() * 2, rectangle_0.Left - 5, 1);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		checked
		{
			int num = ((TabControl)this).get_TabPages().get_Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				if (((TabControl)this).GetTabRect(i).Contains(e.get_Location()))
				{
					int_1 = i;
					break;
				}
			}
			((Control)this).Invalidate();
			((Control)this).OnMouseMove(e);
		}
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		int_1 = -1;
		((Control)this).Invalidate();
		((Control)this).OnMouseLeave(e);
	}
}
