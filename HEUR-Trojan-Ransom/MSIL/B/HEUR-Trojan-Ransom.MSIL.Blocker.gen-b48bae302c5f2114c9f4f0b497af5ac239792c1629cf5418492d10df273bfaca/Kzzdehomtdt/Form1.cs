using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Kzzdehomtdt;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	private ListView listView1;

	private NotifyIcon notifyIcon1;

	private RadioButton radioButton1;

	private ListView listView2;

	private DateTimePicker dateTimePicker1;

	private CheckBox checkBox1;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Catcher.Demo();
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		components = new Container();
		label1 = new Label();
		listView1 = new ListView();
		notifyIcon1 = new NotifyIcon(components);
		radioButton1 = new RadioButton();
		listView2 = new ListView();
		dateTimePicker1 = new DateTimePicker();
		checkBox1 = new CheckBox();
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(0, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("label1");
		listView1.set_HideSelection(false);
		((Control)listView1).set_Location(new Point(8, 8));
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(121, 97));
		((Control)listView1).set_TabIndex(1);
		listView1.set_UseCompatibleStateImageBehavior(false);
		notifyIcon1.set_Text("notifyIcon1");
		notifyIcon1.set_Visible(true);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Location(new Point(0, 0));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(85, 17));
		((Control)radioButton1).set_TabIndex(2);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("radioButton1");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		listView2.set_HideSelection(false);
		((Control)listView2).set_Location(new Point(8, 8));
		((Control)listView2).set_Name("listView2");
		((Control)listView2).set_Size(new Size(121, 97));
		((Control)listView2).set_TabIndex(3);
		listView2.set_UseCompatibleStateImageBehavior(false);
		((Control)dateTimePicker1).set_Location(new Point(16, 16));
		((Control)dateTimePicker1).set_Name("dateTimePicker1");
		((Control)dateTimePicker1).set_Size(new Size(200, 20));
		((Control)dateTimePicker1).set_TabIndex(4);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(24, 24));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(80, 17));
		((Control)checkBox1).set_TabIndex(5);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Location(new Point(32, 32));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(75, 23));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button2).set_Location(new Point(40, 40));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(7);
		((Control)button2).set_Text("button2");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button3).set_Location(new Point(48, 48));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(75, 23));
		((Control)button3).set_TabIndex(8);
		((Control)button3).set_Text("button3");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Location(new Point(56, 56));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(75, 23));
		((Control)button4).set_TabIndex(9);
		((Control)button4).set_Text("button4");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(464, 468));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).get_Controls().Add((Control)(object)dateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)listView2);
		((Control)this).get_Controls().Add((Control)(object)radioButton1);
		((Control)this).get_Controls().Add((Control)(object)listView1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
