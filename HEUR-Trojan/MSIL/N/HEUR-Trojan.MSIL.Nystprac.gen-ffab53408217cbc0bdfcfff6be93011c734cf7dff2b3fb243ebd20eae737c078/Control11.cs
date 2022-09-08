using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class Control11 : TabControl
{
	private static List<WeakReference> list_0;

	private int[] int_0;

	private int[] int_1;

	[DebuggerNonUserCode]
	static Control11()
	{
		Class14.hYiyYvszsKHjE();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	public Control11()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((TabControl)this)._002Ector();
		smethod_0(this);
		int_0 = new int[10000];
		int_1 = new int[10000];
		((Control)this).SetStyle((ControlStyles)73746, true);
		((TabControl)this).set_DoubleBuffered(true);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TabPage val = (TabPage)enumerator.Current;
				val.set_BackColor(Color.White);
				Application.DoEvents();
				val.set_BackColor(Color.Transparent);
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

	protected override void CreateHandle()
	{
		((TabControl)this).CreateHandle();
		((TabControl)this).set_Alignment((TabAlignment)0);
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Invalid comparison between Unknown and I4
		((Control)this).OnMouseClick(e);
		int num = 0;
		int num2 = checked((int)Math.Round(((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f));
		int[] array = int_0;
		foreach (int num3 in array)
		{
			if ((e.get_X() > num3) & (e.get_X() < int_1[num]) & (e.get_Y() < num2) & ((int)e.get_Button() == 1048576))
			{
				((TabControl)this).set_SelectedIndex(num);
				((Control)this).Invalidate();
			}
			num = checked(num + 1);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a1: Expected O, but got Unknown
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e7: Expected O, but got Unknown
		//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_06bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_06de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0751: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.Clear(Color.FromArgb(60, 60, 60));
		HatchBrush val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
		SolidBrush val4 = new SolidBrush(Color.FromArgb(60, 60, 60));
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		val2.FillRectangle((Brush)val4, rectangle);
		val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
		val2.FillRectangle((Brush)(object)val3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		val2.FillRectangle(Brushes.get_Black(), 0f, 0f, (float)((Control)this).get_Width(), ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
		checked
		{
			val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(20, Color.Black)), 2f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 7f, (float)(((Control)this).get_Width() - 2), (float)(((Control)this).get_Height() - 2));
			int num = 0;
			int num2 = 0;
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
				while (enumerator.MoveNext())
				{
					TabPage val5 = (TabPage)enumerator.Current;
					if (((TabControl)this).get_SelectedIndex() == num2)
					{
						val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), (float)num, 1f, ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
						val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
						val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(60, 60, 60)), (float)num, 1f, ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
						val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
						val2.FillRectangle((Brush)(object)val3, (float)num, 1f, ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
						val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), (float)num, 1f, ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 10f);
						Point point = new Point(num, 1);
						Point point2 = new Point(num, (int)Math.Round(((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f));
						LinearGradientBrush val6 = new LinearGradientBrush(point, point2, Color.FromArgb(15, Color.White), Color.Transparent);
						val2.FillRectangle((Brush)(object)val6, (float)num, 1f, ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 5f);
						val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), (float)num + ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, 2f, (float)num + ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
						val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), (float)num, 2f, (float)num, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
						val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), (float)num + ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f, (float)(((Control)this).get_Width() - 1), ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
						val2.DrawLine(new Pen(Color.FromArgb(60, 60, 60)), 1f, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f, (float)num, ((Control)this).CreateGraphics().MeasureString("Mava is awesome", ((Control)this).get_Font()).Height + 8f);
					}
					int_0[num2] = num;
					int_1[num2] = (int)Math.Round((float)num + ((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f);
					val2.DrawString(val5.get_Text(), ((Control)this).get_Font(), Brushes.get_White(), (float)(num + 8), 5f);
					num = (int)Math.Round((float)num + (((Control)this).CreateGraphics().MeasureString(val5.get_Text(), ((Control)this).get_Font()).Width + 15f));
					num2++;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, ((Control)this).get_Width() - 2, 1);
			val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1, ((Control)this).get_Height() - 2, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, 1, ((Control)this).get_Height() - 2);
			val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), ((Control)this).get_Width() - 2, 1, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			val2.DrawLine(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, 0);
			val2.DrawLine(Pens.get_Black(), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
			val2.DrawLine(Pens.get_Black(), 0, 0, 0, ((Control)this).get_Height() - 1);
			val2.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}

	protected override void OnSelectedIndexChanged(EventArgs e)
	{
		((TabControl)this).OnSelectedIndexChanged(e);
		((Control)this).Invalidate();
	}
}
