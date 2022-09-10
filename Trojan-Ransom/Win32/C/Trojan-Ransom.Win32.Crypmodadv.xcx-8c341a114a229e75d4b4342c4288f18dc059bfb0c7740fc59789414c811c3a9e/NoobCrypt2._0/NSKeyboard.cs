using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace NoobCrypt2._0;

internal class NSKeyboard : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private Bitmap TextBitmap;

	private Graphics TextGraphics;

	private const string LowerKeys = "1234567890-=qwertyuiop[]asdfghjkl\\;'zxcvbnm,./`";

	private const string UpperKeys = "!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL|:\"ZXCVBNM<>?~";

	private Control _Target;

	private bool Shift;

	private int Pressed;

	private Rectangle[] Buttons;

	private char[] Lower;

	private char[] Upper;

	private string[] Other;

	private PointF[] UpperCache;

	private PointF[] LowerCache;

	private GraphicsPath GP1;

	private SizeF SZ1;

	private PointF PT1;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private SolidBrush B1;

	private PathGradientBrush PB1;

	private LinearGradientBrush GB1;

	public Control Target
	{
		get
		{
			return _Target;
		}
		set
		{
			_Target = value;
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

	public NSKeyboard()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		__ENCAddToList(this);
		Pressed = -1;
		Other = new string[3] { "Shift", "Space", "Back" };
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_Font(new Font("Verdana", 8.25f));
		TextBitmap = new Bitmap(1, 1);
		TextGraphics = Graphics.FromImage((Image)(object)TextBitmap);
		Size minimumSize = new Size(386, 162);
		((Control)this).set_MinimumSize(minimumSize);
		minimumSize = new Size(386, 162);
		((Control)this).set_MaximumSize(minimumSize);
		Lower = "1234567890-=qwertyuiop[]asdfghjkl\\;'zxcvbnm,./`".ToCharArray();
		Upper = "!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL|:\"ZXCVBNM<>?~".ToCharArray();
		PrepareCache();
		P1 = new Pen(Color.FromArgb(45, 45, 45));
		P2 = new Pen(Color.FromArgb(65, 65, 65));
		P3 = new Pen(Color.FromArgb(35, 35, 35));
		B1 = new SolidBrush(Color.FromArgb(100, 100, 100));
	}

	private void PrepareCache()
	{
		Buttons = new Rectangle[51];
		checked
		{
			UpperCache = new PointF[Upper.Length - 1 + 1];
			LowerCache = new PointF[Lower.Length - 1 + 1];
			int num = 0;
			do
			{
				int num2 = 0;
				do
				{
					int num3 = num * 12 + num2;
					Rectangle rectangle = new Rectangle(num2 * 32, num * 32, 32, 32);
					Buttons[num3] = rectangle;
					if ((num3 != 47 && !char.IsLetter(Upper[num3])) ? true : false)
					{
						SizeF sizeF = TextGraphics.MeasureString(Conversions.ToString(Upper[num3]), ((Control)this).get_Font());
						ref PointF reference = ref UpperCache[num3];
						reference = new PointF((float)rectangle.X + ((float)unchecked(rectangle.Width / 2) - sizeF.Width / 2f), (float)(rectangle.Y + rectangle.Height) - sizeF.Height - 2f);
						sizeF = TextGraphics.MeasureString(Conversions.ToString(Lower[num3]), ((Control)this).get_Font());
						ref PointF reference2 = ref LowerCache[num3];
						reference2 = new PointF((float)rectangle.X + ((float)unchecked(rectangle.Width / 2) - sizeF.Width / 2f), (float)(rectangle.Y + rectangle.Height) - sizeF.Height - 2f);
					}
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 3);
			ref Rectangle reference3 = ref Buttons[48];
			reference3 = new Rectangle(0, 128, 64, 32);
			ref Rectangle reference4 = ref Buttons[49];
			reference4 = new Rectangle(Buttons[48].Right, 128, 256, 32);
			ref Rectangle reference5 = ref Buttons[50];
			reference5 = new Rectangle(Buttons[49].Right, 128, 64, 32);
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.set_TextRenderingHint((TextRenderingHint)5);
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.DrawRectangle(P1, 0, 0, 385, 161);
		checked
		{
			int num = Buttons.Length - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				Rectangle rectangle = Buttons[num2];
				int num5 = 0;
				if (num2 == Pressed)
				{
					num5 = 1;
					GP1 = new GraphicsPath();
					GP1.AddRectangle(rectangle);
					PB1 = new PathGradientBrush(GP1);
					PB1.set_CenterColor(Color.FromArgb(60, 60, 60));
					PB1.set_SurroundColors(new Color[1] { Color.FromArgb(55, 55, 55) });
					PathGradientBrush pB = PB1;
					PointF focusScales = new PointF(0.8f, 0.5f);
					pB.set_FocusScales(focusScales);
					ThemeModule.G.FillPath((Brush)(object)PB1, GP1);
				}
				else
				{
					GB1 = new LinearGradientBrush(rectangle, Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
					ThemeModule.G.FillRectangle((Brush)(object)GB1, rectangle);
				}
				switch (num2)
				{
				default:
					if (Shift)
					{
						ThemeModule.G.DrawString(Conversions.ToString(Upper[num2]), ((Control)this).get_Font(), Brushes.get_Black(), (float)(rectangle.X + 3 + num5 + 1), (float)(rectangle.Y + 2 + num5 + 1));
						ThemeModule.G.DrawString(Conversions.ToString(Upper[num2]), ((Control)this).get_Font(), Brushes.get_White(), (float)(rectangle.X + 3 + num5), (float)(rectangle.Y + 2 + num5));
						if (!char.IsLetter(Lower[num2]))
						{
							PT1 = LowerCache[num2];
							ThemeModule.G.DrawString(Conversions.ToString(Lower[num2]), ((Control)this).get_Font(), (Brush)(object)B1, PT1.X + (float)num5, PT1.Y + (float)num5);
						}
					}
					else
					{
						ThemeModule.G.DrawString(Conversions.ToString(Lower[num2]), ((Control)this).get_Font(), Brushes.get_Black(), (float)(rectangle.X + 3 + num5 + 1), (float)(rectangle.Y + 2 + num5 + 1));
						ThemeModule.G.DrawString(Conversions.ToString(Lower[num2]), ((Control)this).get_Font(), Brushes.get_White(), (float)(rectangle.X + 3 + num5), (float)(rectangle.Y + 2 + num5));
						if (!char.IsLetter(Upper[num2]))
						{
							PT1 = UpperCache[num2];
							ThemeModule.G.DrawString(Conversions.ToString(Upper[num2]), ((Control)this).get_Font(), (Brush)(object)B1, PT1.X + (float)num5, PT1.Y + (float)num5);
						}
					}
					break;
				case 47:
					DrawArrow(Color.Black, rectangle.X + num5 + 1, rectangle.Y + num5 + 1);
					DrawArrow(Color.White, rectangle.X + num5, rectangle.Y + num5);
					break;
				case 48:
				case 49:
				case 50:
					SZ1 = ThemeModule.G.MeasureString(Other[num2 - 48], ((Control)this).get_Font());
					unchecked
					{
						ThemeModule.G.DrawString(Other[checked(num2 - 48)], ((Control)this).get_Font(), Brushes.get_Black(), (float)rectangle.X + ((float)(rectangle.Width / 2) - SZ1.Width / 2f) + (float)num5 + 1f, (float)rectangle.Y + ((float)(rectangle.Height / 2) - SZ1.Height / 2f) + (float)num5 + 1f);
						ThemeModule.G.DrawString(Other[checked(num2 - 48)], ((Control)this).get_Font(), Brushes.get_White(), (float)rectangle.X + ((float)(rectangle.Width / 2) - SZ1.Width / 2f) + (float)num5, (float)rectangle.Y + ((float)(rectangle.Height / 2) - SZ1.Height / 2f) + (float)num5);
						break;
					}
				}
				ThemeModule.G.DrawRectangle(P2, rectangle.X + 1 + num5, rectangle.Y + 1 + num5, rectangle.Width - 2, rectangle.Height - 2);
				ThemeModule.G.DrawRectangle(P3, rectangle.X + num5, rectangle.Y + num5, rectangle.Width, rectangle.Height);
				if (num2 == Pressed)
				{
					ThemeModule.G.DrawLine(P1, rectangle.X, rectangle.Y, rectangle.Right, rectangle.Y);
					ThemeModule.G.DrawLine(P1, rectangle.X, rectangle.Y, rectangle.X, rectangle.Bottom);
				}
				num2++;
			}
		}
	}

	private void DrawArrow(Color color, int rx, int ry)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Rectangle rectangle = checked(new Rectangle(rx + 8, ry + 8, 16, 16));
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		Pen val = new Pen(color, 1f);
		AdjustableArrowCap val2 = new AdjustableArrowCap(3f, 2f);
		val.set_CustomEndCap((CustomLineCap)(object)val2);
		ThemeModule.G.DrawArc(val, rectangle, 0f, 290f);
		val.Dispose();
		((CustomLineCap)val2).Dispose();
		ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		checked
		{
			int num = unchecked(e.get_Y() / 32) * 12 + unchecked(e.get_X() / 32);
			if (num > 47)
			{
				int num2 = Buttons.Length - 1;
				int num3 = 48;
				while (true)
				{
					int num4 = num3;
					int num5 = num2;
					if (num4 <= num5)
					{
						if (!Buttons[num3].Contains(e.get_X(), e.get_Y()))
						{
							num3++;
							continue;
						}
						Pressed = num3;
						break;
					}
					break;
				}
			}
			else
			{
				Pressed = num;
			}
			HandleKey();
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		Pressed = -1;
		((Control)this).Invalidate();
	}

	private void HandleKey()
	{
		if (_Target == null || Pressed == -1)
		{
			return;
		}
		switch (Pressed)
		{
		case 47:
			_Target.set_Text(string.Empty);
			return;
		case 48:
			Shift = !Shift;
			return;
		case 49:
		{
			Control target = _Target;
			target.set_Text(target.get_Text() + " ");
			return;
		}
		case 50:
			if (_Target.get_Text().Length != 0)
			{
				_Target.set_Text(_Target.get_Text().Remove(checked(_Target.get_Text().Length - 1)));
			}
			return;
		}
		if (Shift)
		{
			Control target = _Target;
			target.set_Text(target.get_Text() + Conversions.ToString(Upper[Pressed]));
		}
		else
		{
			Control target = _Target;
			target.set_Text(target.get_Text() + Conversions.ToString(Lower[Pressed]));
		}
	}
}
