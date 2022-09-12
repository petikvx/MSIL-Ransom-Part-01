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

namespace Ni0b;

[DesignerGenerated]
public class Lb4r : Form
{
	private TextBox _txtProvisional;

	private Label _Label1;

	private PictureBox _PictureBox141;

	private PictureBox _PictureBox142;

	private PictureBox _PictureBox143;

	private PictureBox _PictureBox146;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox148;

	private PictureBox _PictureBox149;

	private PictureBox _PictureBox150;

	private PictureBox _PictureBox154;

	private PictureBox _PictureBox155;

	private PictureBox _PictureBox156;

	private PictureBox _PictureBox159;

	private PictureBox _PictureBox160;

	private PictureBox _PictureBox123;

	private PictureBox _PictureBox125;

	private PictureBox _PictureBox126;

	private PictureBox _PictureBox128;

	private PictureBox _PictureBox129;

	private PictureBox _PictureBox130;

	private PictureBox _PictureBox131;

	private PictureBox _PictureBox133;

	private PictureBox _PictureBox134;

	private PictureBox _PictureBox136;

	private PictureBox _PictureBox139;

	private PictureBox _PictureBox140;

	private PictureBox _PictureBox101;

	private PictureBox _PictureBox103;

	private PictureBox _PictureBox106;

	private PictureBox _PictureBox107;

	private PictureBox _PictureBox109;

	private PictureBox _PictureBox110;

	private PictureBox _PictureBox112;

	private PictureBox _PictureBox115;

	private PictureBox _PictureBox116;

	private PictureBox _PictureBox119;

	private PictureBox _PictureBox84;

	private PictureBox _PictureBox86;

	private PictureBox _PictureBox88;

	private PictureBox _PictureBox89;

	private PictureBox _PictureBox91;

	private PictureBox _PictureBox95;

	private PictureBox _PictureBox96;

	private PictureBox _PictureBox100;

	private PictureBox _PictureBox64;

	private PictureBox _PictureBox65;

	private PictureBox _PictureBox68;

	private PictureBox _PictureBox69;

	private PictureBox _PictureBox70;

	private PictureBox _PictureBox72;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox74;

	private PictureBox _PictureBox76;

	private PictureBox _PictureBox42;

	private PictureBox _PictureBox44;

	private PictureBox _PictureBox46;

	private PictureBox _PictureBox50;

	private PictureBox _PictureBox53;

	private PictureBox _PictureBox55;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox59;

	private PictureBox _PictureBox60;

	private PictureBox _PictureBox21;

	private PictureBox _PictureBox25;

	private PictureBox _PictureBox26;

	private PictureBox _PictureBox28;

	private PictureBox _PictureBox31;

	private PictureBox _PictureBox33;

	private PictureBox _PictureBox37;

	private PictureBox _PictureBox38;

	private PictureBox _PictureBox40;

	private PictureBox _PictureBox20;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox12;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox6;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox2;

	private Label _Label33;

	private Label _Label34;

	private Label _Label35;

	private Label _Label37;

	private Label _Label40;

	private Label _Label41;

	private Label _Label43;

	private Label _Label45;

	private Label _Label47;

	private Label _Label48;

	private Label _Label50;

	private Label _Label51;

	private Label _Label54;

	private Label _Label56;

	private Label _Label26;

	private Label _Label27;

	private Label _Label28;

	private Label _Label24;

	private Label _Label23;

	private Label _Label22;

	private Label _Label21;

	private Label _Label16;

	private Label _Label15;

	private Label _Label14;

	private Label _Label13;

	private Label _Label12;

	private Label _Label8;

	private Label _Label7;

	private TextBox _txtAvailable;

	private PictureBox _Provisional;

	private PictureBox _Available;

	private Label _Label6;

	private PictureBox _Background;

	private PictureBox _NameBox;

	private Button _btnViewReservations;

	private PictureBox _Cover;

	private Button _btnNew;

	private Button _btnReset;

	private Button _btnExisting;

	private TextBox _txtFirstName;

	private Button _btnSave;

	private Button _btnCalculateChange;

	private TextBox _txtTotalCost;

	private TextBox _txtSeats;

	private Label _Label61;

	private Label _Label62;

	private object bookedIcon;

	private int bookedSeats;

	private int provisionalSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal IContainer V;

	internal TextBox j;

	internal Label n;

	internal PictureBox d;

	internal PictureBox a;

	internal PictureBox F;

	internal PictureBox t;

	internal PictureBox r;

	internal PictureBox O;

	internal PictureBox H;

	internal PictureBox e;

	internal PictureBox K;

	internal PictureBox w;

	internal PictureBox G;

	internal PictureBox b;

	internal PictureBox x;

	internal PictureBox p;

	internal PictureBox i;

	internal PictureBox s;

	internal PictureBox Q;

	internal PictureBox L;

	internal PictureBox Y;

	internal PictureBox U;

	internal PictureBox m;

	internal PictureBox c;

	internal PictureBox z;

	internal PictureBox jV;

	internal PictureBox jj;

	internal PictureBox jn;

	internal PictureBox jd;

	internal PictureBox ja;

	internal PictureBox jF;

	internal PictureBox jt;

	internal PictureBox jr;

	internal PictureBox jO;

	internal PictureBox jH;

	internal PictureBox je;

	internal PictureBox jK;

	internal PictureBox jw;

	internal PictureBox jG;

	internal PictureBox jb;

	internal PictureBox jx;

	internal PictureBox jp;

	internal PictureBox ji;

	internal PictureBox js;

	internal PictureBox jQ;

	internal PictureBox jL;

	internal PictureBox jY;

	internal PictureBox jU;

	internal PictureBox jm;

	internal PictureBox jc;

	internal PictureBox jz;

	internal PictureBox nV;

	internal PictureBox nj;

	internal PictureBox nn;

	internal PictureBox nd;

	internal PictureBox na;

	internal PictureBox nF;

	internal PictureBox nt;

	internal PictureBox nr;

	internal PictureBox nO;

	internal PictureBox nH;

	internal PictureBox ne;

	internal PictureBox nK;

	internal PictureBox nw;

	internal PictureBox nG;

	internal PictureBox nb;

	internal PictureBox nx;

	internal PictureBox np;

	internal PictureBox ni;

	internal PictureBox ns;

	internal PictureBox nQ;

	internal PictureBox nL;

	internal PictureBox nY;

	internal PictureBox nU;

	internal PictureBox nm;

	internal PictureBox nc;

	internal PictureBox nz;

	internal PictureBox dV;

	internal PictureBox dj;

	internal PictureBox dn;

	internal PictureBox dd;

	internal Label da;

	internal Label dF;

	internal Label dt;

	internal Label dr;

	internal Label dO;

	internal Label dH;

	internal Label de;

	internal Label dK;

	internal Label dw;

	internal Label dG;

	internal Label db;

	internal Label dx;

	internal Label dp;

	internal Label di;

	internal Label ds;

	internal Label dQ;

	internal Label dL;

	internal Label dY;

	internal Label dU;

	internal Label dm;

	internal Label dc;

	internal Label dz;

	internal GroupBox aV;

	internal PictureBox aj;

	internal Label an;

	internal GroupBox ad;

	internal GroupBox aa;

	internal TextBox aF;

	internal Label at;

	internal Label ar;

	internal GroupBox aO;

	internal TextBox aH;

	internal TextBox ae;

	internal Label aK;

	internal Label aw;

	internal object aG;

	internal object ab;

	internal int ax;

	public Lb4r()
	{
		((Form)this).add_Load((EventHandler)s0WC);
		object obj = (aG = RuntimeHelpers.GetObjectValue(new object()));
		object obj2 = (ab = RuntimeHelpers.GetObjectValue(new object()));
		bookedIcon = RuntimeHelpers.GetObjectValue(new object());
		m6B3();
	}

	protected override void m3F5(bool m9Y2)
	{
		try
		{
			if (m9Y2 && V != null)
			{
				V.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m9Y2);
		}
	}

