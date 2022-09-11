using System.Windows.Forms;

namespace Gma.UserActivityMonitor;

public class MouseEventExtArgs : MouseEventArgs
{
	private bool m_Handled;

	public bool Handled
	{
		get
		{
			return m_Handled;
		}
		set
		{
			m_Handled = value;
		}
	}

	public MouseEventExtArgs(MouseButtons buttons, int clicks, int x, int y, int delta)
		: base(buttons, clicks, x, y, delta)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)


	internal MouseEventExtArgs(MouseEventArgs e)
		: base(e.get_Button(), e.get_Clicks(), e.get_X(), e.get_Y(), e.get_Delta())
	{
	}//IL_0002: Unknown result type (might be due to invalid IL or missing references)

}
