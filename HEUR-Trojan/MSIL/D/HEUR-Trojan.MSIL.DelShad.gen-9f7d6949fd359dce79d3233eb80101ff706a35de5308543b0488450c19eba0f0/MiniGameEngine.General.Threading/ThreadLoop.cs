using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MiniGameEngine.General.Threading;

public class ThreadLoop
{
	public delegate void Work();

	private Thread thread_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Work work_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	public bool Enabled
	{
		get
		{
			return method_2();
		}
		set
		{
			method_3(value);
			if (method_2())
			{
				thread_0 = new Thread(ThreadLoop);
				thread_0.Start();
			}
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private Work method_0()
	{
		return work_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(Work AutoPropertyValue)
	{
		work_0 = AutoPropertyValue;
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_2()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_3(bool AutoPropertyValue)
	{
		bool_0 = AutoPropertyValue;
	}

	public void Start()
	{
		Enabled = true;
	}

	public void Stop()
	{
		Enabled = false;
	}

	public ThreadLoop(Work Routine)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		method_3(AutoPropertyValue: false);
		method_1(Routine);
	}

	public void ThreadLoop()
	{
	}
}
