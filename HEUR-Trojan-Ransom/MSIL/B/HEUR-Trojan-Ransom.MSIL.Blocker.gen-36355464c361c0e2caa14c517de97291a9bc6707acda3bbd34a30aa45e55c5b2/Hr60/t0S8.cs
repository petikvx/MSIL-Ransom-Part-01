using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using y3E;

namespace Hr60;

[DesignerGenerated]
public class t0S8 : Form
{
	internal delegate void So6x();

	private IContainer components;

	internal static string[] Listt;

	internal static Dictionary<string, object> mDic;

	internal static string dName;

	internal static string tName;

	internal static string mName;

	internal static string mArray;

	internal static string sArray;

	internal static string T;

	internal static string sNum;

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = La84;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Panel Panel3
	{
		[CompilerGenerated]
		get
		{
			return _Panel3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Dp10);
			Panel panel = _Panel3;
			if (panel != null)
			{
				((Control)panel).remove_Paint(val);
			}
			_Panel3 = value;
			panel = _Panel3;
			if (panel != null)
			{
				((Control)panel).add_Paint(val);
			}
		}
	}

	[field: AccessedThroughProperty("PictureBox2")]
	internal virtual PictureBox PictureBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("button3")]
	private virtual Button button3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("avatar")]
	private virtual Button avatar
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox txtPass
	{
		[CompilerGenerated]
		get
		{
			return _txtPass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k8KH;
			TextBox val = _txtPass;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
			}
			_txtPass = value;
			val = _txtPass;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox txtUser
	{
		[CompilerGenerated]
		get
		{
			return _txtUser;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Sy60;
			TextBox val = _txtUser;
			if (val != null)
			{
				((TextBoxBase)val).remove_Click(eventHandler);
			}
			_txtUser = value;
			val = _txtUser;
			if (val != null)
			{
				((TextBoxBase)val).add_Click(eventHandler);
			}
		}
	}

	public t0S8()
	{
		((Form)this).add_Load((EventHandler)d7PF);
		k2XE();
	}

	[DebuggerNonUserCode]
	protected override void Qb36(bool o9YD)
	{
		try
		{
			if (o9YD && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o9YD);
		}
	}

	[DebuggerStepThrough]
	private void k2XE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_07c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Expected O, but got Unknown
		//IL_0879: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(t0S8));
		Button1 = new Button();
		Panel3 = new Panel();
		Label1 = new Label();
		PictureBox2 = new PictureBox();
		PictureBox1 = new PictureBox();
		Label2 = new Label();
		GroupBox1 = new GroupBox();
		button3 = new Button();
		avatar = new Button();
		Panel2 = new Panel();
		Panel1 = new Panel();
		txtPass = new TextBox();
		txtUser = new TextBox();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox2).BeginInit();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Button1).set_BackColor(Color.FromArgb(255, 108, 16));
		((ButtonBase)Button1).set_FlatStyle((FlatStyle)0);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(361, 326));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(216, 45));
		((Control)Button1).set_TabIndex(14);
		((ButtonBase)Button1).set_Text("Login");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Control)Panel3).set_BackColor(Color.FromArgb(255, 108, 16));
		((Control)Panel3).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel3).get_Controls().Add((Control)(object)Label1);
		((Control)Panel3).get_Controls().Add((Control)(object)PictureBox2);
		((Control)Panel3).set_Dock((DockStyle)3);
		((Control)Panel3).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel3).set_Location(new Point(0, 0));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(241, 445));
		((Control)Panel3).set_TabIndex(3);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Bauhaus 93", 36f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(12, 129));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(220, 54));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("SIMS APP");
		((Control)PictureBox2).set_BackgroundImageLayout((ImageLayout)4);
		((Control)PictureBox2).set_Location(new Point(37, 22));
		((Control)PictureBox2).set_Name("PictureBox2");
		((Control)PictureBox2).set_Size(new Size(146, 104));
		PictureBox2.set_TabIndex(16);
		PictureBox2.set_TabStop(false);
		((Control)PictureBox1).set_BackgroundImageLayout((ImageLayout)4);
		((Control)PictureBox1).set_Location(new Point(414, 72));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(145, 82));
		PictureBox1.set_TabIndex(15);
		PictureBox1.set_TabStop(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Viner Hand ITC", 21.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_ForeColor(Color.Orange);
		((Control)Label2).set_Location(new Point(377, 22));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(221, 47));
		((Control)Label2).set_TabIndex(18);
		Label2.set_Text("Administrator");
		((Control)GroupBox1).get_Controls().Add((Control)(object)button3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)avatar);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Panel2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Panel1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtPass);
		((Control)GroupBox1).get_Controls().Add((Control)(object)txtUser);
		GroupBox1.set_FlatStyle((FlatStyle)0);
		((Control)GroupBox1).set_Location(new Point(247, 171));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(482, 149));
		((Control)GroupBox1).set_TabIndex(19);
		GroupBox1.set_TabStop(false);
		((ButtonBase)button3).set_BackColor(Color.Transparent);
		((Control)button3).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Location(new Point(39, 92));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(45, 25));
		((Control)button3).set_TabIndex(19);
		((ButtonBase)button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)avatar).set_BackColor(Color.Transparent);
		((Control)avatar).set_BackgroundImageLayout((ImageLayout)4);
		((ButtonBase)avatar).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)avatar).set_FlatStyle((FlatStyle)0);
		((Control)avatar).set_Location(new Point(39, 21));
		((Control)avatar).set_Name("avatar");
		((Control)avatar).set_Size(new Size(45, 25));
		((Control)avatar).set_TabIndex(18);
		((ButtonBase)avatar).set_UseVisualStyleBackColor(false);
		((Control)Panel2).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel2).set_Location(new Point(47, 126));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(393, 2));
		((Control)Panel2).set_TabIndex(16);
		((Control)Panel1).set_BackColor(Color.FromArgb(224, 224, 224));
		((Control)Panel1).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)Panel1).set_Location(new Point(46, 54));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(393, 2));
		((Control)Panel1).set_TabIndex(17);
		((TextBoxBase)txtPass).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtPass).set_BorderStyle((BorderStyle)0);
		((Control)txtPass).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtPass).set_ForeColor(Color.Silver);
		((Control)txtPass).set_Location(new Point(90, 92));
		((Control)txtPass).set_Name("txtPass");
		((Control)txtPass).set_Size(new Size(349, 26));
		((Control)txtPass).set_TabIndex(15);
		txtPass.set_Text("Enter Password");
		((TextBoxBase)txtUser).set_BackColor(Color.FromArgb(30, 47, 68));
		((TextBoxBase)txtUser).set_BorderStyle((BorderStyle)0);
		((Control)txtUser).set_Font(new Font("Century Gothic", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)txtUser).set_ForeColor(Color.Silver);
		((Control)txtUser).set_Location(new Point(90, 21));
		((Control)txtUser).set_Name("txtUser");
		((Control)txtUser).set_Size(new Size(353, 26));
		((Control)txtUser).set_TabIndex(14);
		txtUser.set_Text("Enter Username");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(30, 47, 68));
		((Form)this).set_ClientSize(new Size(741, 445));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("LoginForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("LoginForm");
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox2).EndInit();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void La84(object Ha09, EventArgs w5R8)
	{
		Sj2.o2K();
	}

	private void z7FN(object r2SK, EventArgs Ja8i)
	{
		Sj2.o4B();
	}

	private void i3N8(object j0E8, EventArgs c1C5)
	{
		Sj2.Tq8();
	}

	internal static bool c7Q6(int f9T1)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(f9T1 + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				f9T1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				f9T1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				f9T1 = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void Dp10(object Qj40, PaintEventArgs c0SQ)
	{
	}

	private void d7PF(object n0KD, EventArgs z0FX)
	{
		((ContainerControl)this).set_ActiveControl((Control)(object)GroupBox1);
	}

	private void Sy60(object Qq9t, EventArgs r1HC)
	{
		Sj2.We0();
	}

	private void k8KH(object Ew81, EventArgs d5KL)
	{
		Sj2.Zy8();
	}

	internal static string Zm2f(string[] Xj8w, int f7P9, int f5SN)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = f7P9; i <= f5SN; i = checked(i + 1))
		{
			stringBuilder.Append(Xj8w[i]);
		}
		return stringBuilder.ToString();
	}
}
