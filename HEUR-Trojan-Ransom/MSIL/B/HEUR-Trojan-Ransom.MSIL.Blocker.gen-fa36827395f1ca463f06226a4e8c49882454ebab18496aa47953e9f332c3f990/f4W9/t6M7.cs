using System;
using System.Collections;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cf97;
using Microsoft.VisualBasic.CompilerServices;
using g6WL;
using t0B;

namespace f4W9;

[DesignerGenerated]
public class t6M7 : UserControl
{
	private Label _Label1;

	private Label _Label3;

	private Label _Label4;

	private Label _Label6;

	private Label _Label7;

	private TextBox _txtUsername;

	private TextBox _txtEmail;

	private Button _btnAddUser;

	private ComboBox _ComboBox1;

	internal IContainer I;

	internal Label P;

	internal Label D;

	internal TextBox V;

	internal TextBox r;

	internal TextBox Q;

	internal ComboBox s;

	internal Label w;

	public t6M7()
	{
		((UserControl)this).add_Load((EventHandler)Di9);
		r1Q();
	}

	protected override void k6TK(bool Wc12)
	{
		try
		{
			if (Wc12 && I != null)
			{
				I.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Wc12);
		}
	}

	private void r1Q()
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
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
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
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_0302: Unknown result type (might be due to invalid IL or missing references)
		//IL_030c: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_041d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04aa: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0587: Expected O, but got Unknown
		//IL_05f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_066b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0675: Expected O, but got Unknown
		//IL_071f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0729: Expected O, but got Unknown
		//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Expected O, but got Unknown
		//IL_086a: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dd: Expected O, but got Unknown
		//IL_0930: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b3: Expected O, but got Unknown
		j4Q(new Label());
		c6W(new Label());
		q5C(new Label());
		Lo2(new Label());
		Zf4(new Label());
		f2H(new Label());
		Jt8(new Label());
		Je9(new TextBox());
		Kg8(new TextBox());
		Wd3(new TextBox());
		Xo5(new TextBox());
		Ha4(new TextBox());
		n6B(new Button());
		g5M(new ComboBox());
		Cz3(new ComboBox());
		f2Q(new Label());
		((Control)this).SuspendLayout();
		e6L().set_AutoSize(true);
		((Control)e6L()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)e6L()).set_Location(new Point(151, 105));
		((Control)e6L()).set_Name("Label1");
		((Control)e6L()).set_Size(new Size(70, 19));
		((Control)e6L()).set_TabIndex(0);
		e6L().set_Text("Username");
		z6F().set_AutoSize(true);
		((Control)z6F()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)z6F()).set_Location(new Point(175, 147));
		((Control)z6F()).set_Name("Label2");
		((Control)z6F()).set_Size(new Size(46, 19));
		((Control)z6F()).set_TabIndex(1);
		z6F().set_Text("Name");
		((Control)z6F()).set_Visible(false);
		e7T().set_AutoSize(true);
		((Control)e7T()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)e7T()).set_Location(new Point(152, 403));
		((Control)e7T()).set_Name("Label3");
		((Control)e7T()).set_Size(new Size(69, 19));
		((Control)e7T()).set_TabIndex(2);
		e7T().set_Text("Password");
		((Control)e7T()).set_Visible(false);
		Ks6().set_AutoSize(true);
		((Control)Ks6()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ks6()).set_Location(new Point(179, 189));
		((Control)Ks6()).set_Name("Label4");
		((Control)Ks6()).set_Size(new Size(42, 19));
		((Control)Ks6()).set_TabIndex(3);
		Ks6().set_Text("Email");
		((Control)Ks6()).set_Visible(false);
		y2Z().set_AutoSize(true);
		((Control)y2Z()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)y2Z()).set_Location(new Point(120, 241));
		((Control)y2Z()).set_Name("Label5");
		((Control)y2Z()).set_Size(new Size(101, 19));
		((Control)y2Z()).set_TabIndex(4);
		y2Z().set_Text("Phone Number");
		((Control)y2Z()).set_Visible(false);
		p2T().set_AutoSize(true);
		((Control)p2T()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p2T()).set_Location(new Point(141, 291));
		((Control)p2T()).set_Name("Label6");
		((Control)p2T()).set_Size(new Size(80, 19));
		((Control)p2T()).set_TabIndex(5);
		p2T().set_Text("Department");
		((Control)p2T()).set_Visible(false);
		q9A().set_AutoSize(true);
		((Control)q9A()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q9A()).set_Location(new Point(142, 347));
		((Control)q9A()).set_Name("Label7");
		((Control)q9A()).set_Size(new Size(79, 19));
		((Control)q9A()).set_TabIndex(6);
		q9A().set_Text("Designation");
		((Control)q9A()).set_Visible(false);
		((Control)Bk3()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Bk3()).set_Location(new Point(278, 102));
		((Control)Bk3()).set_Name("txtUsername");
		((Control)Bk3()).set_Size(new Size(228, 26));
		((Control)Bk3()).set_TabIndex(7);
		((Control)i6K()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i6K()).set_Location(new Point(278, 144));
		((Control)i6K()).set_Name("txtName");
		((Control)i6K()).set_Size(new Size(228, 26));
		((Control)i6K()).set_TabIndex(8);
		((Control)i6K()).set_Visible(false);
		((Control)c7L()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)c7L()).set_Location(new Point(278, 186));
		((Control)c7L()).set_Name("txtEmail");
		((Control)c7L()).set_Size(new Size(228, 26));
		((Control)c7L()).set_TabIndex(9);
		((Control)c7L()).set_Visible(false);
		((Control)d8J()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d8J()).set_Location(new Point(278, 234));
		((Control)d8J()).set_Name("txtPhone");
		((Control)d8J()).set_Size(new Size(228, 26));
		((Control)d8J()).set_TabIndex(10);
		((Control)d8J()).set_Visible(false);
		((Control)To7()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)To7()).set_Location(new Point(278, 400));
		((Control)To7()).set_Name("txtPassword");
		((Control)To7()).set_Size(new Size(228, 26));
		((Control)To7()).set_TabIndex(13);
		((Control)To7()).set_Visible(false);
		((ButtonBase)g8K()).set_BackColor(Color.MediumSeaGreen);
		((Control)g8K()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)g8K()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)g8K()).set_FlatStyle((FlatStyle)1);
		((Control)g8K()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)g8K()).set_ForeColor(Color.White);
		((Control)g8K()).set_Location(new Point(278, 486));
		((Control)g8K()).set_Name("btnAddUser");
		((Control)g8K()).set_Size(new Size(228, 42));
		((Control)g8K()).set_TabIndex(18);
		((ButtonBase)g8K()).set_Text("Search");
		((ButtonBase)g8K()).set_UseVisualStyleBackColor(false);
		i7J().set_DropDownStyle((ComboBoxStyle)2);
		((Control)i7J()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)i7J()).set_FormattingEnabled(true);
		i7J().get_Items().AddRange(new object[11]
		{
			"Biosciences and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engg.", "Design", "Electronics and Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering",
			"Physics"
		});
		((Control)i7J()).set_Location(new Point(278, 288));
		((Control)i7J()).set_Margin(new Padding(2));
		((Control)i7J()).set_Name("ComboBox1");
		((Control)i7J()).set_Size(new Size(228, 27));
		((Control)i7J()).set_TabIndex(19);
		((Control)i7J()).set_Visible(false);
		Tn2().set_DropDownStyle((ComboBoxStyle)2);
		((Control)Tn2()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)Tn2()).set_FormattingEnabled(true);
		Tn2().get_Items().AddRange(new object[2] { "Student", "Professor" });
		((Control)Tn2()).set_Location(new Point(278, 344));
		((Control)Tn2()).set_Margin(new Padding(2));
		((Control)Tn2()).set_Name("ComboBox2");
		((Control)Tn2()).set_Size(new Size(228, 27));
		((Control)Tn2()).set_TabIndex(20);
		((Control)Tn2()).set_Visible(false);
		Eg6().set_AutoSize(true);
		((Control)Eg6()).set_BackColor(SystemColors.Control);
		((Control)Eg6()).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Eg6()).set_ForeColor(Color.Red);
		((Control)Eg6()).set_Location(new Point(57, 29));
		((Control)Eg6()).set_Name("Label8");
		((Control)Eg6()).set_Size(new Size(88, 23));
		((Control)Eg6()).set_TabIndex(21);
		Eg6().set_Text("Add User");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Eg6());
		((Control)this).get_Controls().Add((Control)(object)Tn2());
		((Control)this).get_Controls().Add((Control)(object)i7J());
		((Control)this).get_Controls().Add((Control)(object)g8K());
		((Control)this).get_Controls().Add((Control)(object)To7());
		((Control)this).get_Controls().Add((Control)(object)d8J());
		((Control)this).get_Controls().Add((Control)(object)c7L());
		((Control)this).get_Controls().Add((Control)(object)i6K());
		((Control)this).get_Controls().Add((Control)(object)Bk3());
		((Control)this).get_Controls().Add((Control)(object)q9A());
		((Control)this).get_Controls().Add((Control)(object)p2T());
		((Control)this).get_Controls().Add((Control)(object)y2Z());
		((Control)this).get_Controls().Add((Control)(object)Ks6());
		((Control)this).get_Controls().Add((Control)(object)e7T());
		((Control)this).get_Controls().Add((Control)(object)z6F());
		((Control)this).get_Controls().Add((Control)(object)e6L());
		((Control)this).set_Name("AddUser");
		((Control)this).set_Size(new Size(1017, 681));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label e6L()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4Q(Label Yc3)
	{
		_Label1 = Yc3;
	}

	[SpecialName]
	internal virtual Label z6F()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6W(Label Si1)
	{
		Label val = (P = Si1);
	}

	[SpecialName]
	internal virtual Label e7T()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5C(Label Xs1)
	{
		_Label3 = Xs1;
	}

	[SpecialName]
	internal virtual Label Ks6()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo2(Label Ag3)
	{
		_Label4 = Ag3;
	}

	[SpecialName]
	internal virtual Label y2Z()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf4(Label c5A)
	{
		Label val = (D = c5A);
	}

	[SpecialName]
	internal virtual Label p2T()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2H(Label p2B)
	{
		_Label6 = p2B;
	}

	[SpecialName]
	internal virtual Label q9A()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt8(Label Qn1)
	{
		_Label7 = Qn1;
	}

	[SpecialName]
	internal virtual TextBox Bk3()
	{
		return _txtUsername;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je9(TextBox e3Y)
	{
		_txtUsername = e3Y;
	}

	[SpecialName]
	internal virtual TextBox i6K()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kg8(TextBox w9H)
	{
		TextBox val = (V = w9H);
	}

	[SpecialName]
	internal virtual TextBox c7L()
	{
		return _txtEmail;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wd3(TextBox Hq7)
	{
		_txtEmail = Hq7;
	}

	[SpecialName]
	internal virtual TextBox d8J()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xo5(TextBox Ha0)
	{
		TextBox val = (r = Ha0);
	}

	[SpecialName]
	internal virtual TextBox To7()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ha4(TextBox Fq5)
	{
		TextBox val = (Q = Fq5);
	}

	[SpecialName]
	internal virtual Button g8K()
	{
		return _btnAddUser;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6B(Button Xo2)
	{
		EventHandler eventHandler = s4D;
		Button btnAddUser = _btnAddUser;
		if (btnAddUser != null)
		{
			((Control)btnAddUser).remove_Click(eventHandler);
		}
		_btnAddUser = Xo2;
		btnAddUser = _btnAddUser;
		if (btnAddUser != null)
		{
			((Control)btnAddUser).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox i7J()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5M(ComboBox m4R)
	{
		EventHandler eventHandler = p6Z;
		ComboBox comboBox = _ComboBox1;
		if (comboBox != null)
		{
			comboBox.remove_SelectedIndexChanged(eventHandler);
		}
		_ComboBox1 = m4R;
		comboBox = _ComboBox1;
		if (comboBox != null)
		{
			comboBox.add_SelectedIndexChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ComboBox Tn2()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cz3(ComboBox Sb7)
	{
		ComboBox val = (s = Sb7);
	}

	[SpecialName]
	internal virtual Label Eg6()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2Q(Label Bd3)
	{
		Label val = (w = Bd3);
	}

	private void s4D(object sender, EventArgs e)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_042d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(((ButtonBase)g8K()).get_Text(), "Search", false) == 0)
		{
			Tx6(Bk3().get_Text());
			return;
		}
		string text = i6K().get_Text();
		string text2 = Bk3().get_Text();
		string text3 = c7L().get_Text();
		string text4 = d8J().get_Text();
		Conversions.ToString(i7J().get_SelectedItem());
		string text5 = To7().get_Text();
		if (Operators.CompareString(text, "", false) == 0)
		{
			MessageBox.Show("Please enter your name", "Invalid name");
			return;
		}
		bool flag = true;
		string text6 = text;
		foreach (char c in text6)
		{
			if (Operators.CompareString(Conversions.ToString(c), " ", false) != 0)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			MessageBox.Show("Please enter valid name", "Invalid Name");
			return;
		}
		string text7 = text;
		int num = 0;
		checked
		{
			while (true)
			{
				if (num < text7.Length)
				{
					char c2 = text7[num];
					if (!char.IsLower(c2) & !char.IsUpper(c2) & (Operators.CompareString(Conversions.ToString(c2), " ", false) != 0))
					{
						break;
					}
					num++;
					continue;
				}
				if (!Regex.IsMatch(text2, "^[a-zA-Z]+[0-9]+$"))
				{
					MessageBox.Show("Please enter a valid username", "Invalid email ID");
					return;
				}
				if (!Regex.IsMatch(text3, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
				{
					MessageBox.Show("Please enter a valid email ID", "Invalid email ID");
					return;
				}
				string text8 = text4;
				int num2 = 0;
				while (true)
				{
					if (num2 < text8.Length)
					{
						char c3 = text8[num2];
						if (!char.IsNumber(c3))
						{
							break;
						}
						num2++;
						continue;
					}
					if (text4.Length != 10)
					{
						MessageBox.Show("Your phone number should have 10 digits only", "Invalid phone number");
						return;
					}
					if (Operators.CompareString(((ButtonBase)g8K()).get_Text(), "ADD", false) == 0)
					{
						string text9 = text5;
						foreach (char c4 in text9)
						{
							if (Operators.CompareString(Conversions.ToString(c4), " ", false) == 0)
							{
								MessageBox.Show("Password should not contain blanks");
								return;
							}
						}
						if (Operators.CompareString(text5, "", false) == 0)
						{
							MessageBox.Show("Please enter the user's password");
							return;
						}
					}
					string connectionString = m2A.Forms.At0().connectionString;
					OleDbConnection val = new OleDbConnection(connectionString);
					val.Open();
					int num3 = ((!Operators.ConditionalCompareObjectEqual(Tn2().get_SelectedItem(), (object)"Student", false)) ? 10 : 7);
					string text10 = "defaultProfilePic.JPG";
					if (Operators.CompareString(((ButtonBase)g8K()).get_Text(), "ADD", false) == 0)
					{
						string text11 = "insert into Users (UserName, [Password]) values('" + Bk3().get_Text() + "', '" + p3S8.s4G1(To7().get_Text(), Bk3().get_Text()) + "')";
						OleDbCommand val2 = new OleDbCommand(text11, val);
						OleDbDataReader val3 = val2.ExecuteReader();
						val3.Close();
					}
					string text12 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("update Users Set ProfileName='" + i6K().get_Text() + "', Email='" + c7L().get_Text() + "', PhoneNumber='" + d8J().get_Text() + "', Department='"), i7J().get_SelectedItem()), (object)"', Designation='"), Tn2().get_SelectedItem()), (object)"', ProfileImage='"), (object)text10), (object)"', MaxBooks='"), (object)num3), (object)"' WHERE UserName='"), (object)Bk3().get_Text()), (object)"'"));
					OleDbCommand val4 = new OleDbCommand(text12, val);
					OleDbDataReader val5 = val4.ExecuteReader();
					MessageBox.Show("Success");
					val5.Close();
					val.Close();
					m2A.Forms.y3X().k6M4();
					return;
				}
				MessageBox.Show("You should enter only numerical digits in your phone number", "Invalid phone number");
				return;
			}
			MessageBox.Show("Your name should contain only lowercase, uppercase or blankspace letters.", "Invalid name");
		}
	}

	private void Di9(object sender, EventArgs e)
	{
		if (Operators.CompareString(m2A.Forms.y3X().Designation, "Admin", false) == 0)
		{
			Tn2().get_Items().Clear();
			Tn2().get_Items().Add((object)"Staff");
			i7J().get_Items().Clear();
			i7J().get_Items().Add((object)"Staff");
		}
		i7J().set_SelectedIndex(0);
		Tn2().set_SelectedIndex(0);
	}

	public bool Tx6(string An7)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (!Regex.IsMatch(An7, "^[a-zA-Z]+[0-9]+$"))
		{
			MessageBox.Show("Please enter a valid username", "Invalid email ID");
			return false;
		}
		string connectionString = m2A.Forms.At0().connectionString;
		OleDbConnection val = new OleDbConnection(connectionString);
		val.Open();
		string text = "SELECT * FROM Users WHERE UserName like '" + An7 + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		((ButtonBase)g8K()).set_Text("ADD");
		if (val3.get_HasRows())
		{
			val3.Read();
			if (Operators.ConditionalCompareObjectEqual(val3.get_Item("Designation"), (object)"Admin", false))
			{
				MessageBox.Show("You cannot access this account");
				Bk3().set_Text("");
				return false;
			}
			((ButtonBase)g8K()).set_Text("MODIFY");
			i6K().set_Text(Conversions.ToString(val3.get_Item("ProfileName")));
			c7L().set_Text(Conversions.ToString(val3.get_Item("Email")));
			d8J().set_Text(Conversions.ToString(val3.get_Item("PhoneNumber")));
			i7J().set_Text(Conversions.ToString(val3.get_Item("Department")));
			Tn2().set_Text(Conversions.ToString(val3.get_Item("Designation")));
			((Control)To7()).set_Enabled(false);
		}
		((Control)Bk3()).set_Enabled(false);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
				NewLateBinding.LateSet(objectValue, (Type)null, "visible", new object[1] { true }, (string[])null, (Type[])null);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		val.Close();
		return true;
	}

	internal static bool s0K()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string a5XR in array2)
				{
					if (!Jw8n.z3JZ(a5XR))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}

	private void p6Z(object sender, EventArgs e)
	{
	}
}
