using System.ComponentModel;
using System.Windows.Forms;

namespace FC2ServerLauncher;

public class EmptyControl : UserControl
{
	private IContainer components;

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

	public EmptyControl()
	{
		InitializeComponent();
	}
}
