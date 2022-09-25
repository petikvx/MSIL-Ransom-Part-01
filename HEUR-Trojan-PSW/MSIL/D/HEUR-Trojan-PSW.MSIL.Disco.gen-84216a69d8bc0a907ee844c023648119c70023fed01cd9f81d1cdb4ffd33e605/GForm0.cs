using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Windows.Forms;

public class GForm0 : Form
{
	private Timer timer_0;

	private int int_0 = 3;

	private int int_1 = 0;

	private int int_2 = 0;

	private Class9 class9_0 = new Class9(Class4.string_3);

	private IContainer icontainer_0 = null;

	private BackgroundWorker backgroundWorker_0;

	private Label label_0;

	private TextBox textBox_0;

	private Label label_1;

	private Label label_2;

	private Panel panel_0;

	private Panel panel_1;

	private Label label_3;

	private Button button_0;

	private Label label_4;

	private TextBox textBox_1;

	private Label label_5;

	private Button button_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private Label label_6;

	private Label label_7;

	private TextBox textBox_4;

	private Panel panel_2;

	private Label label_8;

	public GForm0()
	{
		method_2();
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		timer_0 = new Timer();
		timer_0.Interval = 1000.0;
		timer_0.Elapsed += timer_0_Elapsed;
		timer_0.Start();
		((Control)textBox_4).set_Text("");
		foreach (string item in Class0.list_0)
		{
			TextBox obj = textBox_4;
			((Control)obj).set_Text(((Control)obj).get_Text() + Class11.smethod_0("\ue698\ue6b3\ue6be\ue6af\ue6a4\ue6ad\ue6a9\ue6b8\ue6b9\ue6e7\ue6fd", 58909) + item + Class11.smethod_0("\uf5d3\uf5d4", 62806));
		}
	}

