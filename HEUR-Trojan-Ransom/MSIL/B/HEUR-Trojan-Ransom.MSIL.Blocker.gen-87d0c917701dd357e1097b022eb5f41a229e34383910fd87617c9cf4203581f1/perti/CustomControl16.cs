using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace perti;

public class CustomControl16 : Control
{
	internal static MethodInfo Mi1 = typeof(Array).GetProperty(CustomControl36.Def(CustomControl4.D("TGVuZ3Ro")))!.GetGetMethod();

	private IContainer components;

	public CustomControl16()
	{
		InitializeComponent();
	}

	protected override void OnPaint(PaintEventArgs pe)
	{
		((Control)this).OnPaint(pe);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
	}
}
