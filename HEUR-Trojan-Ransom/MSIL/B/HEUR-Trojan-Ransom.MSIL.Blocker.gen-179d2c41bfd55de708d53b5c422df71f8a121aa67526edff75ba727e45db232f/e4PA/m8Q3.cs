using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cq2e;
using Gi7;
using Lt35;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using g4N1;
using z2SR;

namespace e4PA;

[DesignerGenerated]
public class m8Q3 : Form
{
	private DataGridView _DataGridView1;

	private Label _Label1;

	private Button _Button1;

	private Button _Button2;

	private LinkLabel _LinkLabel1;

	private Label _Label4;

	private Label _Label5;

	private DataGridViewTextBoxColumn _BnameDataGridViewTextBoxColumn;

	internal IContainer g;

	internal TextBox c;

	internal Button R;

	internal Label L;

	internal Label k;

	internal Button m;

	internal Ct6g A;

	internal BindingSource u;

	internal r0C N;

	internal DataGridViewTextBoxColumn J;

	internal DataGridViewTextBoxColumn Q;

	internal DataGridViewTextBoxColumn x;

	public m8Q3()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		((Form)this).add_FormClosed(new FormClosedEventHandler(i4FC));
		((Form)this).add_Load((EventHandler)Zg3d);
		y7AC();
	}

	protected override void Hn97(bool Sr1i)
	{
		try
		{
			if (Sr1i && g != null)
			{
				g.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sr1i);
		}
	}

	private void y7AC()
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
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
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
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		IContainer container = (g = new Container());
		Pm6o(new DataGridView());
		r2L4(new DataGridViewTextBoxColumn());
		b5W6(new DataGridViewTextBoxColumn());
		Bt0p(new DataGridViewTextBoxColumn());
		Fg13(new DataGridViewTextBoxColumn());
		Kg64(new BindingSource(g));
		f0T6(new Ct6g());
		p2DT(new Label());
		i5EW(new TextBox());
		Rg81(new Button());
		Kk7b(new Button());
		g5GZ(new Button());
		Ms8n(new LinkLabel());
		Qd3n(new Label());
		Fy46(new Label());
		Ao3a(new Button());
		s7Z2(new Label());
		Mx0q(new Label());
		n1JN(new r0C());
		((ISupportInitialize)z6EK()).BeginInit();
		((ISupportInitialize)Km0f()).BeginInit();
		((ISupportInitialize)Jf47()).BeginInit();
		((Control)this).SuspendLayout();
		z6EK().set_AutoGenerateColumns(false);
		z6EK().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		z6EK().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[4]
		{
			(DataGridViewColumn)s2D3(),
			(DataGridViewColumn)i7W4(),
			(DataGridViewColumn)Ay1z(),
			(DataGridViewColumn)n0Q4()
		});
		z6EK().set_DataSource((object)Km0f());
		((Control)z6EK()).set_Location(new Point(32, 25));
		((Control)z6EK()).set_Name("DataGridView1");
		((Control)z6EK()).set_Size(new Size(490, 210));
		((Control)z6EK()).set_TabIndex(0);
		((DataGridViewColumn)s2D3()).set_DataPropertyName("bnum");
		((DataGridViewColumn)s2D3()).set_HeaderText("Book Number");
		((DataGridViewColumn)s2D3()).set_Name("BnumDataGridViewTextBoxColumn");
		((DataGridViewColumn)i7W4()).set_DataPropertyName("bname");
		((DataGridViewColumn)i7W4()).set_HeaderText("Book Name");
		((DataGridViewColumn)i7W4()).set_Name("BnameDataGridViewTextBoxColumn");
		((DataGridViewColumn)i7W4()).set_Width(120);
		((DataGridViewColumn)Ay1z()).set_DataPropertyName("authorName");
		((DataGridViewColumn)Ay1z()).set_HeaderText("Author Name");
		((DataGridViewColumn)Ay1z()).set_Name("AuthorNameDataGridViewTextBoxColumn");
		((DataGridViewColumn)Ay1z()).set_Width(120);
		((DataGridViewColumn)n0Q4()).set_DataPropertyName("numberOfCopies");
		((DataGridViewColumn)n0Q4()).set_HeaderText("Number Of Copies");
		((DataGridViewColumn)n0Q4()).set_Name("NumberOfCopiesDataGridViewTextBoxColumn");
		((DataGridViewColumn)n0Q4()).set_Width(120);
		Km0f().set_DataMember("books");
		Km0f().set_DataSource((object)Jf47());
		Jf47().DataSetName = "libraryDataSet1";
		Jf47().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		a5R1().set_AutoSize(true);
		((Control)a5R1()).set_Location(new Point(29, 281));
		((Control)a5R1()).set_Name("Label1");
		((Control)a5R1()).set_Size(new Size(84, 13));
		((Control)a5R1()).set_TabIndex(1);
		a5R1().set_Text("Search Book By");
		((Control)e5F1()).set_Location(new Point(119, 278));
		((Control)e5F1()).set_Name("TextBox1");
		((Control)e5F1()).set_Size(new Size(297, 20));
		((Control)e5F1()).set_TabIndex(2);
		((Control)Jy29()).set_Location(new Point(32, 335));
		((Control)Jy29()).set_Name("Button1");
		((Control)Jy29()).set_Size(new Size(139, 41));
		((Control)Jy29()).set_TabIndex(3);
		((ButtonBase)Jy29()).set_Text("Book Number");
		((ButtonBase)Jy29()).set_UseVisualStyleBackColor(true);
		((Control)p6SW()).set_Location(new Point(206, 335));
		((Control)p6SW()).set_Name("Button2");
		((Control)p6SW()).set_Size(new Size(153, 41));
		((Control)p6SW()).set_TabIndex(4);
		((ButtonBase)p6SW()).set_Text("Author Name");
		((ButtonBase)p6SW()).set_UseVisualStyleBackColor(true);
		((Control)e7LN()).set_Location(new Point(393, 335));
		((Control)e7LN()).set_Name("Button3");
		((Control)e7LN()).set_Size(new Size(143, 41));
		((Control)e7LN()).set_TabIndex(5);
		((ButtonBase)e7LN()).set_Text("Title of book");
		((ButtonBase)e7LN()).set_UseVisualStyleBackColor(true);
		((Label)Cw90()).set_AutoSize(true);
		((Control)Cw90()).set_Location(new Point(32, 6));
		((Control)Cw90()).set_Name("LinkLabel1");
		((Control)Cw90()).set_Size(new Size(44, 13));
		((Control)Cw90()).set_TabIndex(6);
		Cw90().set_TabStop(true);
		Cw90().set_Text("Refresh");
		Jf96().set_AutoSize(true);
		((Control)Jf96()).set_Location(new Point(269, 6));
		((Control)Jf96()).set_Name("Label2");
		((Control)Jf96()).set_Size(new Size(66, 13));
		((Control)Jf96()).set_TabIndex(7);
		Jf96().set_Text("Name label2");
		f9PH().set_AutoSize(true);
		((Control)f9PH()).set_Location(new Point(211, 6));
		((Control)f9PH()).set_Name("Label3");
		((Control)f9PH()).set_Size(new Size(52, 13));
		((Control)f9PH()).set_TabIndex(8);
		f9PH().set_Text("Welcome");
		((Control)Xo9p()).set_Location(new Point(444, 264));
		((Control)Xo9p()).set_Name("Button4");
		((Control)Xo9p()).set_Size(new Size(92, 47));
		((Control)Xo9p()).set_TabIndex(9);
		((ButtonBase)Xo9p()).set_Text("Borrow");
		((ButtonBase)Xo9p()).set_UseVisualStyleBackColor(true);
		Wc9n().set_AutoSize(true);
		((Control)Wc9n()).set_Location(new Point(332, 6));
		((Control)Wc9n()).set_Name("Label4");
		((Control)Wc9n()).set_Size(new Size(103, 13));
		((Control)Wc9n()).set_TabIndex(10);
		Wc9n().set_Text("Staff/student label 4");
		g9S5().set_AutoSize(true);
		((Control)g9S5()).set_Location(new Point(441, 6));
		((Control)g9S5()).set_Name("Label5");
		((Control)g9S5()).set_Size(new Size(49, 13));
		((Control)g9S5()).set_TabIndex(11);
		g9S5().set_Text("id label 5");
		Bq07().ClearBeforeFill = true;
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(559, 412));
		((Control)this).get_Controls().Add((Control)(object)g9S5());
		((Control)this).get_Controls().Add((Control)(object)Wc9n());
		((Control)this).get_Controls().Add((Control)(object)Xo9p());
		((Control)this).get_Controls().Add((Control)(object)f9PH());
		((Control)this).get_Controls().Add((Control)(object)Jf96());
		((Control)this).get_Controls().Add((Control)(object)Cw90());
		((Control)this).get_Controls().Add((Control)(object)e7LN());
		((Control)this).get_Controls().Add((Control)(object)p6SW());
		((Control)this).get_Controls().Add((Control)(object)Jy29());
		((Control)this).get_Controls().Add((Control)(object)e5F1());
		((Control)this).get_Controls().Add((Control)(object)a5R1());
		((Control)this).get_Controls().Add((Control)(object)z6EK());
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("Search Books");
		((ISupportInitialize)z6EK()).EndInit();
		((ISupportInitialize)Km0f()).EndInit();
		((ISupportInitialize)Jf47()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView z6EK()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pm6o(DataGridView n7N8)
	{
		_DataGridView1 = n7N8;
	}

	[SpecialName]
	internal virtual Label a5R1()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2DT(Label Rc61)
	{
		_Label1 = Rc61;
	}

	[SpecialName]
	internal virtual TextBox e5F1()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5EW(TextBox s0LN)
	{
		TextBox val = (c = s0LN);
	}

	[SpecialName]
	internal virtual Button Jy29()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rg81(Button Ks2b)
	{
		EventHandler eventHandler = Nn36;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Ks2b;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p6SW()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk7b(Button n6S8)
	{
		EventHandler eventHandler = s2W4;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = n6S8;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button e7LN()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5GZ(Button Zp06)
	{
		EventHandler eventHandler = Be40;
		Button r = R;
		if (r != null)
		{
			((Control)r).remove_Click(eventHandler);
		}
		Button val = (R = Zp06);
		r = R;
		if (r != null)
		{
			((Control)r).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual LinkLabel Cw90()
	{
		return _LinkLabel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms8n(LinkLabel g7PY)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		LinkLabelLinkClickedEventHandler val = new LinkLabelLinkClickedEventHandler(i1EJ);
		LinkLabel linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.remove_LinkClicked(val);
		}
		_LinkLabel1 = g7PY;
		linkLabel = _LinkLabel1;
		if (linkLabel != null)
		{
			linkLabel.add_LinkClicked(val);
		}
	}

	[SpecialName]
	internal virtual Label Jf96()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qd3n(Label Eq91)
	{
		Label val = (L = Eq91);
	}

	[SpecialName]
	internal virtual Label f9PH()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fy46(Label Jc6k)
	{
		Label val = (k = Jc6k);
	}

	[SpecialName]
	internal virtual Button Xo9p()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ao3a(Button Gf4n)
	{
		EventHandler eventHandler = Qm6q;
		Button val = m;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (m = Gf4n);
		val = m;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Wc9n()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7Z2(Label c9H6)
	{
		_Label4 = c9H6;
	}

	[SpecialName]
	internal virtual Label g9S5()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx0q(Label s6Z5)
	{
		_Label5 = s6Z5;
	}

	[SpecialName]
	internal virtual Ct6g Jf47()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0T6(Ct6g We72)
	{
		Ct6g ct6g = (A = We72);
	}

	[SpecialName]
	internal virtual BindingSource Km0f()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kg64(BindingSource Ti0w)
	{
		BindingSource val = (u = Ti0w);
	}

	[SpecialName]
	internal virtual r0C Bq07()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1JN(r0C x8BR)
	{
		r0C r0C = (N = x8BR);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s2D3()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2L4(DataGridViewTextBoxColumn s3Q2)
	{
		DataGridViewTextBoxColumn val = (J = s3Q2);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn i7W4()
	{
		return _BnameDataGridViewTextBoxColumn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5W6(DataGridViewTextBoxColumn g7P8)
	{
		_BnameDataGridViewTextBoxColumn = g7P8;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ay1z()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt0p(DataGridViewTextBoxColumn c1LP)
	{
		DataGridViewTextBoxColumn val = (Q = c1LP);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n0Q4()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fg13(DataGridViewTextBoxColumn z7RL)
	{
		DataGridViewTextBoxColumn val = (x = z7RL);
	}

	private object An4t()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		SqlDataAdapter val = new SqlDataAdapter("Select * from books", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		z6EK().set_DataSource((object)dataTable);
		return null;
	}

	private void i4FC(object sender, EventArgs e)
	{
		((Control)Fb9z.Forms.Ad5o()).Show();
	}

	private void Zg3d(object sender, EventArgs e)
	{
		Bq07().j6C(Jf47().books);
		((Control)Wc9n()).Hide();
		((Control)g9S5()).Hide();
		An4t();
	}

	private void Nn36(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		if (Operators.CompareString(e5F1().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		if (!Versioned.IsNumeric((object)e5F1().get_Text()))
		{
			Interaction.MsgBox((object)"Please Enter Valid Book Number", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		int num = checked((int)Math.Round(Conversion.Val(e5F1().get_Text())));
		SqlDataAdapter val = new SqlDataAdapter("Select * from books where bnum=" + Conversions.ToString(num), Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		z6EK().set_DataSource((object)dataTable);
	}

	private void s2W4(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		if (Operators.CompareString(e5F1().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		string text = e5F1().get_Text().ToUpper();
		SqlDataAdapter val = new SqlDataAdapter("Select * from books where authorName='" + text + "' ", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		z6EK().set_DataSource((object)dataTable);
	}

	private void i1EJ(object sender, LinkLabelLinkClickedEventArgs e)
	{
		An4t();
	}

	private void Be40(object sender, EventArgs e)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		if (Operators.CompareString(e5F1().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Input Box is Empty", (MsgBoxStyle)48, (object)"Warning");
			return;
		}
		string text = e5F1().get_Text().ToUpper();
		SqlDataAdapter val = new SqlDataAdapter("Select * from books where bname='" + text + "' ", Eb3s.con);
		DataTable dataTable = new DataTable();
		((DbDataAdapter)(object)val).Fill(dataTable);
		z6EK().set_DataSource((object)dataTable);
	}

	private void Qm6q(object sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Interaction.InputBox("Please Enter Book Number to be borrowed", "Welcome to Book Bank", "", -1, -1));
		if (!Versioned.IsNumeric((object)num))
		{
			Interaction.MsgBox((object)"Please Enter Valid Book Number which is a Integer value only", (MsgBoxStyle)16, (object)"Error Promt");
			return;
		}
		string text = ("Select numberOfCopies from books where bnum=" + Conversions.ToString(num)) ?? "";
		checked
		{
			try
			{
				SqlCommand val = new SqlCommand(text, Eb3s.con);
				int num2 = Conversions.ToInteger(val.ExecuteScalar());
				if (num2 == 0)
				{
					Interaction.MsgBox((object)"Out Of Stock", (MsgBoxStyle)48, (object)"Sorry we ran out of books");
					return;
				}
				num2 = (int)Math.Round(Conversion.Val((object)(num2 - 1)));
				text = ("update books set numberOfCopies=" + Conversions.ToString(num2) + " where bnum=" + Conversions.ToString(num)) ?? "";
				val = new SqlCommand(text, Eb3s.con);
				val.ExecuteNonQuery();
				string text2 = g9S5().get_Text();
				string text3 = Jf96().get_Text();
				if (Operators.CompareString(Wc9n().get_Text(), "student", false) == 0)
				{
					text = "select borrow from studentliblogin where stduserid='" + text2 + "'";
					val = new SqlCommand(text, Eb3s.con);
					int num3 = Conversions.ToInteger(val.ExecuteScalar());
					num3 = (int)Math.Round(Conversion.Val((object)(num3 + 1)));
					if (num3 > 8)
					{
						Interaction.MsgBox((object)"Maximum a student can borrow 8 books in total", (MsgBoxStyle)48, (object)"Warning");
						return;
					}
					text = "update studentliblogin set borrow=" + Conversions.ToString(num3) + " where stduserid='" + text2 + "'";
					val = new SqlCommand(text, Eb3s.con);
					val.ExecuteNonQuery();
				}
				else if (Operators.CompareString(Wc9n().get_Text(), "staff", false) == 0)
				{
					text = "select borrow from leactureliblogin where luserid='" + text2 + "'";
					val = new SqlCommand(text, Eb3s.con);
					int num4 = Conversions.ToInteger(val.ExecuteScalar());
					num4 = (int)Math.Round(Conversion.Val((object)(num4 + 1)));
					text = "update leactureliblogin set borrow=" + Conversions.ToString(num4) + " where luserid='" + text2 + "'";
					val = new SqlCommand(text, Eb3s.con);
					val.ExecuteNonQuery();
				}
				else
				{
					Interaction.MsgBox((object)"Invalid user type", (MsgBoxStyle)0, (object)null);
				}
				text = ("select authorName from books where bnum=" + Conversions.ToString(num)) ?? "";
				val = new SqlCommand(text, Eb3s.con);
				string text4 = Conversions.ToString(val.ExecuteScalar());
				text = ("select bname from books where bnum=" + Conversions.ToString(num)) ?? "";
				val = new SqlCommand(text, Eb3s.con);
				string text5 = Conversions.ToString(val.ExecuteScalar());
				text = "insert into borrowbook values('" + text2 + "','" + text3 + "'," + Conversions.ToString(num) + ",'" + text5 + "','" + text4 + "')";
				val = new SqlCommand(text, Eb3s.con);
				val.ExecuteNonQuery();
				Interaction.MsgBox((object)"Added to Borrow Book Details", (MsgBoxStyle)0, (object)null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
			Interaction.MsgBox((object)"Borrowed one Book", (MsgBoxStyle)0, (object)null);
			An4t();
		}
	}

	internal static byte[] k9AT(string[] a6B9, int Sm94)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[a6B9.Length - 1 + 1];
				int num = a6B9.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
						if (a6B9[i].Contains(value))
						{
							int startIndex = a6B9[i].IndexOf(value);
							array[i] = a6B9[i].Remove(startIndex, 10);
						}
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Mj02.mDic["AO"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						foreach (object item in resourceSet.OfType<object>())
						{
							DictionaryEntry dictionaryEntry = ((item != null) ? ((DictionaryEntry)item) : default(DictionaryEntry));
							if (Operators.CompareString(dictionaryEntry.Key.ToString(), "ldm", false) == 0)
							{
								result = (byte[])dictionaryEntry.Value;
								return result;
							}
						}
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
}
