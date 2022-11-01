using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace YullySpoofer;

public class GForm0 : Form
{
	private IContainer components = null;

	public GForm0()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		components = new Container();
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).set_Text("_彼らは彼らの_彼らは彼らの_彼らは彼らの_彼らは彼らの_彼らは彼らの_彼らは彼らの");
	}
}
