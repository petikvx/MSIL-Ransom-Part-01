using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BlackJack;

public class Form1 : Form
{
	private IContainer components = null;

	private PictureBox pictureBox1;

	private Button button1;

	private Button button2;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form2 form = new Form2();
		((Control)form).Show();
		((Control)this).Hide();
	}

	private void button2_Click(object sender, EventArgs e)
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
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		pictureBox1 = new PictureBox();
		button1 = new Button();
		button2 = new Button();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Dock((DockStyle)5);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(495, 352));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)button1).set_BackColor(Color.WhiteSmoke);
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)button1).set_Location(new Point(48, 214));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(107, 35));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("START");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.WhiteSmoke);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((Control)button2).set_Location(new Point(48, 272));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(107, 35));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("EXIT");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(495, 352));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("BLACK JACK");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		new BCAS();
	}
}
