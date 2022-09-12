using System.ComponentModel;
using System.Windows.Forms;
using ns2;

namespace ns0;

internal class Form1 : Form
{
	private IContainer icontainer_0 = null;

	internal ListView listView_0;

	public Form1()
	{
		Class7.smethod_20(this);
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}
}
