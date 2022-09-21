using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace MiniGameEngine.General.Threading;

public abstract class ThreadedLoop
{
	private Thread thread_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_0;

	public bool Enabled
	{
		get
		{
			return method_0();
		}
		set
		{
			method_1(value);
			if (method_0())
			{
				thread_0 = new Thread(ThreadLoop);
				thread_0.Start();
			}
		}
	}

	protected ThreadedLoop()
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		method_1(AutoPropertyValue: false);
	}

	[SpecialName]
	[CompilerGenerated]
	private bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(bool AutoPropertyValue)
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

	public void ThreadLoop()
	{
	}

	public abstract void Update();
}
