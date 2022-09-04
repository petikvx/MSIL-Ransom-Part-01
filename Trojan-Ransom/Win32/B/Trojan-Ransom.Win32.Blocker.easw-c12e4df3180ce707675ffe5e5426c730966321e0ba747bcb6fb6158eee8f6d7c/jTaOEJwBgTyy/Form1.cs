using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using jTaOEJwBgTyy.Properties;

namespace jTaOEJwBgTyy;

public class Form1 : Form
{
	private IContainer components;

	private BindingSource bindingSource1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		components = new Container();
		bindingSource1 = new BindingSource(components);
		((ISupportInitialize)bindingSource1).BeginInit();
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(363, 248));
		_ = Resources.ResourceManager.BaseName;
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)bindingSource1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