	private void m6B3()
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
		//IL_6a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a0d: Expected O, but got Unknown
		Xn54(new TextBox());
		o5Q4(new TextBox());
		p6MH(new Label());
		Ls19(new Label());
		j5T6(new PictureBox());
		w7GY(new PictureBox());
		Sq54(new PictureBox());
		Wp0d(new PictureBox());
		k9H0(new PictureBox());
		q9DQ(new PictureBox());
		Cz68(new PictureBox());
		y4B8(new PictureBox());
		t6C1(new PictureBox());
		f8MG(new PictureBox());
		St59(new PictureBox());
		x4PT(new PictureBox());
		Xm6t(new PictureBox());
		Cr12(new PictureBox());
		Me6t(new PictureBox());
		Nw7p(new PictureBox());
		La8d(new PictureBox());
		f3AN(new PictureBox());
		c5RC(new PictureBox());
		i8J6(new PictureBox());
		w2WD(new PictureBox());
		Gz15(new PictureBox());
		Hq29(new PictureBox());
		Qj7k(new PictureBox());
		Ct35(new PictureBox());
		Ax3o(new PictureBox());
		d0LN(new PictureBox());
		Ps70(new PictureBox());
		Jc7e(new PictureBox());
		q1SP(new PictureBox());
		f1KS(new PictureBox());
		Kb3t(new PictureBox());
		Nb34(new PictureBox());
		Td5y(new PictureBox());
		Se2w(new PictureBox());
		Bz5d(new PictureBox());
		Zg57(new PictureBox());
		w1M5(new PictureBox());
		To46(new PictureBox());
		Yc4(new PictureBox());
		So9(new PictureBox());
		Sd4(new PictureBox());
		Rj0(new PictureBox());
		Gq7(new PictureBox());
		m7Q(new PictureBox());
		s3L(new PictureBox());
		m1G(new PictureBox());
		x1K(new PictureBox());
		Kb6(new PictureBox());
		Ft5(new PictureBox());
		e5H(new PictureBox());
		Mw0(new PictureBox());
		n2H(new PictureBox());
		z2G(new PictureBox());
		Zz6(new PictureBox());
		g2S(new PictureBox());
		m9W(new PictureBox());
		b7Q(new PictureBox());
		b7K(new PictureBox());
		Ld7(new PictureBox());
		Hq8(new PictureBox());
		Yr3(new PictureBox());
		Hb9(new PictureBox());
		j8S(new PictureBox());
		e2M(new PictureBox());
		k7P(new PictureBox());
		Li4(new PictureBox());
		z9H(new PictureBox());
		Ks6(new PictureBox());
		Lp0(new PictureBox());
		Xm0(new PictureBox());
		Lp3(new PictureBox());
		r5K(new PictureBox());
		Pi5(new PictureBox());
		Jd7(new PictureBox());
		f2Y(new PictureBox());
		m6L(new PictureBox());
		Bp1(new PictureBox());
		Dd8(new PictureBox());
		Ga1(new PictureBox());
		n1Q(new PictureBox());
		Aj1(new PictureBox());
		e1T(new PictureBox());
		Ln6(new PictureBox());
		Zi3(new PictureBox());
		g5B(new PictureBox());
		Jx1(new PictureBox());
		Ae3(new PictureBox());
		n0H(new PictureBox());
		o0Q(new PictureBox());
		Se8(new PictureBox());
		t5G(new PictureBox());
		x8F(new PictureBox());
		g5X(new PictureBox());
		e7K(new PictureBox());
		Kz3(new PictureBox());
		Zd4(new PictureBox());
		x2N(new PictureBox());
		y8H(new PictureBox());
		p2E(new PictureBox());
		Ri8(new PictureBox());
		Ck1(new PictureBox());
		this.o5M(new PictureBox());
		f4P(new PictureBox());
		Aa0(new PictureBox());
		Gk1(new PictureBox());
		Lf7(new PictureBox());
		Lo4(new PictureBox());
		Pb1(new PictureBox());
		e0B(new PictureBox());
		f9P(new PictureBox());
		q2H(new PictureBox());
		Yg1(new PictureBox());
		Gw1(new PictureBox());
		Qp7(new PictureBox());
		Kd5(new PictureBox());
		s7P(new PictureBox());
		p2Q(new PictureBox());
		z6B(new PictureBox());
		r3Q(new PictureBox());
		k1K(new PictureBox());
		g0K(new PictureBox());
		Bb0(new PictureBox());
		d4C(new PictureBox());
		Pi4(new PictureBox());
		Gz7(new PictureBox());
		w2W(new PictureBox());
		e5G(new PictureBox());
		Yo6(new PictureBox());
		a4X(new PictureBox());
		Rp3(new PictureBox());
		w3Q(new PictureBox());
		Sb3(new PictureBox());
		x1N(new PictureBox());
		Zw1(new PictureBox());
		n2T(new PictureBox());
		Md4(new PictureBox());
		g0Y(new PictureBox());
		i4R(new PictureBox());
		m8T(new PictureBox());
		y2K(new PictureBox());
		Bi4(new PictureBox());
		Wk0(new PictureBox());
		Yw2(new PictureBox());
		Kw9(new PictureBox());
		k9L(new PictureBox());
		w3G(new PictureBox());
		Am2(new PictureBox());
		r0N(new PictureBox());
		Mc4(new PictureBox());
		e0X(new PictureBox());
		c3X(new PictureBox());
		Lq2(new PictureBox());
		e9X(new PictureBox());
		z4K(new PictureBox());
		Sb7(new PictureBox());
		o0Y(new PictureBox());
		n4R(new PictureBox());
		this.b3G(new PictureBox());
		Mt9(new PictureBox());
		j6F(new Label());
		Zf8(new Label());
		Jw8(new Label());
		this.b3G(new Label());
		g7L(new Label());
		x5N(new Label());
		g3S(new Label());
		w7W(new Label());
		Aw8(new Label());
		s3P(new Label());
		k2N(new Label());
		Dy3(new Label());
		Ft8(new Label());
		Tb6(new Label());
		Az3(new Label());
		w5N(new Label());
		Yn5(new Label());
		Bm0(new Label());
		r8X(new Label());
		Lj3(new Label());
		Wi5(new Label());
		i8S(new Label());
		Qb1(new Label());
		Ao2(new Label());
		Wb3(new Label());
		Br5(new Label());
		Bt6(new Label());
		Gc6(new Label());
		t2B(new Label());
		y6G(new Label());
		n1J(new Label());
		p1X(new Label());
		e7R(new Label());
		d9E(new Label());
		f4Y(new Label());
		Lr6(new Label());
		e0F(new Label());
		b1Z(new Label());
		this.o5M(new Label());
		Zk9(new Label());
		t7R(new Label());
		Nc3r(new Label());
		Ez8s(new Label());
		Pn73(new Label());
		Zt0j(new Label());
		Em13(new Label());
		i3Z4(new Label());
		e9W3(new Label());
		Rr04(new Label());
		z1EF(new Label());
		Cp1f(new GroupBox());
		p7XC(new TextBox());
		Dd91(new PictureBox());
		Mb0z(new PictureBox());
		En3p(new PictureBox());
		Cj9x(new Label());
		r6P3(new Label());
		Qc0b(new PictureBox());
		Gt6z(new PictureBox());
		t5M3(new GroupBox());
		g0HM(new Button());
		q3QY(new PictureBox());
		Rx82(new GroupBox());
		Gt7x(new Button());
		t7XR(new Button());
		Zy30(new Button());
		Qf7z(new TextBox());
		Kb14(new TextBox());
		x4T5(new Label());
		Bs42(new Label());
		g7CJ(new GroupBox());
		b7JR(new Button());
		Pr2b(new Button());
		Qt4z(new TextBox());
		Lo2j(new TextBox());
		Le74(new TextBox());
		e4QM(new TextBox());
		g7W0(new Label());
		Wx6i(new Label());
		Pn4p(new Label());
		w6F9(new Label());
		((ISupportInitialize)Kc46()).BeginInit();
		((ISupportInitialize)e6FL()).BeginInit();
		((ISupportInitialize)Bb08()).BeginInit();
		((ISupportInitialize)c3X0()).BeginInit();
		((ISupportInitialize)t3L9()).BeginInit();
		((ISupportInitialize)d5E7()).BeginInit();
		((ISupportInitialize)Et13()).BeginInit();
		((ISupportInitialize)o3TL()).BeginInit();
		((ISupportInitialize)p5T0()).BeginInit();
		((ISupportInitialize)m3A6()).BeginInit();
		((ISupportInitialize)n3MA()).BeginInit();
		((ISupportInitialize)Zo3q()).BeginInit();
		((ISupportInitialize)Fx90()).BeginInit();
		((ISupportInitialize)r7M0()).BeginInit();
		((ISupportInitialize)g8NK()).BeginInit();
		((ISupportInitialize)Rj1m()).BeginInit();
		((ISupportInitialize)Da9t()).BeginInit();
		((ISupportInitialize)Xn75()).BeginInit();
		((ISupportInitialize)Xr94()).BeginInit();
		((ISupportInitialize)Rc37()).BeginInit();
		((ISupportInitialize)z0Z5()).BeginInit();
		((ISupportInitialize)Zi13()).BeginInit();
		((ISupportInitialize)p1GB()).BeginInit();
		((ISupportInitialize)Hr6f()).BeginInit();
		((ISupportInitialize)Fn13()).BeginInit();
		((ISupportInitialize)s2FW()).BeginInit();
		((ISupportInitialize)Df39()).BeginInit();
		((ISupportInitialize)Sa83()).BeginInit();
		((ISupportInitialize)o8Z2()).BeginInit();
		((ISupportInitialize)j4E0()).BeginInit();
		((ISupportInitialize)a7M6()).BeginInit();
		((ISupportInitialize)x3H8()).BeginInit();
		((ISupportInitialize)Yn37()).BeginInit();
		((ISupportInitialize)b5N1()).BeginInit();
		((ISupportInitialize)Ym39()).BeginInit();
		((ISupportInitialize)Ci5r()).BeginInit();
		((ISupportInitialize)b3EM()).BeginInit();
		((ISupportInitialize)Mm56()).BeginInit();
		((ISupportInitialize)Go7w()).BeginInit();
		((ISupportInitialize)Xm41()).BeginInit();
		((ISupportInitialize)p0W()).BeginInit();
		((ISupportInitialize)Gp4()).BeginInit();
		((ISupportInitialize)Qo4()).BeginInit();
		((ISupportInitialize)z7Y()).BeginInit();
		((ISupportInitialize)p4C()).BeginInit();
		((ISupportInitialize)Cp7()).BeginInit();
		((ISupportInitialize)d7X()).BeginInit();
		((ISupportInitialize)s1A()).BeginInit();
		((ISupportInitialize)Qs5()).BeginInit();
		((ISupportInitialize)a1L()).BeginInit();
		((ISupportInitialize)Cw3()).BeginInit();
		((ISupportInitialize)Ab2()).BeginInit();
		((ISupportInitialize)Yo7()).BeginInit();
		((ISupportInitialize)m6Z()).BeginInit();
		((ISupportInitialize)Kf0()).BeginInit();
		((ISupportInitialize)Ha5()).BeginInit();
		((ISupportInitialize)La2()).BeginInit();
		((ISupportInitialize)Wq4()).BeginInit();
		((ISupportInitialize)Mp2()).BeginInit();
		((ISupportInitialize)j7Y()).BeginInit();
		((ISupportInitialize)Xt8()).BeginInit();
		((ISupportInitialize)Tz0()).BeginInit();
		((ISupportInitialize)g7H()).BeginInit();
		((ISupportInitialize)Qo1()).BeginInit();
		((ISupportInitialize)w6H()).BeginInit();
		((ISupportInitialize)n9Z()).BeginInit();
		((ISupportInitialize)Kp8()).BeginInit();
		((ISupportInitialize)Qd3()).BeginInit();
		((ISupportInitialize)this.Tw0()).BeginInit();
		((ISupportInitialize)As4()).BeginInit();
		((ISupportInitialize)a0Y()).BeginInit();
		((ISupportInitialize)Jq4()).BeginInit();
		((ISupportInitialize)Pt2()).BeginInit();
		((ISupportInitialize)Gb2()).BeginInit();
		((ISupportInitialize)c5E()).BeginInit();
		((ISupportInitialize)j2R()).BeginInit();
		((ISupportInitialize)o3T()).BeginInit();
		((ISupportInitialize)Kt1()).BeginInit();
		((ISupportInitialize)Fk0()).BeginInit();
		((ISupportInitialize)e3H()).BeginInit();
		((ISupportInitialize)Cr6()).BeginInit();
		((ISupportInitialize)w2J()).BeginInit();
		((ISupportInitialize)p2G()).BeginInit();
		((ISupportInitialize)s5Q()).BeginInit();
		((ISupportInitialize)Lp1()).BeginInit();
		((ISupportInitialize)Py8()).BeginInit();
		((ISupportInitialize)z4G()).BeginInit();
		((ISupportInitialize)o6L()).BeginInit();
		((ISupportInitialize)Pw3()).BeginInit();
		((ISupportInitialize)m0R()).BeginInit();
		((ISupportInitialize)k4L()).BeginInit();
		((ISupportInitialize)Zy0()).BeginInit();
		((ISupportInitialize)s5Z()).BeginInit();
		((ISupportInitialize)Kc6()).BeginInit();
		((ISupportInitialize)t6T()).BeginInit();
		((ISupportInitialize)n6S()).BeginInit();
		((ISupportInitialize)Di4()).BeginInit();
		((ISupportInitialize)Gj7()).BeginInit();
		((ISupportInitialize)c8T()).BeginInit();
		((ISupportInitialize)g8L()).BeginInit();
		((ISupportInitialize)Xe6()).BeginInit();
		((ISupportInitialize)m3N()).BeginInit();
		((ISupportInitialize)Cx4()).BeginInit();
		((ISupportInitialize)z2X()).BeginInit();
		((ISupportInitialize)Pe8()).BeginInit();
		((ISupportInitialize)Qt9()).BeginInit();
		((ISupportInitialize)e1Z()).BeginInit();
		((ISupportInitialize)this.Kc2()).BeginInit();
		((ISupportInitialize)i4J()).BeginInit();
		((ISupportInitialize)Cx5()).BeginInit();
		((ISupportInitialize)y1M()).BeginInit();
		((ISupportInitialize)z8M()).BeginInit();
		((ISupportInitialize)this.e6A()).BeginInit();
		((ISupportInitialize)k3F()).BeginInit();
		((ISupportInitialize)r4A()).BeginInit();
		((ISupportInitialize)Kc4()).BeginInit();
		((ISupportInitialize)n2R()).BeginInit();
		((ISupportInitialize)Pp5()).BeginInit();
		((ISupportInitialize)k6S()).BeginInit();
		((ISupportInitialize)d6A()).BeginInit();
		((ISupportInitialize)Zi0()).BeginInit();
		((ISupportInitialize)Kg2()).BeginInit();
		((ISupportInitialize)Dp8()).BeginInit();
		((ISupportInitialize)Qo8()).BeginInit();
		((ISupportInitialize)r3W()).BeginInit();
		((ISupportInitialize)o3K()).BeginInit();
		((ISupportInitialize)Kr4()).BeginInit();
		((ISupportInitialize)Qr3()).BeginInit();
		((ISupportInitialize)Cq4()).BeginInit();
		((ISupportInitialize)De3()).BeginInit();
		((ISupportInitialize)Wo4()).BeginInit();
		((ISupportInitialize)w8Q()).BeginInit();
		((ISupportInitialize)Yc4()).BeginInit();
		((ISupportInitialize)z9R()).BeginInit();
		((ISupportInitialize)b7R()).BeginInit();
		((ISupportInitialize)Dq4()).BeginInit();
		((ISupportInitialize)a4E()).BeginInit();
		((ISupportInitialize)Ak6()).BeginInit();
		((ISupportInitialize)this.e6A()).BeginInit();
		((ISupportInitialize)Sk4()).BeginInit();
		((ISupportInitialize)b2R()).BeginInit();
		((ISupportInitialize)Zi7()).BeginInit();
		((ISupportInitialize)b0N()).BeginInit();
		((ISupportInitialize)Bq5()).BeginInit();
		((ISupportInitialize)m0L()).BeginInit();
		((ISupportInitialize)Kq3()).BeginInit();
		((ISupportInitialize)t3X()).BeginInit();
		((ISupportInitialize)i6M()).BeginInit();
		((ISupportInitialize)w6R()).BeginInit();
		((ISupportInitialize)Sb8()).BeginInit();
		((ISupportInitialize)Ek9()).BeginInit();
		((ISupportInitialize)Yg6()).BeginInit();
		((ISupportInitialize)Ww7()).BeginInit();
		((ISupportInitialize)f4K()).BeginInit();
		((ISupportInitialize)r5C()).BeginInit();
		((ISupportInitialize)this.Kc2()).BeginInit();
		((ISupportInitialize)e8W()).BeginInit();
		((ISupportInitialize)m1Z()).BeginInit();
		((ISupportInitialize)Ki0()).BeginInit();
		((ISupportInitialize)k4P()).BeginInit();
		((Control)Zq2z()).SuspendLayout();
		((ISupportInitialize)i0WK()).BeginInit();
		((ISupportInitialize)Zn93()).BeginInit();
		((ISupportInitialize)Dq74()).BeginInit();
		((ISupportInitialize)r4AX()).BeginInit();
		((ISupportInitialize)Tk0d()).BeginInit();
		((Control)x5S6()).SuspendLayout();
		((ISupportInitialize)d8RL()).BeginInit();
		((Control)Hs78()).SuspendLayout();
		((Control)g3JD()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Yx4a()).set_Location(new Point(151, 73));
		((Control)Yx4a()).set_Name("txtProvisional");
		((Control)Yx4a()).set_Size(new Size(83, 20));
		((Control)Yx4a()).set_TabIndex(29);
		((Control)Ri1r()).set_Location(new Point(151, 42));
		((Control)Ri1r()).set_Name("txtBooked");
		((Control)Ri1r()).set_Size(new Size(83, 20));
		((Control)Ri1r()).set_TabIndex(28);
		Ai78().set_AutoSize(true);
		((Control)Ai78()).set_BackColor(Color.Transparent);
		((Control)Ai78()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ai78()).set_Location(new Point(30, 76));
		((Control)Ai78()).set_Name("Label1");
		((Control)Ai78()).set_Size(new Size(115, 13));
		((Control)Ai78()).set_TabIndex(11);
		Ai78().set_Text("Seat[s] on Reservation");
		Kb2d().set_AutoSize(true);
		((Control)Kb2d()).set_BackColor(Color.Transparent);
		((Control)Kb2d()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Kb2d()).set_Location(new Point(30, 24));
		((Control)Kb2d()).set_Name("Label2");
		((Control)Kb2d()).set_Size(new Size(80, 13));
		((Control)Kb2d()).set_TabIndex(10);
		Kb2d().set_Text("Available Seats");
		((Control)Kc46()).set_Location(new Point(372, 362));
		((Control)Kc46()).set_Name("PictureBox141");
		((Control)Kc46()).set_Size(new Size(10, 12));
		Kc46().set_SizeMode((PictureBoxSizeMode)4);
		Kc46().set_TabIndex(1219);
		Kc46().set_TabStop(false);
		((Control)e6FL()).set_Location(new Point(352, 362));
		((Control)e6FL()).set_Name("PictureBox142");
		((Control)e6FL()).set_Size(new Size(10, 12));
		e6FL().set_SizeMode((PictureBoxSizeMode)4);
		e6FL().set_TabIndex(1218);
		e6FL().set_TabStop(false);
		((Control)Bb08()).set_Location(new Point(333, 362));
		((Control)Bb08()).set_Name("PictureBox143");
		((Control)Bb08()).set_Size(new Size(10, 12));
		Bb08().set_SizeMode((PictureBoxSizeMode)4);
		Bb08().set_TabIndex(1217);
		Bb08().set_TabStop(false);
		((Control)c3X0()).set_Location(new Point(314, 362));
		((Control)c3X0()).set_Name("PictureBox144");
		((Control)c3X0()).set_Size(new Size(10, 12));
		c3X0().set_SizeMode((PictureBoxSizeMode)4);
		c3X0().set_TabIndex(1216);
		c3X0().set_TabStop(false);
		((Control)t3L9()).set_Location(new Point(296, 362));
		((Control)t3L9()).set_Name("PictureBox145");
		((Control)t3L9()).set_Size(new Size(10, 12));
		t3L9().set_SizeMode((PictureBoxSizeMode)4);
		t3L9().set_TabIndex(1215);
		t3L9().set_TabStop(false);
		((Control)d5E7()).set_Location(new Point(279, 362));
		((Control)d5E7()).set_Name("PictureBox146");
		((Control)d5E7()).set_Size(new Size(10, 12));
		d5E7().set_SizeMode((PictureBoxSizeMode)4);
		d5E7().set_TabIndex(1214);
		d5E7().set_TabStop(false);
		((Control)Et13()).set_Location(new Point(261, 362));
		((Control)Et13()).set_Name("PictureBox147");
		((Control)Et13()).set_Size(new Size(10, 12));
		Et13().set_SizeMode((PictureBoxSizeMode)4);
		Et13().set_TabIndex(1213);
		Et13().set_TabStop(false);
		((Control)o3TL()).set_Location(new Point(245, 362));
		((Control)o3TL()).set_Name("PictureBox148");
		((Control)o3TL()).set_Size(new Size(10, 12));
		o3TL().set_SizeMode((PictureBoxSizeMode)4);
		o3TL().set_TabIndex(1212);
		o3TL().set_TabStop(false);
		((Control)p5T0()).set_Location(new Point(227, 362));
		((Control)p5T0()).set_Name("PictureBox149");
		((Control)p5T0()).set_Size(new Size(10, 12));
		p5T0().set_SizeMode((PictureBoxSizeMode)4);
		p5T0().set_TabIndex(1211);
		p5T0().set_TabStop(false);
		((Control)m3A6()).set_Location(new Point(208, 362));
		((Control)m3A6()).set_Name("PictureBox150");
		((Control)m3A6()).set_Size(new Size(10, 12));
		m3A6().set_SizeMode((PictureBoxSizeMode)4);
		m3A6().set_TabIndex(1210);
		m3A6().set_TabStop(false);
		((Control)n3MA()).set_Location(new Point(190, 362));
		((Control)n3MA()).set_Name("PictureBox151");
		((Control)n3MA()).set_Size(new Size(10, 12));
		n3MA().set_SizeMode((PictureBoxSizeMode)4);
		n3MA().set_TabIndex(1209);
		n3MA().set_TabStop(false);
		((Control)Zo3q()).set_Location(new Point(174, 362));
		((Control)Zo3q()).set_Name("PictureBox152");
		((Control)Zo3q()).set_Size(new Size(10, 12));
		Zo3q().set_SizeMode((PictureBoxSizeMode)4);
		Zo3q().set_TabIndex(1208);
		Zo3q().set_TabStop(false);
		((Control)Fx90()).set_Location(new Point(158, 362));
		((Control)Fx90()).set_Name("PictureBox153");
		((Control)Fx90()).set_Size(new Size(10, 12));
		Fx90().set_SizeMode((PictureBoxSizeMode)4);
		Fx90().set_TabIndex(1207);
		Fx90().set_TabStop(false);
		((Control)r7M0()).set_Location(new Point(142, 362));
		((Control)r7M0()).set_Name("PictureBox154");
		((Control)r7M0()).set_Size(new Size(10, 12));
		r7M0().set_SizeMode((PictureBoxSizeMode)4);
		r7M0().set_TabIndex(1206);
		r7M0().set_TabStop(false);
		((Control)g8NK()).set_Location(new Point(126, 362));
		((Control)g8NK()).set_Name("PictureBox155");
		((Control)g8NK()).set_Size(new Size(10, 12));
		g8NK().set_SizeMode((PictureBoxSizeMode)4);
		g8NK().set_TabIndex(1205);
		g8NK().set_TabStop(false);
		((Control)Rj1m()).set_Location(new Point(110, 362));
		((Control)Rj1m()).set_Name("PictureBox156");
		((Control)Rj1m()).set_Size(new Size(10, 12));
		Rj1m().set_SizeMode((PictureBoxSizeMode)4);
		Rj1m().set_TabIndex(1204);
		Rj1m().set_TabStop(false);
		((Control)Da9t()).set_Location(new Point(94, 362));
		((Control)Da9t()).set_Name("PictureBox157");
		((Control)Da9t()).set_Size(new Size(10, 12));
		Da9t().set_SizeMode((PictureBoxSizeMode)4);
		Da9t().set_TabIndex(1203);
		Da9t().set_TabStop(false);
		((Control)Xn75()).set_Location(new Point(78, 362));
		((Control)Xn75()).set_Name("PictureBox158");
		((Control)Xn75()).set_Size(new Size(10, 12));
		Xn75().set_SizeMode((PictureBoxSizeMode)4);
		Xn75().set_TabIndex(1202);
		Xn75().set_TabStop(false);
		((Control)Xr94()).set_Location(new Point(62, 362));
		((Control)Xr94()).set_Name("PictureBox159");
		((Control)Xr94()).set_Size(new Size(10, 12));
		Xr94().set_SizeMode((PictureBoxSizeMode)4);
		Xr94().set_TabIndex(1201);
		Xr94().set_TabStop(false);
		((Control)Rc37()).set_Location(new Point(48, 362));
		((Control)Rc37()).set_Name("PictureBox160");
		((Control)Rc37()).set_Size(new Size(10, 12));
		Rc37().set_SizeMode((PictureBoxSizeMode)4);
		Rc37().set_TabIndex(1200);
		Rc37().set_TabStop(false);
		((Control)z0Z5()).set_Location(new Point(372, 340));
		((Control)z0Z5()).set_Name("PictureBox121");
		((Control)z0Z5()).set_Size(new Size(10, 12));
		z0Z5().set_SizeMode((PictureBoxSizeMode)4);
		z0Z5().set_TabIndex(1199);
		z0Z5().set_TabStop(false);
		((Control)Zi13()).set_Location(new Point(352, 340));
		((Control)Zi13()).set_Name("PictureBox122");
		((Control)Zi13()).set_Size(new Size(10, 12));
		Zi13().set_SizeMode((PictureBoxSizeMode)4);
		Zi13().set_TabIndex(1198);
		Zi13().set_TabStop(false);
		((Control)p1GB()).set_Location(new Point(333, 340));
		((Control)p1GB()).set_Name("PictureBox123");
		((Control)p1GB()).set_Size(new Size(10, 12));
		p1GB().set_SizeMode((PictureBoxSizeMode)4);
		p1GB().set_TabIndex(1197);
		p1GB().set_TabStop(false);
		((Control)Hr6f()).set_Location(new Point(314, 340));
		((Control)Hr6f()).set_Name("PictureBox124");
		((Control)Hr6f()).set_Size(new Size(10, 12));
		Hr6f().set_SizeMode((PictureBoxSizeMode)4);
		Hr6f().set_TabIndex(1196);
		Hr6f().set_TabStop(false);
		((Control)Fn13()).set_Location(new Point(296, 340));
		((Control)Fn13()).set_Name("PictureBox125");
		((Control)Fn13()).set_Size(new Size(10, 12));
		Fn13().set_SizeMode((PictureBoxSizeMode)4);
		Fn13().set_TabIndex(1195);
		Fn13().set_TabStop(false);
		((Control)s2FW()).set_Location(new Point(279, 340));
		((Control)s2FW()).set_Name("PictureBox126");
		((Control)s2FW()).set_Size(new Size(10, 12));
		s2FW().set_SizeMode((PictureBoxSizeMode)4);
		s2FW().set_TabIndex(1194);
		s2FW().set_TabStop(false);
		((Control)Df39()).set_Location(new Point(261, 340));
		((Control)Df39()).set_Name("PictureBox127");
		((Control)Df39()).set_Size(new Size(10, 12));
		Df39().set_SizeMode((PictureBoxSizeMode)4);
		Df39().set_TabIndex(1193);
		Df39().set_TabStop(false);
		((Control)Sa83()).set_Location(new Point(245, 340));
		((Control)Sa83()).set_Name("PictureBox128");
		((Control)Sa83()).set_Size(new Size(10, 12));
		Sa83().set_SizeMode((PictureBoxSizeMode)4);
		Sa83().set_TabIndex(1192);
		Sa83().set_TabStop(false);
		((Control)o8Z2()).set_Location(new Point(227, 340));
		((Control)o8Z2()).set_Name("PictureBox129");
		((Control)o8Z2()).set_Size(new Size(10, 12));
		o8Z2().set_SizeMode((PictureBoxSizeMode)4);
		o8Z2().set_TabIndex(1191);
		o8Z2().set_TabStop(false);
		((Control)j4E0()).set_Location(new Point(208, 340));
		((Control)j4E0()).set_Name("PictureBox130");
		((Control)j4E0()).set_Size(new Size(10, 12));
		j4E0().set_SizeMode((PictureBoxSizeMode)4);
		j4E0().set_TabIndex(1190);
		j4E0().set_TabStop(false);
		((Control)a7M6()).set_Location(new Point(190, 340));
		((Control)a7M6()).set_Name("PictureBox131");
		((Control)a7M6()).set_Size(new Size(10, 12));
		a7M6().set_SizeMode((PictureBoxSizeMode)4);
		a7M6().set_TabIndex(1189);
		a7M6().set_TabStop(false);
		((Control)x3H8()).set_Location(new Point(174, 340));
		((Control)x3H8()).set_Name("PictureBox132");
		((Control)x3H8()).set_Size(new Size(10, 12));
		x3H8().set_SizeMode((PictureBoxSizeMode)4);
		x3H8().set_TabIndex(1188);
		x3H8().set_TabStop(false);
		((Control)Yn37()).set_Location(new Point(158, 340));
		((Control)Yn37()).set_Name("PictureBox133");
		((Control)Yn37()).set_Size(new Size(10, 12));
		Yn37().set_SizeMode((PictureBoxSizeMode)4);
		Yn37().set_TabIndex(1187);
		Yn37().set_TabStop(false);
		((Control)b5N1()).set_Location(new Point(142, 340));
		((Control)b5N1()).set_Name("PictureBox134");
		((Control)b5N1()).set_Size(new Size(10, 12));
		b5N1().set_SizeMode((PictureBoxSizeMode)4);
		b5N1().set_TabIndex(1186);
		b5N1().set_TabStop(false);
		((Control)Ym39()).set_Location(new Point(126, 340));
		((Control)Ym39()).set_Name("PictureBox135");
		((Control)Ym39()).set_Size(new Size(10, 12));
		Ym39().set_SizeMode((PictureBoxSizeMode)4);
		Ym39().set_TabIndex(1185);
		Ym39().set_TabStop(false);
		((Control)Ci5r()).set_Location(new Point(110, 340));
		((Control)Ci5r()).set_Name("PictureBox136");
		((Control)Ci5r()).set_Size(new Size(10, 12));
		Ci5r().set_SizeMode((PictureBoxSizeMode)4);
		Ci5r().set_TabIndex(1184);
		Ci5r().set_TabStop(false);
		((Control)b3EM()).set_Location(new Point(94, 340));
		((Control)b3EM()).set_Name("PictureBox137");
		((Control)b3EM()).set_Size(new Size(10, 12));
		b3EM().set_SizeMode((PictureBoxSizeMode)4);
		b3EM().set_TabIndex(1183);
		b3EM().set_TabStop(false);
		((Control)Mm56()).set_Location(new Point(78, 340));
		((Control)Mm56()).set_Name("PictureBox138");
		((Control)Mm56()).set_Size(new Size(10, 12));
		Mm56().set_SizeMode((PictureBoxSizeMode)4);
		Mm56().set_TabIndex(1182);
		Mm56().set_TabStop(false);
		((Control)Go7w()).set_Location(new Point(62, 340));
		((Control)Go7w()).set_Name("PictureBox139");
		((Control)Go7w()).set_Size(new Size(10, 12));
		Go7w().set_SizeMode((PictureBoxSizeMode)4);
		Go7w().set_TabIndex(1181);
		Go7w().set_TabStop(false);
		((Control)Xm41()).set_Location(new Point(48, 340));
		((Control)Xm41()).set_Name("PictureBox140");
		((Control)Xm41()).set_Size(new Size(10, 12));
		Xm41().set_SizeMode((PictureBoxSizeMode)4);
		Xm41().set_TabIndex(1180);
		Xm41().set_TabStop(false);
		((Control)p0W()).set_Location(new Point(372, 318));
		((Control)p0W()).set_Name("PictureBox101");
		((Control)p0W()).set_Size(new Size(10, 12));
		p0W().set_SizeMode((PictureBoxSizeMode)4);
		p0W().set_TabIndex(1179);
		p0W().set_TabStop(false);
		((Control)Gp4()).set_Location(new Point(352, 318));
		((Control)Gp4()).set_Name("PictureBox102");
		((Control)Gp4()).set_Size(new Size(10, 12));
		Gp4().set_SizeMode((PictureBoxSizeMode)4);
		Gp4().set_TabIndex(1178);
		Gp4().set_TabStop(false);
		((Control)Qo4()).set_Location(new Point(333, 318));
		((Control)Qo4()).set_Name("PictureBox103");
		((Control)Qo4()).set_Size(new Size(10, 12));
		Qo4().set_SizeMode((PictureBoxSizeMode)4);
		Qo4().set_TabIndex(1177);
		Qo4().set_TabStop(false);
		((Control)z7Y()).set_Location(new Point(314, 318));
		((Control)z7Y()).set_Name("PictureBox104");
		((Control)z7Y()).set_Size(new Size(10, 12));
		z7Y().set_SizeMode((PictureBoxSizeMode)4);
		z7Y().set_TabIndex(1176);
		z7Y().set_TabStop(false);
		((Control)p4C()).set_Location(new Point(296, 318));
		((Control)p4C()).set_Name("PictureBox105");
		((Control)p4C()).set_Size(new Size(10, 12));
		p4C().set_SizeMode((PictureBoxSizeMode)4);
		p4C().set_TabIndex(1175);
		p4C().set_TabStop(false);
		((Control)Cp7()).set_Location(new Point(279, 318));
		((Control)Cp7()).set_Name("PictureBox106");
		((Control)Cp7()).set_Size(new Size(10, 12));
		Cp7().set_SizeMode((PictureBoxSizeMode)4);
		Cp7().set_TabIndex(1174);
		Cp7().set_TabStop(false);
		((Control)d7X()).set_Location(new Point(261, 318));
		((Control)d7X()).set_Name("PictureBox107");
		((Control)d7X()).set_Size(new Size(10, 12));
		d7X().set_SizeMode((PictureBoxSizeMode)4);
		d7X().set_TabIndex(1173);
		d7X().set_TabStop(false);
		((Control)s1A()).set_Location(new Point(245, 318));
		((Control)s1A()).set_Name("PictureBox108");
		((Control)s1A()).set_Size(new Size(10, 12));
		s1A().set_SizeMode((PictureBoxSizeMode)4);
		s1A().set_TabIndex(1172);
		s1A().set_TabStop(false);
		((Control)Qs5()).set_Location(new Point(227, 318));
		((Control)Qs5()).set_Name("PictureBox109");
		((Control)Qs5()).set_Size(new Size(10, 12));
		Qs5().set_SizeMode((PictureBoxSizeMode)4);
		Qs5().set_TabIndex(1171);
		Qs5().set_TabStop(false);
		((Control)a1L()).set_Location(new Point(208, 318));
		((Control)a1L()).set_Name("PictureBox110");
		((Control)a1L()).set_Size(new Size(10, 12));
		a1L().set_SizeMode((PictureBoxSizeMode)4);
		a1L().set_TabIndex(1170);
		a1L().set_TabStop(false);
		((Control)Cw3()).set_Location(new Point(190, 318));
		((Control)Cw3()).set_Name("PictureBox111");
		((Control)Cw3()).set_Size(new Size(10, 12));
		Cw3().set_SizeMode((PictureBoxSizeMode)4);
		Cw3().set_TabIndex(1169);
		Cw3().set_TabStop(false);
		((Control)Ab2()).set_Location(new Point(174, 318));
		((Control)Ab2()).set_Name("PictureBox112");
		((Control)Ab2()).set_Size(new Size(10, 12));
		Ab2().set_SizeMode((PictureBoxSizeMode)4);
		Ab2().set_TabIndex(1168);
		Ab2().set_TabStop(false);
		((Control)Yo7()).set_Location(new Point(158, 318));
		((Control)Yo7()).set_Name("PictureBox113");
		((Control)Yo7()).set_Size(new Size(10, 12));
		Yo7().set_SizeMode((PictureBoxSizeMode)4);
		Yo7().set_TabIndex(1167);
		Yo7().set_TabStop(false);
		((Control)m6Z()).set_Location(new Point(142, 318));
		((Control)m6Z()).set_Name("PictureBox114");
		((Control)m6Z()).set_Size(new Size(10, 12));
		m6Z().set_SizeMode((PictureBoxSizeMode)4);
		m6Z().set_TabIndex(1166);
		m6Z().set_TabStop(false);
		((Control)Kf0()).set_Location(new Point(126, 318));
		((Control)Kf0()).set_Name("PictureBox115");
		((Control)Kf0()).set_Size(new Size(10, 12));
		Kf0().set_SizeMode((PictureBoxSizeMode)4);
		Kf0().set_TabIndex(1165);
		Kf0().set_TabStop(false);
		((Control)Ha5()).set_Location(new Point(110, 318));
		((Control)Ha5()).set_Name("PictureBox116");
		((Control)Ha5()).set_Size(new Size(10, 12));
		Ha5().set_SizeMode((PictureBoxSizeMode)4);
		Ha5().set_TabIndex(1164);
		Ha5().set_TabStop(false);
		((Control)La2()).set_Location(new Point(94, 318));
		((Control)La2()).set_Name("PictureBox117");
		((Control)La2()).set_Size(new Size(10, 12));
		La2().set_SizeMode((PictureBoxSizeMode)4);
		La2().set_TabIndex(1163);
		La2().set_TabStop(false);
		((Control)Wq4()).set_Location(new Point(78, 318));
		((Control)Wq4()).set_Name("PictureBox118");
		((Control)Wq4()).set_Size(new Size(10, 12));
		Wq4().set_SizeMode((PictureBoxSizeMode)4);
		Wq4().set_TabIndex(1162);
		Wq4().set_TabStop(false);
		((Control)Mp2()).set_Location(new Point(62, 318));
		((Control)Mp2()).set_Name("PictureBox119");
		((Control)Mp2()).set_Size(new Size(10, 12));
		Mp2().set_SizeMode((PictureBoxSizeMode)4);
		Mp2().set_TabIndex(1161);
		Mp2().set_TabStop(false);
		((Control)j7Y()).set_Location(new Point(48, 318));
		((Control)j7Y()).set_Name("PictureBox120");
		((Control)j7Y()).set_Size(new Size(10, 12));
		j7Y().set_SizeMode((PictureBoxSizeMode)4);
		j7Y().set_TabIndex(1160);
		j7Y().set_TabStop(false);
		((Control)Xt8()).set_Location(new Point(372, 299));
		((Control)Xt8()).set_Name("PictureBox81");
		((Control)Xt8()).set_Size(new Size(10, 12));
		Xt8().set_SizeMode((PictureBoxSizeMode)4);
		Xt8().set_TabIndex(1159);
		Xt8().set_TabStop(false);
		((Control)Tz0()).set_Location(new Point(352, 299));
		((Control)Tz0()).set_Name("PictureBox82");
		((Control)Tz0()).set_Size(new Size(10, 12));
		Tz0().set_SizeMode((PictureBoxSizeMode)4);
		Tz0().set_TabIndex(1158);
		Tz0().set_TabStop(false);
		((Control)g7H()).set_Location(new Point(333, 299));
		((Control)g7H()).set_Name("PictureBox83");
		((Control)g7H()).set_Size(new Size(10, 12));
		g7H().set_SizeMode((PictureBoxSizeMode)4);
		g7H().set_TabIndex(1157);
		g7H().set_TabStop(false);
		((Control)Qo1()).set_Location(new Point(314, 299));
		((Control)Qo1()).set_Name("PictureBox84");
		((Control)Qo1()).set_Size(new Size(10, 12));
		Qo1().set_SizeMode((PictureBoxSizeMode)4);
		Qo1().set_TabIndex(1156);
		Qo1().set_TabStop(false);
		((Control)w6H()).set_Location(new Point(296, 299));
		((Control)w6H()).set_Name("PictureBox85");
		((Control)w6H()).set_Size(new Size(10, 12));
		w6H().set_SizeMode((PictureBoxSizeMode)4);
		w6H().set_TabIndex(1155);
		w6H().set_TabStop(false);
		((Control)n9Z()).set_Location(new Point(279, 299));
		((Control)n9Z()).set_Name("PictureBox86");
		((Control)n9Z()).set_Size(new Size(10, 12));
		n9Z().set_SizeMode((PictureBoxSizeMode)4);
		n9Z().set_TabIndex(1154);
		n9Z().set_TabStop(false);
		((Control)Kp8()).set_Location(new Point(261, 299));
		((Control)Kp8()).set_Name("PictureBox87");
		((Control)Kp8()).set_Size(new Size(10, 12));
		Kp8().set_SizeMode((PictureBoxSizeMode)4);
		Kp8().set_TabIndex(1153);
		Kp8().set_TabStop(false);
		((Control)Qd3()).set_Location(new Point(245, 299));
		((Control)Qd3()).set_Name("PictureBox88");
		((Control)Qd3()).set_Size(new Size(10, 12));
		Qd3().set_SizeMode((PictureBoxSizeMode)4);
		Qd3().set_TabIndex(1152);
		Qd3().set_TabStop(false);
		((Control)this.Tw0()).set_Location(new Point(227, 299));
		((Control)this.Tw0()).set_Name("PictureBox89");
		((Control)this.Tw0()).set_Size(new Size(10, 12));
		this.Tw0().set_SizeMode((PictureBoxSizeMode)4);
		this.Tw0().set_TabIndex(1151);
		this.Tw0().set_TabStop(false);
		((Control)As4()).set_Location(new Point(208, 299));
		((Control)As4()).set_Name("PictureBox90");
		((Control)As4()).set_Size(new Size(10, 12));
		As4().set_SizeMode((PictureBoxSizeMode)4);
		As4().set_TabIndex(1150);
		As4().set_TabStop(false);
		((Control)a0Y()).set_Location(new Point(190, 299));
		((Control)a0Y()).set_Name("PictureBox91");
		((Control)a0Y()).set_Size(new Size(10, 12));
		a0Y().set_SizeMode((PictureBoxSizeMode)4);
		a0Y().set_TabIndex(1149);
		a0Y().set_TabStop(false);
		((Control)Jq4()).set_Location(new Point(174, 299));
		((Control)Jq4()).set_Name("PictureBox92");
		((Control)Jq4()).set_Size(new Size(10, 12));
		Jq4().set_SizeMode((PictureBoxSizeMode)4);
		Jq4().set_TabIndex(1148);
		Jq4().set_TabStop(false);
		((Control)Pt2()).set_Location(new Point(158, 299));
		((Control)Pt2()).set_Name("PictureBox93");
		((Control)Pt2()).set_Size(new Size(10, 12));
		Pt2().set_SizeMode((PictureBoxSizeMode)4);
		Pt2().set_TabIndex(1147);
		Pt2().set_TabStop(false);
		((Control)Gb2()).set_Location(new Point(142, 299));
		((Control)Gb2()).set_Name("PictureBox94");
		((Control)Gb2()).set_Size(new Size(10, 12));
		Gb2().set_SizeMode((PictureBoxSizeMode)4);
		Gb2().set_TabIndex(1146);
		Gb2().set_TabStop(false);
		((Control)c5E()).set_Location(new Point(126, 299));
		((Control)c5E()).set_Name("PictureBox95");
		((Control)c5E()).set_Size(new Size(10, 12));
		c5E().set_SizeMode((PictureBoxSizeMode)4);
		c5E().set_TabIndex(1145);
		c5E().set_TabStop(false);
		((Control)j2R()).set_Location(new Point(110, 299));
		((Control)j2R()).set_Name("PictureBox96");
		((Control)j2R()).set_Size(new Size(10, 12));
		j2R().set_SizeMode((PictureBoxSizeMode)4);
		j2R().set_TabIndex(1144);
		j2R().set_TabStop(false);
		((Control)o3T()).set_Location(new Point(94, 299));
		((Control)o3T()).set_Name("PictureBox97");
		((Control)o3T()).set_Size(new Size(10, 12));
		o3T().set_SizeMode((PictureBoxSizeMode)4);
		o3T().set_TabIndex(1143);
		o3T().set_TabStop(false);
		((Control)Kt1()).set_Location(new Point(78, 299));
		((Control)Kt1()).set_Name("PictureBox98");
		((Control)Kt1()).set_Size(new Size(10, 12));
		Kt1().set_SizeMode((PictureBoxSizeMode)4);
		Kt1().set_TabIndex(1142);
		Kt1().set_TabStop(false);
		((Control)Fk0()).set_Location(new Point(62, 299));
		((Control)Fk0()).set_Name("PictureBox99");
		((Control)Fk0()).set_Size(new Size(10, 12));
		Fk0().set_SizeMode((PictureBoxSizeMode)4);
		Fk0().set_TabIndex(1141);
		Fk0().set_TabStop(false);
		((Control)e3H()).set_Location(new Point(48, 299));
		((Control)e3H()).set_Name("PictureBox100");
		((Control)e3H()).set_Size(new Size(10, 12));
		e3H().set_SizeMode((PictureBoxSizeMode)4);
		e3H().set_TabIndex(1140);
		e3H().set_TabStop(false);
		((Control)Cr6()).set_Location(new Point(372, 187));
		((Control)Cr6()).set_Name("PictureBox61");
		((Control)Cr6()).set_Size(new Size(10, 10));
		Cr6().set_SizeMode((PictureBoxSizeMode)4);
		Cr6().set_TabIndex(1139);
		Cr6().set_TabStop(false);
		((Control)w2J()).set_Location(new Point(352, 187));
		((Control)w2J()).set_Name("PictureBox62");
		((Control)w2J()).set_Size(new Size(10, 10));
		w2J().set_SizeMode((PictureBoxSizeMode)4);
		w2J().set_TabIndex(1138);
		w2J().set_TabStop(false);
		((Control)p2G()).set_Location(new Point(333, 187));
		((Control)p2G()).set_Name("PictureBox63");
		((Control)p2G()).set_Size(new Size(10, 10));
		p2G().set_SizeMode((PictureBoxSizeMode)4);
		p2G().set_TabIndex(1137);
		p2G().set_TabStop(false);
		((Control)s5Q()).set_Location(new Point(314, 187));
		((Control)s5Q()).set_Name("PictureBox64");
		((Control)s5Q()).set_Size(new Size(10, 10));
		s5Q().set_SizeMode((PictureBoxSizeMode)4);
		s5Q().set_TabIndex(1136);
		s5Q().set_TabStop(false);
		((Control)Lp1()).set_Location(new Point(296, 187));
		((Control)Lp1()).set_Name("PictureBox65");
		((Control)Lp1()).set_Size(new Size(10, 10));
		Lp1().set_SizeMode((PictureBoxSizeMode)4);
		Lp1().set_TabIndex(1135);
		Lp1().set_TabStop(false);
		((Control)Py8()).set_Location(new Point(279, 187));
		((Control)Py8()).set_Name("PictureBox66");
		((Control)Py8()).set_Size(new Size(10, 10));
		Py8().set_SizeMode((PictureBoxSizeMode)4);
		Py8().set_TabIndex(1134);
		Py8().set_TabStop(false);
		((Control)z4G()).set_Location(new Point(261, 187));
		((Control)z4G()).set_Name("PictureBox67");
		((Control)z4G()).set_Size(new Size(10, 10));
		z4G().set_SizeMode((PictureBoxSizeMode)4);
		z4G().set_TabIndex(1133);
		z4G().set_TabStop(false);
		((Control)o6L()).set_Location(new Point(245, 187));
		((Control)o6L()).set_Name("PictureBox68");
		((Control)o6L()).set_Size(new Size(10, 10));
		o6L().set_SizeMode((PictureBoxSizeMode)4);
		o6L().set_TabIndex(1132);
		o6L().set_TabStop(false);
		((Control)Pw3()).set_Location(new Point(227, 187));
		((Control)Pw3()).set_Name("PictureBox69");
		((Control)Pw3()).set_Size(new Size(10, 10));
		Pw3().set_SizeMode((PictureBoxSizeMode)4);
		Pw3().set_TabIndex(1131);
		Pw3().set_TabStop(false);
		((Control)m0R()).set_Location(new Point(208, 187));
		((Control)m0R()).set_Name("PictureBox70");
		((Control)m0R()).set_Size(new Size(10, 10));
		m0R().set_SizeMode((PictureBoxSizeMode)4);
		m0R().set_TabIndex(1130);
		m0R().set_TabStop(false);
		((Control)k4L()).set_Location(new Point(190, 187));
		((Control)k4L()).set_Name("PictureBox71");
		((Control)k4L()).set_Size(new Size(10, 10));
		k4L().set_SizeMode((PictureBoxSizeMode)4);
		k4L().set_TabIndex(1129);
		k4L().set_TabStop(false);
		((Control)Zy0()).set_Location(new Point(174, 187));
		((Control)Zy0()).set_Name("PictureBox72");
		((Control)Zy0()).set_Size(new Size(10, 10));
		Zy0().set_SizeMode((PictureBoxSizeMode)4);
		Zy0().set_TabIndex(1128);
		Zy0().set_TabStop(false);
		((Control)s5Z()).set_Location(new Point(158, 187));
		((Control)s5Z()).set_Name("PictureBox73");
		((Control)s5Z()).set_Size(new Size(10, 10));
		s5Z().set_SizeMode((PictureBoxSizeMode)4);
		s5Z().set_TabIndex(1127);
		s5Z().set_TabStop(false);
		((Control)Kc6()).set_Location(new Point(142, 187));
		((Control)Kc6()).set_Name("PictureBox74");
		((Control)Kc6()).set_Size(new Size(10, 10));
		Kc6().set_SizeMode((PictureBoxSizeMode)4);
		Kc6().set_TabIndex(1126);
		Kc6().set_TabStop(false);
		((Control)t6T()).set_Location(new Point(126, 187));
		((Control)t6T()).set_Name("PictureBox75");
		((Control)t6T()).set_Size(new Size(10, 10));
		t6T().set_SizeMode((PictureBoxSizeMode)4);
		t6T().set_TabIndex(1125);
		t6T().set_TabStop(false);
		((Control)n6S()).set_Location(new Point(110, 187));
		((Control)n6S()).set_Name("PictureBox76");
		((Control)n6S()).set_Size(new Size(10, 10));
		n6S().set_SizeMode((PictureBoxSizeMode)4);
		n6S().set_TabIndex(1124);
		n6S().set_TabStop(false);
		((Control)Di4()).set_Location(new Point(94, 187));
		((Control)Di4()).set_Name("PictureBox77");
		((Control)Di4()).set_Size(new Size(10, 10));
		Di4().set_SizeMode((PictureBoxSizeMode)4);
		Di4().set_TabIndex(1123);
		Di4().set_TabStop(false);
		((Control)Gj7()).set_Location(new Point(78, 187));
		((Control)Gj7()).set_Name("PictureBox78");
		((Control)Gj7()).set_Size(new Size(10, 10));
		Gj7().set_SizeMode((PictureBoxSizeMode)4);
		Gj7().set_TabIndex(1122);
		Gj7().set_TabStop(false);
		((Control)c8T()).set_Location(new Point(62, 187));
		((Control)c8T()).set_Name("PictureBox79");
		((Control)c8T()).set_Size(new Size(10, 10));
		c8T().set_SizeMode((PictureBoxSizeMode)4);
		c8T().set_TabIndex(1121);
		c8T().set_TabStop(false);
		((Control)g8L()).set_Location(new Point(48, 187));
		((Control)g8L()).set_Name("PictureBox80");
		((Control)g8L()).set_Size(new Size(10, 10));
		g8L().set_SizeMode((PictureBoxSizeMode)4);
		g8L().set_TabIndex(1120);
		g8L().set_TabStop(false);
		((Control)Xe6()).set_Location(new Point(372, 165));
		((Control)Xe6()).set_Name("PictureBox41");
		((Control)Xe6()).set_Size(new Size(10, 10));
		Xe6().set_SizeMode((PictureBoxSizeMode)4);
		Xe6().set_TabIndex(1119);
		Xe6().set_TabStop(false);
		((Control)m3N()).set_Location(new Point(352, 165));
		((Control)m3N()).set_Name("PictureBox42");
		((Control)m3N()).set_Size(new Size(10, 10));
		m3N().set_SizeMode((PictureBoxSizeMode)4);
		m3N().set_TabIndex(1118);
		m3N().set_TabStop(false);
		((Control)Cx4()).set_Location(new Point(333, 165));
		((Control)Cx4()).set_Name("PictureBox43");
		((Control)Cx4()).set_Size(new Size(10, 10));
		Cx4().set_SizeMode((PictureBoxSizeMode)4);
		Cx4().set_TabIndex(1117);
		Cx4().set_TabStop(false);
		((Control)z2X()).set_Location(new Point(314, 165));
		((Control)z2X()).set_Name("PictureBox44");
		((Control)z2X()).set_Size(new Size(10, 10));
		z2X().set_SizeMode((PictureBoxSizeMode)4);
		z2X().set_TabIndex(1116);
		z2X().set_TabStop(false);
		((Control)Pe8()).set_Location(new Point(296, 165));
		((Control)Pe8()).set_Name("PictureBox45");
		((Control)Pe8()).set_Size(new Size(10, 10));
		Pe8().set_SizeMode((PictureBoxSizeMode)4);
		Pe8().set_TabIndex(1115);
		Pe8().set_TabStop(false);
		((Control)Qt9()).set_Location(new Point(279, 165));
		((Control)Qt9()).set_Name("PictureBox46");
		((Control)Qt9()).set_Size(new Size(10, 10));
		Qt9().set_SizeMode((PictureBoxSizeMode)4);
		Qt9().set_TabIndex(1114);
		Qt9().set_TabStop(false);
		((Control)e1Z()).set_Location(new Point(261, 165));
		((Control)e1Z()).set_Name("PictureBox47");
		((Control)e1Z()).set_Size(new Size(10, 10));
		e1Z().set_SizeMode((PictureBoxSizeMode)4);
		e1Z().set_TabIndex(1113);
		e1Z().set_TabStop(false);
		((Control)this.Kc2()).set_Location(new Point(245, 165));
		((Control)this.Kc2()).set_Name("PictureBox48");
		((Control)this.Kc2()).set_Size(new Size(10, 10));
		this.Kc2().set_SizeMode((PictureBoxSizeMode)4);
		this.Kc2().set_TabIndex(1112);
		this.Kc2().set_TabStop(false);
		((Control)i4J()).set_Location(new Point(227, 165));
		((Control)i4J()).set_Name("PictureBox49");
		((Control)i4J()).set_Size(new Size(10, 10));
		i4J().set_SizeMode((PictureBoxSizeMode)4);
		i4J().set_TabIndex(1111);
		i4J().set_TabStop(false);
		((Control)Cx5()).set_Location(new Point(208, 165));
		((Control)Cx5()).set_Name("PictureBox50");
		((Control)Cx5()).set_Size(new Size(10, 10));
		Cx5().set_SizeMode((PictureBoxSizeMode)4);
		Cx5().set_TabIndex(1110);
		Cx5().set_TabStop(false);
		((Control)y1M()).set_Location(new Point(190, 165));
		((Control)y1M()).set_Name("PictureBox51");
		((Control)y1M()).set_Size(new Size(10, 10));
		y1M().set_SizeMode((PictureBoxSizeMode)4);
		y1M().set_TabIndex(1109);
		y1M().set_TabStop(false);
		((Control)z8M()).set_Location(new Point(174, 165));
		((Control)z8M()).set_Name("PictureBox52");
		((Control)z8M()).set_Size(new Size(10, 10));
		z8M().set_SizeMode((PictureBoxSizeMode)4);
		z8M().set_TabIndex(1108);
		z8M().set_TabStop(false);
		((Control)this.e6A()).set_Location(new Point(158, 165));
		((Control)this.e6A()).set_Name("PictureBox53");
		((Control)this.e6A()).set_Size(new Size(10, 10));
		this.e6A().set_SizeMode((PictureBoxSizeMode)4);
		this.e6A().set_TabIndex(1107);
		this.e6A().set_TabStop(false);
		((Control)k3F()).set_Location(new Point(142, 165));
		((Control)k3F()).set_Name("PictureBox54");
		((Control)k3F()).set_Size(new Size(10, 10));
		k3F().set_SizeMode((PictureBoxSizeMode)4);
		k3F().set_TabIndex(1106);
		k3F().set_TabStop(false);
		((Control)r4A()).set_Location(new Point(126, 165));
		((Control)r4A()).set_Name("PictureBox55");
		((Control)r4A()).set_Size(new Size(10, 10));
		r4A().set_SizeMode((PictureBoxSizeMode)4);
		r4A().set_TabIndex(1105);
		r4A().set_TabStop(false);
		((Control)Kc4()).set_Location(new Point(110, 165));
		((Control)Kc4()).set_Name("PictureBox56");
		((Control)Kc4()).set_Size(new Size(10, 10));
		Kc4().set_SizeMode((PictureBoxSizeMode)4);
		Kc4().set_TabIndex(1104);
		Kc4().set_TabStop(false);
		((Control)n2R()).set_Location(new Point(94, 165));
		((Control)n2R()).set_Name("PictureBox57");
		((Control)n2R()).set_Size(new Size(10, 10));
		n2R().set_SizeMode((PictureBoxSizeMode)4);
		n2R().set_TabIndex(1103);
		n2R().set_TabStop(false);
		((Control)Pp5()).set_Location(new Point(78, 165));
		((Control)Pp5()).set_Name("PictureBox58");
		((Control)Pp5()).set_Size(new Size(10, 10));
		Pp5().set_SizeMode((PictureBoxSizeMode)4);
		Pp5().set_TabIndex(1102);
		Pp5().set_TabStop(false);
		((Control)k6S()).set_Location(new Point(62, 165));
		((Control)k6S()).set_Name("PictureBox59");
		((Control)k6S()).set_Size(new Size(10, 10));
		k6S().set_SizeMode((PictureBoxSizeMode)4);
		k6S().set_TabIndex(1101);
		k6S().set_TabStop(false);
		((Control)d6A()).set_Location(new Point(48, 165));
		((Control)d6A()).set_Name("PictureBox60");
		((Control)d6A()).set_Size(new Size(10, 10));
		d6A().set_SizeMode((PictureBoxSizeMode)4);
		d6A().set_TabIndex(1100);
		d6A().set_TabStop(false);
		((Control)Zi0()).set_Location(new Point(372, 143));
		((Control)Zi0()).set_Name("PictureBox21");
		((Control)Zi0()).set_Size(new Size(10, 10));
		Zi0().set_SizeMode((PictureBoxSizeMode)4);
		Zi0().set_TabIndex(1099);
		Zi0().set_TabStop(false);
		((Control)Kg2()).set_Location(new Point(352, 143));
		((Control)Kg2()).set_Name("PictureBox22");
		((Control)Kg2()).set_Size(new Size(10, 10));
		Kg2().set_SizeMode((PictureBoxSizeMode)4);
		Kg2().set_TabIndex(1098);
		Kg2().set_TabStop(false);
		((Control)Dp8()).set_Location(new Point(333, 143));
		((Control)Dp8()).set_Name("PictureBox23");
		((Control)Dp8()).set_Size(new Size(10, 10));
		Dp8().set_SizeMode((PictureBoxSizeMode)4);
		Dp8().set_TabIndex(1097);
		Dp8().set_TabStop(false);
		((Control)Qo8()).set_Location(new Point(314, 143));
		((Control)Qo8()).set_Name("PictureBox24");
		((Control)Qo8()).set_Size(new Size(10, 10));
		Qo8().set_SizeMode((PictureBoxSizeMode)4);
		Qo8().set_TabIndex(1096);
		Qo8().set_TabStop(false);
		((Control)r3W()).set_Location(new Point(296, 143));
		((Control)r3W()).set_Name("PictureBox25");
		((Control)r3W()).set_Size(new Size(10, 10));
		r3W().set_SizeMode((PictureBoxSizeMode)4);
		r3W().set_TabIndex(1095);
		r3W().set_TabStop(false);
		((Control)o3K()).set_Location(new Point(279, 143));
		((Control)o3K()).set_Name("PictureBox26");
		((Control)o3K()).set_Size(new Size(10, 10));
		o3K().set_SizeMode((PictureBoxSizeMode)4);
		o3K().set_TabIndex(1094);
		o3K().set_TabStop(false);
		((Control)Kr4()).set_Location(new Point(261, 143));
		((Control)Kr4()).set_Name("PictureBox27");
		((Control)Kr4()).set_Size(new Size(10, 10));
		Kr4().set_SizeMode((PictureBoxSizeMode)4);
		Kr4().set_TabIndex(1093);
		Kr4().set_TabStop(false);
		((Control)Qr3()).set_Location(new Point(245, 143));
		((Control)Qr3()).set_Name("PictureBox28");
		((Control)Qr3()).set_Size(new Size(10, 10));
		Qr3().set_SizeMode((PictureBoxSizeMode)4);
		Qr3().set_TabIndex(1092);
		Qr3().set_TabStop(false);
		((Control)Cq4()).set_Location(new Point(227, 143));
		((Control)Cq4()).set_Name("PictureBox29");
		((Control)Cq4()).set_Size(new Size(10, 10));
		Cq4().set_SizeMode((PictureBoxSizeMode)4);
		Cq4().set_TabIndex(1091);
		Cq4().set_TabStop(false);
		((Control)De3()).set_Location(new Point(208, 143));
		((Control)De3()).set_Name("PictureBox30");
		((Control)De3()).set_Size(new Size(10, 10));
		De3().set_SizeMode((PictureBoxSizeMode)4);
		De3().set_TabIndex(1090);
		De3().set_TabStop(false);
		((Control)Wo4()).set_Location(new Point(190, 143));
		((Control)Wo4()).set_Name("PictureBox31");
		((Control)Wo4()).set_Size(new Size(10, 10));
		Wo4().set_SizeMode((PictureBoxSizeMode)4);
		Wo4().set_TabIndex(1089);
		Wo4().set_TabStop(false);
		((Control)w8Q()).set_Location(new Point(174, 143));
		((Control)w8Q()).set_Name("PictureBox32");
		((Control)w8Q()).set_Size(new Size(10, 10));
		w8Q().set_SizeMode((PictureBoxSizeMode)4);
		w8Q().set_TabIndex(1088);
		w8Q().set_TabStop(false);
		((Control)Yc4()).set_Location(new Point(158, 143));
		((Control)Yc4()).set_Name("PictureBox33");
		((Control)Yc4()).set_Size(new Size(10, 10));
		Yc4().set_SizeMode((PictureBoxSizeMode)4);
		Yc4().set_TabIndex(1087);
		Yc4().set_TabStop(false);
		((Control)z9R()).set_Location(new Point(142, 143));
		((Control)z9R()).set_Name("PictureBox34");
		((Control)z9R()).set_Size(new Size(10, 10));
		z9R().set_SizeMode((PictureBoxSizeMode)4);
		z9R().set_TabIndex(1086);
		z9R().set_TabStop(false);
		((Control)b7R()).set_Location(new Point(126, 143));
		((Control)b7R()).set_Name("PictureBox35");
		((Control)b7R()).set_Size(new Size(10, 10));
		b7R().set_SizeMode((PictureBoxSizeMode)4);
		b7R().set_TabIndex(1085);
		b7R().set_TabStop(false);
		((Control)Dq4()).set_Location(new Point(110, 143));
		((Control)Dq4()).set_Name("PictureBox36");
		((Control)Dq4()).set_Size(new Size(10, 10));
		Dq4().set_SizeMode((PictureBoxSizeMode)4);
		Dq4().set_TabIndex(1084);
		Dq4().set_TabStop(false);
		((Control)a4E()).set_Location(new Point(94, 143));
		((Control)a4E()).set_Name("PictureBox37");
		((Control)a4E()).set_Size(new Size(10, 10));
		a4E().set_SizeMode((PictureBoxSizeMode)4);
		a4E().set_TabIndex(1083);
		a4E().set_TabStop(false);
		((Control)Ak6()).set_Location(new Point(78, 143));
		((Control)Ak6()).set_Name("PictureBox38");
		((Control)Ak6()).set_Size(new Size(10, 10));
		Ak6().set_SizeMode((PictureBoxSizeMode)4);
		Ak6().set_TabIndex(1082);
		Ak6().set_TabStop(false);
		((Control)this.e6A()).set_Location(new Point(62, 143));
		((Control)this.e6A()).set_Name("PictureBox39");
		((Control)this.e6A()).set_Size(new Size(10, 10));
		this.e6A().set_SizeMode((PictureBoxSizeMode)4);
		this.e6A().set_TabIndex(1081);
		this.e6A().set_TabStop(false);
		((Control)Sk4()).set_Location(new Point(48, 143));
		((Control)Sk4()).set_Name("PictureBox40");
		((Control)Sk4()).set_Size(new Size(10, 10));
		Sk4().set_SizeMode((PictureBoxSizeMode)4);
		Sk4().set_TabIndex(1080);
		Sk4().set_TabStop(false);
		((Control)b2R()).set_Location(new Point(372, 121));
		((Control)b2R()).set_Name("PictureBox20");
		((Control)b2R()).set_Size(new Size(10, 10));
		b2R().set_SizeMode((PictureBoxSizeMode)4);
		b2R().set_TabIndex(1079);
		b2R().set_TabStop(false);
		((Control)Zi7()).set_Location(new Point(352, 121));
		((Control)Zi7()).set_Name("PictureBox19");
		((Control)Zi7()).set_Size(new Size(10, 10));
		Zi7().set_SizeMode((PictureBoxSizeMode)4);
		Zi7().set_TabIndex(1078);
		Zi7().set_TabStop(false);
		((Control)b0N()).set_Location(new Point(333, 121));
		((Control)b0N()).set_Name("PictureBox18");
		((Control)b0N()).set_Size(new Size(10, 10));
		b0N().set_SizeMode((PictureBoxSizeMode)4);
		b0N().set_TabIndex(1077);
		b0N().set_TabStop(false);
		((Control)Bq5()).set_Location(new Point(314, 121));
		((Control)Bq5()).set_Name("PictureBox17");
		((Control)Bq5()).set_Size(new Size(10, 10));
		Bq5().set_SizeMode((PictureBoxSizeMode)4);
		Bq5().set_TabIndex(1076);
		Bq5().set_TabStop(false);
		((Control)m0L()).set_Location(new Point(296, 121));
		((Control)m0L()).set_Name("PictureBox16");
		((Control)m0L()).set_Size(new Size(10, 10));
		m0L().set_SizeMode((PictureBoxSizeMode)4);
		m0L().set_TabIndex(1075);
		m0L().set_TabStop(false);
		((Control)Kq3()).set_Location(new Point(279, 121));
		((Control)Kq3()).set_Name("PictureBox15");
		((Control)Kq3()).set_Size(new Size(10, 10));
		Kq3().set_SizeMode((PictureBoxSizeMode)4);
		Kq3().set_TabIndex(1074);
		Kq3().set_TabStop(false);
		((Control)t3X()).set_Location(new Point(261, 121));
		((Control)t3X()).set_Name("PictureBox14");
		((Control)t3X()).set_Size(new Size(10, 10));
		t3X().set_SizeMode((PictureBoxSizeMode)4);
		t3X().set_TabIndex(1073);
		t3X().set_TabStop(false);
		((Control)i6M()).set_Location(new Point(245, 121));
		((Control)i6M()).set_Name("PictureBox13");
		((Control)i6M()).set_Size(new Size(10, 10));
		i6M().set_SizeMode((PictureBoxSizeMode)4);
		i6M().set_TabIndex(1072);
		i6M().set_TabStop(false);
		((Control)w6R()).set_Location(new Point(227, 121));
		((Control)w6R()).set_Name("PictureBox12");
		((Control)w6R()).set_Size(new Size(10, 10));
		w6R().set_SizeMode((PictureBoxSizeMode)4);
		w6R().set_TabIndex(1071);
		w6R().set_TabStop(false);
		((Control)Sb8()).set_Location(new Point(208, 121));
		((Control)Sb8()).set_Name("PictureBox11");
		((Control)Sb8()).set_Size(new Size(10, 10));
		Sb8().set_SizeMode((PictureBoxSizeMode)4);
		Sb8().set_TabIndex(1070);
		Sb8().set_TabStop(false);
		((Control)Ek9()).set_Location(new Point(190, 121));
		((Control)Ek9()).set_Name("PictureBox10");
		((Control)Ek9()).set_Size(new Size(10, 10));
		Ek9().set_SizeMode((PictureBoxSizeMode)4);
		Ek9().set_TabIndex(1069);
		Ek9().set_TabStop(false);
		((Control)Yg6()).set_Location(new Point(174, 121));
		((Control)Yg6()).set_Name("PictureBox9");
		((Control)Yg6()).set_Size(new Size(10, 10));
		Yg6().set_SizeMode((PictureBoxSizeMode)4);
		Yg6().set_TabIndex(1068);
		Yg6().set_TabStop(false);
		((Control)Ww7()).set_Location(new Point(158, 121));
		((Control)Ww7()).set_Name("PictureBox8");
		((Control)Ww7()).set_Size(new Size(10, 10));
		Ww7().set_SizeMode((PictureBoxSizeMode)4);
		Ww7().set_TabIndex(1067);
		Ww7().set_TabStop(false);
		((Control)f4K()).set_Location(new Point(142, 121));
		((Control)f4K()).set_Name("PictureBox7");
		((Control)f4K()).set_Size(new Size(10, 10));
		f4K().set_SizeMode((PictureBoxSizeMode)4);
		f4K().set_TabIndex(1066);
		f4K().set_TabStop(false);
		((Control)r5C()).set_Location(new Point(126, 121));
		((Control)r5C()).set_Name("PictureBox6");
		((Control)r5C()).set_Size(new Size(10, 10));
		r5C().set_SizeMode((PictureBoxSizeMode)4);
		r5C().set_TabIndex(1065);
		r5C().set_TabStop(false);
		((Control)this.Kc2()).set_Location(new Point(110, 121));
		((Control)this.Kc2()).set_Name("PictureBox5");
		((Control)this.Kc2()).set_Size(new Size(10, 10));
		this.Kc2().set_SizeMode((PictureBoxSizeMode)4);
		this.Kc2().set_TabIndex(1064);
		this.Kc2().set_TabStop(false);
		((Control)e8W()).set_Location(new Point(94, 121));
		((Control)e8W()).set_Name("PictureBox4");
		((Control)e8W()).set_Size(new Size(10, 10));
		e8W().set_SizeMode((PictureBoxSizeMode)4);
		e8W().set_TabIndex(1063);
		e8W().set_TabStop(false);
		((Control)m1Z()).set_Location(new Point(78, 121));
		((Control)m1Z()).set_Name("PictureBox3");
		((Control)m1Z()).set_Size(new Size(10, 10));
		m1Z().set_SizeMode((PictureBoxSizeMode)4);
		m1Z().set_TabIndex(1062);
		m1Z().set_TabStop(false);
		((Control)Ki0()).set_Location(new Point(62, 121));
		((Control)Ki0()).set_Name("PictureBox2");
		((Control)Ki0()).set_Size(new Size(10, 10));
		Ki0().set_SizeMode((PictureBoxSizeMode)4);
		Ki0().set_TabIndex(1061);
		Ki0().set_TabStop(false);
		((Control)k4P()).set_Location(new Point(48, 121));
		((Control)k4P()).set_Name("PictureBox1");
		((Control)k4P()).set_Size(new Size(10, 10));
		k4P().set_SizeMode((PictureBoxSizeMode)4);
		k4P().set_TabIndex(1060);
		k4P().set_TabStop(false);
		Ax4().set_AutoSize(true);
		((Control)Ax4()).set_Location(new Point(367, 256));
		((Control)Ax4()).set_Name("Label32");
		((Control)Ax4()).set_Size(new Size(19, 13));
		((Control)Ax4()).set_TabIndex(1059);
		Ax4().set_Text("20");
		n5A().set_AutoSize(true);
		((Control)n5A()).set_Location(new Point(274, 256));
		((Control)n5A()).set_Name("Label33");
		((Control)n5A()).set_Size(new Size(19, 13));
		((Control)n5A()).set_TabIndex(1058);
		n5A().set_Text("15");
		a7Q().set_AutoSize(true);
		((Control)a7Q()).set_Location(new Point(309, 256));
		((Control)a7Q()).set_Name("Label34");
		((Control)a7Q()).set_Size(new Size(19, 13));
		((Control)a7Q()).set_TabIndex(1057);
		a7Q().set_Text("17");
		x3F().set_AutoSize(true);
		((Control)x3F()).set_Location(new Point(328, 256));
		((Control)x3F()).set_Name("Label35");
		((Control)x3F()).set_Size(new Size(19, 13));
		((Control)x3F()).set_TabIndex(1056);
		x3F().set_Text("18");
		Qk1().set_AutoSize(true);
		((Control)Qk1()).set_Location(new Point(347, 256));
		((Control)Qk1()).set_Name("Label36");
		((Control)Qk1()).set_Size(new Size(19, 13));
		((Control)Qk1()).set_TabIndex(1055);
		Qk1().set_Text("19");
		Tb0().set_AutoSize(true);
		((Control)Tb0()).set_Location(new Point(222, 256));
		((Control)Tb0()).set_Name("Label37");
		((Control)Tb0()).set_Size(new Size(19, 13));
		((Control)Tb0()).set_TabIndex(1054);
		Tb0().set_Text("12");
		Gw7().set_AutoSize(true);
		((Control)Gw7()).set_Location(new Point(240, 256));
		((Control)Gw7()).set_Name("Label39");
		((Control)Gw7()).set_Size(new Size(19, 13));
		((Control)Gw7()).set_TabIndex(1052);
		Gw7().set_Text("13");
		Ly3().set_AutoSize(true);
		((Control)Ly3()).set_Location(new Point(291, 256));
		((Control)Ly3()).set_Name("Label40");
		((Control)Ly3()).set_Size(new Size(19, 13));
		((Control)Ly3()).set_TabIndex(1051);
		Ly3().set_Text("16");
		z8W().set_AutoSize(true);
		((Control)z8W()).set_Location(new Point(205, 256));
		((Control)z8W()).set_Name("Label41");
		((Control)z8W()).set_Size(new Size(19, 13));
		((Control)z8W()).set_TabIndex(1050);
		z8W().set_Text("11");
		Nj7().set_AutoSize(true);
		((Control)Nj7()).set_Location(new Point(256, 256));
		((Control)Nj7()).set_Name("Label42");
		((Control)Nj7()).set_Size(new Size(19, 13));
		((Control)Nj7()).set_TabIndex(1049);
		Nj7().set_Text("14");
		Nd1().set_AutoSize(true);
		((Control)Nd1()).set_Location(new Point(155, 256));
		((Control)Nd1()).set_Name("Label43");
		((Control)Nd1()).set_Size(new Size(13, 13));
		((Control)Nd1()).set_TabIndex(1048);
		Nd1().set_Text("8");
		Dz6().set_AutoSize(true);
		((Control)Dz6()).set_Location(new Point(91, 256));
		((Control)Dz6()).set_Name("Label38");
		((Control)Dz6()).set_Size(new Size(13, 13));
		((Control)Dz6()).set_TabIndex(1053);
		Dz6().set_Text("4");
		j8Y().set_AutoSize(true);
		((Control)j8Y()).set_Location(new Point(187, 256));
		((Control)j8Y()).set_Name("Label44");
		((Control)j8Y()).set_Size(new Size(19, 13));
		((Control)j8Y()).set_TabIndex(1047);
		j8Y().set_Text("10");
		Rj1().set_AutoSize(true);
		((Control)Rj1()).set_Location(new Point(171, 256));
		((Control)Rj1()).set_Name("Label45");
		((Control)Rj1()).set_Size(new Size(13, 13));
		((Control)Rj1()).set_TabIndex(1046);
		Rj1().set_Text("9");
		Xq4().set_AutoSize(true);
		((Control)Xq4()).set_Location(new Point(139, 256));
		((Control)Xq4()).set_Name("Label46");
		((Control)Xq4()).set_Size(new Size(13, 13));
		((Control)Xq4()).set_TabIndex(1045);
		Xq4().set_Text("7");
		Ye1().set_AutoSize(true);
		((Control)Ye1()).set_Location(new Point(123, 256));
		((Control)Ye1()).set_Name("Label47");
		((Control)Ye1()).set_Size(new Size(13, 13));
		((Control)Ye1()).set_TabIndex(1044);
		Ye1().set_Text("6");
		q0H().set_AutoSize(true);
		((Control)q0H()).set_Location(new Point(107, 256));
		((Control)q0H()).set_Name("Label48");
		((Control)q0H()).set_Size(new Size(13, 13));
		((Control)q0H()).set_TabIndex(1043);
		q0H().set_Text("5");
		this.Tw0().set_AutoSize(true);
		((Control)this.Tw0()).set_Location(new Point(75, 256));
		((Control)this.Tw0()).set_Name("Label49");
		((Control)this.Tw0()).set_Size(new Size(13, 13));
		((Control)this.Tw0()).set_TabIndex(1042);
		this.Tw0().set_Text("3");
		Wd8().set_AutoSize(true);
		((Control)Wd8()).set_Location(new Point(59, 256));
		((Control)Wd8()).set_Name("Label50");
		((Control)Wd8()).set_Size(new Size(13, 13));
		((Control)Wd8()).set_TabIndex(1041);
		Wd8().set_Text("2");
		x1C().set_AutoSize(true);
		((Control)x1C()).set_Location(new Point(43, 256));
		((Control)x1C()).set_Name("Label51");
		((Control)x1C()).set_Size(new Size(13, 13));
		((Control)x1C()).set_TabIndex(1040);
		x1C().set_Text("1");
		Yn4().set_AutoSize(true);
		((Control)Yn4()).set_Location(new Point(29, 362));
		((Control)Yn4()).set_Name("Label54");
		((Control)Yn4()).set_Size(new Size(15, 13));
		((Control)Yn4()).set_TabIndex(1039);
		Yn4().set_Text("H");
		Fy1().set_AutoSize(true);
		((Control)Fy1()).set_Location(new Point(29, 340));
		((Control)Fy1()).set_Name("Label55");
		((Control)Fy1()).set_Size(new Size(15, 13));
		((Control)Fy1()).set_TabIndex(1038);
		Fy1().set_Text("G");
		w4K().set_AutoSize(true);
		((Control)w4K()).set_Location(new Point(29, 318));
		((Control)w4K()).set_Name("Label56");
		((Control)w4K()).set_Size(new Size(13, 13));
		((Control)w4K()).set_TabIndex(1037);
		w4K().set_Text("F");
		Rp6().set_AutoSize(true);
		((Control)Rp6()).set_Location(new Point(176, 222));
		((Control)Rp6()).set_Name("Label31");
		((Control)Rp6()).set_Size(new Size(72, 13));
		((Control)Rp6()).set_TabIndex(1036);
		Rp6().set_Text("LOWER BOX");
		Bw8().set_AutoSize(true);
		((Control)Bw8()).set_Location(new Point(28, 299));
		((Control)Bw8()).set_Name("Label26");
		((Control)Bw8()).set_Size(new Size(14, 13));
		((Control)Bw8()).set_TabIndex(1035);
		Bw8().set_Text("E");
		j3X().set_AutoSize(true);
		((Control)j3X()).set_Location(new Point(28, 187));
		((Control)j3X()).set_Name("Label27");
		((Control)j3X()).set_Size(new Size(15, 13));
		((Control)j3X()).set_TabIndex(1034);
		j3X().set_Text("D");
		Gy9().set_AutoSize(true);
		((Control)Gy9()).set_Location(new Point(28, 165));
		((Control)Gy9()).set_Name("Label28");
		((Control)Gy9()).set_Size(new Size(14, 13));
		((Control)Gy9()).set_TabIndex(1033);
		Gy9().set_Text("C");
		Hy9().set_AutoSize(true);
		((Control)Hy9()).set_Location(new Point(28, 143));
		((Control)Hy9()).set_Name("Label29");
		((Control)Hy9()).set_Size(new Size(14, 13));
		((Control)Hy9()).set_TabIndex(1032);
		Hy9().set_Text("B");
		Xq8().set_AutoSize(true);
		((Control)Xq8()).set_Location(new Point(28, 121));
		((Control)Xq8()).set_Name("Label30");
		((Control)Xq8()).set_Size(new Size(14, 13));
		((Control)Xq8()).set_TabIndex(1031);
		Xq8().set_Text("A");
		Jj3().set_AutoSize(true);
		((Control)Jj3()).set_Location(new Point(367, 75));
		((Control)Jj3()).set_Name("Label25");
		((Control)Jj3()).set_Size(new Size(19, 13));
		((Control)Jj3()).set_TabIndex(1030);
		Jj3().set_Text("20");
		Ab4().set_AutoSize(true);
		((Control)Ab4()).set_Location(new Point(274, 75));
		((Control)Ab4()).set_Name("Label24");
		((Control)Ab4()).set_Size(new Size(19, 13));
		((Control)Ab4()).set_TabIndex(1029);
		Ab4().set_Text("15");
		Bw5().set_AutoSize(true);
		((Control)Bw5()).set_Location(new Point(309, 75));
		((Control)Bw5()).set_Name("Label23");
		((Control)Bw5()).set_Size(new Size(19, 13));
		((Control)Bw5()).set_TabIndex(1028);
		Bw5().set_Text("17");
		Ca4().set_AutoSize(true);
		((Control)Ca4()).set_Location(new Point(328, 75));
		((Control)Ca4()).set_Name("Label22");
		((Control)Ca4()).set_Size(new Size(19, 13));
		((Control)Ca4()).set_TabIndex(1027);
		Ca4().set_Text("18");
		z5G().set_AutoSize(true);
		((Control)z5G()).set_Location(new Point(347, 75));
		((Control)z5G()).set_Name("Label21");
		((Control)z5G()).set_Size(new Size(19, 13));
		((Control)z5G()).set_TabIndex(1026);
		z5G().set_Text("19");
		y5G().set_AutoSize(true);
		((Control)y5G()).set_Location(new Point(222, 75));
		((Control)y5G()).set_Name("Label20");
		((Control)y5G()).set_Size(new Size(19, 13));
		((Control)y5G()).set_TabIndex(1025);
		y5G().set_Text("12");
		y3J().set_AutoSize(true);
		((Control)y3J()).set_Location(new Point(91, 75));
		((Control)y3J()).set_Name("Label19");
		((Control)y3J()).set_Size(new Size(13, 13));
		((Control)y3J()).set_TabIndex(1024);
		y3J().set_Text("4");
		Bo7().set_AutoSize(true);
		((Control)Bo7()).set_Location(new Point(240, 75));
		((Control)Bo7()).set_Name("Label18");
		((Control)Bo7()).set_Size(new Size(19, 13));
		((Control)Bo7()).set_TabIndex(1023);
		Bo7().set_Text("13");
		x1W().set_AutoSize(true);
		((Control)x1W()).set_Location(new Point(291, 75));
		((Control)x1W()).set_Name("Label17");
		((Control)x1W()).set_Size(new Size(19, 13));
		((Control)x1W()).set_TabIndex(1022);
		x1W().set_Text("16");
		i7B().set_AutoSize(true);
		((Control)i7B()).set_Location(new Point(205, 75));
		((Control)i7B()).set_Name("Label16");
		((Control)i7B()).set_Size(new Size(19, 13));
		((Control)i7B()).set_TabIndex(1021);
		i7B().set_Text("11");
		Kg8().set_AutoSize(true);
		((Control)Kg8()).set_Location(new Point(256, 75));
		((Control)Kg8()).set_Name("Label15");
		((Control)Kg8()).set_Size(new Size(19, 13));
		((Control)Kg8()).set_TabIndex(1020);
		Kg8().set_Text("14");
		Lp8().set_AutoSize(true);
		((Control)Lp8()).set_Location(new Point(155, 75));
		((Control)Lp8()).set_Name("Label14");
		((Control)Lp8()).set_Size(new Size(13, 13));
		((Control)Lp8()).set_TabIndex(1019);
		Lp8().set_Text("8");
		x7L9().set_AutoSize(true);
		((Control)x7L9()).set_Location(new Point(187, 75));
		((Control)x7L9()).set_Name("Label13");
		((Control)x7L9()).set_Size(new Size(19, 13));
		((Control)x7L9()).set_TabIndex(1018);
		x7L9().set_Text("10");
		n2WP().set_AutoSize(true);
		((Control)n2WP()).set_Location(new Point(171, 75));
		((Control)n2WP()).set_Name("Label12");
		((Control)n2WP()).set_Size(new Size(13, 13));
		((Control)n2WP()).set_TabIndex(1017);
		n2WP().set_Text("9");
		Lo0e().set_AutoSize(true);
		((Control)Lo0e()).set_Location(new Point(139, 75));
		((Control)Lo0e()).set_Name("Label11");
		((Control)Lo0e()).set_Size(new Size(13, 13));
		((Control)Lo0e()).set_TabIndex(1016);
		Lo0e().set_Text("7");
		Bf2s().set_AutoSize(true);
		((Control)Bf2s()).set_Location(new Point(123, 75));
		((Control)Bf2s()).set_Name("Label10");
		((Control)Bf2s()).set_Size(new Size(13, 13));
		((Control)Bf2s()).set_TabIndex(1015);
		Bf2s().set_Text("6");
		n8SB().set_AutoSize(true);
		((Control)n8SB()).set_Location(new Point(107, 75));
		((Control)n8SB()).set_Name("Label9");
		((Control)n8SB()).set_Size(new Size(13, 13));
		((Control)n8SB()).set_TabIndex(1014);
		n8SB().set_Text("5");
		n1BG().set_AutoSize(true);
		((Control)n1BG()).set_Location(new Point(75, 75));
		((Control)n1BG()).set_Name("Label8");
		((Control)n1BG()).set_Size(new Size(13, 13));
		((Control)n1BG()).set_TabIndex(1013);
		n1BG().set_Text("3");
		Dk3y().set_AutoSize(true);
		((Control)Dk3y()).set_Location(new Point(59, 75));
		((Control)Dk3y()).set_Name("Label7");
		((Control)Dk3y()).set_Size(new Size(13, 13));
		((Control)Dk3y()).set_TabIndex(1012);
		Dk3y().set_Text("2");
		r3S9().set_AutoSize(true);
		((Control)r3S9()).set_Location(new Point(176, 48));
		((Control)r3S9()).set_Name("Label4");
		((Control)r3S9()).set_Size(new Size(69, 13));
		((Control)r3S9()).set_TabIndex(1010);
		r3S9().set_Text("UPPER BOX");
		Cy86().set_AutoSize(true);
		((Control)Cy86()).set_Location(new Point(43, 75));
		((Control)Cy86()).set_Name("Label5");
		((Control)Cy86()).set_Size(new Size(13, 13));
		((Control)Cy86()).set_TabIndex(1011);
		Cy86().set_Text("1");
		((Control)Zq2z()).get_Controls().Add((Control)(object)Yx4a());
		((Control)Zq2z()).get_Controls().Add((Control)(object)Ri1r());
		((Control)Zq2z()).get_Controls().Add((Control)(object)j7M2());
		((Control)Zq2z()).get_Controls().Add((Control)(object)i0WK());
		((Control)Zq2z()).get_Controls().Add((Control)(object)Zn93());
		((Control)Zq2z()).get_Controls().Add((Control)(object)Dq74());
		((Control)Zq2z()).get_Controls().Add((Control)(object)f9E5());
		((Control)Zq2z()).get_Controls().Add((Control)(object)Ai78());
		((Control)Zq2z()).get_Controls().Add((Control)(object)Kb2d());
		((Control)Zq2z()).set_ForeColor(SystemColors.ControlLight);
		((Control)Zq2z()).set_Location(new Point(454, 48));
		((Control)Zq2z()).set_Name("GroupBox1");
		((Control)Zq2z()).set_Size(new Size(240, 100));
		((Control)Zq2z()).set_TabIndex(1006);
		Zq2z().set_TabStop(false);
		Zq2z().set_Text("Statistics");
		((Control)j7M2()).set_Location(new Point(151, 16));
		((Control)j7M2()).set_Name("txtAvailable");
		((Control)j7M2()).set_Size(new Size(83, 20));
		((Control)j7M2()).set_TabIndex(25);
		((Control)i0WK()).set_BackColor(Color.Transparent);
		((Control)i0WK()).set_Location(new Point(5, 47));
		((Control)i0WK()).set_Name("Booked");
		((Control)i0WK()).set_Size(new Size(23, 18));
		i0WK().set_SizeMode((PictureBoxSizeMode)4);
		i0WK().set_TabIndex(27);
		i0WK().set_TabStop(false);
		((Control)Zn93()).set_BackColor(Color.Transparent);
		((Control)Zn93()).set_Location(new Point(6, 74));
		((Control)Zn93()).set_Name("Provisional");
		((Control)Zn93()).set_Size(new Size(23, 17));
		Zn93().set_SizeMode((PictureBoxSizeMode)4);
		Zn93().set_TabIndex(26);
		Zn93().set_TabStop(false);
		((Control)Dq74()).set_BackColor(Color.Transparent);
		((Control)Dq74()).set_Location(new Point(5, 23));
		((Control)Dq74()).set_Name("Available");
		((Control)Dq74()).set_Size(new Size(23, 17));
		Dq74().set_SizeMode((PictureBoxSizeMode)4);
		Dq74().set_TabIndex(25);
		Dq74().set_TabStop(false);
		f9E5().set_AutoSize(true);
		((Control)f9E5()).set_BackColor(Color.Transparent);
		((Control)f9E5()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)f9E5()).set_Location(new Point(30, 49));
		((Control)f9E5()).set_Name("Label3");
		((Control)f9E5()).set_Size(new Size(74, 13));
		((Control)f9E5()).set_TabIndex(12);
		f9E5().set_Text("Booked Seats");
		Cj75().set_AutoSize(true);
		((Control)Cj75()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Cj75()).set_ForeColor(SystemColors.ControlLight);
		((Control)Cj75()).set_Location(new Point(28, 6));
		((Control)Cj75()).set_Name("Label6");
		((Control)Cj75()).set_Size(new Size(106, 24));
		((Control)Cj75()).set_TabIndex(1005);
		Cj75().set_Text("CINEMA 4");
		((Control)r4AX()).set_Location(new Point(435, 40));
		((Control)r4AX()).set_Name("Background");
		((Control)r4AX()).set_Size(new Size(474, 396));
		r4AX().set_SizeMode((PictureBoxSizeMode)1);
		r4AX().set_TabIndex(1004);
		r4AX().set_TabStop(false);
		((Control)Tk0d()).set_BackColor(Color.Transparent);
		((Control)Tk0d()).set_Location(new Point(-2, -3));
		((Control)Tk0d()).set_Name("NameBox");
		((Control)Tk0d()).set_Size(new Size(914, 45));
		Tk0d().set_SizeMode((PictureBoxSizeMode)1);
		Tk0d().set_TabIndex(1003);
		Tk0d().set_TabStop(false);
		((Control)x5S6()).get_Controls().Add((Control)(object)Ed95());
		((Control)x5S6()).get_Controls().Add((Control)(object)d8RL());
		((Control)x5S6()).set_ForeColor(SystemColors.ControlLight);
		((Control)x5S6()).set_Location(new Point(471, 170));
		((Control)x5S6()).set_Name("GroupBox3");
		((Control)x5S6()).set_Size(new Size(200, 251));
		((Control)x5S6()).set_TabIndex(1220);
		x5S6().set_TabStop(false);
		x5S6().set_Text("Movie On Display");
		((ButtonBase)Ed95()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ed95()).set_FlatStyle((FlatStyle)0);
		((Control)Ed95()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ed95()).set_Location(new Point(48, 214));
		((Control)Ed95()).set_Name("btnViewReservations");
		((Control)Ed95()).set_Size(new Size(117, 23));
		((Control)Ed95()).set_TabIndex(41);
		((ButtonBase)Ed95()).set_Text("View Reservations");
		((ButtonBase)Ed95()).set_UseVisualStyleBackColor(true);
		((Control)d8RL()).set_BackColor(Color.Transparent);
		((Control)d8RL()).set_Location(new Point(39, 21));
		((Control)d8RL()).set_Name("Cover");
		((Control)d8RL()).set_Size(new Size(129, 187));
		d8RL().set_SizeMode((PictureBoxSizeMode)4);
		d8RL().set_TabIndex(25);
		d8RL().set_TabStop(false);
		((Control)Hs78()).get_Controls().Add((Control)(object)q2X0());
		((Control)Hs78()).get_Controls().Add((Control)(object)Te1d());
		((Control)Hs78()).get_Controls().Add((Control)(object)f4SD());
		((Control)Hs78()).get_Controls().Add((Control)(object)Dm0t());
		((Control)Hs78()).get_Controls().Add((Control)(object)Pf96());
		((Control)Hs78()).get_Controls().Add((Control)(object)Ss18());
		((Control)Hs78()).get_Controls().Add((Control)(object)r8X9());
		((Control)Hs78()).set_ForeColor(SystemColors.ControlLight);
		((Control)Hs78()).set_Location(new Point(704, 51));
		((Control)Hs78()).set_Name("GroupBox2");
		((Control)Hs78()).set_Size(new Size(200, 129));
		((Control)Hs78()).set_TabIndex(1221);
		Hs78().set_TabStop(false);
		Hs78().set_Text("Customer");
		((ButtonBase)q2X0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)q2X0()).set_FlatStyle((FlatStyle)0);
		((Control)q2X0()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)q2X0()).set_Location(new Point(70, 90));
		((Control)q2X0()).set_Name("btnNew");
		((Control)q2X0()).set_Size(new Size(54, 23));
		((Control)q2X0()).set_TabIndex(39);
		((ButtonBase)q2X0()).set_Text("New");
		((ButtonBase)q2X0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Te1d()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Te1d()).set_FlatStyle((FlatStyle)0);
		((Control)Te1d()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Te1d()).set_Location(new Point(130, 90));
		((Control)Te1d()).set_Name("btnReset");
		((Control)Te1d()).set_Size(new Size(54, 23));
		((Control)Te1d()).set_TabIndex(38);
		((ButtonBase)Te1d()).set_Text("Reset");
		((ButtonBase)Te1d()).set_UseVisualStyleBackColor(true);
		((ButtonBase)f4SD()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)f4SD()).set_FlatStyle((FlatStyle)0);
		((Control)f4SD()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)f4SD()).set_Location(new Point(10, 90));
		((Control)f4SD()).set_Name("btnExisting");
		((Control)f4SD()).set_Size(new Size(54, 23));
		((Control)f4SD()).set_TabIndex(37);
		((ButtonBase)f4SD()).set_Text("Existing");
		((ButtonBase)f4SD()).set_UseVisualStyleBackColor(true);
		((Control)Dm0t()).set_Location(new Point(94, 57));
		((Control)Dm0t()).set_Name("txtFirstName");
		((Control)Dm0t()).set_Size(new Size(103, 20));
		((Control)Dm0t()).set_TabIndex(30);
		((Control)Pf96()).set_Location(new Point(94, 31));
		((Control)Pf96()).set_Name("txtID");
		((Control)Pf96()).set_Size(new Size(103, 20));
		((Control)Pf96()).set_TabIndex(29);
		Ss18().set_AutoSize(true);
		((Control)Ss18()).set_BackColor(Color.Transparent);
		((Control)Ss18()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ss18()).set_Location(new Point(6, 58));
		((Control)Ss18()).set_Name("Label60");
		((Control)Ss18()).set_Size(new Size(57, 13));
		((Control)Ss18()).set_TabIndex(12);
		Ss18().set_Text("First Name");
		r8X9().set_AutoSize(true);
		((Control)r8X9()).set_BackColor(Color.Transparent);
		((Control)r8X9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)r8X9()).set_Location(new Point(6, 34));
		((Control)r8X9()).set_Name("Label59");
		((Control)r8X9()).set_Size(new Size(65, 13));
		((Control)r8X9()).set_TabIndex(11);
		r8X9().set_Text("Customer ID");
		((Control)g3JD()).get_Controls().Add((Control)(object)Gz8d());
		((Control)g3JD()).get_Controls().Add((Control)(object)x2TX());
		((Control)g3JD()).get_Controls().Add((Control)(object)Mo6g());
		((Control)g3JD()).get_Controls().Add((Control)(object)g1X0());
		((Control)g3JD()).get_Controls().Add((Control)(object)o0Q4());
		((Control)g3JD()).get_Controls().Add((Control)(object)Hc6d());
		((Control)g3JD()).get_Controls().Add((Control)(object)j7L2());
		((Control)g3JD()).get_Controls().Add((Control)(object)Qj1s());
		((Control)g3JD()).get_Controls().Add((Control)(object)r1Q0());
		((Control)g3JD()).get_Controls().Add((Control)(object)Mx6f());
		((Control)g3JD()).set_ForeColor(SystemColors.ControlLight);
		((Control)g3JD()).set_Location(new Point(687, 185));
		((Control)g3JD()).set_Name("GroupBox4");
		((Control)g3JD()).set_Size(new Size(211, 231));
		((Control)g3JD()).set_TabIndex(1222);
		g3JD().set_TabStop(false);
		g3JD().set_Text("Billing INFO");
		((ButtonBase)Gz8d()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Gz8d()).set_FlatStyle((FlatStyle)0);
		((Control)Gz8d()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Gz8d()).set_Location(new Point(72, 184));
		((Control)Gz8d()).set_Name("btnSave");
		((Control)Gz8d()).set_Size(new Size(133, 23));
		((Control)Gz8d()).set_TabIndex(40);
		((ButtonBase)Gz8d()).set_Text("Save / Receipt Preview");
		((ButtonBase)Gz8d()).set_UseVisualStyleBackColor(true);
		((ButtonBase)x2TX()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)x2TX()).set_FlatStyle((FlatStyle)0);
		((Control)x2TX()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)x2TX()).set_Location(new Point(103, 155));
		((Control)x2TX()).set_Name("btnCalculateChange");
		((Control)x2TX()).set_Size(new Size(101, 23));
		((Control)x2TX()).set_TabIndex(39);
		((ButtonBase)x2TX()).set_Text("Calculate Change");
		((ButtonBase)x2TX()).set_UseVisualStyleBackColor(true);
		((Control)Mo6g()).set_Location(new Point(95, 123));
		((Control)Mo6g()).set_Name("txtChange");
		((Control)Mo6g()).set_Size(new Size(110, 20));
		((Control)Mo6g()).set_TabIndex(34);
		((Control)g1X0()).set_Location(new Point(95, 91));
		((Control)g1X0()).set_Name("txtTotalPayment");
		((Control)g1X0()).set_Size(new Size(110, 20));
		((Control)g1X0()).set_TabIndex(33);
		((Control)o0Q4()).set_Location(new Point(96, 58));
		((Control)o0Q4()).set_Name("txtTotalCost");
		((Control)o0Q4()).set_Size(new Size(109, 20));
		((Control)o0Q4()).set_TabIndex(32);
		((Control)Hc6d()).set_Location(new Point(122, 24));
		((Control)Hc6d()).set_Name("txtSeats");
		((Control)Hc6d()).set_Size(new Size(83, 20));
		((Control)Hc6d()).set_TabIndex(31);
		j7L2().set_AutoSize(true);
		((Control)j7L2()).set_BackColor(Color.Transparent);
		((Control)j7L2()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)j7L2()).set_Location(new Point(8, 62));
		((Control)j7L2()).set_Name("Label63");
		((Control)j7L2()).set_Size(new Size(66, 13));
		((Control)j7L2()).set_TabIndex(16);
		j7L2().set_Text("Total Costs :");
		Qj1s().set_AutoSize(true);
		((Control)Qj1s()).set_BackColor(Color.Transparent);
		((Control)Qj1s()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Qj1s()).set_Location(new Point(8, 27));
		((Control)Qj1s()).set_Name("Label64");
		((Control)Qj1s()).set_Size(new Size(106, 13));
		((Control)Qj1s()).set_TabIndex(15);
		Qj1s().set_Text("Seats to be booked :");
		r1Q0().set_AutoSize(true);
		((Control)r1Q0()).set_BackColor(Color.Transparent);
		((Control)r1Q0()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)r1Q0()).set_Location(new Point(8, 121));
		((Control)r1Q0()).set_Name("Label61");
		((Control)r1Q0()).set_Size(new Size(50, 13));
		((Control)r1Q0()).set_TabIndex(14);
		r1Q0().set_Text("Change :");
		Mx6f().set_AutoSize(true);
		((Control)Mx6f()).set_BackColor(Color.Transparent);
		((Control)Mx6f()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mx6f()).set_Location(new Point(8, 91));
		((Control)Mx6f()).set_Name("Label62");
		((Control)Mx6f()).set_Size(new Size(81, 13));
		((Control)Mx6f()).set_TabIndex(13);
		Mx6f().set_Text("Total Payment :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)g3JD());
		((Control)this).get_Controls().Add((Control)(object)Hs78());
		((Control)this).get_Controls().Add((Control)(object)x5S6());
		((Control)this).get_Controls().Add((Control)(object)Kc46());
		((Control)this).get_Controls().Add((Control)(object)e6FL());
		((Control)this).get_Controls().Add((Control)(object)Bb08());
		((Control)this).get_Controls().Add((Control)(object)c3X0());
		((Control)this).get_Controls().Add((Control)(object)t3L9());
		((Control)this).get_Controls().Add((Control)(object)d5E7());
		((Control)this).get_Controls().Add((Control)(object)Et13());
		((Control)this).get_Controls().Add((Control)(object)o3TL());
		((Control)this).get_Controls().Add((Control)(object)p5T0());
		((Control)this).get_Controls().Add((Control)(object)m3A6());
		((Control)this).get_Controls().Add((Control)(object)n3MA());
		((Control)this).get_Controls().Add((Control)(object)Zo3q());
		((Control)this).get_Controls().Add((Control)(object)Fx90());
		((Control)this).get_Controls().Add((Control)(object)r7M0());
		((Control)this).get_Controls().Add((Control)(object)g8NK());
		((Control)this).get_Controls().Add((Control)(object)Rj1m());
		((Control)this).get_Controls().Add((Control)(object)Da9t());
		((Control)this).get_Controls().Add((Control)(object)Xn75());
		((Control)this).get_Controls().Add((Control)(object)Xr94());
		((Control)this).get_Controls().Add((Control)(object)Rc37());
		((Control)this).get_Controls().Add((Control)(object)z0Z5());
		((Control)this).get_Controls().Add((Control)(object)Zi13());
		((Control)this).get_Controls().Add((Control)(object)p1GB());
		((Control)this).get_Controls().Add((Control)(object)Hr6f());
		((Control)this).get_Controls().Add((Control)(object)Fn13());
		((Control)this).get_Controls().Add((Control)(object)s2FW());
		((Control)this).get_Controls().Add((Control)(object)Df39());
		((Control)this).get_Controls().Add((Control)(object)Sa83());
		((Control)this).get_Controls().Add((Control)(object)o8Z2());
		((Control)this).get_Controls().Add((Control)(object)j4E0());
		((Control)this).get_Controls().Add((Control)(object)a7M6());
		((Control)this).get_Controls().Add((Control)(object)x3H8());
		((Control)this).get_Controls().Add((Control)(object)Yn37());
		((Control)this).get_Controls().Add((Control)(object)b5N1());
		((Control)this).get_Controls().Add((Control)(object)Ym39());
		((Control)this).get_Controls().Add((Control)(object)Ci5r());
		((Control)this).get_Controls().Add((Control)(object)b3EM());
		((Control)this).get_Controls().Add((Control)(object)Mm56());
		((Control)this).get_Controls().Add((Control)(object)Go7w());
		((Control)this).get_Controls().Add((Control)(object)Xm41());
		((Control)this).get_Controls().Add((Control)(object)p0W());
		((Control)this).get_Controls().Add((Control)(object)Gp4());
		((Control)this).get_Controls().Add((Control)(object)Qo4());
		((Control)this).get_Controls().Add((Control)(object)z7Y());
		((Control)this).get_Controls().Add((Control)(object)p4C());
		((Control)this).get_Controls().Add((Control)(object)Cp7());
		((Control)this).get_Controls().Add((Control)(object)d7X());
		((Control)this).get_Controls().Add((Control)(object)s1A());
		((Control)this).get_Controls().Add((Control)(object)Qs5());
		((Control)this).get_Controls().Add((Control)(object)a1L());
		((Control)this).get_Controls().Add((Control)(object)Cw3());
		((Control)this).get_Controls().Add((Control)(object)Ab2());
		((Control)this).get_Controls().Add((Control)(object)Yo7());
		((Control)this).get_Controls().Add((Control)(object)m6Z());
		((Control)this).get_Controls().Add((Control)(object)Kf0());
		((Control)this).get_Controls().Add((Control)(object)Ha5());
		((Control)this).get_Controls().Add((Control)(object)La2());
		((Control)this).get_Controls().Add((Control)(object)Wq4());
		((Control)this).get_Controls().Add((Control)(object)Mp2());
		((Control)this).get_Controls().Add((Control)(object)j7Y());
		((Control)this).get_Controls().Add((Control)(object)Xt8());
		((Control)this).get_Controls().Add((Control)(object)Tz0());
		((Control)this).get_Controls().Add((Control)(object)g7H());
		((Control)this).get_Controls().Add((Control)(object)Qo1());
		((Control)this).get_Controls().Add((Control)(object)w6H());
		((Control)this).get_Controls().Add((Control)(object)n9Z());
		((Control)this).get_Controls().Add((Control)(object)Kp8());
		((Control)this).get_Controls().Add((Control)(object)Qd3());
		((Control)this).get_Controls().Add((Control)(object)this.Tw0());
		((Control)this).get_Controls().Add((Control)(object)As4());
		((Control)this).get_Controls().Add((Control)(object)a0Y());
		((Control)this).get_Controls().Add((Control)(object)Jq4());
		((Control)this).get_Controls().Add((Control)(object)Pt2());
		((Control)this).get_Controls().Add((Control)(object)Gb2());
		((Control)this).get_Controls().Add((Control)(object)c5E());
		((Control)this).get_Controls().Add((Control)(object)j2R());
		((Control)this).get_Controls().Add((Control)(object)o3T());
		((Control)this).get_Controls().Add((Control)(object)Kt1());
		((Control)this).get_Controls().Add((Control)(object)Fk0());
		((Control)this).get_Controls().Add((Control)(object)e3H());
		((Control)this).get_Controls().Add((Control)(object)Cr6());
		((Control)this).get_Controls().Add((Control)(object)w2J());
		((Control)this).get_Controls().Add((Control)(object)p2G());
		((Control)this).get_Controls().Add((Control)(object)s5Q());
		((Control)this).get_Controls().Add((Control)(object)Lp1());
		((Control)this).get_Controls().Add((Control)(object)Py8());
		((Control)this).get_Controls().Add((Control)(object)z4G());
		((Control)this).get_Controls().Add((Control)(object)o6L());
		((Control)this).get_Controls().Add((Control)(object)Pw3());
		((Control)this).get_Controls().Add((Control)(object)m0R());
		((Control)this).get_Controls().Add((Control)(object)k4L());
		((Control)this).get_Controls().Add((Control)(object)Zy0());
		((Control)this).get_Controls().Add((Control)(object)s5Z());
		((Control)this).get_Controls().Add((Control)(object)Kc6());
		((Control)this).get_Controls().Add((Control)(object)t6T());
		((Control)this).get_Controls().Add((Control)(object)n6S());
		((Control)this).get_Controls().Add((Control)(object)Di4());
		((Control)this).get_Controls().Add((Control)(object)Gj7());
		((Control)this).get_Controls().Add((Control)(object)c8T());
		((Control)this).get_Controls().Add((Control)(object)g8L());
		((Control)this).get_Controls().Add((Control)(object)Xe6());
		((Control)this).get_Controls().Add((Control)(object)m3N());
		((Control)this).get_Controls().Add((Control)(object)Cx4());
		((Control)this).get_Controls().Add((Control)(object)z2X());
		((Control)this).get_Controls().Add((Control)(object)Pe8());
		((Control)this).get_Controls().Add((Control)(object)Qt9());
		((Control)this).get_Controls().Add((Control)(object)e1Z());
		((Control)this).get_Controls().Add((Control)(object)this.Kc2());
		((Control)this).get_Controls().Add((Control)(object)i4J());
		((Control)this).get_Controls().Add((Control)(object)Cx5());
		((Control)this).get_Controls().Add((Control)(object)y1M());
		((Control)this).get_Controls().Add((Control)(object)z8M());
		((Control)this).get_Controls().Add((Control)(object)this.e6A());
		((Control)this).get_Controls().Add((Control)(object)k3F());
		((Control)this).get_Controls().Add((Control)(object)r4A());
		((Control)this).get_Controls().Add((Control)(object)Kc4());
		((Control)this).get_Controls().Add((Control)(object)n2R());
		((Control)this).get_Controls().Add((Control)(object)Pp5());
		((Control)this).get_Controls().Add((Control)(object)k6S());
		((Control)this).get_Controls().Add((Control)(object)d6A());
		((Control)this).get_Controls().Add((Control)(object)Zi0());
		((Control)this).get_Controls().Add((Control)(object)Kg2());
		((Control)this).get_Controls().Add((Control)(object)Dp8());
		((Control)this).get_Controls().Add((Control)(object)Qo8());
		((Control)this).get_Controls().Add((Control)(object)r3W());
		((Control)this).get_Controls().Add((Control)(object)o3K());
		((Control)this).get_Controls().Add((Control)(object)Kr4());
		((Control)this).get_Controls().Add((Control)(object)Qr3());
		((Control)this).get_Controls().Add((Control)(object)Cq4());
		((Control)this).get_Controls().Add((Control)(object)De3());
		((Control)this).get_Controls().Add((Control)(object)Wo4());
		((Control)this).get_Controls().Add((Control)(object)w8Q());
		((Control)this).get_Controls().Add((Control)(object)Yc4());
		((Control)this).get_Controls().Add((Control)(object)z9R());
		((Control)this).get_Controls().Add((Control)(object)b7R());
		((Control)this).get_Controls().Add((Control)(object)Dq4());
		((Control)this).get_Controls().Add((Control)(object)a4E());
		((Control)this).get_Controls().Add((Control)(object)Ak6());
		((Control)this).get_Controls().Add((Control)(object)this.e6A());
		((Control)this).get_Controls().Add((Control)(object)Sk4());
		((Control)this).get_Controls().Add((Control)(object)b2R());
		((Control)this).get_Controls().Add((Control)(object)Zi7());
		((Control)this).get_Controls().Add((Control)(object)b0N());
		((Control)this).get_Controls().Add((Control)(object)Bq5());
		((Control)this).get_Controls().Add((Control)(object)m0L());
		((Control)this).get_Controls().Add((Control)(object)Kq3());
		((Control)this).get_Controls().Add((Control)(object)t3X());
		((Control)this).get_Controls().Add((Control)(object)i6M());
		((Control)this).get_Controls().Add((Control)(object)w6R());
		((Control)this).get_Controls().Add((Control)(object)Sb8());
		((Control)this).get_Controls().Add((Control)(object)Ek9());
		((Control)this).get_Controls().Add((Control)(object)Yg6());
		((Control)this).get_Controls().Add((Control)(object)Ww7());
		((Control)this).get_Controls().Add((Control)(object)f4K());
		((Control)this).get_Controls().Add((Control)(object)r5C());
		((Control)this).get_Controls().Add((Control)(object)this.Kc2());
		((Control)this).get_Controls().Add((Control)(object)e8W());
		((Control)this).get_Controls().Add((Control)(object)m1Z());
		((Control)this).get_Controls().Add((Control)(object)Ki0());
		((Control)this).get_Controls().Add((Control)(object)k4P());
		((Control)this).get_Controls().Add((Control)(object)Ax4());
		((Control)this).get_Controls().Add((Control)(object)n5A());
		((Control)this).get_Controls().Add((Control)(object)a7Q());
		((Control)this).get_Controls().Add((Control)(object)x3F());
		((Control)this).get_Controls().Add((Control)(object)Qk1());
		((Control)this).get_Controls().Add((Control)(object)Tb0());
		((Control)this).get_Controls().Add((Control)(object)Gw7());
		((Control)this).get_Controls().Add((Control)(object)Ly3());
		((Control)this).get_Controls().Add((Control)(object)z8W());
		((Control)this).get_Controls().Add((Control)(object)Nj7());
		((Control)this).get_Controls().Add((Control)(object)Nd1());
		((Control)this).get_Controls().Add((Control)(object)Dz6());
		((Control)this).get_Controls().Add((Control)(object)j8Y());
		((Control)this).get_Controls().Add((Control)(object)Rj1());
		((Control)this).get_Controls().Add((Control)(object)Xq4());
		((Control)this).get_Controls().Add((Control)(object)Ye1());
		((Control)this).get_Controls().Add((Control)(object)q0H());
		((Control)this).get_Controls().Add((Control)(object)this.Tw0());
		((Control)this).get_Controls().Add((Control)(object)Wd8());
		((Control)this).get_Controls().Add((Control)(object)x1C());
		((Control)this).get_Controls().Add((Control)(object)Yn4());
		((Control)this).get_Controls().Add((Control)(object)Fy1());
		((Control)this).get_Controls().Add((Control)(object)w4K());
		((Control)this).get_Controls().Add((Control)(object)Rp6());
		((Control)this).get_Controls().Add((Control)(object)Bw8());
		((Control)this).get_Controls().Add((Control)(object)j3X());
		((Control)this).get_Controls().Add((Control)(object)Gy9());
		((Control)this).get_Controls().Add((Control)(object)Hy9());
		((Control)this).get_Controls().Add((Control)(object)Xq8());
		((Control)this).get_Controls().Add((Control)(object)Jj3());
		((Control)this).get_Controls().Add((Control)(object)Ab4());
		((Control)this).get_Controls().Add((Control)(object)Bw5());
		((Control)this).get_Controls().Add((Control)(object)Ca4());
		((Control)this).get_Controls().Add((Control)(object)z5G());
		((Control)this).get_Controls().Add((Control)(object)y5G());
		((Control)this).get_Controls().Add((Control)(object)y3J());
		((Control)this).get_Controls().Add((Control)(object)Bo7());
		((Control)this).get_Controls().Add((Control)(object)x1W());
		((Control)this).get_Controls().Add((Control)(object)i7B());
		((Control)this).get_Controls().Add((Control)(object)Kg8());
		((Control)this).get_Controls().Add((Control)(object)Lp8());
		((Control)this).get_Controls().Add((Control)(object)x7L9());
		((Control)this).get_Controls().Add((Control)(object)n2WP());
		((Control)this).get_Controls().Add((Control)(object)Lo0e());
		((Control)this).get_Controls().Add((Control)(object)Bf2s());
		((Control)this).get_Controls().Add((Control)(object)n8SB());
		((Control)this).get_Controls().Add((Control)(object)n1BG());
		((Control)this).get_Controls().Add((Control)(object)Dk3y());
		((Control)this).get_Controls().Add((Control)(object)r3S9());
		((Control)this).get_Controls().Add((Control)(object)Cy86());
		((Control)this).get_Controls().Add((Control)(object)Zq2z());
		((Control)this).get_Controls().Add((Control)(object)Cj75());
		((Control)this).get_Controls().Add((Control)(object)r4AX());
		((Control)this).get_Controls().Add((Control)(object)Tk0d());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 4");
		((ISupportInitialize)Kc46()).EndInit();
		((ISupportInitialize)e6FL()).EndInit();
		((ISupportInitialize)Bb08()).EndInit();
		((ISupportInitialize)c3X0()).EndInit();
		((ISupportInitialize)t3L9()).EndInit();
		((ISupportInitialize)d5E7()).EndInit();
		((ISupportInitialize)Et13()).EndInit();
		((ISupportInitialize)o3TL()).EndInit();
		((ISupportInitialize)p5T0()).EndInit();
		((ISupportInitialize)m3A6()).EndInit();
		((ISupportInitialize)n3MA()).EndInit();
		((ISupportInitialize)Zo3q()).EndInit();
		((ISupportInitialize)Fx90()).EndInit();
		((ISupportInitialize)r7M0()).EndInit();
		((ISupportInitialize)g8NK()).EndInit();
		((ISupportInitialize)Rj1m()).EndInit();
		((ISupportInitialize)Da9t()).EndInit();
		((ISupportInitialize)Xn75()).EndInit();
		((ISupportInitialize)Xr94()).EndInit();
		((ISupportInitialize)Rc37()).EndInit();
		((ISupportInitialize)z0Z5()).EndInit();
		((ISupportInitialize)Zi13()).EndInit();
		((ISupportInitialize)p1GB()).EndInit();
		((ISupportInitialize)Hr6f()).EndInit();
		((ISupportInitialize)Fn13()).EndInit();
		((ISupportInitialize)s2FW()).EndInit();
		((ISupportInitialize)Df39()).EndInit();
		((ISupportInitialize)Sa83()).EndInit();
		((ISupportInitialize)o8Z2()).EndInit();
		((ISupportInitialize)j4E0()).EndInit();
		((ISupportInitialize)a7M6()).EndInit();
		((ISupportInitialize)x3H8()).EndInit();
		((ISupportInitialize)Yn37()).EndInit();
		((ISupportInitialize)b5N1()).EndInit();
		((ISupportInitialize)Ym39()).EndInit();
		((ISupportInitialize)Ci5r()).EndInit();
		((ISupportInitialize)b3EM()).EndInit();
		((ISupportInitialize)Mm56()).EndInit();
		((ISupportInitialize)Go7w()).EndInit();
		((ISupportInitialize)Xm41()).EndInit();
		((ISupportInitialize)p0W()).EndInit();
		((ISupportInitialize)Gp4()).EndInit();
		((ISupportInitialize)Qo4()).EndInit();
		((ISupportInitialize)z7Y()).EndInit();
		((ISupportInitialize)p4C()).EndInit();
		((ISupportInitialize)Cp7()).EndInit();
		((ISupportInitialize)d7X()).EndInit();
		((ISupportInitialize)s1A()).EndInit();
		((ISupportInitialize)Qs5()).EndInit();
		((ISupportInitialize)a1L()).EndInit();
		((ISupportInitialize)Cw3()).EndInit();
		((ISupportInitialize)Ab2()).EndInit();
		((ISupportInitialize)Yo7()).EndInit();
		((ISupportInitialize)m6Z()).EndInit();
		((ISupportInitialize)Kf0()).EndInit();
		((ISupportInitialize)Ha5()).EndInit();
		((ISupportInitialize)La2()).EndInit();
		((ISupportInitialize)Wq4()).EndInit();
		((ISupportInitialize)Mp2()).EndInit();
		((ISupportInitialize)j7Y()).EndInit();
		((ISupportInitialize)Xt8()).EndInit();
		((ISupportInitialize)Tz0()).EndInit();
		((ISupportInitialize)g7H()).EndInit();
		((ISupportInitialize)Qo1()).EndInit();
		((ISupportInitialize)w6H()).EndInit();
		((ISupportInitialize)n9Z()).EndInit();
		((ISupportInitialize)Kp8()).EndInit();
		((ISupportInitialize)Qd3()).EndInit();
		((ISupportInitialize)this.Tw0()).EndInit();
		((ISupportInitialize)As4()).EndInit();
		((ISupportInitialize)a0Y()).EndInit();
		((ISupportInitialize)Jq4()).EndInit();
		((ISupportInitialize)Pt2()).EndInit();
		((ISupportInitialize)Gb2()).EndInit();
		((ISupportInitialize)c5E()).EndInit();
		((ISupportInitialize)j2R()).EndInit();
		((ISupportInitialize)o3T()).EndInit();
		((ISupportInitialize)Kt1()).EndInit();
		((ISupportInitialize)Fk0()).EndInit();
		((ISupportInitialize)e3H()).EndInit();
		((ISupportInitialize)Cr6()).EndInit();
		((ISupportInitialize)w2J()).EndInit();
		((ISupportInitialize)p2G()).EndInit();
		((ISupportInitialize)s5Q()).EndInit();
		((ISupportInitialize)Lp1()).EndInit();
		((ISupportInitialize)Py8()).EndInit();
		((ISupportInitialize)z4G()).EndInit();
		((ISupportInitialize)o6L()).EndInit();
		((ISupportInitialize)Pw3()).EndInit();
		((ISupportInitialize)m0R()).EndInit();
		((ISupportInitialize)k4L()).EndInit();
		((ISupportInitialize)Zy0()).EndInit();
		((ISupportInitialize)s5Z()).EndInit();
		((ISupportInitialize)Kc6()).EndInit();
		((ISupportInitialize)t6T()).EndInit();
		((ISupportInitialize)n6S()).EndInit();
		((ISupportInitialize)Di4()).EndInit();
		((ISupportInitialize)Gj7()).EndInit();
		((ISupportInitialize)c8T()).EndInit();
		((ISupportInitialize)g8L()).EndInit();
		((ISupportInitialize)Xe6()).EndInit();
		((ISupportInitialize)m3N()).EndInit();
		((ISupportInitialize)Cx4()).EndInit();
		((ISupportInitialize)z2X()).EndInit();
		((ISupportInitialize)Pe8()).EndInit();
		((ISupportInitialize)Qt9()).EndInit();
		((ISupportInitialize)e1Z()).EndInit();
		((ISupportInitialize)this.Kc2()).EndInit();
		((ISupportInitialize)i4J()).EndInit();
		((ISupportInitialize)Cx5()).EndInit();
		((ISupportInitialize)y1M()).EndInit();
		((ISupportInitialize)z8M()).EndInit();
		((ISupportInitialize)this.e6A()).EndInit();
		((ISupportInitialize)k3F()).EndInit();
		((ISupportInitialize)r4A()).EndInit();
		((ISupportInitialize)Kc4()).EndInit();
		((ISupportInitialize)n2R()).EndInit();
		((ISupportInitialize)Pp5()).EndInit();
		((ISupportInitialize)k6S()).EndInit();
		((ISupportInitialize)d6A()).EndInit();
		((ISupportInitialize)Zi0()).EndInit();
		((ISupportInitialize)Kg2()).EndInit();
		((ISupportInitialize)Dp8()).EndInit();
		((ISupportInitialize)Qo8()).EndInit();
		((ISupportInitialize)r3W()).EndInit();
		((ISupportInitialize)o3K()).EndInit();
		((ISupportInitialize)Kr4()).EndInit();
		((ISupportInitialize)Qr3()).EndInit();
		((ISupportInitialize)Cq4()).EndInit();
		((ISupportInitialize)De3()).EndInit();
		((ISupportInitialize)Wo4()).EndInit();
		((ISupportInitialize)w8Q()).EndInit();
		((ISupportInitialize)Yc4()).EndInit();
		((ISupportInitialize)z9R()).EndInit();
		((ISupportInitialize)b7R()).EndInit();
		((ISupportInitialize)Dq4()).EndInit();
		((ISupportInitialize)a4E()).EndInit();
		((ISupportInitialize)Ak6()).EndInit();
		((ISupportInitialize)this.e6A()).EndInit();
		((ISupportInitialize)Sk4()).EndInit();
		((ISupportInitialize)b2R()).EndInit();
		((ISupportInitialize)Zi7()).EndInit();
		((ISupportInitialize)b0N()).EndInit();
		((ISupportInitialize)Bq5()).EndInit();
		((ISupportInitialize)m0L()).EndInit();
		((ISupportInitialize)Kq3()).EndInit();
		((ISupportInitialize)t3X()).EndInit();
		((ISupportInitialize)i6M()).EndInit();
		((ISupportInitialize)w6R()).EndInit();
		((ISupportInitialize)Sb8()).EndInit();
		((ISupportInitialize)Ek9()).EndInit();
		((ISupportInitialize)Yg6()).EndInit();
		((ISupportInitialize)Ww7()).EndInit();
		((ISupportInitialize)f4K()).EndInit();
		((ISupportInitialize)r5C()).EndInit();
		((ISupportInitialize)this.Kc2()).EndInit();
		((ISupportInitialize)e8W()).EndInit();
		((ISupportInitialize)m1Z()).EndInit();
		((ISupportInitialize)Ki0()).EndInit();
		((ISupportInitialize)k4P()).EndInit();
		((Control)Zq2z()).ResumeLayout(false);
		((Control)Zq2z()).PerformLayout();
		((ISupportInitialize)i0WK()).EndInit();
		((ISupportInitialize)Zn93()).EndInit();
		((ISupportInitialize)Dq74()).EndInit();
		((ISupportInitialize)r4AX()).EndInit();
		((ISupportInitialize)Tk0d()).EndInit();
		((Control)x5S6()).ResumeLayout(false);
		((ISupportInitialize)d8RL()).EndInit();
		((Control)Hs78()).ResumeLayout(false);
		((Control)Hs78()).PerformLayout();
		((Control)g3JD()).ResumeLayout(false);
		((Control)g3JD()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Yx4a()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn54(TextBox m0N6)
	{
		_txtProvisional = m0N6;
	}

	[SpecialName]
	internal virtual TextBox Ri1r()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5Q4(TextBox p3QW)
	{
		TextBox val = (j = p3QW);
	}

	[SpecialName]
	internal virtual Label Ai78()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6MH(Label w1GP)
	{
		_Label1 = w1GP;
	}

	[SpecialName]
	internal virtual Label Kb2d()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls19(Label z1Q4)
	{
		Label val = (n = z1Q4);
	}

	[SpecialName]
	internal virtual PictureBox Kc46()
	{
		return _PictureBox141;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5T6(PictureBox Nw1p)
	{
		_PictureBox141 = Nw1p;
	}

	[SpecialName]
	internal virtual PictureBox e6FL()
	{
		return _PictureBox142;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7GY(PictureBox Jk35)
	{
		_PictureBox142 = Jk35;
	}

	[SpecialName]
	internal virtual PictureBox Bb08()
	{
		return _PictureBox143;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sq54(PictureBox Mz81)
	{
		_PictureBox143 = Mz81;
	}

	[SpecialName]
	internal virtual PictureBox c3X0()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp0d(PictureBox Hs7i)
	{
		PictureBox val = (d = Hs7i);
	}

	[SpecialName]
	internal virtual PictureBox t3L9()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9H0(PictureBox Mn9x)
	{
		PictureBox val = (a = Mn9x);
	}

	[SpecialName]
	internal virtual PictureBox d5E7()
	{
		return _PictureBox146;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9DQ(PictureBox k6W8)
	{
		_PictureBox146 = k6W8;
	}

	[SpecialName]
	internal virtual PictureBox Et13()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cz68(PictureBox b2JF)
	{
		_PictureBox147 = b2JF;
	}

	[SpecialName]
	internal virtual PictureBox o3TL()
	{
		return _PictureBox148;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4B8(PictureBox Tx14)
	{
		_PictureBox148 = Tx14;
	}

	[SpecialName]
	internal virtual PictureBox p5T0()
	{
		return _PictureBox149;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6C1(PictureBox Xn6q)
	{
		_PictureBox149 = Xn6q;
	}

	[SpecialName]
	internal virtual PictureBox m3A6()
	{
		return _PictureBox150;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8MG(PictureBox Pz53)
	{
		_PictureBox150 = Pz53;
	}

	[SpecialName]
	internal virtual PictureBox n3MA()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St59(PictureBox e4MB)
	{
		PictureBox val = (F = e4MB);
	}

	[SpecialName]
	internal virtual PictureBox Zo3q()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4PT(PictureBox Pp23)
	{
		PictureBox val = (t = Pp23);
	}

	[SpecialName]
	internal virtual PictureBox Fx90()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xm6t(PictureBox Mc85)
	{
		PictureBox val = (r = Mc85);
	}

	[SpecialName]
	internal virtual PictureBox r7M0()
	{
		return _PictureBox154;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cr12(PictureBox Hk5i)
	{
		_PictureBox154 = Hk5i;
	}

	[SpecialName]
	internal virtual PictureBox g8NK()
	{
		return _PictureBox155;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me6t(PictureBox Bj4g)
	{
		_PictureBox155 = Bj4g;
	}

	[SpecialName]
	internal virtual PictureBox Rj1m()
	{
		return _PictureBox156;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw7p(PictureBox d6S2)
	{
		_PictureBox156 = d6S2;
	}

	[SpecialName]
	internal virtual PictureBox Da9t()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void La8d(PictureBox Yz3j)
	{
		PictureBox val = (O = Yz3j);
	}

	[SpecialName]
	internal virtual PictureBox Xn75()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3AN(PictureBox o8DT)
	{
		PictureBox val = (H = o8DT);
	}

	[SpecialName]
	internal virtual PictureBox Xr94()
	{
		return _PictureBox159;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5RC(PictureBox Hq6y)
	{
		_PictureBox159 = Hq6y;
	}

	[SpecialName]
	internal virtual PictureBox Rc37()
	{
		return _PictureBox160;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8J6(PictureBox r9C1)
	{
		_PictureBox160 = r9C1;
	}

	[SpecialName]
	internal virtual PictureBox z0Z5()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2WD(PictureBox Yf2x)
	{
		PictureBox val = (e = Yf2x);
	}

	[SpecialName]
	internal virtual PictureBox Zi13()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz15(PictureBox Kd46)
	{
		PictureBox val = (K = Kd46);
	}

	[SpecialName]
	internal virtual PictureBox p1GB()
	{
		return _PictureBox123;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq29(PictureBox Dk2f)
	{
		_PictureBox123 = Dk2f;
	}

	[SpecialName]
	internal virtual PictureBox Hr6f()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qj7k(PictureBox m9JM)
	{
		PictureBox val = (w = m9JM);
	}

	[SpecialName]
	internal virtual PictureBox Fn13()
	{
		return _PictureBox125;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ct35(PictureBox Bx8r)
	{
		_PictureBox125 = Bx8r;
	}

	[SpecialName]
	internal virtual PictureBox s2FW()
	{
		return _PictureBox126;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ax3o(PictureBox x3FW)
	{
		_PictureBox126 = x3FW;
	}

	[SpecialName]
	internal virtual PictureBox Df39()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0LN(PictureBox Qe4q)
	{
		PictureBox val = (G = Qe4q);
	}

	[SpecialName]
	internal virtual PictureBox Sa83()
	{
		return _PictureBox128;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps70(PictureBox Kq27)
	{
		_PictureBox128 = Kq27;
	}

	[SpecialName]
	internal virtual PictureBox o8Z2()
	{
		return _PictureBox129;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jc7e(PictureBox Le78)
	{
		_PictureBox129 = Le78;
	}

	[SpecialName]
	internal virtual PictureBox j4E0()
	{
		return _PictureBox130;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1SP(PictureBox i9CH)
	{
		_PictureBox130 = i9CH;
	}

	[SpecialName]
	internal virtual PictureBox a7M6()
	{
		return _PictureBox131;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f1KS(PictureBox Mr1p)
	{
		_PictureBox131 = Mr1p;
	}

	[SpecialName]
	internal virtual PictureBox x3H8()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb3t(PictureBox t0L3)
	{
		PictureBox val = (b = t0L3);
	}

	[SpecialName]
	internal virtual PictureBox Yn37()
	{
		return _PictureBox133;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nb34(PictureBox Ys6p)
	{
		_PictureBox133 = Ys6p;
	}

	[SpecialName]
	internal virtual PictureBox b5N1()
	{
		return _PictureBox134;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Td5y(PictureBox Gd97)
	{
		_PictureBox134 = Gd97;
	}

	[SpecialName]
	internal virtual PictureBox Ym39()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Se2w(PictureBox q1Y5)
	{
		PictureBox val = (x = q1Y5);
	}

	[SpecialName]
	internal virtual PictureBox Ci5r()
	{
		return _PictureBox136;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bz5d(PictureBox c2Z6)
	{
		_PictureBox136 = c2Z6;
	}

	[SpecialName]
	internal virtual PictureBox b3EM()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg57(PictureBox Cz70)
	{
		PictureBox val = (p = Cz70);
	}

	[SpecialName]
	internal virtual PictureBox Mm56()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1M5(PictureBox p4QZ)
	{
		PictureBox val = (i = p4QZ);
	}

	[SpecialName]
	internal virtual PictureBox Go7w()
	{
		return _PictureBox139;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void To46(PictureBox d6JF)
	{
		_PictureBox139 = d6JF;
	}

	[SpecialName]
	internal virtual PictureBox Xm41()
	{
		return _PictureBox140;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yc4(PictureBox p6Z)
	{
		_PictureBox140 = p6Z;
	}

	[SpecialName]
	internal virtual PictureBox p0W()
	{
		return _PictureBox101;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So9(PictureBox Jw1)
	{
		_PictureBox101 = Jw1;
	}

	[SpecialName]
	internal virtual PictureBox Gp4()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd4(PictureBox w6G)
	{
		PictureBox val = (s = w6G);
	}

	[SpecialName]
	internal virtual PictureBox Qo4()
	{
		return _PictureBox103;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rj0(PictureBox a1S)
	{
		_PictureBox103 = a1S;
	}

	[SpecialName]
	internal virtual PictureBox z7Y()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq7(PictureBox Rd1)
	{
		PictureBox val = (Q = Rd1);
	}

	[SpecialName]
	internal virtual PictureBox p4C()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7Q(PictureBox o5A)
	{
		PictureBox val = (L = o5A);
	}

	[SpecialName]
	internal virtual PictureBox Cp7()
	{
		return _PictureBox106;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3L(PictureBox Fa1)
	{
		_PictureBox106 = Fa1;
	}

	[SpecialName]
	internal virtual PictureBox d7X()
	{
		return _PictureBox107;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1G(PictureBox Ma7)
	{
		_PictureBox107 = Ma7;
	}

	[SpecialName]
	internal virtual PictureBox s1A()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1K(PictureBox Si9)
	{
		PictureBox val = (Y = Si9);
	}

	[SpecialName]
	internal virtual PictureBox Qs5()
	{
		return _PictureBox109;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb6(PictureBox Lk9)
	{
		_PictureBox109 = Lk9;
	}

	[SpecialName]
	internal virtual PictureBox a1L()
	{
		return _PictureBox110;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft5(PictureBox g0P)
	{
		_PictureBox110 = g0P;
	}

	[SpecialName]
	internal virtual PictureBox Cw3()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5H(PictureBox n0X)
	{
		PictureBox val = (U = n0X);
	}

	[SpecialName]
	internal virtual PictureBox Ab2()
	{
		return _PictureBox112;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mw0(PictureBox w5Z)
	{
		_PictureBox112 = w5Z;
	}

	[SpecialName]
	internal virtual PictureBox Yo7()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2H(PictureBox d3Y)
	{
		PictureBox val = (m = d3Y);
	}

	[SpecialName]
	internal virtual PictureBox m6Z()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2G(PictureBox m9X)
	{
		PictureBox val = (c = m9X);
	}

	[SpecialName]
	internal virtual PictureBox Kf0()
	{
		return _PictureBox115;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zz6(PictureBox Pi6)
	{
		_PictureBox115 = Pi6;
	}

	[SpecialName]
	internal virtual PictureBox Ha5()
	{
		return _PictureBox116;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2S(PictureBox b8T)
	{
		_PictureBox116 = b8T;
	}

	[SpecialName]
	internal virtual PictureBox La2()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9W(PictureBox Cy9)
	{
		PictureBox val = (z = Cy9);
	}

	[SpecialName]
	internal virtual PictureBox Wq4()
	{
		return jV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7Q(PictureBox n4L)
	{
		PictureBox val = (jV = n4L);
	}

	[SpecialName]
	internal virtual PictureBox Mp2()
	{
		return _PictureBox119;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7K(PictureBox p2T)
	{
		_PictureBox119 = p2T;
	}

	[SpecialName]
	internal virtual PictureBox j7Y()
	{
		return jj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ld7(PictureBox Pi9)
	{
		PictureBox val = (jj = Pi9);
	}

	[SpecialName]
	internal virtual PictureBox Xt8()
	{
		return jn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq8(PictureBox Gc3)
	{
		PictureBox val = (jn = Gc3);
	}

	[SpecialName]
	internal virtual PictureBox Tz0()
	{
		return jd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yr3(PictureBox p4Q)
	{
		PictureBox val = (jd = p4Q);
	}

	[SpecialName]
	internal virtual PictureBox g7H()
	{
		return ja;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hb9(PictureBox w2X)
	{
		PictureBox val = (ja = w2X);
	}

	[SpecialName]
	internal virtual PictureBox Qo1()
	{
		return _PictureBox84;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8S(PictureBox Cz6)
	{
		_PictureBox84 = Cz6;
	}

	[SpecialName]
	internal virtual PictureBox w6H()
	{
		return jF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2M(PictureBox z6Z)
	{
		PictureBox val = (jF = z6Z);
	}

	[SpecialName]
	internal virtual PictureBox n9Z()
	{
		return _PictureBox86;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7P(PictureBox a1L)
	{
		_PictureBox86 = a1L;
	}

	[SpecialName]
	internal virtual PictureBox Kp8()
	{
		return jt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Li4(PictureBox g5B)
	{
		PictureBox val = (jt = g5B);
	}

	[SpecialName]
	internal virtual PictureBox Qd3()
	{
		return _PictureBox88;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9H(PictureBox b1K)
	{
		_PictureBox88 = b1K;
	}

	[SpecialName]
	internal virtual PictureBox Tw0()
	{
		return _PictureBox89;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ks6(PictureBox Wi8)
	{
		_PictureBox89 = Wi8;
	}

	[SpecialName]
	internal virtual PictureBox As4()
	{
		return jr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp0(PictureBox Lf9)
	{
		PictureBox val = (jr = Lf9);
	}

	[SpecialName]
	internal virtual PictureBox a0Y()
	{
		return _PictureBox91;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xm0(PictureBox w2Z)
	{
		_PictureBox91 = w2Z;
	}

	[SpecialName]
	internal virtual PictureBox Jq4()
	{
		return jO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp3(PictureBox k2N)
	{
		PictureBox val = (jO = k2N);
	}

	[SpecialName]
	internal virtual PictureBox Pt2()
	{
		return jH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5K(PictureBox Lp0)
	{
		PictureBox val = (jH = Lp0);
	}

	[SpecialName]
	internal virtual PictureBox Gb2()
	{
		return je;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi5(PictureBox Cr0)
	{
		PictureBox val = (je = Cr0);
	}

	[SpecialName]
	internal virtual PictureBox c5E()
	{
		return _PictureBox95;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jd7(PictureBox x7S)
	{
		_PictureBox95 = x7S;
	}

	[SpecialName]
	internal virtual PictureBox j2R()
	{
		return _PictureBox96;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2Y(PictureBox r6R)
	{
		_PictureBox96 = r6R;
	}

	[SpecialName]
	internal virtual PictureBox o3T()
	{
		return jK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6L(PictureBox b8F)
	{
		PictureBox val = (jK = b8F);
	}

	[SpecialName]
	internal virtual PictureBox Kt1()
	{
		return jw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bp1(PictureBox r8J)
	{
		PictureBox val = (jw = r8J);
	}

	[SpecialName]
	internal virtual PictureBox Fk0()
	{
		return jG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd8(PictureBox Aw2)
	{
		PictureBox val = (jG = Aw2);
	}

	[SpecialName]
	internal virtual PictureBox e3H()
	{
		return _PictureBox100;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga1(PictureBox Ed4)
	{
		_PictureBox100 = Ed4;
	}

	[SpecialName]
	internal virtual PictureBox Cr6()
	{
		return jb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1Q(PictureBox Lq5)
	{
		PictureBox val = (jb = Lq5);
	}

	[SpecialName]
	internal virtual PictureBox w2J()
	{
		return jx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj1(PictureBox j6Z)
	{
		PictureBox val = (jx = j6Z);
	}

	[SpecialName]
	internal virtual PictureBox p2G()
	{
		return jp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1T(PictureBox b1T)
	{
		PictureBox val = (jp = b1T);
	}

	[SpecialName]
	internal virtual PictureBox s5Q()
	{
		return _PictureBox64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln6(PictureBox Bk8)
	{
		_PictureBox64 = Bk8;
	}

	[SpecialName]
	internal virtual PictureBox Lp1()
	{
		return _PictureBox65;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zi3(PictureBox Nk9)
	{
		_PictureBox65 = Nk9;
	}

	[SpecialName]
	internal virtual PictureBox Py8()
	{
		return ji;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5B(PictureBox m6E)
	{
		PictureBox val = (ji = m6E);
	}

	[SpecialName]
	internal virtual PictureBox z4G()
	{
		return js;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx1(PictureBox Mp6)
	{
		PictureBox val = (js = Mp6);
	}

	[SpecialName]
	internal virtual PictureBox o6L()
	{
		return _PictureBox68;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ae3(PictureBox z4S)
	{
		_PictureBox68 = z4S;
	}

	[SpecialName]
	internal virtual PictureBox Pw3()
	{
		return _PictureBox69;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0H(PictureBox o4C)
	{
		_PictureBox69 = o4C;
	}

	[SpecialName]
	internal virtual PictureBox m0R()
	{
		return _PictureBox70;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0Q(PictureBox d1A)
	{
		_PictureBox70 = d1A;
	}

	[SpecialName]
	internal virtual PictureBox k4L()
	{
		return jQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Se8(PictureBox Sg6)
	{
		PictureBox val = (jQ = Sg6);
	}

	[SpecialName]
	internal virtual PictureBox Zy0()
	{
		return _PictureBox72;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5G(PictureBox Ma1)
	{
		_PictureBox72 = Ma1;
	}

	[SpecialName]
	internal virtual PictureBox s5Z()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8F(PictureBox n5M)
	{
		_PictureBox73 = n5M;
	}

	[SpecialName]
	internal virtual PictureBox Kc6()
	{
		return _PictureBox74;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5X(PictureBox x3K)
	{
		_PictureBox74 = x3K;
	}

	[SpecialName]
	internal virtual PictureBox t6T()
	{
		return jL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7K(PictureBox Ef6)
	{
		PictureBox val = (jL = Ef6);
	}

	[SpecialName]
	internal virtual PictureBox n6S()
	{
		return _PictureBox76;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kz3(PictureBox Li8)
	{
		_PictureBox76 = Li8;
	}

	[SpecialName]
	internal virtual PictureBox Di4()
	{
		return jY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zd4(PictureBox Xj6)
	{
		PictureBox val = (jY = Xj6);
	}

	[SpecialName]
	internal virtual PictureBox Gj7()
	{
		return jU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2N(PictureBox y7W)
	{
		PictureBox val = (jU = y7W);
	}

	[SpecialName]
	internal virtual PictureBox c8T()
	{
		return jm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8H(PictureBox Zy8)
	{
		PictureBox val = (jm = Zy8);
	}

	[SpecialName]
	internal virtual PictureBox g8L()
	{
		return jc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2E(PictureBox Zi2)
	{
		PictureBox val = (jc = Zi2);
	}

	[SpecialName]
	internal virtual PictureBox Xe6()
	{
		return jz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ri8(PictureBox s9X)
	{
		PictureBox val = (jz = s9X);
	}

	[SpecialName]
	internal virtual PictureBox m3N()
	{
		return _PictureBox42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ck1(PictureBox q8C)
	{
		_PictureBox42 = q8C;
	}

	[SpecialName]
	internal virtual PictureBox Cx4()
	{
		return nV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5M(PictureBox a9Q)
	{
		PictureBox val = (nV = a9Q);
	}

	[SpecialName]
	internal virtual PictureBox z2X()
	{
		return _PictureBox44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4P(PictureBox p8D)
	{
		_PictureBox44 = p8D;
	}

	[SpecialName]
	internal virtual PictureBox Pe8()
	{
		return nj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aa0(PictureBox Hm4)
	{
		PictureBox val = (nj = Hm4);
	}

	[SpecialName]
	internal virtual PictureBox Qt9()
	{
		return _PictureBox46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gk1(PictureBox b4P)
	{
		_PictureBox46 = b4P;
	}

	[SpecialName]
	internal virtual PictureBox e1Z()
	{
		return nn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf7(PictureBox e6W)
	{
		PictureBox val = (nn = e6W);
	}

	[SpecialName]
	internal virtual PictureBox Kc2()
	{
		return nd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo4(PictureBox Mp0)
	{
		PictureBox val = (nd = Mp0);
	}

	[SpecialName]
	internal virtual PictureBox i4J()
	{
		return na;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pb1(PictureBox Nw7)
	{
		PictureBox val = (na = Nw7);
	}

	[SpecialName]
	internal virtual PictureBox Cx5()
	{
		return _PictureBox50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0B(PictureBox Ke5)
	{
		_PictureBox50 = Ke5;
	}

	[SpecialName]
	internal virtual PictureBox y1M()
	{
		return nF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9P(PictureBox Pd0)
	{
		PictureBox val = (nF = Pd0);
	}

	[SpecialName]
	internal virtual PictureBox z8M()
	{
		return nt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2H(PictureBox Gc0)
	{
		PictureBox val = (nt = Gc0);
	}

	[SpecialName]
	internal virtual PictureBox e6A()
	{
		return _PictureBox53;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg1(PictureBox z7Q)
	{
		_PictureBox53 = z7Q;
	}

	[SpecialName]
	internal virtual PictureBox k3F()
	{
		return nr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gw1(PictureBox Wb1)
	{
		PictureBox val = (nr = Wb1);
	}

	[SpecialName]
	internal virtual PictureBox r4A()
	{
		return _PictureBox55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp7(PictureBox La8)
	{
		_PictureBox55 = La8;
	}

	[SpecialName]
	internal virtual PictureBox Kc4()
	{
		return nO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd5(PictureBox d1H)
	{
		PictureBox val = (nO = d1H);
	}

	[SpecialName]
	internal virtual PictureBox n2R()
	{
		return nH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7P(PictureBox Ji0)
	{
		PictureBox val = (nH = Ji0);
	}

	[SpecialName]
	internal virtual PictureBox Pp5()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2Q(PictureBox n7E)
	{
		_PictureBox58 = n7E;
	}

	[SpecialName]
	internal virtual PictureBox k6S()
	{
		return _PictureBox59;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6B(PictureBox e2P)
	{
		_PictureBox59 = e2P;
	}

	[SpecialName]
	internal virtual PictureBox d6A()
	{
		return _PictureBox60;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3Q(PictureBox b3C)
	{
		_PictureBox60 = b3C;
	}

	[SpecialName]
	internal virtual PictureBox Zi0()
	{
		return _PictureBox21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1K(PictureBox Bs4)
	{
		_PictureBox21 = Bs4;
	}

	[SpecialName]
	internal virtual PictureBox Kg2()
	{
		return ne;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0K(PictureBox Db0)
	{
		PictureBox val = (ne = Db0);
	}

	[SpecialName]
	internal virtual PictureBox Dp8()
	{
		return nK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bb0(PictureBox Ho6)
	{
		PictureBox val = (nK = Ho6);
	}

	[SpecialName]
	internal virtual PictureBox Qo8()
	{
		return nw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4C(PictureBox Ja5)
	{
		PictureBox val = (nw = Ja5);
	}

	[SpecialName]
	internal virtual PictureBox r3W()
	{
		return _PictureBox25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi4(PictureBox s0J)
	{
		_PictureBox25 = s0J;
	}

	[SpecialName]
	internal virtual PictureBox o3K()
	{
		return _PictureBox26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz7(PictureBox Pk6)
	{
		_PictureBox26 = Pk6;
	}

	[SpecialName]
	internal virtual PictureBox Kr4()
	{
		return nG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2W(PictureBox g3Q)
	{
		PictureBox val = (nG = g3Q);
	}

	[SpecialName]
	internal virtual PictureBox Qr3()
	{
		return _PictureBox28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5G(PictureBox Ef8)
	{
		_PictureBox28 = Ef8;
	}

	[SpecialName]
	internal virtual PictureBox Cq4()
	{
		return nb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo6(PictureBox d0F)
	{
		PictureBox val = (nb = d0F);
	}

	[SpecialName]
	internal virtual PictureBox De3()
	{
		return nx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4X(PictureBox Sr6)
	{
		PictureBox val = (nx = Sr6);
	}

	[SpecialName]
	internal virtual PictureBox Wo4()
	{
		return _PictureBox31;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp3(PictureBox r4J)
	{
		_PictureBox31 = r4J;
	}

	[SpecialName]
	internal virtual PictureBox w8Q()
	{
		return np;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3Q(PictureBox Pi8)
	{
		PictureBox val = (np = Pi8);
	}

	[SpecialName]
	internal virtual PictureBox Yc4()
	{
		return _PictureBox33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb3(PictureBox x1Q)
	{
		_PictureBox33 = x1Q;
	}

	[SpecialName]
	internal virtual PictureBox z9R()
	{
		return ni;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1N(PictureBox Wt8)
	{
		PictureBox val = (ni = Wt8);
	}

	[SpecialName]
	internal virtual PictureBox b7R()
	{
		return ns;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zw1(PictureBox w0A)
	{
		PictureBox val = (ns = w0A);
	}

	[SpecialName]
	internal virtual PictureBox Dq4()
	{
		return nQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2T(PictureBox Mm5)
	{
		PictureBox val = (nQ = Mm5);
	}

	[SpecialName]
	internal virtual PictureBox a4E()
	{
		return _PictureBox37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md4(PictureBox Ff3)
	{
		_PictureBox37 = Ff3;
	}

	[SpecialName]
	internal virtual PictureBox Ak6()
	{
		return _PictureBox38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0Y(PictureBox Bp8)
	{
		_PictureBox38 = Bp8;
	}

	[SpecialName]
	internal virtual PictureBox e6A()
	{
		return nL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4R(PictureBox c8M)
	{
		PictureBox val = (nL = c8M);
	}

	[SpecialName]
	internal virtual PictureBox Sk4()
	{
		return _PictureBox40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m8T(PictureBox y0C)
	{
		_PictureBox40 = y0C;
	}

	[SpecialName]
	internal virtual PictureBox b2R()
	{
		return _PictureBox20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2K(PictureBox e7J)
	{
		_PictureBox20 = e7J;
	}

	[SpecialName]
	internal virtual PictureBox Zi7()
	{
		return nY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bi4(PictureBox q6T)
	{
		PictureBox val = (nY = q6T);
	}

	[SpecialName]
	internal virtual PictureBox b0N()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wk0(PictureBox d4N)
	{
		_PictureBox18 = d4N;
	}

	[SpecialName]
	internal virtual PictureBox Bq5()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yw2(PictureBox g7Z)
	{
		_PictureBox17 = g7Z;
	}

	[SpecialName]
	internal virtual PictureBox m0L()
	{
		return nU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kw9(PictureBox Eq3)
	{
		PictureBox val = (nU = Eq3);
	}

	[SpecialName]
	internal virtual PictureBox Kq3()
	{
		return nm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9L(PictureBox x1H)
	{
		PictureBox val = (nm = x1H);
	}

	[SpecialName]
	internal virtual PictureBox t3X()
	{
		return nc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3G(PictureBox Xg1)
	{
		PictureBox val = (nc = Xg1);
	}

	[SpecialName]
	internal virtual PictureBox i6M()
	{
		return nz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am2(PictureBox Ws6)
	{
		PictureBox val = (nz = Ws6);
	}

	[SpecialName]
	internal virtual PictureBox w6R()
	{
		return _PictureBox12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0N(PictureBox f0Z)
	{
		_PictureBox12 = f0Z;
	}

	[SpecialName]
	internal virtual PictureBox Sb8()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc4(PictureBox Kp4)
	{
		_PictureBox11 = Kp4;
	}

	[SpecialName]
	internal virtual PictureBox Ek9()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0X(PictureBox Lj2)
	{
		_PictureBox10 = Lj2;
	}

	[SpecialName]
	internal virtual PictureBox Yg6()
	{
		return dV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3X(PictureBox Fz9)
	{
		PictureBox val = (dV = Fz9);
	}

	[SpecialName]
	internal virtual PictureBox Ww7()
	{
		return dj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lq2(PictureBox Xx6)
	{
		PictureBox val = (dj = Xx6);
	}

	[SpecialName]
	internal virtual PictureBox f4K()
	{
		return dn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9X(PictureBox c2P)
	{
		PictureBox val = (dn = c2P);
	}

	[SpecialName]
	internal virtual PictureBox r5C()
	{
		return _PictureBox6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4K(PictureBox Nn2)
	{
		_PictureBox6 = Nn2;
	}

	[SpecialName]
	internal virtual PictureBox Kc2()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sb7(PictureBox p8X)
	{
		_PictureBox5 = p8X;
	}

	[SpecialName]
	internal virtual PictureBox e8W()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0Y(PictureBox Rg9)
	{
		_PictureBox4 = Rg9;
	}

	[SpecialName]
	internal virtual PictureBox m1Z()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4R(PictureBox j3H)
	{
		_PictureBox3 = j3H;
	}

	[SpecialName]
	internal virtual PictureBox Ki0()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3G(PictureBox Sa0)
	{
		_PictureBox2 = Sa0;
	}

	[SpecialName]
	internal virtual PictureBox k4P()
	{
		return dd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt9(PictureBox e3K)
	{
		PictureBox val = (dd = e3K);
	}

	[SpecialName]
	internal virtual Label Ax4()
	{
		return da;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6F(Label Ts3)
	{
		Label val = (da = Ts3);
	}

	[SpecialName]
	internal virtual Label n5A()
	{
		return _Label33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf8(Label Bw2)
	{
		_Label33 = Bw2;
	}

	[SpecialName]
	internal virtual Label a7Q()
	{
		return _Label34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw8(Label Xs8)
	{
		_Label34 = Xs8;
	}

	[SpecialName]
	internal virtual Label x3F()
	{
		return _Label35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3G(Label Ag5)
	{
		_Label35 = Ag5;
	}

	[SpecialName]
	internal virtual Label Qk1()
	{
		return dF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7L(Label t2Z)
	{
		Label val = (dF = t2Z);
	}

	[SpecialName]
	internal virtual Label Tb0()
	{
		return _Label37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5N(Label Tr2)
	{
		_Label37 = Tr2;
	}

	[SpecialName]
	internal virtual Label Gw7()
	{
		return dt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3S(Label Zr7)
	{
		Label val = (dt = Zr7);
	}

	[SpecialName]
	internal virtual Label Ly3()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7W(Label c1S)
	{
		_Label40 = c1S;
	}

	[SpecialName]
	internal virtual Label z8W()
	{
		return _Label41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw8(Label Ys7)
	{
		_Label41 = Ys7;
	}

	[SpecialName]
	internal virtual Label Nj7()
	{
		return dr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3P(Label Wq9)
	{
		Label val = (dr = Wq9);
	}

	[SpecialName]
	internal virtual Label Nd1()
	{
		return _Label43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2N(Label s1B)
	{
		_Label43 = s1B;
	}

	[SpecialName]
	internal virtual Label Dz6()
	{
		return dO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dy3(Label Nm7)
	{
		Label val = (dO = Nm7);
	}

	[SpecialName]
	internal virtual Label j8Y()
	{
		return dH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft8(Label Dy8)
	{
		Label val = (dH = Dy8);
	}

	[SpecialName]
	internal virtual Label Rj1()
	{
		return _Label45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tb6(Label p6P)
	{
		_Label45 = p6P;
	}

	[SpecialName]
	internal virtual Label Xq4()
	{
		return de;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az3(Label r1N)
	{
		Label val = (de = r1N);
	}

	[SpecialName]
	internal virtual Label Ye1()
	{
		return _Label47;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5N(Label j0A)
	{
		_Label47 = j0A;
	}

	[SpecialName]
	internal virtual Label q0H()
	{
		return _Label48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yn5(Label Kt7)
	{
		_Label48 = Kt7;
	}

	[SpecialName]
	internal virtual Label Tw0()
	{
		return dK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm0(Label Mm8)
	{
		Label val = (dK = Mm8);
	}

	[SpecialName]
	internal virtual Label Wd8()
	{
		return _Label50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8X(Label s5M)
	{
		_Label50 = s5M;
	}

	[SpecialName]
	internal virtual Label x1C()
	{
		return _Label51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj3(Label r9A)
	{
		_Label51 = r9A;
	}

	[SpecialName]
	internal virtual Label Yn4()
	{
		return _Label54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wi5(Label t3Z)
	{
		_Label54 = t3Z;
	}

	[SpecialName]
	internal virtual Label Fy1()
	{
		return dw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8S(Label We4)
	{
		Label val = (dw = We4);
	}

	[SpecialName]
	internal virtual Label w4K()
	{
		return _Label56;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qb1(Label Hj0)
	{
		_Label56 = Hj0;
	}

	[SpecialName]
	internal virtual Label Rp6()
	{
		return dG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ao2(Label f1Z)
	{
		Label val = (dG = f1Z);
	}

	[SpecialName]
	internal virtual Label Bw8()
	{
		return _Label26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wb3(Label Fm7)
	{
		_Label26 = Fm7;
	}

	[SpecialName]
	internal virtual Label j3X()
	{
		return _Label27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Br5(Label s9C)
	{
		_Label27 = s9C;
	}

	[SpecialName]
	internal virtual Label Gy9()
	{
		return _Label28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt6(Label Pw1)
	{
		_Label28 = Pw1;
	}

	[SpecialName]
	internal virtual Label Hy9()
	{
		return db;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gc6(Label s5K)
	{
		Label val = (db = s5K);
	}

	[SpecialName]
	internal virtual Label Xq8()
	{
		return dx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2B(Label De2)
	{
		Label val = (dx = De2);
	}

	[SpecialName]
	internal virtual Label Jj3()
	{
		return dp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6G(Label k6K)
	{
		Label val = (dp = k6K);
	}

	[SpecialName]
	internal virtual Label Ab4()
	{
		return _Label24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1J(Label r3W)
	{
		_Label24 = r3W;
	}

	[SpecialName]
	internal virtual Label Bw5()
	{
		return _Label23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1X(Label r7C)
	{
		_Label23 = r7C;
	}

	[SpecialName]
	internal virtual Label Ca4()
	{
		return _Label22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7R(Label j5S)
	{
		_Label22 = j5S;
	}

	[SpecialName]
	internal virtual Label z5G()
	{
		return _Label21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9E(Label Wg6)
	{
		_Label21 = Wg6;
	}

	[SpecialName]
	internal virtual Label y5G()
	{
		return di;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4Y(Label Le6)
	{
		Label val = (di = Le6);
	}

	[SpecialName]
	internal virtual Label y3J()
	{
		return ds;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lr6(Label n7K)
	{
		Label val = (ds = n7K);
	}

	[SpecialName]
	internal virtual Label Bo7()
	{
		return dQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0F(Label e2P)
	{
		Label val = (dQ = e2P);
	}

	[SpecialName]
	internal virtual Label x1W()
	{
		return dL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1Z(Label o8H)
	{
		Label val = (dL = o8H);
	}

	[SpecialName]
	internal virtual Label i7B()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5M(Label Qa7)
	{
		_Label16 = Qa7;
	}

	[SpecialName]
	internal virtual Label Kg8()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk9(Label b9P)
	{
		_Label15 = b9P;
	}

	[SpecialName]
	internal virtual Label Lp8()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7R(Label Tj6w)
	{
		_Label14 = Tj6w;
	}

	[SpecialName]
	internal virtual Label x7L9()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nc3r(Label z4H0)
	{
		_Label13 = z4H0;
	}

	[SpecialName]
	internal virtual Label n2WP()
	{
		return _Label12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez8s(Label Wy2o)
	{
		_Label12 = Wy2o;
	}

	[SpecialName]
	internal virtual Label Lo0e()
	{
		return dY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn73(Label n4Q2)
	{
		Label val = (dY = n4Q2);
	}

	[SpecialName]
	internal virtual Label Bf2s()
	{
		return dU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt0j(Label q9B5)
	{
		Label val = (dU = q9B5);
	}

	[SpecialName]
	internal virtual Label n8SB()
	{
		return dm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Em13(Label Zm2p)
	{
		Label val = (dm = Zm2p);
	}

	[SpecialName]
	internal virtual Label n1BG()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3Z4(Label o1Z8)
	{
		_Label8 = o1Z8;
	}

	[SpecialName]
	internal virtual Label Dk3y()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9W3(Label Le4k)
	{
		_Label7 = Le4k;
	}

	[SpecialName]
	internal virtual Label r3S9()
	{
		return dc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rr04(Label Ck40)
	{
		Label val = (dc = Ck40);
	}

	[SpecialName]
	internal virtual Label Cy86()
	{
		return dz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1EF(Label q6E0)
	{
		Label val = (dz = q6E0);
	}

	[SpecialName]
	internal virtual GroupBox Zq2z()
	{
		return aV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cp1f(GroupBox k7PL)
	{
		GroupBox val = (aV = k7PL);
	}

	[SpecialName]
	internal virtual TextBox j7M2()
	{
		return _txtAvailable;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7XC(TextBox s0A7)
	{
		_txtAvailable = s0A7;
	}

	[SpecialName]
	internal virtual PictureBox i0WK()
	{
		return aj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd91(PictureBox Tt5a)
	{
		PictureBox val = (aj = Tt5a);
	}

	[SpecialName]
	internal virtual PictureBox Zn93()
	{
		return _Provisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mb0z(PictureBox y7N5)
	{
		_Provisional = y7N5;
	}

	[SpecialName]
	internal virtual PictureBox Dq74()
	{
		return _Available;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void En3p(PictureBox Bm76)
	{
		_Available = Bm76;
	}

	[SpecialName]
	internal virtual Label f9E5()
	{
		return an;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cj9x(Label y9Y6)
	{
		Label val = (an = y9Y6);
	}

	[SpecialName]
	internal virtual Label Cj75()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6P3(Label Jb0f)
	{
		_Label6 = Jb0f;
	}

	[SpecialName]
	internal virtual PictureBox r4AX()
	{
		return _Background;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc0b(PictureBox g6Q8)
	{
		_Background = g6Q8;
	}

	[SpecialName]
	internal virtual PictureBox Tk0d()
	{
		return _NameBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gt6z(PictureBox Ke91)
	{
		_NameBox = Ke91;
	}

	[SpecialName]
	internal virtual GroupBox x5S6()
	{
		return ad;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5M3(GroupBox Ss1b)
	{
		GroupBox val = (ad = Ss1b);
	}

	[SpecialName]
	internal virtual Button Ed95()
	{
		return _btnViewReservations;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0HM(Button r8PL)
	{
		EventHandler eventHandler = y5PE;
		Button btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).remove_Click(eventHandler);
		}
		_btnViewReservations = r8PL;
		btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox d8RL()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3QY(PictureBox g2KP)
	{
		_Cover = g2KP;
	}

	[SpecialName]
	internal virtual GroupBox Hs78()
	{
		return aa;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rx82(GroupBox y3KS)
	{
		GroupBox val = (aa = y3KS);
	}

	[SpecialName]
	internal virtual Button q2X0()
	{
		return _btnNew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gt7x(Button y2DQ)
	{
		EventHandler eventHandler = m0BN;
		Button btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).remove_Click(eventHandler);
		}
		_btnNew = y2DQ;
		btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Te1d()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7XR(Button s2TQ)
	{
		_btnReset = s2TQ;
	}

	[SpecialName]
	internal virtual Button f4SD()
	{
		return _btnExisting;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zy30(Button z2W6)
	{
		EventHandler eventHandler = i8JZ;
		Button btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).remove_Click(eventHandler);
		}
		_btnExisting = z2W6;
		btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Dm0t()
	{
		return _txtFirstName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf7z(TextBox Lg16)
	{
		_txtFirstName = Lg16;
	}

	[SpecialName]
	internal virtual TextBox Pf96()
	{
		return aF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb14(TextBox n9F2)
	{
		TextBox val = (aF = n9F2);
	}

	[SpecialName]
	internal virtual Label Ss18()
	{
		return at;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4T5(Label w2S6)
	{
		Label val = (at = w2S6);
	}

	[SpecialName]
	internal virtual Label r8X9()
	{
		return ar;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bs42(Label Hw0b)
	{
		Label val = (ar = Hw0b);
	}

	[SpecialName]
	internal virtual GroupBox g3JD()
	{
		return aO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7CJ(GroupBox j1LF)
	{
		GroupBox val = (aO = j1LF);
	}

	[SpecialName]
	internal virtual Button Gz8d()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7JR(Button Zo46)
	{
		EventHandler eventHandler = Ms8q;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = Zo46;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button x2TX()
	{
		return _btnCalculateChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr2b(Button z1YB)
	{
		EventHandler eventHandler = Wg53;
		Button btnCalculateChange = _btnCalculateChange;
		if (btnCalculateChange != null)
		{
			((Control)btnCalculateChange).remove_Click(eventHandler);
		}
		_btnCalculateChange = z1YB;
		btnCalculateChange = _btnCalculateChange;
		if (btnCalculateChange != null)
		{
			((Control)btnCalculateChange).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Mo6g()
	{
		return aH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qt4z(TextBox m2P4)
	{
		TextBox val = (aH = m2P4);
	}

	[SpecialName]
	internal virtual TextBox g1X0()
	{
		return ae;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo2j(TextBox Wy51)
	{
		TextBox val = (ae = Wy51);
	}

	[SpecialName]
	internal virtual TextBox o0Q4()
	{
		return _txtTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le74(TextBox Ht8o)
	{
		_txtTotalCost = Ht8o;
	}

	[SpecialName]
	internal virtual TextBox Hc6d()
	{
		return _txtSeats;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4QM(TextBox Wr6n)
	{
		_txtSeats = Wr6n;
	}

	[SpecialName]
	internal virtual Label j7L2()
	{
		return aK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7W0(Label Zm34)
	{
		Label val = (aK = Zm34);
	}

	[SpecialName]
	internal virtual Label Qj1s()
	{
		return aw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wx6i(Label i5R2)
	{
		Label val = (aw = i5R2);
	}

	[SpecialName]
	internal virtual Label r1Q0()
	{
		return _Label61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn4p(Label Ri2m)
	{
		_Label61 = Ri2m;
	}

	[SpecialName]
	internal virtual Label Mx6f()
	{
		return _Label62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6F9(Label q2QX)
	{
		_Label62 = q2QX;
	}

	private void Ms8q(object sender, EventArgs e)
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
				if (val != null && val.get_Image() == ab)
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
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 4.accdb";
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
				if (val != null && val.get_Image() == ab)
				{
					int num = Conversions.ToInteger(Strings.Mid(((Control)val).get_Name(), 11));
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Pf96().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = Pf96().get_Text();
		firstName = Dm0t().get_Text();
		val2.Close();
		Ca4o();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Wg53(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(g1X0().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			Mo6g().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)g1X0()).Clear();
		}
	}

	private void s0WC(object sender, EventArgs e)
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
					((PictureBox)val).set_Image((Image)aG);
					val.add_Click((EventHandler)g4S9);
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
		ax = 160;
		bookedSeats = 0;
		provisionalSeats = 0;
		Ca4o();
	}

	private void y5PE(object sender, EventArgs e)
	{
	}

	private void i8JZ(object sender, EventArgs e)
	{
	}

	private void m0BN(object sender, EventArgs e)
	{
	}

	public void Ca4o()
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
			int num = (ax = 160 - bookedSeats);
			provisionalSeats = 0;
			string commandText = "SELECT * FROM tblBookings";
			string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 4.accdb";
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
					bookedSeats++;
					ax--;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Ri1r().set_Text(Conversions.ToString(bookedSeats));
			j7M2().set_Text(Conversions.ToString(ax));
			Yx4a().set_Text(Conversions.ToString(provisionalSeats));
			z3BP();
		}
	}

	internal static byte[] Bq5i(byte[] q0T4, byte[] i7M5, int At90, int Ee92)
	{
		int num = checked(q0T4.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			q0T4[i] = (byte)(q0T4[i] ^ checked((byte)(i7M5[unchecked(i % i7M5.Length)] ^ ((i + unchecked(At90 % i7M5.Length)) & At90))));
		}
		return q0T4;
	}

	private void g4S9(object sender, EventArgs e)
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
			if (((PictureBox)sender).get_Image() == aG)
			{
				((PictureBox)sender).set_Image((Image)ab);
				provisionalSeats++;
				ax--;
			}
			else if (((PictureBox)sender).get_Image() == ab)
			{
				((PictureBox)sender).set_Image((Image)aG);
				provisionalSeats--;
				ax++;
			}
			j7M2().set_Text(Conversions.ToString(ax));
			Yx4a().set_Text(Conversions.ToString(provisionalSeats));
			seats = provisionalSeats;
			Hc6d().set_Text(Conversions.ToString(seats));
			totalCost = provisionalSeats * 5;
			o0Q4().set_Text("$" + totalCost);
		}
	}

	public void z3BP()
	{
		((TextBoxBase)g1X0()).Clear();
		((TextBoxBase)Dm0t()).Clear();
		((TextBoxBase)o0Q4()).Clear();
		((TextBoxBase)Mo6g()).Clear();
		((TextBoxBase)Hc6d()).Clear();
		((TextBoxBase)Pf96()).Clear();
	}
}
