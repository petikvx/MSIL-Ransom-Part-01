using System;
using System.ComponentModel;
using System.Windows.Forms;
using ns1;

namespace ns0;

internal class Form0 : Form
{
	private IContainer icontainer_0 = null;

	internal Label label_0;

	internal Label label_1;

	internal Label label_2;

	internal TextBox textBox_0;

	internal TextBox textBox_1;

	internal TextBox textBox_2;

	internal Button button_0;

	internal Button button_1;

	internal Button button_2;

	public Form0()
	{
		Class2.smethod_0(this);
		Form1 form = new Form1();
		try
		{
			Class2.smethod_4(this);
		}
		finally
		{
			((IDisposable)form)?.Dispose();
		}
		Class2.smethod_1(this);
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
