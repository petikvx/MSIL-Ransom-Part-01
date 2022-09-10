using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSControlButton : Control
{
	public enum Button : byte
	{
		None,
		Minimize,
		MaximizeRestore,
		Close
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Button _ControlButton;

	private GraphicsPath ClosePath;

	public Button ControlButton
	{
		get
		{
			return _ControlButton;
		}
		set
		{
			_ControlButton = value;
			((Control)this).Invalidate();
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

	public NSControlButton()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		__ENCAddToList(this);
		_ControlButton = Button.Close;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_Anchor((AnchorStyles)9);
		((Control)this).set_Width(18);
		((Control)this).set_Height(20);
		((Control)this).set_MinimumSize(((Control)this).get_Size());
		((Control)this).set_MaximumSize(((Control)this).get_Size());
		Padding margin = default(Padding);
		((Padding)(ref margin))._002Ector(0);
		((Control)this).set_Margin(margin);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		switch (_ControlButton)
		{
		case Button.Minimize:
			DrawMinimize(3, 10);
			break;
		case Button.MaximizeRestore:
			if ((int)((Control)this).FindForm().get_WindowState() == 0)
			{
				DrawMaximize(3, 5);
			}
			else
			{
				DrawRestore(3, 4);
			}
			break;
		case Button.Close:
			DrawClose(4, 5);
			break;
		}
	}

	private void DrawMinimize(int x, int y)
	{
		ThemeModule.G.FillRectangle(Brushes.get_White(), x, y, 12, 5);
		ThemeModule.G.DrawRectangle(Pens.get_Black(), x, y, 11, 4);
	}

	private void DrawMaximize(int x, int y)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		checked
		{
			ThemeModule.G.DrawRectangle(new Pen(Color.White, 2f), x + 2, y + 2, 8, 6);
			ThemeModule.G.DrawRectangle(Pens.get_Black(), x, y, 11, 9);
			ThemeModule.G.DrawRectangle(Pens.get_Black(), x + 3, y + 3, 5, 3);
		}
	}

	private void DrawRestore(int x, int y)
	{
		checked
		{
			ThemeModule.G.FillRectangle(Brushes.get_White(), x + 3, y + 1, 8, 4);
			ThemeModule.G.FillRectangle(Brushes.get_White(), x + 7, y + 5, 4, 4);
			ThemeModule.G.DrawRectangle(Pens.get_Black(), x + 2, y + 0, 9, 9);
			ThemeModule.G.FillRectangle(Brushes.get_White(), x + 1, y + 3, 2, 6);
			ThemeModule.G.FillRectangle(Brushes.get_White(), x + 1, y + 9, 8, 2);
			ThemeModule.G.DrawRectangle(Pens.get_Black(), x, y + 2, 9, 9);
			ThemeModule.G.DrawRectangle(Pens.get_Black(), x + 3, y + 5, 3, 3);
		}
	}

	private void DrawClose(int x, int y)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		checked
		{
			if (ClosePath == null)
			{
				ClosePath = new GraphicsPath();
				ClosePath.AddLine(x + 1, y, x + 3, y);
				ClosePath.AddLine(x + 5, y + 2, x + 7, y);
				ClosePath.AddLine(x + 9, y, x + 10, y + 1);
				ClosePath.AddLine(x + 7, y + 4, x + 7, y + 5);
				ClosePath.AddLine(x + 10, y + 8, x + 9, y + 9);
				ClosePath.AddLine(x + 7, y + 9, x + 5, y + 7);
				ClosePath.AddLine(x + 3, y + 9, x + 1, y + 9);
				ClosePath.AddLine(x + 0, y + 8, x + 3, y + 5);
				ClosePath.AddLine(x + 3, y + 4, x + 0, y + 1);
			}
			ThemeModule.G.FillPath(Brushes.get_White(), ClosePath);
			ThemeModule.G.DrawPath(Pens.get_Black(), ClosePath);
		}
	}

	protected override void OnMouseClick(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			Form val = ((Control)this).FindForm();
			switch (_ControlButton)
			{
			case Button.Minimize:
				val.set_WindowState((FormWindowState)1);
				break;
			case Button.MaximizeRestore:
				if ((int)val.get_WindowState() == 0)
				{
					val.set_WindowState((FormWindowState)2);
				}
				else
				{
					val.set_WindowState((FormWindowState)0);
				}
				break;
			case Button.Close:
				val.Close();
				break;
			}
		}
		((Control)this).Invalidate();
		((Control)this).OnMouseClick(e);
	}
}
