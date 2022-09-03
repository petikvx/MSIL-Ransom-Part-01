using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page4)]
public class Page4 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Label label3;

	private Label label4;

	private Label lbl1;

	private Label lbl2;

	private Label lbl3;

	private Label lbl4;

	private Label lbl5;

	private Label lbl6;

	private TextBox txtSei;

	private TextBox txtMei;

	private TextBox txtEmail;

	private TextBox txtPass;

	private TextBox txtAnswer;

	private ComboBox cmbQuestion;

	private Label label11;

	private Label label12;

	private Label label13;

	private Label label14;

	private Label label15;

	private Label label16;

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
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		picHeader = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		label3 = new Label();
		label4 = new Label();
		lbl1 = new Label();
		lbl2 = new Label();
		lbl3 = new Label();
		lbl4 = new Label();
		lbl5 = new Label();
		lbl6 = new Label();
		txtSei = new TextBox();
		txtMei = new TextBox();
		txtEmail = new TextBox();
		txtPass = new TextBox();
		txtAnswer = new TextBox();
		cmbQuestion = new ComboBox();
		label11 = new Label();
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
		((Control)label2).set_TabIndex(10);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(9);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(30, 85));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(11, 12));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("*");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(47, 85));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(113, 12));
		((Control)label4).set_TabIndex(12);
		((Control)label4).set_Text("アスタリスクは必須項目");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Location(new Point(106, 110));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(27, 12));
		((Control)lbl1).set_TabIndex(13);
		((Control)lbl1).set_Text("姓 : ");
		((Control)lbl2).set_AutoSize(true);
		((Control)lbl2).set_Location(new Point(106, 132));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Size(new Size(27, 12));
		((Control)lbl2).set_TabIndex(14);
		((Control)lbl2).set_Text("名 : ");
		((Control)lbl3).set_AutoSize(true);
		((Control)lbl3).set_Location(new Point(66, 154));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Size(new Size(67, 12));
		((Control)lbl3).set_TabIndex(15);
		((Control)lbl3).set_Text("電子メール : ");
		((Control)lbl4).set_AutoSize(true);
		((Control)lbl4).set_Location(new Point(71, 176));
		((Control)lbl4).set_Name("lbl4");
		((Control)lbl4).set_Size(new Size(62, 12));
		((Control)lbl4).set_TabIndex(16);
		((Control)lbl4).set_Text("パスワード : ");
		((Control)lbl5).set_AutoSize(true);
		((Control)lbl5).set_Location(new Point(60, 198));
		((Control)lbl5).set_Name("lbl5");
		((Control)lbl5).set_Size(new Size(73, 12));
		((Control)lbl5).set_TabIndex(17);
		((Control)lbl5).set_Text("秘密の質問 : ");
		((Control)lbl6).set_AutoSize(true);
		((Control)lbl6).set_Location(new Point(29, 220));
		((Control)lbl6).set_Name("lbl6");
		((Control)lbl6).set_Size(new Size(104, 12));
		((Control)lbl6).set_TabIndex(18);
		((Control)lbl6).set_Text("秘密の質問の答え : ");
		((Control)txtSei).set_ImeMode((ImeMode)1);
		((Control)txtSei).set_Location(new Point(135, 107));
		((TextBoxBase)txtSei).set_MaxLength(50);
		((Control)txtSei).set_Name("txtSei");
		((Control)txtSei).set_Size(new Size(350, 19));
		((Control)txtSei).set_TabIndex(0);
		((Control)txtSei).add_TextChanged((EventHandler)InputChk);
		((Control)txtSei).add_Leave((EventHandler)txtSei_Leave);
		((Control)txtMei).set_ImeMode((ImeMode)1);
		((Control)txtMei).set_Location(new Point(135, 129));
		((TextBoxBase)txtMei).set_MaxLength(50);
		((Control)txtMei).set_Name("txtMei");
		((Control)txtMei).set_Size(new Size(350, 19));
		((Control)txtMei).set_TabIndex(1);
		((Control)txtMei).add_TextChanged((EventHandler)InputChk);
		((Control)txtMei).add_Leave((EventHandler)txtMei_Leave);
		((Control)txtEmail).set_ImeMode((ImeMode)2);
		((Control)txtEmail).set_Location(new Point(135, 151));
		((TextBoxBase)txtEmail).set_MaxLength(255);
		((Control)txtEmail).set_Name("txtEmail");
		((Control)txtEmail).set_Size(new Size(350, 19));
		((Control)txtEmail).set_TabIndex(2);
		((Control)txtEmail).add_TextChanged((EventHandler)InputChk);
		((Control)txtEmail).add_Leave((EventHandler)txtEmail_Leave);
		((Control)txtPass).set_ImeMode((ImeMode)2);
		((Control)txtPass).set_Location(new Point(135, 173));
		((TextBoxBase)txtPass).set_MaxLength(100);
		((Control)txtPass).set_Name("txtPass");
		((Control)txtPass).set_Size(new Size(350, 19));
		((Control)txtPass).set_TabIndex(3);
		txtPass.set_UseSystemPasswordChar(true);
		((Control)txtPass).add_TextChanged((EventHandler)InputChk);
		((Control)txtPass).add_Leave((EventHandler)txtPass_Leave);
		((Control)txtAnswer).set_ImeMode((ImeMode)1);
		((Control)txtAnswer).set_Location(new Point(135, 217));
		((TextBoxBase)txtAnswer).set_MaxLength(100);
		((Control)txtAnswer).set_Name("txtAnswer");
		((Control)txtAnswer).set_Size(new Size(350, 19));
		((Control)txtAnswer).set_TabIndex(5);
		((Control)txtAnswer).add_TextChanged((EventHandler)InputChk);
		((Control)txtAnswer).add_Leave((EventHandler)txtAnswer_Leave);
		((ListControl)cmbQuestion).set_FormattingEnabled(true);
		((Control)cmbQuestion).set_Location(new Point(135, 194));
		((Control)cmbQuestion).set_Name("cmbQuestion");
		((Control)cmbQuestion).set_Size(new Size(350, 20));
		((Control)cmbQuestion).set_TabIndex(4);
		cmbQuestion.add_SelectedIndexChanged((EventHandler)InputChk);
		((Control)cmbQuestion).add_Leave((EventHandler)cmbQuestion_Leave);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(89, 110));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(11, 12));
		((Control)label11).set_TabIndex(19);
		((Control)label11).set_Text("*");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(89, 132));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(11, 12));
		((Control)label12).set_TabIndex(20);
		((Control)label12).set_Text("*");
		((Control)label13).set_AutoSize(true);
		((Control)label13).set_ForeColor(Color.Red);
		((Control)label13).set_Location(new Point(49, 154));
		((Control)label13).set_Name("label13");
		((Control)label13).set_Size(new Size(11, 12));
		((Control)label13).set_TabIndex(21);
		((Control)label13).set_Text("*");
		((Control)label14).set_AutoSize(true);
		((Control)label14).set_ForeColor(Color.Red);
		((Control)label14).set_Location(new Point(54, 176));
		((Control)label14).set_Name("label14");
		((Control)label14).set_Size(new Size(11, 12));
		((Control)label14).set_TabIndex(22);
		((Control)label14).set_Text("*");
		((Control)label15).set_AutoSize(true);
		((Control)label15).set_ForeColor(Color.Red);
		((Control)label15).set_Location(new Point(43, 198));
		((Control)label15).set_Name("label15");
		((Control)label15).set_Size(new Size(11, 12));
		((Control)label15).set_TabIndex(23);
		((Control)label15).set_Text("*");
		((Control)label16).set_AutoSize(true);
		((Control)label16).set_ForeColor(Color.Red);
		((Control)label16).set_Location(new Point(12, 220));
		((Control)label16).set_Name("label16");
		((Control)label16).set_Size(new Size(11, 12));
		((Control)label16).set_TabIndex(24);
		((Control)label16).set_Text("*");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label16);
		((Control)this).get_Controls().Add((Control)(object)label15);
		((Control)this).get_Controls().Add((Control)(object)label14);
		((Control)this).get_Controls().Add((Control)(object)label13);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)cmbQuestion);
		((Control)this).get_Controls().Add((Control)(object)txtAnswer);
		((Control)this).get_Controls().Add((Control)(object)txtPass);
		((Control)this).get_Controls().Add((Control)(object)txtEmail);
		((Control)this).get_Controls().Add((Control)(object)txtMei);
		((Control)this).get_Controls().Add((Control)(object)txtSei);
		((Control)this).get_Controls().Add((Control)(object)lbl6);
		((Control)this).get_Controls().Add((Control)(object)lbl5);
		((Control)this).get_Controls().Add((Control)(object)lbl4);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page4");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Page4()
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
		cmbQuestion.get_Items().Add((object)"▼選択してください");
		cmbQuestion.get_Items().Add((object)"子どものころのあだ名は？");
		cmbQuestion.get_Items().Add((object)"初めて買った曲のタイトルは？");
		cmbQuestion.get_Items().Add((object)"初恋の人の名前は？");
		cmbQuestion.get_Items().Add((object)"子どものころの夢は？");
		cmbQuestion.get_Items().Add((object)"座右の銘は？");
		cmbQuestion.get_Items().Add((object)"初めて飼ったペットの名前は？");
		cmbQuestion.get_Items().Add((object)"祖父の下の名前は？");
		cmbQuestion.get_Items().Add((object)"生まれた病院は？");
		cmbQuestion.get_Items().Add((object)"初めて行った海外の国・地域は？");
		cmbQuestion.get_Items().Add((object)"小学1年生のときの担任の先生の名前は？");
		cmbQuestion.get_Items().Add((object)"リタイア後に住みたい場所は？");
		cmbQuestion.get_Items().Add((object)"初めて見た映画は？");
		cmbQuestion.get_Items().Add((object)"初めて買った車は？");
		cmbQuestion.get_Items().Add((object)"おふくろの味といえば？");
		cmbQuestion.get_Items().Add((object)"中学時代に所属していたクラブは？");
		cmbQuestion.set_DropDownStyle((ComboBoxStyle)2);
		((Control)txtSei).set_Text(Settings.Default.sei);
		((Control)txtMei).set_Text(Settings.Default.mei);
		((Control)txtEmail).set_Text(Settings.Default.email);
		((Control)txtPass).set_Text(Settings.Default.password);
		((ListControl)cmbQuestion).set_SelectedIndex(Settings.Default.i_question);
		((Control)txtAnswer).set_Text(Settings.Default.answer);
		chk();
	}

	private void InputChk(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		bool flag = true;
		if (((Control)txtSei).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtMei).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtEmail).get_Text() == "")
		{
			flag = false;
		}
		if (!lib.EmailChk(((Control)txtEmail).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtPass).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtAnswer).get_Text() == "")
		{
			flag = false;
		}
		if (((ListControl)cmbQuestion).get_SelectedIndex() == 0)
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
		if (((Control)txtSei).get_Text() != "")
		{
			Settings.Default.sei = ((Control)txtSei).get_Text();
			if (Settings.Default.type == "1")
			{
				Settings.Default.hero1 = ((Control)txtSei).get_Text();
			}
		}
		if (((Control)txtMei).get_Text() != "")
		{
			Settings.Default.mei = ((Control)txtMei).get_Text();
			if (Settings.Default.type == "1")
			{
				Settings.Default.hero2 = ((Control)txtMei).get_Text();
			}
		}
		if (((Control)txtEmail).get_Text() != "" && lib.EmailChk(((Control)txtEmail).get_Text()))
		{
			Settings.Default.email = ((Control)txtEmail).get_Text();
		}
		if (((Control)txtPass).get_Text() != "")
		{
			Settings.Default.password = ((Control)txtPass).get_Text();
		}
		if (((ListControl)cmbQuestion).get_SelectedIndex() != 0)
		{
			Settings.Default.question = ((Control)cmbQuestion).get_Text();
			Settings.Default.i_question = ((ListControl)cmbQuestion).get_SelectedIndex();
		}
		if (((Control)txtAnswer).get_Text() != "")
		{
			Settings.Default.answer = ((Control)txtAnswer).get_Text();
		}
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void txtSei_Leave(object sender, EventArgs e)
	{
		((Control)lbl1).set_ForeColor(Color.Black);
		if (((Control)txtSei).get_Text() == "")
		{
			((Control)lbl1).set_ForeColor(Color.Red);
		}
	}

	private void txtMei_Leave(object sender, EventArgs e)
	{
		((Control)lbl2).set_ForeColor(Color.Black);
		if (((Control)txtMei).get_Text() == "")
		{
			((Control)lbl2).set_ForeColor(Color.Red);
		}
	}

	private void txtEmail_Leave(object sender, EventArgs e)
	{
		((Control)lbl3).set_ForeColor(Color.Black);
		if (((Control)txtEmail).get_Text() == "" || !lib.EmailChk(((Control)txtEmail).get_Text()))
		{
			((Control)lbl3).set_ForeColor(Color.Red);
		}
	}

	private void txtPass_Leave(object sender, EventArgs e)
	{
		((Control)lbl4).set_ForeColor(Color.Black);
		if (((Control)txtPass).get_Text() == "")
		{
			((Control)lbl4).set_ForeColor(Color.Red);
		}
	}

	private void cmbQuestion_Leave(object sender, EventArgs e)
	{
		((Control)lbl5).set_ForeColor(Color.Black);
		if (((ListControl)cmbQuestion).get_SelectedIndex() == 0)
		{
			((Control)lbl5).set_ForeColor(Color.Red);
		}
	}

	private void txtAnswer_Leave(object sender, EventArgs e)
	{
		((Control)lbl6).set_ForeColor(Color.Black);
		if (((Control)txtAnswer).get_Text() == "")
		{
			((Control)lbl6).set_ForeColor(Color.Red);
		}
	}
}
