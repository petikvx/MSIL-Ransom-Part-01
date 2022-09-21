using System.Drawing;
using System.Windows.Forms;
using MiniGameEngine.Examples.Droplets;
using MiniGameEngine.General.Threading;

namespace MiniGameEngine.Examples.Scenes;

public class EchoLocationDemo : Scene
{
	private SimpleEchoDroplets simpleEchoDroplets_0;

	private Point point_0;

	public EchoLocationDemo(GameContainer Game)
	{
		Class11.NQ1E32yzjMukk();
		base._002Ector(Game);
		simpleEchoDroplets_0 = new SimpleEchoDroplets(this);
		Game.Clip = false;
	}

	public override void MouseClick(MouseButtons MouseButton)
	{
		ThreadWork.Start(delegate
		{
			simpleEchoDroplets_0.Spawn(point_0);
		});
	}

	public override void MouseMove(Point Location)
	{
		point_0 = Location;
	}

	public override void Init()
	{
	}

	public override void Render(Graphics g)
	{
	}

	public override void Update(double delta)
	{
	}
}
