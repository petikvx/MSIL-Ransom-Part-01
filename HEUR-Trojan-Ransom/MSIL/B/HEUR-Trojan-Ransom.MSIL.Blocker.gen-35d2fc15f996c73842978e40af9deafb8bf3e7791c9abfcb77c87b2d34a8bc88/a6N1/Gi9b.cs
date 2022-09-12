using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bb8;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Xk4;
using e0TX;
using f4L;
using f8M;

namespace a6N1;

[DesignerGenerated]
public class Gi9b : Form
{
	private PictureBox _PictureBox141;

	private PictureBox _PictureBox143;

	private PictureBox _PictureBox144;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox148;

	private PictureBox _PictureBox151;

	private PictureBox _PictureBox152;

	private PictureBox _PictureBox153;

	private PictureBox _PictureBox154;

	private PictureBox _PictureBox155;

	private PictureBox _PictureBox156;

	private PictureBox _PictureBox159;

	private PictureBox _PictureBox121;

	private PictureBox _PictureBox122;

	private PictureBox _PictureBox127;

	private PictureBox _PictureBox133;

	private PictureBox _PictureBox134;

	private PictureBox _PictureBox135;

	private PictureBox _PictureBox137;

	private PictureBox _PictureBox139;

	private PictureBox _PictureBox101;

	private PictureBox _PictureBox102;

	private PictureBox _PictureBox106;

	private PictureBox _PictureBox107;

	private PictureBox _PictureBox108;

	private PictureBox _PictureBox110;

	private PictureBox _PictureBox111;

	private PictureBox _PictureBox112;

	private PictureBox _PictureBox113;

	private PictureBox _PictureBox115;

	private PictureBox _PictureBox117;

	private PictureBox _PictureBox118;

	private PictureBox _PictureBox119;

	private PictureBox _PictureBox82;

	private PictureBox _PictureBox84;

	private PictureBox _PictureBox85;

	private PictureBox _PictureBox88;

	private PictureBox _PictureBox91;

	private PictureBox _PictureBox92;

	private PictureBox _PictureBox94;

	private PictureBox _PictureBox95;

	private PictureBox _PictureBox97;

	private PictureBox _PictureBox98;

	private PictureBox _PictureBox99;

	private PictureBox _PictureBox63;

	private PictureBox _PictureBox64;

	private PictureBox _PictureBox65;

	private PictureBox _PictureBox66;

	private PictureBox _PictureBox69;

	private PictureBox _PictureBox70;

	private PictureBox _PictureBox71;

	private PictureBox _PictureBox72;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox74;

	private PictureBox _PictureBox75;

	private PictureBox _PictureBox79;

	private PictureBox _PictureBox80;

	private PictureBox _PictureBox41;

	private PictureBox _PictureBox42;

	private PictureBox _PictureBox45;

	private PictureBox _PictureBox46;

	private PictureBox _PictureBox49;

	private PictureBox _PictureBox52;

	private PictureBox _PictureBox55;

	private PictureBox _PictureBox57;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox60;

	private PictureBox _PictureBox22;

	private PictureBox _PictureBox23;

	private PictureBox _PictureBox24;

	private PictureBox _PictureBox28;

	private PictureBox _PictureBox29;

	private PictureBox _PictureBox35;

	private PictureBox _PictureBox36;

	private PictureBox _PictureBox37;

	private PictureBox _PictureBox38;

	private TextBox _txtAvailable;

	private PictureBox _Booked;

	private PictureBox _Provisional;

	private Label _Label3;

	private PictureBox _PictureBox39;

	private Label _Label1;

	private Label _Label2;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox1;

	private Label _Label32;

	private Label _Label34;

	private Label _Label40;

	private Label _Label41;

	private Label _Label38;

	private Label _Label44;

	private Label _Label48;

	private Label _Label49;

	private Label _Label50;

	private Label _Label51;

	private Label _Label55;

	private Label _Label56;

	private Label _Label31;

	private Label _Label26;

	private Label _Label27;

	private Label _Label28;

	private Label _Label29;

	private Label _Label30;

	private Label _Label21;

	private Label _Label20;

	private Label _Label19;

	private Label _Label17;

	private Label _Label14;

	private Label _Label13;

	private Label _Label10;

	private Label _Label4;

	private Label _Label5;

	private PictureBox _Cover;

	private TextBox _txtProvisional;

	private Label _Label6;

	private TextBox _txtChange;

	private TextBox _txtTotalCost;

	private TextBox _txtSeats;

	private Label _Label62;

	private GroupBox _GroupBox2;

	private Button _btnNew;

	private Button _btnReset;

	private TextBox _txtFirstName;

	private TextBox _txtID;

	private Button _btnViewReservations;

	private object availableIcon;

	private object provisionalIcon;

	private int bookedSeats;

	private int provisionalSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal IContainer O;

	internal PictureBox Q;

	internal PictureBox j;

	internal PictureBox Y;

	internal PictureBox H;

	internal PictureBox V;

	internal PictureBox i;

	internal PictureBox b;

	internal PictureBox k;

	internal PictureBox r;

	internal PictureBox n;

	internal PictureBox t;

	internal PictureBox P;

	internal PictureBox c;

	internal PictureBox U;

	internal PictureBox F;

	internal PictureBox d;

	internal PictureBox a;

	internal PictureBox M;

	internal PictureBox g;

	internal PictureBox W;

	internal PictureBox l;

	internal PictureBox x;

	internal PictureBox e;

	internal PictureBox S;

	internal PictureBox z;

	internal PictureBox QO;

	internal PictureBox QQ;

	internal PictureBox Qj;

	internal PictureBox QY;

	internal PictureBox QH;

	internal PictureBox QV;

	internal PictureBox Qi;

	internal PictureBox Qb;

	internal PictureBox Qk;

	internal PictureBox Qr;

	internal PictureBox Qn;

	internal PictureBox Qt;

	internal PictureBox QP;

	internal PictureBox Qc;

	internal PictureBox QU;

	internal PictureBox QF;

	internal PictureBox Qd;

	internal PictureBox Qa;

	internal PictureBox QM;

	internal PictureBox Qg;

	internal PictureBox QW;

	internal PictureBox Ql;

	internal PictureBox Qx;

	internal PictureBox Qe;

	internal PictureBox QS;

	internal PictureBox Qz;

	internal PictureBox jO;

	internal PictureBox jQ;

	internal PictureBox jj;

	internal PictureBox jY;

	internal PictureBox jH;

	internal PictureBox jV;

	internal PictureBox ji;

	internal PictureBox jb;

	internal PictureBox jk;

	internal PictureBox jr;

	internal PictureBox jn;

	internal PictureBox jt;

	internal TextBox jP;

	internal PictureBox jc;

	internal PictureBox jU;

	internal PictureBox jF;

	internal PictureBox jd;

	internal PictureBox ja;

	internal PictureBox jM;

	internal PictureBox jg;

	internal PictureBox jW;

	internal PictureBox jl;

	internal PictureBox jx;

	internal PictureBox je;

	internal PictureBox jS;

	internal Label jz;

	internal Label YO;

	internal Label YQ;

	internal Label Yj;

	internal Label YY;

	internal Label YH;

	internal Label YV;

	internal Label Yi;

	internal Label Yb;

	internal Label Yk;

	internal Label Yr;

	internal Label Yn;

	internal Label Yt;

	internal Label YP;

	internal Label Yc;

	internal Label YU;

	internal Label YF;

	internal Label Yd;

	internal Label Ya;

	internal Label YM;

	internal Label Yg;

	internal Label YW;

	internal Label Yl;

	internal GroupBox Yx;

	internal GroupBox Ye;

	internal PictureBox YS;

	internal PictureBox Yz;

	internal GroupBox HO;

	internal Button HQ;

	internal Button Hj;

	internal TextBox HY;

	internal Label HH;

	internal Label HV;

	internal Label Hi;

	internal Button Hb;

	internal Label Hk;

	internal Label Hr;

	internal object Hn;

	internal int Ht;

	public Gi9b()
	{
		((Form)this).add_Load((EventHandler)Md8f);
		availableIcon = RuntimeHelpers.GetObjectValue(new object());
		provisionalIcon = RuntimeHelpers.GetObjectValue(new object());
		object obj = (Hn = RuntimeHelpers.GetObjectValue(new object()));
		Rz0();
	}

	protected override void Ki20(bool Wk8o)
	{
		try
		{
			if (Wk8o && O != null)
			{
				O.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wk8o);
		}
	}

