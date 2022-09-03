using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Smart.Windows.Mvc;
using setup.Properties;

namespace setup.View;

[View(Views.page1)]
public class Page1 : AppViewBase
{
	private IContainer components;

	private PictureBox picTop;

	private Label label1;

	private Label label2;

	private Label label3;

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
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		picTop = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		((ISupportInitialize)picTop).BeginInit();
		((Control)this).SuspendLayout();
		((Control)picTop).set_Dock((DockStyle)5);
		((Control)picTop).set_Location(new Point(0, 0));
		((Control)picTop).set_Name("picTop");
		((Control)picTop).set_Size(new Size(500, 300));
		picTop.set_TabIndex(0);
		picTop.set_TabStop(false);
		((Control)label1).set_BackColor(Color.Transparent);
		((Control)label1).set_Font(new Font("MS UI Gothic", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(190, 10));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(300, 50));
		((Control)label1).set_TabIndex(1);
		((Control)label2).set_Location(new Point(190, 70));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(300, 70));
		((Control)label2).set_TabIndex(2);
		((Control)label3).set_Location(new Point(190, 180));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(300, 70));
		((Control)label3).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)picTop);
		((Control)this).set_Name("Page1");
		((Control)this).set_Size(new Size(500, 300));
		((ISupportInitialize)picTop).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public Page1()
	{
		InitializeComponent();
	}

	public override void OnViewOpen(ViewForwardEventArgs args)
	{
		picTop.set_Image(Image.FromFile(Settings.Default.it_dir));
		Label obj = label1;
		Label obj2 = label2;
		Color transparent;
		((Control)label3).set_BackColor(transparent = Color.Transparent);
		Color backColor;
		((Control)obj2).set_BackColor(backColor = transparent);
		((Control)obj).set_BackColor(backColor);
		Label obj3 = label1;
		Label obj4 = label2;
		Control val;
		((Control)label3).set_Parent(val = (Control)(object)picTop);
		Control parent;
		((Control)obj4).set_Parent(parent = val);
		((Control)obj3).set_Parent(parent);
		Label obj5 = label1;
		Label obj6 = label2;
		Color color;
		((Control)label3).set_ForeColor(color = ColorTranslator.FromHtml(Settings.Default.f1));
		Color foreColor;
		((Control)obj6).set_ForeColor(foreColor = color);
		((Control)obj5).set_ForeColor(foreColor);
		((Control)label1).set_Text(Settings.Default.fn + "のインストールウィザードへようこそ");
		((Control)label2).set_Text("インストールウィザードにはコンピューターに" + Settings.Default.fn + "をインストールします。続行するには「次へ」をクリックしてください。");
		((Control)label3).set_Text("警告：このプログラムは著作憲法および国際協定によって保護されています。");
		base.FunctionCotrol.UpdateFunctionKeys(new FunctionKey[2]
		{
			new FunctionKey((Keys)78, "次へ"),
			new FunctionKey((Keys)67, "キャンセル")
		});
	}

	public override void OnViewClose()
	{
		picTop.get_Image().Dispose();
		picTop.set_Image((Image)null);
	}
}
