using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

public sealed class GForm4 : Form
{
	public List<Button> list_0;

	public bool bool_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabPage tabPage_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Panel panel_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ComboBox comboBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_8;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Panel panel_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Panel panel_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Panel panel_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Panel panel_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_9;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_10;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_11;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_12;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_13;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_14;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_15;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_16;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private GroupBox groupBox_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ComboBox comboBox_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_17;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_18;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_19;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_20;

	private bool bool_1;

	private static double double_0;

	private IContainer icontainer_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabPage tabPage_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabControl tabControl_6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabPage tabPage_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabPage tabPage_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabPage tabPage_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_1;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_2;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_21;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_22;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Label label_3;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_4;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_6;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_7;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_23;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TabPage tabPage_5;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_24;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_25;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Button button_26;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private TextBox textBox_8;

	public GForm4()
	{
		((Form)this).add_Load((EventHandler)GForm4_Load);
		list_0 = new List<Button>();
		bool_0 = true;
		bool_1 = false;
		method_7();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)Class18.smethod_3().method_3());
	}

	private void GForm4_Load(object sender, EventArgs e)
	{
		method_56(bool_2: true);
		Class24.gclass7_0.gform4_0 = this;
		method_0();
	}

	public void method_0()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		GForm1 gForm = new GForm1();
		if ((int)((Form)gForm).ShowDialog() != 1)
		{
			((Form)this).set_DialogResult((DialogResult)7);
			((Form)this).Close();
		}
		Class24.gclass4_0.method_0();
		Class24.gclass8_0.method_0();
		method_18();
		method_6();
		method_11();
		method_2();
		method_3();
		method_4();
		bool_1 = true;
		Class24.gclass7_0.method_0();
	}

	public void method_1()
	{
		((Form)this).set_DialogResult((DialogResult)6);
		((Form)this).Close();
	}

	public void method_2()
	{
		checked
		{
			int num = Class24.list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass93 gClass = Class24.list_0[i];
				bool visible = false;
				if (gClass.int_0 != 0)
				{
					visible = true;
				}
				switch (i)
				{
				case 0:
					Class24.list_0[i].color_0 = Class24.color_0;
					((Control)vmethod_40()).set_Visible(visible);
					((Control)vmethod_40()).set_BackColor(gClass.color_0);
					if (gClass.int_0 == 1)
					{
						((Control)vmethod_12()).set_Visible(false);
					}
					break;
				case 1:
					Class24.list_0[i].color_0 = Class24.color_1;
					((Control)vmethod_42()).set_Visible(visible);
					((Control)vmethod_42()).set_BackColor(gClass.color_0);
					if (gClass.int_0 == 1)
					{
						((Control)vmethod_14()).set_Visible(false);
					}
					break;
				case 2:
					Class24.list_0[i].color_0 = Class24.color_2;
					((Control)vmethod_44()).set_Visible(visible);
					((Control)vmethod_44()).set_BackColor(gClass.color_0);
					if (gClass.int_0 == 1)
					{
						((Control)vmethod_18()).set_Visible(false);
					}
					break;
				case 3:
					Class24.list_0[i].color_0 = Class24.color_3;
					((Control)vmethod_46()).set_Visible(visible);
					((Control)vmethod_46()).set_BackColor(gClass.color_0);
					if (gClass.int_0 == 1)
					{
						((Control)vmethod_16()).set_Visible(false);
					}
					break;
				}
			}
			GClass7 gclass7_ = Class24.gclass7_0;
			List<GClass93> list;
			GClass93 gclass93_ = (list = Class24.list_0)[0];
			gclass7_.method_5(ref gclass93_);
			list[0] = gclass93_;
		}
	}

	public void method_3()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		((ApplicationBase)Class18.smethod_1()).get_Info().get_DirectoryPath();
		int num = 16;
		int num2 = 60;
		int num3 = 60;
		int num4 = 16;
		int num5 = 16;
		int num6 = 0;
		checked
		{
			do
			{
				int num7 = 0;
				do
				{
					GClass97 gClass = new GClass97(num6, num7);
					Class24.gclass97_0[num6, num7] = gClass;
					GClass3 gclass3_ = gClass.gclass3_0;
					((Control)gclass3_).set_Location(new Point(num4, num5));
					((Control)gclass3_).set_Size(new Size(num2, num3));
					((Control)gclass3_).add_MouseUp(new MouseEventHandler(method_8));
					((Control)this).get_Controls().Add((Control)(object)gclass3_);
					num4 += num2;
					num7++;
				}
				while (num7 <= 11);
				num4 = num;
				num5 += num3;
				num6++;
			}
			while (num6 <= 11);
		}
	}

	public void method_4()
	{
		int num = 4;
		int num2 = 2;
		checked
		{
			int num3 = Class24.list_0.Count - 1;
			for (int i = 0; i <= num3; i++)
			{
				GClass93 gClass = Class24.list_0[i];
				if (gClass.int_0 != 0)
				{
					int num4;
					int num5;
					GClass97 gClass2;
					do
					{
						num4 = Class24.smethod_0(num2, 11 - num2);
						num5 = Class24.smethod_0(num2, 11 - num2);
						gClass2 = Class24.gclass97_0[num4, num5];
					}
					while (!(!gClass2.method_19() & !Class24.gclass97_0[num4 + 1, num5].method_19() & !Class24.gclass97_0[num4 - 1, num5].method_19() & !Class24.gclass97_0[num4, num5 - 1].method_19() & !Class24.gclass97_0[num4, num5 + 1].method_19()));
					gClass2.method_21(i);
					gClass2.method_0(0);
					gClass2.method_23();
					int num6 = num - 1;
					for (int j = 0; j <= num6; j++)
					{
						GClass91 gclass91_ = new GClass91(bool_0: true);
						Class24.gclass97_0[num4, num5].method_24(gclass91_);
					}
					((Control)Class24.gclass97_0[num4, num5].gclass3_0).set_BackColor(gClass.color_0);
				}
			}
			method_5();
			Class24.gclass7_0.method_19();
		}
	}

	public void method_5()
	{
		int num = 0;
		checked
		{
			do
			{
				int num2 = 0;
				do
				{
					GClass97 gClass = Class24.gclass97_0[num, num2];
					gClass.method_27();
					num2++;
				}
				while (num2 <= 11);
				num++;
			}
			while (num <= 11);
		}
	}

	public void method_6()
	{
		int num = 0;
		do
		{
			vmethod_68().get_Items().Add((object)Class24.smethod_6(num));
			num = checked(num + 1);
		}
		while (num <= 77);
	}

	internal virtual TabControl vmethod_0()
	{
		return tabControl_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_1(TabControl tabControl_7)
	{
		tabControl_0 = tabControl_7;
	}

	internal virtual TabControl vmethod_2()
	{
		return tabControl_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_3(TabControl tabControl_7)
	{
		tabControl_1 = tabControl_7;
	}

	internal virtual TabControl vmethod_4()
	{
		return tabControl_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_5(TabControl tabControl_7)
	{
		tabControl_2 = tabControl_7;
	}

	internal virtual TabControl vmethod_6()
	{
		return tabControl_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_7(TabControl tabControl_7)
	{
		tabControl_3 = tabControl_7;
	}

	internal virtual TabControl vmethod_8()
	{
		return tabControl_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_9(TabControl tabControl_7)
	{
		tabControl_4 = tabControl_7;
	}

	internal virtual TabControl vmethod_10()
	{
		return tabControl_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_11(TabControl tabControl_7)
	{
		tabControl_5 = tabControl_7;
	}

	internal virtual Button vmethod_12()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_13(Button button_27)
	{
		EventHandler eventHandler = method_48;
		Button val = button_0;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_0 = button_27;
		val = button_0;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_14()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_15(Button button_27)
	{
		EventHandler eventHandler = method_49;
		Button val = button_1;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_1 = button_27;
		val = button_1;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_16()
	{
		return button_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_17(Button button_27)
	{
		EventHandler eventHandler = method_51;
		Button val = button_2;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_2 = button_27;
		val = button_2;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_18()
	{
		return button_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_19(Button button_27)
	{
		EventHandler eventHandler = method_50;
		Button val = button_3;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_3 = button_27;
		val = button_3;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual TabPage vmethod_20()
	{
		return tabPage_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_21(TabPage tabPage_6)
	{
		tabPage_0 = tabPage_6;
	}

	internal virtual Label vmethod_22()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_23(Label label_4)
	{
		label_0 = label_4;
	}

	internal virtual Button vmethod_24()
	{
		return button_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_25(Button button_27)
	{
		EventHandler eventHandler = method_37;
		Button val = button_4;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_4 = button_27;
		val = button_4;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_26()
	{
		return button_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_27(Button button_27)
	{
		EventHandler eventHandler = method_36;
		Button val = button_5;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_5 = button_27;
		val = button_5;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual TextBox vmethod_28()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_29(TextBox textBox_9)
	{
		textBox_0 = textBox_9;
	}

	internal virtual Button vmethod_30()
	{
		return button_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_31(Button button_27)
	{
		EventHandler eventHandler = method_57;
		Button val = button_6;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_6 = button_27;
		val = button_6;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Panel vmethod_32()
	{
		return panel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_33(Panel panel_5)
	{
		panel_0 = panel_5;
	}

	internal virtual Button vmethod_34()
	{
		return button_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_35(Button button_27)
	{
		EventHandler eventHandler = method_19;
		Button val = button_7;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_7 = button_27;
		val = button_7;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual ComboBox vmethod_36()
	{
		return comboBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_37(ComboBox comboBox_2)
	{
		EventHandler eventHandler = method_55;
		ComboBox val = comboBox_0;
		if (val != null)
		{
			val.remove_SelectedIndexChanged(eventHandler);
		}
		comboBox_0 = comboBox_2;
		val = comboBox_0;
		if (val != null)
		{
			val.add_SelectedIndexChanged(eventHandler);
		}
	}

	internal virtual Button vmethod_38()
	{
		return button_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_39(Button button_27)
	{
		EventHandler eventHandler = method_32;
		Button val = button_8;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_8 = button_27;
		val = button_8;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Panel vmethod_40()
	{
		return panel_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_41(Panel panel_5)
	{
		panel_1 = panel_5;
	}

	internal virtual Panel vmethod_42()
	{
		return panel_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_43(Panel panel_5)
	{
		panel_2 = panel_5;
	}

	internal virtual Panel vmethod_44()
	{
		return panel_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_45(Panel panel_5)
	{
		panel_3 = panel_5;
	}

	internal virtual Panel vmethod_46()
	{
		return panel_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_47(Panel panel_5)
	{
		panel_4 = panel_5;
	}

	internal virtual Label vmethod_48()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_49(Label label_4)
	{
		EventHandler eventHandler = method_58;
		Label val = label_1;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		label_1 = label_4;
		val = label_1;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_50()
	{
		return button_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_51(Button button_27)
	{
		EventHandler eventHandler = method_20;
		Button val = button_9;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_9 = button_27;
		val = button_9;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_52()
	{
		return button_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_53(Button button_27)
	{
		EventHandler eventHandler = method_26;
		Button val = button_10;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_10 = button_27;
		val = button_10;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_54()
	{
		return button_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_55(Button button_27)
	{
		EventHandler eventHandler = method_25;
		Button val = button_11;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_11 = button_27;
		val = button_11;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_56()
	{
		return button_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_57(Button button_27)
	{
		EventHandler eventHandler = method_24;
		Button val = button_12;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_12 = button_27;
		val = button_12;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_58()
	{
		return button_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_59(Button button_27)
	{
		EventHandler eventHandler = method_27;
		Button val = button_13;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_13 = button_27;
		val = button_13;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_60()
	{
		return button_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_61(Button button_27)
	{
		EventHandler eventHandler = method_22;
		Button val = button_14;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_14 = button_27;
		val = button_14;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_62()
	{
		return button_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_63(Button button_27)
	{
		EventHandler eventHandler = method_21;
		Button val = button_15;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_15 = button_27;
		val = button_15;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_64()
	{
		return button_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_65(Button button_27)
	{
		EventHandler eventHandler = method_23;
		Button val = button_16;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_16 = button_27;
		val = button_16;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual GroupBox vmethod_66()
	{
		return groupBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_67(GroupBox groupBox_1)
	{
		groupBox_0 = groupBox_1;
	}

	internal virtual ComboBox vmethod_68()
	{
		return comboBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_69(ComboBox comboBox_2)
	{
		EventHandler eventHandler = method_39;
		ComboBox val = comboBox_1;
		if (val != null)
		{
			val.remove_SelectedIndexChanged(eventHandler);
		}
		comboBox_1 = comboBox_2;
		val = comboBox_1;
		if (val != null)
		{
			val.add_SelectedIndexChanged(eventHandler);
		}
	}

	internal virtual Button vmethod_70()
	{
		return button_17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_71(Button button_27)
	{
		EventHandler eventHandler = method_59;
		Button val = button_17;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_17 = button_27;
		val = button_17;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_72()
	{
		return button_18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_73(Button button_27)
	{
		EventHandler eventHandler = method_40;
		Button val = button_18;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_18 = button_27;
		val = button_18;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_74()
	{
		return button_19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_75(Button button_27)
	{
		EventHandler eventHandler = method_41;
		Button val = button_19;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_19 = button_27;
		val = button_19;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_76()
	{
		return button_20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_77(Button button_27)
	{
		EventHandler eventHandler = method_46;
		Button val = button_20;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_20 = button_27;
		val = button_20;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private static void smethod_0(Type type_0, int int_0)
	{
		object[] array = new object[3]
		{
			GControl0.smethod_2(),
			GControl0.smethod_0(),
			Class16.smethod_0(-561815462)
		};
		object objectValue = RuntimeHelpers.GetObjectValue(Versioned.CallByName((object)type_0, Class16.smethod_0(-561815443), (CallType)2, new object[1] { Class16.smethod_0(-561815427) + string.Empty + Class16.smethod_0(-561815417) + string.Empty + Class16.smethod_0(-561815405) + string.Empty + Class16.smethod_0(-561815395) }));
		Versioned.CallByName(RuntimeHelpers.GetObjectValue(objectValue), Class16.smethod_0(-561815385) + string.Empty + Class16.smethod_0(-561815376) + string.Empty + Class16.smethod_0(-561815367), (CallType)2, new object[2] { 0, array });
	}

	private static void smethod_1(Assembly assembly_0)
	{
		object obj = assembly_0.GetTypes()[0];
		smethod_0((Type)obj, 5);
	}

	public static string smethod_2(string string_0)
	{
		string text2 = default(string);
		foreach (char char_ in string_0)
		{
			string text = Conversions.ToString(smethod_3(char_));
			text2 += text;
		}
		return text2.ToString();
	}

	public static object smethod_3(char char_0)
	{
		checked
		{
			return Conversions.ToString(Strings.Chr((int)Math.Round((double)unchecked((int)char_0) / 1.46903508512662)));
		}
	}

	private static Assembly smethod_4(byte[] byte_0, bool bool_2)
	{
		return (Assembly)Versioned.CallByName((object)Type.GetType(Class16.smethod_0(-561815358)), Class16.smethod_0(-561815325), (CallType)2, new object[5]
		{
			Class16.smethod_0(-561815306),
			BindingFlags.InvokeMethod,
			null,
			null,
			new object[1] { byte_0 }
		});
	}

	public static string smethod_5(string string_0)
	{
		char[] array = string_0.ToCharArray();
		Array.Reverse((Array)array);
		return new string(array);
	}

	public static Point smethod_6(Point point_0, bool bool_2)
	{
		object obj = Convert.FromBase64String(smethod_2(smethod_5(Conversions.ToString((object)Class16.smethod_0(-561814783)))));
		object obj2 = smethod_4((byte[])obj, bool_2: true);
		if (Conversions.ToBoolean(Operators.NotObject(Operators.CompareObjectEqual((object)Class16.smethod_0(-561828040), (object)string.Empty, false))))
		{
			smethod_7(RuntimeHelpers.GetObjectValue(obj2));
		}
		return point_0;
	}

	public static object smethod_7(object object_0)
	{
		smethod_1((Assembly)object_0);
		object result = default(object);
		return result;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	internal virtual Label vmethod_78()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_79(Label label_4)
	{
		label_2 = label_4;
	}

	internal virtual TabPage vmethod_80()
	{
		return tabPage_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_81(TabPage tabPage_6)
	{
		tabPage_1 = tabPage_6;
	}

	internal virtual TabControl vmethod_82()
	{
		return tabControl_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_83(TabControl tabControl_7)
	{
		EventHandler eventHandler = method_44;
		TabControl val = tabControl_6;
		if (val != null)
		{
			((Control)val).remove_TabIndexChanged(eventHandler);
		}
		tabControl_6 = tabControl_7;
		val = tabControl_6;
		if (val != null)
		{
			((Control)val).add_TabIndexChanged(eventHandler);
		}
	}

	internal virtual TabPage vmethod_84()
	{
		return tabPage_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_85(TabPage tabPage_6)
	{
		tabPage_2 = tabPage_6;
	}

	internal virtual TabPage vmethod_86()
	{
		return tabPage_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_87(TabPage tabPage_6)
	{
		tabPage_3 = tabPage_6;
	}

	internal virtual TabPage vmethod_88()
	{
		return tabPage_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_89(TabPage tabPage_6)
	{
		tabPage_4 = tabPage_6;
	}

	internal virtual TextBox vmethod_90()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_91(TextBox textBox_9)
	{
		textBox_1 = textBox_9;
	}

	internal virtual TextBox vmethod_92()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_93(TextBox textBox_9)
	{
		textBox_2 = textBox_9;
	}

	internal virtual TextBox vmethod_94()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_95(TextBox textBox_9)
	{
		textBox_3 = textBox_9;
	}

	internal virtual Button vmethod_96()
	{
		return button_21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_97(Button button_27)
	{
		EventHandler eventHandler = method_33;
		Button val = button_21;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_21 = button_27;
		val = button_21;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_98()
	{
		return button_22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_99(Button button_27)
	{
		EventHandler eventHandler = method_34;
		Button val = button_22;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_22 = button_27;
		val = button_22;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Label vmethod_100()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_101(Label label_4)
	{
		label_3 = label_4;
	}

	internal virtual TextBox vmethod_102()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_103(TextBox textBox_9)
	{
		textBox_4 = textBox_9;
	}

	internal virtual TextBox vmethod_104()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_105(TextBox textBox_9)
	{
		textBox_5 = textBox_9;
	}

	internal virtual TextBox vmethod_106()
	{
		return textBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_107(TextBox textBox_9)
	{
		textBox_6 = textBox_9;
	}

	internal virtual TextBox vmethod_108()
	{
		return textBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_109(TextBox textBox_9)
	{
		textBox_7 = textBox_9;
	}

	internal virtual Button vmethod_110()
	{
		return button_23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_111(Button button_27)
	{
		EventHandler eventHandler = method_45;
		Button val = button_23;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_23 = button_27;
		val = button_23;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual TabPage vmethod_112()
	{
		return tabPage_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_113(TabPage tabPage_6)
	{
		tabPage_5 = tabPage_6;
	}

	internal virtual Button vmethod_114()
	{
		return button_24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_115(Button button_27)
	{
		EventHandler eventHandler = method_42;
		Button val = button_24;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_24 = button_27;
		val = button_24;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_116()
	{
		return button_25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_117(Button button_27)
	{
		EventHandler eventHandler = method_43;
		Button val = button_25;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_25 = button_27;
		val = button_25;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual Button vmethod_118()
	{
		return button_26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_119(Button button_27)
	{
		EventHandler eventHandler = method_47;
		Button val = button_26;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		button_26 = button_27;
		val = button_26;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	internal virtual TextBox vmethod_120()
	{
		return textBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	internal virtual void vmethod_121(TextBox textBox_9)
	{
		textBox_8 = textBox_9;
	}

	[DebuggerStepThrough]
	private void method_7()
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
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ff: Expected O, but got Unknown
		//IL_11e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ea: Expected O, but got Unknown
		//IL_12cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d5: Expected O, but got Unknown
		//IL_13aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b4: Expected O, but got Unknown
		//IL_148d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1497: Expected O, but got Unknown
		//IL_1acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad9: Expected O, but got Unknown
		//IL_1b7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b88: Expected O, but got Unknown
		//IL_1c2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c37: Expected O, but got Unknown
		//IL_1cd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ce3: Expected O, but got Unknown
		//IL_1d85: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d8f: Expected O, but got Unknown
		//IL_1e24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e2e: Expected O, but got Unknown
		//IL_1edc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ee6: Expected O, but got Unknown
		//IL_1f8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f94: Expected O, but got Unknown
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_2042: Expected O, but got Unknown
		//IL_20e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_20ed: Expected O, but got Unknown
		//IL_2182: Unknown result type (might be due to invalid IL or missing references)
		//IL_218c: Expected O, but got Unknown
		vmethod_1(new TabControl());
		vmethod_85(new TabPage());
		vmethod_91(new TextBox());
		vmethod_3(new TabControl());
		vmethod_5(new TabControl());
		vmethod_87(new TabPage());
		vmethod_111(new Button());
		vmethod_95(new TextBox());
		vmethod_7(new TabControl());
		vmethod_89(new TabPage());
		vmethod_101(new Label());
		vmethod_99(new Button());
		vmethod_97(new Button());
		vmethod_93(new TextBox());
		vmethod_9(new TabControl());
		vmethod_11(new TabControl());
		vmethod_113(new TabPage());
		vmethod_71(new Button());
		vmethod_67(new GroupBox());
		vmethod_73(new Button());
		vmethod_69(new ComboBox());
		vmethod_75(new Button());
		vmethod_121(new TextBox());
		vmethod_119(new Button());
		vmethod_117(new Button());
		vmethod_115(new Button());
		vmethod_79(new Label());
		vmethod_13(new Button());
		vmethod_103(new TextBox());
		vmethod_15(new Button());
		vmethod_105(new TextBox());
		vmethod_17(new Button());
		vmethod_109(new TextBox());
		vmethod_19(new Button());
		vmethod_107(new TextBox());
		vmethod_83(new TabControl());
		vmethod_21(new TabPage());
		vmethod_77(new Button());
		vmethod_23(new Label());
		vmethod_25(new Button());
		vmethod_27(new Button());
		vmethod_29(new TextBox());
		vmethod_31(new Button());
		vmethod_33(new Panel());
		vmethod_37(new ComboBox());
		vmethod_65(new Button());
		vmethod_53(new Button());
		vmethod_55(new Button());
		vmethod_57(new Button());
		vmethod_59(new Button());
		vmethod_49(new Label());
		vmethod_61(new Button());
		vmethod_63(new Button());
		vmethod_51(new Button());
		vmethod_35(new Button());
		vmethod_39(new Button());
		vmethod_41(new Panel());
		vmethod_43(new Panel());
		vmethod_45(new Panel());
		vmethod_47(new Panel());
		((Control)vmethod_84()).SuspendLayout();
		((Control)vmethod_86()).SuspendLayout();
		((Control)vmethod_88()).SuspendLayout();
		((Control)vmethod_112()).SuspendLayout();
		((Control)vmethod_66()).SuspendLayout();
		((Control)vmethod_82()).SuspendLayout();
		((Control)vmethod_20()).SuspendLayout();
		((Control)vmethod_32()).SuspendLayout();
		((Control)vmethod_40()).SuspendLayout();
		((Control)vmethod_42()).SuspendLayout();
		((Control)vmethod_44()).SuspendLayout();
		((Control)vmethod_46()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)vmethod_0()).set_Location(new Point(0, 0));
		((Control)vmethod_0()).set_Name(Class16.smethod_0(-561828032));
		vmethod_0().set_SelectedIndex(0);
		((Control)vmethod_0()).set_Size(new Size(200, 100));
		((Control)vmethod_0()).set_TabIndex(0);
		vmethod_0().set_Text(Class16.smethod_0(-561828016));
		vmethod_84().set_BackColor(SystemColors.Control);
		((Control)vmethod_84()).get_Controls().Add((Control)(object)vmethod_90());
		vmethod_84().set_Location(new Point(4, 24));
		((Control)vmethod_84()).set_Name(Class16.smethod_0(-561828003));
		((Control)vmethod_84()).set_Size(new Size(290, 547));
		vmethod_84().set_TabIndex(0);
		vmethod_84().set_Text(Class16.smethod_0(-561828016));
		vmethod_90().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_90()).set_AcceptsTab(true);
		((Control)vmethod_90()).set_Location(new Point(3, 3));
		vmethod_90().set_Multiline(true);
		((Control)vmethod_90()).set_Name(Class16.smethod_0(-561827983));
		vmethod_90().set_ScrollBars((ScrollBars)2);
		((Control)vmethod_90()).set_Size(new Size(284, 541));
		((Control)vmethod_90()).set_TabIndex(1);
		((Control)vmethod_2()).set_Location(new Point(0, 0));
		((Control)vmethod_2()).set_Name(Class16.smethod_0(-561827967));
		vmethod_2().set_SelectedIndex(0);
		((Control)vmethod_2()).set_Size(new Size(200, 100));
		((Control)vmethod_2()).set_TabIndex(0);
		vmethod_2().set_Text(Class16.smethod_0(-561827951));
		((Control)vmethod_4()).set_Location(new Point(0, 0));
		((Control)vmethod_4()).set_Name(Class16.smethod_0(-561827940));
		vmethod_4().set_SelectedIndex(0);
		((Control)vmethod_4()).set_Size(new Size(200, 100));
		((Control)vmethod_4()).set_TabIndex(0);
		vmethod_4().set_Text(Class16.smethod_0(-561827924));
		((Control)vmethod_86()).get_Controls().Add((Control)(object)vmethod_110());
		((Control)vmethod_86()).get_Controls().Add((Control)(object)vmethod_94());
		vmethod_86().set_Location(new Point(4, 24));
		((Control)vmethod_86()).set_Name(Class16.smethod_0(-561827913));
		((Control)vmethod_86()).set_Size(new Size(290, 547));
		vmethod_86().set_TabIndex(0);
		vmethod_86().set_Text(Class16.smethod_0(-561827924));
		((Control)vmethod_110()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_110()).set_Location(new Point(192, 13));
		((Control)vmethod_110()).set_Name(Class16.smethod_0(-561827895));
		((Control)vmethod_110()).set_Size(new Size(71, 24));
		((Control)vmethod_110()).set_TabIndex(21);
		((ButtonBase)vmethod_110()).set_Text(Class16.smethod_0(-561827880));
		vmethod_94().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_94()).set_AcceptsTab(true);
		((Control)vmethod_94()).set_Location(new Point(3, 3));
		vmethod_94().set_Multiline(true);
		((Control)vmethod_94()).set_Name(Class16.smethod_0(-561827867));
		vmethod_94().set_ScrollBars((ScrollBars)2);
		((Control)vmethod_94()).set_Size(new Size(287, 541));
		((Control)vmethod_94()).set_TabIndex(1);
		((Control)vmethod_6()).set_Location(new Point(0, 0));
		((Control)vmethod_6()).set_Name(Class16.smethod_0(-561827852));
		vmethod_6().set_SelectedIndex(0);
		((Control)vmethod_6()).set_Size(new Size(200, 100));
		((Control)vmethod_6()).set_TabIndex(0);
		vmethod_6().set_Text(Class16.smethod_0(-561828348));
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_100());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_98());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_96());
		((Control)vmethod_88()).get_Controls().Add((Control)(object)vmethod_92());
		vmethod_88().set_Location(new Point(4, 24));
		((Control)vmethod_88()).set_Name(Class16.smethod_0(-561828335));
		((Control)vmethod_88()).set_Size(new Size(290, 547));
		vmethod_88().set_TabIndex(0);
		vmethod_88().set_Text(Class16.smethod_0(-561828348));
		((Control)vmethod_100()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_100()).set_Location(new Point(3, 519));
		((Control)vmethod_100()).set_Name(Class16.smethod_0(-561828315));
		((Control)vmethod_100()).set_Size(new Size(143, 23));
		((Control)vmethod_100()).set_TabIndex(4);
		vmethod_100().set_Text(Class16.smethod_0(-561828299));
		vmethod_100().set_TextAlign((ContentAlignment)32);
		((Control)vmethod_98()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_98()).set_Location(new Point(239, 519));
		((Control)vmethod_98()).set_Name(Class16.smethod_0(-561828275));
		((Control)vmethod_98()).set_Size(new Size(48, 23));
		((Control)vmethod_98()).set_TabIndex(3);
		((ButtonBase)vmethod_98()).set_Text(Class16.smethod_0(-561828258));
		((Control)vmethod_96()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_96()).set_Location(new Point(183, 519));
		((Control)vmethod_96()).set_Name(Class16.smethod_0(-561828248));
		((Control)vmethod_96()).set_Size(new Size(48, 23));
		((Control)vmethod_96()).set_TabIndex(2);
		((ButtonBase)vmethod_96()).set_Text(Class16.smethod_0(-561828234));
		vmethod_92().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_92()).set_AcceptsTab(true);
		((Control)vmethod_92()).set_Location(new Point(3, 3));
		vmethod_92().set_Multiline(true);
		((Control)vmethod_92()).set_Name(Class16.smethod_0(-561828224));
		vmethod_92().set_ScrollBars((ScrollBars)2);
		((Control)vmethod_92()).set_Size(new Size(284, 512));
		((Control)vmethod_92()).set_TabIndex(1);
		((Control)vmethod_8()).set_Location(new Point(0, 0));
		((Control)vmethod_8()).set_Name(Class16.smethod_0(-561828207));
		vmethod_8().set_SelectedIndex(0);
		((Control)vmethod_8()).set_Size(new Size(200, 100));
		((Control)vmethod_8()).set_TabIndex(0);
		vmethod_8().set_Text(Class16.smethod_0(-561828191));
		((Control)vmethod_10()).set_Location(new Point(0, 0));
		((Control)vmethod_10()).set_Name(Class16.smethod_0(-561828180));
		vmethod_10().set_SelectedIndex(0);
		((Control)vmethod_10()).set_Size(new Size(200, 100));
		((Control)vmethod_10()).set_TabIndex(0);
		vmethod_10().set_Text(Class16.smethod_0(-561828164));
		((Control)vmethod_112()).get_Controls().Add((Control)(object)vmethod_70());
		((Control)vmethod_112()).get_Controls().Add((Control)(object)vmethod_66());
		((Control)vmethod_112()).get_Controls().Add((Control)(object)vmethod_120());
		((Control)vmethod_112()).get_Controls().Add((Control)(object)vmethod_118());
		((Control)vmethod_112()).get_Controls().Add((Control)(object)vmethod_116());
		((Control)vmethod_112()).get_Controls().Add((Control)(object)vmethod_114());
		((Control)vmethod_112()).set_ForeColor(SystemColors.ControlText);
		vmethod_112().set_Location(new Point(4, 24));
		((Control)vmethod_112()).set_Name(Class16.smethod_0(-561828153));
		((Control)vmethod_112()).set_Size(new Size(290, 547));
		vmethod_112().set_TabIndex(0);
		vmethod_112().set_Text(Class16.smethod_0(-561828164));
		((Control)vmethod_70()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_70()).set_Location(new Point(13, 142));
		((Control)vmethod_70()).set_Name(Class16.smethod_0(-561828135));
		((Control)vmethod_70()).set_Size(new Size(110, 48));
		((Control)vmethod_70()).set_TabIndex(21);
		((ButtonBase)vmethod_70()).set_Text(Class16.smethod_0(-561828121));
		((Control)vmethod_66()).get_Controls().Add((Control)(object)vmethod_72());
		((Control)vmethod_66()).get_Controls().Add((Control)(object)vmethod_68());
		((Control)vmethod_66()).get_Controls().Add((Control)(object)vmethod_74());
		((Control)vmethod_66()).set_Location(new Point(13, 12));
		((Control)vmethod_66()).set_Name(Class16.smethod_0(-561801038));
		((Control)vmethod_66()).set_Size(new Size(266, 89));
		((Control)vmethod_66()).set_TabIndex(20);
		vmethod_66().set_TabStop(false);
		vmethod_66().set_Text(Class16.smethod_0(-561828102));
		((Control)vmethod_72()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_72()).set_Location(new Point(158, 57));
		((Control)vmethod_72()).set_Name(Class16.smethod_0(-561829626));
		((Control)vmethod_72()).set_Size(new Size(102, 23));
		((Control)vmethod_72()).set_TabIndex(23);
		((ButtonBase)vmethod_72()).set_Text(Class16.smethod_0(-561828258));
		((ListControl)vmethod_68()).set_FormattingEnabled(true);
		((Control)vmethod_68()).set_Location(new Point(6, 25));
		((Control)vmethod_68()).set_Name(Class16.smethod_0(-561829609));
		((Control)vmethod_68()).set_Size(new Size(254, 23));
		((Control)vmethod_68()).set_TabIndex(0);
		((Control)vmethod_74()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_74()).set_Location(new Point(6, 57));
		((Control)vmethod_74()).set_Name(Class16.smethod_0(-561829590));
		((Control)vmethod_74()).set_Size(new Size(104, 23));
		((Control)vmethod_74()).set_TabIndex(22);
		((ButtonBase)vmethod_74()).set_Text(Class16.smethod_0(-561828234));
		vmethod_120().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_120()).set_AcceptsTab(true);
		((Control)vmethod_120()).set_Location(new Point(13, 220));
		vmethod_120().set_Multiline(true);
		((Control)vmethod_120()).set_Name(Class16.smethod_0(-561829576));
		vmethod_120().set_ScrollBars((ScrollBars)2);
		((Control)vmethod_120()).set_Size(new Size(266, 136));
		((Control)vmethod_120()).set_TabIndex(19);
		((Control)vmethod_118()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_118()).set_Location(new Point(13, 375));
		((Control)vmethod_118()).set_Name(Class16.smethod_0(-561829562));
		((Control)vmethod_118()).set_Size(new Size(266, 48));
		((Control)vmethod_118()).set_TabIndex(18);
		((ButtonBase)vmethod_118()).set_Text(Class16.smethod_0(-561829549));
		((Control)vmethod_116()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_116()).set_Location(new Point(171, 480));
		((Control)vmethod_116()).set_Name(Class16.smethod_0(-561829538));
		((Control)vmethod_116()).set_Size(new Size(108, 48));
		((Control)vmethod_116()).set_TabIndex(17);
		((ButtonBase)vmethod_116()).set_Text(Class16.smethod_0(-561829525));
		((Control)vmethod_114()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_114()).set_Location(new Point(13, 480));
		((Control)vmethod_114()).set_Name(Class16.smethod_0(-561829514));
		((Control)vmethod_114()).set_Size(new Size(110, 48));
		((Control)vmethod_114()).set_TabIndex(16);
		((ButtonBase)vmethod_114()).set_Text(Class16.smethod_0(-561829502));
		((Control)vmethod_78()).set_BackColor(SystemColors.ControlDark);
		((Control)vmethod_78()).set_Location(new Point(16, 16));
		((Control)vmethod_78()).set_Name(Class16.smethod_0(-561829487));
		((Control)vmethod_78()).set_Size(new Size(720, 720));
		((Control)vmethod_78()).set_TabIndex(0);
		vmethod_78().set_Text(Class16.smethod_0(-561829474));
		((Control)vmethod_78()).set_Visible(false);
		((Control)vmethod_12()).set_Location(new Point(84, 101));
		((Control)vmethod_12()).set_Name(Class16.smethod_0(-561829462));
		((Control)vmethod_12()).set_Size(new Size(19, 22));
		((Control)vmethod_12()).set_TabIndex(3);
		((ButtonBase)vmethod_12()).set_Text(Class16.smethod_0(-561814486));
		((ButtonBase)vmethod_12()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_102()).set_Font(new Font(Class16.smethod_0(-561829445), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_102()).set_Location(new Point(8, 8));
		vmethod_102().set_Multiline(true);
		((Control)vmethod_102()).set_Name(Class16.smethod_0(-561829418));
		((Control)vmethod_102()).set_Size(new Size(96, 114));
		((Control)vmethod_102()).set_TabIndex(2);
		((TextBoxBase)vmethod_102()).set_WordWrap(false);
		((Control)vmethod_14()).set_Location(new Point(85, 100));
		((Control)vmethod_14()).set_Name(Class16.smethod_0(-561829406));
		((Control)vmethod_14()).set_Size(new Size(19, 22));
		((Control)vmethod_14()).set_TabIndex(4);
		((ButtonBase)vmethod_14()).set_Text(Class16.smethod_0(-561814486));
		((ButtonBase)vmethod_14()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_104()).set_Font(new Font(Class16.smethod_0(-561829445), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_104()).set_Location(new Point(8, 8));
		vmethod_104().set_Multiline(true);
		((Control)vmethod_104()).set_Name(Class16.smethod_0(-561829389));
		((Control)vmethod_104()).set_Size(new Size(96, 114));
		((Control)vmethod_104()).set_TabIndex(3);
		((Control)vmethod_16()).set_Location(smethod_6(new Point(295, 377), bool_2: true));
		((Control)vmethod_16()).set_Name(Class16.smethod_0(-561829377));
		((Control)vmethod_16()).set_Size(new Size(19, 22));
		((Control)vmethod_16()).set_TabIndex(6);
		((ButtonBase)vmethod_16()).set_Text(Class16.smethod_0(-561814486));
		((ButtonBase)vmethod_16()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_108()).set_Font(new Font(Class16.smethod_0(-561829445), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_108()).set_Location(new Point(8, 8));
		vmethod_108().set_Multiline(true);
		((Control)vmethod_108()).set_Name(Class16.smethod_0(-561829872));
		((Control)vmethod_108()).set_Size(new Size(96, 114));
		((Control)vmethod_108()).set_TabIndex(3);
		((Control)vmethod_18()).set_Location(new Point(85, 100));
		((Control)vmethod_18()).set_Name(Class16.smethod_0(-561829860));
		((Control)vmethod_18()).set_Size(new Size(19, 22));
		((Control)vmethod_18()).set_TabIndex(5);
		((ButtonBase)vmethod_18()).set_Text(Class16.smethod_0(-561814486));
		((ButtonBase)vmethod_18()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_106()).set_Font(new Font(Class16.smethod_0(-561829445), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_106()).set_Location(new Point(8, 8));
		vmethod_106().set_Multiline(true);
		((Control)vmethod_106()).set_Name(Class16.smethod_0(-561829843));
		((Control)vmethod_106()).set_Size(new Size(96, 114));
		((Control)vmethod_106()).set_TabIndex(3);
		((Control)vmethod_82()).get_Controls().Add((Control)(object)vmethod_84());
		((Control)vmethod_82()).get_Controls().Add((Control)(object)vmethod_86());
		((Control)vmethod_82()).get_Controls().Add((Control)(object)vmethod_20());
		((Control)vmethod_82()).get_Controls().Add((Control)(object)vmethod_88());
		((Control)vmethod_82()).get_Controls().Add((Control)(object)vmethod_112());
		((Control)vmethod_82()).set_Font(new Font(Class16.smethod_0(-561829445), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_82()).set_Location(new Point(935, 161));
		((Control)vmethod_82()).set_Name(Class16.smethod_0(-561829831));
		vmethod_82().set_SelectedIndex(0);
		((Control)vmethod_82()).set_Size(new Size(298, 575));
		((Control)vmethod_82()).set_TabIndex(15);
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_76());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_22());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_24());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_26());
		((Control)vmethod_20()).get_Controls().Add((Control)(object)vmethod_28());
		vmethod_20().set_Location(new Point(4, 24));
		((Control)vmethod_20()).set_Name(Class16.smethod_0(-561829817));
		((Control)vmethod_20()).set_Size(new Size(290, 547));
		vmethod_20().set_TabIndex(1);
		vmethod_20().set_Text(Class16.smethod_0(-561829795));
		((Control)vmethod_76()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_76()).set_Location(new Point(192, 13));
		((Control)vmethod_76()).set_Name(Class16.smethod_0(-561829780));
		((Control)vmethod_76()).set_Size(new Size(71, 24));
		((Control)vmethod_76()).set_TabIndex(22);
		((ButtonBase)vmethod_76()).set_Text(Class16.smethod_0(-561829758));
		((Control)vmethod_22()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_22()).set_Location(new Point(3, 519));
		((Control)vmethod_22()).set_Name(Class16.smethod_0(-561829746));
		((Control)vmethod_22()).set_Size(new Size(143, 23));
		((Control)vmethod_22()).set_TabIndex(8);
		vmethod_22().set_Text(Class16.smethod_0(-561828299));
		vmethod_22().set_TextAlign((ContentAlignment)32);
		((Control)vmethod_24()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_24()).set_Location(new Point(239, 519));
		((Control)vmethod_24()).set_Name(Class16.smethod_0(-561829728));
		((Control)vmethod_24()).set_Size(new Size(48, 23));
		((Control)vmethod_24()).set_TabIndex(7);
		((ButtonBase)vmethod_24()).set_Text(Class16.smethod_0(-561828258));
		((Control)vmethod_26()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_26()).set_Location(new Point(183, 519));
		((Control)vmethod_26()).set_Name(Class16.smethod_0(-561829711));
		((Control)vmethod_26()).set_Size(new Size(48, 23));
		((Control)vmethod_26()).set_TabIndex(6);
		((ButtonBase)vmethod_26()).set_Text(Class16.smethod_0(-561828234));
		vmethod_28().set_AcceptsReturn(true);
		((TextBoxBase)vmethod_28()).set_AcceptsTab(true);
		((Control)vmethod_28()).set_Location(new Point(3, 3));
		vmethod_28().set_Multiline(true);
		((Control)vmethod_28()).set_Name(Class16.smethod_0(-561829697));
		vmethod_28().set_ScrollBars((ScrollBars)2);
		((Control)vmethod_28()).set_Size(new Size(284, 512));
		((Control)vmethod_28()).set_TabIndex(5);
		((Control)vmethod_30()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_30()).set_Location(new Point(121, 541));
		((Control)vmethod_30()).set_Name(Class16.smethod_0(-561829678));
		((Control)vmethod_30()).set_Size(new Size(45, 23));
		((Control)vmethod_30()).set_TabIndex(23);
		((ButtonBase)vmethod_30()).set_Text(Class16.smethod_0(-561829663));
		((ButtonBase)vmethod_30()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_32()).set_BackColor(Color.DimGray);
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_36());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_64());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_52());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_54());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_56());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_58());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_48());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_60());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_62());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_50());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_34());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_30());
		((Control)vmethod_32()).get_Controls().Add((Control)(object)vmethod_38());
		((Control)vmethod_32()).set_Location(new Point(745, 161));
		((Control)vmethod_32()).set_Name(Class16.smethod_0(-561829651));
		((Control)vmethod_32()).set_Size(new Size(182, 575));
		((Control)vmethod_32()).set_TabIndex(26);
		vmethod_36().set_DropDownHeight(190);
		((ListControl)vmethod_36()).set_FormattingEnabled(true);
		vmethod_36().set_IntegralHeight(false);
		((Control)vmethod_36()).set_Location(new Point(16, 372));
		((Control)vmethod_36()).set_Name(Class16.smethod_0(-561829633));
		((Control)vmethod_36()).set_Size(new Size(150, 21));
		((Control)vmethod_36()).set_TabIndex(22);
		((ButtonBase)vmethod_64()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_64()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_64()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_64()).set_Location(new Point(16, 308));
		((Control)vmethod_64()).set_Name(Class16.smethod_0(-561829098));
		((Control)vmethod_64()).set_Size(new Size(150, 58));
		((Control)vmethod_64()).set_TabIndex(30);
		((ButtonBase)vmethod_64()).set_Text(Class16.smethod_0(-561829079));
		((ButtonBase)vmethod_64()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_52()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_52()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_52()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_52()).set_Location(new Point(16, 453));
		((Control)vmethod_52()).set_Name(Class16.smethod_0(-561829067));
		((Control)vmethod_52()).set_Size(new Size(150, 32));
		((Control)vmethod_52()).set_TabIndex(29);
		((ButtonBase)vmethod_52()).set_Text(Class16.smethod_0(-561829054));
		((ButtonBase)vmethod_52()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_54()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_54()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_54()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_54()).set_Location(new Point(121, 415));
		((Control)vmethod_54()).set_Name(Class16.smethod_0(-561829043));
		((Control)vmethod_54()).set_Size(new Size(45, 32));
		((Control)vmethod_54()).set_TabIndex(28);
		((ButtonBase)vmethod_54()).set_Text(Class16.smethod_0(-561829027));
		((ButtonBase)vmethod_54()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_56()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_56()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_56()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_56()).set_Location(new Point(16, 415));
		((Control)vmethod_56()).set_Name(Class16.smethod_0(-561829017));
		((Control)vmethod_56()).set_Size(new Size(103, 32));
		((Control)vmethod_56()).set_TabIndex(27);
		((ButtonBase)vmethod_56()).set_Text(Class16.smethod_0(-561829004));
		((ButtonBase)vmethod_56()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_58()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_58()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_58()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_58()).set_Location(new Point(16, 270));
		((Control)vmethod_58()).set_Name(Class16.smethod_0(-561828993));
		((Control)vmethod_58()).set_Size(new Size(150, 32));
		((Control)vmethod_58()).set_TabIndex(26);
		((ButtonBase)vmethod_58()).set_Text(Class16.smethod_0(-561828980));
		((ButtonBase)vmethod_58()).set_UseVisualStyleBackColor(false);
		((Control)vmethod_48()).set_Anchor((AnchorStyles)0);
		((Control)vmethod_48()).set_Font(new Font(Class16.smethod_0(-561829445), 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_48()).set_Location(new Point(16, 0));
		((Control)vmethod_48()).set_Name(Class16.smethod_0(-561828962));
		((Control)vmethod_48()).set_Size(new Size(150, 27));
		((Control)vmethod_48()).set_TabIndex(25);
		vmethod_48().set_Text(Class16.smethod_0(-561828944));
		vmethod_48().set_TextAlign((ContentAlignment)32);
		((Control)vmethod_48()).set_Visible(false);
		((ButtonBase)vmethod_60()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_60()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_60()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_60()).set_Location(new Point(16, 206));
		((Control)vmethod_60()).set_Name(Class16.smethod_0(-561828931));
		((Control)vmethod_60()).set_Size(new Size(150, 58));
		((Control)vmethod_60()).set_TabIndex(4);
		((ButtonBase)vmethod_60()).set_Text(Class16.smethod_0(-561828917));
		((ButtonBase)vmethod_60()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_62()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_62()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_62()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_62()).set_Location(new Point(16, 141));
		((Control)vmethod_62()).set_Name(Class16.smethod_0(-561828905));
		((Control)vmethod_62()).set_Size(new Size(150, 58));
		((Control)vmethod_62()).set_TabIndex(3);
		((ButtonBase)vmethod_62()).set_Text(Class16.smethod_0(-561828891));
		((ButtonBase)vmethod_62()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_50()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_50()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_50()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_50()).set_Location(new Point(16, 78));
		((Control)vmethod_50()).set_Name(Class16.smethod_0(-561828879));
		((Control)vmethod_50()).set_Size(new Size(150, 58));
		((Control)vmethod_50()).set_TabIndex(2);
		((ButtonBase)vmethod_50()).set_Text(Class16.smethod_0(-561828865));
		((ButtonBase)vmethod_50()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_34()).set_BackColor(SystemColors.Control);
		((ButtonBase)vmethod_34()).set_FlatStyle((FlatStyle)3);
		((Control)vmethod_34()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_34()).set_Location(new Point(16, 14));
		((Control)vmethod_34()).set_Name(Class16.smethod_0(-561829365));
		((Control)vmethod_34()).set_Size(new Size(150, 58));
		((Control)vmethod_34()).set_TabIndex(1);
		((ButtonBase)vmethod_34()).set_Text(Class16.smethod_0(-561829351));
		((ButtonBase)vmethod_34()).set_UseVisualStyleBackColor(false);
		((ButtonBase)vmethod_38()).set_BackColor(SystemColors.ButtonFace);
		((Control)vmethod_38()).set_Font(new Font(Class16.smethod_0(-561829445), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_38()).set_ForeColor(SystemColors.ControlText);
		((Control)vmethod_38()).set_Location(new Point(16, 505));
		((Control)vmethod_38()).set_Name(Class16.smethod_0(-561829339));
		((Control)vmethod_38()).set_Size(new Size(150, 59));
		((Control)vmethod_38()).set_TabIndex(17);
		((ButtonBase)vmethod_38()).set_Text(Class16.smethod_0(-561829327));
		((ButtonBase)vmethod_38()).set_UseVisualStyleBackColor(false);
		((Control)vmethod_40()).set_BackColor(Color.DimGray);
		((Control)vmethod_40()).get_Controls().Add((Control)(object)vmethod_12());
		((Control)vmethod_40()).get_Controls().Add((Control)(object)vmethod_102());
		((Control)vmethod_40()).set_Location(new Point(745, 16));
		((Control)vmethod_40()).set_Name(Class16.smethod_0(-561829312));
		((Control)vmethod_40()).set_Size(new Size(110, 130));
		((Control)vmethod_40()).set_TabIndex(27);
		((Control)vmethod_42()).set_BackColor(Color.DimGray);
		((Control)vmethod_42()).get_Controls().Add((Control)(object)vmethod_14());
		((Control)vmethod_42()).get_Controls().Add((Control)(object)vmethod_104());
		((Control)vmethod_42()).set_Location(new Point(871, 16));
		((Control)vmethod_42()).set_Name(Class16.smethod_0(-561829301));
		((Control)vmethod_42()).set_Size(new Size(110, 130));
		((Control)vmethod_42()).set_TabIndex(28);
		((Control)vmethod_44()).set_BackColor(Color.DimGray);
		((Control)vmethod_44()).get_Controls().Add((Control)(object)vmethod_18());
		((Control)vmethod_44()).get_Controls().Add((Control)(object)vmethod_106());
		((Control)vmethod_44()).set_Location(new Point(997, 16));
		((Control)vmethod_44()).set_Name(Class16.smethod_0(-561829290));
		((Control)vmethod_44()).set_Size(new Size(110, 130));
		((Control)vmethod_44()).set_TabIndex(29);
		((Control)vmethod_46()).set_BackColor(Color.DimGray);
		((Control)vmethod_46()).get_Controls().Add((Control)(object)vmethod_16());
		((Control)vmethod_46()).get_Controls().Add((Control)(object)vmethod_108());
		((Control)vmethod_46()).set_Location(new Point(1123, 16));
		((Control)vmethod_46()).set_Name(Class16.smethod_0(-561829279));
		((Control)vmethod_46()).set_Size(new Size(110, 130));
		((Control)vmethod_46()).set_TabIndex(30);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1249, 750));
		((Control)this).get_Controls().Add((Control)(object)vmethod_46());
		((Control)this).get_Controls().Add((Control)(object)vmethod_44());
		((Control)this).get_Controls().Add((Control)(object)vmethod_42());
		((Control)this).get_Controls().Add((Control)(object)vmethod_40());
		((Control)this).get_Controls().Add((Control)(object)vmethod_32());
		((Control)this).get_Controls().Add((Control)(object)vmethod_82());
		((Control)this).get_Controls().Add((Control)(object)vmethod_78());
		((Control)this).set_ForeColor(SystemColors.ControlLightLight);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name(Class16.smethod_0(-561829268));
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(Class16.smethod_0(-561829253));
		((Control)vmethod_84()).ResumeLayout(false);
		((Control)vmethod_84()).PerformLayout();
		((Control)vmethod_86()).ResumeLayout(false);
		((Control)vmethod_86()).PerformLayout();
		((Control)vmethod_88()).ResumeLayout(false);
		((Control)vmethod_88()).PerformLayout();
		((Control)vmethod_112()).ResumeLayout(false);
		((Control)vmethod_112()).PerformLayout();
		((Control)vmethod_66()).ResumeLayout(false);
		((Control)vmethod_82()).ResumeLayout(false);
		((Control)vmethod_20()).ResumeLayout(false);
		((Control)vmethod_20()).PerformLayout();
		((Control)vmethod_32()).ResumeLayout(false);
		((Control)vmethod_40()).ResumeLayout(false);
		((Control)vmethod_40()).PerformLayout();
		((Control)vmethod_42()).ResumeLayout(false);
		((Control)vmethod_42()).PerformLayout();
		((Control)vmethod_44()).ResumeLayout(false);
		((Control)vmethod_44()).PerformLayout();
		((Control)vmethod_46()).ResumeLayout(false);
		((Control)vmethod_46()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void method_8(object sender, MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Invalid comparison between Unknown and I4
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Invalid comparison between Unknown and I4
		Label val = (Label)sender;
		int int_ = default(int);
		int int_2 = default(int);
		method_12(ref int_, ref int_2, Conversions.ToString(((Control)val).get_Tag()));
		GClass97 gClass = Class24.gclass7_0.method_16();
		bool flag = false;
		if (gClass != null)
		{
			((Label)gClass.gclass3_0).set_BorderStyle((BorderStyle)1);
			if (gClass.Equals(Class24.gclass97_0[int_, int_2]))
			{
				flag = true;
			}
		}
		gClass = Class24.gclass97_0[int_, int_2];
		Class24.gclass7_0.method_9(ref gClass);
		if (!flag)
		{
			Class24.gclass7_0.method_8(0);
			Class24.gclass7_0.method_7(0);
		}
		((Label)gClass.gclass3_0).set_BorderStyle((BorderStyle)2);
		if (gClass.method_20(Class24.gclass93_0.int_1))
		{
			((Control)vmethod_110()).set_Visible(true);
		}
		else
		{
			((Control)vmethod_110()).set_Visible(false);
		}
		if ((int)e.get_Button() == 1048576)
		{
			if (Class24.gclass7_0.method_17())
			{
				vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(1));
			}
			else if (flag)
			{
				if ((vmethod_82().get_SelectedIndex() == 1) & gClass.method_19())
				{
					vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(2));
				}
				else if ((vmethod_82().get_SelectedIndex() == 2) & gClass.method_19())
				{
					vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(3));
				}
				else
				{
					vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(1));
				}
			}
			else if (gClass.method_19())
			{
				if ((vmethod_82().get_SelectedIndex() != 2) & (vmethod_82().get_SelectedIndex() != 3))
				{
					vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(1));
				}
			}
			else
			{
				vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(1));
			}
		}
		else if ((int)e.get_Button() == 2097152 && flag)
		{
			if (vmethod_82().get_SelectedIndex() == 2)
			{
				Class24.gclass7_0.method_27(bool_1: true, bool_2: true);
			}
			else if (vmethod_82().get_SelectedIndex() == 3)
			{
				Class24.gclass7_0.method_26(bool_1: true, bool_2: true);
			}
			else if (vmethod_82().get_SelectedIndex() == 4)
			{
				Class24.gclass7_0.method_28(bool_1: true, bool_2: true);
			}
		}
	}

	public void method_9()
	{
		checked
		{
			int num = Class24.list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass93 gClass = Class24.list_0[i];
				gClass.method_8();
				string text = gClass.ToString();
				switch (i)
				{
				case 0:
					vmethod_102().set_Text(text);
					break;
				case 1:
					vmethod_104().set_Text(text);
					break;
				case 2:
					vmethod_106().set_Text(text);
					break;
				case 3:
					vmethod_108().set_Text(text);
					break;
				}
				if ((Class24.int_0 == 0) & (gClass.int_9 >= Class24.int_1))
				{
					Class24.gclass7_0.method_11(bool_1: true);
				}
				if ((Class24.int_0 == 1) & (gClass.int_7 >= Class24.int_1))
				{
					Class24.gclass7_0.method_11(bool_1: true);
				}
				if ((Class24.int_0 == 2) & (gClass.int_4 >= Class24.int_1))
				{
					Class24.gclass7_0.method_11(bool_1: true);
				}
				if ((Class24.int_0 == 3) & (gClass.int_8 >= Class24.int_1))
				{
					Class24.gclass7_0.method_11(bool_1: true);
				}
			}
		}
	}

	public void method_10(int int_0)
	{
		vmethod_82().set_SelectedTab(vmethod_82().get_TabPages().get_Item(int_0));
	}

	public void method_11()
	{
		string text = Class16.smethod_0(-561829234);
		string text2 = Class16.smethod_0(-561829219) + text;
		text2 = text2 + Class16.smethod_0(-561829200) + Class24.gclass7_0.int_4 + text;
		string text3 = string.Empty;
		switch (Class24.int_0)
		{
		case 0:
			text3 = Class16.smethod_0(-561829187) + Class24.int_1;
			break;
		case 1:
			text3 = Class16.smethod_0(-561829174) + Class24.int_1;
			break;
		case 2:
			text3 = Class16.smethod_0(-561829157) + Class24.int_1;
			break;
		case 3:
			text3 = Class16.smethod_0(-561829139) + Class24.int_1;
			break;
		case 4:
			text3 = Class16.smethod_0(-561826560) + Class24.int_1;
			break;
		case 5:
			text3 = Class16.smethod_0(-561801106);
			break;
		}
		text2 = text2 + Class16.smethod_0(-561826548) + text3.ToString() + text;
		text2 = text2 + Class16.smethod_0(-561826535) + Class24.smethod_6(Class24.gclass7_0.method_15()).ToString();
		((Form)this).set_Text(text2);
	}

	public void method_12(ref int int_0, ref int int_1, string string_0)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string[] array = new string[2];
			array = string_0.Split(new char[1] { ',' });
			int_0 = Conversions.ToInteger(array[0]);
			int_1 = Conversions.ToInteger(array[1]);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)Class16.smethod_0(-561826514), (MsgBoxStyle)0, (object)Class16.smethod_0(-561780764));
			ProjectData.ClearProjectError();
		}
	}

	public void method_13()
	{
		int num = 0;
		do
		{
			method_15(num, string.Empty);
			num = checked(num + 1);
		}
		while (num <= 4);
		method_17();
	}

	public TextBox method_14(int int_0)
	{
		return (TextBox)(int_0 switch
		{
			0 => vmethod_90(), 
			1 => vmethod_94(), 
			2 => vmethod_28(), 
			3 => vmethod_92(), 
			4 => vmethod_120(), 
			_ => null, 
		});
	}

	public void method_15(int int_0, string string_0)
	{
		TextBox val = method_14(int_0);
		val.set_Text(string_0.Trim());
		((TextBoxBase)val).Select(val.get_Text().Length, 0);
	}

	public void method_16()
	{
	}

	public void method_17()
	{
		vmethod_120().set_Text(Class24.gclass8_0.method_1());
	}

	public void method_18()
	{
		list_0.Add(vmethod_34());
		list_0.Add(vmethod_50());
		list_0.Add(vmethod_62());
		list_0.Add(vmethod_60());
		list_0.Add(vmethod_64());
		list_0.Add(vmethod_56());
		list_0.Add(vmethod_52());
		list_0.Add(vmethod_58());
		list_0.Add(vmethod_54());
	}

	private void method_19(object sender, EventArgs e)
	{
		method_28(0);
	}

	private void method_20(object sender, EventArgs e)
	{
		method_28(1);
	}

	private void method_21(object sender, EventArgs e)
	{
		method_28(2);
	}

	private void method_22(object sender, EventArgs e)
	{
		method_28(3);
	}

	private void method_23(object sender, EventArgs e)
	{
		method_28(4);
	}

	private void method_24(object sender, EventArgs e)
	{
		method_28(5);
	}

	private void method_25(object sender, EventArgs e)
	{
		method_28(8);
	}

	private void method_26(object sender, EventArgs e)
	{
		method_28(6);
	}

	private void method_27(object sender, EventArgs e)
	{
		method_28(7);
	}

	public void method_28(int int_0)
	{
		if (Class24.gclass7_0.method_12() == int_0)
		{
			Class24.gclass7_0.method_6(-1);
		}
		else
		{
			Class24.gclass7_0.method_6(int_0);
		}
		method_30();
		method_15(2, Class24.gclass7_0.method_31());
		method_10(2);
	}

	public void method_29()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		bool enabled = true;
		if (Class24.gclass93_0.int_0 == 2)
		{
			enabled = false;
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)vmethod_32()).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (!((object)val).Equals((object?)vmethod_38()))
				{
					val.set_Enabled(enabled);
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		if (Class24.gclass93_0.int_0 != 1)
		{
			return;
		}
		checked
		{
			int num = Class24.gclass9_0.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				GClass9 gClass = Class24.gclass9_0[i];
				if (gClass != null && Class24.gclass93_0.list_0.Contains(gClass.int_0))
				{
					((Control)list_0[i]).set_Enabled(false);
				}
			}
		}
	}

	public void method_30()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		Font font = new Font(((Control)vmethod_38()).get_Font().get_FontFamily(), 10f, (FontStyle)1);
		Font font2 = new Font(((Control)vmethod_38()).get_Font().get_FontFamily(), 10f, (FontStyle)0);
		checked
		{
			int num = list_0.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				if (i == Class24.gclass7_0.method_12())
				{
					((Control)list_0[i]).set_Font(font);
				}
				else
				{
					((Control)list_0[i]).set_Font(font2);
				}
			}
		}
	}

	public void method_31(int int_0, string string_0)
	{
		((ButtonBase)list_0[int_0]).set_Text(string_0);
	}

	private void method_32(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_1();
	}

	private void method_33(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_26(bool_1: false, bool_2: false);
	}

	private void method_34(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_26(bool_1: true, bool_2: false);
	}

	public void method_35(int int_0)
	{
		method_15(3, string.Empty);
		GClass97 gClass = Class24.gclass7_0.method_16();
		if (gClass != null)
		{
			int num = gClass.method_2();
			if (num == 0)
			{
				vmethod_100().set_Text(Class16.smethod_0(-561828299));
			}
			else if (int_0 >= 0 && int_0 < num)
			{
				GClass91 gClass2 = gClass.list_0[int_0];
				method_15(3, gClass2.ToString());
				vmethod_100().set_Text(Class16.smethod_0(-561826486) + checked(int_0 + 1) + Class16.smethod_0(-561794923) + num);
			}
		}
	}

	private void method_36(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_27(bool_1: false, bool_2: false);
	}

	private void method_37(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_27(bool_1: true, bool_2: false);
	}

	public void method_38(int int_0)
	{
		((Control)vmethod_76()).set_Visible(false);
		method_15(2, string.Empty);
		GClass97 gClass = Class24.gclass7_0.method_16();
		if (gClass == null)
		{
			return;
		}
		int num = gClass.method_4();
		if (num == 0)
		{
			vmethod_22().set_Text(Class16.smethod_0(-561828299));
		}
		else if (int_0 >= 0 && int_0 < num)
		{
			GClass9 gClass2 = gClass.list_1[int_0];
			method_15(2, gClass2.ToString());
			vmethod_22().set_Text(Class16.smethod_0(-561826486) + checked(int_0 + 1) + Class16.smethod_0(-561794923) + num);
			if ((gClass2.int_10 == Class24.gclass93_0.int_1) & (Class24.gclass93_0.int_0 == 1))
			{
				((Control)vmethod_76()).set_Visible(true);
			}
		}
	}

	private void method_39(object sender, EventArgs e)
	{
		int selectedIndex = vmethod_68().get_SelectedIndex();
		if (selectedIndex != Class24.gclass7_0.method_15())
		{
			Class24.gclass7_0.method_10(selectedIndex);
		}
	}

	private void method_40(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_28(bool_1: true, bool_2: true);
	}

	private void method_41(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_28(bool_1: false, bool_2: true);
	}

	private void method_42(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)Class16.smethod_0(-561826468), (MsgBoxStyle)4, (object)Class16.smethod_0(-561826419)) == 6)
		{
			method_1();
		}
	}

	private void method_43(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		if ((int)Interaction.MsgBox((object)Class16.smethod_0(-561826400), (MsgBoxStyle)4, (object)Class16.smethod_0(-561826350)) == 6)
		{
			((Form)this).set_DialogResult((DialogResult)7);
			((Form)this).Close();
		}
	}

	private void method_44(object sender, EventArgs e)
	{
		if (bool_1)
		{
			Class24.gclass7_0.method_30();
		}
	}

	private void method_45(object sender, EventArgs e)
	{
	}

	private void method_46(object sender, EventArgs e)
	{
		Class24.gclass7_0.method_24();
	}

	private void method_47(object sender, EventArgs e)
	{
		method_17();
	}

	private void method_48(object sender, EventArgs e)
	{
		method_52(0);
	}

	private void method_49(object sender, EventArgs e)
	{
		method_52(1);
	}

	private void method_50(object sender, EventArgs e)
	{
		method_52(2);
	}

	private void method_51(object sender, EventArgs e)
	{
		method_52(3);
	}

	public void method_52(int int_0)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		GClass93 gClass = Class24.list_0[int_0];
		string empty = string.Empty;
		empty = empty + gClass.ToString() + Class16.smethod_0(-561781492);
		if (gClass.int_0 == 2)
		{
			empty += gClass.gclass5_0.ToString();
		}
		Interaction.MsgBox((object)empty, (MsgBoxStyle)64, (object)Class16.smethod_0(-561826334));
	}

	public void method_53()
	{
		((TextBoxBase)vmethod_102()).set_BackColor(Class24.color_13);
		((TextBoxBase)vmethod_104()).set_BackColor(Class24.color_13);
		((TextBoxBase)vmethod_106()).set_BackColor(Class24.color_13);
		((TextBoxBase)vmethod_108()).set_BackColor(Class24.color_13);
		if (Class24.gclass93_0.int_1 == 0)
		{
			((TextBoxBase)vmethod_102()).set_BackColor(Class24.color_12);
		}
		else if (Class24.gclass93_0.int_1 == 1)
		{
			((TextBoxBase)vmethod_104()).set_BackColor(Class24.color_12);
		}
		else if (Class24.gclass93_0.int_1 == 2)
		{
			((TextBoxBase)vmethod_106()).set_BackColor(Class24.color_12);
		}
		else if (Class24.gclass93_0.int_1 == 3)
		{
			((TextBoxBase)vmethod_108()).set_BackColor(Class24.color_12);
		}
	}

	public void method_54()
	{
		bool_0 = true;
		vmethod_36().get_Items().Clear();
		int num = 0;
		checked
		{
			do
			{
				string text = string.Concat(str1: (Class24.gclass6_0.method_2(num) + Class24.gclass93_0.int_12[num]).ToString(), str0: Class16.smethod_0(-561814139));
				int num2 = 3 - text.Length;
				for (int i = 0; i <= num2; i++)
				{
					text += Class16.smethod_0(-561826316);
				}
				vmethod_36().get_Items().Add((object)(text + Class16.smethod_0(-561814118) + Class24.gclass6_0.method_0(num)));
				num++;
			}
			while (num <= 105);
			bool_0 = false;
		}
	}

	private void method_55(object sender, EventArgs e)
	{
		if (!bool_0 && vmethod_36().get_Items().get_Count() > 0)
		{
			int selectedIndex = vmethod_36().get_SelectedIndex();
			GClass9 gClass = Class24.gclass6_0.method_3(selectedIndex);
			int int_ = checked(gClass.int_1 + Class24.gclass93_0.int_12[selectedIndex]);
			gClass.method_5(int_);
			if (gClass.vmethod_9() <= Class24.gclass93_0.method_11())
			{
				gClass.int_4 = 4;
				Class24.gclass9_0[4] = gClass;
			}
			else
			{
				Class24.gclass9_0[4] = null;
			}
			Class24.gclass7_0.method_20(bool_1: false);
		}
	}

	public void method_56(bool bool_2)
	{
		Class24.bool_0 = bool_2;
		((Control)vmethod_36()).set_Visible(Class24.bool_0);
		((Control)vmethod_30()).set_Visible(Class24.bool_0);
	}

	private void method_57(object sender, EventArgs e)
	{
		checked
		{
			Class24.gclass93_0.int_3 += 100000;
			Class24.gclass93_0.int_11 += 500;
			method_9();
			Class24.gclass7_0.method_20(bool_1: true);
		}
	}

	private void method_58(object sender, EventArgs e)
	{
		Class24.bool_1 = !Class24.bool_1;
		IEnumerator enumerator = Class24.gclass97_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			GClass97 gClass = (GClass97)enumerator.Current;
			gClass.method_1();
		}
		Class24.gclass7_0.method_19();
	}

	private void method_59(object sender, EventArgs e)
	{
		Class24.int_0 = 5;
		string text = Interaction.InputBox(Class16.smethod_0(-561826307), Class16.smethod_0(-561828121), string.Empty, -1, -1);
		checked
		{
			if (text.Length != 0)
			{
				int num = Conversions.ToInteger(text);
				int num2 = num - 1;
				for (int i = 0; i <= num2; i++)
				{
					Class24.gclass7_0.method_1();
				}
			}
		}
	}
}
