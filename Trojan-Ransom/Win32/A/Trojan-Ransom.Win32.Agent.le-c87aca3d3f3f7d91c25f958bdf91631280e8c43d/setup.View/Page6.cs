using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page6)]
public class Page6 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Label label4;

	private Label label3;

	private TextBox txtMTel;

	private TextBox txtFax;

	private TextBox txtTel;

	private Label lbl4;

	private Label lbl3;

	private Label lbl2;

	private Label lbl1;

	private Label label5;

	private TextBox txtMEmail;

	public Page6()
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
		((Control)txtTel).set_Text(Settings.Default.tel);
		((Control)txtFax).set_Text(Settings.Default.fax);
		((Control)txtMTel).set_Text(Settings.Default.mtel);
		((Control)txtMEmail).set_Text(Settings.Default.memail);
		chk();
	}

	private void InputChk(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		bool flag = true;
		if (((Control)txtTel).get_Text() == "")
		{
			flag = false;
		}
		if (!lib.TelChk(((Control)txtTel).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtFax).get_Text() != "" && !lib.TelChk(((Control)txtFax).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtMTel).get_Text() != "" && !lib.TelChk(((Control)txtMTel).get_Text()))
		{
			flag = false;
		}
		if (((Control)txtMEmail).get_Text() != "" && !lib.EmailChk(((Control)txtMEmail).get_Text()))
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
		if (((Control)txtTel).get_Text() != "" && lib.TelChk(((Control)txtTel).get_Text()))
		{
			Settings.Default.tel = ((Control)txtTel).get_Text();
		}
		if (((Control)txtFax).get_Text() != "" && lib.TelChk(((Control)txtFax).get_Text()))
		{
			Settings.Default.fax = ((Control)txtFax).get_Text();
		}
		if (((Control)txtMTel).get_Text() != "" && lib.TelChk(((Control)txtMTel).get_Text()))
		{
			Settings.Default.mtel = ((Control)txtMTel).get_Text();
		}
		if (((Control)txtMEmail).get_Text() != "" && lib.EmailChk(((Control)txtMEmail).get_Text()))
		{
			Settings.Default.memail = ((Control)txtMEmail).get_Text();
		}
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void txtTel_Leave(object sender, EventArgs e)
	{
		((Control)lbl1).set_ForeColor(Color.Black);
		if (((Control)txtTel).get_Text() == "" || !lib.TelChk(((Control)txtTel).get_Text()))
		{
			((Control)lbl1).set_ForeColor(Color.Red);
		}
	}

	private void txtFax_Leave(object sender, EventArgs e)
	{
		((Control)lbl2).set_ForeColor(Color.Black);
		if (((Control)txtFax).get_Text() == "" || !lib.TelChk(((Control)txtFax).get_Text()))
		{
			((Control)lbl2).set_ForeColor(Color.Red);
		}
	}

	private void txtMTel_Leave(object sender, EventArgs e)
	{
		((Control)lbl3).set_ForeColor(Color.Black);
		if (((Control)txtMTel).get_Text() == "" || !lib.TelChk(((Control)txtMTel).get_Text()))
		{
			((Control)lbl3).set_ForeColor(Color.Red);
		}
	}

	private void txtMEmail_Leave(object sender, EventArgs e)
	{
		((Control)lbl4).set_ForeColor(Color.Black);
		if (((Control)txtMEmail).get_Text() == "" || !lib.EmailChk(((Control)txtMEmail).get_Text()))
		{
			((Control)lbl4).set_ForeColor(Color.Red);
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
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		picHeader = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		label4 = new Label();
		label3 = new Label();
		txtMTel = new TextBox();
		txtFax = new TextBox();
		txtTel = new TextBox();
		lbl4 = new Label();
		lbl3 = new Label();
		lbl2 = new Label();
		lbl1 = new Label();
		label5 = new Label();
		txtMEmail = new TextBox();
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
		((Control)label2).set_TabIndex(12);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(11);
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
		((Control)txtMTel).set_Location(new Point(135, 151));
		((TextBoxBase)txtMTel).set_MaxLength(15);
		((Control)txtMTel).set_Name("txtMTel");
		((Control)txtMTel).set_Size(new Size(350, 19));
		((Control)txtMTel).set_TabIndex(2);
		((Control)txtMTel).add_TextChanged((EventHandler)InputChk);
		((Control)txtMTel).add_Leave((EventHandler)txtMTel_Leave);
		((Control)txtFax).set_Location(new Point(135, 129));
		((TextBoxBase)txtFax).set_MaxLength(15);
		((Control)txtFax).set_Name("txtFax");
		((Control)txtFax).set_Size(new Size(350, 19));
		((Control)txtFax).set_TabIndex(1);
		((Control)txtFax).add_TextChanged((EventHandler)InputChk);
		((Control)txtFax).add_Leave((EventHandler)txtFax_Leave);
		((Control)txtTel).set_Location(new Point(135, 107));
		((TextBoxBase)txtTel).set_MaxLength(15);
		((Control)txtTel).set_Name("txtTel");
		((Control)txtTel).set_Size(new Size(350, 19));
		((Control)txtTel).set_TabIndex(0);
		((Control)txtTel).add_TextChanged((EventHandler)InputChk);
		((Control)txtTel).add_Leave((EventHandler)txtTel_Leave);
		((Control)lbl4).set_AutoSize(true);
		((Control)lbl4).set_Location(new Point(30, 176));
		((Control)lbl4).set_Name("lbl4");
		((Control)lbl4).set_Size(new Size(103, 12));
		((Control)lbl4).set_TabIndex(22);
		((Control)lbl4).set_Text("携帯メールアドレス : ");
		((Control)lbl3).set_AutoSize(true);
		((Control)lbl3).set_Location(new Point(46, 154));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Size(new Size(87, 12));
		((Control)lbl3).set_TabIndex(21);
		((Control)lbl3).set_Text("携帯電話番号 : ");
		((Control)lbl2).set_AutoSize(true);
		((Control)lbl2).set_Location(new Point(72, 132));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Size(new Size(61, 12));
		((Control)lbl2).set_TabIndex(20);
		((Control)lbl2).set_Text("FAX番号 : ");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Location(new Point(70, 110));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(63, 12));
		((Control)lbl1).set_TabIndex(19);
		((Control)lbl1).set_Text("電話番号 : ");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(53, 110));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(11, 12));
		((Control)label5).set_TabIndex(23);
		((Control)label5).set_Text("*");
		((Control)txtMEmail).set_Location(new Point(135, 173));
		((TextBoxBase)txtMEmail).set_MaxLength(100);
		((Control)txtMEmail).set_Name("txtMEmail");
		((Control)txtMEmail).set_Size(new Size(350, 19));
		((Control)txtMEmail).set_TabIndex(3);
		((Control)txtMEmail).add_TextChanged((EventHandler)InputChk);
		((Control)txtMEmail).add_Leave((EventHandler)txtMEmail_Leave);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)txtMEmail);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)lbl4);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)txtMTel);
		((Control)this).get_Controls().Add((Control)(object)txtFax);
		((Control)this).get_Controls().Add((Control)(object)txtTel);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page6");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
