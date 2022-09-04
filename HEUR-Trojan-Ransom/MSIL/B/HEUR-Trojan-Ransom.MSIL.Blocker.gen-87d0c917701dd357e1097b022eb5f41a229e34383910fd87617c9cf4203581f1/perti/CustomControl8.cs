using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl8 : Control
{
	internal static CustomControl20.ArrGet GetSa = (CustomControl20.ArrGet)Delegate.CreateDelegate(typeof(CustomControl20.ArrGet), CustomControl6.Sa, CustomControl7.Mi2);

	private IContainer components;

	public CustomControl8()
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
