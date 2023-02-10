using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.MouseKeyHook;

public class MouseEventExtArgs : MouseEventArgs
{
	public bool Handled { get; set; }

	public bool WheelScrolled => ((MouseEventArgs)this).get_Delta() != 0;

	public bool Clicked => ((MouseEventArgs)this).get_Clicks() > 0;

	public bool IsMouseKeyDown { get; private set; }

	public bool IsMouseKeyUp { get; private set; }

	public int Timestamp { get; private set; }

	internal Point Point => new Point(((MouseEventArgs)this).get_X(), ((MouseEventArgs)this).get_Y());

	internal MouseEventExtArgs(MouseButtons buttons, int clicks, Point point, int delta, int timestamp, bool isMouseKeyDown, bool isMouseKeyUp)
		: base(buttons, clicks, point.X, point.Y, delta)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		IsMouseKeyDown = isMouseKeyDown;
		IsMouseKeyUp = isMouseKeyUp;
		Timestamp = timestamp;
	}

	internal static MouseEventExtArgs FromRawDataApp(CallbackData data)
	{
		return FromRawDataUniversal(data.WParam, ((AppMouseStruct)Marshal.PtrToStructure(data.LParam, typeof(AppMouseStruct))).ToMouseStruct());
	}

	internal static MouseEventExtArgs FromRawDataGlobal(CallbackData data)
	{
		IntPtr wParam = data.WParam;
		MouseStruct mouseInfo = (MouseStruct)Marshal.PtrToStructure(data.LParam, typeof(MouseStruct));
		return FromRawDataUniversal(wParam, mouseInfo);
	}

	private static MouseEventExtArgs FromRawDataUniversal(IntPtr wParam, MouseStruct mouseInfo)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		MouseButtons buttons = (MouseButtons)0;
		short delta = 0;
		int clicks = 0;
		bool isMouseKeyDown = false;
		bool isMouseKeyUp = false;
		long num = (long)wParam;
		long num2 = num - 513;
		if ((ulong)num2 <= 13uL)
		{
			switch (num2)
			{
			case 0L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)1048576;
				clicks = 1;
				break;
			case 1L:
				isMouseKeyUp = true;
				buttons = (MouseButtons)1048576;
				clicks = 1;
				break;
			case 2L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)1048576;
				clicks = 2;
				break;
			case 3L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)2097152;
				clicks = 1;
				break;
			case 4L:
				isMouseKeyUp = true;
				buttons = (MouseButtons)2097152;
				clicks = 1;
				break;
			case 5L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)2097152;
				clicks = 2;
				break;
			case 6L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)4194304;
				clicks = 1;
				break;
			case 7L:
				isMouseKeyUp = true;
				buttons = (MouseButtons)4194304;
				clicks = 1;
				break;
			case 8L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)4194304;
				clicks = 2;
				break;
			case 9L:
				delta = mouseInfo.MouseData;
				break;
			case 10L:
				buttons = (MouseButtons)((mouseInfo.MouseData == 1) ? 8388608 : 16777216);
				isMouseKeyDown = true;
				clicks = 1;
				break;
			case 11L:
				buttons = (MouseButtons)((mouseInfo.MouseData == 1) ? 8388608 : 16777216);
				isMouseKeyUp = true;
				clicks = 1;
				break;
			case 12L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)((mouseInfo.MouseData == 1) ? 8388608 : 16777216);
				clicks = 2;
				break;
			case 13L:
				delta = mouseInfo.MouseData;
				break;
			}
		}
		return new MouseEventExtArgs(buttons, clicks, mouseInfo.Point, delta, mouseInfo.Timestamp, isMouseKeyDown, isMouseKeyUp);
	}

	internal MouseEventExtArgs ToDoubleClickEventArgs()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new MouseEventExtArgs(((MouseEventArgs)this).get_Button(), 2, Point, ((MouseEventArgs)this).get_Delta(), Timestamp, IsMouseKeyDown, IsMouseKeyUp);
	}
}
