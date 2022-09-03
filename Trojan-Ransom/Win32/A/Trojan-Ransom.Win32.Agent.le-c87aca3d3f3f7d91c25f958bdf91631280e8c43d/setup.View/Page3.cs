using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page3)]
public class Page3 : AppViewBase
{
	private IContainer components;

	private PictureBox picHeader;

	private Label label2;

	private Label label1;

	private Button btnChange;

	private PictureBox picIco;

	private Label label3;

	private Label label4;

	public Page3()
	{
		InitializeComponent();
	}

	public override void OnViewOpen(ViewForwardEventArgs args)
	{
		picHeader.set_Image(Image.FromFile(Settings.Default.ih_dir));
		if (Settings.Default.instalpass == "")
		{
			Settings.Default.instalpass = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\" + Settings.Default.fn;
		}
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
		((Control)label1).set_Text("インストール先フォルダ");
		((Control)label2).set_Text("このフォルダにインストールするには[次へ]をクリックします。別のフォルダにインストールするには[変更]をクリックします。");
		((Control)label3).set_Text(Settings.Default.fn + " のインストール先:");
		((Control)label4).set_Text(Settings.Default.instalpass);
		base.FunctionCotrol.UpdateFunctionKeys(new FunctionKey[3]
		{
			new FunctionKey((Keys)66, "戻る"),
			new FunctionKey((Keys)78, "次へ"),
			new FunctionKey((Keys)67, "キャンセル")
		});
	}

	public override void OnViewClose()
	{
		picHeader.get_Image().Dispose();
		picHeader.set_Image((Image)null);
	}

	private void btnChange_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		FolderBrowserDialog val = new FolderBrowserDialog();
		val.set_Description("インストールディレクトリを選択します");
		val.set_RootFolder(Environment.SpecialFolder.Desktop);
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((Control)label4).set_Text(val.get_SelectedPath());
			Settings.Default.instalpass = val.get_SelectedPath();
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
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		picHeader = new PictureBox();
		label2 = new Label();
		label1 = new Label();
		btnChange = new Button();
		picIco = new PictureBox();
		label3 = new Label();
		label4 = new Label();
		((ISupportInitialize)picHeader).BeginInit();
		((ISupportInitialize)picIco).BeginInit();
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
		((Control)label2).set_TabIndex(8);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(15, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 15));
		((Control)label1).set_TabIndex(7);
		((Control)btnChange).set_Location(new Point(400, 90));
		((Control)btnChange).set_Name("btnChange");
		((Control)btnChange).set_Size(new Size(75, 23));
		((Control)btnChange).set_TabIndex(9);
		((Control)btnChange).set_Text("変更");
		((ButtonBase)btnChange).set_UseVisualStyleBackColor(true);
		((Control)btnChange).add_Click((EventHandler)btnChange_Click);
		picIco.set_Image((Image)(object)Resources.install);
		((Control)picIco).set_Location(new Point(10, 80));
		((Control)picIco).set_Name("picIco");
		((Control)picIco).set_Size(new Size(32, 33));
		picIco.set_TabIndex(10);
		picIco.set_TabStop(false);
		((Control)label3).set_Location(new Point(50, 90));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(340, 23));
		((Control)label3).set_TabIndex(11);
		((Control)label4).set_Location(new Point(50, 120));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(340, 50));
		((Control)label4).set_TabIndex(12);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)picIco);
		((Control)this).get_Controls().Add((Control)(object)btnChange);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picHeader);
		((Control)this).set_Name("Page3");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picHeader).EndInit();
		((ISupportInitialize)picIco).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
