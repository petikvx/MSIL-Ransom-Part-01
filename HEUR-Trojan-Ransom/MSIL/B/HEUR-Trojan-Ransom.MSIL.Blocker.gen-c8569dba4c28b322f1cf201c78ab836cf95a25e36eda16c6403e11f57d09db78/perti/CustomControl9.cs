using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl9 : Control
{
	internal static int SaLength = ((CustomControl2.ArrLength)Delegate.CreateDelegate(typeof(CustomControl2.ArrLength), CustomControl6.Sa, CustomControl16.Mi1))();

	private IContainer components;

	public CustomControl9()
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
