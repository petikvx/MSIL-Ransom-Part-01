using System.Threading;
using MiniGameEngine.Examples.Shapes;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.Examples.Droplets;

public class SimpleEchoDroplets : Droplets
{
	public SimpleEchoDroplets(Scene Scene)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Scene);
	}

	internal override void vmethod_0(int i, ref Circle currentCircle)
	{
		DoubleTransition transition = new DoubleTransition(0.0, 0.0, 100.0, base.MovementDuration, Enabled: true);
		Circle circle = currentCircle;
		Scene scene = method_0();
		TransitionProperty TransitionProperty = circle.RadiusProperty;
		scene.add(ref TransitionProperty, transition, AutomaticallyRemoveTransition: true, AutomaticallyRemoveObject: true);
		Thread.Sleep(100);
	}
}
