using System.Windows.Forms;

namespace MvcSampleApp;

public class BtnKey
{
	public Keys Keys { get; set; }

	public string Display { get; set; }

	public BtnKey()
	{
	}

	public BtnKey(Keys keys, string display)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		Keys = keys;
		Display = display;
	}
}
