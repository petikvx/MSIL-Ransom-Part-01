using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page5)]
public class Page5 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Label label4;

	private Label label3;

	private ComboBox cmbYear;

	private TextBox txtZip1;

	private ComboBox cmbPref;

	private TextBox txtAddr1;

	private TextBox txtAddr2;

	private ComboBox cmbMonth;

	private ComboBox cmbDay;

	private TextBox txtZip2;

	private Label label5;

	private RadioButton rbMen;

	private RadioButton rbWomen;

	private Label lbl6;

	private Label lbl5;

	private Label lbl4;

	private Label lbl3;

	private Label lbl2;

	private Label lbl1;

	private Label label14;

	private Label label15;

	private Label label16;

	public Page5()
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
		((Control)label1).set_Text("オンラインユーザ登録");
		((Control)label2).set_Text("ゲームをプレイするには、オンラインユーザ登録が必要です。");
		cmbYear.get_Items().Add((object)"----");
		for (int i = 1900; i <= DateTime.Now.Year; i++)
		{
			cmbYear.get_Items().Add((object)i.ToString());
		}
		cmbMonth.get_Items().Add((object)"----");
		for (int j = 1; j <= 12; j++)
		{
			cmbMonth.get_Items().Add((object)j.ToString());
		}
		cmbDay.get_Items().Add((object)"----");
		for (int k = 1; k <= 31; k++)
		{
			cmbDay.get_Items().Add((object)k.ToString());
		}
		cmbPref.get_Items().Add((object)"▼選択してください");
		cmbPref.get_Items().Add((object)"東京都");
		cmbPref.get_Items().Add((object)"北海道");
		cmbPref.get_Items().Add((object)"青森県");
		cmbPref.get_Items().Add((object)"岩手県");
		cmbPref.get_Items().Add((object)"宮城県");
		cmbPref.get_Items().Add((object)"秋田県");
		cmbPref.get_Items().Add((object)"山形県");
		cmbPref.get_Items().Add((object)"福島県");
		cmbPref.get_Items().Add((object)"神奈川県");
		cmbPref.get_Items().Add((object)"埼玉県");
		cmbPref.get_Items().Add((object)"千葉県");
		cmbPref.get_Items().Add((object)"茨城県");
		cmbPref.get_Items().Add((object)"栃木県");
		cmbPref.get_Items().Add((object)"群馬県");
		cmbPref.get_Items().Add((object)"山梨県");
		cmbPref.get_Items().Add((object)"新潟県");
		cmbPref.get_Items().Add((object)"長野県");
		cmbPref.get_Items().Add((object)"富山県");
		cmbPref.get_Items().Add((object)"石川県");
		cmbPref.get_Items().Add((object)"福井県");
		cmbPref.get_Items().Add((object)"愛知県");
		cmbPref.get_Items().Add((object)"岐阜県");
		cmbPref.get_Items().Add((object)"静岡県");
		cmbPref.get_Items().Add((object)"三重県");
		cmbPref.get_Items().Add((object)"大阪府");
		cmbPref.get_Items().Add((object)"兵庫県");
		cmbPref.get_Items().Add((object)"京都府");
		cmbPref.get_Items().Add((object)"滋賀県");
		cmbPref.get_Items().Add((object)"奈良県");
		cmbPref.get_Items().Add((object)"和歌山県");
		cmbPref.get_Items().Add((object)"鳥取県");
		cmbPref.get_Items().Add((object)"島根県");
		cmbPref.get_Items().Add((object)"岡山県");
		cmbPref.get_Items().Add((object)"広島県");
		cmbPref.get_Items().Add((object)"山口県");
		cmbPref.get_Items().Add((object)"徳島県");
		cmbPref.get_Items().Add((object)"香川県");
		cmbPref.get_Items().Add((object)"愛媛県");
		cmbPref.get_Items().Add((object)"高知県");
		cmbPref.get_Items().Add((object)"福岡県");
		cmbPref.get_Items().Add((object)"佐賀県");
		cmbPref.get_Items().Add((object)"長崎県");
		cmbPref.get_Items().Add((object)"熊本県");
		cmbPref.get_Items().Add((object)"大分県");
		cmbPref.get_Items().Add((object)"宮崎県");
		cmbPref.get_Items().Add((object)"鹿児島県");
		cmbPref.get_Items().Add((object)"沖縄県 ");
		ComboBox obj4 = cmbYear;
		ComboBox obj5 = cmbMonth;
		ComboBox obj6 = cmbDay;
		cmbPref.set_DropDownStyle((ComboBoxStyle)2);
		obj6.set_DropDownStyle((ComboBoxStyle)2);
		obj5.set_DropDownStyle((ComboBoxStyle)2);
		obj4.set_DropDownStyle((ComboBoxStyle)2);
		if (Settings.Default.sex == "男性")
		{
			rbMen.set_Checked(true);
		}
		if (Settings.Default.sex == "女性")
		{
			rbMen.set_Checked(true);
		}
		((Control)txtAddr1).set_Text(Settings.Default.addr1);
		((Control)txtAddr2).set_Text(Settings.Default.addr2);
		((Control)txtZip1).set_Text(Settings.Default.zip1);
		((Control)txtZip2).set_Text(Settings.Default.zip2);
		((ListControl)cmbYear).set_SelectedIndex(Settings.Default.b_year);
		((ListControl)cmbMonth).set_SelectedIndex(Settings.Default.b_month);
		((ListControl)cmbDay).set_SelectedIndex(Settings.Default.b_day);
		((ListControl)cmbPref).set_SelectedIndex(Settings.Default.i_pref);
		chk();
	}

	private void InputChk(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		bool flag = true;
		if (((Control)txtZip1).get_Text() == "")
		{
			flag = false;
		}
		if (!lib.NumChk(((Control)txtZip1).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtZip1).get_Text().Length < 3)
		{
			flag = false;
		}
		if (((Control)txtZip2).get_Text() == "")
		{
			flag = false;
		}
		if (!lib.NumChk(((Control)txtZip2).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtZip2).get_Text().Length < 4)
		{
			flag = false;
		}
		if (((ListControl)cmbPref).get_SelectedIndex() == 0)
		{
			flag = false;
		}
		if (((Control)txtAddr1).get_Text() == "")
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
		if (rbMen.get_Checked())
		{
			Settings.Default.sex = ((Control)rbMen).get_Text();
		}
		if (rbWomen.get_Checked())
		{
			Settings.Default.sex = ((Control)rbWomen).get_Text();
		}
		if (((ListControl)cmbYear).get_SelectedIndex() != 0 && ((ListControl)cmbMonth).get_SelectedIndex() != 0 && ((ListControl)cmbDay).get_SelectedIndex() != 0)
		{
			Settings.Default.birth = ((Control)cmbYear).get_Text() + "/" + zero(((Control)cmbMonth).get_Text()) + "/" + zero(((Control)cmbDay).get_Text());
			Settings.Default.age = AgeUtil.GetAge(((Control)cmbYear).get_Text() + zero(((Control)cmbMonth).get_Text()) + zero(((Control)cmbDay).get_Text())).ToString();
		}
		Settings.Default.zip = ((Control)txtZip1).get_Text() + "-" + ((Control)txtZip2).get_Text();
		if (((ListControl)cmbPref).get_SelectedIndex() != 0)
		{
			Settings.Default.pref = ((Control)cmbPref).get_Text();
			Settings.Default.i_pref = ((ListControl)cmbPref).get_SelectedIndex();
		}
		if (((Control)txtAddr1).get_Text() != "")
		{
			Settings.Default.addr1 = ((Control)txtAddr1).get_Text();
		}
		Settings.Default.addr2 = ((Control)txtAddr2).get_Text();
		Settings.Default.b_year = ((ListControl)cmbYear).get_SelectedIndex();
		Settings.Default.b_month = ((ListControl)cmbMonth).get_SelectedIndex();
		Settings.Default.b_day = ((ListControl)cmbDay).get_SelectedIndex();
		if (((Control)txtZip1).get_Text() != "")
		{
			Settings.Default.zip1 = ((Control)txtZip1).get_Text();
		}
		if (((Control)txtZip2).get_Text() != "")
		{
			Settings.Default.zip2 = ((Control)txtZip2).get_Text();
		}
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private string zero(string str)
	{
		string result = str;
		if (int.Parse(str) < 10)
		{
			result = "0" + str;
		}
		return result;
	}

	private void txtZip1_Leave(object sender, EventArgs e)
	{
		chkZip();
	}

	private void txtZip2_Leave(object sender, EventArgs e)
	{
		chkZip();
	}

	private void chkZip()
	{
		((Control)lbl3).set_ForeColor(Color.Black);
		if (((Control)txtZip1).get_Text() == "" || !lib.NumChk(((Control)txtZip1).get_Text()) || ((Control)txtZip1).get_Text().Length < 3 || ((Control)txtZip2).get_Text() == "" || !lib.NumChk(((Control)txtZip2).get_Text()) || ((Control)txtZip2).get_Text().Length < 4)
		{
			((Control)lbl3).set_ForeColor(Color.Red);
		}
	}

	private void cmbPref_Leave(object sender, EventArgs e)
	{
		((Control)lbl4).set_ForeColor(Color.Black);
		if (((ListControl)cmbPref).get_SelectedIndex() == 0)
		{
			((Control)lbl4).set_ForeColor(Color.Red);
		}
	}

	private void txtAddr1_Leave(object sender, EventArgs e)
	{
		((Control)lbl5).set_ForeColor(Color.Black);
		if (((Control)txtAddr1).get_Text() == "")
		{
			((Control)lbl5).set_ForeColor(Color.Red);
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
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		picHeader = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		label4 = new Label();
		label3 = new Label();
		cmbYear = new ComboBox();
		txtZip1 = new TextBox();
		cmbPref = new ComboBox();
		txtAddr1 = new TextBox();
		txtAddr2 = new TextBox();
		cmbMonth = new ComboBox();
		cmbDay = new ComboBox();
		txtZip2 = new TextBox();
		label5 = new Label();
		rbMen = new RadioButton();
		rbWomen = new RadioButton();
		lbl6 = new Label();
		lbl5 = new Label();
		lbl4 = new Label();
		lbl3 = new Label();
		lbl2 = new Label();
		lbl1 = new Label();
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
		((Control)label2).set_TabIndex(10);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(9);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(47, 85));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(113, 12));
		((Control)label4).set_TabIndex(14);
		((Control)label4).set_Text("アスタリスクは必須項目");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(30, 85));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(11, 12));
		((Control)label3).set_TabIndex(13);
		((Control)label3).set_Text("*");
		((ListControl)cmbYear).set_FormattingEnabled(true);
		((Control)cmbYear).set_Location(new Point(135, 129));
		((Control)cmbYear).set_Name("cmbYear");
		((Control)cmbYear).set_Size(new Size(50, 20));
		((Control)cmbYear).set_TabIndex(2);
		cmbYear.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)txtZip1).set_ImeMode((ImeMode)2);
		((Control)txtZip1).set_Location(new Point(135, 151));
		((TextBoxBase)txtZip1).set_MaxLength(3);
		((Control)txtZip1).set_Name("txtZip1");
		((Control)txtZip1).set_Size(new Size(25, 19));
		((Control)txtZip1).set_TabIndex(5);
		((Control)txtZip1).add_TextChanged((EventHandler)InputChk);
		((Control)txtZip1).add_Leave((EventHandler)txtZip1_Leave);
		((ListControl)cmbPref).set_FormattingEnabled(true);
		((Control)cmbPref).set_Location(new Point(135, 173));
		((Control)cmbPref).set_Name("cmbPref");
		((Control)cmbPref).set_Size(new Size(350, 20));
		((Control)cmbPref).set_TabIndex(7);
		cmbPref.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)cmbPref).add_Leave((EventHandler)cmbPref_Leave);
		((Control)txtAddr1).set_ImeMode((ImeMode)1);
		((Control)txtAddr1).set_Location(new Point(135, 194));
		((TextBoxBase)txtAddr1).set_MaxLength(100);
		((Control)txtAddr1).set_Name("txtAddr1");
		((Control)txtAddr1).set_Size(new Size(350, 19));
		((Control)txtAddr1).set_TabIndex(8);
		((Control)txtAddr1).add_TextChanged((EventHandler)InputChk);
		((Control)txtAddr1).add_Leave((EventHandler)txtAddr1_Leave);
		((Control)txtAddr2).set_ImeMode((ImeMode)1);
		((Control)txtAddr2).set_Location(new Point(135, 217));
		((TextBoxBase)txtAddr2).set_MaxLength(100);
		((Control)txtAddr2).set_Name("txtAddr2");
		((Control)txtAddr2).set_Size(new Size(350, 19));
		((Control)txtAddr2).set_TabIndex(9);
		((Control)txtAddr2).add_TextChanged((EventHandler)InputChk);
		((ListControl)cmbMonth).set_FormattingEnabled(true);
		((Control)cmbMonth).set_Location(new Point(191, 129));
		((Control)cmbMonth).set_Name("cmbMonth");
		((Control)cmbMonth).set_Size(new Size(50, 20));
		((Control)cmbMonth).set_TabIndex(3);
		cmbMonth.add_SelectedIndexChanged((EventHandler)InputChk);
		((ListControl)cmbDay).set_FormattingEnabled(true);
		((Control)cmbDay).set_Location(new Point(247, 129));
		((Control)cmbDay).set_Name("cmbDay");
		((Control)cmbDay).set_Size(new Size(50, 20));
		((Control)cmbDay).set_TabIndex(4);
		cmbDay.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)txtZip2).set_ImeMode((ImeMode)2);
		((Control)txtZip2).set_Location(new Point(183, 151));
		((TextBoxBase)txtZip2).set_MaxLength(4);
		((Control)txtZip2).set_Name("txtZip2");
		((Control)txtZip2).set_Size(new Size(30, 19));
		((Control)txtZip2).set_TabIndex(6);
		((Control)txtZip2).add_TextChanged((EventHandler)InputChk);
		((Control)txtZip2).add_Leave((EventHandler)txtZip2_Leave);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Location(new Point(166, 154));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(11, 12));
		((Control)label5).set_TabIndex(24);
		((Control)label5).set_Text("-");
		label5.set_TextAlign((ContentAlignment)32);
		((Control)rbMen).set_AutoSize(true);
		((Control)rbMen).set_Location(new Point(135, 107));
		((Control)rbMen).set_Name("rbMen");
		((Control)rbMen).set_Size(new Size(47, 16));
		((Control)rbMen).set_TabIndex(0);
		((Control)rbMen).set_Text("男性");
		((ButtonBase)rbMen).set_UseVisualStyleBackColor(true);
		rbMen.add_CheckedChanged((EventHandler)InputChk);
		((Control)rbWomen).set_AutoSize(true);
		((Control)rbWomen).set_Location(new Point(191, 107));
		((Control)rbWomen).set_Name("rbWomen");
		((Control)rbWomen).set_Size(new Size(47, 16));
		((Control)rbWomen).set_TabIndex(1);
		((Control)rbWomen).set_Text("女性");
		((ButtonBase)rbWomen).set_UseVisualStyleBackColor(true);
		rbWomen.add_CheckedChanged((EventHandler)InputChk);
		((Control)lbl6).set_AutoSize(true);
		((Control)lbl6).set_Location(new Point(88, 220));
		((Control)lbl6).set_Name("lbl6");
		((Control)lbl6).set_Size(new Size(45, 12));
		((Control)lbl6).set_TabIndex(32);
		((Control)lbl6).set_Text("住所2 : ");
		((Control)lbl5).set_AutoSize(true);
		((Control)lbl5).set_Location(new Point(88, 198));
		((Control)lbl5).set_Name("lbl5");
		((Control)lbl5).set_Size(new Size(45, 12));
		((Control)lbl5).set_TabIndex(31);
		((Control)lbl5).set_Text("住所1 : ");
		((Control)lbl4).set_AutoSize(true);
		((Control)lbl4).set_Location(new Point(70, 176));
		((Control)lbl4).set_Name("lbl4");
		((Control)lbl4).set_Size(new Size(63, 12));
		((Control)lbl4).set_TabIndex(30);
		((Control)lbl4).set_Text("都道府県 : ");
		((Control)lbl3).set_AutoSize(true);
		((Control)lbl3).set_Location(new Point(70, 154));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Size(new Size(63, 12));
		((Control)lbl3).set_TabIndex(29);
		((Control)lbl3).set_Text("郵便番号 : ");
		((Control)lbl2).set_AutoSize(true);
		((Control)lbl2).set_Location(new Point(70, 132));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Size(new Size(63, 12));
		((Control)lbl2).set_TabIndex(28);
		((Control)lbl2).set_Text("生年月日 : ");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Location(new Point(94, 110));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(39, 12));
		((Control)lbl1).set_TabIndex(27);
		((Control)lbl1).set_Text("性別 : ");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_ForeColor(Color.Red);
		((Control)label14).set_Location(new Point(53, 154));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(11, 12));
		((Control)label14).set_TabIndex(35);
		((Control)label14).set_Text("*");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_ForeColor(Color.Red);
		((Control)label15).set_Location(new Point(53, 176));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(11, 12));
		((Control)label15).set_TabIndex(36);
		((Control)label15).set_Text("*");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_ForeColor(Color.Red);
		((Control)label16).set_Location(new Point(71, 198));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(11, 12));
		((Control)label16).set_TabIndex(37);
		((Control)label16).set_Text("*");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).get_Controls().Add((Control)(object)label15);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)lbl6);
		((Control)this).get_Controls().Add((Control)(object)lbl5);
		((Control)this).get_Controls().Add((Control)(object)lbl4);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)rbWomen);
		((Control)this).get_Controls().Add((Control)(object)rbMen);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)txtZip2);
		((Control)this).get_Controls().Add((Control)(object)cmbDay);
		((Control)this).get_Controls().Add((Control)(object)cmbMonth);
		((Control)this).get_Controls().Add((Control)(object)txtAddr2);
		((Control)this).get_Controls().Add((Control)(object)txtAddr1);
		((Control)this).get_Controls().Add((Control)(object)cmbPref);
		((Control)this).get_Controls().Add((Control)(object)txtZip1);
		((Control)this).get_Controls().Add((Control)(object)cmbYear);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page5");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
