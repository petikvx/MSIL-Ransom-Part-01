using System.Drawing;
using System.Windows.Forms;
using MiniGameEngine.UI;

namespace MiniGameEngine;

public class EmptyScene : Scene
{
	private TextElement textElement_0;

	private TextElement textElement_1;

	public EmptyScene(GameContainer game)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		Class11.NQ1E32yzjMukk();
		base._002Ector(game);
		checked
		{
			textElement_0 = new TextElement("Welcome!")
			{
				Position = new Point(base.Game.MIDDLE_POS.X, base.Game.MIDDLE_POS.Y - 50),
				Font = new Font(((Control)base.Game.Window).get_Font().get_FontFamily(), 45f),
				Color = Color.White,
				HorizontalAlignment = HorizontalAlignment.Center
			};
			textElement_1 = new TextElement("To get started, add a scene to your project using the addScene sub procedure.")
			{
				Position = new Point(base.Game.MIDDLE_POS.X, base.Game.MIDDLE_POS.Y + 25),
				Font = new Font(((Control)base.Game.Window).get_Font().get_FontFamily(), 14f),
				Color = Color.White,
				HorizontalAlignment = HorizontalAlignment.Center
			};
		}
	}

	public override void Init()
	{
		add(textElement_0);
		add(textElement_1);
	}

	public override void Render(Graphics g)
	{
	}

	public override void Update(double delta)
	{
	}
}
