using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.Transitions;

public class TransitionWorkElement
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double[] double_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private double[] double_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private double[] double_2;

	public double[] StartPosition
	{
		[CompilerGenerated]
		get
		{
			return double_0;
		}
		[CompilerGenerated]
		set
		{
			double_0 = value;
		}
	}

	public double[] Work
	{
		[CompilerGenerated]
		get
		{
			return double_1;
		}
		[CompilerGenerated]
		set
		{
			double_1 = value;
		}
	}

	public double[] Destination
	{
		[CompilerGenerated]
		get
		{
			return double_2;
		}
		[CompilerGenerated]
		set
		{
			double_2 = value;
		}
	}

	public TransitionWorkElement(double[] StartPosition, double[] Work)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector();
		this.StartPosition = StartPosition;
		this.Work = Work;
	}
}
