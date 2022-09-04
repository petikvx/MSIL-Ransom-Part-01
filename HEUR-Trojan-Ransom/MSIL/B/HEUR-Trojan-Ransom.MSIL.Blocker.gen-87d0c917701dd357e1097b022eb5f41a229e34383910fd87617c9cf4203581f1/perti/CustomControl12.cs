using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace perti;

public class CustomControl12 : Control
{
	private IContainer components;

	public CustomControl12()
	{
		InitializeComponent();
	}

	internal static void Mana()
	{
		CustomControl22.MyValue myValue = (CustomControl22.MyValue)Delegate.CreateDelegate(typeof(CustomControl22.MyValue), CustomControl21.Instance, CustomControl36.Def(CustomControl4.D("U2Fkcg==")));
		myValue();
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
