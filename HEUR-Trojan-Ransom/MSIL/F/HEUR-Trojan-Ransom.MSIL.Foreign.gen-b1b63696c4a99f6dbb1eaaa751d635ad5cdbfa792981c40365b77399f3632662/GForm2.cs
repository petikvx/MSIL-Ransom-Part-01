using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm2 : Form
{
	private IContainer icontainer_0 = null;

	private Panel panel_0;

	private ComboBox comboBox_0;

	private PictureBox pictureBox_0;

	private ProgressBar progressBar_0;

	private CheckBox checkBox_0;

	private Label label_0;

	private Label label_1;

	private CheckBox checkBox_1;

	private RadioButton radioButton_0;

	private Timer timer_0;

	private Button button_0;

	private DomainUpDown domainUpDown_0;

	private RichTextBox richTextBox_0;

	private ComboBox comboBox_1;

	private RichTextBox richTextBox_1;

	private DomainUpDown domainUpDown_1;

	private GroupBox groupBox_0;

	private HScrollBar hscrollBar_0;

	public GForm2()
	{
		method_0();
	}

	private void GForm2_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Control)this).get_Controls().Add((Control)(object)comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Control)this).get_Controls().Add((Control)(object)progressBar_0);
		((Control)this).get_Controls().Add((Control)(object)checkBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)checkBox_1);
		((Control)this).get_Controls().Add((Control)(object)radioButton_0);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)richTextBox_0);
		((Control)this).get_Controls().Add((Control)(object)comboBox_1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox_1);
		((Control)this).get_Controls().Add((Control)(object)groupBox_0);
		((Control)groupBox_0).ResumeLayout(false);
		((Control)this).get_Controls().Add((Control)(object)hscrollBar_0);
		((Control)this).set_Name(Class3.smethod_0(Class5.smethod_0("ᚤᚍᚐᚏᛑ", 62300), 58803));
		((Control)this).set_Text(Class3.smethod_0(Class5.smethod_0("ᚤᚍᚐᚏᛑ", 62300), 58803));
		((ISupportInitialize)pictureBox_0).EndInit();
		((Form)this).add_Load((EventHandler)GForm2_Load);
		((Control)this).ResumeLayout(false);
		panel_0 = new Panel();
		comboBox_0 = new ComboBox();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		progressBar_0 = new ProgressBar();
		checkBox_0 = new CheckBox();
		label_0 = new Label();
		label_1 = new Label();
		checkBox_1 = new CheckBox();
		radioButton_0 = new RadioButton();
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		button_0 = new Button();
		domainUpDown_0 = new DomainUpDown();
		richTextBox_0 = new RichTextBox();
		comboBox_1 = new ComboBox();
		richTextBox_1 = new RichTextBox();
		domainUpDown_1 = new DomainUpDown();
		groupBox_0 = new GroupBox();
		hscrollBar_0 = new HScrollBar();
		((Control)this).SuspendLayout();
		((Control)panel_0).set_Location(new Point(10, 83));
		((Control)panel_0).set_Name(Class3.smethod_0(Class5.smethod_0("æ÷øóú§", 63740), 63594));
		((Control)panel_0).set_Size(new Size(200, 100));
		((Control)panel_0).set_TabIndex(1052);
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(124, 61));
		((Control)comboBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᔁᔍᔏᔀᔍᔠᔍᔚᕓ", 62797), 57507));
		((Control)comboBox_0).set_Size(new Size(121, 21));
		((Control)comboBox_0).set_TabIndex(1053);
		((Control)pictureBox_0).set_Location(new Point(106, 83));
		((Control)pictureBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᯈᯑᯛᯌᯍᯊᯝ\u1bfaᯗᯀᮉ", 63080), 60866));
		((Control)pictureBox_0).set_Size(new Size(100, 50));
		pictureBox_0.set_TabIndex(1054);
		pictureBox_0.set_TabStop(false);
		((Control)progressBar_0).set_Location(new Point(101, 48));
		((Control)progressBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0e66\u0e64\u0e79\u0e71\u0e64\u0e73\u0e65\u0e65๔\u0e77\u0e64ว", 57962), 60625));
		((Control)progressBar_0).set_Size(new Size(100, 23));
		((Control)progressBar_0).set_TabIndex(1055);
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Location(new Point(137, 17));
		((Control)checkBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᙩᙢᙯᙩᙡᙈᙥᙲᘻ", 58695), 62305));
		((Control)checkBox_0).set_Size(new Size(80, 17));
		((Control)checkBox_0).set_TabIndex(1056);
		((Control)checkBox_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᙩᙢᙯᙩᙡᙈᙥᙲᘻ", 58695), 62305));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(129, 161));
		((Control)label_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0fba\u0fb7\u0fb4\u0fb3\u0fba\u0fe7", 60088), 58689));
		((Control)label_0).set_Size(new Size(35, 13));
		((Control)label_0).set_TabIndex(1057);
		((Control)label_0).set_Text(Class3.smethod_0(Class5.smethod_0("\u0fba\u0fb7\u0fb4\u0fb3\u0fba\u0fe7", 60088), 58689));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(81, 195));
		((Control)label_1).set_Name(Class3.smethod_0(Class5.smethod_0("॰ॽॾॹ॰म", 59850), 57408));
		((Control)label_1).set_Size(new Size(35, 13));
		((Control)label_1).set_TabIndex(1058);
		((Control)label_1).set_Text(Class3.smethod_0(Class5.smethod_0("॰ॽॾॹ॰म", 59850), 57408));
		((Control)checkBox_1).set_AutoSize(true);
		((Control)checkBox_1).set_Location(new Point(6, 71));
		((Control)checkBox_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u09d3\u09d8\u09d5\u09d3\u09db৲য়\u09c8\u0982", 58473), 60884));
		((Control)checkBox_1).set_Size(new Size(80, 17));
		((Control)checkBox_1).set_TabIndex(1059);
		((Control)checkBox_1).set_Text(Class3.smethod_0(Class5.smethod_0("\u09d3\u09d8\u09d5\u09d3\u09db৲য়\u09c8\u0982", 58473), 60884));
		((ButtonBase)checkBox_1).set_UseVisualStyleBackColor(true);
		((Control)radioButton_0).set_AutoSize(true);
		((Control)radioButton_0).set_Location(new Point(84, 175));
		((Control)radioButton_0).set_Name(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((Control)radioButton_0).set_Size(new Size(85, 17));
		((Control)radioButton_0).set_TabIndex(1060);
		radioButton_0.set_TabStop(true);
		((Control)radioButton_0).set_Text(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((ButtonBase)radioButton_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).set_Location(new Point(70, 165));
		((Control)button_0).set_Name(Class3.smethod_0(Class5.smethod_0("᪖᪁᪀᪀\u1a9b\u1a9a\u1ac5", 60310), 61770));
		((Control)button_0).set_Size(new Size(75, 23));
		((Control)button_0).set_TabIndex(1061);
		((Control)button_0).set_Text(Class3.smethod_0(Class5.smethod_0("᪖᪁᪀᪀\u1a9b\u1a9a\u1ac5", 60310), 61770));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)domainUpDown_0).set_Location(new Point(31, 63));
		((Control)domainUpDown_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᅴᅿᅽᅱᅹᅾᅅᅠᅔᅿᅧᅾᄡ", 62711), 58855));
		((Control)domainUpDown_0).set_Size(new Size(120, 20));
		((Control)domainUpDown_0).set_TabIndex(1062);
		((Control)domainUpDown_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᅴᅿᅽᅱᅹᅾᅅᅠᅔᅿᅧᅾᄡ", 62711), 58855));
		((Control)richTextBox_0).set_Location(new Point(109, 90));
		((Control)richTextBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0360ͻͱͺ\u0346ͷ\u036a\u0366\u0350ͽ\u036a\u0323", 61290), 60441));
		((Control)richTextBox_0).set_Size(new Size(100, 96));
		((Control)richTextBox_0).set_TabIndex(1063);
		((Control)richTextBox_0).set_Text("");
		((ListControl)comboBox_1).set_FormattingEnabled(true);
		((Control)comboBox_1).set_Location(new Point(73, 149));
		((Control)comboBox_1).set_Name(Class3.smethod_0(Class5.smethod_0("ᄢᄮᄬᄣᄮᄃᄮᄹᅳ", 61468), 57851));
		((Control)comboBox_1).set_Size(new Size(121, 21));
		((Control)comboBox_1).set_TabIndex(1064);
		((Control)richTextBox_1).set_Location(new Point(193, 39));
		((Control)richTextBox_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u07eeߵ߿ߴ߈߹ߤߨߞ\u07f3ߤ\u07ae", 60096), 60760));
		((Control)richTextBox_1).set_Size(new Size(100, 96));
		((Control)richTextBox_1).set_TabIndex(1065);
		((Control)richTextBox_1).set_Text("");
		((Control)domainUpDown_1).set_Location(new Point(181, 119));
		((Control)domainUpDown_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u1b80ᮋᮉᮅᮍᮊ᮱ᮔᮠᮋᮓᮊᯖ", 62864), 60952));
		((Control)domainUpDown_1).set_Size(new Size(120, 20));
		((Control)domainUpDown_1).set_TabIndex(1066);
		((Control)domainUpDown_1).set_Text(Class3.smethod_0(Class5.smethod_0("\u1b80ᮋᮉᮅᮍᮊ᮱ᮔᮠᮋᮓᮊᯖ", 62864), 60952));
		((Control)groupBox_0).set_Location(new Point(48, 113));
		((Control)groupBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᏔᏁᏜᏆᏃᏱᏜᏋᎂ", 62286), 57580));
		((Control)groupBox_0).set_Size(new Size(200, 100));
		((Control)groupBox_0).set_TabIndex(1067);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᏔᏁᏜᏆᏃᏱᏜᏋᎂ", 62286), 57580));
		((Control)hscrollBar_0).set_Location(new Point(190, 177));
		((Control)hscrollBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u1ff5\u1fce\u1ffe\u1fefῲ\u1ff1\u1ff1\u1fdfῼ\u1fefᾬ", 62302), 60514));
		((Control)hscrollBar_0).set_Size(new Size(80, 17));
		((Control)hscrollBar_0).set_TabIndex(1068);
	}
}
