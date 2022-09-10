using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Egebimtes.EtiketBasimi;

public class FormBasimAciklama : Form
{
	private IContainer components;

	private Panel panel1;

	private TableLayoutPanel tableLayoutPanel1;

	private Label label2;

	private Label label3;

	private Label label4;

	private TextBox txtAciklama1;

	private Label label1;

	private TextBox txtAciklama4;

	private TextBox txtAciklama3;

	private TextBox txtAciklama2;

	private Button btnVazgec;

	private Button btnTamam;

	private GForm0 frmEtiketBasim;

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
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ce: Expected O, but got Unknown
		//IL_052c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0536: Expected O, but got Unknown
		//IL_05c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		panel1 = new Panel();
		btnVazgec = new Button();
		btnTamam = new Button();
		tableLayoutPanel1 = new TableLayoutPanel();
		txtAciklama4 = new TextBox();
		txtAciklama3 = new TextBox();
		txtAciklama2 = new TextBox();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label1 = new Label();
		txtAciklama1 = new TextBox();
		((Control)panel1).SuspendLayout();
		((Control)tableLayoutPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		panel1.set_BorderStyle((BorderStyle)1);
		((Control)panel1).get_Controls().Add((Control)(object)btnVazgec);
		((Control)panel1).get_Controls().Add((Control)(object)btnTamam);
		((Control)panel1).set_Dock((DockStyle)2);
		((Control)panel1).set_Location(new Point(0, 241));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(560, 61));
		((Control)panel1).set_TabIndex(0);
		((Control)btnVazgec).set_Location(new Point(299, 11));
		((Control)btnVazgec).set_Name("btnVazgec");
		((Control)btnVazgec).set_Size(new Size(82, 37));
		((Control)btnVazgec).set_TabIndex(1);
		((Control)btnVazgec).set_Text("Vazgeç");
		((ButtonBase)btnVazgec).set_UseVisualStyleBackColor(true);
		((Control)btnVazgec).add_Click((EventHandler)btnVazgec_Click);
		((Control)btnTamam).set_Location(new Point(177, 11));
		((Control)btnTamam).set_Name("btnTamam");
		((Control)btnTamam).set_Size(new Size(82, 37));
		((Control)btnTamam).set_TabIndex(0);
		((Control)btnTamam).set_Text("Tamam");
		((ButtonBase)btnTamam).set_UseVisualStyleBackColor(true);
		((Control)btnTamam).add_Click((EventHandler)btnTamam_Click);
		tableLayoutPanel1.set_ColumnCount(2);
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 28.57143f));
		tableLayoutPanel1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 71.42857f));
		tableLayoutPanel1.get_Controls().Add((Control)(object)txtAciklama4, 1, 3);
		tableLayoutPanel1.get_Controls().Add((Control)(object)txtAciklama3, 1, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)txtAciklama2, 1, 1);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label2, 0, 1);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label3, 0, 2);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label4, 0, 3);
		tableLayoutPanel1.get_Controls().Add((Control)(object)label1, 0, 0);
		tableLayoutPanel1.get_Controls().Add((Control)(object)txtAciklama1, 1, 0);
		((Control)tableLayoutPanel1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel1).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel1).set_Name("tableLayoutPanel1");
		tableLayoutPanel1.set_RowCount(4);
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)1, 58f));
		tableLayoutPanel1.get_RowStyles().Add(new RowStyle((SizeType)1, 59f));
		((Control)tableLayoutPanel1).set_Size(new Size(560, 241));
		((Control)tableLayoutPanel1).set_TabIndex(1);
		((Control)txtAciklama4).set_Anchor((AnchorStyles)0);
		((Control)txtAciklama4).set_Location(new Point(198, 201));
		((Control)txtAciklama4).set_Name("txtAciklama4");
		((Control)txtAciklama4).set_Size(new Size(323, 20));
		((Control)txtAciklama4).set_TabIndex(7);
		((Control)txtAciklama3).set_Anchor((AnchorStyles)0);
		((Control)txtAciklama3).set_Location(new Point(198, 143));
		((Control)txtAciklama3).set_Name("txtAciklama3");
		((Control)txtAciklama3).set_Size(new Size(323, 20));
		((Control)txtAciklama3).set_TabIndex(6);
		((Control)txtAciklama2).set_Anchor((AnchorStyles)0);
		((Control)txtAciklama2).set_Location(new Point(198, 83));
		((Control)txtAciklama2).set_Name("txtAciklama2");
		((Control)txtAciklama2).set_Size(new Size(323, 20));
		((Control)txtAciklama2).set_TabIndex(5);
		((Control)label2).set_Anchor((AnchorStyles)0);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)label2).set_Location(new Point(37, 83));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(86, 20));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Açıklama 2");
		label2.set_TextAlign((ContentAlignment)64);
		((Control)label3).set_Anchor((AnchorStyles)0);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)label3).set_Location(new Point(37, 143));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(86, 20));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Açıklama 3");
		label3.set_TextAlign((ContentAlignment)64);
		((Control)label4).set_Anchor((AnchorStyles)0);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)label4).set_Location(new Point(37, 201));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(86, 20));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Açıklama 4");
		label4.set_TextAlign((ContentAlignment)64);
		((Control)label1).set_Anchor((AnchorStyles)0);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)162));
		((Control)label1).set_Location(new Point(37, 21));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(86, 20));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Açıklama 1");
		label1.set_TextAlign((ContentAlignment)64);
		((Control)txtAciklama1).set_Anchor((AnchorStyles)0);
		((Control)txtAciklama1).set_Location(new Point(198, 21));
		((Control)txtAciklama1).set_Name("txtAciklama1");
		((Control)txtAciklama1).set_Size(new Size(323, 20));
		((Control)txtAciklama1).set_TabIndex(4);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(560, 302));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("FormBasimAciklama");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Etiket Dizayn Açıklama Sahaları");
		((Control)panel1).ResumeLayout(false);
		((Control)tableLayoutPanel1).ResumeLayout(false);
		((Control)tableLayoutPanel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public FormBasimAciklama(GForm0 frmGelen)
	{
		InitializeComponent();
		frmEtiketBasim = frmGelen;
	}

	private void btnTamam_Click(object sender, EventArgs e)
	{
		frmEtiketBasim.SetAciklamaSahalari(((Control)txtAciklama1).get_Text(), ((Control)txtAciklama2).get_Text(), ((Control)txtAciklama3).get_Text(), ((Control)txtAciklama4).get_Text());
		((Form)this).Close();
	}

	private void btnVazgec_Click(object sender, EventArgs e)
	{
		frmEtiketBasim.SetAciklamaSahalari("", "", "", "");
		((Form)this).Close();
	}
}
