using System.ComponentModel;
using System.Windows.Forms;
using ns6;

namespace ns0;

internal sealed class Form0 : Form
{
	private IContainer icontainer_0;

	internal Panel panel_0;

	internal Label label_0;

	internal PictureBox pictureBox_0;

	internal PictureBox pictureBox_1;

	internal Label label_1;

	internal Label label_2;

	internal Label label_3;

	internal TextBox textBox_0;

	internal Button button_0;

	public Form0()
	{
		Class27.smethod_36(this);
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
	}
}
