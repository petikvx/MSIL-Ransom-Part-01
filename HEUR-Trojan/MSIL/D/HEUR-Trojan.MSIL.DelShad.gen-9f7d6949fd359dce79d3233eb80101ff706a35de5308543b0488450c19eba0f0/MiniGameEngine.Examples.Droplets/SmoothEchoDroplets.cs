using System.Drawing;
using System.Threading;
using MiniGameEngine.Examples.Shapes;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.Examples.Droplets;

public class SmoothEchoDroplets : Droplets
{
	public SmoothEchoDroplets(Scene Scene)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Scene);
	}

	internal override void vmethod_0(int i, ref Circle currentCircle)
	{
		Scene scene = method_0();
		TransitionProperty TransitionProperty = currentCircle.RadiusProperty;
		scene.add(ref TransitionProperty, new DoubleTransition(1.0, base.dropletRadius)
		{
			Duration = base.MovementDuration,
			Enabled = true
		}, AutomaticallyRemoveTransition: true);
		Scene scene2 = method_0();
		TransitionProperty = currentCircle.ColorProperty;
		scene2.add(ref TransitionProperty, new ColorTransition(base.dropletColor, Color.Transparent)
		{
			Duration = base.MovementDuration,
			Enabled = true
		}, AutomaticallyRemoveTransition: true, AutomaticallyRemoveObject: true);
		Thread.Sleep(20);
	}
}
