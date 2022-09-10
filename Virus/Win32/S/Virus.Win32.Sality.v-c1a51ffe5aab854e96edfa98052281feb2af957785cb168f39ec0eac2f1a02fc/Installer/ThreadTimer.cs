using System;
using System.ComponentModel;
using System.Threading;

namespace Installer;

[Serializable]
public sealed class ThreadTimer : Component
{
	public delegate void GDelegate0();

	private Timer timer;

	private long timerInterval;

	private TimerState timerState;

	private GDelegate0 Execute;

	public ThreadTimer()
	{
		timerInterval = 100L;
		timerState = TimerState.Stopped;
		timer = new Timer(method_6, null, -1L, timerInterval);
	}

	public ThreadTimer(long long_0, int int_0)
	{
		timerInterval = long_0;
		timerState = ((int_0 != -1) ? TimerState.Running : TimerState.Stopped);
		timer = new Timer(method_6, null, int_0, long_0);
	}

	public ThreadTimer(long long_0, bool bool_0)
	{
		timerInterval = long_0;
		timerState = (bool_0 ? TimerState.Running : TimerState.Stopped);
		timer = new Timer(method_6, null, 0L, long_0);
	}

	public void method_0(GDelegate0 gdelegate0_0)
	{
		GDelegate0 gDelegate = Execute;
		GDelegate0 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate0 value = (GDelegate0)Delegate.Combine(gDelegate2, gdelegate0_0);
			gDelegate = Interlocked.CompareExchange(ref Execute, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public void method_1(GDelegate0 gdelegate0_0)
	{
		GDelegate0 gDelegate = Execute;
		GDelegate0 gDelegate2;
		do
		{
			gDelegate2 = gDelegate;
			GDelegate0 value = (GDelegate0)Delegate.Remove(gDelegate2, gdelegate0_0);
			gDelegate = Interlocked.CompareExchange(ref Execute, value, gDelegate2);
		}
		while ((object)gDelegate != gDelegate2);
	}

	public void method_2(int int_0)
	{
		timerState = TimerState.Running;
		timer.Change(int_0, timerInterval);
	}

	public void method_3()
	{
		timerState = TimerState.Running;
		timer.Change(0L, timerInterval);
	}

	public void method_4()
	{
		timerState = TimerState.Paused;
		timer.Change(-1L, timerInterval);
	}

	public void method_5()
	{
		timerState = TimerState.Stopped;
		timer.Change(-1L, timerInterval);
	}

	public void method_6(object object_0)
	{
		if (timerState == TimerState.Running && Execute != null)
		{
			lock (this)
			{
				Execute();
			}
		}
	}

	public TimerState method_7()
	{
		return timerState;
	}

	public long method_8()
	{
		return timerInterval;
	}

	public void method_9(long long_0)
	{
		timer.Change((timerState == TimerState.Running) ? long_0 : (-1L), long_0);
	}
}
