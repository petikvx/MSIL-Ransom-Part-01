using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GimApp1;

public class Debugtool : Form
{
	private IContainer components;

	private Button button1;

	private Button button2;

	private Button button3;

	private MaskedTextBox maskedTextBox1;

	private Label label1;

	private Label label2;

	private Label label4;

	private Label label6;

	private CheckBox checkBox1;

	private Button button4;

	private Label label10;

	private Button button5;

	public Label label3;

	public Label label5;

	public Label label7;

	public Label label11;

	public string ReturnButtomClick { get; set; }

	public Debugtool()
	{
		InitializeComponent();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		ReturnButtomClick = "install";
		((Control)this).Hide();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		ReturnButtomClick = "remove";
		((Control)this).Hide();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		ReturnButtomClick = "update";
		((Control)this).Hide();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (checkBox1.get_Checked())
		{
			MessageBox.Show("In auto debug parametr You can't change parametr");
			return;
		}
		string text = ((Control)maskedTextBox1).get_Text();
		MessageBox.Show(text);
		ReturnButtomClick = "setParam";
	}

	private void button5_Click(object sender, EventArgs e)
	{
		ReturnButtomClick = "exit";
		((Form)this).Close();
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		maskedTextBox1 = new MaskedTextBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		checkBox1 = new CheckBox();
		button4 = new Button();
		label10 = new Label();
		label11 = new Label();
		button5 = new Button();
		((Control)this).SuspendLayout();
		((Control)button1).set_Location(new Point(177, 155));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("SetParam");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Location(new Point(96, 189));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Remove");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button3).set_Location(new Point(15, 189));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(2);
		((Control)button3).set_Text("Install");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)maskedTextBox1).set_Location(new Point(67, 126));
		((Control)maskedTextBox1).set_Name("maskedTextBox1");
		((Control)maskedTextBox1).set_Size(new Size(185, 20));
		((Control)maskedTextBox1).set_TabIndex(3);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 129));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 13));
		((Control)label1).set_TabIndex(4);
		((Control)label1).set_Text("Parametr");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 9));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(24, 13));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("ID: ");
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(101, 9));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(35, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("label3");
		((Control)label3).add_Click((EventHandler)label3_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(12, 22));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(69, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Registry run: ");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(101, 22));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(35, 13));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text("label5");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Location(new Point(12, 35));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(79, 13));
		((Control)label6).set_TabIndex(9);
		((Control)label6).set_Text("Registry alcos: ");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Location(new Point(101, 35));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(35, 13));
		((Control)label7).set_TabIndex(10);
		((Control)label7).set_Text("label7");
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(15, 155));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(125, 17));
		((Control)checkBox1).set_TabIndex(11);
		((Control)checkBox1).set_Text("Auto debug parametr");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(177, 189));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 23));
		((Control)button4).set_TabIndex(12);
		((Control)button4).set_Text("Update");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(12, 48));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(59, 13));
		((Control)label10).set_TabIndex(15);
		((Control)label10).set_Text("Bottom Url:");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Location(new Point(101, 48));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(41, 13));
		((Control)label11).set_TabIndex(16);
		((Control)label11).set_Text("label11");
		((Control)button5).set_Location(new Point(15, 219));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Size(new Size(75, 23));
		((Control)button5).set_TabIndex(17);
		((Control)button5).set_Text("Exit");
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(480, 260));
		((Control)this).get_Controls().Add((Control)(object)button5);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Debugtool");
		((Control)this).set_Text("Debugtool");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
