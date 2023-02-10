using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xi1;
using Yw6;
using q3G;
using t8C;

namespace y3E;

[StandardModule]
internal sealed class Sj2
{
	public static void We0()
	{
		if (Operators.CompareString(Ng2.Forms.LoginForm.txtUser.get_Text(), "Enter Username", false) == 0)
		{
			Ng2.Forms.LoginForm.txtUser.set_Text("");
			((TextBoxBase)Ng2.Forms.LoginForm.txtUser).set_ForeColor(Color.Black);
		}
	}

	public static void o4B()
	{
		if (Operators.CompareString(Ng2.Forms.LoginForm.txtUser.get_Text(), "", false) == 0)
		{
			Ng2.Forms.LoginForm.txtUser.set_Text("Enter Username");
			((TextBoxBase)Ng2.Forms.LoginForm.txtUser).set_ForeColor(Color.Gray);
		}
	}

	public static void Zy8()
	{
		if (Operators.CompareString(Ng2.Forms.LoginForm.txtPass.get_Text(), "Enter Password", false) == 0)
		{
			Ng2.Forms.LoginForm.txtPass.set_Text("");
			Ng2.Forms.LoginForm.txtPass.set_PasswordChar('*');
			((TextBoxBase)Ng2.Forms.LoginForm.txtPass).set_ForeColor(Color.Black);
		}
	}

	public static void Tq8()
	{
		if (Operators.CompareString(Ng2.Forms.LoginForm.txtPass.get_Text(), "", false) == 0)
		{
			Ng2.Forms.LoginForm.txtPass.set_Text("Enter Password");
			((TextBoxBase)Ng2.Forms.LoginForm.txtPass).set_ForeColor(Color.Gray);
		}
	}

	internal static byte n2R(byte y8B, byte[] n3T, int Mg5, int Mk9)
	{
		y8B = (byte)(y8B ^ checked((byte)(n3T[unchecked(Mk9 % n3T.Length)] ^ ((Mk9 + unchecked(Mg5 % n3T.Length)) & Mg5))));
		return y8B;
	}

	public static void o2K()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Ng2.Forms.LoginForm.txtUser.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Username is required", (MsgBoxStyle)16, (object)null);
			return;
		}
		if (Operators.CompareString(Ng2.Forms.LoginForm.txtPass.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Password is required", (MsgBoxStyle)16, (object)null);
			return;
		}
		Xe9.sql = "SELECT * FROM `user` WHERE `username`='" + Ng2.Forms.LoginForm.txtUser.get_Text() + "' AND `password`='" + Ng2.Forms.LoginForm.txtPass.get_Text() + "' ";
		j5J.Cn2(Xe9.sql);
		if (Yd3.w3C() == 1)
		{
			j5J.Db8("login");
			Interaction.MsgBox((object)"Welcome to Student Infomation", (MsgBoxStyle)0, (object)null);
			Ng2.Forms.LoginForm.txtPass.set_Text("");
			Ng2.Forms.LoginForm.txtUser.set_Text("");
		}
		else
		{
			Interaction.MsgBox((object)"Username or Passwrord is not correct, Please try again!!", (MsgBoxStyle)16, (object)null);
			Ng2.Forms.LoginForm.txtPass.set_Text("");
			Ng2.Forms.LoginForm.txtUser.set_Text("");
		}
	}
}
