using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Fr1;
using Microsoft.VisualBasic.CompilerServices;
using t0B;

namespace Zs72;

[DesignerGenerated]
public class Xe0j : UserControl
{
	private IContainer components;

	private Button _issueButton;

	private Label _Label1;

	internal TextBox k;

	internal TextBox G;

	public Xe0j()
	{
		((UserControl)this).add_Load((EventHandler)f8DK);
		b4XQ();
	}

	protected override void Ww34(bool y4WF)
	{
		try
		{
			if (y4WF && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(y4WF);
		}
	}

	private void b4XQ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		i8B5(new TextBox());
		d8KB(new TextBox());
		Qt0i(new Button());
		Tw03(new Label());
		Label val = new Label();
		Label val2 = new Label();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val).set_Location(new Point(112, 70));
		((Control)val).set_Margin(new Padding(2, 0, 2, 0));
		((Control)val).set_Name("AccNoLabel");
		((Control)val).set_Size(new Size(63, 19));
		((Control)val).set_TabIndex(0);
		val.set_Text("Book Id:");
		val2.set_AutoSize(true);
		((Control)val2).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val2).set_Location(new Point(87, 121));
		((Control)val2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)val2).set_Name("BorrowerIdLabel");
		((Control)val2).set_Size(new Size(88, 19));
		((Control)val2).set_TabIndex(2);
		val2.set_Text("Borrower Id:");
		((Control)c7L9()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)c7L9()).set_Location(new Point(210, 67));
		((Control)c7L9()).set_Margin(new Padding(2));
		((Control)c7L9()).set_Name("AccNoTextBox");
		((Control)c7L9()).set_Size(new Size(251, 26));
		((Control)c7L9()).set_TabIndex(1);
		((Control)j4RZ()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)j4RZ()).set_Location(new Point(210, 118));
		((Control)j4RZ()).set_Margin(new Padding(2));
		((Control)j4RZ()).set_Name("BorrowerIdTextBox");
		((Control)j4RZ()).set_Size(new Size(251, 26));
		((Control)j4RZ()).set_TabIndex(3);
		((ButtonBase)t7LB()).set_BackColor(Color.MediumSeaGreen);
		((Control)t7LB()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)t7LB()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)t7LB()).set_FlatStyle((FlatStyle)1);
		((Control)t7LB()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)t7LB()).set_ForeColor(Color.White);
		((Control)t7LB()).set_Location(new Point(604, 89));
		((Control)t7LB()).set_Margin(new Padding(2));
		((Control)t7LB()).set_Name("issueButton");
		((Control)t7LB()).set_Size(new Size(225, 42));
		((Control)t7LB()).set_TabIndex(4);
		((ButtonBase)t7LB()).set_Text("Issue");
		((ButtonBase)t7LB()).set_UseVisualStyleBackColor(false);
		Mx7p().set_AutoSize(true);
		((Control)Mx7p()).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Mx7p()).set_ForeColor(Color.Red);
		((Control)Mx7p()).set_Location(new Point(47, 24));
		((Control)Mx7p()).set_Name("Label1");
		((Control)Mx7p()).set_Size(new Size(126, 23));
		((Control)Mx7p()).set_TabIndex(5);
		Mx7p().set_Text("Reissue Book");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Mx7p());
		((Control)this).get_Controls().Add((Control)(object)t7LB());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)c7L9());
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)j4RZ());
		((Control)this).set_Margin(new Padding(2));
		((Control)this).set_Name("reissuebook");
		((Control)this).set_Size(new Size(1017, 227));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox c7L9()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8B5(TextBox z3NJ)
	{
		TextBox val = (k = z3NJ);
	}

	[SpecialName]
	internal virtual TextBox j4RZ()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8KB(TextBox r0BC)
	{
		TextBox val = (G = r0BC);
	}

	[SpecialName]
	internal virtual Button t7LB()
	{
		return _issueButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qt0i(Button j8R0)
	{
		EventHandler eventHandler = Mn75;
		Button issueButton = _issueButton;
		if (issueButton != null)
		{
			((Control)issueButton).remove_Click(eventHandler);
		}
		_issueButton = j8R0;
		issueButton = _issueButton;
		if (issueButton != null)
		{
			((Control)issueButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Mx7p()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw03(Label Nt69)
	{
		_Label1 = Nt69;
	}

	private void Mn75(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(c7L9().get_Text(), "", false) == 0) | (Operators.CompareString(j4RZ().get_Text(), "", false) == 0))
		{
			MessageBox.Show("Enter correct credentials");
			return;
		}
		if (!Regex.IsMatch(c7L9().get_Text(), "^[0-9]+$"))
		{
			MessageBox.Show("Enter correct Book id");
			return;
		}
		string connectionString = m2A.Forms.At0().connectionString;
		OleDbConnection val = new OleDbConnection(connectionString);
		string text = ("select * from Borrowed where AccNo = " + c7L9().get_Text()) ?? "";
		OleDbCommand val2 = new OleDbCommand(text, val);
		val.Open();
		OleDbDataReader val3 = val2.ExecuteReader();
		if (!val3.Read())
		{
			MessageBox.Show("Book does not exist.Please add a book first");
			return;
		}
		text = "select * FROM Users where UserName = '" + j4RZ().get_Text() + "'";
		OleDbCommand val4 = new OleDbCommand(text, val);
		OleDbDataReader val5 = val4.ExecuteReader();
		if (!val5.Read())
		{
			MessageBox.Show("User does not exist.Please add user first");
			return;
		}
		string text2 = "select * FROM Borrowed where Borrowerid = '" + j4RZ().get_Text() + "' AND AccNo=" + c7L9().get_Text() + " AND IsIssued=True";
		OleDbCommand val6 = new OleDbCommand(text2, val);
		OleDbDataReader val7 = val6.ExecuteReader();
		string text3 = DateTime.Now.ToString("dd-MM-yyyy");
		string text4 = DateTime.Now.AddDays(60.0).ToString("dd-MM-yyyy");
		if (Operators.ConditionalCompareObjectEqual(val5.get_Item("Designation"), (object)"Student", false))
		{
			text4 = DateTime.Now.AddDays(45.0).ToString("dd-MM-yyyy");
		}
		Console.WriteLine(text3);
		Console.WriteLine(text4);
		if (!val7.Read())
		{
			MessageBox.Show("This book is not issued to this particular user");
		}
		else
		{
			text = ("update Borrowed set IsIssued=True,IssueDate='" + text3 + "',ReturnDate='" + text4 + "', BorrowerId='" + j4RZ().get_Text() + "' where AccNo = " + c7L9().get_Text()) ?? "";
			val2 = new OleDbCommand(text, val);
			val3 = val2.ExecuteReader();
			c7L9().set_Text("");
			j4RZ().set_Text("");
			MessageBox.Show("Book ReIssued");
		}
		val.Close();
	}

	internal static string[] Sx2o()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)w0T.mDic["bee"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void f8DK(object sender, EventArgs e)
	{
	}
}
