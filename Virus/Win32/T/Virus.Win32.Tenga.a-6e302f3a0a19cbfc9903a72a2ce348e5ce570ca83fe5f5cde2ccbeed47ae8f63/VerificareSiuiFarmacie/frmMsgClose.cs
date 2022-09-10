using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace VerificareSiuiFarmacie;

public class frmMsgClose : Form
{
	private IContainer icontainer_0 = null;

	private Label lblMessage;

	private Button btnYes;

	private Button btnNo;

	private Button btnCancel;

	public frmMsgClose()
	{
		InitializeComponent();
	}

	private void btnNo_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)7);
	}

	private void btnCancel_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)2);
	}

	private void btnYes_Click(object sender, EventArgs e)
	{
		((Form)this).set_DialogResult((DialogResult)6);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMsgClose));
		lblMessage = new Label();
		btnYes = new Button();
		btnNo = new Button();
		btnCancel = new Button();
		((Control)this).SuspendLayout();
		((Control)lblMessage).set_AutoSize(true);
		((Control)lblMessage).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblMessage).set_ForeColor(Color.FromArgb(0, 0, 192));
		((Control)lblMessage).set_Location(new Point(12, 9));
		((Control)lblMessage).set_Name("lblMessage");
		((Control)lblMessage).set_Size(new Size(343, 45));
		((Control)lblMessage).set_TabIndex(0);
		((Control)lblMessage).set_Text("Atentie ! \r\nSe va inchide aplicatia si nu se vor putea face validari de CNP \r\nsau trimitere de raportari din aplicatia Pharmec Farmacie!");
		((Control)btnYes).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnYes).set_Location(new Point(9, 83));
		((Control)btnYes).set_Name("btnYes");
		((Control)btnYes).set_Size(new Size(111, 29));
		((Control)btnYes).set_TabIndex(1);
		((Control)btnYes).set_Text("Inchidere");
		((ButtonBase)btnYes).set_UseVisualStyleBackColor(true);
		((Control)btnYes).add_Click((EventHandler)btnYes_Click);
		((Control)btnNo).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnNo).set_Location(new Point(122, 83));
		((Control)btnNo).set_Name("btnNo");
		((Control)btnNo).set_Size(new Size(111, 29));
		((Control)btnNo).set_TabIndex(2);
		((Control)btnNo).set_Text("Renuntare");
		((ButtonBase)btnNo).set_UseVisualStyleBackColor(true);
		((Control)btnNo).add_Click((EventHandler)btnNo_Click);
		btnCancel.set_DialogResult((DialogResult)2);
		((Control)btnCancel).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnCancel).set_Location(new Point(235, 83));
		((Control)btnCancel).set_Name("btnCancel");
		((Control)btnCancel).set_Size(new Size(111, 29));
		((Control)btnCancel).set_TabIndex(1);
		((Control)btnCancel).set_Text("Raman in bara");
		((ButtonBase)btnCancel).set_UseVisualStyleBackColor(true);
		((Control)btnCancel).add_Click((EventHandler)btnCancel_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnYes);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnCancel);
		((Form)this).set_ClientSize(new Size(358, 127));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)btnCancel);
		((Control)this).get_Controls().Add((Control)(object)btnNo);
		((Control)this).get_Controls().Add((Control)(object)btnYes);
		((Control)this).get_Controls().Add((Control)(object)lblMessage);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("frmMsgClose");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Atentie");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
