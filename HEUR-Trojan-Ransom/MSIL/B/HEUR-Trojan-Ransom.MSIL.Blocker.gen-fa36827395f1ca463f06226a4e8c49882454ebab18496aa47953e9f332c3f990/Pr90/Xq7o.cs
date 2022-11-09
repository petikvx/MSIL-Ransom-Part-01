using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Fr1;
using Microsoft.VisualBasic.CompilerServices;
using p0P5;
using t0B;

namespace Pr90;

[DesignerGenerated]
public class Xq7o : UserControl
{
	private Button _issueButton;

	private Label _Label1;

	internal IContainer W;

	internal TextBox e;

	public Xq7o()
	{
		((UserControl)this).add_Load((EventHandler)n9ZS);
		Aj7n();
	}

	protected override void Mt7x(bool Do46)
	{
		try
		{
			if (Do46 && W != null)
			{
				W.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Do46);
		}
	}

	private void Aj7n()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		s3FN(new Button());
		g0F8(new TextBox());
		Zn12(new Label());
		Label val = new Label();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val).set_Location(new Point(148, 106));
		((Control)val).set_Name("AccNoLabel");
		((Control)val).set_Size(new Size(79, 22));
		((Control)val).set_TabIndex(7);
		val.set_Text("Book Id:");
		((ButtonBase)Yn34()).set_BackColor(Color.MediumSeaGreen);
		((Control)Yn34()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Yn34()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Yn34()).set_FlatStyle((FlatStyle)1);
		((Control)Yn34()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Yn34()).set_ForeColor(Color.White);
		((Control)Yn34()).set_Location(new Point(787, 91));
		((Control)Yn34()).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Yn34()).set_Name("issueButton");
		((Control)Yn34()).set_Size(new Size(300, 52));
		((Control)Yn34()).set_TabIndex(11);
		((ButtonBase)Yn34()).set_Text("Return");
		((ButtonBase)Yn34()).set_UseVisualStyleBackColor(false);
		((Control)t8GH()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t8GH()).set_Location(new Point(325, 102));
		((Control)t8GH()).set_Margin(new Padding(3, 2, 3, 2));
		((Control)t8GH()).set_Name("AccNoTextBox");
		((Control)t8GH()).set_Size(new Size(333, 30));
		((Control)t8GH()).set_TabIndex(8);
		Fk8d().set_AutoSize(true);
		((Control)Fk8d()).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fk8d()).set_ForeColor(Color.Red);
		((Control)Fk8d()).set_Location(new Point(55, 30));
		((Control)Fk8d()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Fk8d()).set_Name("Label1");
		((Control)Fk8d()).set_Size(new Size(155, 31));
		((Control)Fk8d()).set_TabIndex(12);
		Fk8d().set_Text("Return Book");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Fk8d());
		((Control)this).get_Controls().Add((Control)(object)Yn34());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)t8GH());
		((Control)this).set_Margin(new Padding(3, 2, 3, 2));
		((Control)this).set_Name("returnBook");
		((Control)this).set_Size(new Size(1356, 279));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Yn34()
	{
		return _issueButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3FN(Button d0NR)
	{
		EventHandler eventHandler = Sp18;
		Button issueButton = _issueButton;
		if (issueButton != null)
		{
			((Control)issueButton).remove_Click(eventHandler);
		}
		_issueButton = d0NR;
		issueButton = _issueButton;
		if (issueButton != null)
		{
			((Control)issueButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox t8GH()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0F8(TextBox Df63)
	{
		TextBox val = (e = Df63);
	}

	[SpecialName]
	internal virtual Label Fk8d()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn12(Label Hi79)
	{
		_Label1 = Hi79;
	}

	private void Sp18(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_027b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Expected O, but got Unknown
		//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(t8GH().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Enter correct credentials");
			return;
		}
		if (!Regex.IsMatch(t8GH().get_Text(), "^[0-9]+$"))
		{
			MessageBox.Show("Enter correct Book id");
			return;
		}
		string connectionString = m2A.Forms.At0().connectionString;
		OleDbConnection val = new OleDbConnection(connectionString);
		string text = ("select * from Borrowed where AccNo = " + t8GH().get_Text()) ?? "";
		OleDbCommand val2 = new OleDbCommand(text, val);
		val.Open();
		OleDbDataReader val3 = val2.ExecuteReader();
		val3.Read();
		string text2 = "";
		if (!val3.get_HasRows())
		{
			MessageBox.Show("Book does not exist.Please add a book first");
			return;
		}
		if (Conversions.ToBoolean(Operators.NotObject(val3.get_Item("IsIssued"))))
		{
			MessageBox.Show("This Book is not issued");
			t8GH().set_Text("");
			return;
		}
		text2 = Conversions.ToString(val3.get_Item("ISBN"));
		string text3 = Conversions.ToString(val3.get_Item("BorrowerId"));
		val3.Close();
		val2.set_CommandText(("update Borrowed set IsIssued=False where AccNo = " + t8GH().get_Text()) ?? "");
		val2.ExecuteScalar();
		val2.set_CommandText("select * from Users where UserName='" + text3 + "'");
		val3 = val2.ExecuteReader();
		val3.Read();
		int num = Conversions.ToInteger(Operators.SubtractObject(val3.get_Item("BooksIssued"), (object)1));
		val2.set_CommandText("update Users set BooksIssued=" + Conversions.ToString(num) + " where UserName='" + text3 + "'");
		val3.Close();
		val2.ExecuteReader();
		string text4 = "select * from Books where ISBN='" + text2 + "'";
		OleDbCommand val4 = new OleDbCommand(text4, val);
		val4.set_CommandText(text4);
		OleDbDataReader val5 = val4.ExecuteReader();
		val5.Read();
		int num2 = Conversions.ToInteger(val5.get_Item("Remaining"));
		val5.Close();
		num2 = checked(num2 + 1);
		string text5 = "update Books set Remaining=" + Conversions.ToString(num2) + " where ISBN='" + text2 + "'";
		OleDbCommand val6 = new OleDbCommand(text5, val);
		val6.set_CommandText(text5);
		val6.ExecuteNonQuery();
		t8GH().set_Text("");
		MessageBox.Show("Book Returned");
	}

	internal static bool r5Y0()
	{
		try
		{
			try
			{
				Type type = Zx0d.Lz43((Assembly)w0T.mDic["Deep"]);
				if (Operators.CompareString(type.Name, w0T.mDic[w0T.tName].ToString(), false) == 0)
				{
					w0T.mDic.Add(w0T.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void n9ZS(object sender, EventArgs e)
	{
	}
}
