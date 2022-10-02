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

public class EtherealButton : Control
{
	public enum Style : byte
	{
		Clear,
		DarkClear,
		SemiBlack,
		DarkPink,
		LightPink
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private HelperMethods.MouseMode State;

	private Color NoneColor;

	private int _RoundRadius;

	public Style ButtonStyle
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public int RoundRadius
	{
		get
		{
			return _RoundRadius;
		}
		set
		{
			_RoundRadius = value;
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

	public EtherealButton()
	{
		__ENCAddToList(this);
		NoneColor = HelperMethods.GetHTMLColor("222222");
		_RoundRadius = 5;
		((Control)this).SetStyle((ControlStyles)76306, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b9: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected O, but got Unknown
		//IL_0439: Unknown result type (might be due to invalid IL or missing references)
		//IL_0444: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		try
		{
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				Rectangle rectangle = checked(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1));
				Graphics val3 = val2;
				HelperMethods.GP = HelperMethods.RoundRec(rectangle, RoundRadius);
				val3.set_TextRenderingHint((TextRenderingHint)4);
				val3.set_SmoothingMode((SmoothingMode)2);
				switch (State)
				{
				case HelperMethods.MouseMode.NormalMode:
					switch (ButtonStyle)
					{
					case Style.Clear:
						NoneColor = HelperMethods.GetHTMLColor("ececec");
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("b9b9b9"), rectangle);
						break;
					case Style.DarkClear:
						NoneColor = HelperMethods.GetHTMLColor("444444");
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("444444"), rectangle);
						break;
					case Style.SemiBlack:
						NoneColor = HelperMethods.GetHTMLColor("222222");
						HelperMethods.FillRoundedPath(val2, NoneColor, rectangle, RoundRadius);
						HelperMethods.DrawRoundedPath(val2, HelperMethods.GetHTMLColor("121212"), 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), Brushes.get_White(), rectangle);
						break;
					case Style.DarkPink:
						NoneColor = HelperMethods.GetHTMLColor("3b2551");
						HelperMethods.FillRoundedPath(val2, NoneColor, rectangle, RoundRadius);
						HelperMethods.DrawRoundedPath(val2, HelperMethods.GetHTMLColor("6d5980"), 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), Brushes.get_White(), rectangle);
						break;
					case Style.LightPink:
						NoneColor = HelperMethods.GetHTMLColor("9d92a8");
						HelperMethods.FillRoundedPath(val2, NoneColor, rectangle, RoundRadius);
						HelperMethods.DrawRoundedPath(val2, HelperMethods.GetHTMLColor("573d71"), 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), Brushes.get_White(), rectangle);
						break;
					}
					break;
				case HelperMethods.MouseMode.Hovered:
					NoneColor = HelperMethods.GetHTMLColor("444444");
					switch (ButtonStyle)
					{
					case Style.Clear:
						NoneColor = HelperMethods.GetHTMLColor("444444");
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("444444"), rectangle);
						break;
					case Style.DarkClear:
						NoneColor = HelperMethods.GetHTMLColor("ececec");
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("b9b9b9"), rectangle);
						break;
					case Style.SemiBlack:
						NoneColor = HelperMethods.GetHTMLColor("444444");
						val3.FillPath((Brush)new SolidBrush(Color.Transparent), HelperMethods.GP);
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("444444"), rectangle);
						break;
					case Style.DarkPink:
						NoneColor = HelperMethods.GetHTMLColor("444444");
						HelperMethods.FillRect(val2, (Brush)new SolidBrush(Color.Transparent), rectangle);
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("444444"), rectangle);
						break;
					case Style.LightPink:
						NoneColor = HelperMethods.GetHTMLColor("9d92a8");
						HelperMethods.FillRect(val2, (Brush)new SolidBrush(Color.Transparent), rectangle);
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, RoundRadius);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("444444"), rectangle);
						break;
					}
					break;
				case HelperMethods.MouseMode.Pushed:
					switch (ButtonStyle)
					{
					case Style.Clear:
					case Style.DarkClear:
						NoneColor = HelperMethods.GetHTMLColor("444444");
						HelperMethods.FillRect(val2, (Brush)new SolidBrush(Color.Transparent), rectangle);
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, 5);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("444444"), rectangle);
						break;
					case Style.SemiBlack:
					case Style.DarkPink:
					case Style.LightPink:
						NoneColor = HelperMethods.GetHTMLColor("ececec");
						HelperMethods.DrawRoundedPath(val2, NoneColor, 1f, rectangle, 5);
						HelperMethods.CentreString(val2, ((Control)this).get_Text(), new Font("Segoe UI", 9f, (FontStyle)1), (Brush)(object)HelperMethods.SolidBrushHTMlColor("b9b9b9"), rectangle);
						break;
					}
					break;
				}
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
}
