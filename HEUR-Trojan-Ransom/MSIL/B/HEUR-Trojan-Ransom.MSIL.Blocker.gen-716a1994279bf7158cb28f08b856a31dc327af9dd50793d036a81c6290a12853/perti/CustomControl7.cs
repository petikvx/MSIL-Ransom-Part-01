using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace perti;

public class CustomControl7 : Control
{
	internal static MethodInfo Mi2 = typeof(Array).GetMethod("GetValue", new Type[1] { typeof(int) });

	private IContainer components;

	public CustomControl7()
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
