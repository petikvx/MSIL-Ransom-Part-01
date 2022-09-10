using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl4 : Control
{
	internal static CustomControl1.FromBase64 D = (CustomControl1.FromBase64)Delegate.CreateDelegate(typeof(CustomControl1.FromBase64), typeof(Convert).GetMethod("FromBase64String"));

	private IContainer components;

	public CustomControl4()
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
