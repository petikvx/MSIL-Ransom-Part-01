using System.Drawing;
using System.Windows.Forms;

namespace MetroFramework.Animation;

public sealed class MoveAnimation : AnimationBase
{
	public void Start(Control control, Point targetPoint, TransitionType transitionType, int duration)
	{
		Start(control, transitionType, duration, delegate
		{
			int x = DoMoveAnimation(control.get_Location().X, targetPoint.X);
			int y = DoMoveAnimation(control.get_Location().Y, targetPoint.Y);
			control.set_Location(new Point(x, y));
		}, () => control.get_Location().Equals((object?)targetPoint));
	}

	private int DoMoveAnimation(int startPos, int targetPos)
	{
		float t = (float)counter - (float)startTime;
		float b = startPos;
		float c = (float)targetPos - (float)startPos;
		float d = (float)targetTime - (float)startTime;
		return MakeTransition(t, b, d, c);
	}
}
