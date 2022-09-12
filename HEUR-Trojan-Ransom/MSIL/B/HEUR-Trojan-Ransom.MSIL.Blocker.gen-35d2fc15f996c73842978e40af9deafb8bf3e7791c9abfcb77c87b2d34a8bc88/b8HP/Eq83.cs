using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pz08;

namespace b8HP;

[DesignerGenerated]
public class Eq83 : Form
{
	private IContainer components;

	private PictureBox _NameBox;

	private GroupBox _GroupBox1;

	private GroupBox _GroupBox4;

	private PictureBox _Cover;

	private TextBox _txtProvisional;

	private PictureBox _Available;

	private Label _Label4;

	private Label _Label5;

	private Label _Label9;

	private Label _Label10;

	private Label _Label11;

	private Label _Label13;

	private Label _Label14;

	private Label _Label15;

	private Label _Label17;

	private Label _Label18;

	private Label _Label19;

	private Label _Label22;

	private Label _Label23;

	private Label _Label26;

	private Label _Label27;

	private Label _Label28;

	private Label _Label31;

	private Label _Label54;

	private Label _Label55;

	private TextBox _txtFirstName;

	private Label _Label60;

	private TextBox _txtTotalCost;

	private TextBox _txtSeats;

	private Label _Label63;

	private Label _Label61;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox16;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox24;

	private PictureBox _PictureBox26;

	private PictureBox _PictureBox28;

	private PictureBox _PictureBox31;

	private PictureBox _PictureBox33;

	private PictureBox _PictureBox35;

	private PictureBox _PictureBox36;

	private PictureBox _PictureBox38;

	private PictureBox _PictureBox39;

	private PictureBox _PictureBox40;

	private Label _Label32;

	private Label _Label33;

	private Label _Label34;

	private Label _Label36;

	private Label _Label38;

	private Label _Label40;

	private Label _Label41;

	private Label _Label45;

	private Label _Label46;

	private Label _Label48;

	private PictureBox _PictureBox42;

	private PictureBox _PictureBox43;

	private PictureBox _PictureBox44;

	private PictureBox _PictureBox45;

	private PictureBox _PictureBox47;

	private PictureBox _PictureBox49;

	private PictureBox _PictureBox50;

	private PictureBox _PictureBox51;

	private PictureBox _PictureBox52;

	private PictureBox _PictureBox53;

	private PictureBox _PictureBox54;

	private PictureBox _PictureBox55;

	private PictureBox _PictureBox57;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox61;

	private PictureBox _PictureBox62;

	private PictureBox _PictureBox69;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox75;

	private PictureBox _PictureBox76;

	private PictureBox _PictureBox78;

	private PictureBox _PictureBox79;

	private PictureBox _PictureBox82;

	private PictureBox _PictureBox83;

	private PictureBox _PictureBox87;

	private PictureBox _PictureBox89;

	private PictureBox _PictureBox91;

	private PictureBox _PictureBox92;

	private PictureBox _PictureBox94;

	private PictureBox _PictureBox95;

	private PictureBox _PictureBox97;

	private PictureBox _PictureBox99;

	private PictureBox _PictureBox106;

	private PictureBox _PictureBox107;

	private PictureBox _PictureBox115;

	private PictureBox _PictureBox116;

	private PictureBox _PictureBox117;

	private PictureBox _PictureBox118;

	private PictureBox _PictureBox120;

	private PictureBox _PictureBox122;

	private PictureBox _PictureBox125;

	private PictureBox _PictureBox127;

	private PictureBox _PictureBox128;

	private PictureBox _PictureBox129;

	private PictureBox _PictureBox131;

	private PictureBox _PictureBox132;

	private PictureBox _PictureBox133;

	private PictureBox _PictureBox135;

	private PictureBox _PictureBox138;

	private PictureBox _PictureBox139;

	private PictureBox _PictureBox140;

	private PictureBox _PictureBox141;

	private PictureBox _PictureBox142;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox150;

	private PictureBox _PictureBox151;

	private PictureBox _PictureBox156;

	private PictureBox _PictureBox157;

	private PictureBox _PictureBox158;

	private PictureBox _PictureBox160;

	private Button _btnNew;

	private Button _btnReset;

	private Button _btnSave;

	private object provisionalIcon;

	private int bookedSeats;

	private int provisionalSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal PictureBox A;

	internal Label y;

	internal GroupBox C;

	internal GroupBox S;

	internal TextBox d;

	internal TextBox O;

	internal PictureBox Q;

	internal PictureBox E;

	internal Label W;

	internal Label p;

	internal Label B;

	internal Label u;

	internal Label X;

	internal Label G;

	internal Label V;

	internal Label t;

	internal Label I;

	internal Label K;

	internal Label j;

	internal Label r;

	internal TextBox N;

	internal Label m;

	internal TextBox h;

	internal TextBox f;

	internal Label l;

	internal Label z;

	internal Label yA;

	internal Label yy;

	internal PictureBox yC;

	internal PictureBox yS;

	internal PictureBox yd;

	internal PictureBox yO;

	internal PictureBox yQ;

	internal PictureBox yE;

	internal PictureBox yW;

	internal PictureBox yp;

	internal PictureBox yB;

	internal PictureBox yu;

	internal PictureBox yX;

	internal PictureBox yG;

	internal PictureBox yV;

	internal PictureBox yt;

	internal PictureBox yI;

	internal PictureBox yK;

	internal PictureBox yj;

	internal PictureBox yr;

	internal PictureBox yN;

	internal Label ym;

	internal Label yh;

	internal Label yf;

	internal Label yl;

	internal Label yz;

	internal Label CA;

	internal Label Cy;

	internal Label CC;

	internal Label CS;

	internal Label Cd;

	internal PictureBox CO;

	internal PictureBox CQ;

	internal PictureBox CE;

	internal PictureBox CW;

	internal PictureBox Cp;

	internal PictureBox CB;

	internal PictureBox Cu;

	internal PictureBox CX;

	internal PictureBox CG;

	internal PictureBox CV;

	internal PictureBox Ct;

	internal PictureBox CI;

	internal PictureBox CK;

	internal PictureBox Cj;

	internal PictureBox Cr;

	internal PictureBox CN;

	internal PictureBox Cm;

	internal PictureBox Ch;

	internal PictureBox Cf;

	internal PictureBox Cl;

	internal PictureBox Cz;

	internal PictureBox SA;

	internal PictureBox Sy;

	internal PictureBox SC;

	internal PictureBox SS;

	internal PictureBox Sd;

	internal PictureBox SO;

	internal PictureBox SQ;

	internal PictureBox SE;

	internal PictureBox SW;

	internal PictureBox Sp;

	internal PictureBox SB;

	internal PictureBox Su;

	internal PictureBox SX;

	internal PictureBox SG;

	internal PictureBox SV;

	internal PictureBox St;

	internal PictureBox SI;

	internal PictureBox SK;

	internal PictureBox Sj;

	internal PictureBox Sr;

	internal PictureBox SN;

	internal PictureBox Sm;

	internal PictureBox Sh;

	internal PictureBox Sf;

	internal PictureBox Sl;

	internal PictureBox Sz;

	internal PictureBox dA;

	internal PictureBox dy;

	internal PictureBox dC;

	internal PictureBox dS;

	internal PictureBox dd;

	internal PictureBox dO;

	internal PictureBox dQ;

	internal PictureBox dE;

	internal PictureBox dW;

	internal PictureBox dp;

	internal PictureBox dB;

	internal PictureBox du;

	internal PictureBox dX;

	internal Button dG;

	internal Button dV;

	internal Button dt;

	internal object dI;

	internal object dK;

	internal int dj;

	public Eq83()
	{
		((Form)this).add_Load((EventHandler)a5YP);
		object obj = (dI = RuntimeHelpers.GetObjectValue(new object()));
		provisionalIcon = RuntimeHelpers.GetObjectValue(new object());
		object obj2 = (dK = RuntimeHelpers.GetObjectValue(new object()));
		w3X();
	}

	protected override void e3DX(bool g6WL)
	{
		try
		{
			if (g6WL && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g6WL);
		}
	}

