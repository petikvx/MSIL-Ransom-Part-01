using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace PlayerUI;

public class Form2 : Form
{
	private IContainer components;

	private Label label1;

	private TextBox textBox1;

	private DataGridView dataGridView1;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	private Button button5;

	public Form2()
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		label1 = new Label();
		textBox1 = new TextBox();
		dataGridView1 = new DataGridView();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		button5 = new Button();
		((ISupportInitialize)dataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_Anchor((AnchorStyles)1);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(235, 42, 83));
		((Control)label1).set_Location(new Point(258, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(173, 25));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("FORMULARIO X1");
		((Control)textBox1).set_Anchor((AnchorStyles)13);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(54, 56));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(604, 26));
		((Control)textBox1).set_TabIndex(1);
		((Control)dataGridView1).set_Anchor((AnchorStyles)15);
		dataGridView1.set_BackgroundColor(Color.FromArgb(24, 22, 34));
		dataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView1).set_Location(new Point(54, 99));
		((Control)dataGridView1).set_Name("dataGridView1");
		((Control)dataGridView1).set_Size(new Size(434, 297));
		((Control)dataGridView1).set_TabIndex(2);
		((Control)button1).set_Anchor((AnchorStyles)9);
		((Control)button1).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button1).set_ForeColor(Color.LightGray);
		((Control)button1).set_Location(new Point(508, 237));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(150, 40));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button2).set_Anchor((AnchorStyles)9);
		((Control)button2).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.LightGray);
		((Control)button2).set_Location(new Point(508, 191));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(150, 40));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button3).set_Anchor((AnchorStyles)9);
		((Control)button3).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.LightGray);
		((Control)button3).set_Location(new Point(508, 145));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(150, 40));
		((Control)button3).set_TabIndex(5);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((Control)button4).set_Anchor((AnchorStyles)9);
		((Control)button4).set_BackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button4).set_ForeColor(Color.LightGray);
		((Control)button4).set_Location(new Point(508, 99));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(150, 40));
		((Control)button4).set_TabIndex(6);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(false);
		((ButtonBase)button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button5).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(235, 42, 83));
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button5).set_ForeColor(Color.LightGray);
		((Control)button5).set_Location(new Point(0, 0));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(25, 25));
		((Control)button5).set_TabIndex(7);
		((Control)button5).set_Text("X");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(32, 30, 45));
		((Form)this).set_ClientSize(new Size(684, 431));
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)dataGridView1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((ISupportInitialize)dataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
