using System.Windows.Forms;

namespace setup;

public class FunctionKey
{
	public Keys Keys { get; set; }

	public string Display { get; set; }

	public FunctionKey()
	{
	}

	public FunctionKey(Keys keys, string display)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Keys = keys;
		Display = display;
	}
}
