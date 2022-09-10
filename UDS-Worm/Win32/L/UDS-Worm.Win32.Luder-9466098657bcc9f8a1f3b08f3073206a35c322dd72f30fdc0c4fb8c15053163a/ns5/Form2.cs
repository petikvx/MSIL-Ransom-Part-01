using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns1;
using ns3;
using ns4;

namespace ns5;

[GAttribute0(42)]
internal sealed class Form2 : Form
{
	private GEventArgs2 geventArgs2_0 = null;

	private GControl2 gcontrol2_0 = new GControl2();

	private Button button_0 = new Button();

	private Button button_1 = new Button();

	private GControl1 gcontrol1_0 = new GControl1(string.Format("ほ⁽瑡整灭整\u2064潴瀠牥潦浲愠\u206e灯牥瑡潩\u206e潮⁴污潬敷\u2064祢琠敨猠捥牵瑩⁹潰楬祣", "整瑳"));

	private GClass1 gclass1_0 = new GClass1();

	private void method_0()
	{
		((Control)this).SuspendLayout();
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(100, 24));
		((Control)button_1).set_Location(new Point(408 - ((Control)button_1).get_Width(), 188));
		((Control)button_1).set_TabIndex(0);
		((Control)button_1).set_Text("儦極");
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(100, 24));
		((Control)button_0).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_0).get_Width() - 6, 188));
		((Control)button_0).set_TabIndex(1);
		((Control)button_0).set_Text("䌦湯楴畮");
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)gcontrol2_0).set_Anchor((AnchorStyles)6);
		((Control)gcontrol2_0).SetBounds(6, 186, 120, 32);
		gcontrol1_0.method_0(GEnum0.const_2);
		((Control)gclass1_0).set_Anchor((AnchorStyles)13);
		((Control)gclass1_0).set_Location(new Point(20, 72));
		((Control)gclass1_0).set_Size(new Size(382, 13));
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(418, 224));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			gcontrol2_0,
			(Control)button_0,
			(Control)button_1,
			gcontrol1_0,
			(Control)gclass1_0
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		geventArgs2_0.method_4(bool_3: true);
		((Form)this).Close();
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		geventArgs2_0.method_4(bool_3: false);
		((Form)this).Close();
	}

	public Form2(GEventArgs2 geventArgs2_1)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		method_0();
		((Form)this).set_Icon(GClass4.smethod_0());
		((Control)this).set_Text("整瑳");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("敓畣楲祴攠牲牯");
		}
		geventArgs2_0 = geventArgs2_1;
		if (!geventArgs2_1.method_2())
		{
			((Control)button_0).set_Visible(false);
		}
		if (geventArgs2_1.method_1().Length > 0)
		{
			((Control)gclass1_0).set_Text(geventArgs2_1.method_1());
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("ほ⁽瑡整灭整\u2064潴瀠牥潦浲愠\u206e灯牥瑡潩\u206e潮⁴污潬敷\u2064祢琠敨猠捥牵瑩⁹潰楬祣\u202e潔朠慲瑮琠楨\u2073灡汰捩瑡潩\u206e桴\u2065敲畱物摥瀠牥業獳潩Ɱ挠湯慴瑣礠畯\u2072祳瑳浥愠浤湩獩牴瑡牯\u202c牯甠敳琠敨䴠捩潲潳瑦⸠䕎\u2054牆浡睥牯\u206b潃普杩牵瑡潩\u206e潴汯ਮ", "整瑳"));
			if (geventArgs2_1.method_2())
			{
				stringBuilder.Append("晉礠畯挠楬正䌠湯楴畮ⱥ琠敨愠灰楬慣楴湯眠汩\u206c杩潮敲琠楨\u2073牥潲\u2072湡\u2064瑡整灭⁴潴挠湯楴畮\u2e65䤠\u2066潹⁵汣捩\u206b畑瑩\u202c桴\u2065灡汰捩瑡潩\u206e楷汬挠潬敳椠浭摥慩整祬ਮ");
			}
			stringBuilder.Append(geventArgs2_1.method_0().Message);
			((Control)gclass1_0).set_Text(stringBuilder.ToString());
		}
		int num = ((Control)gclass1_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}
}
