using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace NoobCrypt2._0;

[DefaultEvent("ValueChanged")]
internal class NSRandomPool : Control
{
	public delegate void ValueChangedEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private ValueChangedEventHandler ValueChangedEvent;

	private StringBuilder _Value;

	private string _FullValue;

	private Random RNG;

	private int ItemSize;

	private int DrawSize;

	private Rectangle WA;

	private int RowSize;

	private int ColumnSize;

	private byte[] Table;

	private int Index1;

	private int Index2;

	private bool InvertColors;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private Pen P1;

	private Pen P2;

	private SolidBrush B1;

	private SolidBrush B2;

	private PathGradientBrush PB1;

	public string Value => _Value.ToString();

	public string FullValue => BitConverter.ToString(Table).Replace("-", "");

	public event ValueChangedEventHandler ValueChanged
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ValueChangedEvent = (ValueChangedEventHandler)Delegate.Combine(ValueChangedEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ValueChangedEvent = (ValueChangedEventHandler)Delegate.Remove(ValueChangedEvent, value);
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

	public NSRandomPool()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		__ENCAddToList(this);
		_Value = new StringBuilder();
		RNG = new Random();
		ItemSize = 9;
		DrawSize = 8;
		Index1 = -1;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		P1 = new Pen(Color.FromArgb(55, 55, 55));
		P2 = new Pen(Color.FromArgb(35, 35, 35));
		B1 = new SolidBrush(Color.FromArgb(30, 30, 30));
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		UpdateTable();
		((Control)this).OnHandleCreated(e);
	}

	private void UpdateTable()
	{
		ref Rectangle wA = ref WA;
		wA = checked(new Rectangle(5, 5, ((Control)this).get_Width() - 10, ((Control)this).get_Height() - 10));
		RowSize = WA.Width / ItemSize;
		ColumnSize = WA.Height / ItemSize;
		checked
		{
			WA.Width = RowSize * ItemSize;
			WA.Height = ColumnSize * ItemSize;
			WA.X = unchecked(((Control)this).get_Width() / 2) - unchecked(WA.Width / 2);
			WA.Y = unchecked(((Control)this).get_Height() / 2) - unchecked(WA.Height / 2);
			Table = new byte[RowSize * ColumnSize - 1 + 1];
			int num = Table.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				Table[num2] = (byte)RNG.Next(100);
				num2++;
			}
			((Control)this).Invalidate();
		}
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		UpdateTable();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		HandleDraw(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		HandleDraw(e);
		((Control)this).OnMouseDown(e);
	}

	private void HandleDraw(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Invalid comparison between Unknown and I4
		if (((int)e.get_Button() != 1048576 && (int)e.get_Button() != 2097152) || 1 == 0 || !WA.Contains(e.get_Location()))
		{
			return;
		}
		InvertColors = (int)e.get_Button() == 2097152;
		Index1 = GetIndex(e.get_X(), e.get_Y());
		if (Index1 != Index2)
		{
			bool flag = Index1 % RowSize != 0;
			bool flag2 = Index1 % RowSize != checked(RowSize - 1);
			checked
			{
				Randomize(Index1 - RowSize);
				if (flag)
				{
					Randomize(Index1 - 1);
				}
				Randomize(Index1);
				if (flag2)
				{
					Randomize(Index1 + 1);
				}
				Randomize(Index1 + RowSize);
				_Value.Append(Table[Index1].ToString("X"));
				if (_Value.Length > 32)
				{
					_Value.Remove(0, 2);
				}
				ValueChangedEvent?.Invoke(this);
				Index2 = Index1;
				((Control)this).Invalidate();
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			PB1 = new PathGradientBrush(GP1);
			PB1.set_CenterColor(Color.FromArgb(50, 50, 50));
			PB1.set_SurroundColors(new Color[1] { Color.FromArgb(45, 45, 45) });
			PathGradientBrush pB = PB1;
			PointF focusScales = new PointF(0.9f, 0.5f);
			pB.set_FocusScales(focusScales);
			ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
			ThemeModule.G.DrawPath(P1, GP1);
			ThemeModule.G.DrawPath(P2, GP2);
			ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
			int num = Table.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 <= num4)
				{
					int num5 = Math.Max(unchecked((int)Table[num2]), 75);
					int num6 = unchecked(num2 % RowSize) * ItemSize + WA.X;
					int num7 = unchecked(num2 / RowSize) * ItemSize + WA.Y;
					B2 = new SolidBrush(Color.FromArgb(num5, num5, num5));
					ThemeModule.G.FillRectangle((Brush)(object)B1, num6 + 1, num7 + 1, DrawSize, DrawSize);
					ThemeModule.G.FillRectangle((Brush)(object)B2, num6, num7, DrawSize, DrawSize);
					((Brush)B2).Dispose();
					num2++;
					continue;
				}
				break;
			}
		}
	}

	private int GetIndex(int x, int y)
	{
		checked
		{
			return unchecked(checked(y - WA.Y) / ItemSize) * RowSize + unchecked(checked(x - WA.X) / ItemSize);
		}
	}

	private void Randomize(int index)
	{
		checked
		{
			if ((index > -1 && index < Table.Length) ? true : false)
			{
				if (InvertColors)
				{
					Table[index] = (byte)RNG.Next(100);
				}
				else
				{
					Table[index] = (byte)RNG.Next(100, 256);
				}
			}
		}
	}
}
