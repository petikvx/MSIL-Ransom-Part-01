using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nc3g;
using Rm59;
using g2H;
using m1F4;

namespace Nr7t;

[StandardModule]
internal sealed class g2GB
{
	public static void c7YD()
	{
		if (Operators.CompareString(Gw5.Forms.LoginForm.txtUser.get_Text(), "Enter Username", false) == 0)
		{
			Gw5.Forms.LoginForm.txtUser.set_Text("");
			((TextBoxBase)Gw5.Forms.LoginForm.txtUser).set_ForeColor(Color.Black);
		}
	}

	public static void Ks08()
	{
		if (Operators.CompareString(Gw5.Forms.LoginForm.txtUser.get_Text(), "", false) == 0)
		{
			Gw5.Forms.LoginForm.txtUser.set_Text("Enter Username");
			((TextBoxBase)Gw5.Forms.LoginForm.txtUser).set_ForeColor(Color.Gray);
		}
	}

	public static void Fb4e()
	{
		if (Operators.CompareString(Gw5.Forms.LoginForm.txtPass.get_Text(), "Enter Password", false) == 0)
		{
			Gw5.Forms.LoginForm.txtPass.set_Text("");
			Gw5.Forms.LoginForm.txtPass.set_PasswordChar('*');
			((TextBoxBase)Gw5.Forms.LoginForm.txtPass).set_ForeColor(Color.Black);
		}
	}

	public static void Do72()
	{
		if (Operators.CompareString(Gw5.Forms.LoginForm.txtPass.get_Text(), "", false) == 0)
		{
			Gw5.Forms.LoginForm.txtPass.set_Text("Enter Password");
			((TextBoxBase)Gw5.Forms.LoginForm.txtPass).set_ForeColor(Color.Gray);
		}
	}

	internal static byte y4L6(byte Gk1t, byte[] y8RM, int Gt28, int x1HL)
	{
		Gk1t = (byte)(Gk1t ^ checked((byte)(y8RM[unchecked(x1HL % y8RM.Length)] ^ ((x1HL + unchecked(Gt28 % y8RM.Length)) & Gt28))));
		return Gk1t;
	}

	public static void y2Q7()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Gw5.Forms.LoginForm.txtUser.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Username is required", (MsgBoxStyle)16, (object)null);
			return;
		}
		if (Operators.CompareString(Gw5.Forms.LoginForm.txtPass.get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Password is required", (MsgBoxStyle)16, (object)null);
			return;
		}
		g8H5.sql = "SELECT * FROM `user` WHERE `username`='" + Gw5.Forms.LoginForm.txtUser.get_Text() + "' AND `password`='" + Gw5.Forms.LoginForm.txtPass.get_Text() + "' ";
		x3HT.c6AD(g8H5.sql);
		if (Gs93.Zt7w() == 1)
		{
			x3HT.e5F1("login");
			Interaction.MsgBox((object)"Welcome to Student Infomation", (MsgBoxStyle)0, (object)null);
			Gw5.Forms.LoginForm.txtPass.set_Text("");
			Gw5.Forms.LoginForm.txtUser.set_Text("");
		}
		else
		{
			Interaction.MsgBox((object)"Username or Passwrord is not correct, Please try again!!", (MsgBoxStyle)16, (object)null);
			Gw5.Forms.LoginForm.txtPass.set_Text("");
			Gw5.Forms.LoginForm.txtUser.set_Text("");
		}
	}
}
