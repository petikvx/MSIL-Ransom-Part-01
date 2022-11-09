using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using g6WL;
using t0B;

namespace f4S;

[DesignerGenerated]
public class x2A : UserControl
{
	private Label _Label1;

	private Label _Label2;

	private TextBox _TextBox1;

	private TextBox _TextBox3;

	private Button _Button1;

	internal IContainer V;

	internal Label k;

	internal TextBox b;

	internal CheckBox H;

	public x2A()
	{
		((UserControl)this).add_Load((EventHandler)b0P);
		s1M();
	}

	protected override void e7T(bool Da8)
	{
		try
		{
			if (Da8 && V != null)
			{
				V.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Da8);
		}
	}

	private void s1M()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_030b: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0449: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		k4G(new Label());
		r4E(new Label());
		De3(new Label());
		Dg0(new TextBox());
		Yp3(new TextBox());
		Nm0(new TextBox());
		Ci8(new Button());
		z8H(new CheckBox());
		((Control)this).SuspendLayout();
		g2R().set_AutoSize(true);
		((Control)g2R()).set_Cursor(Cursors.get_Hand());
		((Control)g2R()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g2R()).set_Location(new Point(172, 135));
		((Control)g2R()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)g2R()).set_Name("Label1");
		((Control)g2R()).set_Size(new Size(119, 19));
		((Control)g2R()).set_TabIndex(0);
		g2R().set_Text("Current Password");
		e4E().set_AutoSize(true);
		((Control)e4E()).set_Cursor(Cursors.get_Hand());
		((Control)e4E()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)e4E()).set_Location(new Point(172, 210));
		((Control)e4E()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)e4E()).set_Name("Label2");
		((Control)e4E()).set_Size(new Size(103, 19));
		((Control)e4E()).set_TabIndex(1);
		e4E().set_Text("New Password");
		q0B().set_AutoSize(true);
		((Control)q0B()).set_Cursor(Cursors.get_Hand());
		((Control)q0B()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q0B()).set_Location(new Point(172, 286));
		((Control)q0B()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)q0B()).set_Name("Label3");
		((Control)q0B()).set_Size(new Size(122, 19));
		((Control)q0B()).set_TabIndex(2);
		q0B().set_Text("Confirm Password");
		((Control)d4J()).set_Cursor(Cursors.get_IBeam());
		((Control)d4J()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d4J()).set_Location(new Point(335, 135));
		((Control)d4J()).set_Margin(new Padding(2));
		((Control)d4J()).set_Name("TextBox1");
		((Control)d4J()).set_Size(new Size(197, 26));
		((Control)d4J()).set_TabIndex(3);
		((Control)g1X()).set_Cursor(Cursors.get_IBeam());
		((Control)g1X()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g1X()).set_Location(new Point(335, 208));
		((Control)g1X()).set_Margin(new Padding(2));
		((Control)g1X()).set_Name("TextBox2");
		((Control)g1X()).set_Size(new Size(197, 26));
		((Control)g1X()).set_TabIndex(4);
		((Control)Fd6()).set_Cursor(Cursors.get_IBeam());
		((Control)Fd6()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fd6()).set_Location(new Point(335, 284));
		((Control)Fd6()).set_Margin(new Padding(2));
		((Control)Fd6()).set_Name("TextBox3");
		((TextBoxBase)Fd6()).set_ShortcutsEnabled(false);
		((Control)Fd6()).set_Size(new Size(197, 26));
		((Control)Fd6()).set_TabIndex(5);
		((ButtonBase)Bn8()).set_BackColor(Color.MediumSeaGreen);
		((Control)Bn8()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Bn8()).set_FlatStyle((FlatStyle)1);
		((Control)Bn8()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Bn8()).set_ForeColor(Color.White);
		((Control)Bn8()).set_Location(new Point(335, 357));
		((Control)Bn8()).set_Margin(new Padding(2));
		((Control)Bn8()).set_Name("Button1");
		((Control)Bn8()).set_Size(new Size(196, 40));
		((Control)Bn8()).set_TabIndex(6);
		((ButtonBase)Bn8()).set_Text("Update Password");
		((ButtonBase)Bn8()).set_UseVisualStyleBackColor(false);
		((ButtonBase)j0Q()).set_AutoSize(true);
		((Control)j0Q()).set_Cursor(Cursors.get_Hand());
		((Control)j0Q()).set_Location(new Point(434, 164));
		((Control)j0Q()).set_Margin(new Padding(2));
		((Control)j0Q()).set_Name("CheckBox1");
		((Control)j0Q()).set_Size(new Size(102, 17));
		((Control)j0Q()).set_TabIndex(7);
		((ButtonBase)j0Q()).set_Text("Show Password");
		((ButtonBase)j0Q()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)j0Q());
		((Control)this).get_Controls().Add((Control)(object)Bn8());
		((Control)this).get_Controls().Add((Control)(object)Fd6());
		((Control)this).get_Controls().Add((Control)(object)g1X());
		((Control)this).get_Controls().Add((Control)(object)d4J());
		((Control)this).get_Controls().Add((Control)(object)q0B());
		((Control)this).get_Controls().Add((Control)(object)e4E());
		((Control)this).get_Controls().Add((Control)(object)g2R());
		((Control)this).set_Margin(new Padding(2));
		((Control)this).set_Name("ChangePassword");
		((Control)this).set_Size(new Size(1009, 681));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label g2R()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4G(Label z0P)
	{
		_Label1 = z0P;
	}

	[SpecialName]
	internal virtual Label e4E()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4E(Label Aa6)
	{
		_Label2 = Aa6;
	}

	[SpecialName]
	internal virtual Label q0B()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void De3(Label Em0)
	{
		Label val = (k = Em0);
	}

	[SpecialName]
	internal virtual TextBox d4J()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dg0(TextBox Fr0)
	{
		EventHandler eventHandler = Te8;
		TextBox textBox = _TextBox1;
		if (textBox != null)
		{
			((Control)textBox).remove_TextChanged(eventHandler);
		}
		_TextBox1 = Fr0;
		textBox = _TextBox1;
		if (textBox != null)
		{
			((Control)textBox).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox g1X()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp3(TextBox q8K)
	{
		EventHandler eventHandler = g2H;
		TextBox val = b;
		if (val != null)
		{
			((Control)val).remove_TextChanged(eventHandler);
		}
		TextBox val2 = (b = q8K);
		val = b;
		if (val != null)
		{
			((Control)val).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Fd6()
	{
		return _TextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm0(TextBox z4J)
	{
		EventHandler eventHandler = t9B;
		TextBox textBox = _TextBox3;
		if (textBox != null)
		{
			((Control)textBox).remove_TextChanged(eventHandler);
		}
		_TextBox3 = z4J;
		textBox = _TextBox3;
		if (textBox != null)
		{
			((Control)textBox).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Bn8()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci8(Button Zn7)
	{
		EventHandler eventHandler = n0J;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Zn7;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual CheckBox j0Q()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8H(CheckBox x1Y)
	{
		EventHandler eventHandler = Mp3;
		CheckBox h = H;
		if (h != null)
		{
			h.remove_CheckedChanged(eventHandler);
		}
		CheckBox val = (H = x1Y);
		h = H;
		if (h != null)
		{
			h.add_CheckedChanged(eventHandler);
		}
	}

	private void n0J(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = p3S8.s4G1(d4J().get_Text(), m2A.Forms.r0M().UserName);
		string text2 = g1X().get_Text();
		string text3 = Fd6().get_Text();
		bool flag = true;
		string text4 = "SELECT * FROM Users WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
		OleDbCommand val2 = new OleDbCommand(text4, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		if (val3.Read())
		{
			if (Operators.CompareString(text, "", false) == 0)
			{
				MessageBox.Show("Please enter your current password", "Invalid password");
				flag = false;
			}
			else if (Operators.ConditionalCompareObjectNotEqual((object)text, val3.get_Item("Password"), false))
			{
				MessageBox.Show("Your current password does not match", "Wrong password");
				flag = false;
			}
			else if (Operators.CompareString(text2, "", false) == 0)
			{
				MessageBox.Show("Please enter your new password", "Invalid password");
				flag = false;
			}
			else if (Operators.CompareString(text3, "", false) == 0)
			{
				MessageBox.Show("Please confirm your new password", "Invalid password");
				flag = false;
			}
			else if (Operators.CompareString(text2, text3, false) != 0)
			{
				MessageBox.Show("Password not confirmed correctly", "Invalid new password");
				flag = false;
			}
			else if (Operators.CompareString(text2, text, false) == 0)
			{
				MessageBox.Show("Enter a new password", "Set Password");
				flag = false;
			}
		}
		if (flag)
		{
			string text5 = "UPDATE Users SET [Password]='" + p3S8.s4G1(text2, m2A.Forms.r0M().UserName) + "' WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
			OleDbCommand val4 = new OleDbCommand(text5, val);
			if (val4.ExecuteNonQuery() > 0)
			{
				((Component)(object)val4).Dispose();
				MessageBox.Show("Password successfully updated!", "Password Change");
				((TextBoxBase)d4J()).Clear();
				((TextBoxBase)g1X()).Clear();
				((TextBoxBase)Fd6()).Clear();
			}
		}
		val.Close();
	}

	private void Mp3(object sender, EventArgs e)
	{
		if (j0Q().get_Checked())
		{
			d4J().set_UseSystemPasswordChar(false);
		}
		else
		{
			d4J().set_UseSystemPasswordChar(true);
		}
	}

	private void Te8(object sender, EventArgs e)
	{
		if (j0Q().get_Checked())
		{
			d4J().set_UseSystemPasswordChar(false);
		}
		else
		{
			d4J().set_UseSystemPasswordChar(true);
		}
	}

	internal static string Hz0(string[] Fa1, int Np6, int a9G)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Np6; i <= a9G; i = checked(i + 1))
		{
			stringBuilder.Append(Fa1[i]);
		}
		return stringBuilder.ToString();
	}

	private void g2H(object sender, EventArgs e)
	{
		g1X().set_UseSystemPasswordChar(true);
	}

	private void t9B(object sender, EventArgs e)
	{
		Fd6().set_UseSystemPasswordChar(true);
	}

	private void b0P(object sender, EventArgs e)
	{
	}
}
