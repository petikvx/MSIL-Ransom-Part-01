using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FaturaDecryptor;

public class DecryptionProgressBarForm : Form
{
	private IContainer components;

	private ProgressBar DecryptionProcessProgressBar;

	public DecryptionProgressBarForm()
	{
		InitializeComponent();
	}

	private void DecryptionProgressBarForm_Load(object sender, EventArgs e)
	{
		DecryptionProcessProgressBar.set_Style((ProgressBarStyle)2);
		DecryptionProcessProgressBar.set_MarqueeAnimationSpeed(30);
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
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		DecryptionProcessProgressBar = new ProgressBar();
		((Control)this).SuspendLayout();
		((Control)DecryptionProcessProgressBar).set_Anchor((AnchorStyles)15);
		((Control)DecryptionProcessProgressBar).set_Location(new Point(14, 18));
		((Control)DecryptionProcessProgressBar).set_Name("DecryptionProcessProgressBar");
		((Control)DecryptionProcessProgressBar).set_Size(new Size(728, 51));
		((Control)DecryptionProcessProgressBar).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 15f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(747, 84));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)DecryptionProcessProgressBar);
		((Control)this).set_Font(new Font("Segoe UI", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("DecryptionProgressBarForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Lütfen bekle ...");
		((Form)this).add_Load((EventHandler)DecryptionProgressBarForm_Load);
		((Control)this).ResumeLayout(false);
	}
}
