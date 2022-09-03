using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page7)]
public class Page7 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Label label4;

	private Label label3;

	private Label label5;

	private Label lbl3;

	private Label lbl2;

	private Label lbl1;

	private TextBox txtName3;

	private TextBox txtName2;

	private TextBox txtName1;

	private Label label6;

	private Label label10;

	public Page7()
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
		((Control)label1).set_Text("主人公の名前");
		((Control)label2).set_Text("主人公の名前を入力してください。(6文字以内)");
		((Control)txtName1).set_Text(Settings.Default.hero1);
		((Control)txtName2).set_Text(Settings.Default.hero2);
		((Control)txtName3).set_Text(Settings.Default.hero3);
		chk();
	}

	private void InputChk(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		bool flag = true;
		if (((Control)txtName1).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtName2).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtName3).get_Text() == "")
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
		if (((Control)txtName1).get_Text() != "")
		{
			Settings.Default.hero1 = ((Control)txtName1).get_Text();
		}
		if (((Control)txtName2).get_Text() != "")
		{
			Settings.Default.hero2 = ((Control)txtName2).get_Text();
		}
		if (((Control)txtName3).get_Text() != "")
		{
			Settings.Default.hero3 = ((Control)txtName3).get_Text();
		}
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void txtName1_Leave(object sender, EventArgs e)
	{
		((Control)lbl1).set_ForeColor(Color.Black);
		if (((Control)txtName1).get_Text() == "")
		{
			((Control)lbl1).set_ForeColor(Color.Red);
		}
	}

	private void txtName2_Leave(object sender, EventArgs e)
	{
		((Control)lbl2).set_ForeColor(Color.Black);
		if (((Control)txtName2).get_Text() == "")
		{
			((Control)lbl2).set_ForeColor(Color.Red);
		}
	}

	private void txtName3_Leave(object sender, EventArgs e)
	{
		((Control)lbl3).set_ForeColor(Color.Black);
		if (((Control)txtName3).get_Text() == "")
		{
			((Control)lbl3).set_ForeColor(Color.Red);
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
		label5 = new Label();
		lbl3 = new Label();
		lbl2 = new Label();
		lbl1 = new Label();
		txtName3 = new TextBox();
		txtName2 = new TextBox();
		txtName1 = new TextBox();
		label6 = new Label();
		label10 = new Label();
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
		((Control)label2).set_TabIndex(14);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(13);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(47, 85));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(113, 12));
		((Control)label4).set_TabIndex(16);
		((Control)label4).set_Text("アスタリスクは必須項目");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(30, 85));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(11, 12));
		((Control)label3).set_TabIndex(15);
		((Control)label3).set_Text("*");
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(77, 110));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(11, 12));
		((Control)label5).set_TabIndex(30);
		((Control)label5).set_Text("*");
		((Control)lbl3).set_AutoSize(true);
		((Control)lbl3).set_Location(new Point(64, 154));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Size(new Size(69, 12));
		((Control)lbl3).set_TabIndex(29);
		((Control)lbl3).set_Text("ニックネーム : ");
		((Control)lbl2).set_AutoSize(true);
		((Control)lbl2).set_Location(new Point(94, 132));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Size(new Size(39, 12));
		((Control)lbl2).set_TabIndex(28);
		((Control)lbl2).set_Text("名前 : ");
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Location(new Point(94, 110));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(39, 12));
		((Control)lbl1).set_TabIndex(27);
		((Control)lbl1).set_Text("苗字 : ");
		((Control)txtName3).set_ImeMode((ImeMode)1);
		((Control)txtName3).set_Location(new Point(135, 151));
		((TextBoxBase)txtName3).set_MaxLength(40);
		((Control)txtName3).set_Name("txtName3");
		((Control)txtName3).set_Size(new Size(350, 19));
		((Control)txtName3).set_TabIndex(2);
		((Control)txtName3).add_TextChanged((EventHandler)InputChk);
		((Control)txtName3).add_Leave((EventHandler)txtName3_Leave);
		((Control)txtName2).set_ImeMode((ImeMode)1);
		((Control)txtName2).set_Location(new Point(135, 129));
		((TextBoxBase)txtName2).set_MaxLength(40);
		((Control)txtName2).set_Name("txtName2");
		((Control)txtName2).set_Size(new Size(350, 19));
		((Control)txtName2).set_TabIndex(1);
		((Control)txtName2).add_TextChanged((EventHandler)InputChk);
		((Control)txtName2).add_Leave((EventHandler)txtName2_Leave);
		((Control)txtName1).set_ImeMode((ImeMode)1);
		((Control)txtName1).set_Location(new Point(135, 107));
		((TextBoxBase)txtName1).set_MaxLength(40);
		((Control)txtName1).set_Name("txtName1");
		((Control)txtName1).set_Size(new Size(350, 19));
		((Control)txtName1).set_TabIndex(0);
		((Control)txtName1).add_TextChanged((EventHandler)InputChk);
		((Control)txtName1).add_Leave((EventHandler)txtName1_Leave);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_ForeColor(Color.Red);
		((Control)label6).set_Location(new Point(77, 132));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(11, 12));
		((Control)label6).set_TabIndex(31);
		((Control)label6).set_Text("*");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_ForeColor(Color.Red);
		((Control)label10).set_Location(new Point(47, 154));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(11, 12));
		((Control)label10).set_TabIndex(32);
		((Control)label10).set_Text("*");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)txtName3);
		((Control)this).get_Controls().Add((Control)(object)txtName2);
		((Control)this).get_Controls().Add((Control)(object)txtName1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page7");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
