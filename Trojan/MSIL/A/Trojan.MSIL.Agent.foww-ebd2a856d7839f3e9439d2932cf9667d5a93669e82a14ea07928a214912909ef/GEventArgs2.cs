using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GEventArgs2 : MouseEventArgs
{
	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private int int_0;

	public bool Handled
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	public bool WheelScrolled => ((MouseEventArgs)this).get_Delta() != 0;

	public bool Clicked => ((MouseEventArgs)this).get_Clicks() > 0;

	public bool IsMouseKeyDown
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		private set
		{
			bool_1 = value;
		}
	}

	public bool IsMouseKeyUp
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		private set
		{
			bool_2 = value;
		}
	}

	public int Timestamp
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	internal Struct4 Point => new Struct4(((MouseEventArgs)this).get_X(), ((MouseEventArgs)this).get_Y());

	internal GEventArgs2(MouseButtons buttons, int clicks, Struct4 point, int delta, int timestamp, bool isMouseKeyDown, bool isMouseKeyUp)
		: base(buttons, clicks, point.int_0, point.int_1, delta)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		IsMouseKeyDown = isMouseKeyDown;
		IsMouseKeyUp = isMouseKeyUp;
		Timestamp = timestamp;
	}

	internal static GEventArgs2 smethod_0(Struct1 data)
	{
		return smethod_2(data.WParam, ((Struct0)Marshal.PtrToStructure(data.LParam, typeof(Struct0))).method_0());
	}

	internal static GEventArgs2 smethod_1(Struct1 data)
	{
		IntPtr wParam = data.WParam;
		Struct3 mouseInfo = (Struct3)Marshal.PtrToStructure(data.LParam, typeof(Struct3));
		return smethod_2(wParam, mouseInfo);
	}

	private static GEventArgs2 smethod_2(IntPtr wParam, Struct3 mouseInfo)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		MouseButtons buttons = (MouseButtons)0;
		short delta = 0;
		int clicks = 0;
		bool isMouseKeyDown = false;
		bool isMouseKeyUp = false;
		long num = (long)wParam;
		long num2 = num - 513L;
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
				delta = mouseInfo.short_0;
				break;
			case 10L:
				buttons = (MouseButtons)((mouseInfo.short_0 == 1) ? 8388608 : 16777216);
				isMouseKeyDown = true;
				clicks = 1;
				break;
			case 11L:
				buttons = (MouseButtons)((mouseInfo.short_0 == 1) ? 8388608 : 16777216);
				isMouseKeyUp = true;
				clicks = 1;
				break;
			case 12L:
				isMouseKeyDown = true;
				buttons = (MouseButtons)((mouseInfo.short_0 == 1) ? 8388608 : 16777216);
				clicks = 2;
				break;
			case 13L:
				delta = mouseInfo.short_0;
				break;
			}
		}
		return new GEventArgs2(buttons, clicks, mouseInfo.struct4_0, delta, mouseInfo.int_0, isMouseKeyDown, isMouseKeyUp);
	}

	internal GEventArgs2 method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return new GEventArgs2(((MouseEventArgs)this).get_Button(), 2, Point, ((MouseEventArgs)this).get_Delta(), Timestamp, IsMouseKeyDown, IsMouseKeyUp);
	}
}
