using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page10)]
public class Page10 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Label label4;

	private Label label3;

	private ComboBox cmbFamily;

	private ComboBox cmbHouse;

	private ComboBox cmbJob;

	private TextBox txtCompanypost;

	private TextBox txtCompany;

	private TextBox txtLoan;

	private TextBox txtSalary;

	private Label lbl3;

	private Label lbl2;

	private Label lbl1;

	private Label lbl6;

	private Label lbl5;

	private Label lbl4;

	private Label lbl7;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label label15;

	private Label label16;

	public Page10()
	{
		InitializeComponent();
	}

	public override void OnViewOpen(ViewForwardEventArgs args)
	{
		picHeader.set_Image(Image.FromFile(Settings.Default.ih_dir));
		Label obj = label1;
		Color transparent;
		((Control)label2).set_BackColor(transparent = Color.Transparent);
		((Control)obj).set_BackColor(transparent);
		Label obj2 = label1;
		Control parent;
		((Control)label2).set_Parent(parent = (Control)(object)picHeader);
		((Control)obj2).set_Parent(parent);
		Label obj3 = label1;
		Color foreColor;
		((Control)label2).set_ForeColor(foreColor = ColorTranslator.FromHtml(Settings.Default.f2));
		((Control)obj3).set_ForeColor(foreColor);
		((Control)label1).set_Text("アンケート");
		((Control)label2).set_Text("アンケートにご協力ください。");
		cmbFamily.get_Items().Add((object)"▼選択してください");
		cmbFamily.get_Items().Add((object)"配偶者あり(子供あり)");
		cmbFamily.get_Items().Add((object)"配偶者あり(子供なし)");
		cmbFamily.get_Items().Add((object)"独身(家族同居)");
		cmbFamily.get_Items().Add((object)"独身(家族別居)");
		cmbFamily.get_Items().Add((object)"配偶者なし(子供あり)");
		cmbHouse.get_Items().Add((object)"▼選択してください");
		cmbHouse.get_Items().Add((object)"持家(自己所有)");
		cmbHouse.get_Items().Add((object)"持家(家族所有)");
		cmbHouse.get_Items().Add((object)"社宅・官舎");
		cmbHouse.get_Items().Add((object)"寮");
		cmbHouse.get_Items().Add((object)"借家");
		cmbHouse.get_Items().Add((object)"賃貸マンション");
		cmbHouse.get_Items().Add((object)"賃貸(公営住宅)");
		cmbHouse.get_Items().Add((object)"賃貸(公団)");
		cmbHouse.get_Items().Add((object)"アパート");
		cmbHouse.get_Items().Add((object)"下宿・間借");
		cmbHouse.get_Items().Add((object)"その他");
		cmbJob.get_Items().Add((object)"▼選択してください");
		cmbJob.get_Items().Add((object)"会社員");
		cmbJob.get_Items().Add((object)"会社役員");
		cmbJob.get_Items().Add((object)"派遣社員・契約社員");
		cmbJob.get_Items().Add((object)"公務員（教職員を除く）");
		cmbJob.get_Items().Add((object)"教師・教職員");
		cmbJob.get_Items().Add((object)"自営業");
		cmbJob.get_Items().Add((object)"専門職（医師、弁護士、会計士など）");
		cmbJob.get_Items().Add((object)"営業/マーケティング");
		cmbJob.get_Items().Add((object)"大学生・大学院生・専門学校生");
		cmbJob.get_Items().Add((object)"高校生");
		cmbJob.get_Items().Add((object)"中学生");
		cmbJob.get_Items().Add((object)"小学生");
		cmbJob.get_Items().Add((object)"専業主婦・主夫");
		cmbJob.get_Items().Add((object)"パート・アルバイト");
		cmbJob.get_Items().Add((object)"無職");
		cmbJob.get_Items().Add((object)"定年退職者");
		cmbJob.get_Items().Add((object)"その他");
		ComboBox obj4 = cmbFamily;
		ComboBox obj5 = cmbHouse;
		cmbJob.set_DropDownStyle((ComboBoxStyle)2);
		obj5.set_DropDownStyle((ComboBoxStyle)2);
		obj4.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cmbFamily).set_SelectedIndex(Settings.Default.i_family);
		((ListControl)cmbHouse).set_SelectedIndex(Settings.Default.i_house);
		((ListControl)cmbJob).set_SelectedIndex(Settings.Default.i_job);
		((Control)txtCompany).set_Text(Settings.Default.company);
		((Control)txtCompanypost).set_Text(Settings.Default.companypost);
		((Control)txtSalary).set_Text(Settings.Default.salary);
		((Control)txtLoan).set_Text(Settings.Default.loan);
		chk();
	}

	private void InputChk(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		bool flag = true;
		if (((ListControl)cmbFamily).get_SelectedIndex() == 0)
		{
			flag = false;
		}
		if (((ListControl)cmbHouse).get_SelectedIndex() == 0)
		{
			flag = false;
		}
		if (((ListControl)cmbJob).get_SelectedIndex() == 0)
		{
			flag = false;
		}
		if (((Control)txtSalary).get_Text() != "" && !lib.NumChk(((Control)txtSalary).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtLoan).get_Text() != "" && !lib.NumChk(((Control)txtLoan).get_Text()))
		{
			flag = false;
		}
		base.FunctionCotrol.UpdateFunctionKeys(new FunctionKey[2]
		{
			new FunctionKey((Keys)66, "戻る"),
			new FunctionKey((Keys)67, "キャンセル")
		});
		if (flag)
		{
			base.FunctionCotrol.UpdateFunctionKeys(new FunctionKey[3]
			{
				new FunctionKey((Keys)66, "戻る"),
				new FunctionKey((Keys)78, "次へ"),
				new FunctionKey((Keys)67, "キャンセル")
			});
		}
	}

	public override void OnViewClose()
	{
		Settings.Default.i_family = ((ListControl)cmbFamily).get_SelectedIndex();
		Settings.Default.i_house = ((ListControl)cmbHouse).get_SelectedIndex();
		Settings.Default.i_job = ((ListControl)cmbJob).get_SelectedIndex();
		if (((ListControl)cmbFamily).get_SelectedIndex() != 0)
		{
			Settings.Default.family = ((Control)cmbFamily).get_Text();
		}
		if (((ListControl)cmbHouse).get_SelectedIndex() != 0)
		{
			Settings.Default.house = ((Control)cmbHouse).get_Text();
		}
		if (((ListControl)cmbJob).get_SelectedIndex() != 0)
		{
			Settings.Default.job = ((Control)cmbJob).get_Text();
		}
		Settings.Default.company = ((Control)txtCompany).get_Text();
		Settings.Default.companypost = ((Control)txtCompanypost).get_Text();
		if (((Control)txtSalary).get_Text() != "" && lib.NumChk(((Control)txtSalary).get_Text()))
		{
			Settings.Default.salary = ((Control)txtSalary).get_Text();
		}
		if (((Control)txtLoan).get_Text() != "" && lib.NumChk(((Control)txtLoan).get_Text()))
		{
			Settings.Default.loan = ((Control)txtLoan).get_Text();
		}
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void cmbFamily_Leave(object sender, EventArgs e)
	{
		((Control)lbl1).set_ForeColor(Color.Black);
		if (((ListControl)cmbFamily).get_SelectedIndex() == 0)
		{
			((Control)lbl1).set_ForeColor(Color.Red);
		}
	}

	private void cmbHouse_Leave(object sender, EventArgs e)
	{
		((Control)lbl2).set_ForeColor(Color.Black);
		if (((ListControl)cmbHouse).get_SelectedIndex() == 0)
		{
			((Control)lbl2).set_ForeColor(Color.Red);
		}
	}

	private void cmbJob_Leave(object sender, EventArgs e)
	{
		((Control)lbl3).set_ForeColor(Color.Black);
		if (((ListControl)cmbJob).get_SelectedIndex() == 0)
		{
			((Control)lbl3).set_ForeColor(Color.Red);
		}
	}

	private void txtSalary_Leave(object sender, EventArgs e)
	{
		((Control)lbl6).set_ForeColor(Color.Black);
		if (((Control)txtSalary).get_Text() != "" && !lib.NumChk(((Control)txtSalary).get_Text()))
		{
			((Control)lbl6).set_ForeColor(Color.Red);
		}
	}

	private void txtLoan_Leave(object sender, EventArgs e)
	{
		((Control)lbl7).set_ForeColor(Color.Black);
		if (((Control)txtLoan).get_Text() != "" && !lib.NumChk(((Control)txtLoan).get_Text()))
		{
			((Control)lbl7).set_ForeColor(Color.Red);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
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
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		picHeader = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		label4 = new Label();
		label3 = new Label();
		cmbFamily = new ComboBox();
		cmbHouse = new ComboBox();
		cmbJob = new ComboBox();
		txtCompanypost = new TextBox();
		txtCompany = new TextBox();
		txtLoan = new TextBox();
		txtSalary = new TextBox();
		lbl3 = new Label();
		lbl2 = new Label();
		lbl1 = new Label();
		lbl6 = new Label();
		lbl5 = new Label();
		lbl4 = new Label();
		lbl7 = new Label();
		label12 = new Label();
		label13 = new Label();
		label14 = new Label();
		label15 = new Label();
		label16 = new Label();
		((ISupportInitialize)picHeader).BeginInit();
		((Control)this).SuspendLayout();
		((Control)picHeader).set_Dock((DockStyle)1);
		((Control)picHeader).set_Location(new Point(0, 0));
		((Control)picHeader).set_Name("picHeader");
		((Control)picHeader).set_Size(new Size(500, 70));
		picHeader.set_TabIndex(1);
		picHeader.set_TabStop(false);
		((Control)label2).set_Location(new Point(30, 33));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(300, 27));
		((Control)label2).set_TabIndex(16);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(15);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(47, 85));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(113, 12));
		((Control)label4).set_TabIndex(18);
		((Control)label4).set_Text("アスタリスクは必須項目");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(30, 85));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(11, 12));
		((Control)label3).set_TabIndex(17);
		((Control)label3).set_Text("*");
		((ListControl)cmbFamily).set_FormattingEnabled(true);
		((Control)cmbFamily).set_Location(new Point(135, 107));
		((Control)cmbFamily).set_Name("cmbFamily");
		((Control)cmbFamily).set_Size(new Size(350, 20));
		((Control)cmbFamily).set_TabIndex(0);
		cmbFamily.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)cmbFamily).add_Leave((EventHandler)cmbFamily_Leave);
		((ListControl)cmbHouse).set_FormattingEnabled(true);
		((Control)cmbHouse).set_Location(new Point(135, 129));
		((Control)cmbHouse).set_Name("cmbHouse");
		((Control)cmbHouse).set_Size(new Size(350, 20));
		((Control)cmbHouse).set_TabIndex(1);
		cmbHouse.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)cmbHouse).add_Leave((EventHandler)cmbHouse_Leave);
		((ListControl)cmbJob).set_FormattingEnabled(true);
		((Control)cmbJob).set_Location(new Point(135, 151));
		((Control)cmbJob).set_Name("cmbJob");
		((Control)cmbJob).set_Size(new Size(350, 20));
		((Control)cmbJob).set_TabIndex(2);
		cmbJob.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)cmbJob).add_Leave((EventHandler)cmbJob_Leave);
		((Control)txtCompanypost).set_ImeMode((ImeMode)1);
		((Control)txtCompanypost).set_Location(new Point(135, 194));
		((TextBoxBase)txtCompanypost).set_MaxLength(100);
		((Control)txtCompanypost).set_Name("txtCompanypost");
		((Control)txtCompanypost).set_Size(new Size(350, 19));
		((Control)txtCompanypost).set_TabIndex(4);
		((Control)txtCompanypost).add_TextChanged((EventHandler)InputChk);
		((Control)txtCompany).set_ImeMode((ImeMode)1);
		((Control)txtCompany).set_Location(new Point(135, 173));
		((TextBoxBase)txtCompany).set_MaxLength(100);
		((Control)txtCompany).set_Name("txtCompany");
		((Control)txtCompany).set_Size(new Size(350, 19));
		((Control)txtCompany).set_TabIndex(3);
		((Control)txtCompany).add_TextChanged((EventHandler)InputChk);
		((Control)txtLoan).set_ImeMode((ImeMode)2);
		((Control)txtLoan).set_Location(new Point(135, 236));
		((TextBoxBase)txtLoan).set_MaxLength(10);
		((Control)txtLoan).set_Name("txtLoan");
		((Control)txtLoan).set_Size(new Size(100, 19));
		((Control)txtLoan).set_TabIndex(6);
		txtLoan.set_TextAlign((HorizontalAlignment)1);
		((Control)txtLoan).add_TextChanged((EventHandler)InputChk);
		((Control)txtLoan).add_Leave((EventHandler)txtLoan_Leave);
		((Control)txtSalary).set_ImeMode((ImeMode)2);
		((Control)txtSalary).set_Location(new Point(135, 215));
		((TextBoxBase)txtSalary).set_MaxLength(10);
		((Control)txtSalary).set_Name("txtSalary");
		((Control)txtSalary).set_Size(new Size(100, 19));
		((Control)txtSalary).set_TabIndex(5);
		txtSalary.set_TextAlign((HorizontalAlignment)1);
		((Control)txtSalary).add_TextChanged((EventHandler)InputChk);
		((Control)txtSalary).add_Leave((EventHandler)txtSalary_Leave);
		((Control)lbl3).set_AutoSize(true);
		((Control)lbl3).set_Location(new Point(94, 154));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Size(new Size(39, 12));
		((Control)lbl3).set_TabIndex(50);
		((Control)lbl3).set_Text("職種 : ");
		((Control)lbl2).set_AutoSize(true);
		((Control)lbl2).set_Location(new Point(77, 132));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Size(new Size(56, 12));
		((Control)lbl2).set_TabIndex(49);
		((Control)lbl2).set_Text("お住まい : ");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Location(new Point(85, 110));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(48, 12));
		((Control)lbl1).set_TabIndex(48);
		((Control)lbl1).set_Text("ご家族 : ");
		((Control)lbl6).set_AutoSize(true);
		((Control)lbl6).set_Location(new Point(82, 218));
		((Control)lbl6).set_Name("lbl6");
		((Control)lbl6).set_Size(new Size(51, 12));
		((Control)lbl6).set_TabIndex(53);
		((Control)lbl6).set_Text("年収額 : ");
		((Control)lbl5).set_AutoSize(true);
		((Control)lbl5).set_Location(new Point(64, 198));
		((Control)lbl5).set_Name("lbl5");
		((Control)lbl5).set_Size(new Size(69, 12));
		((Control)lbl5).set_TabIndex(52);
		((Control)lbl5).set_Text("部署・役職 : ");
		((Control)lbl4).set_AutoSize(true);
		((Control)lbl4).set_Location(new Point(70, 176));
		((Control)lbl4).set_Name("lbl4");
		((Control)lbl4).set_Size(new Size(63, 12));
		((Control)lbl4).set_TabIndex(51);
		((Control)lbl4).set_Text("勤務先名 : ");
		((Control)lbl7).set_AutoSize(true);
		((Control)lbl7).set_Location(new Point(82, 239));
		((Control)lbl7).set_Name("lbl7");
		((Control)lbl7).set_Size(new Size(51, 12));
		((Control)lbl7).set_TabIndex(54);
		((Control)lbl7).set_Text("借入額 : ");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(68, 110));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(11, 12));
		((Control)label12).set_TabIndex(55);
		((Control)label12).set_Text("*");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_ForeColor(Color.Red);
		((Control)label13).set_Location(new Point(60, 132));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(11, 12));
		((Control)label13).set_TabIndex(56);
		((Control)label13).set_Text("*");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_ForeColor(Color.Red);
		((Control)label14).set_Location(new Point(77, 154));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(11, 12));
		((Control)label14).set_TabIndex(57);
		((Control)label14).set_Text("*");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_Location(new Point(241, 218));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(29, 12));
		((Control)label15).set_TabIndex(58);
		((Control)label15).set_Text("万円");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_Location(new Point(241, 239));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(29, 12));
		((Control)label16).set_TabIndex(59);
		((Control)label16).set_Text("万円");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).get_Controls().Add((Control)(object)label15);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)lbl7);
		((Control)this).get_Controls().Add((Control)(object)lbl6);
		((Control)this).get_Controls().Add((Control)(object)lbl5);
		((Control)this).get_Controls().Add((Control)(object)lbl4);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)txtLoan);
		((Control)this).get_Controls().Add((Control)(object)txtSalary);
		((Control)this).get_Controls().Add((Control)(object)txtCompanypost);
		((Control)this).get_Controls().Add((Control)(object)txtCompany);
		((Control)this).get_Controls().Add((Control)(object)cmbJob);
		((Control)this).get_Controls().Add((Control)(object)cmbHouse);
		((Control)this).get_Controls().Add((Control)(object)cmbFamily);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page10");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
