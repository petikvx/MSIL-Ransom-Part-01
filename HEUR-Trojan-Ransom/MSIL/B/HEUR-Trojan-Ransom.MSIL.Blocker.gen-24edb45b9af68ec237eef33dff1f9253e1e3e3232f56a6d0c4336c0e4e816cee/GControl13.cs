using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GControl13 : TabControl
{
	private Color color_0;

	private Color color_1;

	private LinearGradientBrush linearGradientBrush_0;

	private LinearGradientBrush linearGradientBrush_1;

	private Color color_2;

	public Color Color_0
	{
		get
		{
			return color_2;
		}
		set
		{
			color_2 = value;
			for (int num = 0; num == 0; num = 1)
			{
				((Control)this).Invalidate();
			}
		}
	}

	public GControl13()
	{
		if (1 == 0)
		{
		}
		((TabControl)this)._002Ector();
		color_0 = Color.FromArgb(37, 37, 37);
		color_1 = Color.FromArgb(44, 44, 44);
		((Control)this).SetStyle((ControlStyles)73746, true);
		Color_0 = Color.White;
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0437: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		int num = 0;
		checked
		{
			int num3 = default(int);
			SolidBrush val = default(SolidBrush);
			StringFormat val4 = default(StringFormat);
			int num2 = default(int);
			IEnumerator enumerator = default(IEnumerator);
			TabPage val7 = default(TabPage);
			Rectangle tabRect = default(Rectangle);
			Pen val6 = default(Pen);
			SolidBrush val2 = default(SolidBrush);
			Rectangle rectangle = default(Rectangle);
			Rectangle rectangle2 = default(Rectangle);
			while (true)
			{
				Rectangle rectangle3;
				switch (num)
				{
				default:
					return;
				case 23:
					e.get_Graphics().DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70))), 2, ((Control)this).get_Height() - 2, ((Control)this).get_Width() + 1, ((Control)this).get_Height() - 2);
					num = 24;
					break;
				case 22:
					e.get_Graphics().DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(35, 35, 35))), 0, 0, 1, 1);
					num = 23;
					break;
				case 21:
					e.get_Graphics().DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(255, Color.Black))), 2, 23, ((Control)this).get_Width() - 2, 23);
					num = 22;
					break;
				case 20:
				{
					Graphics graphics2 = e.get_Graphics();
					Pen val5 = new Pen((Brush)new SolidBrush(color_1));
					rectangle3 = new Rectangle(3, 24, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 28);
					graphics2.DrawRectangle(val5, rectangle3);
					num = 21;
					break;
				}
				case 19:
					e.get_Graphics().DrawString(((TabControl)this).get_TabPages().get_Item(num3).get_Text(), ((Control)this).get_Font(), (Brush)(object)val, (RectangleF)((TabControl)this).GetTabRect(num3), val4);
					try
					{
						((TabControl)this).get_TabPages().get_Item(num3).set_BackColor(Color.FromArgb(35, 35, 35));
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						for (int num4 = 0; num4 == 0; num4 = 1)
						{
							ProjectData.ClearProjectError();
						}
					}
					num3++;
					goto case 9;
				case 9:
					if (num3 > num2)
					{
						try
						{
							try
							{
								enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
								int num5 = 0;
								while (true)
								{
									if (num5 != 0)
									{
										((Panel)val7).set_BorderStyle((BorderStyle)0);
									}
									if (enumerator.MoveNext())
									{
										val7 = (TabPage)enumerator.Current;
										num5 = 1;
										continue;
									}
									break;
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
						catch (Exception projectError2)
						{
							ProjectData.SetProjectError(projectError2);
							for (int num6 = 0; num6 == 0; num6 = 1)
							{
								ProjectData.ClearProjectError();
							}
						}
						e.get_Graphics().DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(255, Color.Black))), 2, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
						num = 20;
					}
					else
					{
						tabRect = ((TabControl)this).GetTabRect(num3);
						num = 10;
					}
					break;
				case 18:
					if (((TabControl)this).get_SelectedIndex() == num3)
					{
						val.set_Color(Color_0);
						num = 19;
						break;
					}
					val.set_Color(Color.DimGray);
					goto case 19;
				case 17:
					val4.set_Alignment((StringAlignment)1);
					num = 18;
					break;
				case 16:
					val4.set_LineAlignment((StringAlignment)1);
					num = 17;
					break;
				case 15:
					val4 = new StringFormat();
					num = 16;
					break;
				case 14:
					val6.Dispose();
					num = 15;
					break;
				case 13:
				{
					Graphics graphics3 = e.get_Graphics();
					Pen obj = val6;
					rectangle3 = new Rectangle(tabRect.Location.X + 3, tabRect.Location.Y + 1, tabRect.Width - 8, tabRect.Height - 4);
					graphics3.DrawRectangle(obj, rectangle3);
					num = 14;
					break;
				}
				case 12:
					if (num3 == ((TabControl)this).get_SelectedIndex())
					{
						val6 = new Pen(Color.Transparent, 1f);
						num = 13;
						break;
					}
					val6 = new Pen(Color.Transparent, 1f);
					goto case 13;
				case 11:
					e.get_Graphics().FillRectangle((Brush)(object)val2, tabRect);
					num = 12;
					break;
				case 10:
					if ((unchecked((uint)num3) & (true ? 1u : 0u)) != 0)
					{
						val2.set_Color(Color.Transparent);
						num = 11;
						break;
					}
					val2.set_Color(Color.Transparent);
					goto case 11;
				case 8:
					num2 = ((TabControl)this).get_TabCount() - 1;
					num3 = 0;
					num = 9;
					break;
				case 7:
					e.get_Graphics().FillRectangle((Brush)(object)linearGradientBrush_1, rectangle);
					num = 8;
					break;
				case 6:
					linearGradientBrush_1 = new LinearGradientBrush(rectangle2, Color.FromArgb(62, Color.White), Color.FromArgb(30, Color.White), 90f);
					num = 7;
					break;
				case 5:
				{
					Graphics graphics = e.get_Graphics();
					SolidBrush val3 = new SolidBrush(Color.FromArgb(33, 33, 33));
					rectangle3 = new Rectangle(1, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
					graphics.FillRectangle((Brush)val3, rectangle3);
					num = 6;
					break;
				}
				case 4:
					val2 = new SolidBrush(Color.DimGray);
					num = 5;
					break;
				case 3:
					val = new SolidBrush(Color.Empty);
					num = 4;
					break;
				case 2:
					e.get_Graphics().Clear(Color.FromArgb(37, 37, 37));
					num = 3;
					break;
				case 1:
					rectangle2 = new Rectangle(2, 0, ((Control)this).get_Width() - 1, 11);
					num = 2;
					break;
				case 0:
					rectangle = new Rectangle(2, 0, ((Control)this).get_Width() - 1, 11);
					num = 1;
					break;
				}
			}
		}
	}
}
