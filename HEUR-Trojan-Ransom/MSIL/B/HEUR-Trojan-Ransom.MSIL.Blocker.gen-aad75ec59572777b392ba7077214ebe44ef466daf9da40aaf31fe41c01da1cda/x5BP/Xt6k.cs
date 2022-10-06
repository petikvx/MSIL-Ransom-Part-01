using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;
using r8C;

namespace x5BP;

[DesignerGenerated]
public class Xt6k : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10904)]
	private struct m9KJ
	{
	}

	private TextBox _TxtPass;

	private TextBox _TxtPassw;

	private TextBox _TxtEmail;

	private Button _btnCreate;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox4;

	private SqlDataAdapter Sqlda;

	private DataSet Sqlds;

	private static readonly object y;

	private static readonly Array a;

	private static readonly object J;

	internal static byte n/* Not supported: data(00) */;

	internal IContainer U;

	internal Label b;

	internal Label P;

	internal Label J;

	internal Label s;

	internal TextBox D;

	internal Button n;

	internal PictureBox O;

	internal Label I;

	internal TextBox x;

	internal SqlConnection A;

	internal SqlCommand e;

	public Xt6k()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)k0C6);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = (A = val);
		SqlCommand val3 = (e = new SqlCommand());
		Sqlda = new SqlDataAdapter();
		Sqlds = new DataSet();
		Mb68();
	}

	protected override void Yi7n(bool e1PS)
	{
		try
		{
			if (e1PS && U != null)
			{
				U.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e1PS);
		}
	}

	private void Mb68()
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
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0356: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0490: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_053b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_068d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0697: Expected O, but got Unknown
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_0753: Expected O, but got Unknown
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0909: Unknown result type (might be due to invalid IL or missing references)
		//IL_0913: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a48: Expected O, but got Unknown
		//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae9: Expected O, but got Unknown
		//IL_0b7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b86: Expected O, but got Unknown
		//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ccf: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Xt6k));
		o3C6(new Label());
		o8KP(new Label());
		w9DY(new Label());
		Tr41(new Label());
		p7LX(new TextBox());
		x0XA(new TextBox());
		Xb40(new TextBox());
		Go24(new TextBox());
		j9DB(new Button());
		e1CL(new Button());
		e4X3(new PictureBox());
		Jj1n(new PictureBox());
		f9M0(new PictureBox());
		p9WS(new PictureBox());
		s9P2(new TextBox());
		Qm0z(new Label());
		((ISupportInitialize)Nr0i()).BeginInit();
		((ISupportInitialize)m0SY()).BeginInit();
		((ISupportInitialize)Fw2a()).BeginInit();
		((ISupportInitialize)n8A4()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)n9EN()).set_Anchor((AnchorStyles)15);
		n9EN().set_AutoSize(true);
		((Control)n9EN()).set_BackColor(Color.Transparent);
		((Control)n9EN()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)n9EN()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)n9EN()).set_Location(new Point(87, 167));
		((Control)n9EN()).set_Name("Label2");
		((Control)n9EN()).set_Size(new Size(158, 19));
		((Control)n9EN()).set_TabIndex(8);
		n9EN().set_Text("Enter your UserName :");
		((Control)Wp91()).set_Anchor((AnchorStyles)15);
		Wp91().set_AutoSize(true);
		((Control)Wp91()).set_BackColor(Color.Transparent);
		((Control)Wp91()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Wp91()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Wp91()).set_Location(new Point(95, 208));
		((Control)Wp91()).set_Name("Label3");
		((Control)Wp91()).set_Size(new Size(150, 19));
		((Control)Wp91()).set_TabIndex(9);
		Wp91().set_Text("Enter your Password :");
		((Control)r0L2()).set_Anchor((AnchorStyles)15);
		r0L2().set_AutoSize(true);
		((Control)r0L2()).set_BackColor(Color.Transparent);
		((Control)r0L2()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)r0L2()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)r0L2()).set_Location(new Point(80, 250));
		((Control)r0L2()).set_Name("Label4");
		((Control)r0L2()).set_Size(new Size(165, 19));
		((Control)r0L2()).set_TabIndex(10);
		r0L2().set_Text("Confirm your Password :");
		((Control)x5CR()).set_Anchor((AnchorStyles)15);
		x5CR().set_AutoSize(true);
		((Control)x5CR()).set_BackColor(Color.Transparent);
		((Control)x5CR()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)x5CR()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)x5CR()).set_Location(new Point(109, 296));
		((Control)x5CR()).set_Name("Label5");
		((Control)x5CR()).set_Size(new Size(136, 19));
		((Control)x5CR()).set_TabIndex(11);
		x5CR().set_Text("Enter your E-Mail :");
		((Control)t7Z3()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)t7Z3()).set_BackColor(Color.Azure);
		((Control)t7Z3()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)t7Z3()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)t7Z3()).set_Location(new Point(278, 164));
		((Control)t7Z3()).set_Name("TxtUser");
		((Control)t7Z3()).set_Size(new Size(162, 22));
		((Control)t7Z3()).set_TabIndex(1);
		((Control)Np04()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Np04()).set_BackColor(Color.Azure);
		((Control)Np04()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Np04()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Np04()).set_Location(new Point(278, 206));
		((Control)Np04()).set_Name("TxtPass");
		Np04().set_PasswordChar('•');
		((Control)Np04()).set_Size(new Size(162, 22));
		((Control)Np04()).set_TabIndex(2);
		((Control)Hn46()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)Hn46()).set_BackColor(Color.Azure);
		((Control)Hn46()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Hn46()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Hn46()).set_Location(new Point(278, 248));
		((Control)Hn46()).set_Name("TxtPassw");
		Hn46().set_PasswordChar('•');
		((Control)Hn46()).set_Size(new Size(162, 22));
		((Control)Hn46()).set_TabIndex(3);
		((Control)w5HM()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)w5HM()).set_BackColor(Color.Azure);
		((Control)w5HM()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)w5HM()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)w5HM()).set_Location(new Point(278, 293));
		((Control)w5HM()).set_Name("TxtEmail");
		((Control)w5HM()).set_Size(new Size(191, 22));
		((Control)w5HM()).set_TabIndex(4);
		((Control)m1JT()).set_Anchor((AnchorStyles)15);
		((ButtonBase)m1JT()).set_BackColor(Color.Transparent);
		((ButtonBase)m1JT()).set_FlatStyle((FlatStyle)1);
		((Control)m1JT()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)m1JT()).set_ForeColor(Color.Navy);
		((Control)m1JT()).set_Location(new Point(128, 353));
		((Control)m1JT()).set_Name("btnCreate");
		((Control)m1JT()).set_Size(new Size(98, 25));
		((Control)m1JT()).set_TabIndex(5);
		((ButtonBase)m1JT()).set_Text("&CREATE");
		((ButtonBase)m1JT()).set_UseVisualStyleBackColor(false);
		((Control)m7T9()).set_Anchor((AnchorStyles)15);
		((ButtonBase)m7T9()).set_BackColor(Color.Transparent);
		((ButtonBase)m7T9()).set_FlatStyle((FlatStyle)1);
		((Control)m7T9()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)m7T9()).set_ForeColor(Color.Navy);
		((Control)m7T9()).set_Location(new Point(342, 353));
		((Control)m7T9()).set_Name("btnExit");
		((Control)m7T9()).set_Size(new Size(98, 25));
		((Control)m7T9()).set_TabIndex(6);
		((ButtonBase)m7T9()).set_Text("&EXIT");
		((ButtonBase)m7T9()).set_UseVisualStyleBackColor(false);
		((Control)Nr0i()).set_Anchor((AnchorStyles)15);
		((Control)Nr0i()).set_BackColor(Color.Transparent);
		((Control)Nr0i()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Nr0i()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Nr0i()).set_Location(new Point(3, 1));
		((Control)Nr0i()).set_Name("PictureBox1");
		((Control)Nr0i()).set_Size(new Size(110, 90));
		Nr0i().set_TabIndex(11);
		Nr0i().set_TabStop(false);
		((Control)m0SY()).set_Anchor((AnchorStyles)15);
		((Control)m0SY()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)m0SY()).set_Location(new Point(173, 26));
		((Control)m0SY()).set_Name("PictureBox2");
		((Control)m0SY()).set_Size(new Size(257, 50));
		m0SY().set_TabIndex(12);
		m0SY().set_TabStop(false);
		((Control)Fw2a()).set_Anchor((AnchorStyles)15);
		((Control)Fw2a()).set_BackColor(Color.Transparent);
		((Control)Fw2a()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox3.BackgroundImage"));
		((Control)Fw2a()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Fw2a()).set_Location(new Point(80, 339));
		((Control)Fw2a()).set_Name("PictureBox3");
		((Control)Fw2a()).set_Size(new Size(52, 49));
		Fw2a().set_TabIndex(13);
		Fw2a().set_TabStop(false);
		((Control)n8A4()).set_Anchor((AnchorStyles)15);
		((Control)n8A4()).set_BackColor(Color.Transparent);
		((Control)n8A4()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox4.BackgroundImage"));
		((Control)n8A4()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)n8A4()).set_Location(new Point(302, 347));
		((Control)n8A4()).set_Name("PictureBox4");
		((Control)n8A4()).set_Size(new Size(47, 41));
		n8A4().set_TabIndex(14);
		n8A4().set_TabStop(false);
		((Control)b4DM()).set_Anchor((AnchorStyles)15);
		((TextBoxBase)b4DM()).set_BackColor(Color.Azure);
		((Control)b4DM()).set_Font(new Font("Calibri", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)b4DM()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)b4DM()).set_Location(new Point(278, 123));
		((Control)b4DM()).set_Name("TxtID");
		((Control)b4DM()).set_Size(new Size(71, 22));
		((Control)b4DM()).set_TabIndex(0);
		((Control)r3QF()).set_Anchor((AnchorStyles)15);
		r3QF().set_AutoSize(true);
		((Control)r3QF()).set_BackColor(Color.Transparent);
		((Control)r3QF()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)r3QF()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)r3QF()).set_Location(new Point(106, 126));
		((Control)r3QF()).set_Name("Label1");
		((Control)r3QF()).set_Size(new Size(139, 19));
		((Control)r3QF()).set_TabIndex(7);
		r3QF().set_Text("Enter your UserID :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(519, 390));
		((Control)this).get_Controls().Add((Control)(object)b4DM());
		((Control)this).get_Controls().Add((Control)(object)r3QF());
		((Control)this).get_Controls().Add((Control)(object)n8A4());
		((Control)this).get_Controls().Add((Control)(object)Fw2a());
		((Control)this).get_Controls().Add((Control)(object)m0SY());
		((Control)this).get_Controls().Add((Control)(object)Nr0i());
		((Control)this).get_Controls().Add((Control)(object)m7T9());
		((Control)this).get_Controls().Add((Control)(object)m1JT());
		((Control)this).get_Controls().Add((Control)(object)w5HM());
		((Control)this).get_Controls().Add((Control)(object)Hn46());
		((Control)this).get_Controls().Add((Control)(object)Np04());
		((Control)this).get_Controls().Add((Control)(object)t7Z3());
		((Control)this).get_Controls().Add((Control)(object)x5CR());
		((Control)this).get_Controls().Add((Control)(object)r0L2());
		((Control)this).get_Controls().Add((Control)(object)Wp91());
		((Control)this).get_Controls().Add((Control)(object)n9EN());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form8");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Create your Account");
		((ISupportInitialize)Nr0i()).EndInit();
		((ISupportInitialize)m0SY()).EndInit();
		((ISupportInitialize)Fw2a()).EndInit();
		((ISupportInitialize)n8A4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label n9EN()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3C6(Label Tz84)
	{
		Label val = (b = Tz84);
	}

	[SpecialName]
	internal virtual Label Wp91()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8KP(Label Az28)
	{
		Label val = (P = Az28);
	}

	[SpecialName]
	internal virtual Label r0L2()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9DY(Label p2QA)
	{
		Label val = (J = p2QA);
	}

	[SpecialName]
	internal virtual Label x5CR()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tr41(Label Br32)
	{
		Label val = (s = Br32);
	}

	[SpecialName]
	internal virtual TextBox t7Z3()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7LX(TextBox De10)
	{
		TextBox val = (D = De10);
	}

	[SpecialName]
	internal virtual TextBox Np04()
	{
		return _TxtPass;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0XA(TextBox j2H5)
	{
		_TxtPass = j2H5;
	}

	[SpecialName]
	internal virtual TextBox Hn46()
	{
		return _TxtPassw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb40(TextBox Ls3q)
	{
		_TxtPassw = Ls3q;
	}

	[SpecialName]
	internal virtual TextBox w5HM()
	{
		return _TxtEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go24(TextBox k5H8)
	{
		_TxtEmail = k5H8;
	}

	[SpecialName]
	internal virtual Button m1JT()
	{
		return _btnCreate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9DB(Button f8K7)
	{
		EventHandler eventHandler = w5Y3;
		Button btnCreate = _btnCreate;
		if (btnCreate != null)
		{
			((Control)btnCreate).remove_Click(eventHandler);
		}
		_btnCreate = f8K7;
		btnCreate = _btnCreate;
		if (btnCreate != null)
		{
			((Control)btnCreate).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button m7T9()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1CL(Button Mj10)
	{
		EventHandler eventHandler = Ta45;
		Button val = n;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (n = Mj10);
		val = n;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Nr0i()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4X3(PictureBox g4ME)
	{
		_PictureBox1 = g4ME;
	}

	[SpecialName]
	internal virtual PictureBox m0SY()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jj1n(PictureBox x0SM)
	{
		_PictureBox2 = x0SM;
	}

	[SpecialName]
	internal virtual PictureBox Fw2a()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9M0(PictureBox Ks0b)
	{
		PictureBox val = (O = Ks0b);
	}

	[SpecialName]
	internal virtual PictureBox n8A4()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9WS(PictureBox Ro47)
	{
		_PictureBox4 = Ro47;
	}

	[SpecialName]
	internal virtual Label r3QF()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm0z(Label q0K6)
	{
		Label val = (I = q0K6);
	}

	[SpecialName]
	internal virtual TextBox b4DM()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s9P2(TextBox p9T8)
	{
		TextBox val = (x = p9T8);
	}

	public bool Ts98()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			A.Open();
			A.Close();
			return true;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	internal static void b3EC(string Pq80)
	{
		Task.Delay(new Random().Next(1000, 5000)).Wait();
		Ya7.Pb3(Pq80);
	}

	private void k0C6(object sender, EventArgs e)
	{
	}

	private void w5Y3(object sender, EventArgs e)
	{
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		string text = Np04().get_Text();
		string text2 = Hn46().get_Text();
		if (string.Compare(text, text2) == 0)
		{
			if (A.get_State() != ConnectionState.Open)
			{
				A.Open();
			}
			try
			{
				string text3 = "INSERT INTO [login]([User ID], [UserName], [Password], [E-mail])  VALUES('" + b4DM().get_Text() + "','" + t7Z3().get_Text() + "','" + Np04().get_Text() + "','" + w5HM().get_Text() + "')";
				SqlCommand val = (this.e = new SqlCommand(text3, A));
				this.e.ExecuteNonQuery();
				A.Close();
				((Control)Db5.Forms.Ap3()).Show();
				((Form)this).Close();
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		Interaction.MsgBox((object)"Passwords Do Not match", (MsgBoxStyle)0, (object)"Error!");
		b4DM().set_Text("");
		t7Z3().set_Text("");
		Np04().set_Text("");
		Hn46().set_Text("");
		w5HM().set_Text("");
	}

	internal static string[] i7M3()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Ya7.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void Ta45(object sender, EventArgs e)
	{
		((Control)Db5.Forms.Ek3()).Show();
		((Form)this).Close();
	}

	static Xt6k()
	{
		a = new char[5452];
		char[] array = new char[8];
		array[1] = 'ᓇ';
		array[4] = 'ᒦ';
		array[6] = 'ኩ';
		array[0] = '႖';
		array[2] = '\u1ccc';
		array[3] = '\u1717';
		array[5] = 'ឳ';
		array[7] = 'ĕ';
		Xt6k.J = new string[310];
		y = array;
	}
}
