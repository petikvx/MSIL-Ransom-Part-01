using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public sealed class ScanControl : UserControl
{
	private delegate void Delegate0(string string_0, string string_1);

	private delegate void Delegate1(int int_0);

	private delegate void Delegate2();

	private IContainer icontainer_0;

	private Class7 panel1;

	private Label label2;

	private Label label1;

	private ProgressBar progressBar1;

	private Class7 panel5;

	private Button btnRemove;

	private Button btnScan;

	private RadioButton radioButton3;

	private RadioButton radioButton2;

	private RadioButton radioButton1;

	private Label label7;

	private ExplorerTreeView explorerTreeView1;

	private Button btnStop;

	private Timer timer_0;

	private int int_0;

	private bool bool_0;

	private List<string> list_0 = new List<string>();

	private List<string> list_1 = new List<string>();

	public ScanControl()
	{
		InitializeComponent();
		new Delegate0(method_6);
		((Control)btnRemove).set_Enabled(false);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
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
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_0663: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		panel1 = new Class7();
		btnStop = new Button();
		panel5 = new Class7();
		btnRemove = new Button();
		btnScan = new Button();
		radioButton3 = new RadioButton();
		radioButton2 = new RadioButton();
		radioButton1 = new RadioButton();
		label7 = new Label();
		label2 = new Label();
		label1 = new Label();
		progressBar1 = new ProgressBar();
		explorerTreeView1 = new ExplorerTreeView();
		((Control)panel1).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.White);
		((Control)panel1).get_Controls().Add((Control)(object)btnStop);
		((Control)panel1).get_Controls().Add((Control)(object)explorerTreeView1);
		((Control)panel1).get_Controls().Add((Control)(object)panel5);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)progressBar1);
		((Control)panel1).set_Dock((DockStyle)5);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(703, 282));
		((Control)panel1).set_TabIndex(2);
		((Control)panel1).add_VisibleChanged((EventHandler)panel1_VisibleChanged);
		panel1.method_5(Color.FromArgb(207, 207, 207));
		((Control)btnStop).set_Enabled(false);
		((Control)btnStop).set_Location(new Point(443, 247));
		((Control)btnStop).set_Name("btnStop");
		((Control)btnStop).set_Size(new Size(75, 29));
		((Control)btnStop).set_TabIndex(6);
		((Control)btnStop).set_Text("Stop");
		((ButtonBase)btnStop).set_UseVisualStyleBackColor(true);
		((Control)btnStop).add_Click((EventHandler)btnStop_Click);
		((Control)panel5).set_BackColor(Color.FromArgb(239, 242, 246));
		((Control)panel5).get_Controls().Add((Control)(object)btnRemove);
		((Control)panel5).get_Controls().Add((Control)(object)btnScan);
		((Control)panel5).get_Controls().Add((Control)(object)radioButton3);
		((Control)panel5).get_Controls().Add((Control)(object)radioButton2);
		((Control)panel5).get_Controls().Add((Control)(object)radioButton1);
		((Control)panel5).get_Controls().Add((Control)(object)label7);
		((Control)panel5).set_Location(new Point(524, 1));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(178, 280));
		((Control)panel5).set_TabIndex(4);
		((Control)btnRemove).set_Enabled(false);
		((Control)btnRemove).set_Location(new Point(34, 232));
		((Control)btnRemove).set_Name("btnRemove");
		((Control)btnRemove).set_Size(new Size(126, 34));
		((Control)btnRemove).set_TabIndex(5);
		((Control)btnRemove).set_Text("Remove All");
		((ButtonBase)btnRemove).set_UseVisualStyleBackColor(true);
		((Control)btnRemove).add_Click((EventHandler)btnRemove_Click);
		((Control)btnScan).set_Location(new Point(24, 185));
		((Control)btnScan).set_Name("btnScan");
		((Control)btnScan).set_Size(new Size(147, 27));
		((Control)btnScan).set_TabIndex(4);
		((Control)btnScan).set_Text("Scan now");
		((ButtonBase)btnScan).set_UseVisualStyleBackColor(true);
		((Control)btnScan).add_Click((EventHandler)btnScan_Click);
		((Control)radioButton3).set_AutoSize(true);
		((Control)radioButton3).set_Enabled(false);
		((Control)radioButton3).set_Location(new Point(24, 144));
		((Control)radioButton3).set_Name("radioButton3");
		((Control)radioButton3).set_Size(new Size(69, 17));
		((Control)radioButton3).set_TabIndex(3);
		radioButton3.set_TabStop(true);
		((Control)radioButton3).set_Text("Custom...");
		((ButtonBase)radioButton3).set_UseVisualStyleBackColor(true);
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Enabled(false);
		((Control)radioButton2).set_Location(new Point(24, 112));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(41, 17));
		((Control)radioButton2).set_TabIndex(2);
		((Control)radioButton2).set_Text("Full");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)radioButton1).set_AutoSize(true);
		radioButton1.set_Checked(true);
		((Control)radioButton1).set_Location(new Point(24, 80));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(53, 17));
		((Control)radioButton1).set_TabIndex(1);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("Quick");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_Location(new Point(20, 31));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(89, 16));
		((Control)label7).set_TabIndex(0);
		((Control)label7).set_Text("Scan options:");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(228, 247));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(0, 15));
		((Control)label2).set_TabIndex(3);
		label1.set_AutoEllipsis(true);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(17, 253));
		((Control)label1).set_MaximumSize(new Size(400, 50));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(22, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("C:\\");
		((Control)progressBar1).set_Location(new Point(20, 218));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(498, 23));
		((Control)progressBar1).set_TabIndex(1);
		((Control)explorerTreeView1).set_Location(new Point(20, 13));
		((Control)explorerTreeView1).set_Name("explorerTreeView1");
		((Control)explorerTreeView1).set_Size(new Size(498, 199));
		((Control)explorerTreeView1).set_TabIndex(5);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("ScanControl");
		((Control)this).set_Size(new Size(703, 282));
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)panel5).ResumeLayout(false);
		((Control)panel5).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void method_0()
	{
		int num = ((list_0.Count > 1000) ? 1000 : list_0.Count);
		if (num > 0)
		{
			double num2 = int_0 * 100 / num;
			if (num2 >= 100.0)
			{
				method_1();
				return;
			}
			method_5((int)num2);
		}
		if (int_0 < num && bool_0)
		{
			int length = 90;
			string text = list_0[int_0];
			if (text.Length > 90)
			{
				text = text.Substring(0, length);
			}
			method_6("label1", text + "...");
		}
		int_0++;
	}

	private void method_1()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		bool_0 = false;
		method_6("label1", "Scan complete.");
		method_6("label2", "Warning! Multiple threats detected.\nActivate now to remove threats.");
		QuickScanResultDialog quickScanResultDialog = new QuickScanResultDialog(list_0);
		((Control)quickScanResultDialog).BringToFront();
		((Form)quickScanResultDialog).set_TopMost(true);
		((Form)quickScanResultDialog).set_StartPosition((FormStartPosition)1);
		((Form)quickScanResultDialog).ShowDialog();
		if (quickScanResultDialog.bool_0)
		{
			method_2();
		}
		method_3();
	}

	private void method_2()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if (((Control)this).get_Parent().get_InvokeRequired())
		{
			((Control)this).get_Parent().Invoke((Delegate)new MethodInvoker(method_2));
		}
		else if (Thread.CurrentThread.ApartmentState == ApartmentState.STA)
		{
			ActivateForm activateForm = new ActivateForm();
			((Control)activateForm).Show();
		}
	}

	private void method_3()
	{
		if (((Control)btnScan).get_InvokeRequired())
		{
			((Control)btnScan).Invoke((Delegate)new Delegate2(method_3));
		}
		else
		{
			method_4();
		}
	}

	private void method_4()
	{
		if (((Control)this).get_Visible())
		{
			bool_0 = false;
			explorerTreeView1.list_0.Clear();
			explorerTreeView1.method_0();
			list_0.Clear();
			((Control)explorerTreeView1).Refresh();
			progressBar1.set_Value(0);
			((Control)label1).set_Text("Select files.");
			((Control)label2).set_Text(string.Empty);
			((Control)btnScan).set_Enabled(true);
			((Control)btnRemove).set_Enabled(false);
			((Control)btnStop).set_Enabled(false);
			((Control)panel1).Invalidate();
			progressBar1.set_Value(0);
			((Control)progressBar1).Invalidate();
			((Control)panel1).Refresh();
			int_0 = 0;
		}
	}

	public void method_5(int int_1)
	{
		if (((Control)progressBar1).get_InvokeRequired())
		{
			Delegate1 @delegate = method_5;
			((Control)progressBar1).Invoke((Delegate)@delegate, new object[1] { int_1 });
		}
		else if ((double)int_1 <= 100.0)
		{
			progressBar1.set_Value(int_1);
		}
	}

	public void method_6(string string_0, string string_1)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		try
		{
			Label val = (Label)((Control)panel1).get_Controls().get_Item(string_0);
			if (((Control)val).get_InvokeRequired())
			{
				Delegate0 @delegate = method_6;
				((Control)val).Invoke((Delegate)@delegate, new object[2] { string_0, string_1 });
			}
			else
			{
				((Control)val).set_Text(string_1);
			}
		}
		catch
		{
		}
	}

	private void btnRemove_Click(object sender, EventArgs e)
	{
		NotActivated notActivated = new NotActivated();
		((Control)notActivated).Show();
	}

	private void method_7()
	{
		if (list_1.Count <= 0)
		{
			return;
		}
		for (int i = 0; i < list_1.Count; i++)
		{
			try
			{
				string path = list_1[i];
				list_0.AddRange(Directory.GetFiles(path, "*.*", SearchOption.AllDirectories));
			}
			catch
			{
			}
		}
		if (list_0.Count > 0)
		{
			int num = new Random().Next(Class6.int_5, Class6.int_6);
			do
			{
				num = new Random().Next(Class6.int_5, Class6.int_6);
				Thread.Sleep(num);
				method_0();
			}
			while (progressBar1.get_Value() != progressBar1.get_Maximum() && bool_0);
		}
	}

	private void btnScan_Click(object sender, EventArgs e)
	{
		((Control)explorerTreeView1).Refresh();
		list_1 = explorerTreeView1.list_0;
		if (list_1.Count > 0)
		{
			((Control)btnScan).set_Enabled(false);
			((Control)btnRemove).set_Enabled(true);
			((Control)btnStop).set_Enabled(true);
			bool_0 = true;
			((Control)label2).set_Text(string.Empty);
		}
		Thread thread = new Thread(method_7);
		thread.Start();
	}

	private void panel1_VisibleChanged(object sender, EventArgs e)
	{
		if (((Control)this).get_Visible())
		{
			explorerTreeView1.list_0.Clear();
			progressBar1.set_Value(0);
			((Control)label1).set_Text("Select files.");
			((Control)label2).set_Text(string.Empty);
			((Control)btnScan).set_Enabled(true);
		}
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		method_4();
	}
}
