using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HexConverter;

public class DialogBox : Form
{
	private int count;

	private IContainer components;

	private PictureBox pictureBox1;

	private Button button1;

	private Label label1;

	private RichTextBox richTextBox1;

	private Timer timer1;

	private Label label2;

	public DialogBox()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void DialogBox_Load(object sender, EventArgs e)
	{
		count = 0;
		timer1.set_Enabled(true);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (count == 0)
		{
			((Control)label2).set_Text("Made by Axdx");
		}
		else if (count == 1)
		{
			((Control)label2).set_Text("Made by aXdx");
		}
		else if (count == 2)
		{
			((Control)label2).set_Text("Made by axDx");
		}
		else if (count == 3)
		{
			((Control)label2).set_Text("Made by axdX");
		}
		else
		{
			((Control)label2).set_Text("Made by axdx");
			count = -1;
		}
		count++;
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DialogBox));
		pictureBox1 = new PictureBox();
		button1 = new Button();
		label1 = new Label();
		richTextBox1 = new RichTextBox();
		timer1 = new Timer(components);
		label2 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(12, 12));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(48, 48));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)button1).set_Location(new Point(353, 35));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 25));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("OK");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(92, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(111, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Hex Converter ver 1.5");
		((Control)richTextBox1).set_BackColor(SystemColors.Control);
		((Control)richTextBox1).set_Dock((DockStyle)2);
		((Control)richTextBox1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)richTextBox1).set_Location(new Point(0, 66));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(440, 398));
		((Control)richTextBox1).set_TabIndex(4);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((TextBoxBase)richTextBox1).set_WordWrap(false);
		timer1.set_Interval(500);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(222, 41));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(73, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("Made by axdx");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(440, 464));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("DialogBox");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("About");
		((Form)this).add_Load((EventHandler)DialogBox_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
