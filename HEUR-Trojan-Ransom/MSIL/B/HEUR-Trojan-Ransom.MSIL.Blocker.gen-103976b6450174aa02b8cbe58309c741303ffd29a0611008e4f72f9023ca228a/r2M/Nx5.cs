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
using c5R;

namespace r2M;

[DesignerGenerated]
public class Nx5 : Form
{
	private IContainer components;

	private PictureBox _NameBox;

	private GroupBox _GroupBox2;

	private PictureBox _Cover;

	private TextBox _txtProvisional;

	private TextBox _txtBooked;

	private Label _Label2;

	private Label _Label4;

	private Label _Label5;

	private Label _Label8;

	private Label _Label11;

	private Label _Label15;

	private Label _Label16;

	private Label _Label17;

	private Label _Label19;

	private Label _Label20;

	private Label _Label22;

	private Label _Label23;

	private Label _Label24;

	private Label _Label27;

	private Label _Label28;

	private Label _Label29;

	private Label _Label30;

	private Label _Label54;

	private Label _Label55;

	private TextBox _txtID;

	private TextBox _txtChange;

	private TextBox _txtTotalPayment;

	private TextBox _txtSeats;

	private Label _Label63;

	private Label _Label61;

	private Label _Label21;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox23;

	private PictureBox _PictureBox25;

	private PictureBox _PictureBox30;

	private PictureBox _PictureBox31;

	private PictureBox _PictureBox32;

	private PictureBox _PictureBox33;

	private PictureBox _PictureBox34;

	private PictureBox _PictureBox36;

	private PictureBox _PictureBox37;

	private PictureBox _PictureBox39;

	private PictureBox _PictureBox40;

	private Label _Label32;

	private Label _Label33;

	private Label _Label34;

	private Label _Label37;

	private Label _Label40;

	private Label _Label42;

	private Label _Label43;

	private Label _Label44;

	private Label _Label46;

	private Label _Label49;

	private Label _Label51;

	private PictureBox _PictureBox44;

	private PictureBox _PictureBox46;

	private PictureBox _PictureBox48;

	private PictureBox _PictureBox51;

	private PictureBox _PictureBox55;

	private PictureBox _PictureBox57;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox61;

	private PictureBox _PictureBox62;

	private PictureBox _PictureBox69;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox75;

	private PictureBox _PictureBox76;

	private PictureBox _PictureBox77;

	private PictureBox _PictureBox79;

	private PictureBox _PictureBox83;

	private PictureBox _PictureBox84;

	private PictureBox _PictureBox85;

	private PictureBox _PictureBox90;

	private PictureBox _PictureBox92;

	private PictureBox _PictureBox95;

	private PictureBox _PictureBox96;

	private PictureBox _PictureBox97;

	private PictureBox _PictureBox98;

	private PictureBox _PictureBox101;

	private PictureBox _PictureBox102;

	private PictureBox _PictureBox105;

	private PictureBox _PictureBox109;

	private PictureBox _PictureBox111;

	private PictureBox _PictureBox112;

	private PictureBox _PictureBox115;

	private PictureBox _PictureBox116;

	private PictureBox _PictureBox118;

	private PictureBox _PictureBox119;

	private PictureBox _PictureBox121;

	private PictureBox _PictureBox122;

	private PictureBox _PictureBox125;

	private PictureBox _PictureBox126;

	private PictureBox _PictureBox127;

	private PictureBox _PictureBox128;

	private PictureBox _PictureBox132;

	private PictureBox _PictureBox133;

	private PictureBox _PictureBox136;

	private PictureBox _PictureBox138;

	private PictureBox _PictureBox141;

	private PictureBox _PictureBox146;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox149;

	private PictureBox _PictureBox155;

	private PictureBox _PictureBox156;

	private PictureBox _PictureBox157;

	private PictureBox _PictureBox158;

	private PictureBox _PictureBox159;

	private Button _btnNew;

	private Button _btnReset;

	private Button _btnExisting;

	private Button _btnSave;

	private Button _btnViewReservations;

	private object availableIcon;

	private object provisionalIcon;

	private object bookedIcon;

	private int availableSeats;

	private int provisionalSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal PictureBox c;

	internal Label m;

	internal GroupBox V;

	internal GroupBox t;

	internal GroupBox j;

	internal TextBox B;

	internal PictureBox w;

	internal PictureBox n;

	internal PictureBox a;

	internal Label i;

	internal Label L;

	internal Label U;

	internal Label X;

	internal Label Q;

	internal Label G;

	internal Label r;

	internal Label s;

	internal Label d;

	internal Label P;

	internal Label O;

	internal Label E;

	internal TextBox H;

	internal Label Y;

	internal Label K;

	internal TextBox F;

	internal Label Z;

	internal Label mc;

	internal Label mm;

	internal PictureBox mV;

	internal PictureBox mt;

	internal PictureBox mj;

	internal PictureBox mB;

	internal PictureBox mw;

	internal PictureBox mn;

	internal PictureBox ma;

	internal PictureBox mi;

	internal PictureBox mL;

	internal PictureBox mU;

	internal PictureBox mX;

	internal PictureBox mQ;

	internal PictureBox mG;

	internal PictureBox mr;

	internal PictureBox ms;

	internal PictureBox md;

	internal PictureBox mP;

	internal PictureBox mO;

	internal PictureBox mE;

	internal PictureBox mH;

	internal PictureBox mY;

	internal Label mK;

	internal Label mF;

	internal Label mZ;

	internal Label Vc;

	internal Label Vm;

	internal Label VV;

	internal Label Vt;

	internal Label Vj;

	internal Label VB;

	internal PictureBox Vw;

	internal PictureBox Vn;

	internal PictureBox Va;

	internal PictureBox Vi;

	internal PictureBox VL;

	internal PictureBox VU;

	internal PictureBox VX;

	internal PictureBox VQ;

	internal PictureBox VG;

	internal PictureBox Vr;

	internal PictureBox Vs;

	internal PictureBox Vd;

	internal PictureBox VP;

	internal PictureBox VO;

	internal PictureBox VE;

	internal PictureBox VH;

	internal PictureBox VY;

	internal PictureBox VK;

	internal PictureBox VF;

	internal PictureBox VZ;

	internal PictureBox tc;

	internal PictureBox tm;

	internal PictureBox tV;

	internal PictureBox tt;

	internal PictureBox tj;

	internal PictureBox tB;

	internal PictureBox tw;

	internal PictureBox tn;

	internal PictureBox ta;

	internal PictureBox ti;

	internal PictureBox tL;

	internal PictureBox tU;

	internal PictureBox tX;

	internal PictureBox tQ;

	internal PictureBox tG;

	internal PictureBox tr;

	internal PictureBox ts;

	internal PictureBox td;

	internal PictureBox tP;

	internal PictureBox tO;

	internal PictureBox tE;

	internal PictureBox tH;

	internal PictureBox tY;

	internal PictureBox tK;

	internal PictureBox tF;

	internal PictureBox tZ;

	internal PictureBox jc;

	internal PictureBox jm;

	internal PictureBox jV;

	internal PictureBox jt;

	internal PictureBox jj;

	internal PictureBox jB;

	internal PictureBox jw;

	internal PictureBox jn;

	internal PictureBox ja;

	internal PictureBox ji;

	internal PictureBox jL;

	internal PictureBox jU;

	internal PictureBox jX;

	internal PictureBox jQ;

	internal PictureBox jG;

	internal PictureBox jr;

	internal PictureBox js;

	internal PictureBox jd;

	internal PictureBox jP;

	internal PictureBox jO;

	internal PictureBox jE;

	internal Button jH;

	internal int jY;

	public Nx5()
	{
		((Form)this).add_Load((EventHandler)g9Y);
		availableIcon = RuntimeHelpers.GetObjectValue(new object());
		provisionalIcon = RuntimeHelpers.GetObjectValue(new object());
		bookedIcon = RuntimeHelpers.GetObjectValue(new object());
		p9Q();
	}

