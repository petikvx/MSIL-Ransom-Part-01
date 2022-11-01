using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Forms;

namespace com.poweriwb.PowerDesk;

internal class AutoClosingMessageBox
{
	public const int ALERTSEC3100 = 3100;

	public const int ALERTSEC40000 = 40000;

	private const int WM_CLOSE = 16;

	private const int WM_DESTROY = 2;

	private const int WM_QUIT = 18;

	private int TICK200 = 200;

	private bool isClosedByTimer = false;

	private Timer _timeoutTimer;

	private int ini_timeout;

	private int progress_time;

	private string ini_caption;

	private string full_caption;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32")]
	public static extern int SetWindowText(IntPtr hWnd, string lpString);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	private AutoClosingMessageBox(string text, string caption, int timeout, int default_pos, ref MessageBoxResult mr)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected I4, but got Unknown
		DialogResult val = (DialogResult)0;
		ini_caption = caption;
		full_caption = caption;
		ini_timeout = timeout;
		progress_time = 0;
		_timeoutTimer = new Timer(OnTimerElapsed_1sec, null, TICK200, -1);
		switch (default_pos)
		{
		case 0:
			val = MessageBox.Show(text, caption, (MessageBoxButtons)0, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
			if (isClosedByTimer)
			{
				val = (DialogResult)1;
			}
			break;
		case 1:
			val = MessageBox.Show(text, caption, (MessageBoxButtons)3, (MessageBoxIcon)48, (MessageBoxDefaultButton)0);
			if (isClosedByTimer)
			{
				val = (DialogResult)6;
			}
			break;
		case 2:
			val = MessageBox.Show(text, caption, (MessageBoxButtons)3, (MessageBoxIcon)48, (MessageBoxDefaultButton)256);
			if (isClosedByTimer)
			{
				val = (DialogResult)7;
			}
			break;
		case 3:
			val = MessageBox.Show(text, caption, (MessageBoxButtons)3, (MessageBoxIcon)48, (MessageBoxDefaultButton)512);
			if (isClosedByTimer)
			{
				val = (DialogResult)2;
			}
			break;
		}
		DialogResult val2 = val;
		switch (val2 - 6)
		{
		default:
			mr = (MessageBoxResult)2;
			break;
		case 0:
			mr = (MessageBoxResult)6;
			break;
		case 1:
			mr = (MessageBoxResult)7;
			break;
		}
	}

	public static MessageBoxResult Show(string text, string caption, int timeout, int default_pos)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxResult mr = (MessageBoxResult)0;
		new AutoClosingMessageBox(text, caption, timeout, default_pos, ref mr);
		return mr;
	}

	public static MessageBoxResult Show1(string text, string caption, int timeout, int default_pos)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MessageBoxResult mr = (MessageBoxResult)0;
		new AutoClosingMessageBox(text, caption, timeout, 0, ref mr);
		return mr;
	}

	private void OnTimerElapsed_1sec(object state)
	{
		progress_time += TICK200;
		IntPtr intPtr = FindWindow(null, full_caption);
		if (ini_timeout - progress_time <= 0)
		{
			if (intPtr != IntPtr.Zero)
			{
				isClosedByTimer = true;
				PostMessage(intPtr, 16u, IntPtr.Zero, IntPtr.Zero);
				PostMessage(intPtr, 2u, IntPtr.Zero, IntPtr.Zero);
			}
			_timeoutTimer.Dispose();
			return;
		}
		full_caption = ini_caption + " " + $"{(double)(ini_timeout - progress_time) / 1000.0:F0}";
		if (intPtr != IntPtr.Zero)
		{
			SetWindowText(intPtr, full_caption);
		}
		_timeoutTimer.Dispose();
		_timeoutTimer = null;
		_timeoutTimer = new Timer(OnTimerElapsed_1sec, null, TICK200, -1);
	}
}
