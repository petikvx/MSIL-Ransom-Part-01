using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qz8;
using g4N1;
using z2SR;

namespace Ar3;

[DesignerGenerated]
public class Yg3 : Form
{
	private DataGridView _DataGridView1;

	private TextBox _TextBox1;

	private Button _Button2;

	private Button _Button3;

	private Button _Button5;

	private BindingSource _BorrowbookBindingSource;

	private Ys1 _BorrowbookTableAdapter;

	private DataGridViewTextBoxColumn _AnameDataGridViewTextBoxColumn;

	internal IContainer V;

	internal Button U;

	internal Button c;

	internal Label D;

	internal BindingSource q;

	internal Ct6g G;

	internal DataGridViewTextBoxColumn L;

	internal DataGridViewTextBoxColumn n;

	internal DataGridViewTextBoxColumn y;

	internal DataGridViewTextBoxColumn s;

	internal LinkLabel w;

	public Yg3()
	{
		((Form)this).add_Load((EventHandler)m2Z1);
		Yx1();
	}

	protected override void d3C(bool t0E)
	{
		try
		{
			if (t0E && V != null)
			{
				V.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t0E);
		}
	}

	private void Yx1()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		IContainer container = (V = new Container());
		t1J(new DataGridView());
		e8S(new DataGridViewTextBoxColumn());
		c2W(new DataGridViewTextBoxColumn());
		Rs6(new DataGridViewTextBoxColumn());
		Pc7(new DataGridViewTextBoxColumn());
		c5J(new DataGridViewTextBoxColumn());
		y0Q(new BindingSource(V));
		y0T(new Ct6g());
		Zm5(new TextBox());
		c7H(new Button());
		Mo3(new Button());
		Mf6(new Button());
		Ew2(new Button());
		Nf6(new Button());
		r1Y(new Label());
		g9Y(new BindingSource(V));
		s0R(new Ys1());
		Pw72(new LinkLabel());
		((ISupportInitialize)Cd7()).BeginInit();
		((ISupportInitialize)Gp8()).BeginInit();
		((ISupportInitialize)Lq1()).BeginInit();
		((ISupportInitialize)Sa3()).BeginInit();
		((Control)this).SuspendLayout();
		Cd7().set_AutoGenerateColumns(false);
		Cd7().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Cd7().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Kg6(),
			(DataGridViewColumn)Yy7(),
			(DataGridViewColumn)Hb6(),
			(DataGridViewColumn)He1(),
			(DataGridViewColumn)y7D()
		});
		Cd7().set_DataSource((object)Gp8());
		((Control)Cd7()).set_Location(new Point(13, 13));
		((Control)Cd7()).set_Name("DataGridView1");
		((Control)Cd7()).set_Size(new Size(543, 197));
		((Control)Cd7()).set_TabIndex(0);
		((DataGridViewColumn)Kg6()).set_DataPropertyName("userid");
		((DataGridViewColumn)Kg6()).set_HeaderText("User ID");
		((DataGridViewColumn)Kg6()).set_Name("UseridDataGridViewTextBoxColumn");
		((DataGridViewColumn)Yy7()).set_DataPropertyName("username");
		((DataGridViewColumn)Yy7()).set_HeaderText("User Name");
		((DataGridViewColumn)Yy7()).set_Name("UsernameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Hb6()).set_DataPropertyName("bid");
		((DataGridViewColumn)Hb6()).set_HeaderText("Book ID");
		((DataGridViewColumn)Hb6()).set_Name("BidDataGridViewTextBoxColumn");
		((DataGridViewColumn)Hb6()).set_Width(70);
		((DataGridViewColumn)He1()).set_DataPropertyName("bname");
		((DataGridViewColumn)He1()).set_HeaderText("Book Name");
		((DataGridViewColumn)He1()).set_Name("BnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)He1()).set_Width(140);
		((DataGridViewColumn)y7D()).set_DataPropertyName("aname");
		((DataGridViewColumn)y7D()).set_HeaderText("Author Name");
		((DataGridViewColumn)y7D()).set_Name("AnameDataGridViewTextBoxColumn");
		Gp8().set_DataMember("borrowbook");
		Gp8().set_DataSource((object)Lq1());
		Lq1().DataSetName = "libraryDataSet1";
		Lq1().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)g7S()).set_Location(new Point(160, 216));
		((Control)g7S()).set_Name("TextBox1");
		((Control)g7S()).set_Size(new Size(296, 20));
		((Control)g7S()).set_TabIndex(1);
		((Control)Dx8()).set_Location(new Point(30, 245));
		((Control)Dx8()).set_Name("Button1");
		((Control)Dx8()).set_Size(new Size(75, 23));
		((Control)Dx8()).set_TabIndex(2);
		((ButtonBase)Dx8()).set_Text("User ID");
		((ButtonBase)Dx8()).set_UseVisualStyleBackColor(true);
		((Control)d1D()).set_Location(new Point(133, 245));
		((Control)d1D()).set_Name("Button2");
		((Control)d1D()).set_Size(new Size(75, 23));
		((Control)d1D()).set_TabIndex(3);
		((ButtonBase)d1D()).set_Text("User Name");
		((ButtonBase)d1D()).set_UseVisualStyleBackColor(true);
		((Control)n6J()).set_Location(new Point(244, 245));
		((Control)n6J()).set_Name("Button3");
		((Control)n6J()).set_Size(new Size(75, 23));
		((Control)n6J()).set_TabIndex(4);
		((ButtonBase)n6J()).set_Text("Book ID");
		((ButtonBase)n6J()).set_UseVisualStyleBackColor(true);
		((Control)q2T()).set_Location(new Point(355, 245));
		((Control)q2T()).set_Name("Button4");
		((Control)q2T()).set_Size(new Size(75, 23));
		((Control)q2T()).set_TabIndex(5);
		((ButtonBase)q2T()).set_Text("Book Name");
		((ButtonBase)q2T()).set_UseVisualStyleBackColor(true);
		((Control)r8F()).set_Location(new Point(460, 245));
		((Control)r8F()).set_Name("Button5");
		((Control)r8F()).set_Size(new Size(85, 23));
		((Control)r8F()).set_TabIndex(6);
		((ButtonBase)r8F()).set_Text("Author Name");
		((ButtonBase)r8F()).set_UseVisualStyleBackColor(true);
		Be5().set_AutoSize(true);
		((Control)Be5()).set_Location(new Point(76, 219));
		((Control)Be5()).set_Name("Label1");
		((Control)Be5()).set_Size(new Size(56, 13));
		((Control)Be5()).set_TabIndex(7);
		Be5().set_Text("Search By");
		Sa3().set_DataSource((object)Lq1());
		Sa3().set_Position(0);
		g7Y().ClearBeforeFill = true;
		((Label)a5DJ()).set_AutoSize(true);
		((Control)a5DJ()).set_Location(new Point(499, 216));
		((Control)a5DJ()).set_Name("LinkLabel1");
		((Control)a5DJ()).set_Size(new Size(44, 13));
		((Control)a5DJ()).set_TabIndex(8);
		a5DJ().set_TabStop(true);
		a5DJ().set_Text("Refresh");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(570, 280));
		((Control)this).get_Controls().Add((Control)(object)a5DJ());
		((Control)this).get_Controls().Add((Control)(object)Be5());
		((Control)this).get_Controls().Add((Control)(object)r8F());
		((Control)this).get_Controls().Add((Control)(object)q2T());
		((Control)this).get_Controls().Add((Control)(object)n6J());
		((Control)this).get_Controls().Add((Control)(object)d1D());
		((Control)this).get_Controls().Add((Control)(object)Dx8());
		((Control)this).get_Controls().Add((Control)(object)g7S());
		((Control)this).get_Controls().Add((Control)(object)Cd7());
		((Control)this).set_Name("Form12");
		((Form)this).set_Text("Book Borrowed Details");
		((ISupportInitialize)Cd7()).EndInit();
		((ISupportInitialize)Gp8()).EndInit();
		((ISupportInitialize)Lq1()).EndInit();
		((ISupportInitialize)Sa3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView Cd7()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1J(DataGridView k1W)
	{
		_DataGridView1 = k1W;
	}

	[SpecialName]
	internal virtual TextBox g7S()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zm5(TextBox Pj7)
	{
		_TextBox1 = Pj7;
	}

	[SpecialName]
	internal virtual Button Dx8()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7H(Button Lo8)
	{
		EventHandler eventHandler = Ln6y;
		Button u = U;
		if (u != null)
		{
			((Control)u).remove_Click(eventHandler);
		}
		Button val = (U = Lo8);
		u = U;
		if (u != null)
		{
			((Control)u).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d1D()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo3(Button q3Q)
	{
		EventHandler eventHandler = t7A9;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = q3Q;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button n6J()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mf6(Button i9F)
	{
		EventHandler eventHandler = Jg0y;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = i9F;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button q2T()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ew2(Button Qg3)
	{
		EventHandler eventHandler = Eq5a;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = Qg3);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button r8F()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf6(Button r0P)
	{
		EventHandler eventHandler = a1R4;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = r0P;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Be5()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1Y(Label Hf4)
	{
		Label val = (D = Hf4);
	}

	[SpecialName]
	internal virtual BindingSource Sa3()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9Y(BindingSource k6T)
	{
		BindingSource val = (q = k6T);
	}

	[SpecialName]
	internal virtual Ct6g Lq1()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0T(Ct6g Kc9)
	{
		Ct6g ct6g = (G = Kc9);
	}

	[SpecialName]
	internal virtual BindingSource Gp8()
	{
		return _BorrowbookBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0Q(BindingSource t0T)
	{
		_BorrowbookBindingSource = t0T;
	}

	[SpecialName]
	internal virtual Ys1 g7Y()
	{
		return _BorrowbookTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0R(Ys1 Qc7)
	{
		_BorrowbookTableAdapter = Qc7;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Kg6()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8S(DataGridViewTextBoxColumn d4Y)
	{
		DataGridViewTextBoxColumn val = (L = d4Y);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Yy7()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2W(DataGridViewTextBoxColumn Qo2)
	{
		DataGridViewTextBoxColumn val = (n = Qo2);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Hb6()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs6(DataGridViewTextBoxColumn Mp9)
	{
		DataGridViewTextBoxColumn val = (y = Mp9);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn He1()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pc7(DataGridViewTextBoxColumn o8J)
	{
		DataGridViewTextBoxColumn val = (s = o8J);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y7D()
	{
		return _AnameDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5J(DataGridViewTextBoxColumn m1C4)
	{
		_AnameDataGridViewTextBoxColumn = m1C4;
	}

	[SpecialName]
	internal virtual LinkLabel a5DJ()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw72(LinkLabel b4TN)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(k3T1);
		LinkLabel val2 = w;
		if (val2 != null)
		{
			val2.remove_LinkClicked(val);
		}
		LinkLabel val3 = (w = b4TN);
		val2 = w;
		if (val2 != null)
		{
			val2.add_LinkClicked(val);
		}
	}

	private void Jg0y(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (Operators.CompareString(g7S().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		if (!Versioned.IsNumeric((object)g7S().get_Text()))
		{
			Interaction.MsgBox((object)"Please Enter Valid Book Number", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		int num = checked((int)Math.Round(Conversion.Val(g7S().get_Text())));
		SqlDataAdapter val = new SqlDataAdapter("Select * from borrowbook where bid=" + Conversions.ToString(num), Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Cd7().set_DataSource((object)dataTable);
	}

	private void Ln6y(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (Operators.CompareString(g7S().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		int num = checked((int)Math.Round(Conversion.Val(g7S().get_Text())));
		SqlDataAdapter val = new SqlDataAdapter("Select * from borrowbook where userid='" + Conversions.ToString(num) + "'", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Cd7().set_DataSource((object)dataTable);
	}

	private void t7A9(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (Operators.CompareString(g7S().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box Is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		int num = checked((int)Math.Round(Conversion.Val(g7S().get_Text())));
		SqlDataAdapter val = new SqlDataAdapter("Select * from borrowbook where username='" + Conversions.ToString(num) + "'", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Cd7().set_DataSource((object)dataTable);
	}

	internal static byte[] a1Q4(byte[] Ck35, byte[] Hk49, int k7BE, int j2YE)
	{
		int num = checked(Ck35.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			Ck35[i] = (byte)(Ck35[i] ^ checked((byte)(Hk49[unchecked(i % Hk49.Length)] ^ ((i + unchecked(k7BE % Hk49.Length)) & k7BE))));
		}
		return Ck35;
	}

	private void Eq5a(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (Operators.CompareString(g7S().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box Is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		int num = checked((int)Math.Round(Conversion.Val(g7S().get_Text())));
		SqlDataAdapter val = new SqlDataAdapter("Select * from borrowbook where bname='" + Conversions.ToString(num) + "'", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Cd7().set_DataSource((object)dataTable);
	}

	private void a1R4(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		if (Operators.CompareString(g7S().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box Is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		int num = checked((int)Math.Round(Conversion.Val(g7S().get_Text())));
		SqlDataAdapter val = new SqlDataAdapter("Select * from borrowbook where aname='" + Conversions.ToString(num) + "'", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Cd7().set_DataSource((object)dataTable);
	}

	private void m2Z1(object sender, EventArgs e)
	{
		g7Y().j2A(Lq1().borrowbook);
		((Control)Dx8()).Hide();
		((Control)d1D()).Hide();
		((Control)n6J()).Hide();
		((Control)q2T()).Hide();
		((Control)r8F()).Hide();
		((Control)g7S()).Hide();
		((Control)Be5()).Hide();
		((Control)a5DJ()).Hide();
	}

	private void k3T1(object sender, LinkLabelLinkClickedEventArgs e)
	{
		g7Y().j2A(Lq1().borrowbook);
	}
}