	private void Rz0()
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
		//IL_6b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b2c: Expected O, but got Unknown
		r9M(new PictureBox());
		e9Q(new PictureBox());
		Ze4(new PictureBox());
		this.k8S(new PictureBox());
		Kk6(new PictureBox());
		y3X(new PictureBox());
		Eo8(new PictureBox());
		f4M(new PictureBox());
		f0N(new PictureBox());
		Pt8(new PictureBox());
		Ty4(new PictureBox());
		c6N(new PictureBox());
		Sg6(new PictureBox());
		Hf0(new PictureBox());
		x2A(new PictureBox());
		Fj4(new PictureBox());
		Gd9(new PictureBox());
		d4S(new PictureBox());
		k9Z(new PictureBox());
		Pt1(new PictureBox());
		Ka7(new PictureBox());
		Rn5(new PictureBox());
		this.k8S(new PictureBox());
		Ts5(new PictureBox());
		Wt0(new PictureBox());
		Lg2(new PictureBox());
		Gs3(new PictureBox());
		Cq4(new PictureBox());
		j6J(new PictureBox());
		Ds8(new PictureBox());
		Jo5(new PictureBox());
		e3P(new PictureBox());
		o3Y(new PictureBox());
		m4C(new PictureBox());
		x1D(new PictureBox());
		Dz1(new PictureBox());
		b8X(new PictureBox());
		Tj0(new PictureBox());
		q6J(new PictureBox());
		Cr8(new PictureBox());
		s8L(new PictureBox());
		j1S(new PictureBox());
		w7Y(new PictureBox());
		f4L(new PictureBox());
		b3D(new PictureBox());
		Kd0(new PictureBox());
		Hm0(new PictureBox());
		Ec6(new PictureBox());
		Yp9(new PictureBox());
		Nj3(new PictureBox());
		s0H(new PictureBox());
		k8D(new PictureBox());
		Ei1(new PictureBox());
		Sp6(new PictureBox());
		Nc1(new PictureBox());
		y9C(new PictureBox());
		Fo4(new PictureBox());
		Aj3(new PictureBox());
		Sd4(new PictureBox());
		Gd3(new PictureBox());
		r5P(new PictureBox());
		s1C(new PictureBox());
		Ei2(new PictureBox());
		Yf8(new PictureBox());
		Qt0(new PictureBox());
		Di8(new PictureBox());
		Te1(new PictureBox());
		Le3(new PictureBox());
		g4C(new PictureBox());
		Pw6(new PictureBox());
		Ri5(new PictureBox());
		o7F(new PictureBox());
		t0R(new PictureBox());
		d8Q(new PictureBox());
		Wo2(new PictureBox());
		c0Z(new PictureBox());
		St0(new PictureBox());
		y0E(new PictureBox());
		Ck3(new PictureBox());
		f5Z(new PictureBox());
		d1F(new PictureBox());
		z5D(new PictureBox());
		Wx1(new PictureBox());
		Cm6(new PictureBox());
		r4J(new PictureBox());
		Lx5(new PictureBox());
		j1XP(new PictureBox());
		Ze28(new PictureBox());
		Fj05(new PictureBox());
		x2TN(new PictureBox());
		Ng48(new PictureBox());
		Ki9o(new PictureBox());
		Rp12(new PictureBox());
		Qs41(new PictureBox());
		Ek03(new PictureBox());
		Wp95(new PictureBox());
		Lt8p(new PictureBox());
		w7NZ(new PictureBox());
		e5DF(new PictureBox());
		x1P2(new PictureBox());
		Ts7p(new PictureBox());
		Qp6c(new PictureBox());
		a6FH(new PictureBox());
		Rk7s(new PictureBox());
		Kx97(new PictureBox());
		Go29(new PictureBox());
		Gp36(new PictureBox());
		r1JS(new PictureBox());
		c3TH(new PictureBox());
		d8C3(new PictureBox());
		So4d(new PictureBox());
		y4SX(new PictureBox());
		j3ZD(new PictureBox());
		i2Y9(new PictureBox());
		Kt3r(new PictureBox());
		n5LN(new PictureBox());
		m6W3(new PictureBox());
		Pm3n(new PictureBox());
		m2B8(new PictureBox());
		o5E6(new PictureBox());
		z3YF(new PictureBox());
		s5E1(new PictureBox());
		Co9t(new PictureBox());
		Lq2y(new PictureBox());
		f4M7(new PictureBox());
		r6ZG(new PictureBox());
		Ht54(new PictureBox());
		Bx21(new PictureBox());
		Lj76(new PictureBox());
		t1E4(new PictureBox());
		Bt61(new PictureBox());
		Rd54(new PictureBox());
		z0A2(new PictureBox());
		Nq9r(new PictureBox());
		Sw61(new PictureBox());
		No8t(new PictureBox());
		k2P4(new PictureBox());
		g3R4(new PictureBox());
		x0LK(new TextBox());
		Es59(new PictureBox());
		Wz65(new PictureBox());
		z9XD(new PictureBox());
		Pe1b(new Label());
		b5KS(new PictureBox());
		a3GB(new TextBox());
		o6MQ(new Label());
		t3CJ(new Label());
		En85(new PictureBox());
		Ao6c(new PictureBox());
		f2P6(new PictureBox());
		j9L3(new PictureBox());
		Gk5y(new PictureBox());
		d1NA(new PictureBox());
		Ft5d(new PictureBox());
		Ep48(new PictureBox());
		Sg12(new PictureBox());
		Ei6w(new PictureBox());
		x2AX(new PictureBox());
		Rk8f(new PictureBox());
		Dx9p(new PictureBox());
		Ck67(new PictureBox());
		w8G4(new PictureBox());
		n2T6(new PictureBox());
		Xn48(new PictureBox());
		a5GM(new PictureBox());
		z0D9(new PictureBox());
		p2KJ(new PictureBox());
		c9P2(new PictureBox());
		Qx08(new Label());
		Nc8o(new Label());
		Bx1s(new Label());
		c5Q7(new Label());
		q3F1(new Label());
		n2R9(new Label());
		a2DN(new Label());
		i2AT(new Label());
		Xc56(new Label());
		t9Q1(new Label());
		Pr4q(new Label());
		Br6n(new Label());
		g9S1(new Label());
		Gi5r(new Label());
		Dt87(new Label());
		e5XQ(new Label());
		a1MY(new Label());
		m9AJ(new Label());
		Xf4y(new Label());
		j0EB(new Label());
		c9BZ(new Label());
		z1XW(new Label());
		Nb15(new Label());
		j8QS(new Label());
		Cn4j(new Label());
		c1Z5(new Label());
		d4LB(new Label());
		Kt5r(new Label());
		f0TY(new Label());
		o2XF(new Label());
		Pw26(new Label());
		k1KE(new Label());
		y7QA(new Label());
		Jm1e(new Label());
		z0H2(new Label());
		q5XS(new Label());
		Ff45(new Label());
		Yj15(new Label());
		x8TF(new Label());
		n3J1(new Label());
		d0JX(new Label());
		Bc57(new Label());
		Jm05(new Label());
		Fz6k(new Label());
		p3W9(new Label());
		Lq26(new Label());
		n5AR(new Label());
		Yi0x(new Label());
		p1QR(new Label());
		Cm6z(new Label());
		i1W6(new GroupBox());
		q9T8(new PictureBox());
		Lo3b(new GroupBox());
		y1D9(new TextBox());
		z9X7(new Label());
		Jm9y(new PictureBox());
		k2JT(new PictureBox());
		w3AZ(new GroupBox());
		Gf32(new Button());
		j2QP(new Button());
		f3Q7(new TextBox());
		n7ZL(new TextBox());
		k9TJ(new TextBox());
		t1FP(new TextBox());
		k4KC(new Label());
		Ds36(new Label());
		Mt28(new Label());
		Sb90(new Label());
		g4Y3(new GroupBox());
		a4L3(new Button());
		z8Y7(new Button());
		Ao4w(new Button());
		Ks86(new TextBox());
		z1R2(new TextBox());
		Mq54(new Label());
		Kg34(new Label());
		x8QC(new Button());
		((ISupportInitialize)i0D()).BeginInit();
		((ISupportInitialize)y1L()).BeginInit();
		((ISupportInitialize)b5G()).BeginInit();
		((ISupportInitialize)c6B()).BeginInit();
		((ISupportInitialize)x9G()).BeginInit();
		((ISupportInitialize)Me1()).BeginInit();
		((ISupportInitialize)Pr8()).BeginInit();
		((ISupportInitialize)e5Q()).BeginInit();
		((ISupportInitialize)m3A()).BeginInit();
		((ISupportInitialize)Pe7()).BeginInit();
		((ISupportInitialize)e2T()).BeginInit();
		((ISupportInitialize)j9X()).BeginInit();
		((ISupportInitialize)t5C()).BeginInit();
		((ISupportInitialize)Da1()).BeginInit();
		((ISupportInitialize)Gy7()).BeginInit();
		((ISupportInitialize)g4T()).BeginInit();
		((ISupportInitialize)j3Q()).BeginInit();
		((ISupportInitialize)b4F()).BeginInit();
		((ISupportInitialize)b8J()).BeginInit();
		((ISupportInitialize)Dg9()).BeginInit();
		((ISupportInitialize)Tc1()).BeginInit();
		((ISupportInitialize)Qb9()).BeginInit();
		((ISupportInitialize)Aw4()).BeginInit();
		((ISupportInitialize)t0Y()).BeginInit();
		((ISupportInitialize)Pq5()).BeginInit();
		((ISupportInitialize)Gp2()).BeginInit();
		((ISupportInitialize)z8D()).BeginInit();
		((ISupportInitialize)Fa1()).BeginInit();
		((ISupportInitialize)Zn3()).BeginInit();
		((ISupportInitialize)Pf4()).BeginInit();
		((ISupportInitialize)Jq1()).BeginInit();
		((ISupportInitialize)Ea7()).BeginInit();
		((ISupportInitialize)o1J()).BeginInit();
		((ISupportInitialize)Pc2()).BeginInit();
		((ISupportInitialize)Tq3()).BeginInit();
		((ISupportInitialize)Wo3()).BeginInit();
		((ISupportInitialize)p1P()).BeginInit();
		((ISupportInitialize)Zy7()).BeginInit();
		((ISupportInitialize)Hk9()).BeginInit();
		((ISupportInitialize)Zf2()).BeginInit();
		((ISupportInitialize)Qf5()).BeginInit();
		((ISupportInitialize)Bm9()).BeginInit();
		((ISupportInitialize)n6N()).BeginInit();
		((ISupportInitialize)Po3()).BeginInit();
		((ISupportInitialize)z0F()).BeginInit();
		((ISupportInitialize)n9Q()).BeginInit();
		((ISupportInitialize)k3S()).BeginInit();
		((ISupportInitialize)Gg0()).BeginInit();
		((ISupportInitialize)Fm5()).BeginInit();
		((ISupportInitialize)Ns7()).BeginInit();
		((ISupportInitialize)f0E()).BeginInit();
		((ISupportInitialize)Jx7()).BeginInit();
		((ISupportInitialize)s1J()).BeginInit();
		((ISupportInitialize)Hz9()).BeginInit();
		((ISupportInitialize)x4A()).BeginInit();
		((ISupportInitialize)j7T()).BeginInit();
		((ISupportInitialize)Ld9()).BeginInit();
		((ISupportInitialize)Lt9()).BeginInit();
		((ISupportInitialize)w9L()).BeginInit();
		((ISupportInitialize)z2N()).BeginInit();
		((ISupportInitialize)b9G()).BeginInit();
		((ISupportInitialize)Fw6()).BeginInit();
		((ISupportInitialize)St4()).BeginInit();
		((ISupportInitialize)e3H()).BeginInit();
		((ISupportInitialize)Ae2()).BeginInit();
		((ISupportInitialize)i8P()).BeginInit();
		((ISupportInitialize)Xe8()).BeginInit();
		((ISupportInitialize)w0S()).BeginInit();
		((ISupportInitialize)Qy6()).BeginInit();
		((ISupportInitialize)t8W()).BeginInit();
		((ISupportInitialize)g9P()).BeginInit();
		((ISupportInitialize)Wb7()).BeginInit();
		((ISupportInitialize)Ha0()).BeginInit();
		((ISupportInitialize)b5S()).BeginInit();
		((ISupportInitialize)y8B()).BeginInit();
		((ISupportInitialize)Kz8()).BeginInit();
		((ISupportInitialize)Kq7()).BeginInit();
		((ISupportInitialize)Km9()).BeginInit();
		((ISupportInitialize)Dg8()).BeginInit();
		((ISupportInitialize)Co8()).BeginInit();
		((ISupportInitialize)q4N()).BeginInit();
		((ISupportInitialize)Pb4()).BeginInit();
		((ISupportInitialize)Kn8()).BeginInit();
		((ISupportInitialize)Fc0()).BeginInit();
		((ISupportInitialize)At9()).BeginInit();
		((ISupportInitialize)g0G()).BeginInit();
		((ISupportInitialize)k3W2()).BeginInit();
		((ISupportInitialize)i5C1()).BeginInit();
		((ISupportInitialize)Ye6b()).BeginInit();
		((ISupportInitialize)Tk06()).BeginInit();
		((ISupportInitialize)Ks8r()).BeginInit();
		((ISupportInitialize)Ws96()).BeginInit();
		((ISupportInitialize)z9T1()).BeginInit();
		((ISupportInitialize)Gz21()).BeginInit();
		((ISupportInitialize)So09()).BeginInit();
		((ISupportInitialize)Et85()).BeginInit();
		((ISupportInitialize)Dy47()).BeginInit();
		((ISupportInitialize)z9R2()).BeginInit();
		((ISupportInitialize)Ds70()).BeginInit();
		((ISupportInitialize)a2BA()).BeginInit();
		((ISupportInitialize)a6B3()).BeginInit();
		((ISupportInitialize)a4QS()).BeginInit();
		((ISupportInitialize)Kf6n()).BeginInit();
		((ISupportInitialize)Sf0j()).BeginInit();
		((ISupportInitialize)Xy4z()).BeginInit();
		((ISupportInitialize)a2B3()).BeginInit();
		((ISupportInitialize)Dg96()).BeginInit();
		((ISupportInitialize)g7RE()).BeginInit();
		((ISupportInitialize)Tp7z()).BeginInit();
		((ISupportInitialize)d1L5()).BeginInit();
		((ISupportInitialize)Bq97()).BeginInit();
		((ISupportInitialize)Ge19()).BeginInit();
		((ISupportInitialize)y8QL()).BeginInit();
		((ISupportInitialize)p0MA()).BeginInit();
		((ISupportInitialize)Fp7o()).BeginInit();
		((ISupportInitialize)b6H2()).BeginInit();
		((ISupportInitialize)r6QH()).BeginInit();
		((ISupportInitialize)b9M5()).BeginInit();
		((ISupportInitialize)s6X0()).BeginInit();
		((ISupportInitialize)Sq2d()).BeginInit();
		((ISupportInitialize)e4PT()).BeginInit();
		((ISupportInitialize)Jr6q()).BeginInit();
		((ISupportInitialize)g2X5()).BeginInit();
		((ISupportInitialize)Bx8z()).BeginInit();
		((ISupportInitialize)g6L7()).BeginInit();
		((ISupportInitialize)f3ZF()).BeginInit();
		((ISupportInitialize)n8J2()).BeginInit();
		((ISupportInitialize)q0B4()).BeginInit();
		((ISupportInitialize)Go3n()).BeginInit();
		((ISupportInitialize)n7GH()).BeginInit();
		((ISupportInitialize)k5CG()).BeginInit();
		((ISupportInitialize)s1E0()).BeginInit();
		((ISupportInitialize)Lf3c()).BeginInit();
		((ISupportInitialize)Cr56()).BeginInit();
		((ISupportInitialize)k6ZT()).BeginInit();
		((ISupportInitialize)Dr79()).BeginInit();
		((ISupportInitialize)d4A1()).BeginInit();
		((ISupportInitialize)k0GY()).BeginInit();
		((ISupportInitialize)Dp6d()).BeginInit();
		((ISupportInitialize)Ab62()).BeginInit();
		((ISupportInitialize)Sk38()).BeginInit();
		((ISupportInitialize)a8L0()).BeginInit();
		((ISupportInitialize)Ea5b()).BeginInit();
		((ISupportInitialize)Rr59()).BeginInit();
		((ISupportInitialize)Lt83()).BeginInit();
		((ISupportInitialize)Mi50()).BeginInit();
		((ISupportInitialize)Yy4t()).BeginInit();
		((ISupportInitialize)Fd79()).BeginInit();
		((ISupportInitialize)Li0k()).BeginInit();
		((ISupportInitialize)f0N5()).BeginInit();
		((ISupportInitialize)Ez04()).BeginInit();
		((ISupportInitialize)p8Q6()).BeginInit();
		((ISupportInitialize)Ja5k()).BeginInit();
		((ISupportInitialize)m9Q7()).BeginInit();
		((ISupportInitialize)b5K1()).BeginInit();
		((ISupportInitialize)Ym8i()).BeginInit();
		((ISupportInitialize)Cm76()).BeginInit();
		((ISupportInitialize)d9CL()).BeginInit();
		((ISupportInitialize)Si54()).BeginInit();
		((ISupportInitialize)this.f3H7()).BeginInit();
		((ISupportInitialize)t7R8()).BeginInit();
		((ISupportInitialize)c8NZ()).BeginInit();
		((ISupportInitialize)c0ZQ()).BeginInit();
		((Control)Ee4z()).SuspendLayout();
		((ISupportInitialize)Mz3o()).BeginInit();
		((Control)Wb3i()).SuspendLayout();
		((ISupportInitialize)To2j()).BeginInit();
		((ISupportInitialize)Ja59()).BeginInit();
		((Control)e8MC()).SuspendLayout();
		((Control)Ky40()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)i0D()).set_Location(new Point(372, 362));
		((Control)i0D()).set_Name("PictureBox141");
		((Control)i0D()).set_Size(new Size(10, 12));
		i0D().set_SizeMode((PictureBoxSizeMode)4);
		i0D().set_TabIndex(1002);
		i0D().set_TabStop(false);
		((Control)y1L()).set_Location(new Point(352, 362));
		((Control)y1L()).set_Name("PictureBox142");
		((Control)y1L()).set_Size(new Size(10, 12));
		y1L().set_SizeMode((PictureBoxSizeMode)4);
		y1L().set_TabIndex(1001);
		y1L().set_TabStop(false);
		((Control)b5G()).set_Location(new Point(333, 362));
		((Control)b5G()).set_Name("PictureBox143");
		((Control)b5G()).set_Size(new Size(10, 12));
		b5G().set_SizeMode((PictureBoxSizeMode)4);
		b5G().set_TabIndex(1000);
		b5G().set_TabStop(false);
		((Control)c6B()).set_Location(new Point(314, 362));
		((Control)c6B()).set_Name("PictureBox144");
		((Control)c6B()).set_Size(new Size(10, 12));
		c6B().set_SizeMode((PictureBoxSizeMode)4);
		c6B().set_TabIndex(999);
		c6B().set_TabStop(false);
		((Control)x9G()).set_Location(new Point(296, 362));
		((Control)x9G()).set_Name("PictureBox145");
		((Control)x9G()).set_Size(new Size(10, 12));
		x9G().set_SizeMode((PictureBoxSizeMode)4);
		x9G().set_TabIndex(998);
		x9G().set_TabStop(false);
		((Control)Me1()).set_Location(new Point(279, 362));
		((Control)Me1()).set_Name("PictureBox146");
		((Control)Me1()).set_Size(new Size(10, 12));
		Me1().set_SizeMode((PictureBoxSizeMode)4);
		Me1().set_TabIndex(997);
		Me1().set_TabStop(false);
		((Control)Pr8()).set_Location(new Point(261, 362));
		((Control)Pr8()).set_Name("PictureBox147");
		((Control)Pr8()).set_Size(new Size(10, 12));
		Pr8().set_SizeMode((PictureBoxSizeMode)4);
		Pr8().set_TabIndex(996);
		Pr8().set_TabStop(false);
		((Control)e5Q()).set_Location(new Point(245, 362));
		((Control)e5Q()).set_Name("PictureBox148");
		((Control)e5Q()).set_Size(new Size(10, 12));
		e5Q().set_SizeMode((PictureBoxSizeMode)4);
		e5Q().set_TabIndex(995);
		e5Q().set_TabStop(false);
		((Control)m3A()).set_Location(new Point(227, 362));
		((Control)m3A()).set_Name("PictureBox149");
		((Control)m3A()).set_Size(new Size(10, 12));
		m3A().set_SizeMode((PictureBoxSizeMode)4);
		m3A().set_TabIndex(994);
		m3A().set_TabStop(false);
		((Control)Pe7()).set_Location(new Point(208, 362));
		((Control)Pe7()).set_Name("PictureBox150");
		((Control)Pe7()).set_Size(new Size(10, 12));
		Pe7().set_SizeMode((PictureBoxSizeMode)4);
		Pe7().set_TabIndex(993);
		Pe7().set_TabStop(false);
		((Control)e2T()).set_Location(new Point(190, 362));
		((Control)e2T()).set_Name("PictureBox151");
		((Control)e2T()).set_Size(new Size(10, 12));
		e2T().set_SizeMode((PictureBoxSizeMode)4);
		e2T().set_TabIndex(992);
		e2T().set_TabStop(false);
		((Control)j9X()).set_Location(new Point(174, 362));
		((Control)j9X()).set_Name("PictureBox152");
		((Control)j9X()).set_Size(new Size(10, 12));
		j9X().set_SizeMode((PictureBoxSizeMode)4);
		j9X().set_TabIndex(991);
		j9X().set_TabStop(false);
		((Control)t5C()).set_Location(new Point(158, 362));
		((Control)t5C()).set_Name("PictureBox153");
		((Control)t5C()).set_Size(new Size(10, 12));
		t5C().set_SizeMode((PictureBoxSizeMode)4);
		t5C().set_TabIndex(990);
		t5C().set_TabStop(false);
		((Control)Da1()).set_Location(new Point(142, 362));
		((Control)Da1()).set_Name("PictureBox154");
		((Control)Da1()).set_Size(new Size(10, 12));
		Da1().set_SizeMode((PictureBoxSizeMode)4);
		Da1().set_TabIndex(989);
		Da1().set_TabStop(false);
		((Control)Gy7()).set_Location(new Point(126, 362));
		((Control)Gy7()).set_Name("PictureBox155");
		((Control)Gy7()).set_Size(new Size(10, 12));
		Gy7().set_SizeMode((PictureBoxSizeMode)4);
		Gy7().set_TabIndex(988);
		Gy7().set_TabStop(false);
		((Control)g4T()).set_Location(new Point(110, 362));
		((Control)g4T()).set_Name("PictureBox156");
		((Control)g4T()).set_Size(new Size(10, 12));
		g4T().set_SizeMode((PictureBoxSizeMode)4);
		g4T().set_TabIndex(987);
		g4T().set_TabStop(false);
		((Control)j3Q()).set_Location(new Point(94, 362));
		((Control)j3Q()).set_Name("PictureBox157");
		((Control)j3Q()).set_Size(new Size(10, 12));
		j3Q().set_SizeMode((PictureBoxSizeMode)4);
		j3Q().set_TabIndex(986);
		j3Q().set_TabStop(false);
		((Control)b4F()).set_Location(new Point(78, 362));
		((Control)b4F()).set_Name("PictureBox158");
		((Control)b4F()).set_Size(new Size(10, 12));
		b4F().set_SizeMode((PictureBoxSizeMode)4);
		b4F().set_TabIndex(985);
		b4F().set_TabStop(false);
		((Control)b8J()).set_Location(new Point(62, 362));
		((Control)b8J()).set_Name("PictureBox159");
		((Control)b8J()).set_Size(new Size(10, 12));
		b8J().set_SizeMode((PictureBoxSizeMode)4);
		b8J().set_TabIndex(984);
		b8J().set_TabStop(false);
		((Control)Dg9()).set_Location(new Point(48, 362));
		((Control)Dg9()).set_Name("PictureBox160");
		((Control)Dg9()).set_Size(new Size(10, 12));
		Dg9().set_SizeMode((PictureBoxSizeMode)4);
		Dg9().set_TabIndex(983);
		Dg9().set_TabStop(false);
		((Control)Tc1()).set_Location(new Point(372, 340));
		((Control)Tc1()).set_Name("PictureBox121");
		((Control)Tc1()).set_Size(new Size(10, 12));
		Tc1().set_SizeMode((PictureBoxSizeMode)4);
		Tc1().set_TabIndex(982);
		Tc1().set_TabStop(false);
		((Control)Qb9()).set_Location(new Point(352, 340));
		((Control)Qb9()).set_Name("PictureBox122");
		((Control)Qb9()).set_Size(new Size(10, 12));
		Qb9().set_SizeMode((PictureBoxSizeMode)4);
		Qb9().set_TabIndex(981);
		Qb9().set_TabStop(false);
		((Control)Aw4()).set_Location(new Point(333, 340));
		((Control)Aw4()).set_Name("PictureBox123");
		((Control)Aw4()).set_Size(new Size(10, 12));
		Aw4().set_SizeMode((PictureBoxSizeMode)4);
		Aw4().set_TabIndex(980);
		Aw4().set_TabStop(false);
		((Control)t0Y()).set_Location(new Point(314, 340));
		((Control)t0Y()).set_Name("PictureBox124");
		((Control)t0Y()).set_Size(new Size(10, 12));
		t0Y().set_SizeMode((PictureBoxSizeMode)4);
		t0Y().set_TabIndex(979);
		t0Y().set_TabStop(false);
		((Control)Pq5()).set_Location(new Point(296, 340));
		((Control)Pq5()).set_Name("PictureBox125");
		((Control)Pq5()).set_Size(new Size(10, 12));
		Pq5().set_SizeMode((PictureBoxSizeMode)4);
		Pq5().set_TabIndex(978);
		Pq5().set_TabStop(false);
		((Control)Gp2()).set_Location(new Point(279, 340));
		((Control)Gp2()).set_Name("PictureBox126");
		((Control)Gp2()).set_Size(new Size(10, 12));
		Gp2().set_SizeMode((PictureBoxSizeMode)4);
		Gp2().set_TabIndex(977);
		Gp2().set_TabStop(false);
		((Control)z8D()).set_Location(new Point(261, 340));
		((Control)z8D()).set_Name("PictureBox127");
		((Control)z8D()).set_Size(new Size(10, 12));
		z8D().set_SizeMode((PictureBoxSizeMode)4);
		z8D().set_TabIndex(976);
		z8D().set_TabStop(false);
		((Control)Fa1()).set_Location(new Point(245, 340));
		((Control)Fa1()).set_Name("PictureBox128");
		((Control)Fa1()).set_Size(new Size(10, 12));
		Fa1().set_SizeMode((PictureBoxSizeMode)4);
		Fa1().set_TabIndex(975);
		Fa1().set_TabStop(false);
		((Control)Zn3()).set_Location(new Point(227, 340));
		((Control)Zn3()).set_Name("PictureBox129");
		((Control)Zn3()).set_Size(new Size(10, 12));
		Zn3().set_SizeMode((PictureBoxSizeMode)4);
		Zn3().set_TabIndex(974);
		Zn3().set_TabStop(false);
		((Control)Pf4()).set_Location(new Point(208, 340));
		((Control)Pf4()).set_Name("PictureBox130");
		((Control)Pf4()).set_Size(new Size(10, 12));
		Pf4().set_SizeMode((PictureBoxSizeMode)4);
		Pf4().set_TabIndex(973);
		Pf4().set_TabStop(false);
		((Control)Jq1()).set_Location(new Point(190, 340));
		((Control)Jq1()).set_Name("PictureBox131");
		((Control)Jq1()).set_Size(new Size(10, 12));
		Jq1().set_SizeMode((PictureBoxSizeMode)4);
		Jq1().set_TabIndex(972);
		Jq1().set_TabStop(false);
		((Control)Ea7()).set_Location(new Point(174, 340));
		((Control)Ea7()).set_Name("PictureBox132");
		((Control)Ea7()).set_Size(new Size(10, 12));
		Ea7().set_SizeMode((PictureBoxSizeMode)4);
		Ea7().set_TabIndex(971);
		Ea7().set_TabStop(false);
		((Control)o1J()).set_Location(new Point(158, 340));
		((Control)o1J()).set_Name("PictureBox133");
		((Control)o1J()).set_Size(new Size(10, 12));
		o1J().set_SizeMode((PictureBoxSizeMode)4);
		o1J().set_TabIndex(970);
		o1J().set_TabStop(false);
		((Control)Pc2()).set_Location(new Point(142, 340));
		((Control)Pc2()).set_Name("PictureBox134");
		((Control)Pc2()).set_Size(new Size(10, 12));
		Pc2().set_SizeMode((PictureBoxSizeMode)4);
		Pc2().set_TabIndex(969);
		Pc2().set_TabStop(false);
		((Control)Tq3()).set_Location(new Point(126, 340));
		((Control)Tq3()).set_Name("PictureBox135");
		((Control)Tq3()).set_Size(new Size(10, 12));
		Tq3().set_SizeMode((PictureBoxSizeMode)4);
		Tq3().set_TabIndex(968);
		Tq3().set_TabStop(false);
		((Control)Wo3()).set_Location(new Point(110, 340));
		((Control)Wo3()).set_Name("PictureBox136");
		((Control)Wo3()).set_Size(new Size(10, 12));
		Wo3().set_SizeMode((PictureBoxSizeMode)4);
		Wo3().set_TabIndex(967);
		Wo3().set_TabStop(false);
		((Control)p1P()).set_Location(new Point(94, 340));
		((Control)p1P()).set_Name("PictureBox137");
		((Control)p1P()).set_Size(new Size(10, 12));
		p1P().set_SizeMode((PictureBoxSizeMode)4);
		p1P().set_TabIndex(966);
		p1P().set_TabStop(false);
		((Control)Zy7()).set_Location(new Point(78, 340));
		((Control)Zy7()).set_Name("PictureBox138");
		((Control)Zy7()).set_Size(new Size(10, 12));
		Zy7().set_SizeMode((PictureBoxSizeMode)4);
		Zy7().set_TabIndex(965);
		Zy7().set_TabStop(false);
		((Control)Hk9()).set_Location(new Point(62, 340));
		((Control)Hk9()).set_Name("PictureBox139");
		((Control)Hk9()).set_Size(new Size(10, 12));
		Hk9().set_SizeMode((PictureBoxSizeMode)4);
		Hk9().set_TabIndex(964);
		Hk9().set_TabStop(false);
		((Control)Zf2()).set_Location(new Point(48, 340));
		((Control)Zf2()).set_Name("PictureBox140");
		((Control)Zf2()).set_Size(new Size(10, 12));
		Zf2().set_SizeMode((PictureBoxSizeMode)4);
		Zf2().set_TabIndex(963);
		Zf2().set_TabStop(false);
		((Control)Qf5()).set_Location(new Point(372, 318));
		((Control)Qf5()).set_Name("PictureBox101");
		((Control)Qf5()).set_Size(new Size(10, 12));
		Qf5().set_SizeMode((PictureBoxSizeMode)4);
		Qf5().set_TabIndex(962);
		Qf5().set_TabStop(false);
		((Control)Bm9()).set_Location(new Point(352, 318));
		((Control)Bm9()).set_Name("PictureBox102");
		((Control)Bm9()).set_Size(new Size(10, 12));
		Bm9().set_SizeMode((PictureBoxSizeMode)4);
		Bm9().set_TabIndex(961);
		Bm9().set_TabStop(false);
		((Control)n6N()).set_Location(new Point(333, 318));
		((Control)n6N()).set_Name("PictureBox103");
		((Control)n6N()).set_Size(new Size(10, 12));
		n6N().set_SizeMode((PictureBoxSizeMode)4);
		n6N().set_TabIndex(960);
		n6N().set_TabStop(false);
		((Control)Po3()).set_Location(new Point(314, 318));
		((Control)Po3()).set_Name("PictureBox104");
		((Control)Po3()).set_Size(new Size(10, 12));
		Po3().set_SizeMode((PictureBoxSizeMode)4);
		Po3().set_TabIndex(959);
		Po3().set_TabStop(false);
		((Control)z0F()).set_Location(new Point(296, 318));
		((Control)z0F()).set_Name("PictureBox105");
		((Control)z0F()).set_Size(new Size(10, 12));
		z0F().set_SizeMode((PictureBoxSizeMode)4);
		z0F().set_TabIndex(958);
		z0F().set_TabStop(false);
		((Control)n9Q()).set_Location(new Point(279, 318));
		((Control)n9Q()).set_Name("PictureBox106");
		((Control)n9Q()).set_Size(new Size(10, 12));
		n9Q().set_SizeMode((PictureBoxSizeMode)4);
		n9Q().set_TabIndex(957);
		n9Q().set_TabStop(false);
		((Control)k3S()).set_Location(new Point(261, 318));
		((Control)k3S()).set_Name("PictureBox107");
		((Control)k3S()).set_Size(new Size(10, 12));
		k3S().set_SizeMode((PictureBoxSizeMode)4);
		k3S().set_TabIndex(956);
		k3S().set_TabStop(false);
		((Control)Gg0()).set_Location(new Point(245, 318));
		((Control)Gg0()).set_Name("PictureBox108");
		((Control)Gg0()).set_Size(new Size(10, 12));
		Gg0().set_SizeMode((PictureBoxSizeMode)4);
		Gg0().set_TabIndex(955);
		Gg0().set_TabStop(false);
		((Control)Fm5()).set_Location(new Point(227, 318));
		((Control)Fm5()).set_Name("PictureBox109");
		((Control)Fm5()).set_Size(new Size(10, 12));
		Fm5().set_SizeMode((PictureBoxSizeMode)4);
		Fm5().set_TabIndex(954);
		Fm5().set_TabStop(false);
		((Control)Ns7()).set_Location(new Point(208, 318));
		((Control)Ns7()).set_Name("PictureBox110");
		((Control)Ns7()).set_Size(new Size(10, 12));
		Ns7().set_SizeMode((PictureBoxSizeMode)4);
		Ns7().set_TabIndex(953);
		Ns7().set_TabStop(false);
		((Control)f0E()).set_Location(new Point(190, 318));
		((Control)f0E()).set_Name("PictureBox111");
		((Control)f0E()).set_Size(new Size(10, 12));
		f0E().set_SizeMode((PictureBoxSizeMode)4);
		f0E().set_TabIndex(952);
		f0E().set_TabStop(false);
		((Control)Jx7()).set_Location(new Point(174, 318));
		((Control)Jx7()).set_Name("PictureBox112");
		((Control)Jx7()).set_Size(new Size(10, 12));
		Jx7().set_SizeMode((PictureBoxSizeMode)4);
		Jx7().set_TabIndex(951);
		Jx7().set_TabStop(false);
		((Control)s1J()).set_Location(new Point(158, 318));
		((Control)s1J()).set_Name("PictureBox113");
		((Control)s1J()).set_Size(new Size(10, 12));
		s1J().set_SizeMode((PictureBoxSizeMode)4);
		s1J().set_TabIndex(950);
		s1J().set_TabStop(false);
		((Control)Hz9()).set_Location(new Point(142, 318));
		((Control)Hz9()).set_Name("PictureBox114");
		((Control)Hz9()).set_Size(new Size(10, 12));
		Hz9().set_SizeMode((PictureBoxSizeMode)4);
		Hz9().set_TabIndex(949);
		Hz9().set_TabStop(false);
		((Control)x4A()).set_Location(new Point(126, 318));
		((Control)x4A()).set_Name("PictureBox115");
		((Control)x4A()).set_Size(new Size(10, 12));
		x4A().set_SizeMode((PictureBoxSizeMode)4);
		x4A().set_TabIndex(948);
		x4A().set_TabStop(false);
		((Control)j7T()).set_Location(new Point(110, 318));
		((Control)j7T()).set_Name("PictureBox116");
		((Control)j7T()).set_Size(new Size(10, 12));
		j7T().set_SizeMode((PictureBoxSizeMode)4);
		j7T().set_TabIndex(947);
		j7T().set_TabStop(false);
		((Control)Ld9()).set_Location(new Point(94, 318));
		((Control)Ld9()).set_Name("PictureBox117");
		((Control)Ld9()).set_Size(new Size(10, 12));
		Ld9().set_SizeMode((PictureBoxSizeMode)4);
		Ld9().set_TabIndex(946);
		Ld9().set_TabStop(false);
		((Control)Lt9()).set_Location(new Point(78, 318));
		((Control)Lt9()).set_Name("PictureBox118");
		((Control)Lt9()).set_Size(new Size(10, 12));
		Lt9().set_SizeMode((PictureBoxSizeMode)4);
		Lt9().set_TabIndex(945);
		Lt9().set_TabStop(false);
		((Control)w9L()).set_Location(new Point(62, 318));
		((Control)w9L()).set_Name("PictureBox119");
		((Control)w9L()).set_Size(new Size(10, 12));
		w9L().set_SizeMode((PictureBoxSizeMode)4);
		w9L().set_TabIndex(944);
		w9L().set_TabStop(false);
		((Control)z2N()).set_Location(new Point(48, 318));
		((Control)z2N()).set_Name("PictureBox120");
		((Control)z2N()).set_Size(new Size(10, 12));
		z2N().set_SizeMode((PictureBoxSizeMode)4);
		z2N().set_TabIndex(943);
		z2N().set_TabStop(false);
		((Control)b9G()).set_Location(new Point(372, 299));
		((Control)b9G()).set_Name("PictureBox81");
		((Control)b9G()).set_Size(new Size(10, 12));
		b9G().set_SizeMode((PictureBoxSizeMode)4);
		b9G().set_TabIndex(942);
		b9G().set_TabStop(false);
		((Control)Fw6()).set_Location(new Point(352, 299));
		((Control)Fw6()).set_Name("PictureBox82");
		((Control)Fw6()).set_Size(new Size(10, 12));
		Fw6().set_SizeMode((PictureBoxSizeMode)4);
		Fw6().set_TabIndex(941);
		Fw6().set_TabStop(false);
		((Control)St4()).set_Location(new Point(333, 299));
		((Control)St4()).set_Name("PictureBox83");
		((Control)St4()).set_Size(new Size(10, 12));
		St4().set_SizeMode((PictureBoxSizeMode)4);
		St4().set_TabIndex(940);
		St4().set_TabStop(false);
		((Control)e3H()).set_Location(new Point(314, 299));
		((Control)e3H()).set_Name("PictureBox84");
		((Control)e3H()).set_Size(new Size(10, 12));
		e3H().set_SizeMode((PictureBoxSizeMode)4);
		e3H().set_TabIndex(939);
		e3H().set_TabStop(false);
		((Control)Ae2()).set_Location(new Point(296, 299));
		((Control)Ae2()).set_Name("PictureBox85");
		((Control)Ae2()).set_Size(new Size(10, 12));
		Ae2().set_SizeMode((PictureBoxSizeMode)4);
		Ae2().set_TabIndex(938);
		Ae2().set_TabStop(false);
		((Control)i8P()).set_Location(new Point(279, 299));
		((Control)i8P()).set_Name("PictureBox86");
		((Control)i8P()).set_Size(new Size(10, 12));
		i8P().set_SizeMode((PictureBoxSizeMode)4);
		i8P().set_TabIndex(937);
		i8P().set_TabStop(false);
		((Control)Xe8()).set_Location(new Point(261, 299));
		((Control)Xe8()).set_Name("PictureBox87");
		((Control)Xe8()).set_Size(new Size(10, 12));
		Xe8().set_SizeMode((PictureBoxSizeMode)4);
		Xe8().set_TabIndex(936);
		Xe8().set_TabStop(false);
		((Control)w0S()).set_Location(new Point(245, 299));
		((Control)w0S()).set_Name("PictureBox88");
		((Control)w0S()).set_Size(new Size(10, 12));
		w0S().set_SizeMode((PictureBoxSizeMode)4);
		w0S().set_TabIndex(935);
		w0S().set_TabStop(false);
		((Control)Qy6()).set_Location(new Point(227, 299));
		((Control)Qy6()).set_Name("PictureBox89");
		((Control)Qy6()).set_Size(new Size(10, 12));
		Qy6().set_SizeMode((PictureBoxSizeMode)4);
		Qy6().set_TabIndex(934);
		Qy6().set_TabStop(false);
		((Control)t8W()).set_Location(new Point(208, 299));
		((Control)t8W()).set_Name("PictureBox90");
		((Control)t8W()).set_Size(new Size(10, 12));
		t8W().set_SizeMode((PictureBoxSizeMode)4);
		t8W().set_TabIndex(933);
		t8W().set_TabStop(false);
		((Control)g9P()).set_Location(new Point(190, 299));
		((Control)g9P()).set_Name("PictureBox91");
		((Control)g9P()).set_Size(new Size(10, 12));
		g9P().set_SizeMode((PictureBoxSizeMode)4);
		g9P().set_TabIndex(932);
		g9P().set_TabStop(false);
		((Control)Wb7()).set_Location(new Point(174, 299));
		((Control)Wb7()).set_Name("PictureBox92");
		((Control)Wb7()).set_Size(new Size(10, 12));
		Wb7().set_SizeMode((PictureBoxSizeMode)4);
		Wb7().set_TabIndex(931);
		Wb7().set_TabStop(false);
		((Control)Ha0()).set_Location(new Point(158, 299));
		((Control)Ha0()).set_Name("PictureBox93");
		((Control)Ha0()).set_Size(new Size(10, 12));
		Ha0().set_SizeMode((PictureBoxSizeMode)4);
		Ha0().set_TabIndex(930);
		Ha0().set_TabStop(false);
		((Control)b5S()).set_Location(new Point(142, 299));
		((Control)b5S()).set_Name("PictureBox94");
		((Control)b5S()).set_Size(new Size(10, 12));
		b5S().set_SizeMode((PictureBoxSizeMode)4);
		b5S().set_TabIndex(929);
		b5S().set_TabStop(false);
		((Control)y8B()).set_Location(new Point(126, 299));
		((Control)y8B()).set_Name("PictureBox95");
		((Control)y8B()).set_Size(new Size(10, 12));
		y8B().set_SizeMode((PictureBoxSizeMode)4);
		y8B().set_TabIndex(928);
		y8B().set_TabStop(false);
		((Control)Kz8()).set_Location(new Point(110, 299));
		((Control)Kz8()).set_Name("PictureBox96");
		((Control)Kz8()).set_Size(new Size(10, 12));
		Kz8().set_SizeMode((PictureBoxSizeMode)4);
		Kz8().set_TabIndex(927);
		Kz8().set_TabStop(false);
		((Control)Kq7()).set_Location(new Point(94, 299));
		((Control)Kq7()).set_Name("PictureBox97");
		((Control)Kq7()).set_Size(new Size(10, 12));
		Kq7().set_SizeMode((PictureBoxSizeMode)4);
		Kq7().set_TabIndex(926);
		Kq7().set_TabStop(false);
		((Control)Km9()).set_Location(new Point(78, 299));
		((Control)Km9()).set_Name("PictureBox98");
		((Control)Km9()).set_Size(new Size(10, 12));
		Km9().set_SizeMode((PictureBoxSizeMode)4);
		Km9().set_TabIndex(925);
		Km9().set_TabStop(false);
		((Control)Dg8()).set_Location(new Point(62, 299));
		((Control)Dg8()).set_Name("PictureBox99");
		((Control)Dg8()).set_Size(new Size(10, 12));
		Dg8().set_SizeMode((PictureBoxSizeMode)4);
		Dg8().set_TabIndex(924);
		Dg8().set_TabStop(false);
		((Control)Co8()).set_Location(new Point(48, 299));
		((Control)Co8()).set_Name("PictureBox100");
		((Control)Co8()).set_Size(new Size(10, 12));
		Co8().set_SizeMode((PictureBoxSizeMode)4);
		Co8().set_TabIndex(923);
		Co8().set_TabStop(false);
		((Control)q4N()).set_Location(new Point(372, 187));
		((Control)q4N()).set_Name("PictureBox61");
		((Control)q4N()).set_Size(new Size(10, 10));
		q4N().set_SizeMode((PictureBoxSizeMode)4);
		q4N().set_TabIndex(922);
		q4N().set_TabStop(false);
		((Control)Pb4()).set_Location(new Point(352, 187));
		((Control)Pb4()).set_Name("PictureBox62");
		((Control)Pb4()).set_Size(new Size(10, 10));
		Pb4().set_SizeMode((PictureBoxSizeMode)4);
		Pb4().set_TabIndex(921);
		Pb4().set_TabStop(false);
		((Control)Kn8()).set_Location(new Point(333, 187));
		((Control)Kn8()).set_Name("PictureBox63");
		((Control)Kn8()).set_Size(new Size(10, 10));
		Kn8().set_SizeMode((PictureBoxSizeMode)4);
		Kn8().set_TabIndex(920);
		Kn8().set_TabStop(false);
		((Control)Fc0()).set_Location(new Point(314, 187));
		((Control)Fc0()).set_Name("PictureBox64");
		((Control)Fc0()).set_Size(new Size(10, 10));
		Fc0().set_SizeMode((PictureBoxSizeMode)4);
		Fc0().set_TabIndex(919);
		Fc0().set_TabStop(false);
		((Control)At9()).set_Location(new Point(296, 187));
		((Control)At9()).set_Name("PictureBox65");
		((Control)At9()).set_Size(new Size(10, 10));
		At9().set_SizeMode((PictureBoxSizeMode)4);
		At9().set_TabIndex(918);
		At9().set_TabStop(false);
		((Control)g0G()).set_Location(new Point(279, 187));
		((Control)g0G()).set_Name("PictureBox66");
		((Control)g0G()).set_Size(new Size(10, 10));
		g0G().set_SizeMode((PictureBoxSizeMode)4);
		g0G().set_TabIndex(917);
		g0G().set_TabStop(false);
		((Control)k3W2()).set_Location(new Point(261, 187));
		((Control)k3W2()).set_Name("PictureBox67");
		((Control)k3W2()).set_Size(new Size(10, 10));
		k3W2().set_SizeMode((PictureBoxSizeMode)4);
		k3W2().set_TabIndex(916);
		k3W2().set_TabStop(false);
		((Control)i5C1()).set_Location(new Point(245, 187));
		((Control)i5C1()).set_Name("PictureBox68");
		((Control)i5C1()).set_Size(new Size(10, 10));
		i5C1().set_SizeMode((PictureBoxSizeMode)4);
		i5C1().set_TabIndex(915);
		i5C1().set_TabStop(false);
		((Control)Ye6b()).set_Location(new Point(227, 187));
		((Control)Ye6b()).set_Name("PictureBox69");
		((Control)Ye6b()).set_Size(new Size(10, 10));
		Ye6b().set_SizeMode((PictureBoxSizeMode)4);
		Ye6b().set_TabIndex(914);
		Ye6b().set_TabStop(false);
		((Control)Tk06()).set_Location(new Point(208, 187));
		((Control)Tk06()).set_Name("PictureBox70");
		((Control)Tk06()).set_Size(new Size(10, 10));
		Tk06().set_SizeMode((PictureBoxSizeMode)4);
		Tk06().set_TabIndex(913);
		Tk06().set_TabStop(false);
		((Control)Ks8r()).set_Location(new Point(190, 187));
		((Control)Ks8r()).set_Name("PictureBox71");
		((Control)Ks8r()).set_Size(new Size(10, 10));
		Ks8r().set_SizeMode((PictureBoxSizeMode)4);
		Ks8r().set_TabIndex(912);
		Ks8r().set_TabStop(false);
		((Control)Ws96()).set_Location(new Point(174, 187));
		((Control)Ws96()).set_Name("PictureBox72");
		((Control)Ws96()).set_Size(new Size(10, 10));
		Ws96().set_SizeMode((PictureBoxSizeMode)4);
		Ws96().set_TabIndex(911);
		Ws96().set_TabStop(false);
		((Control)z9T1()).set_Location(new Point(158, 187));
		((Control)z9T1()).set_Name("PictureBox73");
		((Control)z9T1()).set_Size(new Size(10, 10));
		z9T1().set_SizeMode((PictureBoxSizeMode)4);
		z9T1().set_TabIndex(910);
		z9T1().set_TabStop(false);
		((Control)Gz21()).set_Location(new Point(142, 187));
		((Control)Gz21()).set_Name("PictureBox74");
		((Control)Gz21()).set_Size(new Size(10, 10));
		Gz21().set_SizeMode((PictureBoxSizeMode)4);
		Gz21().set_TabIndex(909);
		Gz21().set_TabStop(false);
		((Control)So09()).set_Location(new Point(126, 187));
		((Control)So09()).set_Name("PictureBox75");
		((Control)So09()).set_Size(new Size(10, 10));
		So09().set_SizeMode((PictureBoxSizeMode)4);
		So09().set_TabIndex(908);
		So09().set_TabStop(false);
		((Control)Et85()).set_Location(new Point(110, 187));
		((Control)Et85()).set_Name("PictureBox76");
		((Control)Et85()).set_Size(new Size(10, 10));
		Et85().set_SizeMode((PictureBoxSizeMode)4);
		Et85().set_TabIndex(907);
		Et85().set_TabStop(false);
		((Control)Dy47()).set_Location(new Point(94, 187));
		((Control)Dy47()).set_Name("PictureBox77");
		((Control)Dy47()).set_Size(new Size(10, 10));
		Dy47().set_SizeMode((PictureBoxSizeMode)4);
		Dy47().set_TabIndex(906);
		Dy47().set_TabStop(false);
		((Control)z9R2()).set_Location(new Point(78, 187));
		((Control)z9R2()).set_Name("PictureBox78");
		((Control)z9R2()).set_Size(new Size(10, 10));
		z9R2().set_SizeMode((PictureBoxSizeMode)4);
		z9R2().set_TabIndex(905);
		z9R2().set_TabStop(false);
		((Control)Ds70()).set_Location(new Point(62, 187));
		((Control)Ds70()).set_Name("PictureBox79");
		((Control)Ds70()).set_Size(new Size(10, 10));
		Ds70().set_SizeMode((PictureBoxSizeMode)4);
		Ds70().set_TabIndex(904);
		Ds70().set_TabStop(false);
		((Control)a2BA()).set_Location(new Point(48, 187));
		((Control)a2BA()).set_Name("PictureBox80");
		((Control)a2BA()).set_Size(new Size(10, 10));
		a2BA().set_SizeMode((PictureBoxSizeMode)4);
		a2BA().set_TabIndex(903);
		a2BA().set_TabStop(false);
		((Control)a6B3()).set_Location(new Point(372, 165));
		((Control)a6B3()).set_Name("PictureBox41");
		((Control)a6B3()).set_Size(new Size(10, 10));
		a6B3().set_SizeMode((PictureBoxSizeMode)4);
		a6B3().set_TabIndex(902);
		a6B3().set_TabStop(false);
		((Control)a4QS()).set_Location(new Point(352, 165));
		((Control)a4QS()).set_Name("PictureBox42");
		((Control)a4QS()).set_Size(new Size(10, 10));
		a4QS().set_SizeMode((PictureBoxSizeMode)4);
		a4QS().set_TabIndex(901);
		a4QS().set_TabStop(false);
		((Control)Kf6n()).set_Location(new Point(333, 165));
		((Control)Kf6n()).set_Name("PictureBox43");
		((Control)Kf6n()).set_Size(new Size(10, 10));
		Kf6n().set_SizeMode((PictureBoxSizeMode)4);
		Kf6n().set_TabIndex(900);
		Kf6n().set_TabStop(false);
		((Control)Sf0j()).set_Location(new Point(314, 165));
		((Control)Sf0j()).set_Name("PictureBox44");
		((Control)Sf0j()).set_Size(new Size(10, 10));
		Sf0j().set_SizeMode((PictureBoxSizeMode)4);
		Sf0j().set_TabIndex(899);
		Sf0j().set_TabStop(false);
		((Control)Xy4z()).set_Location(new Point(296, 165));
		((Control)Xy4z()).set_Name("PictureBox45");
		((Control)Xy4z()).set_Size(new Size(10, 10));
		Xy4z().set_SizeMode((PictureBoxSizeMode)4);
		Xy4z().set_TabIndex(898);
		Xy4z().set_TabStop(false);
		((Control)a2B3()).set_Location(new Point(279, 165));
		((Control)a2B3()).set_Name("PictureBox46");
		((Control)a2B3()).set_Size(new Size(10, 10));
		a2B3().set_SizeMode((PictureBoxSizeMode)4);
		a2B3().set_TabIndex(897);
		a2B3().set_TabStop(false);
		((Control)Dg96()).set_Location(new Point(261, 165));
		((Control)Dg96()).set_Name("PictureBox47");
		((Control)Dg96()).set_Size(new Size(10, 10));
		Dg96().set_SizeMode((PictureBoxSizeMode)4);
		Dg96().set_TabIndex(896);
		Dg96().set_TabStop(false);
		((Control)g7RE()).set_Location(new Point(245, 165));
		((Control)g7RE()).set_Name("PictureBox48");
		((Control)g7RE()).set_Size(new Size(10, 10));
		g7RE().set_SizeMode((PictureBoxSizeMode)4);
		g7RE().set_TabIndex(895);
		g7RE().set_TabStop(false);
		((Control)Tp7z()).set_Location(new Point(227, 165));
		((Control)Tp7z()).set_Name("PictureBox49");
		((Control)Tp7z()).set_Size(new Size(10, 10));
		Tp7z().set_SizeMode((PictureBoxSizeMode)4);
		Tp7z().set_TabIndex(894);
		Tp7z().set_TabStop(false);
		((Control)d1L5()).set_Location(new Point(208, 165));
		((Control)d1L5()).set_Name("PictureBox50");
		((Control)d1L5()).set_Size(new Size(10, 10));
		d1L5().set_SizeMode((PictureBoxSizeMode)4);
		d1L5().set_TabIndex(893);
		d1L5().set_TabStop(false);
		((Control)Bq97()).set_Location(new Point(190, 165));
		((Control)Bq97()).set_Name("PictureBox51");
		((Control)Bq97()).set_Size(new Size(10, 10));
		Bq97().set_SizeMode((PictureBoxSizeMode)4);
		Bq97().set_TabIndex(892);
		Bq97().set_TabStop(false);
		((Control)Ge19()).set_Location(new Point(174, 165));
		((Control)Ge19()).set_Name("PictureBox52");
		((Control)Ge19()).set_Size(new Size(10, 10));
		Ge19().set_SizeMode((PictureBoxSizeMode)4);
		Ge19().set_TabIndex(891);
		Ge19().set_TabStop(false);
		((Control)y8QL()).set_Location(new Point(158, 165));
		((Control)y8QL()).set_Name("PictureBox53");
		((Control)y8QL()).set_Size(new Size(10, 10));
		y8QL().set_SizeMode((PictureBoxSizeMode)4);
		y8QL().set_TabIndex(890);
		y8QL().set_TabStop(false);
		((Control)p0MA()).set_Location(new Point(142, 165));
		((Control)p0MA()).set_Name("PictureBox54");
		((Control)p0MA()).set_Size(new Size(10, 10));
		p0MA().set_SizeMode((PictureBoxSizeMode)4);
		p0MA().set_TabIndex(889);
		p0MA().set_TabStop(false);
		((Control)Fp7o()).set_Location(new Point(126, 165));
		((Control)Fp7o()).set_Name("PictureBox55");
		((Control)Fp7o()).set_Size(new Size(10, 10));
		Fp7o().set_SizeMode((PictureBoxSizeMode)4);
		Fp7o().set_TabIndex(888);
		Fp7o().set_TabStop(false);
		((Control)b6H2()).set_Location(new Point(110, 165));
		((Control)b6H2()).set_Name("PictureBox56");
		((Control)b6H2()).set_Size(new Size(10, 10));
		b6H2().set_SizeMode((PictureBoxSizeMode)4);
		b6H2().set_TabIndex(887);
		b6H2().set_TabStop(false);
		((Control)r6QH()).set_Location(new Point(94, 165));
		((Control)r6QH()).set_Name("PictureBox57");
		((Control)r6QH()).set_Size(new Size(10, 10));
		r6QH().set_SizeMode((PictureBoxSizeMode)4);
		r6QH().set_TabIndex(886);
		r6QH().set_TabStop(false);
		((Control)b9M5()).set_Location(new Point(78, 165));
		((Control)b9M5()).set_Name("PictureBox58");
		((Control)b9M5()).set_Size(new Size(10, 10));
		b9M5().set_SizeMode((PictureBoxSizeMode)4);
		b9M5().set_TabIndex(885);
		b9M5().set_TabStop(false);
		((Control)s6X0()).set_Location(new Point(62, 165));
		((Control)s6X0()).set_Name("PictureBox59");
		((Control)s6X0()).set_Size(new Size(10, 10));
		s6X0().set_SizeMode((PictureBoxSizeMode)4);
		s6X0().set_TabIndex(884);
		s6X0().set_TabStop(false);
		((Control)Sq2d()).set_Location(new Point(48, 165));
		((Control)Sq2d()).set_Name("PictureBox60");
		((Control)Sq2d()).set_Size(new Size(10, 10));
		Sq2d().set_SizeMode((PictureBoxSizeMode)4);
		Sq2d().set_TabIndex(883);
		Sq2d().set_TabStop(false);
		((Control)e4PT()).set_Location(new Point(372, 143));
		((Control)e4PT()).set_Name("PictureBox21");
		((Control)e4PT()).set_Size(new Size(10, 10));
		e4PT().set_SizeMode((PictureBoxSizeMode)4);
		e4PT().set_TabIndex(882);
		e4PT().set_TabStop(false);
		((Control)Jr6q()).set_Location(new Point(352, 143));
		((Control)Jr6q()).set_Name("PictureBox22");
		((Control)Jr6q()).set_Size(new Size(10, 10));
		Jr6q().set_SizeMode((PictureBoxSizeMode)4);
		Jr6q().set_TabIndex(881);
		Jr6q().set_TabStop(false);
		((Control)g2X5()).set_Location(new Point(333, 143));
		((Control)g2X5()).set_Name("PictureBox23");
		((Control)g2X5()).set_Size(new Size(10, 10));
		g2X5().set_SizeMode((PictureBoxSizeMode)4);
		g2X5().set_TabIndex(880);
		g2X5().set_TabStop(false);
		((Control)Bx8z()).set_Location(new Point(314, 143));
		((Control)Bx8z()).set_Name("PictureBox24");
		((Control)Bx8z()).set_Size(new Size(10, 10));
		Bx8z().set_SizeMode((PictureBoxSizeMode)4);
		Bx8z().set_TabIndex(879);
		Bx8z().set_TabStop(false);
		((Control)g6L7()).set_Location(new Point(296, 143));
		((Control)g6L7()).set_Name("PictureBox25");
		((Control)g6L7()).set_Size(new Size(10, 10));
		g6L7().set_SizeMode((PictureBoxSizeMode)4);
		g6L7().set_TabIndex(878);
		g6L7().set_TabStop(false);
		((Control)f3ZF()).set_Location(new Point(279, 143));
		((Control)f3ZF()).set_Name("PictureBox26");
		((Control)f3ZF()).set_Size(new Size(10, 10));
		f3ZF().set_SizeMode((PictureBoxSizeMode)4);
		f3ZF().set_TabIndex(877);
		f3ZF().set_TabStop(false);
		((Control)n8J2()).set_Location(new Point(261, 143));
		((Control)n8J2()).set_Name("PictureBox27");
		((Control)n8J2()).set_Size(new Size(10, 10));
		n8J2().set_SizeMode((PictureBoxSizeMode)4);
		n8J2().set_TabIndex(876);
		n8J2().set_TabStop(false);
		((Control)q0B4()).set_Location(new Point(245, 143));
		((Control)q0B4()).set_Name("PictureBox28");
		((Control)q0B4()).set_Size(new Size(10, 10));
		q0B4().set_SizeMode((PictureBoxSizeMode)4);
		q0B4().set_TabIndex(875);
		q0B4().set_TabStop(false);
		((Control)Go3n()).set_Location(new Point(227, 143));
		((Control)Go3n()).set_Name("PictureBox29");
		((Control)Go3n()).set_Size(new Size(10, 10));
		Go3n().set_SizeMode((PictureBoxSizeMode)4);
		Go3n().set_TabIndex(874);
		Go3n().set_TabStop(false);
		((Control)n7GH()).set_Location(new Point(208, 143));
		((Control)n7GH()).set_Name("PictureBox30");
		((Control)n7GH()).set_Size(new Size(10, 10));
		n7GH().set_SizeMode((PictureBoxSizeMode)4);
		n7GH().set_TabIndex(873);
		n7GH().set_TabStop(false);
		((Control)k5CG()).set_Location(new Point(190, 143));
		((Control)k5CG()).set_Name("PictureBox31");
		((Control)k5CG()).set_Size(new Size(10, 10));
		k5CG().set_SizeMode((PictureBoxSizeMode)4);
		k5CG().set_TabIndex(872);
		k5CG().set_TabStop(false);
		((Control)s1E0()).set_Location(new Point(174, 143));
		((Control)s1E0()).set_Name("PictureBox32");
		((Control)s1E0()).set_Size(new Size(10, 10));
		s1E0().set_SizeMode((PictureBoxSizeMode)4);
		s1E0().set_TabIndex(871);
		s1E0().set_TabStop(false);
		((Control)Lf3c()).set_Location(new Point(158, 143));
		((Control)Lf3c()).set_Name("PictureBox33");
		((Control)Lf3c()).set_Size(new Size(10, 10));
		Lf3c().set_SizeMode((PictureBoxSizeMode)4);
		Lf3c().set_TabIndex(870);
		Lf3c().set_TabStop(false);
		((Control)Cr56()).set_Location(new Point(142, 143));
		((Control)Cr56()).set_Name("PictureBox34");
		((Control)Cr56()).set_Size(new Size(10, 10));
		Cr56().set_SizeMode((PictureBoxSizeMode)4);
		Cr56().set_TabIndex(869);
		Cr56().set_TabStop(false);
		((Control)k6ZT()).set_Location(new Point(126, 143));
		((Control)k6ZT()).set_Name("PictureBox35");
		((Control)k6ZT()).set_Size(new Size(10, 10));
		k6ZT().set_SizeMode((PictureBoxSizeMode)4);
		k6ZT().set_TabIndex(868);
		k6ZT().set_TabStop(false);
		((Control)Dr79()).set_Location(new Point(110, 143));
		((Control)Dr79()).set_Name("PictureBox36");
		((Control)Dr79()).set_Size(new Size(10, 10));
		Dr79().set_SizeMode((PictureBoxSizeMode)4);
		Dr79().set_TabIndex(867);
		Dr79().set_TabStop(false);
		((Control)d4A1()).set_Location(new Point(94, 143));
		((Control)d4A1()).set_Name("PictureBox37");
		((Control)d4A1()).set_Size(new Size(10, 10));
		d4A1().set_SizeMode((PictureBoxSizeMode)4);
		d4A1().set_TabIndex(866);
		d4A1().set_TabStop(false);
		((Control)k0GY()).set_Location(new Point(78, 143));
		((Control)k0GY()).set_Name("PictureBox38");
		((Control)k0GY()).set_Size(new Size(10, 10));
		k0GY().set_SizeMode((PictureBoxSizeMode)4);
		k0GY().set_TabIndex(865);
		k0GY().set_TabStop(false);
		((Control)Rx3k()).set_Location(new Point(151, 16));
		((Control)Rx3k()).set_Name("txtAvailable");
		((Control)Rx3k()).set_Size(new Size(83, 20));
		((Control)Rx3k()).set_TabIndex(25);
		((Control)Dp6d()).set_BackColor(Color.Transparent);
		((Control)Dp6d()).set_Location(new Point(5, 47));
		((Control)Dp6d()).set_Name("Booked");
		((Control)Dp6d()).set_Size(new Size(23, 18));
		Dp6d().set_SizeMode((PictureBoxSizeMode)4);
		Dp6d().set_TabIndex(27);
		Dp6d().set_TabStop(false);
		((Control)Ab62()).set_BackColor(Color.Transparent);
		((Control)Ab62()).set_Location(new Point(6, 74));
		((Control)Ab62()).set_Name("Provisional");
		((Control)Ab62()).set_Size(new Size(23, 17));
		Ab62().set_SizeMode((PictureBoxSizeMode)4);
		Ab62().set_TabIndex(26);
		Ab62().set_TabStop(false);
		((Control)Sk38()).set_BackColor(Color.Transparent);
		((Control)Sk38()).set_Location(new Point(5, 23));
		((Control)Sk38()).set_Name("Available");
		((Control)Sk38()).set_Size(new Size(23, 17));
		Sk38().set_SizeMode((PictureBoxSizeMode)4);
		Sk38().set_TabIndex(25);
		Sk38().set_TabStop(false);
		w3KW().set_AutoSize(true);
		((Control)w3KW()).set_BackColor(Color.Transparent);
		((Control)w3KW()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)w3KW()).set_Location(new Point(30, 49));
		((Control)w3KW()).set_Name("Label3");
		((Control)w3KW()).set_Size(new Size(74, 13));
		((Control)w3KW()).set_TabIndex(12);
		w3KW().set_Text("Booked Seats");
		((Control)a8L0()).set_Location(new Point(62, 143));
		((Control)a8L0()).set_Name("PictureBox39");
		((Control)a8L0()).set_Size(new Size(10, 10));
		a8L0().set_SizeMode((PictureBoxSizeMode)4);
		a8L0().set_TabIndex(864);
		a8L0().set_TabStop(false);
		((Control)n5QT()).set_Location(new Point(151, 42));
		((Control)n5QT()).set_Name("txtBooked");
		((Control)n5QT()).set_Size(new Size(83, 20));
		((Control)n5QT()).set_TabIndex(28);
		Xn37().set_AutoSize(true);
		((Control)Xn37()).set_BackColor(Color.Transparent);
		((Control)Xn37()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Xn37()).set_Location(new Point(30, 76));
		((Control)Xn37()).set_Name("Label1");
		((Control)Xn37()).set_Size(new Size(115, 13));
		((Control)Xn37()).set_TabIndex(11);
		Xn37().set_Text("Seat[s] on Reservation");
		Fj31().set_AutoSize(true);
		((Control)Fj31()).set_BackColor(Color.Transparent);
		((Control)Fj31()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Fj31()).set_Location(new Point(30, 24));
		((Control)Fj31()).set_Name("Label2");
		((Control)Fj31()).set_Size(new Size(80, 13));
		((Control)Fj31()).set_TabIndex(10);
		Fj31().set_Text("Available Seats");
		((Control)Ea5b()).set_Location(new Point(48, 143));
		((Control)Ea5b()).set_Name("PictureBox40");
		((Control)Ea5b()).set_Size(new Size(10, 10));
		Ea5b().set_SizeMode((PictureBoxSizeMode)4);
		Ea5b().set_TabIndex(863);
		Ea5b().set_TabStop(false);
		((Control)Rr59()).set_Location(new Point(372, 121));
		((Control)Rr59()).set_Name("PictureBox20");
		((Control)Rr59()).set_Size(new Size(10, 10));
		Rr59().set_SizeMode((PictureBoxSizeMode)4);
		Rr59().set_TabIndex(862);
		Rr59().set_TabStop(false);
		((Control)Lt83()).set_Location(new Point(352, 121));
		((Control)Lt83()).set_Name("PictureBox19");
		((Control)Lt83()).set_Size(new Size(10, 10));
		Lt83().set_SizeMode((PictureBoxSizeMode)4);
		Lt83().set_TabIndex(861);
		Lt83().set_TabStop(false);
		((Control)Mi50()).set_Location(new Point(333, 121));
		((Control)Mi50()).set_Name("PictureBox18");
		((Control)Mi50()).set_Size(new Size(10, 10));
		Mi50().set_SizeMode((PictureBoxSizeMode)4);
		Mi50().set_TabIndex(860);
		Mi50().set_TabStop(false);
		((Control)Yy4t()).set_Location(new Point(314, 121));
		((Control)Yy4t()).set_Name("PictureBox17");
		((Control)Yy4t()).set_Size(new Size(10, 10));
		Yy4t().set_SizeMode((PictureBoxSizeMode)4);
		Yy4t().set_TabIndex(859);
		Yy4t().set_TabStop(false);
		((Control)Fd79()).set_Location(new Point(296, 121));
		((Control)Fd79()).set_Name("PictureBox16");
		((Control)Fd79()).set_Size(new Size(10, 10));
		Fd79().set_SizeMode((PictureBoxSizeMode)4);
		Fd79().set_TabIndex(858);
		Fd79().set_TabStop(false);
		((Control)Li0k()).set_Location(new Point(279, 121));
		((Control)Li0k()).set_Name("PictureBox15");
		((Control)Li0k()).set_Size(new Size(10, 10));
		Li0k().set_SizeMode((PictureBoxSizeMode)4);
		Li0k().set_TabIndex(857);
		Li0k().set_TabStop(false);
		((Control)f0N5()).set_Location(new Point(261, 121));
		((Control)f0N5()).set_Name("PictureBox14");
		((Control)f0N5()).set_Size(new Size(10, 10));
		f0N5().set_SizeMode((PictureBoxSizeMode)4);
		f0N5().set_TabIndex(856);
		f0N5().set_TabStop(false);
		((Control)Ez04()).set_Location(new Point(245, 121));
		((Control)Ez04()).set_Name("PictureBox13");
		((Control)Ez04()).set_Size(new Size(10, 10));
		Ez04().set_SizeMode((PictureBoxSizeMode)4);
		Ez04().set_TabIndex(855);
		Ez04().set_TabStop(false);
		((Control)p8Q6()).set_Location(new Point(227, 121));
		((Control)p8Q6()).set_Name("PictureBox12");
		((Control)p8Q6()).set_Size(new Size(10, 10));
		p8Q6().set_SizeMode((PictureBoxSizeMode)4);
		p8Q6().set_TabIndex(854);
		p8Q6().set_TabStop(false);
		((Control)Ja5k()).set_Location(new Point(208, 121));
		((Control)Ja5k()).set_Name("PictureBox11");
		((Control)Ja5k()).set_Size(new Size(10, 10));
		Ja5k().set_SizeMode((PictureBoxSizeMode)4);
		Ja5k().set_TabIndex(853);
		Ja5k().set_TabStop(false);
		((Control)m9Q7()).set_Location(new Point(190, 121));
		((Control)m9Q7()).set_Name("PictureBox10");
		((Control)m9Q7()).set_Size(new Size(10, 10));
		m9Q7().set_SizeMode((PictureBoxSizeMode)4);
		m9Q7().set_TabIndex(852);
		m9Q7().set_TabStop(false);
		((Control)b5K1()).set_Location(new Point(174, 121));
		((Control)b5K1()).set_Name("PictureBox9");
		((Control)b5K1()).set_Size(new Size(10, 10));
		b5K1().set_SizeMode((PictureBoxSizeMode)4);
		b5K1().set_TabIndex(851);
		b5K1().set_TabStop(false);
		((Control)Ym8i()).set_Location(new Point(158, 121));
		((Control)Ym8i()).set_Name("PictureBox8");
		((Control)Ym8i()).set_Size(new Size(10, 10));
		Ym8i().set_SizeMode((PictureBoxSizeMode)4);
		Ym8i().set_TabIndex(850);
		Ym8i().set_TabStop(false);
		((Control)Cm76()).set_Location(new Point(142, 121));
		((Control)Cm76()).set_Name("PictureBox7");
		((Control)Cm76()).set_Size(new Size(10, 10));
		Cm76().set_SizeMode((PictureBoxSizeMode)4);
		Cm76().set_TabIndex(849);
		Cm76().set_TabStop(false);
		((Control)d9CL()).set_Location(new Point(126, 121));
		((Control)d9CL()).set_Name("PictureBox6");
		((Control)d9CL()).set_Size(new Size(10, 10));
		d9CL().set_SizeMode((PictureBoxSizeMode)4);
		d9CL().set_TabIndex(848);
		d9CL().set_TabStop(false);
		((Control)Si54()).set_Location(new Point(110, 121));
		((Control)Si54()).set_Name("PictureBox5");
		((Control)Si54()).set_Size(new Size(10, 10));
		Si54().set_SizeMode((PictureBoxSizeMode)4);
		Si54().set_TabIndex(847);
		Si54().set_TabStop(false);
		((Control)this.f3H7()).set_Location(new Point(94, 121));
		((Control)this.f3H7()).set_Name("PictureBox4");
		((Control)this.f3H7()).set_Size(new Size(10, 10));
		this.f3H7().set_SizeMode((PictureBoxSizeMode)4);
		this.f3H7().set_TabIndex(846);
		this.f3H7().set_TabStop(false);
		((Control)t7R8()).set_Location(new Point(78, 121));
		((Control)t7R8()).set_Name("PictureBox3");
		((Control)t7R8()).set_Size(new Size(10, 10));
		t7R8().set_SizeMode((PictureBoxSizeMode)4);
		t7R8().set_TabIndex(845);
		t7R8().set_TabStop(false);
		((Control)c8NZ()).set_Location(new Point(62, 121));
		((Control)c8NZ()).set_Name("PictureBox2");
		((Control)c8NZ()).set_Size(new Size(10, 10));
		c8NZ().set_SizeMode((PictureBoxSizeMode)4);
		c8NZ().set_TabIndex(844);
		c8NZ().set_TabStop(false);
		((Control)c0ZQ()).set_Location(new Point(48, 121));
		((Control)c0ZQ()).set_Name("PictureBox1");
		((Control)c0ZQ()).set_Size(new Size(10, 10));
		c0ZQ().set_SizeMode((PictureBoxSizeMode)4);
		c0ZQ().set_TabIndex(843);
		c0ZQ().set_TabStop(false);
		r0YS().set_AutoSize(true);
		((Control)r0YS()).set_Location(new Point(367, 256));
		((Control)r0YS()).set_Name("Label32");
		((Control)r0YS()).set_Size(new Size(19, 13));
		((Control)r0YS()).set_TabIndex(842);
		r0YS().set_Text("20");
		i9P8().set_AutoSize(true);
		((Control)i9P8()).set_Location(new Point(274, 256));
		((Control)i9P8()).set_Name("Label33");
		((Control)i9P8()).set_Size(new Size(19, 13));
		((Control)i9P8()).set_TabIndex(841);
		i9P8().set_Text("15");
		Qp40().set_AutoSize(true);
		((Control)Qp40()).set_Location(new Point(309, 256));
		((Control)Qp40()).set_Name("Label34");
		((Control)Qp40()).set_Size(new Size(19, 13));
		((Control)Qp40()).set_TabIndex(840);
		Qp40().set_Text("17");
		p3N0().set_AutoSize(true);
		((Control)p3N0()).set_Location(new Point(328, 256));
		((Control)p3N0()).set_Name("Label35");
		((Control)p3N0()).set_Size(new Size(19, 13));
		((Control)p3N0()).set_TabIndex(839);
		p3N0().set_Text("18");
		Fb5e().set_AutoSize(true);
		((Control)Fb5e()).set_Location(new Point(347, 256));
		((Control)Fb5e()).set_Name("Label36");
		((Control)Fb5e()).set_Size(new Size(19, 13));
		((Control)Fb5e()).set_TabIndex(838);
		Fb5e().set_Text("19");
		Ho59().set_AutoSize(true);
		((Control)Ho59()).set_Location(new Point(222, 256));
		((Control)Ho59()).set_Name("Label37");
		((Control)Ho59()).set_Size(new Size(19, 13));
		((Control)Ho59()).set_TabIndex(837);
		Ho59().set_Text("12");
		o3GA().set_AutoSize(true);
		((Control)o3GA()).set_Location(new Point(240, 256));
		((Control)o3GA()).set_Name("Label39");
		((Control)o3GA()).set_Size(new Size(19, 13));
		((Control)o3GA()).set_TabIndex(835);
		o3GA().set_Text("13");
		y0LE().set_AutoSize(true);
		((Control)y0LE()).set_Location(new Point(291, 256));
		((Control)y0LE()).set_Name("Label40");
		((Control)y0LE()).set_Size(new Size(19, 13));
		((Control)y0LE()).set_TabIndex(834);
		y0LE().set_Text("16");
		e6Z8().set_AutoSize(true);
		((Control)e6Z8()).set_Location(new Point(205, 256));
		((Control)e6Z8()).set_Name("Label41");
		((Control)e6Z8()).set_Size(new Size(19, 13));
		((Control)e6Z8()).set_TabIndex(833);
		e6Z8().set_Text("11");
		Hc21().set_AutoSize(true);
		((Control)Hc21()).set_Location(new Point(256, 256));
		((Control)Hc21()).set_Name("Label42");
		((Control)Hc21()).set_Size(new Size(19, 13));
		((Control)Hc21()).set_TabIndex(832);
		Hc21().set_Text("14");
		p9F4().set_AutoSize(true);
		((Control)p9F4()).set_Location(new Point(155, 256));
		((Control)p9F4()).set_Name("Label43");
		((Control)p9F4()).set_Size(new Size(13, 13));
		((Control)p9F4()).set_TabIndex(831);
		p9F4().set_Text("8");
		t0E6().set_AutoSize(true);
		((Control)t0E6()).set_Location(new Point(91, 256));
		((Control)t0E6()).set_Name("Label38");
		((Control)t0E6()).set_Size(new Size(13, 13));
		((Control)t0E6()).set_TabIndex(836);
		t0E6().set_Text("4");
		f4KE().set_AutoSize(true);
		((Control)f4KE()).set_Location(new Point(187, 256));
		((Control)f4KE()).set_Name("Label44");
		((Control)f4KE()).set_Size(new Size(19, 13));
		((Control)f4KE()).set_TabIndex(830);
		f4KE().set_Text("10");
		f8QK().set_AutoSize(true);
		((Control)f8QK()).set_Location(new Point(171, 256));
		((Control)f8QK()).set_Name("Label45");
		((Control)f8QK()).set_Size(new Size(13, 13));
		((Control)f8QK()).set_TabIndex(829);
		f8QK().set_Text("9");
		c9E7().set_AutoSize(true);
		((Control)c9E7()).set_Location(new Point(139, 256));
		((Control)c9E7()).set_Name("Label46");
		((Control)c9E7()).set_Size(new Size(13, 13));
		((Control)c9E7()).set_TabIndex(828);
		c9E7().set_Text("7");
		Bm0z().set_AutoSize(true);
		((Control)Bm0z()).set_Location(new Point(123, 256));
		((Control)Bm0z()).set_Name("Label47");
		((Control)Bm0z()).set_Size(new Size(13, 13));
		((Control)Bm0z()).set_TabIndex(827);
		Bm0z().set_Text("6");
		f2CH().set_AutoSize(true);
		((Control)f2CH()).set_Location(new Point(107, 256));
		((Control)f2CH()).set_Name("Label48");
		((Control)f2CH()).set_Size(new Size(13, 13));
		((Control)f2CH()).set_TabIndex(826);
		f2CH().set_Text("5");
		z9R7().set_AutoSize(true);
		((Control)z9R7()).set_Location(new Point(75, 256));
		((Control)z9R7()).set_Name("Label49");
		((Control)z9R7()).set_Size(new Size(13, 13));
		((Control)z9R7()).set_TabIndex(825);
		z9R7().set_Text("3");
		Zn5w().set_AutoSize(true);
		((Control)Zn5w()).set_Location(new Point(59, 256));
		((Control)Zn5w()).set_Name("Label50");
		((Control)Zn5w()).set_Size(new Size(13, 13));
		((Control)Zn5w()).set_TabIndex(824);
		Zn5w().set_Text("2");
		y6GT().set_AutoSize(true);
		((Control)y6GT()).set_Location(new Point(43, 256));
		((Control)y6GT()).set_Name("Label51");
		((Control)y6GT()).set_Size(new Size(13, 13));
		((Control)y6GT()).set_TabIndex(823);
		y6GT().set_Text("1");
		Mi01().set_AutoSize(true);
		((Control)Mi01()).set_Location(new Point(29, 362));
		((Control)Mi01()).set_Name("Label54");
		((Control)Mi01()).set_Size(new Size(15, 13));
		((Control)Mi01()).set_TabIndex(822);
		Mi01().set_Text("H");
		Mr13().set_AutoSize(true);
		((Control)Mr13()).set_Location(new Point(29, 340));
		((Control)Mr13()).set_Name("Label55");
		((Control)Mr13()).set_Size(new Size(15, 13));
		((Control)Mr13()).set_TabIndex(821);
		Mr13().set_Text("G");
		Hw3d().set_AutoSize(true);
		((Control)Hw3d()).set_Location(new Point(29, 318));
		((Control)Hw3d()).set_Name("Label56");
		((Control)Hw3d()).set_Size(new Size(13, 13));
		((Control)Hw3d()).set_TabIndex(820);
		Hw3d().set_Text("F");
		s3GK().set_AutoSize(true);
		((Control)s3GK()).set_Location(new Point(176, 222));
		((Control)s3GK()).set_Name("Label31");
		((Control)s3GK()).set_Size(new Size(72, 13));
		((Control)s3GK()).set_TabIndex(819);
		s3GK().set_Text("LOWER BOX");
		y4F1().set_AutoSize(true);
		((Control)y4F1()).set_Location(new Point(28, 299));
		((Control)y4F1()).set_Name("Label26");
		((Control)y4F1()).set_Size(new Size(14, 13));
		((Control)y4F1()).set_TabIndex(818);
		y4F1().set_Text("E");
		a2F9().set_AutoSize(true);
		((Control)a2F9()).set_Location(new Point(28, 187));
		((Control)a2F9()).set_Name("Label27");
		((Control)a2F9()).set_Size(new Size(15, 13));
		((Control)a2F9()).set_TabIndex(817);
		a2F9().set_Text("D");
		m1LF().set_AutoSize(true);
		((Control)m1LF()).set_Location(new Point(28, 165));
		((Control)m1LF()).set_Name("Label28");
		((Control)m1LF()).set_Size(new Size(14, 13));
		((Control)m1LF()).set_TabIndex(816);
		m1LF().set_Text("C");
		s9FJ().set_AutoSize(true);
		((Control)s9FJ()).set_Location(new Point(28, 143));
		((Control)s9FJ()).set_Name("Label29");
		((Control)s9FJ()).set_Size(new Size(14, 13));
		((Control)s9FJ()).set_TabIndex(815);
		s9FJ().set_Text("B");
		j1J8().set_AutoSize(true);
		((Control)j1J8()).set_Location(new Point(28, 121));
		((Control)j1J8()).set_Name("Label30");
		((Control)j1J8()).set_Size(new Size(14, 13));
		((Control)j1J8()).set_TabIndex(814);
		j1J8().set_Text("A");
		n0CG().set_AutoSize(true);
		((Control)n0CG()).set_Location(new Point(367, 75));
		((Control)n0CG()).set_Name("Label25");
		((Control)n0CG()).set_Size(new Size(19, 13));
		((Control)n0CG()).set_TabIndex(813);
		n0CG().set_Text("20");
		g1CW().set_AutoSize(true);
		((Control)g1CW()).set_Location(new Point(274, 75));
		((Control)g1CW()).set_Name("Label24");
		((Control)g1CW()).set_Size(new Size(19, 13));
		((Control)g1CW()).set_TabIndex(812);
		g1CW().set_Text("15");
		o8T4().set_AutoSize(true);
		((Control)o8T4()).set_Location(new Point(309, 75));
		((Control)o8T4()).set_Name("Label23");
		((Control)o8T4()).set_Size(new Size(19, 13));
		((Control)o8T4()).set_TabIndex(811);
		o8T4().set_Text("17");
		Dg68().set_AutoSize(true);
		((Control)Dg68()).set_Location(new Point(328, 75));
		((Control)Dg68()).set_Name("Label22");
		((Control)Dg68()).set_Size(new Size(19, 13));
		((Control)Dg68()).set_TabIndex(810);
		Dg68().set_Text("18");
		i8DM().set_AutoSize(true);
		((Control)i8DM()).set_Location(new Point(347, 75));
		((Control)i8DM()).set_Name("Label21");
		((Control)i8DM()).set_Size(new Size(19, 13));
		((Control)i8DM()).set_TabIndex(809);
		i8DM().set_Text("19");
		p1W0().set_AutoSize(true);
		((Control)p1W0()).set_Location(new Point(222, 75));
		((Control)p1W0()).set_Name("Label20");
		((Control)p1W0()).set_Size(new Size(19, 13));
		((Control)p1W0()).set_TabIndex(808);
		p1W0().set_Text("12");
		g1RN().set_AutoSize(true);
		((Control)g1RN()).set_Location(new Point(91, 75));
		((Control)g1RN()).set_Name("Label19");
		((Control)g1RN()).set_Size(new Size(13, 13));
		((Control)g1RN()).set_TabIndex(807);
		g1RN().set_Text("4");
		s4Z3().set_AutoSize(true);
		((Control)s4Z3()).set_Location(new Point(240, 75));
		((Control)s4Z3()).set_Name("Label18");
		((Control)s4Z3()).set_Size(new Size(19, 13));
		((Control)s4Z3()).set_TabIndex(806);
		s4Z3().set_Text("13");
		Gj6z().set_AutoSize(true);
		((Control)Gj6z()).set_Location(new Point(291, 75));
		((Control)Gj6z()).set_Name("Label17");
		((Control)Gj6z()).set_Size(new Size(19, 13));
		((Control)Gj6z()).set_TabIndex(805);
		Gj6z().set_Text("16");
		Jw5g().set_AutoSize(true);
		((Control)Jw5g()).set_Location(new Point(205, 75));
		((Control)Jw5g()).set_Name("Label16");
		((Control)Jw5g()).set_Size(new Size(19, 13));
		((Control)Jw5g()).set_TabIndex(804);
		Jw5g().set_Text("11");
		Zq6p().set_AutoSize(true);
		((Control)Zq6p()).set_Location(new Point(256, 75));
		((Control)Zq6p()).set_Name("Label15");
		((Control)Zq6p()).set_Size(new Size(19, 13));
		((Control)Zq6p()).set_TabIndex(803);
		Zq6p().set_Text("14");
		z9K7().set_AutoSize(true);
		((Control)z9K7()).set_Location(new Point(155, 75));
		((Control)z9K7()).set_Name("Label14");
		((Control)z9K7()).set_Size(new Size(13, 13));
		((Control)z9K7()).set_TabIndex(802);
		z9K7().set_Text("8");
		s2FB().set_AutoSize(true);
		((Control)s2FB()).set_Location(new Point(187, 75));
		((Control)s2FB()).set_Name("Label13");
		((Control)s2FB()).set_Size(new Size(19, 13));
		((Control)s2FB()).set_TabIndex(801);
		s2FB().set_Text("10");
		o5AK().set_AutoSize(true);
		((Control)o5AK()).set_Location(new Point(171, 75));
		((Control)o5AK()).set_Name("Label12");
		((Control)o5AK()).set_Size(new Size(13, 13));
		((Control)o5AK()).set_TabIndex(800);
		o5AK().set_Text("9");
		i3YS().set_AutoSize(true);
		((Control)i3YS()).set_Location(new Point(139, 75));
		((Control)i3YS()).set_Name("Label11");
		((Control)i3YS()).set_Size(new Size(13, 13));
		((Control)i3YS()).set_TabIndex(799);
		i3YS().set_Text("7");
		this.f3H7().set_AutoSize(true);
		((Control)this.f3H7()).set_Location(new Point(123, 75));
		((Control)this.f3H7()).set_Name("Label10");
		((Control)this.f3H7()).set_Size(new Size(13, 13));
		((Control)this.f3H7()).set_TabIndex(798);
		this.f3H7().set_Text("6");
		Mz0g().set_AutoSize(true);
		((Control)Mz0g()).set_Location(new Point(107, 75));
		((Control)Mz0g()).set_Name("Label9");
		((Control)Mz0g()).set_Size(new Size(13, 13));
		((Control)Mz0g()).set_TabIndex(797);
		Mz0g().set_Text("5");
		Jd39().set_AutoSize(true);
		((Control)Jd39()).set_Location(new Point(75, 75));
		((Control)Jd39()).set_Name("Label8");
		((Control)Jd39()).set_Size(new Size(13, 13));
		((Control)Jd39()).set_TabIndex(796);
		Jd39().set_Text("3");
		Yq3s().set_AutoSize(true);
		((Control)Yq3s()).set_Location(new Point(59, 75));
		((Control)Yq3s()).set_Name("Label7");
		((Control)Yq3s()).set_Size(new Size(13, 13));
		((Control)Yq3s()).set_TabIndex(795);
		Yq3s().set_Text("2");
		r0SL().set_AutoSize(true);
		((Control)r0SL()).set_Location(new Point(176, 48));
		((Control)r0SL()).set_Name("Label4");
		((Control)r0SL()).set_Size(new Size(69, 13));
		((Control)r0SL()).set_TabIndex(793);
		r0SL().set_Text("UPPER BOX");
		Bk41().set_AutoSize(true);
		((Control)Bk41()).set_Location(new Point(43, 75));
		((Control)Bk41()).set_Name("Label5");
		((Control)Bk41()).set_Size(new Size(13, 13));
		((Control)Bk41()).set_TabIndex(794);
		Bk41().set_Text("1");
		((Control)Ee4z()).get_Controls().Add((Control)(object)Fe1x());
		((Control)Ee4z()).get_Controls().Add((Control)(object)Mz3o());
		((Control)Ee4z()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ee4z()).set_Location(new Point(471, 167));
		((Control)Ee4z()).set_Name("GroupBox3");
		((Control)Ee4z()).set_Size(new Size(200, 251));
		((Control)Ee4z()).set_TabIndex(791);
		Ee4z().set_TabStop(false);
		Ee4z().set_Text("Movie On Display");
		((Control)Mz3o()).set_BackColor(Color.Transparent);
		((Control)Mz3o()).set_Location(new Point(39, 21));
		((Control)Mz3o()).set_Name("Cover");
		((Control)Mz3o()).set_Size(new Size(129, 187));
		Mz3o().set_SizeMode((PictureBoxSizeMode)4);
		Mz3o().set_TabIndex(25);
		Mz3o().set_TabStop(false);
		((Control)Wb3i()).get_Controls().Add((Control)(object)t8E7());
		((Control)Wb3i()).get_Controls().Add((Control)(object)n5QT());
		((Control)Wb3i()).get_Controls().Add((Control)(object)Rx3k());
		((Control)Wb3i()).get_Controls().Add((Control)(object)Dp6d());
		((Control)Wb3i()).get_Controls().Add((Control)(object)Ab62());
		((Control)Wb3i()).get_Controls().Add((Control)(object)Sk38());
		((Control)Wb3i()).get_Controls().Add((Control)(object)w3KW());
		((Control)Wb3i()).get_Controls().Add((Control)(object)Xn37());
		((Control)Wb3i()).get_Controls().Add((Control)(object)Fj31());
		((Control)Wb3i()).set_ForeColor(SystemColors.ControlLight);
		((Control)Wb3i()).set_Location(new Point(454, 48));
		((Control)Wb3i()).set_Name("GroupBox1");
		((Control)Wb3i()).set_Size(new Size(240, 100));
		((Control)Wb3i()).set_TabIndex(789);
		Wb3i().set_TabStop(false);
		Wb3i().set_Text("Statistics");
		((Control)t8E7()).set_Location(new Point(151, 73));
		((Control)t8E7()).set_Name("txtProvisional");
		((Control)t8E7()).set_Size(new Size(83, 20));
		((Control)t8E7()).set_TabIndex(29);
		s6CR().set_AutoSize(true);
		((Control)s6CR()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)s6CR()).set_ForeColor(SystemColors.ControlLight);
		((Control)s6CR()).set_Location(new Point(28, 6));
		((Control)s6CR()).set_Name("Label6");
		((Control)s6CR()).set_Size(new Size(106, 24));
		((Control)s6CR()).set_TabIndex(788);
		s6CR().set_Text("CINEMA 3");
		((Control)To2j()).set_Location(new Point(435, 40));
		((Control)To2j()).set_Name("Background");
		((Control)To2j()).set_Size(new Size(474, 396));
		To2j().set_SizeMode((PictureBoxSizeMode)1);
		To2j().set_TabIndex(787);
		To2j().set_TabStop(false);
		((Control)Ja59()).set_BackColor(Color.Transparent);
		((Control)Ja59()).set_Location(new Point(-2, -3));
		((Control)Ja59()).set_Name("NameBox");
		((Control)Ja59()).set_Size(new Size(914, 45));
		Ja59().set_SizeMode((PictureBoxSizeMode)1);
		Ja59().set_TabIndex(786);
		Ja59().set_TabStop(false);
		((Control)e8MC()).get_Controls().Add((Control)(object)Ti14());
		((Control)e8MC()).get_Controls().Add((Control)(object)Ci3s());
		((Control)e8MC()).get_Controls().Add((Control)(object)m5J8());
		((Control)e8MC()).get_Controls().Add((Control)(object)z8R0());
		((Control)e8MC()).get_Controls().Add((Control)(object)w1Q3());
		((Control)e8MC()).get_Controls().Add((Control)(object)a0C5());
		((Control)e8MC()).get_Controls().Add((Control)(object)Zo61());
		((Control)e8MC()).get_Controls().Add((Control)(object)b3P8());
		((Control)e8MC()).get_Controls().Add((Control)(object)z3G2());
		((Control)e8MC()).get_Controls().Add((Control)(object)Se7r());
		((Control)e8MC()).set_ForeColor(SystemColors.ControlLight);
		((Control)e8MC()).set_Location(new Point(688, 188));
		((Control)e8MC()).set_Name("GroupBox4");
		((Control)e8MC()).set_Size(new Size(211, 231));
		((Control)e8MC()).set_TabIndex(1004);
		e8MC().set_TabStop(false);
		e8MC().set_Text("Billing INFO");
		((ButtonBase)Ti14()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ti14()).set_FlatStyle((FlatStyle)0);
		((Control)Ti14()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ti14()).set_Location(new Point(72, 184));
		((Control)Ti14()).set_Name("btnSave");
		((Control)Ti14()).set_Size(new Size(133, 23));
		((Control)Ti14()).set_TabIndex(40);
		((ButtonBase)Ti14()).set_Text("Save / Receipt Preview");
		((ButtonBase)Ti14()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Ci3s()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ci3s()).set_FlatStyle((FlatStyle)0);
		((Control)Ci3s()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ci3s()).set_Location(new Point(103, 155));
		((Control)Ci3s()).set_Name("btnCalculateChange");
		((Control)Ci3s()).set_Size(new Size(101, 23));
		((Control)Ci3s()).set_TabIndex(39);
		((ButtonBase)Ci3s()).set_Text("Calculate Change");
		((ButtonBase)Ci3s()).set_UseVisualStyleBackColor(true);
		((Control)m5J8()).set_Location(new Point(95, 123));
		((Control)m5J8()).set_Name("txtChange");
		((Control)m5J8()).set_Size(new Size(110, 20));
		((Control)m5J8()).set_TabIndex(34);
		((Control)z8R0()).set_Location(new Point(95, 91));
		((Control)z8R0()).set_Name("txtTotalPayment");
		((Control)z8R0()).set_Size(new Size(110, 20));
		((Control)z8R0()).set_TabIndex(33);
		((Control)w1Q3()).set_Location(new Point(96, 58));
		((Control)w1Q3()).set_Name("txtTotalCost");
		((Control)w1Q3()).set_Size(new Size(109, 20));
		((Control)w1Q3()).set_TabIndex(32);
		((Control)a0C5()).set_Location(new Point(122, 24));
		((Control)a0C5()).set_Name("txtSeats");
		((Control)a0C5()).set_Size(new Size(83, 20));
		((Control)a0C5()).set_TabIndex(31);
		Zo61().set_AutoSize(true);
		((Control)Zo61()).set_BackColor(Color.Transparent);
		((Control)Zo61()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Zo61()).set_Location(new Point(8, 62));
		((Control)Zo61()).set_Name("Label63");
		((Control)Zo61()).set_Size(new Size(66, 13));
		((Control)Zo61()).set_TabIndex(16);
		Zo61().set_Text("Total Costs :");
		b3P8().set_AutoSize(true);
		((Control)b3P8()).set_BackColor(Color.Transparent);
		((Control)b3P8()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)b3P8()).set_Location(new Point(8, 27));
		((Control)b3P8()).set_Name("Label64");
		((Control)b3P8()).set_Size(new Size(106, 13));
		((Control)b3P8()).set_TabIndex(15);
		b3P8().set_Text("Seats to be booked :");
		z3G2().set_AutoSize(true);
		((Control)z3G2()).set_BackColor(Color.Transparent);
		((Control)z3G2()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)z3G2()).set_Location(new Point(8, 121));
		((Control)z3G2()).set_Name("Label61");
		((Control)z3G2()).set_Size(new Size(50, 13));
		((Control)z3G2()).set_TabIndex(14);
		z3G2().set_Text("Change :");
		Se7r().set_AutoSize(true);
		((Control)Se7r()).set_BackColor(Color.Transparent);
		((Control)Se7r()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Se7r()).set_Location(new Point(8, 91));
		((Control)Se7r()).set_Name("Label62");
		((Control)Se7r()).set_Size(new Size(81, 13));
		((Control)Se7r()).set_TabIndex(13);
		Se7r().set_Text("Total Payment :");
		((Control)Ky40()).get_Controls().Add((Control)(object)m5K0());
		((Control)Ky40()).get_Controls().Add((Control)(object)Mt58());
		((Control)Ky40()).get_Controls().Add((Control)(object)Qn2i());
		((Control)Ky40()).get_Controls().Add((Control)(object)s0MY());
		((Control)Ky40()).get_Controls().Add((Control)(object)Cg3a());
		((Control)Ky40()).get_Controls().Add((Control)(object)x2TQ());
		((Control)Ky40()).get_Controls().Add((Control)(object)c9K7());
		((Control)Ky40()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ky40()).set_Location(new Point(699, 49));
		((Control)Ky40()).set_Name("GroupBox2");
		((Control)Ky40()).set_Size(new Size(200, 129));
		((Control)Ky40()).set_TabIndex(1003);
		Ky40().set_TabStop(false);
		Ky40().set_Text("Customer");
		((ButtonBase)m5K0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)m5K0()).set_FlatStyle((FlatStyle)0);
		((Control)m5K0()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)m5K0()).set_Location(new Point(70, 90));
		((Control)m5K0()).set_Name("btnNew");
		((Control)m5K0()).set_Size(new Size(54, 23));
		((Control)m5K0()).set_TabIndex(39);
		((ButtonBase)m5K0()).set_Text("New");
		((ButtonBase)m5K0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Mt58()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Mt58()).set_FlatStyle((FlatStyle)0);
		((Control)Mt58()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Mt58()).set_Location(new Point(130, 90));
		((Control)Mt58()).set_Name("btnReset");
		((Control)Mt58()).set_Size(new Size(54, 23));
		((Control)Mt58()).set_TabIndex(38);
		((ButtonBase)Mt58()).set_Text("Reset");
		((ButtonBase)Mt58()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Qn2i()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Qn2i()).set_FlatStyle((FlatStyle)0);
		((Control)Qn2i()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Qn2i()).set_Location(new Point(10, 90));
		((Control)Qn2i()).set_Name("btnExisting");
		((Control)Qn2i()).set_Size(new Size(54, 23));
		((Control)Qn2i()).set_TabIndex(37);
		((ButtonBase)Qn2i()).set_Text("Existing");
		((ButtonBase)Qn2i()).set_UseVisualStyleBackColor(true);
		((Control)s0MY()).set_Location(new Point(94, 57));
		((Control)s0MY()).set_Name("txtFirstName");
		((Control)s0MY()).set_Size(new Size(103, 20));
		((Control)s0MY()).set_TabIndex(30);
		((Control)Cg3a()).set_Location(new Point(94, 31));
		((Control)Cg3a()).set_Name("txtID");
		((Control)Cg3a()).set_Size(new Size(103, 20));
		((Control)Cg3a()).set_TabIndex(29);
		x2TQ().set_AutoSize(true);
		((Control)x2TQ()).set_BackColor(Color.Transparent);
		((Control)x2TQ()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)x2TQ()).set_Location(new Point(6, 58));
		((Control)x2TQ()).set_Name("Label60");
		((Control)x2TQ()).set_Size(new Size(57, 13));
		((Control)x2TQ()).set_TabIndex(12);
		x2TQ().set_Text("First Name");
		c9K7().set_AutoSize(true);
		((Control)c9K7()).set_BackColor(Color.Transparent);
		((Control)c9K7()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)c9K7()).set_Location(new Point(6, 34));
		((Control)c9K7()).set_Name("Label59");
		((Control)c9K7()).set_Size(new Size(65, 13));
		((Control)c9K7()).set_TabIndex(11);
		c9K7().set_Text("Customer ID");
		((ButtonBase)Fe1x()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Fe1x()).set_FlatStyle((FlatStyle)0);
		((Control)Fe1x()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Fe1x()).set_Location(new Point(42, 214));
		((Control)Fe1x()).set_Name("btnViewReservations");
		((Control)Fe1x()).set_Size(new Size(117, 23));
		((Control)Fe1x()).set_TabIndex(42);
		((ButtonBase)Fe1x()).set_Text("View Reservations");
		((ButtonBase)Fe1x()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)e8MC());
		((Control)this).get_Controls().Add((Control)(object)Ky40());
		((Control)this).get_Controls().Add((Control)(object)i0D());
		((Control)this).get_Controls().Add((Control)(object)y1L());
		((Control)this).get_Controls().Add((Control)(object)b5G());
		((Control)this).get_Controls().Add((Control)(object)c6B());
		((Control)this).get_Controls().Add((Control)(object)x9G());
		((Control)this).get_Controls().Add((Control)(object)Me1());
		((Control)this).get_Controls().Add((Control)(object)Pr8());
		((Control)this).get_Controls().Add((Control)(object)e5Q());
		((Control)this).get_Controls().Add((Control)(object)m3A());
		((Control)this).get_Controls().Add((Control)(object)Pe7());
		((Control)this).get_Controls().Add((Control)(object)e2T());
		((Control)this).get_Controls().Add((Control)(object)j9X());
		((Control)this).get_Controls().Add((Control)(object)t5C());
		((Control)this).get_Controls().Add((Control)(object)Da1());
		((Control)this).get_Controls().Add((Control)(object)Gy7());
		((Control)this).get_Controls().Add((Control)(object)g4T());
		((Control)this).get_Controls().Add((Control)(object)j3Q());
		((Control)this).get_Controls().Add((Control)(object)b4F());
		((Control)this).get_Controls().Add((Control)(object)b8J());
		((Control)this).get_Controls().Add((Control)(object)Dg9());
		((Control)this).get_Controls().Add((Control)(object)Tc1());
		((Control)this).get_Controls().Add((Control)(object)Qb9());
		((Control)this).get_Controls().Add((Control)(object)Aw4());
		((Control)this).get_Controls().Add((Control)(object)t0Y());
		((Control)this).get_Controls().Add((Control)(object)Pq5());
		((Control)this).get_Controls().Add((Control)(object)Gp2());
		((Control)this).get_Controls().Add((Control)(object)z8D());
		((Control)this).get_Controls().Add((Control)(object)Fa1());
		((Control)this).get_Controls().Add((Control)(object)Zn3());
		((Control)this).get_Controls().Add((Control)(object)Pf4());
		((Control)this).get_Controls().Add((Control)(object)Jq1());
		((Control)this).get_Controls().Add((Control)(object)Ea7());
		((Control)this).get_Controls().Add((Control)(object)o1J());
		((Control)this).get_Controls().Add((Control)(object)Pc2());
		((Control)this).get_Controls().Add((Control)(object)Tq3());
		((Control)this).get_Controls().Add((Control)(object)Wo3());
		((Control)this).get_Controls().Add((Control)(object)p1P());
		((Control)this).get_Controls().Add((Control)(object)Zy7());
		((Control)this).get_Controls().Add((Control)(object)Hk9());
		((Control)this).get_Controls().Add((Control)(object)Zf2());
		((Control)this).get_Controls().Add((Control)(object)Qf5());
		((Control)this).get_Controls().Add((Control)(object)Bm9());
		((Control)this).get_Controls().Add((Control)(object)n6N());
		((Control)this).get_Controls().Add((Control)(object)Po3());
		((Control)this).get_Controls().Add((Control)(object)z0F());
		((Control)this).get_Controls().Add((Control)(object)n9Q());
		((Control)this).get_Controls().Add((Control)(object)k3S());
		((Control)this).get_Controls().Add((Control)(object)Gg0());
		((Control)this).get_Controls().Add((Control)(object)Fm5());
		((Control)this).get_Controls().Add((Control)(object)Ns7());
		((Control)this).get_Controls().Add((Control)(object)f0E());
		((Control)this).get_Controls().Add((Control)(object)Jx7());
		((Control)this).get_Controls().Add((Control)(object)s1J());
		((Control)this).get_Controls().Add((Control)(object)Hz9());
		((Control)this).get_Controls().Add((Control)(object)x4A());
		((Control)this).get_Controls().Add((Control)(object)j7T());
		((Control)this).get_Controls().Add((Control)(object)Ld9());
		((Control)this).get_Controls().Add((Control)(object)Lt9());
		((Control)this).get_Controls().Add((Control)(object)w9L());
		((Control)this).get_Controls().Add((Control)(object)z2N());
		((Control)this).get_Controls().Add((Control)(object)b9G());
		((Control)this).get_Controls().Add((Control)(object)Fw6());
		((Control)this).get_Controls().Add((Control)(object)St4());
		((Control)this).get_Controls().Add((Control)(object)e3H());
		((Control)this).get_Controls().Add((Control)(object)Ae2());
		((Control)this).get_Controls().Add((Control)(object)i8P());
		((Control)this).get_Controls().Add((Control)(object)Xe8());
		((Control)this).get_Controls().Add((Control)(object)w0S());
		((Control)this).get_Controls().Add((Control)(object)Qy6());
		((Control)this).get_Controls().Add((Control)(object)t8W());
		((Control)this).get_Controls().Add((Control)(object)g9P());
		((Control)this).get_Controls().Add((Control)(object)Wb7());
		((Control)this).get_Controls().Add((Control)(object)Ha0());
		((Control)this).get_Controls().Add((Control)(object)b5S());
		((Control)this).get_Controls().Add((Control)(object)y8B());
		((Control)this).get_Controls().Add((Control)(object)Kz8());
		((Control)this).get_Controls().Add((Control)(object)Kq7());
		((Control)this).get_Controls().Add((Control)(object)Km9());
		((Control)this).get_Controls().Add((Control)(object)Dg8());
		((Control)this).get_Controls().Add((Control)(object)Co8());
		((Control)this).get_Controls().Add((Control)(object)q4N());
		((Control)this).get_Controls().Add((Control)(object)Pb4());
		((Control)this).get_Controls().Add((Control)(object)Kn8());
		((Control)this).get_Controls().Add((Control)(object)Fc0());
		((Control)this).get_Controls().Add((Control)(object)At9());
		((Control)this).get_Controls().Add((Control)(object)g0G());
		((Control)this).get_Controls().Add((Control)(object)k3W2());
		((Control)this).get_Controls().Add((Control)(object)i5C1());
		((Control)this).get_Controls().Add((Control)(object)Ye6b());
		((Control)this).get_Controls().Add((Control)(object)Tk06());
		((Control)this).get_Controls().Add((Control)(object)Ks8r());
		((Control)this).get_Controls().Add((Control)(object)Ws96());
		((Control)this).get_Controls().Add((Control)(object)z9T1());
		((Control)this).get_Controls().Add((Control)(object)Gz21());
		((Control)this).get_Controls().Add((Control)(object)So09());
		((Control)this).get_Controls().Add((Control)(object)Et85());
		((Control)this).get_Controls().Add((Control)(object)Dy47());
		((Control)this).get_Controls().Add((Control)(object)z9R2());
		((Control)this).get_Controls().Add((Control)(object)Ds70());
		((Control)this).get_Controls().Add((Control)(object)a2BA());
		((Control)this).get_Controls().Add((Control)(object)a6B3());
		((Control)this).get_Controls().Add((Control)(object)a4QS());
		((Control)this).get_Controls().Add((Control)(object)Kf6n());
		((Control)this).get_Controls().Add((Control)(object)Sf0j());
		((Control)this).get_Controls().Add((Control)(object)Xy4z());
		((Control)this).get_Controls().Add((Control)(object)a2B3());
		((Control)this).get_Controls().Add((Control)(object)Dg96());
		((Control)this).get_Controls().Add((Control)(object)g7RE());
		((Control)this).get_Controls().Add((Control)(object)Tp7z());
		((Control)this).get_Controls().Add((Control)(object)d1L5());
		((Control)this).get_Controls().Add((Control)(object)Bq97());
		((Control)this).get_Controls().Add((Control)(object)Ge19());
		((Control)this).get_Controls().Add((Control)(object)y8QL());
		((Control)this).get_Controls().Add((Control)(object)p0MA());
		((Control)this).get_Controls().Add((Control)(object)Fp7o());
		((Control)this).get_Controls().Add((Control)(object)b6H2());
		((Control)this).get_Controls().Add((Control)(object)r6QH());
		((Control)this).get_Controls().Add((Control)(object)b9M5());
		((Control)this).get_Controls().Add((Control)(object)s6X0());
		((Control)this).get_Controls().Add((Control)(object)Sq2d());
		((Control)this).get_Controls().Add((Control)(object)e4PT());
		((Control)this).get_Controls().Add((Control)(object)Jr6q());
		((Control)this).get_Controls().Add((Control)(object)g2X5());
		((Control)this).get_Controls().Add((Control)(object)Bx8z());
		((Control)this).get_Controls().Add((Control)(object)g6L7());
		((Control)this).get_Controls().Add((Control)(object)f3ZF());
		((Control)this).get_Controls().Add((Control)(object)n8J2());
		((Control)this).get_Controls().Add((Control)(object)q0B4());
		((Control)this).get_Controls().Add((Control)(object)Go3n());
		((Control)this).get_Controls().Add((Control)(object)n7GH());
		((Control)this).get_Controls().Add((Control)(object)k5CG());
		((Control)this).get_Controls().Add((Control)(object)s1E0());
		((Control)this).get_Controls().Add((Control)(object)Lf3c());
		((Control)this).get_Controls().Add((Control)(object)Cr56());
		((Control)this).get_Controls().Add((Control)(object)k6ZT());
		((Control)this).get_Controls().Add((Control)(object)Dr79());
		((Control)this).get_Controls().Add((Control)(object)d4A1());
		((Control)this).get_Controls().Add((Control)(object)k0GY());
		((Control)this).get_Controls().Add((Control)(object)a8L0());
		((Control)this).get_Controls().Add((Control)(object)Ea5b());
		((Control)this).get_Controls().Add((Control)(object)Rr59());
		((Control)this).get_Controls().Add((Control)(object)Lt83());
		((Control)this).get_Controls().Add((Control)(object)Mi50());
		((Control)this).get_Controls().Add((Control)(object)Yy4t());
		((Control)this).get_Controls().Add((Control)(object)Fd79());
		((Control)this).get_Controls().Add((Control)(object)Li0k());
		((Control)this).get_Controls().Add((Control)(object)f0N5());
		((Control)this).get_Controls().Add((Control)(object)Ez04());
		((Control)this).get_Controls().Add((Control)(object)p8Q6());
		((Control)this).get_Controls().Add((Control)(object)Ja5k());
		((Control)this).get_Controls().Add((Control)(object)m9Q7());
		((Control)this).get_Controls().Add((Control)(object)b5K1());
		((Control)this).get_Controls().Add((Control)(object)Ym8i());
		((Control)this).get_Controls().Add((Control)(object)Cm76());
		((Control)this).get_Controls().Add((Control)(object)d9CL());
		((Control)this).get_Controls().Add((Control)(object)Si54());
		((Control)this).get_Controls().Add((Control)(object)this.f3H7());
		((Control)this).get_Controls().Add((Control)(object)t7R8());
		((Control)this).get_Controls().Add((Control)(object)c8NZ());
		((Control)this).get_Controls().Add((Control)(object)c0ZQ());
		((Control)this).get_Controls().Add((Control)(object)r0YS());
		((Control)this).get_Controls().Add((Control)(object)i9P8());
		((Control)this).get_Controls().Add((Control)(object)Qp40());
		((Control)this).get_Controls().Add((Control)(object)p3N0());
		((Control)this).get_Controls().Add((Control)(object)Fb5e());
		((Control)this).get_Controls().Add((Control)(object)Ho59());
		((Control)this).get_Controls().Add((Control)(object)o3GA());
		((Control)this).get_Controls().Add((Control)(object)y0LE());
		((Control)this).get_Controls().Add((Control)(object)e6Z8());
		((Control)this).get_Controls().Add((Control)(object)Hc21());
		((Control)this).get_Controls().Add((Control)(object)p9F4());
		((Control)this).get_Controls().Add((Control)(object)t0E6());
		((Control)this).get_Controls().Add((Control)(object)f4KE());
		((Control)this).get_Controls().Add((Control)(object)f8QK());
		((Control)this).get_Controls().Add((Control)(object)c9E7());
		((Control)this).get_Controls().Add((Control)(object)Bm0z());
		((Control)this).get_Controls().Add((Control)(object)f2CH());
		((Control)this).get_Controls().Add((Control)(object)z9R7());
		((Control)this).get_Controls().Add((Control)(object)Zn5w());
		((Control)this).get_Controls().Add((Control)(object)y6GT());
		((Control)this).get_Controls().Add((Control)(object)Mi01());
		((Control)this).get_Controls().Add((Control)(object)Mr13());
		((Control)this).get_Controls().Add((Control)(object)Hw3d());
		((Control)this).get_Controls().Add((Control)(object)s3GK());
		((Control)this).get_Controls().Add((Control)(object)y4F1());
		((Control)this).get_Controls().Add((Control)(object)a2F9());
		((Control)this).get_Controls().Add((Control)(object)m1LF());
		((Control)this).get_Controls().Add((Control)(object)s9FJ());
		((Control)this).get_Controls().Add((Control)(object)j1J8());
		((Control)this).get_Controls().Add((Control)(object)n0CG());
		((Control)this).get_Controls().Add((Control)(object)g1CW());
		((Control)this).get_Controls().Add((Control)(object)o8T4());
		((Control)this).get_Controls().Add((Control)(object)Dg68());
		((Control)this).get_Controls().Add((Control)(object)i8DM());
		((Control)this).get_Controls().Add((Control)(object)p1W0());
		((Control)this).get_Controls().Add((Control)(object)g1RN());
		((Control)this).get_Controls().Add((Control)(object)s4Z3());
		((Control)this).get_Controls().Add((Control)(object)Gj6z());
		((Control)this).get_Controls().Add((Control)(object)Jw5g());
		((Control)this).get_Controls().Add((Control)(object)Zq6p());
		((Control)this).get_Controls().Add((Control)(object)z9K7());
		((Control)this).get_Controls().Add((Control)(object)s2FB());
		((Control)this).get_Controls().Add((Control)(object)o5AK());
		((Control)this).get_Controls().Add((Control)(object)i3YS());
		((Control)this).get_Controls().Add((Control)(object)this.f3H7());
		((Control)this).get_Controls().Add((Control)(object)Mz0g());
		((Control)this).get_Controls().Add((Control)(object)Jd39());
		((Control)this).get_Controls().Add((Control)(object)Yq3s());
		((Control)this).get_Controls().Add((Control)(object)r0SL());
		((Control)this).get_Controls().Add((Control)(object)Bk41());
		((Control)this).get_Controls().Add((Control)(object)Ee4z());
		((Control)this).get_Controls().Add((Control)(object)Wb3i());
		((Control)this).get_Controls().Add((Control)(object)s6CR());
		((Control)this).get_Controls().Add((Control)(object)To2j());
		((Control)this).get_Controls().Add((Control)(object)Ja59());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 3");
		((ISupportInitialize)i0D()).EndInit();
		((ISupportInitialize)y1L()).EndInit();
		((ISupportInitialize)b5G()).EndInit();
		((ISupportInitialize)c6B()).EndInit();
		((ISupportInitialize)x9G()).EndInit();
		((ISupportInitialize)Me1()).EndInit();
		((ISupportInitialize)Pr8()).EndInit();
		((ISupportInitialize)e5Q()).EndInit();
		((ISupportInitialize)m3A()).EndInit();
		((ISupportInitialize)Pe7()).EndInit();
		((ISupportInitialize)e2T()).EndInit();
		((ISupportInitialize)j9X()).EndInit();
		((ISupportInitialize)t5C()).EndInit();
		((ISupportInitialize)Da1()).EndInit();
		((ISupportInitialize)Gy7()).EndInit();
		((ISupportInitialize)g4T()).EndInit();
		((ISupportInitialize)j3Q()).EndInit();
		((ISupportInitialize)b4F()).EndInit();
		((ISupportInitialize)b8J()).EndInit();
		((ISupportInitialize)Dg9()).EndInit();
		((ISupportInitialize)Tc1()).EndInit();
		((ISupportInitialize)Qb9()).EndInit();
		((ISupportInitialize)Aw4()).EndInit();
		((ISupportInitialize)t0Y()).EndInit();
		((ISupportInitialize)Pq5()).EndInit();
		((ISupportInitialize)Gp2()).EndInit();
		((ISupportInitialize)z8D()).EndInit();
		((ISupportInitialize)Fa1()).EndInit();
		((ISupportInitialize)Zn3()).EndInit();
		((ISupportInitialize)Pf4()).EndInit();
		((ISupportInitialize)Jq1()).EndInit();
		((ISupportInitialize)Ea7()).EndInit();
		((ISupportInitialize)o1J()).EndInit();
		((ISupportInitialize)Pc2()).EndInit();
		((ISupportInitialize)Tq3()).EndInit();
		((ISupportInitialize)Wo3()).EndInit();
		((ISupportInitialize)p1P()).EndInit();
		((ISupportInitialize)Zy7()).EndInit();
		((ISupportInitialize)Hk9()).EndInit();
		((ISupportInitialize)Zf2()).EndInit();
		((ISupportInitialize)Qf5()).EndInit();
		((ISupportInitialize)Bm9()).EndInit();
		((ISupportInitialize)n6N()).EndInit();
		((ISupportInitialize)Po3()).EndInit();
		((ISupportInitialize)z0F()).EndInit();
		((ISupportInitialize)n9Q()).EndInit();
		((ISupportInitialize)k3S()).EndInit();
		((ISupportInitialize)Gg0()).EndInit();
		((ISupportInitialize)Fm5()).EndInit();
		((ISupportInitialize)Ns7()).EndInit();
		((ISupportInitialize)f0E()).EndInit();
		((ISupportInitialize)Jx7()).EndInit();
		((ISupportInitialize)s1J()).EndInit();
		((ISupportInitialize)Hz9()).EndInit();
		((ISupportInitialize)x4A()).EndInit();
		((ISupportInitialize)j7T()).EndInit();
		((ISupportInitialize)Ld9()).EndInit();
		((ISupportInitialize)Lt9()).EndInit();
		((ISupportInitialize)w9L()).EndInit();
		((ISupportInitialize)z2N()).EndInit();
		((ISupportInitialize)b9G()).EndInit();
		((ISupportInitialize)Fw6()).EndInit();
		((ISupportInitialize)St4()).EndInit();
		((ISupportInitialize)e3H()).EndInit();
		((ISupportInitialize)Ae2()).EndInit();
		((ISupportInitialize)i8P()).EndInit();
		((ISupportInitialize)Xe8()).EndInit();
		((ISupportInitialize)w0S()).EndInit();
		((ISupportInitialize)Qy6()).EndInit();
		((ISupportInitialize)t8W()).EndInit();
		((ISupportInitialize)g9P()).EndInit();
		((ISupportInitialize)Wb7()).EndInit();
		((ISupportInitialize)Ha0()).EndInit();
		((ISupportInitialize)b5S()).EndInit();
		((ISupportInitialize)y8B()).EndInit();
		((ISupportInitialize)Kz8()).EndInit();
		((ISupportInitialize)Kq7()).EndInit();
		((ISupportInitialize)Km9()).EndInit();
		((ISupportInitialize)Dg8()).EndInit();
		((ISupportInitialize)Co8()).EndInit();
		((ISupportInitialize)q4N()).EndInit();
		((ISupportInitialize)Pb4()).EndInit();
		((ISupportInitialize)Kn8()).EndInit();
		((ISupportInitialize)Fc0()).EndInit();
		((ISupportInitialize)At9()).EndInit();
		((ISupportInitialize)g0G()).EndInit();
		((ISupportInitialize)k3W2()).EndInit();
		((ISupportInitialize)i5C1()).EndInit();
		((ISupportInitialize)Ye6b()).EndInit();
		((ISupportInitialize)Tk06()).EndInit();
		((ISupportInitialize)Ks8r()).EndInit();
		((ISupportInitialize)Ws96()).EndInit();
		((ISupportInitialize)z9T1()).EndInit();
		((ISupportInitialize)Gz21()).EndInit();
		((ISupportInitialize)So09()).EndInit();
		((ISupportInitialize)Et85()).EndInit();
		((ISupportInitialize)Dy47()).EndInit();
		((ISupportInitialize)z9R2()).EndInit();
		((ISupportInitialize)Ds70()).EndInit();
		((ISupportInitialize)a2BA()).EndInit();
		((ISupportInitialize)a6B3()).EndInit();
		((ISupportInitialize)a4QS()).EndInit();
		((ISupportInitialize)Kf6n()).EndInit();
		((ISupportInitialize)Sf0j()).EndInit();
		((ISupportInitialize)Xy4z()).EndInit();
		((ISupportInitialize)a2B3()).EndInit();
		((ISupportInitialize)Dg96()).EndInit();
		((ISupportInitialize)g7RE()).EndInit();
		((ISupportInitialize)Tp7z()).EndInit();
		((ISupportInitialize)d1L5()).EndInit();
		((ISupportInitialize)Bq97()).EndInit();
		((ISupportInitialize)Ge19()).EndInit();
		((ISupportInitialize)y8QL()).EndInit();
		((ISupportInitialize)p0MA()).EndInit();
		((ISupportInitialize)Fp7o()).EndInit();
		((ISupportInitialize)b6H2()).EndInit();
		((ISupportInitialize)r6QH()).EndInit();
		((ISupportInitialize)b9M5()).EndInit();
		((ISupportInitialize)s6X0()).EndInit();
		((ISupportInitialize)Sq2d()).EndInit();
		((ISupportInitialize)e4PT()).EndInit();
		((ISupportInitialize)Jr6q()).EndInit();
		((ISupportInitialize)g2X5()).EndInit();
		((ISupportInitialize)Bx8z()).EndInit();
		((ISupportInitialize)g6L7()).EndInit();
		((ISupportInitialize)f3ZF()).EndInit();
		((ISupportInitialize)n8J2()).EndInit();
		((ISupportInitialize)q0B4()).EndInit();
		((ISupportInitialize)Go3n()).EndInit();
		((ISupportInitialize)n7GH()).EndInit();
		((ISupportInitialize)k5CG()).EndInit();
		((ISupportInitialize)s1E0()).EndInit();
		((ISupportInitialize)Lf3c()).EndInit();
		((ISupportInitialize)Cr56()).EndInit();
		((ISupportInitialize)k6ZT()).EndInit();
		((ISupportInitialize)Dr79()).EndInit();
		((ISupportInitialize)d4A1()).EndInit();
		((ISupportInitialize)k0GY()).EndInit();
		((ISupportInitialize)Dp6d()).EndInit();
		((ISupportInitialize)Ab62()).EndInit();
		((ISupportInitialize)Sk38()).EndInit();
		((ISupportInitialize)a8L0()).EndInit();
		((ISupportInitialize)Ea5b()).EndInit();
		((ISupportInitialize)Rr59()).EndInit();
		((ISupportInitialize)Lt83()).EndInit();
		((ISupportInitialize)Mi50()).EndInit();
		((ISupportInitialize)Yy4t()).EndInit();
		((ISupportInitialize)Fd79()).EndInit();
		((ISupportInitialize)Li0k()).EndInit();
		((ISupportInitialize)f0N5()).EndInit();
		((ISupportInitialize)Ez04()).EndInit();
		((ISupportInitialize)p8Q6()).EndInit();
		((ISupportInitialize)Ja5k()).EndInit();
		((ISupportInitialize)m9Q7()).EndInit();
		((ISupportInitialize)b5K1()).EndInit();
		((ISupportInitialize)Ym8i()).EndInit();
		((ISupportInitialize)Cm76()).EndInit();
		((ISupportInitialize)d9CL()).EndInit();
		((ISupportInitialize)Si54()).EndInit();
		((ISupportInitialize)this.f3H7()).EndInit();
		((ISupportInitialize)t7R8()).EndInit();
		((ISupportInitialize)c8NZ()).EndInit();
		((ISupportInitialize)c0ZQ()).EndInit();
		((Control)Ee4z()).ResumeLayout(false);
		((ISupportInitialize)Mz3o()).EndInit();
		((Control)Wb3i()).ResumeLayout(false);
		((Control)Wb3i()).PerformLayout();
		((ISupportInitialize)To2j()).EndInit();
		((ISupportInitialize)Ja59()).EndInit();
		((Control)e8MC()).ResumeLayout(false);
		((Control)e8MC()).PerformLayout();
		((Control)Ky40()).ResumeLayout(false);
		((Control)Ky40()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox i0D()
	{
		return _PictureBox141;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9M(PictureBox c7H)
	{
		_PictureBox141 = c7H;
	}

	[SpecialName]
	internal virtual PictureBox y1L()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9Q(PictureBox t6S)
	{
		PictureBox val = (Q = t6S);
	}

	[SpecialName]
	internal virtual PictureBox b5G()
	{
		return _PictureBox143;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ze4(PictureBox Cw4)
	{
		_PictureBox143 = Cw4;
	}

	[SpecialName]
	internal virtual PictureBox c6B()
	{
		return _PictureBox144;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8S(PictureBox f5C)
	{
		_PictureBox144 = f5C;
	}

	[SpecialName]
	internal virtual PictureBox x9G()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk6(PictureBox Ft0)
	{
		PictureBox val = (j = Ft0);
	}

	[SpecialName]
	internal virtual PictureBox Me1()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3X(PictureBox Po1)
	{
		PictureBox val = (Y = Po1);
	}

	[SpecialName]
	internal virtual PictureBox Pr8()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eo8(PictureBox Ta8)
	{
		_PictureBox147 = Ta8;
	}

	[SpecialName]
	internal virtual PictureBox e5Q()
	{
		return _PictureBox148;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4M(PictureBox b1K)
	{
		_PictureBox148 = b1K;
	}

	[SpecialName]
	internal virtual PictureBox m3A()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0N(PictureBox n9T)
	{
		PictureBox val = (H = n9T);
	}

	[SpecialName]
	internal virtual PictureBox Pe7()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt8(PictureBox x1K)
	{
		PictureBox val = (V = x1K);
	}

	[SpecialName]
	internal virtual PictureBox e2T()
	{
		return _PictureBox151;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ty4(PictureBox Ez5)
	{
		_PictureBox151 = Ez5;
	}

	[SpecialName]
	internal virtual PictureBox j9X()
	{
		return _PictureBox152;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6N(PictureBox Hk1)
	{
		_PictureBox152 = Hk1;
	}

	[SpecialName]
	internal virtual PictureBox t5C()
	{
		return _PictureBox153;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg6(PictureBox c7A)
	{
		_PictureBox153 = c7A;
	}

	[SpecialName]
	internal virtual PictureBox Da1()
	{
		return _PictureBox154;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hf0(PictureBox o7L)
	{
		_PictureBox154 = o7L;
	}

	[SpecialName]
	internal virtual PictureBox Gy7()
	{
		return _PictureBox155;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2A(PictureBox Bg6)
	{
		_PictureBox155 = Bg6;
	}

	[SpecialName]
	internal virtual PictureBox g4T()
	{
		return _PictureBox156;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj4(PictureBox Qm7)
	{
		_PictureBox156 = Qm7;
	}

	[SpecialName]
	internal virtual PictureBox j3Q()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gd9(PictureBox Yb0)
	{
		PictureBox val = (i = Yb0);
	}

	[SpecialName]
	internal virtual PictureBox b4F()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4S(PictureBox t3C)
	{
		PictureBox val = (b = t3C);
	}

	[SpecialName]
	internal virtual PictureBox b8J()
	{
		return _PictureBox159;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9Z(PictureBox e6W)
	{
		_PictureBox159 = e6W;
	}

	[SpecialName]
	internal virtual PictureBox Dg9()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt1(PictureBox o8S)
	{
		PictureBox val = (k = o8S);
	}

	[SpecialName]
	internal virtual PictureBox Tc1()
	{
		return _PictureBox121;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ka7(PictureBox o9X)
	{
		_PictureBox121 = o9X;
	}

	[SpecialName]
	internal virtual PictureBox Qb9()
	{
		return _PictureBox122;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn5(PictureBox Tf7)
	{
		_PictureBox122 = Tf7;
	}

	[SpecialName]
	internal virtual PictureBox Aw4()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8S(PictureBox At5)
	{
		PictureBox val = (r = At5);
	}

	[SpecialName]
	internal virtual PictureBox t0Y()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts5(PictureBox z0W)
	{
		PictureBox val = (n = z0W);
	}

	[SpecialName]
	internal virtual PictureBox Pq5()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wt0(PictureBox Gw2)
	{
		PictureBox val = (t = Gw2);
	}

	[SpecialName]
	internal virtual PictureBox Gp2()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lg2(PictureBox Xr6)
	{
		PictureBox val = (P = Xr6);
	}

	[SpecialName]
	internal virtual PictureBox z8D()
	{
		return _PictureBox127;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gs3(PictureBox m4X)
	{
		_PictureBox127 = m4X;
	}

	[SpecialName]
	internal virtual PictureBox Fa1()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cq4(PictureBox Ya8)
	{
		PictureBox val = (c = Ya8);
	}

	[SpecialName]
	internal virtual PictureBox Zn3()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6J(PictureBox q4P)
	{
		PictureBox val = (U = q4P);
	}

	[SpecialName]
	internal virtual PictureBox Pf4()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ds8(PictureBox x6N)
	{
		PictureBox val = (F = x6N);
	}

	[SpecialName]
	internal virtual PictureBox Jq1()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jo5(PictureBox Yc6)
	{
		PictureBox val = (d = Yc6);
	}

	[SpecialName]
	internal virtual PictureBox Ea7()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3P(PictureBox x8J)
	{
		PictureBox val = (a = x8J);
	}

	[SpecialName]
	internal virtual PictureBox o1J()
	{
		return _PictureBox133;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3Y(PictureBox Ri9)
	{
		_PictureBox133 = Ri9;
	}

	[SpecialName]
	internal virtual PictureBox Pc2()
	{
		return _PictureBox134;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4C(PictureBox t2Y)
	{
		_PictureBox134 = t2Y;
	}

	[SpecialName]
	internal virtual PictureBox Tq3()
	{
		return _PictureBox135;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1D(PictureBox m0J)
	{
		_PictureBox135 = m0J;
	}

	[SpecialName]
	internal virtual PictureBox Wo3()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz1(PictureBox Db6)
	{
		PictureBox val = (M = Db6);
	}

	[SpecialName]
	internal virtual PictureBox p1P()
	{
		return _PictureBox137;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8X(PictureBox i4Z)
	{
		_PictureBox137 = i4Z;
	}

	[SpecialName]
	internal virtual PictureBox Zy7()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tj0(PictureBox c9P)
	{
		PictureBox val = (g = c9P);
	}

	[SpecialName]
	internal virtual PictureBox Hk9()
	{
		return _PictureBox139;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q6J(PictureBox z1P)
	{
		_PictureBox139 = z1P;
	}

	[SpecialName]
	internal virtual PictureBox Zf2()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cr8(PictureBox Dk1)
	{
		PictureBox val = (W = Dk1);
	}

	[SpecialName]
	internal virtual PictureBox Qf5()
	{
		return _PictureBox101;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s8L(PictureBox Np2)
	{
		_PictureBox101 = Np2;
	}

	[SpecialName]
	internal virtual PictureBox Bm9()
	{
		return _PictureBox102;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1S(PictureBox Hb5)
	{
		_PictureBox102 = Hb5;
	}

	[SpecialName]
	internal virtual PictureBox n6N()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7Y(PictureBox o3C)
	{
		PictureBox val = (l = o3C);
	}

	[SpecialName]
	internal virtual PictureBox Po3()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4L(PictureBox Dd9)
	{
		PictureBox val = (x = Dd9);
	}

	[SpecialName]
	internal virtual PictureBox z0F()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3D(PictureBox a4Y)
	{
		PictureBox val = (e = a4Y);
	}

	[SpecialName]
	internal virtual PictureBox n9Q()
	{
		return _PictureBox106;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd0(PictureBox Mb4)
	{
		_PictureBox106 = Mb4;
	}

	[SpecialName]
	internal virtual PictureBox k3S()
	{
		return _PictureBox107;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm0(PictureBox k5N)
	{
		_PictureBox107 = k5N;
	}

	[SpecialName]
	internal virtual PictureBox Gg0()
	{
		return _PictureBox108;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec6(PictureBox Xz2)
	{
		_PictureBox108 = Xz2;
	}

	[SpecialName]
	internal virtual PictureBox Fm5()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp9(PictureBox Af0)
	{
		PictureBox val = (S = Af0);
	}

	[SpecialName]
	internal virtual PictureBox Ns7()
	{
		return _PictureBox110;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nj3(PictureBox Hq2)
	{
		_PictureBox110 = Hq2;
	}

	[SpecialName]
	internal virtual PictureBox f0E()
	{
		return _PictureBox111;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0H(PictureBox Bm2)
	{
		_PictureBox111 = Bm2;
	}

	[SpecialName]
	internal virtual PictureBox Jx7()
	{
		return _PictureBox112;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8D(PictureBox Ye8)
	{
		_PictureBox112 = Ye8;
	}

	[SpecialName]
	internal virtual PictureBox s1J()
	{
		return _PictureBox113;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei1(PictureBox c2Q)
	{
		_PictureBox113 = c2Q;
	}

	[SpecialName]
	internal virtual PictureBox Hz9()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp6(PictureBox Dq3)
	{
		PictureBox val = (z = Dq3);
	}

	[SpecialName]
	internal virtual PictureBox x4A()
	{
		return _PictureBox115;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nc1(PictureBox j2D)
	{
		_PictureBox115 = j2D;
	}

	[SpecialName]
	internal virtual PictureBox j7T()
	{
		return QO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9C(PictureBox m1S)
	{
		PictureBox val = (QO = m1S);
	}

	[SpecialName]
	internal virtual PictureBox Ld9()
	{
		return _PictureBox117;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo4(PictureBox n2P)
	{
		_PictureBox117 = n2P;
	}

	[SpecialName]
	internal virtual PictureBox Lt9()
	{
		return _PictureBox118;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj3(PictureBox Ss9)
	{
		_PictureBox118 = Ss9;
	}

	[SpecialName]
	internal virtual PictureBox w9L()
	{
		return _PictureBox119;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd4(PictureBox d6Z)
	{
		_PictureBox119 = d6Z;
	}

	[SpecialName]
	internal virtual PictureBox z2N()
	{
		return QQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gd3(PictureBox y7J)
	{
		PictureBox val = (QQ = y7J);
	}

	[SpecialName]
	internal virtual PictureBox b9G()
	{
		return Qj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5P(PictureBox Cz6)
	{
		PictureBox val = (Qj = Cz6);
	}

	[SpecialName]
	internal virtual PictureBox Fw6()
	{
		return _PictureBox82;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1C(PictureBox d2X)
	{
		_PictureBox82 = d2X;
	}

	[SpecialName]
	internal virtual PictureBox St4()
	{
		return QY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei2(PictureBox Aw5)
	{
		PictureBox val = (QY = Aw5);
	}

	[SpecialName]
	internal virtual PictureBox e3H()
	{
		return _PictureBox84;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yf8(PictureBox g4F)
	{
		_PictureBox84 = g4F;
	}

	[SpecialName]
	internal virtual PictureBox Ae2()
	{
		return _PictureBox85;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qt0(PictureBox Kt1)
	{
		_PictureBox85 = Kt1;
	}

	[SpecialName]
	internal virtual PictureBox i8P()
	{
		return QH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Di8(PictureBox Qb8)
	{
		PictureBox val = (QH = Qb8);
	}

	[SpecialName]
	internal virtual PictureBox Xe8()
	{
		return QV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te1(PictureBox p7R)
	{
		PictureBox val = (QV = p7R);
	}

	[SpecialName]
	internal virtual PictureBox w0S()
	{
		return _PictureBox88;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le3(PictureBox Mq3)
	{
		_PictureBox88 = Mq3;
	}

	[SpecialName]
	internal virtual PictureBox Qy6()
	{
		return Qi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4C(PictureBox Mc9)
	{
		PictureBox val = (Qi = Mc9);
	}

	[SpecialName]
	internal virtual PictureBox t8W()
	{
		return Qb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw6(PictureBox Wq7)
	{
		PictureBox val = (Qb = Wq7);
	}

	[SpecialName]
	internal virtual PictureBox g9P()
	{
		return _PictureBox91;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ri5(PictureBox Tf5)
	{
		_PictureBox91 = Tf5;
	}

	[SpecialName]
	internal virtual PictureBox Wb7()
	{
		return _PictureBox92;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7F(PictureBox d6D)
	{
		_PictureBox92 = d6D;
	}

	[SpecialName]
	internal virtual PictureBox Ha0()
	{
		return Qk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0R(PictureBox Ry4)
	{
		PictureBox val = (Qk = Ry4);
	}

	[SpecialName]
	internal virtual PictureBox b5S()
	{
		return _PictureBox94;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8Q(PictureBox e1H)
	{
		_PictureBox94 = e1H;
	}

	[SpecialName]
	internal virtual PictureBox y8B()
	{
		return _PictureBox95;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wo2(PictureBox Pz2)
	{
		_PictureBox95 = Pz2;
	}

	[SpecialName]
	internal virtual PictureBox Kz8()
	{
		return Qr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0Z(PictureBox Ze5)
	{
		PictureBox val = (Qr = Ze5);
	}

	[SpecialName]
	internal virtual PictureBox Kq7()
	{
		return _PictureBox97;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St0(PictureBox q4K)
	{
		_PictureBox97 = q4K;
	}

	[SpecialName]
	internal virtual PictureBox Km9()
	{
		return _PictureBox98;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0E(PictureBox Md3)
	{
		_PictureBox98 = Md3;
	}

	[SpecialName]
	internal virtual PictureBox Dg8()
	{
		return _PictureBox99;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ck3(PictureBox j4S)
	{
		_PictureBox99 = j4S;
	}

	[SpecialName]
	internal virtual PictureBox Co8()
	{
		return Qn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5Z(PictureBox x1G)
	{
		PictureBox val = (Qn = x1G);
	}

	[SpecialName]
	internal virtual PictureBox q4N()
	{
		return Qt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1F(PictureBox Bw6)
	{
		PictureBox val = (Qt = Bw6);
	}

	[SpecialName]
	internal virtual PictureBox Pb4()
	{
		return QP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5D(PictureBox Ci7)
	{
		PictureBox val = (QP = Ci7);
	}

	[SpecialName]
	internal virtual PictureBox Kn8()
	{
		return _PictureBox63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wx1(PictureBox Gq2)
	{
		_PictureBox63 = Gq2;
	}

	[SpecialName]
	internal virtual PictureBox Fc0()
	{
		return _PictureBox64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cm6(PictureBox Zd3)
	{
		_PictureBox64 = Zd3;
	}

	[SpecialName]
	internal virtual PictureBox At9()
	{
		return _PictureBox65;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4J(PictureBox k8P)
	{
		_PictureBox65 = k8P;
	}

	[SpecialName]
	internal virtual PictureBox g0G()
	{
		return _PictureBox66;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lx5(PictureBox n5Y)
	{
		_PictureBox66 = n5Y;
	}

	[SpecialName]
	internal virtual PictureBox k3W2()
	{
		return Qc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1XP(PictureBox Bc7p)
	{
		PictureBox val = (Qc = Bc7p);
	}

	[SpecialName]
	internal virtual PictureBox i5C1()
	{
		return QU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ze28(PictureBox Ct7d)
	{
		PictureBox val = (QU = Ct7d);
	}

	[SpecialName]
	internal virtual PictureBox Ye6b()
	{
		return _PictureBox69;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj05(PictureBox d1K0)
	{
		_PictureBox69 = d1K0;
	}

	[SpecialName]
	internal virtual PictureBox Tk06()
	{
		return _PictureBox70;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2TN(PictureBox Sm3s)
	{
		_PictureBox70 = Sm3s;
	}

	[SpecialName]
	internal virtual PictureBox Ks8r()
	{
		return _PictureBox71;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng48(PictureBox Yj5a)
	{
		_PictureBox71 = Yj5a;
	}

	[SpecialName]
	internal virtual PictureBox Ws96()
	{
		return _PictureBox72;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ki9o(PictureBox Zf82)
	{
		_PictureBox72 = Zf82;
	}

	[SpecialName]
	internal virtual PictureBox z9T1()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp12(PictureBox k9QF)
	{
		_PictureBox73 = k9QF;
	}

	[SpecialName]
	internal virtual PictureBox Gz21()
	{
		return _PictureBox74;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qs41(PictureBox Sz1q)
	{
		_PictureBox74 = Sz1q;
	}

	[SpecialName]
	internal virtual PictureBox So09()
	{
		return _PictureBox75;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ek03(PictureBox g6Q1)
	{
		_PictureBox75 = g6Q1;
	}

	[SpecialName]
	internal virtual PictureBox Et85()
	{
		return QF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp95(PictureBox t8MT)
	{
		PictureBox val = (QF = t8MT);
	}

	[SpecialName]
	internal virtual PictureBox Dy47()
	{
		return Qd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt8p(PictureBox a3BA)
	{
		PictureBox val = (Qd = a3BA);
	}

	[SpecialName]
	internal virtual PictureBox z9R2()
	{
		return Qa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7NZ(PictureBox Fx92)
	{
		PictureBox val = (Qa = Fx92);
	}

	[SpecialName]
	internal virtual PictureBox Ds70()
	{
		return _PictureBox79;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5DF(PictureBox d7A8)
	{
		_PictureBox79 = d7A8;
	}

	[SpecialName]
	internal virtual PictureBox a2BA()
	{
		return _PictureBox80;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1P2(PictureBox r9YX)
	{
		_PictureBox80 = r9YX;
	}

	[SpecialName]
	internal virtual PictureBox a6B3()
	{
		return _PictureBox41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts7p(PictureBox y6B3)
	{
		_PictureBox41 = y6B3;
	}

	[SpecialName]
	internal virtual PictureBox a4QS()
	{
		return _PictureBox42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp6c(PictureBox i4E9)
	{
		_PictureBox42 = i4E9;
	}

	[SpecialName]
	internal virtual PictureBox Kf6n()
	{
		return QM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6FH(PictureBox Si83)
	{
		PictureBox val = (QM = Si83);
	}

	[SpecialName]
	internal virtual PictureBox Sf0j()
	{
		return Qg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rk7s(PictureBox Mk21)
	{
		PictureBox val = (Qg = Mk21);
	}

	[SpecialName]
	internal virtual PictureBox Xy4z()
	{
		return _PictureBox45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kx97(PictureBox Gq38)
	{
		_PictureBox45 = Gq38;
	}

	[SpecialName]
	internal virtual PictureBox a2B3()
	{
		return _PictureBox46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go29(PictureBox Ba67)
	{
		_PictureBox46 = Ba67;
	}

	[SpecialName]
	internal virtual PictureBox Dg96()
	{
		return QW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gp36(PictureBox Xn24)
	{
		PictureBox val = (QW = Xn24);
	}

	[SpecialName]
	internal virtual PictureBox g7RE()
	{
		return Ql;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1JS(PictureBox b6Y9)
	{
		PictureBox val = (Ql = b6Y9);
	}

	[SpecialName]
	internal virtual PictureBox Tp7z()
	{
		return _PictureBox49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3TH(PictureBox e6W5)
	{
		_PictureBox49 = e6W5;
	}

	[SpecialName]
	internal virtual PictureBox d1L5()
	{
		return Qx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8C3(PictureBox Fn09)
	{
		PictureBox val = (Qx = Fn09);
	}

	[SpecialName]
	internal virtual PictureBox Bq97()
	{
		return Qe;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So4d(PictureBox Cb53)
	{
		PictureBox val = (Qe = Cb53);
	}

	[SpecialName]
	internal virtual PictureBox Ge19()
	{
		return _PictureBox52;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4SX(PictureBox Bj9g)
	{
		_PictureBox52 = Bj9g;
	}

	[SpecialName]
	internal virtual PictureBox y8QL()
	{
		return QS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3ZD(PictureBox Cd89)
	{
		PictureBox val = (QS = Cd89);
	}

	[SpecialName]
	internal virtual PictureBox p0MA()
	{
		return Qz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2Y9(PictureBox z0ZX)
	{
		PictureBox val = (Qz = z0ZX);
	}

	[SpecialName]
	internal virtual PictureBox Fp7o()
	{
		return _PictureBox55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kt3r(PictureBox Js5a)
	{
		_PictureBox55 = Js5a;
	}

	[SpecialName]
	internal virtual PictureBox b6H2()
	{
		return jO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5LN(PictureBox y1R7)
	{
		PictureBox val = (jO = y1R7);
	}

	[SpecialName]
	internal virtual PictureBox r6QH()
	{
		return _PictureBox57;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6W3(PictureBox Ax09)
	{
		_PictureBox57 = Ax09;
	}

	[SpecialName]
	internal virtual PictureBox b9M5()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pm3n(PictureBox Fi4a)
	{
		_PictureBox58 = Fi4a;
	}

	[SpecialName]
	internal virtual PictureBox s6X0()
	{
		return jQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2B8(PictureBox i2SR)
	{
		PictureBox val = (jQ = i2SR);
	}

	[SpecialName]
	internal virtual PictureBox Sq2d()
	{
		return _PictureBox60;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5E6(PictureBox Zw2j)
	{
		_PictureBox60 = Zw2j;
	}

	[SpecialName]
	internal virtual PictureBox e4PT()
	{
		return jj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3YF(PictureBox c2T6)
	{
		PictureBox val = (jj = c2T6);
	}

	[SpecialName]
	internal virtual PictureBox Jr6q()
	{
		return _PictureBox22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5E1(PictureBox Rd40)
	{
		_PictureBox22 = Rd40;
	}

	[SpecialName]
	internal virtual PictureBox g2X5()
	{
		return _PictureBox23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Co9t(PictureBox Ff4j)
	{
		_PictureBox23 = Ff4j;
	}

	[SpecialName]
	internal virtual PictureBox Bx8z()
	{
		return _PictureBox24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lq2y(PictureBox Qg6k)
	{
		_PictureBox24 = Qg6k;
	}

	[SpecialName]
	internal virtual PictureBox g6L7()
	{
		return jY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4M7(PictureBox Ta8x)
	{
		PictureBox val = (jY = Ta8x);
	}

	[SpecialName]
	internal virtual PictureBox f3ZF()
	{
		return jH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6ZG(PictureBox i4AR)
	{
		PictureBox val = (jH = i4AR);
	}

	[SpecialName]
	internal virtual PictureBox n8J2()
	{
		return jV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ht54(PictureBox i2GK)
	{
		PictureBox val = (jV = i2GK);
	}

	[SpecialName]
	internal virtual PictureBox q0B4()
	{
		return _PictureBox28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx21(PictureBox Ye1s)
	{
		_PictureBox28 = Ye1s;
	}

	[SpecialName]
	internal virtual PictureBox Go3n()
	{
		return _PictureBox29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj76(PictureBox Zi23)
	{
		_PictureBox29 = Zi23;
	}

	[SpecialName]
	internal virtual PictureBox n7GH()
	{
		return ji;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1E4(PictureBox y4KR)
	{
		PictureBox val = (ji = y4KR);
	}

	[SpecialName]
	internal virtual PictureBox k5CG()
	{
		return jb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt61(PictureBox q1ZM)
	{
		PictureBox val = (jb = q1ZM);
	}

	[SpecialName]
	internal virtual PictureBox s1E0()
	{
		return jk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rd54(PictureBox Xs27)
	{
		PictureBox val = (jk = Xs27);
	}

	[SpecialName]
	internal virtual PictureBox Lf3c()
	{
		return jr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0A2(PictureBox i5Y3)
	{
		PictureBox val = (jr = i5Y3);
	}

	[SpecialName]
	internal virtual PictureBox Cr56()
	{
		return jn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nq9r(PictureBox q7LE)
	{
		PictureBox val = (jn = q7LE);
	}

	[SpecialName]
	internal virtual PictureBox k6ZT()
	{
		return _PictureBox35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sw61(PictureBox Ax8j)
	{
		_PictureBox35 = Ax8j;
	}

	[SpecialName]
	internal virtual PictureBox Dr79()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No8t(PictureBox Et06)
	{
		_PictureBox36 = Et06;
	}

	[SpecialName]
	internal virtual PictureBox d4A1()
	{
		return _PictureBox37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2P4(PictureBox Rn83)
	{
		_PictureBox37 = Rn83;
	}

	[SpecialName]
	internal virtual PictureBox k0GY()
	{
		return _PictureBox38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3R4(PictureBox q0N6)
	{
		_PictureBox38 = q0N6;
	}

	[SpecialName]
	internal virtual TextBox Rx3k()
	{
		return _txtAvailable;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0LK(TextBox Dp6t)
	{
		_txtAvailable = Dp6t;
	}

	[SpecialName]
	internal virtual PictureBox Dp6d()
	{
		return _Booked;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Es59(PictureBox o9JX)
	{
		_Booked = o9JX;
	}

	[SpecialName]
	internal virtual PictureBox Ab62()
	{
		return _Provisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wz65(PictureBox p9N6)
	{
		_Provisional = p9N6;
	}

	[SpecialName]
	internal virtual PictureBox Sk38()
	{
		return jt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9XD(PictureBox Gr1j)
	{
		PictureBox val = (jt = Gr1j);
	}

	[SpecialName]
	internal virtual Label w3KW()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pe1b(Label Tm73)
	{
		_Label3 = Tm73;
	}

	[SpecialName]
	internal virtual PictureBox a8L0()
	{
		return _PictureBox39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5KS(PictureBox Hr06)
	{
		_PictureBox39 = Hr06;
	}

	[SpecialName]
	internal virtual TextBox n5QT()
	{
		return jP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3GB(TextBox s9Z3)
	{
		TextBox val = (jP = s9Z3);
	}

	[SpecialName]
	internal virtual Label Xn37()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6MQ(Label Gq9e)
	{
		_Label1 = Gq9e;
	}

	[SpecialName]
	internal virtual Label Fj31()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3CJ(Label Dg36)
	{
		_Label2 = Dg36;
	}

	[SpecialName]
	internal virtual PictureBox Ea5b()
	{
		return jc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void En85(PictureBox c4C1)
	{
		PictureBox val = (jc = c4C1);
	}

	[SpecialName]
	internal virtual PictureBox Rr59()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ao6c(PictureBox Lw2i)
	{
		_PictureBox20 = Lw2i;
	}

	[SpecialName]
	internal virtual PictureBox Lt83()
	{
		return jU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2P6(PictureBox Hp2d)
	{
		PictureBox val = (jU = Hp2d);
	}

	[SpecialName]
	internal virtual PictureBox Mi50()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9L3(PictureBox p1W3)
	{
		_PictureBox18 = p1W3;
	}

	[SpecialName]
	internal virtual PictureBox Yy4t()
	{
		return jF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gk5y(PictureBox d6E2)
	{
		PictureBox val = (jF = d6E2);
	}

	[SpecialName]
	internal virtual PictureBox Fd79()
	{
		return jd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1NA(PictureBox g9M2)
	{
		PictureBox val = (jd = g9M2);
	}

	[SpecialName]
	internal virtual PictureBox Li0k()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft5d(PictureBox f3PA)
	{
		_PictureBox15 = f3PA;
	}

	[SpecialName]
	internal virtual PictureBox f0N5()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep48(PictureBox o2Y4)
	{
		_PictureBox14 = o2Y4;
	}

	[SpecialName]
	internal virtual PictureBox Ez04()
	{
		return ja;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg12(PictureBox e8XA)
	{
		PictureBox val = (ja = e8XA);
	}

	[SpecialName]
	internal virtual PictureBox p8Q6()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei6w(PictureBox Mb4g)
	{
		_PictureBox12 = Mb4g;
	}

	[SpecialName]
	internal virtual PictureBox Ja5k()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2AX(PictureBox w0Q9)
	{
		_PictureBox11 = w0Q9;
	}

	[SpecialName]
	internal virtual PictureBox m9Q7()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rk8f(PictureBox Jm09)
	{
		_PictureBox10 = Jm09;
	}

	[SpecialName]
	internal virtual PictureBox b5K1()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dx9p(PictureBox Ad10)
	{
		_PictureBox9 = Ad10;
	}

	[SpecialName]
	internal virtual PictureBox Ym8i()
	{
		return jM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ck67(PictureBox k3R0)
	{
		PictureBox val = (jM = k3R0);
	}

	[SpecialName]
	internal virtual PictureBox Cm76()
	{
		return jg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w8G4(PictureBox Tq91)
	{
		PictureBox val = (jg = Tq91);
	}

	[SpecialName]
	internal virtual PictureBox d9CL()
	{
		return jW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2T6(PictureBox Pq59)
	{
		PictureBox val = (jW = Pq59);
	}

	[SpecialName]
	internal virtual PictureBox Si54()
	{
		return jl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn48(PictureBox Nc1e)
	{
		PictureBox val = (jl = Nc1e);
	}

	[SpecialName]
	internal virtual PictureBox f3H7()
	{
		return jx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5GM(PictureBox Dt12)
	{
		PictureBox val = (jx = Dt12);
	}

	[SpecialName]
	internal virtual PictureBox t7R8()
	{
		return je;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0D9(PictureBox y2YB)
	{
		PictureBox val = (je = y2YB);
	}

	[SpecialName]
	internal virtual PictureBox c8NZ()
	{
		return jS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2KJ(PictureBox t3N2)
	{
		PictureBox val = (jS = t3N2);
	}

	[SpecialName]
	internal virtual PictureBox c0ZQ()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9P2(PictureBox Tx2t)
	{
		_PictureBox1 = Tx2t;
	}

	[SpecialName]
	internal virtual Label r0YS()
	{
		return _Label32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx08(Label k2JK)
	{
		_Label32 = k2JK;
	}

	[SpecialName]
	internal virtual Label i9P8()
	{
		return jz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nc8o(Label p0WR)
	{
		Label val = (jz = p0WR);
	}

	[SpecialName]
	internal virtual Label Qp40()
	{
		return _Label34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx1s(Label r0C6)
	{
		_Label34 = r0C6;
	}

	[SpecialName]
	internal virtual Label p3N0()
	{
		return YO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5Q7(Label Lg0b)
	{
		Label val = (YO = Lg0b);
	}

	[SpecialName]
	internal virtual Label Fb5e()
	{
		return YQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3F1(Label n1RA)
	{
		Label val = (YQ = n1RA);
	}

	[SpecialName]
	internal virtual Label Ho59()
	{
		return Yj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2R9(Label n9Z3)
	{
		Label val = (Yj = n9Z3);
	}

	[SpecialName]
	internal virtual Label o3GA()
	{
		return YY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2DN(Label Lr43)
	{
		Label val = (YY = Lr43);
	}

	[SpecialName]
	internal virtual Label y0LE()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2AT(Label n1PT)
	{
		_Label40 = n1PT;
	}

	[SpecialName]
	internal virtual Label e6Z8()
	{
		return _Label41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc56(Label a3GZ)
	{
		_Label41 = a3GZ;
	}

	[SpecialName]
	internal virtual Label Hc21()
	{
		return YH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9Q1(Label Eb2r)
	{
		Label val = (YH = Eb2r);
	}

	[SpecialName]
	internal virtual Label p9F4()
	{
		return YV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr4q(Label e4DE)
	{
		Label val = (YV = e4DE);
	}

	[SpecialName]
	internal virtual Label t0E6()
	{
		return _Label38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Br6n(Label k5RC)
	{
		_Label38 = k5RC;
	}

	[SpecialName]
	internal virtual Label f4KE()
	{
		return _Label44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9S1(Label Pq5c)
	{
		_Label44 = Pq5c;
	}

	[SpecialName]
	internal virtual Label f8QK()
	{
		return Yi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gi5r(Label i7AW)
	{
		Label val = (Yi = i7AW);
	}

	[SpecialName]
	internal virtual Label c9E7()
	{
		return Yb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dt87(Label Hb1k)
	{
		Label val = (Yb = Hb1k);
	}

	[SpecialName]
	internal virtual Label Bm0z()
	{
		return Yk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5XQ(Label Mq0t)
	{
		Label val = (Yk = Mq0t);
	}

	[SpecialName]
	internal virtual Label f2CH()
	{
		return _Label48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1MY(Label g4HK)
	{
		_Label48 = g4HK;
	}

	[SpecialName]
	internal virtual Label z9R7()
	{
		return _Label49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9AJ(Label Hc8x)
	{
		_Label49 = Hc8x;
	}

	[SpecialName]
	internal virtual Label Zn5w()
	{
		return _Label50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf4y(Label Fb81)
	{
		_Label50 = Fb81;
	}

	[SpecialName]
	internal virtual Label y6GT()
	{
		return _Label51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0EB(Label j2LX)
	{
		_Label51 = j2LX;
	}

	[SpecialName]
	internal virtual Label Mi01()
	{
		return Yr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9BZ(Label Nf0y)
	{
		Label val = (Yr = Nf0y);
	}

	[SpecialName]
	internal virtual Label Mr13()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1XW(Label Qa35)
	{
		_Label55 = Qa35;
	}

	[SpecialName]
	internal virtual Label Hw3d()
	{
		return _Label56;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nb15(Label f3T5)
	{
		_Label56 = f3T5;
	}

	[SpecialName]
	internal virtual Label s3GK()
	{
		return _Label31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8QS(Label Jk31)
	{
		_Label31 = Jk31;
	}

	[SpecialName]
	internal virtual Label y4F1()
	{
		return _Label26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cn4j(Label c0L2)
	{
		_Label26 = c0L2;
	}

	[SpecialName]
	internal virtual Label a2F9()
	{
		return _Label27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1Z5(Label d6YD)
	{
		_Label27 = d6YD;
	}

	[SpecialName]
	internal virtual Label m1LF()
	{
		return _Label28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4LB(Label Ft1k)
	{
		_Label28 = Ft1k;
	}

	[SpecialName]
	internal virtual Label s9FJ()
	{
		return _Label29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kt5r(Label Md20)
	{
		_Label29 = Md20;
	}

	[SpecialName]
	internal virtual Label j1J8()
	{
		return _Label30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0TY(Label m4RS)
	{
		_Label30 = m4RS;
	}

	[SpecialName]
	internal virtual Label n0CG()
	{
		return Yn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2XF(Label Lj3p)
	{
		Label val = (Yn = Lj3p);
	}

	[SpecialName]
	internal virtual Label g1CW()
	{
		return Yt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw26(Label w5BN)
	{
		Label val = (Yt = w5BN);
	}

	[SpecialName]
	internal virtual Label o8T4()
	{
		return YP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1KE(Label Jc8x)
	{
		Label val = (YP = Jc8x);
	}

	[SpecialName]
	internal virtual Label Dg68()
	{
		return Yc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7QA(Label Rb6z)
	{
		Label val = (Yc = Rb6z);
	}

	[SpecialName]
	internal virtual Label i8DM()
	{
		return _Label21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jm1e(Label Gi87)
	{
		_Label21 = Gi87;
	}

	[SpecialName]
	internal virtual Label p1W0()
	{
		return _Label20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0H2(Label Xb0i)
	{
		_Label20 = Xb0i;
	}

	[SpecialName]
	internal virtual Label g1RN()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5XS(Label Dk4t)
	{
		_Label19 = Dk4t;
	}

	[SpecialName]
	internal virtual Label s4Z3()
	{
		return YU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ff45(Label e2J4)
	{
		Label val = (YU = e2J4);
	}

	[SpecialName]
	internal virtual Label Gj6z()
	{
		return _Label17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yj15(Label No20)
	{
		_Label17 = No20;
	}

	[SpecialName]
	internal virtual Label Jw5g()
	{
		return YF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8TF(Label f5W2)
	{
		Label val = (YF = f5W2);
	}

	[SpecialName]
	internal virtual Label Zq6p()
	{
		return Yd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3J1(Label Nb53)
	{
		Label val = (Yd = Nb53);
	}

	[SpecialName]
	internal virtual Label z9K7()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0JX(Label n8L3)
	{
		_Label14 = n8L3;
	}

	[SpecialName]
	internal virtual Label s2FB()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bc57(Label r1G2)
	{
		_Label13 = r1G2;
	}

	[SpecialName]
	internal virtual Label o5AK()
	{
		return Ya;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jm05(Label Bx47)
	{
		Label val = (Ya = Bx47);
	}

	[SpecialName]
	internal virtual Label i3YS()
	{
		return YM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fz6k(Label Ws75)
	{
		Label val = (YM = Ws75);
	}

	[SpecialName]
	internal virtual Label f3H7()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3W9(Label Gd1k)
	{
		_Label10 = Gd1k;
	}

	[SpecialName]
	internal virtual Label Mz0g()
	{
		return Yg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lq26(Label y1XP)
	{
		Label val = (Yg = y1XP);
	}

	[SpecialName]
	internal virtual Label Jd39()
	{
		return YW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5AR(Label z4KZ)
	{
		Label val = (YW = z4KZ);
	}

	[SpecialName]
	internal virtual Label Yq3s()
	{
		return Yl;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi0x(Label n7RT)
	{
		Label val = (Yl = n7RT);
	}

	[SpecialName]
	internal virtual Label r0SL()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1QR(Label w0T3)
	{
		_Label4 = w0T3;
	}

	[SpecialName]
	internal virtual Label Bk41()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cm6z(Label w7N2)
	{
		_Label5 = w7N2;
	}

	[SpecialName]
	internal virtual GroupBox Ee4z()
	{
		return Yx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1W6(GroupBox t7A0)
	{
		GroupBox val = (Yx = t7A0);
	}

	[SpecialName]
	internal virtual PictureBox Mz3o()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9T8(PictureBox Rz5n)
	{
		_Cover = Rz5n;
	}

	[SpecialName]
	internal virtual GroupBox Wb3i()
	{
		return Ye;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo3b(GroupBox Yw9n)
	{
		GroupBox val = (Ye = Yw9n);
	}

	[SpecialName]
	internal virtual TextBox t8E7()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1D9(TextBox e2GJ)
	{
		_txtProvisional = e2GJ;
	}

	[SpecialName]
	internal virtual Label s6CR()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9X7(Label Lo82)
	{
		_Label6 = Lo82;
	}

	[SpecialName]
	internal virtual PictureBox To2j()
	{
		return YS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jm9y(PictureBox g2PB)
	{
		PictureBox val = (YS = g2PB);
	}

	[SpecialName]
	internal virtual PictureBox Ja59()
	{
		return Yz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2JT(PictureBox a5Z4)
	{
		PictureBox val = (Yz = a5Z4);
	}

	[SpecialName]
	internal virtual GroupBox e8MC()
	{
		return HO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3AZ(GroupBox Np9c)
	{
		GroupBox val = (HO = Np9c);
	}

	[SpecialName]
	internal virtual Button Ti14()
	{
		return HQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gf32(Button r6HZ)
	{
		EventHandler eventHandler = Ys74;
		Button hQ = HQ;
		if (hQ != null)
		{
			((Control)hQ).remove_Click(eventHandler);
		}
		Button val = (HQ = r6HZ);
		hQ = HQ;
		if (hQ != null)
		{
			((Control)hQ).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ci3s()
	{
		return Hj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2QP(Button y7PW)
	{
		EventHandler eventHandler = m1J2;
		Button hj = Hj;
		if (hj != null)
		{
			((Control)hj).remove_Click(eventHandler);
		}
		Button val = (Hj = y7PW);
		hj = Hj;
		if (hj != null)
		{
			((Control)hj).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox m5J8()
	{
		return _txtChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3Q7(TextBox Bp60)
	{
		_txtChange = Bp60;
	}

	[SpecialName]
	internal virtual TextBox z8R0()
	{
		return HY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7ZL(TextBox Wc50)
	{
		TextBox val = (HY = Wc50);
	}

	[SpecialName]
	internal virtual TextBox w1Q3()
	{
		return _txtTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9TJ(TextBox o5SH)
	{
		_txtTotalCost = o5SH;
	}

	[SpecialName]
	internal virtual TextBox a0C5()
	{
		return _txtSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1FP(TextBox Te47)
	{
		_txtSeats = Te47;
	}

	[SpecialName]
	internal virtual Label Zo61()
	{
		return HH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4KC(Label Kz9i)
	{
		Label val = (HH = Kz9i);
	}

	[SpecialName]
	internal virtual Label b3P8()
	{
		return HV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ds36(Label q0XM)
	{
		Label val = (HV = q0XM);
	}

	[SpecialName]
	internal virtual Label z3G2()
	{
		return Hi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt28(Label d3EF)
	{
		Label val = (Hi = d3EF);
	}

	[SpecialName]
	internal virtual Label Se7r()
	{
		return _Label62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb90(Label k2R0)
	{
		_Label62 = k2R0;
	}

	[SpecialName]
	internal virtual GroupBox Ky40()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4Y3(GroupBox Kr79)
	{
		_GroupBox2 = Kr79;
	}

	[SpecialName]
	internal virtual Button m5K0()
	{
		return _btnNew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4L3(Button Sc97)
	{
		EventHandler eventHandler = Yq4n;
		Button btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).remove_Click(eventHandler);
		}
		_btnNew = Sc97;
		btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Mt58()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8Y7(Button y5AQ)
	{
		_btnReset = y5AQ;
	}

	[SpecialName]
	internal virtual Button Qn2i()
	{
		return Hb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ao4w(Button Ty49)
	{
		EventHandler eventHandler = Xz6b;
		Button hb = Hb;
		if (hb != null)
		{
			((Control)hb).remove_Click(eventHandler);
		}
		Button val = (Hb = Ty49);
		hb = Hb;
		if (hb != null)
		{
			((Control)hb).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox s0MY()
	{
		return _txtFirstName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ks86(TextBox n6XL)
	{
		_txtFirstName = n6XL;
	}

	[SpecialName]
	internal virtual TextBox Cg3a()
	{
		return _txtID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1R2(TextBox Ww56)
	{
		_txtID = Ww56;
	}

	[SpecialName]
	internal virtual Label x2TQ()
	{
		return Hk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mq54(Label Ak7i)
	{
		Label val = (Hk = Ak7i);
	}

	[SpecialName]
	internal virtual Label c9K7()
	{
		return Hr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kg34(Label Kb10)
	{
		Label val = (Hr = Kb10);
	}

	[SpecialName]
	internal virtual Button Fe1x()
	{
		return _btnViewReservations;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8QC(Button o3CS)
	{
		EventHandler eventHandler = Ca53;
		Button btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).remove_Click(eventHandler);
		}
		_btnViewReservations = o3CS;
		btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).add_Click(eventHandler);
		}
	}

	private void Ys74(object sender, EventArgs e)
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
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 3.accdb";
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
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Cg3a().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = Cg3a().get_Text();
		firstName = s0MY().get_Text();
		val2.Close();
		d0WB();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void m1J2(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(z8R0().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			m5J8().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)z8R0()).Clear();
		}
	}

	private void Md8f(object sender, EventArgs e)
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
					val.add_Click((EventHandler)Gw1c);
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
		Ht = 160;
		bookedSeats = 0;
		provisionalSeats = 0;
		d0WB();
	}

	private void Ca53(object sender, EventArgs e)
	{
	}

	private void Xz6b(object sender, EventArgs e)
	{
	}

	private void Yq4n(object sender, EventArgs e)
	{
	}

	public void d0WB()
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
			int num = (Ht = 160 - bookedSeats);
			provisionalSeats = 0;
			string commandText = "SELECT * FROM tblBookings";
			string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 3.accdb";
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
					((PictureBox)NewLateBinding.LateGet((object)((Control)this).get_Controls(), (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"PictureBox", dataRow[2]) }, (string[])null, (Type[])null, (bool[])null)).set_Image((Image)Hn);
					bookedSeats++;
					Ht--;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			n5QT().set_Text(Conversions.ToString(bookedSeats));
			Rx3k().set_Text(Conversions.ToString(Ht));
			t8E7().set_Text(Conversions.ToString(provisionalSeats));
			x9F2();
		}
	}

	private void Gw1c(object sender, EventArgs e)
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
				Ht--;
			}
			else if (((PictureBox)sender).get_Image() == provisionalIcon)
			{
				((PictureBox)sender).set_Image((Image)availableIcon);
				provisionalSeats--;
				Ht++;
			}
			Rx3k().set_Text(Conversions.ToString(Ht));
			t8E7().set_Text(Conversions.ToString(provisionalSeats));
			seats = provisionalSeats;
			a0C5().set_Text(Conversions.ToString(seats));
			totalCost = provisionalSeats * 5;
			w1Q3().set_Text("$" + totalCost);
		}
	}

	public void x9F2()
	{
		((TextBoxBase)z8R0()).Clear();
		((TextBoxBase)s0MY()).Clear();
		((TextBoxBase)w1Q3()).Clear();
		((TextBoxBase)m5J8()).Clear();
		((TextBoxBase)a0C5()).Clear();
		((TextBoxBase)Cg3a()).Clear();
	}

	internal static void x0GC()
	{
		byte[] gk = So0.i9D3(133632);
		int num = checked(Conversions.ToInteger(r6C.mDic[r6C.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		r6C.mDic.Add(r6C.mArray, d2QN.g0J(gk, (byte[])r6C.mDic[r6C.sArray], num, 25));
		if (Hj3.f4N())
		{
			Yd2.Qf2();
		}
	}
}
