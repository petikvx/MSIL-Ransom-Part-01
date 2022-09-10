using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns2;
using ns3;
using ns4;

namespace ns5;

[GAttribute0(41)]
internal sealed class Form1 : Form
{
	private GClass2 gclass2_0 = null;

	private GEventArgs1 geventArgs1_0 = null;

	private Thread thread_0 = null;

	private CheckBox checkBox_0 = new CheckBox();

	private Label label_0 = new Label();

	private Button button_0 = new Button();

	private Button button_1 = new Button();

	private Label label_1 = new Label();

	private GClass1 gclass1_0 = new GClass1();

	private Panel panel_0 = new Panel();

	private Panel panel_1 = new Panel();

	private Button button_2 = new Button();

	private GControl3 gcontrol3_0 = new GControl3();

	private GControl0 gcontrol0_0 = new GControl0("牐灥牡湩\u2067桴\u2065牥潲\u2072敲潰瑲");

	private GControl0 gcontrol0_1 = new GControl0("潃湮捥楴杮琠\u206f敳癲牥");

	private GControl0 gcontrol0_2 = new GControl0("牔湡晳牥楲杮爠灥牯\u2e74");

	private GControl0 gcontrol0_3 = new GControl0("牅潲\u2072敲潰瑲湩\u2067潣灭敬整\u2e64吠慨歮礠畯");

	private Button button_3 = new Button();

	private Button button_4 = new Button();

	private GControl1 gcontrol1_0 = new GControl1(string.Format("ほ⁽慨\u2073湥潣湵整敲\u2064\u2061牰扯敬\u2e6d圊\u2065牡\u2065潳牲⁹潦\u2072桴\u2065湩潣癮湥敩据\u2e65", "整瑳"));

	private GControl1 gcontrol1_1 = new GControl1(string.Format("汐慥敳眠楡⁴桷汩\u2065ほ⁽獩猠湥楤杮琠敨爠灥牯⁴潴笠紱琠牨畯桧琠敨䤠瑮牥敮\u2e74", "整瑳", "啛歮潮湷䌠浯慰祮"));

	private GControl2 gcontrol2_0 = new GControl2();

	private Button button_5 = new Button();

