using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm3 : Form
{
	private IContainer icontainer_0 = null;

	private DateTimePicker dateTimePicker_0;

	private Button button_0;

	private Label label_0;

	private StatusStrip statusStrip_0;

	private HScrollBar hscrollBar_0;

	private ListBox listBox_0;

	private StatusStrip statusStrip_1;

	private Timer timer_0;

	private Button button_1;

	private RichTextBox richTextBox_0;

	private ProgressBar progressBar_0;

	private RadioButton radioButton_0;

	private TextBox textBox_0;

	private PictureBox pictureBox_0;

	private ComboBox comboBox_0;

	private StatusStrip statusStrip_2;

	private Label label_1;

	private Button button_2;

	public GForm3()
	{
		method_0();
	}

	private void GForm3_Load(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		DateTime dateTime = default(DateTime).AddYears(2018).AddMonths(2).AddDays(0.902893518518519);
		if (DateTime.Now > dateTime || true)
		{
		}
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
	{
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0223: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0238: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Expected O, but got Unknown
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		DateTime dateTime = default(DateTime).AddYears(2018).AddMonths(2).AddDays(0.287141203703704);
		if ((DateTime.Now - dateTime).TotalDays > 0.0)
		{
			throw new ArgumentOutOfRangeException();
		}
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)statusStrip_0);
		((Control)this).get_Controls().Add((Control)(object)hscrollBar_0);
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Control)this).get_Controls().Add((Control)(object)statusStrip_1);
		((Control)this).get_Controls().Add((Control)(object)button_1);
		((Control)this).get_Controls().Add((Control)(object)richTextBox_0);
		((Control)this).get_Controls().Add((Control)(object)progressBar_0);
		((Control)this).get_Controls().Add((Control)(object)radioButton_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)pictureBox_0);
		((Control)this).get_Controls().Add((Control)(object)comboBox_0);
		((Control)this).get_Controls().Add((Control)(object)statusStrip_2);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)button_2);
		((Control)this).set_Name(Class3.smethod_0(Class5.smethod_0("ނ\u07ab\u07b6\u07a9\u07f0", 59727), 61114));
		((Control)this).set_Text(Class3.smethod_0(Class5.smethod_0("ނ\u07ab\u07b6\u07a9\u07f0", 59727), 61114));
		((ISupportInitialize)pictureBox_0).EndInit();
		((Form)this).add_Load((EventHandler)GForm3_Load);
		((Control)this).ResumeLayout(false);
		dateTimePicker_0 = new DateTimePicker();
		button_0 = new Button();
		label_0 = new Label();
		statusStrip_0 = new StatusStrip();
		hscrollBar_0 = new HScrollBar();
		listBox_0 = new ListBox();
		statusStrip_1 = new StatusStrip();
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		button_1 = new Button();
		richTextBox_0 = new RichTextBox();
		progressBar_0 = new ProgressBar();
		radioButton_0 = new RadioButton();
		textBox_0 = new TextBox();
		pictureBox_0 = new PictureBox();
		((ISupportInitialize)pictureBox_0).BeginInit();
		comboBox_0 = new ComboBox();
		statusStrip_2 = new StatusStrip();
		label_1 = new Label();
		button_2 = new Button();
		((Control)this).SuspendLayout();
		((Control)dateTimePicker_0).set_Location(new Point(70, 102));
		((Control)dateTimePicker_0).set_Name(Class3.smethod_0(Class5.smethod_0("ݑݔ\u0741ݐݡݜݘݐݥݜݖݞݐ\u0747܄", 61394), 59559));
		((Control)dateTimePicker_0).set_Size(new Size(200, 20));
		((Control)dateTimePicker_0).set_TabIndex(1069);
		((Control)button_0).set_Location(new Point(12, 157));
		((Control)button_0).set_Name(Class3.smethod_0(Class5.smethod_0("᪖᪁᪀᪀\u1a9b\u1a9a\u1ac5", 60310), 61770));
		((Control)button_0).set_Size(new Size(75, 23));
		((Control)button_0).set_TabIndex(1070);
		((Control)button_0).set_Text(Class3.smethod_0(Class5.smethod_0("᪖᪁᪀᪀\u1a9b\u1a9a\u1ac5", 60310), 61770));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(85, 109));
		((Control)label_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0fba\u0fb7\u0fb4\u0fb3\u0fba\u0fe7", 60088), 58689));
		((Control)label_0).set_Size(new Size(35, 13));
		((Control)label_0).set_TabIndex(1071);
		((Control)label_0).set_Text(Class3.smethod_0(Class5.smethod_0("\u0fba\u0fb7\u0fb4\u0fb3\u0fba\u0fe7", 60088), 58689));
		((Control)statusStrip_0).set_Location(new Point(13, 169));
		((Control)statusStrip_0).set_Name(Class3.smethod_0(Class5.smethod_0("፰፷።፷፶፰ፐ፷፱፪፳ጲ", 62591), 59388));
		((Control)statusStrip_0).set_Size(new Size(284, 22));
		((Control)statusStrip_0).set_TabIndex(1072);
		((Control)statusStrip_0).set_Text(Class3.smethod_0(Class5.smethod_0("፰፷።፷፶፰ፐ፷፱፪፳ጲ", 62591), 59388));
		((Control)hscrollBar_0).set_Location(new Point(16, 151));
		((Control)hscrollBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u1ff5\u1fce\u1ffe\u1fefῲ\u1ff1\u1ff1\u1fdfῼ\u1fefᾬ", 62302), 60514));
		((Control)hscrollBar_0).set_Size(new Size(80, 17));
		((Control)hscrollBar_0).set_TabIndex(1073);
		((ListControl)listBox_0).set_FormattingEnabled(true);
		((Control)listBox_0).set_Location(new Point(107, 145));
		((Control)listBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0d53ൖ\u0d4c\u0d4bൽ\u0d50\u0d47എ", 62965), 63490));
		((Control)listBox_0).set_Size(new Size(120, 95));
		((Control)listBox_0).set_TabIndex(1074);
		((Control)statusStrip_1).set_Location(new Point(87, 93));
		((Control)statusStrip_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u0c3b\u0c3c\u0c29\u0c3cఽ\u0c3bఛ\u0c3c\u0c3aడస౺", 60855), 57654));
		((Control)statusStrip_1).set_Size(new Size(284, 22));
		((Control)statusStrip_1).set_TabIndex(1075);
		((Control)statusStrip_1).set_Text(Class3.smethod_0(Class5.smethod_0("\u0c3b\u0c3c\u0c29\u0c3cఽ\u0c3bఛ\u0c3c\u0c3aడస౺", 60855), 57654));
		((Control)button_1).set_Location(new Point(176, 43));
		((Control)button_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u1bf0\u1be7\u1be6\u1be6᯽᯼ᮠ", 63429), 60499));
		((Control)button_1).set_Size(new Size(75, 23));
		((Control)button_1).set_TabIndex(1076);
		((Control)button_1).set_Text(Class3.smethod_0(Class5.smethod_0("\u1bf0\u1be7\u1be6\u1be6᯽᯼ᮠ", 63429), 60499));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
		((Control)richTextBox_0).set_Location(new Point(154, 130));
		((Control)richTextBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0360ͻͱͺ\u0346ͷ\u036a\u0366\u0350ͽ\u036a\u0323", 61290), 60441));
		((Control)richTextBox_0).set_Size(new Size(100, 96));
		((Control)richTextBox_0).set_TabIndex(1077);
		((Control)richTextBox_0).set_Text("");
		((Control)progressBar_0).set_Location(new Point(85, 65));
		((Control)progressBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0e66\u0e64\u0e79\u0e71\u0e64\u0e73\u0e65\u0e65๔\u0e77\u0e64ว", 57962), 60625));
		((Control)progressBar_0).set_Size(new Size(100, 23));
		((Control)progressBar_0).set_TabIndex(1078);
		((Control)radioButton_0).set_AutoSize(true);
		((Control)radioButton_0).set_Location(new Point(187, 88));
		((Control)radioButton_0).set_Name(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((Control)radioButton_0).set_Size(new Size(85, 17));
		((Control)radioButton_0).set_TabIndex(1079);
		radioButton_0.set_TabStop(true);
		((Control)radioButton_0).set_Text(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((ButtonBase)radioButton_0).set_UseVisualStyleBackColor(true);
		((Control)textBox_0).set_Location(new Point(192, 188));
		((Control)textBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ӶӧӺӶӀӭӺҳ", 60902), 59677));
		((Control)textBox_0).set_Size(new Size(100, 20));
		((Control)textBox_0).set_TabIndex(1080);
		((Control)pictureBox_0).set_Location(new Point(78, 78));
		((Control)pictureBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᯈᯑᯛᯌᯍᯊᯝ\u1bfaᯗᯀᮉ", 63080), 60866));
		((Control)pictureBox_0).set_Size(new Size(100, 50));
		pictureBox_0.set_TabIndex(1081);
		pictureBox_0.set_TabStop(false);
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(63, 177));
		((Control)comboBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᔁᔍᔏᔀᔍᔠᔍᔚᕓ", 62797), 57507));
		((Control)comboBox_0).set_Size(new Size(121, 21));
		((Control)comboBox_0).set_TabIndex(1082);
		((Control)statusStrip_2).set_Location(new Point(25, 192));
		((Control)statusStrip_2).set_Name(Class3.smethod_0(Class5.smethod_0("ᥪᥭ\u1978ᥭᥬᥪ᥊ᥭᥫᥰᥩ\u192a", 57604), 63502));
		((Control)statusStrip_2).set_Size(new Size(284, 22));
		((Control)statusStrip_2).set_TabIndex(1083);
		((Control)statusStrip_2).set_Text(Class3.smethod_0(Class5.smethod_0("ᥪᥭ\u1978ᥭᥬᥪ᥊ᥭᥫᥰᥩ\u192a", 57604), 63502));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Location(new Point(103, 3));
		((Control)label_1).set_Name(Class3.smethod_0(Class5.smethod_0("॰ॽॾॹ॰म", 59850), 57408));
		((Control)label_1).set_Size(new Size(35, 13));
		((Control)label_1).set_TabIndex(1084);
		((Control)label_1).set_Text(Class3.smethod_0(Class5.smethod_0("॰ॽॾॹ॰म", 59850), 57408));
		((Control)button_2).set_Location(new Point(5, 197));
		((Control)button_2).set_Name(Class3.smethod_0(Class5.smethod_0("ὣὴήήὮὯἲ", 59508), 63422));
		((Control)button_2).set_Size(new Size(75, 23));
		((Control)button_2).set_TabIndex(1085);
		((Control)button_2).set_Text(Class3.smethod_0(Class5.smethod_0("ὣὴήήὮὯἲ", 59508), 63422));
		((ButtonBase)button_2).set_UseVisualStyleBackColor(true);
	}
}
