using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qm3;
using Zt6;
using r8C;
using z2C5;

namespace k3Z;

[DesignerGenerated]
public class Wg8 : Form
{
	private SqlConnection Sqlcn;

	private SqlDataAdapter da;

	private string Usr;

	private PictureBox _PictureBox1;

	private Button _CmdAdmincancel;

	private Button _CmdAdminLogin;

	private Label _UserLabel1;

	private ProgressBar _ProgressBar1;

	private PictureBox _Pic;

	internal SqlDataAdapter i;

	internal DataSet E;

	internal DataSet C;

	internal IContainer B;

	internal Timer o;

	internal PictureBox T;

	internal GroupBox j;

	internal Label w;

	internal TextBox P;

	internal TextBox V;

	internal LinkLabel n;

	internal PictureBox F;

	public Wg8()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Qt0);
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		Sqlcn = val;
		Xo6();
	}

	public bool Bo1()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Sqlcn.Open();
			Sqlcn.Close();
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

	private void Qt0(object sender, EventArgs e)
	{
		((Control)x1D()).Hide();
		((Control)Ty6()).Hide();
	}

	public void Xs1()
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		if (Sqlcn.get_State() != ConnectionState.Open)
		{
			Sqlcn.Open();
		}
		if (E != null)
		{
			E.Clear();
		}
		try
		{
			SqlCommand val = new SqlCommand("SELECT [User ID] FROM [login] WHERE UserName='" + Usr + "' ", Sqlcn);
			da = new SqlDataAdapter(val);
			DataSet dataSet = (C = new DataSet());
			((DbDataAdapter)(object)da).Fill(C);
			Sqlcn.Close();
			Gf87.UsrID = Conversions.ToString(C.Tables[0].Rows[0][0]);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void Hp7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		SqlConnection val = new SqlConnection();
		val.set_ConnectionString("Data Source=DELL;Initial Catalog=logindata;Integrated Security=True");
		SqlConnection val2 = val;
		val2.Open();
		try
		{
			string usrID = Gf87.UsrID;
			Gf87.Identity = Gf87.UsrID;
			SqlCommand val3 = new SqlCommand("CREATE TABLE[" + usrID + " ](Date VARCHAR(30), Income money, Food money, Stationary money, Clothes money, Market money, Entertainment money, Medical money, Transport money, Others money, FoodNote text, StatNote text, ClotNote text, MarkNote text, EnteNote text, MediNote text, TranNote text, OtheNote text, IncoNote text)", val2);
			val3.ExecuteNonQuery();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	public void Fn1()
	{
		((Control)Ty6()).Show();
		((Control)x1D()).Show();
		Cs2().Start();
	}

	private void Ai4(object sender, EventArgs e)
	{
		x1D().Increment(40);
		if (x1D().get_Value() == x1D().get_Maximum())
		{
			Cs2().Stop();
			x1D().set_Value(0);
			((Control)x1D()).Hide();
			((Control)Ty6()).Hide();
			d4K().set_Text("");
			Mp3().set_Text("");
			((Control)this).Hide();
		}
	}

	private void c3H(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		if (Bo1())
		{
			if (Sqlcn.get_State() != ConnectionState.Open)
			{
				Sqlcn.Open();
			}
			if (E != null)
			{
				E.Clear();
			}
			try
			{
				SqlCommand val = new SqlCommand("SELECT Count(UserName) As Usercount FROM [login]WHERE [UserName]='" + Mp3().get_Text() + "'  AND [Password] = '" + d4K().get_Text() + "' COLLATE SQL_Latin1_General_CP1_CS_AS ", Sqlcn);
				SqlDataAdapter val2 = (i = new SqlDataAdapter(val));
				DataSet dataSet = (E = new DataSet());
				((DbDataAdapter)(object)i).Fill(E);
				Sqlcn.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			if (Operators.ConditionalCompareObjectEqual(E.Tables[0].Rows[0]["Usercount"], (object)1, false))
			{
				Usr = Mp3().get_Text();
				Gf87.UsrNam = Usr;
				Xs1();
				Hp7();
				Fn1();
			}
			else
			{
				Interaction.MsgBox((object)"Invalid UserName or Password", (MsgBoxStyle)16, (object)"LOGIN FAILED");
			}
		}
	}

	[STAThread]
	public static void Xd7()
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				}
				while (!g9L.Zm9(2) || !Ya7.w8Z())
				{
				}
				Ya7.g9L(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0000_dispatch = 15;
			}
		}
	}

	private void g8G(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)Db5.Forms.Wa2()).Show();
		((Control)this).Hide();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void At0(object sender, EventArgs e)
	{
		ProjectData.EndApp();
	}

	protected override void g2F(bool Fr6)
	{
		try
		{
			if (Fr6 && B != null)
			{
				B.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Fr6);
		}
	}

	private void Xo6()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b5: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
		//IL_04c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0589: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_060d: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ba: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_075d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0767: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09db: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Expected O, but got Unknown
		//IL_0b2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b39: Expected O, but got Unknown
		IContainer container = (B = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Wg8));
		p6H(new Timer(B));
		Fc5(new PictureBox());
		p5H(new PictureBox());
		Tx0(new GroupBox());
		Dj0(new Button());
		Lp5(new Button());
		Ye5(new Label());
		e2E(new Label());
		c6C(new TextBox());
		Pg0(new TextBox());
		Ly4(new LinkLabel());
		Go0(new PictureBox());
		Ln4(new ProgressBar());
		t8H(new PictureBox());
		((ISupportInitialize)Gi2()).BeginInit();
		((ISupportInitialize)p0J()).BeginInit();
		((Control)m2B()).SuspendLayout();
		((ISupportInitialize)Jn8()).BeginInit();
		((ISupportInitialize)Ty6()).BeginInit();
		((Control)this).SuspendLayout();
		Cs2().set_Interval(1000);
		((Control)Gi2()).set_Anchor((AnchorStyles)15);
		((Control)Gi2()).set_BackColor(Color.Transparent);
		((Control)Gi2()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)Gi2()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Gi2()).set_Location(new Point(105, 12));
		((Control)Gi2()).set_Name("PictureBox1");
		((Control)Gi2()).set_Size(new Size(377, 60));
		Gi2().set_TabIndex(29);
		Gi2().set_TabStop(false);
		((Control)p0J()).set_Anchor((AnchorStyles)15);
		((Control)p0J()).set_BackColor(Color.Transparent);
		((Control)p0J()).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox2.BackgroundImage"));
		((Control)p0J()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)p0J()).set_Location(new Point(2, 1));
		((Control)p0J()).set_Name("PictureBox2");
		((Control)p0J()).set_Size(new Size(107, 83));
		p0J().set_TabIndex(33);
		p0J().set_TabStop(false);
		((Control)m2B()).set_Anchor((AnchorStyles)15);
		((Control)m2B()).set_BackColor(Color.Transparent);
		((Control)m2B()).get_Controls().Add((Control)(object)Dj8());
		((Control)m2B()).get_Controls().Add((Control)(object)Nf6());
		((Control)m2B()).get_Controls().Add((Control)(object)Zr2());
		((Control)m2B()).get_Controls().Add((Control)(object)g7D());
		((Control)m2B()).get_Controls().Add((Control)(object)d4K());
		((Control)m2B()).get_Controls().Add((Control)(object)Mp3());
		((Control)m2B()).get_Controls().Add((Control)(object)Lf0());
		((Control)m2B()).get_Controls().Add((Control)(object)Jn8());
		((Control)m2B()).set_Location(new Point(35, 90));
		((Control)m2B()).set_Name("GroupBox1");
		((Control)m2B()).set_Size(new Size(481, 202));
		((Control)m2B()).set_TabIndex(34);
		m2B().set_TabStop(false);
		((Control)Dj8()).set_Cursor(Cursors.get_Arrow());
		((Control)Dj8()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Dj8()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((ButtonBase)Dj8()).set_Image((Image)componentResourceManager.GetObject("CmdAdmincancel.Image"));
		((ButtonBase)Dj8()).set_ImageAlign((ContentAlignment)16);
		((Control)Dj8()).set_Location(new Point(338, 143));
		((Control)Dj8()).set_Margin(new Padding(4));
		((Control)Dj8()).set_Name("CmdAdmincancel");
		((Control)Dj8()).set_Size(new Size(97, 40));
		((Control)Dj8()).set_TabIndex(39);
		((ButtonBase)Dj8()).set_Text("     &Cancel");
		((ButtonBase)Dj8()).set_UseVisualStyleBackColor(true);
		((Control)Nf6()).set_Cursor(Cursors.get_Arrow());
		((Control)Nf6()).set_Font(new Font("Palatino Linotype", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Nf6()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((ButtonBase)Nf6()).set_Image((Image)componentResourceManager.GetObject("CmdAdminLogin.Image"));
		((ButtonBase)Nf6()).set_ImageAlign((ContentAlignment)16);
		((Control)Nf6()).set_Location(new Point(237, 143));
		((Control)Nf6()).set_Margin(new Padding(4));
		((Control)Nf6()).set_Name("CmdAdminLogin");
		((Control)Nf6()).set_Size(new Size(97, 40));
		((Control)Nf6()).set_TabIndex(38);
		((ButtonBase)Nf6()).set_Text("        &Login");
		((ButtonBase)Nf6()).set_UseVisualStyleBackColor(true);
		Zr2().set_AutoSize(true);
		((Control)Zr2()).set_BackColor(Color.Transparent);
		((Control)Zr2()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Zr2()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Zr2()).set_Location(new Point(236, 76));
		((Control)Zr2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Zr2()).set_Name("UserLabel2");
		((Control)Zr2()).set_Size(new Size(86, 23));
		((Control)Zr2()).set_TabIndex(37);
		Zr2().set_Text("Password :");
		g7D().set_AutoSize(true);
		((Control)g7D()).set_BackColor(Color.Transparent);
		((Control)g7D()).set_Font(new Font("Comic Sans MS", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g7D()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)g7D()).set_Location(new Point(236, 16));
		((Control)g7D()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)g7D()).set_Name("UserLabel1");
		((Control)g7D()).set_Size(new Size(100, 23));
		((Control)g7D()).set_TabIndex(36);
		g7D().set_Text("User Name :");
		((TextBoxBase)d4K()).set_BackColor(Color.Azure);
		((Control)d4K()).set_Font(new Font("Palatino Linotype", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)d4K()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)d4K()).set_Location(new Point(237, 103));
		((Control)d4K()).set_Margin(new Padding(4));
		((Control)d4K()).set_Name("TxtPassword");
		d4K().set_PasswordChar('•');
		((Control)d4K()).set_Size(new Size(200, 25));
		((Control)d4K()).set_TabIndex(35);
		((TextBoxBase)Mp3()).set_BackColor(Color.Azure);
		((Control)Mp3()).set_Font(new Font("Comic Sans MS", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)Mp3()).set_ForeColor(Color.FromArgb(0, 64, 0));
		((Control)Mp3()).set_Location(new Point(235, 43));
		((Control)Mp3()).set_Margin(new Padding(4));
		((Control)Mp3()).set_Name("TxtUserName");
		((Control)Mp3()).set_Size(new Size(200, 26));
		((Control)Mp3()).set_TabIndex(34);
		((Control)Lf0()).set_BackColor(Color.Transparent);
		((Control)Lf0()).set_Cursor(Cursors.get_Hand());
		((Control)Lf0()).set_Font(new Font("Calibri", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Lf0()).set_Location(new Point(37, 166));
		((Control)Lf0()).set_Name("LinkLabel1");
		((Control)Lf0()).set_Size(new Size(124, 24));
		((Control)Lf0()).set_TabIndex(33);
		Lf0().set_TabStop(true);
		Lf0().set_Text("Create an Account");
		((Label)Lf0()).set_TextAlign((ContentAlignment)32);
		((Control)Jn8()).set_BackColor(Color.Transparent);
		Jn8().set_ErrorImage((Image)null);
		Jn8().set_Image((Image)componentResourceManager.GetObject("UserPictureBox.Image"));
		((Control)Jn8()).set_Location(new Point(29, 20));
		((Control)Jn8()).set_Margin(new Padding(4));
		((Control)Jn8()).set_Name("UserPictureBox");
		((Control)Jn8()).set_Size(new Size(132, 139));
		Jn8().set_SizeMode((PictureBoxSizeMode)1);
		Jn8().set_TabIndex(32);
		Jn8().set_TabStop(false);
		((Control)x1D()).set_Anchor((AnchorStyles)15);
		((Control)x1D()).set_Location(new Point(146, 319));
		((Control)x1D()).set_Name("ProgressBar1");
		((Control)x1D()).set_Size(new Size(292, 23));
		x1D().set_Style((ProgressBarStyle)1);
		((Control)x1D()).set_TabIndex(32);
		((Control)x1D()).set_Visible(false);
		((Control)Ty6()).set_Anchor((AnchorStyles)15);
		((Control)Ty6()).set_BackColor(Color.Transparent);
		((Control)Ty6()).set_BackgroundImage((Image)componentResourceManager.GetObject("Pic.BackgroundImage"));
		((Control)Ty6()).set_BackgroundImageLayout((ImageLayout)3);
		Ty6().set_Image((Image)componentResourceManager.GetObject("Pic.Image"));
		((Control)Ty6()).set_Location(new Point(75, 306));
		((Control)Ty6()).set_Name("Pic");
		((Control)Ty6()).set_Size(new Size(52, 50));
		Ty6().set_SizeMode((PictureBoxSizeMode)1);
		Ty6().set_TabIndex(35);
		Ty6().set_TabStop(false);
		((Control)Ty6()).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(555, 368));
		((Control)this).get_Controls().Add((Control)(object)Ty6());
		((Control)this).get_Controls().Add((Control)(object)m2B());
		((Control)this).get_Controls().Add((Control)(object)p0J());
		((Control)this).get_Controls().Add((Control)(object)Gi2());
		((Control)this).get_Controls().Add((Control)(object)x1D());
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Login");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Login");
		((ISupportInitialize)Gi2()).EndInit();
		((ISupportInitialize)p0J()).EndInit();
		((Control)m2B()).ResumeLayout(false);
		((Control)m2B()).PerformLayout();
		((ISupportInitialize)Jn8()).EndInit();
		((ISupportInitialize)Ty6()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Timer Cs2()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6H(Timer c9B)
	{
		EventHandler eventHandler = Ai4;
		Timer val = o;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		Timer val2 = (o = c9B);
		val = o;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Gi2()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fc5(PictureBox p1B)
	{
		_PictureBox1 = p1B;
	}

	[SpecialName]
	internal virtual PictureBox p0J()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5H(PictureBox w5X)
	{
		PictureBox val = (T = w5X);
	}

	[SpecialName]
	internal virtual GroupBox m2B()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tx0(GroupBox c1X)
	{
		GroupBox val = (j = c1X);
	}

	[SpecialName]
	internal virtual Button Dj8()
	{
		return _CmdAdmincancel;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dj0(Button Ld2)
	{
		EventHandler eventHandler = At0;
		Button cmdAdmincancel = _CmdAdmincancel;
		if (cmdAdmincancel != null)
		{
			((Control)cmdAdmincancel).remove_Click(eventHandler);
		}
		_CmdAdmincancel = Ld2;
		cmdAdmincancel = _CmdAdmincancel;
		if (cmdAdmincancel != null)
		{
			((Control)cmdAdmincancel).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Nf6()
	{
		return _CmdAdminLogin;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp5(Button Re1)
	{
		EventHandler eventHandler = c3H;
		Button cmdAdminLogin = _CmdAdminLogin;
		if (cmdAdminLogin != null)
		{
			((Control)cmdAdminLogin).remove_Click(eventHandler);
		}
		_CmdAdminLogin = Re1;
		cmdAdminLogin = _CmdAdminLogin;
		if (cmdAdminLogin != null)
		{
			((Control)cmdAdminLogin).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Zr2()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ye5(Label b1L)
	{
		Label val = (w = b1L);
	}

	[SpecialName]
	internal virtual Label g7D()
	{
		return _UserLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2E(Label Gx3)
	{
		_UserLabel1 = Gx3;
	}

	[SpecialName]
	internal virtual TextBox d4K()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6C(TextBox Qs9)
	{
		TextBox val = (P = Qs9);
	}

	[SpecialName]
	internal virtual TextBox Mp3()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg0(TextBox Hr9)
	{
		TextBox val = (V = Hr9);
	}

	[SpecialName]
	internal virtual LinkLabel Lf0()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ly4(LinkLabel x5W)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(g8G);
		LinkLabel val2 = n;
		if (val2 != null)
		{
			val2.remove_LinkClicked(val);
		}
		LinkLabel val3 = (n = x5W);
		val2 = n;
		if (val2 != null)
		{
			val2.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual PictureBox Jn8()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go0(PictureBox y3P)
	{
		PictureBox val = (F = y3P);
	}

	[SpecialName]
	internal virtual ProgressBar x1D()
	{
		return _ProgressBar1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln4(ProgressBar Wm6)
	{
		_ProgressBar1 = Wm6;
	}

	[SpecialName]
	internal virtual PictureBox Ty6()
	{
		return _Pic;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8H(PictureBox Ke0)
	{
		_Pic = Ke0;
	}
}
