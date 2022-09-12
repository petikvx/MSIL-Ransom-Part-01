using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace C5C480410;

public class B22613AD3 : Form
{
	private SoundPlayer B4E9D5EB5 = new SoundPlayer("C:\\Windows\\Media\\chord.wav");

	private SoundPlayer CFC16A740 = new SoundPlayer("C:\\Windows\\Media\\tada.wav");

	private IContainer DE68C7F3F = null;

	private Panel FE428CF9F;

	private Label A187DF833;

	private Label C5DC5DE28;

	private Label B64639873;

	private Label AE7048D3B;

	private Label D793A45C6;

	private Label AF545B1BA;

	private Label A2A012933;

	private Label F56222762;

	private Label DC377A678;

	private Label DA5385676;

	private Label BA6847052;

	private Label E8114CE26;

	private Label F5ECABC02;

	private Label E6CF54325;

	private Label C9D865F45;

	private Label ABB7FC528;

	private Label F012BEC36;

	private Label DFAE6B204;

	private Label C97272C8B;

	private Label F2CBC5B54;

	private Label DC43E7EB9;

	private Label CCD06AFA4;

	private Label D36591B4A;

	private Label F3BE1A4E9;

	private Label C8D53E542;

	private Label A2E2CD4F4;

	private Label D5691EE03;

	private Label BCF2F3C63;

	private Label E5265D81D;

	private Label A6177C4C6;

	private Label A6C37BF4A;

	private Label F01A3A3FC;

	private Label C6C0B7A35;

	private Label FCCFD81BD;

	private Label D2DF07108;

	private Label EC15E8CD4;

	private Label F431B99EE;

	private Label CFC438B78;

	private Label E1F9272A0;

	private Label F40F8DB1F;

	private Label A4C51BC88;

	private Label A3727DC1D;

