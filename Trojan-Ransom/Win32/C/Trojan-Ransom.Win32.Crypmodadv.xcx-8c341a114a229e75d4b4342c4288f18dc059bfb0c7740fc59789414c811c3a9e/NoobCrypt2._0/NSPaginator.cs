using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NoobCrypt2._0;

[DefaultEvent("SelectedIndexChanged")]
internal class NSPaginator : Control
{
	public delegate void SelectedIndexChangedEventHandler(object sender, EventArgs e);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private SelectedIndexChangedEventHandler SelectedIndexChangedEvent;

	private Bitmap TextBitmap;

	private Graphics TextGraphics;

	private int _SelectedIndex;

	private int _NumberOfPages;

	private int ItemWidth;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private Rectangle R1;

	private Size SZ1;

	private Point PT1;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private SolidBrush B1;

	private SolidBrush B2;

	public int SelectedIndex
	{
		get
		{
			return _SelectedIndex;
		}
		set
		{
			_SelectedIndex = Math.Max(Math.Min(value, MaximumIndex), 0);
			((Control)this).Invalidate();
		}
	}

	public int NumberOfPages
	{
		get
		{
			return _NumberOfPages;
		}
		set
		{
			_NumberOfPages = value;
			_SelectedIndex = Math.Max(Math.Min(_SelectedIndex, MaximumIndex), 0);
			((Control)this).Invalidate();
		}
	}

	public int MaximumIndex => checked(NumberOfPages - 1);

	public override Font Font
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
			InvalidateItems();
			((Control)this).Invalidate();
		}
	}

	public event SelectedIndexChangedEventHandler SelectedIndexChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			SelectedIndexChangedEvent = (SelectedIndexChangedEventHandler)Delegate.Combine(SelectedIndexChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			SelectedIndexChangedEvent = (SelectedIndexChangedEventHandler)Delegate.Remove(SelectedIndexChangedEvent, value);
		}
	}

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

	public NSPaginator()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		__ENCAddToList(this);
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		Size size = new Size(202, 26);
		((Control)this).set_Size(size);
		TextBitmap = new Bitmap(1, 1);
		TextGraphics = Graphics.FromImage((Image)(object)TextBitmap);
		InvalidateItems();
		B1 = new SolidBrush(Color.FromArgb(50, 50, 50));
		B2 = new SolidBrush(Color.FromArgb(55, 55, 55));
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(55, 55, 55));
		P3 = new Pen(Color.FromArgb(65, 65, 65));
	}

	private void InvalidateItems()
	{
		ItemWidth = checked(TextGraphics.MeasureString("000 ..", Font).ToSize().Width + 10);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			if (_SelectedIndex < 4)
			{
				int num = Math.Min(MaximumIndex, 4);
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 <= num4)
					{
						bool rightEllipse = ((num2 == 4 && MaximumIndex > 4) ? true : false);
						DrawBox(num2 * ItemWidth, num2, leftEllipse: false, rightEllipse);
						num2++;
						continue;
					}
					break;
				}
			}
			else if ((_SelectedIndex > 3 && _SelectedIndex < MaximumIndex - 3) ? true : false)
			{
				int num5 = 0;
				int num6;
				do
				{
					bool leftEllipse = num5 == 0;
					bool rightEllipse = num5 == 4;
					DrawBox(num5 * ItemWidth, _SelectedIndex + num5 - 2, leftEllipse, rightEllipse);
					num5++;
					num6 = num5;
					int num4 = 4;
				}
				while (num6 <= 4);
			}
			else
			{
				int num7 = 0;
				int num8;
				do
				{
					bool leftEllipse = ((num7 == 0 && MaximumIndex > 4) ? true : false);
					DrawBox(num7 * ItemWidth, MaximumIndex - (4 - num7), leftEllipse, rightEllipse: false);
					num7++;
					num8 = num7;
					int num4 = 4;
				}
				while (num8 <= 4);
			}
		}
	}

	private void DrawBox(int x, int index, bool leftEllipse, bool rightEllipse)
	{
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		ref Rectangle r = ref R1;
		checked
		{
			r = new Rectangle(x, 0, ItemWidth - 4, ((Control)this).get_Height() - 1);
			GP1 = ThemeModule.CreateRound(R1, 7);
			GP2 = ThemeModule.CreateRound(R1.X + 1, R1.Y + 1, R1.Width - 2, R1.Height - 2, 7);
			string text = Conversions.ToString(index + 1);
			if (leftEllipse)
			{
				text = ".. " + text;
			}
			if (rightEllipse)
			{
				text += " ..";
			}
			SZ1 = ThemeModule.G.MeasureString(text, Font).ToSize();
			ref Point pT = ref PT1;
			pT = new Point(R1.X + (unchecked(R1.Width / 2) - unchecked(SZ1.Width / 2)), R1.Y + (unchecked(R1.Height / 2) - unchecked(SZ1.Height / 2)));
			if (index == _SelectedIndex)
			{
				ThemeModule.G.FillPath((Brush)(object)B1, GP1);
				Font val = new Font(Font, (FontStyle)4);
				ThemeModule.G.DrawString(text, val, Brushes.get_Black(), (float)(PT1.X + 1), (float)(PT1.Y + 1));
				ThemeModule.G.DrawString(text, val, Brushes.get_White(), (PointF)PT1);
				val.Dispose();
				ThemeModule.G.DrawPath(P1, GP2);
				ThemeModule.G.DrawPath(P2, GP1);
			}
			else
			{
				ThemeModule.G.FillPath((Brush)(object)B2, GP1);
				ThemeModule.G.DrawString(text, Font, Brushes.get_Black(), (float)(PT1.X + 1), (float)(PT1.Y + 1));
				ThemeModule.G.DrawString(text, Font, Brushes.get_White(), (PointF)PT1);
				ThemeModule.G.DrawPath(P3, GP2);
				ThemeModule.G.DrawPath(P1, GP1);
			}
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			int selectedIndex = _SelectedIndex;
			checked
			{
				int num;
				if (_SelectedIndex < 4)
				{
					num = unchecked(e.get_X() / ItemWidth);
				}
				else if ((_SelectedIndex > 3 && _SelectedIndex < MaximumIndex - 3) ? true : false)
				{
					num = unchecked(e.get_X() / ItemWidth);
					int num2 = num;
					if (num2 == 2)
					{
						num = selectedIndex;
					}
					else if (num2 < 2)
					{
						num = selectedIndex - (2 - num);
					}
					else if (num2 > 2)
					{
						num = selectedIndex + (num - 2);
					}
				}
				else
				{
					num = MaximumIndex - (4 - unchecked(e.get_X() / ItemWidth));
				}
				if ((num < _NumberOfPages && num != selectedIndex) ? true : false)
				{
					SelectedIndex = num;
					SelectedIndexChangedEvent?.Invoke(this, null);
				}
			}
		}
		((Control)this).OnMouseDown(e);
	}
}
