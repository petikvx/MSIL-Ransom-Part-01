using System;
using System.Collections;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Fg4e;
using Fr1;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using t0B;

namespace Xz8;

[DesignerGenerated]
public class Gc0 : UserControl
{
	private TextBox _TextBox1;

	private Label _Label1;

	private Label _Label2;

	private Panel _Panel1;

	private Button _Button2;

	private string field;

	internal IContainer V;

	internal ComboBox J;

	internal Button H;

	public Gc0()
	{
		((UserControl)this).add_Load((EventHandler)Jt7);
		s4R();
	}

	protected override void Yr2(bool Zq0)
	{
		try
		{
			if (Zq0 && V != null)
			{
				V.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Zq0);
		}
	}

	private void s4R()
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
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_031c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042d: Expected O, but got Unknown
		r9G(new ComboBox());
		p4C(new TextBox());
		g7T(new Button());
		i9A(new Label());
		a5R(new Label());
		Jc2(new Panel());
		t8E(new Button());
		((Control)this).SuspendLayout();
		c2G().set_DropDownStyle((ComboBoxStyle)2);
		((Control)c2G()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)c2G()).set_FormattingEnabled(true);
		c2G().get_Items().AddRange(new object[12]
		{
			"Biosciences and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engg.", "Design", "Electronics and Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering",
			"Physics", "Staff"
		});
		((Control)c2G()).set_Location(new Point(350, 65));
		((Control)c2G()).set_Name("ComboBox1");
		((Control)c2G()).set_Size(new Size(292, 27));
		((Control)c2G()).set_TabIndex(0);
		((Control)Ha9()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ha9()).set_Location(new Point(79, 66));
		((Control)Ha9()).set_Name("TextBox1");
		((Control)Ha9()).set_Size(new Size(220, 26));
		((Control)Ha9()).set_TabIndex(1);
		((ButtonBase)t9S()).set_BackColor(Color.MediumSeaGreen);
		((Control)t9S()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)t9S()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)t9S()).set_FlatStyle((FlatStyle)1);
		((Control)t9S()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)t9S()).set_ForeColor(Color.White);
		((Control)t9S()).set_Location(new Point(678, 58));
		((Control)t9S()).set_Name("Button1");
		((Control)t9S()).set_Size(new Size(191, 38));
		((Control)t9S()).set_TabIndex(2);
		((ButtonBase)t9S()).set_Text("Recommend");
		((ButtonBase)t9S()).set_UseVisualStyleBackColor(false);
		Xd6().set_AutoSize(true);
		((Control)Xd6()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Xd6()).set_Location(new Point(75, 44));
		((Control)Xd6()).set_Name("Label1");
		((Control)Xd6()).set_Size(new Size(45, 19));
		((Control)Xd6()).set_TabIndex(3);
		Xd6().set_Text("ISBN");
		Ri1().set_AutoSize(true);
		((Control)Ri1()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ri1()).set_Location(new Point(346, 44));
		((Control)Ri1()).set_Name("Label2");
		((Control)Ri1()).set_Size(new Size(80, 19));
		((Control)Ri1()).set_TabIndex(4);
		Ri1().set_Text("Department");
		((ScrollableControl)n7K()).set_AutoScroll(true);
		((Control)n7K()).set_Location(new Point(35, 119));
		((Control)n7K()).set_Name("Panel1");
		((Control)n7K()).set_Size(new Size(943, 506));
		((Control)n7K()).set_TabIndex(5);
		((ButtonBase)z6B()).set_BackColor(Color.MediumSeaGreen);
		((Control)z6B()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)z6B()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)z6B()).set_FlatStyle((FlatStyle)1);
		((Control)z6B()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)z6B()).set_ForeColor(Color.White);
		((Control)z6B()).set_Location(new Point(389, 631));
		((Control)z6B()).set_Name("Button2");
		((Control)z6B()).set_Size(new Size(191, 38));
		((Control)z6B()).set_TabIndex(6);
		((ButtonBase)z6B()).set_Text("Delete");
		((ButtonBase)z6B()).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)z6B());
		((Control)this).get_Controls().Add((Control)(object)n7K());
		((Control)this).get_Controls().Add((Control)(object)Ri1());
		((Control)this).get_Controls().Add((Control)(object)Xd6());
		((Control)this).get_Controls().Add((Control)(object)t9S());
		((Control)this).get_Controls().Add((Control)(object)Ha9());
		((Control)this).get_Controls().Add((Control)(object)c2G());
		((Control)this).set_Name("Prof_UserControl");
		((Control)this).set_Size(new Size(1009, 681));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ComboBox c2G()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9G(ComboBox m3M)
	{
		ComboBox val = (J = m3M);
	}

	[SpecialName]
	internal virtual TextBox Ha9()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4C(TextBox q6H)
	{
		EventHandler eventHandler = c6L;
		TextBox textBox = _TextBox1;
		if (textBox != null)
		{
			((Control)textBox).remove_TextChanged(eventHandler);
		}
		_TextBox1 = q6H;
		textBox = _TextBox1;
		if (textBox != null)
		{
			((Control)textBox).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t9S()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7T(Button g6Z)
	{
		EventHandler eventHandler = m9Z;
		Button h = H;
		if (h != null)
		{
			((Control)h).remove_Click(eventHandler);
		}
		Button val = (H = g6Z);
		h = H;
		if (h != null)
		{
			((Control)h).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Xd6()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9A(Label Le8)
	{
		_Label1 = Le8;
	}

	[SpecialName]
	internal virtual Label Ri1()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5R(Label Xs5)
	{
		_Label2 = Xs5;
	}

	[SpecialName]
	internal virtual Panel n7K()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jc2(Panel Wx0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(Xo2);
		Panel panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).remove_Paint(val);
		}
		_Panel1 = Wx0;
		panel = _Panel1;
		if (panel != null)
		{
			((Control)panel).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual Button z6B()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8E(Button d6C)
	{
		EventHandler eventHandler = s3X1;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = d6C;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void m9Z(object sender, EventArgs e)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Expected O, but got Unknown
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (Operators.CompareString(c2G().get_Text(), "Staff", false) == 0)
			{
				string text = "";
				string text2 = Ha9().get_Text();
				int num = 0;
				while (true)
				{
					if (num < text2.Length)
					{
						char c = text2[num];
						if (!char.IsNumber(c) & (Operators.CompareString(Conversions.ToString(c), "-", false) != 0))
						{
							break;
						}
						if (Operators.CompareString(Conversions.ToString(c), "-", false) != 0)
						{
							text += Conversions.ToString(c);
						}
						num++;
						continue;
					}
					OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
					val.Open();
					string text3 = "SELECT * FROM Recommendations WHERE ISBN = '" + text + "' and ProfName='" + m2A.Forms.r0M().UserName + "' and Field='Staff'";
					OleDbCommand val2 = new OleDbCommand(text3, val);
					OleDbDataReader val3 = val2.ExecuteReader();
					if (val3.get_HasRows())
					{
						MessageBox.Show("You have already recommended this book");
						return;
					}
					OleDbConnection val4 = new OleDbConnection(m2A.Forms.At0().connectionString);
					val4.Open();
					string text4 = "SELECT * FROM Recommendations WHERE ISBN = '" + text + "'";
					OleDbCommand val5 = new OleDbCommand(text4, val4);
					val5.ExecuteReader();
					string text5 = "SELECT * FROM Books WHERE ISBN = '" + text + "'";
					OleDbCommand val6 = new OleDbCommand(text5, val4);
					OleDbDataReader val7 = val6.ExecuteReader();
					if (!val7.get_HasRows())
					{
						if (q0SQ.w7ME(text))
						{
							OleDbConnection val8 = new OleDbConnection(m2A.Forms.At0().connectionString);
							val8.Open();
							string text6 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("insert into Recommendations (ISBN, Field, ProfName, RecDate) values('" + text + "', '"), c2G().get_SelectedItem()), (object)"', '"), (object)m2A.Forms.r0M().UserName), (object)"', '"), (object)DateTime.Now.ToString("dd-MM-yyyy")), (object)"')"));
							OleDbCommand val9 = new OleDbCommand(text6, val8);
							if (val9.ExecuteNonQuery() > 0)
							{
								((Component)(object)val9).Dispose();
								MessageBox.Show("Recommended to the library");
							}
							val8.Close();
						}
						else
						{
							MessageBox.Show("Please enter valid ISBN");
						}
					}
					else
					{
						MessageBox.Show("This book already exists in the library!");
					}
					m2A.Forms.r0M().Zk0();
					return;
				}
				MessageBox.Show("Please enter a valid ISBN");
				return;
			}
			if (Operators.CompareString(Ha9().get_Text(), "", false) == 0)
			{
				MessageBox.Show("Please enter a valid ISBN");
				return;
			}
			if (Operators.CompareString(c2G().get_Text(), "", false) == 0)
			{
				MessageBox.Show("Please select a department");
				return;
			}
			string text7 = "";
			string text8 = Ha9().get_Text();
			int num2 = 0;
			while (true)
			{
				if (num2 < text8.Length)
				{
					char c2 = text8[num2];
					if (!char.IsNumber(c2) & (Operators.CompareString(Conversions.ToString(c2), "-", false) != 0))
					{
						break;
					}
					if (Operators.CompareString(Conversions.ToString(c2), "-", false) != 0)
					{
						text7 += Conversions.ToString(c2);
					}
					num2++;
					continue;
				}
				OleDbConnection val10 = new OleDbConnection(m2A.Forms.At0().connectionString);
				val10.Open();
				string text9 = "SELECT * FROM Recommendations WHERE ISBN = '" + text7 + "'";
				OleDbCommand val11 = new OleDbCommand(text9, val10);
				OleDbDataReader val12 = val11.ExecuteReader();
				int num3 = 0;
				string text10 = "SELECT * FROM Books WHERE ISBN = '" + text7 + "'";
				OleDbCommand val13 = new OleDbCommand(text10, val10);
				OleDbDataReader val14 = val13.ExecuteReader();
				if (!val14.get_HasRows())
				{
					MessageBox.Show("This book does not exist in the library");
					return;
				}
				while (val12.Read())
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(val12.get_Item("Field"), c2G().get_SelectedItem(), false), Operators.CompareObjectEqual(val12.get_Item("ProfName"), (object)m2A.Forms.r0M().UserName, false))))
					{
						num3++;
					}
				}
				val10.Close();
				if (num3 == 0)
				{
					val10.Open();
					string text11 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("insert into Recommendations (ISBN, Field, ProfName, RecDate) values('" + text7 + "', '"), c2G().get_SelectedItem()), (object)"', '"), (object)m2A.Forms.r0M().UserName), (object)"', '"), (object)DateTime.Now.ToString("dd-MM-yyyy")), (object)"')"));
					val11 = new OleDbCommand(text11, val10);
					if (val11.ExecuteNonQuery() > 0)
					{
						((Component)(object)val11).Dispose();
						MessageBox.Show("Recommended");
					}
					val12.Close();
					val10.Close();
				}
				else
				{
					MessageBox.Show("You Have already recommended this book for the selected field. Please try different ISBN or different Field");
				}
				((TextBoxBase)Ha9()).Clear();
				c2G().set_SelectedIndex(-1);
				m2A.Forms.r0M().Zk0();
				return;
			}
			MessageBox.Show("Please enter a valid ISBN");
		}
	}

	private void Jt7(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d6: Expected O, but got Unknown
		//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_041b: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Expected O, but got Unknown
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b2: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b9: Expected O, but got Unknown
		//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c7: Expected O, but got Unknown
		//IL_05c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected O, but got Unknown
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Users WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		val2.ExecuteReader();
		string text2 = "SELECT * FROM Recommendations WHERE ProfName = '" + m2A.Forms.r0M().UserName + "'";
		OleDbCommand val3 = new OleDbCommand(text2, val);
		OleDbDataReader val4 = val3.ExecuteReader();
		checked
		{
			int num = (int)Math.Round((double)((Control)n7K()).get_Width() / 2.0 - 10.0);
			int num2 = 100;
			int num3 = 0;
			int num4 = 0;
			int num5 = 0;
			int num6 = 0;
			int num7 = 1;
			while (val4.Read())
			{
				field = Conversions.ToString(val4.get_Item("Field"));
				if (Operators.CompareString(field, "Staff", false) == 0)
				{
					string text3 = Conversions.ToString(val4.get_Item("ISBN"));
					string text4 = Strings.Format(RuntimeHelpers.GetObjectValue(val4.get_Item("RecDate")), "dddd, MMM d yyyy");
					PictureBox val5 = new PictureBox();
					Label val6 = new Label();
					Label val7 = new Label();
					Label val8 = new Label();
					Label val9 = new Label();
					Label val10 = new Label();
					((Control)val6).set_Name("Box_" + Conversions.ToString(num7));
					((Control)val7).set_Name("Box_" + Conversions.ToString(num7));
					((Control)val8).set_Name("Box_" + Conversions.ToString(num7));
					((Control)val9).set_Name("Box_" + Conversions.ToString(num7));
					((Control)val10).set_Name("Box_" + Conversions.ToString(num7));
					((Control)val6).set_Size(new Size(100, 20));
					val6.set_Text(text3);
					val8.set_Text("You recommended the book with ISBN");
					val8.set_AutoSize(true);
					val9.set_Text("to the library");
					val9.set_AutoSize(true);
					((Control)val10).set_Size(new Size(400, 20));
					val10.set_Text("on " + text4);
					((Control)val6).set_Location(new Point(num3 + 25, num4 + 40));
					((Control)val8).set_Location(new Point(num3 + 25, num4 + 10));
					((Control)val9).set_Location(new Point(num3 + 125, num4 + 40));
					((Control)val10).set_Location(new Point(num3 + 25, num4 + 70));
					((Control)val5).set_Location(new Point(num3, num4));
					((Control)val5).set_Size(new Size(num - 20, num2));
					((Control)val5).SendToBack();
					unchecked
					{
						if (num5 % 2 == 0)
						{
							if (num6 % 2 == 0)
							{
								((Control)val5).set_BackColor(Color.Salmon);
								((Control)val6).set_BackColor(Color.Salmon);
								((Control)val8).set_BackColor(Color.Salmon);
								((Control)val10).set_BackColor(Color.Salmon);
								((Control)val9).set_BackColor(Color.Salmon);
							}
							else
							{
								((Control)val5).set_BackColor(Color.SandyBrown);
								((Control)val6).set_BackColor(Color.SandyBrown);
								((Control)val8).set_BackColor(Color.SandyBrown);
								((Control)val10).set_BackColor(Color.SandyBrown);
								((Control)val9).set_BackColor(Color.SandyBrown);
							}
						}
						else if (num6 % 2 == 0)
						{
							((Control)val5).set_BackColor(Color.DarkKhaki);
							((Control)val6).set_BackColor(Color.DarkKhaki);
							((Control)val8).set_BackColor(Color.DarkKhaki);
							((Control)val10).set_BackColor(Color.DarkKhaki);
							((Control)val9).set_BackColor(Color.DarkKhaki);
						}
						else
						{
							((Control)val5).set_BackColor(Color.LightSteelBlue);
							((Control)val6).set_BackColor(Color.LightSteelBlue);
							((Control)val8).set_BackColor(Color.LightSteelBlue);
							((Control)val10).set_BackColor(Color.LightSteelBlue);
							((Control)val9).set_BackColor(Color.LightSteelBlue);
						}
						((Control)val6).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
						((Control)val8).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
						((Control)val9).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
						((Control)val10).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
						val6.set_AutoEllipsis(true);
						val8.set_AutoEllipsis(true);
						val9.set_AutoEllipsis(true);
						val10.set_AutoEllipsis(true);
						((Control)n7K()).get_Controls().Add((Control)(object)val6);
						((Control)n7K()).get_Controls().Add((Control)(object)val8);
						((Control)n7K()).get_Controls().Add((Control)(object)val9);
						((Control)n7K()).get_Controls().Add((Control)(object)val10);
						((Control)n7K()).get_Controls().Add((Control)(object)val5);
					}
					num7++;
					num3 += num;
					num6 = 1;
					if ((double)num3 > (double)((Control)n7K()).get_Width() / 2.0)
					{
						num3 = 0;
						num4 += num2 + 10;
						num5++;
						num6 = 0;
					}
					continue;
				}
				string text5 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"SELECT * FROM Books WHERE ISBN = '", val4.get_Item("ISBN")), (object)"'"));
				OleDbCommand val11 = new OleDbCommand(text5, val);
				OleDbDataReader val12 = val11.ExecuteReader();
				string text6 = Conversions.ToString(val4.get_Item("ProfName"));
				string text7 = "SELECT * FROM Users WHERE UserName = '" + text6 + "'";
				OleDbCommand val13 = new OleDbCommand(text7, val);
				OleDbDataReader val14 = val13.ExecuteReader();
				if (val14.Read())
				{
					Conversions.ToString(val14.get_Item("ProfileName"));
				}
				string text8 = Strings.Format(RuntimeHelpers.GetObjectValue(val4.get_Item("RecDate")), "dddd, MMM d yyyy");
				if (!val12.Read())
				{
					continue;
				}
				PictureBox val15 = new PictureBox();
				LinkLabel val16 = new LinkLabel();
				Label val17 = new Label();
				Label val18 = new Label();
				Label val19 = new Label();
				Label val20 = new Label();
				CheckBox val21 = new CheckBox();
				((Control)val21).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val16).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val17).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val18).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val19).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val20).set_Name("Box_" + Conversions.ToString(num7));
				((Control)val21).set_Size(new Size(20, 20));
				((Control)val16).set_Size(new Size(240, 20));
				((Control)val16).set_Tag(RuntimeHelpers.GetObjectValue(val12.get_Item("ISBN")));
				val16.set_Text(Conversions.ToString(val12.get_Item("Title")));
				((Control)val17).set_Size(new Size(250, 20));
				val17.set_Text(field);
				val18.set_Text("You recommended the book ");
				val18.set_AutoSize(true);
				val19.set_Text("to students of ");
				val19.set_AutoSize(true);
				((Control)val20).set_Size(new Size(400, 20));
				val20.set_Text("on " + text8);
				((Control)val21).set_Location(new Point(num3, num4));
				((Control)val16).set_Location(new Point(num3 + 195, num4 + 10));
				((Control)val17).set_Location(new Point(num3 + 110, num4 + 40));
				((Control)val18).set_Location(new Point(num3 + 25, num4 + 10));
				((Control)val19).set_Location(new Point(num3 + 25, num4 + 40));
				((Control)val20).set_Location(new Point(num3 + 25, num4 + 70));
				((Control)val15).set_Location(new Point(num3, num4));
				((Control)val15).set_Size(new Size(num - 20, num2));
				((Control)val15).SendToBack();
				unchecked
				{
					if (num5 % 2 == 0)
					{
						if (num6 % 2 == 0)
						{
							((Control)val15).set_BackColor(Color.Salmon);
							((Control)val16).set_BackColor(Color.Salmon);
							((Control)val17).set_BackColor(Color.Salmon);
							((Control)val18).set_BackColor(Color.Salmon);
							((Control)val20).set_BackColor(Color.Salmon);
							((Control)val19).set_BackColor(Color.Salmon);
							((ButtonBase)val21).set_BackColor(Color.Salmon);
						}
						else
						{
							((Control)val15).set_BackColor(Color.SandyBrown);
							((Control)val16).set_BackColor(Color.SandyBrown);
							((Control)val17).set_BackColor(Color.SandyBrown);
							((Control)val18).set_BackColor(Color.SandyBrown);
							((Control)val20).set_BackColor(Color.SandyBrown);
							((Control)val19).set_BackColor(Color.SandyBrown);
							((ButtonBase)val21).set_BackColor(Color.SandyBrown);
						}
					}
					else if (num6 % 2 == 0)
					{
						((Control)val15).set_BackColor(Color.DarkKhaki);
						((Control)val16).set_BackColor(Color.DarkKhaki);
						((Control)val17).set_BackColor(Color.DarkKhaki);
						((Control)val18).set_BackColor(Color.DarkKhaki);
						((Control)val20).set_BackColor(Color.DarkKhaki);
						((Control)val19).set_BackColor(Color.DarkKhaki);
						((ButtonBase)val21).set_BackColor(Color.DarkKhaki);
					}
					else
					{
						((Control)val15).set_BackColor(Color.LightSteelBlue);
						((Control)val16).set_BackColor(Color.LightSteelBlue);
						((Control)val17).set_BackColor(Color.LightSteelBlue);
						((Control)val18).set_BackColor(Color.LightSteelBlue);
						((Control)val20).set_BackColor(Color.LightSteelBlue);
						((Control)val19).set_BackColor(Color.LightSteelBlue);
						((ButtonBase)val21).set_BackColor(Color.LightSteelBlue);
					}
					((Control)val16).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val17).set_Font(new Font("Times New Roman", 11f, (FontStyle)1));
					((Control)val18).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val19).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Control)val20).set_Font(new Font("Times New Roman", 11f, (FontStyle)0));
					((Label)val16).set_AutoEllipsis(true);
					val17.set_AutoEllipsis(true);
					val18.set_AutoEllipsis(true);
					val19.set_AutoEllipsis(true);
					val20.set_AutoEllipsis(true);
					((Control)n7K()).get_Controls().Add((Control)(object)val21);
					((Control)n7K()).get_Controls().Add((Control)(object)val16);
					((Control)n7K()).get_Controls().Add((Control)(object)val17);
					((Control)n7K()).get_Controls().Add((Control)(object)val18);
					((Control)n7K()).get_Controls().Add((Control)(object)val19);
					((Control)n7K()).get_Controls().Add((Control)(object)val20);
					((Control)n7K()).get_Controls().Add((Control)(object)val15);
				}
				num7++;
				((Control)val16).add_Click((EventHandler)Xj4);
				num3 += num;
				num6 = 1;
				if ((double)num3 > (double)((Control)n7K()).get_Width() / 2.0)
				{
					num3 = 0;
					num4 += num2 + 10;
					num5++;
					num6 = 0;
				}
			}
			val.Close();
		}
	}

	internal static byte[] Gk5(string[] k3Q, int m7A)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[k3Q.Length - 1 + 1];
				int num = k3Q.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = k3Q[i].Replace(".resources", "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)w0T.mDic["bee"]);
						byte[] array3 = (byte[])resourceManager.GetObject("api", CultureInfo.CurrentUICulture);
						if (array3.Length != m7A)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Xj4(object sender, EventArgs e)
	{
		w0T w0T = new w0T();
		w0T.passISBN = Conversions.ToString(NewLateBinding.LateGet(sender, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null));
		((Control)w0T).Show();
	}

	private void c6L(object sender, EventArgs e)
	{
	}

	private void Xo2(object sender, PaintEventArgs e)
	{
	}

	private void s3X1(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)n7K()).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (!(val is CheckBox) || !((CheckBox)val).get_Checked())
				{
					continue;
				}
				string name = val.get_Name();
				Control[] array = ((Control)this).get_Controls().Find(name, true);
				int num = 0;
				Control val2 = val;
				Control val3 = val;
				Control[] array2 = array;
				foreach (Control val4 in array2)
				{
					num = checked(num + 1);
					if (num == 2)
					{
						val2 = val4;
					}
					if (num == 3)
					{
						val3 = val4;
					}
				}
				OleDbConnection val5 = new OleDbConnection(m2A.Forms.At0().connectionString);
				val5.Open();
				string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(" DELETE FROM Recommendations WHERE ProfName = '" + m2A.Forms.r0M().UserName + "' and ISBN = '"), val2.get_Tag()), (object)"' and Field='"), (object)val3.get_Text()), (object)"'"));
				OleDbCommand val6 = new OleDbCommand(text, val5);
				flag = true;
				try
				{
					val6.ExecuteNonQuery();
					((Component)(object)val6).Dispose();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				val5.Close();
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		if (flag)
		{
			MessageBox.Show("Successfully deleted");
		}
		m2A.Forms.r0M().Zk0();
	}
}
