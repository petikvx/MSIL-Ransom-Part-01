using System;
using System.ComponentModel;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace F976818F2;

public class A9C5A16E9 : Form
{
	private SoundPlayer D96B9764A = new SoundPlayer("C:\\Windows\\Media\\chord.wav");

	private SoundPlayer DCC97BFB0 = new SoundPlayer("C:\\Windows\\Media\\tada.wav");

	private IContainer E3848AEDE = null;

	private Panel E88A6E206;

	private Label D03D2C30D;

	private Label C2E85E44E;

	private Label D272DB3DC;

	private Label E511D8CFC;

	private Label E53D289B5;

	private Label D58939B34;

	private Label D08A999E4;

	private Label A2E29C865;

	private Label D7BD72CF3;

	private Label E37441DED;

	private Label D72BC5D96;

	private Label EC565C444;

	private Label D7E8532D5;

	private Label BFCA0F8A9;

	private Label BD50262BE;

	private Label D8FCB289E;

	private Label FC74DDD7C;

	private Label CC2D04D8F;

	private Label B1869D2F4;

	private Label A77E700D5;

	private Label AAA626CA5;

	private Label F1D373227;

	private Label BF5BE7710;

	private Label CBA904D37;

	private Label FE2AC9843;

	private Label C806E19C5;

	private Label D1EC78265;

	private Label B1F8223A2;

	private Label DB2D34C7F;

	private Label E4D227CA5;

	private Label A8026F41E;

	private Label EA3B44340;

	private Label CEDFE3FA6;

	private Label DDB4EFC49;

	private Label BC8C6F0D9;

	private Label DFBBFA504;

	private Label CE0B45257;

	private Label E9D4E4DB5;

	private Label F221F42B7;

	private Label C10655703;

	private Label EA014E6BB;

	private Label E5BEF2F83;

