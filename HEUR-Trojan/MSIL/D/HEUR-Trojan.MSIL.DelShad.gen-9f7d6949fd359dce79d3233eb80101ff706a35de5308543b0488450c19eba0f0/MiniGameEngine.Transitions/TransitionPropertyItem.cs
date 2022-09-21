using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.Transitions;

public class TransitionPropertyItem
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private TransitionProperty transitionProperty_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Transition transition_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private bool bool_1;

	public TransitionProperty TransitionProperty
	{
		[CompilerGenerated]
		get
		{
			return transitionProperty_0;
		}
		[CompilerGenerated]
		set
		{
			transitionProperty_0 = value;
		}
	}

	public Transition Transition
	{
		[CompilerGenerated]
		get
		{
			return transition_0;
		}
		[CompilerGenerated]
		set
		{
			transition_0 = value;
		}
	}

	public bool AutomaticallyRemoveTransition
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

	public bool AutomaticallyRemoveObject
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public TransitionPropertyItem(TransitionProperty TransitionProperty, Transition Transition, bool AutomaticallyRemoveTransition = false, bool AutomaticallyRemoveObject = false)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		this.TransitionProperty = TransitionProperty;
		this.Transition = Transition;
		this.AutomaticallyRemoveTransition = AutomaticallyRemoveTransition;
		this.AutomaticallyRemoveObject = AutomaticallyRemoveObject;
	}
}
