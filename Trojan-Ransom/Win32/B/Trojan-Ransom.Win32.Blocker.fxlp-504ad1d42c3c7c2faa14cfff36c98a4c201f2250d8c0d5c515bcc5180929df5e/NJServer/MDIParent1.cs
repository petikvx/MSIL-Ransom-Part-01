using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using NJServer.My;
using ns0;

namespace NJServer;

[DesignerGenerated]
public class MDIParent1 : Form
{
	private static List<WeakReference> list_0;

	internal IContainer icontainer_0;

	internal ToolStripMenuItem toolStripMenuItem_0;

	internal ToolStripMenuItem toolStripMenuItem_1;

	internal ToolStripMenuItem toolStripMenuItem_2;

	internal ToolStripMenuItem toolStripMenuItem_3;

	internal ToolStripSeparator toolStripSeparator_0;

	internal ToolStripMenuItem toolStripMenuItem_4;

	internal ToolStripMenuItem toolStripMenuItem_5;

	internal ToolStripMenuItem toolStripMenuItem_6;

	internal ToolStripMenuItem toolStripMenuItem_7;

	internal ToolStripMenuItem toolStripMenuItem_8;

	internal ToolStripMenuItem toolStripMenuItem_9;

	internal ToolStripMenuItem toolStripMenuItem_10;

	internal ToolStripMenuItem toolStripMenuItem_11;

	internal ToolStripMenuItem toolStripMenuItem_12;

	internal ToolStripButton toolStripButton_0;

	internal ToolStripSeparator toolStripSeparator_1;

	internal ToolStripButton toolStripButton_1;

	internal ToolTip toolTip_0;

	internal ToolStripStatusLabel toolStripStatusLabel_0;

	internal StatusStrip statusStrip_0;

	internal ToolStripButton toolStripButton_2;

	internal ToolStripButton toolStripButton_3;

	internal ToolStrip toolStrip_0;

	internal ToolStripButton toolStripButton_4;

	internal ToolStripButton toolStripButton_5;

	internal ToolStripSeparator toolStripSeparator_2;

	internal ToolStripMenuItem toolStripMenuItem_13;

	internal ToolStripMenuItem toolStripMenuItem_14;

	internal ToolStripSeparator toolStripSeparator_3;

	internal ToolStripMenuItem toolStripMenuItem_15;

	internal ToolStripSeparator toolStripSeparator_4;

	internal ToolStripMenuItem toolStripMenuItem_16;

	internal ToolStripMenuItem toolStripMenuItem_17;

	internal ToolStripMenuItem toolStripMenuItem_18;

	internal ToolStripMenuItem toolStripMenuItem_19;

	internal ToolStripMenuItem toolStripMenuItem_20;

	internal ToolStripSeparator toolStripSeparator_5;

	internal ToolStripMenuItem toolStripMenuItem_21;

	internal MenuStrip menuStrip_0;

	internal ToolStripMenuItem toolStripMenuItem_22;

	internal ToolStripMenuItem toolStripMenuItem_23;

	internal ToolStripMenuItem toolStripMenuItem_24;

	internal ToolStripSeparator toolStripSeparator_6;

	internal ToolStripMenuItem toolStripMenuItem_25;

	internal ToolStripMenuItem toolStripMenuItem_26;

	internal ToolStripMenuItem toolStripMenuItem_27;

	internal ToolStripSeparator toolStripSeparator_7;

	internal ToolStripMenuItem toolStripMenuItem_28;

	internal ToolStripMenuItem toolStripMenuItem_29;

	internal ToolStripMenuItem toolStripMenuItem_30;

	internal ToolStripMenuItem toolStripMenuItem_31;

	internal ToolStripMenuItem toolStripMenuItem_32;

	internal int int_0;

	static MDIParent1()
	{
		Class3.smethod_15();
		list_0 = new List<WeakReference>();
	}

	public MDIParent1()
	{
		smethod_0(this);
		InitializeComponent();
	}

