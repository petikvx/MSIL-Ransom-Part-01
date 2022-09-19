using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.V1Interop;
using Microsoft.Win32.TaskScheduler.V2Interop;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public sealed class IdleSettings : IDisposable
{
	private ITask v1Task;

	private IIdleSettings v2Settings;

	[DefaultValue(typeof(TimeSpan), "00:10:00")]
	public TimeSpan IdleDuration
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.IdleDuration);
			}
			v1Task.GetIdleWait(out var _, out var DeadlineMinutes);
			return TimeSpan.FromMinutes((int)DeadlineMinutes);
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.IdleDuration = Task.TimeSpanToString(value);
			}
			else
			{
				v1Task.SetIdleWait((ushort)WaitTimeout.TotalMinutes, (ushort)value.TotalMinutes);
			}
		}
	}

	[DefaultValue(false)]
	public bool RestartOnIdle
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.RestartOnIdle;
			}
			return (v1Task.GetFlags() & TaskFlags.RestartOnIdleResume) == TaskFlags.RestartOnIdleResume;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.RestartOnIdle = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.RestartOnIdleResume);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.RestartOnIdleResume);
			}
		}
	}

	[DefaultValue(true)]
	public bool StopOnIdleEnd
	{
		get
		{
			if (v2Settings != null)
			{
				return v2Settings.StopOnIdleEnd;
			}
			return (v1Task.GetFlags() & TaskFlags.KillOnIdleEnd) == TaskFlags.KillOnIdleEnd;
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.StopOnIdleEnd = value;
				return;
			}
			TaskFlags flags = v1Task.GetFlags();
			if (value)
			{
				v1Task.SetFlags(flags |= TaskFlags.KillOnIdleEnd);
			}
			else
			{
				v1Task.SetFlags(flags &= ~TaskFlags.KillOnIdleEnd);
			}
		}
	}

	[DefaultValue(typeof(TimeSpan), "01:00:00")]
	public TimeSpan WaitTimeout
	{
		get
		{
			if (v2Settings != null)
			{
				return Task.StringToTimeSpan(v2Settings.WaitTimeout);
			}
			v1Task.GetIdleWait(out var IdleMinutes, out var _);
			return TimeSpan.FromMinutes((int)IdleMinutes);
		}
		set
		{
			if (v2Settings != null)
			{
				v2Settings.WaitTimeout = Task.TimeSpanToString(value);
			}
			else
			{
				v1Task.SetIdleWait((ushort)value.TotalMinutes, (ushort)IdleDuration.TotalMinutes);
			}
		}
	}

	internal IdleSettings(IIdleSettings iSettings)
	{
		v2Settings = iSettings;
	}

	internal IdleSettings(ITask iTask)
	{
		v1Task = iTask;
	}

	public void Dispose()
	{
		if (v2Settings != null)
		{
			Marshal.ReleaseComObject(v2Settings);
		}
		v1Task = null;
	}
}
