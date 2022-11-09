using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Ng9;
using d3J;
using t0B;
using y4Z;

namespace s5R7;

[DesignerGenerated]
public class r5HK : UserControl
{
	private Pt8 _DatabaseDataSet;

	private Ba8 _UserTableAdapter;

	private TextBox _txtName;

	private Button _btnUpdate;

	private PictureBox _picBoxProfile;

	private OpenFileDialog _OpenFileDialog1;

	private ContextMenuStrip _ContextMenuStrip1;

	private ToolStripMenuItem _BiosciencesAndBioengineeringToolStripMenuItem;

	private ToolStripMenuItem _ChemicalEngineeringToolStripMenuItem;

	private ToolStripMenuItem _ChemistryToolStripMenuItem;

	private ToolStripMenuItem _CivilEngineeringToolStripMenuItem;

	private ToolStripMenuItem _ComputerScienceAndEnggToolStripMenuItem;

	private ToolStripMenuItem _MathematicsToolStripMenuItem;

	private ToolStripMenuItem _MechanicjalEngineeringToolStripMenuItem;

	private ComboBox _ComboBox1;

	private Label _Label1;

	internal IContainer X;

	internal BindingSource j;

	internal a1X V;

	internal TextBox O;

	internal TextBox i;

	internal Button s;

	internal ToolStripMenuItem t;

	internal ToolStripMenuItem a;

	public r5HK()
	{
		((UserControl)this).add_Load((EventHandler)Hr17);
		Yo9y();
	}

	protected override void Ef9m(bool q5M4)
	{
		try
		{
			if (q5M4 && X != null)
			{
				X.Dispose();
			}
		}
		finally
		{
			((ContainerControl)this).Dispose(q5M4);
		}
	}

