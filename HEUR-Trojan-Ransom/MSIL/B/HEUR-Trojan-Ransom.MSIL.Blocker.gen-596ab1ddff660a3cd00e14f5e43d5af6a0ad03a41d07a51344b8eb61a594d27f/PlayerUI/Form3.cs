using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PlayerUI;

public class Form3 : Form
{
	private IContainer components;

	private DataGridView dataGridView1;

	private Label label1;

	private Button button5;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button button9;

	public Form3()
	{
		InitializeComponent();
	}

	private void button5_Click(object sender, EventArgs e)
	{
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
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_035f: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0430: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		dataGridView1 = new DataGridView();
		label1 = new Label();
		button5 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		button9 = new Button();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)dataGridView1).set_Anchor((AnchorStyles)15);
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(205, 79));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(433, 274));
		((Control)dataGridView1).set_TabIndex(9);
		((Control)label1).set_Anchor((AnchorStyles)1);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(235, 42, 83));
		((Control)label1).set_Location(new Point(257, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(173, 25));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("FORMULARIO X2");
		((ButtonBase)button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button5).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(235, 42, 83));
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button5).set_ForeColor(Color.LightGray);
		((Control)button5).set_Location(new Point(0, 0));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(25, 25));
		((Control)button5).set_TabIndex(14);
		((Control)button5).set_Text("X");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button6).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button6).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button6).set_ForeColor(Color.LightGray);
		((Control)button6).set_Location(new Point(25, 79));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Size(new Size(150, 40));
		((Control)button6).set_TabIndex(18);
		((Control)button6).set_Text("button6");
		((ButtonBase)button6).set_UseVisualStyleBackColor(false);
		((Control)button7).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button7).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button7).set_ForeColor(Color.LightGray);
		((Control)button7).set_Location(new Point(25, 125));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Size(new Size(150, 40));
		((Control)button7).set_TabIndex(17);
		((Control)button7).set_Text("button7");
		((ButtonBase)button7).set_UseVisualStyleBackColor(false);
		((Control)button8).set_Anchor((AnchorStyles)10);
		((Control)button8).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button8).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button8).set_ForeColor(Color.LightGray);
		((Control)button8).set_Location(new Point(488, 359));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Size(new Size(150, 40));
		((Control)button8).set_TabIndex(16);
		((Control)button8).set_Text("button8");
		((ButtonBase)button8).set_UseVisualStyleBackColor(false);
		((Control)button9).set_Anchor((AnchorStyles)10);
		((Control)button9).set_BackColor(Color.FromArgb(235, 42, 83));
		((ButtonBase)button9).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button9).set_FlatStyle((FlatStyle)0);
		((Control)button9).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button9).set_ForeColor(Color.LightGray);
		((Control)button9).set_Location(new Point(332, 359));
		((Control)button9).set_Name("button9");
		((Control)button9).set_Size(new Size(150, 40));
		((Control)button9).set_TabIndex(15);
		((Control)button9).set_Text("button9");
		((ButtonBase)button9).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(32, 30, 45));
		((Form)this).set_ClientSize(new Size(684, 431));
		((Control)this).get_Controls().Add((Control)(object)button6);
		((Control)this).get_Controls().Add((Control)(object)button7);
		((Control)this).get_Controls().Add((Control)(object)button8);
		((Control)this).get_Controls().Add((Control)(object)button9);
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form3");
		((Control)this).set_Text("Form3");
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
