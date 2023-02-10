using System.ComponentModel;
using System.Windows.Forms;

namespace ConsoleApplication1;

public class UserControl1 : UserControl
{
	private IContainer components;

	public UserControl1()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
	}
}
