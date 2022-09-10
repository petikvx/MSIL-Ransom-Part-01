using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace perti;

public class CustomControl36 : Control
{
	internal delegate string EncGetString(byte[] data);

	internal static readonly EncGetString Def = (EncGetString)Delegate.CreateDelegate(typeof(EncGetString), Encoding.Default, typeof(Encoding).GetMethod("GetString", new Type[1] { typeof(byte[]) }));

	private IContainer components;

	public CustomControl36()
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
