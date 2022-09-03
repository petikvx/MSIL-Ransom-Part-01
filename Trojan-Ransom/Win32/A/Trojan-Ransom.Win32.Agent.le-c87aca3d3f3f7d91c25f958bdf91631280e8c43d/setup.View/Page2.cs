using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page2)]
public class Page2 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private RadioButton rbNo;

	private RadioButton rbYes;

	private TextBox txtRule;

	private Label label1;

	private Label label2;

	public Page2()
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
		((Control)label1).set_Text("使用許諾契約書");
		((Control)label2).set_Text("次の使用許諾契約書をよくお読みください。");
		((Control)txtRule).set_Text(lib.GetRules());
		chk();
	}

	public override void OnViewClose()
	{
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void rbYes_CheckedChanged(object sender, EventArgs e)
	{
		chk();
	}

	private void chk()
	{
		base.FunctionCotrol.UpdateFunctionKeys(new FunctionKey[2]
		{
			new FunctionKey((Keys)66, "戻る"),
			new FunctionKey((Keys)67, "キャンセル")
		});
		if (rbYes.get_Checked())
		{
			base.FunctionCotrol.UpdateFunctionKeys(new FunctionKey[3]
			{
				new FunctionKey((Keys)66, "戻る"),
				new FunctionKey((Keys)78, "次へ"),
				new FunctionKey((Keys)67, "キャンセル")
			});
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
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		picHeader = new PictureBox();
		rbNo = new RadioButton();
		rbYes = new RadioButton();
		txtRule = new TextBox();
		label1 = new Label();
		label2 = new Label();
		((ISupportInitialize)picHeader).BeginInit();
		((Control)this).SuspendLayout();
		((Control)picHeader).set_Dock((DockStyle)1);
		((Control)picHeader).set_Location(new Point(0, 0));
		((Control)picHeader).set_Name("picHeader");
		((Control)picHeader).set_Size(new Size(500, 70));
		picHeader.set_TabIndex(0);
		picHeader.set_TabStop(false);
		((Control)rbNo).set_AutoSize(true);
		rbNo.set_Checked(true);
		((Control)rbNo).set_Location(new Point(20, 246));
		((Control)rbNo).set_Name("rbNo");
		((Control)rbNo).set_Size(new Size(166, 16));
		((Control)rbNo).set_TabIndex(1);
		rbNo.set_TabStop(true);
		((Control)rbNo).set_Text("使用許諾契約に同意しません");
		((ButtonBase)rbNo).set_UseVisualStyleBackColor(true);
		((Control)rbYes).set_AutoSize(true);
		((Control)rbYes).set_Location(new Point(20, 268));
		((Control)rbYes).set_Name("rbYes");
		((Control)rbYes).set_Size(new Size(156, 16));
		((Control)rbYes).set_TabIndex(2);
		((Control)rbYes).set_Text("使用許諾契約に同意します");
		((ButtonBase)rbYes).set_UseVisualStyleBackColor(true);
		rbYes.add_CheckedChanged((EventHandler)rbYes_CheckedChanged);
		((Control)txtRule).set_BackColor(Color.White);
		((Control)txtRule).set_Font(new Font("MS UI Gothic", 12f));
		((Control)txtRule).set_Location(new Point(20, 90));
		((TextBoxBase)txtRule).set_Multiline(true);
		((Control)txtRule).set_Name("txtRule");
		((TextBoxBase)txtRule).set_ReadOnly(true);
		txtRule.set_ScrollBars((ScrollBars)2);
		((Control)txtRule).set_Size(new Size(460, 150));
		((Control)txtRule).set_TabIndex(4);
		((Control)txtRule).set_TabStop(false);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(5);
		((Control)label2).set_Location(new Point(30, 33));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(300, 27));
		((Control)label2).set_TabIndex(6);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)txtRule);
		((Control)this).get_Controls().Add((Control)(object)rbYes);
		((Control)this).get_Controls().Add((Control)(object)rbNo);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page2");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
