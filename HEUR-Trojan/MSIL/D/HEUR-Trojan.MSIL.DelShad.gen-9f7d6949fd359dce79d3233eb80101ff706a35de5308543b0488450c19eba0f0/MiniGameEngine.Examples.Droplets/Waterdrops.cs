using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using MiniGameEngine.Examples.Shapes;
using MiniGameEngine.Transitions;

namespace MiniGameEngine.Examples.Droplets;

public class Waterdrops : Droplets
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Color color_1;

	public Color dropletFadeColor
	{
		[CompilerGenerated]
		get
		{
			return color_1;
		}
		[CompilerGenerated]
		set
		{
			color_1 = value;
		}
	}

	public Waterdrops(Scene Scene)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Scene);
		dropletFadeColor = Color.Transparent;
	}

	internal override void vmethod_0(int i, ref Circle currentCircle)
	{
		ColorTransition transition = new ColorTransition(base.dropletColor, dropletFadeColor)
		{
			Enabled = true
		};
		DoubleTransition transition2 = new DoubleTransition(0.0, 0.0, base.dropletRadius, base.MovementDuration, Enabled: true);
		Circle circle = currentCircle;
		Scene scene = method_0();
		TransitionProperty TransitionProperty = circle.RadiusProperty;
		scene.add(ref TransitionProperty, transition2, AutomaticallyRemoveTransition: true);
		Scene scene2 = method_0();
		TransitionProperty = circle.ColorProperty;
		scene2.add(ref TransitionProperty, transition, AutomaticallyRemoveTransition: true, AutomaticallyRemoveObject: true);
		Thread.Sleep(checked(0 + 50 * (base.dropletCount - i)));
	}
}
