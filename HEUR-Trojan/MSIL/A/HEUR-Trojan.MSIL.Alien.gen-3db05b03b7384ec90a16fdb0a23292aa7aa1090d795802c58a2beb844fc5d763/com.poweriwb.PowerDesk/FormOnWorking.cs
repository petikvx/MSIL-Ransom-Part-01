using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace com.poweriwb.PowerDesk;

public class FormOnWorking : Form
{
	private IContainer components = null;

	private Label lbMSG;

	public FormOnWorking()
	{
		InitializeComponent();
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
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		lbMSG = new Label();
		((Control)this).SuspendLayout();
		((Control)lbMSG).set_AutoSize(true);
		((Control)lbMSG).set_BackColor(Color.Transparent);
		((Control)lbMSG).set_Font(new Font("굴림체", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)129));
		((Control)lbMSG).set_ForeColor(Color.Aqua);
		((Control)lbMSG).set_Location(new Point(13, 1));
		((Control)lbMSG).set_Name("lbMSG");
		((Control)lbMSG).set_Size(new Size(130, 24));
		((Control)lbMSG).set_TabIndex(0);
		((Control)lbMSG).set_Text("건강진단중");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Magenta);
		((Form)this).set_ClientSize(new Size(168, 27));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)lbMSG);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("FormOnWorking");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("FormOnWorking");
		((Form)this).set_TopMost(true);
		((Form)this).set_TransparencyKey(Color.Magenta);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