	protected override void Wy6(bool p1X)
	{
		try
		{
			if (p1X && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(p1X);
		}
	}

	private void p9Q()
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
		x3Z5(new PictureBox());
		c8AR(new PictureBox());
		a1P4(new Label());
		w1K2(new GroupBox());
		Lc28(new TextBox());
		Me51(new TextBox());
		j5EX(new TextBox());
		r3AK(new PictureBox());
		y3LY(new PictureBox());
		Ef7q(new PictureBox());
		Mo2q(new Label());
		g6B5(new Label());
		Rg4c(new Label());
		Ay23(new GroupBox());
		j3B(new Button());
		j7B(new Button());
		Cs1(new Button());
		j6R7(new TextBox());
		g7DZ(new TextBox());
		i1AK(new Label());
		Dw7p(new Label());
		Jx7w(new GroupBox());
		Ka7(new Button());
		i0GT(new PictureBox());
		s1FR(new GroupBox());
		f1R(new Button());
		Zo8(new Button());
		e2B8(new TextBox());
		Pw8x(new TextBox());
		k2PM(new TextBox());
		Hn91(new TextBox());
		c8HW(new Label());
		e7F6(new Label());
		Qj3z(new Label());
		t3ZT(new Label());
		He9c(new Label());
		j0LR(new Label());
		e5NS(new Label());
		b3Y0(new Label());
		i1CJ(new Label());
		j1MB(new Label());
		Xd4w(new Label());
		Wk1d(new Label());
		Bp8c(new Label());
		Zp76(new Label());
		q3B5(new Label());
		c3N0(new Label());
		Qk86(new Label());
		Hb1c(new Label());
		Ax20(new Label());
		Nj6m(new Label());
		Sg9f(new Label());
		w6R4(new Label());
		Dd90(new Label());
		j4H1(new Label());
		n6AC(new Label());
		i0XL(new Label());
		Xj2s(new Label());
		Jz7b(new Label());
		Fq3f(new Label());
		Sa8m(new Label());
		s2T4(new Label());
		Zk56(new Label());
		Tm7b(new Label());
		Ck9j(new Label());
		g3D5(new PictureBox());
		Pp8z(new PictureBox());
		c3H8(new PictureBox());
		Rs8b(new PictureBox());
		Lp2e(new PictureBox());
		s1S5(new PictureBox());
		p2KG(new PictureBox());
		e0Q2(new PictureBox());
		c9W5(new PictureBox());
		q1J3(new PictureBox());
		Nm7w(new PictureBox());
		Pg0s(new PictureBox());
		Gc60(new PictureBox());
		Yk39(new PictureBox());
		w1Z9(new PictureBox());
		j8G7(new PictureBox());
		r8N2(new PictureBox());
		Go20(new PictureBox());
		Fc8o(new PictureBox());
		c4K7(new PictureBox());
		m8H5(new PictureBox());
		Wc52(new PictureBox());
		Wc4t(new PictureBox());
		c2AE(new PictureBox());
		Hk7p(new PictureBox());
		Xg04(new PictureBox());
		Wj2m(new PictureBox());
		Hp32(new PictureBox());
		a1QY(new PictureBox());
		Dg21(new PictureBox());
		x3W8(new PictureBox());
		Qc54(new PictureBox());
		z1J7(new PictureBox());
		c4F5(new PictureBox());
		Ze4w(new PictureBox());
		Yb1o(new PictureBox());
		Rd5z(new PictureBox());
		g9GN(new PictureBox());
		Nf3k(new PictureBox());
		t1BR(new PictureBox());
		p6Q2(new Label());
		Ma17(new Label());
		Ex3g(new Label());
		Ez5a(new Label());
		p1LB(new Label());
		q1BN(new Label());
		Ea9c(new Label());
		b3MQ(new Label());
		t0WY(new Label());
		m3QP(new Label());
		z2W4(new Label());
		Ad1i(new Label());
		w6LN(new Label());
		Fi92(new Label());
		Xz13(new Label());
		Nn75(new Label());
		s9W3(new Label());
		Aj93(new Label());
		Bq25(new Label());
		Pz1n(new Label());
		Tn1q(new PictureBox());
		p4NQ(new PictureBox());
		c6GN(new PictureBox());
		Ns0o(new PictureBox());
		Za1q(new PictureBox());
		Yz92(new PictureBox());
		j4WM(new PictureBox());
		Mc5f(new PictureBox());
		Jb9e(new PictureBox());
		Rj0m(new PictureBox());
		Jg9w(new PictureBox());
		g4T2(new PictureBox());
		c5AL(new PictureBox());
		Bi8j(new PictureBox());
		w2Z4(new PictureBox());
		An1a(new PictureBox());
		Hq2r(new PictureBox());
		Sb02(new PictureBox());
		Gb6x(new PictureBox());
		Te9i(new PictureBox());
		Am96(new PictureBox());
		Ew32(new PictureBox());
		b6S4(new PictureBox());
		Wn27(new PictureBox());
		Px60(new PictureBox());
		Az74(new PictureBox());
		Tk60(new PictureBox());
		Cg4k(new PictureBox());
		Cs2o(new PictureBox());
		Qp5o(new PictureBox());
		Zx5q(new PictureBox());
		x5T8(new PictureBox());
		m6Y1(new PictureBox());
		y3T4(new PictureBox());
		Hr39(new PictureBox());
		z4G7(new PictureBox());
		Ps17(new PictureBox());
		Zb7t(new PictureBox());
		Dm5w(new PictureBox());
		t7W1(new PictureBox());
		o9G8(new PictureBox());
		m7N6(new PictureBox());
		Fp1g(new PictureBox());
		x0CS(new PictureBox());
		Rx4f(new PictureBox());
		Py79(new PictureBox());
		p4M2(new PictureBox());
		s4HY(new PictureBox());
		p4M6(new PictureBox());
		q6K8(new PictureBox());
		Bg2x(new PictureBox());
		g0FJ(new PictureBox());
		m6PE(new PictureBox());
		Yg3k(new PictureBox());
		Pf4m(new PictureBox());
		Df78(new PictureBox());
		Xz58(new PictureBox());
		i3AT(new PictureBox());
		k5F6(new PictureBox());
		r7Z0(new PictureBox());
		a6CH(new PictureBox());
		Aq70(new PictureBox());
		Sa91(new PictureBox());
		Ng2o(new PictureBox());
		Bg89(new PictureBox());
		n7EJ(new PictureBox());
		Bd91(new PictureBox());
		Lc7y(new PictureBox());
		p2BW(new PictureBox());
		x5WQ(new PictureBox());
		Ln78(new PictureBox());
		k0K6(new PictureBox());
		g2RK(new PictureBox());
		Pb73(new PictureBox());
		Fq2e(new PictureBox());
		z7RS(new PictureBox());
		Qp80(new PictureBox());
		r8E2(new PictureBox());
		d0DP(new PictureBox());
		Kq2f(new PictureBox());
		Re87(new PictureBox());
		p2B7(new PictureBox());
		Fi7g(new PictureBox());
		Sn9e(new PictureBox());
		Zn31(new PictureBox());
		j8ES(new PictureBox());
		He8r(new PictureBox());
		k2CG(new PictureBox());
		d5ND(new PictureBox());
		Je16(new PictureBox());
		m2W0(new PictureBox());
		Tb5n(new PictureBox());
		a7F2(new PictureBox());
		Fn9k(new PictureBox());
		m6CK(new PictureBox());
		i9N6(new PictureBox());
		Be4a(new PictureBox());
		w4P6(new PictureBox());
		Pw37(new PictureBox());
		Yr78(new PictureBox());
		Yz1e(new PictureBox());
		k8KX(new PictureBox());
		q5HP(new PictureBox());
		Yn41(new PictureBox());
		i2S1(new PictureBox());
		Rn93(new PictureBox());
		Lw34(new PictureBox());
		c9ES(new PictureBox());
		Ci19(new PictureBox());
		Fm18(new PictureBox());
		j7JQ(new PictureBox());
		z9A4(new PictureBox());
		Rz81(new PictureBox());
		y3HD(new PictureBox());
		Di0y(new PictureBox());
		Wz37(new PictureBox());
		i1N(new PictureBox());
		g8E(new PictureBox());
		Cq7(new PictureBox());
		b1N(new PictureBox());
		((ISupportInitialize)g3CY()).BeginInit();
		((ISupportInitialize)z0H6()).BeginInit();
		((Control)Qg5y()).SuspendLayout();
		((ISupportInitialize)Wc36()).BeginInit();
		((ISupportInitialize)Fa2y()).BeginInit();
		((ISupportInitialize)Ka17()).BeginInit();
		((Control)w6QX()).SuspendLayout();
		((Control)Ld52()).SuspendLayout();
		((ISupportInitialize)Cd0t()).BeginInit();
		((Control)Fx8t()).SuspendLayout();
		((ISupportInitialize)Kq14()).BeginInit();
		((ISupportInitialize)x1Z9()).BeginInit();
		((ISupportInitialize)Da4b()).BeginInit();
		((ISupportInitialize)Ge5g()).BeginInit();
		((ISupportInitialize)x9A1()).BeginInit();
		((ISupportInitialize)j7HB()).BeginInit();
		((ISupportInitialize)o5P6()).BeginInit();
		((ISupportInitialize)x7RX()).BeginInit();
		((ISupportInitialize)k9WH()).BeginInit();
		((ISupportInitialize)Kn21()).BeginInit();
		((ISupportInitialize)i8RF()).BeginInit();
		((ISupportInitialize)Sa51()).BeginInit();
		((ISupportInitialize)g6XB()).BeginInit();
		((ISupportInitialize)Ng4x()).BeginInit();
		((ISupportInitialize)Xx2q()).BeginInit();
		((ISupportInitialize)Tg8n()).BeginInit();
		((ISupportInitialize)g9ZW()).BeginInit();
		((ISupportInitialize)Qj0e()).BeginInit();
		((ISupportInitialize)Sb7e()).BeginInit();
		((ISupportInitialize)f1E6()).BeginInit();
		((ISupportInitialize)r4EP()).BeginInit();
		((ISupportInitialize)r0L1()).BeginInit();
		((ISupportInitialize)Cy0f()).BeginInit();
		((ISupportInitialize)Wi1e()).BeginInit();
		((ISupportInitialize)Za6d()).BeginInit();
		((ISupportInitialize)Ny87()).BeginInit();
		((ISupportInitialize)z9F3()).BeginInit();
		((ISupportInitialize)m6EQ()).BeginInit();
		((ISupportInitialize)Nx18()).BeginInit();
		((ISupportInitialize)Ek37()).BeginInit();
		((ISupportInitialize)Bs59()).BeginInit();
		((ISupportInitialize)k2Q5()).BeginInit();
		((ISupportInitialize)c0X4()).BeginInit();
		((ISupportInitialize)Gf7o()).BeginInit();
		((ISupportInitialize)n7R1()).BeginInit();
		((ISupportInitialize)z8Y1()).BeginInit();
		((ISupportInitialize)Xk23()).BeginInit();
		((ISupportInitialize)c7XW()).BeginInit();
		((ISupportInitialize)q6S4()).BeginInit();
		((ISupportInitialize)j6E4()).BeginInit();
		((ISupportInitialize)t7W0()).BeginInit();
		((ISupportInitialize)c5SP()).BeginInit();
		((ISupportInitialize)Bt87()).BeginInit();
		((ISupportInitialize)c6M1()).BeginInit();
		((ISupportInitialize)Tn90()).BeginInit();
		((ISupportInitialize)c6L3()).BeginInit();
		((ISupportInitialize)Gd59()).BeginInit();
		((ISupportInitialize)n4QW()).BeginInit();
		((ISupportInitialize)Tk06()).BeginInit();
		((ISupportInitialize)d0XD()).BeginInit();
		((ISupportInitialize)n4BE()).BeginInit();
		((ISupportInitialize)e5A0()).BeginInit();
		((ISupportInitialize)Yy8t()).BeginInit();
		((ISupportInitialize)Cz01()).BeginInit();
		((ISupportInitialize)Qp1f()).BeginInit();
		((ISupportInitialize)k0FH()).BeginInit();
		((ISupportInitialize)Mn86()).BeginInit();
		((ISupportInitialize)Af08()).BeginInit();
		((ISupportInitialize)y8Y3()).BeginInit();
		((ISupportInitialize)g8JS()).BeginInit();
		((ISupportInitialize)Sp2w()).BeginInit();
		((ISupportInitialize)c9R8()).BeginInit();
		((ISupportInitialize)r9Q8()).BeginInit();
		((ISupportInitialize)f6L2()).BeginInit();
		((ISupportInitialize)Jq34()).BeginInit();
		((ISupportInitialize)n8FH()).BeginInit();
		((ISupportInitialize)o3W6()).BeginInit();
		((ISupportInitialize)c8E0()).BeginInit();
		((ISupportInitialize)q1N6()).BeginInit();
		((ISupportInitialize)n8B7()).BeginInit();
		((ISupportInitialize)a1P0()).BeginInit();
		((ISupportInitialize)Pf8a()).BeginInit();
		((ISupportInitialize)f9ML()).BeginInit();
		((ISupportInitialize)To52()).BeginInit();
		((ISupportInitialize)c4MX()).BeginInit();
		((ISupportInitialize)Yq34()).BeginInit();
		((ISupportInitialize)Mi1b()).BeginInit();
		((ISupportInitialize)x5S0()).BeginInit();
		((ISupportInitialize)Sg1w()).BeginInit();
		((ISupportInitialize)f1RY()).BeginInit();
		((ISupportInitialize)m5ZS()).BeginInit();
		((ISupportInitialize)p3J0()).BeginInit();
		((ISupportInitialize)y0B8()).BeginInit();
		((ISupportInitialize)Hy43()).BeginInit();
		((ISupportInitialize)q4Z6()).BeginInit();
		((ISupportInitialize)k6BJ()).BeginInit();
		((ISupportInitialize)w2WY()).BeginInit();
		((ISupportInitialize)Wt18()).BeginInit();
		((ISupportInitialize)a5Q3()).BeginInit();
		((ISupportInitialize)Km41()).BeginInit();
		((ISupportInitialize)Mg6r()).BeginInit();
		((ISupportInitialize)Kq38()).BeginInit();
		((ISupportInitialize)d5DG()).BeginInit();
		((ISupportInitialize)Db05()).BeginInit();
		((ISupportInitialize)g6KE()).BeginInit();
		((ISupportInitialize)Dx34()).BeginInit();
		((ISupportInitialize)Fm78()).BeginInit();
		((ISupportInitialize)z6AG()).BeginInit();
		((ISupportInitialize)Zt9m()).BeginInit();
		((ISupportInitialize)Qe29()).BeginInit();
		((ISupportInitialize)k4HJ()).BeginInit();
		((ISupportInitialize)m0Z1()).BeginInit();
		((ISupportInitialize)Cb7m()).BeginInit();
		((ISupportInitialize)y7H0()).BeginInit();
		((ISupportInitialize)r5D3()).BeginInit();
		((ISupportInitialize)Zy9o()).BeginInit();
		((ISupportInitialize)Gt91()).BeginInit();
		((ISupportInitialize)An90()).BeginInit();
		((ISupportInitialize)z0N9()).BeginInit();
		((ISupportInitialize)i9Z6()).BeginInit();
		((ISupportInitialize)Ky85()).BeginInit();
		((ISupportInitialize)Cz6x()).BeginInit();
		((ISupportInitialize)Aj42()).BeginInit();
		((ISupportInitialize)Sb5y()).BeginInit();
		((ISupportInitialize)Wn95()).BeginInit();
		((ISupportInitialize)k0M9()).BeginInit();
		((ISupportInitialize)z4T5()).BeginInit();
		((ISupportInitialize)s3F4()).BeginInit();
		((ISupportInitialize)Kt56()).BeginInit();
		((ISupportInitialize)m9ZA()).BeginInit();
		((ISupportInitialize)y6G4()).BeginInit();
		((ISupportInitialize)Jc96()).BeginInit();
		((ISupportInitialize)i8MH()).BeginInit();
		((ISupportInitialize)a6AR()).BeginInit();
		((ISupportInitialize)r6Q8()).BeginInit();
		((ISupportInitialize)s1E4()).BeginInit();
		((ISupportInitialize)b7TB()).BeginInit();
		((ISupportInitialize)Jo1d()).BeginInit();
		((ISupportInitialize)Kj57()).BeginInit();
		((ISupportInitialize)b0LK()).BeginInit();
		((ISupportInitialize)Hc0s()).BeginInit();
		((ISupportInitialize)q6WX()).BeginInit();
		((ISupportInitialize)Mn68()).BeginInit();
		((ISupportInitialize)Zr7j()).BeginInit();
		((ISupportInitialize)Nw1k()).BeginInit();
		((ISupportInitialize)x6P9()).BeginInit();
		((ISupportInitialize)Te6p()).BeginInit();
		((ISupportInitialize)Kw09()).BeginInit();
		((ISupportInitialize)Ca45()).BeginInit();
		((ISupportInitialize)t0Y1()).BeginInit();
		((ISupportInitialize)j7CK()).BeginInit();
		((ISupportInitialize)Ex36()).BeginInit();
		((ISupportInitialize)Fs14()).BeginInit();
		((ISupportInitialize)Aj9m()).BeginInit();
		((ISupportInitialize)g3Y9()).BeginInit();
		((ISupportInitialize)Gn7g()).BeginInit();
		((ISupportInitialize)z4P6()).BeginInit();
		((ISupportInitialize)Wt50()).BeginInit();
		((ISupportInitialize)o8DK()).BeginInit();
		((ISupportInitialize)Kk79()).BeginInit();
		((ISupportInitialize)Qf18()).BeginInit();
		((ISupportInitialize)Rp15()).BeginInit();
		((ISupportInitialize)Si9m()).BeginInit();
		((ISupportInitialize)j4R2()).BeginInit();
		((ISupportInitialize)Di90()).BeginInit();
		((ISupportInitialize)w6EC()).BeginInit();
		((ISupportInitialize)z7XY()).BeginInit();
		((ISupportInitialize)Mr9()).BeginInit();
		((ISupportInitialize)a6E()).BeginInit();
		((ISupportInitialize)Zm3()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)g3CY()).set_BackColor(Color.Transparent);
		((Control)g3CY()).set_Location(new Point(-1, 0));
		((Control)g3CY()).set_Name("NameBox");
		((Control)g3CY()).set_Size(new Size(914, 45));
		g3CY().set_SizeMode((PictureBoxSizeMode)1);
		g3CY().set_TabIndex(0);
		g3CY().set_TabStop(false);
		((Control)z0H6()).set_Location(new Point(436, 43));
		((Control)z0H6()).set_Name("Background");
		((Control)z0H6()).set_Size(new Size(474, 396));
		z0H6().set_SizeMode((PictureBoxSizeMode)1);
		z0H6().set_TabIndex(1);
		z0H6().set_TabStop(false);
		Xt6z().set_AutoSize(true);
		((Control)Xt6z()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Xt6z()).set_ForeColor(SystemColors.ControlLight);
		((Control)Xt6z()).set_Location(new Point(29, 9));
		((Control)Xt6z()).set_Name("Label6");
		((Control)Xt6z()).set_Size(new Size(106, 24));
		((Control)Xt6z()).set_TabIndex(20);
		Xt6z().set_Text("CINEMA 1");
		((Control)Qg5y()).get_Controls().Add((Control)(object)t9K2());
		((Control)Qg5y()).get_Controls().Add((Control)(object)z6C9());
		((Control)Qg5y()).get_Controls().Add((Control)(object)i5ZA());
		((Control)Qg5y()).get_Controls().Add((Control)(object)Wc36());
		((Control)Qg5y()).get_Controls().Add((Control)(object)Fa2y());
		((Control)Qg5y()).get_Controls().Add((Control)(object)Ka17());
		((Control)Qg5y()).get_Controls().Add((Control)(object)Fy2z());
		((Control)Qg5y()).get_Controls().Add((Control)(object)Mw9b());
		((Control)Qg5y()).get_Controls().Add((Control)(object)b8JG());
		((Control)Qg5y()).set_ForeColor(SystemColors.ControlLight);
		((Control)Qg5y()).set_Location(new Point(455, 51));
		((Control)Qg5y()).set_Name("GroupBox1");
		((Control)Qg5y()).set_Size(new Size(240, 100));
		((Control)Qg5y()).set_TabIndex(21);
		Qg5y().set_TabStop(false);
		Qg5y().set_Text("Statistics");
		((Control)t9K2()).set_Location(new Point(151, 73));
		((Control)t9K2()).set_Name("txtProvisional");
		((Control)t9K2()).set_Size(new Size(83, 20));
		((Control)t9K2()).set_TabIndex(29);
		((Control)z6C9()).set_Location(new Point(151, 42));
		((Control)z6C9()).set_Name("txtBooked");
		((Control)z6C9()).set_Size(new Size(83, 20));
		((Control)z6C9()).set_TabIndex(28);
		((Control)i5ZA()).set_Location(new Point(151, 16));
		((Control)i5ZA()).set_Name("txtAvailable");
		((Control)i5ZA()).set_Size(new Size(83, 20));
		((Control)i5ZA()).set_TabIndex(25);
		((Control)Wc36()).set_BackColor(Color.Transparent);
		((Control)Wc36()).set_Location(new Point(5, 47));
		((Control)Wc36()).set_Name("Booked");
		((Control)Wc36()).set_Size(new Size(23, 18));
		Wc36().set_SizeMode((PictureBoxSizeMode)4);
		Wc36().set_TabIndex(27);
		Wc36().set_TabStop(false);
		((Control)Fa2y()).set_BackColor(Color.Transparent);
		((Control)Fa2y()).set_Location(new Point(6, 74));
		((Control)Fa2y()).set_Name("Provisional");
		((Control)Fa2y()).set_Size(new Size(23, 17));
		Fa2y().set_SizeMode((PictureBoxSizeMode)4);
		Fa2y().set_TabIndex(26);
		Fa2y().set_TabStop(false);
		((Control)Ka17()).set_BackColor(Color.Transparent);
		((Control)Ka17()).set_Location(new Point(5, 23));
		((Control)Ka17()).set_Name("Available");
		((Control)Ka17()).set_Size(new Size(23, 17));
		Ka17().set_SizeMode((PictureBoxSizeMode)4);
		Ka17().set_TabIndex(25);
		Ka17().set_TabStop(false);
		Fy2z().set_AutoSize(true);
		((Control)Fy2z()).set_BackColor(Color.Transparent);
		((Control)Fy2z()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Fy2z()).set_Location(new Point(30, 49));
		((Control)Fy2z()).set_Name("Label3");
		((Control)Fy2z()).set_Size(new Size(74, 13));
		((Control)Fy2z()).set_TabIndex(12);
		Fy2z().set_Text("Booked Seats");
		Mw9b().set_AutoSize(true);
		((Control)Mw9b()).set_BackColor(Color.Transparent);
		((Control)Mw9b()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mw9b()).set_Location(new Point(30, 76));
		((Control)Mw9b()).set_Name("Label1");
		((Control)Mw9b()).set_Size(new Size(115, 13));
		((Control)Mw9b()).set_TabIndex(11);
		Mw9b().set_Text("Seat[s] on Reservation");
		b8JG().set_AutoSize(true);
		((Control)b8JG()).set_BackColor(Color.Transparent);
		((Control)b8JG()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)b8JG()).set_Location(new Point(30, 24));
		((Control)b8JG()).set_Name("Label2");
		((Control)b8JG()).set_Size(new Size(80, 13));
		((Control)b8JG()).set_TabIndex(10);
		b8JG().set_Text("Available Seats");
		((Control)w6QX()).get_Controls().Add((Control)(object)Tg3());
		((Control)w6QX()).get_Controls().Add((Control)(object)Yf6());
		((Control)w6QX()).get_Controls().Add((Control)(object)Po5());
		((Control)w6QX()).get_Controls().Add((Control)(object)p5R9());
		((Control)w6QX()).get_Controls().Add((Control)(object)Dj8x());
		((Control)w6QX()).get_Controls().Add((Control)(object)f8N2());
		((Control)w6QX()).get_Controls().Add((Control)(object)Rd70());
		((Control)w6QX()).set_ForeColor(SystemColors.ControlLight);
		((Control)w6QX()).set_Location(new Point(701, 51));
		((Control)w6QX()).set_Name("GroupBox2");
		((Control)w6QX()).set_Size(new Size(200, 129));
		((Control)w6QX()).set_TabIndex(22);
		w6QX().set_TabStop(false);
		w6QX().set_Text("Customer");
		((ButtonBase)Tg3()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Tg3()).set_FlatStyle((FlatStyle)0);
		((Control)Tg3()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Tg3()).set_Location(new Point(70, 90));
		((Control)Tg3()).set_Name("btnNew");
		((Control)Tg3()).set_Size(new Size(54, 23));
		((Control)Tg3()).set_TabIndex(39);
		((ButtonBase)Tg3()).set_Text("New");
		((ButtonBase)Tg3()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Yf6()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Yf6()).set_FlatStyle((FlatStyle)0);
		((Control)Yf6()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Yf6()).set_Location(new Point(130, 90));
		((Control)Yf6()).set_Name("btnReset");
		((Control)Yf6()).set_Size(new Size(54, 23));
		((Control)Yf6()).set_TabIndex(38);
		((ButtonBase)Yf6()).set_Text("Reset");
		((ButtonBase)Yf6()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Po5()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Po5()).set_FlatStyle((FlatStyle)0);
		((Control)Po5()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Po5()).set_Location(new Point(10, 90));
		((Control)Po5()).set_Name("btnExisting");
		((Control)Po5()).set_Size(new Size(54, 23));
		((Control)Po5()).set_TabIndex(37);
		((ButtonBase)Po5()).set_Text("Existing");
		((ButtonBase)Po5()).set_UseVisualStyleBackColor(true);
		((Control)p5R9()).set_Location(new Point(94, 57));
		((Control)p5R9()).set_Name("txtFirstName");
		((Control)p5R9()).set_Size(new Size(103, 20));
		((Control)p5R9()).set_TabIndex(30);
		((Control)Dj8x()).set_Location(new Point(94, 31));
		((Control)Dj8x()).set_Name("txtID");
		((Control)Dj8x()).set_Size(new Size(103, 20));
		((Control)Dj8x()).set_TabIndex(29);
		f8N2().set_AutoSize(true);
		((Control)f8N2()).set_BackColor(Color.Transparent);
		((Control)f8N2()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)f8N2()).set_Location(new Point(6, 58));
		((Control)f8N2()).set_Name("Label60");
		((Control)f8N2()).set_Size(new Size(57, 13));
		((Control)f8N2()).set_TabIndex(12);
		f8N2().set_Text("First Name");
		Rd70().set_AutoSize(true);
		((Control)Rd70()).set_BackColor(Color.Transparent);
		((Control)Rd70()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Rd70()).set_Location(new Point(6, 34));
		((Control)Rd70()).set_Name("Label59");
		((Control)Rd70()).set_Size(new Size(65, 13));
		((Control)Rd70()).set_TabIndex(11);
		Rd70().set_Text("Customer ID");
		((Control)Ld52()).get_Controls().Add((Control)(object)e7N());
		((Control)Ld52()).get_Controls().Add((Control)(object)Cd0t());
		((Control)Ld52()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ld52()).set_Location(new Point(472, 170));
		((Control)Ld52()).set_Name("GroupBox3");
		((Control)Ld52()).set_Size(new Size(200, 251));
		((Control)Ld52()).set_TabIndex(23);
		Ld52().set_TabStop(false);
		Ld52().set_Text("Movie On Display");
		((ButtonBase)e7N()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)e7N()).set_FlatStyle((FlatStyle)0);
		((Control)e7N()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)e7N()).set_Location(new Point(45, 217));
		((Control)e7N()).set_Name("btnViewReservations");
		((Control)e7N()).set_Size(new Size(117, 23));
		((Control)e7N()).set_TabIndex(40);
		((ButtonBase)e7N()).set_Text("View Reservations");
		((ButtonBase)e7N()).set_UseVisualStyleBackColor(true);
		((Control)Cd0t()).set_BackColor(Color.Transparent);
		((Control)Cd0t()).set_Location(new Point(39, 21));
		((Control)Cd0t()).set_Name("Cover");
		((Control)Cd0t()).set_Size(new Size(129, 187));
		Cd0t().set_SizeMode((PictureBoxSizeMode)4);
		Cd0t().set_TabIndex(25);
		Cd0t().set_TabStop(false);
		((Control)Fx8t()).get_Controls().Add((Control)(object)f0S());
		((Control)Fx8t()).get_Controls().Add((Control)(object)Ye9());
		((Control)Fx8t()).get_Controls().Add((Control)(object)d7HZ());
		((Control)Fx8t()).get_Controls().Add((Control)(object)a3N6());
		((Control)Fx8t()).get_Controls().Add((Control)(object)k4YG());
		((Control)Fx8t()).get_Controls().Add((Control)(object)r2B9());
		((Control)Fx8t()).get_Controls().Add((Control)(object)r3W9());
		((Control)Fx8t()).get_Controls().Add((Control)(object)My14());
		((Control)Fx8t()).get_Controls().Add((Control)(object)Rq2e());
		((Control)Fx8t()).get_Controls().Add((Control)(object)Ji37());
		((Control)Fx8t()).set_ForeColor(SystemColors.ControlLight);
		((Control)Fx8t()).set_Location(new Point(690, 190));
		((Control)Fx8t()).set_Name("GroupBox4");
		((Control)Fx8t()).set_Size(new Size(211, 231));
		((Control)Fx8t()).set_TabIndex(24);
		Fx8t().set_TabStop(false);
		Fx8t().set_Text("Billing INFO");
		((ButtonBase)f0S()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)f0S()).set_FlatStyle((FlatStyle)0);
		((Control)f0S()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)f0S()).set_Location(new Point(72, 184));
		((Control)f0S()).set_Name("btnSave");
		((Control)f0S()).set_Size(new Size(133, 23));
		((Control)f0S()).set_TabIndex(40);
		((ButtonBase)f0S()).set_Text("Save / Receipt Preview");
		((ButtonBase)f0S()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Ye9()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ye9()).set_FlatStyle((FlatStyle)0);
		((Control)Ye9()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ye9()).set_Location(new Point(103, 155));
		((Control)Ye9()).set_Name("btnCalculateChange");
		((Control)Ye9()).set_Size(new Size(101, 23));
		((Control)Ye9()).set_TabIndex(39);
		((ButtonBase)Ye9()).set_Text("Calculate Change");
		((ButtonBase)Ye9()).set_UseVisualStyleBackColor(true);
		((Control)d7HZ()).set_Location(new Point(95, 123));
		((Control)d7HZ()).set_Name("txtChange");
		((Control)d7HZ()).set_Size(new Size(110, 20));
		((Control)d7HZ()).set_TabIndex(34);
		((Control)a3N6()).set_Location(new Point(95, 91));
		((Control)a3N6()).set_Name("txtTotalPayment");
		((Control)a3N6()).set_Size(new Size(110, 20));
		((Control)a3N6()).set_TabIndex(33);
		((Control)k4YG()).set_Location(new Point(96, 58));
		((Control)k4YG()).set_Name("txtTotalCost");
		((Control)k4YG()).set_Size(new Size(109, 20));
		((Control)k4YG()).set_TabIndex(32);
		((Control)r2B9()).set_Location(new Point(122, 24));
		((Control)r2B9()).set_Name("txtSeats");
		((Control)r2B9()).set_Size(new Size(83, 20));
		((Control)r2B9()).set_TabIndex(31);
		r3W9().set_AutoSize(true);
		((Control)r3W9()).set_BackColor(Color.Transparent);
		((Control)r3W9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)r3W9()).set_Location(new Point(8, 62));
		((Control)r3W9()).set_Name("Label63");
		((Control)r3W9()).set_Size(new Size(66, 13));
		((Control)r3W9()).set_TabIndex(16);
		r3W9().set_Text("Total Costs :");
		My14().set_AutoSize(true);
		((Control)My14()).set_BackColor(Color.Transparent);
		((Control)My14()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)My14()).set_Location(new Point(8, 27));
		((Control)My14()).set_Name("Label64");
		((Control)My14()).set_Size(new Size(106, 13));
		((Control)My14()).set_TabIndex(15);
		My14().set_Text("Seats to be booked :");
		Rq2e().set_AutoSize(true);
		((Control)Rq2e()).set_BackColor(Color.Transparent);
		((Control)Rq2e()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Rq2e()).set_Location(new Point(8, 121));
		((Control)Rq2e()).set_Name("Label61");
		((Control)Rq2e()).set_Size(new Size(50, 13));
		((Control)Rq2e()).set_TabIndex(14);
		Rq2e().set_Text("Change :");
		Ji37().set_AutoSize(true);
		((Control)Ji37()).set_BackColor(Color.Transparent);
		((Control)Ji37()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ji37()).set_Location(new Point(8, 91));
		((Control)Ji37()).set_Name("Label62");
		((Control)Ji37()).set_Size(new Size(81, 13));
		((Control)Ji37()).set_TabIndex(13);
		Ji37().set_Text("Total Payment :");
		y8WN().set_AutoSize(true);
		((Control)y8WN()).set_Location(new Point(177, 51));
		((Control)y8WN()).set_Name("Label4");
		((Control)y8WN()).set_Size(new Size(69, 13));
		((Control)y8WN()).set_TabIndex(25);
		y8WN().set_Text("UPPER BOX");
		Cq5n().set_AutoSize(true);
		((Control)Cq5n()).set_Location(new Point(44, 78));
		((Control)Cq5n()).set_Name("Label5");
		((Control)Cq5n()).set_Size(new Size(13, 13));
		((Control)Cq5n()).set_TabIndex(26);
		Cq5n().set_Text("1");
		Ny4k().set_AutoSize(true);
		((Control)Ny4k()).set_Location(new Point(60, 78));
		((Control)Ny4k()).set_Name("Label7");
		((Control)Ny4k()).set_Size(new Size(13, 13));
		((Control)Ny4k()).set_TabIndex(27);
		Ny4k().set_Text("2");
		z7TN().set_AutoSize(true);
		((Control)z7TN()).set_Location(new Point(76, 78));
		((Control)z7TN()).set_Name("Label8");
		((Control)z7TN()).set_Size(new Size(13, 13));
		((Control)z7TN()).set_TabIndex(28);
		z7TN().set_Text("3");
		Rt6k().set_AutoSize(true);
		((Control)Rt6k()).set_Location(new Point(108, 78));
		((Control)Rt6k()).set_Name("Label9");
		((Control)Rt6k()).set_Size(new Size(13, 13));
		((Control)Rt6k()).set_TabIndex(29);
		Rt6k().set_Text("5");
		Ze27().set_AutoSize(true);
		((Control)Ze27()).set_Location(new Point(124, 78));
		((Control)Ze27()).set_Name("Label10");
		((Control)Ze27()).set_Size(new Size(13, 13));
		((Control)Ze27()).set_TabIndex(30);
		Ze27().set_Text("6");
		Dw9s().set_AutoSize(true);
		((Control)Dw9s()).set_Location(new Point(140, 78));
		((Control)Dw9s()).set_Name("Label11");
		((Control)Dw9s()).set_Size(new Size(13, 13));
		((Control)Dw9s()).set_TabIndex(31);
		Dw9s().set_Text("7");
		o3W9().set_AutoSize(true);
		((Control)o3W9()).set_Location(new Point(172, 78));
		((Control)o3W9()).set_Name("Label12");
		((Control)o3W9()).set_Size(new Size(13, 13));
		((Control)o3W9()).set_TabIndex(32);
		o3W9().set_Text("9");
		b8H5().set_AutoSize(true);
		((Control)b8H5()).set_Location(new Point(188, 78));
		((Control)b8H5()).set_Name("Label13");
		((Control)b8H5()).set_Size(new Size(19, 13));
		((Control)b8H5()).set_TabIndex(33);
		b8H5().set_Text("10");
		r2MG().set_AutoSize(true);
		((Control)r2MG()).set_Location(new Point(156, 78));
		((Control)r2MG()).set_Name("Label14");
		((Control)r2MG()).set_Size(new Size(13, 13));
		((Control)r2MG()).set_TabIndex(34);
		r2MG().set_Text("8");
		y0H6().set_AutoSize(true);
		((Control)y0H6()).set_Location(new Point(257, 78));
		((Control)y0H6()).set_Name("Label15");
		((Control)y0H6()).set_Size(new Size(19, 13));
		((Control)y0H6()).set_TabIndex(35);
		y0H6().set_Text("14");
		Yn39().set_AutoSize(true);
		((Control)Yn39()).set_Location(new Point(206, 78));
		((Control)Yn39()).set_Name("Label16");
		((Control)Yn39()).set_Size(new Size(19, 13));
		((Control)Yn39()).set_TabIndex(36);
		Yn39().set_Text("11");
		Gn7b().set_AutoSize(true);
		((Control)Gn7b()).set_Location(new Point(292, 78));
		((Control)Gn7b()).set_Name("Label17");
		((Control)Gn7b()).set_Size(new Size(19, 13));
		((Control)Gn7b()).set_TabIndex(37);
		Gn7b().set_Text("16");
		Ab9x().set_AutoSize(true);
		((Control)Ab9x()).set_Location(new Point(241, 78));
		((Control)Ab9x()).set_Name("Label18");
		((Control)Ab9x()).set_Size(new Size(19, 13));
		((Control)Ab9x()).set_TabIndex(38);
		Ab9x().set_Text("13");
		Lr6a().set_AutoSize(true);
		((Control)Lr6a()).set_Location(new Point(92, 78));
		((Control)Lr6a()).set_Name("Label19");
		((Control)Lr6a()).set_Size(new Size(13, 13));
		((Control)Lr6a()).set_TabIndex(39);
		Lr6a().set_Text("4");
		z8N3().set_AutoSize(true);
		((Control)z8N3()).set_Location(new Point(223, 78));
		((Control)z8N3()).set_Name("Label20");
		((Control)z8N3()).set_Size(new Size(19, 13));
		((Control)z8N3()).set_TabIndex(40);
		z8N3().set_Text("12");
		s2XF().set_AutoSize(true);
		((Control)s2XF()).set_Location(new Point(329, 78));
		((Control)s2XF()).set_Name("Label22");
		((Control)s2XF()).set_Size(new Size(19, 13));
		((Control)s2XF()).set_TabIndex(42);
		s2XF().set_Text("18");
		Yy30().set_AutoSize(true);
		((Control)Yy30()).set_Location(new Point(310, 78));
		((Control)Yy30()).set_Name("Label23");
		((Control)Yy30()).set_Size(new Size(19, 13));
		((Control)Yy30()).set_TabIndex(43);
		Yy30().set_Text("17");
		Qx4a().set_AutoSize(true);
		((Control)Qx4a()).set_Location(new Point(275, 78));
		((Control)Qx4a()).set_Name("Label24");
		((Control)Qx4a()).set_Size(new Size(19, 13));
		((Control)Qx4a()).set_TabIndex(44);
		Qx4a().set_Text("15");
		Jn45().set_AutoSize(true);
		((Control)Jn45()).set_Location(new Point(29, 302));
		((Control)Jn45()).set_Name("Label26");
		((Control)Jn45()).set_Size(new Size(14, 13));
		((Control)Jn45()).set_TabIndex(50);
		Jn45().set_Text("E");
		Ti17().set_AutoSize(true);
		((Control)Ti17()).set_Location(new Point(29, 190));
		((Control)Ti17()).set_Name("Label27");
		((Control)Ti17()).set_Size(new Size(15, 13));
		((Control)Ti17()).set_TabIndex(49);
		Ti17().set_Text("D");
		Lq23().set_AutoSize(true);
		((Control)Lq23()).set_Location(new Point(29, 168));
		((Control)Lq23()).set_Name("Label28");
		((Control)Lq23()).set_Size(new Size(14, 13));
		((Control)Lq23()).set_TabIndex(48);
		Lq23().set_Text("C");
		c1HE().set_AutoSize(true);
		((Control)c1HE()).set_Location(new Point(29, 146));
		((Control)c1HE()).set_Name("Label29");
		((Control)c1HE()).set_Size(new Size(14, 13));
		((Control)c1HE()).set_TabIndex(47);
		c1HE().set_Text("B");
		o8CJ().set_AutoSize(true);
		((Control)o8CJ()).set_Location(new Point(29, 124));
		((Control)o8CJ()).set_Name("Label30");
		((Control)o8CJ()).set_Size(new Size(14, 13));
		((Control)o8CJ()).set_TabIndex(46);
		o8CJ().set_Text("A");
		Jm4t().set_AutoSize(true);
		((Control)Jm4t()).set_Location(new Point(177, 225));
		((Control)Jm4t()).set_Name("Label31");
		((Control)Jm4t()).set_Size(new Size(72, 13));
		((Control)Jm4t()).set_TabIndex(159);
		Jm4t().set_Text("LOWER BOX");
		b4D0().set_AutoSize(true);
		((Control)b4D0()).set_Location(new Point(30, 365));
		((Control)b4D0()).set_Name("Label54");
		((Control)b4D0()).set_Size(new Size(15, 13));
		((Control)b4D0()).set_TabIndex(182);
		b4D0().set_Text("H");
		n6Z7().set_AutoSize(true);
		((Control)n6Z7()).set_Location(new Point(30, 343));
		((Control)n6Z7()).set_Name("Label55");
		((Control)n6Z7()).set_Size(new Size(15, 13));
		((Control)n6Z7()).set_TabIndex(181);
		n6Z7().set_Text("G");
		Kk6q().set_AutoSize(true);
		((Control)Kk6q()).set_Location(new Point(30, 321));
		((Control)Kk6q()).set_Name("Label56");
		((Control)Kk6q()).set_Size(new Size(13, 13));
		((Control)Kk6q()).set_TabIndex(180);
		Kk6q().set_Text("F");
		He7w().set_AutoSize(true);
		((Control)He7w()).set_Location(new Point(348, 78));
		((Control)He7w()).set_Name("Label21");
		((Control)He7w()).set_Size(new Size(19, 13));
		((Control)He7w()).set_TabIndex(41);
		He7w().set_Text("19");
		w8T3().set_AutoSize(true);
		((Control)w8T3()).set_Location(new Point(368, 78));
		((Control)w8T3()).set_Name("Label25");
		((Control)w8T3()).set_Size(new Size(19, 13));
		((Control)w8T3()).set_TabIndex(45);
		w8T3().set_Text("20");
		((Control)Kq14()).set_Location(new Point(47, 124));
		((Control)Kq14()).set_Name("PictureBox1");
		((Control)Kq14()).set_Size(new Size(10, 12));
		Kq14().set_SizeMode((PictureBoxSizeMode)4);
		Kq14().set_TabIndex(349);
		Kq14().set_TabStop(false);
		((Control)x1Z9()).set_Location(new Point(61, 124));
		((Control)x1Z9()).set_Name("PictureBox2");
		((Control)x1Z9()).set_Size(new Size(10, 12));
		x1Z9().set_SizeMode((PictureBoxSizeMode)4);
		x1Z9().set_TabIndex(350);
		x1Z9().set_TabStop(false);
		((Control)Da4b()).set_Location(new Point(77, 124));
		((Control)Da4b()).set_Name("PictureBox3");
		((Control)Da4b()).set_Size(new Size(10, 12));
		Da4b().set_SizeMode((PictureBoxSizeMode)4);
		Da4b().set_TabIndex(351);
		Da4b().set_TabStop(false);
		((Control)Ge5g()).set_Location(new Point(93, 124));
		((Control)Ge5g()).set_Name("PictureBox4");
		((Control)Ge5g()).set_Size(new Size(10, 12));
		Ge5g().set_SizeMode((PictureBoxSizeMode)4);
		Ge5g().set_TabIndex(352);
		Ge5g().set_TabStop(false);
		((Control)x9A1()).set_Location(new Point(109, 124));
		((Control)x9A1()).set_Name("PictureBox5");
		((Control)x9A1()).set_Size(new Size(10, 12));
		x9A1().set_SizeMode((PictureBoxSizeMode)4);
		x9A1().set_TabIndex(353);
		x9A1().set_TabStop(false);
		((Control)j7HB()).set_Location(new Point(125, 124));
		((Control)j7HB()).set_Name("PictureBox6");
		((Control)j7HB()).set_Size(new Size(10, 12));
		j7HB().set_SizeMode((PictureBoxSizeMode)4);
		j7HB().set_TabIndex(354);
		j7HB().set_TabStop(false);
		((Control)o5P6()).set_Location(new Point(141, 124));
		((Control)o5P6()).set_Name("PictureBox7");
		((Control)o5P6()).set_Size(new Size(10, 12));
		o5P6().set_SizeMode((PictureBoxSizeMode)4);
		o5P6().set_TabIndex(355);
		o5P6().set_TabStop(false);
		((Control)x7RX()).set_Location(new Point(157, 124));
		((Control)x7RX()).set_Name("PictureBox8");
		((Control)x7RX()).set_Size(new Size(10, 12));
		x7RX().set_SizeMode((PictureBoxSizeMode)4);
		x7RX().set_TabIndex(356);
		x7RX().set_TabStop(false);
		((Control)k9WH()).set_Location(new Point(173, 124));
		((Control)k9WH()).set_Name("PictureBox9");
		((Control)k9WH()).set_Size(new Size(10, 12));
		k9WH().set_SizeMode((PictureBoxSizeMode)4);
		k9WH().set_TabIndex(357);
		k9WH().set_TabStop(false);
		((Control)Kn21()).set_Location(new Point(189, 124));
		((Control)Kn21()).set_Name("PictureBox10");
		((Control)Kn21()).set_Size(new Size(10, 12));
		Kn21().set_SizeMode((PictureBoxSizeMode)4);
		Kn21().set_TabIndex(358);
		Kn21().set_TabStop(false);
		((Control)i8RF()).set_Location(new Point(207, 124));
		((Control)i8RF()).set_Name("PictureBox11");
		((Control)i8RF()).set_Size(new Size(10, 12));
		i8RF().set_SizeMode((PictureBoxSizeMode)4);
		i8RF().set_TabIndex(359);
		i8RF().set_TabStop(false);
		((Control)Sa51()).set_Location(new Point(226, 124));
		((Control)Sa51()).set_Name("PictureBox12");
		((Control)Sa51()).set_Size(new Size(10, 12));
		Sa51().set_SizeMode((PictureBoxSizeMode)4);
		Sa51().set_TabIndex(360);
		Sa51().set_TabStop(false);
		((Control)g6XB()).set_Location(new Point(244, 124));
		((Control)g6XB()).set_Name("PictureBox13");
		((Control)g6XB()).set_Size(new Size(10, 12));
		g6XB().set_SizeMode((PictureBoxSizeMode)4);
		g6XB().set_TabIndex(361);
		g6XB().set_TabStop(false);
		((Control)Ng4x()).set_Location(new Point(260, 124));
		((Control)Ng4x()).set_Name("PictureBox14");
		((Control)Ng4x()).set_Size(new Size(10, 12));
		Ng4x().set_SizeMode((PictureBoxSizeMode)4);
		Ng4x().set_TabIndex(362);
		Ng4x().set_TabStop(false);
		((Control)Xx2q()).set_Location(new Point(278, 124));
		((Control)Xx2q()).set_Name("PictureBox15");
		((Control)Xx2q()).set_Size(new Size(10, 12));
		Xx2q().set_SizeMode((PictureBoxSizeMode)4);
		Xx2q().set_TabIndex(363);
		Xx2q().set_TabStop(false);
		((Control)Tg8n()).set_Location(new Point(295, 124));
		((Control)Tg8n()).set_Name("PictureBox16");
		((Control)Tg8n()).set_Size(new Size(10, 12));
		Tg8n().set_SizeMode((PictureBoxSizeMode)4);
		Tg8n().set_TabIndex(364);
		Tg8n().set_TabStop(false);
		((Control)g9ZW()).set_Location(new Point(313, 124));
		((Control)g9ZW()).set_Name("PictureBox17");
		((Control)g9ZW()).set_Size(new Size(10, 12));
		g9ZW().set_SizeMode((PictureBoxSizeMode)4);
		g9ZW().set_TabIndex(365);
		g9ZW().set_TabStop(false);
		((Control)Qj0e()).set_Location(new Point(332, 124));
		((Control)Qj0e()).set_Name("PictureBox18");
		((Control)Qj0e()).set_Size(new Size(10, 12));
		Qj0e().set_SizeMode((PictureBoxSizeMode)4);
		Qj0e().set_TabIndex(366);
		Qj0e().set_TabStop(false);
		((Control)Sb7e()).set_Location(new Point(351, 124));
		((Control)Sb7e()).set_Name("PictureBox19");
		((Control)Sb7e()).set_Size(new Size(10, 12));
		Sb7e().set_SizeMode((PictureBoxSizeMode)4);
		Sb7e().set_TabIndex(367);
		Sb7e().set_TabStop(false);
		((Control)f1E6()).set_Location(new Point(371, 124));
		((Control)f1E6()).set_Name("PictureBox20");
		((Control)f1E6()).set_Size(new Size(10, 12));
		f1E6().set_SizeMode((PictureBoxSizeMode)4);
		f1E6().set_TabIndex(368);
		f1E6().set_TabStop(false);
		((Control)r4EP()).set_Location(new Point(371, 146));
		((Control)r4EP()).set_Name("PictureBox21");
		((Control)r4EP()).set_Size(new Size(10, 12));
		r4EP().set_SizeMode((PictureBoxSizeMode)4);
		r4EP().set_TabIndex(388);
		r4EP().set_TabStop(false);
		((Control)r0L1()).set_Location(new Point(351, 146));
		((Control)r0L1()).set_Name("PictureBox22");
		((Control)r0L1()).set_Size(new Size(10, 12));
		r0L1().set_SizeMode((PictureBoxSizeMode)4);
		r0L1().set_TabIndex(387);
		r0L1().set_TabStop(false);
		((Control)Cy0f()).set_Location(new Point(332, 146));
		((Control)Cy0f()).set_Name("PictureBox23");
		((Control)Cy0f()).set_Size(new Size(10, 12));
		Cy0f().set_SizeMode((PictureBoxSizeMode)4);
		Cy0f().set_TabIndex(386);
		Cy0f().set_TabStop(false);
		((Control)Wi1e()).set_Location(new Point(313, 146));
		((Control)Wi1e()).set_Name("PictureBox24");
		((Control)Wi1e()).set_Size(new Size(10, 12));
		Wi1e().set_SizeMode((PictureBoxSizeMode)4);
		Wi1e().set_TabIndex(385);
		Wi1e().set_TabStop(false);
		((Control)Za6d()).set_Location(new Point(295, 146));
		((Control)Za6d()).set_Name("PictureBox25");
		((Control)Za6d()).set_Size(new Size(10, 12));
		Za6d().set_SizeMode((PictureBoxSizeMode)4);
		Za6d().set_TabIndex(384);
		Za6d().set_TabStop(false);
		((Control)Ny87()).set_Location(new Point(278, 146));
		((Control)Ny87()).set_Name("PictureBox26");
		((Control)Ny87()).set_Size(new Size(10, 12));
		Ny87().set_SizeMode((PictureBoxSizeMode)4);
		Ny87().set_TabIndex(383);
		Ny87().set_TabStop(false);
		((Control)z9F3()).set_Location(new Point(260, 146));
		((Control)z9F3()).set_Name("PictureBox27");
		((Control)z9F3()).set_Size(new Size(10, 12));
		z9F3().set_SizeMode((PictureBoxSizeMode)4);
		z9F3().set_TabIndex(382);
		z9F3().set_TabStop(false);
		((Control)m6EQ()).set_Location(new Point(244, 146));
		((Control)m6EQ()).set_Name("PictureBox28");
		((Control)m6EQ()).set_Size(new Size(10, 12));
		m6EQ().set_SizeMode((PictureBoxSizeMode)4);
		m6EQ().set_TabIndex(381);
		m6EQ().set_TabStop(false);
		((Control)Nx18()).set_Location(new Point(226, 146));
		((Control)Nx18()).set_Name("PictureBox29");
		((Control)Nx18()).set_Size(new Size(10, 12));
		Nx18().set_SizeMode((PictureBoxSizeMode)4);
		Nx18().set_TabIndex(380);
		Nx18().set_TabStop(false);
		((Control)Ek37()).set_Location(new Point(207, 146));
		((Control)Ek37()).set_Name("PictureBox30");
		((Control)Ek37()).set_Size(new Size(10, 12));
		Ek37().set_SizeMode((PictureBoxSizeMode)4);
		Ek37().set_TabIndex(379);
		Ek37().set_TabStop(false);
		((Control)Bs59()).set_Location(new Point(189, 146));
		((Control)Bs59()).set_Name("PictureBox31");
		((Control)Bs59()).set_Size(new Size(10, 12));
		Bs59().set_SizeMode((PictureBoxSizeMode)4);
		Bs59().set_TabIndex(378);
		Bs59().set_TabStop(false);
		((Control)k2Q5()).set_Location(new Point(173, 146));
		((Control)k2Q5()).set_Name("PictureBox32");
		((Control)k2Q5()).set_Size(new Size(10, 12));
		k2Q5().set_SizeMode((PictureBoxSizeMode)4);
		k2Q5().set_TabIndex(377);
		k2Q5().set_TabStop(false);
		((Control)c0X4()).set_Location(new Point(157, 146));
		((Control)c0X4()).set_Name("PictureBox33");
		((Control)c0X4()).set_Size(new Size(10, 12));
		c0X4().set_SizeMode((PictureBoxSizeMode)4);
		c0X4().set_TabIndex(376);
		c0X4().set_TabStop(false);
		((Control)Gf7o()).set_Location(new Point(141, 146));
		((Control)Gf7o()).set_Name("PictureBox34");
		((Control)Gf7o()).set_Size(new Size(10, 12));
		Gf7o().set_SizeMode((PictureBoxSizeMode)4);
		Gf7o().set_TabIndex(375);
		Gf7o().set_TabStop(false);
		((Control)n7R1()).set_Location(new Point(125, 146));
		((Control)n7R1()).set_Name("PictureBox35");
		((Control)n7R1()).set_Size(new Size(10, 12));
		n7R1().set_SizeMode((PictureBoxSizeMode)4);
		n7R1().set_TabIndex(374);
		n7R1().set_TabStop(false);
		((Control)z8Y1()).set_Location(new Point(109, 146));
		((Control)z8Y1()).set_Name("PictureBox36");
		((Control)z8Y1()).set_Size(new Size(10, 12));
		z8Y1().set_SizeMode((PictureBoxSizeMode)4);
		z8Y1().set_TabIndex(373);
		z8Y1().set_TabStop(false);
		((Control)Xk23()).set_Location(new Point(93, 146));
		((Control)Xk23()).set_Name("PictureBox37");
		((Control)Xk23()).set_Size(new Size(10, 12));
		Xk23().set_SizeMode((PictureBoxSizeMode)4);
		Xk23().set_TabIndex(372);
		Xk23().set_TabStop(false);
		((Control)c7XW()).set_Location(new Point(77, 146));
		((Control)c7XW()).set_Name("PictureBox38");
		((Control)c7XW()).set_Size(new Size(10, 12));
		c7XW().set_SizeMode((PictureBoxSizeMode)4);
		c7XW().set_TabIndex(371);
		c7XW().set_TabStop(false);
		((Control)q6S4()).set_Location(new Point(61, 146));
		((Control)q6S4()).set_Name("PictureBox39");
		((Control)q6S4()).set_Size(new Size(10, 12));
		q6S4().set_SizeMode((PictureBoxSizeMode)4);
		q6S4().set_TabIndex(370);
		q6S4().set_TabStop(false);
		((Control)j6E4()).set_Location(new Point(47, 146));
		((Control)j6E4()).set_Name("PictureBox40");
		((Control)j6E4()).set_Size(new Size(10, 12));
		j6E4().set_SizeMode((PictureBoxSizeMode)4);
		j6E4().set_TabIndex(369);
		j6E4().set_TabStop(false);
		j8Y7().set_AutoSize(true);
		((Control)j8Y7()).set_Location(new Point(368, 259));
		((Control)j8Y7()).set_Name("Label32");
		((Control)j8Y7()).set_Size(new Size(19, 13));
		((Control)j8Y7()).set_TabIndex(408);
		j8Y7().set_Text("20");
		y2FD().set_AutoSize(true);
		((Control)y2FD()).set_Location(new Point(275, 259));
		((Control)y2FD()).set_Name("Label33");
		((Control)y2FD()).set_Size(new Size(19, 13));
		((Control)y2FD()).set_TabIndex(407);
		y2FD().set_Text("15");
		Mp20().set_AutoSize(true);
		((Control)Mp20()).set_Location(new Point(310, 259));
		((Control)Mp20()).set_Name("Label34");
		((Control)Mp20()).set_Size(new Size(19, 13));
		((Control)Mp20()).set_TabIndex(406);
		Mp20().set_Text("17");
		Sp93().set_AutoSize(true);
		((Control)Sp93()).set_Location(new Point(329, 259));
		((Control)Sp93()).set_Name("Label35");
		((Control)Sp93()).set_Size(new Size(19, 13));
		((Control)Sp93()).set_TabIndex(405);
		Sp93().set_Text("18");
		Kz6i().set_AutoSize(true);
		((Control)Kz6i()).set_Location(new Point(348, 259));
		((Control)Kz6i()).set_Name("Label36");
		((Control)Kz6i()).set_Size(new Size(19, 13));
		((Control)Kz6i()).set_TabIndex(404);
		Kz6i().set_Text("19");
		Mj58().set_AutoSize(true);
		((Control)Mj58()).set_Location(new Point(223, 259));
		((Control)Mj58()).set_Name("Label37");
		((Control)Mj58()).set_Size(new Size(19, 13));
		((Control)Mj58()).set_TabIndex(403);
		Mj58().set_Text("12");
		Jr57().set_AutoSize(true);
		((Control)Jr57()).set_Location(new Point(92, 259));
		((Control)Jr57()).set_Name("Label38");
		((Control)Jr57()).set_Size(new Size(13, 13));
		((Control)Jr57()).set_TabIndex(402);
		Jr57().set_Text("4");
		Hm79().set_AutoSize(true);
		((Control)Hm79()).set_Location(new Point(241, 259));
		((Control)Hm79()).set_Name("Label39");
		((Control)Hm79()).set_Size(new Size(19, 13));
		((Control)Hm79()).set_TabIndex(401);
		Hm79().set_Text("13");
		Lb7j().set_AutoSize(true);
		((Control)Lb7j()).set_Location(new Point(292, 259));
		((Control)Lb7j()).set_Name("Label40");
		((Control)Lb7j()).set_Size(new Size(19, 13));
		((Control)Lb7j()).set_TabIndex(400);
		Lb7j().set_Text("16");
		x4W0().set_AutoSize(true);
		((Control)x4W0()).set_Location(new Point(206, 259));
		((Control)x4W0()).set_Name("Label41");
		((Control)x4W0()).set_Size(new Size(19, 13));
		((Control)x4W0()).set_TabIndex(399);
		x4W0().set_Text("11");
		b7ZA().set_AutoSize(true);
		((Control)b7ZA()).set_Location(new Point(257, 259));
		((Control)b7ZA()).set_Name("Label42");
		((Control)b7ZA()).set_Size(new Size(19, 13));
		((Control)b7ZA()).set_TabIndex(398);
		b7ZA().set_Text("14");
		Wc9n().set_AutoSize(true);
		((Control)Wc9n()).set_Location(new Point(156, 259));
		((Control)Wc9n()).set_Name("Label43");
		((Control)Wc9n()).set_Size(new Size(13, 13));
		((Control)Wc9n()).set_TabIndex(397);
		Wc9n().set_Text("8");
		Yx7p().set_AutoSize(true);
		((Control)Yx7p()).set_Location(new Point(188, 259));
		((Control)Yx7p()).set_Name("Label44");
		((Control)Yx7p()).set_Size(new Size(19, 13));
		((Control)Yx7p()).set_TabIndex(396);
		Yx7p().set_Text("10");
		Hj3g().set_AutoSize(true);
		((Control)Hj3g()).set_Location(new Point(172, 259));
		((Control)Hj3g()).set_Name("Label45");
		((Control)Hj3g()).set_Size(new Size(13, 13));
		((Control)Hj3g()).set_TabIndex(395);
		Hj3g().set_Text("9");
		b8BL().set_AutoSize(true);
		((Control)b8BL()).set_Location(new Point(140, 259));
		((Control)b8BL()).set_Name("Label46");
		((Control)b8BL()).set_Size(new Size(13, 13));
		((Control)b8BL()).set_TabIndex(394);
		b8BL().set_Text("7");
		Nz80().set_AutoSize(true);
		((Control)Nz80()).set_Location(new Point(124, 259));
		((Control)Nz80()).set_Name("Label47");
		((Control)Nz80()).set_Size(new Size(13, 13));
		((Control)Nz80()).set_TabIndex(393);
		Nz80().set_Text("6");
		Es46().set_AutoSize(true);
		((Control)Es46()).set_Location(new Point(108, 259));
		((Control)Es46()).set_Name("Label48");
		((Control)Es46()).set_Size(new Size(13, 13));
		((Control)Es46()).set_TabIndex(392);
		Es46().set_Text("5");
		a9T0().set_AutoSize(true);
		((Control)a9T0()).set_Location(new Point(76, 259));
		((Control)a9T0()).set_Name("Label49");
		((Control)a9T0()).set_Size(new Size(13, 13));
		((Control)a9T0()).set_TabIndex(391);
		a9T0().set_Text("3");
		q7DT().set_AutoSize(true);
		((Control)q7DT()).set_Location(new Point(60, 259));
		((Control)q7DT()).set_Name("Label50");
		((Control)q7DT()).set_Size(new Size(13, 13));
		((Control)q7DT()).set_TabIndex(390);
		q7DT().set_Text("2");
		n3E6().set_AutoSize(true);
		((Control)n3E6()).set_Location(new Point(44, 259));
		((Control)n3E6()).set_Name("Label51");
		((Control)n3E6()).set_Size(new Size(13, 13));
		((Control)n3E6()).set_TabIndex(389);
		n3E6().set_Text("1");
		((Control)t7W0()).set_Location(new Point(371, 168));
		((Control)t7W0()).set_Name("PictureBox41");
		((Control)t7W0()).set_Size(new Size(10, 12));
		t7W0().set_SizeMode((PictureBoxSizeMode)4);
		t7W0().set_TabIndex(428);
		t7W0().set_TabStop(false);
		((Control)c5SP()).set_Location(new Point(351, 168));
		((Control)c5SP()).set_Name("PictureBox42");
		((Control)c5SP()).set_Size(new Size(10, 12));
		c5SP().set_SizeMode((PictureBoxSizeMode)4);
		c5SP().set_TabIndex(427);
		c5SP().set_TabStop(false);
		((Control)Bt87()).set_Location(new Point(332, 168));
		((Control)Bt87()).set_Name("PictureBox43");
		((Control)Bt87()).set_Size(new Size(10, 12));
		Bt87().set_SizeMode((PictureBoxSizeMode)4);
		Bt87().set_TabIndex(426);
		Bt87().set_TabStop(false);
		((Control)c6M1()).set_Location(new Point(313, 168));
		((Control)c6M1()).set_Name("PictureBox44");
		((Control)c6M1()).set_Size(new Size(10, 12));
		c6M1().set_SizeMode((PictureBoxSizeMode)4);
		c6M1().set_TabIndex(425);
		c6M1().set_TabStop(false);
		((Control)Tn90()).set_Location(new Point(295, 168));
		((Control)Tn90()).set_Name("PictureBox45");
		((Control)Tn90()).set_Size(new Size(10, 12));
		Tn90().set_SizeMode((PictureBoxSizeMode)4);
		Tn90().set_TabIndex(424);
		Tn90().set_TabStop(false);
		((Control)c6L3()).set_Location(new Point(278, 168));
		((Control)c6L3()).set_Name("PictureBox46");
		((Control)c6L3()).set_Size(new Size(10, 12));
		c6L3().set_SizeMode((PictureBoxSizeMode)4);
		c6L3().set_TabIndex(423);
		c6L3().set_TabStop(false);
		((Control)Gd59()).set_Location(new Point(260, 168));
		((Control)Gd59()).set_Name("PictureBox47");
		((Control)Gd59()).set_Size(new Size(10, 12));
		Gd59().set_SizeMode((PictureBoxSizeMode)4);
		Gd59().set_TabIndex(422);
		Gd59().set_TabStop(false);
		((Control)n4QW()).set_Location(new Point(244, 168));
		((Control)n4QW()).set_Name("PictureBox48");
		((Control)n4QW()).set_Size(new Size(10, 12));
		n4QW().set_SizeMode((PictureBoxSizeMode)4);
		n4QW().set_TabIndex(421);
		n4QW().set_TabStop(false);
		((Control)Tk06()).set_Location(new Point(226, 168));
		((Control)Tk06()).set_Name("PictureBox49");
		((Control)Tk06()).set_Size(new Size(10, 12));
		Tk06().set_SizeMode((PictureBoxSizeMode)4);
		Tk06().set_TabIndex(420);
		Tk06().set_TabStop(false);
		((Control)d0XD()).set_Location(new Point(207, 168));
		((Control)d0XD()).set_Name("PictureBox50");
		((Control)d0XD()).set_Size(new Size(10, 12));
		d0XD().set_SizeMode((PictureBoxSizeMode)4);
		d0XD().set_TabIndex(419);
		d0XD().set_TabStop(false);
		((Control)n4BE()).set_Location(new Point(189, 168));
		((Control)n4BE()).set_Name("PictureBox51");
		((Control)n4BE()).set_Size(new Size(10, 12));
		n4BE().set_SizeMode((PictureBoxSizeMode)4);
		n4BE().set_TabIndex(418);
		n4BE().set_TabStop(false);
		((Control)e5A0()).set_Location(new Point(173, 168));
		((Control)e5A0()).set_Name("PictureBox52");
		((Control)e5A0()).set_Size(new Size(10, 12));
		e5A0().set_SizeMode((PictureBoxSizeMode)4);
		e5A0().set_TabIndex(417);
		e5A0().set_TabStop(false);
		((Control)Yy8t()).set_Location(new Point(157, 168));
		((Control)Yy8t()).set_Name("PictureBox53");
		((Control)Yy8t()).set_Size(new Size(10, 12));
		Yy8t().set_SizeMode((PictureBoxSizeMode)4);
		Yy8t().set_TabIndex(416);
		Yy8t().set_TabStop(false);
		((Control)Cz01()).set_Location(new Point(141, 168));
		((Control)Cz01()).set_Name("PictureBox54");
		((Control)Cz01()).set_Size(new Size(10, 12));
		Cz01().set_SizeMode((PictureBoxSizeMode)4);
		Cz01().set_TabIndex(415);
		Cz01().set_TabStop(false);
		((Control)Qp1f()).set_Location(new Point(125, 168));
		((Control)Qp1f()).set_Name("PictureBox55");
		((Control)Qp1f()).set_Size(new Size(10, 12));
		Qp1f().set_SizeMode((PictureBoxSizeMode)4);
		Qp1f().set_TabIndex(414);
		Qp1f().set_TabStop(false);
		((Control)k0FH()).set_Location(new Point(109, 168));
		((Control)k0FH()).set_Name("PictureBox56");
		((Control)k0FH()).set_Size(new Size(10, 12));
		k0FH().set_SizeMode((PictureBoxSizeMode)4);
		k0FH().set_TabIndex(413);
		k0FH().set_TabStop(false);
		((Control)Mn86()).set_Location(new Point(93, 168));
		((Control)Mn86()).set_Name("PictureBox57");
		((Control)Mn86()).set_Size(new Size(10, 12));
		Mn86().set_SizeMode((PictureBoxSizeMode)4);
		Mn86().set_TabIndex(412);
		Mn86().set_TabStop(false);
		((Control)Af08()).set_Location(new Point(77, 168));
		((Control)Af08()).set_Name("PictureBox58");
		((Control)Af08()).set_Size(new Size(10, 12));
		Af08().set_SizeMode((PictureBoxSizeMode)4);
		Af08().set_TabIndex(411);
		Af08().set_TabStop(false);
		((Control)y8Y3()).set_Location(new Point(61, 168));
		((Control)y8Y3()).set_Name("PictureBox59");
		((Control)y8Y3()).set_Size(new Size(10, 12));
		y8Y3().set_SizeMode((PictureBoxSizeMode)4);
		y8Y3().set_TabIndex(410);
		y8Y3().set_TabStop(false);
		((Control)g8JS()).set_Location(new Point(47, 168));
		((Control)g8JS()).set_Name("PictureBox60");
		((Control)g8JS()).set_Size(new Size(10, 12));
		g8JS().set_SizeMode((PictureBoxSizeMode)4);
		g8JS().set_TabIndex(409);
		g8JS().set_TabStop(false);
		((Control)Sp2w()).set_Location(new Point(371, 190));
		((Control)Sp2w()).set_Name("PictureBox61");
		((Control)Sp2w()).set_Size(new Size(10, 12));
		Sp2w().set_SizeMode((PictureBoxSizeMode)4);
		Sp2w().set_TabIndex(448);
		Sp2w().set_TabStop(false);
		((Control)c9R8()).set_Location(new Point(351, 190));
		((Control)c9R8()).set_Name("PictureBox62");
		((Control)c9R8()).set_Size(new Size(10, 12));
		c9R8().set_SizeMode((PictureBoxSizeMode)4);
		c9R8().set_TabIndex(447);
		c9R8().set_TabStop(false);
		((Control)r9Q8()).set_Location(new Point(332, 190));
		((Control)r9Q8()).set_Name("PictureBox63");
		((Control)r9Q8()).set_Size(new Size(10, 12));
		r9Q8().set_SizeMode((PictureBoxSizeMode)4);
		r9Q8().set_TabIndex(446);
		r9Q8().set_TabStop(false);
		((Control)f6L2()).set_Location(new Point(313, 190));
		((Control)f6L2()).set_Name("PictureBox64");
		((Control)f6L2()).set_Size(new Size(10, 12));
		f6L2().set_SizeMode((PictureBoxSizeMode)4);
		f6L2().set_TabIndex(445);
		f6L2().set_TabStop(false);
		((Control)Jq34()).set_Location(new Point(295, 190));
		((Control)Jq34()).set_Name("PictureBox65");
		((Control)Jq34()).set_Size(new Size(10, 12));
		Jq34().set_SizeMode((PictureBoxSizeMode)4);
		Jq34().set_TabIndex(444);
		Jq34().set_TabStop(false);
		((Control)n8FH()).set_Location(new Point(278, 190));
		((Control)n8FH()).set_Name("PictureBox66");
		((Control)n8FH()).set_Size(new Size(10, 12));
		n8FH().set_SizeMode((PictureBoxSizeMode)4);
		n8FH().set_TabIndex(443);
		n8FH().set_TabStop(false);
		((Control)o3W6()).set_Location(new Point(260, 190));
		((Control)o3W6()).set_Name("PictureBox67");
		((Control)o3W6()).set_Size(new Size(10, 12));
		o3W6().set_SizeMode((PictureBoxSizeMode)4);
		o3W6().set_TabIndex(442);
		o3W6().set_TabStop(false);
		((Control)c8E0()).set_Location(new Point(244, 190));
		((Control)c8E0()).set_Name("PictureBox68");
		((Control)c8E0()).set_Size(new Size(10, 12));
		c8E0().set_SizeMode((PictureBoxSizeMode)4);
		c8E0().set_TabIndex(441);
		c8E0().set_TabStop(false);
		((Control)q1N6()).set_Location(new Point(226, 190));
		((Control)q1N6()).set_Name("PictureBox69");
		((Control)q1N6()).set_Size(new Size(10, 12));
		q1N6().set_SizeMode((PictureBoxSizeMode)4);
		q1N6().set_TabIndex(440);
		q1N6().set_TabStop(false);
		((Control)n8B7()).set_Location(new Point(207, 190));
		((Control)n8B7()).set_Name("PictureBox70");
		((Control)n8B7()).set_Size(new Size(10, 12));
		n8B7().set_SizeMode((PictureBoxSizeMode)4);
		n8B7().set_TabIndex(439);
		n8B7().set_TabStop(false);
		((Control)a1P0()).set_Location(new Point(189, 190));
		((Control)a1P0()).set_Name("PictureBox71");
		((Control)a1P0()).set_Size(new Size(10, 12));
		a1P0().set_SizeMode((PictureBoxSizeMode)4);
		a1P0().set_TabIndex(438);
		a1P0().set_TabStop(false);
		((Control)Pf8a()).set_Location(new Point(173, 190));
		((Control)Pf8a()).set_Name("PictureBox72");
		((Control)Pf8a()).set_Size(new Size(10, 12));
		Pf8a().set_SizeMode((PictureBoxSizeMode)4);
		Pf8a().set_TabIndex(437);
		Pf8a().set_TabStop(false);
		((Control)f9ML()).set_Location(new Point(157, 190));
		((Control)f9ML()).set_Name("PictureBox73");
		((Control)f9ML()).set_Size(new Size(10, 12));
		f9ML().set_SizeMode((PictureBoxSizeMode)4);
		f9ML().set_TabIndex(436);
		f9ML().set_TabStop(false);
		((Control)To52()).set_Location(new Point(141, 190));
		((Control)To52()).set_Name("PictureBox74");
		((Control)To52()).set_Size(new Size(10, 12));
		To52().set_SizeMode((PictureBoxSizeMode)4);
		To52().set_TabIndex(435);
		To52().set_TabStop(false);
		((Control)c4MX()).set_Location(new Point(125, 190));
		((Control)c4MX()).set_Name("PictureBox75");
		((Control)c4MX()).set_Size(new Size(10, 12));
		c4MX().set_SizeMode((PictureBoxSizeMode)4);
		c4MX().set_TabIndex(434);
		c4MX().set_TabStop(false);
		((Control)Yq34()).set_Location(new Point(109, 190));
		((Control)Yq34()).set_Name("PictureBox76");
		((Control)Yq34()).set_Size(new Size(10, 12));
		Yq34().set_SizeMode((PictureBoxSizeMode)4);
		Yq34().set_TabIndex(433);
		Yq34().set_TabStop(false);
		((Control)Mi1b()).set_Location(new Point(93, 190));
		((Control)Mi1b()).set_Name("PictureBox77");
		((Control)Mi1b()).set_Size(new Size(10, 12));
		Mi1b().set_SizeMode((PictureBoxSizeMode)4);
		Mi1b().set_TabIndex(432);
		Mi1b().set_TabStop(false);
		((Control)x5S0()).set_Location(new Point(77, 190));
		((Control)x5S0()).set_Name("PictureBox78");
		((Control)x5S0()).set_Size(new Size(10, 12));
		x5S0().set_SizeMode((PictureBoxSizeMode)4);
		x5S0().set_TabIndex(431);
		x5S0().set_TabStop(false);
		((Control)Sg1w()).set_Location(new Point(61, 190));
		((Control)Sg1w()).set_Name("PictureBox79");
		((Control)Sg1w()).set_Size(new Size(10, 12));
		Sg1w().set_SizeMode((PictureBoxSizeMode)4);
		Sg1w().set_TabIndex(430);
		Sg1w().set_TabStop(false);
		((Control)f1RY()).set_Location(new Point(47, 190));
		((Control)f1RY()).set_Name("PictureBox80");
		((Control)f1RY()).set_Size(new Size(10, 12));
		f1RY().set_SizeMode((PictureBoxSizeMode)4);
		f1RY().set_TabIndex(429);
		f1RY().set_TabStop(false);
		((Control)m5ZS()).set_Location(new Point(371, 302));
		((Control)m5ZS()).set_Name("PictureBox81");
		((Control)m5ZS()).set_Size(new Size(10, 12));
		m5ZS().set_SizeMode((PictureBoxSizeMode)4);
		m5ZS().set_TabIndex(468);
		m5ZS().set_TabStop(false);
		((Control)p3J0()).set_Location(new Point(351, 302));
		((Control)p3J0()).set_Name("PictureBox82");
		((Control)p3J0()).set_Size(new Size(10, 12));
		p3J0().set_SizeMode((PictureBoxSizeMode)4);
		p3J0().set_TabIndex(467);
		p3J0().set_TabStop(false);
		((Control)y0B8()).set_Location(new Point(332, 302));
		((Control)y0B8()).set_Name("PictureBox83");
		((Control)y0B8()).set_Size(new Size(10, 12));
		y0B8().set_SizeMode((PictureBoxSizeMode)4);
		y0B8().set_TabIndex(466);
		y0B8().set_TabStop(false);
		((Control)Hy43()).set_Location(new Point(313, 302));
		((Control)Hy43()).set_Name("PictureBox84");
		((Control)Hy43()).set_Size(new Size(10, 12));
		Hy43().set_SizeMode((PictureBoxSizeMode)4);
		Hy43().set_TabIndex(465);
		Hy43().set_TabStop(false);
		((Control)q4Z6()).set_Location(new Point(295, 302));
		((Control)q4Z6()).set_Name("PictureBox85");
		((Control)q4Z6()).set_Size(new Size(10, 12));
		q4Z6().set_SizeMode((PictureBoxSizeMode)4);
		q4Z6().set_TabIndex(464);
		q4Z6().set_TabStop(false);
		((Control)k6BJ()).set_Location(new Point(278, 302));
		((Control)k6BJ()).set_Name("PictureBox86");
		((Control)k6BJ()).set_Size(new Size(10, 12));
		k6BJ().set_SizeMode((PictureBoxSizeMode)4);
		k6BJ().set_TabIndex(463);
		k6BJ().set_TabStop(false);
		((Control)w2WY()).set_Location(new Point(260, 302));
		((Control)w2WY()).set_Name("PictureBox87");
		((Control)w2WY()).set_Size(new Size(10, 12));
		w2WY().set_SizeMode((PictureBoxSizeMode)4);
		w2WY().set_TabIndex(462);
		w2WY().set_TabStop(false);
		((Control)Wt18()).set_Location(new Point(244, 302));
		((Control)Wt18()).set_Name("PictureBox88");
		((Control)Wt18()).set_Size(new Size(10, 12));
		Wt18().set_SizeMode((PictureBoxSizeMode)4);
		Wt18().set_TabIndex(461);
		Wt18().set_TabStop(false);
		((Control)a5Q3()).set_Location(new Point(226, 302));
		((Control)a5Q3()).set_Name("PictureBox89");
		((Control)a5Q3()).set_Size(new Size(10, 12));
		a5Q3().set_SizeMode((PictureBoxSizeMode)4);
		a5Q3().set_TabIndex(460);
		a5Q3().set_TabStop(false);
		((Control)Km41()).set_Location(new Point(207, 302));
		((Control)Km41()).set_Name("PictureBox90");
		((Control)Km41()).set_Size(new Size(10, 12));
		Km41().set_SizeMode((PictureBoxSizeMode)4);
		Km41().set_TabIndex(459);
		Km41().set_TabStop(false);
		((Control)Mg6r()).set_Location(new Point(189, 302));
		((Control)Mg6r()).set_Name("PictureBox91");
		((Control)Mg6r()).set_Size(new Size(10, 12));
		Mg6r().set_SizeMode((PictureBoxSizeMode)4);
		Mg6r().set_TabIndex(458);
		Mg6r().set_TabStop(false);
		((Control)Kq38()).set_Location(new Point(173, 302));
		((Control)Kq38()).set_Name("PictureBox92");
		((Control)Kq38()).set_Size(new Size(10, 12));
		Kq38().set_SizeMode((PictureBoxSizeMode)4);
		Kq38().set_TabIndex(457);
		Kq38().set_TabStop(false);
		((Control)d5DG()).set_Location(new Point(157, 302));
		((Control)d5DG()).set_Name("PictureBox93");
		((Control)d5DG()).set_Size(new Size(10, 12));
		d5DG().set_SizeMode((PictureBoxSizeMode)4);
		d5DG().set_TabIndex(456);
		d5DG().set_TabStop(false);
		((Control)Db05()).set_Location(new Point(141, 302));
		((Control)Db05()).set_Name("PictureBox94");
		((Control)Db05()).set_Size(new Size(10, 12));
		Db05().set_SizeMode((PictureBoxSizeMode)4);
		Db05().set_TabIndex(455);
		Db05().set_TabStop(false);
		((Control)g6KE()).set_Location(new Point(125, 302));
		((Control)g6KE()).set_Name("PictureBox95");
		((Control)g6KE()).set_Size(new Size(10, 12));
		g6KE().set_SizeMode((PictureBoxSizeMode)4);
		g6KE().set_TabIndex(454);
		g6KE().set_TabStop(false);
		((Control)Dx34()).set_Location(new Point(109, 302));
		((Control)Dx34()).set_Name("PictureBox96");
		((Control)Dx34()).set_Size(new Size(10, 12));
		Dx34().set_SizeMode((PictureBoxSizeMode)4);
		Dx34().set_TabIndex(453);
		Dx34().set_TabStop(false);
		((Control)Fm78()).set_Location(new Point(93, 302));
		((Control)Fm78()).set_Name("PictureBox97");
		((Control)Fm78()).set_Size(new Size(10, 12));
		Fm78().set_SizeMode((PictureBoxSizeMode)4);
		Fm78().set_TabIndex(452);
		Fm78().set_TabStop(false);
		((Control)z6AG()).set_Location(new Point(77, 302));
		((Control)z6AG()).set_Name("PictureBox98");
		((Control)z6AG()).set_Size(new Size(10, 12));
		z6AG().set_SizeMode((PictureBoxSizeMode)4);
		z6AG().set_TabIndex(451);
		z6AG().set_TabStop(false);
		((Control)Zt9m()).set_Location(new Point(61, 302));
		((Control)Zt9m()).set_Name("PictureBox99");
		((Control)Zt9m()).set_Size(new Size(10, 12));
		Zt9m().set_SizeMode((PictureBoxSizeMode)4);
		Zt9m().set_TabIndex(450);
		Zt9m().set_TabStop(false);
		((Control)Qe29()).set_Location(new Point(47, 302));
		((Control)Qe29()).set_Name("PictureBox100");
		((Control)Qe29()).set_Size(new Size(10, 12));
		Qe29().set_SizeMode((PictureBoxSizeMode)4);
		Qe29().set_TabIndex(449);
		Qe29().set_TabStop(false);
		((Control)k4HJ()).set_Location(new Point(371, 321));
		((Control)k4HJ()).set_Name("PictureBox101");
		((Control)k4HJ()).set_Size(new Size(10, 12));
		k4HJ().set_SizeMode((PictureBoxSizeMode)4);
		k4HJ().set_TabIndex(488);
		k4HJ().set_TabStop(false);
		((Control)m0Z1()).set_Location(new Point(351, 321));
		((Control)m0Z1()).set_Name("PictureBox102");
		((Control)m0Z1()).set_Size(new Size(10, 12));
		m0Z1().set_SizeMode((PictureBoxSizeMode)4);
		m0Z1().set_TabIndex(487);
		m0Z1().set_TabStop(false);
		((Control)Cb7m()).set_Location(new Point(332, 321));
		((Control)Cb7m()).set_Name("PictureBox103");
		((Control)Cb7m()).set_Size(new Size(10, 12));
		Cb7m().set_SizeMode((PictureBoxSizeMode)4);
		Cb7m().set_TabIndex(486);
		Cb7m().set_TabStop(false);
		((Control)y7H0()).set_Location(new Point(313, 321));
		((Control)y7H0()).set_Name("PictureBox104");
		((Control)y7H0()).set_Size(new Size(10, 12));
		y7H0().set_SizeMode((PictureBoxSizeMode)4);
		y7H0().set_TabIndex(485);
		y7H0().set_TabStop(false);
		((Control)r5D3()).set_Location(new Point(295, 321));
		((Control)r5D3()).set_Name("PictureBox105");
		((Control)r5D3()).set_Size(new Size(10, 12));
		r5D3().set_SizeMode((PictureBoxSizeMode)4);
		r5D3().set_TabIndex(484);
		r5D3().set_TabStop(false);
		((Control)Zy9o()).set_Location(new Point(278, 321));
		((Control)Zy9o()).set_Name("PictureBox106");
		((Control)Zy9o()).set_Size(new Size(10, 12));
		Zy9o().set_SizeMode((PictureBoxSizeMode)4);
		Zy9o().set_TabIndex(483);
		Zy9o().set_TabStop(false);
		((Control)Gt91()).set_Location(new Point(260, 321));
		((Control)Gt91()).set_Name("PictureBox107");
		((Control)Gt91()).set_Size(new Size(10, 12));
		Gt91().set_SizeMode((PictureBoxSizeMode)4);
		Gt91().set_TabIndex(482);
		Gt91().set_TabStop(false);
		((Control)An90()).set_Location(new Point(244, 321));
		((Control)An90()).set_Name("PictureBox108");
		((Control)An90()).set_Size(new Size(10, 12));
		An90().set_SizeMode((PictureBoxSizeMode)4);
		An90().set_TabIndex(481);
		An90().set_TabStop(false);
		((Control)z0N9()).set_Location(new Point(226, 321));
		((Control)z0N9()).set_Name("PictureBox109");
		((Control)z0N9()).set_Size(new Size(10, 12));
		z0N9().set_SizeMode((PictureBoxSizeMode)4);
		z0N9().set_TabIndex(480);
		z0N9().set_TabStop(false);
		((Control)i9Z6()).set_Location(new Point(207, 321));
		((Control)i9Z6()).set_Name("PictureBox110");
		((Control)i9Z6()).set_Size(new Size(10, 12));
		i9Z6().set_SizeMode((PictureBoxSizeMode)4);
		i9Z6().set_TabIndex(479);
		i9Z6().set_TabStop(false);
		((Control)Ky85()).set_Location(new Point(189, 321));
		((Control)Ky85()).set_Name("PictureBox111");
		((Control)Ky85()).set_Size(new Size(10, 12));
		Ky85().set_SizeMode((PictureBoxSizeMode)4);
		Ky85().set_TabIndex(478);
		Ky85().set_TabStop(false);
		((Control)Cz6x()).set_Location(new Point(173, 321));
		((Control)Cz6x()).set_Name("PictureBox112");
		((Control)Cz6x()).set_Size(new Size(10, 12));
		Cz6x().set_SizeMode((PictureBoxSizeMode)4);
		Cz6x().set_TabIndex(477);
		Cz6x().set_TabStop(false);
		((Control)Aj42()).set_Location(new Point(157, 321));
		((Control)Aj42()).set_Name("PictureBox113");
		((Control)Aj42()).set_Size(new Size(10, 12));
		Aj42().set_SizeMode((PictureBoxSizeMode)4);
		Aj42().set_TabIndex(476);
		Aj42().set_TabStop(false);
		((Control)Sb5y()).set_Location(new Point(141, 321));
		((Control)Sb5y()).set_Name("PictureBox114");
		((Control)Sb5y()).set_Size(new Size(10, 12));
		Sb5y().set_SizeMode((PictureBoxSizeMode)4);
		Sb5y().set_TabIndex(475);
		Sb5y().set_TabStop(false);
		((Control)Wn95()).set_Location(new Point(125, 321));
		((Control)Wn95()).set_Name("PictureBox115");
		((Control)Wn95()).set_Size(new Size(10, 12));
		Wn95().set_SizeMode((PictureBoxSizeMode)4);
		Wn95().set_TabIndex(474);
		Wn95().set_TabStop(false);
		((Control)k0M9()).set_Location(new Point(109, 321));
		((Control)k0M9()).set_Name("PictureBox116");
		((Control)k0M9()).set_Size(new Size(10, 12));
		k0M9().set_SizeMode((PictureBoxSizeMode)4);
		k0M9().set_TabIndex(473);
		k0M9().set_TabStop(false);
		((Control)z4T5()).set_Location(new Point(93, 321));
		((Control)z4T5()).set_Name("PictureBox117");
		((Control)z4T5()).set_Size(new Size(10, 12));
		z4T5().set_SizeMode((PictureBoxSizeMode)4);
		z4T5().set_TabIndex(472);
		z4T5().set_TabStop(false);
		((Control)s3F4()).set_Location(new Point(77, 321));
		((Control)s3F4()).set_Name("PictureBox118");
		((Control)s3F4()).set_Size(new Size(10, 12));
		s3F4().set_SizeMode((PictureBoxSizeMode)4);
		s3F4().set_TabIndex(471);
		s3F4().set_TabStop(false);
		((Control)Kt56()).set_Location(new Point(61, 321));
		((Control)Kt56()).set_Name("PictureBox119");
		((Control)Kt56()).set_Size(new Size(10, 12));
		Kt56().set_SizeMode((PictureBoxSizeMode)4);
		Kt56().set_TabIndex(470);
		Kt56().set_TabStop(false);
		((Control)m9ZA()).set_Location(new Point(47, 321));
		((Control)m9ZA()).set_Name("PictureBox120");
		((Control)m9ZA()).set_Size(new Size(10, 12));
		m9ZA().set_SizeMode((PictureBoxSizeMode)4);
		m9ZA().set_TabIndex(469);
		m9ZA().set_TabStop(false);
		((Control)y6G4()).set_Location(new Point(371, 343));
		((Control)y6G4()).set_Name("PictureBox121");
		((Control)y6G4()).set_Size(new Size(10, 12));
		y6G4().set_SizeMode((PictureBoxSizeMode)4);
		y6G4().set_TabIndex(508);
		y6G4().set_TabStop(false);
		((Control)Jc96()).set_Location(new Point(351, 343));
		((Control)Jc96()).set_Name("PictureBox122");
		((Control)Jc96()).set_Size(new Size(10, 12));
		Jc96().set_SizeMode((PictureBoxSizeMode)4);
		Jc96().set_TabIndex(507);
		Jc96().set_TabStop(false);
		((Control)i8MH()).set_Location(new Point(332, 343));
		((Control)i8MH()).set_Name("PictureBox123");
		((Control)i8MH()).set_Size(new Size(10, 12));
		i8MH().set_SizeMode((PictureBoxSizeMode)4);
		i8MH().set_TabIndex(506);
		i8MH().set_TabStop(false);
		((Control)a6AR()).set_Location(new Point(313, 343));
		((Control)a6AR()).set_Name("PictureBox124");
		((Control)a6AR()).set_Size(new Size(10, 12));
		a6AR().set_SizeMode((PictureBoxSizeMode)4);
		a6AR().set_TabIndex(505);
		a6AR().set_TabStop(false);
		((Control)r6Q8()).set_Location(new Point(295, 343));
		((Control)r6Q8()).set_Name("PictureBox125");
		((Control)r6Q8()).set_Size(new Size(10, 12));
		r6Q8().set_SizeMode((PictureBoxSizeMode)4);
		r6Q8().set_TabIndex(504);
		r6Q8().set_TabStop(false);
		((Control)s1E4()).set_Location(new Point(278, 343));
		((Control)s1E4()).set_Name("PictureBox126");
		((Control)s1E4()).set_Size(new Size(10, 12));
		s1E4().set_SizeMode((PictureBoxSizeMode)4);
		s1E4().set_TabIndex(503);
		s1E4().set_TabStop(false);
		((Control)b7TB()).set_Location(new Point(260, 343));
		((Control)b7TB()).set_Name("PictureBox127");
		((Control)b7TB()).set_Size(new Size(10, 12));
		b7TB().set_SizeMode((PictureBoxSizeMode)4);
		b7TB().set_TabIndex(502);
		b7TB().set_TabStop(false);
		((Control)Jo1d()).set_Location(new Point(244, 343));
		((Control)Jo1d()).set_Name("PictureBox128");
		((Control)Jo1d()).set_Size(new Size(10, 12));
		Jo1d().set_SizeMode((PictureBoxSizeMode)4);
		Jo1d().set_TabIndex(501);
		Jo1d().set_TabStop(false);
		((Control)Kj57()).set_Location(new Point(226, 343));
		((Control)Kj57()).set_Name("PictureBox129");
		((Control)Kj57()).set_Size(new Size(10, 12));
		Kj57().set_SizeMode((PictureBoxSizeMode)4);
		Kj57().set_TabIndex(500);
		Kj57().set_TabStop(false);
		((Control)b0LK()).set_Location(new Point(207, 343));
		((Control)b0LK()).set_Name("PictureBox130");
		((Control)b0LK()).set_Size(new Size(10, 12));
		b0LK().set_SizeMode((PictureBoxSizeMode)4);
		b0LK().set_TabIndex(499);
		b0LK().set_TabStop(false);
		((Control)Hc0s()).set_Location(new Point(189, 343));
		((Control)Hc0s()).set_Name("PictureBox131");
		((Control)Hc0s()).set_Size(new Size(10, 12));
		Hc0s().set_SizeMode((PictureBoxSizeMode)4);
		Hc0s().set_TabIndex(498);
		Hc0s().set_TabStop(false);
		((Control)q6WX()).set_Location(new Point(173, 343));
		((Control)q6WX()).set_Name("PictureBox132");
		((Control)q6WX()).set_Size(new Size(10, 12));
		q6WX().set_SizeMode((PictureBoxSizeMode)4);
		q6WX().set_TabIndex(497);
		q6WX().set_TabStop(false);
		((Control)Mn68()).set_Location(new Point(157, 343));
		((Control)Mn68()).set_Name("PictureBox133");
		((Control)Mn68()).set_Size(new Size(10, 12));
		Mn68().set_SizeMode((PictureBoxSizeMode)4);
		Mn68().set_TabIndex(496);
		Mn68().set_TabStop(false);
		((Control)Zr7j()).set_Location(new Point(141, 343));
		((Control)Zr7j()).set_Name("PictureBox134");
		((Control)Zr7j()).set_Size(new Size(10, 12));
		Zr7j().set_SizeMode((PictureBoxSizeMode)4);
		Zr7j().set_TabIndex(495);
		Zr7j().set_TabStop(false);
		((Control)Nw1k()).set_Location(new Point(125, 343));
		((Control)Nw1k()).set_Name("PictureBox135");
		((Control)Nw1k()).set_Size(new Size(10, 12));
		Nw1k().set_SizeMode((PictureBoxSizeMode)4);
		Nw1k().set_TabIndex(494);
		Nw1k().set_TabStop(false);
		((Control)x6P9()).set_Location(new Point(109, 343));
		((Control)x6P9()).set_Name("PictureBox136");
		((Control)x6P9()).set_Size(new Size(10, 12));
		x6P9().set_SizeMode((PictureBoxSizeMode)4);
		x6P9().set_TabIndex(493);
		x6P9().set_TabStop(false);
		((Control)Te6p()).set_Location(new Point(93, 343));
		((Control)Te6p()).set_Name("PictureBox137");
		((Control)Te6p()).set_Size(new Size(10, 12));
		Te6p().set_SizeMode((PictureBoxSizeMode)4);
		Te6p().set_TabIndex(492);
		Te6p().set_TabStop(false);
		((Control)Kw09()).set_Location(new Point(77, 343));
		((Control)Kw09()).set_Name("PictureBox138");
		((Control)Kw09()).set_Size(new Size(10, 12));
		Kw09().set_SizeMode((PictureBoxSizeMode)4);
		Kw09().set_TabIndex(491);
		Kw09().set_TabStop(false);
		((Control)Ca45()).set_Location(new Point(61, 343));
		((Control)Ca45()).set_Name("PictureBox139");
		((Control)Ca45()).set_Size(new Size(10, 12));
		Ca45().set_SizeMode((PictureBoxSizeMode)4);
		Ca45().set_TabIndex(490);
		Ca45().set_TabStop(false);
		((Control)t0Y1()).set_Location(new Point(47, 343));
		((Control)t0Y1()).set_Name("PictureBox140");
		((Control)t0Y1()).set_Size(new Size(10, 12));
		t0Y1().set_SizeMode((PictureBoxSizeMode)4);
		t0Y1().set_TabIndex(489);
		t0Y1().set_TabStop(false);
		((Control)j7CK()).set_Location(new Point(371, 365));
		((Control)j7CK()).set_Name("PictureBox141");
		((Control)j7CK()).set_Size(new Size(10, 12));
		j7CK().set_SizeMode((PictureBoxSizeMode)4);
		j7CK().set_TabIndex(528);
		j7CK().set_TabStop(false);
		((Control)Ex36()).set_Location(new Point(351, 365));
		((Control)Ex36()).set_Name("PictureBox142");
		((Control)Ex36()).set_Size(new Size(10, 12));
		Ex36().set_SizeMode((PictureBoxSizeMode)4);
		Ex36().set_TabIndex(527);
		Ex36().set_TabStop(false);
		((Control)Fs14()).set_Location(new Point(332, 365));
		((Control)Fs14()).set_Name("PictureBox143");
		((Control)Fs14()).set_Size(new Size(10, 12));
		Fs14().set_SizeMode((PictureBoxSizeMode)4);
		Fs14().set_TabIndex(526);
		Fs14().set_TabStop(false);
		((Control)Aj9m()).set_Location(new Point(313, 365));
		((Control)Aj9m()).set_Name("PictureBox144");
		((Control)Aj9m()).set_Size(new Size(10, 12));
		Aj9m().set_SizeMode((PictureBoxSizeMode)4);
		Aj9m().set_TabIndex(525);
		Aj9m().set_TabStop(false);
		((Control)g3Y9()).set_Location(new Point(295, 365));
		((Control)g3Y9()).set_Name("PictureBox145");
		((Control)g3Y9()).set_Size(new Size(10, 12));
		g3Y9().set_SizeMode((PictureBoxSizeMode)4);
		g3Y9().set_TabIndex(524);
		g3Y9().set_TabStop(false);
		((Control)Gn7g()).set_Location(new Point(278, 365));
		((Control)Gn7g()).set_Name("PictureBox146");
		((Control)Gn7g()).set_Size(new Size(10, 12));
		Gn7g().set_SizeMode((PictureBoxSizeMode)4);
		Gn7g().set_TabIndex(523);
		Gn7g().set_TabStop(false);
		((Control)z4P6()).set_Location(new Point(260, 365));
		((Control)z4P6()).set_Name("PictureBox147");
		((Control)z4P6()).set_Size(new Size(10, 12));
		z4P6().set_SizeMode((PictureBoxSizeMode)4);
		z4P6().set_TabIndex(522);
		z4P6().set_TabStop(false);
		((Control)Wt50()).set_Location(new Point(244, 365));
		((Control)Wt50()).set_Name("PictureBox148");
		((Control)Wt50()).set_Size(new Size(10, 12));
		Wt50().set_SizeMode((PictureBoxSizeMode)4);
		Wt50().set_TabIndex(521);
		Wt50().set_TabStop(false);
		((Control)o8DK()).set_Location(new Point(226, 365));
		((Control)o8DK()).set_Name("PictureBox149");
		((Control)o8DK()).set_Size(new Size(10, 12));
		o8DK().set_SizeMode((PictureBoxSizeMode)4);
		o8DK().set_TabIndex(520);
		o8DK().set_TabStop(false);
		((Control)Kk79()).set_Location(new Point(207, 365));
		((Control)Kk79()).set_Name("PictureBox150");
		((Control)Kk79()).set_Size(new Size(10, 12));
		Kk79().set_SizeMode((PictureBoxSizeMode)4);
		Kk79().set_TabIndex(519);
		Kk79().set_TabStop(false);
		((Control)Qf18()).set_Location(new Point(189, 365));
		((Control)Qf18()).set_Name("PictureBox151");
		((Control)Qf18()).set_Size(new Size(10, 12));
		Qf18().set_SizeMode((PictureBoxSizeMode)4);
		Qf18().set_TabIndex(518);
		Qf18().set_TabStop(false);
		((Control)Rp15()).set_Location(new Point(173, 365));
		((Control)Rp15()).set_Name("PictureBox152");
		((Control)Rp15()).set_Size(new Size(10, 12));
		Rp15().set_SizeMode((PictureBoxSizeMode)4);
		Rp15().set_TabIndex(517);
		Rp15().set_TabStop(false);
		((Control)Si9m()).set_Location(new Point(157, 365));
		((Control)Si9m()).set_Name("PictureBox153");
		((Control)Si9m()).set_Size(new Size(10, 12));
		Si9m().set_SizeMode((PictureBoxSizeMode)4);
		Si9m().set_TabIndex(516);
		Si9m().set_TabStop(false);
		((Control)j4R2()).set_Location(new Point(141, 365));
		((Control)j4R2()).set_Name("PictureBox154");
		((Control)j4R2()).set_Size(new Size(10, 12));
		j4R2().set_SizeMode((PictureBoxSizeMode)4);
		j4R2().set_TabIndex(515);
		j4R2().set_TabStop(false);
		((Control)Di90()).set_Location(new Point(125, 365));
		((Control)Di90()).set_Name("PictureBox155");
		((Control)Di90()).set_Size(new Size(10, 12));
		Di90().set_SizeMode((PictureBoxSizeMode)4);
		Di90().set_TabIndex(514);
		Di90().set_TabStop(false);
		((Control)w6EC()).set_Location(new Point(109, 365));
		((Control)w6EC()).set_Name("PictureBox156");
		((Control)w6EC()).set_Size(new Size(10, 12));
		w6EC().set_SizeMode((PictureBoxSizeMode)4);
		w6EC().set_TabIndex(513);
		w6EC().set_TabStop(false);
		((Control)z7XY()).set_Location(new Point(93, 365));
		((Control)z7XY()).set_Name("PictureBox157");
		((Control)z7XY()).set_Size(new Size(10, 12));
		z7XY().set_SizeMode((PictureBoxSizeMode)4);
		z7XY().set_TabIndex(512);
		z7XY().set_TabStop(false);
		((Control)Mr9()).set_Location(new Point(77, 365));
		((Control)Mr9()).set_Name("PictureBox158");
		((Control)Mr9()).set_Size(new Size(10, 12));
		Mr9().set_SizeMode((PictureBoxSizeMode)4);
		Mr9().set_TabIndex(511);
		Mr9().set_TabStop(false);
		((Control)a6E()).set_Location(new Point(61, 365));
		((Control)a6E()).set_Name("PictureBox159");
		((Control)a6E()).set_Size(new Size(10, 12));
		a6E().set_SizeMode((PictureBoxSizeMode)4);
		a6E().set_TabIndex(510);
		a6E().set_TabStop(false);
		((Control)Zm3()).set_Location(new Point(47, 365));
		((Control)Zm3()).set_Name("PictureBox160");
		((Control)Zm3()).set_Size(new Size(10, 12));
		Zm3().set_SizeMode((PictureBoxSizeMode)4);
		Zm3().set_TabIndex(509);
		Zm3().set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)j7CK());
		((Control)this).get_Controls().Add((Control)(object)Ex36());
		((Control)this).get_Controls().Add((Control)(object)Fs14());
		((Control)this).get_Controls().Add((Control)(object)Aj9m());
		((Control)this).get_Controls().Add((Control)(object)g3Y9());
		((Control)this).get_Controls().Add((Control)(object)Gn7g());
		((Control)this).get_Controls().Add((Control)(object)z4P6());
		((Control)this).get_Controls().Add((Control)(object)Wt50());
		((Control)this).get_Controls().Add((Control)(object)o8DK());
		((Control)this).get_Controls().Add((Control)(object)Kk79());
		((Control)this).get_Controls().Add((Control)(object)Qf18());
		((Control)this).get_Controls().Add((Control)(object)Rp15());
		((Control)this).get_Controls().Add((Control)(object)Si9m());
		((Control)this).get_Controls().Add((Control)(object)j4R2());
		((Control)this).get_Controls().Add((Control)(object)Di90());
		((Control)this).get_Controls().Add((Control)(object)w6EC());
		((Control)this).get_Controls().Add((Control)(object)z7XY());
		((Control)this).get_Controls().Add((Control)(object)Mr9());
		((Control)this).get_Controls().Add((Control)(object)a6E());
		((Control)this).get_Controls().Add((Control)(object)Zm3());
		((Control)this).get_Controls().Add((Control)(object)y6G4());
		((Control)this).get_Controls().Add((Control)(object)Jc96());
		((Control)this).get_Controls().Add((Control)(object)i8MH());
		((Control)this).get_Controls().Add((Control)(object)a6AR());
		((Control)this).get_Controls().Add((Control)(object)r6Q8());
		((Control)this).get_Controls().Add((Control)(object)s1E4());
		((Control)this).get_Controls().Add((Control)(object)b7TB());
		((Control)this).get_Controls().Add((Control)(object)Jo1d());
		((Control)this).get_Controls().Add((Control)(object)Kj57());
		((Control)this).get_Controls().Add((Control)(object)b0LK());
		((Control)this).get_Controls().Add((Control)(object)Hc0s());
		((Control)this).get_Controls().Add((Control)(object)q6WX());
		((Control)this).get_Controls().Add((Control)(object)Mn68());
		((Control)this).get_Controls().Add((Control)(object)Zr7j());
		((Control)this).get_Controls().Add((Control)(object)Nw1k());
		((Control)this).get_Controls().Add((Control)(object)x6P9());
		((Control)this).get_Controls().Add((Control)(object)Te6p());
		((Control)this).get_Controls().Add((Control)(object)Kw09());
		((Control)this).get_Controls().Add((Control)(object)Ca45());
		((Control)this).get_Controls().Add((Control)(object)t0Y1());
		((Control)this).get_Controls().Add((Control)(object)k4HJ());
		((Control)this).get_Controls().Add((Control)(object)m0Z1());
		((Control)this).get_Controls().Add((Control)(object)Cb7m());
		((Control)this).get_Controls().Add((Control)(object)y7H0());
		((Control)this).get_Controls().Add((Control)(object)r5D3());
		((Control)this).get_Controls().Add((Control)(object)Zy9o());
		((Control)this).get_Controls().Add((Control)(object)Gt91());
		((Control)this).get_Controls().Add((Control)(object)An90());
		((Control)this).get_Controls().Add((Control)(object)z0N9());
		((Control)this).get_Controls().Add((Control)(object)i9Z6());
		((Control)this).get_Controls().Add((Control)(object)Ky85());
		((Control)this).get_Controls().Add((Control)(object)Cz6x());
		((Control)this).get_Controls().Add((Control)(object)Aj42());
		((Control)this).get_Controls().Add((Control)(object)Sb5y());
		((Control)this).get_Controls().Add((Control)(object)Wn95());
		((Control)this).get_Controls().Add((Control)(object)k0M9());
		((Control)this).get_Controls().Add((Control)(object)z4T5());
		((Control)this).get_Controls().Add((Control)(object)s3F4());
		((Control)this).get_Controls().Add((Control)(object)Kt56());
		((Control)this).get_Controls().Add((Control)(object)m9ZA());
		((Control)this).get_Controls().Add((Control)(object)m5ZS());
		((Control)this).get_Controls().Add((Control)(object)p3J0());
		((Control)this).get_Controls().Add((Control)(object)y0B8());
		((Control)this).get_Controls().Add((Control)(object)Hy43());
		((Control)this).get_Controls().Add((Control)(object)q4Z6());
		((Control)this).get_Controls().Add((Control)(object)k6BJ());
		((Control)this).get_Controls().Add((Control)(object)w2WY());
		((Control)this).get_Controls().Add((Control)(object)Wt18());
		((Control)this).get_Controls().Add((Control)(object)a5Q3());
		((Control)this).get_Controls().Add((Control)(object)Km41());
		((Control)this).get_Controls().Add((Control)(object)Mg6r());
		((Control)this).get_Controls().Add((Control)(object)Kq38());
		((Control)this).get_Controls().Add((Control)(object)d5DG());
		((Control)this).get_Controls().Add((Control)(object)Db05());
		((Control)this).get_Controls().Add((Control)(object)g6KE());
		((Control)this).get_Controls().Add((Control)(object)Dx34());
		((Control)this).get_Controls().Add((Control)(object)Fm78());
		((Control)this).get_Controls().Add((Control)(object)z6AG());
		((Control)this).get_Controls().Add((Control)(object)Zt9m());
		((Control)this).get_Controls().Add((Control)(object)Qe29());
		((Control)this).get_Controls().Add((Control)(object)Sp2w());
		((Control)this).get_Controls().Add((Control)(object)c9R8());
		((Control)this).get_Controls().Add((Control)(object)r9Q8());
		((Control)this).get_Controls().Add((Control)(object)f6L2());
		((Control)this).get_Controls().Add((Control)(object)Jq34());
		((Control)this).get_Controls().Add((Control)(object)n8FH());
		((Control)this).get_Controls().Add((Control)(object)o3W6());
		((Control)this).get_Controls().Add((Control)(object)c8E0());
		((Control)this).get_Controls().Add((Control)(object)q1N6());
		((Control)this).get_Controls().Add((Control)(object)n8B7());
		((Control)this).get_Controls().Add((Control)(object)a1P0());
		((Control)this).get_Controls().Add((Control)(object)Pf8a());
		((Control)this).get_Controls().Add((Control)(object)f9ML());
		((Control)this).get_Controls().Add((Control)(object)To52());
		((Control)this).get_Controls().Add((Control)(object)c4MX());
		((Control)this).get_Controls().Add((Control)(object)Yq34());
		((Control)this).get_Controls().Add((Control)(object)Mi1b());
		((Control)this).get_Controls().Add((Control)(object)x5S0());
		((Control)this).get_Controls().Add((Control)(object)Sg1w());
		((Control)this).get_Controls().Add((Control)(object)f1RY());
		((Control)this).get_Controls().Add((Control)(object)t7W0());
		((Control)this).get_Controls().Add((Control)(object)c5SP());
		((Control)this).get_Controls().Add((Control)(object)Bt87());
		((Control)this).get_Controls().Add((Control)(object)c6M1());
		((Control)this).get_Controls().Add((Control)(object)Tn90());
		((Control)this).get_Controls().Add((Control)(object)c6L3());
		((Control)this).get_Controls().Add((Control)(object)Gd59());
		((Control)this).get_Controls().Add((Control)(object)n4QW());
		((Control)this).get_Controls().Add((Control)(object)Tk06());
		((Control)this).get_Controls().Add((Control)(object)d0XD());
		((Control)this).get_Controls().Add((Control)(object)n4BE());
		((Control)this).get_Controls().Add((Control)(object)e5A0());
		((Control)this).get_Controls().Add((Control)(object)Yy8t());
		((Control)this).get_Controls().Add((Control)(object)Cz01());
		((Control)this).get_Controls().Add((Control)(object)Qp1f());
		((Control)this).get_Controls().Add((Control)(object)k0FH());
		((Control)this).get_Controls().Add((Control)(object)Mn86());
		((Control)this).get_Controls().Add((Control)(object)Af08());
		((Control)this).get_Controls().Add((Control)(object)y8Y3());
		((Control)this).get_Controls().Add((Control)(object)g8JS());
		((Control)this).get_Controls().Add((Control)(object)j8Y7());
		((Control)this).get_Controls().Add((Control)(object)y2FD());
		((Control)this).get_Controls().Add((Control)(object)Mp20());
		((Control)this).get_Controls().Add((Control)(object)Sp93());
		((Control)this).get_Controls().Add((Control)(object)Kz6i());
		((Control)this).get_Controls().Add((Control)(object)Mj58());
		((Control)this).get_Controls().Add((Control)(object)Jr57());
		((Control)this).get_Controls().Add((Control)(object)Hm79());
		((Control)this).get_Controls().Add((Control)(object)Lb7j());
		((Control)this).get_Controls().Add((Control)(object)x4W0());
		((Control)this).get_Controls().Add((Control)(object)b7ZA());
		((Control)this).get_Controls().Add((Control)(object)Wc9n());
		((Control)this).get_Controls().Add((Control)(object)Yx7p());
		((Control)this).get_Controls().Add((Control)(object)Hj3g());
		((Control)this).get_Controls().Add((Control)(object)b8BL());
		((Control)this).get_Controls().Add((Control)(object)Nz80());
		((Control)this).get_Controls().Add((Control)(object)Es46());
		((Control)this).get_Controls().Add((Control)(object)a9T0());
		((Control)this).get_Controls().Add((Control)(object)q7DT());
		((Control)this).get_Controls().Add((Control)(object)n3E6());
		((Control)this).get_Controls().Add((Control)(object)r4EP());
		((Control)this).get_Controls().Add((Control)(object)r0L1());
		((Control)this).get_Controls().Add((Control)(object)Cy0f());
		((Control)this).get_Controls().Add((Control)(object)Wi1e());
		((Control)this).get_Controls().Add((Control)(object)Za6d());
		((Control)this).get_Controls().Add((Control)(object)Ny87());
		((Control)this).get_Controls().Add((Control)(object)z9F3());
		((Control)this).get_Controls().Add((Control)(object)m6EQ());
		((Control)this).get_Controls().Add((Control)(object)Nx18());
		((Control)this).get_Controls().Add((Control)(object)Ek37());
		((Control)this).get_Controls().Add((Control)(object)Bs59());
		((Control)this).get_Controls().Add((Control)(object)k2Q5());
		((Control)this).get_Controls().Add((Control)(object)c0X4());
		((Control)this).get_Controls().Add((Control)(object)Gf7o());
		((Control)this).get_Controls().Add((Control)(object)n7R1());
		((Control)this).get_Controls().Add((Control)(object)z8Y1());
		((Control)this).get_Controls().Add((Control)(object)Xk23());
		((Control)this).get_Controls().Add((Control)(object)c7XW());
		((Control)this).get_Controls().Add((Control)(object)q6S4());
		((Control)this).get_Controls().Add((Control)(object)j6E4());
		((Control)this).get_Controls().Add((Control)(object)f1E6());
		((Control)this).get_Controls().Add((Control)(object)Sb7e());
		((Control)this).get_Controls().Add((Control)(object)Qj0e());
		((Control)this).get_Controls().Add((Control)(object)g9ZW());
		((Control)this).get_Controls().Add((Control)(object)Tg8n());
		((Control)this).get_Controls().Add((Control)(object)Xx2q());
		((Control)this).get_Controls().Add((Control)(object)Ng4x());
		((Control)this).get_Controls().Add((Control)(object)g6XB());
		((Control)this).get_Controls().Add((Control)(object)Sa51());
		((Control)this).get_Controls().Add((Control)(object)i8RF());
		((Control)this).get_Controls().Add((Control)(object)Kn21());
		((Control)this).get_Controls().Add((Control)(object)k9WH());
		((Control)this).get_Controls().Add((Control)(object)x7RX());
		((Control)this).get_Controls().Add((Control)(object)o5P6());
		((Control)this).get_Controls().Add((Control)(object)j7HB());
		((Control)this).get_Controls().Add((Control)(object)x9A1());
		((Control)this).get_Controls().Add((Control)(object)Ge5g());
		((Control)this).get_Controls().Add((Control)(object)Da4b());
		((Control)this).get_Controls().Add((Control)(object)x1Z9());
		((Control)this).get_Controls().Add((Control)(object)Kq14());
		((Control)this).get_Controls().Add((Control)(object)b4D0());
		((Control)this).get_Controls().Add((Control)(object)n6Z7());
		((Control)this).get_Controls().Add((Control)(object)Kk6q());
		((Control)this).get_Controls().Add((Control)(object)Jm4t());
		((Control)this).get_Controls().Add((Control)(object)Jn45());
		((Control)this).get_Controls().Add((Control)(object)Ti17());
		((Control)this).get_Controls().Add((Control)(object)Lq23());
		((Control)this).get_Controls().Add((Control)(object)c1HE());
		((Control)this).get_Controls().Add((Control)(object)o8CJ());
		((Control)this).get_Controls().Add((Control)(object)w8T3());
		((Control)this).get_Controls().Add((Control)(object)Qx4a());
		((Control)this).get_Controls().Add((Control)(object)Yy30());
		((Control)this).get_Controls().Add((Control)(object)s2XF());
		((Control)this).get_Controls().Add((Control)(object)He7w());
		((Control)this).get_Controls().Add((Control)(object)z8N3());
		((Control)this).get_Controls().Add((Control)(object)Lr6a());
		((Control)this).get_Controls().Add((Control)(object)Ab9x());
		((Control)this).get_Controls().Add((Control)(object)Gn7b());
		((Control)this).get_Controls().Add((Control)(object)Yn39());
		((Control)this).get_Controls().Add((Control)(object)y0H6());
		((Control)this).get_Controls().Add((Control)(object)r2MG());
		((Control)this).get_Controls().Add((Control)(object)b8H5());
		((Control)this).get_Controls().Add((Control)(object)o3W9());
		((Control)this).get_Controls().Add((Control)(object)Dw9s());
		((Control)this).get_Controls().Add((Control)(object)Ze27());
		((Control)this).get_Controls().Add((Control)(object)Rt6k());
		((Control)this).get_Controls().Add((Control)(object)z7TN());
		((Control)this).get_Controls().Add((Control)(object)Ny4k());
		((Control)this).get_Controls().Add((Control)(object)Cq5n());
		((Control)this).get_Controls().Add((Control)(object)y8WN());
		((Control)this).get_Controls().Add((Control)(object)Fx8t());
		((Control)this).get_Controls().Add((Control)(object)Ld52());
		((Control)this).get_Controls().Add((Control)(object)w6QX());
		((Control)this).get_Controls().Add((Control)(object)Qg5y());
		((Control)this).get_Controls().Add((Control)(object)Xt6z());
		((Control)this).get_Controls().Add((Control)(object)z0H6());
		((Control)this).get_Controls().Add((Control)(object)g3CY());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 1");
		((ISupportInitialize)g3CY()).EndInit();
		((ISupportInitialize)z0H6()).EndInit();
		((Control)Qg5y()).ResumeLayout(false);
		((Control)Qg5y()).PerformLayout();
		((ISupportInitialize)Wc36()).EndInit();
		((ISupportInitialize)Fa2y()).EndInit();
		((ISupportInitialize)Ka17()).EndInit();
		((Control)w6QX()).ResumeLayout(false);
		((Control)w6QX()).PerformLayout();
		((Control)Ld52()).ResumeLayout(false);
		((ISupportInitialize)Cd0t()).EndInit();
		((Control)Fx8t()).ResumeLayout(false);
		((Control)Fx8t()).PerformLayout();
		((ISupportInitialize)Kq14()).EndInit();
		((ISupportInitialize)x1Z9()).EndInit();
		((ISupportInitialize)Da4b()).EndInit();
		((ISupportInitialize)Ge5g()).EndInit();
		((ISupportInitialize)x9A1()).EndInit();
		((ISupportInitialize)j7HB()).EndInit();
		((ISupportInitialize)o5P6()).EndInit();
		((ISupportInitialize)x7RX()).EndInit();
		((ISupportInitialize)k9WH()).EndInit();
		((ISupportInitialize)Kn21()).EndInit();
		((ISupportInitialize)i8RF()).EndInit();
		((ISupportInitialize)Sa51()).EndInit();
		((ISupportInitialize)g6XB()).EndInit();
		((ISupportInitialize)Ng4x()).EndInit();
		((ISupportInitialize)Xx2q()).EndInit();
		((ISupportInitialize)Tg8n()).EndInit();
		((ISupportInitialize)g9ZW()).EndInit();
		((ISupportInitialize)Qj0e()).EndInit();
		((ISupportInitialize)Sb7e()).EndInit();
		((ISupportInitialize)f1E6()).EndInit();
		((ISupportInitialize)r4EP()).EndInit();
		((ISupportInitialize)r0L1()).EndInit();
		((ISupportInitialize)Cy0f()).EndInit();
		((ISupportInitialize)Wi1e()).EndInit();
		((ISupportInitialize)Za6d()).EndInit();
		((ISupportInitialize)Ny87()).EndInit();
		((ISupportInitialize)z9F3()).EndInit();
		((ISupportInitialize)m6EQ()).EndInit();
		((ISupportInitialize)Nx18()).EndInit();
		((ISupportInitialize)Ek37()).EndInit();
		((ISupportInitialize)Bs59()).EndInit();
		((ISupportInitialize)k2Q5()).EndInit();
		((ISupportInitialize)c0X4()).EndInit();
		((ISupportInitialize)Gf7o()).EndInit();
		((ISupportInitialize)n7R1()).EndInit();
		((ISupportInitialize)z8Y1()).EndInit();
		((ISupportInitialize)Xk23()).EndInit();
		((ISupportInitialize)c7XW()).EndInit();
		((ISupportInitialize)q6S4()).EndInit();
		((ISupportInitialize)j6E4()).EndInit();
		((ISupportInitialize)t7W0()).EndInit();
		((ISupportInitialize)c5SP()).EndInit();
		((ISupportInitialize)Bt87()).EndInit();
		((ISupportInitialize)c6M1()).EndInit();
		((ISupportInitialize)Tn90()).EndInit();
		((ISupportInitialize)c6L3()).EndInit();
		((ISupportInitialize)Gd59()).EndInit();
		((ISupportInitialize)n4QW()).EndInit();
		((ISupportInitialize)Tk06()).EndInit();
		((ISupportInitialize)d0XD()).EndInit();
		((ISupportInitialize)n4BE()).EndInit();
		((ISupportInitialize)e5A0()).EndInit();
		((ISupportInitialize)Yy8t()).EndInit();
		((ISupportInitialize)Cz01()).EndInit();
		((ISupportInitialize)Qp1f()).EndInit();
		((ISupportInitialize)k0FH()).EndInit();
		((ISupportInitialize)Mn86()).EndInit();
		((ISupportInitialize)Af08()).EndInit();
		((ISupportInitialize)y8Y3()).EndInit();
		((ISupportInitialize)g8JS()).EndInit();
		((ISupportInitialize)Sp2w()).EndInit();
		((ISupportInitialize)c9R8()).EndInit();
		((ISupportInitialize)r9Q8()).EndInit();
		((ISupportInitialize)f6L2()).EndInit();
		((ISupportInitialize)Jq34()).EndInit();
		((ISupportInitialize)n8FH()).EndInit();
		((ISupportInitialize)o3W6()).EndInit();
		((ISupportInitialize)c8E0()).EndInit();
		((ISupportInitialize)q1N6()).EndInit();
		((ISupportInitialize)n8B7()).EndInit();
		((ISupportInitialize)a1P0()).EndInit();
		((ISupportInitialize)Pf8a()).EndInit();
		((ISupportInitialize)f9ML()).EndInit();
		((ISupportInitialize)To52()).EndInit();
		((ISupportInitialize)c4MX()).EndInit();
		((ISupportInitialize)Yq34()).EndInit();
		((ISupportInitialize)Mi1b()).EndInit();
		((ISupportInitialize)x5S0()).EndInit();
		((ISupportInitialize)Sg1w()).EndInit();
		((ISupportInitialize)f1RY()).EndInit();
		((ISupportInitialize)m5ZS()).EndInit();
		((ISupportInitialize)p3J0()).EndInit();
		((ISupportInitialize)y0B8()).EndInit();
		((ISupportInitialize)Hy43()).EndInit();
		((ISupportInitialize)q4Z6()).EndInit();
		((ISupportInitialize)k6BJ()).EndInit();
		((ISupportInitialize)w2WY()).EndInit();
		((ISupportInitialize)Wt18()).EndInit();
		((ISupportInitialize)a5Q3()).EndInit();
		((ISupportInitialize)Km41()).EndInit();
		((ISupportInitialize)Mg6r()).EndInit();
		((ISupportInitialize)Kq38()).EndInit();
		((ISupportInitialize)d5DG()).EndInit();
		((ISupportInitialize)Db05()).EndInit();
		((ISupportInitialize)g6KE()).EndInit();
		((ISupportInitialize)Dx34()).EndInit();
		((ISupportInitialize)Fm78()).EndInit();
		((ISupportInitialize)z6AG()).EndInit();
		((ISupportInitialize)Zt9m()).EndInit();
		((ISupportInitialize)Qe29()).EndInit();
		((ISupportInitialize)k4HJ()).EndInit();
		((ISupportInitialize)m0Z1()).EndInit();
		((ISupportInitialize)Cb7m()).EndInit();
		((ISupportInitialize)y7H0()).EndInit();
		((ISupportInitialize)r5D3()).EndInit();
		((ISupportInitialize)Zy9o()).EndInit();
		((ISupportInitialize)Gt91()).EndInit();
		((ISupportInitialize)An90()).EndInit();
		((ISupportInitialize)z0N9()).EndInit();
		((ISupportInitialize)i9Z6()).EndInit();
		((ISupportInitialize)Ky85()).EndInit();
		((ISupportInitialize)Cz6x()).EndInit();
		((ISupportInitialize)Aj42()).EndInit();
		((ISupportInitialize)Sb5y()).EndInit();
		((ISupportInitialize)Wn95()).EndInit();
		((ISupportInitialize)k0M9()).EndInit();
		((ISupportInitialize)z4T5()).EndInit();
		((ISupportInitialize)s3F4()).EndInit();
		((ISupportInitialize)Kt56()).EndInit();
		((ISupportInitialize)m9ZA()).EndInit();
		((ISupportInitialize)y6G4()).EndInit();
		((ISupportInitialize)Jc96()).EndInit();
		((ISupportInitialize)i8MH()).EndInit();
		((ISupportInitialize)a6AR()).EndInit();
		((ISupportInitialize)r6Q8()).EndInit();
		((ISupportInitialize)s1E4()).EndInit();
		((ISupportInitialize)b7TB()).EndInit();
		((ISupportInitialize)Jo1d()).EndInit();
		((ISupportInitialize)Kj57()).EndInit();
		((ISupportInitialize)b0LK()).EndInit();
		((ISupportInitialize)Hc0s()).EndInit();
		((ISupportInitialize)q6WX()).EndInit();
		((ISupportInitialize)Mn68()).EndInit();
		((ISupportInitialize)Zr7j()).EndInit();
		((ISupportInitialize)Nw1k()).EndInit();
		((ISupportInitialize)x6P9()).EndInit();
		((ISupportInitialize)Te6p()).EndInit();
		((ISupportInitialize)Kw09()).EndInit();
		((ISupportInitialize)Ca45()).EndInit();
		((ISupportInitialize)t0Y1()).EndInit();
		((ISupportInitialize)j7CK()).EndInit();
		((ISupportInitialize)Ex36()).EndInit();
		((ISupportInitialize)Fs14()).EndInit();
		((ISupportInitialize)Aj9m()).EndInit();
		((ISupportInitialize)g3Y9()).EndInit();
		((ISupportInitialize)Gn7g()).EndInit();
		((ISupportInitialize)z4P6()).EndInit();
		((ISupportInitialize)Wt50()).EndInit();
		((ISupportInitialize)o8DK()).EndInit();
		((ISupportInitialize)Kk79()).EndInit();
		((ISupportInitialize)Qf18()).EndInit();
		((ISupportInitialize)Rp15()).EndInit();
		((ISupportInitialize)Si9m()).EndInit();
		((ISupportInitialize)j4R2()).EndInit();
		((ISupportInitialize)Di90()).EndInit();
		((ISupportInitialize)w6EC()).EndInit();
		((ISupportInitialize)z7XY()).EndInit();
		((ISupportInitialize)Mr9()).EndInit();
		((ISupportInitialize)a6E()).EndInit();
		((ISupportInitialize)Zm3()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox g3CY()
	{
		return _NameBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3Z5(PictureBox Li26)
	{
		_NameBox = Li26;
	}

	[SpecialName]
	internal virtual PictureBox z0H6()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8AR(PictureBox Kt96)
	{
		PictureBox val = (c = Kt96);
	}

	[SpecialName]
	internal virtual Label Xt6z()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1P4(Label b9WR)
	{
		Label val = (m = b9WR);
	}

	[SpecialName]
	internal virtual GroupBox Qg5y()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1K2(GroupBox Ki67)
	{
		GroupBox val = (V = Ki67);
	}

	[SpecialName]
	internal virtual GroupBox w6QX()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay23(GroupBox Nk8e)
	{
		_GroupBox2 = Nk8e;
	}

	[SpecialName]
	internal virtual GroupBox Ld52()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx7w(GroupBox Sn46)
	{
		GroupBox val = (t = Sn46);
	}

	[SpecialName]
	internal virtual GroupBox Fx8t()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1FR(GroupBox k0LZ)
	{
		GroupBox val = (j = k0LZ);
	}

	[SpecialName]
	internal virtual PictureBox Cd0t()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0GT(PictureBox Wp93)
	{
		_Cover = Wp93;
	}

	[SpecialName]
	internal virtual TextBox t9K2()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc28(TextBox k2FJ)
	{
		_txtProvisional = k2FJ;
	}

	[SpecialName]
	internal virtual TextBox z6C9()
	{
		return _txtBooked;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me51(TextBox s8PC)
	{
		_txtBooked = s8PC;
	}

	[SpecialName]
	internal virtual TextBox i5ZA()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5EX(TextBox Wt25)
	{
		TextBox val = (B = Wt25);
	}

	[SpecialName]
	internal virtual PictureBox Wc36()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3AK(PictureBox o8F6)
	{
		PictureBox val = (w = o8F6);
	}

	[SpecialName]
	internal virtual PictureBox Fa2y()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3LY(PictureBox w0C7)
	{
		PictureBox val = (n = w0C7);
	}

	[SpecialName]
	internal virtual PictureBox Ka17()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ef7q(PictureBox j1A0)
	{
		PictureBox val = (a = j1A0);
	}

	[SpecialName]
	internal virtual Label Fy2z()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo2q(Label r5LP)
	{
		Label val = (i = r5LP);
	}

	[SpecialName]
	internal virtual Label Mw9b()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6B5(Label s3Q1)
	{
		Label val = (L = s3Q1);
	}

	[SpecialName]
	internal virtual Label b8JG()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rg4c(Label s6D4)
	{
		_Label2 = s6D4;
	}

	[SpecialName]
	internal virtual Label y8WN()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He9c(Label Lx97)
	{
		_Label4 = Lx97;
	}

	[SpecialName]
	internal virtual Label Cq5n()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0LR(Label y3S0)
	{
		_Label5 = y3S0;
	}

	[SpecialName]
	internal virtual Label Ny4k()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5NS(Label t3E6)
	{
		Label val = (U = t3E6);
	}

	[SpecialName]
	internal virtual Label z7TN()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3Y0(Label Lr04)
	{
		_Label8 = Lr04;
	}

	[SpecialName]
	internal virtual Label Rt6k()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1CJ(Label f8X5)
	{
		Label val = (X = f8X5);
	}

	[SpecialName]
	internal virtual Label Ze27()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1MB(Label Qa79)
	{
		Label val = (Q = Qa79);
	}

	[SpecialName]
	internal virtual Label Dw9s()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd4w(Label Ep19)
	{
		_Label11 = Ep19;
	}

	[SpecialName]
	internal virtual Label o3W9()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wk1d(Label Dy3d)
	{
		Label val = (G = Dy3d);
	}

	[SpecialName]
	internal virtual Label b8H5()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bp8c(Label Ao42)
	{
		Label val = (r = Ao42);
	}

	[SpecialName]
	internal virtual Label r2MG()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zp76(Label i8Z3)
	{
		Label val = (s = i8Z3);
	}

	[SpecialName]
	internal virtual Label y0H6()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3B5(Label Ac3k)
	{
		_Label15 = Ac3k;
	}

	[SpecialName]
	internal virtual Label Yn39()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3N0(Label x8DL)
	{
		_Label16 = x8DL;
	}

	[SpecialName]
	internal virtual Label Gn7b()
	{
		return _Label17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qk86(Label f7H2)
	{
		_Label17 = f7H2;
	}

	[SpecialName]
	internal virtual Label Ab9x()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hb1c(Label o0ZW)
	{
		Label val = (d = o0ZW);
	}

	[SpecialName]
	internal virtual Label Lr6a()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ax20(Label q6GZ)
	{
		_Label19 = q6GZ;
	}

	[SpecialName]
	internal virtual Label z8N3()
	{
		return _Label20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj6m(Label r0H1)
	{
		_Label20 = r0H1;
	}

	[SpecialName]
	internal virtual Label s2XF()
	{
		return _Label22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg9f(Label Tp84)
	{
		_Label22 = Tp84;
	}

	[SpecialName]
	internal virtual Label Yy30()
	{
		return _Label23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6R4(Label Hg4o)
	{
		_Label23 = Hg4o;
	}

	[SpecialName]
	internal virtual Label Qx4a()
	{
		return _Label24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd90(Label p7D3)
	{
		_Label24 = p7D3;
	}

	[SpecialName]
	internal virtual Label Jn45()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4H1(Label Jb7j)
	{
		Label val = (P = Jb7j);
	}

	[SpecialName]
	internal virtual Label Ti17()
	{
		return _Label27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6AC(Label d3XC)
	{
		_Label27 = d3XC;
	}

	[SpecialName]
	internal virtual Label Lq23()
	{
		return _Label28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0XL(Label Ec1m)
	{
		_Label28 = Ec1m;
	}

	[SpecialName]
	internal virtual Label c1HE()
	{
		return _Label29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj2s(Label k8G0)
	{
		_Label29 = k8G0;
	}

	[SpecialName]
	internal virtual Label o8CJ()
	{
		return _Label30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz7b(Label n5G0)
	{
		_Label30 = n5G0;
	}

	[SpecialName]
	internal virtual Label Jm4t()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq3f(Label Qk25)
	{
		Label val = (O = Qk25);
	}

	[SpecialName]
	internal virtual Label b4D0()
	{
		return _Label54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sa8m(Label f8Y5)
	{
		_Label54 = f8Y5;
	}

	[SpecialName]
	internal virtual Label n6Z7()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2T4(Label j6P4)
	{
		_Label55 = j6P4;
	}

	[SpecialName]
	internal virtual Label Kk6q()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk56(Label Lq04)
	{
		Label val = (E = Lq04);
	}

	[SpecialName]
	internal virtual TextBox p5R9()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6R7(TextBox d3MQ)
	{
		TextBox val = (H = d3MQ);
	}

	[SpecialName]
	internal virtual TextBox Dj8x()
	{
		return _txtID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7DZ(TextBox Cy8g)
	{
		_txtID = Cy8g;
	}

	[SpecialName]
	internal virtual Label f8N2()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1AK(Label Bo8k)
	{
		Label val = (Y = Bo8k);
	}

	[SpecialName]
	internal virtual Label Rd70()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dw7p(Label b4M0)
	{
		Label val = (K = b4M0);
	}

	[SpecialName]
	internal virtual TextBox d7HZ()
	{
		return _txtChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2B8(TextBox z6RX)
	{
		_txtChange = z6RX;
	}

	[SpecialName]
	internal virtual TextBox a3N6()
	{
		return _txtTotalPayment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw8x(TextBox i7WR)
	{
		_txtTotalPayment = i7WR;
	}

	[SpecialName]
	internal virtual TextBox k4YG()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2PM(TextBox p8H2)
	{
		TextBox val = (F = p8H2);
	}

	[SpecialName]
	internal virtual TextBox r2B9()
	{
		return _txtSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hn91(TextBox b3P9)
	{
		_txtSeats = b3P9;
	}

	[SpecialName]
	internal virtual Label r3W9()
	{
		return _Label63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8HW(Label t6S2)
	{
		_Label63 = t6S2;
	}

	[SpecialName]
	internal virtual Label My14()
	{
		return Z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7F6(Label a9C6)
	{
		Label val = (Z = a9C6);
	}

	[SpecialName]
	internal virtual Label Rq2e()
	{
		return _Label61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qj3z(Label c8L4)
	{
		_Label61 = c8L4;
	}

	[SpecialName]
	internal virtual Label Ji37()
	{
		return mc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3ZT(Label Bf3a)
	{
		Label val = (mc = Bf3a);
	}

	[SpecialName]
	internal virtual Label He7w()
	{
		return _Label21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tm7b(Label Qa01)
	{
		_Label21 = Qa01;
	}

	[SpecialName]
	internal virtual Label w8T3()
	{
		return mm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ck9j(Label Zq56)
	{
		Label val = (mm = Zq56);
	}

	[SpecialName]
	internal virtual PictureBox Kq14()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3D5(PictureBox Rx5e)
	{
		_PictureBox1 = Rx5e;
	}

	[SpecialName]
	internal virtual PictureBox x1Z9()
	{
		return mV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp8z(PictureBox e2PK)
	{
		PictureBox val = (mV = e2PK);
	}

	[SpecialName]
	internal virtual PictureBox Da4b()
	{
		return mt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3H8(PictureBox Zr9s)
	{
		PictureBox val = (mt = Zr9s);
	}

	[SpecialName]
	internal virtual PictureBox Ge5g()
	{
		return mj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs8b(PictureBox Gx6z)
	{
		PictureBox val = (mj = Gx6z);
	}

	[SpecialName]
	internal virtual PictureBox x9A1()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp2e(PictureBox a7Z9)
	{
		_PictureBox5 = a7Z9;
	}

	[SpecialName]
	internal virtual PictureBox j7HB()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1S5(PictureBox Bi16)
	{
		_PictureBox6 = Bi16;
	}

	[SpecialName]
	internal virtual PictureBox o5P6()
	{
		return mB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2KG(PictureBox Pe0m)
	{
		PictureBox val = (mB = Pe0m);
	}

	[SpecialName]
	internal virtual PictureBox x7RX()
	{
		return mw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0Q2(PictureBox o0BT)
	{
		PictureBox val = (mw = o0BT);
	}

	[SpecialName]
	internal virtual PictureBox k9WH()
	{
		return mn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9W5(PictureBox x2G3)
	{
		PictureBox val = (mn = x2G3);
	}

	[SpecialName]
	internal virtual PictureBox Kn21()
	{
		return ma;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1J3(PictureBox Pp16)
	{
		PictureBox val = (ma = Pp16);
	}

	[SpecialName]
	internal virtual PictureBox i8RF()
	{
		return mi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm7w(PictureBox b9WA)
	{
		PictureBox val = (mi = b9WA);
	}

	[SpecialName]
	internal virtual PictureBox Sa51()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg0s(PictureBox Sb37)
	{
		_PictureBox12 = Sb37;
	}

	[SpecialName]
	internal virtual PictureBox g6XB()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gc60(PictureBox Qr7c)
	{
		_PictureBox13 = Qr7c;
	}

	[SpecialName]
	internal virtual PictureBox Ng4x()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yk39(PictureBox m1D0)
	{
		_PictureBox14 = m1D0;
	}

	[SpecialName]
	internal virtual PictureBox Xx2q()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1Z9(PictureBox Xg6y)
	{
		_PictureBox15 = Xg6y;
	}

	[SpecialName]
	internal virtual PictureBox Tg8n()
	{
		return mL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8G7(PictureBox Ra86)
	{
		PictureBox val = (mL = Ra86);
	}

	[SpecialName]
	internal virtual PictureBox g9ZW()
	{
		return mU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8N2(PictureBox x4CK)
	{
		PictureBox val = (mU = x4CK);
	}

	[SpecialName]
	internal virtual PictureBox Qj0e()
	{
		return mX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go20(PictureBox Sk6w)
	{
		PictureBox val = (mX = Sk6w);
	}

	[SpecialName]
	internal virtual PictureBox Sb7e()
	{
		return mQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fc8o(PictureBox w0A7)
	{
		PictureBox val = (mQ = w0A7);
	}

	[SpecialName]
	internal virtual PictureBox f1E6()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4K7(PictureBox j8HB)
	{
		_PictureBox20 = j8HB;
	}

	[SpecialName]
	internal virtual PictureBox r4EP()
	{
		return mG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8H5(PictureBox e7AE)
	{
		PictureBox val = (mG = e7AE);
	}

	[SpecialName]
	internal virtual PictureBox r0L1()
	{
		return mr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wc52(PictureBox r2TA)
	{
		PictureBox val = (mr = r2TA);
	}

	[SpecialName]
	internal virtual PictureBox Cy0f()
	{
		return _PictureBox23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wc4t(PictureBox Lk60)
	{
		_PictureBox23 = Lk60;
	}

	[SpecialName]
	internal virtual PictureBox Wi1e()
	{
		return ms;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2AE(PictureBox t3XD)
	{
		PictureBox val = (ms = t3XD);
	}

	[SpecialName]
	internal virtual PictureBox Za6d()
	{
		return _PictureBox25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk7p(PictureBox z4Q2)
	{
		_PictureBox25 = z4Q2;
	}

	[SpecialName]
	internal virtual PictureBox Ny87()
	{
		return md;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xg04(PictureBox Sg39)
	{
		PictureBox val = (md = Sg39);
	}

	[SpecialName]
	internal virtual PictureBox z9F3()
	{
		return mP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wj2m(PictureBox Ca7b)
	{
		PictureBox val = (mP = Ca7b);
	}

	[SpecialName]
	internal virtual PictureBox m6EQ()
	{
		return mO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp32(PictureBox f2J0)
	{
		PictureBox val = (mO = f2J0);
	}

	[SpecialName]
	internal virtual PictureBox Nx18()
	{
		return mE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1QY(PictureBox Rb76)
	{
		PictureBox val = (mE = Rb76);
	}

	[SpecialName]
	internal virtual PictureBox Ek37()
	{
		return _PictureBox30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dg21(PictureBox Zz8r)
	{
		_PictureBox30 = Zz8r;
	}

	[SpecialName]
	internal virtual PictureBox Bs59()
	{
		return _PictureBox31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3W8(PictureBox Qr7f)
	{
		_PictureBox31 = Qr7f;
	}

	[SpecialName]
	internal virtual PictureBox k2Q5()
	{
		return _PictureBox32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc54(PictureBox i9K7)
	{
		_PictureBox32 = i9K7;
	}

	[SpecialName]
	internal virtual PictureBox c0X4()
	{
		return _PictureBox33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1J7(PictureBox Cy58)
	{
		_PictureBox33 = Cy58;
	}

	[SpecialName]
	internal virtual PictureBox Gf7o()
	{
		return _PictureBox34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4F5(PictureBox f8Z2)
	{
		_PictureBox34 = f8Z2;
	}

	[SpecialName]
	internal virtual PictureBox n7R1()
	{
		return mH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ze4w(PictureBox b0KP)
	{
		PictureBox val = (mH = b0KP);
	}

	[SpecialName]
	internal virtual PictureBox z8Y1()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yb1o(PictureBox s3K8)
	{
		_PictureBox36 = s3K8;
	}

	[SpecialName]
	internal virtual PictureBox Xk23()
	{
		return _PictureBox37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rd5z(PictureBox Jy48)
	{
		_PictureBox37 = Jy48;
	}

	[SpecialName]
	internal virtual PictureBox c7XW()
	{
		return mY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9GN(PictureBox x4YW)
	{
		PictureBox val = (mY = x4YW);
	}

	[SpecialName]
	internal virtual PictureBox q6S4()
	{
		return _PictureBox39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf3k(PictureBox t9C4)
	{
		_PictureBox39 = t9C4;
	}

	[SpecialName]
	internal virtual PictureBox j6E4()
	{
		return _PictureBox40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1BR(PictureBox Rc20)
	{
		_PictureBox40 = Rc20;
	}

	[SpecialName]
	internal virtual Label j8Y7()
	{
		return _Label32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6Q2(Label s4M1)
	{
		_Label32 = s4M1;
	}

	[SpecialName]
	internal virtual Label y2FD()
	{
		return _Label33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ma17(Label Ji8f)
	{
		_Label33 = Ji8f;
	}

	[SpecialName]
	internal virtual Label Mp20()
	{
		return _Label34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex3g(Label Nw3t)
	{
		_Label34 = Nw3t;
	}

	[SpecialName]
	internal virtual Label Sp93()
	{
		return mK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez5a(Label Gj6f)
	{
		Label val = (mK = Gj6f);
	}

	[SpecialName]
	internal virtual Label Kz6i()
	{
		return mF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1LB(Label Qb21)
	{
		Label val = (mF = Qb21);
	}

	[SpecialName]
	internal virtual Label Mj58()
	{
		return _Label37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1BN(Label Bb7x)
	{
		_Label37 = Bb7x;
	}

	[SpecialName]
	internal virtual Label Jr57()
	{
		return mZ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ea9c(Label Ky30)
	{
		Label val = (mZ = Ky30);
	}

	[SpecialName]
	internal virtual Label Hm79()
	{
		return Vc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3MQ(Label Je43)
	{
		Label val = (Vc = Je43);
	}

	[SpecialName]
	internal virtual Label Lb7j()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0WY(Label Rd49)
	{
		_Label40 = Rd49;
	}

	[SpecialName]
	internal virtual Label x4W0()
	{
		return Vm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3QP(Label Xs8g)
	{
		Label val = (Vm = Xs8g);
	}

	[SpecialName]
	internal virtual Label b7ZA()
	{
		return _Label42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2W4(Label Xm0c)
	{
		_Label42 = Xm0c;
	}

	[SpecialName]
	internal virtual Label Wc9n()
	{
		return _Label43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ad1i(Label e8BF)
	{
		_Label43 = e8BF;
	}

	[SpecialName]
	internal virtual Label Yx7p()
	{
		return _Label44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6LN(Label y1H6)
	{
		_Label44 = y1H6;
	}

	[SpecialName]
	internal virtual Label Hj3g()
	{
		return VV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fi92(Label k5YX)
	{
		Label val = (VV = k5YX);
	}

	[SpecialName]
	internal virtual Label b8BL()
	{
		return _Label46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz13(Label m9M7)
	{
		_Label46 = m9M7;
	}

	[SpecialName]
	internal virtual Label Nz80()
	{
		return Vt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn75(Label Cm9z)
	{
		Label val = (Vt = Cm9z);
	}

	[SpecialName]
	internal virtual Label Es46()
	{
		return Vj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s9W3(Label p5RF)
	{
		Label val = (Vj = p5RF);
	}

	[SpecialName]
	internal virtual Label a9T0()
	{
		return _Label49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj93(Label Rt40)
	{
		_Label49 = Rt40;
	}

	[SpecialName]
	internal virtual Label q7DT()
	{
		return VB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bq25(Label r5F4)
	{
		Label val = (VB = r5F4);
	}

	[SpecialName]
	internal virtual Label n3E6()
	{
		return _Label51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pz1n(Label s7QW)
	{
		_Label51 = s7QW;
	}

	[SpecialName]
	internal virtual PictureBox t7W0()
	{
		return Vw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn1q(PictureBox Jx62)
	{
		PictureBox val = (Vw = Jx62);
	}

	[SpecialName]
	internal virtual PictureBox c5SP()
	{
		return Vn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4NQ(PictureBox Jf6x)
	{
		PictureBox val = (Vn = Jf6x);
	}

	[SpecialName]
	internal virtual PictureBox Bt87()
	{
		return Va;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6GN(PictureBox Bd3o)
	{
		PictureBox val = (Va = Bd3o);
	}

	[SpecialName]
	internal virtual PictureBox c6M1()
	{
		return _PictureBox44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns0o(PictureBox b4YN)
	{
		_PictureBox44 = b4YN;
	}

	[SpecialName]
	internal virtual PictureBox Tn90()
	{
		return Vi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Za1q(PictureBox c4F9)
	{
		PictureBox val = (Vi = c4F9);
	}

	[SpecialName]
	internal virtual PictureBox c6L3()
	{
		return _PictureBox46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz92(PictureBox b5TW)
	{
		_PictureBox46 = b5TW;
	}

	[SpecialName]
	internal virtual PictureBox Gd59()
	{
		return VL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j4WM(PictureBox Kz74)
	{
		PictureBox val = (VL = Kz74);
	}

	[SpecialName]
	internal virtual PictureBox n4QW()
	{
		return _PictureBox48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc5f(PictureBox Pz6f)
	{
		_PictureBox48 = Pz6f;
	}

	[SpecialName]
	internal virtual PictureBox Tk06()
	{
		return VU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jb9e(PictureBox k7GF)
	{
		PictureBox val = (VU = k7GF);
	}

	[SpecialName]
	internal virtual PictureBox d0XD()
	{
		return VX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rj0m(PictureBox Wo53)
	{
		PictureBox val = (VX = Wo53);
	}

	[SpecialName]
	internal virtual PictureBox n4BE()
	{
		return _PictureBox51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jg9w(PictureBox y7SB)
	{
		_PictureBox51 = y7SB;
	}

	[SpecialName]
	internal virtual PictureBox e5A0()
	{
		return VQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4T2(PictureBox w0HS)
	{
		PictureBox val = (VQ = w0HS);
	}

	[SpecialName]
	internal virtual PictureBox Yy8t()
	{
		return VG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5AL(PictureBox g8E7)
	{
		PictureBox val = (VG = g8E7);
	}

	[SpecialName]
	internal virtual PictureBox Cz01()
	{
		return Vr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bi8j(PictureBox Ho4t)
	{
		PictureBox val = (Vr = Ho4t);
	}

	[SpecialName]
	internal virtual PictureBox Qp1f()
	{
		return _PictureBox55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2Z4(PictureBox Sr37)
	{
		_PictureBox55 = Sr37;
	}

	[SpecialName]
	internal virtual PictureBox k0FH()
	{
		return Vs;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An1a(PictureBox Jf02)
	{
		PictureBox val = (Vs = Jf02);
	}

	[SpecialName]
	internal virtual PictureBox Mn86()
	{
		return _PictureBox57;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq2r(PictureBox k7QK)
	{
		_PictureBox57 = k7QK;
	}

	[SpecialName]
	internal virtual PictureBox Af08()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb02(PictureBox Ho4s)
	{
		_PictureBox58 = Ho4s;
	}

	[SpecialName]
	internal virtual PictureBox y8Y3()
	{
		return Vd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gb6x(PictureBox t1LQ)
	{
		PictureBox val = (Vd = t1LQ);
	}

	[SpecialName]
	internal virtual PictureBox g8JS()
	{
		return VP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te9i(PictureBox c1C6)
	{
		PictureBox val = (VP = c1C6);
	}

	[SpecialName]
	internal virtual PictureBox Sp2w()
	{
		return _PictureBox61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am96(PictureBox Qz0s)
	{
		_PictureBox61 = Qz0s;
	}

	[SpecialName]
	internal virtual PictureBox c9R8()
	{
		return _PictureBox62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ew32(PictureBox Jq6k)
	{
		_PictureBox62 = Jq6k;
	}

	[SpecialName]
	internal virtual PictureBox r9Q8()
	{
		return VO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6S4(PictureBox Lg7n)
	{
		PictureBox val = (VO = Lg7n);
	}

	[SpecialName]
	internal virtual PictureBox f6L2()
	{
		return VE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn27(PictureBox e9D3)
	{
		PictureBox val = (VE = e9D3);
	}

	[SpecialName]
	internal virtual PictureBox Jq34()
	{
		return VH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Px60(PictureBox Ha0b)
	{
		PictureBox val = (VH = Ha0b);
	}

	[SpecialName]
	internal virtual PictureBox n8FH()
	{
		return VY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az74(PictureBox Gq0o)
	{
		PictureBox val = (VY = Gq0o);
	}

	[SpecialName]
	internal virtual PictureBox o3W6()
	{
		return VK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tk60(PictureBox c6K9)
	{
		PictureBox val = (VK = c6K9);
	}

	[SpecialName]
	internal virtual PictureBox c8E0()
	{
		return VF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cg4k(PictureBox t2M8)
	{
		PictureBox val = (VF = t2M8);
	}

	[SpecialName]
	internal virtual PictureBox q1N6()
	{
		return _PictureBox69;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs2o(PictureBox Cw29)
	{
		_PictureBox69 = Cw29;
	}

	[SpecialName]
	internal virtual PictureBox n8B7()
	{
		return VZ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp5o(PictureBox d4XK)
	{
		PictureBox val = (VZ = d4XK);
	}

	[SpecialName]
	internal virtual PictureBox a1P0()
	{
		return tc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zx5q(PictureBox z1EL)
	{
		PictureBox val = (tc = z1EL);
	}

	[SpecialName]
	internal virtual PictureBox Pf8a()
	{
		return tm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5T8(PictureBox Xn56)
	{
		PictureBox val = (tm = Xn56);
	}

	[SpecialName]
	internal virtual PictureBox f9ML()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6Y1(PictureBox z1EC)
	{
		_PictureBox73 = z1EC;
	}

	[SpecialName]
	internal virtual PictureBox To52()
	{
		return tV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3T4(PictureBox Es58)
	{
		PictureBox val = (tV = Es58);
	}

	[SpecialName]
	internal virtual PictureBox c4MX()
	{
		return _PictureBox75;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hr39(PictureBox Sn45)
	{
		_PictureBox75 = Sn45;
	}

	[SpecialName]
	internal virtual PictureBox Yq34()
	{
		return _PictureBox76;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4G7(PictureBox q5B3)
	{
		_PictureBox76 = q5B3;
	}

	[SpecialName]
	internal virtual PictureBox Mi1b()
	{
		return _PictureBox77;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps17(PictureBox z5F4)
	{
		_PictureBox77 = z5F4;
	}

	[SpecialName]
	internal virtual PictureBox x5S0()
	{
		return tt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb7t(PictureBox Td4e)
	{
		PictureBox val = (tt = Td4e);
	}

	[SpecialName]
	internal virtual PictureBox Sg1w()
	{
		return _PictureBox79;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dm5w(PictureBox p8H4)
	{
		_PictureBox79 = p8H4;
	}

	[SpecialName]
	internal virtual PictureBox f1RY()
	{
		return tj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7W1(PictureBox Ks73)
	{
		PictureBox val = (tj = Ks73);
	}

	[SpecialName]
	internal virtual PictureBox m5ZS()
	{
		return tB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9G8(PictureBox n6DG)
	{
		PictureBox val = (tB = n6DG);
	}

	[SpecialName]
	internal virtual PictureBox p3J0()
	{
		return tw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7N6(PictureBox t2A3)
	{
		PictureBox val = (tw = t2A3);
	}

	[SpecialName]
	internal virtual PictureBox y0B8()
	{
		return _PictureBox83;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fp1g(PictureBox Xp98)
	{
		_PictureBox83 = Xp98;
	}

	[SpecialName]
	internal virtual PictureBox Hy43()
	{
		return _PictureBox84;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0CS(PictureBox b9F4)
	{
		_PictureBox84 = b9F4;
	}

	[SpecialName]
	internal virtual PictureBox q4Z6()
	{
		return _PictureBox85;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rx4f(PictureBox b4K5)
	{
		_PictureBox85 = b4K5;
	}

	[SpecialName]
	internal virtual PictureBox k6BJ()
	{
		return tn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Py79(PictureBox Ws1w)
	{
		PictureBox val = (tn = Ws1w);
	}

	[SpecialName]
	internal virtual PictureBox w2WY()
	{
		return ta;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4M2(PictureBox i6YF)
	{
		PictureBox val = (ta = i6YF);
	}

	[SpecialName]
	internal virtual PictureBox Wt18()
	{
		return ti;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4HY(PictureBox Fb93)
	{
		PictureBox val = (ti = Fb93);
	}

	[SpecialName]
	internal virtual PictureBox a5Q3()
	{
		return tL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4M6(PictureBox Xw09)
	{
		PictureBox val = (tL = Xw09);
	}

	[SpecialName]
	internal virtual PictureBox Km41()
	{
		return _PictureBox90;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6K8(PictureBox i4TD)
	{
		_PictureBox90 = i4TD;
	}

	[SpecialName]
	internal virtual PictureBox Mg6r()
	{
		return tU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bg2x(PictureBox Wr62)
	{
		PictureBox val = (tU = Wr62);
	}

	[SpecialName]
	internal virtual PictureBox Kq38()
	{
		return _PictureBox92;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0FJ(PictureBox i8G5)
	{
		_PictureBox92 = i8G5;
	}

	[SpecialName]
	internal virtual PictureBox d5DG()
	{
		return tX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6PE(PictureBox Yf24)
	{
		PictureBox val = (tX = Yf24);
	}

	[SpecialName]
	internal virtual PictureBox Db05()
	{
		return tQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg3k(PictureBox p0P9)
	{
		PictureBox val = (tQ = p0P9);
	}

	[SpecialName]
	internal virtual PictureBox g6KE()
	{
		return _PictureBox95;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf4m(PictureBox Qa3p)
	{
		_PictureBox95 = Qa3p;
	}

	[SpecialName]
	internal virtual PictureBox Dx34()
	{
		return _PictureBox96;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Df78(PictureBox w7M1)
	{
		_PictureBox96 = w7M1;
	}

	[SpecialName]
	internal virtual PictureBox Fm78()
	{
		return _PictureBox97;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xz58(PictureBox Ce2j)
	{
		_PictureBox97 = Ce2j;
	}

	[SpecialName]
	internal virtual PictureBox z6AG()
	{
		return _PictureBox98;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3AT(PictureBox s5K8)
	{
		_PictureBox98 = s5K8;
	}

	[SpecialName]
	internal virtual PictureBox Zt9m()
	{
		return tG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5F6(PictureBox t5Q0)
	{
		PictureBox val = (tG = t5Q0);
	}

	[SpecialName]
	internal virtual PictureBox Qe29()
	{
		return tr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7Z0(PictureBox x7YQ)
	{
		PictureBox val = (tr = x7YQ);
	}

	[SpecialName]
	internal virtual PictureBox k4HJ()
	{
		return _PictureBox101;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6CH(PictureBox j1D8)
	{
		_PictureBox101 = j1D8;
	}

	[SpecialName]
	internal virtual PictureBox m0Z1()
	{
		return _PictureBox102;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq70(PictureBox q1P3)
	{
		_PictureBox102 = q1P3;
	}

	[SpecialName]
	internal virtual PictureBox Cb7m()
	{
		return ts;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sa91(PictureBox We5f)
	{
		PictureBox val = (ts = We5f);
	}

	[SpecialName]
	internal virtual PictureBox y7H0()
	{
		return td;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng2o(PictureBox Tw3a)
	{
		PictureBox val = (td = Tw3a);
	}

	[SpecialName]
	internal virtual PictureBox r5D3()
	{
		return _PictureBox105;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bg89(PictureBox Fe4g)
	{
		_PictureBox105 = Fe4g;
	}

	[SpecialName]
	internal virtual PictureBox Zy9o()
	{
		return tP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7EJ(PictureBox Af36)
	{
		PictureBox val = (tP = Af36);
	}

	[SpecialName]
	internal virtual PictureBox Gt91()
	{
		return tO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd91(PictureBox j6RW)
	{
		PictureBox val = (tO = j6RW);
	}

	[SpecialName]
	internal virtual PictureBox An90()
	{
		return tE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc7y(PictureBox Ka10)
	{
		PictureBox val = (tE = Ka10);
	}

	[SpecialName]
	internal virtual PictureBox z0N9()
	{
		return _PictureBox109;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2BW(PictureBox Wz5m)
	{
		_PictureBox109 = Wz5m;
	}

	[SpecialName]
	internal virtual PictureBox i9Z6()
	{
		return tH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5WQ(PictureBox g8T5)
	{
		PictureBox val = (tH = g8T5);
	}

	[SpecialName]
	internal virtual PictureBox Ky85()
	{
		return _PictureBox111;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln78(PictureBox w1J9)
	{
		_PictureBox111 = w1J9;
	}

	[SpecialName]
	internal virtual PictureBox Cz6x()
	{
		return _PictureBox112;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0K6(PictureBox Jk3t)
	{
		_PictureBox112 = Jk3t;
	}

	[SpecialName]
	internal virtual PictureBox Aj42()
	{
		return tY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2RK(PictureBox i8MJ)
	{
		PictureBox val = (tY = i8MJ);
	}

	[SpecialName]
	internal virtual PictureBox Sb5y()
	{
		return tK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pb73(PictureBox o1WT)
	{
		PictureBox val = (tK = o1WT);
	}

	[SpecialName]
	internal virtual PictureBox Wn95()
	{
		return _PictureBox115;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq2e(PictureBox Xz21)
	{
		_PictureBox115 = Xz21;
	}

	[SpecialName]
	internal virtual PictureBox k0M9()
	{
		return _PictureBox116;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7RS(PictureBox t3RP)
	{
		_PictureBox116 = t3RP;
	}

	[SpecialName]
	internal virtual PictureBox z4T5()
	{
		return tF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp80(PictureBox b1GN)
	{
		PictureBox val = (tF = b1GN);
	}

	[SpecialName]
	internal virtual PictureBox s3F4()
	{
		return _PictureBox118;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8E2(PictureBox Wb2p)
	{
		_PictureBox118 = Wb2p;
	}

	[SpecialName]
	internal virtual PictureBox Kt56()
	{
		return _PictureBox119;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0DP(PictureBox Qj1x)
	{
		_PictureBox119 = Qj1x;
	}

	[SpecialName]
	internal virtual PictureBox m9ZA()
	{
		return tZ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kq2f(PictureBox x9X4)
	{
		PictureBox val = (tZ = x9X4);
	}

	[SpecialName]
	internal virtual PictureBox y6G4()
	{
		return _PictureBox121;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Re87(PictureBox y0XD)
	{
		_PictureBox121 = y0XD;
	}

	[SpecialName]
	internal virtual PictureBox Jc96()
	{
		return _PictureBox122;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2B7(PictureBox Qb73)
	{
		_PictureBox122 = Qb73;
	}

	[SpecialName]
	internal virtual PictureBox i8MH()
	{
		return jc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fi7g(PictureBox t0HS)
	{
		PictureBox val = (jc = t0HS);
	}

	[SpecialName]
	internal virtual PictureBox a6AR()
	{
		return jm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sn9e(PictureBox j1RD)
	{
		PictureBox val = (jm = j1RD);
	}

	[SpecialName]
	internal virtual PictureBox r6Q8()
	{
		return _PictureBox125;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn31(PictureBox r4J1)
	{
		_PictureBox125 = r4J1;
	}

	[SpecialName]
	internal virtual PictureBox s1E4()
	{
		return _PictureBox126;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8ES(PictureBox Bf2c)
	{
		_PictureBox126 = Bf2c;
	}

	[SpecialName]
	internal virtual PictureBox b7TB()
	{
		return _PictureBox127;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He8r(PictureBox Xd4s)
	{
		_PictureBox127 = Xd4s;
	}

	[SpecialName]
	internal virtual PictureBox Jo1d()
	{
		return _PictureBox128;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2CG(PictureBox g8C3)
	{
		_PictureBox128 = g8C3;
	}

	[SpecialName]
	internal virtual PictureBox Kj57()
	{
		return jV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5ND(PictureBox Wn78)
	{
		PictureBox val = (jV = Wn78);
	}

	[SpecialName]
	internal virtual PictureBox b0LK()
	{
		return jt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je16(PictureBox Dc5a)
	{
		PictureBox val = (jt = Dc5a);
	}

	[SpecialName]
	internal virtual PictureBox Hc0s()
	{
		return jj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2W0(PictureBox Ym4w)
	{
		PictureBox val = (jj = Ym4w);
	}

	[SpecialName]
	internal virtual PictureBox q6WX()
	{
		return _PictureBox132;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tb5n(PictureBox Py9c)
	{
		_PictureBox132 = Py9c;
	}

	[SpecialName]
	internal virtual PictureBox Mn68()
	{
		return _PictureBox133;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7F2(PictureBox n9SJ)
	{
		_PictureBox133 = n9SJ;
	}

	[SpecialName]
	internal virtual PictureBox Zr7j()
	{
		return jB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fn9k(PictureBox Gc0q)
	{
		PictureBox val = (jB = Gc0q);
	}

	[SpecialName]
	internal virtual PictureBox Nw1k()
	{
		return jw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6CK(PictureBox f9GP)
	{
		PictureBox val = (jw = f9GP);
	}

	[SpecialName]
	internal virtual PictureBox x6P9()
	{
		return _PictureBox136;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9N6(PictureBox Le4r)
	{
		_PictureBox136 = Le4r;
	}

	[SpecialName]
	internal virtual PictureBox Te6p()
	{
		return jn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Be4a(PictureBox p3MK)
	{
		PictureBox val = (jn = p3MK);
	}

	[SpecialName]
	internal virtual PictureBox Kw09()
	{
		return _PictureBox138;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4P6(PictureBox Bw10)
	{
		_PictureBox138 = Bw10;
	}

	[SpecialName]
	internal virtual PictureBox Ca45()
	{
		return ja;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw37(PictureBox p1FH)
	{
		PictureBox val = (ja = p1FH);
	}

	[SpecialName]
	internal virtual PictureBox t0Y1()
	{
		return ji;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yr78(PictureBox n0AD)
	{
		PictureBox val = (ji = n0AD);
	}

	[SpecialName]
	internal virtual PictureBox j7CK()
	{
		return _PictureBox141;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yz1e(PictureBox q3WQ)
	{
		_PictureBox141 = q3WQ;
	}

	[SpecialName]
	internal virtual PictureBox Ex36()
	{
		return jL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8KX(PictureBox p7PY)
	{
		PictureBox val = (jL = p7PY);
	}

	[SpecialName]
	internal virtual PictureBox Fs14()
	{
		return jU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5HP(PictureBox Sq5r)
	{
		PictureBox val = (jU = Sq5r);
	}

	[SpecialName]
	internal virtual PictureBox Aj9m()
	{
		return jX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yn41(PictureBox Gm29)
	{
		PictureBox val = (jX = Gm29);
	}

	[SpecialName]
	internal virtual PictureBox g3Y9()
	{
		return jQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2S1(PictureBox c5AH)
	{
		PictureBox val = (jQ = c5AH);
	}

	[SpecialName]
	internal virtual PictureBox Gn7g()
	{
		return _PictureBox146;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn93(PictureBox o9Y0)
	{
		_PictureBox146 = o9Y0;
	}

	[SpecialName]
	internal virtual PictureBox z4P6()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lw34(PictureBox Li10)
	{
		_PictureBox147 = Li10;
	}

	[SpecialName]
	internal virtual PictureBox Wt50()
	{
		return jG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9ES(PictureBox Fc78)
	{
		PictureBox val = (jG = Fc78);
	}

	[SpecialName]
	internal virtual PictureBox o8DK()
	{
		return _PictureBox149;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci19(PictureBox x5H3)
	{
		_PictureBox149 = x5H3;
	}

	[SpecialName]
	internal virtual PictureBox Kk79()
	{
		return jr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm18(PictureBox e9JN)
	{
		PictureBox val = (jr = e9JN);
	}

	[SpecialName]
	internal virtual PictureBox Qf18()
	{
		return js;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7JQ(PictureBox m0J6)
	{
		PictureBox val = (js = m0J6);
	}

	[SpecialName]
	internal virtual PictureBox Rp15()
	{
		return jd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9A4(PictureBox Mt8k)
	{
		PictureBox val = (jd = Mt8k);
	}

	[SpecialName]
	internal virtual PictureBox Si9m()
	{
		return jP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz81(PictureBox Eb74)
	{
		PictureBox val = (jP = Eb74);
	}

	[SpecialName]
	internal virtual PictureBox j4R2()
	{
		return jO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3HD(PictureBox Mr4g)
	{
		PictureBox val = (jO = Mr4g);
	}

	[SpecialName]
	internal virtual PictureBox Di90()
	{
		return _PictureBox155;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Di0y(PictureBox z9FA)
	{
		_PictureBox155 = z9FA;
	}

	[SpecialName]
	internal virtual PictureBox w6EC()
	{
		return _PictureBox156;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wz37(PictureBox p1XQ)
	{
		_PictureBox156 = p1XQ;
	}

	[SpecialName]
	internal virtual PictureBox z7XY()
	{
		return _PictureBox157;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1N(PictureBox Sx7)
	{
		_PictureBox157 = Sx7;
	}

	[SpecialName]
	internal virtual PictureBox Mr9()
	{
		return _PictureBox158;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8E(PictureBox Ra0)
	{
		_PictureBox158 = Ra0;
	}

	[SpecialName]
	internal virtual PictureBox a6E()
	{
		return _PictureBox159;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq7(PictureBox Pz4)
	{
		_PictureBox159 = Pz4;
	}

	[SpecialName]
	internal virtual PictureBox Zm3()
	{
		return jE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1N(PictureBox p4D)
	{
		PictureBox val = (jE = p4D);
	}

	[SpecialName]
	internal virtual Button Tg3()
	{
		return _btnNew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3B(Button Cw6)
	{
		EventHandler eventHandler = We1;
		Button btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).remove_Click(eventHandler);
		}
		_btnNew = Cw6;
		btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Yf6()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7B(Button q6Y)
	{
		_btnReset = q6Y;
	}

	[SpecialName]
	internal virtual Button Po5()
	{
		return _btnExisting;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs1(Button Mz7)
	{
		EventHandler eventHandler = t3B;
		Button btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).remove_Click(eventHandler);
		}
		_btnExisting = Mz7;
		btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button f0S()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1R(Button q2Z)
	{
		EventHandler eventHandler = Mc7;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = q2Z;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ye9()
	{
		return jH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zo8(Button a5X)
	{
		EventHandler eventHandler = Fy4;
		Button val = jH;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (jH = a5X);
		val = jH;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button e7N()
	{
		return _btnViewReservations;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ka7(Button z5T)
	{
		EventHandler eventHandler = w9F;
		Button btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).remove_Click(eventHandler);
		}
		_btnViewReservations = z5T;
		btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).add_Click(eventHandler);
		}
	}

	private void Mc7(object sender, EventArgs e)
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
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Dj8x().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = Dj8x().get_Text();
		firstName = p5R9().get_Text();
		val2.Close();
		s9C();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Fy4(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(a3N6().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			d7HZ().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)a3N6()).Clear();
		}
	}

	private void g9Y(object sender, EventArgs e)
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
					((PictureBox)val).set_Image((Image)availableIcon);
					val.add_Click((EventHandler)r1D);
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
		availableSeats = 160;
		jY = 0;
		provisionalSeats = 0;
		s9C();
	}

	private void w9F(object sender, EventArgs e)
	{
	}

	private void t3B(object sender, EventArgs e)
	{
	}

	private void We1(object sender, EventArgs e)
	{
	}

	internal static byte[] w3N(int j1K, int g5M)
	{
		if (j1K <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[g5M + 1];
			for (int i = 0; i <= g5M; i++)
			{
				int num = j1K * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return n7F.Gx4(array, g5M);
		}
	}

	public void s9C()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		checked
		{
			availableSeats = 160 - jY;
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
					((PictureBox)NewLateBinding.LateGet((object)((Control)this).get_Controls(), (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"PictureBox", dataRow[2]) }, (string[])null, (Type[])null, (bool[])null)).set_Image((Image)bookedIcon);
					jY++;
					availableSeats--;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			z6C9().set_Text(Conversions.ToString(jY));
			i5ZA().set_Text(Conversions.ToString(availableSeats));
			t9K2().set_Text(Conversions.ToString(provisionalSeats));
			d8D();
		}
	}

	private void r1D(object sender, EventArgs e)
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
			if (((PictureBox)sender).get_Image() == availableIcon)
			{
				((PictureBox)sender).set_Image((Image)provisionalIcon);
				provisionalSeats++;
				availableSeats--;
			}
			else if (((PictureBox)sender).get_Image() == provisionalIcon)
			{
				((PictureBox)sender).set_Image((Image)availableIcon);
				provisionalSeats--;
				availableSeats++;
			}
			i5ZA().set_Text(Conversions.ToString(availableSeats));
			t9K2().set_Text(Conversions.ToString(provisionalSeats));
			seats = provisionalSeats;
			r2B9().set_Text(Conversions.ToString(seats));
			totalCost = provisionalSeats * 5;
			k4YG().set_Text("$" + totalCost);
		}
	}

	public void d8D()
	{
		((TextBoxBase)a3N6()).Clear();
		((TextBoxBase)p5R9()).Clear();
		((TextBoxBase)k4YG()).Clear();
		((TextBoxBase)d7HZ()).Clear();
		((TextBoxBase)r2B9()).Clear();
		((TextBoxBase)Dj8x()).Clear();
	}
}
