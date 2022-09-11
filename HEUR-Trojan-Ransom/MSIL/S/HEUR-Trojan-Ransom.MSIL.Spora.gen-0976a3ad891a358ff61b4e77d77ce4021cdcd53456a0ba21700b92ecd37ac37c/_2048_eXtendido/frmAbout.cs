using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace _2048_eXtendido;

public class frmAbout : Form
{
	private IContainer components = null;

	private PictureBox pbxFotoIvan;

	private Label lblInformationPersonal;

	public frmAbout()
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmAbout));
		pbxFotoIvan = new PictureBox();
		lblInformationPersonal = new Label();
		((ISupportInitialize)pbxFotoIvan).BeginInit();
		((Control)this).SuspendLayout();
		pbxFotoIvan.set_ErrorImage((Image)null);
		pbxFotoIvan.set_Image((Image)componentResourceManager.GetObject("pbxFotoIvan.Image"));
		pbxFotoIvan.set_InitialImage((Image)null);
		((Control)pbxFotoIvan).set_Location(new Point(12, 3));
		((Control)pbxFotoIvan).set_Name("pbxFotoIvan");
		((Control)pbxFotoIvan).set_Size(new Size(253, 308));
		pbxFotoIvan.set_SizeMode((PictureBoxSizeMode)4);
		pbxFotoIvan.set_TabIndex(0);
		pbxFotoIvan.set_TabStop(false);
		((Control)lblInformationPersonal).set_AutoSize(true);
		((Control)lblInformationPersonal).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblInformationPersonal).set_Location(new Point(282, 30));
		((Control)lblInformationPersonal).set_Name("lblInformationPersonal");
		((Control)lblInformationPersonal).set_Size(new Size(436, 100));
		((Control)lblInformationPersonal).set_TabIndex(1);
		((Control)lblInformationPersonal).set_Text("Iván Galbán Smith\r\nDireción correo: i.galban@lab.matcom.uh.cu\r\nFacultad de Matemática y Computación\r\nUniversidad de La Habana, Cuba");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaption);
		((Form)this).set_ClientSize(new Size(737, 311));
		((Control)this).get_Controls().Add((Control)(object)lblInformationPersonal);
		((Control)this).get_Controls().Add((Control)(object)pbxFotoIvan);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("frmAbout");
		((Control)this).set_Text("About Created");
		((ISupportInitialize)pbxFotoIvan).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
