using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Kn6m;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using g4N1;
using y0R;
using z2SR;

namespace x5NZ;

[DesignerGenerated]
public class Zz9s : Form
{
	private IContainer components;

	private Label _Label1;

	private Label _Label2;

	private TextBox _TextBox3;

	private TextBox _TextBox4;

	private Button _Button3;

	private Button _Button4;

	private ErrorProvider _ErrorProvider1;

	private ErrorProvider _ErrorProvider4;

	private Ct6g _LibraryDataSet1;

	private BindingSource _StudentlibloginBindingSource;

	private z1J6 _StudentlibloginTableAdapter;

	private DataGridViewTextBoxColumn _StdpasswordDataGridViewTextBoxColumn;

	internal TextBox V;

	internal TextBox I;

	internal Label O;

	internal Label F;

	internal DataGridView Y;

	internal Button c;

	internal Button b;

	internal ErrorProvider X;

	internal ErrorProvider k;

	internal Button P;

	internal DataGridViewTextBoxColumn A;

	internal DataGridViewTextBoxColumn w;

	internal DataGridViewTextBoxColumn E;

	public Zz9s()
	{
		((Form)this).add_Load((EventHandler)Nj6);
		k8E1();
	}

	protected override void Ao1q(bool c5Q4)
	{
		try
		{
			if (c5Q4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c5Q4);
		}
	}

