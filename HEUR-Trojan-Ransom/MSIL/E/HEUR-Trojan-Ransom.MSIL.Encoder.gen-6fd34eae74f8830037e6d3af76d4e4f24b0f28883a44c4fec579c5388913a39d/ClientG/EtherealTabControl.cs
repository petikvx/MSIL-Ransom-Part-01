using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClientG;

public class EtherealTabControl : TabControl
{
	private struct MouseMode
	{
		public bool Hover;

		public Point Coordinates;
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseMode State;

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

	public EtherealTabControl()
	{
		__ENCAddToList(this);
		State = default(MouseMode);
		((Control)this).SetStyle((ControlStyles)141314, true);
		((TabControl)this).set_DoubleBuffered(true);
		((TabControl)this).set_SizeMode((TabSizeMode)2);
		((Control)this).set_Dock((DockStyle)0);
		Size itemSize = new Size(40, 170);
		((TabControl)this).set_ItemSize(itemSize);
		((TabControl)this).set_Alignment((TabAlignment)2);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		checked
		{
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					Graphics val3 = val2;
					val3.set_TextRenderingHint((TextRenderingHint)4);
					val3.set_InterpolationMode((InterpolationMode)7);
					SolidBrush br = HelperMethods.SolidBrushHTMlColor("030303");
					Rectangle rect = new Rectangle(0, 1, 150, ((Control)this).get_Height());
					HelperMethods.FillRect(val2, (Brush)(object)br, rect);
					int num = ((TabControl)this).get_TabCount() - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						Rectangle tabRect = ((TabControl)this).GetTabRect(num2);
						SolidBrush br2 = HelperMethods.SolidBrushHTMlColor("030303");
						rect = new Rectangle(tabRect.X - 1, tabRect.Y - 1, tabRect.Width - 3, tabRect.Height);
						HelperMethods.FillRect(val2, (Brush)(object)br2, rect);
						if (num2 == ((TabControl)this).get_SelectedIndex())
						{
							val3.set_SmoothingMode((SmoothingMode)4);
							Point point = new Point(((TabControl)this).get_ItemSize().Height - 12, tabRect.Location.Y + 20);
							Point point2 = new Point(((TabControl)this).get_ItemSize().Height + 2, tabRect.Location.Y + 10);
							Point point3 = new Point(((TabControl)this).get_ItemSize().Height + 2, tabRect.Location.Y + 30);
							val3.FillPolygon(Brushes.get_White(), new Point[3] { point, point2, point3 });
						}
						else if ((State.Hover && tabRect.Contains(State.Coordinates)) ? true : false)
						{
							((Control)this).set_Cursor(Cursors.get_Default());
							SolidBrush br3 = HelperMethods.SolidBrushHTMlColor("000033");
							rect = new Rectangle(tabRect.X, tabRect.Y, tabRect.Width - 3, tabRect.Height);
							HelperMethods.FillRect(val2, (Brush)(object)br3, rect);
						}
						val3.DrawString(((TabControl)this).get_TabPages().get_Item(num2).get_Text(), new Font("Segoe UI", 8.2f, (FontStyle)1), Brushes.get_AliceBlue(), (float)(tabRect.X + 28), (float)(tabRect.Y + 13));
						if (((TabControl)this).get_ImageList() != null)
						{
							Graphics obj = val3;
							Image obj2 = ((TabControl)this).get_ImageList().get_Images().get_Item(num2);
							rect = new Rectangle(tabRect.X + 6, tabRect.Y + 11, 16, 16);
							obj.DrawImage(obj2, rect);
						}
						Graphics obj3 = val3;
						Pen obj4 = HelperMethods.PenHTMlColor("f2f2f2", 1f);
						Point point4 = new Point(tabRect.X - 1, tabRect.Bottom - 2);
						Point point5 = point4;
						Point point6 = new Point(tabRect.Width - 2, tabRect.Bottom - 2);
						obj3.DrawLine(obj4, point5, point6);
						num2++;
					}
					Graphics obj5 = val3;
					Brush white = Brushes.get_White();
					rect = new Rectangle(150, 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 2);
					obj5.FillRectangle(white, rect);
					Graphics obj6 = val3;
					Pen obj7 = HelperMethods.PenHTMlColor("f3edf8", 1f);
					rect = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					obj6.DrawRectangle(obj7, rect);
					val3 = null;
					e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
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
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		State.Hover = true;
		((Control)this).OnMouseHover(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		State.Hover = false;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TabPage val = (TabPage)enumerator.Current;
				if (((ScrollableControl)val).get_DisplayRectangle().Contains(State.Coordinates))
				{
					((Control)this).Invalidate();
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)this).OnMouseHover(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		State.Coordinates = e.get_Location();
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TabPage val = (TabPage)enumerator.Current;
				if (((ScrollableControl)val).get_DisplayRectangle().Contains(e.get_Location()))
				{
					((Control)this).Invalidate();
					break;
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		((Control)this).OnMouseMove(e);
	}
}
