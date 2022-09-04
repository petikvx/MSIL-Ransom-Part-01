using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns5;

namespace ns7;

internal class Form2 : Form
{
	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	private IContainer icontainer_0;

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	public Form2()
	{
		Class24.smethod_59(this);
		((Control)button_1).set_Top(((Form)this).get_ClientSize().Height - 13 - ((Control)button_1).get_Height());
		((Control)button_0).set_Top(((Control)button_1).get_Top() - 6 - ((Control)button_0).get_Height());
		((ButtonBase)button_0).set_Image((Image)(object)Class24.smethod_49("ok"));
		((ButtonBase)button_1).set_Image((Image)(object)Class24.smethod_49("error"));
		((Control)label_0).set_Text(string.Format(((Control)label_0).get_Text(), Class44.string_0, Class44.string_1));
		((Control)this).set_Text(string.Format(((Control)this).get_Text(), Class44.string_0));
	}
}
