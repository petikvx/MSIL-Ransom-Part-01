using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GControl11 : TabControl
{
	private int[] int_0;

	private int[] int_1;

	public GControl11()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		int_0 = new int[10000];
		int_1 = new int[10000];
		((TabControl)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)73746, true);
		((Control)this).set_DoubleBuffered(true);
		foreach (TabPage tabPage in ((TabControl)this).get_TabPages())
		{
			TabPage val = tabPage;
			((Control)val).set_BackColor(Color.White);
			Application.DoEvents();
			((Control)val).set_BackColor(Color.Transparent);
		}
	}

	protected override void CreateHandle()
	{
		((TabControl)this).CreateHandle();
		for (int num = 0; num == 0; num = 1)
		{
			((TabControl)this).set_Alignment((TabAlignment)0);
		}
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		((Control)this).OnMouseClick(e);
		int num = 0;
		int num2 = default(int);
		bool flag = default(bool);
		int[] array = default(int[]);
		int num4 = default(int);
		int num3 = default(int);
		int num5 = default(int);
		SizeF sizeF = default(SizeF);
		while (true)
		{
			switch (num)
			{
			case 10:
				num2++;
				goto case 5;
			case 5:
				flag = num2 < array.Length;
				num = 11;
				break;
			case 9:
				num4++;
				num = 10;
				break;
			case 8:
				((Control)this).Invalidate();
				num = 9;
				break;
			case 7:
				if (!flag)
				{
					((TabControl)this).set_SelectedIndex(num4);
					num = 8;
					break;
				}
				goto case 9;
			case 6:
				flag = !((e.get_X() > num3) & (e.get_X() < int_1[num4]) & (e.get_Y() < num5) & ((int)e.get_Button() == 1048576));
				num = 7;
				break;
			case 4:
				num2 = 0;
				num = 5;
				break;
			case 3:
				array = int_0;
				num = 4;
				break;
			case 2:
				num5 = (int)sizeF.Height + 8;
				num = 3;
				break;
			case 1:
				sizeF = ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font());
				num = 2;
				break;
			case 0:
				num4 = 0;
				num = 1;
				break;
			default:
				if (flag)
				{
					num3 = array[num2];
					num = 6;
					break;
				}
				return;
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0329: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0388: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bf: Expected O, but got Unknown
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0532: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_0637: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Expected O, but got Unknown
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d3: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_086b: Expected O, but got Unknown
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_0896: Expected O, but got Unknown
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c2: Expected O, but got Unknown
		//IL_08de: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		int num = 0;
		Graphics val2 = default(Graphics);
		bool flag = default(bool);
		int num3 = default(int);
		int num2 = default(int);
		TabPage val4 = default(TabPage);
		LinearGradientBrush val5 = default(LinearGradientBrush);
		HatchBrush val3 = default(HatchBrush);
		while (true)
		{
			switch (num)
			{
			case 22:
				((Image)val).Dispose();
				num = 23;
				break;
			case 21:
				val2.Dispose();
				num = 22;
				break;
			case 20:
				e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
				num = 21;
				break;
			case 19:
				val2.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				num = 20;
				break;
			case 18:
				val2.DrawLine(Pens.get_Black(), 0, 0, 0, ((Control)this).get_Height() - 1);
				num = 19;
				break;
			case 17:
				val2.DrawLine(Pens.get_Black(), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
				num = 18;
				break;
			case 16:
				val2.DrawLine(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, 0);
				num = 17;
				break;
			case 15:
				val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), ((Control)this).get_Width() - 2, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
				num = 16;
				break;
			case 14:
				val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 1, ((Control)this).get_Height() - 2);
				num = 15;
				break;
			case 13:
				val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1, ((Control)this).get_Height() - 2, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
				num = 14;
				break;
			case 12:
			{
				IEnumerator enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
				try
				{
					while (true)
					{
						IL_0727:
						flag = enumerator.MoveNext();
						int num4 = 19;
						while (true)
						{
							switch (num4)
							{
							case 17:
								num3++;
								num4 = 18;
								continue;
							case 16:
								num2 += (int)((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15;
								num4 = 17;
								continue;
							case 15:
								val2.DrawString(((Control)val4).get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (float)(num2 + 8), 5f);
								num4 = 16;
								continue;
							case 14:
								int_1[num3] = num2 + (int)((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15;
								num4 = 15;
								continue;
							case 13:
								int_0[num3] = num2;
								num4 = 14;
								continue;
							case 12:
								val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), 1f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f, (float)num2, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
								num4 = 13;
								continue;
							case 11:
								val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), (float)num2 + ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f, (float)(((Control)this).get_Width() - 1), ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
								num4 = 12;
								continue;
							case 10:
								val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), (float)num2, 2f, (float)num2, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
								num4 = 11;
								continue;
							case 9:
								val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), (float)num2 + ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, 2f, (float)num2 + ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
								num4 = 10;
								continue;
							case 8:
								val2.FillRectangle((Brush)(object)val5, (float)num2, 1f, ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 5f);
								num4 = 9;
								continue;
							case 7:
								val5 = new LinearGradientBrush(new Point(num2, 1), new Point(num2, (int)((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8), Color.FromArgb(15, Color.White), Color.Transparent);
								num4 = 8;
								continue;
							case 6:
								val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), (float)num2, 1f, ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
								num4 = 7;
								continue;
							case 5:
								val2.FillRectangle((Brush)(object)val3, (float)num2, 1f, ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
								num4 = 6;
								continue;
							case 4:
								val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
								num4 = 5;
								continue;
							case 3:
								val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), (float)num2, 1f, ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
								num4 = 4;
								continue;
							case 2:
								val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
								num4 = 3;
								continue;
							case 1:
								if (!flag)
								{
									val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), (float)num2, 1f, ((Control)this).CreateGraphics().MeasureString(((Control)val4).get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
									num4 = 2;
									continue;
								}
								goto case 13;
							case 0:
								flag = ((TabControl)this).get_SelectedIndex() != num3;
								num4 = 1;
								continue;
							default:
								if (flag)
								{
									val4 = (TabPage)enumerator.Current;
									num4 = 0;
									continue;
								}
								goto end_IL_06d4;
							case 18:
								break;
							}
							goto IL_0727;
							continue;
							end_IL_06d4:
							break;
						}
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 0;
					while (true)
					{
						switch (num5)
						{
						case 1:
							if (!flag)
							{
								disposable.Dispose();
								num5 = 2;
								continue;
							}
							break;
						case 0:
							flag = disposable == null;
							num5 = 1;
							continue;
						}
						break;
					}
				}
				val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, ((Control)this).get_Width() - 2, 1);
				num = 13;
				break;
			}
			case 11:
				num3 = 0;
				num = 12;
				break;
			case 10:
				num2 = 0;
				num = 11;
				break;
			case 9:
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.Black)), 2f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 7f, (float)(((Control)this).get_Width() - 2), (float)(((Control)this).get_Height() - 2));
				num = 10;
				break;
			case 8:
				val2.FillRectangle(Brushes.get_Black(), 0f, 0f, (float)((Control)this).get_Width(), ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
				num = 9;
				break;
			case 7:
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 8;
				break;
			case 6:
				val2.FillRectangle((Brush)(object)val3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				num = 7;
				break;
			case 5:
				val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
				num = 6;
				break;
			case 4:
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height()));
				num = 5;
				break;
			case 3:
				val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
				num = 4;
				break;
			case 2:
				val3 = null;
				num = 3;
				break;
			case 1:
				val2.Clear(Color.FromArgb(60, 60, 60));
				num = 2;
				break;
			case 0:
				val2 = Graphics.FromImage((Image)(object)val);
				num = 1;
				break;
			default:
				return;
			}
		}
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		((TabControl)this).OnSelectedIndexChanged(e);
		for (int num = 0; num == 0; num = 1)
		{
			((Control)this).Invalidate();
		}
	}
}
