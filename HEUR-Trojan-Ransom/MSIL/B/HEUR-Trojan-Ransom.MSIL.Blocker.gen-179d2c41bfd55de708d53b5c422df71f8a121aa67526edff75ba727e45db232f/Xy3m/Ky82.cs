using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cq2e;
using Cw3s;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using s2H;
using z2SR;

namespace Xy3m;

[DesignerGenerated]
public class Ky82 : Form
{
	private IContainer components;

	private Button _Button1;

	private TextBox _TextBox1;

	private BindingSource _BooksBindingSource;

	private Js7d _BooksTableAdapter;

	private DataGridViewTextBoxColumn _BnumDataGridViewTextBoxColumn;

	private DataGridViewTextBoxColumn _NumberOfCopiesDataGridViewTextBoxColumn;

	internal DataGridView i;

	internal Button A;

	internal Label B;

	internal Button h;

	internal LinkLabel n;

	internal w8K S;

	internal DataGridViewTextBoxColumn Q;

	internal DataGridViewTextBoxColumn F;

	public Ky82()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(St6));
		((Form)this).add_Load((EventHandler)Me3);
		s2G();
	}

	protected override void Xq3(bool Ew5)
	{
		try
		{
			if (Ew5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ew5);
		}
	}

	private void s2G()
	{
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
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		components = new Container();
		Aa6(new DataGridView());
		d2X(new DataGridViewTextBoxColumn());
		x1T(new DataGridViewTextBoxColumn());
		a1Z(new DataGridViewTextBoxColumn());
		d3P(new DataGridViewTextBoxColumn());
		St0(new BindingSource(components));
		b1Q(new w8K());
		t1C(new Button());
		Xz7(new Button());
		w6P(new Label());
		Wa6(new TextBox());
		e4Q(new Button());
		p1T(new LinkLabel());
		s4P(new Js7d());
		((ISupportInitialize)e9T()).BeginInit();
		((ISupportInitialize)Hj0()).BeginInit();
		((ISupportInitialize)Za0()).BeginInit();
		((Control)this).SuspendLayout();
		e9T().set_AutoGenerateColumns(false);
		e9T().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		e9T().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)Sc6(),
			(DataGridViewColumn)e1M(),
			(DataGridViewColumn)n4L(),
			(DataGridViewColumn)Ht1()
		});
		e9T().set_DataSource((object)Hj0());
		((Control)e9T()).set_Location(new Point(26, 27));
		((Control)e9T()).set_Name("DataGridView1");
		((Control)e9T()).set_Size(new Size(591, 277));
		((Control)e9T()).set_TabIndex(0);
		((DataGridViewColumn)Sc6()).set_DataPropertyName("bnum");
		((DataGridViewColumn)Sc6()).set_HeaderText("Book Number");
		((DataGridViewColumn)Sc6()).set_Name("BnumDataGridViewTextBoxColumn");
		((DataGridViewColumn)e1M()).set_DataPropertyName("bname");
		((DataGridViewColumn)e1M()).set_HeaderText("Book Number");
		((DataGridViewColumn)e1M()).set_MinimumWidth(20);
		((DataGridViewColumn)e1M()).set_Name("BnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)e1M()).set_Width(180);
		((DataGridViewColumn)n4L()).set_DataPropertyName("authorName");
		((DataGridViewColumn)n4L()).set_HeaderText("Author Name");
		((DataGridViewColumn)n4L()).set_Name("AuthorNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)n4L()).set_Width(150);
		((DataGridViewColumn)Ht1()).set_DataPropertyName("numberOfCopies");
		((DataGridViewColumn)Ht1()).set_HeaderText("Number Of Copies");
		((DataGridViewColumn)Ht1()).set_Name("NumberOfCopiesDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ht1()).set_Width(120);
		Hj0().set_DataMember("books");
		Hj0().set_DataSource((object)Za0());
		Za0().DataSetName = "libraryDataSet";
		Za0().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		((Control)i7R()).set_Location(new Point(44, 320));
		((Control)i7R()).set_Name("Button1");
		((Control)i7R()).set_Size(new Size(122, 44));
		((Control)i7R()).set_TabIndex(1);
		((ButtonBase)i7R()).set_Text("Insert");
		((ButtonBase)i7R()).set_UseVisualStyleBackColor(true);
		((Control)z3W()).set_Location(new Point(238, 320));
		((Control)z3W()).set_Name("Button2");
		((Control)z3W()).set_Size(new Size(136, 44));
		((Control)z3W()).set_TabIndex(2);
		((ButtonBase)z3W()).set_Text("Update");
		((ButtonBase)z3W()).set_UseVisualStyleBackColor(true);
		n5B().set_AutoSize(true);
		((Control)n5B()).set_Location(new Point(148, 380));
		((Control)n5B()).set_Name("Label1");
		((Control)n5B()).set_Size(new Size(240, 13));
		((Control)n5B()).set_TabIndex(3);
		n5B().set_Text("Enter the Book Number of the book to be deleted");
		((Control)f8W()).set_Location(new Point(399, 377));
		((Control)f8W()).set_Name("TextBox1");
		((Control)f8W()).set_Size(new Size(166, 20));
		((Control)f8W()).set_TabIndex(4);
		((Control)Ps9()).set_Location(new Point(436, 320));
		((Control)Ps9()).set_Name("Button3");
		((Control)Ps9()).set_Size(new Size(129, 44));
		((Control)Ps9()).set_TabIndex(5);
		((ButtonBase)Ps9()).set_Text("Delete");
		((ButtonBase)Ps9()).set_UseVisualStyleBackColor(true);
		((Label)Nn4()).set_AutoSize(true);
		((Control)Nn4()).set_Location(new Point(26, 8));
		((Control)Nn4()).set_Name("LinkLabel1");
		((Control)Nn4()).set_Size(new Size(44, 13));
		((Control)Nn4()).set_TabIndex(6);
		Nn4().set_TabStop(true);
		Nn4().set_Text("Refresh");
		t5G().ClearBeforeFill = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(645, 420));
		((Control)this).get_Controls().Add((Control)(object)Nn4());
		((Control)this).get_Controls().Add((Control)(object)Ps9());
		((Control)this).get_Controls().Add((Control)(object)f8W());
		((Control)this).get_Controls().Add((Control)(object)n5B());
		((Control)this).get_Controls().Add((Control)(object)z3W());
		((Control)this).get_Controls().Add((Control)(object)i7R());
		((Control)this).get_Controls().Add((Control)(object)e9T());
		((Control)this).set_Name("Form6");
		((Form)this).set_Text("Add Update Delete Books");
		((ISupportInitialize)e9T()).EndInit();
		((ISupportInitialize)Hj0()).EndInit();
		((ISupportInitialize)Za0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView e9T()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aa6(DataGridView s0N)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(Ji0);
		DataGridView val2 = i;
		if (val2 != null)
		{
			val2.remove_CellContentClick(val);
		}
		DataGridView val3 = (i = s0N);
		val2 = i;
		if (val2 != null)
		{
			val2.add_CellContentClick(val);
		}
	}

	[SpecialName]
	internal virtual Button i7R()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1C(Button g6M)
	{
		EventHandler eventHandler = Yi7;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = g6M;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button z3W()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz7(Button s5J)
	{
		EventHandler eventHandler = f3R;
		Button a = A;
		if (a != null)
		{
			((Control)a).remove_Click(eventHandler);
		}
		Button val = (A = s5J);
		a = A;
		if (a != null)
		{
			((Control)a).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label n5B()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6P(Label Dr2)
	{
		Label val = (B = Dr2);
	}

	[SpecialName]
	internal virtual TextBox f8W()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa6(TextBox Cb2)
	{
		_TextBox1 = Cb2;
	}

	[SpecialName]
	internal virtual Button Ps9()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4Q(Button e3P)
	{
		EventHandler eventHandler = Nn4;
		Button val = h;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (h = e3P);
		val = h;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual LinkLabel Nn4()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1T(LinkLabel Dq5)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(p3F);
		LinkLabel val2 = n;
		if (val2 != null)
		{
			val2.remove_LinkClicked(val);
		}
		LinkLabel val3 = (n = Dq5);
		val2 = n;
		if (val2 != null)
		{
			val2.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual w8K Za0()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1Q(w8K Ta4)
	{
		w8K w8K = (S = Ta4);
	}

	[SpecialName]
	internal virtual BindingSource Hj0()
	{
		return _BooksBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St0(BindingSource t1W)
	{
		_BooksBindingSource = t1W;
	}

	[SpecialName]
	internal virtual Js7d t5G()
	{
		return _BooksTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4P(Js7d x1A)
	{
		_BooksTableAdapter = x1A;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Sc6()
	{
		return _BnumDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2X(DataGridViewTextBoxColumn p0W)
	{
		_BnumDataGridViewTextBoxColumn = p0W;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn e1M()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1T(DataGridViewTextBoxColumn To1)
	{
		DataGridViewTextBoxColumn val = (Q = To1);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n4L()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1Z(DataGridViewTextBoxColumn y1X)
	{
		DataGridViewTextBoxColumn val = (F = y1X);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ht1()
	{
		return _NumberOfCopiesDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3P(DataGridViewTextBoxColumn e9Z)
	{
		_NumberOfCopiesDataGridViewTextBoxColumn = e9Z;
	}

	private bool z1W(int Xo9)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		SqlDataAdapter val = new SqlDataAdapter("select * from books where bnum=" + Conversions.ToString(Xo9), Eb3s.con);
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count == 0)
		{
			return true;
		}
		return false;
	}

	private object z5H()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		SqlDataAdapter val = new SqlDataAdapter("Select * from books", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		e9T().set_DataSource((object)dataTable);
		return null;
	}

	private void Nn4(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Invalid comparison between Unknown and I4
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		int num = checked((int)Math.Round(Conversion.Val(f8W().get_Text())));
		if (Operators.CompareString(f8W().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please Enter the BookNumber", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		if (!Versioned.IsNumeric((object)f8W().get_Text()))
		{
			Interaction.MsgBox((object)"Book Number should be number only", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		if (z1W(num))
		{
			Interaction.MsgBox((object)"Book Number Not found", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		string text = "delete from books where bnum =" + Conversions.ToString(num);
		try
		{
			if ((int)Interaction.MsgBox((object)"Are you sure you want to delete", (MsgBoxStyle)4, (object)"Warning!!!") == 6)
			{
				SqlCommand val = new SqlCommand(text, Eb3s.con);
				val.ExecuteNonQuery();
				Interaction.MsgBox((object)"A book has been deleted", (MsgBoxStyle)48, (object)"Please press on refresh");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void St6(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.e5R8()).Show();
	}

	private void Me3(object sender, EventArgs e)
	{
		t5G().Nq9i(Za0().books);
		z5H();
	}

	private void Yi7(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Wf6k()).Show();
		z5H();
	}

	private void f3R(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Yj25()).Show();
		z5H();
	}

	private void p3F(object sender, LinkLabelLinkClickedEventArgs e)
	{
		z5H();
	}

	internal static string[] k2B()
	{
		checked
		{
			try
			{
				List<string> list = new List<string>();
				int num = 0;
				string[] array = (string[])NewLateBinding.LateGet(Mj02.mDic["AO"], (Type)null, "GetManifestResourceNames", new object[0], (string[])null, (Type[])null, (bool[])null);
				string[] array2 = array;
				foreach (string item in array2)
				{
					list.Add(item);
				}
				string[] array3 = new string[list.Count - 1 + 1];
				int num2 = array3.Length - 1;
				for (num = 0; num <= num2; num++)
				{
					array3[num] = list[num];
				}
				return array3;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Ji0(object sender, DataGridViewCellEventArgs e)
	{
	}
}
