using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl14 : Control
{
	internal static CustomControl3.ArrSet SetSa = (CustomControl3.ArrSet)Delegate.CreateDelegate(typeof(CustomControl3.ArrSet), CustomControl6.Sa, typeof(Array).GetMethod(CustomControl36.Def(CustomControl4.D("U2V0VmFsdWU=")), new Type[2]
	{
		typeof(object),
		typeof(int)
	}));

	private IContainer components;

	public CustomControl14()
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
