using System.ComponentModel;
using System.Windows.Forms;

namespace Letum;

public class Form1 : Form
{
	private IContainer components;

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
		((Control)this).set_Text("Form1");
	}

	public Form1()
	{
		InitializeComponent();
	}
}
