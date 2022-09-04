using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace VI_Theme_Dll_By_xVenoxi;

public class PrecisionTimer : IDisposable
{
	public delegate void TimerDelegate(IntPtr r1, bool r2);

	private bool _Enabled;

	private IntPtr Handle;

	private TimerDelegate TimerCallback;

	public bool Enabled => _Enabled;

	[DebuggerNonUserCode]
	public PrecisionTimer()
	{
	}

	[DllImport("kernel32.dll")]
	private static extern bool CreateTimerQueueTimer(ref IntPtr handle, IntPtr queue, TimerDelegate callback, IntPtr state, uint dueTime, uint period, uint flags);

	[DllImport("kernel32.dll")]
	private static extern bool DeleteTimerQueueTimer(IntPtr queue, IntPtr handle, IntPtr callback);

	public void Create(uint dueTime, uint period, TimerDelegate callback)
	{
		if (!_Enabled)
		{
			TimerCallback = callback;
			bool enabled;
			if (!(enabled = CreateTimerQueueTimer(ref Handle, IntPtr.Zero, TimerCallback, IntPtr.Zero, dueTime, period, 0u)))
			{
				ThrowNewException("CreateTimerQueueTimer");
			}
			_Enabled = enabled;
		}
	}

	public void Delete()
	{
		if (_Enabled)
		{
			bool flag;
			if ((!(flag = DeleteTimerQueueTimer(IntPtr.Zero, Handle, IntPtr.Zero)) && Marshal.GetLastWin32Error() != 997) ? true : false)
			{
				ThrowNewException("DeleteTimerQueueTimer");
			}
			_Enabled = !flag;
		}
	}

	private void ThrowNewException(string name)
	{
		throw new Exception($"{name} failed. Win32Error: {Marshal.GetLastWin32Error()}");
	}

	public void Dispose()
	{
		Delete();
	}
}
