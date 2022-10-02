using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

public class EtherealClose : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private HelperMethods.MouseMode State;

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public EtherealClose()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)76306, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_Font(new Font("Marlett", 8f));
		Size size = new Size(20, 20);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				Graphics val3 = val2;
				val3.Clear(HelperMethods.GetHTMLColor("00001a"));
				val3.set_SmoothingMode((SmoothingMode)2);
				val3.set_TextRenderingHint((TextRenderingHint)4);
				val3.set_PixelOffsetMode((PixelOffsetMode)2);
				switch (State)
				{
				case HelperMethods.MouseMode.NormalMode:
					val3.FillEllipse((Brush)new SolidBrush(Color.FromArgb(120, HelperMethods.GetHTMLColor("966bc1"))), 1, 1, 19, 19);
					break;
				case HelperMethods.MouseMode.Hovered:
					((Control)this).set_Cursor(Cursors.get_Default());
					val3.FillEllipse((Brush)(object)HelperMethods.SolidBrushHTMlColor("00004d"), 1, 1, 19, 19);
					val3.DrawEllipse(HelperMethods.PenHTMlColor("f0f0f0", 2f), 1, 1, 18, 18);
					break;
				case HelperMethods.MouseMode.Pushed:
					val3.FillEllipse((Brush)(object)HelperMethods.SolidBrushHTMlColor("966bc1"), 1, 1, 19, 19);
					break;
				}
				Graphics obj = val3;
				Font font = ((Control)this).get_Font();
				Brush white = Brushes.get_White();
				Rectangle rectangle = new Rectangle(4, 6, 18, 18);
				obj.DrawString("r", font, white, (RectangleF)rectangle);
				val3 = null;
				NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
				{
					RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
					0,
					0
				}, (string[])null, (Type[])null, (bool[])null, true);
				val2.Dispose();
				((Image)val).Dispose();
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = HelperMethods.MouseMode.Pushed;
		((Control)this).Invalidate();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = HelperMethods.MouseMode.Hovered;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = HelperMethods.MouseMode.NormalMode;
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		Size size = new Size(20, 20);
		((Control)this).set_Size(size);
	}

	protected override void OnClick(EventArgs e)
	{
		((Control)this).OnClick(e);
		Environment.Exit(0);
		Application.Exit();
	}
}
