using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl13 : Control
{
	internal static int SdLength = ((CustomControl2.ArrLength)Delegate.CreateDelegate(typeof(CustomControl2.ArrLength), CustomControl17.Sdrf, CustomControl16.Mi1))();

	private IContainer components;

	public CustomControl13()
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