	private void w3X()
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
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0318: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Expected O, but got Unknown
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a7: Expected O, but got Unknown
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Expected O, but got Unknown
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03de: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f4: Expected O, but got Unknown
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Expected O, but got Unknown
		//IL_0400: Unknown result type (might be due to invalid IL or missing references)
		//IL_040a: Expected O, but got Unknown
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0415: Expected O, but got Unknown
		//IL_0416: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0421: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0436: Expected O, but got Unknown
		//IL_0437: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0457: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Expected O, but got Unknown
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0483: Expected O, but got Unknown
		//IL_0484: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_048f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0499: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04af: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ba: Expected O, but got Unknown
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c5: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04db: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Expected O, but got Unknown
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0512: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Expected O, but got Unknown
		//IL_056b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_0576: Unknown result type (might be due to invalid IL or missing references)
		//IL_0580: Expected O, but got Unknown
		//IL_0581: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_058c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a1: Expected O, but got Unknown
		//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ac: Expected O, but got Unknown
		//IL_05ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Expected O, but got Unknown
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cd: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Expected O, but got Unknown
		//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ee: Expected O, but got Unknown
		//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_05fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_060f: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061a: Expected O, but got Unknown
		//IL_061b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Expected O, but got Unknown
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_0631: Unknown result type (might be due to invalid IL or missing references)
		//IL_063b: Expected O, but got Unknown
		//IL_063c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0646: Expected O, but got Unknown
		//IL_0647: Unknown result type (might be due to invalid IL or missing references)
		//IL_0651: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_0672: Expected O, but got Unknown
		//IL_0673: Unknown result type (might be due to invalid IL or missing references)
		//IL_067d: Expected O, but got Unknown
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0688: Expected O, but got Unknown
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_0693: Expected O, but got Unknown
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_069e: Expected O, but got Unknown
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a9: Expected O, but got Unknown
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ca: Expected O, but got Unknown
		//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06eb: Expected O, but got Unknown
		//IL_06ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_070d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_0718: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Expected O, but got Unknown
		//IL_0723: Unknown result type (might be due to invalid IL or missing references)
		//IL_072d: Expected O, but got Unknown
		//IL_072e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_074e: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_077b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0785: Expected O, but got Unknown
		//IL_0786: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Expected O, but got Unknown
		//IL_0791: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Expected O, but got Unknown
		//IL_079c: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a6: Expected O, but got Unknown
		//IL_07a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b1: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bc: Expected O, but got Unknown
		//IL_07bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c7: Expected O, but got Unknown
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_07f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fe: Expected O, but got Unknown
		//IL_07ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0809: Expected O, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_0815: Unknown result type (might be due to invalid IL or missing references)
		//IL_081f: Expected O, but got Unknown
		//IL_0820: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_084c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0856: Expected O, but got Unknown
		//IL_0857: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_086d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0877: Expected O, but got Unknown
		//IL_0878: Unknown result type (might be due to invalid IL or missing references)
		//IL_0882: Expected O, but got Unknown
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_088d: Expected O, but got Unknown
		//IL_088e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0898: Expected O, but got Unknown
		//IL_0899: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a3: Expected O, but got Unknown
		//IL_08a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ae: Expected O, but got Unknown
		//IL_08af: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b9: Expected O, but got Unknown
		//IL_08ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c4: Expected O, but got Unknown
		//IL_08c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected O, but got Unknown
		//IL_08db: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e5: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0906: Expected O, but got Unknown
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_0911: Expected O, but got Unknown
		//IL_0912: Unknown result type (might be due to invalid IL or missing references)
		//IL_091c: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_0949: Unknown result type (might be due to invalid IL or missing references)
		//IL_0953: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_095f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0969: Expected O, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_0975: Unknown result type (might be due to invalid IL or missing references)
		//IL_097f: Expected O, but got Unknown
		//IL_0980: Unknown result type (might be due to invalid IL or missing references)
		//IL_098a: Expected O, but got Unknown
		//IL_098b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0995: Expected O, but got Unknown
		//IL_0996: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a0: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ab: Expected O, but got Unknown
		//IL_09ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Expected O, but got Unknown
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c1: Expected O, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_09e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ed: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a03: Expected O, but got Unknown
		//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0e: Expected O, but got Unknown
		//IL_0a0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a19: Expected O, but got Unknown
		//IL_0a1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a24: Expected O, but got Unknown
		//IL_0a25: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a2f: Expected O, but got Unknown
		//IL_0a30: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Expected O, but got Unknown
		//IL_0a3b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a45: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a50: Expected O, but got Unknown
		//IL_0a51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5b: Expected O, but got Unknown
		//IL_0a5c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a66: Expected O, but got Unknown
		//IL_0a67: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a71: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0a7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a87: Expected O, but got Unknown
		//IL_12cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d6: Expected O, but got Unknown
		Zn6(new PictureBox());
		Qm4(new PictureBox());
		q7R(new Label());
		m5Q(new GroupBox());
		Cg8(new TextBox());
		w0C(new TextBox());
		Zb3(new TextBox());
		n3N(new PictureBox());
		s9E(new PictureBox());
		Qa2(new PictureBox());
		Xa4(new Label());
		a2N(new Label());
		y3B(new Label());
		y5W(new GroupBox());
		n7QM(new Button());
		Wy5q(new Button());
		Bj9k(new Button());
		g2J(new TextBox());
		Tc7(new TextBox());
		c8D(new Label());
		g2G(new Label());
		Pn9(new GroupBox());
		r1KC(new Button());
		t0Q(new PictureBox());
		y9E(new GroupBox());
		Wn9e(new Button());
		Bb76(new Button());
		Gy9(new TextBox());
		Br9(new TextBox());
		Kq8(new TextBox());
		k5Y(new TextBox());
		Tq4(new Label());
		Bc1(new Label());
		d1A(new Label());
		Nd2(new Label());
		Lx8(new Label());
		Gn6(new Label());
		d4C(new Label());
		Fd7(new Label());
		Xw1(new Label());
		k4J(new Label());
		j3D(new Label());
		y1H(new Label());
		Cq4(new Label());
		Zc1(new Label());
		f1E(new Label());
		d6D(new Label());
		Kx0(new Label());
		Rw0(new Label());
		n1E(new Label());
		Rf0(new Label());
		r2N(new Label());
		q3A(new Label());
		q7F(new Label());
		Yr5(new Label());
		Fb9(new Label());
		y0Y(new Label());
		Wf8(new Label());
		Zb8(new Label());
		Jf1(new Label());
		Ed0(new Label());
		c3K(new Label());
		At3(new Label());
		y5N(new Label());
		Ld6(new Label());
		Tz7(new PictureBox());
		Li4(new PictureBox());
		y3F(new PictureBox());
		q4N(new PictureBox());
		Hq7(new PictureBox());
		b0W(new PictureBox());
		Wt3(new PictureBox());
		Mr7(new PictureBox());
		Ma6(new PictureBox());
		Sj9(new PictureBox());
		m1S(new PictureBox());
		e3J(new PictureBox());
		Pe8(new PictureBox());
		Bb7(new PictureBox());
		Qd5(new PictureBox());
		Bw2o(new PictureBox());
		Rc78(new PictureBox());
		We9o(new PictureBox());
		Aq49(new PictureBox());
		y6KB(new PictureBox());
		Le8a(new PictureBox());
		Er1s(new PictureBox());
		Pp4e(new PictureBox());
		a6Q9(new PictureBox());
		Nj0a(new PictureBox());
		d9CM(new PictureBox());
		Xw03(new PictureBox());
		j0XG(new PictureBox());
		Gb73(new PictureBox());
		f2W7(new PictureBox());
		Co0m(new PictureBox());
		Jq21(new PictureBox());
		p3H4(new PictureBox());
		Td79(new PictureBox());
		n5W0(new PictureBox());
		Hz8e(new PictureBox());
		Lp3i(new PictureBox());
		Zk81(new PictureBox());
		m8TN(new PictureBox());
		My46(new PictureBox());
		Dt4s(new Label());
		m3N0(new Label());
		n2P5(new Label());
		Lz4k(new Label());
		Hk08(new Label());
		t6PX(new Label());
		Mz65(new Label());
		Pg8s(new Label());
		Aq9r(new Label());
		Ni8n(new Label());
		s5G4(new Label());
		y0T4(new Label());
		Gz18(new Label());
		Cf64(new Label());
		Js7w(new Label());
		m1X4(new Label());
		Ek1o(new Label());
		b1Y5(new Label());
		p0A6(new Label());
		r5PA(new Label());
		t1Q9(new PictureBox());
		y6QZ(new PictureBox());
		s6XK(new PictureBox());
		j6PW(new PictureBox());
		q3PT(new PictureBox());
		Xq79(new PictureBox());
		Ae61(new PictureBox());
		g5DJ(new PictureBox());
		c8Q6(new PictureBox());
		w4Y7(new PictureBox());
		z6FH(new PictureBox());
		Ba9z(new PictureBox());
		Wp9g(new PictureBox());
		n1WJ(new PictureBox());
		Bo7y(new PictureBox());
		p2XB(new PictureBox());
		Lz2a(new PictureBox());
		Km93(new PictureBox());
		Pf2x(new PictureBox());
		Mc5y(new PictureBox());
		c4J9(new PictureBox());
		Kd6z(new PictureBox());
		o5R3(new PictureBox());
		p4MW(new PictureBox());
		Kb79(new PictureBox());
		Rn1t(new PictureBox());
		f3M0(new PictureBox());
		p5K4(new PictureBox());
		s4BG(new PictureBox());
		Ww5q(new PictureBox());
		x3J9(new PictureBox());
		m2FT(new PictureBox());
		o6H2(new PictureBox());
		Rq4x(new PictureBox());
		e7H5(new PictureBox());
		z5Y3(new PictureBox());
		Hy86(new PictureBox());
		r0ZB(new PictureBox());
		Qf6i(new PictureBox());
		Lo25(new PictureBox());
		Ps3o(new PictureBox());
		a4T5(new PictureBox());
		Wa96(new PictureBox());
		j9Z1(new PictureBox());
		z1Z5(new PictureBox());
		Cy7g(new PictureBox());
		Kq94(new PictureBox());
		c2MC(new PictureBox());
		r3R4(new PictureBox());
		Yp1e(new PictureBox());
		j8CG(new PictureBox());
		Dq1r(new PictureBox());
		Tz49(new PictureBox());
		Ec50(new PictureBox());
		Bi57(new PictureBox());
		Re5i(new PictureBox());
		f8FM(new PictureBox());
		Xz4t(new PictureBox());
		p1B0(new PictureBox());
		r1QC(new PictureBox());
		d4D3(new PictureBox());
		Gd5z(new PictureBox());
		Ws1w(new PictureBox());
		Hw84(new PictureBox());
		Fw59(new PictureBox());
		Ga1i(new PictureBox());
		Er24(new PictureBox());
		Xw7o(new PictureBox());
		Pj8k(new PictureBox());
		y4ZT(new PictureBox());
		Mc8b(new PictureBox());
		Jq94(new PictureBox());
		Ap17(new PictureBox());
		d2Y5(new PictureBox());
		Jz28(new PictureBox());
		Rn3q(new PictureBox());
		m9D4(new PictureBox());
		f2F3(new PictureBox());
		Xe50(new PictureBox());
		Gq43(new PictureBox());
		Mt41(new PictureBox());
		Jq0m(new PictureBox());
		q1Y9(new PictureBox());
		Xx7r(new PictureBox());
		Bk31(new PictureBox());
		Ai29(new PictureBox());
		j7GC(new PictureBox());
		Rj0r(new PictureBox());
		g7N1(new PictureBox());
		k9RT(new PictureBox());
		Nm6s(new PictureBox());
		t8ET(new PictureBox());
		s2Z6(new PictureBox());
		j9F0(new PictureBox());
		Rn19(new PictureBox());
		Ki6s(new PictureBox());
		q1SB(new PictureBox());
		Dc47(new PictureBox());
		t8E1(new PictureBox());
		i7WA(new PictureBox());
		z4N8(new PictureBox());
		t5A7(new PictureBox());
		w5WR(new PictureBox());
		Ra3x(new PictureBox());
		o8ZF(new PictureBox());
		g3TY(new PictureBox());
		x9Z5(new PictureBox());
		Rp73(new PictureBox());
		Wq5x(new PictureBox());
		Eb4c(new PictureBox());
		Na8b(new PictureBox());
		o0LY(new PictureBox());
		He86(new PictureBox());
		n8W7(new PictureBox());
		s3CP(new PictureBox());
		Li52(new PictureBox());
		Ei70(new PictureBox());
		Wj6o(new PictureBox());
		Zb5c(new PictureBox());
		s0Q3(new PictureBox());
		((ISupportInitialize)i5C()).BeginInit();
		((ISupportInitialize)s2P()).BeginInit();
		((Control)r4J()).SuspendLayout();
		((ISupportInitialize)w3N()).BeginInit();
		((ISupportInitialize)e0F()).BeginInit();
		((ISupportInitialize)o2Z()).BeginInit();
		((Control)Mk2()).SuspendLayout();
		((Control)g9F()).SuspendLayout();
		((ISupportInitialize)Lr3()).BeginInit();
		((Control)d5K()).SuspendLayout();
		((ISupportInitialize)a1Q()).BeginInit();
		((ISupportInitialize)a7P()).BeginInit();
		((ISupportInitialize)Xb7()).BeginInit();
		((ISupportInitialize)e5H()).BeginInit();
		((ISupportInitialize)Fj9()).BeginInit();
		((ISupportInitialize)o1M()).BeginInit();
		((ISupportInitialize)n7K()).BeginInit();
		((ISupportInitialize)Qz7()).BeginInit();
		((ISupportInitialize)Go3()).BeginInit();
		((ISupportInitialize)n6S()).BeginInit();
		((ISupportInitialize)x9T()).BeginInit();
		((ISupportInitialize)Lf2()).BeginInit();
		((ISupportInitialize)x7T()).BeginInit();
		((ISupportInitialize)t9W()).BeginInit();
		((ISupportInitialize)Sq0()).BeginInit();
		((ISupportInitialize)Xo7()).BeginInit();
		((ISupportInitialize)r3W4()).BeginInit();
		((ISupportInitialize)y8S9()).BeginInit();
		((ISupportInitialize)Kb3i()).BeginInit();
		((ISupportInitialize)d3Y4()).BeginInit();
		((ISupportInitialize)Ya6x()).BeginInit();
		((ISupportInitialize)g1ST()).BeginInit();
		((ISupportInitialize)Qa80()).BeginInit();
		((ISupportInitialize)Nd4m()).BeginInit();
		((ISupportInitialize)Sq3o()).BeginInit();
		((ISupportInitialize)d2M6()).BeginInit();
		((ISupportInitialize)Ni8p()).BeginInit();
		((ISupportInitialize)t2H8()).BeginInit();
		((ISupportInitialize)f3JW()).BeginInit();
		((ISupportInitialize)Bj9a()).BeginInit();
		((ISupportInitialize)x1SC()).BeginInit();
		((ISupportInitialize)m1DN()).BeginInit();
		((ISupportInitialize)Pp96()).BeginInit();
		((ISupportInitialize)j9E5()).BeginInit();
		((ISupportInitialize)Ls45()).BeginInit();
		((ISupportInitialize)a2N5()).BeginInit();
		((ISupportInitialize)Eq4y()).BeginInit();
		((ISupportInitialize)Cs27()).BeginInit();
		((ISupportInitialize)Ao91()).BeginInit();
		((ISupportInitialize)Hs05()).BeginInit();
		((ISupportInitialize)j4A9()).BeginInit();
		((ISupportInitialize)c6LQ()).BeginInit();
		((ISupportInitialize)d4C6()).BeginInit();
		((ISupportInitialize)r4TC()).BeginInit();
		((ISupportInitialize)Qy23()).BeginInit();
		((ISupportInitialize)r7J1()).BeginInit();
		((ISupportInitialize)e9C2()).BeginInit();
		((ISupportInitialize)Nm51()).BeginInit();
		((ISupportInitialize)Ax9o()).BeginInit();
		((ISupportInitialize)Tn91()).BeginInit();
		((ISupportInitialize)e1GJ()).BeginInit();
		((ISupportInitialize)Fn84()).BeginInit();
		((ISupportInitialize)Zf7m()).BeginInit();
		((ISupportInitialize)w5WY()).BeginInit();
		((ISupportInitialize)y1P6()).BeginInit();
		((ISupportInitialize)Qm38()).BeginInit();
		((ISupportInitialize)Ss59()).BeginInit();
		((ISupportInitialize)Lc16()).BeginInit();
		((ISupportInitialize)n5LD()).BeginInit();
		((ISupportInitialize)Hd5f()).BeginInit();
		((ISupportInitialize)Zi2f()).BeginInit();
		((ISupportInitialize)Lw78()).BeginInit();
		((ISupportInitialize)Kb93()).BeginInit();
		((ISupportInitialize)a1J2()).BeginInit();
		((ISupportInitialize)Kb9r()).BeginInit();
		((ISupportInitialize)f1K6()).BeginInit();
		((ISupportInitialize)b1PY()).BeginInit();
		((ISupportInitialize)Yr28()).BeginInit();
		((ISupportInitialize)Ld98()).BeginInit();
		((ISupportInitialize)j1F0()).BeginInit();
		((ISupportInitialize)p1P6()).BeginInit();
		((ISupportInitialize)Lx2j()).BeginInit();
		((ISupportInitialize)Hi8g()).BeginInit();
		((ISupportInitialize)Zp2c()).BeginInit();
		((ISupportInitialize)c0PE()).BeginInit();
		((ISupportInitialize)Gz23()).BeginInit();
		((ISupportInitialize)z1JZ()).BeginInit();
		((ISupportInitialize)m0RA()).BeginInit();
		((ISupportInitialize)Sy67()).BeginInit();
		((ISupportInitialize)At3b()).BeginInit();
		((ISupportInitialize)Le04()).BeginInit();
		((ISupportInitialize)w0WP()).BeginInit();
		((ISupportInitialize)a5K8()).BeginInit();
		((ISupportInitialize)Dy89()).BeginInit();
		((ISupportInitialize)Rc1g()).BeginInit();
		((ISupportInitialize)o1A2()).BeginInit();
		((ISupportInitialize)z2R5()).BeginInit();
		((ISupportInitialize)y4YA()).BeginInit();
		((ISupportInitialize)Zt0z()).BeginInit();
		((ISupportInitialize)Hs2m()).BeginInit();
		((ISupportInitialize)Zz12()).BeginInit();
		((ISupportInitialize)o6B1()).BeginInit();
		((ISupportInitialize)o8LB()).BeginInit();
		((ISupportInitialize)Zb25()).BeginInit();
		((ISupportInitialize)o9PD()).BeginInit();
		((ISupportInitialize)p5SW()).BeginInit();
		((ISupportInitialize)w7EZ()).BeginInit();
		((ISupportInitialize)g7K5()).BeginInit();
		((ISupportInitialize)w6S4()).BeginInit();
		((ISupportInitialize)r3KX()).BeginInit();
		((ISupportInitialize)Ld39()).BeginInit();
		((ISupportInitialize)y6X2()).BeginInit();
		((ISupportInitialize)Sz01()).BeginInit();
		((ISupportInitialize)d2RG()).BeginInit();
		((ISupportInitialize)Pk09()).BeginInit();
		((ISupportInitialize)Qs19()).BeginInit();
		((ISupportInitialize)g9HY()).BeginInit();
		((ISupportInitialize)p3RB()).BeginInit();
		((ISupportInitialize)Fd5p()).BeginInit();
		((ISupportInitialize)Xd57()).BeginInit();
		((ISupportInitialize)y3J1()).BeginInit();
		((ISupportInitialize)Fy1a()).BeginInit();
		((ISupportInitialize)Ai06()).BeginInit();
		((ISupportInitialize)Mg4d()).BeginInit();
		((ISupportInitialize)Jb25()).BeginInit();
		((ISupportInitialize)Zf64()).BeginInit();
		((ISupportInitialize)w2L0()).BeginInit();
		((ISupportInitialize)Wf1w()).BeginInit();
		((ISupportInitialize)Rd10()).BeginInit();
		((ISupportInitialize)i0NQ()).BeginInit();
		((ISupportInitialize)j1S0()).BeginInit();
		((ISupportInitialize)Wf8p()).BeginInit();
		((ISupportInitialize)p6GP()).BeginInit();
		((ISupportInitialize)Za9j()).BeginInit();
		((ISupportInitialize)o3G0()).BeginInit();
		((ISupportInitialize)p6X3()).BeginInit();
		((ISupportInitialize)Kc4r()).BeginInit();
		((ISupportInitialize)d4S0()).BeginInit();
		((ISupportInitialize)Bt47()).BeginInit();
		((ISupportInitialize)Ja90()).BeginInit();
		((ISupportInitialize)Rb47()).BeginInit();
		((ISupportInitialize)Kt9z()).BeginInit();
		((ISupportInitialize)r0J3()).BeginInit();
		((ISupportInitialize)Jt9s()).BeginInit();
		((ISupportInitialize)Hi1s()).BeginInit();
		((ISupportInitialize)Qo48()).BeginInit();
		((ISupportInitialize)c4N1()).BeginInit();
		((ISupportInitialize)St98()).BeginInit();
		((ISupportInitialize)r7P1()).BeginInit();
		((ISupportInitialize)j4DB()).BeginInit();
		((ISupportInitialize)Kp56()).BeginInit();
		((ISupportInitialize)Cx43()).BeginInit();
		((ISupportInitialize)q7R0()).BeginInit();
		((ISupportInitialize)x2Y3()).BeginInit();
		((ISupportInitialize)Fm3r()).BeginInit();
		((ISupportInitialize)t4Q9()).BeginInit();
		((ISupportInitialize)Fx64()).BeginInit();
		((ISupportInitialize)t5GT()).BeginInit();
		((ISupportInitialize)y2RM()).BeginInit();
		((ISupportInitialize)i1CL()).BeginInit();
		((ISupportInitialize)a6X2()).BeginInit();
		((ISupportInitialize)j6AP()).BeginInit();
		((ISupportInitialize)Sz12()).BeginInit();
		((ISupportInitialize)p2LK()).BeginInit();
		((ISupportInitialize)Ne8c()).BeginInit();
		((ISupportInitialize)Wd38()).BeginInit();
		((ISupportInitialize)j9Y6()).BeginInit();
		((ISupportInitialize)w9X0()).BeginInit();
		((ISupportInitialize)Be8z()).BeginInit();
		((ISupportInitialize)r1RQ()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)i5C()).set_BackColor(Color.Transparent);
		((Control)i5C()).set_Location(new Point(-1, 0));
		((Control)i5C()).set_Name("NameBox");
		((Control)i5C()).set_Size(new Size(914, 45));
		i5C().set_SizeMode((PictureBoxSizeMode)1);
		i5C().set_TabIndex(0);
		i5C().set_TabStop(false);
		((Control)s2P()).set_Location(new Point(436, 43));
		((Control)s2P()).set_Name("Background");
		((Control)s2P()).set_Size(new Size(474, 396));
		s2P().set_SizeMode((PictureBoxSizeMode)1);
		s2P().set_TabIndex(1);
		s2P().set_TabStop(false);
		Mp6().set_AutoSize(true);
		((Control)Mp6()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Mp6()).set_ForeColor(SystemColors.ControlLight);
		((Control)Mp6()).set_Location(new Point(29, 9));
		((Control)Mp6()).set_Name("Label6");
		((Control)Mp6()).set_Size(new Size(106, 24));
		((Control)Mp6()).set_TabIndex(20);
		Mp6().set_Text("CINEMA 1");
		((Control)r4J()).get_Controls().Add((Control)(object)Jc3());
		((Control)r4J()).get_Controls().Add((Control)(object)e0Q());
		((Control)r4J()).get_Controls().Add((Control)(object)Bj9());
		((Control)r4J()).get_Controls().Add((Control)(object)w3N());
		((Control)r4J()).get_Controls().Add((Control)(object)e0F());
		((Control)r4J()).get_Controls().Add((Control)(object)o2Z());
		((Control)r4J()).get_Controls().Add((Control)(object)Ze8());
		((Control)r4J()).get_Controls().Add((Control)(object)Wb9());
		((Control)r4J()).get_Controls().Add((Control)(object)Bp8());
		((Control)r4J()).set_ForeColor(SystemColors.ControlLight);
		((Control)r4J()).set_Location(new Point(455, 51));
		((Control)r4J()).set_Name("GroupBox1");
		((Control)r4J()).set_Size(new Size(240, 100));
		((Control)r4J()).set_TabIndex(21);
		r4J().set_TabStop(false);
		r4J().set_Text("Statistics");
		((Control)Jc3()).set_Location(new Point(151, 73));
		((Control)Jc3()).set_Name("txtProvisional");
		((Control)Jc3()).set_Size(new Size(83, 20));
		((Control)Jc3()).set_TabIndex(29);
		((Control)e0Q()).set_Location(new Point(151, 42));
		((Control)e0Q()).set_Name("txtBooked");
		((Control)e0Q()).set_Size(new Size(83, 20));
		((Control)e0Q()).set_TabIndex(28);
		((Control)Bj9()).set_Location(new Point(151, 16));
		((Control)Bj9()).set_Name("txtAvailable");
		((Control)Bj9()).set_Size(new Size(83, 20));
		((Control)Bj9()).set_TabIndex(25);
		((Control)w3N()).set_BackColor(Color.Transparent);
		((Control)w3N()).set_Location(new Point(5, 47));
		((Control)w3N()).set_Name("Booked");
		((Control)w3N()).set_Size(new Size(23, 18));
		w3N().set_SizeMode((PictureBoxSizeMode)4);
		w3N().set_TabIndex(27);
		w3N().set_TabStop(false);
		((Control)e0F()).set_BackColor(Color.Transparent);
		((Control)e0F()).set_Location(new Point(6, 74));
		((Control)e0F()).set_Name("Provisional");
		((Control)e0F()).set_Size(new Size(23, 17));
		e0F().set_SizeMode((PictureBoxSizeMode)4);
		e0F().set_TabIndex(26);
		e0F().set_TabStop(false);
		((Control)o2Z()).set_BackColor(Color.Transparent);
		((Control)o2Z()).set_Location(new Point(5, 23));
		((Control)o2Z()).set_Name("Available");
		((Control)o2Z()).set_Size(new Size(23, 17));
		o2Z().set_SizeMode((PictureBoxSizeMode)4);
		o2Z().set_TabIndex(25);
		o2Z().set_TabStop(false);
		Ze8().set_AutoSize(true);
		((Control)Ze8()).set_BackColor(Color.Transparent);
		((Control)Ze8()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ze8()).set_Location(new Point(30, 49));
		((Control)Ze8()).set_Name("Label3");
		((Control)Ze8()).set_Size(new Size(74, 13));
		((Control)Ze8()).set_TabIndex(12);
		Ze8().set_Text("Booked Seats");
		Wb9().set_AutoSize(true);
		((Control)Wb9()).set_BackColor(Color.Transparent);
		((Control)Wb9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Wb9()).set_Location(new Point(30, 76));
		((Control)Wb9()).set_Name("Label1");
		((Control)Wb9()).set_Size(new Size(115, 13));
		((Control)Wb9()).set_TabIndex(11);
		Wb9().set_Text("Seat[s] on Reservation");
		Bp8().set_AutoSize(true);
		((Control)Bp8()).set_BackColor(Color.Transparent);
		((Control)Bp8()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Bp8()).set_Location(new Point(30, 24));
		((Control)Bp8()).set_Name("Label2");
		((Control)Bp8()).set_Size(new Size(80, 13));
		((Control)Bp8()).set_TabIndex(10);
		Bp8().set_Text("Available Seats");
		((Control)Mk2()).get_Controls().Add((Control)(object)Nk89());
		((Control)Mk2()).get_Controls().Add((Control)(object)Jc8s());
		((Control)Mk2()).get_Controls().Add((Control)(object)Hg78());
		((Control)Mk2()).get_Controls().Add((Control)(object)k0W());
		((Control)Mk2()).get_Controls().Add((Control)(object)Pn7());
		((Control)Mk2()).get_Controls().Add((Control)(object)y7K());
		((Control)Mk2()).get_Controls().Add((Control)(object)s6W());
		((Control)Mk2()).set_ForeColor(SystemColors.ControlLight);
		((Control)Mk2()).set_Location(new Point(701, 51));
		((Control)Mk2()).set_Name("GroupBox2");
		((Control)Mk2()).set_Size(new Size(200, 129));
		((Control)Mk2()).set_TabIndex(22);
		Mk2().set_TabStop(false);
		Mk2().set_Text("Customer");
		((ButtonBase)Nk89()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Nk89()).set_FlatStyle((FlatStyle)0);
		((Control)Nk89()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Nk89()).set_Location(new Point(70, 90));
		((Control)Nk89()).set_Name("btnNew");
		((Control)Nk89()).set_Size(new Size(54, 23));
		((Control)Nk89()).set_TabIndex(39);
		((ButtonBase)Nk89()).set_Text("New");
		((ButtonBase)Nk89()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Jc8s()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Jc8s()).set_FlatStyle((FlatStyle)0);
		((Control)Jc8s()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Jc8s()).set_Location(new Point(130, 90));
		((Control)Jc8s()).set_Name("btnReset");
		((Control)Jc8s()).set_Size(new Size(54, 23));
		((Control)Jc8s()).set_TabIndex(38);
		((ButtonBase)Jc8s()).set_Text("Reset");
		((ButtonBase)Jc8s()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Hg78()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Hg78()).set_FlatStyle((FlatStyle)0);
		((Control)Hg78()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Hg78()).set_Location(new Point(10, 90));
		((Control)Hg78()).set_Name("btnExisting");
		((Control)Hg78()).set_Size(new Size(54, 23));
		((Control)Hg78()).set_TabIndex(37);
		((ButtonBase)Hg78()).set_Text("Existing");
		((ButtonBase)Hg78()).set_UseVisualStyleBackColor(true);
		((Control)k0W()).set_Location(new Point(94, 57));
		((Control)k0W()).set_Name("txtFirstName");
		((Control)k0W()).set_Size(new Size(103, 20));
		((Control)k0W()).set_TabIndex(30);
		((Control)Pn7()).set_Location(new Point(94, 31));
		((Control)Pn7()).set_Name("txtID");
		((Control)Pn7()).set_Size(new Size(103, 20));
		((Control)Pn7()).set_TabIndex(29);
		y7K().set_AutoSize(true);
		((Control)y7K()).set_BackColor(Color.Transparent);
		((Control)y7K()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)y7K()).set_Location(new Point(6, 58));
		((Control)y7K()).set_Name("Label60");
		((Control)y7K()).set_Size(new Size(57, 13));
		((Control)y7K()).set_TabIndex(12);
		y7K().set_Text("First Name");
		s6W().set_AutoSize(true);
		((Control)s6W()).set_BackColor(Color.Transparent);
		((Control)s6W()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)s6W()).set_Location(new Point(6, 34));
		((Control)s6W()).set_Name("Label59");
		((Control)s6W()).set_Size(new Size(65, 13));
		((Control)s6W()).set_TabIndex(11);
		s6W().set_Text("Customer ID");
		((Control)g9F()).get_Controls().Add((Control)(object)e9RT());
		((Control)g9F()).get_Controls().Add((Control)(object)Lr3());
		((Control)g9F()).set_ForeColor(SystemColors.ControlLight);
		((Control)g9F()).set_Location(new Point(472, 170));
		((Control)g9F()).set_Name("GroupBox3");
		((Control)g9F()).set_Size(new Size(200, 251));
		((Control)g9F()).set_TabIndex(23);
		g9F().set_TabStop(false);
		g9F().set_Text("Movie On Display");
		((ButtonBase)e9RT()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)e9RT()).set_FlatStyle((FlatStyle)0);
		((Control)e9RT()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)e9RT()).set_Location(new Point(45, 217));
		((Control)e9RT()).set_Name("btnViewReservations");
		((Control)e9RT()).set_Size(new Size(117, 23));
		((Control)e9RT()).set_TabIndex(40);
		((ButtonBase)e9RT()).set_Text("View Reservations");
		((ButtonBase)e9RT()).set_UseVisualStyleBackColor(true);
		((Control)Lr3()).set_BackColor(Color.Transparent);
		((Control)Lr3()).set_Location(new Point(39, 21));
		((Control)Lr3()).set_Name("Cover");
		((Control)Lr3()).set_Size(new Size(129, 187));
		Lr3().set_SizeMode((PictureBoxSizeMode)4);
		Lr3().set_TabIndex(25);
		Lr3().set_TabStop(false);
		((Control)d5K()).get_Controls().Add((Control)(object)j7CZ());
		((Control)d5K()).get_Controls().Add((Control)(object)Rj14());
		((Control)d5K()).get_Controls().Add((Control)(object)j3D());
		((Control)d5K()).get_Controls().Add((Control)(object)Pa7());
		((Control)d5K()).get_Controls().Add((Control)(object)Lc1());
		((Control)d5K()).get_Controls().Add((Control)(object)At7());
		((Control)d5K()).get_Controls().Add((Control)(object)q1K());
		((Control)d5K()).get_Controls().Add((Control)(object)b9Q());
		((Control)d5K()).get_Controls().Add((Control)(object)y4Q());
		((Control)d5K()).get_Controls().Add((Control)(object)Mr6());
		((Control)d5K()).set_ForeColor(SystemColors.ControlLight);
		((Control)d5K()).set_Location(new Point(690, 190));
		((Control)d5K()).set_Name("GroupBox4");
		((Control)d5K()).set_Size(new Size(211, 231));
		((Control)d5K()).set_TabIndex(24);
		d5K().set_TabStop(false);
		d5K().set_Text("Billing INFO");
		((ButtonBase)j7CZ()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)j7CZ()).set_FlatStyle((FlatStyle)0);
		((Control)j7CZ()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)j7CZ()).set_Location(new Point(72, 184));
		((Control)j7CZ()).set_Name("btnSave");
		((Control)j7CZ()).set_Size(new Size(133, 23));
		((Control)j7CZ()).set_TabIndex(40);
		((ButtonBase)j7CZ()).set_Text("Save / Receipt Preview");
		((ButtonBase)j7CZ()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Rj14()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Rj14()).set_FlatStyle((FlatStyle)0);
		((Control)Rj14()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Rj14()).set_Location(new Point(103, 155));
		((Control)Rj14()).set_Name("btnCalculateChange");
		((Control)Rj14()).set_Size(new Size(101, 23));
		((Control)Rj14()).set_TabIndex(39);
		((ButtonBase)Rj14()).set_Text("Calculate Change");
		((ButtonBase)Rj14()).set_UseVisualStyleBackColor(true);
		((Control)j3D()).set_Location(new Point(95, 123));
		((Control)j3D()).set_Name("txtChange");
		((Control)j3D()).set_Size(new Size(110, 20));
		((Control)j3D()).set_TabIndex(34);
		((Control)Pa7()).set_Location(new Point(95, 91));
		((Control)Pa7()).set_Name("txtTotalPayment");
		((Control)Pa7()).set_Size(new Size(110, 20));
		((Control)Pa7()).set_TabIndex(33);
		((Control)Lc1()).set_Location(new Point(96, 58));
		((Control)Lc1()).set_Name("txtTotalCost");
		((Control)Lc1()).set_Size(new Size(109, 20));
		((Control)Lc1()).set_TabIndex(32);
		((Control)At7()).set_Location(new Point(122, 24));
		((Control)At7()).set_Name("txtSeats");
		((Control)At7()).set_Size(new Size(83, 20));
		((Control)At7()).set_TabIndex(31);
		q1K().set_AutoSize(true);
		((Control)q1K()).set_BackColor(Color.Transparent);
		((Control)q1K()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)q1K()).set_Location(new Point(8, 62));
		((Control)q1K()).set_Name("Label63");
		((Control)q1K()).set_Size(new Size(66, 13));
		((Control)q1K()).set_TabIndex(16);
		q1K().set_Text("Total Costs :");
		b9Q().set_AutoSize(true);
		((Control)b9Q()).set_BackColor(Color.Transparent);
		((Control)b9Q()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)b9Q()).set_Location(new Point(8, 27));
		((Control)b9Q()).set_Name("Label64");
		((Control)b9Q()).set_Size(new Size(106, 13));
		((Control)b9Q()).set_TabIndex(15);
		b9Q().set_Text("Seats to be booked :");
		y4Q().set_AutoSize(true);
		((Control)y4Q()).set_BackColor(Color.Transparent);
		((Control)y4Q()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)y4Q()).set_Location(new Point(8, 121));
		((Control)y4Q()).set_Name("Label61");
		((Control)y4Q()).set_Size(new Size(50, 13));
		((Control)y4Q()).set_TabIndex(14);
		y4Q().set_Text("Change :");
		Mr6().set_AutoSize(true);
		((Control)Mr6()).set_BackColor(Color.Transparent);
		((Control)Mr6()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mr6()).set_Location(new Point(8, 91));
		((Control)Mr6()).set_Name("Label62");
		((Control)Mr6()).set_Size(new Size(81, 13));
		((Control)Mr6()).set_TabIndex(13);
		Mr6().set_Text("Total Payment :");
		r8E().set_AutoSize(true);
		((Control)r8E()).set_Location(new Point(177, 51));
		((Control)r8E()).set_Name("Label4");
		((Control)r8E()).set_Size(new Size(69, 13));
		((Control)r8E()).set_TabIndex(25);
		r8E().set_Text("UPPER BOX");
		f8G().set_AutoSize(true);
		((Control)f8G()).set_Location(new Point(44, 78));
		((Control)f8G()).set_Name("Label5");
		((Control)f8G()).set_Size(new Size(13, 13));
		((Control)f8G()).set_TabIndex(26);
		f8G().set_Text("1");
		Wi5().set_AutoSize(true);
		((Control)Wi5()).set_Location(new Point(60, 78));
		((Control)Wi5()).set_Name("Label7");
		((Control)Wi5()).set_Size(new Size(13, 13));
		((Control)Wi5()).set_TabIndex(27);
		Wi5().set_Text("2");
		p9P().set_AutoSize(true);
		((Control)p9P()).set_Location(new Point(76, 78));
		((Control)p9P()).set_Name("Label8");
		((Control)p9P()).set_Size(new Size(13, 13));
		((Control)p9P()).set_TabIndex(28);
		p9P().set_Text("3");
		i0B().set_AutoSize(true);
		((Control)i0B()).set_Location(new Point(108, 78));
		((Control)i0B()).set_Name("Label9");
		((Control)i0B()).set_Size(new Size(13, 13));
		((Control)i0B()).set_TabIndex(29);
		i0B().set_Text("5");
		m2R().set_AutoSize(true);
		((Control)m2R()).set_Location(new Point(124, 78));
		((Control)m2R()).set_Name("Label10");
		((Control)m2R()).set_Size(new Size(13, 13));
		((Control)m2R()).set_TabIndex(30);
		m2R().set_Text("6");
		Dq9().set_AutoSize(true);
		((Control)Dq9()).set_Location(new Point(140, 78));
		((Control)Dq9()).set_Name("Label11");
		((Control)Dq9()).set_Size(new Size(13, 13));
		((Control)Dq9()).set_TabIndex(31);
		Dq9().set_Text("7");
		Ls3().set_AutoSize(true);
		((Control)Ls3()).set_Location(new Point(172, 78));
		((Control)Ls3()).set_Name("Label12");
		((Control)Ls3()).set_Size(new Size(13, 13));
		((Control)Ls3()).set_TabIndex(32);
		Ls3().set_Text("9");
		i0D().set_AutoSize(true);
		((Control)i0D()).set_Location(new Point(188, 78));
		((Control)i0D()).set_Name("Label13");
		((Control)i0D()).set_Size(new Size(19, 13));
		((Control)i0D()).set_TabIndex(33);
		i0D().set_Text("10");
		Xg0().set_AutoSize(true);
		((Control)Xg0()).set_Location(new Point(156, 78));
		((Control)Xg0()).set_Name("Label14");
		((Control)Xg0()).set_Size(new Size(13, 13));
		((Control)Xg0()).set_TabIndex(34);
		Xg0().set_Text("8");
		c3F().set_AutoSize(true);
		((Control)c3F()).set_Location(new Point(257, 78));
		((Control)c3F()).set_Name("Label15");
		((Control)c3F()).set_Size(new Size(19, 13));
		((Control)c3F()).set_TabIndex(35);
		c3F().set_Text("14");
		Sc9().set_AutoSize(true);
		((Control)Sc9()).set_Location(new Point(206, 78));
		((Control)Sc9()).set_Name("Label16");
		((Control)Sc9()).set_Size(new Size(19, 13));
		((Control)Sc9()).set_TabIndex(36);
		Sc9().set_Text("11");
		d3Z().set_AutoSize(true);
		((Control)d3Z()).set_Location(new Point(292, 78));
		((Control)d3Z()).set_Name("Label17");
		((Control)d3Z()).set_Size(new Size(19, 13));
		((Control)d3Z()).set_TabIndex(37);
		d3Z().set_Text("16");
		o4Y().set_AutoSize(true);
		((Control)o4Y()).set_Location(new Point(241, 78));
		((Control)o4Y()).set_Name("Label18");
		((Control)o4Y()).set_Size(new Size(19, 13));
		((Control)o4Y()).set_TabIndex(38);
		o4Y().set_Text("13");
		e0K().set_AutoSize(true);
		((Control)e0K()).set_Location(new Point(92, 78));
		((Control)e0K()).set_Name("Label19");
		((Control)e0K()).set_Size(new Size(13, 13));
		((Control)e0K()).set_TabIndex(39);
		e0K().set_Text("4");
		k0G().set_AutoSize(true);
		((Control)k0G()).set_Location(new Point(223, 78));
		((Control)k0G()).set_Name("Label20");
		((Control)k0G()).set_Size(new Size(19, 13));
		((Control)k0G()).set_TabIndex(40);
		k0G().set_Text("12");
		Wm4().set_AutoSize(true);
		((Control)Wm4()).set_Location(new Point(329, 78));
		((Control)Wm4()).set_Name("Label22");
		((Control)Wm4()).set_Size(new Size(19, 13));
		((Control)Wm4()).set_TabIndex(42);
		Wm4().set_Text("18");
		q4Q().set_AutoSize(true);
		((Control)q4Q()).set_Location(new Point(310, 78));
		((Control)q4Q()).set_Name("Label23");
		((Control)q4Q()).set_Size(new Size(19, 13));
		((Control)q4Q()).set_TabIndex(43);
		q4Q().set_Text("17");
		Mq5().set_AutoSize(true);
		((Control)Mq5()).set_Location(new Point(275, 78));
		((Control)Mq5()).set_Name("Label24");
		((Control)Mq5()).set_Size(new Size(19, 13));
		((Control)Mq5()).set_TabIndex(44);
		Mq5().set_Text("15");
		c3C().set_AutoSize(true);
		((Control)c3C()).set_Location(new Point(29, 302));
		((Control)c3C()).set_Name("Label26");
		((Control)c3C()).set_Size(new Size(14, 13));
		((Control)c3C()).set_TabIndex(50);
		c3C().set_Text("E");
		e8S().set_AutoSize(true);
		((Control)e8S()).set_Location(new Point(29, 190));
		((Control)e8S()).set_Name("Label27");
		((Control)e8S()).set_Size(new Size(15, 13));
		((Control)e8S()).set_TabIndex(49);
		e8S().set_Text("D");
		k3K().set_AutoSize(true);
		((Control)k3K()).set_Location(new Point(29, 168));
		((Control)k3K()).set_Name("Label28");
		((Control)k3K()).set_Size(new Size(14, 13));
		((Control)k3K()).set_TabIndex(48);
		k3K().set_Text("C");
		d1L().set_AutoSize(true);
		((Control)d1L()).set_Location(new Point(29, 146));
		((Control)d1L()).set_Name("Label29");
		((Control)d1L()).set_Size(new Size(14, 13));
		((Control)d1L()).set_TabIndex(47);
		d1L().set_Text("B");
		Gi2().set_AutoSize(true);
		((Control)Gi2()).set_Location(new Point(29, 124));
		((Control)Gi2()).set_Name("Label30");
		((Control)Gi2()).set_Size(new Size(14, 13));
		((Control)Gi2()).set_TabIndex(46);
		Gi2().set_Text("A");
		Ed5().set_AutoSize(true);
		((Control)Ed5()).set_Location(new Point(177, 225));
		((Control)Ed5()).set_Name("Label31");
		((Control)Ed5()).set_Size(new Size(72, 13));
		((Control)Ed5()).set_TabIndex(159);
		Ed5().set_Text("LOWER BOX");
		Px0().set_AutoSize(true);
		((Control)Px0()).set_Location(new Point(30, 365));
		((Control)Px0()).set_Name("Label54");
		((Control)Px0()).set_Size(new Size(15, 13));
		((Control)Px0()).set_TabIndex(182);
		Px0().set_Text("H");
		k9H().set_AutoSize(true);
		((Control)k9H()).set_Location(new Point(30, 343));
		((Control)k9H()).set_Name("Label55");
		((Control)k9H()).set_Size(new Size(15, 13));
		((Control)k9H()).set_TabIndex(181);
		k9H().set_Text("G");
		i7R().set_AutoSize(true);
		((Control)i7R()).set_Location(new Point(30, 321));
		((Control)i7R()).set_Name("Label56");
		((Control)i7R()).set_Size(new Size(13, 13));
		((Control)i7R()).set_TabIndex(180);
		i7R().set_Text("F");
		m0N().set_AutoSize(true);
		((Control)m0N()).set_Location(new Point(348, 78));
		((Control)m0N()).set_Name("Label21");
		((Control)m0N()).set_Size(new Size(19, 13));
		((Control)m0N()).set_TabIndex(41);
		m0N().set_Text("19");
		q4Y().set_AutoSize(true);
		((Control)q4Y()).set_Location(new Point(368, 78));
		((Control)q4Y()).set_Name("Label25");
		((Control)q4Y()).set_Size(new Size(19, 13));
		((Control)q4Y()).set_TabIndex(45);
		q4Y().set_Text("20");
		((Control)a1Q()).set_Location(new Point(47, 124));
		((Control)a1Q()).set_Name("PictureBox1");
		((Control)a1Q()).set_Size(new Size(10, 12));
		a1Q().set_SizeMode((PictureBoxSizeMode)4);
		a1Q().set_TabIndex(349);
		a1Q().set_TabStop(false);
		((Control)a7P()).set_Location(new Point(61, 124));
		((Control)a7P()).set_Name("PictureBox2");
		((Control)a7P()).set_Size(new Size(10, 12));
		a7P().set_SizeMode((PictureBoxSizeMode)4);
		a7P().set_TabIndex(350);
		a7P().set_TabStop(false);
		((Control)Xb7()).set_Location(new Point(77, 124));
		((Control)Xb7()).set_Name("PictureBox3");
		((Control)Xb7()).set_Size(new Size(10, 12));
		Xb7().set_SizeMode((PictureBoxSizeMode)4);
		Xb7().set_TabIndex(351);
		Xb7().set_TabStop(false);
		((Control)e5H()).set_Location(new Point(93, 124));
		((Control)e5H()).set_Name("PictureBox4");
		((Control)e5H()).set_Size(new Size(10, 12));
		e5H().set_SizeMode((PictureBoxSizeMode)4);
		e5H().set_TabIndex(352);
		e5H().set_TabStop(false);
		((Control)Fj9()).set_Location(new Point(109, 124));
		((Control)Fj9()).set_Name("PictureBox5");
		((Control)Fj9()).set_Size(new Size(10, 12));
		Fj9().set_SizeMode((PictureBoxSizeMode)4);
		Fj9().set_TabIndex(353);
		Fj9().set_TabStop(false);
		((Control)o1M()).set_Location(new Point(125, 124));
		((Control)o1M()).set_Name("PictureBox6");
		((Control)o1M()).set_Size(new Size(10, 12));
		o1M().set_SizeMode((PictureBoxSizeMode)4);
		o1M().set_TabIndex(354);
		o1M().set_TabStop(false);
		((Control)n7K()).set_Location(new Point(141, 124));
		((Control)n7K()).set_Name("PictureBox7");
		((Control)n7K()).set_Size(new Size(10, 12));
		n7K().set_SizeMode((PictureBoxSizeMode)4);
		n7K().set_TabIndex(355);
		n7K().set_TabStop(false);
		((Control)Qz7()).set_Location(new Point(157, 124));
		((Control)Qz7()).set_Name("PictureBox8");
		((Control)Qz7()).set_Size(new Size(10, 12));
		Qz7().set_SizeMode((PictureBoxSizeMode)4);
		Qz7().set_TabIndex(356);
		Qz7().set_TabStop(false);
		((Control)Go3()).set_Location(new Point(173, 124));
		((Control)Go3()).set_Name("PictureBox9");
		((Control)Go3()).set_Size(new Size(10, 12));
		Go3().set_SizeMode((PictureBoxSizeMode)4);
		Go3().set_TabIndex(357);
		Go3().set_TabStop(false);
		((Control)n6S()).set_Location(new Point(189, 124));
		((Control)n6S()).set_Name("PictureBox10");
		((Control)n6S()).set_Size(new Size(10, 12));
		n6S().set_SizeMode((PictureBoxSizeMode)4);
		n6S().set_TabIndex(358);
		n6S().set_TabStop(false);
		((Control)x9T()).set_Location(new Point(207, 124));
		((Control)x9T()).set_Name("PictureBox11");
		((Control)x9T()).set_Size(new Size(10, 12));
		x9T().set_SizeMode((PictureBoxSizeMode)4);
		x9T().set_TabIndex(359);
		x9T().set_TabStop(false);
		((Control)Lf2()).set_Location(new Point(226, 124));
		((Control)Lf2()).set_Name("PictureBox12");
		((Control)Lf2()).set_Size(new Size(10, 12));
		Lf2().set_SizeMode((PictureBoxSizeMode)4);
		Lf2().set_TabIndex(360);
		Lf2().set_TabStop(false);
		((Control)x7T()).set_Location(new Point(244, 124));
		((Control)x7T()).set_Name("PictureBox13");
		((Control)x7T()).set_Size(new Size(10, 12));
		x7T().set_SizeMode((PictureBoxSizeMode)4);
		x7T().set_TabIndex(361);
		x7T().set_TabStop(false);
		((Control)t9W()).set_Location(new Point(260, 124));
		((Control)t9W()).set_Name("PictureBox14");
		((Control)t9W()).set_Size(new Size(10, 12));
		t9W().set_SizeMode((PictureBoxSizeMode)4);
		t9W().set_TabIndex(362);
		t9W().set_TabStop(false);
		((Control)Sq0()).set_Location(new Point(278, 124));
		((Control)Sq0()).set_Name("PictureBox15");
		((Control)Sq0()).set_Size(new Size(10, 12));
		Sq0().set_SizeMode((PictureBoxSizeMode)4);
		Sq0().set_TabIndex(363);
		Sq0().set_TabStop(false);
		((Control)Xo7()).set_Location(new Point(295, 124));
		((Control)Xo7()).set_Name("PictureBox16");
		((Control)Xo7()).set_Size(new Size(10, 12));
		Xo7().set_SizeMode((PictureBoxSizeMode)4);
		Xo7().set_TabIndex(364);
		Xo7().set_TabStop(false);
		((Control)r3W4()).set_Location(new Point(313, 124));
		((Control)r3W4()).set_Name("PictureBox17");
		((Control)r3W4()).set_Size(new Size(10, 12));
		r3W4().set_SizeMode((PictureBoxSizeMode)4);
		r3W4().set_TabIndex(365);
		r3W4().set_TabStop(false);
		((Control)y8S9()).set_Location(new Point(332, 124));
		((Control)y8S9()).set_Name("PictureBox18");
		((Control)y8S9()).set_Size(new Size(10, 12));
		y8S9().set_SizeMode((PictureBoxSizeMode)4);
		y8S9().set_TabIndex(366);
		y8S9().set_TabStop(false);
		((Control)Kb3i()).set_Location(new Point(351, 124));
		((Control)Kb3i()).set_Name("PictureBox19");
		((Control)Kb3i()).set_Size(new Size(10, 12));
		Kb3i().set_SizeMode((PictureBoxSizeMode)4);
		Kb3i().set_TabIndex(367);
		Kb3i().set_TabStop(false);
		((Control)d3Y4()).set_Location(new Point(371, 124));
		((Control)d3Y4()).set_Name("PictureBox20");
		((Control)d3Y4()).set_Size(new Size(10, 12));
		d3Y4().set_SizeMode((PictureBoxSizeMode)4);
		d3Y4().set_TabIndex(368);
		d3Y4().set_TabStop(false);
		((Control)Ya6x()).set_Location(new Point(371, 146));
		((Control)Ya6x()).set_Name("PictureBox21");
		((Control)Ya6x()).set_Size(new Size(10, 12));
		Ya6x().set_SizeMode((PictureBoxSizeMode)4);
		Ya6x().set_TabIndex(388);
		Ya6x().set_TabStop(false);
		((Control)g1ST()).set_Location(new Point(351, 146));
		((Control)g1ST()).set_Name("PictureBox22");
		((Control)g1ST()).set_Size(new Size(10, 12));
		g1ST().set_SizeMode((PictureBoxSizeMode)4);
		g1ST().set_TabIndex(387);
		g1ST().set_TabStop(false);
		((Control)Qa80()).set_Location(new Point(332, 146));
		((Control)Qa80()).set_Name("PictureBox23");
		((Control)Qa80()).set_Size(new Size(10, 12));
		Qa80().set_SizeMode((PictureBoxSizeMode)4);
		Qa80().set_TabIndex(386);
		Qa80().set_TabStop(false);
		((Control)Nd4m()).set_Location(new Point(313, 146));
		((Control)Nd4m()).set_Name("PictureBox24");
		((Control)Nd4m()).set_Size(new Size(10, 12));
		Nd4m().set_SizeMode((PictureBoxSizeMode)4);
		Nd4m().set_TabIndex(385);
		Nd4m().set_TabStop(false);
		((Control)Sq3o()).set_Location(new Point(295, 146));
		((Control)Sq3o()).set_Name("PictureBox25");
		((Control)Sq3o()).set_Size(new Size(10, 12));
		Sq3o().set_SizeMode((PictureBoxSizeMode)4);
		Sq3o().set_TabIndex(384);
		Sq3o().set_TabStop(false);
		((Control)d2M6()).set_Location(new Point(278, 146));
		((Control)d2M6()).set_Name("PictureBox26");
		((Control)d2M6()).set_Size(new Size(10, 12));
		d2M6().set_SizeMode((PictureBoxSizeMode)4);
		d2M6().set_TabIndex(383);
		d2M6().set_TabStop(false);
		((Control)Ni8p()).set_Location(new Point(260, 146));
		((Control)Ni8p()).set_Name("PictureBox27");
		((Control)Ni8p()).set_Size(new Size(10, 12));
		Ni8p().set_SizeMode((PictureBoxSizeMode)4);
		Ni8p().set_TabIndex(382);
		Ni8p().set_TabStop(false);
		((Control)t2H8()).set_Location(new Point(244, 146));
		((Control)t2H8()).set_Name("PictureBox28");
		((Control)t2H8()).set_Size(new Size(10, 12));
		t2H8().set_SizeMode((PictureBoxSizeMode)4);
		t2H8().set_TabIndex(381);
		t2H8().set_TabStop(false);
		((Control)f3JW()).set_Location(new Point(226, 146));
		((Control)f3JW()).set_Name("PictureBox29");
		((Control)f3JW()).set_Size(new Size(10, 12));
		f3JW().set_SizeMode((PictureBoxSizeMode)4);
		f3JW().set_TabIndex(380);
		f3JW().set_TabStop(false);
		((Control)Bj9a()).set_Location(new Point(207, 146));
		((Control)Bj9a()).set_Name("PictureBox30");
		((Control)Bj9a()).set_Size(new Size(10, 12));
		Bj9a().set_SizeMode((PictureBoxSizeMode)4);
		Bj9a().set_TabIndex(379);
		Bj9a().set_TabStop(false);
		((Control)x1SC()).set_Location(new Point(189, 146));
		((Control)x1SC()).set_Name("PictureBox31");
		((Control)x1SC()).set_Size(new Size(10, 12));
		x1SC().set_SizeMode((PictureBoxSizeMode)4);
		x1SC().set_TabIndex(378);
		x1SC().set_TabStop(false);
		((Control)m1DN()).set_Location(new Point(173, 146));
		((Control)m1DN()).set_Name("PictureBox32");
		((Control)m1DN()).set_Size(new Size(10, 12));
		m1DN().set_SizeMode((PictureBoxSizeMode)4);
		m1DN().set_TabIndex(377);
		m1DN().set_TabStop(false);
		((Control)Pp96()).set_Location(new Point(157, 146));
		((Control)Pp96()).set_Name("PictureBox33");
		((Control)Pp96()).set_Size(new Size(10, 12));
		Pp96().set_SizeMode((PictureBoxSizeMode)4);
		Pp96().set_TabIndex(376);
		Pp96().set_TabStop(false);
		((Control)j9E5()).set_Location(new Point(141, 146));
		((Control)j9E5()).set_Name("PictureBox34");
		((Control)j9E5()).set_Size(new Size(10, 12));
		j9E5().set_SizeMode((PictureBoxSizeMode)4);
		j9E5().set_TabIndex(375);
		j9E5().set_TabStop(false);
		((Control)Ls45()).set_Location(new Point(125, 146));
		((Control)Ls45()).set_Name("PictureBox35");
		((Control)Ls45()).set_Size(new Size(10, 12));
		Ls45().set_SizeMode((PictureBoxSizeMode)4);
		Ls45().set_TabIndex(374);
		Ls45().set_TabStop(false);
		((Control)a2N5()).set_Location(new Point(109, 146));
		((Control)a2N5()).set_Name("PictureBox36");
		((Control)a2N5()).set_Size(new Size(10, 12));
		a2N5().set_SizeMode((PictureBoxSizeMode)4);
		a2N5().set_TabIndex(373);
		a2N5().set_TabStop(false);
		((Control)Eq4y()).set_Location(new Point(93, 146));
		((Control)Eq4y()).set_Name("PictureBox37");
		((Control)Eq4y()).set_Size(new Size(10, 12));
		Eq4y().set_SizeMode((PictureBoxSizeMode)4);
		Eq4y().set_TabIndex(372);
		Eq4y().set_TabStop(false);
		((Control)Cs27()).set_Location(new Point(77, 146));
		((Control)Cs27()).set_Name("PictureBox38");
		((Control)Cs27()).set_Size(new Size(10, 12));
		Cs27().set_SizeMode((PictureBoxSizeMode)4);
		Cs27().set_TabIndex(371);
		Cs27().set_TabStop(false);
		((Control)Ao91()).set_Location(new Point(61, 146));
		((Control)Ao91()).set_Name("PictureBox39");
		((Control)Ao91()).set_Size(new Size(10, 12));
		Ao91().set_SizeMode((PictureBoxSizeMode)4);
		Ao91().set_TabIndex(370);
		Ao91().set_TabStop(false);
		((Control)Hs05()).set_Location(new Point(47, 146));
		((Control)Hs05()).set_Name("PictureBox40");
		((Control)Hs05()).set_Size(new Size(10, 12));
		Hs05().set_SizeMode((PictureBoxSizeMode)4);
		Hs05().set_TabIndex(369);
		Hs05().set_TabStop(false);
		x0L1().set_AutoSize(true);
		((Control)x0L1()).set_Location(new Point(368, 259));
		((Control)x0L1()).set_Name("Label32");
		((Control)x0L1()).set_Size(new Size(19, 13));
		((Control)x0L1()).set_TabIndex(408);
		x0L1().set_Text("20");
		Jx4w().set_AutoSize(true);
		((Control)Jx4w()).set_Location(new Point(275, 259));
		((Control)Jx4w()).set_Name("Label33");
		((Control)Jx4w()).set_Size(new Size(19, 13));
		((Control)Jx4w()).set_TabIndex(407);
		Jx4w().set_Text("15");
		Qi73().set_AutoSize(true);
		((Control)Qi73()).set_Location(new Point(310, 259));
		((Control)Qi73()).set_Name("Label34");
		((Control)Qi73()).set_Size(new Size(19, 13));
		((Control)Qi73()).set_TabIndex(406);
		Qi73().set_Text("17");
		Rp8k().set_AutoSize(true);
		((Control)Rp8k()).set_Location(new Point(329, 259));
		((Control)Rp8k()).set_Name("Label35");
		((Control)Rp8k()).set_Size(new Size(19, 13));
		((Control)Rp8k()).set_TabIndex(405);
		Rp8k().set_Text("18");
		e8YG().set_AutoSize(true);
		((Control)e8YG()).set_Location(new Point(348, 259));
		((Control)e8YG()).set_Name("Label36");
		((Control)e8YG()).set_Size(new Size(19, 13));
		((Control)e8YG()).set_TabIndex(404);
		e8YG().set_Text("19");
		Jz5d().set_AutoSize(true);
		((Control)Jz5d()).set_Location(new Point(223, 259));
		((Control)Jz5d()).set_Name("Label37");
		((Control)Jz5d()).set_Size(new Size(19, 13));
		((Control)Jz5d()).set_TabIndex(403);
		Jz5d().set_Text("12");
		Lp20().set_AutoSize(true);
		((Control)Lp20()).set_Location(new Point(92, 259));
		((Control)Lp20()).set_Name("Label38");
		((Control)Lp20()).set_Size(new Size(13, 13));
		((Control)Lp20()).set_TabIndex(402);
		Lp20().set_Text("4");
		Qm60().set_AutoSize(true);
		((Control)Qm60()).set_Location(new Point(241, 259));
		((Control)Qm60()).set_Name("Label39");
		((Control)Qm60()).set_Size(new Size(19, 13));
		((Control)Qm60()).set_TabIndex(401);
		Qm60().set_Text("13");
		q5M9().set_AutoSize(true);
		((Control)q5M9()).set_Location(new Point(292, 259));
		((Control)q5M9()).set_Name("Label40");
		((Control)q5M9()).set_Size(new Size(19, 13));
		((Control)q5M9()).set_TabIndex(400);
		q5M9().set_Text("16");
		Rp1o().set_AutoSize(true);
		((Control)Rp1o()).set_Location(new Point(206, 259));
		((Control)Rp1o()).set_Name("Label41");
		((Control)Rp1o()).set_Size(new Size(19, 13));
		((Control)Rp1o()).set_TabIndex(399);
		Rp1o().set_Text("11");
		c2GS().set_AutoSize(true);
		((Control)c2GS()).set_Location(new Point(257, 259));
		((Control)c2GS()).set_Name("Label42");
		((Control)c2GS()).set_Size(new Size(19, 13));
		((Control)c2GS()).set_TabIndex(398);
		c2GS().set_Text("14");
		p1T2().set_AutoSize(true);
		((Control)p1T2()).set_Location(new Point(156, 259));
		((Control)p1T2()).set_Name("Label43");
		((Control)p1T2()).set_Size(new Size(13, 13));
		((Control)p1T2()).set_TabIndex(397);
		p1T2().set_Text("8");
		s3ET().set_AutoSize(true);
		((Control)s3ET()).set_Location(new Point(188, 259));
		((Control)s3ET()).set_Name("Label44");
		((Control)s3ET()).set_Size(new Size(19, 13));
		((Control)s3ET()).set_TabIndex(396);
		s3ET().set_Text("10");
		m1G8().set_AutoSize(true);
		((Control)m1G8()).set_Location(new Point(172, 259));
		((Control)m1G8()).set_Name("Label45");
		((Control)m1G8()).set_Size(new Size(13, 13));
		((Control)m1G8()).set_TabIndex(395);
		m1G8().set_Text("9");
		k2C1().set_AutoSize(true);
		((Control)k2C1()).set_Location(new Point(140, 259));
		((Control)k2C1()).set_Name("Label46");
		((Control)k2C1()).set_Size(new Size(13, 13));
		((Control)k2C1()).set_TabIndex(394);
		k2C1().set_Text("7");
		Mf8j().set_AutoSize(true);
		((Control)Mf8j()).set_Location(new Point(124, 259));
		((Control)Mf8j()).set_Name("Label47");
		((Control)Mf8j()).set_Size(new Size(13, 13));
		((Control)Mf8j()).set_TabIndex(393);
		Mf8j().set_Text("6");
		t6PG().set_AutoSize(true);
		((Control)t6PG()).set_Location(new Point(108, 259));
		((Control)t6PG()).set_Name("Label48");
		((Control)t6PG()).set_Size(new Size(13, 13));
		((Control)t6PG()).set_TabIndex(392);
		t6PG().set_Text("5");
		b5ZB().set_AutoSize(true);
		((Control)b5ZB()).set_Location(new Point(76, 259));
		((Control)b5ZB()).set_Name("Label49");
		((Control)b5ZB()).set_Size(new Size(13, 13));
		((Control)b5ZB()).set_TabIndex(391);
		b5ZB().set_Text("3");
		s7ES().set_AutoSize(true);
		((Control)s7ES()).set_Location(new Point(60, 259));
		((Control)s7ES()).set_Name("Label50");
		((Control)s7ES()).set_Size(new Size(13, 13));
		((Control)s7ES()).set_TabIndex(390);
		s7ES().set_Text("2");
		Ax1t().set_AutoSize(true);
		((Control)Ax1t()).set_Location(new Point(44, 259));
		((Control)Ax1t()).set_Name("Label51");
		((Control)Ax1t()).set_Size(new Size(13, 13));
		((Control)Ax1t()).set_TabIndex(389);
		Ax1t().set_Text("1");
		((Control)j4A9()).set_Location(new Point(371, 168));
		((Control)j4A9()).set_Name("PictureBox41");
		((Control)j4A9()).set_Size(new Size(10, 12));
		j4A9().set_SizeMode((PictureBoxSizeMode)4);
		j4A9().set_TabIndex(428);
		j4A9().set_TabStop(false);
		((Control)c6LQ()).set_Location(new Point(351, 168));
		((Control)c6LQ()).set_Name("PictureBox42");
		((Control)c6LQ()).set_Size(new Size(10, 12));
		c6LQ().set_SizeMode((PictureBoxSizeMode)4);
		c6LQ().set_TabIndex(427);
		c6LQ().set_TabStop(false);
		((Control)d4C6()).set_Location(new Point(332, 168));
		((Control)d4C6()).set_Name("PictureBox43");
		((Control)d4C6()).set_Size(new Size(10, 12));
		d4C6().set_SizeMode((PictureBoxSizeMode)4);
		d4C6().set_TabIndex(426);
		d4C6().set_TabStop(false);
		((Control)r4TC()).set_Location(new Point(313, 168));
		((Control)r4TC()).set_Name("PictureBox44");
		((Control)r4TC()).set_Size(new Size(10, 12));
		r4TC().set_SizeMode((PictureBoxSizeMode)4);
		r4TC().set_TabIndex(425);
		r4TC().set_TabStop(false);
		((Control)Qy23()).set_Location(new Point(295, 168));
		((Control)Qy23()).set_Name("PictureBox45");
		((Control)Qy23()).set_Size(new Size(10, 12));
		Qy23().set_SizeMode((PictureBoxSizeMode)4);
		Qy23().set_TabIndex(424);
		Qy23().set_TabStop(false);
		((Control)r7J1()).set_Location(new Point(278, 168));
		((Control)r7J1()).set_Name("PictureBox46");
		((Control)r7J1()).set_Size(new Size(10, 12));
		r7J1().set_SizeMode((PictureBoxSizeMode)4);
		r7J1().set_TabIndex(423);
		r7J1().set_TabStop(false);
		((Control)e9C2()).set_Location(new Point(260, 168));
		((Control)e9C2()).set_Name("PictureBox47");
		((Control)e9C2()).set_Size(new Size(10, 12));
		e9C2().set_SizeMode((PictureBoxSizeMode)4);
		e9C2().set_TabIndex(422);
		e9C2().set_TabStop(false);
		((Control)Nm51()).set_Location(new Point(244, 168));
		((Control)Nm51()).set_Name("PictureBox48");
		((Control)Nm51()).set_Size(new Size(10, 12));
		Nm51().set_SizeMode((PictureBoxSizeMode)4);
		Nm51().set_TabIndex(421);
		Nm51().set_TabStop(false);
		((Control)Ax9o()).set_Location(new Point(226, 168));
		((Control)Ax9o()).set_Name("PictureBox49");
		((Control)Ax9o()).set_Size(new Size(10, 12));
		Ax9o().set_SizeMode((PictureBoxSizeMode)4);
		Ax9o().set_TabIndex(420);
		Ax9o().set_TabStop(false);
		((Control)Tn91()).set_Location(new Point(207, 168));
		((Control)Tn91()).set_Name("PictureBox50");
		((Control)Tn91()).set_Size(new Size(10, 12));
		Tn91().set_SizeMode((PictureBoxSizeMode)4);
		Tn91().set_TabIndex(419);
		Tn91().set_TabStop(false);
		((Control)e1GJ()).set_Location(new Point(189, 168));
		((Control)e1GJ()).set_Name("PictureBox51");
		((Control)e1GJ()).set_Size(new Size(10, 12));
		e1GJ().set_SizeMode((PictureBoxSizeMode)4);
		e1GJ().set_TabIndex(418);
		e1GJ().set_TabStop(false);
		((Control)Fn84()).set_Location(new Point(173, 168));
		((Control)Fn84()).set_Name("PictureBox52");
		((Control)Fn84()).set_Size(new Size(10, 12));
		Fn84().set_SizeMode((PictureBoxSizeMode)4);
		Fn84().set_TabIndex(417);
		Fn84().set_TabStop(false);
		((Control)Zf7m()).set_Location(new Point(157, 168));
		((Control)Zf7m()).set_Name("PictureBox53");
		((Control)Zf7m()).set_Size(new Size(10, 12));
		Zf7m().set_SizeMode((PictureBoxSizeMode)4);
		Zf7m().set_TabIndex(416);
		Zf7m().set_TabStop(false);
		((Control)w5WY()).set_Location(new Point(141, 168));
		((Control)w5WY()).set_Name("PictureBox54");
		((Control)w5WY()).set_Size(new Size(10, 12));
		w5WY().set_SizeMode((PictureBoxSizeMode)4);
		w5WY().set_TabIndex(415);
		w5WY().set_TabStop(false);
		((Control)y1P6()).set_Location(new Point(125, 168));
		((Control)y1P6()).set_Name("PictureBox55");
		((Control)y1P6()).set_Size(new Size(10, 12));
		y1P6().set_SizeMode((PictureBoxSizeMode)4);
		y1P6().set_TabIndex(414);
		y1P6().set_TabStop(false);
		((Control)Qm38()).set_Location(new Point(109, 168));
		((Control)Qm38()).set_Name("PictureBox56");
		((Control)Qm38()).set_Size(new Size(10, 12));
		Qm38().set_SizeMode((PictureBoxSizeMode)4);
		Qm38().set_TabIndex(413);
		Qm38().set_TabStop(false);
		((Control)Ss59()).set_Location(new Point(93, 168));
		((Control)Ss59()).set_Name("PictureBox57");
		((Control)Ss59()).set_Size(new Size(10, 12));
		Ss59().set_SizeMode((PictureBoxSizeMode)4);
		Ss59().set_TabIndex(412);
		Ss59().set_TabStop(false);
		((Control)Lc16()).set_Location(new Point(77, 168));
		((Control)Lc16()).set_Name("PictureBox58");
		((Control)Lc16()).set_Size(new Size(10, 12));
		Lc16().set_SizeMode((PictureBoxSizeMode)4);
		Lc16().set_TabIndex(411);
		Lc16().set_TabStop(false);
		((Control)n5LD()).set_Location(new Point(61, 168));
		((Control)n5LD()).set_Name("PictureBox59");
		((Control)n5LD()).set_Size(new Size(10, 12));
		n5LD().set_SizeMode((PictureBoxSizeMode)4);
		n5LD().set_TabIndex(410);
		n5LD().set_TabStop(false);
		((Control)Hd5f()).set_Location(new Point(47, 168));
		((Control)Hd5f()).set_Name("PictureBox60");
		((Control)Hd5f()).set_Size(new Size(10, 12));
		Hd5f().set_SizeMode((PictureBoxSizeMode)4);
		Hd5f().set_TabIndex(409);
		Hd5f().set_TabStop(false);
		((Control)Zi2f()).set_Location(new Point(371, 190));
		((Control)Zi2f()).set_Name("PictureBox61");
		((Control)Zi2f()).set_Size(new Size(10, 12));
		Zi2f().set_SizeMode((PictureBoxSizeMode)4);
		Zi2f().set_TabIndex(448);
		Zi2f().set_TabStop(false);
		((Control)Lw78()).set_Location(new Point(351, 190));
		((Control)Lw78()).set_Name("PictureBox62");
		((Control)Lw78()).set_Size(new Size(10, 12));
		Lw78().set_SizeMode((PictureBoxSizeMode)4);
		Lw78().set_TabIndex(447);
		Lw78().set_TabStop(false);
		((Control)Kb93()).set_Location(new Point(332, 190));
		((Control)Kb93()).set_Name("PictureBox63");
		((Control)Kb93()).set_Size(new Size(10, 12));
		Kb93().set_SizeMode((PictureBoxSizeMode)4);
		Kb93().set_TabIndex(446);
		Kb93().set_TabStop(false);
		((Control)a1J2()).set_Location(new Point(313, 190));
		((Control)a1J2()).set_Name("PictureBox64");
		((Control)a1J2()).set_Size(new Size(10, 12));
		a1J2().set_SizeMode((PictureBoxSizeMode)4);
		a1J2().set_TabIndex(445);
		a1J2().set_TabStop(false);
		((Control)Kb9r()).set_Location(new Point(295, 190));
		((Control)Kb9r()).set_Name("PictureBox65");
		((Control)Kb9r()).set_Size(new Size(10, 12));
		Kb9r().set_SizeMode((PictureBoxSizeMode)4);
		Kb9r().set_TabIndex(444);
		Kb9r().set_TabStop(false);
		((Control)f1K6()).set_Location(new Point(278, 190));
		((Control)f1K6()).set_Name("PictureBox66");
		((Control)f1K6()).set_Size(new Size(10, 12));
		f1K6().set_SizeMode((PictureBoxSizeMode)4);
		f1K6().set_TabIndex(443);
		f1K6().set_TabStop(false);
		((Control)b1PY()).set_Location(new Point(260, 190));
		((Control)b1PY()).set_Name("PictureBox67");
		((Control)b1PY()).set_Size(new Size(10, 12));
		b1PY().set_SizeMode((PictureBoxSizeMode)4);
		b1PY().set_TabIndex(442);
		b1PY().set_TabStop(false);
		((Control)Yr28()).set_Location(new Point(244, 190));
		((Control)Yr28()).set_Name("PictureBox68");
		((Control)Yr28()).set_Size(new Size(10, 12));
		Yr28().set_SizeMode((PictureBoxSizeMode)4);
		Yr28().set_TabIndex(441);
		Yr28().set_TabStop(false);
		((Control)Ld98()).set_Location(new Point(226, 190));
		((Control)Ld98()).set_Name("PictureBox69");
		((Control)Ld98()).set_Size(new Size(10, 12));
		Ld98().set_SizeMode((PictureBoxSizeMode)4);
		Ld98().set_TabIndex(440);
		Ld98().set_TabStop(false);
		((Control)j1F0()).set_Location(new Point(207, 190));
		((Control)j1F0()).set_Name("PictureBox70");
		((Control)j1F0()).set_Size(new Size(10, 12));
		j1F0().set_SizeMode((PictureBoxSizeMode)4);
		j1F0().set_TabIndex(439);
		j1F0().set_TabStop(false);
		((Control)p1P6()).set_Location(new Point(189, 190));
		((Control)p1P6()).set_Name("PictureBox71");
		((Control)p1P6()).set_Size(new Size(10, 12));
		p1P6().set_SizeMode((PictureBoxSizeMode)4);
		p1P6().set_TabIndex(438);
		p1P6().set_TabStop(false);
		((Control)Lx2j()).set_Location(new Point(173, 190));
		((Control)Lx2j()).set_Name("PictureBox72");
		((Control)Lx2j()).set_Size(new Size(10, 12));
		Lx2j().set_SizeMode((PictureBoxSizeMode)4);
		Lx2j().set_TabIndex(437);
		Lx2j().set_TabStop(false);
		((Control)Hi8g()).set_Location(new Point(157, 190));
		((Control)Hi8g()).set_Name("PictureBox73");
		((Control)Hi8g()).set_Size(new Size(10, 12));
		Hi8g().set_SizeMode((PictureBoxSizeMode)4);
		Hi8g().set_TabIndex(436);
		Hi8g().set_TabStop(false);
		((Control)Zp2c()).set_Location(new Point(141, 190));
		((Control)Zp2c()).set_Name("PictureBox74");
		((Control)Zp2c()).set_Size(new Size(10, 12));
		Zp2c().set_SizeMode((PictureBoxSizeMode)4);
		Zp2c().set_TabIndex(435);
		Zp2c().set_TabStop(false);
		((Control)c0PE()).set_Location(new Point(125, 190));
		((Control)c0PE()).set_Name("PictureBox75");
		((Control)c0PE()).set_Size(new Size(10, 12));
		c0PE().set_SizeMode((PictureBoxSizeMode)4);
		c0PE().set_TabIndex(434);
		c0PE().set_TabStop(false);
		((Control)Gz23()).set_Location(new Point(109, 190));
		((Control)Gz23()).set_Name("PictureBox76");
		((Control)Gz23()).set_Size(new Size(10, 12));
		Gz23().set_SizeMode((PictureBoxSizeMode)4);
		Gz23().set_TabIndex(433);
		Gz23().set_TabStop(false);
		((Control)z1JZ()).set_Location(new Point(93, 190));
		((Control)z1JZ()).set_Name("PictureBox77");
		((Control)z1JZ()).set_Size(new Size(10, 12));
		z1JZ().set_SizeMode((PictureBoxSizeMode)4);
		z1JZ().set_TabIndex(432);
		z1JZ().set_TabStop(false);
		((Control)m0RA()).set_Location(new Point(77, 190));
		((Control)m0RA()).set_Name("PictureBox78");
		((Control)m0RA()).set_Size(new Size(10, 12));
		m0RA().set_SizeMode((PictureBoxSizeMode)4);
		m0RA().set_TabIndex(431);
		m0RA().set_TabStop(false);
		((Control)Sy67()).set_Location(new Point(61, 190));
		((Control)Sy67()).set_Name("PictureBox79");
		((Control)Sy67()).set_Size(new Size(10, 12));
		Sy67().set_SizeMode((PictureBoxSizeMode)4);
		Sy67().set_TabIndex(430);
		Sy67().set_TabStop(false);
		((Control)At3b()).set_Location(new Point(47, 190));
		((Control)At3b()).set_Name("PictureBox80");
		((Control)At3b()).set_Size(new Size(10, 12));
		At3b().set_SizeMode((PictureBoxSizeMode)4);
		At3b().set_TabIndex(429);
		At3b().set_TabStop(false);
		((Control)Le04()).set_Location(new Point(371, 302));
		((Control)Le04()).set_Name("PictureBox81");
		((Control)Le04()).set_Size(new Size(10, 12));
		Le04().set_SizeMode((PictureBoxSizeMode)4);
		Le04().set_TabIndex(468);
		Le04().set_TabStop(false);
		((Control)w0WP()).set_Location(new Point(351, 302));
		((Control)w0WP()).set_Name("PictureBox82");
		((Control)w0WP()).set_Size(new Size(10, 12));
		w0WP().set_SizeMode((PictureBoxSizeMode)4);
		w0WP().set_TabIndex(467);
		w0WP().set_TabStop(false);
		((Control)a5K8()).set_Location(new Point(332, 302));
		((Control)a5K8()).set_Name("PictureBox83");
		((Control)a5K8()).set_Size(new Size(10, 12));
		a5K8().set_SizeMode((PictureBoxSizeMode)4);
		a5K8().set_TabIndex(466);
		a5K8().set_TabStop(false);
		((Control)Dy89()).set_Location(new Point(313, 302));
		((Control)Dy89()).set_Name("PictureBox84");
		((Control)Dy89()).set_Size(new Size(10, 12));
		Dy89().set_SizeMode((PictureBoxSizeMode)4);
		Dy89().set_TabIndex(465);
		Dy89().set_TabStop(false);
		((Control)Rc1g()).set_Location(new Point(295, 302));
		((Control)Rc1g()).set_Name("PictureBox85");
		((Control)Rc1g()).set_Size(new Size(10, 12));
		Rc1g().set_SizeMode((PictureBoxSizeMode)4);
		Rc1g().set_TabIndex(464);
		Rc1g().set_TabStop(false);
		((Control)o1A2()).set_Location(new Point(278, 302));
		((Control)o1A2()).set_Name("PictureBox86");
		((Control)o1A2()).set_Size(new Size(10, 12));
		o1A2().set_SizeMode((PictureBoxSizeMode)4);
		o1A2().set_TabIndex(463);
		o1A2().set_TabStop(false);
		((Control)z2R5()).set_Location(new Point(260, 302));
		((Control)z2R5()).set_Name("PictureBox87");
		((Control)z2R5()).set_Size(new Size(10, 12));
		z2R5().set_SizeMode((PictureBoxSizeMode)4);
		z2R5().set_TabIndex(462);
		z2R5().set_TabStop(false);
		((Control)y4YA()).set_Location(new Point(244, 302));
		((Control)y4YA()).set_Name("PictureBox88");
		((Control)y4YA()).set_Size(new Size(10, 12));
		y4YA().set_SizeMode((PictureBoxSizeMode)4);
		y4YA().set_TabIndex(461);
		y4YA().set_TabStop(false);
		((Control)Zt0z()).set_Location(new Point(226, 302));
		((Control)Zt0z()).set_Name("PictureBox89");
		((Control)Zt0z()).set_Size(new Size(10, 12));
		Zt0z().set_SizeMode((PictureBoxSizeMode)4);
		Zt0z().set_TabIndex(460);
		Zt0z().set_TabStop(false);
		((Control)Hs2m()).set_Location(new Point(207, 302));
		((Control)Hs2m()).set_Name("PictureBox90");
		((Control)Hs2m()).set_Size(new Size(10, 12));
		Hs2m().set_SizeMode((PictureBoxSizeMode)4);
		Hs2m().set_TabIndex(459);
		Hs2m().set_TabStop(false);
		((Control)Zz12()).set_Location(new Point(189, 302));
		((Control)Zz12()).set_Name("PictureBox91");
		((Control)Zz12()).set_Size(new Size(10, 12));
		Zz12().set_SizeMode((PictureBoxSizeMode)4);
		Zz12().set_TabIndex(458);
		Zz12().set_TabStop(false);
		((Control)o6B1()).set_Location(new Point(173, 302));
		((Control)o6B1()).set_Name("PictureBox92");
		((Control)o6B1()).set_Size(new Size(10, 12));
		o6B1().set_SizeMode((PictureBoxSizeMode)4);
		o6B1().set_TabIndex(457);
		o6B1().set_TabStop(false);
		((Control)o8LB()).set_Location(new Point(157, 302));
		((Control)o8LB()).set_Name("PictureBox93");
		((Control)o8LB()).set_Size(new Size(10, 12));
		o8LB().set_SizeMode((PictureBoxSizeMode)4);
		o8LB().set_TabIndex(456);
		o8LB().set_TabStop(false);
		((Control)Zb25()).set_Location(new Point(141, 302));
		((Control)Zb25()).set_Name("PictureBox94");
		((Control)Zb25()).set_Size(new Size(10, 12));
		Zb25().set_SizeMode((PictureBoxSizeMode)4);
		Zb25().set_TabIndex(455);
		Zb25().set_TabStop(false);
		((Control)o9PD()).set_Location(new Point(125, 302));
		((Control)o9PD()).set_Name("PictureBox95");
		((Control)o9PD()).set_Size(new Size(10, 12));
		o9PD().set_SizeMode((PictureBoxSizeMode)4);
		o9PD().set_TabIndex(454);
		o9PD().set_TabStop(false);
		((Control)p5SW()).set_Location(new Point(109, 302));
		((Control)p5SW()).set_Name("PictureBox96");
		((Control)p5SW()).set_Size(new Size(10, 12));
		p5SW().set_SizeMode((PictureBoxSizeMode)4);
		p5SW().set_TabIndex(453);
		p5SW().set_TabStop(false);
		((Control)w7EZ()).set_Location(new Point(93, 302));
		((Control)w7EZ()).set_Name("PictureBox97");
		((Control)w7EZ()).set_Size(new Size(10, 12));
		w7EZ().set_SizeMode((PictureBoxSizeMode)4);
		w7EZ().set_TabIndex(452);
		w7EZ().set_TabStop(false);
		((Control)g7K5()).set_Location(new Point(77, 302));
		((Control)g7K5()).set_Name("PictureBox98");
		((Control)g7K5()).set_Size(new Size(10, 12));
		g7K5().set_SizeMode((PictureBoxSizeMode)4);
		g7K5().set_TabIndex(451);
		g7K5().set_TabStop(false);
		((Control)w6S4()).set_Location(new Point(61, 302));
		((Control)w6S4()).set_Name("PictureBox99");
		((Control)w6S4()).set_Size(new Size(10, 12));
		w6S4().set_SizeMode((PictureBoxSizeMode)4);
		w6S4().set_TabIndex(450);
		w6S4().set_TabStop(false);
		((Control)r3KX()).set_Location(new Point(47, 302));
		((Control)r3KX()).set_Name("PictureBox100");
		((Control)r3KX()).set_Size(new Size(10, 12));
		r3KX().set_SizeMode((PictureBoxSizeMode)4);
		r3KX().set_TabIndex(449);
		r3KX().set_TabStop(false);
		((Control)Ld39()).set_Location(new Point(371, 321));
		((Control)Ld39()).set_Name("PictureBox101");
		((Control)Ld39()).set_Size(new Size(10, 12));
		Ld39().set_SizeMode((PictureBoxSizeMode)4);
		Ld39().set_TabIndex(488);
		Ld39().set_TabStop(false);
		((Control)y6X2()).set_Location(new Point(351, 321));
		((Control)y6X2()).set_Name("PictureBox102");
		((Control)y6X2()).set_Size(new Size(10, 12));
		y6X2().set_SizeMode((PictureBoxSizeMode)4);
		y6X2().set_TabIndex(487);
		y6X2().set_TabStop(false);
		((Control)Sz01()).set_Location(new Point(332, 321));
		((Control)Sz01()).set_Name("PictureBox103");
		((Control)Sz01()).set_Size(new Size(10, 12));
		Sz01().set_SizeMode((PictureBoxSizeMode)4);
		Sz01().set_TabIndex(486);
		Sz01().set_TabStop(false);
		((Control)d2RG()).set_Location(new Point(313, 321));
		((Control)d2RG()).set_Name("PictureBox104");
		((Control)d2RG()).set_Size(new Size(10, 12));
		d2RG().set_SizeMode((PictureBoxSizeMode)4);
		d2RG().set_TabIndex(485);
		d2RG().set_TabStop(false);
		((Control)Pk09()).set_Location(new Point(295, 321));
		((Control)Pk09()).set_Name("PictureBox105");
		((Control)Pk09()).set_Size(new Size(10, 12));
		Pk09().set_SizeMode((PictureBoxSizeMode)4);
		Pk09().set_TabIndex(484);
		Pk09().set_TabStop(false);
		((Control)Qs19()).set_Location(new Point(278, 321));
		((Control)Qs19()).set_Name("PictureBox106");
		((Control)Qs19()).set_Size(new Size(10, 12));
		Qs19().set_SizeMode((PictureBoxSizeMode)4);
		Qs19().set_TabIndex(483);
		Qs19().set_TabStop(false);
		((Control)g9HY()).set_Location(new Point(260, 321));
		((Control)g9HY()).set_Name("PictureBox107");
		((Control)g9HY()).set_Size(new Size(10, 12));
		g9HY().set_SizeMode((PictureBoxSizeMode)4);
		g9HY().set_TabIndex(482);
		g9HY().set_TabStop(false);
		((Control)p3RB()).set_Location(new Point(244, 321));
		((Control)p3RB()).set_Name("PictureBox108");
		((Control)p3RB()).set_Size(new Size(10, 12));
		p3RB().set_SizeMode((PictureBoxSizeMode)4);
		p3RB().set_TabIndex(481);
		p3RB().set_TabStop(false);
		((Control)Fd5p()).set_Location(new Point(226, 321));
		((Control)Fd5p()).set_Name("PictureBox109");
		((Control)Fd5p()).set_Size(new Size(10, 12));
		Fd5p().set_SizeMode((PictureBoxSizeMode)4);
		Fd5p().set_TabIndex(480);
		Fd5p().set_TabStop(false);
		((Control)Xd57()).set_Location(new Point(207, 321));
		((Control)Xd57()).set_Name("PictureBox110");
		((Control)Xd57()).set_Size(new Size(10, 12));
		Xd57().set_SizeMode((PictureBoxSizeMode)4);
		Xd57().set_TabIndex(479);
		Xd57().set_TabStop(false);
		((Control)y3J1()).set_Location(new Point(189, 321));
		((Control)y3J1()).set_Name("PictureBox111");
		((Control)y3J1()).set_Size(new Size(10, 12));
		y3J1().set_SizeMode((PictureBoxSizeMode)4);
		y3J1().set_TabIndex(478);
		y3J1().set_TabStop(false);
		((Control)Fy1a()).set_Location(new Point(173, 321));
		((Control)Fy1a()).set_Name("PictureBox112");
		((Control)Fy1a()).set_Size(new Size(10, 12));
		Fy1a().set_SizeMode((PictureBoxSizeMode)4);
		Fy1a().set_TabIndex(477);
		Fy1a().set_TabStop(false);
		((Control)Ai06()).set_Location(new Point(157, 321));
		((Control)Ai06()).set_Name("PictureBox113");
		((Control)Ai06()).set_Size(new Size(10, 12));
		Ai06().set_SizeMode((PictureBoxSizeMode)4);
		Ai06().set_TabIndex(476);
		Ai06().set_TabStop(false);
		((Control)Mg4d()).set_Location(new Point(141, 321));
		((Control)Mg4d()).set_Name("PictureBox114");
		((Control)Mg4d()).set_Size(new Size(10, 12));
		Mg4d().set_SizeMode((PictureBoxSizeMode)4);
		Mg4d().set_TabIndex(475);
		Mg4d().set_TabStop(false);
		((Control)Jb25()).set_Location(new Point(125, 321));
		((Control)Jb25()).set_Name("PictureBox115");
		((Control)Jb25()).set_Size(new Size(10, 12));
		Jb25().set_SizeMode((PictureBoxSizeMode)4);
		Jb25().set_TabIndex(474);
		Jb25().set_TabStop(false);
		((Control)Zf64()).set_Location(new Point(109, 321));
		((Control)Zf64()).set_Name("PictureBox116");
		((Control)Zf64()).set_Size(new Size(10, 12));
		Zf64().set_SizeMode((PictureBoxSizeMode)4);
		Zf64().set_TabIndex(473);
		Zf64().set_TabStop(false);
		((Control)w2L0()).set_Location(new Point(93, 321));
		((Control)w2L0()).set_Name("PictureBox117");
		((Control)w2L0()).set_Size(new Size(10, 12));
		w2L0().set_SizeMode((PictureBoxSizeMode)4);
		w2L0().set_TabIndex(472);
		w2L0().set_TabStop(false);
		((Control)Wf1w()).set_Location(new Point(77, 321));
		((Control)Wf1w()).set_Name("PictureBox118");
		((Control)Wf1w()).set_Size(new Size(10, 12));
		Wf1w().set_SizeMode((PictureBoxSizeMode)4);
		Wf1w().set_TabIndex(471);
		Wf1w().set_TabStop(false);
		((Control)Rd10()).set_Location(new Point(61, 321));
		((Control)Rd10()).set_Name("PictureBox119");
		((Control)Rd10()).set_Size(new Size(10, 12));
		Rd10().set_SizeMode((PictureBoxSizeMode)4);
		Rd10().set_TabIndex(470);
		Rd10().set_TabStop(false);
		((Control)i0NQ()).set_Location(new Point(47, 321));
		((Control)i0NQ()).set_Name("PictureBox120");
		((Control)i0NQ()).set_Size(new Size(10, 12));
		i0NQ().set_SizeMode((PictureBoxSizeMode)4);
		i0NQ().set_TabIndex(469);
		i0NQ().set_TabStop(false);
		((Control)j1S0()).set_Location(new Point(371, 343));
		((Control)j1S0()).set_Name("PictureBox121");
		((Control)j1S0()).set_Size(new Size(10, 12));
		j1S0().set_SizeMode((PictureBoxSizeMode)4);
		j1S0().set_TabIndex(508);
		j1S0().set_TabStop(false);
		((Control)Wf8p()).set_Location(new Point(351, 343));
		((Control)Wf8p()).set_Name("PictureBox122");
		((Control)Wf8p()).set_Size(new Size(10, 12));
		Wf8p().set_SizeMode((PictureBoxSizeMode)4);
		Wf8p().set_TabIndex(507);
		Wf8p().set_TabStop(false);
		((Control)p6GP()).set_Location(new Point(332, 343));
		((Control)p6GP()).set_Name("PictureBox123");
		((Control)p6GP()).set_Size(new Size(10, 12));
		p6GP().set_SizeMode((PictureBoxSizeMode)4);
		p6GP().set_TabIndex(506);
		p6GP().set_TabStop(false);
		((Control)Za9j()).set_Location(new Point(313, 343));
		((Control)Za9j()).set_Name("PictureBox124");
		((Control)Za9j()).set_Size(new Size(10, 12));
		Za9j().set_SizeMode((PictureBoxSizeMode)4);
		Za9j().set_TabIndex(505);
		Za9j().set_TabStop(false);
		((Control)o3G0()).set_Location(new Point(295, 343));
		((Control)o3G0()).set_Name("PictureBox125");
		((Control)o3G0()).set_Size(new Size(10, 12));
		o3G0().set_SizeMode((PictureBoxSizeMode)4);
		o3G0().set_TabIndex(504);
		o3G0().set_TabStop(false);
		((Control)p6X3()).set_Location(new Point(278, 343));
		((Control)p6X3()).set_Name("PictureBox126");
		((Control)p6X3()).set_Size(new Size(10, 12));
		p6X3().set_SizeMode((PictureBoxSizeMode)4);
		p6X3().set_TabIndex(503);
		p6X3().set_TabStop(false);
		((Control)Kc4r()).set_Location(new Point(260, 343));
		((Control)Kc4r()).set_Name("PictureBox127");
		((Control)Kc4r()).set_Size(new Size(10, 12));
		Kc4r().set_SizeMode((PictureBoxSizeMode)4);
		Kc4r().set_TabIndex(502);
		Kc4r().set_TabStop(false);
		((Control)d4S0()).set_Location(new Point(244, 343));
		((Control)d4S0()).set_Name("PictureBox128");
		((Control)d4S0()).set_Size(new Size(10, 12));
		d4S0().set_SizeMode((PictureBoxSizeMode)4);
		d4S0().set_TabIndex(501);
		d4S0().set_TabStop(false);
		((Control)Bt47()).set_Location(new Point(226, 343));
		((Control)Bt47()).set_Name("PictureBox129");
		((Control)Bt47()).set_Size(new Size(10, 12));
		Bt47().set_SizeMode((PictureBoxSizeMode)4);
		Bt47().set_TabIndex(500);
		Bt47().set_TabStop(false);
		((Control)Ja90()).set_Location(new Point(207, 343));
		((Control)Ja90()).set_Name("PictureBox130");
		((Control)Ja90()).set_Size(new Size(10, 12));
		Ja90().set_SizeMode((PictureBoxSizeMode)4);
		Ja90().set_TabIndex(499);
		Ja90().set_TabStop(false);
		((Control)Rb47()).set_Location(new Point(189, 343));
		((Control)Rb47()).set_Name("PictureBox131");
		((Control)Rb47()).set_Size(new Size(10, 12));
		Rb47().set_SizeMode((PictureBoxSizeMode)4);
		Rb47().set_TabIndex(498);
		Rb47().set_TabStop(false);
		((Control)Kt9z()).set_Location(new Point(173, 343));
		((Control)Kt9z()).set_Name("PictureBox132");
		((Control)Kt9z()).set_Size(new Size(10, 12));
		Kt9z().set_SizeMode((PictureBoxSizeMode)4);
		Kt9z().set_TabIndex(497);
		Kt9z().set_TabStop(false);
		((Control)r0J3()).set_Location(new Point(157, 343));
		((Control)r0J3()).set_Name("PictureBox133");
		((Control)r0J3()).set_Size(new Size(10, 12));
		r0J3().set_SizeMode((PictureBoxSizeMode)4);
		r0J3().set_TabIndex(496);
		r0J3().set_TabStop(false);
		((Control)Jt9s()).set_Location(new Point(141, 343));
		((Control)Jt9s()).set_Name("PictureBox134");
		((Control)Jt9s()).set_Size(new Size(10, 12));
		Jt9s().set_SizeMode((PictureBoxSizeMode)4);
		Jt9s().set_TabIndex(495);
		Jt9s().set_TabStop(false);
		((Control)Hi1s()).set_Location(new Point(125, 343));
		((Control)Hi1s()).set_Name("PictureBox135");
		((Control)Hi1s()).set_Size(new Size(10, 12));
		Hi1s().set_SizeMode((PictureBoxSizeMode)4);
		Hi1s().set_TabIndex(494);
		Hi1s().set_TabStop(false);
		((Control)Qo48()).set_Location(new Point(109, 343));
		((Control)Qo48()).set_Name("PictureBox136");
		((Control)Qo48()).set_Size(new Size(10, 12));
		Qo48().set_SizeMode((PictureBoxSizeMode)4);
		Qo48().set_TabIndex(493);
		Qo48().set_TabStop(false);
		((Control)c4N1()).set_Location(new Point(93, 343));
		((Control)c4N1()).set_Name("PictureBox137");
		((Control)c4N1()).set_Size(new Size(10, 12));
		c4N1().set_SizeMode((PictureBoxSizeMode)4);
		c4N1().set_TabIndex(492);
		c4N1().set_TabStop(false);
		((Control)St98()).set_Location(new Point(77, 343));
		((Control)St98()).set_Name("PictureBox138");
		((Control)St98()).set_Size(new Size(10, 12));
		St98().set_SizeMode((PictureBoxSizeMode)4);
		St98().set_TabIndex(491);
		St98().set_TabStop(false);
		((Control)r7P1()).set_Location(new Point(61, 343));
		((Control)r7P1()).set_Name("PictureBox139");
		((Control)r7P1()).set_Size(new Size(10, 12));
		r7P1().set_SizeMode((PictureBoxSizeMode)4);
		r7P1().set_TabIndex(490);
		r7P1().set_TabStop(false);
		((Control)j4DB()).set_Location(new Point(47, 343));
		((Control)j4DB()).set_Name("PictureBox140");
		((Control)j4DB()).set_Size(new Size(10, 12));
		j4DB().set_SizeMode((PictureBoxSizeMode)4);
		j4DB().set_TabIndex(489);
		j4DB().set_TabStop(false);
		((Control)Kp56()).set_Location(new Point(371, 365));
		((Control)Kp56()).set_Name("PictureBox141");
		((Control)Kp56()).set_Size(new Size(10, 12));
		Kp56().set_SizeMode((PictureBoxSizeMode)4);
		Kp56().set_TabIndex(528);
		Kp56().set_TabStop(false);
		((Control)Cx43()).set_Location(new Point(351, 365));
		((Control)Cx43()).set_Name("PictureBox142");
		((Control)Cx43()).set_Size(new Size(10, 12));
		Cx43().set_SizeMode((PictureBoxSizeMode)4);
		Cx43().set_TabIndex(527);
		Cx43().set_TabStop(false);
		((Control)q7R0()).set_Location(new Point(332, 365));
		((Control)q7R0()).set_Name("PictureBox143");
		((Control)q7R0()).set_Size(new Size(10, 12));
		q7R0().set_SizeMode((PictureBoxSizeMode)4);
		q7R0().set_TabIndex(526);
		q7R0().set_TabStop(false);
		((Control)x2Y3()).set_Location(new Point(313, 365));
		((Control)x2Y3()).set_Name("PictureBox144");
		((Control)x2Y3()).set_Size(new Size(10, 12));
		x2Y3().set_SizeMode((PictureBoxSizeMode)4);
		x2Y3().set_TabIndex(525);
		x2Y3().set_TabStop(false);
		((Control)Fm3r()).set_Location(new Point(295, 365));
		((Control)Fm3r()).set_Name("PictureBox145");
		((Control)Fm3r()).set_Size(new Size(10, 12));
		Fm3r().set_SizeMode((PictureBoxSizeMode)4);
		Fm3r().set_TabIndex(524);
		Fm3r().set_TabStop(false);
		((Control)t4Q9()).set_Location(new Point(278, 365));
		((Control)t4Q9()).set_Name("PictureBox146");
		((Control)t4Q9()).set_Size(new Size(10, 12));
		t4Q9().set_SizeMode((PictureBoxSizeMode)4);
		t4Q9().set_TabIndex(523);
		t4Q9().set_TabStop(false);
		((Control)Fx64()).set_Location(new Point(260, 365));
		((Control)Fx64()).set_Name("PictureBox147");
		((Control)Fx64()).set_Size(new Size(10, 12));
		Fx64().set_SizeMode((PictureBoxSizeMode)4);
		Fx64().set_TabIndex(522);
		Fx64().set_TabStop(false);
		((Control)t5GT()).set_Location(new Point(244, 365));
		((Control)t5GT()).set_Name("PictureBox148");
		((Control)t5GT()).set_Size(new Size(10, 12));
		t5GT().set_SizeMode((PictureBoxSizeMode)4);
		t5GT().set_TabIndex(521);
		t5GT().set_TabStop(false);
		((Control)y2RM()).set_Location(new Point(226, 365));
		((Control)y2RM()).set_Name("PictureBox149");
		((Control)y2RM()).set_Size(new Size(10, 12));
		y2RM().set_SizeMode((PictureBoxSizeMode)4);
		y2RM().set_TabIndex(520);
		y2RM().set_TabStop(false);
		((Control)i1CL()).set_Location(new Point(207, 365));
		((Control)i1CL()).set_Name("PictureBox150");
		((Control)i1CL()).set_Size(new Size(10, 12));
		i1CL().set_SizeMode((PictureBoxSizeMode)4);
		i1CL().set_TabIndex(519);
		i1CL().set_TabStop(false);
		((Control)a6X2()).set_Location(new Point(189, 365));
		((Control)a6X2()).set_Name("PictureBox151");
		((Control)a6X2()).set_Size(new Size(10, 12));
		a6X2().set_SizeMode((PictureBoxSizeMode)4);
		a6X2().set_TabIndex(518);
		a6X2().set_TabStop(false);
		((Control)j6AP()).set_Location(new Point(173, 365));
		((Control)j6AP()).set_Name("PictureBox152");
		((Control)j6AP()).set_Size(new Size(10, 12));
		j6AP().set_SizeMode((PictureBoxSizeMode)4);
		j6AP().set_TabIndex(517);
		j6AP().set_TabStop(false);
		((Control)Sz12()).set_Location(new Point(157, 365));
		((Control)Sz12()).set_Name("PictureBox153");
		((Control)Sz12()).set_Size(new Size(10, 12));
		Sz12().set_SizeMode((PictureBoxSizeMode)4);
		Sz12().set_TabIndex(516);
		Sz12().set_TabStop(false);
		((Control)p2LK()).set_Location(new Point(141, 365));
		((Control)p2LK()).set_Name("PictureBox154");
		((Control)p2LK()).set_Size(new Size(10, 12));
		p2LK().set_SizeMode((PictureBoxSizeMode)4);
		p2LK().set_TabIndex(515);
		p2LK().set_TabStop(false);
		((Control)Ne8c()).set_Location(new Point(125, 365));
		((Control)Ne8c()).set_Name("PictureBox155");
		((Control)Ne8c()).set_Size(new Size(10, 12));
		Ne8c().set_SizeMode((PictureBoxSizeMode)4);
		Ne8c().set_TabIndex(514);
		Ne8c().set_TabStop(false);
		((Control)Wd38()).set_Location(new Point(109, 365));
		((Control)Wd38()).set_Name("PictureBox156");
		((Control)Wd38()).set_Size(new Size(10, 12));
		Wd38().set_SizeMode((PictureBoxSizeMode)4);
		Wd38().set_TabIndex(513);
		Wd38().set_TabStop(false);
		((Control)j9Y6()).set_Location(new Point(93, 365));
		((Control)j9Y6()).set_Name("PictureBox157");
		((Control)j9Y6()).set_Size(new Size(10, 12));
		j9Y6().set_SizeMode((PictureBoxSizeMode)4);
		j9Y6().set_TabIndex(512);
		j9Y6().set_TabStop(false);
		((Control)w9X0()).set_Location(new Point(77, 365));
		((Control)w9X0()).set_Name("PictureBox158");
		((Control)w9X0()).set_Size(new Size(10, 12));
		w9X0().set_SizeMode((PictureBoxSizeMode)4);
		w9X0().set_TabIndex(511);
		w9X0().set_TabStop(false);
		((Control)Be8z()).set_Location(new Point(61, 365));
		((Control)Be8z()).set_Name("PictureBox159");
		((Control)Be8z()).set_Size(new Size(10, 12));
		Be8z().set_SizeMode((PictureBoxSizeMode)4);
		Be8z().set_TabIndex(510);
		Be8z().set_TabStop(false);
		((Control)r1RQ()).set_Location(new Point(47, 365));
		((Control)r1RQ()).set_Name("PictureBox160");
		((Control)r1RQ()).set_Size(new Size(10, 12));
		r1RQ().set_SizeMode((PictureBoxSizeMode)4);
		r1RQ().set_TabIndex(509);
		r1RQ().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)Kp56());
		((Control)this).get_Controls().Add((Control)(object)Cx43());
		((Control)this).get_Controls().Add((Control)(object)q7R0());
		((Control)this).get_Controls().Add((Control)(object)x2Y3());
		((Control)this).get_Controls().Add((Control)(object)Fm3r());
		((Control)this).get_Controls().Add((Control)(object)t4Q9());
		((Control)this).get_Controls().Add((Control)(object)Fx64());
		((Control)this).get_Controls().Add((Control)(object)t5GT());
		((Control)this).get_Controls().Add((Control)(object)y2RM());
		((Control)this).get_Controls().Add((Control)(object)i1CL());
		((Control)this).get_Controls().Add((Control)(object)a6X2());
		((Control)this).get_Controls().Add((Control)(object)j6AP());
		((Control)this).get_Controls().Add((Control)(object)Sz12());
		((Control)this).get_Controls().Add((Control)(object)p2LK());
		((Control)this).get_Controls().Add((Control)(object)Ne8c());
		((Control)this).get_Controls().Add((Control)(object)Wd38());
		((Control)this).get_Controls().Add((Control)(object)j9Y6());
		((Control)this).get_Controls().Add((Control)(object)w9X0());
		((Control)this).get_Controls().Add((Control)(object)Be8z());
		((Control)this).get_Controls().Add((Control)(object)r1RQ());
		((Control)this).get_Controls().Add((Control)(object)j1S0());
		((Control)this).get_Controls().Add((Control)(object)Wf8p());
		((Control)this).get_Controls().Add((Control)(object)p6GP());
		((Control)this).get_Controls().Add((Control)(object)Za9j());
		((Control)this).get_Controls().Add((Control)(object)o3G0());
		((Control)this).get_Controls().Add((Control)(object)p6X3());
		((Control)this).get_Controls().Add((Control)(object)Kc4r());
		((Control)this).get_Controls().Add((Control)(object)d4S0());
		((Control)this).get_Controls().Add((Control)(object)Bt47());
		((Control)this).get_Controls().Add((Control)(object)Ja90());
		((Control)this).get_Controls().Add((Control)(object)Rb47());
		((Control)this).get_Controls().Add((Control)(object)Kt9z());
		((Control)this).get_Controls().Add((Control)(object)r0J3());
		((Control)this).get_Controls().Add((Control)(object)Jt9s());
		((Control)this).get_Controls().Add((Control)(object)Hi1s());
		((Control)this).get_Controls().Add((Control)(object)Qo48());
		((Control)this).get_Controls().Add((Control)(object)c4N1());
		((Control)this).get_Controls().Add((Control)(object)St98());
		((Control)this).get_Controls().Add((Control)(object)r7P1());
		((Control)this).get_Controls().Add((Control)(object)j4DB());
		((Control)this).get_Controls().Add((Control)(object)Ld39());
		((Control)this).get_Controls().Add((Control)(object)y6X2());
		((Control)this).get_Controls().Add((Control)(object)Sz01());
		((Control)this).get_Controls().Add((Control)(object)d2RG());
		((Control)this).get_Controls().Add((Control)(object)Pk09());
		((Control)this).get_Controls().Add((Control)(object)Qs19());
		((Control)this).get_Controls().Add((Control)(object)g9HY());
		((Control)this).get_Controls().Add((Control)(object)p3RB());
		((Control)this).get_Controls().Add((Control)(object)Fd5p());
		((Control)this).get_Controls().Add((Control)(object)Xd57());
		((Control)this).get_Controls().Add((Control)(object)y3J1());
		((Control)this).get_Controls().Add((Control)(object)Fy1a());
		((Control)this).get_Controls().Add((Control)(object)Ai06());
		((Control)this).get_Controls().Add((Control)(object)Mg4d());
		((Control)this).get_Controls().Add((Control)(object)Jb25());
		((Control)this).get_Controls().Add((Control)(object)Zf64());
		((Control)this).get_Controls().Add((Control)(object)w2L0());
		((Control)this).get_Controls().Add((Control)(object)Wf1w());
		((Control)this).get_Controls().Add((Control)(object)Rd10());
		((Control)this).get_Controls().Add((Control)(object)i0NQ());
		((Control)this).get_Controls().Add((Control)(object)Le04());
		((Control)this).get_Controls().Add((Control)(object)w0WP());
		((Control)this).get_Controls().Add((Control)(object)a5K8());
		((Control)this).get_Controls().Add((Control)(object)Dy89());
		((Control)this).get_Controls().Add((Control)(object)Rc1g());
		((Control)this).get_Controls().Add((Control)(object)o1A2());
		((Control)this).get_Controls().Add((Control)(object)z2R5());
		((Control)this).get_Controls().Add((Control)(object)y4YA());
		((Control)this).get_Controls().Add((Control)(object)Zt0z());
		((Control)this).get_Controls().Add((Control)(object)Hs2m());
		((Control)this).get_Controls().Add((Control)(object)Zz12());
		((Control)this).get_Controls().Add((Control)(object)o6B1());
		((Control)this).get_Controls().Add((Control)(object)o8LB());
		((Control)this).get_Controls().Add((Control)(object)Zb25());
		((Control)this).get_Controls().Add((Control)(object)o9PD());
		((Control)this).get_Controls().Add((Control)(object)p5SW());
		((Control)this).get_Controls().Add((Control)(object)w7EZ());
		((Control)this).get_Controls().Add((Control)(object)g7K5());
		((Control)this).get_Controls().Add((Control)(object)w6S4());
		((Control)this).get_Controls().Add((Control)(object)r3KX());
		((Control)this).get_Controls().Add((Control)(object)Zi2f());
		((Control)this).get_Controls().Add((Control)(object)Lw78());
		((Control)this).get_Controls().Add((Control)(object)Kb93());
		((Control)this).get_Controls().Add((Control)(object)a1J2());
		((Control)this).get_Controls().Add((Control)(object)Kb9r());
		((Control)this).get_Controls().Add((Control)(object)f1K6());
		((Control)this).get_Controls().Add((Control)(object)b1PY());
		((Control)this).get_Controls().Add((Control)(object)Yr28());
		((Control)this).get_Controls().Add((Control)(object)Ld98());
		((Control)this).get_Controls().Add((Control)(object)j1F0());
		((Control)this).get_Controls().Add((Control)(object)p1P6());
		((Control)this).get_Controls().Add((Control)(object)Lx2j());
		((Control)this).get_Controls().Add((Control)(object)Hi8g());
		((Control)this).get_Controls().Add((Control)(object)Zp2c());
		((Control)this).get_Controls().Add((Control)(object)c0PE());
		((Control)this).get_Controls().Add((Control)(object)Gz23());
		((Control)this).get_Controls().Add((Control)(object)z1JZ());
		((Control)this).get_Controls().Add((Control)(object)m0RA());
		((Control)this).get_Controls().Add((Control)(object)Sy67());
		((Control)this).get_Controls().Add((Control)(object)At3b());
		((Control)this).get_Controls().Add((Control)(object)j4A9());
		((Control)this).get_Controls().Add((Control)(object)c6LQ());
		((Control)this).get_Controls().Add((Control)(object)d4C6());
		((Control)this).get_Controls().Add((Control)(object)r4TC());
		((Control)this).get_Controls().Add((Control)(object)Qy23());
		((Control)this).get_Controls().Add((Control)(object)r7J1());
		((Control)this).get_Controls().Add((Control)(object)e9C2());
		((Control)this).get_Controls().Add((Control)(object)Nm51());
		((Control)this).get_Controls().Add((Control)(object)Ax9o());
		((Control)this).get_Controls().Add((Control)(object)Tn91());
		((Control)this).get_Controls().Add((Control)(object)e1GJ());
		((Control)this).get_Controls().Add((Control)(object)Fn84());
		((Control)this).get_Controls().Add((Control)(object)Zf7m());
		((Control)this).get_Controls().Add((Control)(object)w5WY());
		((Control)this).get_Controls().Add((Control)(object)y1P6());
		((Control)this).get_Controls().Add((Control)(object)Qm38());
		((Control)this).get_Controls().Add((Control)(object)Ss59());
		((Control)this).get_Controls().Add((Control)(object)Lc16());
		((Control)this).get_Controls().Add((Control)(object)n5LD());
		((Control)this).get_Controls().Add((Control)(object)Hd5f());
		((Control)this).get_Controls().Add((Control)(object)x0L1());
		((Control)this).get_Controls().Add((Control)(object)Jx4w());
		((Control)this).get_Controls().Add((Control)(object)Qi73());
		((Control)this).get_Controls().Add((Control)(object)Rp8k());
		((Control)this).get_Controls().Add((Control)(object)e8YG());
		((Control)this).get_Controls().Add((Control)(object)Jz5d());
		((Control)this).get_Controls().Add((Control)(object)Lp20());
		((Control)this).get_Controls().Add((Control)(object)Qm60());
		((Control)this).get_Controls().Add((Control)(object)q5M9());
		((Control)this).get_Controls().Add((Control)(object)Rp1o());
		((Control)this).get_Controls().Add((Control)(object)c2GS());
		((Control)this).get_Controls().Add((Control)(object)p1T2());
		((Control)this).get_Controls().Add((Control)(object)s3ET());
		((Control)this).get_Controls().Add((Control)(object)m1G8());
		((Control)this).get_Controls().Add((Control)(object)k2C1());
		((Control)this).get_Controls().Add((Control)(object)Mf8j());
		((Control)this).get_Controls().Add((Control)(object)t6PG());
		((Control)this).get_Controls().Add((Control)(object)b5ZB());
		((Control)this).get_Controls().Add((Control)(object)s7ES());
		((Control)this).get_Controls().Add((Control)(object)Ax1t());
		((Control)this).get_Controls().Add((Control)(object)Ya6x());
		((Control)this).get_Controls().Add((Control)(object)g1ST());
		((Control)this).get_Controls().Add((Control)(object)Qa80());
		((Control)this).get_Controls().Add((Control)(object)Nd4m());
		((Control)this).get_Controls().Add((Control)(object)Sq3o());
		((Control)this).get_Controls().Add((Control)(object)d2M6());
		((Control)this).get_Controls().Add((Control)(object)Ni8p());
		((Control)this).get_Controls().Add((Control)(object)t2H8());
		((Control)this).get_Controls().Add((Control)(object)f3JW());
		((Control)this).get_Controls().Add((Control)(object)Bj9a());
		((Control)this).get_Controls().Add((Control)(object)x1SC());
		((Control)this).get_Controls().Add((Control)(object)m1DN());
		((Control)this).get_Controls().Add((Control)(object)Pp96());
		((Control)this).get_Controls().Add((Control)(object)j9E5());
		((Control)this).get_Controls().Add((Control)(object)Ls45());
		((Control)this).get_Controls().Add((Control)(object)a2N5());
		((Control)this).get_Controls().Add((Control)(object)Eq4y());
		((Control)this).get_Controls().Add((Control)(object)Cs27());
		((Control)this).get_Controls().Add((Control)(object)Ao91());
		((Control)this).get_Controls().Add((Control)(object)Hs05());
		((Control)this).get_Controls().Add((Control)(object)d3Y4());
		((Control)this).get_Controls().Add((Control)(object)Kb3i());
		((Control)this).get_Controls().Add((Control)(object)y8S9());
		((Control)this).get_Controls().Add((Control)(object)r3W4());
		((Control)this).get_Controls().Add((Control)(object)Xo7());
		((Control)this).get_Controls().Add((Control)(object)Sq0());
		((Control)this).get_Controls().Add((Control)(object)t9W());
		((Control)this).get_Controls().Add((Control)(object)x7T());
		((Control)this).get_Controls().Add((Control)(object)Lf2());
		((Control)this).get_Controls().Add((Control)(object)x9T());
		((Control)this).get_Controls().Add((Control)(object)n6S());
		((Control)this).get_Controls().Add((Control)(object)Go3());
		((Control)this).get_Controls().Add((Control)(object)Qz7());
		((Control)this).get_Controls().Add((Control)(object)n7K());
		((Control)this).get_Controls().Add((Control)(object)o1M());
		((Control)this).get_Controls().Add((Control)(object)Fj9());
		((Control)this).get_Controls().Add((Control)(object)e5H());
		((Control)this).get_Controls().Add((Control)(object)Xb7());
		((Control)this).get_Controls().Add((Control)(object)a7P());
		((Control)this).get_Controls().Add((Control)(object)a1Q());
		((Control)this).get_Controls().Add((Control)(object)Px0());
		((Control)this).get_Controls().Add((Control)(object)k9H());
		((Control)this).get_Controls().Add((Control)(object)i7R());
		((Control)this).get_Controls().Add((Control)(object)Ed5());
		((Control)this).get_Controls().Add((Control)(object)c3C());
		((Control)this).get_Controls().Add((Control)(object)e8S());
		((Control)this).get_Controls().Add((Control)(object)k3K());
		((Control)this).get_Controls().Add((Control)(object)d1L());
		((Control)this).get_Controls().Add((Control)(object)Gi2());
		((Control)this).get_Controls().Add((Control)(object)q4Y());
		((Control)this).get_Controls().Add((Control)(object)Mq5());
		((Control)this).get_Controls().Add((Control)(object)q4Q());
		((Control)this).get_Controls().Add((Control)(object)Wm4());
		((Control)this).get_Controls().Add((Control)(object)m0N());
		((Control)this).get_Controls().Add((Control)(object)k0G());
		((Control)this).get_Controls().Add((Control)(object)e0K());
		((Control)this).get_Controls().Add((Control)(object)o4Y());
		((Control)this).get_Controls().Add((Control)(object)d3Z());
		((Control)this).get_Controls().Add((Control)(object)Sc9());
		((Control)this).get_Controls().Add((Control)(object)c3F());
		((Control)this).get_Controls().Add((Control)(object)Xg0());
		((Control)this).get_Controls().Add((Control)(object)i0D());
		((Control)this).get_Controls().Add((Control)(object)Ls3());
		((Control)this).get_Controls().Add((Control)(object)Dq9());
		((Control)this).get_Controls().Add((Control)(object)m2R());
		((Control)this).get_Controls().Add((Control)(object)i0B());
		((Control)this).get_Controls().Add((Control)(object)p9P());
		((Control)this).get_Controls().Add((Control)(object)Wi5());
		((Control)this).get_Controls().Add((Control)(object)f8G());
		((Control)this).get_Controls().Add((Control)(object)r8E());
		((Control)this).get_Controls().Add((Control)(object)d5K());
		((Control)this).get_Controls().Add((Control)(object)g9F());
		((Control)this).get_Controls().Add((Control)(object)Mk2());
		((Control)this).get_Controls().Add((Control)(object)r4J());
		((Control)this).get_Controls().Add((Control)(object)Mp6());
		((Control)this).get_Controls().Add((Control)(object)s2P());
		((Control)this).get_Controls().Add((Control)(object)i5C());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 1");
		((ISupportInitialize)i5C()).EndInit();
		((ISupportInitialize)s2P()).EndInit();
		((Control)r4J()).ResumeLayout(false);
		((Control)r4J()).PerformLayout();
		((ISupportInitialize)w3N()).EndInit();
		((ISupportInitialize)e0F()).EndInit();
		((ISupportInitialize)o2Z()).EndInit();
		((Control)Mk2()).ResumeLayout(false);
		((Control)Mk2()).PerformLayout();
		((Control)g9F()).ResumeLayout(false);
		((ISupportInitialize)Lr3()).EndInit();
		((Control)d5K()).ResumeLayout(false);
		((Control)d5K()).PerformLayout();
		((ISupportInitialize)a1Q()).EndInit();
		((ISupportInitialize)a7P()).EndInit();
		((ISupportInitialize)Xb7()).EndInit();
		((ISupportInitialize)e5H()).EndInit();
		((ISupportInitialize)Fj9()).EndInit();
		((ISupportInitialize)o1M()).EndInit();
		((ISupportInitialize)n7K()).EndInit();
		((ISupportInitialize)Qz7()).EndInit();
		((ISupportInitialize)Go3()).EndInit();
		((ISupportInitialize)n6S()).EndInit();
		((ISupportInitialize)x9T()).EndInit();
		((ISupportInitialize)Lf2()).EndInit();
		((ISupportInitialize)x7T()).EndInit();
		((ISupportInitialize)t9W()).EndInit();
		((ISupportInitialize)Sq0()).EndInit();
		((ISupportInitialize)Xo7()).EndInit();
		((ISupportInitialize)r3W4()).EndInit();
		((ISupportInitialize)y8S9()).EndInit();
		((ISupportInitialize)Kb3i()).EndInit();
		((ISupportInitialize)d3Y4()).EndInit();
		((ISupportInitialize)Ya6x()).EndInit();
		((ISupportInitialize)g1ST()).EndInit();
		((ISupportInitialize)Qa80()).EndInit();
		((ISupportInitialize)Nd4m()).EndInit();
		((ISupportInitialize)Sq3o()).EndInit();
		((ISupportInitialize)d2M6()).EndInit();
		((ISupportInitialize)Ni8p()).EndInit();
		((ISupportInitialize)t2H8()).EndInit();
		((ISupportInitialize)f3JW()).EndInit();
		((ISupportInitialize)Bj9a()).EndInit();
		((ISupportInitialize)x1SC()).EndInit();
		((ISupportInitialize)m1DN()).EndInit();
		((ISupportInitialize)Pp96()).EndInit();
		((ISupportInitialize)j9E5()).EndInit();
		((ISupportInitialize)Ls45()).EndInit();
		((ISupportInitialize)a2N5()).EndInit();
		((ISupportInitialize)Eq4y()).EndInit();
		((ISupportInitialize)Cs27()).EndInit();
		((ISupportInitialize)Ao91()).EndInit();
		((ISupportInitialize)Hs05()).EndInit();
		((ISupportInitialize)j4A9()).EndInit();
		((ISupportInitialize)c6LQ()).EndInit();
		((ISupportInitialize)d4C6()).EndInit();
		((ISupportInitialize)r4TC()).EndInit();
		((ISupportInitialize)Qy23()).EndInit();
		((ISupportInitialize)r7J1()).EndInit();
		((ISupportInitialize)e9C2()).EndInit();
		((ISupportInitialize)Nm51()).EndInit();
		((ISupportInitialize)Ax9o()).EndInit();
		((ISupportInitialize)Tn91()).EndInit();
		((ISupportInitialize)e1GJ()).EndInit();
		((ISupportInitialize)Fn84()).EndInit();
		((ISupportInitialize)Zf7m()).EndInit();
		((ISupportInitialize)w5WY()).EndInit();
		((ISupportInitialize)y1P6()).EndInit();
		((ISupportInitialize)Qm38()).EndInit();
		((ISupportInitialize)Ss59()).EndInit();
		((ISupportInitialize)Lc16()).EndInit();
		((ISupportInitialize)n5LD()).EndInit();
		((ISupportInitialize)Hd5f()).EndInit();
		((ISupportInitialize)Zi2f()).EndInit();
		((ISupportInitialize)Lw78()).EndInit();
		((ISupportInitialize)Kb93()).EndInit();
		((ISupportInitialize)a1J2()).EndInit();
		((ISupportInitialize)Kb9r()).EndInit();
		((ISupportInitialize)f1K6()).EndInit();
		((ISupportInitialize)b1PY()).EndInit();
		((ISupportInitialize)Yr28()).EndInit();
		((ISupportInitialize)Ld98()).EndInit();
		((ISupportInitialize)j1F0()).EndInit();
		((ISupportInitialize)p1P6()).EndInit();
		((ISupportInitialize)Lx2j()).EndInit();
		((ISupportInitialize)Hi8g()).EndInit();
		((ISupportInitialize)Zp2c()).EndInit();
		((ISupportInitialize)c0PE()).EndInit();
		((ISupportInitialize)Gz23()).EndInit();
		((ISupportInitialize)z1JZ()).EndInit();
		((ISupportInitialize)m0RA()).EndInit();
		((ISupportInitialize)Sy67()).EndInit();
		((ISupportInitialize)At3b()).EndInit();
		((ISupportInitialize)Le04()).EndInit();
		((ISupportInitialize)w0WP()).EndInit();
		((ISupportInitialize)a5K8()).EndInit();
		((ISupportInitialize)Dy89()).EndInit();
		((ISupportInitialize)Rc1g()).EndInit();
		((ISupportInitialize)o1A2()).EndInit();
		((ISupportInitialize)z2R5()).EndInit();
		((ISupportInitialize)y4YA()).EndInit();
		((ISupportInitialize)Zt0z()).EndInit();
		((ISupportInitialize)Hs2m()).EndInit();
		((ISupportInitialize)Zz12()).EndInit();
		((ISupportInitialize)o6B1()).EndInit();
		((ISupportInitialize)o8LB()).EndInit();
		((ISupportInitialize)Zb25()).EndInit();
		((ISupportInitialize)o9PD()).EndInit();
		((ISupportInitialize)p5SW()).EndInit();
		((ISupportInitialize)w7EZ()).EndInit();
		((ISupportInitialize)g7K5()).EndInit();
		((ISupportInitialize)w6S4()).EndInit();
		((ISupportInitialize)r3KX()).EndInit();
		((ISupportInitialize)Ld39()).EndInit();
		((ISupportInitialize)y6X2()).EndInit();
		((ISupportInitialize)Sz01()).EndInit();
		((ISupportInitialize)d2RG()).EndInit();
		((ISupportInitialize)Pk09()).EndInit();
		((ISupportInitialize)Qs19()).EndInit();
		((ISupportInitialize)g9HY()).EndInit();
		((ISupportInitialize)p3RB()).EndInit();
		((ISupportInitialize)Fd5p()).EndInit();
		((ISupportInitialize)Xd57()).EndInit();
		((ISupportInitialize)y3J1()).EndInit();
		((ISupportInitialize)Fy1a()).EndInit();
		((ISupportInitialize)Ai06()).EndInit();
		((ISupportInitialize)Mg4d()).EndInit();
		((ISupportInitialize)Jb25()).EndInit();
		((ISupportInitialize)Zf64()).EndInit();
		((ISupportInitialize)w2L0()).EndInit();
		((ISupportInitialize)Wf1w()).EndInit();
		((ISupportInitialize)Rd10()).EndInit();
		((ISupportInitialize)i0NQ()).EndInit();
		((ISupportInitialize)j1S0()).EndInit();
		((ISupportInitialize)Wf8p()).EndInit();
		((ISupportInitialize)p6GP()).EndInit();
		((ISupportInitialize)Za9j()).EndInit();
		((ISupportInitialize)o3G0()).EndInit();
		((ISupportInitialize)p6X3()).EndInit();
		((ISupportInitialize)Kc4r()).EndInit();
		((ISupportInitialize)d4S0()).EndInit();
		((ISupportInitialize)Bt47()).EndInit();
		((ISupportInitialize)Ja90()).EndInit();
		((ISupportInitialize)Rb47()).EndInit();
		((ISupportInitialize)Kt9z()).EndInit();
		((ISupportInitialize)r0J3()).EndInit();
		((ISupportInitialize)Jt9s()).EndInit();
		((ISupportInitialize)Hi1s()).EndInit();
		((ISupportInitialize)Qo48()).EndInit();
		((ISupportInitialize)c4N1()).EndInit();
		((ISupportInitialize)St98()).EndInit();
		((ISupportInitialize)r7P1()).EndInit();
		((ISupportInitialize)j4DB()).EndInit();
		((ISupportInitialize)Kp56()).EndInit();
		((ISupportInitialize)Cx43()).EndInit();
		((ISupportInitialize)q7R0()).EndInit();
		((ISupportInitialize)x2Y3()).EndInit();
		((ISupportInitialize)Fm3r()).EndInit();
		((ISupportInitialize)t4Q9()).EndInit();
		((ISupportInitialize)Fx64()).EndInit();
		((ISupportInitialize)t5GT()).EndInit();
		((ISupportInitialize)y2RM()).EndInit();
		((ISupportInitialize)i1CL()).EndInit();
		((ISupportInitialize)a6X2()).EndInit();
		((ISupportInitialize)j6AP()).EndInit();
		((ISupportInitialize)Sz12()).EndInit();
		((ISupportInitialize)p2LK()).EndInit();
		((ISupportInitialize)Ne8c()).EndInit();
		((ISupportInitialize)Wd38()).EndInit();
		((ISupportInitialize)j9Y6()).EndInit();
		((ISupportInitialize)w9X0()).EndInit();
		((ISupportInitialize)Be8z()).EndInit();
		((ISupportInitialize)r1RQ()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox i5C()
	{
		return _NameBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn6(PictureBox e0G)
	{
		_NameBox = e0G;
	}

	[SpecialName]
	internal virtual PictureBox s2P()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm4(PictureBox o5L)
	{
		PictureBox val = (A = o5L);
	}

	[SpecialName]
	internal virtual Label Mp6()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7R(Label Xa4)
	{
		Label val = (y = Xa4);
	}

	[SpecialName]
	internal virtual GroupBox r4J()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5Q(GroupBox d1H)
	{
		_GroupBox1 = d1H;
	}

	[SpecialName]
	internal virtual GroupBox Mk2()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5W(GroupBox Te2)
	{
		GroupBox val = (C = Te2);
	}

	[SpecialName]
	internal virtual GroupBox g9F()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn9(GroupBox z7G)
	{
		GroupBox val = (S = z7G);
	}

	[SpecialName]
	internal virtual GroupBox d5K()
	{
		return _GroupBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9E(GroupBox w2C)
	{
		_GroupBox4 = w2C;
	}

	[SpecialName]
	internal virtual PictureBox Lr3()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0Q(PictureBox b8Y)
	{
		_Cover = b8Y;
	}

	[SpecialName]
	internal virtual TextBox Jc3()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cg8(TextBox d2F)
	{
		_txtProvisional = d2F;
	}

	[SpecialName]
	internal virtual TextBox e0Q()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0C(TextBox m7N)
	{
		TextBox val = (d = m7N);
	}

	[SpecialName]
	internal virtual TextBox Bj9()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb3(TextBox c6P)
	{
		TextBox val = (O = c6P);
	}

	[SpecialName]
	internal virtual PictureBox w3N()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3N(PictureBox i5G)
	{
		PictureBox val = (Q = i5G);
	}

	[SpecialName]
	internal virtual PictureBox e0F()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s9E(PictureBox a0W)
	{
		PictureBox val = (E = a0W);
	}

	[SpecialName]
	internal virtual PictureBox o2Z()
	{
		return _Available;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qa2(PictureBox Fy3)
	{
		_Available = Fy3;
	}

	[SpecialName]
	internal virtual Label Ze8()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xa4(Label Sp1)
	{
		Label val = (W = Sp1);
	}

	[SpecialName]
	internal virtual Label Wb9()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2N(Label At1)
	{
		Label val = (p = At1);
	}

	[SpecialName]
	internal virtual Label Bp8()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3B(Label Re8)
	{
		Label val = (B = Re8);
	}

	[SpecialName]
	internal virtual Label r8E()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lx8(Label Xc2)
	{
		_Label4 = Xc2;
	}

	[SpecialName]
	internal virtual Label f8G()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gn6(Label z7Y)
	{
		_Label5 = z7Y;
	}

	[SpecialName]
	internal virtual Label Wi5()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4C(Label n5Z)
	{
		Label val = (u = n5Z);
	}

	[SpecialName]
	internal virtual Label p9P()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fd7(Label Eb2)
	{
		Label val = (X = Eb2);
	}

	[SpecialName]
	internal virtual Label i0B()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw1(Label Js9)
	{
		_Label9 = Js9;
	}

	[SpecialName]
	internal virtual Label m2R()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4J(Label n9C)
	{
		_Label10 = n9C;
	}

	[SpecialName]
	internal virtual Label Dq9()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3D(Label w2P)
	{
		_Label11 = w2P;
	}

	[SpecialName]
	internal virtual Label Ls3()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1H(Label j6T)
	{
		Label val = (G = j6T);
	}

	[SpecialName]
	internal virtual Label i0D()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq4(Label a6W)
	{
		_Label13 = a6W;
	}

	[SpecialName]
	internal virtual Label Xg0()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc1(Label o6F)
	{
		_Label14 = o6F;
	}

	[SpecialName]
	internal virtual Label c3F()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1E(Label n1E)
	{
		_Label15 = n1E;
	}

	[SpecialName]
	internal virtual Label Sc9()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6D(Label z0R)
	{
		Label val = (V = z0R);
	}

	[SpecialName]
	internal virtual Label d3Z()
	{
		return _Label17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kx0(Label e4M)
	{
		_Label17 = e4M;
	}

	[SpecialName]
	internal virtual Label o4Y()
	{
		return _Label18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw0(Label p2M)
	{
		_Label18 = p2M;
	}

	[SpecialName]
	internal virtual Label e0K()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1E(Label Xf7)
	{
		_Label19 = Xf7;
	}

	[SpecialName]
	internal virtual Label k0G()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf0(Label b3W)
	{
		Label val = (t = b3W);
	}

	[SpecialName]
	internal virtual Label Wm4()
	{
		return _Label22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2N(Label Mo5)
	{
		_Label22 = Mo5;
	}

	[SpecialName]
	internal virtual Label q4Q()
	{
		return _Label23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3A(Label Wn7)
	{
		_Label23 = Wn7;
	}

	[SpecialName]
	internal virtual Label Mq5()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7F(Label Em1)
	{
		Label val = (I = Em1);
	}

	[SpecialName]
	internal virtual Label c3C()
	{
		return _Label26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yr5(Label Eq7)
	{
		_Label26 = Eq7;
	}

	[SpecialName]
	internal virtual Label e8S()
	{
		return _Label27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fb9(Label m5Y)
	{
		_Label27 = m5Y;
	}

	[SpecialName]
	internal virtual Label k3K()
	{
		return _Label28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0Y(Label w1P)
	{
		_Label28 = w1P;
	}

	[SpecialName]
	internal virtual Label d1L()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wf8(Label Az7)
	{
		Label val = (K = Az7);
	}

	[SpecialName]
	internal virtual Label Gi2()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb8(Label w8F)
	{
		Label val = (j = w8F);
	}

	[SpecialName]
	internal virtual Label Ed5()
	{
		return _Label31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jf1(Label Pq4)
	{
		_Label31 = Pq4;
	}

	[SpecialName]
	internal virtual Label Px0()
	{
		return _Label54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed0(Label Ai1)
	{
		_Label54 = Ai1;
	}

	[SpecialName]
	internal virtual Label k9H()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3K(Label w4M)
	{
		_Label55 = w4M;
	}

	[SpecialName]
	internal virtual Label i7R()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At3(Label Qw0)
	{
		Label val = (r = Qw0);
	}

	[SpecialName]
	internal virtual TextBox k0W()
	{
		return _txtFirstName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2J(TextBox f2L)
	{
		_txtFirstName = f2L;
	}

	[SpecialName]
	internal virtual TextBox Pn7()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tc7(TextBox Ct0)
	{
		TextBox val = (N = Ct0);
	}

	[SpecialName]
	internal virtual Label y7K()
	{
		return _Label60;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8D(Label c3Y)
	{
		_Label60 = c3Y;
	}

	[SpecialName]
	internal virtual Label s6W()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2G(Label j9M)
	{
		Label val = (m = j9M);
	}

	[SpecialName]
	internal virtual TextBox j3D()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy9(TextBox Tx8)
	{
		TextBox val = (h = Tx8);
	}

	[SpecialName]
	internal virtual TextBox Pa7()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Br9(TextBox Ed3)
	{
		TextBox val = (f = Ed3);
	}

	[SpecialName]
	internal virtual TextBox Lc1()
	{
		return _txtTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kq8(TextBox Lq8)
	{
		_txtTotalCost = Lq8;
	}

	[SpecialName]
	internal virtual TextBox At7()
	{
		return _txtSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5Y(TextBox t9X)
	{
		_txtSeats = t9X;
	}

	[SpecialName]
	internal virtual Label q1K()
	{
		return _Label63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tq4(Label m6J)
	{
		_Label63 = m6J;
	}

	[SpecialName]
	internal virtual Label b9Q()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc1(Label Yp8)
	{
		Label val = (l = Yp8);
	}

	[SpecialName]
	internal virtual Label y4Q()
	{
		return _Label61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1A(Label Yy4)
	{
		_Label61 = Yy4;
	}

	[SpecialName]
	internal virtual Label Mr6()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nd2(Label Xg4)
	{
		Label val = (z = Xg4);
	}

	[SpecialName]
	internal virtual Label m0N()
	{
		return yA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5N(Label Yx8)
	{
		Label val = (yA = Yx8);
	}

	[SpecialName]
	internal virtual Label q4Y()
	{
		return yy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ld6(Label t3D)
	{
		Label val = (yy = t3D);
	}

	[SpecialName]
	internal virtual PictureBox a1Q()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz7(PictureBox q6N)
	{
		_PictureBox1 = q6N;
	}

	[SpecialName]
	internal virtual PictureBox a7P()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Li4(PictureBox k9K)
	{
		_PictureBox2 = k9K;
	}

	[SpecialName]
	internal virtual PictureBox Xb7()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3F(PictureBox Gq3)
	{
		_PictureBox3 = Gq3;
	}

	[SpecialName]
	internal virtual PictureBox e5H()
	{
		return yC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4N(PictureBox m7T)
	{
		PictureBox val = (yC = m7T);
	}

	[SpecialName]
	internal virtual PictureBox Fj9()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq7(PictureBox Qf8)
	{
		_PictureBox5 = Qf8;
	}

	[SpecialName]
	internal virtual PictureBox o1M()
	{
		return yS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0W(PictureBox Lg9)
	{
		PictureBox val = (yS = Lg9);
	}

	[SpecialName]
	internal virtual PictureBox n7K()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wt3(PictureBox Yq8)
	{
		_PictureBox7 = Yq8;
	}

	[SpecialName]
	internal virtual PictureBox Qz7()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mr7(PictureBox y1Q)
	{
		_PictureBox8 = y1Q;
	}

	[SpecialName]
	internal virtual PictureBox Go3()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ma6(PictureBox Gb9)
	{
		_PictureBox9 = Gb9;
	}

	[SpecialName]
	internal virtual PictureBox n6S()
	{
		return yd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sj9(PictureBox b5F)
	{
		PictureBox val = (yd = b5F);
	}

	[SpecialName]
	internal virtual PictureBox x9T()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1S(PictureBox w0Q)
	{
		_PictureBox11 = w0Q;
	}

	[SpecialName]
	internal virtual PictureBox Lf2()
	{
		return yO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3J(PictureBox Rp7)
	{
		PictureBox val = (yO = Rp7);
	}

	[SpecialName]
	internal virtual PictureBox x7T()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pe8(PictureBox Cr6)
	{
		_PictureBox13 = Cr6;
	}

	[SpecialName]
	internal virtual PictureBox t9W()
	{
		return yQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb7(PictureBox Yg1)
	{
		PictureBox val = (yQ = Yg1);
	}

	[SpecialName]
	internal virtual PictureBox Sq0()
	{
		return yE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qd5(PictureBox z3G)
	{
		PictureBox val = (yE = z3G);
	}

	[SpecialName]
	internal virtual PictureBox Xo7()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bw2o(PictureBox w9B0)
	{
		_PictureBox16 = w9B0;
	}

	[SpecialName]
	internal virtual PictureBox r3W4()
	{
		return yW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rc78(PictureBox d0X1)
	{
		PictureBox val = (yW = d0X1);
	}

	[SpecialName]
	internal virtual PictureBox y8S9()
	{
		return yp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void We9o(PictureBox c7Q4)
	{
		PictureBox val = (yp = c7Q4);
	}

	[SpecialName]
	internal virtual PictureBox Kb3i()
	{
		return yB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq49(PictureBox Qy05)
	{
		PictureBox val = (yB = Qy05);
	}

	[SpecialName]
	internal virtual PictureBox d3Y4()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6KB(PictureBox z5C2)
	{
		_PictureBox20 = z5C2;
	}

	[SpecialName]
	internal virtual PictureBox Ya6x()
	{
		return yu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le8a(PictureBox a6S1)
	{
		PictureBox val = (yu = a6S1);
	}

	[SpecialName]
	internal virtual PictureBox g1ST()
	{
		return yX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Er1s(PictureBox k3HM)
	{
		PictureBox val = (yX = k3HM);
	}

	[SpecialName]
	internal virtual PictureBox Qa80()
	{
		return yG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp4e(PictureBox f3M2)
	{
		PictureBox val = (yG = f3M2);
	}

	[SpecialName]
	internal virtual PictureBox Nd4m()
	{
		return _PictureBox24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6Q9(PictureBox r7XE)
	{
		_PictureBox24 = r7XE;
	}

	[SpecialName]
	internal virtual PictureBox Sq3o()
	{
		return yV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj0a(PictureBox Pi56)
	{
		PictureBox val = (yV = Pi56);
	}

	[SpecialName]
	internal virtual PictureBox d2M6()
	{
		return _PictureBox26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9CM(PictureBox Ak6s)
	{
		_PictureBox26 = Ak6s;
	}

	[SpecialName]
	internal virtual PictureBox Ni8p()
	{
		return yt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw03(PictureBox s0XM)
	{
		PictureBox val = (yt = s0XM);
	}

	[SpecialName]
	internal virtual PictureBox t2H8()
	{
		return _PictureBox28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0XG(PictureBox Ex58)
	{
		_PictureBox28 = Ex58;
	}

	[SpecialName]
	internal virtual PictureBox f3JW()
	{
		return yI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gb73(PictureBox Ad34)
	{
		PictureBox val = (yI = Ad34);
	}

	[SpecialName]
	internal virtual PictureBox Bj9a()
	{
		return yK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2W7(PictureBox z8T4)
	{
		PictureBox val = (yK = z8T4);
	}

	[SpecialName]
	internal virtual PictureBox x1SC()
	{
		return _PictureBox31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Co0m(PictureBox b5XA)
	{
		_PictureBox31 = b5XA;
	}

	[SpecialName]
	internal virtual PictureBox m1DN()
	{
		return yj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jq21(PictureBox m6W9)
	{
		PictureBox val = (yj = m6W9);
	}

	[SpecialName]
	internal virtual PictureBox Pp96()
	{
		return _PictureBox33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3H4(PictureBox z5T3)
	{
		_PictureBox33 = z5T3;
	}

	[SpecialName]
	internal virtual PictureBox j9E5()
	{
		return yr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Td79(PictureBox b2HB)
	{
		PictureBox val = (yr = b2HB);
	}

	[SpecialName]
	internal virtual PictureBox Ls45()
	{
		return _PictureBox35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5W0(PictureBox o2S6)
	{
		_PictureBox35 = o2S6;
	}

	[SpecialName]
	internal virtual PictureBox a2N5()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hz8e(PictureBox Gs2n)
	{
		_PictureBox36 = Gs2n;
	}

	[SpecialName]
	internal virtual PictureBox Eq4y()
	{
		return yN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp3i(PictureBox b9M5)
	{
		PictureBox val = (yN = b9M5);
	}

	[SpecialName]
	internal virtual PictureBox Cs27()
	{
		return _PictureBox38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk81(PictureBox a4A7)
	{
		_PictureBox38 = a4A7;
	}

	[SpecialName]
	internal virtual PictureBox Ao91()
	{
		return _PictureBox39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8TN(PictureBox Lx97)
	{
		_PictureBox39 = Lx97;
	}

	[SpecialName]
	internal virtual PictureBox Hs05()
	{
		return _PictureBox40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void My46(PictureBox i2SX)
	{
		_PictureBox40 = i2SX;
	}

	[SpecialName]
	internal virtual Label x0L1()
	{
		return _Label32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dt4s(Label Az07)
	{
		_Label32 = Az07;
	}

	[SpecialName]
	internal virtual Label Jx4w()
	{
		return _Label33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3N0(Label Mn5j)
	{
		_Label33 = Mn5j;
	}

	[SpecialName]
	internal virtual Label Qi73()
	{
		return _Label34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2P5(Label Xw27)
	{
		_Label34 = Xw27;
	}

	[SpecialName]
	internal virtual Label Rp8k()
	{
		return ym;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lz4k(Label Nb2x)
	{
		Label val = (ym = Nb2x);
	}

	[SpecialName]
	internal virtual Label e8YG()
	{
		return _Label36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk08(Label q8AD)
	{
		_Label36 = q8AD;
	}

	[SpecialName]
	internal virtual Label Jz5d()
	{
		return yh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6PX(Label b6FD)
	{
		Label val = (yh = b6FD);
	}

	[SpecialName]
	internal virtual Label Lp20()
	{
		return _Label38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz65(Label Fs50)
	{
		_Label38 = Fs50;
	}

	[SpecialName]
	internal virtual Label Qm60()
	{
		return yf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg8s(Label Xe41)
	{
		Label val = (yf = Xe41);
	}

	[SpecialName]
	internal virtual Label q5M9()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq9r(Label Ym64)
	{
		_Label40 = Ym64;
	}

	[SpecialName]
	internal virtual Label Rp1o()
	{
		return _Label41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ni8n(Label j3D2)
	{
		_Label41 = j3D2;
	}

	[SpecialName]
	internal virtual Label c2GS()
	{
		return yl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5G4(Label Wj84)
	{
		Label val = (yl = Wj84);
	}

	[SpecialName]
	internal virtual Label p1T2()
	{
		return yz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0T4(Label Bk85)
	{
		Label val = (yz = Bk85);
	}

	[SpecialName]
	internal virtual Label s3ET()
	{
		return CA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz18(Label Kk78)
	{
		Label val = (CA = Kk78);
	}

	[SpecialName]
	internal virtual Label m1G8()
	{
		return _Label45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cf64(Label Ar1i)
	{
		_Label45 = Ar1i;
	}

	[SpecialName]
	internal virtual Label k2C1()
	{
		return _Label46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Js7w(Label Ta90)
	{
		_Label46 = Ta90;
	}

	[SpecialName]
	internal virtual Label Mf8j()
	{
		return Cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1X4(Label a7GA)
	{
		Label val = (Cy = a7GA);
	}

	[SpecialName]
	internal virtual Label t6PG()
	{
		return _Label48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ek1o(Label Sg8c)
	{
		_Label48 = Sg8c;
	}

	[SpecialName]
	internal virtual Label b5ZB()
	{
		return CC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1Y5(Label Yx73)
	{
		Label val = (CC = Yx73);
	}

	[SpecialName]
	internal virtual Label s7ES()
	{
		return CS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0A6(Label r7ES)
	{
		Label val = (CS = r7ES);
	}

	[SpecialName]
	internal virtual Label Ax1t()
	{
		return Cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5PA(Label t7N5)
	{
		Label val = (Cd = t7N5);
	}

	[SpecialName]
	internal virtual PictureBox j4A9()
	{
		return CO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1Q9(PictureBox b2LY)
	{
		PictureBox val = (CO = b2LY);
	}

	[SpecialName]
	internal virtual PictureBox c6LQ()
	{
		return _PictureBox42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6QZ(PictureBox f3W9)
	{
		_PictureBox42 = f3W9;
	}

	[SpecialName]
	internal virtual PictureBox d4C6()
	{
		return _PictureBox43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6XK(PictureBox Rb4d)
	{
		_PictureBox43 = Rb4d;
	}

	[SpecialName]
	internal virtual PictureBox r4TC()
	{
		return _PictureBox44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6PW(PictureBox t6X4)
	{
		_PictureBox44 = t6X4;
	}

	[SpecialName]
	internal virtual PictureBox Qy23()
	{
		return _PictureBox45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3PT(PictureBox z7T8)
	{
		_PictureBox45 = z7T8;
	}

	[SpecialName]
	internal virtual PictureBox r7J1()
	{
		return CQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xq79(PictureBox a5Q8)
	{
		PictureBox val = (CQ = a5Q8);
	}

	[SpecialName]
	internal virtual PictureBox e9C2()
	{
		return _PictureBox47;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ae61(PictureBox g2WM)
	{
		_PictureBox47 = g2WM;
	}

	[SpecialName]
	internal virtual PictureBox Nm51()
	{
		return CE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5DJ(PictureBox d1A3)
	{
		PictureBox val = (CE = d1A3);
	}

	[SpecialName]
	internal virtual PictureBox Ax9o()
	{
		return _PictureBox49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8Q6(PictureBox Md72)
	{
		_PictureBox49 = Md72;
	}

	[SpecialName]
	internal virtual PictureBox Tn91()
	{
		return _PictureBox50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4Y7(PictureBox g2E3)
	{
		_PictureBox50 = g2E3;
	}

	[SpecialName]
	internal virtual PictureBox e1GJ()
	{
		return _PictureBox51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6FH(PictureBox e8L6)
	{
		_PictureBox51 = e8L6;
	}

	[SpecialName]
	internal virtual PictureBox Fn84()
	{
		return _PictureBox52;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ba9z(PictureBox Af0s)
	{
		_PictureBox52 = Af0s;
	}

	[SpecialName]
	internal virtual PictureBox Zf7m()
	{
		return _PictureBox53;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp9g(PictureBox i0Z6)
	{
		_PictureBox53 = i0Z6;
	}

	[SpecialName]
	internal virtual PictureBox w5WY()
	{
		return _PictureBox54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1WJ(PictureBox n0T8)
	{
		_PictureBox54 = n0T8;
	}

	[SpecialName]
	internal virtual PictureBox y1P6()
	{
		return _PictureBox55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo7y(PictureBox Pe2m)
	{
		_PictureBox55 = Pe2m;
	}

	[SpecialName]
	internal virtual PictureBox Qm38()
	{
		return CW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2XB(PictureBox e0WZ)
	{
		PictureBox val = (CW = e0WZ);
	}

	[SpecialName]
	internal virtual PictureBox Ss59()
	{
		return _PictureBox57;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lz2a(PictureBox t9K6)
	{
		_PictureBox57 = t9K6;
	}

	[SpecialName]
	internal virtual PictureBox Lc16()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Km93(PictureBox Dx76)
	{
		_PictureBox58 = Dx76;
	}

	[SpecialName]
	internal virtual PictureBox n5LD()
	{
		return Cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf2x(PictureBox g5KC)
	{
		PictureBox val = (Cp = g5KC);
	}

	[SpecialName]
	internal virtual PictureBox Hd5f()
	{
		return CB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc5y(PictureBox e8XZ)
	{
		PictureBox val = (CB = e8XZ);
	}

	[SpecialName]
	internal virtual PictureBox Zi2f()
	{
		return _PictureBox61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4J9(PictureBox p7RA)
	{
		_PictureBox61 = p7RA;
	}

	[SpecialName]
	internal virtual PictureBox Lw78()
	{
		return _PictureBox62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd6z(PictureBox Bb52)
	{
		_PictureBox62 = Bb52;
	}

	[SpecialName]
	internal virtual PictureBox Kb93()
	{
		return Cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5R3(PictureBox p0C9)
	{
		PictureBox val = (Cu = p0C9);
	}

	[SpecialName]
	internal virtual PictureBox a1J2()
	{
		return CX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4MW(PictureBox p2ZJ)
	{
		PictureBox val = (CX = p2ZJ);
	}

	[SpecialName]
	internal virtual PictureBox Kb9r()
	{
		return CG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb79(PictureBox r5N6)
	{
		PictureBox val = (CG = r5N6);
	}

	[SpecialName]
	internal virtual PictureBox f1K6()
	{
		return CV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn1t(PictureBox Py02)
	{
		PictureBox val = (CV = Py02);
	}

	[SpecialName]
	internal virtual PictureBox b1PY()
	{
		return Ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3M0(PictureBox b9NR)
	{
		PictureBox val = (Ct = b9NR);
	}

	[SpecialName]
	internal virtual PictureBox Yr28()
	{
		return CI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5K4(PictureBox Gs58)
	{
		PictureBox val = (CI = Gs58);
	}

	[SpecialName]
	internal virtual PictureBox Ld98()
	{
		return _PictureBox69;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4BG(PictureBox x0Q4)
	{
		_PictureBox69 = x0Q4;
	}

	[SpecialName]
	internal virtual PictureBox j1F0()
	{
		return CK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ww5q(PictureBox o2C6)
	{
		PictureBox val = (CK = o2C6);
	}

	[SpecialName]
	internal virtual PictureBox p1P6()
	{
		return Cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3J9(PictureBox Zf5w)
	{
		PictureBox val = (Cj = Zf5w);
	}

	[SpecialName]
	internal virtual PictureBox Lx2j()
	{
		return Cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2FT(PictureBox Bj59)
	{
		PictureBox val = (Cr = Bj59);
	}

	[SpecialName]
	internal virtual PictureBox Hi8g()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6H2(PictureBox Jt4j)
	{
		_PictureBox73 = Jt4j;
	}

	[SpecialName]
	internal virtual PictureBox Zp2c()
	{
		return CN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rq4x(PictureBox w3G2)
	{
		PictureBox val = (CN = w3G2);
	}

	[SpecialName]
	internal virtual PictureBox c0PE()
	{
		return _PictureBox75;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7H5(PictureBox Pj50)
	{
		_PictureBox75 = Pj50;
	}

	[SpecialName]
	internal virtual PictureBox Gz23()
	{
		return _PictureBox76;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5Y3(PictureBox b6Y4)
	{
		_PictureBox76 = b6Y4;
	}

	[SpecialName]
	internal virtual PictureBox z1JZ()
	{
		return Cm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hy86(PictureBox Lx3p)
	{
		PictureBox val = (Cm = Lx3p);
	}

	[SpecialName]
	internal virtual PictureBox m0RA()
	{
		return _PictureBox78;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0ZB(PictureBox a7H1)
	{
		_PictureBox78 = a7H1;
	}

	[SpecialName]
	internal virtual PictureBox Sy67()
	{
		return _PictureBox79;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf6i(PictureBox b0E1)
	{
		_PictureBox79 = b0E1;
	}

	[SpecialName]
	internal virtual PictureBox At3b()
	{
		return Ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo25(PictureBox b8D7)
	{
		PictureBox val = (Ch = b8D7);
	}

	[SpecialName]
	internal virtual PictureBox Le04()
	{
		return Cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps3o(PictureBox k0BJ)
	{
		PictureBox val = (Cf = k0BJ);
	}

	[SpecialName]
	internal virtual PictureBox w0WP()
	{
		return _PictureBox82;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4T5(PictureBox Wn4a)
	{
		_PictureBox82 = Wn4a;
	}

	[SpecialName]
	internal virtual PictureBox a5K8()
	{
		return _PictureBox83;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa96(PictureBox c7E9)
	{
		_PictureBox83 = c7E9;
	}

	[SpecialName]
	internal virtual PictureBox Dy89()
	{
		return Cl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9Z1(PictureBox j5ZD)
	{
		PictureBox val = (Cl = j5ZD);
	}

	[SpecialName]
	internal virtual PictureBox Rc1g()
	{
		return Cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1Z5(PictureBox r3P9)
	{
		PictureBox val = (Cz = r3P9);
	}

	[SpecialName]
	internal virtual PictureBox o1A2()
	{
		return SA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cy7g(PictureBox j6Q3)
	{
		PictureBox val = (SA = j6Q3);
	}

	[SpecialName]
	internal virtual PictureBox z2R5()
	{
		return _PictureBox87;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kq94(PictureBox q6J4)
	{
		_PictureBox87 = q6J4;
	}

	[SpecialName]
	internal virtual PictureBox y4YA()
	{
		return Sy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2MC(PictureBox a6LJ)
	{
		PictureBox val = (Sy = a6LJ);
	}

	[SpecialName]
	internal virtual PictureBox Zt0z()
	{
		return _PictureBox89;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3R4(PictureBox Qo53)
	{
		_PictureBox89 = Qo53;
	}

	[SpecialName]
	internal virtual PictureBox Hs2m()
	{
		return SC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp1e(PictureBox Yd8q)
	{
		PictureBox val = (SC = Yd8q);
	}

	[SpecialName]
	internal virtual PictureBox Zz12()
	{
		return _PictureBox91;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8CG(PictureBox Qc65)
	{
		_PictureBox91 = Qc65;
	}

	[SpecialName]
	internal virtual PictureBox o6B1()
	{
		return _PictureBox92;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dq1r(PictureBox z7TK)
	{
		_PictureBox92 = z7TK;
	}

	[SpecialName]
	internal virtual PictureBox o8LB()
	{
		return SS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz49(PictureBox q5F2)
	{
		PictureBox val = (SS = q5F2);
	}

	[SpecialName]
	internal virtual PictureBox Zb25()
	{
		return _PictureBox94;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec50(PictureBox Fc35)
	{
		_PictureBox94 = Fc35;
	}

	[SpecialName]
	internal virtual PictureBox o9PD()
	{
		return _PictureBox95;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bi57(PictureBox Wg42)
	{
		_PictureBox95 = Wg42;
	}

	[SpecialName]
	internal virtual PictureBox p5SW()
	{
		return Sd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Re5i(PictureBox g9J5)
	{
		PictureBox val = (Sd = g9J5);
	}

	[SpecialName]
	internal virtual PictureBox w7EZ()
	{
		return _PictureBox97;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8FM(PictureBox Aq92)
	{
		_PictureBox97 = Aq92;
	}

	[SpecialName]
	internal virtual PictureBox g7K5()
	{
		return SO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz4t(PictureBox e1QY)
	{
		PictureBox val = (SO = e1QY);
	}

	[SpecialName]
	internal virtual PictureBox w6S4()
	{
		return _PictureBox99;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1B0(PictureBox Zg97)
	{
		_PictureBox99 = Zg97;
	}

	[SpecialName]
	internal virtual PictureBox r3KX()
	{
		return SQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1QC(PictureBox Kx15)
	{
		PictureBox val = (SQ = Kx15);
	}

	[SpecialName]
	internal virtual PictureBox Ld39()
	{
		return SE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4D3(PictureBox m5HR)
	{
		PictureBox val = (SE = m5HR);
	}

	[SpecialName]
	internal virtual PictureBox y6X2()
	{
		return SW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gd5z(PictureBox o5EP)
	{
		PictureBox val = (SW = o5EP);
	}

	[SpecialName]
	internal virtual PictureBox Sz01()
	{
		return Sp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ws1w(PictureBox Zc6p)
	{
		PictureBox val = (Sp = Zc6p);
	}

	[SpecialName]
	internal virtual PictureBox d2RG()
	{
		return SB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hw84(PictureBox Lf3y)
	{
		PictureBox val = (SB = Lf3y);
	}

	[SpecialName]
	internal virtual PictureBox Pk09()
	{
		return Su;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fw59(PictureBox o3X1)
	{
		PictureBox val = (Su = o3X1);
	}

	[SpecialName]
	internal virtual PictureBox Qs19()
	{
		return _PictureBox106;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga1i(PictureBox Jk9f)
	{
		_PictureBox106 = Jk9f;
	}

	[SpecialName]
	internal virtual PictureBox g9HY()
	{
		return _PictureBox107;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Er24(PictureBox x1K3)
	{
		_PictureBox107 = x1K3;
	}

	[SpecialName]
	internal virtual PictureBox p3RB()
	{
		return SX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw7o(PictureBox e3P9)
	{
		PictureBox val = (SX = e3P9);
	}

	[SpecialName]
	internal virtual PictureBox Fd5p()
	{
		return SG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pj8k(PictureBox i3H9)
	{
		PictureBox val = (SG = i3H9);
	}

	[SpecialName]
	internal virtual PictureBox Xd57()
	{
		return SV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4ZT(PictureBox m4EW)
	{
		PictureBox val = (SV = m4EW);
	}

	[SpecialName]
	internal virtual PictureBox y3J1()
	{
		return St;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc8b(PictureBox r8W0)
	{
		PictureBox val = (St = r8W0);
	}

	[SpecialName]
	internal virtual PictureBox Fy1a()
	{
		return SI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jq94(PictureBox Qk2f)
	{
		PictureBox val = (SI = Qk2f);
	}

	[SpecialName]
	internal virtual PictureBox Ai06()
	{
		return SK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ap17(PictureBox Pj4t)
	{
		PictureBox val = (SK = Pj4t);
	}

	[SpecialName]
	internal virtual PictureBox Mg4d()
	{
		return Sj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2Y5(PictureBox m0AK)
	{
		PictureBox val = (Sj = m0AK);
	}

	[SpecialName]
	internal virtual PictureBox Jb25()
	{
		return _PictureBox115;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz28(PictureBox Sj04)
	{
		_PictureBox115 = Sj04;
	}

	[SpecialName]
	internal virtual PictureBox Zf64()
	{
		return _PictureBox116;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn3q(PictureBox o4RH)
	{
		_PictureBox116 = o4RH;
	}

	[SpecialName]
	internal virtual PictureBox w2L0()
	{
		return _PictureBox117;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9D4(PictureBox i9TA)
	{
		_PictureBox117 = i9TA;
	}

	[SpecialName]
	internal virtual PictureBox Wf1w()
	{
		return _PictureBox118;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2F3(PictureBox My69)
	{
		_PictureBox118 = My69;
	}

	[SpecialName]
	internal virtual PictureBox Rd10()
	{
		return Sr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xe50(PictureBox Cn59)
	{
		PictureBox val = (Sr = Cn59);
	}

	[SpecialName]
	internal virtual PictureBox i0NQ()
	{
		return _PictureBox120;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq43(PictureBox i7EB)
	{
		_PictureBox120 = i7EB;
	}

	[SpecialName]
	internal virtual PictureBox j1S0()
	{
		return SN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt41(PictureBox Pn3s)
	{
		PictureBox val = (SN = Pn3s);
	}

	[SpecialName]
	internal virtual PictureBox Wf8p()
	{
		return _PictureBox122;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jq0m(PictureBox r5QM)
	{
		_PictureBox122 = r5QM;
	}

	[SpecialName]
	internal virtual PictureBox p6GP()
	{
		return Sm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1Y9(PictureBox k1J7)
	{
		PictureBox val = (Sm = k1J7);
	}

	[SpecialName]
	internal virtual PictureBox Za9j()
	{
		return Sh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xx7r(PictureBox w9L7)
	{
		PictureBox val = (Sh = w9L7);
	}

	[SpecialName]
	internal virtual PictureBox o3G0()
	{
		return _PictureBox125;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk31(PictureBox At70)
	{
		_PictureBox125 = At70;
	}

	[SpecialName]
	internal virtual PictureBox p6X3()
	{
		return Sf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ai29(PictureBox q7R9)
	{
		PictureBox val = (Sf = q7R9);
	}

	[SpecialName]
	internal virtual PictureBox Kc4r()
	{
		return _PictureBox127;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7GC(PictureBox Nt32)
	{
		_PictureBox127 = Nt32;
	}

	[SpecialName]
	internal virtual PictureBox d4S0()
	{
		return _PictureBox128;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rj0r(PictureBox Sd1p)
	{
		_PictureBox128 = Sd1p;
	}

	[SpecialName]
	internal virtual PictureBox Bt47()
	{
		return _PictureBox129;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7N1(PictureBox Tz52)
	{
		_PictureBox129 = Tz52;
	}

	[SpecialName]
	internal virtual PictureBox Ja90()
	{
		return Sl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9RT(PictureBox x3S9)
	{
		PictureBox val = (Sl = x3S9);
	}

	[SpecialName]
	internal virtual PictureBox Rb47()
	{
		return _PictureBox131;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm6s(PictureBox Ed86)
	{
		_PictureBox131 = Ed86;
	}

	[SpecialName]
	internal virtual PictureBox Kt9z()
	{
		return _PictureBox132;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8ET(PictureBox a2RD)
	{
		_PictureBox132 = a2RD;
	}

	[SpecialName]
	internal virtual PictureBox r0J3()
	{
		return _PictureBox133;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2Z6(PictureBox Js46)
	{
		_PictureBox133 = Js46;
	}

	[SpecialName]
	internal virtual PictureBox Jt9s()
	{
		return Sz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9F0(PictureBox Jw61)
	{
		PictureBox val = (Sz = Jw61);
	}

	[SpecialName]
	internal virtual PictureBox Hi1s()
	{
		return _PictureBox135;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn19(PictureBox o3BN)
	{
		_PictureBox135 = o3BN;
	}

	[SpecialName]
	internal virtual PictureBox Qo48()
	{
		return dA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki6s(PictureBox Hf76)
	{
		PictureBox val = (dA = Hf76);
	}

	[SpecialName]
	internal virtual PictureBox c4N1()
	{
		return dy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1SB(PictureBox y3T2)
	{
		PictureBox val = (dy = y3T2);
	}

	[SpecialName]
	internal virtual PictureBox St98()
	{
		return _PictureBox138;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dc47(PictureBox e1D2)
	{
		_PictureBox138 = e1D2;
	}

	[SpecialName]
	internal virtual PictureBox r7P1()
	{
		return _PictureBox139;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8E1(PictureBox d7B5)
	{
		_PictureBox139 = d7B5;
	}

	[SpecialName]
	internal virtual PictureBox j4DB()
	{
		return _PictureBox140;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7WA(PictureBox p3ZQ)
	{
		_PictureBox140 = p3ZQ;
	}

	[SpecialName]
	internal virtual PictureBox Kp56()
	{
		return _PictureBox141;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4N8(PictureBox Tr29)
	{
		_PictureBox141 = Tr29;
	}

	[SpecialName]
	internal virtual PictureBox Cx43()
	{
		return _PictureBox142;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5A7(PictureBox d6AP)
	{
		_PictureBox142 = d6AP;
	}

	[SpecialName]
	internal virtual PictureBox q7R0()
	{
		return dC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5WR(PictureBox Pk7y)
	{
		PictureBox val = (dC = Pk7y);
	}

	[SpecialName]
	internal virtual PictureBox x2Y3()
	{
		return dS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra3x(PictureBox z1NE)
	{
		PictureBox val = (dS = z1NE);
	}

	[SpecialName]
	internal virtual PictureBox Fm3r()
	{
		return dd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8ZF(PictureBox o8KX)
	{
		PictureBox val = (dd = o8KX);
	}

	[SpecialName]
	internal virtual PictureBox t4Q9()
	{
		return dO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3TY(PictureBox De01)
	{
		PictureBox val = (dO = De01);
	}

	[SpecialName]
	internal virtual PictureBox Fx64()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9Z5(PictureBox Jo79)
	{
		_PictureBox147 = Jo79;
	}

	[SpecialName]
	internal virtual PictureBox t5GT()
	{
		return dQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp73(PictureBox y2N3)
	{
		PictureBox val = (dQ = y2N3);
	}

	[SpecialName]
	internal virtual PictureBox y2RM()
	{
		return dE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wq5x(PictureBox Ym50)
	{
		PictureBox val = (dE = Ym50);
	}

	[SpecialName]
	internal virtual PictureBox i1CL()
	{
		return _PictureBox150;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb4c(PictureBox e9PA)
	{
		_PictureBox150 = e9PA;
	}

	[SpecialName]
	internal virtual PictureBox a6X2()
	{
		return _PictureBox151;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Na8b(PictureBox m3LX)
	{
		_PictureBox151 = m3LX;
	}

	[SpecialName]
	internal virtual PictureBox j6AP()
	{
		return dW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0LY(PictureBox w4DW)
	{
		PictureBox val = (dW = w4DW);
	}

	[SpecialName]
	internal virtual PictureBox Sz12()
	{
		return dp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He86(PictureBox Bd59)
	{
		PictureBox val = (dp = Bd59);
	}

	[SpecialName]
	internal virtual PictureBox p2LK()
	{
		return dB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8W7(PictureBox g5X8)
	{
		PictureBox val = (dB = g5X8);
	}

	[SpecialName]
	internal virtual PictureBox Ne8c()
	{
		return du;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3CP(PictureBox w3R4)
	{
		PictureBox val = (du = w3R4);
	}

	[SpecialName]
	internal virtual PictureBox Wd38()
	{
		return _PictureBox156;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Li52(PictureBox j5HN)
	{
		_PictureBox156 = j5HN;
	}

	[SpecialName]
	internal virtual PictureBox j9Y6()
	{
		return _PictureBox157;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei70(PictureBox Na58)
	{
		_PictureBox157 = Na58;
	}

	[SpecialName]
	internal virtual PictureBox w9X0()
	{
		return _PictureBox158;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wj6o(PictureBox Di20)
	{
		_PictureBox158 = Di20;
	}

	[SpecialName]
	internal virtual PictureBox Be8z()
	{
		return dX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb5c(PictureBox Ho1f)
	{
		PictureBox val = (dX = Ho1f);
	}

	[SpecialName]
	internal virtual PictureBox r1RQ()
	{
		return _PictureBox160;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0Q3(PictureBox p1K8)
	{
		_PictureBox160 = p1K8;
	}

	[SpecialName]
	internal virtual Button Nk89()
	{
		return _btnNew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7QM(Button w4LJ)
	{
		EventHandler eventHandler = Mg50;
		Button btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).remove_Click(eventHandler);
		}
		_btnNew = w4LJ;
		btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Jc8s()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wy5q(Button Rw52)
	{
		_btnReset = Rw52;
	}

	[SpecialName]
	internal virtual Button Hg78()
	{
		return dG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bj9k(Button s5AT)
	{
		EventHandler eventHandler = e5BS;
		Button val = dG;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (dG = s5AT);
		val = dG;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j7CZ()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn9e(Button Aa2s)
	{
		EventHandler eventHandler = Ct2p;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = Aa2s;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Rj14()
	{
		return dV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb76(Button Qr6p)
	{
		EventHandler eventHandler = y3LF;
		Button val = dV;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (dV = Qr6p);
		val = dV;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button e9RT()
	{
		return dt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1KC(Button Qn8d)
	{
		EventHandler eventHandler = Ai02;
		Button val = dt;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (dt = Qn8d);
		val = dt;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	private void Ct2p(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		IEnumerator enumerator = default(IEnumerator);
		bool flag = default(bool);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				PictureBox val = (PictureBox)(Control)enumerator.Current;
				if (val != null && val.get_Image() == provisionalIcon)
				{
					flag = true;
					break;
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
		if (!flag)
		{
			MessageBox.Show("Please select at least one seat to book", "Error", (MessageBoxButtons)5, (MessageBoxIcon)48);
			return;
		}
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 1.accdb";
		OleDbConnection val2 = new OleDbConnection();
		val2.set_ConnectionString(connectionString);
		val2.Open();
		OleDbCommand val3 = new OleDbCommand();
		val3.set_Connection(val2);
		IEnumerator enumerator2 = default(IEnumerator);
		try
		{
			enumerator2 = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator2.MoveNext())
			{
				PictureBox val = (PictureBox)(Control)enumerator2.Current;
				if (val != null && val.get_Image() == provisionalIcon)
				{
					int num = Conversions.ToInteger(Strings.Mid(((Control)val).get_Name(), 11));
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Pn7().get_Text() + "'," + Conversions.ToString(num) + " )";
					val3.set_CommandText(commandText);
					val3.ExecuteNonQuery();
				}
			}
		}
		finally
		{
			if (enumerator2 is IDisposable)
			{
				(enumerator2 as IDisposable).Dispose();
			}
		}
		customerID = Pn7().get_Text();
		firstName = k0W().get_Text();
		val2.Close();
		g7EB();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void y3LF(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(Pa7().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			j3D().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)Pa7()).Clear();
		}
	}

	private void a5YP(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (val is PictureBox && !((Operators.CompareString(val.get_Name(), "NameBox", false) == 0) | (Operators.CompareString(val.get_Name(), "Background", false) == 0)))
				{
					((PictureBox)val).set_Image((Image)dI);
					val.add_Click((EventHandler)q6X3);
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
		dj = 160;
		bookedSeats = 0;
		provisionalSeats = 0;
		g7EB();
	}

	private void Ai02(object sender, EventArgs e)
	{
	}

	private void e5BS(object sender, EventArgs e)
	{
	}

	private void Mg50(object sender, EventArgs e)
	{
	}

	internal static byte[] Sc75(int Eo8q, int Tw18)
	{
		if (Eo8q <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[Tw18 + 1];
			for (int i = 0; i <= Tw18; i++)
			{
				int num = Eo8q * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return Cn9r.a7H0(array, Tw18);
		}
	}

	public void g7EB()
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		checked
		{
			int num = (dj = 160 - bookedSeats);
			provisionalSeats = 0;
			string commandText = "SELECT * FROM tblBookings";
			string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 1.accdb";
			OleDbConnection val = new OleDbConnection();
			val.set_ConnectionString(connectionString);
			val.Open();
			OleDbCommand val2 = new OleDbCommand();
			val2.set_CommandText(commandText);
			val2.set_Connection(val);
			DataSet dataSet = new DataSet();
			OleDbDataAdapter val3 = new OleDbDataAdapter(val2);
			((DbDataAdapter)(object)val3).Fill(dataSet, "Bookings");
			val.Close();
			DataTable dataTable = dataSet.Tables["Bookings"];
			IEnumerator enumerator = default(IEnumerator);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					((PictureBox)NewLateBinding.LateGet((object)((Control)this).get_Controls(), (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"PictureBox", dataRow[2]) }, (string[])null, (Type[])null, (bool[])null)).set_Image((Image)dK);
					bookedSeats++;
					dj--;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			e0Q().set_Text(Conversions.ToString(bookedSeats));
			Bj9().set_Text(Conversions.ToString(dj));
			Jc3().set_Text(Conversions.ToString(provisionalSeats));
			t2K4();
		}
	}

	private void q6X3(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		checked
		{
			if (((PictureBox)sender).get_Image() == dI)
			{
				((PictureBox)sender).set_Image((Image)provisionalIcon);
				provisionalSeats++;
				dj--;
			}
			else if (((PictureBox)sender).get_Image() == provisionalIcon)
			{
				((PictureBox)sender).set_Image((Image)dI);
				provisionalSeats--;
				dj++;
			}
			Bj9().set_Text(Conversions.ToString(dj));
			Jc3().set_Text(Conversions.ToString(provisionalSeats));
			seats = provisionalSeats;
			At7().set_Text(Conversions.ToString(seats));
			totalCost = provisionalSeats * 5;
			Lc1().set_Text("$" + totalCost);
		}
	}

	public void t2K4()
	{
		((TextBoxBase)Pa7()).Clear();
		((TextBoxBase)k0W()).Clear();
		((TextBoxBase)Lc1()).Clear();
		((TextBoxBase)j3D()).Clear();
		((TextBoxBase)At7()).Clear();
		((TextBoxBase)Pn7()).Clear();
	}
}
