using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GForm1 : Form
{
	private IContainer icontainer_0 = null;

	private Splitter splitter_0;

	private GroupBox groupBox_0;

	private Timer timer_0;

	private DomainUpDown domainUpDown_0;

	private StatusStrip statusStrip_0;

	private GroupBox groupBox_1;

	private DomainUpDown domainUpDown_1;

	private MenuStrip menuStrip_0;

	private RadioButton radioButton_0;

	private ToolStrip toolStrip_0;

	private Timer timer_1;

	private CheckBox checkBox_0;

	private ToolStrip toolStrip_1;

	private DateTimePicker dateTimePicker_0;

	private ProgressBar progressBar_0;

	private HScrollBar hscrollBar_0;

	public GForm1()
	{
		method_0();
	}

	private void GForm1_Load(object sender, EventArgs e)
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
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c5: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0245: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		DateTime dateTime = new DateTime(2019, 3, 1);
		if (dateTime < DateTime.Now || 1 == 0)
		{
			throw new InvalidOperationException();
		}
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)groupBox_0);
		((Control)groupBox_0).ResumeLayout(false);
		((Control)this).get_Controls().Add((Control)(object)statusStrip_0);
		((Control)this).get_Controls().Add((Control)(object)groupBox_1);
		((Control)groupBox_1).ResumeLayout(false);
		((Control)this).get_Controls().Add((Control)(object)menuStrip_0);
		((Form)this).set_MainMenuStrip(menuStrip_0);
		((Control)this).get_Controls().Add((Control)(object)radioButton_0);
		((Control)this).get_Controls().Add((Control)(object)toolStrip_0);
		((Control)this).get_Controls().Add((Control)(object)checkBox_0);
		((Control)this).get_Controls().Add((Control)(object)toolStrip_1);
		((Control)this).get_Controls().Add((Control)(object)progressBar_0);
		((Control)this).get_Controls().Add((Control)(object)hscrollBar_0);
		((Control)this).set_Name(Class3.smethod_0(Class5.smethod_0("\u0954ॽॠॿठ", 59637), 57807));
		((Control)this).set_Text(Class3.smethod_0(Class5.smethod_0("\u0954ॽॠॿठ", 59637), 57807));
		((Form)this).add_Load((EventHandler)GForm1_Load);
		((Control)this).ResumeLayout(false);
		splitter_0 = new Splitter();
		groupBox_0 = new GroupBox();
		icontainer_0 = new Container();
		timer_0 = new Timer(icontainer_0);
		domainUpDown_0 = new DomainUpDown();
		statusStrip_0 = new StatusStrip();
		groupBox_1 = new GroupBox();
		domainUpDown_1 = new DomainUpDown();
		menuStrip_0 = new MenuStrip();
		radioButton_0 = new RadioButton();
		toolStrip_0 = new ToolStrip();
		icontainer_0 = new Container();
		timer_1 = new Timer(icontainer_0);
		checkBox_0 = new CheckBox();
		toolStrip_1 = new ToolStrip();
		dateTimePicker_0 = new DateTimePicker();
		progressBar_0 = new ProgressBar();
		hscrollBar_0 = new HScrollBar();
		((Control)this).SuspendLayout();
		((Control)splitter_0).set_Location(new Point(127, 144));
		((Control)splitter_0).set_Name(Class3.smethod_0(Class5.smethod_0("ቱቲቮቫቶቶቧተሳ", 57450), 62025));
		((Control)splitter_0).set_Size(new Size(3, 68));
		((Control)splitter_0).set_TabIndex(1038);
		splitter_0.set_TabStop(false);
		((Control)groupBox_0).set_Location(new Point(137, 11));
		((Control)groupBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᏔᏁᏜᏆᏃᏱᏜᏋᎂ", 62286), 57580));
		((Control)groupBox_0).set_Size(new Size(200, 100));
		((Control)groupBox_0).set_TabIndex(1039);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᏔᏁᏜᏆᏃᏱᏜᏋᎂ", 62286), 57580));
		((Control)domainUpDown_0).set_Location(new Point(53, 76));
		((Control)domainUpDown_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᅴᅿᅽᅱᅹᅾᅅᅠᅔᅿᅧᅾᄡ", 62711), 58855));
		((Control)domainUpDown_0).set_Size(new Size(120, 20));
		((Control)domainUpDown_0).set_TabIndex(1040);
		((Control)domainUpDown_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᅴᅿᅽᅱᅹᅾᅅᅠᅔᅿᅧᅾᄡ", 62711), 58855));
		((Control)statusStrip_0).set_Location(new Point(138, 104));
		((Control)statusStrip_0).set_Name(Class3.smethod_0(Class5.smethod_0("፰፷።፷፶፰ፐ፷፱፪፳ጲ", 62591), 59388));
		((Control)statusStrip_0).set_Size(new Size(284, 22));
		((Control)statusStrip_0).set_TabIndex(1041);
		((Control)statusStrip_0).set_Text(Class3.smethod_0(Class5.smethod_0("፰፷።፷፶፰ፐ፷፱፪፳ጲ", 62591), 59388));
		((Control)groupBox_1).set_Location(new Point(42, 53));
		((Control)groupBox_1).set_Name(Class3.smethod_0(Class5.smethod_0("᭧\u1b72\u1b6f᭵\u1b70\u1b42\u1b6f᭸ᬲ", 62956), 61164));
		((Control)groupBox_1).set_Size(new Size(200, 100));
		((Control)groupBox_1).set_TabIndex(1042);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class3.smethod_0(Class5.smethod_0("᭧\u1b72\u1b6f᭵\u1b70\u1b42\u1b6f᭸ᬲ", 62956), 61164));
		((Control)domainUpDown_1).set_Location(new Point(129, 186));
		((Control)domainUpDown_1).set_Name(Class3.smethod_0(Class5.smethod_0("\u1b80ᮋᮉᮅᮍᮊ᮱ᮔᮠᮋᮓᮊᯖ", 62864), 60952));
		((Control)domainUpDown_1).set_Size(new Size(120, 20));
		((Control)domainUpDown_1).set_TabIndex(1043);
		((Control)domainUpDown_1).set_Text(Class3.smethod_0(Class5.smethod_0("\u1b80ᮋᮉᮅᮍᮊ᮱ᮔᮠᮋᮓᮊᯖ", 62864), 60952));
		((Control)menuStrip_0).set_Location(new Point(103, 75));
		((Control)menuStrip_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᩅᩍᩆ\u1a5d\u1a7b\u1a5c\u1a5aᩁ\u1a58\u1a19", 62201), 59606));
		((Control)menuStrip_0).set_Size(new Size(284, 24));
		((Control)menuStrip_0).set_TabIndex(1044);
		((Control)menuStrip_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᩅᩍᩆ\u1a5d\u1a7b\u1a5c\u1a5aᩁ\u1a58\u1a19", 62201), 59606));
		((Control)radioButton_0).set_AutoSize(true);
		((Control)radioButton_0).set_Location(new Point(130, 8));
		((Control)radioButton_0).set_Name(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((Control)radioButton_0).set_Size(new Size(85, 17));
		((Control)radioButton_0).set_TabIndex(1045);
		radioButton_0.set_TabStop(true);
		((Control)radioButton_0).set_Text(Class3.smethod_0(Class5.smethod_0("ዢዱዴዹዿዒዥዤዤዿዾኡ", 62332), 57761));
		((ButtonBase)radioButton_0).set_UseVisualStyleBackColor(true);
		((Control)toolStrip_0).set_Location(new Point(174, 67));
		((Control)toolStrip_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0c74౯౯౬\u0c53\u0c74\u0c72౩\u0c70ఱ", 58779), 59775));
		((Control)toolStrip_0).set_Size(new Size(284, 25));
		((Control)toolStrip_0).set_TabIndex(1046);
		((Control)toolStrip_0).set_Text(Class3.smethod_0(Class5.smethod_0("\u0c74౯౯౬\u0c53\u0c74\u0c72౩\u0c70ఱ", 58779), 59775));
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Location(new Point(195, 100));
		((Control)checkBox_0).set_Name(Class3.smethod_0(Class5.smethod_0("ᙩᙢᙯᙩᙡᙈᙥᙲᘻ", 58695), 62305));
		((Control)checkBox_0).set_Size(new Size(80, 17));
		((Control)checkBox_0).set_TabIndex(1047);
		((Control)checkBox_0).set_Text(Class3.smethod_0(Class5.smethod_0("ᙩᙢᙯᙩᙡᙈᙥᙲᘻ", 58695), 62305));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)toolStrip_1).set_Location(new Point(97, 82));
		((Control)toolStrip_1).set_Name(Class3.smethod_0(Class5.smethod_0("ٲ٩٩٪\u0655ٲٴٯٶش", 60617), 60061));
		((Control)toolStrip_1).set_Size(new Size(284, 25));
		((Control)toolStrip_1).set_TabIndex(1048);
		((Control)toolStrip_1).set_Text(Class3.smethod_0(Class5.smethod_0("ٲ٩٩٪\u0655ٲٴٯٶش", 60617), 60061));
		((Control)dateTimePicker_0).set_Location(new Point(169, 186));
		((Control)dateTimePicker_0).set_Name(Class3.smethod_0(Class5.smethod_0("ݑݔ\u0741ݐݡݜݘݐݥݜݖݞݐ\u0747܄", 61394), 59559));
		((Control)dateTimePicker_0).set_Size(new Size(200, 20));
		((Control)dateTimePicker_0).set_TabIndex(1049);
		((Control)progressBar_0).set_Location(new Point(178, 119));
		((Control)progressBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u0e66\u0e64\u0e79\u0e71\u0e64\u0e73\u0e65\u0e65๔\u0e77\u0e64ว", 57962), 60625));
		((Control)progressBar_0).set_Size(new Size(100, 23));
		((Control)progressBar_0).set_TabIndex(1050);
		((Control)hscrollBar_0).set_Location(new Point(114, 47));
		((Control)hscrollBar_0).set_Name(Class3.smethod_0(Class5.smethod_0("\u1ff5\u1fce\u1ffe\u1fefῲ\u1ff1\u1ff1\u1fdfῼ\u1fefᾬ", 62302), 60514));
		((Control)hscrollBar_0).set_Size(new Size(80, 17));
		((Control)hscrollBar_0).set_TabIndex(1051);
	}
}