	private void method_0(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		if (method_1())
		{
			((Control)textBox_1).set_Text(Class0.string_1);
			((Control)label_6).set_Text(Class11.smethod_0("\uf8ed\uf8dc\uf8ce\uf8c9\uf8d8\uf89d\uf8c4\uf8d2\uf8c8\uf8cf\uf89d\uf8d6\uf8d8\uf8c4\uf89d\uf8d5\uf8d8\uf8cf\uf8d8\uf893", 63640));
			((Control)label_6).set_ForeColor(Color.LightGreen);
			((Control)textBox_3).set_Text("");
			((Control)label_0).set_Text("");
			((Control)panel_2).set_BackColor(Color.FromArgb(35, 39, 42));
			((Control)textBox_0).set_Text(Class11.smethod_0("\uf8b7\uf890\uf888\uf8df\uf88b\uf890\uf8df\uf8bb\uf89a\uf89c\uf88d\uf886\uf88f\uf88b\uf8df\uf899\uf896\uf893\uf89a\uf88c\uf8c5\uf8f2\uf8f5\uf8df\uf8ba\uf891\uf88b\uf89a\uf88d\uf8df\uf89b\uf89a\uf89c\uf88d\uf886\uf88f\uf88b\uf896\uf890\uf891\uf8df\uf894\uf89a\uf886\uf8df\uf89e\uf891\uf89b\uf8df\uf89c\uf893\uf896\uf89c\uf894\uf8df\uf890\uf891\uf8df\uf8bb\uf89a\uf89c\uf88d\uf886\uf88f\uf88b\uf8df\uf89d\uf88a\uf88b\uf88b\uf890\uf891\uf8d1\uf8df\uf8f5\uf8df\uf8b2\uf89e\uf894\uf89a\uf8df\uf88c\uf88a\uf88d\uf89a\uf8df\uf8a8\uf896\uf891\uf89b\uf890\uf888\uf88c\uf8df\uf8bb\uf89a\uf899\uf89a\uf891\uf89b\uf89a\uf88d\uf8df\uf89e\uf891\uf89b\uf8df\uf89e\uf891\uf886\uf8df\uf890\uf88b\uf897\uf89a\uf88d\uf8df\uf89e\uf891\uf88b\uf896\uf889\uf896\uf88d\uf88a\uf88c\uf8df\uf896\uf88c\uf8df\uf890\uf899\uf899\uf8d1\uf8f2\uf8f5\uf8df\uf8bb\uf890\uf8df\uf891\uf890\uf88b\uf8df\uf89c\uf893\uf890\uf88c\uf89a\uf8df\uf88b\uf897\uf89a\uf8df\uf89e\uf88f\uf88f\uf893\uf896\uf89c\uf89e\uf88b\uf896\uf890\uf891\uf8df\uf888\uf897\uf896\uf893\uf89a\uf8df\uf89b\uf89a\uf89c\uf88d\uf886\uf88f\uf88b\uf896\uf891\uf898\uf8df\uf890\uf88d\uf8df\uf89a\uf893\uf88c\uf89a\uf8df\uf899\uf896\uf893\uf89a\uf88c\uf8df\uf892\uf89e\uf886\uf8df\uf898\uf89a\uf88b\uf8df\uf89c\uf890\uf88d\uf88d\uf88a\uf88f\uf88b\uf89a\uf89b\uf8d1", 63726));
			timer_0.Stop();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		string text = ((Control)textBox_3).get_Text();
		if (text == Class0.string_1)
		{
			class9_0.method_0(Class11.smethod_0("\uf6ad\uf6ad\uf6ad\uf698\uf6be\uf6a8\uf6bf\uf6ed\uf6a5\uf6ac\uf6be\uf6ed\uf6a8\uf6a3\uf6b9\uf6a8\uf6bf\uf6a8\uf6a9\uf6ed\uf6ae\uf6a2\uf6bf\uf6bf\uf6a8\uf6ae\uf6b9\uf6ed\uf6a9\uf6a8\uf6ae\uf6bf\uf6b4\uf6bd\uf6b9\uf6a4\uf6a2\uf6a3\uf6ed\uf6a6\uf6a8\uf6b4\uf6e3\uf6e3\uf6ed\uf689\uf6a8\uf6ae\uf6bf\uf6b4\uf6bd\uf6b9\uf6a4\uf6a3\uf6aa\uf6ed\uf6ab\uf6a4\uf6a1\uf6a8\uf6be\uf6e3\uf6ad\uf6ad\uf6ad", 63116));
			MessageBox.Show(Class11.smethod_0("\ue4b6\ue498\ue484\ue4dd\ue494\ue48e\ue4dd\ue49e\ue492\ue48f\ue48f\ue498\ue49e\ue489\ue4d3\ue4dd\ue4b9\ue498\ue49e\ue48f\ue484\ue48d\ue489\ue494\ue493\ue49a\ue4dd\ue49b\ue494\ue491\ue498\ue48e\ue4d3\ue4d3\ue4d3", 58413), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)64);
			Class0.string_2 = Class0.string_1;
			((Control)textBox_4).set_Text(Class11.smethod_0("\ue47f\ue45e\ue458\ue449\ue442\ue44b\ue44f\ue452\ue455\ue45c\ue41b\ue45d\ue452\ue457\ue45e\ue448\ue415\ue415\ue41b\ue436\ue431\ue46f\ue453\ue452\ue448\ue41b\ue456\ue45a\ue442\ue41b\ue44f\ue45a\ue450\ue45e\ue41b\ue45a\ue41b\ue44c\ue453\ue452\ue457\ue45e\ue415\ue41b\ue477\ue454\ue45a\ue45f\ue452\ue455\ue45c\ue415\ue415", 58427));
			Cursor.set_Current(Cursors.get_WaitCursor());
			Class4.smethod_2();
			Cursor.set_Current(Cursors.get_Default());
			MessageBox.Show(Class11.smethod_0("\uf3eb\uf3de\uf3cc\uf3d4\uf39f\uf3dc\uf3d0\uf3d2\uf3cf\uf3d3\uf3da\uf3cb\uf3da\uf391\uf39f\uf3f6\uf3d9\uf39f\uf3cb\uf3d7\uf3da\uf3cd\uf3da\uf39f\uf3de\uf3cd\uf3da\uf39f\uf3d9\uf3d6\uf3d3\uf3da\uf3cc\uf39f\uf3cb\uf3d7\uf3de\uf3cb\uf39f\uf3d7\uf3de\uf3c9\uf3da\uf39f\uf3d1\uf3d0\uf3cb\uf39f\uf3dd\uf3da\uf3da\uf3d1\uf39f\uf3db\uf3da\uf3dc\uf3cd\uf3c6\uf3cf\uf3cb\uf3da\uf3db\uf393\uf39f\uf3d2\uf3de\uf3d4\uf3da\uf39f\uf3cc\uf3ca\uf3cd\uf3da\uf39f\uf3c6\uf3d0\uf3ca\uf39f\uf3cb\uf3ca\uf3cd\uf3d1\uf39f\uf3d0\uf3d9\uf3d9\uf39f\uf3de\uf3d3\uf3d3\uf39f\uf3de\uf3d1\uf3cb\uf3d6\uf3c9\uf3d6\uf3cd\uf3ca\uf3cc\uf39f\uf3de\uf3d1\uf3db\uf39f\uf3e8\uf3d6\uf3d1\uf3db\uf3d0\uf3c8\uf3cc\uf39f\uf3fb\uf3da\uf3d9\uf3da\uf3d1\uf3db\uf3da\uf3cd\uf393\uf39f\uf3cb\uf3d7\uf3da\uf3d1\uf39f\uf3cb\uf3cd\uf3c6\uf39f\uf3db\uf3da\uf3dc\uf3cd\uf3c6\uf3cf\uf3cb\uf3d6\uf3d1\uf3d8\uf39f\uf3de\uf3d8\uf3de\uf3d6\uf3d1\uf391\uf39f\uf3b2\uf3b5\uf3f6\uf3d9\uf39f\uf3d6\uf3cb\uf39f\uf3db\uf3d0\uf3da\uf3cc\uf3d1\uf398\uf3cb\uf39f\uf3c8\uf3d0\uf3cd\uf3d4\uf393\uf39f\uf3db\uf3da\uf3d3\uf3da\uf3cb\uf3da\uf39f\uf3de\uf3d3\uf3d3\uf39f\uf3fb\uf3da\uf3cc\uf3d4\uf3cb\uf3d0\uf3cf\uf391\uf3d6\uf3d1\uf3d6\uf391\uf3d8\uf3d6\uf3c9\uf3da\uf3d2\uf3da\uf3d1\uf3d6\uf3cb\uf3cd\uf3d0\uf39f\uf3d9\uf3d6\uf3d3\uf3da\uf3cc\uf39f\uf3cb\uf3d7\uf3de\uf3cb\uf39f\uf3c6\uf3d0\uf3ca\uf39f\uf3cc\uf3da\uf3da\uf39f\uf3de\uf3d1\uf3db\uf39f\uf3cb\uf3cd\uf3c6\uf39f\uf3de\uf3d8\uf3de\uf3d6\uf3d1\uf391", 62265), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else
		{
			MessageBox.Show(Class11.smethod_0("\ue4b4\ue493\ue48b\ue49c\ue491\ue494\ue499\ue4dd\ue496\ue498\ue484", 58608), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	private bool method_1()
	{
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		Class9 @class = new Class9(Class4.string_3);
		string text = ((Control)textBox_2).get_Text();
		string empty = string.Empty;
		Console.WriteLine(text);
		if (text.Contains(Class11.smethod_0("\ue899\ue894\ue88e\ue89e\ue892\ue88f\ue899\ue8d3\ue89a\ue894\ue89b\ue889\ue8d2", 59504)))
		{
			if (text.Contains(Class11.smethod_0("\ue79b\ue787\ue787\ue783\ue780\ue7c9\ue7dc\ue7dc", 59329)))
			{
				int num = text.IndexOf(Class11.smethod_0("\ue154", 57722));
				empty = text.Substring(num + 15);
				Console.WriteLine(empty);
			}
			else
			{
				int num2 = text.IndexOf(Class11.smethod_0("\ue154", 57722));
				empty = text.Substring(num2 + 1);
				MessageBox.Show(Class11.smethod_0("\uefb0\uef9b\uef96\uef90\uef98\uef9a\uef9d\uef94\uefd3\uef94\uef9a\uef95\uef87\uefd3\uef85\uef92\uef9f\uef9a\uef97\uef9a\uef87\uef8a\uefdd\uefdd\uefd3\uefdd", 61265), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)64);
			}
			if (Class3.smethod_0(empty))
			{
				@class.method_0(Class11.smethod_0("\ue6df\ue6df\ue6a3\ue694\ue699\ue69c\ue691\ue6d5\ue69b\ue69c\ue681\ue687\ue69a\ue6d5\ue696\ue69a\ue691\ue690\ue6d5\ue682\ue694\ue686\ue6d5\ue687\ue690\ue696\ue690\ue69c\ue683\ue690\ue691\ue6df\ue6df", 59029));
				@class.method_0(text);
				MessageBox.Show(Class11.smethod_0("\uefac\uef8a\uef9c\uef9c\uef9a\uef8c\uef8c\uefde\uefdf\uefa9\uef9e\uef93\uef96\uef9b\uefdf\uef91\uef96\uef8b\uef8d\uef90\uefdf\uef9c\uef90\uef9b\uef9a\uefdf\uef88\uef9e\uef8c\uefdf\uef8c\uef9a\uef91\uef8b\uefd1\uefdf\uefa6\uef90\uef8a\uef8d\uefdf\uef9b\uef9a\uef9c\uef8d\uef86\uef8f\uef8b\uef96\uef90\uef91\uefdf\uef94\uef9a\uef86\uefdf\uef96\uef8c\uefdf\uef91\uef90\uef88\uefdf\uef9e\uef89\uef9e\uef96\uef93\uef9e\uef9d\uef93\uef9a\uefd1\uefdf\uefa6\uef90\uef8a\uefdf\uef92\uef9e\uef86\uefdf\uef8c\uef8b\uef9e\uef8d\uef8b\uefdf\uef9b\uef9a\uef9c\uef8d\uef86\uef8f\uef8b\uef96\uef91\uef98\uefdf\uef86\uef90\uef8a\uef8d\uefdf\uef99\uef96\uef93\uef9a\uef8c\uefdf\uef91\uef90\uef88\uefd1", 61415), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)64);
				return true;
			}
			@class.method_0(Class11.smethod_0("\uf3bd\uf3bd\uf3bd\uf388\uf3ae\uf3b8\uf3af\uf3fd\uf3ae\uf3b8\uf3b3\uf3a9\uf3fd\uf3b4\uf3b3\uf3ab\uf3bc\uf3b1\uf3b4\uf3b9\uf3fd\uf3b9\uf3b4\uf3ae\uf3be\uf3b2\uf3af\uf3b9\uf3fd\uf3ba\uf3b4\uf3bb\uf3a9\uf3fd\uf391\uf3b4\uf3b3\uf3b6\uf3f3\uf3bd\uf3bd\uf3bd", 62272));
			MessageBox.Show(Class11.smethod_0("\ue6b6\ue691\ue689\ue69e\ue693\ue696\ue69b\ue6df\ue6b1\ue696\ue68b\ue68d\ue690", 59119), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			@class.method_0(Class11.smethod_0("\uf3bd\uf3bd\uf3bd\uf388\uf3ae\uf3b8\uf3af\uf3fd\uf3ae\uf3b8\uf3b3\uf3a9\uf3fd\uf3b4\uf3b3\uf3ab\uf3bc\uf3b1\uf3b4\uf3b9\uf3fd\uf3b9\uf3b4\uf3ae\uf3be\uf3b2\uf3af\uf3b9\uf3fd\uf3ba\uf3b4\uf3bb\uf3a9\uf3fd\uf391\uf3b4\uf3b3\uf3b6\uf3f3\uf3bd\uf3bd\uf3bd", 62272));
			MessageBox.Show(Class11.smethod_0("\ue88f\ue8b3\ue8ba\ue8be\ue8ac\ue8ba\ue8ff\ue8ba\ue8b1\ue8ab\ue8ba\ue8ad\ue8ff\ue8be\ue8ff\ue89b\ue8b6\ue8ac\ue8bc\ue8b0\ue8ad\ue8bb\ue8ff\ue8b1\ue8b6\ue8ab\ue8ad\ue8b0\ue8ff\ue8b8\ue8b6\ue8b9\ue8ab\ue8ff\ue8b6\ue8b1\ue8ff\ue8ab\ue8b7\ue8b6\ue8ac\ue8ff\ue8b9\ue8b0\ue8ad\ue8b2\ue8be\ue8ab\ue8ff\ue8bb\ue8b6\ue8ac\ue8bc\ue8b0\ue8ad\ue8bb\ue8f1\ue8b8\ue8b6\ue8b9\ue8ab\ue8f0\ue8bc\ue8b0\ue8bb\ue8ba\ue8ff\ue8b7\ue8ba\ue8ad\ue8ba", 59607), Class11.smethod_0("\ueb75\ueb52\ueb4f\ueb49\ueb54\ueb1b\ueb69\ueb5a\ueb55\ueb48\ueb54\ueb56\ueb4c\ueb5a\ueb49\ueb5e", 60171), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		return false;
	}

	private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			if (int_2 < 1)
			{
				int_2 = 59;
				if (int_1 == 0)
				{
					int_1 = 59;
					if (int_0 != 0)
					{
						int_0--;
					}
				}
				else
				{
					int_1--;
				}
			}
			else
			{
				int_2--;
			}
			if (int_2 != 0 || int_1 != 0 || int_0 != 0)
			{
			}
			((Control)label_8).set_Text(string.Format(Class11.smethod_0("\ue890\ue8db\ue896\ue8d1\ue890\ue8da\ue896\ue8d1\ue890\ue8d9\ue896", 59619), int_0.ToString().PadLeft(2, '0'), int_1.ToString().PadLeft(2, '0'), int_2.ToString().PadLeft(2, '0')));
		});
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_2()
	{
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
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_054a: Expected O, but got Unknown
		//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Expected O, but got Unknown
		//IL_07ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f8: Expected O, but got Unknown
		//IL_0aaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab4: Expected O, but got Unknown
		//IL_0b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b69: Expected O, but got Unknown
		//IL_0c27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c31: Expected O, but got Unknown
		//IL_0d6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d77: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		backgroundWorker_0 = new BackgroundWorker();
		label_0 = new Label();
		textBox_0 = new TextBox();
		label_1 = new Label();
		label_2 = new Label();
		panel_0 = new Panel();
		panel_1 = new Panel();
		label_3 = new Label();
		button_0 = new Button();
		label_4 = new Label();
		textBox_1 = new TextBox();
		label_5 = new Label();
		button_1 = new Button();
		textBox_2 = new TextBox();
		textBox_3 = new TextBox();
		label_6 = new Label();
		label_7 = new Label();
		textBox_4 = new TextBox();
		panel_2 = new Panel();
		label_8 = new Label();
		((Control)panel_1).SuspendLayout();
		((Control)panel_2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Font(new Font(Class11.smethod_0("\uf2b8\uf29c\uf296\uf287\uf29a\uf286\uf29a\uf293\uf281\uf2d5\uf2a6\uf294\uf29b\uf286\uf2d5\uf2a6\uf290\uf287\uf29c\uf293", 62197), 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_ForeColor(Color.Red);
		((Control)label_0).set_Location(new Point(25, 19));
		((Control)label_0).set_Name(Class11.smethod_0("\ue9ba\ue9b7\ue9b4\ue9b3\ue9ba\ue9e7", 59860));
		((Control)label_0).set_Size(new Size(579, 37));
		((Control)label_0).set_TabIndex(2);
		((Control)label_0).set_Text(Class11.smethod_0("\ueccb\ueca4\uec83\ueccb\uec85\uec84\uecca\ueccb\uecb2\uec84\uec9e\uec99\ueccb\uec8d\uec82\uec87\uec8e\uec98\ueccb\uec83\uec8a\uec9d\uec8e\ueccb\uec89\uec8e\uec8e\uec85\ueccb\uec8e\uec85\uec88\uec99\uec92\uec9b\uec9f\uec8e\uec8f\uecc5", 60650));
		((Control)textBox_0).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox_0).set_BorderStyle((BorderStyle)0);
		((Control)textBox_0).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox_0).set_Location(new Point(404, 134));
		((TextBoxBase)textBox_0).set_Multiline(true);
		((Control)textBox_0).set_Name(Class11.smethod_0("\uebeb\uebfa\uebe7\uebeb\uebdd\uebf0\uebe7\uebae", 60303));
		((TextBoxBase)textBox_0).set_ReadOnly(true);
		textBox_0.set_ScrollBars((ScrollBars)2);
		((Control)textBox_0).set_Size(new Size(370, 289));
		((Control)textBox_0).set_TabIndex(3);
		((Control)textBox_0).set_TabStop(false);
		((Control)textBox_0).set_Text(componentResourceManager.GetString(Class11.smethod_0("\uf0ab\uf0ba\uf0a7\uf0ab\uf09d\uf0b0\uf0a7\uf0ee\uf0f1\uf08b\uf0ba\uf0a7\uf0ab", 61513)));
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_ForeColor(SystemColors.Control);
		((Control)label_1).set_Location(new Point(553, 96));
		((Control)label_1).set_Name(Class11.smethod_0("\ue393\ue39e\ue39d\ue39a\ue393\ue3cd", 58233));
		((Control)label_1).set_Size(new Size(45, 25));
		((Control)label_1).set_TabIndex(5);
		((Control)label_1).set_Text(Class11.smethod_0("\ue7d7\ue7f0\ue7f8\ue7f1", 59142));
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_ForeColor(SystemColors.Control);
		((Control)label_2).set_Location(new Point(127, 96));
		((Control)label_2).set_Name(Class11.smethod_0("\uea19\uea14\uea17\uea10\uea19\uea46", 59957));
		((Control)label_2).set_Size(new Size(147, 25));
		((Control)label_2).set_TabIndex(6);
		((Control)label_2).set_Text(Class11.smethod_0("\uf0eb\uf0d6\uf0d2\uf0da\uf09f\uf0ed\uf0da\uf0d2\uf0de\uf0d6\uf0d1\uf0d6\uf0d1\uf0d8", 61470));
		((Control)panel_0).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel_0).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel_0).set_Location(new Point(-1, -4));
		((Control)panel_0).set_Name(Class11.smethod_0("\uee6f\uee7e\uee71\uee7a\uee73\uee2e", 60959));
		((Control)panel_0).set_Size(new Size(807, 32));
		((Control)panel_0).set_TabIndex(4);
		((Control)panel_1).set_BackColor(Color.FromArgb(35, 39, 42));
		((Control)panel_1).get_Controls().Add((Control)(object)label_0);
		((Control)panel_1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)panel_1).set_Location(new Point(87, -1));
		((Control)panel_1).set_Name(Class11.smethod_0("\uf4ab\uf4ba\uf4b5\uf4be\uf4b7\uf4e9", 62618));
		((Control)panel_1).set_Size(new Size(613, 67));
		((Control)panel_1).set_TabIndex(7);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_ForeColor(SystemColors.Control);
		((Control)label_3).set_Location(new Point(84, 454));
		((Control)label_3).set_Name(Class11.smethod_0("\ue8c7\ue8ca\ue8c9\ue8ce\ue8c7\ue89f", 59555));
		((Control)label_3).set_Size(new Size(151, 13));
		((Control)label_3).set_TabIndex(9);
		((Control)label_3).set_Text(Class11.smethod_0("\uf2b6\uf29d\uf287\uf296\uf281\uf2d3\uf2b7\uf29a\uf280\uf290\uf29c\uf281\uf297\uf2d3\uf2bd\uf29a\uf287\uf281\uf29c\uf2d3\uf294\uf29a\uf295\uf287\uf290\uf29c\uf297\uf296", 62145));
		((Control)button_0).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Location(new Point(258, 480));
		((Control)button_0).set_Name(Class11.smethod_0("\uec9f\uec88\uec89\uec89\uec92\uec93\ueccc", 60476));
		((Control)button_0).set_Size(new Size(75, 23));
		((Control)button_0).set_TabIndex(10);
		((Control)button_0).set_Text(Class11.smethod_0("\uef9c\uefbe\uefaf\ueffb\uef90\uefbe\uefa2", 61402));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_ForeColor(SystemColors.Control);
		((Control)label_4).set_Location(new Point(84, 526));
		((Control)label_4).set_Name(Class11.smethod_0("\ue3f3\ue3fe\ue3fd\ue3fa\ue3f3\ue3aa", 58255));
		((Control)label_4).set_Size(new Size(122, 13));
		((Control)label_4).set_TabIndex(11);
		((Control)label_4).set_Text(Class11.smethod_0("\ueaa4\uea92\uea88\uea8f\ueadd\ueab9\uea98\uea9e\uea8f\uea84\uea8d\uea89\uea94\uea92\uea93\ueadd\uea96\uea98\uea84\ueadd\uea94\uea8e\ueac7", 60120));
		((Control)textBox_1).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox_1).set_BorderStyle((BorderStyle)1);
		((Control)textBox_1).set_ForeColor(SystemColors.Window);
		((Control)textBox_1).set_Location(new Point(71, 545));
		((Control)textBox_1).set_Name(Class11.smethod_0("\ue68b\ue69a\ue687\ue68b\ue6bd\ue690\ue687\ue6cc", 59006));
		((TextBoxBase)textBox_1).set_ReadOnly(true);
		((Control)textBox_1).set_Size(new Size(203, 20));
		((Control)textBox_1).set_TabIndex(12);
		((Control)textBox_1).set_TabStop(false);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_ForeColor(SystemColors.Control);
		((Control)label_5).set_Location(new Point(550, 448));
		((Control)label_5).set_Name(Class11.smethod_0("\uf287\uf28a\uf289\uf28e\uf287\uf2dd", 62179));
		((Control)label_5).set_Size(new Size(84, 19));
		((Control)label_5).set_TabIndex(13);
		((Control)label_5).set_Text(Class11.smethod_0("\uf0fa\uf0db\uf0dd\uf0cc\uf0c7\uf0ce\uf0ca\uf09e\uf0d8\uf0d7\uf0d2\uf0db\uf0cd", 61478));
		((Control)button_1).set_BackColor(SystemColors.ButtonHighlight);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)0);
		((Control)button_1).set_Location(new Point(657, 516));
		((Control)button_1).set_Name(Class11.smethod_0("\ue0af\ue0b8\ue0b9\ue0b9\ue0a2\ue0a3\ue0ff", 57548));
		((Control)button_1).set_Size(new Size(75, 23));
		((Control)button_1).set_TabIndex(15);
		((Control)button_1).set_Text(Class11.smethod_0("\uf0fa\uf0db\uf0dd\uf0cc\uf0c7\uf0ce\uf0ca\uf09e\uf0d8\uf0d7\uf0d2\uf0db\uf0cd", 61478));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)textBox_2).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox_2).set_BorderStyle((BorderStyle)1);
		((Control)textBox_2).set_ForeColor(SystemColors.Window);
		((Control)textBox_2).set_Location(new Point(49, 482));
		((Control)textBox_2).set_Name(Class11.smethod_0("\ueaeb\ueafa\ueae7\ueaeb\ueadd\ueaf0\ueae7\ueaad", 60057));
		((Control)textBox_2).set_Size(new Size(203, 20));
		((Control)textBox_2).set_TabIndex(8);
		((Control)textBox_2).set_TabStop(false);
		((Control)textBox_2).set_Text(Class11.smethod_0("\uef99\uef94\uef8e\uef9e\uef92\uef8f\uef99\uefd3\uef9a\uef94\uef9b\uef89\uefd2\uef98\uef85\uef9c\uef90\uef8d\uef91\uef98", 61373));
		((Control)textBox_3).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox_3).set_BorderStyle((BorderStyle)1);
		((Control)textBox_3).set_ForeColor(SystemColors.Window);
		((Control)textBox_3).set_Location(new Point(448, 516));
		((Control)textBox_3).set_Name(Class11.smethod_0("\ueacb\ueada\ueac7\ueacb\ueafd\uead0\ueac7\uea8b", 60087));
		((Control)textBox_3).set_Size(new Size(203, 20));
		((Control)textBox_3).set_TabIndex(17);
		((Control)textBox_3).set_TabStop(false);
		((Control)textBox_3).set_Text(Class11.smethod_0("\uf2ae\uf2b8\uf2b3\uf2b9\uf2fd\uf2b9\uf2b4\uf2ae\uf2be\uf2b2\uf2af\uf2b9\uf2fd\uf2b3\uf2b4\uf2a9\uf2af\uf2b2\uf2fd\uf2a9\uf2b2\uf2fd\uf2ba\uf2b8\uf2a9\uf2fd\uf2b6\uf2b8\uf2a4", 61980));
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_6).set_ForeColor(SystemColors.Control);
		((Control)label_6).set_Location(new Point(445, 485));
		((Control)label_6).set_Name(Class11.smethod_0("\ue6da\ue6d7\ue6d4\ue6d3\ue6da\ue681", 59060));
		((Control)label_6).set_Size(new Size(236, 13));
		((Control)label_6).set_TabIndex(16);
		((Control)label_6).set_Text(Class11.smethod_0("\uf6e8\uf6de\uf6cd\uf6d1\uf6d6\uf6d1\uf6d8\uf685\uf69f\uf6fb\uf6d0\uf69f\uf6d1\uf6d0\uf6cb\uf69f\uf6cb\uf6cd\uf6c6\uf69f\uf6d8\uf6ca\uf6da\uf6cc\uf6cc\uf6d6\uf6d1\uf6d8\uf69f\uf6cb\uf6d7\uf6da\uf69f\uf6cf\uf6de\uf6cc\uf6cc\uf6c8\uf6d0\uf6cd\uf6db\uf691", 63166));
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_7).set_ForeColor(SystemColors.Control);
		((Control)label_7).set_Location(new Point(174, 329));
		((Control)label_7).set_Name(Class11.smethod_0("\ue107\ue10a\ue109\ue10e\ue107\ue152", 57699));
		((Control)label_7).set_Size(new Size(32, 19));
		((Control)label_7).set_TabIndex(19);
		((Control)label_7).set_Text(Class11.smethod_0("\ue237\ue214\ue21c", 57931));
		((Control)textBox_4).set_BackColor(Color.FromArgb(35, 39, 42));
		((TextBoxBase)textBox_4).set_BorderStyle((BorderStyle)0);
		((Control)textBox_4).set_Font(new Font(Class11.smethod_0("\uf671\uf647\uf645\uf64d\uf647\uf602\uf677\uf66b", 63010), 7.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_4).set_ForeColor(SystemColors.MenuBar);
		((Control)textBox_4).set_Location(new Point(35, 364));
		((TextBoxBase)textBox_4).set_Multiline(true);
		((Control)textBox_4).set_Name(Class11.smethod_0("\uec91\uec80\uec9d\uec91\ueca7\uec8a\uec9d\uecd0", 60581));
		((TextBoxBase)textBox_4).set_ReadOnly(true);
		textBox_4.set_ScrollBars((ScrollBars)2);
		((Control)textBox_4).set_Size(new Size(347, 59));
		((Control)textBox_4).set_TabIndex(20);
		((Control)textBox_4).set_TabStop(false);
		((Control)panel_2).set_BackColor(Color.Crimson);
		((Control)panel_2).get_Controls().Add((Control)(object)label_8);
		((Control)panel_2).set_Location(new Point(35, 134));
		((Control)panel_2).set_Name(Class11.smethod_0("\ue29b\ue28a\ue285\ue28e\ue287\ue2d8", 58026));
		((Control)panel_2).set_Size(new Size(347, 178));
		((Control)panel_2).set_TabIndex(21);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Font(new Font(Class11.smethod_0("\uf2b8\uf29c\uf296\uf287\uf29a\uf286\uf29a\uf293\uf281\uf2d5\uf2a6\uf294\uf29b\uf286\uf2d5\uf2a6\uf290\uf287\uf29c\uf293", 62197), 50f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_8).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label_8).set_Location(new Point(23, 47));
		((Control)label_8).set_Name(Class11.smethod_0("\uedd7\uedda\uedd9\uedde\uedd7\ued8a\ued8b", 60843));
		((Control)label_8).set_Size(new Size(293, 76));
		((Control)label_8).set_TabIndex(22);
		((Control)label_8).set_Text(Class11.smethod_0("\uf6cf\uf6cf\uf6c5\uf6cf\uf6cf\uf6c5\uf6cf\uf6cf", 63086));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(44, 47, 51));
		((Form)this).set_ClientSize(new Size(800, 600));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)panel_2);
		((Control)this).get_Controls().Add((Control)(object)textBox_4);
		((Control)this).get_Controls().Add((Control)(object)label_7);
		((Control)this).get_Controls().Add((Control)(object)textBox_3);
		((Control)this).get_Controls().Add((Control)(object)label_6);
		((Control)this).get_Controls().Add((Control)(object)button_1);
		((Control)this).get_Controls().Add((Control)(object)label_5);
		((Control)this).get_Controls().Add((Control)(object)textBox_1);
		((Control)this).get_Controls().Add((Control)(object)label_4);
		((Control)this).get_Controls().Add((Control)(object)button_0);
		((Control)this).get_Controls().Add((Control)(object)label_3);
		((Control)this).get_Controls().Add((Control)(object)textBox_2);
		((Control)this).get_Controls().Add((Control)(object)label_2);
		((Control)this).get_Controls().Add((Control)(object)label_1);
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)panel_1);
		((Control)this).get_Controls().Add((Control)(object)panel_0);
		((Control)this).set_ForeColor(SystemColors.ControlText);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name(Class11.smethod_0("\uf5f8\uf5d1\uf5cc\uf5d3\uf58f", 62886));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class11.smethod_0("\uf5f8\uf5d1\uf5cc\uf5d3\uf58f", 62886));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)panel_1).ResumeLayout(false);
		((Control)panel_1).PerformLayout();
		((Control)panel_2).ResumeLayout(false);
		((Control)panel_2).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[CompilerGenerated]
	private void method_3()
	{
		if (int_2 < 1)
		{
			int_2 = 59;
			if (int_1 == 0)
			{
				int_1 = 59;
				if (int_0 != 0)
				{
					int_0--;
				}
			}
			else
			{
				int_1--;
			}
		}
		else
		{
			int_2--;
		}
		if (int_2 != 0 || int_1 != 0 || int_0 != 0)
		{
		}
		((Control)label_8).set_Text(string.Format(Class11.smethod_0("\ue890\ue8db\ue896\ue8d1\ue890\ue8da\ue896\ue8d1\ue890\ue8d9\ue896", 59619), int_0.ToString().PadLeft(2, '0'), int_1.ToString().PadLeft(2, '0'), int_2.ToString().PadLeft(2, '0')));
	}
}
