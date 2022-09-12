using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cq2e;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xy3m;
using z1F4;
using z2SR;

namespace t4AQ;

[DesignerGenerated]
public class Tb17 : Form
{
	private Label _Label1;

	private GroupBox _GroupBox1;

	private PictureBox _PictureBox1;

	private Button _Button1;

	private ErrorProvider _ErrorProvider1;

	public int count;

	internal IContainer I;

	internal Label W;

	internal TextBox D;

	internal TextBox v;

	internal GroupBox s;

	internal ToolTip f;

	public Tb17()
	{
		((Form)this).add_Load((EventHandler)Qw4s);
		Af89();
	}

	protected override void Wm01(bool Li95)
	{
		try
		{
			if (Li95 && I != null)
			{
				I.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Li95);
		}
	}

	private void Af89()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
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
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		IContainer container = (I = new Container());
		Ns30(new Label());
		Tk90(new Label());
		e4SW(new TextBox());
		Ro5w(new TextBox());
		Fs83(new GroupBox());
		Br59(new Button());
		Jf6n(new GroupBox());
		Ke6r(new ToolTip(I));
		Lm48(new ErrorProvider(I));
		o5NL(new PictureBox());
		((Control)Xw92()).SuspendLayout();
		((Control)g6PB()).SuspendLayout();
		((ISupportInitialize)p8X3()).BeginInit();
		((ISupportInitialize)m4Y2()).BeginInit();
		((Control)this).SuspendLayout();
		Bt85().set_AutoSize(true);
		((Control)Bt85()).set_Location(new Point(19, 32));
		((Control)Bt85()).set_Name("Label1");
		((Control)Bt85()).set_Size(new Size(60, 13));
		((Control)Bt85()).set_TabIndex(0);
		Bt85().set_Text("User Name");
		En5g().set_AutoSize(true);
		((Control)En5g()).set_Location(new Point(22, 70));
		((Control)En5g()).set_Name("Label2");
		((Control)En5g()).set_Size(new Size(53, 13));
		((Control)En5g()).set_TabIndex(1);
		En5g().set_Text("Password");
		((Control)Fg36()).set_Location(new Point(107, 29));
		((Control)Fg36()).set_Name("TextBox1");
		((Control)Fg36()).set_Size(new Size(152, 20));
		((Control)Fg36()).set_TabIndex(2);
		((Control)w6T1()).set_Location(new Point(107, 67));
		((Control)w6T1()).set_Name("TextBox2");
		w6T1().set_PasswordChar('*');
		((Control)w6T1()).set_Size(new Size(152, 20));
		((Control)w6T1()).set_TabIndex(3);
		((Control)Xw92()).get_Controls().Add((Control)(object)y0PQ());
		((Control)Xw92()).get_Controls().Add((Control)(object)w6T1());
		((Control)Xw92()).get_Controls().Add((Control)(object)Fg36());
		((Control)Xw92()).get_Controls().Add((Control)(object)En5g());
		((Control)Xw92()).get_Controls().Add((Control)(object)Bt85());
		((Control)Xw92()).set_Location(new Point(182, 10));
		((Control)Xw92()).set_Name("GroupBox1");
		((Control)Xw92()).set_Size(new Size(290, 178));
		((Control)Xw92()).set_TabIndex(7);
		Xw92().set_TabStop(false);
		((Control)y0PQ()).set_Location(new Point(73, 116));
		((Control)y0PQ()).set_Name("Button1");
		((Control)y0PQ()).set_Size(new Size(144, 31));
		((Control)y0PQ()).set_TabIndex(4);
		((ButtonBase)y0PQ()).set_Text("Login");
		((ButtonBase)y0PQ()).set_UseVisualStyleBackColor(true);
		((Control)g6PB()).get_Controls().Add((Control)(object)m4Y2());
		((Control)g6PB()).get_Controls().Add((Control)(object)Xw92());
		((Control)g6PB()).set_Location(new Point(6, 1));
		((Control)g6PB()).set_Name("GroupBox2");
		((Control)g6PB()).set_Size(new Size(482, 202));
		((Control)g6PB()).set_TabIndex(9);
		g6PB().set_TabStop(false);
		p8X3().set_ContainerControl((ContainerControl)(object)this);
		((Control)m4Y2()).set_Location(new Point(15, 19));
		((Control)m4Y2()).set_Name("PictureBox1");
		((Control)m4Y2()).set_Size(new Size(159, 170));
		m4Y2().set_SizeMode((PictureBoxSizeMode)1);
		m4Y2().set_TabIndex(8);
		m4Y2().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(494, 207));
		((Control)this).get_Controls().Add((Control)(object)g6PB());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Admin Login");
		((Control)Xw92()).ResumeLayout(false);
		((Control)Xw92()).PerformLayout();
		((Control)g6PB()).ResumeLayout(false);
		((ISupportInitialize)p8X3()).EndInit();
		((ISupportInitialize)m4Y2()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Label Bt85()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns30(Label q6Y1)
	{
		_Label1 = q6Y1;
	}

	[SpecialName]
	internal virtual Label En5g()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tk90(Label Ln4f)
	{
		Label val = (W = Ln4f);
	}

	[SpecialName]
	internal virtual TextBox Fg36()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4SW(TextBox Td9j)
	{
		TextBox val = (D = Td9j);
	}

	[SpecialName]
	internal virtual TextBox w6T1()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ro5w(TextBox b5CY)
	{
		TextBox val = (v = b5CY);
	}

	[SpecialName]
	internal virtual GroupBox Xw92()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs83(GroupBox a1DB)
	{
		_GroupBox1 = a1DB;
	}

	[SpecialName]
	internal virtual PictureBox m4Y2()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5NL(PictureBox To3s)
	{
		_PictureBox1 = To3s;
	}

	[SpecialName]
	internal virtual GroupBox g6PB()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jf6n(GroupBox Xe15)
	{
		GroupBox val = (s = Xe15);
	}

	[SpecialName]
	internal virtual ToolTip Ye8r()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ke6r(ToolTip Dt0r)
	{
		ToolTip val = (f = Dt0r);
	}

	[SpecialName]
	internal virtual Button y0PQ()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Br59(Button a7W2)
	{
		EventHandler eventHandler = y7W6;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = a7W2;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ErrorProvider p8X3()
	{
		return _ErrorProvider1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm48(ErrorProvider Hp2n)
	{
		_ErrorProvider1 = Hp2n;
	}

	private void Pf0q(object sender, EventArgs e)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Fg36().get_Text(), "", false) == 0)
		{
			p8X3().SetError((Control)(object)Fg36(), "Enter Username");
			return;
		}
		p8X3().Clear();
		if (Operators.CompareString(w6T1().get_Text(), "", false) == 0)
		{
			p8X3().SetError((Control)(object)w6T1(), "Enter Password");
			return;
		}
		p8X3().Clear();
		string text = Fg36().get_Text().ToUpper();
		w6T1().get_Text();
		string text2 = "select pwd from login where uname='" + text + "'";
		try
		{
			SqlCommand val = new SqlCommand(text2, Eb3s.con);
			string text3 = Conversions.ToString(val.ExecuteScalar());
			if (Operators.CompareString(text3, w6T1().get_Text(), false) == 0)
			{
				string text4 = Interaction.InputBox("Enter Your Enrollment Key", "Secret Enrollment Key", "NMAMIT", -1, -1);
				if ((Operators.CompareString(text4, "NMAMIT", false) == 0) | (Operators.CompareString(text4, "library", false) == 0) | (Operators.CompareString(text4, "nitte", false) == 0))
				{
					Fg36().set_Text("");
					w6T1().set_Text("");
					((Form)this).Close();
					Se8q se8q = new Se8q();
					((Form)se8q).set_MdiParent((Form)(object)Fb9z.Forms.Ad5o());
					((Control)se8q).Show();
				}
			}
			else
			{
				count = checked((int)Math.Round(Conversion.Val((object)(count + 1))));
				if (count > 3)
				{
					Interaction.MsgBox((object)"Reached The Limit Of the login!!!", (MsgBoxStyle)0, (object)null);
					((Form)this).Close();
				}
				else
				{
					Interaction.MsgBox((object)"Not Authenticated", (MsgBoxStyle)0, (object)null);
				}
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Qw4s(object sender, EventArgs e)
	{
		count = 0;
	}

	internal static string[] Km72()
	{
		Se8q.Rc49();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Mj02.mDic.Add("AO", executingAssembly);
		return Ky82.k2B();
	}

	private void y7W6(object sender, EventArgs e)
	{
		Pf0q(RuntimeHelpers.GetObjectValue(new object()), new EventArgs());
	}
}
