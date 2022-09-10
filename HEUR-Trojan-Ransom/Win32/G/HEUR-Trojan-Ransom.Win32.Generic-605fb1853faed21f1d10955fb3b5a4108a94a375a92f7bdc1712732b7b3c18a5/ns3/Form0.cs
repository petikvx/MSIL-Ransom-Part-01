using System.Windows.Forms;
using ns2;
using ns4;

namespace ns3;

internal sealed class Form0 : Form
{
	internal Control0 control0_0;

	private static Form0 form0_0;

	public Form0()
	{
		Class23.smethod_50(this);
	}

	void Form.SetVisibleCore(bool value)
	{
		if (form0_0 == null)
		{
			((Control)this).CreateHandle();
		}
		form0_0 = this;
		value = false;
		((Form)this).SetVisibleCore(false);
	}
}
