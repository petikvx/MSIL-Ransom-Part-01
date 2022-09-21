using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.Transitions;

public class TransitionProperty
{
	public delegate void Worker(ref Transition Transition);

	public readonly string ID;

	private Worker worker_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GameObject gameObject_0;

	public GameObject Reference
	{
		[CompilerGenerated]
		get
		{
			return gameObject_0;
		}
		[CompilerGenerated]
		set
		{
			gameObject_0 = value;
		}
	}

	public TransitionProperty(ref GameObject Reference, Worker Work)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		ID = Guid.NewGuid().ToString();
		this.Reference = Reference;
		worker_0 = Work;
	}

	public void Work(Transition Transition)
	{
		worker_0(ref Transition);
	}
}
