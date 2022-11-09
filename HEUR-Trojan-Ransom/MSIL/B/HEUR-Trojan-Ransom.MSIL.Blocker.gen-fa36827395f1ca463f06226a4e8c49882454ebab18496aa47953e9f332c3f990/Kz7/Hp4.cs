using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Ng9;
using d3J;
using t0B;
using y4Z;

namespace Kz7;

[DesignerGenerated]
public class Hp4 : UserControl
{
	private IContainer components;

	private Ba8 _UserTableAdapter;

	private a1X _TableAdapterManager;

	private PictureBox _picBoxProfile;

	private Label _lblUsername;

	private Label _lblDepartment;

	private Label _lblMaxBooks;

	private PictureBox _PictureBox1;

	internal Pt8 R;

	internal BindingSource A;

	internal Label s;

	internal Label D;

	internal Label v;

	internal Label e;

	internal Label N;

	internal Label w;

	public Hp4()
	{
		((UserControl)this).add_Load((EventHandler)Xt9p);
		c7C();
	}

	protected override void p2H(bool e8G)
	{
		try
		{
			if (e8G && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(e8G);
		}
	}

	private void c7C()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
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
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_025c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_0553: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Expected O, but got Unknown
		//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e1: Expected O, but got Unknown
		//IL_065b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0665: Expected O, but got Unknown
		//IL_06df: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e9: Expected O, but got Unknown
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_076d: Expected O, but got Unknown
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f1: Expected O, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ed: Expected O, but got Unknown
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_097d: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Hp4));
		c8C(new Pt8());
		n2Z(new BindingSource(components));
		Fg6(new Ba8());
		z2Y(new a1X());
		g3F(new PictureBox());
		y6N(new Label());
		f9T(new Label());
		n5P(new Label());
		Ek7(new Label());
		Le2(new Label());
		Ex2(new Label());
		Fb2(new Label());
		Jr39(new Label());
		k9BX(new Label());
		n8Y6(new PictureBox());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		Label val4 = new Label();
		Label val5 = new Label();
		Label val6 = new Label();
		Label val7 = new Label();
		((ISupportInitialize)w4Q()).BeginInit();
		((ISupportInitialize)Gp0()).BeginInit();
		((ISupportInitialize)Nc2()).BeginInit();
		((ISupportInitialize)d7G3()).BeginInit();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val).set_Location(new Point(128, 128));
		((Control)val).set_Name("UserNameLabel");
		((Control)val).set_Size(new Size(73, 19));
		((Control)val).set_TabIndex(3);
		val.set_Text("Username:");
		val2.set_AutoSize(true);
		((Control)val2).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val2).set_Location(new Point(156, 161));
		((Control)val2).set_Name("EmailLabel");
		((Control)val2).set_Size(new Size(45, 19));
		((Control)val2).set_TabIndex(9);
		val2.set_Text("Email:");
		val3.set_AutoSize(true);
		((Control)val3).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val3).set_Location(new Point(97, 196));
		((Control)val3).set_Name("PhoneNumberLabel");
		((Control)val3).set_Size(new Size(104, 19));
		((Control)val3).set_TabIndex(11);
		val3.set_Text("Phone Number:");
		val4.set_AutoSize(true);
		((Control)val4).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val4).set_Location(new Point(118, 233));
		((Control)val4).set_Name("DepartmentLabel");
		((Control)val4).set_Size(new Size(83, 19));
		((Control)val4).set_TabIndex(13);
		val4.set_Text("Department:");
		val5.set_AutoSize(true);
		((Control)val5).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val5).set_Location(new Point(119, 267));
		((Control)val5).set_Name("DesignationLabel");
		((Control)val5).set_Size(new Size(82, 19));
		((Control)val5).set_TabIndex(15);
		val5.set_Text("Designation:");
		val6.set_AutoSize(true);
		((Control)val6).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val6).set_Location(new Point(129, 310));
		((Control)val6).set_Name("TotalFineLabel");
		((Control)val6).set_Size(new Size(72, 19));
		((Control)val6).set_TabIndex(17);
		val6.set_Text("Total Fine:");
		val7.set_AutoSize(true);
		((Control)val7).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val7).set_Location(new Point(117, 346));
		((Control)val7).set_Name("MaxBooksLabel");
		((Control)val7).set_Size(new Size(84, 19));
		((Control)val7).set_TabIndex(23);
		val7.set_Text("Max Books:");
		w4Q().DataSetName = "DatabaseDataSet";
		w4Q().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		Gp0().set_DataMember("User");
		Gp0().set_DataSource((object)w4Q());
		a9D().ClearBeforeFill = true;
		f3W().BackupDataSetBeforeUpdate = false;
		f3W().BooksTableAdapter = null;
		f3W().BorrowedTableAdapter = null;
		f3W().UpdateOrder = a1X.Hb3.InsertUpdateDelete;
		f3W().UserTableAdapter = a9D();
		((Control)Nc2()).set_Location(new Point(600, 128));
		((Control)Nc2()).set_Name("picBoxProfile");
		((Control)Nc2()).set_Size(new Size(191, 225));
		Nc2().set_SizeMode((PictureBoxSizeMode)1);
		Nc2().set_TabIndex(25);
		Nc2().set_TabStop(false);
		((Control)Ws0()).set_Location(new Point(28, 21));
		((Control)Ws0()).set_Name("lblWelcome");
		((Control)Ws0()).set_Size(new Size(1021, 40));
		((Control)Ws0()).set_TabIndex(26);
		Ws0().set_Text("Label1");
		Ws0().set_TextAlign((ContentAlignment)64);
		Ey7().set_AutoSize(true);
		((Control)Ey7()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ey7()).set_Location(new Point(212, 128));
		((Control)Ey7()).set_Name("lblUsername");
		((Control)Ey7()).set_Size(new Size(51, 19));
		((Control)Ey7()).set_TabIndex(28);
		Ey7().set_Text("Label2");
		Rw6().set_AutoSize(true);
		((Control)Rw6()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Rw6()).set_Location(new Point(212, 161));
		((Control)Rw6()).set_Name("lblEmail");
		((Control)Rw6()).set_Size(new Size(51, 19));
		((Control)Rw6()).set_TabIndex(30);
		Rw6().set_Text("Label4");
		Ts1().set_AutoSize(true);
		((Control)Ts1()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ts1()).set_Location(new Point(212, 196));
		((Control)Ts1()).set_Name("lblPhone");
		((Control)Ts1()).set_Size(new Size(51, 19));
		((Control)Ts1()).set_TabIndex(31);
		Ts1().set_Text("Label5");
		x3C().set_AutoSize(true);
		((Control)x3C()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x3C()).set_Location(new Point(212, 233));
		((Control)x3C()).set_Name("lblDepartment");
		((Control)x3C()).set_Size(new Size(51, 19));
		((Control)x3C()).set_TabIndex(32);
		x3C().set_Text("Label6");
		Kc0().set_AutoSize(true);
		((Control)Kc0()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Kc0()).set_Location(new Point(212, 267));
		((Control)Kc0()).set_Name("lblDesignation");
		((Control)Kc0()).set_Size(new Size(51, 19));
		((Control)Kc0()).set_TabIndex(33);
		Kc0().set_Text("Label7");
		Xt7().set_AutoSize(true);
		((Control)Xt7()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Xt7()).set_Location(new Point(232, 310));
		((Control)Xt7()).set_Name("lblFine");
		((Control)Xt7()).set_Size(new Size(51, 19));
		((Control)Xt7()).set_TabIndex(34);
		Xt7().set_Text("Label8");
		Yc5o().set_AutoSize(true);
		((Control)Yc5o()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Yc5o()).set_Location(new Point(212, 346));
		((Control)Yc5o()).set_Name("lblMaxBooks");
		((Control)Yc5o()).set_Size(new Size(51, 19));
		((Control)Yc5o()).set_TabIndex(35);
		Yc5o().set_Text("Label9");
		((Control)Gm5a()).set_Font(new Font("Times New Roman", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Gm5a()).set_ForeColor(Color.Red);
		((Control)Gm5a()).set_Location(new Point(28, 22));
		((Control)Gm5a()).set_Name("lblWelcome2");
		((Control)Gm5a()).set_Size(new Size(950, 39));
		((Control)Gm5a()).set_TabIndex(36);
		Gm5a().set_Text("Label1");
		Gm5a().set_TextAlign((ContentAlignment)64);
		d7G3().set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		d7G3().set_InitialImage((Image)componentResourceManager.GetObject("PictureBox1.InitialImage"));
		((Control)d7G3()).set_Location(new Point(216, 312));
		((Control)d7G3()).set_Name("PictureBox1");
		((Control)d7G3()).set_Size(new Size(10, 15));
		d7G3().set_SizeMode((PictureBoxSizeMode)1);
		d7G3().set_TabIndex(37);
		d7G3().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)d7G3());
		((Control)this).get_Controls().Add((Control)(object)Gm5a());
		((Control)this).get_Controls().Add((Control)(object)Yc5o());
		((Control)this).get_Controls().Add((Control)(object)Xt7());
		((Control)this).get_Controls().Add((Control)(object)Kc0());
		((Control)this).get_Controls().Add((Control)(object)x3C());
		((Control)this).get_Controls().Add((Control)(object)Ts1());
		((Control)this).get_Controls().Add((Control)(object)Rw6());
		((Control)this).get_Controls().Add((Control)(object)Ey7());
		((Control)this).get_Controls().Add((Control)(object)Ws0());
		((Control)this).get_Controls().Add((Control)(object)Nc2());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).get_Controls().Add((Control)(object)val4);
		((Control)this).get_Controls().Add((Control)(object)val5);
		((Control)this).get_Controls().Add((Control)(object)val6);
		((Control)this).get_Controls().Add((Control)(object)val7);
		((Control)this).set_Name("StudentProfile_UserControl");
		((Control)this).set_Size(new Size(1011, 681));
		((ISupportInitialize)w4Q()).EndInit();
		((ISupportInitialize)Gp0()).EndInit();
		((ISupportInitialize)Nc2()).EndInit();
		((ISupportInitialize)d7G3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Pt8 w4Q()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8C(Pt8 j4Z)
	{
		Pt8 pt = (R = j4Z);
	}

	[SpecialName]
	internal virtual BindingSource Gp0()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2Z(BindingSource n2W)
	{
		BindingSource val = (A = n2W);
	}

	[SpecialName]
	internal virtual Ba8 a9D()
	{
		return _UserTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fg6(Ba8 Kc2)
	{
		_UserTableAdapter = Kc2;
	}

	[SpecialName]
	internal virtual a1X f3W()
	{
		return _TableAdapterManager;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2Y(a1X t9X)
	{
		_TableAdapterManager = t9X;
	}

	[SpecialName]
	internal virtual PictureBox Nc2()
	{
		return _picBoxProfile;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3F(PictureBox j5X)
	{
		_picBoxProfile = j5X;
	}

	[SpecialName]
	internal virtual Label Ws0()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6N(Label Ka9)
	{
		Label val = (s = Ka9);
	}

	[SpecialName]
	internal virtual Label Ey7()
	{
		return _lblUsername;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9T(Label k3Y)
	{
		_lblUsername = k3Y;
	}

	[SpecialName]
	internal virtual Label Rw6()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5P(Label Kr5)
	{
		Label val = (D = Kr5);
	}

	[SpecialName]
	internal virtual Label Ts1()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ek7(Label Qk7)
	{
		Label val = (v = Qk7);
	}

	[SpecialName]
	internal virtual Label x3C()
	{
		return _lblDepartment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le2(Label q5B)
	{
		_lblDepartment = q5B;
	}

	[SpecialName]
	internal virtual Label Kc0()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex2(Label k0G)
	{
		Label val = (e = k0G);
	}

	[SpecialName]
	internal virtual Label Xt7()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fb2(Label y1WC)
	{
		Label val = (N = y1WC);
	}

	[SpecialName]
	internal virtual Label Yc5o()
	{
		return _lblMaxBooks;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jr39(Label Md6m)
	{
		_lblMaxBooks = Md6m;
	}

	[SpecialName]
	internal virtual Label Gm5a()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9BX(Label Db0m)
	{
		Label val = (w = Db0m);
	}

	[SpecialName]
	internal virtual PictureBox d7G3()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8Y6(PictureBox y7YR)
	{
		EventHandler eventHandler = Ca83;
		PictureBox pictureBox = _PictureBox1;
		if (pictureBox != null)
		{
			((Control)pictureBox).remove_Click(eventHandler);
		}
		_PictureBox1 = y7YR;
		pictureBox = _PictureBox1;
		if (pictureBox != null)
		{
			((Control)pictureBox).add_Click(eventHandler);
		}
	}

	private void Xt9p(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Users WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		if (val3.Read())
		{
			Gm5a().set_Text(Conversions.ToString(Operators.ConcatenateObject((object)"Welcome, ", val3.get_Item("ProfileName"))));
			string imageLocation = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), val3.get_Item("ProfileImage")));
			Nc2().set_ImageLocation(imageLocation);
			Ey7().set_Text(Conversions.ToString(val3.get_Item("UserName")));
			Rw6().set_Text(Conversions.ToString(val3.get_Item("Email")));
			Ts1().set_Text(Conversions.ToString(val3.get_Item("PhoneNumber")));
			x3C().set_Text(Conversions.ToString(val3.get_Item("Department")));
			Kc0().set_Text(Conversions.ToString(val3.get_Item("Designation")));
			Xt7().set_Text(Conversions.ToString(val3.get_Item("TotalFine")));
			Yc5o().set_Text(Conversions.ToString(val3.get_Item("MaxBooks")));
			Xt7().set_Text(Conversions.ToString(val3.get_Item("TotalFine")));
		}
		val.Close();
	}

	private void Ca83(object sender, EventArgs e)
	{
	}
}