	private void method_0()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		((Control)this).SuspendLayout();
		gcontrol1_0.method_0(GEnum0.const_1);
		gcontrol1_1.method_0(GEnum0.const_1);
		((Control)checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)checkBox_0).set_Location(new Point(22, 98));
		((Control)checkBox_0).set_Size(new Size(226, 16));
		((Control)checkBox_0).set_TabIndex(13);
		((Control)checkBox_0).set_Text("杉潮敲琠楨\u2073牥潲\u2072湡\u2064瑡整灭⁴潴☠潣瑮湩敵");
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)label_0).set_Anchor((AnchorStyles)14);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Font(new Font("楍牣獯景⁴慓獮匠牥晩", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(20, 124));
		((Control)label_0).set_Size(new Size(381, 16));
		((Control)label_0).set_Text(string.Format("汐慥敳琠汥\u206cほ⁽扡畯⁴桴獩瀠潲汢浥", "啛歮潮湷䌠浯慰祮"));
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(75, 24));
		((Control)button_0).set_Location(new Point(400 - ((Control)button_0).get_Width(), 205));
		((Control)button_0).set_TabIndex(4);
		((Control)button_0).set_Text("䐦湯琧匠湥");
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(105, 24));
		((Control)button_1).set_Location(new Point(((Control)button_0).get_Left() - ((Control)button_1).get_Width() - 6, 205));
		((Control)button_1).set_TabIndex(3);
		((Control)button_1).set_Text("匦湥\u2064牅潲\u2072敒潰瑲");
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_5).set_FlatStyle((FlatStyle)3);
		((Control)button_5).set_Size(new Size(64, 24));
		((Control)button_5).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_5).get_Width() - 6, 205));
		((Control)button_5).set_TabIndex(14);
		((Control)button_5).set_Text("敄戦杵");
		((Control)button_5).set_Visible(false);
		((Control)button_5).add_Click((EventHandler)button_5_Click);
		((Control)label_1).set_Anchor((AnchorStyles)14);
		label_1.set_FlatStyle((FlatStyle)3);
		((Control)label_1).set_Location(new Point(20, 140));
		((Control)label_1).set_Size(new Size(381, 55));
		((Control)label_1).set_Text(string.Format("潔栠汥⁰浩牰癯\u2065桴\u2065潳瑦慷敲礠畯甠敳\u202cほ⁽獩椠瑮牥獥整\u2064湩氠慥湲湩\u2067潭敲愠潢瑵琠楨\u2073牥潲\u2e72圠\u2065慨敶挠敲瑡摥愠爠灥牯⁴扡畯⁴桴\u2065牥潲\u2072潦\u2072潹⁵潴猠湥\u2064潴甠\u2e73", "啛歮潮湷䌠浯慰祮"));
		((Control)gclass1_0).set_Anchor((AnchorStyles)13);
		((Control)gclass1_0).set_Location(new Point(20, 69));
		((Control)gclass1_0).set_Size(new Size(381, 13));
		((Control)button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)3);
		((Control)button_2).set_Size(new Size(80, 24));
		((Control)button_2).set_Location(new Point(400 - ((Control)button_2).get_Width(), 205));
		((Control)button_2).set_TabIndex(7);
		((Control)button_2).set_Text("䌦湡散");
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)button_3).set_Anchor((AnchorStyles)10);
		((Control)button_3).set_Enabled(false);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)3);
		((Control)button_3).set_Size(new Size(80, 24));
		((Control)button_3).set_Location(new Point(((Control)button_2).get_Left() - ((Control)button_3).get_Width() - 6, 205));
		((Control)button_3).set_TabIndex(6);
		((Control)button_3).set_Text("伦");
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_4).set_FlatStyle((FlatStyle)3);
		((Control)button_4).set_Location(((Control)button_3).get_Location());
		((Control)button_4).set_Size(((Control)button_3).get_Size());
		((Control)button_4).set_TabIndex(5);
		((Control)button_4).set_Text("刦瑥祲");
		((Control)button_4).set_Visible(false);
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		((Control)gcontrol3_0).set_Location(new Point(87, 146));
		((Control)gcontrol3_0).set_Visible(false);
		((Control)gcontrol0_0).SetBounds(24, 72, 368, 16);
		((Control)gcontrol0_1).SetBounds(24, 96, 368, 16);
		((Control)gcontrol0_2).SetBounds(24, 120, 368, 16);
		((Control)gcontrol0_3).SetBounds(24, 144, 368, 16);
		((Control)gcontrol2_0).set_Anchor((AnchorStyles)6);
		((Control)gcontrol2_0).SetBounds(6, 450, 120, 32);
		((Control)panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)button_5,
			(Control)checkBox_0,
			(Control)label_0,
			(Control)button_0,
			(Control)button_1,
			(Control)label_1,
			(Control)gclass1_0,
			gcontrol1_0
		});
		((Control)panel_0).set_Size(new Size(413, 240));
		((Control)panel_0).set_TabIndex(0);
		((Control)panel_1).get_Controls().AddRange((Control[])(object)new Control[9]
		{
			(Control)button_2,
			(Control)button_3,
			(Control)button_4,
			gcontrol3_0,
			gcontrol1_1,
			gcontrol0_0,
			gcontrol0_1,
			gcontrol0_2,
			gcontrol0_3
		});
		((Control)panel_1).set_Size(new Size(413, 240));
		((Control)panel_1).set_TabIndex(2);
		((Control)panel_1).set_Visible(false);
		((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)this).set_ClientSize(new Size(434, 488));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			gcontrol2_0,
			(Control)panel_0,
			(Control)panel_1
		});
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("整瑳");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("牅潲\u2072敒潰瑲湩");
		}
		((Form)this).set_TopMost(true);
		((Control)panel_0).ResumeLayout(false);
		((Control)panel_1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)button_4).BringToFront();
		((Form)this).set_Size(new Size(419, 264));
		((Control)panel_1).set_Dock((DockStyle)5);
		((Control)panel_0).set_Dock((DockStyle)5);
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			((Control)panel_1).set_Visible(true);
			((Control)gcontrol2_0).set_Visible(true);
			if (geventArgs1_0 != null)
			{
				method_1(method_6);
			}
		}
		catch
		{
		}
	}

	private void method_1(ThreadStart threadStart_0)
	{
		thread_0 = new Thread(threadStart_0);
		thread_0.Start();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		try
		{
			if (thread_0 != null)
			{
				thread_0.Abort();
			}
		}
		catch
		{
		}
		((Form)this).Close();
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		geventArgs1_0.method_8(checkBox_0.get_Checked());
	}

	private void method_2(object sender, GEventArgs3 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new GDelegate0(method_4), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_5), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (thread_0 != null && thread_0.IsAlive)
		{
			thread_0.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void method_4(object sender, GEventArgs3 e)
	{
		switch (e.method_0())
		{
		case GEnum1.const_0:
			if (e.method_1())
			{
				gcontrol0_0.method_3(e.method_2());
				((Control)button_4).set_Visible(true);
				((Control)button_4).Focus();
			}
			else
			{
				gcontrol0_0.method_1();
			}
			break;
		case GEnum1.const_1:
			if (e.method_1())
			{
				gcontrol0_1.method_3(e.method_2());
				((Control)button_4).set_Visible(true);
				((Control)button_4).Focus();
			}
			else
			{
				gcontrol0_0.method_2();
				gcontrol0_1.method_1();
			}
			break;
		case GEnum1.const_2:
			if (e.method_1())
			{
				((Control)gcontrol3_0).set_Visible(false);
				gcontrol0_2.method_3(e.method_2());
				((Control)button_4).set_Visible(true);
				((Control)button_4).Focus();
			}
			else
			{
				gcontrol0_1.method_2();
				gcontrol0_2.method_1();
				((Control)gcontrol3_0).set_Visible(true);
			}
			break;
		case GEnum1.const_3:
			((Control)gcontrol3_0).set_Visible(false);
			gcontrol0_2.method_2();
			gcontrol0_3.method_2();
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			((Control)button_2).set_Enabled(false);
			break;
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		((Control)button_4).set_Visible(false);
		gcontrol0_0.method_0();
		gcontrol0_1.method_0();
		gcontrol0_2.method_0();
		if (geventArgs1_0 != null)
		{
			method_1(method_6);
		}
	}

	private void method_6()
	{
		geventArgs1_0.method_10();
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		if (geventArgs1_0 != null)
		{
			method_1(geventArgs1_0.method_9);
		}
	}

	public Form1(GClass2 gclass2_1, GEventArgs1 geventArgs1_1)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		method_0();
		int height = ((Control)this).get_Height();
		geventArgs1_0 = geventArgs1_1;
		gclass2_0 = gclass2_1;
		((Control)gclass1_0).set_Text(geventArgs1_1.method_0().Message);
		height += ((Control)gclass1_0).get_Height() - ((Control)this).get_FontHeight();
		if (!geventArgs1_1.method_3())
		{
			((Control)checkBox_0).set_Visible(false);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (geventArgs1_1.method_1())
		{
			gclass2_1.method_0(method_3);
			((Control)button_5).set_Visible(true);
			if (((Control)button_5).get_Left() < ((Control)gcontrol2_0).get_Right())
			{
				((Control)gcontrol2_0).set_Visible(false);
			}
		}
		if (!geventArgs1_1.method_2())
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		gclass2_1.method_1(method_2);
	}
}
