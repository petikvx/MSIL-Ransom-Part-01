using System.Windows.Forms;

namespace xClient.Core.MouseKeyHook;

public interface IKeyboardEvents
{
	event KeyEventHandler KeyDown;

	event KeyPressEventHandler KeyPress;

	event KeyEventHandler KeyUp;
}
