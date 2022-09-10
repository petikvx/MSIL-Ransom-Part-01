using System;
using System.Runtime.InteropServices;

public class GClass5 : IDisposable
{
	public delegate void GDelegate3(IntPtr r1, bool r2);

	private bool bool_0;

	private IntPtr intptr_0;

	private GDelegate3 gdelegate3_0;

	public bool Boolean_0
	{
		get
		{
			if (1 == 0)
			{
			}
			return bool_0;
		}
	}

	[DllImport("kernel32.dll")]
	private static extern bool CreateTimerQueueTimer(ref IntPtr handle, IntPtr queue, GDelegate3 callback, IntPtr state, uint dueTime, uint period, uint flags);

	[DllImport("kernel32.dll")]
	private static extern bool DeleteTimerQueueTimer(IntPtr queue, IntPtr handle, IntPtr callback);

	public void method_0(uint uint_0, uint uint_1, GDelegate3 gdelegate3_1)
	{
		bool flag = !bool_0;
		int num = 0;
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			case 3:
				if (!flag)
				{
					method_2("CreateTimerQueueTimer");
					num = 4;
					break;
				}
				goto default;
			case 2:
				flag = flag2;
				num = 3;
				break;
			case 1:
				flag2 = CreateTimerQueueTimer(ref intptr_0, IntPtr.Zero, gdelegate3_0, IntPtr.Zero, uint_0, uint_1, 0u);
				num = 2;
				break;
			case 0:
				if (flag)
				{
					gdelegate3_0 = gdelegate3_1;
					num = 1;
					break;
				}
				return;
			default:
				bool_0 = flag2;
				return;
			}
		}
	}

	public void method_1()
	{
		bool flag = bool_0;
		int num = 0;
		bool flag2 = default(bool);
		while (true)
		{
			switch (num)
			{
			case 2:
				if (!flag)
				{
					method_2("DeleteTimerQueueTimer");
					num = 3;
					break;
				}
				goto default;
			case 1:
				flag = flag2 || Marshal.GetLastWin32Error() == 997;
				num = 2;
				break;
			case 0:
				if (flag)
				{
					flag2 = DeleteTimerQueueTimer(IntPtr.Zero, intptr_0, IntPtr.Zero);
					num = 1;
					break;
				}
				return;
			default:
				bool_0 = !flag2;
				return;
			}
		}
	}

	private void method_2(string string_0)
	{
		if (1 == 0)
		{
		}
		throw new Exception($"{string_0} failed. Win32Error: {Marshal.GetLastWin32Error()}");
	}

	public void Dispose()
	{
		method_1();
	}
}
