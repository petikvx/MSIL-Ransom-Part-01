using System.Drawing;
using System.Runtime.CompilerServices;

namespace MiniGameEngine.Transitions;

public class RandomColorTransition : ColorTransition
{
	public RandomColorTransition()
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Color.Red, Color.Blue);
		base.OnRepeat += RandomColorTransition_OnRepeat;
		base.OnReverse += RandomColorTransition_OnReverse;
	}

	private void RandomColorTransition_OnRepeat(object object_3)
	{
		base.A = RuntimeHelpers.GetObjectValue(base.B);
		base.B = Color.AliceBlue;
	}

	private void RandomColorTransition_OnReverse(TransitionDirection transitionDirection_1, TransitionDirection transitionDirection_2)
	{
		if (base.Direction == TransitionDirection.Forward)
		{
			base.A = Color.AliceBlue;
		}
		else
		{
			base.B = Color.AliceBlue;
		}
	}
}
