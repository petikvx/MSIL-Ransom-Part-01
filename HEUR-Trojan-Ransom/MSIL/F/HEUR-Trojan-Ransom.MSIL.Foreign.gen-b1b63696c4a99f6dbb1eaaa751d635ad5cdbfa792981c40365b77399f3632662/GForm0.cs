using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm0 : Form
{
	private IContainer icontainer_0 = null;

	private HScrollBar hscrollBar_0;

	private Panel panel_0;

	private Label label_0;

	private DateTimePicker dateTimePicker_0;

	private Splitter splitter_0;

	private Label label_1;

	private TextBox textBox_0;

	private HScrollBar hscrollBar_1;

	private ComboBox comboBox_0;

	private HScrollBar hscrollBar_2;

	private Panel panel_1;

	private MenuStrip menuStrip_0;

	private DateTimePicker dateTimePicker_1;

	private ListView listView_0;

	private RadioButton radioButton_0;

	private Label label_2;

	public GForm0()
	{
		method_0();
	}

	private void GForm0_Load(object sender, EventArgs e)
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
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)hscrollBar_0);
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)hscrollBar_1);
		((Control)this).get_Controls().Add((Control)(object)comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)hscrollBar_2);
		((Control)this).get_Controls().Add((Control)(object)panel_1);
		((Control)this).get_Controls().Add((Control)(object)menuStrip_0);
		((Form)this).set_MainMenuStrip(menuStrip_0);
		((Control)this).get_Controls().Add((Control)(object)listView_0);
		((Control)this).get_Controls().Add((Control)(object)radioButton_0);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).set_Name(Class3.smethod_0(Class5.smethod_0("దఏఒ\u0c0d\u0c51", 61169), 57990));
		((Control)this).set_Text(Class3.smethod_0(Class5.smethod_0("దఏఒ\u0c0d\u0c51", 61169), 57990));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
		hscrollBar_0 = new HScrollBar();
		panel_0 = new Panel();
		label_0 = new Label();
		dateTimePicker_0 = new DateTimePicker();
		splitter_0 = new Splitter();
		label_1 = new Label();
		textBox_0 = new TextBox();
		hscrollBar_1 = new HScrollBar();
		comboBox_0 = new ComboBox();
		hscrollBar_2 = new HScrollBar();
		panel_1 = new Panel();
		menuStrip_0 = new MenuStrip();
		dateTimePicker_1 = new DateTimePicker();
		listView_0 = new ListView();
		radioButton_0 = new RadioButton();
		label_2 = new Label();
		((Control)this).SuspendLayout();
		((Control)hscrollBar_0).set_Location(new Point(137, 88));
		((Control)hscrollBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u1ff5\u1fce\u1ffe\u1fefῲ\u1ff1\u1ff1\u1fdfῼ\u1fefᾬ", 62302), 60514));
		((Control)hscrollBar_0).set_Size(new Size(80, 17));
		((Control)hscrollBar_0).set_TabIndex(1022);
		((Control)panel_0).set_Location(new Point(90, 135));
		((Control)panel_0).set_Name(Class3.smethod_0(Class5.smethod_0("æ÷øóú§", 63740), 63594));
		((Control)panel_0).set_Size(new Size(200, 100));
		((Control)panel_0).set_TabIndex(1023);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(12, 137));
		((Control)label_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0fba\u0fb7\u0fb4\u0fb3\u0fba\u0fe7", 60088), 58689));
		((Control)label_0).set_Size(new Size(35, 13));
		((Control)label_0).set_TabIndex(1024);
		((Control)label_0).set_Text(Class3.smethod_0(Class5.smethod_0("\u0fba\u0fb7\u0fb4\u0fb3\u0fba\u0fe7", 60088), 58689));
		((Control)dateTimePicker_0).set_Location(new Point(93, 196));
		((Control)dateTimePicker_0).set_Name(Class3.smethod_0(Class5.smethod_0("ݑݔ\u0741ݐݡݜݘݐݥݜݖݞݐ\u0747܄", 61394), 59559));
		((Control)dateTimePicker_0).set_Size(new Size(200, 20));
		((Control)dateTimePicker_0).set_TabIndex(1025);
		((Control)splitter_0).set_Location(new Point(107, 1));
		((Control)splitter_0).set_Name(Class3.smethod_0(Class5.smethod_0("ቱቲቮቫቶቶቧተሳ", 57450), 62025));
		((Control)splitter_0).set_Size(new Size(3, 68));
		((Control)splitter_0).set_TabIndex(1026);
		splitter_0.set_TabStop(false);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(3, 93));
		((Control)label_1).set_Name(Class3.smethod_0(Class5.smethod_0("॰ॽॾॹ॰म", 59850), 57408));
		((Control)label_1).set_Size(new Size(35, 13));
		((Control)label_1).set_TabIndex(1027);
		((Control)label_1).set_Text(Class3.smethod_0(Class5.smethod_0("॰ॽॾॹ॰म", 59850), 57408));
		((Control)textBox_0).set_Location(new Point(34, 12));
		((Control)textBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ӶӧӺӶӀӭӺҳ", 60902), 59677));
		((Control)textBox_0).set_Size(new Size(100, 20));
		((Control)textBox_0).set_TabIndex(1028);
		((Control)hscrollBar_1).set_Location(new Point(177, 34));
		((Control)hscrollBar_1).set_Name(Class3.smethod_0(Class5.smethod_0("ᣪᣑᣡᣰᣭᣮᣮᣀᣣᣰᢰ", 61789), 59903));
		((Control)hscrollBar_1).set_Size(new Size(80, 17));
		((Control)hscrollBar_1).set_TabIndex(1029);
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(194, 196));
		((Control)comboBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᔁᔍᔏᔀᔍᔠᔍᔚᕓ", 62797), 57507));
		((Control)comboBox_0).set_Size(new Size(121, 21));
		((Control)comboBox_0).set_TabIndex(1030);
		((Control)hscrollBar_2).set_Location(new Point(58, 95));
		((Control)hscrollBar_2).set_Name(Class3.smethod_0(Class5.smethod_0("έὈὸὩὴίίὙὺὩἨ", 62192), 60745));
		((Control)hscrollBar_2).set_Size(new Size(80, 17));
		((Control)hscrollBar_2).set_TabIndex(1031);
		((Control)panel_1).set_Location(new Point(131, 67));
		((Control)panel_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u0f7dཬལཨཡ\u0f3f", 57542), 61352));
		((Control)panel_1).set_Size(new Size(200, 100));
		((Control)panel_1).set_TabIndex(1032);
		((Control)menuStrip_0).set_Location(new Point(117, 97));
		((Control)menuStrip_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᩅᩍᩆ\u1a5d\u1a7b\u1a5c\u1a5aᩁ\u1a58\u1a19", 62201), 59606));
		((Control)menuStrip_0).set_Size(new Size(284, 24));
		((Control)menuStrip_0).set_TabIndex(1033);
		((Control)menuStrip_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᩅᩍᩆ\u1a5d\u1a7b\u1a5c\u1a5aᩁ\u1a58\u1a19", 62201), 59606));
		((Control)dateTimePicker_1).set_Location(new Point(124, 163));
		((Control)dateTimePicker_1).set_Name(Class3.smethod_0(Class5.smethod_0("ǁǄǑǀǱǌǈǀǵǌǆǎǀǗƗ", 58723), 58370));
		((Control)dateTimePicker_1).set_Size(new Size(200, 20));
		((Control)dateTimePicker_1).set_TabIndex(1034);
		((Control)listView_0).set_Location(new Point(114, 37));
		((Control)listView_0).set_Name(Class3.smethod_0(Class5.smethod_0("ӟӚӀӇӥӚӖӄ҂", 59421), 60556));
		((Control)listView_0).set_Size(new Size(121, 97));
		((Control)listView_0).set_TabIndex(1035);
		listView_0.set_UseCompatibleStateImageBehavior(false);
		((Control)radioButton_0).set_AutoSize(true);
		((Control)radioButton_0).set_Location(new Point(178, 23));
		((Control)radioButton_0).set_Name(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((Control)radioButton_0).set_Size(new Size(85, 17));
		((Control)radioButton_0).set_TabIndex(1036);
		radioButton_0.set_TabStop(true);
		((Control)radioButton_0).set_Text(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((ButtonBase)radioButton_0).set_UseVisualStyleBackColor(true);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Location(new Point(93, 74));
		((Control)label_2).set_Name(Class3.smethod_0(Class5.smethod_0("Քՙ՚՝Քԋ", 59475), 60871));
		((Control)label_2).set_Size(new Size(35, 13));
		((Control)label_2).set_TabIndex(1037);
		((Control)label_2).set_Text(Class3.smethod_0(Class5.smethod_0("Քՙ՚՝Քԋ", 59475), 60871));
	}
}