	public A9C5A16E9()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		DDC35E788();
		DD77BC64C();
	}

	private void F7D350DF7(object B8F9BAC7A, EventArgs BF3C7CB1A)
	{
	}

	private void F9DC17478(object ED29010EB, EventArgs ABB4E595D)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		DCC97BFB0.Play();
		MessageBox.Show("Congratulation You won");
		((Form)this).Close();
	}

	private void DD77BC64C()
	{
		D96B9764A.Play();
		Point location = ((Control)E88A6E206).get_Location();
		location.Offset(10, 10);
		Cursor.set_Position(((Control)this).PointToScreen(location));
	}

	private void A2E4D8FAF(object A623A796A, EventArgs C8D58B0A1)
	{
		DD77BC64C();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && E3848AEDE != null)
		{
			E3848AEDE.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void DDC35E788()
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
		E88A6E206 = new Panel();
		E9D4E4DB5 = new Label();
		CE0B45257 = new Label();
		DFBBFA504 = new Label();
		BC8C6F0D9 = new Label();
		DDB4EFC49 = new Label();
		CEDFE3FA6 = new Label();
		EA3B44340 = new Label();
		A8026F41E = new Label();
		E4D227CA5 = new Label();
		DB2D34C7F = new Label();
		B1F8223A2 = new Label();
		D1EC78265 = new Label();
		C806E19C5 = new Label();
		FE2AC9843 = new Label();
		CBA904D37 = new Label();
		BF5BE7710 = new Label();
		F1D373227 = new Label();
		AAA626CA5 = new Label();
		A77E700D5 = new Label();
		B1869D2F4 = new Label();
		CC2D04D8F = new Label();
		FC74DDD7C = new Label();
		D8FCB289E = new Label();
		BD50262BE = new Label();
		BFCA0F8A9 = new Label();
		D7E8532D5 = new Label();
		EC565C444 = new Label();
		D72BC5D96 = new Label();
		E37441DED = new Label();
		D7BD72CF3 = new Label();
		A2E29C865 = new Label();
		D08A999E4 = new Label();
		D58939B34 = new Label();
		E53D289B5 = new Label();
		E511D8CFC = new Label();
		D272DB3DC = new Label();
		C2E85E44E = new Label();
		D03D2C30D = new Label();
		EA014E6BB = new Label();
		C10655703 = new Label();
		F221F42B7 = new Label();
		E5BEF2F83 = new Label();
		((Control)E88A6E206).SuspendLayout();
		((Control)this).SuspendLayout();
		E88A6E206.set_BorderStyle((BorderStyle)2);
		((Control)E88A6E206).get_Controls().Add((Control)(object)E5BEF2F83);
		((Control)E88A6E206).get_Controls().Add((Control)(object)F221F42B7);
		((Control)E88A6E206).get_Controls().Add((Control)(object)C10655703);
		((Control)E88A6E206).get_Controls().Add((Control)(object)EA014E6BB);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D03D2C30D);
		((Control)E88A6E206).get_Controls().Add((Control)(object)C2E85E44E);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D272DB3DC);
		((Control)E88A6E206).get_Controls().Add((Control)(object)E511D8CFC);
		((Control)E88A6E206).get_Controls().Add((Control)(object)E53D289B5);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D58939B34);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D08A999E4);
		((Control)E88A6E206).get_Controls().Add((Control)(object)A2E29C865);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D7BD72CF3);
		((Control)E88A6E206).get_Controls().Add((Control)(object)E37441DED);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D72BC5D96);
		((Control)E88A6E206).get_Controls().Add((Control)(object)EC565C444);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D7E8532D5);
		((Control)E88A6E206).get_Controls().Add((Control)(object)BFCA0F8A9);
		((Control)E88A6E206).get_Controls().Add((Control)(object)BD50262BE);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D8FCB289E);
		((Control)E88A6E206).get_Controls().Add((Control)(object)FC74DDD7C);
		((Control)E88A6E206).get_Controls().Add((Control)(object)CC2D04D8F);
		((Control)E88A6E206).get_Controls().Add((Control)(object)B1869D2F4);
		((Control)E88A6E206).get_Controls().Add((Control)(object)A77E700D5);
		((Control)E88A6E206).get_Controls().Add((Control)(object)AAA626CA5);
		((Control)E88A6E206).get_Controls().Add((Control)(object)F1D373227);
		((Control)E88A6E206).get_Controls().Add((Control)(object)BF5BE7710);
		((Control)E88A6E206).get_Controls().Add((Control)(object)CBA904D37);
		((Control)E88A6E206).get_Controls().Add((Control)(object)FE2AC9843);
		((Control)E88A6E206).get_Controls().Add((Control)(object)C806E19C5);
		((Control)E88A6E206).get_Controls().Add((Control)(object)D1EC78265);
		((Control)E88A6E206).get_Controls().Add((Control)(object)B1F8223A2);
		((Control)E88A6E206).get_Controls().Add((Control)(object)DB2D34C7F);
		((Control)E88A6E206).get_Controls().Add((Control)(object)E4D227CA5);
		((Control)E88A6E206).get_Controls().Add((Control)(object)A8026F41E);
		((Control)E88A6E206).get_Controls().Add((Control)(object)EA3B44340);
		((Control)E88A6E206).get_Controls().Add((Control)(object)CEDFE3FA6);
		((Control)E88A6E206).get_Controls().Add((Control)(object)DDB4EFC49);
		((Control)E88A6E206).get_Controls().Add((Control)(object)BC8C6F0D9);
		((Control)E88A6E206).get_Controls().Add((Control)(object)DFBBFA504);
		((Control)E88A6E206).get_Controls().Add((Control)(object)CE0B45257);
		((Control)E88A6E206).get_Controls().Add((Control)(object)E9D4E4DB5);
		((Control)E88A6E206).set_Location(new Point(12, 12));
		((Control)E88A6E206).set_Name("panel1");
		((Control)E88A6E206).set_Size(new Size(548, 485));
		((Control)E88A6E206).set_TabIndex(0);
		((Control)E88A6E206).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)E9D4E4DB5).set_BackColor(SystemColors.MenuHighlight);
		((Control)E9D4E4DB5).set_Location(new Point(16, 157));
		((Control)E9D4E4DB5).set_Name("label1");
		((Control)E9D4E4DB5).set_Size(new Size(44, 20));
		((Control)E9D4E4DB5).set_TabIndex(0);
		((Control)E9D4E4DB5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)CE0B45257).set_BackColor(SystemColors.MenuHighlight);
		((Control)CE0B45257).set_Location(new Point(84, 308));
		((Control)CE0B45257).set_Name("label2");
		((Control)CE0B45257).set_Size(new Size(202, 20));
		((Control)CE0B45257).set_TabIndex(1);
		((Control)CE0B45257).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)DFBBFA504).set_BackColor(SystemColors.MenuHighlight);
		((Control)DFBBFA504).set_Location(new Point(63, 347));
		((Control)DFBBFA504).set_Name("label3");
		((Control)DFBBFA504).set_Size(new Size(174, 22));
		((Control)DFBBFA504).set_TabIndex(2);
		((Control)DFBBFA504).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)BC8C6F0D9).set_BackColor(SystemColors.MenuHighlight);
		((Control)BC8C6F0D9).set_Location(new Point(86, 258));
		((Control)BC8C6F0D9).set_Name("label4");
		((Control)BC8C6F0D9).set_Size(new Size(70, 20));
		((Control)BC8C6F0D9).set_TabIndex(3);
		((Control)BC8C6F0D9).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)DDB4EFC49).set_BackColor(SystemColors.MenuHighlight);
		((Control)DDB4EFC49).set_Location(new Point(63, 212));
		((Control)DDB4EFC49).set_Name("label5");
		((Control)DDB4EFC49).set_Size(new Size(114, 23));
		((Control)DDB4EFC49).set_TabIndex(4);
		((Control)DDB4EFC49).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)CEDFE3FA6).set_BackColor(SystemColors.MenuHighlight);
		((Control)CEDFE3FA6).set_Location(new Point(107, 147));
		((Control)CEDFE3FA6).set_Name("label6");
		((Control)CEDFE3FA6).set_Size(new Size(175, 18));
		((Control)CEDFE3FA6).set_TabIndex(5);
		((Control)CEDFE3FA6).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)EA3B44340).set_BackColor(SystemColors.MenuHighlight);
		((Control)EA3B44340).set_Location(new Point(385, 23));
		((Control)EA3B44340).set_Name("label7");
		((Control)EA3B44340).set_Size(new Size(127, 21));
		((Control)EA3B44340).set_TabIndex(6);
		((Control)EA3B44340).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)A8026F41E).set_BackColor(SystemColors.MenuHighlight);
		((Control)A8026F41E).set_Location(new Point(324, 77));
		((Control)A8026F41E).set_Name("label8");
		((Control)A8026F41E).set_Size(new Size(41, 19));
		((Control)A8026F41E).set_TabIndex(7);
		((Control)A8026F41E).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)E4D227CA5).set_BackColor(SystemColors.MenuHighlight);
		((Control)E4D227CA5).set_Location(new Point(253, 23));
		((Control)E4D227CA5).set_Name("label9");
		((Control)E4D227CA5).set_Size(new Size(68, 21));
		((Control)E4D227CA5).set_TabIndex(8);
		((Control)E4D227CA5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)DB2D34C7F).set_BackColor(SystemColors.MenuHighlight);
		((Control)DB2D34C7F).set_Location(new Point(77, 100));
		((Control)DB2D34C7F).set_Name("label10");
		((Control)DB2D34C7F).set_Size(new Size(160, 19));
		((Control)DB2D34C7F).set_TabIndex(9);
		((Control)DB2D34C7F).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)B1F8223A2).set_BackColor(SystemColors.MenuHighlight);
		((Control)B1F8223A2).set_Location(new Point(77, 34));
		((Control)B1F8223A2).set_Name("label11");
		((Control)B1F8223A2).set_Size(new Size(79, 21));
		((Control)B1F8223A2).set_TabIndex(10);
		((Control)B1F8223A2).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D1EC78265).set_BackColor(SystemColors.MenuHighlight);
		((Control)D1EC78265).set_Location(new Point(60, 34));
		((Control)D1EC78265).set_Name("label12");
		((Control)D1EC78265).set_Size(new Size(20, 143));
		((Control)D1EC78265).set_TabIndex(11);
		((Control)D1EC78265).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)C806E19C5).set_BackColor(SystemColors.MenuHighlight);
		((Control)C806E19C5).set_Location(new Point(236, 23));
		((Control)C806E19C5).set_Name("label13");
		((Control)C806E19C5).set_Size(new Size(21, 96));
		((Control)C806E19C5).set_TabIndex(12);
		((Control)C806E19C5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)FE2AC9843).set_BackColor(SystemColors.MenuHighlight);
		((Control)FE2AC9843).set_Location(new Point(174, 0));
		((Control)FE2AC9843).set_Name("label14");
		((Control)FE2AC9843).set_Size(new Size(21, 80));
		((Control)FE2AC9843).set_TabIndex(13);
		((Control)FE2AC9843).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)CBA904D37).set_BackColor(SystemColors.MenuHighlight);
		((Control)CBA904D37).set_Location(new Point(282, 62));
		((Control)CBA904D37).set_Name("label15");
		((Control)CBA904D37).set_Size(new Size(19, 180));
		((Control)CBA904D37).set_TabIndex(14);
		((Control)CBA904D37).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)BF5BE7710).set_BackColor(SystemColors.MenuHighlight);
		((Control)BF5BE7710).set_Location(new Point(9, 417));
		((Control)BF5BE7710).set_Name("label16");
		((Control)BF5BE7710).set_Size(new Size(17, 45));
		((Control)BF5BE7710).set_TabIndex(15);
		((Control)BF5BE7710).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)F1D373227).set_BackColor(SystemColors.MenuHighlight);
		((Control)F1D373227).set_Location(new Point(63, 407));
		((Control)F1D373227).set_Name("label17");
		((Control)F1D373227).set_Size(new Size(17, 33));
		((Control)F1D373227).set_TabIndex(16);
		((Control)F1D373227).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)AAA626CA5).set_BackColor(SystemColors.MenuHighlight);
		((Control)AAA626CA5).set_Location(new Point(504, 114));
		((Control)AAA626CA5).set_Name("label18");
		((Control)AAA626CA5).set_Size(new Size(20, 296));
		((Control)AAA626CA5).set_TabIndex(17);
		((Control)AAA626CA5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)A77E700D5).set_BackColor(SystemColors.MenuHighlight);
		((Control)A77E700D5).set_Location(new Point(155, 235));
		((Control)A77E700D5).set_Name("label19");
		((Control)A77E700D5).set_Size(new Size(22, 43));
		((Control)A77E700D5).set_TabIndex(18);
		((Control)A77E700D5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)B1869D2F4).set_BackColor(SystemColors.MenuHighlight);
		((Control)B1869D2F4).set_Location(new Point(43, 212));
		((Control)B1869D2F4).set_Name("label20");
		((Control)B1869D2F4).set_Size(new Size(20, 157));
		((Control)B1869D2F4).set_TabIndex(19);
		((Control)B1869D2F4).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)CC2D04D8F).set_BackColor(SystemColors.MenuHighlight);
		((Control)CC2D04D8F).set_Location(new Point(107, 165));
		((Control)CC2D04D8F).set_Name("label21");
		((Control)CC2D04D8F).set_Size(new Size(22, 47));
		((Control)CC2D04D8F).set_TabIndex(20);
		((Control)CC2D04D8F).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)FC74DDD7C).set_BackColor(SystemColors.MenuHighlight);
		((Control)FC74DDD7C).set_Location(new Point(362, 0));
		((Control)FC74DDD7C).set_Name("label22");
		((Control)FC74DDD7C).set_Size(new Size(23, 96));
		((Control)FC74DDD7C).set_TabIndex(21);
		((Control)FC74DDD7C).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D8FCB289E).set_BackColor(SystemColors.MenuHighlight);
		((Control)D8FCB289E).set_Location(new Point(218, 164));
		((Control)D8FCB289E).set_Name("label23");
		((Control)D8FCB289E).set_Size(new Size(19, 126));
		((Control)D8FCB289E).set_TabIndex(22);
		((Control)D8FCB289E).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)BD50262BE).set_BackColor(SystemColors.MenuHighlight);
		((Control)BD50262BE).set_Location(new Point(282, 242));
		((Control)BD50262BE).set_Name("label24");
		((Control)BD50262BE).set_Size(new Size(70, 20));
		((Control)BD50262BE).set_TabIndex(23);
		((Control)BD50262BE).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)BFCA0F8A9).set_BackColor(SystemColors.MenuHighlight);
		((Control)BFCA0F8A9).set_Location(new Point(466, 67));
		((Control)BFCA0F8A9).set_Name("label25");
		((Control)BFCA0F8A9).set_Size(new Size(58, 20));
		((Control)BFCA0F8A9).set_TabIndex(24);
		((Control)BFCA0F8A9).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D7E8532D5).set_BackColor(SystemColors.MenuHighlight);
		((Control)D7E8532D5).set_Location(new Point(348, 114));
		((Control)D7E8532D5).set_Name("label26");
		((Control)D7E8532D5).set_Size(new Size(100, 20));
		((Control)D7E8532D5).set_TabIndex(25);
		((Control)D7E8532D5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)EC565C444).set_BackColor(SystemColors.MenuHighlight);
		((Control)EC565C444).set_Location(new Point(304, 278));
		((Control)EC565C444).set_Name("label27");
		((Control)EC565C444).set_Size(new Size(81, 20));
		((Control)EC565C444).set_TabIndex(26);
		((Control)EC565C444).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D72BC5D96).set_BackColor(SystemColors.MenuHighlight);
		((Control)D72BC5D96).set_Location(new Point(385, 303));
		((Control)D72BC5D96).set_Name("label28");
		((Control)D72BC5D96).set_Size(new Size(123, 20));
		((Control)D72BC5D96).set_TabIndex(27);
		((Control)D72BC5D96).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)E37441DED).set_BackColor(SystemColors.MenuHighlight);
		((Control)E37441DED).set_Location(new Point(29, 387));
		((Control)E37441DED).set_Name("label29");
		((Control)E37441DED).set_Size(new Size(208, 20));
		((Control)E37441DED).set_TabIndex(28);
		((Control)E37441DED).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D7BD72CF3).set_BackColor(SystemColors.MenuHighlight);
		((Control)D7BD72CF3).set_Location(new Point(253, 347));
		((Control)D7BD72CF3).set_Name("label30");
		((Control)D7BD72CF3).set_Size(new Size(19, 117));
		((Control)D7BD72CF3).set_TabIndex(29);
		((Control)D7BD72CF3).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)A2E29C865).set_BackColor(SystemColors.MenuHighlight);
		((Control)A2E29C865).set_Location(new Point(286, 278));
		((Control)A2E29C865).set_Name("label31");
		((Control)A2E29C865).set_Size(new Size(19, 91));
		((Control)A2E29C865).set_TabIndex(30);
		((Control)A2E29C865).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D08A999E4).set_BackColor(SystemColors.MenuHighlight);
		((Control)D08A999E4).set_Location(new Point(385, 147));
		((Control)D08A999E4).set_Name("label32");
		((Control)D08A999E4).set_Size(new Size(19, 156));
		((Control)D08A999E4).set_TabIndex(31);
		((Control)D08A999E4).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D58939B34).set_BackColor(SystemColors.MenuHighlight);
		((Control)D58939B34).set_Location(new Point(448, 67));
		((Control)D58939B34).set_Name("label33");
		((Control)D58939B34).set_Size(new Size(19, 193));
		((Control)D58939B34).set_TabIndex(32);
		((Control)D58939B34).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)E53D289B5).set_BackColor(SystemColors.MenuHighlight);
		((Control)E53D289B5).set_Location(new Point(333, 114));
		((Control)E53D289B5).set_Name("label34");
		((Control)E53D289B5).set_Size(new Size(19, 128));
		((Control)E53D289B5).set_TabIndex(33);
		((Control)E53D289B5).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)E511D8CFC).set_BackColor(SystemColors.MenuHighlight);
		((Control)E511D8CFC).set_Location(new Point(408, 372));
		((Control)E511D8CFC).set_Name("label35");
		((Control)E511D8CFC).set_Size(new Size(19, 77));
		((Control)E511D8CFC).set_TabIndex(34);
		((Control)E511D8CFC).add_Click((EventHandler)F7D350DF7);
		((Control)E511D8CFC).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D272DB3DC).set_BackColor(SystemColors.MenuHighlight);
		((Control)D272DB3DC).set_Location(new Point(333, 321));
		((Control)D272DB3DC).set_Name("label36");
		((Control)D272DB3DC).set_Size(new Size(19, 51));
		((Control)D272DB3DC).set_TabIndex(35);
		((Control)D272DB3DC).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)C2E85E44E).set_BackColor(SystemColors.MenuHighlight);
		((Control)C2E85E44E).set_Location(new Point(351, 352));
		((Control)C2E85E44E).set_Name("label38");
		((Control)C2E85E44E).set_Size(new Size(153, 20));
		((Control)C2E85E44E).set_TabIndex(37);
		((Control)C2E85E44E).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)D03D2C30D).set_BackColor(SystemColors.MenuHighlight);
		((Control)D03D2C30D).set_Location(new Point(455, 387));
		((Control)D03D2C30D).set_Name("label39");
		((Control)D03D2C30D).set_Size(new Size(19, 77));
		((Control)D03D2C30D).set_TabIndex(38);
		((Control)D03D2C30D).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)EA014E6BB).set_BackColor(SystemColors.MenuHighlight);
		((Control)EA014E6BB).set_Location(new Point(272, 444));
		((Control)EA014E6BB).set_Name("label40");
		((Control)EA014E6BB).set_Size(new Size(107, 20));
		((Control)EA014E6BB).set_TabIndex(39);
		((Control)EA014E6BB).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)C10655703).set_BackColor(SystemColors.MenuHighlight);
		((Control)C10655703).set_Location(new Point(270, 401));
		((Control)C10655703).set_Name("label41");
		((Control)C10655703).set_Size(new Size(141, 20));
		((Control)C10655703).set_TabIndex(40);
		((Control)C10655703).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)F221F42B7).set_BackColor(SystemColors.MenuHighlight);
		((Control)F221F42B7).set_Location(new Point(123, 423));
		((Control)F221F42B7).set_Name("label42");
		((Control)F221F42B7).set_Size(new Size(130, 20));
		((Control)F221F42B7).set_TabIndex(41);
		((Control)F221F42B7).add_MouseEnter((EventHandler)A2E4D8FAF);
		((Control)E5BEF2F83).set_AutoSize(true);
		((Control)E5BEF2F83).set_Location(new Point(501, 455));
		((Control)E5BEF2F83).set_Name("finishlabel");
		((Control)E5BEF2F83).set_Size(new Size(31, 13));
		((Control)E5BEF2F83).set_TabIndex(42);
		((Control)E5BEF2F83).set_Text("finish");
		((Control)E5BEF2F83).add_MouseEnter((EventHandler)F9DC17478);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(572, 509));
		((Control)this).get_Controls().Add((Control)(object)E88A6E206);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("A9C5A16E9");
		((Control)this).set_Text("MAZE");
		((Control)E88A6E206).ResumeLayout(false);
		((Control)E88A6E206).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