	public B22613AD3()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		D248DE914();
		B2D33218D();
	}

	private void A2A04309C(object EBFE9D9E0, EventArgs F16292751)
	{
	}

	private void D4A218AC9(object BEC2F0CAB, EventArgs C82672C7D)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		CFC16A740.Play();
		MessageBox.Show("Congratulation You won");
		((Form)this).Close();
	}

	private void B2D33218D()
	{
		B4E9D5EB5.Play();
		Point location = ((Control)FE428CF9F).get_Location();
		location.Offset(10, 10);
		Cursor.set_Position(((Control)this).PointToScreen(location));
	}

	private void D3328C418(object A92F16E94, EventArgs E73B1E4C5)
	{
		B2D33218D();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && DE68C7F3F != null)
		{
			DE68C7F3F.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void D248DE914()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0109: Expected O, but got Unknown
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
		FE428CF9F = new Panel();
		CFC438B78 = new Label();
		F431B99EE = new Label();
		EC15E8CD4 = new Label();
		D2DF07108 = new Label();
		FCCFD81BD = new Label();
		C6C0B7A35 = new Label();
		F01A3A3FC = new Label();
		A6C37BF4A = new Label();
		A6177C4C6 = new Label();
		E5265D81D = new Label();
		BCF2F3C63 = new Label();
		D5691EE03 = new Label();
		A2E2CD4F4 = new Label();
		C8D53E542 = new Label();
		F3BE1A4E9 = new Label();
		D36591B4A = new Label();
		CCD06AFA4 = new Label();
		DC43E7EB9 = new Label();
		F2CBC5B54 = new Label();
		C97272C8B = new Label();
		DFAE6B204 = new Label();
		F012BEC36 = new Label();
		ABB7FC528 = new Label();
		C9D865F45 = new Label();
		E6CF54325 = new Label();
		F5ECABC02 = new Label();
		E8114CE26 = new Label();
		BA6847052 = new Label();
		DA5385676 = new Label();
		DC377A678 = new Label();
		F56222762 = new Label();
		A2A012933 = new Label();
		AF545B1BA = new Label();
		D793A45C6 = new Label();
		AE7048D3B = new Label();
		B64639873 = new Label();
		C5DC5DE28 = new Label();
		A187DF833 = new Label();
		A4C51BC88 = new Label();
		F40F8DB1F = new Label();
		E1F9272A0 = new Label();
		A3727DC1D = new Label();
		((Control)FE428CF9F).SuspendLayout();
		((Control)this).SuspendLayout();
		FE428CF9F.set_BorderStyle((BorderStyle)2);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A3727DC1D);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)E1F9272A0);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F40F8DB1F);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A4C51BC88);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A187DF833);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)C5DC5DE28);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)B64639873);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)AE7048D3B);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)D793A45C6);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)AF545B1BA);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A2A012933);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F56222762);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)DC377A678);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)DA5385676);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)BA6847052);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)E8114CE26);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F5ECABC02);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)E6CF54325);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)C9D865F45);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)ABB7FC528);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F012BEC36);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)DFAE6B204);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)C97272C8B);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F2CBC5B54);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)DC43E7EB9);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)CCD06AFA4);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)D36591B4A);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F3BE1A4E9);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)C8D53E542);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A2E2CD4F4);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)D5691EE03);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)BCF2F3C63);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)E5265D81D);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A6177C4C6);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)A6C37BF4A);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F01A3A3FC);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)C6C0B7A35);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)FCCFD81BD);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)D2DF07108);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)EC15E8CD4);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)F431B99EE);
		((Control)FE428CF9F).get_Controls().Add((Control)(object)CFC438B78);
		((Control)FE428CF9F).set_Location(new Point(12, 12));
		((Control)FE428CF9F).set_Name("panel1");
		((Control)FE428CF9F).set_Size(new Size(548, 485));
		((Control)FE428CF9F).set_TabIndex(0);
		((Control)FE428CF9F).add_MouseEnter((EventHandler)D3328C418);
		((Control)CFC438B78).set_BackColor(SystemColors.MenuHighlight);
		((Control)CFC438B78).set_Location(new Point(16, 157));
		((Control)CFC438B78).set_Name("label1");
		((Control)CFC438B78).set_Size(new Size(44, 20));
		((Control)CFC438B78).set_TabIndex(0);
		((Control)CFC438B78).add_MouseEnter((EventHandler)D3328C418);
		((Control)F431B99EE).set_BackColor(SystemColors.MenuHighlight);
		((Control)F431B99EE).set_Location(new Point(84, 308));
		((Control)F431B99EE).set_Name("label2");
		((Control)F431B99EE).set_Size(new Size(202, 20));
		((Control)F431B99EE).set_TabIndex(1);
		((Control)F431B99EE).add_MouseEnter((EventHandler)D3328C418);
		((Control)EC15E8CD4).set_BackColor(SystemColors.MenuHighlight);
		((Control)EC15E8CD4).set_Location(new Point(63, 347));
		((Control)EC15E8CD4).set_Name("label3");
		((Control)EC15E8CD4).set_Size(new Size(174, 22));
		((Control)EC15E8CD4).set_TabIndex(2);
		((Control)EC15E8CD4).add_MouseEnter((EventHandler)D3328C418);
		((Control)D2DF07108).set_BackColor(SystemColors.MenuHighlight);
		((Control)D2DF07108).set_Location(new Point(86, 258));
		((Control)D2DF07108).set_Name("label4");
		((Control)D2DF07108).set_Size(new Size(70, 20));
		((Control)D2DF07108).set_TabIndex(3);
		((Control)D2DF07108).add_MouseEnter((EventHandler)D3328C418);
		((Control)FCCFD81BD).set_BackColor(SystemColors.MenuHighlight);
		((Control)FCCFD81BD).set_Location(new Point(63, 212));
		((Control)FCCFD81BD).set_Name("label5");
		((Control)FCCFD81BD).set_Size(new Size(114, 23));
		((Control)FCCFD81BD).set_TabIndex(4);
		((Control)FCCFD81BD).add_MouseEnter((EventHandler)D3328C418);
		((Control)C6C0B7A35).set_BackColor(SystemColors.MenuHighlight);
		((Control)C6C0B7A35).set_Location(new Point(107, 147));
		((Control)C6C0B7A35).set_Name("label6");
		((Control)C6C0B7A35).set_Size(new Size(175, 18));
		((Control)C6C0B7A35).set_TabIndex(5);
		((Control)C6C0B7A35).add_MouseEnter((EventHandler)D3328C418);
		((Control)F01A3A3FC).set_BackColor(SystemColors.MenuHighlight);
		((Control)F01A3A3FC).set_Location(new Point(385, 23));
		((Control)F01A3A3FC).set_Name("label7");
		((Control)F01A3A3FC).set_Size(new Size(127, 21));
		((Control)F01A3A3FC).set_TabIndex(6);
		((Control)F01A3A3FC).add_MouseEnter((EventHandler)D3328C418);
		((Control)A6C37BF4A).set_BackColor(SystemColors.MenuHighlight);
		((Control)A6C37BF4A).set_Location(new Point(324, 77));
		((Control)A6C37BF4A).set_Name("label8");
		((Control)A6C37BF4A).set_Size(new Size(41, 19));
		((Control)A6C37BF4A).set_TabIndex(7);
		((Control)A6C37BF4A).add_MouseEnter((EventHandler)D3328C418);
		((Control)A6177C4C6).set_BackColor(SystemColors.MenuHighlight);
		((Control)A6177C4C6).set_Location(new Point(253, 23));
		((Control)A6177C4C6).set_Name("label9");
		((Control)A6177C4C6).set_Size(new Size(68, 21));
		((Control)A6177C4C6).set_TabIndex(8);
		((Control)A6177C4C6).add_MouseEnter((EventHandler)D3328C418);
		((Control)E5265D81D).set_BackColor(SystemColors.MenuHighlight);
		((Control)E5265D81D).set_Location(new Point(77, 100));
		((Control)E5265D81D).set_Name("label10");
		((Control)E5265D81D).set_Size(new Size(160, 19));
		((Control)E5265D81D).set_TabIndex(9);
		((Control)E5265D81D).add_MouseEnter((EventHandler)D3328C418);
		((Control)BCF2F3C63).set_BackColor(SystemColors.MenuHighlight);
		((Control)BCF2F3C63).set_Location(new Point(77, 34));
		((Control)BCF2F3C63).set_Name("label11");
		((Control)BCF2F3C63).set_Size(new Size(79, 21));
		((Control)BCF2F3C63).set_TabIndex(10);
		((Control)BCF2F3C63).add_MouseEnter((EventHandler)D3328C418);
		((Control)D5691EE03).set_BackColor(SystemColors.MenuHighlight);
		((Control)D5691EE03).set_Location(new Point(60, 34));
		((Control)D5691EE03).set_Name("label12");
		((Control)D5691EE03).set_Size(new Size(20, 143));
		((Control)D5691EE03).set_TabIndex(11);
		((Control)D5691EE03).add_MouseEnter((EventHandler)D3328C418);
		((Control)A2E2CD4F4).set_BackColor(SystemColors.MenuHighlight);
		((Control)A2E2CD4F4).set_Location(new Point(236, 23));
		((Control)A2E2CD4F4).set_Name("label13");
		((Control)A2E2CD4F4).set_Size(new Size(21, 96));
		((Control)A2E2CD4F4).set_TabIndex(12);
		((Control)A2E2CD4F4).add_MouseEnter((EventHandler)D3328C418);
		((Control)C8D53E542).set_BackColor(SystemColors.MenuHighlight);
		((Control)C8D53E542).set_Location(new Point(174, 0));
		((Control)C8D53E542).set_Name("label14");
		((Control)C8D53E542).set_Size(new Size(21, 80));
		((Control)C8D53E542).set_TabIndex(13);
		((Control)C8D53E542).add_MouseEnter((EventHandler)D3328C418);
		((Control)F3BE1A4E9).set_BackColor(SystemColors.MenuHighlight);
		((Control)F3BE1A4E9).set_Location(new Point(282, 62));
		((Control)F3BE1A4E9).set_Name("label15");
		((Control)F3BE1A4E9).set_Size(new Size(19, 180));
		((Control)F3BE1A4E9).set_TabIndex(14);
		((Control)F3BE1A4E9).add_MouseEnter((EventHandler)D3328C418);
		((Control)D36591B4A).set_BackColor(SystemColors.MenuHighlight);
		((Control)D36591B4A).set_Location(new Point(9, 417));
		((Control)D36591B4A).set_Name("label16");
		((Control)D36591B4A).set_Size(new Size(17, 45));
		((Control)D36591B4A).set_TabIndex(15);
		((Control)D36591B4A).add_MouseEnter((EventHandler)D3328C418);
		((Control)CCD06AFA4).set_BackColor(SystemColors.MenuHighlight);
		((Control)CCD06AFA4).set_Location(new Point(63, 407));
		((Control)CCD06AFA4).set_Name("label17");
		((Control)CCD06AFA4).set_Size(new Size(17, 33));
		((Control)CCD06AFA4).set_TabIndex(16);
		((Control)CCD06AFA4).add_MouseEnter((EventHandler)D3328C418);
		((Control)DC43E7EB9).set_BackColor(SystemColors.MenuHighlight);
		((Control)DC43E7EB9).set_Location(new Point(504, 114));
		((Control)DC43E7EB9).set_Name("label18");
		((Control)DC43E7EB9).set_Size(new Size(20, 296));
		((Control)DC43E7EB9).set_TabIndex(17);
		((Control)DC43E7EB9).add_MouseEnter((EventHandler)D3328C418);
		((Control)F2CBC5B54).set_BackColor(SystemColors.MenuHighlight);
		((Control)F2CBC5B54).set_Location(new Point(155, 235));
		((Control)F2CBC5B54).set_Name("label19");
		((Control)F2CBC5B54).set_Size(new Size(22, 43));
		((Control)F2CBC5B54).set_TabIndex(18);
		((Control)F2CBC5B54).add_MouseEnter((EventHandler)D3328C418);
		((Control)C97272C8B).set_BackColor(SystemColors.MenuHighlight);
		((Control)C97272C8B).set_Location(new Point(43, 212));
		((Control)C97272C8B).set_Name("label20");
		((Control)C97272C8B).set_Size(new Size(20, 157));
		((Control)C97272C8B).set_TabIndex(19);
		((Control)C97272C8B).add_MouseEnter((EventHandler)D3328C418);
		((Control)DFAE6B204).set_BackColor(SystemColors.MenuHighlight);
		((Control)DFAE6B204).set_Location(new Point(107, 165));
		((Control)DFAE6B204).set_Name("label21");
		((Control)DFAE6B204).set_Size(new Size(22, 47));
		((Control)DFAE6B204).set_TabIndex(20);
		((Control)DFAE6B204).add_MouseEnter((EventHandler)D3328C418);
		((Control)F012BEC36).set_BackColor(SystemColors.MenuHighlight);
		((Control)F012BEC36).set_Location(new Point(362, 0));
		((Control)F012BEC36).set_Name("label22");
		((Control)F012BEC36).set_Size(new Size(23, 96));
		((Control)F012BEC36).set_TabIndex(21);
		((Control)F012BEC36).add_MouseEnter((EventHandler)D3328C418);
		((Control)ABB7FC528).set_BackColor(SystemColors.MenuHighlight);
		((Control)ABB7FC528).set_Location(new Point(218, 164));
		((Control)ABB7FC528).set_Name("label23");
		((Control)ABB7FC528).set_Size(new Size(19, 126));
		((Control)ABB7FC528).set_TabIndex(22);
		((Control)ABB7FC528).add_MouseEnter((EventHandler)D3328C418);
		((Control)C9D865F45).set_BackColor(SystemColors.MenuHighlight);
		((Control)C9D865F45).set_Location(new Point(282, 242));
		((Control)C9D865F45).set_Name("label24");
		((Control)C9D865F45).set_Size(new Size(70, 20));
		((Control)C9D865F45).set_TabIndex(23);
		((Control)C9D865F45).add_MouseEnter((EventHandler)D3328C418);
		((Control)E6CF54325).set_BackColor(SystemColors.MenuHighlight);
		((Control)E6CF54325).set_Location(new Point(466, 67));
		((Control)E6CF54325).set_Name("label25");
		((Control)E6CF54325).set_Size(new Size(58, 20));
		((Control)E6CF54325).set_TabIndex(24);
		((Control)E6CF54325).add_MouseEnter((EventHandler)D3328C418);
		((Control)F5ECABC02).set_BackColor(SystemColors.MenuHighlight);
		((Control)F5ECABC02).set_Location(new Point(348, 114));
		((Control)F5ECABC02).set_Name("label26");
		((Control)F5ECABC02).set_Size(new Size(100, 20));
		((Control)F5ECABC02).set_TabIndex(25);
		((Control)F5ECABC02).add_MouseEnter((EventHandler)D3328C418);
		((Control)E8114CE26).set_BackColor(SystemColors.MenuHighlight);
		((Control)E8114CE26).set_Location(new Point(304, 278));
		((Control)E8114CE26).set_Name("label27");
		((Control)E8114CE26).set_Size(new Size(81, 20));
		((Control)E8114CE26).set_TabIndex(26);
		((Control)E8114CE26).add_MouseEnter((EventHandler)D3328C418);
		((Control)BA6847052).set_BackColor(SystemColors.MenuHighlight);
		((Control)BA6847052).set_Location(new Point(385, 303));
		((Control)BA6847052).set_Name("label28");
		((Control)BA6847052).set_Size(new Size(123, 20));
		((Control)BA6847052).set_TabIndex(27);
		((Control)BA6847052).add_MouseEnter((EventHandler)D3328C418);
		((Control)DA5385676).set_BackColor(SystemColors.MenuHighlight);
		((Control)DA5385676).set_Location(new Point(29, 387));
		((Control)DA5385676).set_Name("label29");
		((Control)DA5385676).set_Size(new Size(208, 20));
		((Control)DA5385676).set_TabIndex(28);
		((Control)DA5385676).add_MouseEnter((EventHandler)D3328C418);
		((Control)DC377A678).set_BackColor(SystemColors.MenuHighlight);
		((Control)DC377A678).set_Location(new Point(253, 347));
		((Control)DC377A678).set_Name("label30");
		((Control)DC377A678).set_Size(new Size(19, 117));
		((Control)DC377A678).set_TabIndex(29);
		((Control)DC377A678).add_MouseEnter((EventHandler)D3328C418);
		((Control)F56222762).set_BackColor(SystemColors.MenuHighlight);
		((Control)F56222762).set_Location(new Point(286, 278));
		((Control)F56222762).set_Name("label31");
		((Control)F56222762).set_Size(new Size(19, 91));
		((Control)F56222762).set_TabIndex(30);
		((Control)F56222762).add_MouseEnter((EventHandler)D3328C418);
		((Control)A2A012933).set_BackColor(SystemColors.MenuHighlight);
		((Control)A2A012933).set_Location(new Point(385, 147));
		((Control)A2A012933).set_Name("label32");
		((Control)A2A012933).set_Size(new Size(19, 156));
		((Control)A2A012933).set_TabIndex(31);
		((Control)A2A012933).add_MouseEnter((EventHandler)D3328C418);
		((Control)AF545B1BA).set_BackColor(SystemColors.MenuHighlight);
		((Control)AF545B1BA).set_Location(new Point(448, 67));
		((Control)AF545B1BA).set_Name("label33");
		((Control)AF545B1BA).set_Size(new Size(19, 193));
		((Control)AF545B1BA).set_TabIndex(32);
		((Control)AF545B1BA).add_MouseEnter((EventHandler)D3328C418);
		((Control)D793A45C6).set_BackColor(SystemColors.MenuHighlight);
		((Control)D793A45C6).set_Location(new Point(333, 114));
		((Control)D793A45C6).set_Name("label34");
		((Control)D793A45C6).set_Size(new Size(19, 128));
		((Control)D793A45C6).set_TabIndex(33);
		((Control)D793A45C6).add_MouseEnter((EventHandler)D3328C418);
		((Control)AE7048D3B).set_BackColor(SystemColors.MenuHighlight);
		((Control)AE7048D3B).set_Location(new Point(408, 372));
		((Control)AE7048D3B).set_Name("label35");
		((Control)AE7048D3B).set_Size(new Size(19, 77));
		((Control)AE7048D3B).set_TabIndex(34);
		((Control)AE7048D3B).add_Click((EventHandler)A2A04309C);
		((Control)AE7048D3B).add_MouseEnter((EventHandler)D3328C418);
		((Control)B64639873).set_BackColor(SystemColors.MenuHighlight);
		((Control)B64639873).set_Location(new Point(333, 321));
		((Control)B64639873).set_Name("label36");
		((Control)B64639873).set_Size(new Size(19, 51));
		((Control)B64639873).set_TabIndex(35);
		((Control)B64639873).add_MouseEnter((EventHandler)D3328C418);
		((Control)C5DC5DE28).set_BackColor(SystemColors.MenuHighlight);
		((Control)C5DC5DE28).set_Location(new Point(351, 352));
		((Control)C5DC5DE28).set_Name("label38");
		((Control)C5DC5DE28).set_Size(new Size(153, 20));
		((Control)C5DC5DE28).set_TabIndex(37);
		((Control)C5DC5DE28).add_MouseEnter((EventHandler)D3328C418);
		((Control)A187DF833).set_BackColor(SystemColors.MenuHighlight);
		((Control)A187DF833).set_Location(new Point(455, 387));
		((Control)A187DF833).set_Name("label39");
		((Control)A187DF833).set_Size(new Size(19, 77));
		((Control)A187DF833).set_TabIndex(38);
		((Control)A187DF833).add_MouseEnter((EventHandler)D3328C418);
		((Control)A4C51BC88).set_BackColor(SystemColors.MenuHighlight);
		((Control)A4C51BC88).set_Location(new Point(272, 444));
		((Control)A4C51BC88).set_Name("label40");
		((Control)A4C51BC88).set_Size(new Size(107, 20));
		((Control)A4C51BC88).set_TabIndex(39);
		((Control)A4C51BC88).add_MouseEnter((EventHandler)D3328C418);
		((Control)F40F8DB1F).set_BackColor(SystemColors.MenuHighlight);
		((Control)F40F8DB1F).set_Location(new Point(270, 401));
		((Control)F40F8DB1F).set_Name("label41");
		((Control)F40F8DB1F).set_Size(new Size(141, 20));
		((Control)F40F8DB1F).set_TabIndex(40);
		((Control)F40F8DB1F).add_MouseEnter((EventHandler)D3328C418);
		((Control)E1F9272A0).set_BackColor(SystemColors.MenuHighlight);
		((Control)E1F9272A0).set_Location(new Point(123, 423));
		((Control)E1F9272A0).set_Name("label42");
		((Control)E1F9272A0).set_Size(new Size(130, 20));
		((Control)E1F9272A0).set_TabIndex(41);
		((Control)E1F9272A0).add_MouseEnter((EventHandler)D3328C418);
		((Control)A3727DC1D).set_AutoSize(true);
		((Control)A3727DC1D).set_Location(new Point(501, 455));
		((Control)A3727DC1D).set_Name("finishlabel");
		((Control)A3727DC1D).set_Size(new Size(31, 13));
		((Control)A3727DC1D).set_TabIndex(42);
		((Control)A3727DC1D).set_Text("finish");
		((Control)A3727DC1D).add_MouseEnter((EventHandler)D4A218AC9);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(572, 509));
		((Control)this).get_Controls().Add((Control)(object)FE428CF9F);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("B22613AD3");
		((Control)this).set_Text("MAZE");
		((Control)FE428CF9F).ResumeLayout(false);
		((Control)FE428CF9F).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
