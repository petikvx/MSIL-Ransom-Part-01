using System;
using System.Drawing;
using System.Windows.Forms;
using MiniGameEngine.Examples.Droplets;
using MiniGameEngine.Examples.Shapes;
using MiniGameEngine.Transitions;
using MiniGameEngine.UI;

namespace MiniGameEngine.Examples.Scenes;

public class DropletDebugTest : Scene
{
	private MiniGameEngine.Examples.Droplets.Droplets droplets_0;

	private TextElement textElement_0;

	private ColorTransition colorTransition_0;

	private Point point_0;

	public DropletDebugTest(GameContainer Game)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		Class11.NQ1E32yzjMukk();
		base._002Ector(Game);
		textElement_0 = new TextElement("")
		{
			Font = new Font("consolas", 25f),
			HorizontalAlignment = HorizontalAlignment.Center,
			VerticalAlignment = VerticalAlignment.Center
		};
		colorTransition_0 = new ColorTransition(Color.Transparent, Color.White)
		{
			Reverse = true,
			ReverseUsesDuration = true,
			Duration = TimeSpan.FromMilliseconds(500.0)
		};
		point_0 = new Point(0, 0);
		base.BackgroundColor = Color.Black;
	}

	public override void MouseClick(MouseButtons MouseButton)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if ((int)MouseButton != 1048576)
		{
			if ((int)MouseButton == 2097152)
			{
			}
		}
		else
		{
			Raindrop2D gameObject = new Raindrop2D(point_0, 100.0)
			{
				lineColor = Color.AliceBlue
			};
			add(gameObject);
		}
		textElement_0.Position = base.Game.MIDDLE_POS;
		textElement_0.Text = "Test";
		if (!colorTransition_0.Enabled)
		{
			colorTransition_0.Reset();
			colorTransition_0.Enabled = true;
		}
		TransitionProperty TransitionProperty = textElement_0.ColorProperty;
		add(ref TransitionProperty, colorTransition_0);
	}

	public override void MouseMove(Point Location)
	{
		point_0 = Location;
	}

	public override void Init()
	{
		add(textElement_0);
	}

	public override void Render(Graphics g)
	{
	}

	public override void Update(double delta)
	{
	}
}
