using System.Windows.Forms;

namespace setup;

public interface IApplicationView
{
	void SetFunctionControl(IFunctionControl function);

	void OnFunctionKey(Keys key);

	void OnButtonExit();
}
