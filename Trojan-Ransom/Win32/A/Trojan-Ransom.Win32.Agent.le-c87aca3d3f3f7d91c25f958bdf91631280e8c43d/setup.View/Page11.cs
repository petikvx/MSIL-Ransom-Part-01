using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page11)]
public class Page11 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Label label4;

	private Label label3;

	private TextBox txtMotivation;

	private TextBox txtHobby;

	private TextBox txtSpecialty;

	private TextBox txtFeedback;

	private Label lbl1;

	private Label lbl2;

	private Label lbl3;

	private Label lbl4;

	private Label label9;

	private Label label10;

	private Label label11;

	private Label label12;

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
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		picHeader = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		label4 = new Label();
		label3 = new Label();
		txtMotivation = new TextBox();
		txtHobby = new TextBox();
		txtSpecialty = new TextBox();
		txtFeedback = new TextBox();
		lbl1 = new Label();
		lbl2 = new Label();
		lbl3 = new Label();
		lbl4 = new Label();
		label9 = new Label();
		label10 = new Label();
		label11 = new Label();
		label12 = new Label();
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
		((Control)txtMotivation).set_ImeMode((ImeMode)1);
		((Control)txtMotivation).set_Location(new Point(47, 129));
		((TextBoxBase)txtMotivation).set_MaxLength(120);
		((Control)txtMotivation).set_Name("txtMotivation");
		((Control)txtMotivation).set_Size(new Size(438, 19));
		((Control)txtMotivation).set_TabIndex(0);
		((Control)txtMotivation).add_TextChanged((EventHandler)InputChk);
		((Control)txtMotivation).add_Leave((EventHandler)txtMotivation_Leave);
		((Control)txtHobby).set_ImeMode((ImeMode)1);
		((Control)txtHobby).set_Location(new Point(47, 173));
		((TextBoxBase)txtHobby).set_MaxLength(120);
		((Control)txtHobby).set_Name("txtHobby");
		((Control)txtHobby).set_Size(new Size(438, 19));
		((Control)txtHobby).set_TabIndex(1);
		((Control)txtHobby).add_TextChanged((EventHandler)InputChk);
		((Control)txtHobby).add_Leave((EventHandler)txtHobby_Leave);
		((Control)txtSpecialty).set_ImeMode((ImeMode)1);
		((Control)txtSpecialty).set_Location(new Point(47, 215));
		((TextBoxBase)txtSpecialty).set_MaxLength(120);
		((Control)txtSpecialty).set_Name("txtSpecialty");
		((Control)txtSpecialty).set_Size(new Size(438, 19));
		((Control)txtSpecialty).set_TabIndex(2);
		((Control)txtSpecialty).add_TextChanged((EventHandler)InputChk);
		((Control)txtSpecialty).add_Leave((EventHandler)txtSpecialty_Leave);
		((Control)txtFeedback).set_ImeMode((ImeMode)1);
		((Control)txtFeedback).set_Location(new Point(47, 257));
		((TextBoxBase)txtFeedback).set_MaxLength(120);
		((Control)txtFeedback).set_Name("txtFeedback");
		((Control)txtFeedback).set_Size(new Size(438, 19));
		((Control)txtFeedback).set_TabIndex(3);
		((Control)txtFeedback).add_TextChanged((EventHandler)InputChk);
		((Control)txtFeedback).add_Leave((EventHandler)txtFeedback_Leave);
		((Control)lbl1).set_AutoSize(true);
		((Control)lbl1).set_Location(new Point(47, 110));
		((Control)lbl1).set_Name("lbl1");
		((Control)lbl1).set_Size(new Size(194, 12));
		((Control)lbl1).set_TabIndex(49);
		((Control)lbl1).set_Text("ご購入の動機・理由をお聞かせください。");
		((Control)lbl2).set_AutoSize(true);
		((Control)lbl2).set_Location(new Point(47, 154));
		((Control)lbl2).set_Name("lbl2");
		((Control)lbl2).set_Size(new Size(121, 12));
		((Control)lbl2).set_TabIndex(50);
		((Control)lbl2).set_Text("趣味をお聞かせください。");
		((Control)lbl3).set_AutoSize(true);
		((Control)lbl3).set_Location(new Point(47, 198));
		((Control)lbl3).set_Name("lbl3");
		((Control)lbl3).set_Size(new Size(121, 12));
		((Control)lbl3).set_TabIndex(51);
		((Control)lbl3).set_Text("特技をお聞かせください。");
		((Control)lbl4).set_AutoSize(true);
		((Control)lbl4).set_Location(new Point(47, 239));
		((Control)lbl4).set_Name("lbl4");
		((Control)lbl4).set_Size(new Size(213, 12));
		((Control)lbl4).set_TabIndex(52);
		((Control)lbl4).set_Text("作品へのご意見・ご感想をお聞かせください。");
		((Control)label9).set_AutoSize(true);
		((Control)label9).set_ForeColor(Color.Red);
		((Control)label9).set_Location(new Point(30, 110));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(11, 12));
		((Control)label9).set_TabIndex(53);
		((Control)label9).set_Text("*");
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_ForeColor(Color.Red);
		((Control)label10).set_Location(new Point(30, 154));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(11, 12));
		((Control)label10).set_TabIndex(54);
		((Control)label10).set_Text("*");
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(30, 198));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(11, 12));
		((Control)label11).set_TabIndex(55);
		((Control)label11).set_Text("*");
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(30, 239));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(11, 12));
		((Control)label12).set_TabIndex(56);
		((Control)label12).set_Text("*");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)lbl4);
		((Control)this).get_Controls().Add((Control)(object)lbl3);
		((Control)this).get_Controls().Add((Control)(object)lbl2);
		((Control)this).get_Controls().Add((Control)(object)lbl1);
		((Control)this).get_Controls().Add((Control)(object)txtFeedback);
		((Control)this).get_Controls().Add((Control)(object)txtSpecialty);
		((Control)this).get_Controls().Add((Control)(object)txtHobby);
		((Control)this).get_Controls().Add((Control)(object)txtMotivation);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page11");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public Page11()
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
		((Control)txtMotivation).set_Text(Settings.Default.motivation);
		((Control)txtHobby).set_Text(Settings.Default.hobby);
		((Control)txtSpecialty).set_Text(Settings.Default.specialty);
		((Control)txtFeedback).set_Text(Settings.Default.feedback);
		chk();
	}

	private void InputChk(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		bool flag = true;
		if (((Control)txtMotivation).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtHobby).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtSpecialty).get_Text() == "")
		{
			flag = false;
		}
		if (((Control)txtFeedback).get_Text() == "")
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
				new FunctionKey((Keys)78, "完了"),
				new FunctionKey((Keys)67, "キャンセル")
			});
		}
	}

	public override void OnViewClose()
	{
		if (((Control)txtMotivation).get_Text() != "")
		{
			Settings.Default.motivation = ((Control)txtMotivation).get_Text();
		}
		if (((Control)txtHobby).get_Text() != "")
		{
			Settings.Default.hobby = ((Control)txtHobby).get_Text();
		}
		if (((Control)txtSpecialty).get_Text() != "")
		{
			Settings.Default.specialty = ((Control)txtSpecialty).get_Text();
		}
		if (((Control)txtFeedback).get_Text() != "")
		{
			Settings.Default.feedback = ((Control)txtFeedback).get_Text();
		}
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void txtMotivation_Leave(object sender, EventArgs e)
	{
		((Control)lbl1).set_ForeColor(Color.Black);
		if (((Control)txtMotivation).get_Text() == "")
		{
			((Control)lbl1).set_ForeColor(Color.Red);
		}
	}

	private void txtHobby_Leave(object sender, EventArgs e)
	{
		((Control)lbl2).set_ForeColor(Color.Black);
		if (((Control)txtHobby).get_Text() == "")
		{
			((Control)lbl2).set_ForeColor(Color.Red);
		}
	}

	private void txtSpecialty_Leave(object sender, EventArgs e)
	{
		((Control)lbl3).set_ForeColor(Color.Black);
		if (((Control)txtSpecialty).get_Text() == "")
		{
			((Control)lbl3).set_ForeColor(Color.Red);
		}
	}

	private void txtFeedback_Leave(object sender, EventArgs e)
	{
		((Control)lbl4).set_ForeColor(Color.Black);
		if (((Control)txtFeedback).get_Text() == "")
		{
			((Control)lbl4).set_ForeColor(Color.Red);
		}
	}
}
