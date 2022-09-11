using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class AVComboBox : ComboBox
{
	private int int_0;

	private Color color_0;

	private Color color_1;

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
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			((Control)this).Invalidate();
		}
	}

	public void ReplaceItem(object sender, DrawItemEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		e.DrawBackground();
		checked
		{
			try
			{
				if ((e.get_State() & 1) == 1)
				{
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.LightGray), e.get_Bounds());
					SolidBrush val = new SolidBrush(e.get_ForeColor());
					try
					{
						e.get_Graphics().DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), new Font("Verdana", 10f), (Brush)(object)val, 1f, (float)(e.get_Bounds().Top + 5));
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				else
				{
					e.get_Graphics().DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), new Font("Verdana", 10f), Brushes.get_Gray(), 1f, (float)(e.get_Bounds().Top + 5));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			e.DrawFocusRectangle();
			((Control)this).Invalidate();
		}
	}

	protected void DrawTriangle(Color color_0, Point point_0, Point point_1, Point point_2, Graphics graphics_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		List<Point> list = new List<Point>();
		list.Add(point_0);
		list.Add(point_1);
		list.Add(point_2);
		graphics_0.FillPolygon((Brush)new SolidBrush(color_0), list.ToArray());
	}

	public AVComboBox()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((ComboBox)this)._002Ector();
		((ComboBox)this).add_DrawItem(new DrawItemEventHandler(ReplaceItem));
		int_0 = 0;
		color_0 = Color.FromArgb(254, 254, 254);
		color_1 = Color.FromArgb(244, 244, 244);
		((Control)this).set_Width(163);
		((Control)this).set_Font(new Font("Verdana", 15f));
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_BackColor(color_0);
		((ComboBox)this).set_ForeColor(color_0);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((ComboBox)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		color_1 = Color.FromArgb(233, 233, 233);
		((Control)this).Invalidate();
		((Control)this).OnMouseClick(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		color_1 = Color.FromArgb(244, 244, 244);
		((Control)this).Invalidate();
		((Control)this).OnMouseUp(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d4: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Graphics graphics = e.get_Graphics();
		checked
		{
			graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(color_1.ToArgb())), new Rectangle(((Control)this).get_Width() - 20, 2, 17, ((Control)this).get_Height() - 5));
			graphics.set_SmoothingMode((SmoothingMode)2);
			try
			{
				graphics.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(216, 216, 216))), new Rectangle(((Control)this).get_Width() - 20, 2, 17, ((Control)this).get_Height() - 5));
				try
				{
					string text = ((ComboBox)this).get_Text();
					Font val = new Font("Verdana", 10f);
					Brush gray = Brushes.get_Gray();
					RectangleF rectangleF = new Rectangle(3, 0, ((Control)this).get_Width() - 20, ((Control)this).get_Height());
					StringFormat val2 = new StringFormat();
					val2.set_LineAlignment((StringAlignment)1);
					val2.set_Alignment((StringAlignment)0);
					graphics.DrawString(text, val, gray, rectangleF, val2);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(216, 216, 216))), 0, 0, 0, 0);
				graphics.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(216, 216, 216))), new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
				DrawTriangle(Color.FromArgb(216, 216, 216), new Point(((Control)this).get_Width() - 15, 14), new Point(((Control)this).get_Width() - 8, 14), new Point(((Control)this).get_Width() - 12, 17), graphics);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
	}
}
