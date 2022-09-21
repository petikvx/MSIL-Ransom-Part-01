using System;
using System.Threading;
using MiniGameEngine.Examples.Shapes;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.Examples.Droplets;

public class Raindrops : Waterdrops
{
	public Raindrops(Scene Scene)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Scene);
	}

	internal override void vmethod_0(int i, ref Circle currentCircle)
	{
		ColorTransition colorTransition = new ColorTransition(base.dropletColor, base.dropletFadeColor);
		colorTransition.Enabled = true;
		checked
		{
			colorTransition.Duration = TimeSpan.FromTicks(base.MovementDuration.Ticks + TimeSpan.FromMilliseconds(150 * i).Ticks);
			ColorTransition transition = colorTransition;
			DoubleTransition transition2 = new DoubleTransition(0.0, 0.0, base.dropletRadius, TimeSpan.FromTicks(base.MovementDuration.Ticks + TimeSpan.FromMilliseconds(150 * i).Ticks), Enabled: true);
			Circle circle = currentCircle;
			Scene scene = method_0();
			TransitionProperty TransitionProperty = circle.RadiusProperty;
			scene.add(ref TransitionProperty, transition2, AutomaticallyRemoveTransition: true);
			Scene scene2 = method_0();
			TransitionProperty = circle.ColorProperty;
			scene2.add(ref TransitionProperty, transition, AutomaticallyRemoveTransition: true, AutomaticallyRemoveObject: true);
			Thread.Sleep(1);
		}
	}
}
