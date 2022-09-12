using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UnlockYourFiles.Login;

public class msgbox : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 15820)]
	private struct Struct0
	{
	}

	internal static byte byte_0/* Not supported: data(00) */;

	internal IContainer icontainer_0;

	internal Panel panel1;

	internal Label label1;

	internal Button button1;

	internal PictureBox btnCerrar;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public msgbox()
	{
		IContainer container = (icontainer_0 = null);
		((Form)this)._002Ector();
		InitializeComponent();
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_ShowInTaskbar(false);
	}

	private void msgbox_Load(object sender, EventArgs e)
	{
	}

	public void changeLabel(string text)
	{
		((Control)label1).set_Text(text);
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void btnCerrar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0017: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(msgbox));
		Panel val = (panel1 = new Panel());
		Button val2 = (button1 = new Button());
		PictureBox val3 = (btnCerrar = new PictureBox());
		Label val4 = (label1 = new Label());
		((Control)panel1).SuspendLayout();
		((ISupportInitialize)btnCerrar).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(15, 15, 15));
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)btnCerrar);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).set_Location(new Point(1, 2));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(235, 123));
		((Control)panel1).set_TabIndex(0);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.DimGray);
		((Control)button1).set_Location(new Point(142, 90));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(9);
		((Control)button1).set_Text("Close");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)btnCerrar).set_BackColor(Color.FromArgb(15, 15, 15));
		btnCerrar.set_Image((Image)componentResourceManager.GetObject("btnCerrar.Image"));
		((Control)btnCerrar).set_Location(new Point(200, 8));
		((Control)btnCerrar).set_Name("btnCerrar");
		((Control)btnCerrar).set_Size(new Size(25, 25));
		btnCerrar.set_SizeMode((PictureBoxSizeMode)3);
		btnCerrar.set_TabIndex(8);
		btnCerrar.set_TabStop(false);
		((Control)btnCerrar).add_Click((EventHandler)btnCerrar_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DimGray);
		((Control)label1).set_Location(new Point(11, 27));
		((Control)label1).set_MaximumSize(new Size(165, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(0, 16));
		((Control)label1).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DimGray);
		((Form)this).set_ClientSize(new Size(238, 127));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("msgbox");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("msgbox");
		((Form)this).add_Load((EventHandler)msgbox_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((ISupportInitialize)btnCerrar).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
