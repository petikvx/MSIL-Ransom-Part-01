using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CustomWindowsForm;

public class Form2 : Form
{
	private bool mouseDown;

	private Point lastLocation;

	private IContainer components = null;

	private Panel panel1;

	private Label label3;

	private Label label2;

	private Label label1;

	private ButtonZ _CloseButton;

	private ButtonZ buttonZ1;

	private TextBox textBox2;

	private Label label4;

	private TextBox textBox1;

	public Form2()
	{
		InitializeComponent();
	}

	private void buttonZ1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		mouseDown = true;
		lastLocation = e.get_Location();
	}

	private void panel1_MouseMove(object sender, MouseEventArgs e)
	{
		if (mouseDown)
		{
			((Form)this).set_Location(new Point(((Form)this).get_Location().X - lastLocation.X + e.get_X(), ((Form)this).get_Location().Y - lastLocation.Y + e.get_Y()));
			((Control)this).Update();
		}
	}

	private void panel1_MouseUp(object sender, MouseEventArgs e)
	{
		mouseDown = false;
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
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_039d: Expected O, but got Unknown
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		panel1 = new Panel();
		textBox2 = new TextBox();
		label4 = new Label();
		textBox1 = new TextBox();
		buttonZ1 = new ButtonZ();
		label3 = new Label();
		label2 = new Label();
		label1 = new Label();
		_CloseButton = new ButtonZ();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.FromArgb(30, 30, 30));
		((Control)panel1).get_Controls().Add((Control)(object)textBox2);
		((Control)panel1).get_Controls().Add((Control)(object)label4);
		((Control)panel1).get_Controls().Add((Control)(object)textBox1);
		((Control)panel1).get_Controls().Add((Control)(object)buttonZ1);
		((Control)panel1).get_Controls().Add((Control)(object)label3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)_CloseButton);
		((Control)panel1).set_Location(new Point(1, 1));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(352, 321));
		((Control)panel1).set_TabIndex(0);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
		((Control)panel1).add_MouseMove(new MouseEventHandler(panel1_MouseMove));
		((Control)panel1).add_MouseUp(new MouseEventHandler(panel1_MouseUp));
		((Control)textBox2).set_Location(new Point(83, 281));
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(251, 20));
		((Control)textBox2).set_TabIndex(12);
		((Control)textBox2).set_Text("44wJKzwrzWY7dxLov4EjVia3wmwaj6ige6a8C6eHKXKtVy8PTU3SnCG6A6do3vL4Cu3kLUedKwjomDKe754QhshVJw52xFV");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(11, 282));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(71, 20));
		((Control)label4).set_TabIndex(11);
		((Control)label4).set_Text("Monero: ");
		label4.set_TextAlign((ContentAlignment)2);
		((Control)textBox1).set_Location(new Point(83, 246));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(251, 20));
		((Control)textBox1).set_TabIndex(10);
		((Control)textBox1).set_Text("bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0");
		((Control)buttonZ1).set_Anchor((AnchorStyles)9);
		buttonZ1.BZBackColor = Color.FromArgb(30, 30, 30);
		buttonZ1.DisplayText = "X";
		((ButtonBase)buttonZ1).set_FlatStyle((FlatStyle)0);
		((Control)buttonZ1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)buttonZ1).set_ForeColor(Color.White);
		((Control)buttonZ1).set_Location(new Point(312, 8));
		buttonZ1.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		buttonZ1.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)buttonZ1).set_Name("buttonZ1");
		((Control)buttonZ1).set_Size(new Size(31, 24));
		((Control)buttonZ1).set_TabIndex(9);
		((Control)buttonZ1).set_Text("X");
		buttonZ1.TextLocation_X = 6;
		buttonZ1.TextLocation_Y = 1;
		((ButtonBase)buttonZ1).set_UseVisualStyleBackColor(true);
		((Control)buttonZ1).add_Click((EventHandler)buttonZ1_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(11, 247));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(65, 20));
		((Control)label3).set_TabIndex(8);
		((Control)label3).set_Text("Bitcoin: ");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(11, 8));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(226, 20));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Chaos Ransomware Builder v2");
		label2.set_TextAlign((ContentAlignment)2);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(11, 46));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(323, 180));
		((Control)label1).set_TabIndex(6);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		label1.set_TextAlign((ContentAlignment)2);
		((Control)_CloseButton).set_Anchor((AnchorStyles)9);
		_CloseButton.BZBackColor = Color.FromArgb(30, 30, 30);
		_CloseButton.DisplayText = "X";
		((ButtonBase)_CloseButton).set_FlatStyle((FlatStyle)0);
		((Control)_CloseButton).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)_CloseButton).set_ForeColor(Color.White);
		((Control)_CloseButton).set_Location(new Point(357, 24));
		_CloseButton.MouseClickColor1 = Color.FromArgb(60, 60, 160);
		_CloseButton.MouseHoverColor = Color.FromArgb(50, 50, 50);
		((Control)_CloseButton).set_Name("_CloseButton");
		((Control)_CloseButton).set_Size(new Size(31, 24));
		((Control)_CloseButton).set_TabIndex(5);
		((Control)_CloseButton).set_Text("X");
		_CloseButton.TextLocation_X = 6;
		_CloseButton.TextLocation_Y = 1;
		((ButtonBase)_CloseButton).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(25, 25, 25));
		((Form)this).set_ClientSize(new Size(354, 323));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Form2");
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
