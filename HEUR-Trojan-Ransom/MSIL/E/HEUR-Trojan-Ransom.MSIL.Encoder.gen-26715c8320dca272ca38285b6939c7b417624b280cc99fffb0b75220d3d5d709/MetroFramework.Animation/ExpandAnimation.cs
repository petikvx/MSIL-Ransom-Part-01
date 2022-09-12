using System.Drawing;
using System.Windows.Forms;

namespace MetroFramework.Animation;

public sealed class ExpandAnimation : AnimationBase
{
	public void Start(Control control, Size targetSize, TransitionType transitionType, int duration)
	{
		Start(control, transitionType, duration, delegate
		{
			int width = DoExpandAnimation(control.get_Width(), targetSize.Width);
			int height = DoExpandAnimation(control.get_Height(), targetSize.Height);
			control.set_Size(new Size(width, height));
		}, () => control.get_Size().Equals((object?)targetSize));
	}

	private int DoExpandAnimation(int startSize, int targetSize)
	{
		float t = (float)counter - (float)startTime;
		float b = startSize;
		float c = (float)targetSize - (float)startSize;
		float d = (float)targetTime - (float)startTime;
		return MakeTransition(t, b, d, c);
	}
}