	private static void smethod_0(object object_0)
	{
		List<WeakReference> list = list_0;
		Class3.Class4.Class5.smethod_5(list, 777, 876);
		checked
		{
			try
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
						WeakReference weakReference_ = list_0[num3];
						if (Class3.Class4.Class5.smethod_6(weakReference_, 386, 394))
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
				list_0.Add(new WeakReference(Class3.smethod_4(object_0, 478, 509)));
			}
			finally
			{
				Monitor.Exit(list);
			}
		}
	}

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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0211: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_025e: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_0688: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c: Expected O, but got Unknown
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0942: Expected O, but got Unknown
		//IL_0aa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aba: Expected O, but got Unknown
		//IL_0b33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b47: Expected O, but got Unknown
		//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bde: Expected O, but got Unknown
		//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c55: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Expected O, but got Unknown
		//IL_0efb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0f: Expected O, but got Unknown
		//IL_0f99: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Expected O, but got Unknown
		//IL_1183: Unknown result type (might be due to invalid IL or missing references)
		//IL_118d: Expected O, but got Unknown
		//IL_11de: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Expected O, but got Unknown
		//IL_1249: Unknown result type (might be due to invalid IL or missing references)
		//IL_1253: Expected O, but got Unknown
		//IL_12a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ae: Expected O, but got Unknown
		//IL_12ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_1309: Expected O, but got Unknown
		IContainer container = (icontainer_0 = new Container());
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(Class3.smethod_5(typeof(MDIParent1).TypeHandle, 929, 944));
		vmethod_77(new MenuStrip());
		vmethod_45(new ToolStrip());
		vmethod_39(new StatusStrip());
		vmethod_1(new ToolStripMenuItem());
		vmethod_3(new ToolStripMenuItem());
		vmethod_5(new ToolStripMenuItem());
		vmethod_7(new ToolStripMenuItem());
		vmethod_9(new ToolStripSeparator());
		vmethod_11(new ToolStripMenuItem());
		vmethod_13(new ToolStripMenuItem());
		vmethod_15(new ToolStripMenuItem());
		vmethod_17(new ToolStripMenuItem());
		vmethod_19(new ToolStripMenuItem());
		vmethod_21(new ToolStripMenuItem());
		vmethod_23(new ToolStripMenuItem());
		vmethod_25(new ToolStripMenuItem());
		vmethod_27(new ToolStripMenuItem());
		vmethod_29(new ToolStripButton());
		vmethod_31(new ToolStripSeparator());
		vmethod_33(new ToolStripButton());
		vmethod_35(new ToolTip(icontainer_0));
		vmethod_37(new ToolStripStatusLabel());
		vmethod_41(new ToolStripButton());
		vmethod_43(new ToolStripButton());
		vmethod_47(new ToolStripButton());
		vmethod_49(new ToolStripButton());
		vmethod_51(new ToolStripSeparator());
		vmethod_53(new ToolStripMenuItem());
		vmethod_55(new ToolStripMenuItem());
		vmethod_57(new ToolStripSeparator());
		vmethod_59(new ToolStripMenuItem());
		vmethod_61(new ToolStripSeparator());
		vmethod_63(new ToolStripMenuItem());
		vmethod_65(new ToolStripMenuItem());
		vmethod_67(new ToolStripMenuItem());
		vmethod_69(new ToolStripMenuItem());
		vmethod_71(new ToolStripMenuItem());
		vmethod_73(new ToolStripSeparator());
		vmethod_75(new ToolStripMenuItem());
		vmethod_79(new ToolStripMenuItem());
		vmethod_81(new ToolStripMenuItem());
		vmethod_83(new ToolStripMenuItem());
		vmethod_85(new ToolStripSeparator());
		vmethod_87(new ToolStripMenuItem());
		vmethod_89(new ToolStripMenuItem());
		vmethod_91(new ToolStripMenuItem());
		vmethod_93(new ToolStripSeparator());
		vmethod_95(new ToolStripMenuItem());
		vmethod_97(new ToolStripMenuItem());
		vmethod_99(new ToolStripMenuItem());
		vmethod_101(new ToolStripMenuItem());
		vmethod_103(new ToolStripMenuItem());
		Class3.Class4.Class5.smethod_7((Control)(object)vmethod_38(), 286, 274);
		Class3.Class4.Class5.smethod_7((Control)(object)vmethod_44(), 268, 256);
		Class3.Class4.Class5.smethod_7((Control)(object)vmethod_76(), 959, 947);
		Class3.Class4.Class5.smethod_7((Control)(object)this, 763, 759);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_0(), "ContentsToolStripMenuItem", 479, 464);
		Class3.Class4.Class5.smethod_9(vmethod_0(), (Keys)131184, 596, 533);
		((ToolStripItem)vmethod_0()).set_Text("&Contents");
		Class3.smethod_8(Class3.Class4.smethod_2((ToolStripDropDownItem)(object)vmethod_2(), 21, 26), (ToolStripItem[])(object)new ToolStripItem[5]
		{
			(ToolStripItem)vmethod_0(),
			(ToolStripItem)vmethod_4(),
			(ToolStripItem)vmethod_6(),
			(ToolStripItem)vmethod_8(),
			(ToolStripItem)vmethod_10()
		}, 74, 57);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_2(), "HelpMenu", 695, 696);
		((ToolStripItem)vmethod_2()).set_Text("&Help");
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_4(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "IndexToolStripMenuItem.Image", 502, 457), 728, 655);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_4(), Class3.smethod_9(305, 257), 146, 141);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_4(), "IndexToolStripMenuItem", 721, 734);
		((ToolStripItem)vmethod_4()).set_Text("&Index");
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_6(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "SearchToolStripMenuItem.Image", 1019, 964), 108, 59);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_6(), Class3.smethod_9(291, 275), 181, 170);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_6(), "SearchToolStripMenuItem", 810, 805);
		((ToolStripItem)vmethod_6()).set_Text("&Search");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_8(), "ToolStripSeparator8", 693, 698);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_10(), "AboutToolStripMenuItem", 693, 698);
		((ToolStripItem)vmethod_10()).set_Text("&About ...");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_12(), "ArrangeIconsToolStripMenuItem", 908, 899);
		((ToolStripItem)vmethod_12()).set_Text("&Arrange Icons");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_14(), "CloseAllToolStripMenuItem", 398, 385);
		((ToolStripItem)vmethod_14()).set_Text("C&lose All");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_16(), "NewWindowToolStripMenuItem", 211, 220);
		((ToolStripItem)vmethod_16()).set_Text("&New Window");
		Class3.smethod_8(Class3.Class4.smethod_2((ToolStripDropDownItem)(object)vmethod_18(), 978, 989), (ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)vmethod_16(),
			(ToolStripItem)vmethod_20(),
			(ToolStripItem)vmethod_22(),
			(ToolStripItem)vmethod_24(),
			(ToolStripItem)vmethod_14(),
			(ToolStripItem)vmethod_12()
		}, 897, 1010);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_18(), "WindowsMenu", 767, 752);
		((ToolStripItem)vmethod_18()).set_Text("&Windows");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_20(), "CascadeToolStripMenuItem", 645, 650);
		((ToolStripItem)vmethod_20()).set_Text("&Cascade");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_22(), "TileVerticalToolStripMenuItem", 622, 609);
		((ToolStripItem)vmethod_22()).set_Text("Tile &Vertical");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_24(), "TileHorizontalToolStripMenuItem", 817, 830);
		((ToolStripItem)vmethod_24()).set_Text("Tile &Horizontal");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_26(), "OptionsToolStripMenuItem", 798, 785);
		((ToolStripItem)vmethod_26()).set_Text("&Options");
		Class3.Class4.Class5.smethod_11((ToolStripItem)(object)vmethod_28(), (ToolStripItemDisplayStyle)2, 790, 804);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_28(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "HelpToolStripButton.Image", 26, 37), 903, 976);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_28(), Class3.smethod_9(484, 468), 78, 81);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_28(), "HelpToolStripButton", 586, 581);
		((ToolStripItem)vmethod_28()).set_Text("Help");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_30(), "ToolStripSeparator2", 709, 714);
		Class3.Class4.Class5.smethod_11((ToolStripItem)(object)vmethod_32(), (ToolStripItemDisplayStyle)2, 129, 179);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_32(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "PrintPreviewToolStripButton.Image", 676, 667), 832, 791);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_32(), Class3.smethod_9(532, 548), 364, 371);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_32(), "PrintPreviewToolStripButton", 817, 830);
		((ToolStripItem)vmethod_32()).set_Text("Print Preview");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_36(), "ToolStripStatusLabel", 789, 794);
		((ToolStripItem)vmethod_36()).set_Text("Status");
		Class3.smethod_8(Class3.Class4.smethod_5((ToolStrip)(object)vmethod_38(), 868, 784), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)vmethod_36() }, 511, 396);
		vmethod_38().set_LayoutStyle((ToolStripLayoutStyle)4);
		StatusStrip control_ = vmethod_38();
		Point point_ = new Point(0, 433);
		Class3.smethod_10((Control)(object)control_, point_, 11, 107);
		Class3.smethod_11((Control)(object)vmethod_38(), "StatusStrip", 970, 934);
		StatusStrip obj = vmethod_38();
		Size size = new Size(632, 20);
		((Control)obj).set_Size(size);
		((Control)vmethod_38()).set_TabIndex(7);
		((Control)vmethod_38()).set_Text("StatusStrip");
		Class3.Class4.Class5.smethod_11((ToolStripItem)(object)vmethod_40(), (ToolStripItemDisplayStyle)2, 837, 887);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_40(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "PrintToolStripButton.Image", 769, 830), 257, 342);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_40(), Class3.smethod_9(352, 336), 518, 537);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_40(), "PrintToolStripButton", 667, 660);
		((ToolStripItem)vmethod_40()).set_Text("Print");
		Class3.Class4.Class5.smethod_11((ToolStripItem)(object)vmethod_42(), (ToolStripItemDisplayStyle)2, 607, 621);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_42(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "NewToolStripButton.Image", 383, 320), 940, 1019);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_42(), Class3.smethod_9(563, 515), 278, 265);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_42(), "NewToolStripButton", 217, 214);
		((ToolStripItem)vmethod_42()).set_Text("New");
		Class3.smethod_8(Class3.Class4.smethod_5(vmethod_44(), 320, 308), (ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)vmethod_42(),
			(ToolStripItem)vmethod_46(),
			(ToolStripItem)vmethod_48(),
			(ToolStripItem)vmethod_50(),
			(ToolStripItem)vmethod_40(),
			(ToolStripItem)vmethod_32(),
			(ToolStripItem)vmethod_30(),
			(ToolStripItem)vmethod_28()
		}, 705, 690);
		ToolStrip control_2 = vmethod_44();
		point_ = new Point(0, 24);
		Class3.smethod_10((Control)(object)control_2, point_, 623, 527);
		Class3.smethod_11((Control)(object)vmethod_44(), "ToolStrip", 215, 187);
		ToolStrip obj2 = vmethod_44();
		size = new Size(632, 25);
		((Control)obj2).set_Size(size);
		((Control)vmethod_44()).set_TabIndex(6);
		((Control)vmethod_44()).set_Text("ToolStrip");
		Class3.Class4.Class5.smethod_11((ToolStripItem)(object)vmethod_46(), (ToolStripItemDisplayStyle)2, 230, 212);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_46(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "OpenToolStripButton.Image", 691, 652), 418, 501);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_46(), Class3.smethod_9(698, 650), 918, 905);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_46(), "OpenToolStripButton", 269, 258);
		((ToolStripItem)vmethod_46()).set_Text("Open");
		Class3.Class4.Class5.smethod_11((ToolStripItem)(object)vmethod_48(), (ToolStripItemDisplayStyle)2, 40, 26);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_48(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "SaveToolStripButton.Image", 720, 751), 670, 713);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_48(), Class3.smethod_9(680, 664), 897, 926);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_48(), "SaveToolStripButton", 146, 157);
		((ToolStripItem)vmethod_48()).set_Text("Save");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_50(), "ToolStripSeparator1", 418, 429);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_52(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "PrintPreviewToolStripMenuItem.Image", 139, 180), 635, 556);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_52(), Class3.smethod_9(1003, 987), 105, 118);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_52(), "PrintPreviewToolStripMenuItem", 634, 629);
		((ToolStripItem)vmethod_52()).set_Text("Print Pre&view");
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_54(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "PrintToolStripMenuItem.Image", 218, 229), 948, 995);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_54(), Class3.smethod_9(407, 423), 864, 895);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_54(), "PrintToolStripMenuItem", 186, 181);
		Class3.Class4.Class5.smethod_9(vmethod_54(), (Keys)131152, 716, 653);
		((ToolStripItem)vmethod_54()).set_Text("&Print");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_56(), "ToolStripSeparator4", 451, 460);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_58(), "ExitToolStripMenuItem", 411, 404);
		((ToolStripItem)vmethod_58()).set_Text("E&xit");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_60(), "ToolStripSeparator5", 251, 244);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_62(), "PrintSetupToolStripMenuItem", 520, 519);
		((ToolStripItem)vmethod_62()).set_Text("Print Setup");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_64(), "SaveAsToolStripMenuItem", 607, 592);
		((ToolStripItem)vmethod_64()).set_Text("Save &As");
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_66(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "NewToolStripMenuItem.Image", 863, 864), 677, 754);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_66(), Class3.smethod_9(624, 576), 397, 402);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_66(), "NewToolStripMenuItem", 744, 743);
		Class3.Class4.Class5.smethod_9(vmethod_66(), (Keys)131150, 566, 631);
		((ToolStripItem)vmethod_66()).set_Text("&New");
		Class3.smethod_8(Class3.Class4.smethod_2((ToolStripDropDownItem)(object)vmethod_68(), 270, 257), (ToolStripItem[])(object)new ToolStripItem[11]
		{
			(ToolStripItem)vmethod_66(),
			(ToolStripItem)vmethod_70(),
			(ToolStripItem)vmethod_72(),
			(ToolStripItem)vmethod_74(),
			(ToolStripItem)vmethod_64(),
			(ToolStripItem)vmethod_56(),
			(ToolStripItem)vmethod_54(),
			(ToolStripItem)vmethod_52(),
			(ToolStripItem)vmethod_62(),
			(ToolStripItem)vmethod_60(),
			(ToolStripItem)vmethod_58()
		}, 906, 1017);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_68(), Class3.smethod_9(71, 118), 564, 555);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_68(), "FileMenu", 925, 914);
		((ToolStripItem)vmethod_68()).set_Text("&File");
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_70(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "OpenToolStripMenuItem.Image", 1012, 971), 236, 187);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_70(), Class3.smethod_9(855, 871), 507, 484);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_70(), "OpenToolStripMenuItem", 110, 97);
		Class3.Class4.Class5.smethod_9(vmethod_70(), (Keys)131151, 11, 74);
		((ToolStripItem)vmethod_70()).set_Text("&Open");
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_72(), "ToolStripSeparator3", 11, 4);
		Class3.Class4.smethod_3((ToolStripItem)(object)vmethod_74(), (Image)Class3.Class4.Class5.smethod_10(componentResourceManager, "SaveToolStripMenuItem.Image", 858, 869), 732, 651);
		Class3.Class4.smethod_4((ToolStripItem)(object)vmethod_74(), Class3.smethod_9(577, 625), 260, 283);
		Class3.Class4.Class5.smethod_8((ToolStripItem)(object)vmethod_74(), "SaveToolStripMenuItem", 613, 618);
		Class3.Class4.Class5.smethod_9(vmethod_74(), (Keys)131155, 308, 373);
		((ToolStripItem)vmethod_74()).set_Text("&Save");
		Class3.smethod_8(Class3.Class4.smethod_5((ToolStrip)(object)vmethod_76(), 429, 473), (ToolStripItem[])(object)new ToolStripItem[6]
		{
			(ToolStripItem)vmethod_68(),
			(ToolStripItem)vmethod_78(),
			(ToolStripItem)vmethod_96(),
			(ToolStripItem)vmethod_102(),
			(ToolStripItem)vmethod_18(),
			(ToolStripItem)vmethod_2()
		}, 376, 267);
		MenuStrip control_3 = vmethod_76();
		point_ = new Point(0, 0);
		Class3.smethod_10((Control)(object)control_3, point_, 62, 94);
		vmethod_76().set_MdiWindowListItem(vmethod_18());
		Class3.smethod_11((Control)(object)vmethod_76(), "MenuStrip", 379, 279);
		MenuStrip obj3 = vmethod_76();
		size = new Size(632, 24);
		((Control)obj3).set_Size(size);
		((Control)vmethod_76()).set_TabIndex(5);
		((Control)vmethod_76()).set_Text("MenuStrip");
		((ToolStripDropDownItem)vmethod_78()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[8]
		{
			(ToolStripItem)vmethod_80(),
			(ToolStripItem)vmethod_82(),
			(ToolStripItem)vmethod_84(),
			(ToolStripItem)vmethod_86(),
			(ToolStripItem)vmethod_88(),
			(ToolStripItem)vmethod_90(),
			(ToolStripItem)vmethod_92(),
			(ToolStripItem)vmethod_94()
		});
		((ToolStripItem)vmethod_78()).set_Name("EditMenu");
		((ToolStripItem)vmethod_78()).set_Text("&Edit");
		((ToolStripItem)vmethod_80()).set_Image((Image)componentResourceManager.GetObject("UndoToolStripMenuItem.Image"));
		((ToolStripItem)vmethod_80()).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)vmethod_80()).set_Name("UndoToolStripMenuItem");
		vmethod_80().set_ShortcutKeys((Keys)131162);
		((ToolStripItem)vmethod_80()).set_Text("&Undo");
		((ToolStripItem)vmethod_82()).set_Image((Image)componentResourceManager.GetObject("RedoToolStripMenuItem.Image"));
		((ToolStripItem)vmethod_82()).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)vmethod_82()).set_Name("RedoToolStripMenuItem");
		vmethod_82().set_ShortcutKeys((Keys)131161);
		((ToolStripItem)vmethod_82()).set_Text("&Redo");
		((ToolStripItem)vmethod_84()).set_Name("ToolStripSeparator6");
		((ToolStripItem)vmethod_86()).set_Image((Image)componentResourceManager.GetObject("CutToolStripMenuItem.Image"));
		((ToolStripItem)vmethod_86()).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)vmethod_86()).set_Name("CutToolStripMenuItem");
		vmethod_86().set_ShortcutKeys((Keys)131160);
		((ToolStripItem)vmethod_86()).set_Text("Cu&t");
		((ToolStripItem)vmethod_88()).set_Image((Image)componentResourceManager.GetObject("CopyToolStripMenuItem.Image"));
		((ToolStripItem)vmethod_88()).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)vmethod_88()).set_Name("CopyToolStripMenuItem");
		vmethod_88().set_ShortcutKeys((Keys)131139);
		((ToolStripItem)vmethod_88()).set_Text("&Copy");
		((ToolStripItem)vmethod_90()).set_Image((Image)componentResourceManager.GetObject("PasteToolStripMenuItem.Image"));
		((ToolStripItem)vmethod_90()).set_ImageTransparentColor(Color.Black);
		((ToolStripItem)vmethod_90()).set_Name("PasteToolStripMenuItem");
		vmethod_90().set_ShortcutKeys((Keys)131158);
		((ToolStripItem)vmethod_90()).set_Text("&Paste");
		((ToolStripItem)vmethod_92()).set_Name("ToolStripSeparator7");
		((ToolStripItem)vmethod_94()).set_Name("SelectAllToolStripMenuItem");
		vmethod_94().set_ShortcutKeys((Keys)131137);
		((ToolStripItem)vmethod_94()).set_Text("Select &All");
		((ToolStripDropDownItem)vmethod_96()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)vmethod_98(),
			(ToolStripItem)vmethod_100()
		});
		((ToolStripItem)vmethod_96()).set_Name("ViewMenu");
		((ToolStripItem)vmethod_96()).set_Text("&View");
		vmethod_98().set_Checked(true);
		vmethod_98().set_CheckOnClick(true);
		vmethod_98().set_CheckState((CheckState)1);
		((ToolStripItem)vmethod_98()).set_Name("ToolBarToolStripMenuItem");
		((ToolStripItem)vmethod_98()).set_Text("&Toolbar");
		vmethod_100().set_Checked(true);
		vmethod_100().set_CheckOnClick(true);
		vmethod_100().set_CheckState((CheckState)1);
		((ToolStripItem)vmethod_100()).set_Name("StatusBarToolStripMenuItem");
		((ToolStripItem)vmethod_100()).set_Text("&Status Bar");
		((ToolStripDropDownItem)vmethod_102()).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)vmethod_26() });
		((ToolStripItem)vmethod_102()).set_Name("ToolsMenu");
		((ToolStripItem)vmethod_102()).set_Text("&Tools");
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_44());
		((Control)this).get_Controls().Add((Control)(object)vmethod_76());
		((Control)this).get_Controls().Add((Control)(object)vmethod_38());
		((Form)this).set_IsMdiContainer(true);
		((Form)this).set_MainMenuStrip(vmethod_76());
		((Control)this).set_Name("MDIParent1");
		((Form)this).set_Text("MDIParent1");
		((Control)vmethod_38()).ResumeLayout(false);
		((Control)vmethod_44()).ResumeLayout(false);
		((Control)vmethod_76()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_0()
	{
		return toolStripMenuItem_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_1(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_0 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_2()
	{
		return toolStripMenuItem_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_3(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_1 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_4()
	{
		return toolStripMenuItem_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_5(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_2 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_6()
	{
		return toolStripMenuItem_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_7(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_3 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_8()
	{
		return toolStripSeparator_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_9(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_0 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_10()
	{
		return toolStripMenuItem_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_11(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_4 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_12()
	{
		return toolStripMenuItem_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_13(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_12;
		if (toolStripMenuItem_5 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_5, eventHandler, 524, 600);
		}
		ToolStripMenuItem val = (toolStripMenuItem_5 = toolStripMenuItem_33);
		if (toolStripMenuItem_5 != null)
		{
			((ToolStripItem)toolStripMenuItem_5).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_14()
	{
		return toolStripMenuItem_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_15(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_13;
		if (toolStripMenuItem_6 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_6, eventHandler, 152, 204);
		}
		ToolStripMenuItem val = (toolStripMenuItem_6 = toolStripMenuItem_33);
		if (toolStripMenuItem_6 != null)
		{
			((ToolStripItem)toolStripMenuItem_6).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_16()
	{
		return toolStripMenuItem_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_17(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_0;
		if (toolStripMenuItem_7 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_7, eventHandler, 908, 984);
		}
		ToolStripMenuItem val = (toolStripMenuItem_7 = toolStripMenuItem_33);
		if (toolStripMenuItem_7 != null)
		{
			((ToolStripItem)toolStripMenuItem_7).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_18()
	{
		return toolStripMenuItem_8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_8 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_20()
	{
		return toolStripMenuItem_9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_9;
		if (toolStripMenuItem_9 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_9, eventHandler, 836, 784);
		}
		ToolStripMenuItem val = (toolStripMenuItem_9 = toolStripMenuItem_33);
		if (toolStripMenuItem_9 != null)
		{
			((ToolStripItem)toolStripMenuItem_9).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_22()
	{
		return toolStripMenuItem_10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_10;
		if (toolStripMenuItem_10 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_10, eventHandler, 13, 89);
		}
		ToolStripMenuItem val = (toolStripMenuItem_10 = toolStripMenuItem_33);
		if (toolStripMenuItem_10 != null)
		{
			((ToolStripItem)toolStripMenuItem_10).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_24()
	{
		return toolStripMenuItem_11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_11;
		if (toolStripMenuItem_11 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_11, eventHandler, 595, 519);
		}
		ToolStripMenuItem val = (toolStripMenuItem_11 = toolStripMenuItem_33);
		if (toolStripMenuItem_11 != null)
		{
			((ToolStripItem)toolStripMenuItem_11).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_26()
	{
		return toolStripMenuItem_12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_27(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_12 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripButton vmethod_28()
	{
		return toolStripButton_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_29(ToolStripButton toolStripButton_6)
	{
		ToolStripButton val = (toolStripButton_0 = toolStripButton_6);
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_30()
	{
		return toolStripSeparator_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_31(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_1 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripButton vmethod_32()
	{
		return toolStripButton_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_33(ToolStripButton toolStripButton_6)
	{
		ToolStripButton val = (toolStripButton_1 = toolStripButton_6);
	}

	[SpecialName]
	internal virtual ToolTip vmethod_34()
	{
		return toolTip_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_35(ToolTip toolTip_1)
	{
		ToolTip val = (toolTip_0 = toolTip_1);
	}

	[SpecialName]
	internal virtual ToolStripStatusLabel vmethod_36()
	{
		return toolStripStatusLabel_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_37(ToolStripStatusLabel toolStripStatusLabel_1)
	{
		ToolStripStatusLabel val = (toolStripStatusLabel_0 = toolStripStatusLabel_1);
	}

	[SpecialName]
	internal virtual StatusStrip vmethod_38()
	{
		return statusStrip_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_39(StatusStrip statusStrip_1)
	{
		StatusStrip val = (statusStrip_0 = statusStrip_1);
	}

	[SpecialName]
	internal virtual ToolStripButton vmethod_40()
	{
		return toolStripButton_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_41(ToolStripButton toolStripButton_6)
	{
		ToolStripButton val = (toolStripButton_2 = toolStripButton_6);
	}

	[SpecialName]
	internal virtual ToolStripButton vmethod_42()
	{
		return toolStripButton_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_43(ToolStripButton toolStripButton_6)
	{
		EventHandler eventHandler = method_0;
		if (toolStripButton_3 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripButton_3, eventHandler, 851, 775);
		}
		ToolStripButton val = (toolStripButton_3 = toolStripButton_6);
		if (toolStripButton_3 != null)
		{
			((ToolStripItem)toolStripButton_3).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStrip vmethod_44()
	{
		return toolStrip_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_45(ToolStrip toolStrip_1)
	{
		ToolStrip val = (toolStrip_0 = toolStrip_1);
	}

	[SpecialName]
	internal virtual ToolStripButton vmethod_46()
	{
		return toolStripButton_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_47(ToolStripButton toolStripButton_6)
	{
		EventHandler eventHandler = method_1;
		if (toolStripButton_4 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripButton_4, eventHandler, 915, 967);
		}
		ToolStripButton val = (toolStripButton_4 = toolStripButton_6);
		if (toolStripButton_4 != null)
		{
			((ToolStripItem)toolStripButton_4).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripButton vmethod_48()
	{
		return toolStripButton_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_49(ToolStripButton toolStripButton_6)
	{
		ToolStripButton val = (toolStripButton_5 = toolStripButton_6);
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_50()
	{
		return toolStripSeparator_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_51(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_2 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_52()
	{
		return toolStripMenuItem_13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_53(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_13 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_54()
	{
		return toolStripMenuItem_14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_55(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_14 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_56()
	{
		return toolStripSeparator_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_57(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_3 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_58()
	{
		return toolStripMenuItem_15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_59(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_3;
		if (toolStripMenuItem_15 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_15, eventHandler, 484, 432);
		}
		ToolStripMenuItem val = (toolStripMenuItem_15 = toolStripMenuItem_33);
		if (toolStripMenuItem_15 != null)
		{
			((ToolStripItem)toolStripMenuItem_15).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_60()
	{
		return toolStripSeparator_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_61(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_4 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_62()
	{
		return toolStripMenuItem_16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_63(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_16 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_64()
	{
		return toolStripMenuItem_17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_65(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_2;
		if (toolStripMenuItem_17 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_17, eventHandler, 379, 303);
		}
		ToolStripMenuItem val = (toolStripMenuItem_17 = toolStripMenuItem_33);
		if (toolStripMenuItem_17 != null)
		{
			((ToolStripItem)toolStripMenuItem_17).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_66()
	{
		return toolStripMenuItem_18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_67(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_0;
		if (toolStripMenuItem_18 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_18, eventHandler, 477, 393);
		}
		ToolStripMenuItem val = (toolStripMenuItem_18 = toolStripMenuItem_33);
		if (toolStripMenuItem_18 != null)
		{
			((ToolStripItem)toolStripMenuItem_18).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_68()
	{
		return toolStripMenuItem_19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_69(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_19 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_70()
	{
		return toolStripMenuItem_20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_71(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_1;
		if (toolStripMenuItem_20 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_20, eventHandler, 8, 92);
		}
		ToolStripMenuItem val = (toolStripMenuItem_20 = toolStripMenuItem_33);
		if (toolStripMenuItem_20 != null)
		{
			((ToolStripItem)toolStripMenuItem_20).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_72()
	{
		return toolStripSeparator_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_73(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_5 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_74()
	{
		return toolStripMenuItem_21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_75(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_21 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual MenuStrip vmethod_76()
	{
		return menuStrip_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_77(MenuStrip menuStrip_1)
	{
		MenuStrip val = (menuStrip_0 = menuStrip_1);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_78()
	{
		return toolStripMenuItem_22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_79(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_22 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_80()
	{
		return toolStripMenuItem_23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_81(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_23 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_82()
	{
		return toolStripMenuItem_24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_83(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_24 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_84()
	{
		return toolStripSeparator_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_85(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_6 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_86()
	{
		return toolStripMenuItem_25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_87(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_4;
		if (toolStripMenuItem_25 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_25, eventHandler, 585, 541);
		}
		ToolStripMenuItem val = (toolStripMenuItem_25 = toolStripMenuItem_33);
		if (toolStripMenuItem_25 != null)
		{
			((ToolStripItem)toolStripMenuItem_25).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_88()
	{
		return toolStripMenuItem_26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_89(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_5;
		if (toolStripMenuItem_26 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_26, eventHandler, 30, 74);
		}
		ToolStripMenuItem val = (toolStripMenuItem_26 = toolStripMenuItem_33);
		if (toolStripMenuItem_26 != null)
		{
			((ToolStripItem)toolStripMenuItem_26).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_90()
	{
		return toolStripMenuItem_27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_91(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_6;
		if (toolStripMenuItem_27 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_27, eventHandler, 123, 47);
		}
		ToolStripMenuItem val = (toolStripMenuItem_27 = toolStripMenuItem_33);
		if (toolStripMenuItem_27 != null)
		{
			((ToolStripItem)toolStripMenuItem_27).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripSeparator vmethod_92()
	{
		return toolStripSeparator_7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_93(ToolStripSeparator toolStripSeparator_8)
	{
		ToolStripSeparator val = (toolStripSeparator_7 = toolStripSeparator_8);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_94()
	{
		return toolStripMenuItem_28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_95(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_28 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_96()
	{
		return toolStripMenuItem_29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_97(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_29 = toolStripMenuItem_33);
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_98()
	{
		return toolStripMenuItem_30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_99(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_7;
		if (toolStripMenuItem_30 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_30, eventHandler, 186, 238);
		}
		ToolStripMenuItem val = (toolStripMenuItem_30 = toolStripMenuItem_33);
		if (toolStripMenuItem_30 != null)
		{
			((ToolStripItem)toolStripMenuItem_30).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_100()
	{
		return toolStripMenuItem_31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_101(ToolStripMenuItem toolStripMenuItem_33)
	{
		EventHandler eventHandler = method_8;
		if (toolStripMenuItem_31 != null)
		{
			Class3.smethod_12((ToolStripItem)(object)toolStripMenuItem_31, eventHandler, 88, 12);
		}
		ToolStripMenuItem val = (toolStripMenuItem_31 = toolStripMenuItem_33);
		if (toolStripMenuItem_31 != null)
		{
			((ToolStripItem)toolStripMenuItem_31).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ToolStripMenuItem vmethod_102()
	{
		return toolStripMenuItem_32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_103(ToolStripMenuItem toolStripMenuItem_33)
	{
		ToolStripMenuItem val = (toolStripMenuItem_32 = toolStripMenuItem_33);
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		Class3.Class4.smethod_6(val, (Form)(object)this, 765, 712);
		checked
		{
			int_0++;
			val.set_Text("Window " + Class3.Class4.Class5.smethod_12(int_0, 9, 108));
			((Control)val).Show();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		Class3.Class4.smethod_7((FileDialog)(object)val, Class3.smethod_13(Class3.Class4.Class5.smethod_13(((ServerComputer)MyProject.MyComputer_0).get_FileSystem(), 5, 16), 267, 262), 980, 997);
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void method_2(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		Class3.Class4.smethod_7((FileDialog)(object)val, Class3.smethod_13(Class3.Class4.Class5.smethod_13(((ServerComputer)MyProject.MyComputer_0).get_FileSystem(), 114, 103), 247, 250), 340, 357);
		((FileDialog)val).set_Filter("Text Files (*.txt)|*.txt|All Files (*.*)|*.*");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		Class3.smethod_14((Form)(object)this, 247, 171);
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void method_6(object sender, EventArgs e)
	{
	}

	private void method_7(object sender, EventArgs e)
	{
		Class3.Class4.Class5.smethod_15((Control)(object)vmethod_44(), Class3.Class4.Class5.smethod_14(vmethod_98(), 688, 650), 817, 889);
	}

	private void method_8(object sender, EventArgs e)
	{
		Class3.Class4.Class5.smethod_15((Control)(object)vmethod_38(), Class3.Class4.Class5.smethod_14(vmethod_100(), 915, 937), 392, 448);
	}

	private void method_9(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void method_10(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void method_11(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void method_12(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void method_13(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form form_ in mdiChildren)
		{
			Class3.smethod_14(form_, 515, 607);
		}
	}
}
