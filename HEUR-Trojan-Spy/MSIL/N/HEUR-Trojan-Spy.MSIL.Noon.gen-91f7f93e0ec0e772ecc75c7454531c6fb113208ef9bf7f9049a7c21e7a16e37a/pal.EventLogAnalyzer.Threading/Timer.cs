using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace pal.EventLogAnalyzer.Threading;

public class Timer : IDisposable
{
	private bool _exec = false;

	private System.Timers.Timer _timer;

	private List<Thread> threadsTicks;

	public double Intervall
	{
		get
		{
			return _timer.Interval;
		}
		set
		{
			_timer.Interval = value;
		}
	}

	public bool AsyncCalls
	{
		get
		{
			return _timer.AutoReset;
		}
		set
		{
			_timer.AutoReset = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return _timer.Enabled;
		}
		set
		{
			_timer.Enabled = (_exec = value);
		}
	}

	public string Name { get; set; }

	public event Action Tick;

	public Timer(double interval, Action tick, string name = null, bool asyncCalls = false)
	{
		Tick += tick;
		_timer = new System.Timers.Timer(interval)
		{
			Interval = interval,
			AutoReset = asyncCalls
		};
		Name = name ?? typeof(Timer).FullName;
		_timer.Elapsed += delegate
		{
			work();
		};
		threadsTicks = new List<Thread>(20);
	}

	public void Dispose()
	{
		Stop(abortThreads: true);
		_timer.Dispose();
		this.Tick = null;
		threadsTicks.Clear();
	}

	public void Start()
	{
		if (!_exec)
		{
			lock (_timer)
			{
				Enabled = true;
			}
		}
	}

	public void Stop(bool abortThreads = false)
	{
		if (!_exec)
		{
			return;
		}
		lock (_timer)
		{
			Enabled = false;
		}
		if (!abortThreads)
		{
			return;
		}
		lock (threadsTicks)
		{
			foreach (Thread threadsTick in threadsTicks)
			{
				threadsTick.Abort();
			}
			threadsTicks.Clear();
		}
	}

	private void work()
	{
		Thread currentThread = Thread.CurrentThread;
		currentThread.Name = Name;
		threadsTicks.Add(currentThread);
		this.Tick?.Invoke();
		threadsTicks.Remove(currentThread);
		if (!AsyncCalls && _exec)
		{
			Enabled = true;
		}
	}
}
