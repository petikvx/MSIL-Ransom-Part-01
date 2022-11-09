using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using t0B;

namespace Ck0;

[DesignerGenerated]
public class g9B : UserControl
{
	private RadioButton _RadioButton2;

	private TextBox _TextBox1;

	private RadioButton _RadioButton4;

	internal IContainer B;

	internal DataGridView N;

	internal RadioButton t;

	internal Button O;

	internal RadioButton q;

	public g9B()
	{
		((UserControl)this).add_Load((EventHandler)q0C);
		q5Z();
	}

	protected override void Gp2(bool a0B)
	{
		try
		{
			if (a0B && B != null)
			{
				B.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(a0B);
		}
	}

	private void q5Z()
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
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_035f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		Kt2(new DataGridView());
		Bc9(new RadioButton());
		e6J(new RadioButton());
		t4D(new TextBox());
		Cy8(new Button());
		z8W(new RadioButton());
		Dd7(new RadioButton());
		((ISupportInitialize)Bm4()).BeginInit();
		((Control)this).SuspendLayout();
		Bm4().set_AllowUserToAddRows(false);
		Bm4().set_AllowUserToDeleteRows(false);
		Bm4().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Bm4()).set_Location(new Point(235, 49));
		((Control)Bm4()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)Bm4()).set_Name("DataGridView1");
		Bm4().set_ReadOnly(true);
		Bm4().get_RowTemplate().set_Height(24);
		((Control)Bm4()).set_Size(new Size(780, 588));
		((Control)Bm4()).set_TabIndex(0);
		((ButtonBase)x3S()).set_AutoSize(true);
		((Control)x3S()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x3S()).set_Location(new Point(29, 216));
		((Control)x3S()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)x3S()).set_Name("RadioButton1");
		((Control)x3S()).set_Size(new Size(63, 23));
		((Control)x3S()).set_TabIndex(1);
		x3S().set_TabStop(true);
		((ButtonBase)x3S()).set_Text("ISBN");
		((ButtonBase)x3S()).set_UseVisualStyleBackColor(true);
		((ButtonBase)r9Q()).set_AutoSize(true);
		((Control)r9Q()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)r9Q()).set_Location(new Point(29, 273));
		((Control)r9Q()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)r9Q()).set_Name("RadioButton2");
		((Control)r9Q()).set_Size(new Size(52, 23));
		((Control)r9Q()).set_TabIndex(2);
		r9Q().set_TabStop(true);
		((ButtonBase)r9Q()).set_Text("Acc");
		((ButtonBase)r9Q()).set_UseVisualStyleBackColor(true);
		((Control)x4S()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x4S()).set_Location(new Point(29, 167));
		((Control)x4S()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)x4S()).set_Name("TextBox1");
		((Control)x4S()).set_Size(new Size(180, 26));
		((Control)x4S()).set_TabIndex(4);
		((ButtonBase)Rz7()).set_BackColor(Color.MediumSeaGreen);
		((Control)Rz7()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)Rz7()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)Rz7()).set_FlatStyle((FlatStyle)1);
		((Control)Rz7()).set_Font(new Font("Times New Roman", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Rz7()).set_ForeColor(Color.White);
		((Control)Rz7()).set_Location(new Point(29, 340));
		((Control)Rz7()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)Rz7()).set_Name("Button1");
		((Control)Rz7()).set_Size(new Size(180, 35));
		((Control)Rz7()).set_TabIndex(5);
		((ButtonBase)Rz7()).set_Text("Search");
		((ButtonBase)Rz7()).set_UseVisualStyleBackColor(false);
		((ButtonBase)g4K()).set_AutoSize(true);
		((Control)g4K()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g4K()).set_Location(new Point(29, 302));
		((Control)g4K()).set_Margin(new Padding(2, 2, 2, 2));
		((Control)g4K()).set_Name("RadioButton3");
		((Control)g4K()).set_Size(new Size(77, 23));
		((Control)g4K()).set_TabIndex(6);
		g4K().set_TabStop(true);
		((ButtonBase)g4K()).set_Text("All Data");
		((ButtonBase)g4K()).set_UseVisualStyleBackColor(true);
		((ButtonBase)g8F()).set_AutoSize(true);
		((Control)g8F()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g8F()).set_Location(new Point(29, 244));
		((Control)g8F()).set_Margin(new Padding(2));
		((Control)g8F()).set_Name("RadioButton4");
		((Control)g8F()).set_Size(new Size(88, 23));
		((Control)g8F()).set_TabIndex(7);
		g8F().set_TabStop(true);
		((ButtonBase)g8F()).set_Text("Username");
		((ButtonBase)g8F()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)g8F());
		((Control)this).get_Controls().Add((Control)(object)g4K());
		((Control)this).get_Controls().Add((Control)(object)Rz7());
		((Control)this).get_Controls().Add((Control)(object)x4S());
		((Control)this).get_Controls().Add((Control)(object)r9Q());
		((Control)this).get_Controls().Add((Control)(object)x3S());
		((Control)this).get_Controls().Add((Control)(object)Bm4());
		((Control)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("viewBookTable");
		((Control)this).set_Size(new Size(1079, 681));
		((ISupportInitialize)Bm4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Bm4()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kt2(DataGridView Wa7)
	{
		DataGridView val = (N = Wa7);
	}

	[SpecialName]
	internal virtual RadioButton x3S()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc9(RadioButton x2Y)
	{
		EventHandler eventHandler = m2T;
		RadioButton val = t;
		if (val != null)
		{
			val.remove_CheckedChanged(eventHandler);
		}
		RadioButton val2 = (t = x2Y);
		val = t;
		if (val != null)
		{
			val.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual RadioButton r9Q()
	{
		return _RadioButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6J(RadioButton m2J)
	{
		EventHandler eventHandler = q1D;
		RadioButton radioButton = _RadioButton2;
		if (radioButton != null)
		{
			radioButton.remove_CheckedChanged(eventHandler);
		}
		_RadioButton2 = m2J;
		radioButton = _RadioButton2;
		if (radioButton != null)
		{
			radioButton.add_CheckedChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox x4S()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t4D(TextBox q4Z)
	{
		_TextBox1 = q4Z;
	}

	[SpecialName]
	internal virtual Button Rz7()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cy8(Button n4L)
	{
		EventHandler eventHandler = b6H;
		Button o = O;
		if (o != null)
		{
			((Control)o).remove_Click(eventHandler);
		}
		Button val = (O = n4L);
		o = O;
		if (o != null)
		{
			((Control)o).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual RadioButton g4K()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8W(RadioButton Yw6)
	{
		RadioButton val = (q = Yw6);
	}

	[SpecialName]
	internal virtual RadioButton g8F()
	{
		return _RadioButton4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd7(RadioButton Wq5)
	{
		_RadioButton4 = Wq5;
	}

	private void q0C(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		string connectionString = m2A.Forms.At0().connectionString;
		OleDbCommand val = new OleDbCommand();
		OleDbConnection val2 = new OleDbConnection(connectionString);
		val.set_Connection(val2);
		val.set_CommandType(CommandType.StoredProcedure);
		val.set_CommandText("myquery");
		OleDbDataAdapter val3 = new OleDbDataAdapter(val);
		DataSet dataSet = new DataSet();
		val2.Open();
		((DbDataAdapter)(object)val3).Fill(dataSet, "MyTable");
		Bm4().set_DataSource((object)dataSet);
		Bm4().set_DataMember("MyTable");
		val2.Close();
		g4K().set_Checked(true);
	}

	private void m2T(object sender, EventArgs e)
	{
	}

	private void q1D(object sender, EventArgs e)
	{
	}

	private void b6H(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		if (g4K().get_Checked() | (Operators.CompareString(x4S().get_Text(), "", false) == 0))
		{
			string connectionString = m2A.Forms.At0().connectionString;
			OleDbCommand val = new OleDbCommand();
			OleDbConnection val2 = new OleDbConnection(connectionString);
			val.set_Connection(val2);
			val.set_CommandType(CommandType.StoredProcedure);
			val.set_CommandText("myquery");
			OleDbDataAdapter val3 = new OleDbDataAdapter(val);
			DataSet dataSet = new DataSet();
			val2.Open();
			((DbDataAdapter)(object)val3).Fill(dataSet, "MyTable");
			Bm4().set_DataSource((object)dataSet);
			Bm4().set_DataMember("MyTable");
			val2.Close();
		}
		else if (r9Q().get_Checked() && Operators.CompareString(x4S().get_Text(), "", false) != 0)
		{
			string connectionString2 = m2A.Forms.At0().connectionString;
			string text = "SELECT AccNo,ISBN,BorrowerId as UserID,ReturnDate,IsIssued FROM Borrowed where AccNo = " + x4S().get_Text();
			OleDbConnection val4 = new OleDbConnection(connectionString2);
			OleDbDataAdapter val5 = new OleDbDataAdapter(text, val4);
			DataSet dataSet2 = new DataSet();
			val4.Open();
			((DbDataAdapter)(object)val5).Fill(dataSet2, "Table");
			Bm4().set_DataSource((object)dataSet2);
			Bm4().set_DataMember("Table");
			val4.Close();
		}
		else if (x3S().get_Checked() && Operators.CompareString(x4S().get_Text(), "", false) != 0)
		{
			string connectionString3 = m2A.Forms.At0().connectionString;
			string text2 = "SELECT AccNo,ISBN,BorrowerId as UserID,ReturnDate,IsIssued FROM Borrowed where ISBN = '" + x4S().get_Text() + "'";
			OleDbConnection val6 = new OleDbConnection(connectionString3);
			OleDbDataAdapter val7 = new OleDbDataAdapter(text2, val6);
			DataSet dataSet3 = new DataSet();
			val6.Open();
			((DbDataAdapter)(object)val7).Fill(dataSet3, "Table");
			Bm4().set_DataSource((object)dataSet3);
			Bm4().set_DataMember("Table");
			val6.Close();
		}
		else if (g8F().get_Checked() && Operators.CompareString(x4S().get_Text(), "", false) != 0)
		{
			string connectionString4 = m2A.Forms.At0().connectionString;
			string text3 = "SELECT AccNo,ISBN,BorrowerId as UserID,ReturnDate,IsIssued FROM Borrowed where BorrowerId like '%" + x4S().get_Text() + "%' and IsIssued=True";
			OleDbConnection val8 = new OleDbConnection(connectionString4);
			OleDbDataAdapter val9 = new OleDbDataAdapter(text3, val8);
			DataSet dataSet4 = new DataSet();
			val8.Open();
			((DbDataAdapter)(object)val9).Fill(dataSet4, "Table");
			Bm4().set_DataSource((object)dataSet4);
			Bm4().set_DataMember("Table");
			val8.Close();
		}
	}
}