	private void k8E1()
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
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		components = new Container();
		n4A7(new Label());
		Gg7i(new TextBox());
		o4D7(new Label());
		b8D2(new TextBox());
		c0PK(new TextBox());
		Rc08(new TextBox());
		r6SW(new Label());
		g2ZQ(new Label());
		Gr3x(new DataGridView());
		Cg96(new Button());
		i7L0(new Button());
		Gi5r(new Button());
		n1SY(new Button());
		Fn5m(new ErrorProvider(components));
		Hr02(new ErrorProvider(components));
		r8CW(new ErrorProvider(components));
		Np4i(new ErrorProvider(components));
		Zg5x(new Button());
		x9EN(new Ct6g());
		a4W0(new BindingSource(components));
		Fj7m(new z1J6());
		s3HY(new DataGridViewTextBoxColumn());
		f1W4(new DataGridViewTextBoxColumn());
		Sn4a(new DataGridViewTextBoxColumn());
		Yo2(new DataGridViewTextBoxColumn());
		((ISupportInitialize)Na2n()).BeginInit();
		((ISupportInitialize)Xx87()).BeginInit();
		((ISupportInitialize)t2FC()).BeginInit();
		((ISupportInitialize)f9Z7()).BeginInit();
		((ISupportInitialize)Nj1z()).BeginInit();
		((ISupportInitialize)Ki51()).BeginInit();
		((ISupportInitialize)Sc4q()).BeginInit();
		((Control)this).SuspendLayout();
		i9C4().set_AutoSize(true);
		((Control)i9C4()).set_Location(new Point(13, 33));
		((Control)i9C4()).set_Name("Label1");
		((Control)i9C4()).set_Size(new Size(70, 13));
		((Control)i9C4()).set_TabIndex(0);
		i9C4().set_Text("Student USN");
		((Control)t1CE()).set_Location(new Point(106, 30));
		((Control)t1CE()).set_Name("TextBox1");
		((Control)t1CE()).set_Size(new Size(162, 20));
		((Control)t1CE()).set_TabIndex(1);
		Xn0j().set_AutoSize(true);
		((Control)Xn0j()).set_Location(new Point(307, 33));
		((Control)Xn0j()).set_Name("Label2");
		((Control)Xn0j()).set_Size(new Size(53, 13));
		((Control)Xn0j()).set_TabIndex(2);
		Xn0j().set_Text("Password");
		((Control)x1PW()).set_Location(new Point(406, 30));
		((Control)x1PW()).set_Name("TextBox2");
		((Control)x1PW()).set_Size(new Size(185, 20));
		((Control)x1PW()).set_TabIndex(3);
		((Control)Ax18()).set_Location(new Point(106, 74));
		((Control)Ax18()).set_Name("TextBox3");
		((Control)Ax18()).set_Size(new Size(162, 20));
		((Control)Ax18()).set_TabIndex(4);
		((Control)e0R7()).set_Location(new Point(406, 74));
		((Control)e0R7()).set_Name("TextBox4");
		((Control)e0R7()).set_Size(new Size(185, 20));
		((Control)e0R7()).set_TabIndex(5);
		r9X0().set_AutoSize(true);
		((Control)r9X0()).set_Location(new Point(13, 77));
		((Control)r9X0()).set_Name("Label3");
		((Control)r9X0()).set_Size(new Size(75, 13));
		((Control)r9X0()).set_TabIndex(6);
		r9X0().set_Text("Student Name");
		Hn8t().set_AutoSize(true);
		((Control)Hn8t()).set_Location(new Point(307, 77));
		((Control)Hn8t()).set_Name("Label4");
		((Control)Hn8t()).set_Size(new Size(85, 13));
		((Control)Hn8t()).set_TabIndex(7);
		Hn8t().set_Text("Borrowed Books");
		Na2n().set_AutoGenerateColumns(false);
		Na2n().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		Na2n().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)q2HL(),
			(DataGridViewColumn)n5HM(),
			(DataGridViewColumn)Ls4f(),
			(DataGridViewColumn)y9N()
		});
		Na2n().set_DataSource((object)Sc4q());
		((Control)Na2n()).set_Location(new Point(13, 112));
		((Control)Na2n()).set_Name("DataGridView1");
		((Control)Na2n()).set_Size(new Size(592, 159));
		((Control)Na2n()).set_TabIndex(8);
		((Control)x0J5()).set_Location(new Point(25, 281));
		((Control)x0J5()).set_Name("Button1");
		((Control)x0J5()).set_Size(new Size(101, 32));
		((Control)x0J5()).set_TabIndex(9);
		((ButtonBase)x0J5()).set_Text("ADD");
		((ButtonBase)x0J5()).set_UseVisualStyleBackColor(true);
		((Control)Cf56()).set_Location(new Point(141, 281));
		((Control)Cf56()).set_Name("Button2");
		((Control)Cf56()).set_Size(new Size(94, 32));
		((Control)Cf56()).set_TabIndex(10);
		((ButtonBase)Cf56()).set_Text("UPDATE");
		((ButtonBase)Cf56()).set_UseVisualStyleBackColor(true);
		((Control)Ym76()).set_Location(new Point(257, 281));
		((Control)Ym76()).set_Name("Button3");
		((Control)Ym76()).set_Size(new Size(103, 32));
		((Control)Ym76()).set_TabIndex(11);
		((ButtonBase)Ym76()).set_Text("DELETE");
		((ButtonBase)Ym76()).set_UseVisualStyleBackColor(true);
		((Control)Ar17()).set_Location(new Point(492, 281));
		((Control)Ar17()).set_Name("Button4");
		((Control)Ar17()).set_Size(new Size(99, 32));
		((Control)Ar17()).set_TabIndex(12);
		((ButtonBase)Ar17()).set_Text("HOME");
		((ButtonBase)Ar17()).set_UseVisualStyleBackColor(true);
		Xx87().set_ContainerControl((ContainerControl)(object)this);
		t2FC().set_ContainerControl((ContainerControl)(object)this);
		f9Z7().set_ContainerControl((ContainerControl)(object)this);
		Nj1z().set_ContainerControl((ContainerControl)(object)this);
		((Control)Yn8y()).set_Location(new Point(378, 281));
		((Control)Yn8y()).set_Name("Button5");
		((Control)Yn8y()).set_Size(new Size(95, 32));
		((Control)Yn8y()).set_TabIndex(13);
		((ButtonBase)Yn8y()).set_Text("Borrow details");
		((ButtonBase)Yn8y()).set_UseVisualStyleBackColor(true);
		Ki51().DataSetName = "libraryDataSet1";
		Ki51().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Sc4q().set_DataMember("studentliblogin");
		Sc4q().set_DataSource((object)Ki51());
		r0NJ().ClearBeforeFill = true;
		((DataGridViewColumn)q2HL()).set_DataPropertyName("stduserid");
		((DataGridViewColumn)q2HL()).set_HeaderText("Student User ID");
		((DataGridViewColumn)q2HL()).set_Name("StduseridDataGridViewTextBoxColumn");
		((DataGridViewColumn)q2HL()).set_Width(130);
		((DataGridViewColumn)n5HM()).set_DataPropertyName("stdname");
		((DataGridViewColumn)n5HM()).set_HeaderText("Student Name");
		((DataGridViewColumn)n5HM()).set_Name("StdnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)n5HM()).set_Width(150);
		((DataGridViewColumn)Ls4f()).set_DataPropertyName("stdpassword");
		((DataGridViewColumn)Ls4f()).set_HeaderText("Password");
		((DataGridViewColumn)Ls4f()).set_Name("StdpasswordDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ls4f()).set_Width(150);
		((DataGridViewColumn)y9N()).set_DataPropertyName("borrow");
		((DataGridViewColumn)y9N()).set_HeaderText("Borrow");
		((DataGridViewColumn)y9N()).set_Name("BorrowDataGridViewTextBoxColumn");
		((DataGridViewColumn)y9N()).set_Width(120);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(617, 321));
		((Control)this).get_Controls().Add((Control)(object)Yn8y());
		((Control)this).get_Controls().Add((Control)(object)Ar17());
		((Control)this).get_Controls().Add((Control)(object)Ym76());
		((Control)this).get_Controls().Add((Control)(object)Cf56());
		((Control)this).get_Controls().Add((Control)(object)x0J5());
		((Control)this).get_Controls().Add((Control)(object)Na2n());
		((Control)this).get_Controls().Add((Control)(object)Hn8t());
		((Control)this).get_Controls().Add((Control)(object)r9X0());
		((Control)this).get_Controls().Add((Control)(object)e0R7());
		((Control)this).get_Controls().Add((Control)(object)Ax18());
		((Control)this).get_Controls().Add((Control)(object)x1PW());
		((Control)this).get_Controls().Add((Control)(object)Xn0j());
		((Control)this).get_Controls().Add((Control)(object)t1CE());
		((Control)this).get_Controls().Add((Control)(object)i9C4());
		((Control)this).set_Name("Form10");
		((Form)this).set_Text("Student Details");
		((ISupportInitialize)Na2n()).EndInit();
		((ISupportInitialize)Xx87()).EndInit();
		((ISupportInitialize)t2FC()).EndInit();
		((ISupportInitialize)f9Z7()).EndInit();
		((ISupportInitialize)Nj1z()).EndInit();
		((ISupportInitialize)Ki51()).EndInit();
		((ISupportInitialize)Sc4q()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label i9C4()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4A7(Label g1RF)
	{
		_Label1 = g1RF;
	}

	[SpecialName]
	internal virtual TextBox t1CE()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gg7i(TextBox t3GL)
	{
		TextBox val = (V = t3GL);
	}

	[SpecialName]
	internal virtual Label Xn0j()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4D7(Label k3FZ)
	{
		_Label2 = k3FZ;
	}

	[SpecialName]
	internal virtual TextBox x1PW()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8D2(TextBox Qq3f)
	{
		TextBox val = (I = Qq3f);
	}

	[SpecialName]
	internal virtual TextBox Ax18()
	{
		return _TextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0PK(TextBox f5R4)
	{
		_TextBox3 = f5R4;
	}

	[SpecialName]
	internal virtual TextBox e0R7()
	{
		return _TextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rc08(TextBox o7S5)
	{
		_TextBox4 = o7S5;
	}

	[SpecialName]
	internal virtual Label r9X0()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6SW(Label s6X7)
	{
		Label val = (O = s6X7);
	}

	[SpecialName]
	internal virtual Label Hn8t()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2ZQ(Label Ke09)
	{
		Label val = (F = Ke09);
	}

	[SpecialName]
	internal virtual DataGridView Na2n()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gr3x(DataGridView f0RF)
	{
		DataGridView val = (Y = f0RF);
	}

	[SpecialName]
	internal virtual Button x0J5()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cg96(Button Zz32)
	{
		EventHandler eventHandler = w3W;
		Button val = c;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (c = Zz32);
		val = c;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Cf56()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7L0(Button Yc7w)
	{
		EventHandler eventHandler = Ns8;
		Button val = b;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (b = Yc7w);
		val = b;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ym76()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gi5r(Button d2EQ)
	{
		EventHandler eventHandler = Ap5;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = d2EQ;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ar17()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1SY(Button Lt7s)
	{
		EventHandler eventHandler = Js7;
		Button button = _Button4;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button4 = Lt7s;
		button = _Button4;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ErrorProvider Xx87()
	{
		return _ErrorProvider1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fn5m(ErrorProvider Jm4d)
	{
		_ErrorProvider1 = Jm4d;
	}

	[SpecialName]
	internal virtual ErrorProvider t2FC()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hr02(ErrorProvider Pb96)
	{
		ErrorProvider val = (X = Pb96);
	}

	[SpecialName]
	internal virtual ErrorProvider f9Z7()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8CW(ErrorProvider t7AX)
	{
		ErrorProvider val = (k = t7AX);
	}

	[SpecialName]
	internal virtual ErrorProvider Nj1z()
	{
		return _ErrorProvider4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np4i(ErrorProvider Zp0y)
	{
		_ErrorProvider4 = Zp0y;
	}

	[SpecialName]
	internal virtual Button Yn8y()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg5x(Button n8D3)
	{
		EventHandler eventHandler = q2E;
		Button p = P;
		if (p != null)
		{
			((Control)p).remove_Click(eventHandler);
		}
		Button val = (P = n8D3);
		p = P;
		if (p != null)
		{
			((Control)p).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Ct6g Ki51()
	{
		return _LibraryDataSet1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9EN(Ct6g Ap7o)
	{
		_LibraryDataSet1 = Ap7o;
	}

	[SpecialName]
	internal virtual BindingSource Sc4q()
	{
		return _StudentlibloginBindingSource;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4W0(BindingSource t2AE)
	{
		_StudentlibloginBindingSource = t2AE;
	}

	[SpecialName]
	internal virtual z1J6 r0NJ()
	{
		return _StudentlibloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj7m(z1J6 Cr13)
	{
		_StudentlibloginTableAdapter = Cr13;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn q2HL()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3HY(DataGridViewTextBoxColumn r7PD)
	{
		DataGridViewTextBoxColumn val = (A = r7PD);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n5HM()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1W4(DataGridViewTextBoxColumn x9F4)
	{
		DataGridViewTextBoxColumn val = (w = x9F4);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ls4f()
	{
		return _StdpasswordDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sn4a(DataGridViewTextBoxColumn Ls4d)
	{
		_StdpasswordDataGridViewTextBoxColumn = Ls4d;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y9N()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo2(DataGridViewTextBoxColumn Fj3)
	{
		DataGridViewTextBoxColumn val = (E = Fj3);
	}

	public object i5P()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		SqlDataAdapter val = new SqlDataAdapter("select * from studentliblogin", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		Na2n().set_DataSource((object)dataTable);
		e0R7().set_Text(Conversions.ToString(0));
		return null;
	}

	private void Js7(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)Fb9z.Forms.e5R8()).Show();
	}

	private void Nj6(object sender, EventArgs e)
	{
		r0NJ().Bz0b(Ki51().studentliblogin);
		e0R7().set_Text(Conversions.ToString(0));
		i5P();
	}

	private void w3W(object sender, EventArgs e)
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(t1CE().get_Text(), "", false) == 0)
		{
			Xx87().SetError((Control)(object)t1CE(), "Please Enter Your User ID");
			return;
		}
		Xx87().Clear();
		if (Operators.CompareString(x1PW().get_Text(), "", false) == 0)
		{
			t2FC().SetError((Control)(object)x1PW(), "Please Enter Your Password");
			return;
		}
		t2FC().Clear();
		if (Operators.CompareString(Ax18().get_Text(), "", false) == 0)
		{
			f9Z7().SetError((Control)(object)Ax18(), "Please Enter Your Name");
			return;
		}
		f9Z7().Clear();
		if (Operators.CompareString(e0R7().get_Text(), "", false) == 0)
		{
			Nj1z().SetError((Control)(object)e0R7(), "Please Enter Number of books borrowed");
			return;
		}
		Nj1z().Clear();
		if (!Versioned.IsNumeric((object)e0R7().get_Text()))
		{
			Nj1z().SetError((Control)(object)e0R7(), "Please enter integer only");
			return;
		}
		Nj1z().Clear();
		if (Conversion.Val(e0R7().get_Text()) > 9.0)
		{
			Nj1z().SetError((Control)(object)e0R7(), "Student can borrow max of 8");
			return;
		}
		Nj1z().Clear();
		string text = t1CE().get_Text().ToUpper();
		string text2 = Ax18().get_Text().ToUpper();
		string text3 = x1PW().get_Text();
		int num = checked((int)Math.Round(Conversion.Val(e0R7().get_Text())));
		string text4 = "insert into studetliblogin values('" + text + "','" + text2 + "','" + text3 + "'," + Conversions.ToString(num) + ")";
		try
		{
			SqlCommand val = new SqlCommand(text4, Eb3s.con);
			val.ExecuteNonQuery();
			Interaction.MsgBox((object)"Student Added to the Database", (MsgBoxStyle)0, (object)"Insertion Successful");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		i5P();
	}

	internal static string Lf5(string[] Yz7, int Ld4, int My3)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = Ld4; i <= My3; i = checked(i + 1))
		{
			stringBuilder.Append(Yz7[i]);
		}
		return stringBuilder.ToString();
	}

	private void Ns8(object sender, EventArgs e)
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(t1CE().get_Text(), "", false) == 0)
		{
			Xx87().SetError((Control)(object)t1CE(), "Please Enter Your User ID");
			return;
		}
		Xx87().Clear();
		if (Operators.CompareString(x1PW().get_Text(), "", false) == 0)
		{
			t2FC().SetError((Control)(object)x1PW(), "Please Enter Your Password");
			return;
		}
		t2FC().Clear();
		if (Operators.CompareString(Ax18().get_Text(), "", false) == 0)
		{
			f9Z7().SetError((Control)(object)Ax18(), "Please Enter Your Name");
			return;
		}
		f9Z7().Clear();
		if (Operators.CompareString(e0R7().get_Text(), "", false) == 0)
		{
			Nj1z().SetError((Control)(object)e0R7(), "Please Enter Number of books borrowed");
			return;
		}
		Nj1z().Clear();
		if (!Versioned.IsNumeric((object)e0R7().get_Text()))
		{
			Nj1z().SetError((Control)(object)e0R7(), "Please enter integer only");
			return;
		}
		Nj1z().Clear();
		if (Conversion.Val(e0R7().get_Text()) > 9.0)
		{
			Nj1z().SetError((Control)(object)e0R7(), "Student can borrow max of 8");
			return;
		}
		Nj1z().Clear();
		string text = t1CE().get_Text().ToUpper();
		string text2 = Ax18().get_Text().ToUpper();
		string text3 = x1PW().get_Text();
		int num = checked((int)Math.Round(Conversion.Val(e0R7().get_Text())));
		string text4 = "update studentliblogin set stdname='" + text2 + "',stdpassword='" + text3 + "',borrow=" + Conversions.ToString(num) + " where stduserid= '" + text + "'";
		try
		{
			SqlCommand val = new SqlCommand(text4, Eb3s.con);
			val.ExecuteNonQuery();
			Interaction.MsgBox((object)"A Student data has been updated from Database", (MsgBoxStyle)0, (object)"Updated Successful");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		i5P();
	}

	private bool Xf4(string a4W)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		SqlDataAdapter val = new SqlDataAdapter("select * from studentliblogin where stduserid='" + a4W + "'", Eb3s.con);
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count == 0)
		{
			return true;
		}
		return false;
	}

	private void Ap5(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		string text = Interaction.InputBox("Please Enter the USN to be Deleted", "Delete a Student", "Enter USN Eg: 4NM14CS147", -1, -1);
		text.ToUpper();
		if (Xf4(text))
		{
			Interaction.MsgBox((object)"Student Not found", (MsgBoxStyle)16, (object)"Warning");
			return;
		}
		string text2 = "delete from studentliblogin where stduserid ='" + text + "'";
		try
		{
			if ((int)Interaction.MsgBox((object)"Are you sure you want to delete", (MsgBoxStyle)4, (object)"Warning!!!") == 6)
			{
				SqlCommand val = new SqlCommand(text2, Eb3s.con);
				val.ExecuteNonQuery();
				Interaction.MsgBox((object)"A Student details has been deleted", (MsgBoxStyle)48, (object)"Note :");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		i5P();
	}

	internal static byte[] g7P(int a7R, int Qe1)
	{
		if (a7R <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Qe1 + 1];
			for (int i = 0; i <= Qe1; i++)
			{
				int num = a7R * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Tf4.j6G(array, Qe1);
		}
	}

	private void q2E(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Sk78()).Show();
	}
}