	private void Yo9y()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d2: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d5: Expected O, but got Unknown
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f2: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected O, but got Unknown
		IContainer container = (X = new Container());
		w0LH(new Pt8());
		Sc0d(new BindingSource(X));
		y0F9(new Ba8());
		i4WC(new a1X());
		s8BQ(new TextBox());
		k8G1(new TextBox());
		Zw17(new TextBox());
		Eo6f(new Button());
		Wi7x(new PictureBox());
		Na1p(new Button());
		r0Z4(new OpenFileDialog());
		n7A8(new ContextMenuStrip(X));
		Ys95(new ToolStripMenuItem());
		Pf50(new ToolStripMenuItem());
		Ln02(new ToolStripMenuItem());
		Pk53(new ToolStripMenuItem());
		e3T1(new ToolStripMenuItem());
		Gy2t(new ToolStripMenuItem());
		c1W6(new ToolStripMenuItem());
		Pp6f(new ToolStripMenuItem());
		Mz71(new ToolStripMenuItem());
		Pf3q(new ComboBox());
		x6ZN(new Label());
		Label val = new Label();
		Label val2 = new Label();
		Label val3 = new Label();
		Label val4 = new Label();
		((ISupportInitialize)Nk16()).BeginInit();
		((ISupportInitialize)De10()).BeginInit();
		((ISupportInitialize)Me3w()).BeginInit();
		((Control)Mp16()).SuspendLayout();
		((Control)this).SuspendLayout();
		val.set_AutoSize(true);
		((Control)val).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val).set_Location(new Point(123, 211));
		((Control)val).set_Name("EmailLabel");
		((Control)val).set_Size(new Size(45, 19));
		((Control)val).set_TabIndex(9);
		val.set_Text("Email:");
		((Control)val).add_Click((EventHandler)Qn3z);
		val2.set_AutoSize(true);
		((Control)val2).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val2).set_Location(new Point(64, 244));
		((Control)val2).set_Name("PhoneNumberLabel");
		((Control)val2).set_Size(new Size(104, 19));
		((Control)val2).set_TabIndex(11);
		val2.set_Text("Phone Number:");
		((Control)val2).add_Click((EventHandler)Tw0z);
		val3.set_AutoSize(true);
		((Control)val3).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val3).set_Location(new Point(85, 282));
		((Control)val3).set_Name("DepartmentLabel");
		((Control)val3).set_Size(new Size(83, 19));
		((Control)val3).set_TabIndex(13);
		val3.set_Text("Department:");
		((Control)val3).add_Click((EventHandler)i4K0);
		val4.set_AutoSize(true);
		((Control)val4).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)val4).set_Location(new Point(123, 104));
		((Control)val4).set_Name("UserNameLabel");
		((Control)val4).set_Size(new Size(49, 19));
		((Control)val4).set_TabIndex(3);
		val4.set_Text("Name:");
		((Control)val4).add_Click((EventHandler)m1Y6);
		Nk16().DataSetName = "DatabaseDataSet";
		Nk16().SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		De10().set_DataMember("User");
		De10().set_DataSource((object)Nk16());
		Pj2n().ClearBeforeFill = true;
		t7Z4().BackupDataSetBeforeUpdate = false;
		t7Z4().BooksTableAdapter = null;
		t7Z4().BorrowedTableAdapter = null;
		t7Z4().UpdateOrder = a1X.Hb3.InsertUpdateDelete;
		t7Z4().UserTableAdapter = Pj2n();
		((Control)i7B3()).get_DataBindings().Add(new Binding("Text", (object)De10(), "Email", true));
		((Control)i7B3()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)i7B3()).set_Location(new Point(202, 211));
		((Control)i7B3()).set_Name("EmailTextBox");
		((Control)i7B3()).set_Size(new Size(225, 26));
		((Control)i7B3()).set_TabIndex(10);
		((Control)Qt0n()).get_DataBindings().Add(new Binding("Text", (object)De10(), "PhoneNumber", true));
		((Control)Qt0n()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Qt0n()).set_Location(new Point(202, 244));
		((Control)Qt0n()).set_Name("PhoneNumberTextBox");
		((Control)Qt0n()).set_Size(new Size(225, 26));
		((Control)Qt0n()).set_TabIndex(12);
		((Control)k1LZ()).get_DataBindings().Add(new Binding("Text", (object)De10(), "UserName", true));
		((Control)k1LZ()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k1LZ()).set_Location(new Point(202, 104));
		((Control)k1LZ()).set_Name("txtName");
		((Control)k1LZ()).set_Size(new Size(225, 26));
		((Control)k1LZ()).set_TabIndex(4);
		((ButtonBase)r5J7()).set_BackColor(Color.MediumSeaGreen);
		((Control)r5J7()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)r5J7()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)r5J7()).set_FlatStyle((FlatStyle)1);
		((Control)r5J7()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)r5J7()).set_ForeColor(Color.White);
		((Control)r5J7()).set_Location(new Point(202, 382));
		((Control)r5J7()).set_Name("btnUpdate");
		((Control)r5J7()).set_Size(new Size(225, 42));
		((Control)r5J7()).set_TabIndex(15);
		((ButtonBase)r5J7()).set_Text("Update Profile");
		((ButtonBase)r5J7()).set_UseVisualStyleBackColor(false);
		((Control)Me3w()).set_Location(new Point(559, 104));
		((Control)Me3w()).set_Name("picBoxProfile");
		((Control)Me3w()).set_Size(new Size(200, 205));
		Me3w().set_SizeMode((PictureBoxSizeMode)1);
		Me3w().set_TabIndex(16);
		Me3w().set_TabStop(false);
		((ButtonBase)f0XN()).set_BackColor(Color.MediumSeaGreen);
		((Control)f0XN()).set_Cursor(Cursors.get_Hand());
		((ButtonBase)f0XN()).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)f0XN()).set_FlatStyle((FlatStyle)1);
		((Control)f0XN()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)f0XN()).set_ForeColor(Color.White);
		((Control)f0XN()).set_Location(new Point(559, 336));
		((Control)f0XN()).set_Name("btnChangePic");
		((Control)f0XN()).set_Size(new Size(200, 41));
		((Control)f0XN()).set_TabIndex(17);
		((ButtonBase)f0XN()).set_Text("Upload Image");
		((ButtonBase)f0XN()).set_UseVisualStyleBackColor(false);
		((FileDialog)q7D5()).set_FileName("OpenFileDialog1");
		((ToolStrip)Mp16()).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)Mp16()).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[9]
		{
			(ToolStripItem)i7A5(),
			(ToolStripItem)Ni71(),
			(ToolStripItem)j8N0(),
			(ToolStripItem)e9NP(),
			(ToolStripItem)Jm5x(),
			(ToolStripItem)q4CB(),
			(ToolStripItem)q7C4(),
			(ToolStripItem)Ks1w(),
			(ToolStripItem)e9CD()
		});
		((Control)Mp16()).set_Name("ContextMenuStrip1");
		((Control)Mp16()).set_Size(new Size(242, 202));
		((ToolStripItem)i7A5()).set_Name("BiosciencesAndBioengineeringToolStripMenuItem");
		((ToolStripItem)i7A5()).set_Size(new Size(241, 22));
		((ToolStripItem)i7A5()).set_Text("Biosciences and Bioengineering");
		((ToolStripItem)Ni71()).set_Name("ChemicalEngineeringToolStripMenuItem");
		((ToolStripItem)Ni71()).set_Size(new Size(241, 22));
		((ToolStripItem)Ni71()).set_Text("Chemical Engineering");
		((ToolStripItem)j8N0()).set_Name("ChemistryToolStripMenuItem");
		((ToolStripItem)j8N0()).set_Size(new Size(241, 22));
		((ToolStripItem)j8N0()).set_Text("Chemistry");
		((ToolStripItem)e9NP()).set_Name("CivilEngineeringToolStripMenuItem");
		((ToolStripItem)e9NP()).set_Size(new Size(241, 22));
		((ToolStripItem)e9NP()).set_Text("Civil Engineering");
		((ToolStripItem)Jm5x()).set_Name("ComputerScienceAndEnggToolStripMenuItem");
		((ToolStripItem)Jm5x()).set_Size(new Size(241, 22));
		((ToolStripItem)Jm5x()).set_Text("Computer Science and Engg");
		((ToolStripItem)q4CB()).set_Name("HumanitiesAndSocialSciencesToolStripMenuItem");
		((ToolStripItem)q4CB()).set_Size(new Size(241, 22));
		((ToolStripItem)q4CB()).set_Text("Humanities and Social Sciences");
		((ToolStripItem)q7C4()).set_Name("MathematicsToolStripMenuItem");
		((ToolStripItem)q7C4()).set_Size(new Size(241, 22));
		((ToolStripItem)q7C4()).set_Text("Mathematics");
		((ToolStripItem)Ks1w()).set_Name("MechanicjalEngineeringToolStripMenuItem");
		((ToolStripItem)Ks1w()).set_Size(new Size(241, 22));
		((ToolStripItem)Ks1w()).set_Text("Mechanical Engineering");
		((ToolStripItem)e9CD()).set_Name("PhysicsToolStripMenuItem");
		((ToolStripItem)e9CD()).set_Size(new Size(241, 22));
		((ToolStripItem)e9CD()).set_Text("Physics");
		w0YK().set_DropDownStyle((ComboBoxStyle)2);
		((Control)w0YK()).set_Font(new Font("Times New Roman", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)w0YK()).set_FormattingEnabled(true);
		w0YK().get_Items().AddRange(new object[11]
		{
			"Biosciences and Bioengineering", "Chemical Engineering", "Chemistry", "Civil Engineering", "Computer Science and Engg.", "Design", "Electronics and Electrical Engg.", "Humanities and Social Sciences", "Mathematics", "Mechanical Engineering",
			"Physics"
		});
		((Control)w0YK()).set_Location(new Point(202, 282));
		((Control)w0YK()).set_Margin(new Padding(2));
		((Control)w0YK()).set_Name("ComboBox1");
		((Control)w0YK()).set_Size(new Size(225, 27));
		((Control)w0YK()).set_TabIndex(18);
		Dy58().set_AutoSize(true);
		((Control)Dy58()).set_Font(new Font("Times New Roman", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Dy58()).set_ForeColor(Color.Red);
		((Control)Dy58()).set_Location(new Point(47, 32));
		((Control)Dy58()).set_Name("Label1");
		((Control)Dy58()).set_Size(new Size(108, 23));
		((Control)Dy58()).set_TabIndex(19);
		Dy58().set_Text("Edit Profile");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)Dy58());
		((Control)this).get_Controls().Add((Control)(object)w0YK());
		((Control)this).get_Controls().Add((Control)(object)f0XN());
		((Control)this).get_Controls().Add((Control)(object)Me3w());
		((Control)this).get_Controls().Add((Control)(object)r5J7());
		((Control)this).get_Controls().Add((Control)(object)val4);
		((Control)this).get_Controls().Add((Control)(object)k1LZ());
		((Control)this).get_Controls().Add((Control)(object)val);
		((Control)this).get_Controls().Add((Control)(object)i7B3());
		((Control)this).get_Controls().Add((Control)(object)val2);
		((Control)this).get_Controls().Add((Control)(object)Qt0n());
		((Control)this).get_Controls().Add((Control)(object)val3);
		((Control)this).set_Name("EditStudentProfile_UserControl");
		((Control)this).set_Size(new Size(1079, 681));
		((ISupportInitialize)Nk16()).EndInit();
		((ISupportInitialize)De10()).EndInit();
		((ISupportInitialize)Me3w()).EndInit();
		((Control)Mp16()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Pt8 Nk16()
	{
		return _DatabaseDataSet;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0LH(Pt8 Kz79)
	{
		_DatabaseDataSet = Kz79;
	}

	[SpecialName]
	internal virtual BindingSource De10()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sc0d(BindingSource s0NG)
	{
		BindingSource val = (j = s0NG);
	}

	[SpecialName]
	internal virtual Ba8 Pj2n()
	{
		return _UserTableAdapter;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0F9(Ba8 Fp6t)
	{
		_UserTableAdapter = Fp6t;
	}

	[SpecialName]
	internal virtual a1X t7Z4()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4WC(a1X i6YM)
	{
		a1X a1X = (V = i6YM);
	}

	[SpecialName]
	internal virtual TextBox i7B3()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s8BQ(TextBox Ci0a)
	{
		TextBox val = (O = Ci0a);
	}

	[SpecialName]
	internal virtual TextBox Qt0n()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8G1(TextBox t5WE)
	{
		TextBox val = (i = t5WE);
	}

	[SpecialName]
	internal virtual TextBox k1LZ()
	{
		return _txtName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zw17(TextBox z1X0)
	{
		EventHandler eventHandler = b4YB;
		TextBox txtName = _txtName;
		if (txtName != null)
		{
			((Control)txtName).remove_TextChanged(eventHandler);
		}
		_txtName = z1X0;
		txtName = _txtName;
		if (txtName != null)
		{
			((Control)txtName).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button r5J7()
	{
		return _btnUpdate;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eo6f(Button g7D8)
	{
		EventHandler eventHandler = r7PS;
		Button btnUpdate = _btnUpdate;
		if (btnUpdate != null)
		{
			((Control)btnUpdate).remove_Click(eventHandler);
		}
		_btnUpdate = g7D8;
		btnUpdate = _btnUpdate;
		if (btnUpdate != null)
		{
			((Control)btnUpdate).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Me3w()
	{
		return _picBoxProfile;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wi7x(PictureBox i9WF)
	{
		_picBoxProfile = i9WF;
	}

	[SpecialName]
	internal virtual Button f0XN()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Na1p(Button Bz26)
	{
		EventHandler eventHandler = Wf5r;
		Button val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (s = Bz26);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual OpenFileDialog q7D5()
	{
		return _OpenFileDialog1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0Z4(OpenFileDialog Nm4p)
	{
		_OpenFileDialog1 = Nm4p;
	}

	[SpecialName]
	internal virtual ContextMenuStrip Mp16()
	{
		return _ContextMenuStrip1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7A8(ContextMenuStrip Tf8p)
	{
		_ContextMenuStrip1 = Tf8p;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem i7A5()
	{
		return _BiosciencesAndBioengineeringToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys95(ToolStripMenuItem Sr0f)
	{
		_BiosciencesAndBioengineeringToolStripMenuItem = Sr0f;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Ni71()
	{
		return _ChemicalEngineeringToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf50(ToolStripMenuItem q2GC)
	{
		_ChemicalEngineeringToolStripMenuItem = q2GC;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem j8N0()
	{
		return _ChemistryToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln02(ToolStripMenuItem Ca62)
	{
		_ChemistryToolStripMenuItem = Ca62;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem e9NP()
	{
		return _CivilEngineeringToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pk53(ToolStripMenuItem Wx48)
	{
		_CivilEngineeringToolStripMenuItem = Wx48;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Jm5x()
	{
		return _ComputerScienceAndEnggToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3T1(ToolStripMenuItem w8R4)
	{
		_ComputerScienceAndEnggToolStripMenuItem = w8R4;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem q4CB()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy2t(ToolStripMenuItem Qo21)
	{
		ToolStripMenuItem val = (t = Qo21);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem q7C4()
	{
		return _MathematicsToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1W6(ToolStripMenuItem Qm8j)
	{
		_MathematicsToolStripMenuItem = Qm8j;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem Ks1w()
	{
		return _MechanicjalEngineeringToolStripMenuItem;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp6f(ToolStripMenuItem Kq62)
	{
		_MechanicjalEngineeringToolStripMenuItem = Kq62;
	}

	[SpecialName]
	internal virtual ToolStripMenuItem e9CD()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz71(ToolStripMenuItem m8E2)
	{
		ToolStripMenuItem val = (a = m8E2);
	}

	[SpecialName]
	internal virtual ComboBox w0YK()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf3q(ComboBox Yw73)
	{
		_ComboBox1 = Yw73;
	}

	[SpecialName]
	internal virtual Label Dy58()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6ZN(Label Cw74)
	{
		_Label1 = Cw74;
	}

	private void r7PS(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = k1LZ().get_Text();
		string text2 = i7B3().get_Text();
		string text3 = Qt0n().get_Text();
		string text4 = Conversions.ToString(w0YK().get_SelectedItem());
		bool flag = true;
		if (Operators.CompareString(text, "", false) == 0)
		{
			MessageBox.Show("Please enter your name", "Invalid name");
			flag = false;
		}
		string text5 = text;
		foreach (char c in text5)
		{
			if (!char.IsLower(c) & !char.IsUpper(c) & (Operators.CompareString(Conversions.ToString(c), " ", false) != 0))
			{
				MessageBox.Show("Your name should contain only lowercase, uppercase or blankspace letters.", "Invalid name");
				flag = false;
				break;
			}
		}
		bool flag2 = true;
		string text6 = text;
		foreach (char c2 in text6)
		{
			if (Operators.CompareString(Conversions.ToString(c2), " ", false) != 0)
			{
				flag2 = false;
				break;
			}
		}
		if (flag2)
		{
			MessageBox.Show("Please enter valid name", "Invalid Name");
			return;
		}
		if (Operators.CompareString(text2, "", false) == 0)
		{
			MessageBox.Show("Please enter an email ID", "Invalid email ID");
			return;
		}
		if (!Regex.IsMatch(text2, "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$"))
		{
			MessageBox.Show("Please enter a valid email ID", "Invalid email ID");
			flag = false;
		}
		string text7 = text3;
		int num = 0;
		checked
		{
			while (true)
			{
				if (num < text7.Length)
				{
					char c3 = text7[num];
					if (!char.IsNumber(c3))
					{
						break;
					}
					num++;
					continue;
				}
				if (text3.Length != 10)
				{
					flag = false;
					MessageBox.Show("Your phone number should have 10 digits only", "Invalid phone number");
				}
				string imageLocation = Me3w().get_ImageLocation();
				int length = imageLocation.Length;
				imageLocation = imageLocation.Substring(length - 4);
				if ((Operators.CompareString(imageLocation, ".jpg", false) != 0) & (Operators.CompareString(imageLocation, ".jpeg", false) != 0) & (Operators.CompareString(imageLocation, ".png", false) != 0) & (Operators.CompareString(imageLocation, ".JPG", false) != 0) & (Operators.CompareString(imageLocation, ".JPEG", false) != 0))
				{
					flag = false;
					MessageBox.Show("Please upload a valid image");
				}
				if (flag)
				{
					string text8 = "UPDATE Users SET ProfileName='" + text + "', Email='" + text2 + "',  PhoneNumber='" + text3 + "', Department='" + text4 + "', ProfileImage='" + m2A.Forms.r0M().UserName + ".JPG' WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
					Me3w().get_Image().Save(Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\") + m2A.Forms.r0M().UserName + ".JPG");
					OleDbCommand val2 = new OleDbCommand(text8, val);
					if (val2.ExecuteNonQuery() > 0)
					{
						((Component)(object)val2).Dispose();
						MessageBox.Show("Profile successfully updated!", "Profile updated");
					}
				}
				val.Close();
				return;
			}
			flag = false;
			MessageBox.Show("You should enter only numerical digits in your phone number", "Invalid phone number");
		}
	}

	internal static byte[] Tn4w(int Lc62, int Wi08)
	{
		if (Lc62 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Wi08 + 1];
			for (int i = 0; i <= Wi08; i++)
			{
				int num = Lc62 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return f8EB(array, Wi08);
		}
	}

	private void Wf5r(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Invalid comparison between Unknown and I4
		OleDbConnection val = new OleDbConnection(m2A.Forms.At0().connectionString);
		val.Open();
		string text = "SELECT * FROM Users WHERE UserName = '" + m2A.Forms.r0M().UserName + "'";
		OleDbCommand val2 = new OleDbCommand(text, val);
		OleDbDataReader val3 = val2.ExecuteReader();
		string imageLocation = "";
		if (val3.Read())
		{
			imageLocation = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), val3.get_Item("ProfileImage")));
			Me3w().set_ImageLocation(imageLocation);
		}
		val.Close();
		if ((int)((CommonDialog)q7D5()).ShowDialog() == 2)
		{
			Me3w().set_ImageLocation(imageLocation);
		}
		else
		{
			Me3w().set_ImageLocation(((FileDialog)q7D5()).get_FileName().ToString());
		}
	}

	private void Hr17(object sender, EventArgs e)
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
			string imageLocation = Conversions.ToString(Operators.ConcatenateObject((object)Path.GetFullPath(Application.get_StartupPath() + "\\..\\..\\Resources\\"), val3.get_Item("ProfileImage")));
			Me3w().set_ImageLocation(imageLocation);
			k1LZ().set_Text(Conversions.ToString(val3.get_Item("ProfileName")));
			i7B3().set_Text(Conversions.ToString(val3.get_Item("Email")));
			Qt0n().set_Text(Conversions.ToString(val3.get_Item("PhoneNumber")));
			w0YK().set_Text(Conversions.ToString(val3.get_Item("Department")));
		}
		val.Close();
	}

	internal static byte[] f8EB(int[] f6NB, int Ns01)
	{
		checked
		{
			byte[] array = new byte[Ns01 + 1];
			int num = f6NB.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)f6NB[i];
			}
			return array;
		}
	}

	private void b4YB(object sender, EventArgs e)
	{
	}

	private void i4K0(object sender, EventArgs e)
	{
	}

	private void m1Y6(object sender, EventArgs e)
	{
	}

	private void Tw0z(object sender, EventArgs e)
	{
	}

	private void Qn3z(object sender, EventArgs e)
	{
	}

	internal static byte[] Bb2g(int Jb4g)
	{
		return Tn4w(Jb4g, checked(Jb4g + 1 - 44));
	}
}
