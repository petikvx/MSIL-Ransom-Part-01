using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using z2SR;

namespace e7H;

[DesignerGenerated]
public class Fx6 : Form
{
	private IContainer components;

	private GroupBox _GroupBox1;

	private TextBox _TextBox3;

	private Label _Label2;

	private TextBox _TextBox1;

	private ErrorProvider _ErrorProvider1;

	private ErrorProvider _ErrorProvider3;

	private Label _Label4;

	private Button _Button1;

	internal PictureBox y;

	internal TextBox v;

	internal Label L;

	internal Label b;

	internal ErrorProvider C;

	internal TextBox U;

	internal ErrorProvider P;

	internal GroupBox r;

	public Fx6()
	{
		Xp3();
	}

	protected override void x7M(bool Pn2)
	{
		try
		{
			if (Pn2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pn2);
		}
	}

	private void Xp3()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
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
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		components = new Container();
		r7X(new GroupBox());
		Hj5(new TextBox());
		Ya0(new Label());
		Mi3(new TextBox());
		t9J(new TextBox());
		x9J(new Label());
		m7L(new Label());
		Fs4(new TextBox());
		Ss8(new Label());
		y3R(new ErrorProvider(components));
		Ci3(new ErrorProvider(components));
		Ez3(new ErrorProvider(components));
		w0Y(new ErrorProvider(components));
		q1T(new Button());
		An2(new GroupBox());
		Wb8(new PictureBox());
		((Control)w2B()).SuspendLayout();
		((ISupportInitialize)c5R()).BeginInit();
		((ISupportInitialize)s5J()).BeginInit();
		((ISupportInitialize)Rs8()).BeginInit();
		((ISupportInitialize)e2M()).BeginInit();
		((Control)Ke2()).SuspendLayout();
		((ISupportInitialize)Cj9()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)w2B()).get_Controls().Add((Control)(object)s7B());
		((Control)w2B()).get_Controls().Add((Control)(object)No1());
		((Control)w2B()).get_Controls().Add((Control)(object)o8Z());
		((Control)w2B()).get_Controls().Add((Control)(object)r2A());
		((Control)w2B()).get_Controls().Add((Control)(object)e2H());
		((Control)w2B()).get_Controls().Add((Control)(object)p3L());
		((Control)w2B()).get_Controls().Add((Control)(object)Mc6());
		((Control)w2B()).get_Controls().Add((Control)(object)Ke2());
		((Control)w2B()).get_Controls().Add((Control)(object)Cj9());
		((Control)w2B()).set_Location(new Point(12, 12));
		((Control)w2B()).set_Name("GroupBox1");
		((Control)w2B()).set_Size(new Size(601, 258));
		((Control)w2B()).set_TabIndex(0);
		w2B().set_TabStop(false);
		((Control)No1()).set_Location(new Point(373, 157));
		((Control)No1()).set_Name("TextBox4");
		No1().set_PasswordChar('*');
		((Control)No1()).set_Size(new Size(196, 20));
		((Control)No1()).set_TabIndex(9);
		Yo0().set_AutoSize(true);
		((Control)Yo0()).set_Location(new Point(26, 104));
		((Control)Yo0()).set_Name("Label4");
		((Control)Yo0()).set_Size(new Size(78, 13));
		((Control)Yo0()).set_TabIndex(8);
		Yo0().set_Text("New Password");
		((Control)o8Z()).set_Location(new Point(373, 113));
		((Control)o8Z()).set_Name("TextBox3");
		o8Z().set_PasswordChar('*');
		((Control)o8Z()).set_Size(new Size(196, 20));
		((Control)o8Z()).set_TabIndex(6);
		((Control)r2A()).set_Location(new Point(373, 68));
		((Control)r2A()).set_Name("TextBox2");
		r2A().set_PasswordChar('*');
		((Control)r2A()).set_Size(new Size(196, 20));
		((Control)r2A()).set_TabIndex(5);
		Sg9().set_AutoSize(true);
		((Control)Sg9()).set_Location(new Point(26, 151));
		((Control)Sg9()).set_Name("Label3");
		((Control)Sg9()).set_Size(new Size(119, 13));
		((Control)Sg9()).set_TabIndex(4);
		Sg9().set_Text("Reenter Your Password");
		e2H().set_AutoSize(true);
		((Control)e2H()).set_Location(new Point(236, 71));
		((Control)e2H()).set_Name("Label2");
		((Control)e2H()).set_Size(new Size(106, 13));
		((Control)e2H()).set_TabIndex(3);
		e2H().set_Text("Enter Your Password");
		((Control)p3L()).set_Location(new Point(373, 24));
		((Control)p3L()).set_Name("TextBox1");
		((Control)p3L()).set_Size(new Size(196, 20));
		((Control)p3L()).set_TabIndex(2);
		Mc6().set_AutoSize(true);
		((Control)Mc6()).set_Location(new Point(236, 27));
		((Control)Mc6()).set_Name("Label1");
		((Control)Mc6()).set_Size(new Size(96, 13));
		((Control)Mc6()).set_TabIndex(1);
		Mc6().set_Text("Enter Your User ID");
		c5R().set_ContainerControl((ContainerControl)(object)this);
		s5J().set_ContainerControl((ContainerControl)(object)this);
		Rs8().set_ContainerControl((ContainerControl)(object)this);
		e2M().set_ContainerControl((ContainerControl)(object)this);
		((Control)s7B()).set_Location(new Point(306, 197));
		((Control)s7B()).set_Name("Button1");
		((Control)s7B()).set_Size(new Size(201, 43));
		((Control)s7B()).set_TabIndex(10);
		((ButtonBase)s7B()).set_Text("Reset Password");
		((ButtonBase)s7B()).set_UseVisualStyleBackColor(true);
		((Control)Ke2()).get_Controls().Add((Control)(object)Sg9());
		((Control)Ke2()).get_Controls().Add((Control)(object)Yo0());
		((Control)Ke2()).set_Location(new Point(210, 9));
		((Control)Ke2()).set_Name("GroupBox2");
		((Control)Ke2()).set_Size(new Size(385, 243));
		((Control)Ke2()).set_TabIndex(11);
		Ke2().set_TabStop(false);
		((Control)Cj9()).set_Location(new Point(6, 9));
		((Control)Cj9()).set_Name("PictureBox1");
		((Control)Cj9()).set_Size(new Size(198, 243));
		Cj9().set_SizeMode((PictureBoxSizeMode)1);
		Cj9().set_TabIndex(0);
		Cj9().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(636, 286));
		((Control)this).get_Controls().Add((Control)(object)w2B());
		((Control)this).set_Name("Form9");
		((Form)this).set_Text("Change Your Password");
		((Control)w2B()).ResumeLayout(false);
		((Control)w2B()).PerformLayout();
		((ISupportInitialize)c5R()).EndInit();
		((ISupportInitialize)s5J()).EndInit();
		((ISupportInitialize)Rs8()).EndInit();
		((ISupportInitialize)e2M()).EndInit();
		((Control)Ke2()).ResumeLayout(false);
		((Control)Ke2()).PerformLayout();
		((ISupportInitialize)Cj9()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual GroupBox w2B()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7X(GroupBox Dc5)
	{
		_GroupBox1 = Dc5;
	}

	[SpecialName]
	internal virtual PictureBox Cj9()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wb8(PictureBox Ea3)
	{
		PictureBox val = (y = Ea3);
	}

	[SpecialName]
	internal virtual TextBox o8Z()
	{
		return _TextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mi3(TextBox Ho3)
	{
		_TextBox3 = Ho3;
	}

	[SpecialName]
	internal virtual TextBox r2A()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9J(TextBox Pn9)
	{
		TextBox val = (v = Pn9);
	}

	[SpecialName]
	internal virtual Label Sg9()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9J(Label Kw3)
	{
		Label val = (L = Kw3);
	}

	[SpecialName]
	internal virtual Label e2H()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7L(Label i3F)
	{
		_Label2 = i3F;
	}

	[SpecialName]
	internal virtual TextBox p3L()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs4(TextBox k3W)
	{
		_TextBox1 = k3W;
	}

	[SpecialName]
	internal virtual Label Mc6()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ss8(Label q1C)
	{
		Label val = (b = q1C);
	}

	[SpecialName]
	internal virtual ErrorProvider c5R()
	{
		return _ErrorProvider1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3R(ErrorProvider Rt5)
	{
		_ErrorProvider1 = Rt5;
	}

	[SpecialName]
	internal virtual ErrorProvider s5J()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci3(ErrorProvider Kb1)
	{
		ErrorProvider val = (C = Kb1);
	}

	[SpecialName]
	internal virtual ErrorProvider Rs8()
	{
		return _ErrorProvider3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez3(ErrorProvider Fy9)
	{
		_ErrorProvider3 = Fy9;
	}

	[SpecialName]
	internal virtual TextBox No1()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj5(TextBox p1C)
	{
		TextBox val = (U = p1C);
	}

	[SpecialName]
	internal virtual Label Yo0()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ya0(Label c5E)
	{
		_Label4 = c5E;
	}

	[SpecialName]
	internal virtual ErrorProvider e2M()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0Y(ErrorProvider Pp8)
	{
		ErrorProvider val = (P = Pp8);
	}

	[SpecialName]
	internal virtual Button s7B()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1T(Button a9A)
	{
		EventHandler eventHandler = x8R;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = a9A;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Ke2()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An2(GroupBox a8J)
	{
		GroupBox val = (r = a8J);
	}

	private void x8R(object sender, EventArgs e)
	{
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(p3L().get_Text(), "", false) == 0)
		{
			c5R().SetError((Control)(object)p3L(), "Please Enter Your User Name");
			return;
		}
		c5R().Clear();
		if (Operators.CompareString(r2A().get_Text(), "", false) == 0)
		{
			s5J().SetError((Control)(object)r2A(), "Please Enter Your Password");
			return;
		}
		s5J().Clear();
		if (Operators.CompareString(o8Z().get_Text(), "", false) == 0)
		{
			Rs8().SetError((Control)(object)o8Z(), "Please Enter Your Password");
			return;
		}
		Rs8().Clear();
		if (Operators.CompareString(No1().get_Text(), "", false) == 0)
		{
			e2M().SetError((Control)(object)No1(), "Please Enter New Password");
			return;
		}
		e2M().Clear();
		if (Operators.CompareString(No1().get_Text(), o8Z().get_Text(), false) != 0)
		{
			Rs8().SetError((Control)(object)o8Z(), "Please Enter Your Password");
			e2M().SetError((Control)(object)No1(), "Password Doesn't Match");
			return;
		}
		Rs8().Clear();
		e2M().Clear();
		if (Operators.CompareString(r2A().get_Text(), o8Z().get_Text(), false) == 0)
		{
			Rs8().SetError((Control)(object)No1(), "Please Enter New Password");
			return;
		}
		Rs8().Clear();
		string text = p3L().get_Text();
		r2A().get_Text();
		string text2 = o8Z().get_Text();
		string text3 = "update login set pwd='" + text2 + "' where uname='" + text + "'";
		try
		{
			SqlCommand val = new SqlCommand(text3, Eb3s.con);
			val.ExecuteNonQuery();
			Interaction.MsgBox((object)"Password Has Been Successfully Changed", (MsgBoxStyle)0, (object)"Password Changed");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}
}
