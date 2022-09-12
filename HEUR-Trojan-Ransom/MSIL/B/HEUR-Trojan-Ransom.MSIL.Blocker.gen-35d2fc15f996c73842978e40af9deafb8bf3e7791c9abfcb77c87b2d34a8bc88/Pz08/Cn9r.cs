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

namespace Pz08;

[DesignerGenerated]
public class Cn9r : Form
{
	private Label _Label38;

	private Label _Label39;

	private Label _Label40;

	private Label _Label41;

	private Label _Label43;

	private Label _Label44;

	private Label _Label46;

	private TextBox _txtAvailable;

	private PictureBox _Booked;

	private PictureBox _Provisional;

	private PictureBox _Available;

	private Label _Label3;

	private Label _Label1;

	private Label _Label49;

	private Label _Label51;

	private Label _Label54;

	private Label _Label55;

	private Label _Label28;

	private Label _Label24;

	private Label _Label23;

	private Label _Label20;

	private Label _Label19;

	private Label _Label18;

	private Label _Label16;

	private Label _Label15;

	private Label _Label14;

	private Label _Label12;

	private Label _Label11;

	private Label _Label10;

	private Label _Label8;

	private Label _Label7;

	private Label _Label4;

	private GroupBox _GroupBox3;

	private GroupBox _GroupBox1;

	private PictureBox _NameBox;

	private PictureBox _PictureBox61;

	private PictureBox _PictureBox62;

	private PictureBox _PictureBox64;

	private PictureBox _PictureBox66;

	private PictureBox _PictureBox70;

	private PictureBox _PictureBox71;

	private PictureBox _PictureBox72;

	private PictureBox _PictureBox74;

	private PictureBox _PictureBox78;

	private PictureBox _PictureBox79;

	private PictureBox _PictureBox80;

	private PictureBox _PictureBox42;

	private PictureBox _PictureBox44;

	private PictureBox _PictureBox45;

	private PictureBox _PictureBox46;

	private PictureBox _PictureBox48;

	private PictureBox _PictureBox50;

	private PictureBox _PictureBox53;

	private PictureBox _PictureBox57;

	private PictureBox _PictureBox21;

	private PictureBox _PictureBox23;

	private PictureBox _PictureBox25;

	private PictureBox _PictureBox28;

	private PictureBox _PictureBox30;

	private PictureBox _PictureBox32;

	private PictureBox _PictureBox33;

	private PictureBox _PictureBox35;

	private PictureBox _PictureBox36;

	private PictureBox _PictureBox37;

	private PictureBox _PictureBox38;

	private PictureBox _PictureBox39;

	private PictureBox _PictureBox40;

	private PictureBox _PictureBox19;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox2;

	private PictureBox _PictureBox1;

	private PictureBox _PictureBox142;

	private PictureBox _PictureBox143;

	private PictureBox _PictureBox145;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox148;

	private PictureBox _PictureBox149;

	private PictureBox _PictureBox150;

	private PictureBox _PictureBox151;

	private PictureBox _PictureBox152;

	private PictureBox _PictureBox153;

	private PictureBox _PictureBox155;

	private PictureBox _PictureBox156;

	private PictureBox _PictureBox159;

	private PictureBox _PictureBox160;

	private PictureBox _PictureBox127;

	private PictureBox _PictureBox131;

	private PictureBox _PictureBox133;

	private PictureBox _PictureBox134;

	private PictureBox _PictureBox136;

	private PictureBox _PictureBox137;

	private PictureBox _PictureBox140;

	private PictureBox _PictureBox101;

	private PictureBox _PictureBox105;

	private PictureBox _PictureBox107;

	private PictureBox _PictureBox109;

	private PictureBox _PictureBox110;

	private PictureBox _PictureBox112;

	private PictureBox _PictureBox113;

	private PictureBox _PictureBox115;

	private PictureBox _PictureBox117;

	private PictureBox _PictureBox84;

	private PictureBox _PictureBox85;

	private PictureBox _PictureBox93;

	private PictureBox _PictureBox94;

	private PictureBox _PictureBox95;

	private PictureBox _PictureBox96;

	private PictureBox _PictureBox98;

	private PictureBox _PictureBox100;

	private Button _btnSave;

	private TextBox _txtChange;

	private TextBox _txtTotalPayment;

	private TextBox _txtTotalCost;

	private Label _Label63;

	private Label _Label64;

	private Label _Label61;

	private GroupBox _GroupBox2;

	private Button _btnExisting;

	private TextBox _txtFirstName;

	private TextBox _txtID;

	private Label _Label60;

	private Label _Label59;

	private int availableSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal IContainer J;

	internal Label d;

	internal Label I;

	internal Label V;

	internal Label C;

	internal Label Y;

	internal Label e;

	internal Label x;

	internal Label M;

	internal Label u;

	internal Label n;

	internal TextBox B;

	internal Label S;

	internal PictureBox r;

	internal TextBox H;

	internal Label L;

	internal Label T;

	internal Label q;

	internal Label o;

	internal Label P;

	internal Label f;

	internal Label a;

	internal Label W;

	internal Label G;

	internal Label k;

	internal Label z;

	internal Label dJ;

	internal Label dd;

	internal Label dI;

	internal Label dV;

	internal PictureBox dC;

	internal PictureBox dY;

	internal PictureBox de;

	internal PictureBox dx;

	internal PictureBox dM;

	internal PictureBox du;

	internal PictureBox dn;

	internal PictureBox dB;

	internal PictureBox dS;

	internal PictureBox dr;

	internal PictureBox dH;

	internal PictureBox dL;

	internal PictureBox dT;

	internal PictureBox dq;

	internal PictureBox @do;

	internal PictureBox dP;

	internal PictureBox df;

	internal PictureBox da;

	internal PictureBox dW;

	internal PictureBox dG;

	internal PictureBox dk;

	internal PictureBox dz;

	internal PictureBox IJ;

	internal PictureBox Id;

	internal PictureBox II;

	internal PictureBox IV;

	internal PictureBox IC;

	internal PictureBox IY;

	internal PictureBox Ie;

	internal PictureBox Ix;

	internal PictureBox IM;

	internal PictureBox Iu;

	internal PictureBox In;

	internal PictureBox IB;

	internal PictureBox IS;

	internal PictureBox Ir;

	internal PictureBox IH;

	internal PictureBox IL;

	internal PictureBox IT;

	internal PictureBox Iq;

	internal PictureBox Io;

	internal PictureBox IP;

	internal PictureBox If;

	internal PictureBox Ia;

	internal PictureBox IW;

	internal PictureBox IG;

	internal PictureBox Ik;

	internal PictureBox Iz;

	internal PictureBox VJ;

	internal PictureBox Vd;

	internal PictureBox VI;

	internal PictureBox VV;

	internal PictureBox VC;

	internal PictureBox VY;

	internal PictureBox Ve;

	internal PictureBox Vx;

	internal PictureBox VM;

	internal PictureBox Vu;

	internal PictureBox Vn;

	internal PictureBox VB;

	internal PictureBox VS;

	internal PictureBox Vr;

	internal PictureBox VH;

	internal PictureBox VL;

	internal PictureBox VT;

	internal PictureBox Vq;

	internal PictureBox Vo;

	internal PictureBox VP;

	internal PictureBox Vf;

	internal PictureBox Va;

	internal PictureBox VW;

	internal PictureBox VG;

	internal PictureBox Vk;

	internal PictureBox Vz;

	internal PictureBox CJ;

	internal PictureBox Cd;

	internal PictureBox CI;

	internal PictureBox CV;

	internal PictureBox CC;

	internal PictureBox CY;

	internal PictureBox Ce;

	internal Button Cx;

	internal GroupBox CM;

	internal Button Cu;

	internal TextBox Cn;

	internal Label CB;

	internal Button CS;

	internal Button Cr;

	internal object CH;

	internal object CL;

	internal object CT;

	internal int Cq;

	internal int Co;

	public Cn9r()
	{
		((Form)this).add_Load((EventHandler)c1D7);
		object obj = (CH = RuntimeHelpers.GetObjectValue(new object()));
		object obj2 = (CL = RuntimeHelpers.GetObjectValue(new object()));
		object obj3 = (CT = RuntimeHelpers.GetObjectValue(new object()));
		w8G6();
	}

	protected override void Cx2f(bool Lt03)
	{
		try
		{
			if (Lt03 && J != null)
			{
				J.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lt03);
		}
	}

	private void w8G6()
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
		//IL_2cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb7: Expected O, but got Unknown
		Qr4x(new Label());
		Bz95(new Label());
		Aj21(new Label());
		Se78(new Label());
		Fy40(new Label());
		Cd8s(new Label());
		k0X5(new Label());
		Eb6p(new Label());
		m5JZ(new Label());
		z5HN(new Label());
		Le5x(new Label());
		s0TN(new Label());
		t3MH(new Label());
		z4PT(new Label());
		Ro7j(new Label());
		d6CQ(new Label());
		s7T3(new Label());
		n4LZ(new TextBox());
		Rn95(new TextBox());
		f7BA(new PictureBox());
		Lx5g(new PictureBox());
		Am64(new PictureBox());
		Fp24(new Label());
		Ji1w(new Label());
		j3Z4(new Label());
		Aj18(new PictureBox());
		d2HT(new Label());
		i1QF(new TextBox());
		Tg72(new Label());
		b6K2(new Label());
		x9D5(new Label());
		f4R5(new Label());
		z8XC(new Label());
		e7CX(new Label());
		x9SM(new Label());
		c8JZ(new Label());
		x1J4(new Label());
		Mx7t(new Label());
		Ec6g(new Label());
		Ay74(new Label());
		Gb7g(new Label());
		Pn2z(new Label());
		Ey21(new Label());
		n9B3(new Label());
		Yf32(new Label());
		z3JW(new Label());
		Kz05(new Label());
		Bk7n(new Label());
		Gg5c(new Label());
		f7SN(new Label());
		b6E8(new Label());
		i7W4(new Label());
		Hj1a(new Label());
		a5FK(new Label());
		z0S2(new Label());
		w2J3(new Label());
		Aj68(new Label());
		Zf08(new Label());
		x9FZ(new Label());
		Lq14(new Label());
		Cc1w(new GroupBox());
		g2QJ(new Button());
		q4EL(new GroupBox());
		r7QX(new Label());
		d7NH(new PictureBox());
		Xr29(new PictureBox());
		z4F3(new PictureBox());
		a9S7(new PictureBox());
		a5CW(new PictureBox());
		Pz3s(new PictureBox());
		f4XZ(new PictureBox());
		Sk3j(new PictureBox());
		Xg3a(new PictureBox());
		i9NT(new PictureBox());
		y1YH(new PictureBox());
		Pp48(new PictureBox());
		Wt26(new PictureBox());
		Xy57(new PictureBox());
		Wa53(new PictureBox());
		c8T1(new PictureBox());
		r1JQ(new PictureBox());
		d8W6(new PictureBox());
		a2GJ(new PictureBox());
		s7TP(new PictureBox());
		o6BW(new PictureBox());
		s2J1(new PictureBox());
		Yd87(new PictureBox());
		Lg43(new PictureBox());
		z3M5(new PictureBox());
		Tg3t(new PictureBox());
		Zo6z(new PictureBox());
		i5A2(new PictureBox());
		q2N9(new PictureBox());
		Qb5e(new PictureBox());
		k6W5(new PictureBox());
		Ai01(new PictureBox());
		Sj50(new PictureBox());
		b6PX(new PictureBox());
		j6H3(new PictureBox());
		r1L7(new PictureBox());
		Ji8r(new PictureBox());
		z5RG(new PictureBox());
		z6N1(new PictureBox());
		d0WC(new PictureBox());
		Dg75(new PictureBox());
		An0k(new PictureBox());
		Hg5j(new PictureBox());
		n7HT(new PictureBox());
		Bx02(new PictureBox());
		j5N4(new PictureBox());
		b2KF(new PictureBox());
		Gg90(new PictureBox());
		t4HE(new PictureBox());
		a9M6(new PictureBox());
		r7HS(new PictureBox());
		x3YE(new PictureBox());
		m2CY(new PictureBox());
		Ci53(new PictureBox());
		c9C7(new PictureBox());
		Zt83(new PictureBox());
		Sr0y(new PictureBox());
		Go5a(new PictureBox());
		q3NC(new PictureBox());
		g6CQ(new PictureBox());
		Gy24(new PictureBox());
		r4FA(new PictureBox());
		Ft60(new PictureBox());
		Ff2p(new PictureBox());
		i7LQ(new PictureBox());
		d5SJ(new PictureBox());
		d5H2(new PictureBox());
		Bd5g(new PictureBox());
		y3M4(new PictureBox());
		Br9c(new PictureBox());
		c5G4(new PictureBox());
		f6M5(new PictureBox());
		Lo7s(new PictureBox());
		Tz92(new PictureBox());
		Wp6a(new PictureBox());
		x2SE(new PictureBox());
		Fr70(new PictureBox());
		x0CR(new PictureBox());
		Nn5p(new PictureBox());
		z7GC(new PictureBox());
		Jq6c(new PictureBox());
		w2F4(new PictureBox());
		z8RA(new PictureBox());
		x4SY(new PictureBox());
		Le59(new PictureBox());
		Yf1m(new PictureBox());
		o8X2(new PictureBox());
		Ez3r(new PictureBox());
		a4Q7(new PictureBox());
		n6J0(new PictureBox());
		La9o(new PictureBox());
		w8YB(new PictureBox());
		y5P8(new PictureBox());
		Ar0x(new PictureBox());
		Sn10(new PictureBox());
		Ky2e(new PictureBox());
		g1TG(new PictureBox());
		m5ZB(new PictureBox());
		q0QM(new PictureBox());
		x3WR(new PictureBox());
		Tz79(new PictureBox());
		m3TD(new PictureBox());
		Pt48(new PictureBox());
		r0Z6(new PictureBox());
		q9E6(new PictureBox());
		Ex4r(new PictureBox());
		Ha5j(new PictureBox());
		k3FW(new PictureBox());
		Mg38(new PictureBox());
		f4HT(new PictureBox());
		Zi5g(new PictureBox());
		Pn2o(new PictureBox());
		z8P5(new PictureBox());
		s5ZT(new PictureBox());
		x5Q0(new PictureBox());
		x0CT(new PictureBox());
		Hk36(new PictureBox());
		o0B3(new PictureBox());
		j9N3(new PictureBox());
		Qm7b(new PictureBox());
		Wa8p(new PictureBox());
		Ct6d(new PictureBox());
		y6QE(new PictureBox());
		w3Z2(new PictureBox());
		y8T0(new PictureBox());
		w5RL(new PictureBox());
		w2A7(new PictureBox());
		x4AG(new PictureBox());
		m1DB(new PictureBox());
		No92(new PictureBox());
		Ly28(new PictureBox());
		g9Z1(new PictureBox());
		Ti74(new PictureBox());
		q7KN(new PictureBox());
		Je3q(new PictureBox());
		y2F1(new PictureBox());
		Ps04(new PictureBox());
		Kx32(new PictureBox());
		Lx74(new PictureBox());
		n8Q3(new PictureBox());
		t3AP(new PictureBox());
		m4YA(new PictureBox());
		Xf42(new PictureBox());
		Tb14(new PictureBox());
		Nz69(new PictureBox());
		Ne50(new PictureBox());
		Cc40(new PictureBox());
		No3r(new PictureBox());
		Yp83(new PictureBox());
		Lf9a(new PictureBox());
		Df40(new PictureBox());
		t8W4(new PictureBox());
		z0S1(new PictureBox());
		Kn31(new PictureBox());
		Ns49(new PictureBox());
		g6W8(new PictureBox());
		c0FE(new PictureBox());
		Tx0j(new PictureBox());
		Ej5f(new PictureBox());
		j5L3(new PictureBox());
		Gn9r(new PictureBox());
		g1C9(new GroupBox());
		Je0p(new Button());
		Aj62(new Button());
		y5L1(new TextBox());
		He9t(new TextBox());
		Zb09(new TextBox());
		Ka21(new TextBox());
		Kd42(new Label());
		Sp6e(new Label());
		r4BK(new Label());
		c4W6(new Label());
		o7L5(new GroupBox());
		e2WR(new Button());
		Md9k(new Button());
		Ec6x(new Button());
		Mq93(new TextBox());
		r8F9(new TextBox());
		Yt69(new Label());
		Bk68(new Label());
		((ISupportInitialize)b9NA()).BeginInit();
		((ISupportInitialize)t8ZK()).BeginInit();
		((ISupportInitialize)Et20()).BeginInit();
		((ISupportInitialize)i4P1()).BeginInit();
		((Control)j3GN()).SuspendLayout();
		((Control)f3P9()).SuspendLayout();
		((ISupportInitialize)Xx69()).BeginInit();
		((ISupportInitialize)q1LD()).BeginInit();
		((ISupportInitialize)j8QP()).BeginInit();
		((ISupportInitialize)Jy9i()).BeginInit();
		((ISupportInitialize)d8KN()).BeginInit();
		((ISupportInitialize)Ey9d()).BeginInit();
		((ISupportInitialize)Zk9t()).BeginInit();
		((ISupportInitialize)Ai15()).BeginInit();
		((ISupportInitialize)Zf24()).BeginInit();
		((ISupportInitialize)o7S9()).BeginInit();
		((ISupportInitialize)r0KS()).BeginInit();
		((ISupportInitialize)j9DQ()).BeginInit();
		((ISupportInitialize)z2NB()).BeginInit();
		((ISupportInitialize)My5t()).BeginInit();
		((ISupportInitialize)Rn82()).BeginInit();
		((ISupportInitialize)a7D5()).BeginInit();
		((ISupportInitialize)Wz9d()).BeginInit();
		((ISupportInitialize)r2HZ()).BeginInit();
		((ISupportInitialize)Qa0f()).BeginInit();
		((ISupportInitialize)Ym4q()).BeginInit();
		((ISupportInitialize)z0X3()).BeginInit();
		((ISupportInitialize)k0T5()).BeginInit();
		((ISupportInitialize)Sf7s()).BeginInit();
		((ISupportInitialize)a8QE()).BeginInit();
		((ISupportInitialize)Ks2x()).BeginInit();
		((ISupportInitialize)Te8a()).BeginInit();
		((ISupportInitialize)a1SC()).BeginInit();
		((ISupportInitialize)Xf0g()).BeginInit();
		((ISupportInitialize)x3S4()).BeginInit();
		((ISupportInitialize)Gi31()).BeginInit();
		((ISupportInitialize)e6SY()).BeginInit();
		((ISupportInitialize)i2Q1()).BeginInit();
		((ISupportInitialize)x2CF()).BeginInit();
		((ISupportInitialize)q2QG()).BeginInit();
		((ISupportInitialize)Gr97()).BeginInit();
		((ISupportInitialize)a3C0()).BeginInit();
		((ISupportInitialize)f3SD()).BeginInit();
		((ISupportInitialize)g7AM()).BeginInit();
		((ISupportInitialize)Js1f()).BeginInit();
		((ISupportInitialize)p7D3()).BeginInit();
		((ISupportInitialize)i7QH()).BeginInit();
		((ISupportInitialize)n3BM()).BeginInit();
		((ISupportInitialize)Fg0k()).BeginInit();
		((ISupportInitialize)Ss1a()).BeginInit();
		((ISupportInitialize)i2FT()).BeginInit();
		((ISupportInitialize)f1F0()).BeginInit();
		((ISupportInitialize)Ab13()).BeginInit();
		((ISupportInitialize)Rn4s()).BeginInit();
		((ISupportInitialize)s1Z6()).BeginInit();
		((ISupportInitialize)e2MD()).BeginInit();
		((ISupportInitialize)p5F1()).BeginInit();
		((ISupportInitialize)y2NM()).BeginInit();
		((ISupportInitialize)Ac58()).BeginInit();
		((ISupportInitialize)p4RZ()).BeginInit();
		((ISupportInitialize)g0HD()).BeginInit();
		((ISupportInitialize)x4TK()).BeginInit();
		((ISupportInitialize)i6BG()).BeginInit();
		((ISupportInitialize)Fq80()).BeginInit();
		((ISupportInitialize)m9L0()).BeginInit();
		((ISupportInitialize)k1XN()).BeginInit();
		((ISupportInitialize)Zp5z()).BeginInit();
		((ISupportInitialize)Nb42()).BeginInit();
		((ISupportInitialize)w7LK()).BeginInit();
		((ISupportInitialize)t6TB()).BeginInit();
		((ISupportInitialize)p2N5()).BeginInit();
		((ISupportInitialize)Rd14()).BeginInit();
		((ISupportInitialize)q0T1()).BeginInit();
		((ISupportInitialize)Ni9n()).BeginInit();
		((ISupportInitialize)Zp76()).BeginInit();
		((ISupportInitialize)c6P2()).BeginInit();
		((ISupportInitialize)s2MZ()).BeginInit();
		((ISupportInitialize)Cp3s()).BeginInit();
		((ISupportInitialize)Ym7o()).BeginInit();
		((ISupportInitialize)r9XE()).BeginInit();
		((ISupportInitialize)Pp62()).BeginInit();
		((ISupportInitialize)Tb8k()).BeginInit();
		((ISupportInitialize)o5J1()).BeginInit();
		((ISupportInitialize)Yg8w()).BeginInit();
		((ISupportInitialize)Sx87()).BeginInit();
		((ISupportInitialize)Tg86()).BeginInit();
		((ISupportInitialize)So92()).BeginInit();
		((ISupportInitialize)Ji46()).BeginInit();
		((ISupportInitialize)f1ZW()).BeginInit();
		((ISupportInitialize)r8Q7()).BeginInit();
		((ISupportInitialize)q7YT()).BeginInit();
		((ISupportInitialize)p4WR()).BeginInit();
		((ISupportInitialize)Bd86()).BeginInit();
		((ISupportInitialize)q9JR()).BeginInit();
		((ISupportInitialize)x1G0()).BeginInit();
		((ISupportInitialize)Yy83()).BeginInit();
		((ISupportInitialize)Xa0n()).BeginInit();
		((ISupportInitialize)d1GJ()).BeginInit();
		((ISupportInitialize)Hj2p()).BeginInit();
		((ISupportInitialize)r3PB()).BeginInit();
		((ISupportInitialize)Ea54()).BeginInit();
		((ISupportInitialize)Sf2i()).BeginInit();
		((ISupportInitialize)y0AN()).BeginInit();
		((ISupportInitialize)Cr53()).BeginInit();
		((ISupportInitialize)Wi9s()).BeginInit();
		((ISupportInitialize)d3KB()).BeginInit();
		((ISupportInitialize)Bm6o()).BeginInit();
		((ISupportInitialize)Se02()).BeginInit();
		((ISupportInitialize)r2E1()).BeginInit();
		((ISupportInitialize)x3Y6()).BeginInit();
		((ISupportInitialize)Fe1p()).BeginInit();
		((ISupportInitialize)n6D9()).BeginInit();
		((ISupportInitialize)d0L4()).BeginInit();
		((ISupportInitialize)a2D8()).BeginInit();
		((ISupportInitialize)i0F7()).BeginInit();
		((ISupportInitialize)Lg7n()).BeginInit();
		((ISupportInitialize)Zw16()).BeginInit();
		((ISupportInitialize)g3CA()).BeginInit();
		((ISupportInitialize)Wi6f()).BeginInit();
		((ISupportInitialize)w2B4()).BeginInit();
		((ISupportInitialize)g0Y6()).BeginInit();
		((ISupportInitialize)Ga96()).BeginInit();
		((ISupportInitialize)o6Q5()).BeginInit();
		((ISupportInitialize)d9QL()).BeginInit();
		((ISupportInitialize)r0J1()).BeginInit();
		((ISupportInitialize)Ag82()).BeginInit();
		((ISupportInitialize)Ro36()).BeginInit();
		((ISupportInitialize)s6A9()).BeginInit();
		((ISupportInitialize)Ss20()).BeginInit();
		((ISupportInitialize)a2N0()).BeginInit();
		((ISupportInitialize)s4W5()).BeginInit();
		((ISupportInitialize)Qj5i()).BeginInit();
		((ISupportInitialize)Eb6g()).BeginInit();
		((ISupportInitialize)k9EQ()).BeginInit();
		((ISupportInitialize)r2AW()).BeginInit();
		((ISupportInitialize)k5H2()).BeginInit();
		((ISupportInitialize)Nj0y()).BeginInit();
		((ISupportInitialize)Ma60()).BeginInit();
		((ISupportInitialize)Gx6s()).BeginInit();
		((ISupportInitialize)g7C5()).BeginInit();
		((ISupportInitialize)e9EH()).BeginInit();
		((ISupportInitialize)s0L7()).BeginInit();
		((ISupportInitialize)t3LT()).BeginInit();
		((ISupportInitialize)j7F3()).BeginInit();
		((ISupportInitialize)Hj6b()).BeginInit();
		((ISupportInitialize)As2c()).BeginInit();
		((ISupportInitialize)Yg79()).BeginInit();
		((ISupportInitialize)q4RP()).BeginInit();
		((ISupportInitialize)w0K8()).BeginInit();
		((ISupportInitialize)r5YJ()).BeginInit();
		((ISupportInitialize)t6G4()).BeginInit();
		((ISupportInitialize)Ze0q()).BeginInit();
		((ISupportInitialize)Dn2c()).BeginInit();
		((ISupportInitialize)z2F1()).BeginInit();
		((ISupportInitialize)y5E8()).BeginInit();
		((ISupportInitialize)Rg38()).BeginInit();
		((ISupportInitialize)y2D7()).BeginInit();
		((ISupportInitialize)r5RZ()).BeginInit();
		((ISupportInitialize)Zr8t()).BeginInit();
		((ISupportInitialize)q8NZ()).BeginInit();
		((ISupportInitialize)Jj6n()).BeginInit();
		((ISupportInitialize)Xj97()).BeginInit();
		((ISupportInitialize)s2CQ()).BeginInit();
		((ISupportInitialize)Dt82()).BeginInit();
		((ISupportInitialize)y8YQ()).BeginInit();
		((ISupportInitialize)k9M8()).BeginInit();
		((ISupportInitialize)Hi94()).BeginInit();
		((Control)y8KZ()).SuspendLayout();
		((Control)Nd20()).SuspendLayout();
		((Control)this).SuspendLayout();
		Yn64().set_AutoSize(true);
		((Control)Yn64()).set_Location(new Point(367, 256));
		((Control)Yn64()).set_Name("Label32");
		((Control)Yn64()).set_Size(new Size(19, 13));
		((Control)Yn64()).set_TabIndex(625);
		Yn64().set_Text("20");
		q0E3().set_AutoSize(true);
		((Control)q0E3()).set_Location(new Point(274, 256));
		((Control)q0E3()).set_Name("Label33");
		((Control)q0E3()).set_Size(new Size(19, 13));
		((Control)q0E3()).set_TabIndex(624);
		q0E3().set_Text("15");
		j8AM().set_AutoSize(true);
		((Control)j8AM()).set_Location(new Point(309, 256));
		((Control)j8AM()).set_Name("Label34");
		((Control)j8AM()).set_Size(new Size(19, 13));
		((Control)j8AM()).set_TabIndex(623);
		j8AM().set_Text("17");
		Cd76().set_AutoSize(true);
		((Control)Cd76()).set_Location(new Point(328, 256));
		((Control)Cd76()).set_Name("Label35");
		((Control)Cd76()).set_Size(new Size(19, 13));
		((Control)Cd76()).set_TabIndex(622);
		Cd76().set_Text("18");
		f4DB().set_AutoSize(true);
		((Control)f4DB()).set_Location(new Point(347, 256));
		((Control)f4DB()).set_Name("Label36");
		((Control)f4DB()).set_Size(new Size(19, 13));
		((Control)f4DB()).set_TabIndex(621);
		f4DB().set_Text("19");
		c3GP().set_AutoSize(true);
		((Control)c3GP()).set_Location(new Point(222, 256));
		((Control)c3GP()).set_Name("Label37");
		((Control)c3GP()).set_Size(new Size(19, 13));
		((Control)c3GP()).set_TabIndex(620);
		c3GP().set_Text("12");
		t8C5().set_AutoSize(true);
		((Control)t8C5()).set_Location(new Point(91, 256));
		((Control)t8C5()).set_Name("Label38");
		((Control)t8C5()).set_Size(new Size(13, 13));
		((Control)t8C5()).set_TabIndex(619);
		t8C5().set_Text("4");
		g3H6().set_AutoSize(true);
		((Control)g3H6()).set_Location(new Point(240, 256));
		((Control)g3H6()).set_Name("Label39");
		((Control)g3H6()).set_Size(new Size(19, 13));
		((Control)g3H6()).set_TabIndex(618);
		g3H6().set_Text("13");
		Si95().set_AutoSize(true);
		((Control)Si95()).set_Location(new Point(291, 256));
		((Control)Si95()).set_Name("Label40");
		((Control)Si95()).set_Size(new Size(19, 13));
		((Control)Si95()).set_TabIndex(617);
		Si95().set_Text("16");
		r6L0().set_AutoSize(true);
		((Control)r6L0()).set_Location(new Point(205, 256));
		((Control)r6L0()).set_Name("Label41");
		((Control)r6L0()).set_Size(new Size(19, 13));
		((Control)r6L0()).set_TabIndex(616);
		r6L0().set_Text("11");
		c9NT().set_AutoSize(true);
		((Control)c9NT()).set_Location(new Point(256, 256));
		((Control)c9NT()).set_Name("Label42");
		((Control)c9NT()).set_Size(new Size(19, 13));
		((Control)c9NT()).set_TabIndex(615);
		c9NT().set_Text("14");
		Wm1f().set_AutoSize(true);
		((Control)Wm1f()).set_Location(new Point(155, 256));
		((Control)Wm1f()).set_Name("Label43");
		((Control)Wm1f()).set_Size(new Size(13, 13));
		((Control)Wm1f()).set_TabIndex(614);
		Wm1f().set_Text("8");
		j1F2().set_AutoSize(true);
		((Control)j1F2()).set_Location(new Point(187, 256));
		((Control)j1F2()).set_Name("Label44");
		((Control)j1F2()).set_Size(new Size(19, 13));
		((Control)j1F2()).set_TabIndex(613);
		j1F2().set_Text("10");
		p5GY().set_AutoSize(true);
		((Control)p5GY()).set_Location(new Point(171, 256));
		((Control)p5GY()).set_Name("Label45");
		((Control)p5GY()).set_Size(new Size(13, 13));
		((Control)p5GY()).set_TabIndex(612);
		p5GY().set_Text("9");
		g5K9().set_AutoSize(true);
		((Control)g5K9()).set_Location(new Point(139, 256));
		((Control)g5K9()).set_Name("Label46");
		((Control)g5K9()).set_Size(new Size(13, 13));
		((Control)g5K9()).set_TabIndex(611);
		g5K9().set_Text("7");
		p0JX().set_AutoSize(true);
		((Control)p0JX()).set_Location(new Point(123, 256));
		((Control)p0JX()).set_Name("Label47");
		((Control)p0JX()).set_Size(new Size(13, 13));
		((Control)p0JX()).set_TabIndex(610);
		p0JX().set_Text("6");
		f2T8().set_AutoSize(true);
		((Control)f2T8()).set_Location(new Point(107, 256));
		((Control)f2T8()).set_Name("Label48");
		((Control)f2T8()).set_Size(new Size(13, 13));
		((Control)f2T8()).set_TabIndex(609);
		f2T8().set_Text("5");
		((Control)Rg32()).set_Location(new Point(151, 42));
		((Control)Rg32()).set_Name("txtBooked");
		((Control)Rg32()).set_Size(new Size(83, 20));
		((Control)Rg32()).set_TabIndex(28);
		((Control)d8HZ()).set_Location(new Point(151, 16));
		((Control)d8HZ()).set_Name("txtAvailable");
		((Control)d8HZ()).set_Size(new Size(83, 20));
		((Control)d8HZ()).set_TabIndex(25);
		((Control)b9NA()).set_BackColor(Color.Transparent);
		((Control)b9NA()).set_Location(new Point(5, 47));
		((Control)b9NA()).set_Name("Booked");
		((Control)b9NA()).set_Size(new Size(23, 18));
		b9NA().set_SizeMode((PictureBoxSizeMode)4);
		b9NA().set_TabIndex(27);
		b9NA().set_TabStop(false);
		((Control)t8ZK()).set_BackColor(Color.Transparent);
		((Control)t8ZK()).set_Location(new Point(6, 74));
		((Control)t8ZK()).set_Name("Provisional");
		((Control)t8ZK()).set_Size(new Size(23, 17));
		t8ZK().set_SizeMode((PictureBoxSizeMode)4);
		t8ZK().set_TabIndex(26);
		t8ZK().set_TabStop(false);
		((Control)Et20()).set_BackColor(Color.Transparent);
		((Control)Et20()).set_Location(new Point(5, 23));
		((Control)Et20()).set_Name("Available");
		((Control)Et20()).set_Size(new Size(23, 17));
		Et20().set_SizeMode((PictureBoxSizeMode)4);
		Et20().set_TabIndex(25);
		Et20().set_TabStop(false);
		y2H9().set_AutoSize(true);
		((Control)y2H9()).set_BackColor(Color.Transparent);
		((Control)y2H9()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)y2H9()).set_Location(new Point(30, 49));
		((Control)y2H9()).set_Name("Label3");
		((Control)y2H9()).set_Size(new Size(74, 13));
		((Control)y2H9()).set_TabIndex(12);
		y2H9().set_Text("Booked Seats");
		w8Z6().set_AutoSize(true);
		((Control)w8Z6()).set_BackColor(Color.Transparent);
		((Control)w8Z6()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)w8Z6()).set_Location(new Point(30, 76));
		((Control)w8Z6()).set_Name("Label1");
		((Control)w8Z6()).set_Size(new Size(115, 13));
		((Control)w8Z6()).set_TabIndex(11);
		w8Z6().set_Text("Seat[s] on Reservation");
		Lq62().set_AutoSize(true);
		((Control)Lq62()).set_BackColor(Color.Transparent);
		((Control)Lq62()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Lq62()).set_Location(new Point(30, 24));
		((Control)Lq62()).set_Name("Label2");
		((Control)Lq62()).set_Size(new Size(80, 13));
		((Control)Lq62()).set_TabIndex(10);
		Lq62().set_Text("Available Seats");
		((Control)i4P1()).set_BackColor(Color.Transparent);
		((Control)i4P1()).set_Location(new Point(39, 21));
		((Control)i4P1()).set_Name("Cover");
		((Control)i4P1()).set_Size(new Size(129, 187));
		i4P1().set_SizeMode((PictureBoxSizeMode)4);
		i4P1().set_TabIndex(25);
		i4P1().set_TabStop(false);
		s1L4().set_AutoSize(true);
		((Control)s1L4()).set_Location(new Point(75, 256));
		((Control)s1L4()).set_Name("Label49");
		((Control)s1L4()).set_Size(new Size(13, 13));
		((Control)s1L4()).set_TabIndex(608);
		s1L4().set_Text("3");
		((Control)Me34()).set_Location(new Point(151, 73));
		((Control)Me34()).set_Name("txtProvisional");
		((Control)Me34()).set_Size(new Size(83, 20));
		((Control)Me34()).set_TabIndex(29);
		Ao60().set_AutoSize(true);
		((Control)Ao60()).set_Location(new Point(59, 256));
		((Control)Ao60()).set_Name("Label50");
		((Control)Ao60()).set_Size(new Size(13, 13));
		((Control)Ao60()).set_TabIndex(607);
		Ao60().set_Text("2");
		e3X8().set_AutoSize(true);
		((Control)e3X8()).set_Location(new Point(43, 256));
		((Control)e3X8()).set_Name("Label51");
		((Control)e3X8()).set_Size(new Size(13, 13));
		((Control)e3X8()).set_TabIndex(606);
		e3X8().set_Text("1");
		Ho49().set_AutoSize(true);
		((Control)Ho49()).set_Location(new Point(29, 362));
		((Control)Ho49()).set_Name("Label54");
		((Control)Ho49()).set_Size(new Size(15, 13));
		((Control)Ho49()).set_TabIndex(565);
		Ho49().set_Text("H");
		f4RP().set_AutoSize(true);
		((Control)f4RP()).set_Location(new Point(29, 340));
		((Control)f4RP()).set_Name("Label55");
		((Control)f4RP()).set_Size(new Size(15, 13));
		((Control)f4RP()).set_TabIndex(564);
		f4RP().set_Text("G");
		Xg2j().set_AutoSize(true);
		((Control)Xg2j()).set_Location(new Point(29, 318));
		((Control)Xg2j()).set_Name("Label56");
		((Control)Xg2j()).set_Size(new Size(13, 13));
		((Control)Xg2j()).set_TabIndex(563);
		Xg2j().set_Text("F");
		q1BK().set_AutoSize(true);
		((Control)q1BK()).set_Location(new Point(176, 222));
		((Control)q1BK()).set_Name("Label31");
		((Control)q1BK()).set_Size(new Size(72, 13));
		((Control)q1BK()).set_TabIndex(562);
		q1BK().set_Text("LOWER BOX");
		Tc64().set_AutoSize(true);
		((Control)Tc64()).set_Location(new Point(28, 299));
		((Control)Tc64()).set_Name("Label26");
		((Control)Tc64()).set_Size(new Size(14, 13));
		((Control)Tc64()).set_TabIndex(561);
		Tc64().set_Text("E");
		Kp05().set_AutoSize(true);
		((Control)Kp05()).set_Location(new Point(28, 187));
		((Control)Kp05()).set_Name("Label27");
		((Control)Kp05()).set_Size(new Size(15, 13));
		((Control)Kp05()).set_TabIndex(560);
		Kp05().set_Text("D");
		Nc12().set_AutoSize(true);
		((Control)Nc12()).set_Location(new Point(28, 165));
		((Control)Nc12()).set_Name("Label28");
		((Control)Nc12()).set_Size(new Size(14, 13));
		((Control)Nc12()).set_TabIndex(559);
		Nc12().set_Text("C");
		Fy53().set_AutoSize(true);
		((Control)Fy53()).set_Location(new Point(28, 143));
		((Control)Fy53()).set_Name("Label29");
		((Control)Fy53()).set_Size(new Size(14, 13));
		((Control)Fy53()).set_TabIndex(558);
		Fy53().set_Text("B");
		So91().set_AutoSize(true);
		((Control)So91()).set_Location(new Point(28, 121));
		((Control)So91()).set_Name("Label30");
		((Control)So91()).set_Size(new Size(14, 13));
		((Control)So91()).set_TabIndex(557);
		So91().set_Text("A");
		j1K7().set_AutoSize(true);
		((Control)j1K7()).set_Location(new Point(367, 75));
		((Control)j1K7()).set_Name("Label25");
		((Control)j1K7()).set_Size(new Size(19, 13));
		((Control)j1K7()).set_TabIndex(556);
		j1K7().set_Text("20");
		Et4x().set_AutoSize(true);
		((Control)Et4x()).set_Location(new Point(274, 75));
		((Control)Et4x()).set_Name("Label24");
		((Control)Et4x()).set_Size(new Size(19, 13));
		((Control)Et4x()).set_TabIndex(555);
		Et4x().set_Text("15");
		f9C7().set_AutoSize(true);
		((Control)f9C7()).set_Location(new Point(309, 75));
		((Control)f9C7()).set_Name("Label23");
		((Control)f9C7()).set_Size(new Size(19, 13));
		((Control)f9C7()).set_TabIndex(554);
		f9C7().set_Text("17");
		f9G5().set_AutoSize(true);
		((Control)f9G5()).set_Location(new Point(328, 75));
		((Control)f9G5()).set_Name("Label22");
		((Control)f9G5()).set_Size(new Size(19, 13));
		((Control)f9G5()).set_TabIndex(553);
		f9G5().set_Text("18");
		Hc81().set_AutoSize(true);
		((Control)Hc81()).set_Location(new Point(347, 75));
		((Control)Hc81()).set_Name("Label21");
		((Control)Hc81()).set_Size(new Size(19, 13));
		((Control)Hc81()).set_TabIndex(552);
		Hc81().set_Text("19");
		Hq43().set_AutoSize(true);
		((Control)Hq43()).set_Location(new Point(222, 75));
		((Control)Hq43()).set_Name("Label20");
		((Control)Hq43()).set_Size(new Size(19, 13));
		((Control)Hq43()).set_TabIndex(551);
		Hq43().set_Text("12");
		Qp5o().set_AutoSize(true);
		((Control)Qp5o()).set_Location(new Point(91, 75));
		((Control)Qp5o()).set_Name("Label19");
		((Control)Qp5o()).set_Size(new Size(13, 13));
		((Control)Qp5o()).set_TabIndex(550);
		Qp5o().set_Text("4");
		Dj1s().set_AutoSize(true);
		((Control)Dj1s()).set_Location(new Point(240, 75));
		((Control)Dj1s()).set_Name("Label18");
		((Control)Dj1s()).set_Size(new Size(19, 13));
		((Control)Dj1s()).set_TabIndex(549);
		Dj1s().set_Text("13");
		Yt19().set_AutoSize(true);
		((Control)Yt19()).set_Location(new Point(291, 75));
		((Control)Yt19()).set_Name("Label17");
		((Control)Yt19()).set_Size(new Size(19, 13));
		((Control)Yt19()).set_TabIndex(548);
		Yt19().set_Text("16");
		s2K5().set_AutoSize(true);
		((Control)s2K5()).set_Location(new Point(205, 75));
		((Control)s2K5()).set_Name("Label16");
		((Control)s2K5()).set_Size(new Size(19, 13));
		((Control)s2K5()).set_TabIndex(547);
		s2K5().set_Text("11");
		Xi08().set_AutoSize(true);
		((Control)Xi08()).set_Location(new Point(256, 75));
		((Control)Xi08()).set_Name("Label15");
		((Control)Xi08()).set_Size(new Size(19, 13));
		((Control)Xi08()).set_TabIndex(546);
		Xi08().set_Text("14");
		r7J9().set_AutoSize(true);
		((Control)r7J9()).set_Location(new Point(155, 75));
		((Control)r7J9()).set_Name("Label14");
		((Control)r7J9()).set_Size(new Size(13, 13));
		((Control)r7J9()).set_TabIndex(545);
		r7J9().set_Text("8");
		p2B5().set_AutoSize(true);
		((Control)p2B5()).set_Location(new Point(187, 75));
		((Control)p2B5()).set_Name("Label13");
		((Control)p2B5()).set_Size(new Size(19, 13));
		((Control)p2B5()).set_TabIndex(544);
		p2B5().set_Text("10");
		Yj3i().set_AutoSize(true);
		((Control)Yj3i()).set_Location(new Point(171, 75));
		((Control)Yj3i()).set_Name("Label12");
		((Control)Yj3i()).set_Size(new Size(13, 13));
		((Control)Yj3i()).set_TabIndex(543);
		Yj3i().set_Text("9");
		Nr2m().set_AutoSize(true);
		((Control)Nr2m()).set_Location(new Point(139, 75));
		((Control)Nr2m()).set_Name("Label11");
		((Control)Nr2m()).set_Size(new Size(13, 13));
		((Control)Nr2m()).set_TabIndex(542);
		Nr2m().set_Text("7");
		Hz16().set_AutoSize(true);
		((Control)Hz16()).set_Location(new Point(123, 75));
		((Control)Hz16()).set_Name("Label10");
		((Control)Hz16()).set_Size(new Size(13, 13));
		((Control)Hz16()).set_TabIndex(541);
		Hz16().set_Text("6");
		a1BZ().set_AutoSize(true);
		((Control)a1BZ()).set_Location(new Point(107, 75));
		((Control)a1BZ()).set_Name("Label9");
		((Control)a1BZ()).set_Size(new Size(13, 13));
		((Control)a1BZ()).set_TabIndex(540);
		a1BZ().set_Text("5");
		k9H2().set_AutoSize(true);
		((Control)k9H2()).set_Location(new Point(75, 75));
		((Control)k9H2()).set_Name("Label8");
		((Control)k9H2()).set_Size(new Size(13, 13));
		((Control)k9H2()).set_TabIndex(539);
		k9H2().set_Text("3");
		n2K8().set_AutoSize(true);
		((Control)n2K8()).set_Location(new Point(59, 75));
		((Control)n2K8()).set_Name("Label7");
		((Control)n2K8()).set_Size(new Size(13, 13));
		((Control)n2K8()).set_TabIndex(538);
		n2K8().set_Text("2");
		Yo75().set_AutoSize(true);
		((Control)Yo75()).set_Location(new Point(43, 75));
		((Control)Yo75()).set_Name("Label5");
		((Control)Yo75()).set_Size(new Size(13, 13));
		((Control)Yo75()).set_TabIndex(537);
		Yo75().set_Text("1");
		Aq93().set_AutoSize(true);
		((Control)Aq93()).set_Location(new Point(176, 48));
		((Control)Aq93()).set_Name("Label4");
		((Control)Aq93()).set_Size(new Size(69, 13));
		((Control)Aq93()).set_TabIndex(536);
		Aq93().set_Text("UPPER BOX");
		((Control)j3GN()).get_Controls().Add((Control)(object)m7B9());
		((Control)j3GN()).get_Controls().Add((Control)(object)i4P1());
		((Control)j3GN()).set_ForeColor(SystemColors.ControlLight);
		((Control)j3GN()).set_Location(new Point(471, 167));
		((Control)j3GN()).set_Name("GroupBox3");
		((Control)j3GN()).set_Size(new Size(200, 251));
		((Control)j3GN()).set_TabIndex(534);
		j3GN().set_TabStop(false);
		j3GN().set_Text("Movie On Display");
		((ButtonBase)m7B9()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)m7B9()).set_FlatStyle((FlatStyle)0);
		((Control)m7B9()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)m7B9()).set_Location(new Point(48, 214));
		((Control)m7B9()).set_Name("btnViewReservations");
		((Control)m7B9()).set_Size(new Size(117, 23));
		((Control)m7B9()).set_TabIndex(41);
		((ButtonBase)m7B9()).set_Text("View Reservations");
		((ButtonBase)m7B9()).set_UseVisualStyleBackColor(true);
		((Control)f3P9()).get_Controls().Add((Control)(object)Me34());
		((Control)f3P9()).get_Controls().Add((Control)(object)Rg32());
		((Control)f3P9()).get_Controls().Add((Control)(object)d8HZ());
		((Control)f3P9()).get_Controls().Add((Control)(object)b9NA());
		((Control)f3P9()).get_Controls().Add((Control)(object)t8ZK());
		((Control)f3P9()).get_Controls().Add((Control)(object)Et20());
		((Control)f3P9()).get_Controls().Add((Control)(object)y2H9());
		((Control)f3P9()).get_Controls().Add((Control)(object)w8Z6());
		((Control)f3P9()).get_Controls().Add((Control)(object)Lq62());
		((Control)f3P9()).set_ForeColor(SystemColors.ControlLight);
		((Control)f3P9()).set_Location(new Point(454, 48));
		((Control)f3P9()).set_Name("GroupBox1");
		((Control)f3P9()).set_Size(new Size(240, 100));
		((Control)f3P9()).set_TabIndex(532);
		f3P9().set_TabStop(false);
		f3P9().set_Text("Statistics");
		Bn64().set_AutoSize(true);
		((Control)Bn64()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Bn64()).set_ForeColor(SystemColors.ControlLight);
		((Control)Bn64()).set_Location(new Point(28, 6));
		((Control)Bn64()).set_Name("Label6");
		((Control)Bn64()).set_Size(new Size(106, 24));
		((Control)Bn64()).set_TabIndex(531);
		Bn64().set_Text("CINEMA 2");
		((Control)Xx69()).set_Location(new Point(435, 40));
		((Control)Xx69()).set_Name("Background");
		((Control)Xx69()).set_Size(new Size(474, 396));
		Xx69().set_SizeMode((PictureBoxSizeMode)1);
		Xx69().set_TabIndex(530);
		Xx69().set_TabStop(false);
		((Control)q1LD()).set_BackColor(Color.Transparent);
		((Control)q1LD()).set_Location(new Point(-2, -3));
		((Control)q1LD()).set_Name("NameBox");
		((Control)q1LD()).set_Size(new Size(914, 45));
		q1LD().set_SizeMode((PictureBoxSizeMode)1);
		q1LD().set_TabIndex(529);
		q1LD().set_TabStop(false);
		((Control)j8QP()).set_Location(new Point(372, 187));
		((Control)j8QP()).set_Name("PictureBox61");
		((Control)j8QP()).set_Size(new Size(10, 10));
		j8QP().set_SizeMode((PictureBoxSizeMode)4);
		j8QP().set_TabIndex(705);
		j8QP().set_TabStop(false);
		((Control)Jy9i()).set_Location(new Point(352, 187));
		((Control)Jy9i()).set_Name("PictureBox62");
		((Control)Jy9i()).set_Size(new Size(10, 10));
		Jy9i().set_SizeMode((PictureBoxSizeMode)4);
		Jy9i().set_TabIndex(704);
		Jy9i().set_TabStop(false);
		((Control)d8KN()).set_Location(new Point(333, 187));
		((Control)d8KN()).set_Name("PictureBox63");
		((Control)d8KN()).set_Size(new Size(10, 10));
		d8KN().set_SizeMode((PictureBoxSizeMode)4);
		d8KN().set_TabIndex(703);
		d8KN().set_TabStop(false);
		((Control)Ey9d()).set_Location(new Point(314, 187));
		((Control)Ey9d()).set_Name("PictureBox64");
		((Control)Ey9d()).set_Size(new Size(10, 10));
		Ey9d().set_SizeMode((PictureBoxSizeMode)4);
		Ey9d().set_TabIndex(702);
		Ey9d().set_TabStop(false);
		((Control)Zk9t()).set_Location(new Point(296, 187));
		((Control)Zk9t()).set_Name("PictureBox65");
		((Control)Zk9t()).set_Size(new Size(10, 10));
		Zk9t().set_SizeMode((PictureBoxSizeMode)4);
		Zk9t().set_TabIndex(701);
		Zk9t().set_TabStop(false);
		((Control)Ai15()).set_Location(new Point(279, 187));
		((Control)Ai15()).set_Name("PictureBox66");
		((Control)Ai15()).set_Size(new Size(10, 10));
		Ai15().set_SizeMode((PictureBoxSizeMode)4);
		Ai15().set_TabIndex(700);
		Ai15().set_TabStop(false);
		((Control)Zf24()).set_Location(new Point(261, 187));
		((Control)Zf24()).set_Name("PictureBox67");
		((Control)Zf24()).set_Size(new Size(10, 10));
		Zf24().set_SizeMode((PictureBoxSizeMode)4);
		Zf24().set_TabIndex(699);
		Zf24().set_TabStop(false);
		((Control)o7S9()).set_Location(new Point(245, 187));
		((Control)o7S9()).set_Name("PictureBox68");
		((Control)o7S9()).set_Size(new Size(10, 10));
		o7S9().set_SizeMode((PictureBoxSizeMode)4);
		o7S9().set_TabIndex(698);
		o7S9().set_TabStop(false);
		((Control)r0KS()).set_Location(new Point(227, 187));
		((Control)r0KS()).set_Name("PictureBox69");
		((Control)r0KS()).set_Size(new Size(10, 10));
		r0KS().set_SizeMode((PictureBoxSizeMode)4);
		r0KS().set_TabIndex(697);
		r0KS().set_TabStop(false);
		((Control)j9DQ()).set_Location(new Point(208, 187));
		((Control)j9DQ()).set_Name("PictureBox70");
		((Control)j9DQ()).set_Size(new Size(10, 10));
		j9DQ().set_SizeMode((PictureBoxSizeMode)4);
		j9DQ().set_TabIndex(696);
		j9DQ().set_TabStop(false);
		((Control)z2NB()).set_Location(new Point(190, 187));
		((Control)z2NB()).set_Name("PictureBox71");
		((Control)z2NB()).set_Size(new Size(10, 10));
		z2NB().set_SizeMode((PictureBoxSizeMode)4);
		z2NB().set_TabIndex(695);
		z2NB().set_TabStop(false);
		((Control)My5t()).set_Location(new Point(174, 187));
		((Control)My5t()).set_Name("PictureBox72");
		((Control)My5t()).set_Size(new Size(10, 10));
		My5t().set_SizeMode((PictureBoxSizeMode)4);
		My5t().set_TabIndex(694);
		My5t().set_TabStop(false);
		((Control)Rn82()).set_Location(new Point(158, 187));
		((Control)Rn82()).set_Name("PictureBox73");
		((Control)Rn82()).set_Size(new Size(10, 10));
		Rn82().set_SizeMode((PictureBoxSizeMode)4);
		Rn82().set_TabIndex(693);
		Rn82().set_TabStop(false);
		((Control)a7D5()).set_Location(new Point(142, 187));
		((Control)a7D5()).set_Name("PictureBox74");
		((Control)a7D5()).set_Size(new Size(10, 10));
		a7D5().set_SizeMode((PictureBoxSizeMode)4);
		a7D5().set_TabIndex(692);
		a7D5().set_TabStop(false);
		((Control)Wz9d()).set_Location(new Point(126, 187));
		((Control)Wz9d()).set_Name("PictureBox75");
		((Control)Wz9d()).set_Size(new Size(10, 10));
		Wz9d().set_SizeMode((PictureBoxSizeMode)4);
		Wz9d().set_TabIndex(691);
		Wz9d().set_TabStop(false);
		((Control)r2HZ()).set_Location(new Point(110, 187));
		((Control)r2HZ()).set_Name("PictureBox76");
		((Control)r2HZ()).set_Size(new Size(10, 10));
		r2HZ().set_SizeMode((PictureBoxSizeMode)4);
		r2HZ().set_TabIndex(690);
		r2HZ().set_TabStop(false);
		((Control)Qa0f()).set_Location(new Point(94, 187));
		((Control)Qa0f()).set_Name("PictureBox77");
		((Control)Qa0f()).set_Size(new Size(10, 10));
		Qa0f().set_SizeMode((PictureBoxSizeMode)4);
		Qa0f().set_TabIndex(689);
		Qa0f().set_TabStop(false);
		((Control)Ym4q()).set_Location(new Point(78, 187));
		((Control)Ym4q()).set_Name("PictureBox78");
		((Control)Ym4q()).set_Size(new Size(10, 10));
		Ym4q().set_SizeMode((PictureBoxSizeMode)4);
		Ym4q().set_TabIndex(688);
		Ym4q().set_TabStop(false);
		((Control)z0X3()).set_Location(new Point(62, 187));
		((Control)z0X3()).set_Name("PictureBox79");
		((Control)z0X3()).set_Size(new Size(10, 10));
		z0X3().set_SizeMode((PictureBoxSizeMode)4);
		z0X3().set_TabIndex(687);
		z0X3().set_TabStop(false);
		((Control)k0T5()).set_Location(new Point(48, 187));
		((Control)k0T5()).set_Name("PictureBox80");
		((Control)k0T5()).set_Size(new Size(10, 10));
		k0T5().set_SizeMode((PictureBoxSizeMode)4);
		k0T5().set_TabIndex(686);
		k0T5().set_TabStop(false);
		((Control)Sf7s()).set_Location(new Point(372, 165));
		((Control)Sf7s()).set_Name("PictureBox41");
		((Control)Sf7s()).set_Size(new Size(10, 10));
		Sf7s().set_SizeMode((PictureBoxSizeMode)4);
		Sf7s().set_TabIndex(685);
		Sf7s().set_TabStop(false);
		((Control)a8QE()).set_Location(new Point(352, 165));
		((Control)a8QE()).set_Name("PictureBox42");
		((Control)a8QE()).set_Size(new Size(10, 10));
		a8QE().set_SizeMode((PictureBoxSizeMode)4);
		a8QE().set_TabIndex(684);
		a8QE().set_TabStop(false);
		((Control)Ks2x()).set_Location(new Point(333, 165));
		((Control)Ks2x()).set_Name("PictureBox43");
		((Control)Ks2x()).set_Size(new Size(10, 10));
		Ks2x().set_SizeMode((PictureBoxSizeMode)4);
		Ks2x().set_TabIndex(683);
		Ks2x().set_TabStop(false);
		((Control)Te8a()).set_Location(new Point(314, 165));
		((Control)Te8a()).set_Name("PictureBox44");
		((Control)Te8a()).set_Size(new Size(10, 10));
		Te8a().set_SizeMode((PictureBoxSizeMode)4);
		Te8a().set_TabIndex(682);
		Te8a().set_TabStop(false);
		((Control)a1SC()).set_Location(new Point(296, 165));
		((Control)a1SC()).set_Name("PictureBox45");
		((Control)a1SC()).set_Size(new Size(10, 10));
		a1SC().set_SizeMode((PictureBoxSizeMode)4);
		a1SC().set_TabIndex(681);
		a1SC().set_TabStop(false);
		((Control)Xf0g()).set_Location(new Point(279, 165));
		((Control)Xf0g()).set_Name("PictureBox46");
		((Control)Xf0g()).set_Size(new Size(10, 10));
		Xf0g().set_SizeMode((PictureBoxSizeMode)4);
		Xf0g().set_TabIndex(680);
		Xf0g().set_TabStop(false);
		((Control)x3S4()).set_Location(new Point(261, 165));
		((Control)x3S4()).set_Name("PictureBox47");
		((Control)x3S4()).set_Size(new Size(10, 10));
		x3S4().set_SizeMode((PictureBoxSizeMode)4);
		x3S4().set_TabIndex(679);
		x3S4().set_TabStop(false);
		((Control)Gi31()).set_Location(new Point(245, 165));
		((Control)Gi31()).set_Name("PictureBox48");
		((Control)Gi31()).set_Size(new Size(10, 10));
		Gi31().set_SizeMode((PictureBoxSizeMode)4);
		Gi31().set_TabIndex(678);
		Gi31().set_TabStop(false);
		((Control)e6SY()).set_Location(new Point(227, 165));
		((Control)e6SY()).set_Name("PictureBox49");
		((Control)e6SY()).set_Size(new Size(10, 10));
		e6SY().set_SizeMode((PictureBoxSizeMode)4);
		e6SY().set_TabIndex(677);
		e6SY().set_TabStop(false);
		((Control)i2Q1()).set_Location(new Point(208, 165));
		((Control)i2Q1()).set_Name("PictureBox50");
		((Control)i2Q1()).set_Size(new Size(10, 10));
		i2Q1().set_SizeMode((PictureBoxSizeMode)4);
		i2Q1().set_TabIndex(676);
		i2Q1().set_TabStop(false);
		((Control)x2CF()).set_Location(new Point(190, 165));
		((Control)x2CF()).set_Name("PictureBox51");
		((Control)x2CF()).set_Size(new Size(10, 10));
		x2CF().set_SizeMode((PictureBoxSizeMode)4);
		x2CF().set_TabIndex(675);
		x2CF().set_TabStop(false);
		((Control)q2QG()).set_Location(new Point(174, 165));
		((Control)q2QG()).set_Name("PictureBox52");
		((Control)q2QG()).set_Size(new Size(10, 10));
		q2QG().set_SizeMode((PictureBoxSizeMode)4);
		q2QG().set_TabIndex(674);
		q2QG().set_TabStop(false);
		((Control)Gr97()).set_Location(new Point(158, 165));
		((Control)Gr97()).set_Name("PictureBox53");
		((Control)Gr97()).set_Size(new Size(10, 10));
		Gr97().set_SizeMode((PictureBoxSizeMode)4);
		Gr97().set_TabIndex(673);
		Gr97().set_TabStop(false);
		((Control)a3C0()).set_Location(new Point(142, 165));
		((Control)a3C0()).set_Name("PictureBox54");
		((Control)a3C0()).set_Size(new Size(10, 10));
		a3C0().set_SizeMode((PictureBoxSizeMode)4);
		a3C0().set_TabIndex(672);
		a3C0().set_TabStop(false);
		((Control)f3SD()).set_Location(new Point(126, 165));
		((Control)f3SD()).set_Name("PictureBox55");
		((Control)f3SD()).set_Size(new Size(10, 10));
		f3SD().set_SizeMode((PictureBoxSizeMode)4);
		f3SD().set_TabIndex(671);
		f3SD().set_TabStop(false);
		((Control)g7AM()).set_Location(new Point(110, 165));
		((Control)g7AM()).set_Name("PictureBox56");
		((Control)g7AM()).set_Size(new Size(10, 10));
		g7AM().set_SizeMode((PictureBoxSizeMode)4);
		g7AM().set_TabIndex(670);
		g7AM().set_TabStop(false);
		((Control)Js1f()).set_Location(new Point(94, 165));
		((Control)Js1f()).set_Name("PictureBox57");
		((Control)Js1f()).set_Size(new Size(10, 10));
		Js1f().set_SizeMode((PictureBoxSizeMode)4);
		Js1f().set_TabIndex(669);
		Js1f().set_TabStop(false);
		((Control)p7D3()).set_Location(new Point(78, 165));
		((Control)p7D3()).set_Name("PictureBox58");
		((Control)p7D3()).set_Size(new Size(10, 10));
		p7D3().set_SizeMode((PictureBoxSizeMode)4);
		p7D3().set_TabIndex(668);
		p7D3().set_TabStop(false);
		((Control)i7QH()).set_Location(new Point(62, 165));
		((Control)i7QH()).set_Name("PictureBox59");
		((Control)i7QH()).set_Size(new Size(10, 10));
		i7QH().set_SizeMode((PictureBoxSizeMode)4);
		i7QH().set_TabIndex(667);
		i7QH().set_TabStop(false);
		((Control)n3BM()).set_Location(new Point(48, 165));
		((Control)n3BM()).set_Name("PictureBox60");
		((Control)n3BM()).set_Size(new Size(10, 10));
		n3BM().set_SizeMode((PictureBoxSizeMode)4);
		n3BM().set_TabIndex(666);
		n3BM().set_TabStop(false);
		((Control)Fg0k()).set_Location(new Point(372, 143));
		((Control)Fg0k()).set_Name("PictureBox21");
		((Control)Fg0k()).set_Size(new Size(10, 10));
		Fg0k().set_SizeMode((PictureBoxSizeMode)4);
		Fg0k().set_TabIndex(665);
		Fg0k().set_TabStop(false);
		((Control)Ss1a()).set_Location(new Point(352, 143));
		((Control)Ss1a()).set_Name("PictureBox22");
		((Control)Ss1a()).set_Size(new Size(10, 10));
		Ss1a().set_SizeMode((PictureBoxSizeMode)4);
		Ss1a().set_TabIndex(664);
		Ss1a().set_TabStop(false);
		((Control)i2FT()).set_Location(new Point(333, 143));
		((Control)i2FT()).set_Name("PictureBox23");
		((Control)i2FT()).set_Size(new Size(10, 10));
		i2FT().set_SizeMode((PictureBoxSizeMode)4);
		i2FT().set_TabIndex(663);
		i2FT().set_TabStop(false);
		((Control)f1F0()).set_Location(new Point(314, 143));
		((Control)f1F0()).set_Name("PictureBox24");
		((Control)f1F0()).set_Size(new Size(10, 10));
		f1F0().set_SizeMode((PictureBoxSizeMode)4);
		f1F0().set_TabIndex(662);
		f1F0().set_TabStop(false);
		((Control)Ab13()).set_Location(new Point(296, 143));
		((Control)Ab13()).set_Name("PictureBox25");
		((Control)Ab13()).set_Size(new Size(10, 10));
		Ab13().set_SizeMode((PictureBoxSizeMode)4);
		Ab13().set_TabIndex(661);
		Ab13().set_TabStop(false);
		((Control)Rn4s()).set_Location(new Point(279, 143));
		((Control)Rn4s()).set_Name("PictureBox26");
		((Control)Rn4s()).set_Size(new Size(10, 10));
		Rn4s().set_SizeMode((PictureBoxSizeMode)4);
		Rn4s().set_TabIndex(660);
		Rn4s().set_TabStop(false);
		((Control)s1Z6()).set_Location(new Point(261, 143));
		((Control)s1Z6()).set_Name("PictureBox27");
		((Control)s1Z6()).set_Size(new Size(10, 10));
		s1Z6().set_SizeMode((PictureBoxSizeMode)4);
		s1Z6().set_TabIndex(659);
		s1Z6().set_TabStop(false);
		((Control)e2MD()).set_Location(new Point(245, 143));
		((Control)e2MD()).set_Name("PictureBox28");
		((Control)e2MD()).set_Size(new Size(10, 10));
		e2MD().set_SizeMode((PictureBoxSizeMode)4);
		e2MD().set_TabIndex(658);
		e2MD().set_TabStop(false);
		((Control)p5F1()).set_Location(new Point(227, 143));
		((Control)p5F1()).set_Name("PictureBox29");
		((Control)p5F1()).set_Size(new Size(10, 10));
		p5F1().set_SizeMode((PictureBoxSizeMode)4);
		p5F1().set_TabIndex(657);
		p5F1().set_TabStop(false);
		((Control)y2NM()).set_Location(new Point(208, 143));
		((Control)y2NM()).set_Name("PictureBox30");
		((Control)y2NM()).set_Size(new Size(10, 10));
		y2NM().set_SizeMode((PictureBoxSizeMode)4);
		y2NM().set_TabIndex(656);
		y2NM().set_TabStop(false);
		((Control)Ac58()).set_Location(new Point(190, 143));
		((Control)Ac58()).set_Name("PictureBox31");
		((Control)Ac58()).set_Size(new Size(10, 10));
		Ac58().set_SizeMode((PictureBoxSizeMode)4);
		Ac58().set_TabIndex(655);
		Ac58().set_TabStop(false);
		((Control)p4RZ()).set_Location(new Point(174, 143));
		((Control)p4RZ()).set_Name("PictureBox32");
		((Control)p4RZ()).set_Size(new Size(10, 10));
		p4RZ().set_SizeMode((PictureBoxSizeMode)4);
		p4RZ().set_TabIndex(654);
		p4RZ().set_TabStop(false);
		((Control)g0HD()).set_Location(new Point(158, 143));
		((Control)g0HD()).set_Name("PictureBox33");
		((Control)g0HD()).set_Size(new Size(10, 10));
		g0HD().set_SizeMode((PictureBoxSizeMode)4);
		g0HD().set_TabIndex(653);
		g0HD().set_TabStop(false);
		((Control)x4TK()).set_Location(new Point(142, 143));
		((Control)x4TK()).set_Name("PictureBox34");
		((Control)x4TK()).set_Size(new Size(10, 10));
		x4TK().set_SizeMode((PictureBoxSizeMode)4);
		x4TK().set_TabIndex(652);
		x4TK().set_TabStop(false);
		((Control)i6BG()).set_Location(new Point(126, 143));
		((Control)i6BG()).set_Name("PictureBox35");
		((Control)i6BG()).set_Size(new Size(10, 10));
		i6BG().set_SizeMode((PictureBoxSizeMode)4);
		i6BG().set_TabIndex(651);
		i6BG().set_TabStop(false);
		((Control)Fq80()).set_Location(new Point(110, 143));
		((Control)Fq80()).set_Name("PictureBox36");
		((Control)Fq80()).set_Size(new Size(10, 10));
		Fq80().set_SizeMode((PictureBoxSizeMode)4);
		Fq80().set_TabIndex(650);
		Fq80().set_TabStop(false);
		((Control)m9L0()).set_Location(new Point(94, 143));
		((Control)m9L0()).set_Name("PictureBox37");
		((Control)m9L0()).set_Size(new Size(10, 10));
		m9L0().set_SizeMode((PictureBoxSizeMode)4);
		m9L0().set_TabIndex(649);
		m9L0().set_TabStop(false);
		((Control)k1XN()).set_Location(new Point(78, 143));
		((Control)k1XN()).set_Name("PictureBox38");
		((Control)k1XN()).set_Size(new Size(10, 10));
		k1XN().set_SizeMode((PictureBoxSizeMode)4);
		k1XN().set_TabIndex(648);
		k1XN().set_TabStop(false);
		((Control)Zp5z()).set_Location(new Point(62, 143));
		((Control)Zp5z()).set_Name("PictureBox39");
		((Control)Zp5z()).set_Size(new Size(10, 10));
		Zp5z().set_SizeMode((PictureBoxSizeMode)4);
		Zp5z().set_TabIndex(647);
		Zp5z().set_TabStop(false);
		((Control)Nb42()).set_Location(new Point(48, 143));
		((Control)Nb42()).set_Name("PictureBox40");
		((Control)Nb42()).set_Size(new Size(10, 10));
		Nb42().set_SizeMode((PictureBoxSizeMode)4);
		Nb42().set_TabIndex(646);
		Nb42().set_TabStop(false);
		((Control)w7LK()).set_Location(new Point(372, 121));
		((Control)w7LK()).set_Name("PictureBox20");
		((Control)w7LK()).set_Size(new Size(10, 10));
		w7LK().set_SizeMode((PictureBoxSizeMode)4);
		w7LK().set_TabIndex(645);
		w7LK().set_TabStop(false);
		((Control)t6TB()).set_Location(new Point(352, 121));
		((Control)t6TB()).set_Name("PictureBox19");
		((Control)t6TB()).set_Size(new Size(10, 10));
		t6TB().set_SizeMode((PictureBoxSizeMode)4);
		t6TB().set_TabIndex(644);
		t6TB().set_TabStop(false);
		((Control)p2N5()).set_Location(new Point(333, 121));
		((Control)p2N5()).set_Name("PictureBox18");
		((Control)p2N5()).set_Size(new Size(10, 10));
		p2N5().set_SizeMode((PictureBoxSizeMode)4);
		p2N5().set_TabIndex(643);
		p2N5().set_TabStop(false);
		((Control)Rd14()).set_Location(new Point(314, 121));
		((Control)Rd14()).set_Name("PictureBox17");
		((Control)Rd14()).set_Size(new Size(10, 10));
		Rd14().set_SizeMode((PictureBoxSizeMode)4);
		Rd14().set_TabIndex(642);
		Rd14().set_TabStop(false);
		((Control)q0T1()).set_Location(new Point(296, 121));
		((Control)q0T1()).set_Name("PictureBox16");
		((Control)q0T1()).set_Size(new Size(10, 10));
		q0T1().set_SizeMode((PictureBoxSizeMode)4);
		q0T1().set_TabIndex(641);
		q0T1().set_TabStop(false);
		((Control)Ni9n()).set_Location(new Point(279, 121));
		((Control)Ni9n()).set_Name("PictureBox15");
		((Control)Ni9n()).set_Size(new Size(10, 10));
		Ni9n().set_SizeMode((PictureBoxSizeMode)4);
		Ni9n().set_TabIndex(640);
		Ni9n().set_TabStop(false);
		((Control)Zp76()).set_Location(new Point(261, 121));
		((Control)Zp76()).set_Name("PictureBox14");
		((Control)Zp76()).set_Size(new Size(10, 10));
		Zp76().set_SizeMode((PictureBoxSizeMode)4);
		Zp76().set_TabIndex(639);
		Zp76().set_TabStop(false);
		((Control)c6P2()).set_Location(new Point(245, 121));
		((Control)c6P2()).set_Name("PictureBox13");
		((Control)c6P2()).set_Size(new Size(10, 10));
		c6P2().set_SizeMode((PictureBoxSizeMode)4);
		c6P2().set_TabIndex(638);
		c6P2().set_TabStop(false);
		((Control)s2MZ()).set_Location(new Point(227, 121));
		((Control)s2MZ()).set_Name("PictureBox12");
		((Control)s2MZ()).set_Size(new Size(10, 10));
		s2MZ().set_SizeMode((PictureBoxSizeMode)4);
		s2MZ().set_TabIndex(637);
		s2MZ().set_TabStop(false);
		((Control)Cp3s()).set_Location(new Point(208, 121));
		((Control)Cp3s()).set_Name("PictureBox11");
		((Control)Cp3s()).set_Size(new Size(10, 10));
		Cp3s().set_SizeMode((PictureBoxSizeMode)4);
		Cp3s().set_TabIndex(636);
		Cp3s().set_TabStop(false);
		((Control)Ym7o()).set_Location(new Point(190, 121));
		((Control)Ym7o()).set_Name("PictureBox10");
		((Control)Ym7o()).set_Size(new Size(10, 10));
		Ym7o().set_SizeMode((PictureBoxSizeMode)4);
		Ym7o().set_TabIndex(635);
		Ym7o().set_TabStop(false);
		((Control)r9XE()).set_Location(new Point(174, 121));
		((Control)r9XE()).set_Name("PictureBox9");
		((Control)r9XE()).set_Size(new Size(10, 10));
		r9XE().set_SizeMode((PictureBoxSizeMode)4);
		r9XE().set_TabIndex(634);
		r9XE().set_TabStop(false);
		((Control)Pp62()).set_Location(new Point(158, 121));
		((Control)Pp62()).set_Name("PictureBox8");
		((Control)Pp62()).set_Size(new Size(10, 10));
		Pp62().set_SizeMode((PictureBoxSizeMode)4);
		Pp62().set_TabIndex(633);
		Pp62().set_TabStop(false);
		((Control)Tb8k()).set_Location(new Point(142, 121));
		((Control)Tb8k()).set_Name("PictureBox7");
		((Control)Tb8k()).set_Size(new Size(10, 10));
		Tb8k().set_SizeMode((PictureBoxSizeMode)4);
		Tb8k().set_TabIndex(632);
		Tb8k().set_TabStop(false);
		((Control)o5J1()).set_Location(new Point(126, 121));
		((Control)o5J1()).set_Name("PictureBox6");
		((Control)o5J1()).set_Size(new Size(10, 10));
		o5J1().set_SizeMode((PictureBoxSizeMode)4);
		o5J1().set_TabIndex(631);
		o5J1().set_TabStop(false);
		((Control)Yg8w()).set_Location(new Point(110, 121));
		((Control)Yg8w()).set_Name("PictureBox5");
		((Control)Yg8w()).set_Size(new Size(10, 10));
		Yg8w().set_SizeMode((PictureBoxSizeMode)4);
		Yg8w().set_TabIndex(630);
		Yg8w().set_TabStop(false);
		((Control)Sx87()).set_Location(new Point(94, 121));
		((Control)Sx87()).set_Name("PictureBox4");
		((Control)Sx87()).set_Size(new Size(10, 10));
		Sx87().set_SizeMode((PictureBoxSizeMode)4);
		Sx87().set_TabIndex(629);
		Sx87().set_TabStop(false);
		((Control)Tg86()).set_Location(new Point(78, 121));
		((Control)Tg86()).set_Name("PictureBox3");
		((Control)Tg86()).set_Size(new Size(10, 10));
		Tg86().set_SizeMode((PictureBoxSizeMode)4);
		Tg86().set_TabIndex(628);
		Tg86().set_TabStop(false);
		((Control)So92()).set_Location(new Point(62, 121));
		((Control)So92()).set_Name("PictureBox2");
		((Control)So92()).set_Size(new Size(10, 10));
		So92().set_SizeMode((PictureBoxSizeMode)4);
		So92().set_TabIndex(627);
		So92().set_TabStop(false);
		((Control)Ji46()).set_Location(new Point(48, 121));
		((Control)Ji46()).set_Name("PictureBox1");
		((Control)Ji46()).set_Size(new Size(10, 10));
		Ji46().set_SizeMode((PictureBoxSizeMode)4);
		Ji46().set_TabIndex(626);
		Ji46().set_TabStop(false);
		((Control)f1ZW()).set_Location(new Point(352, 362));
		((Control)f1ZW()).set_Name("PictureBox142");
		((Control)f1ZW()).set_Size(new Size(10, 12));
		f1ZW().set_SizeMode((PictureBoxSizeMode)4);
		f1ZW().set_TabIndex(784);
		f1ZW().set_TabStop(false);
		((Control)r8Q7()).set_Location(new Point(333, 362));
		((Control)r8Q7()).set_Name("PictureBox143");
		((Control)r8Q7()).set_Size(new Size(10, 12));
		r8Q7().set_SizeMode((PictureBoxSizeMode)4);
		r8Q7().set_TabIndex(783);
		r8Q7().set_TabStop(false);
		((Control)q7YT()).set_Location(new Point(314, 362));
		((Control)q7YT()).set_Name("PictureBox144");
		((Control)q7YT()).set_Size(new Size(10, 12));
		q7YT().set_SizeMode((PictureBoxSizeMode)4);
		q7YT().set_TabIndex(782);
		q7YT().set_TabStop(false);
		((Control)p4WR()).set_Location(new Point(296, 362));
		((Control)p4WR()).set_Name("PictureBox145");
		((Control)p4WR()).set_Size(new Size(10, 12));
		p4WR().set_SizeMode((PictureBoxSizeMode)4);
		p4WR().set_TabIndex(781);
		p4WR().set_TabStop(false);
		((Control)Bd86()).set_Location(new Point(279, 362));
		((Control)Bd86()).set_Name("PictureBox146");
		((Control)Bd86()).set_Size(new Size(10, 12));
		Bd86().set_SizeMode((PictureBoxSizeMode)4);
		Bd86().set_TabIndex(780);
		Bd86().set_TabStop(false);
		((Control)q9JR()).set_Location(new Point(261, 362));
		((Control)q9JR()).set_Name("PictureBox147");
		((Control)q9JR()).set_Size(new Size(10, 12));
		q9JR().set_SizeMode((PictureBoxSizeMode)4);
		q9JR().set_TabIndex(779);
		q9JR().set_TabStop(false);
		((Control)x1G0()).set_Location(new Point(245, 362));
		((Control)x1G0()).set_Name("PictureBox148");
		((Control)x1G0()).set_Size(new Size(10, 12));
		x1G0().set_SizeMode((PictureBoxSizeMode)4);
		x1G0().set_TabIndex(778);
		x1G0().set_TabStop(false);
		((Control)Yy83()).set_Location(new Point(227, 362));
		((Control)Yy83()).set_Name("PictureBox149");
		((Control)Yy83()).set_Size(new Size(10, 12));
		Yy83().set_SizeMode((PictureBoxSizeMode)4);
		Yy83().set_TabIndex(777);
		Yy83().set_TabStop(false);
		((Control)Xa0n()).set_Location(new Point(208, 362));
		((Control)Xa0n()).set_Name("PictureBox150");
		((Control)Xa0n()).set_Size(new Size(10, 12));
		Xa0n().set_SizeMode((PictureBoxSizeMode)4);
		Xa0n().set_TabIndex(776);
		Xa0n().set_TabStop(false);
		((Control)d1GJ()).set_Location(new Point(190, 362));
		((Control)d1GJ()).set_Name("PictureBox151");
		((Control)d1GJ()).set_Size(new Size(10, 12));
		d1GJ().set_SizeMode((PictureBoxSizeMode)4);
		d1GJ().set_TabIndex(775);
		d1GJ().set_TabStop(false);
		((Control)Hj2p()).set_Location(new Point(174, 362));
		((Control)Hj2p()).set_Name("PictureBox152");
		((Control)Hj2p()).set_Size(new Size(10, 12));
		Hj2p().set_SizeMode((PictureBoxSizeMode)4);
		Hj2p().set_TabIndex(774);
		Hj2p().set_TabStop(false);
		((Control)r3PB()).set_Location(new Point(158, 362));
		((Control)r3PB()).set_Name("PictureBox153");
		((Control)r3PB()).set_Size(new Size(10, 12));
		r3PB().set_SizeMode((PictureBoxSizeMode)4);
		r3PB().set_TabIndex(773);
		r3PB().set_TabStop(false);
		((Control)Ea54()).set_Location(new Point(142, 362));
		((Control)Ea54()).set_Name("PictureBox154");
		((Control)Ea54()).set_Size(new Size(10, 12));
		Ea54().set_SizeMode((PictureBoxSizeMode)4);
		Ea54().set_TabIndex(772);
		Ea54().set_TabStop(false);
		((Control)Sf2i()).set_Location(new Point(126, 362));
		((Control)Sf2i()).set_Name("PictureBox155");
		((Control)Sf2i()).set_Size(new Size(10, 12));
		Sf2i().set_SizeMode((PictureBoxSizeMode)4);
		Sf2i().set_TabIndex(771);
		Sf2i().set_TabStop(false);
		((Control)y0AN()).set_Location(new Point(110, 362));
		((Control)y0AN()).set_Name("PictureBox156");
		((Control)y0AN()).set_Size(new Size(10, 12));
		y0AN().set_SizeMode((PictureBoxSizeMode)4);
		y0AN().set_TabIndex(770);
		y0AN().set_TabStop(false);
		((Control)Cr53()).set_Location(new Point(94, 362));
		((Control)Cr53()).set_Name("PictureBox157");
		((Control)Cr53()).set_Size(new Size(10, 12));
		Cr53().set_SizeMode((PictureBoxSizeMode)4);
		Cr53().set_TabIndex(769);
		Cr53().set_TabStop(false);
		((Control)Wi9s()).set_Location(new Point(78, 362));
		((Control)Wi9s()).set_Name("PictureBox158");
		((Control)Wi9s()).set_Size(new Size(10, 12));
		Wi9s().set_SizeMode((PictureBoxSizeMode)4);
		Wi9s().set_TabIndex(768);
		Wi9s().set_TabStop(false);
		((Control)d3KB()).set_Location(new Point(62, 362));
		((Control)d3KB()).set_Name("PictureBox159");
		((Control)d3KB()).set_Size(new Size(10, 12));
		d3KB().set_SizeMode((PictureBoxSizeMode)4);
		d3KB().set_TabIndex(767);
		d3KB().set_TabStop(false);
		((Control)Bm6o()).set_Location(new Point(48, 362));
		((Control)Bm6o()).set_Name("PictureBox160");
		((Control)Bm6o()).set_Size(new Size(10, 12));
		Bm6o().set_SizeMode((PictureBoxSizeMode)4);
		Bm6o().set_TabIndex(766);
		Bm6o().set_TabStop(false);
		((Control)Se02()).set_Location(new Point(372, 340));
		((Control)Se02()).set_Name("PictureBox121");
		((Control)Se02()).set_Size(new Size(10, 12));
		Se02().set_SizeMode((PictureBoxSizeMode)4);
		Se02().set_TabIndex(765);
		Se02().set_TabStop(false);
		((Control)r2E1()).set_Location(new Point(352, 340));
		((Control)r2E1()).set_Name("PictureBox122");
		((Control)r2E1()).set_Size(new Size(10, 12));
		r2E1().set_SizeMode((PictureBoxSizeMode)4);
		r2E1().set_TabIndex(764);
		r2E1().set_TabStop(false);
		((Control)x3Y6()).set_Location(new Point(333, 340));
		((Control)x3Y6()).set_Name("PictureBox123");
		((Control)x3Y6()).set_Size(new Size(10, 12));
		x3Y6().set_SizeMode((PictureBoxSizeMode)4);
		x3Y6().set_TabIndex(763);
		x3Y6().set_TabStop(false);
		((Control)Fe1p()).set_Location(new Point(314, 340));
		((Control)Fe1p()).set_Name("PictureBox124");
		((Control)Fe1p()).set_Size(new Size(10, 12));
		Fe1p().set_SizeMode((PictureBoxSizeMode)4);
		Fe1p().set_TabIndex(762);
		Fe1p().set_TabStop(false);
		((Control)n6D9()).set_Location(new Point(296, 340));
		((Control)n6D9()).set_Name("PictureBox125");
		((Control)n6D9()).set_Size(new Size(10, 12));
		n6D9().set_SizeMode((PictureBoxSizeMode)4);
		n6D9().set_TabIndex(761);
		n6D9().set_TabStop(false);
		((Control)d0L4()).set_Location(new Point(279, 340));
		((Control)d0L4()).set_Name("PictureBox126");
		((Control)d0L4()).set_Size(new Size(10, 12));
		d0L4().set_SizeMode((PictureBoxSizeMode)4);
		d0L4().set_TabIndex(760);
		d0L4().set_TabStop(false);
		((Control)a2D8()).set_Location(new Point(261, 340));
		((Control)a2D8()).set_Name("PictureBox127");
		((Control)a2D8()).set_Size(new Size(10, 12));
		a2D8().set_SizeMode((PictureBoxSizeMode)4);
		a2D8().set_TabIndex(759);
		a2D8().set_TabStop(false);
		((Control)i0F7()).set_Location(new Point(245, 340));
		((Control)i0F7()).set_Name("PictureBox128");
		((Control)i0F7()).set_Size(new Size(10, 12));
		i0F7().set_SizeMode((PictureBoxSizeMode)4);
		i0F7().set_TabIndex(758);
		i0F7().set_TabStop(false);
		((Control)Lg7n()).set_Location(new Point(227, 340));
		((Control)Lg7n()).set_Name("PictureBox129");
		((Control)Lg7n()).set_Size(new Size(10, 12));
		Lg7n().set_SizeMode((PictureBoxSizeMode)4);
		Lg7n().set_TabIndex(757);
		Lg7n().set_TabStop(false);
		((Control)Zw16()).set_Location(new Point(208, 340));
		((Control)Zw16()).set_Name("PictureBox130");
		((Control)Zw16()).set_Size(new Size(10, 12));
		Zw16().set_SizeMode((PictureBoxSizeMode)4);
		Zw16().set_TabIndex(756);
		Zw16().set_TabStop(false);
		((Control)g3CA()).set_Location(new Point(190, 340));
		((Control)g3CA()).set_Name("PictureBox131");
		((Control)g3CA()).set_Size(new Size(10, 12));
		g3CA().set_SizeMode((PictureBoxSizeMode)4);
		g3CA().set_TabIndex(755);
		g3CA().set_TabStop(false);
		((Control)Wi6f()).set_Location(new Point(174, 340));
		((Control)Wi6f()).set_Name("PictureBox132");
		((Control)Wi6f()).set_Size(new Size(10, 12));
		Wi6f().set_SizeMode((PictureBoxSizeMode)4);
		Wi6f().set_TabIndex(754);
		Wi6f().set_TabStop(false);
		((Control)w2B4()).set_Location(new Point(158, 340));
		((Control)w2B4()).set_Name("PictureBox133");
		((Control)w2B4()).set_Size(new Size(10, 12));
		w2B4().set_SizeMode((PictureBoxSizeMode)4);
		w2B4().set_TabIndex(753);
		w2B4().set_TabStop(false);
		((Control)g0Y6()).set_Location(new Point(142, 340));
		((Control)g0Y6()).set_Name("PictureBox134");
		((Control)g0Y6()).set_Size(new Size(10, 12));
		g0Y6().set_SizeMode((PictureBoxSizeMode)4);
		g0Y6().set_TabIndex(752);
		g0Y6().set_TabStop(false);
		((Control)Ga96()).set_Location(new Point(126, 340));
		((Control)Ga96()).set_Name("PictureBox135");
		((Control)Ga96()).set_Size(new Size(10, 12));
		Ga96().set_SizeMode((PictureBoxSizeMode)4);
		Ga96().set_TabIndex(751);
		Ga96().set_TabStop(false);
		((Control)o6Q5()).set_Location(new Point(110, 340));
		((Control)o6Q5()).set_Name("PictureBox136");
		((Control)o6Q5()).set_Size(new Size(10, 12));
		o6Q5().set_SizeMode((PictureBoxSizeMode)4);
		o6Q5().set_TabIndex(750);
		o6Q5().set_TabStop(false);
		((Control)d9QL()).set_Location(new Point(94, 340));
		((Control)d9QL()).set_Name("PictureBox137");
		((Control)d9QL()).set_Size(new Size(10, 12));
		d9QL().set_SizeMode((PictureBoxSizeMode)4);
		d9QL().set_TabIndex(749);
		d9QL().set_TabStop(false);
		((Control)r0J1()).set_Location(new Point(78, 340));
		((Control)r0J1()).set_Name("PictureBox138");
		((Control)r0J1()).set_Size(new Size(10, 12));
		r0J1().set_SizeMode((PictureBoxSizeMode)4);
		r0J1().set_TabIndex(748);
		r0J1().set_TabStop(false);
		((Control)Ag82()).set_Location(new Point(62, 340));
		((Control)Ag82()).set_Name("PictureBox139");
		((Control)Ag82()).set_Size(new Size(10, 12));
		Ag82().set_SizeMode((PictureBoxSizeMode)4);
		Ag82().set_TabIndex(747);
		Ag82().set_TabStop(false);
		((Control)Ro36()).set_Location(new Point(48, 340));
		((Control)Ro36()).set_Name("PictureBox140");
		((Control)Ro36()).set_Size(new Size(10, 12));
		Ro36().set_SizeMode((PictureBoxSizeMode)4);
		Ro36().set_TabIndex(746);
		Ro36().set_TabStop(false);
		((Control)s6A9()).set_Location(new Point(372, 318));
		((Control)s6A9()).set_Name("PictureBox101");
		((Control)s6A9()).set_Size(new Size(10, 12));
		s6A9().set_SizeMode((PictureBoxSizeMode)4);
		s6A9().set_TabIndex(745);
		s6A9().set_TabStop(false);
		((Control)Ss20()).set_Location(new Point(352, 318));
		((Control)Ss20()).set_Name("PictureBox102");
		((Control)Ss20()).set_Size(new Size(10, 12));
		Ss20().set_SizeMode((PictureBoxSizeMode)4);
		Ss20().set_TabIndex(744);
		Ss20().set_TabStop(false);
		((Control)a2N0()).set_Location(new Point(333, 318));
		((Control)a2N0()).set_Name("PictureBox103");
		((Control)a2N0()).set_Size(new Size(10, 12));
		a2N0().set_SizeMode((PictureBoxSizeMode)4);
		a2N0().set_TabIndex(743);
		a2N0().set_TabStop(false);
		((Control)s4W5()).set_Location(new Point(314, 318));
		((Control)s4W5()).set_Name("PictureBox104");
		((Control)s4W5()).set_Size(new Size(10, 12));
		s4W5().set_SizeMode((PictureBoxSizeMode)4);
		s4W5().set_TabIndex(742);
		s4W5().set_TabStop(false);
		((Control)Qj5i()).set_Location(new Point(296, 318));
		((Control)Qj5i()).set_Name("PictureBox105");
		((Control)Qj5i()).set_Size(new Size(10, 12));
		Qj5i().set_SizeMode((PictureBoxSizeMode)4);
		Qj5i().set_TabIndex(741);
		Qj5i().set_TabStop(false);
		((Control)Eb6g()).set_Location(new Point(279, 318));
		((Control)Eb6g()).set_Name("PictureBox106");
		((Control)Eb6g()).set_Size(new Size(10, 12));
		Eb6g().set_SizeMode((PictureBoxSizeMode)4);
		Eb6g().set_TabIndex(740);
		Eb6g().set_TabStop(false);
		((Control)k9EQ()).set_Location(new Point(261, 318));
		((Control)k9EQ()).set_Name("PictureBox107");
		((Control)k9EQ()).set_Size(new Size(10, 12));
		k9EQ().set_SizeMode((PictureBoxSizeMode)4);
		k9EQ().set_TabIndex(739);
		k9EQ().set_TabStop(false);
		((Control)r2AW()).set_Location(new Point(245, 318));
		((Control)r2AW()).set_Name("PictureBox108");
		((Control)r2AW()).set_Size(new Size(10, 12));
		r2AW().set_SizeMode((PictureBoxSizeMode)4);
		r2AW().set_TabIndex(738);
		r2AW().set_TabStop(false);
		((Control)k5H2()).set_Location(new Point(227, 318));
		((Control)k5H2()).set_Name("PictureBox109");
		((Control)k5H2()).set_Size(new Size(10, 12));
		k5H2().set_SizeMode((PictureBoxSizeMode)4);
		k5H2().set_TabIndex(737);
		k5H2().set_TabStop(false);
		((Control)Nj0y()).set_Location(new Point(208, 318));
		((Control)Nj0y()).set_Name("PictureBox110");
		((Control)Nj0y()).set_Size(new Size(10, 12));
		Nj0y().set_SizeMode((PictureBoxSizeMode)4);
		Nj0y().set_TabIndex(736);
		Nj0y().set_TabStop(false);
		((Control)Ma60()).set_Location(new Point(190, 318));
		((Control)Ma60()).set_Name("PictureBox111");
		((Control)Ma60()).set_Size(new Size(10, 12));
		Ma60().set_SizeMode((PictureBoxSizeMode)4);
		Ma60().set_TabIndex(735);
		Ma60().set_TabStop(false);
		((Control)Gx6s()).set_Location(new Point(174, 318));
		((Control)Gx6s()).set_Name("PictureBox112");
		((Control)Gx6s()).set_Size(new Size(10, 12));
		Gx6s().set_SizeMode((PictureBoxSizeMode)4);
		Gx6s().set_TabIndex(734);
		Gx6s().set_TabStop(false);
		((Control)g7C5()).set_Location(new Point(158, 318));
		((Control)g7C5()).set_Name("PictureBox113");
		((Control)g7C5()).set_Size(new Size(10, 12));
		g7C5().set_SizeMode((PictureBoxSizeMode)4);
		g7C5().set_TabIndex(733);
		g7C5().set_TabStop(false);
		((Control)e9EH()).set_Location(new Point(142, 318));
		((Control)e9EH()).set_Name("PictureBox114");
		((Control)e9EH()).set_Size(new Size(10, 12));
		e9EH().set_SizeMode((PictureBoxSizeMode)4);
		e9EH().set_TabIndex(732);
		e9EH().set_TabStop(false);
		((Control)s0L7()).set_Location(new Point(126, 318));
		((Control)s0L7()).set_Name("PictureBox115");
		((Control)s0L7()).set_Size(new Size(10, 12));
		s0L7().set_SizeMode((PictureBoxSizeMode)4);
		s0L7().set_TabIndex(731);
		s0L7().set_TabStop(false);
		((Control)t3LT()).set_Location(new Point(110, 318));
		((Control)t3LT()).set_Name("PictureBox116");
		((Control)t3LT()).set_Size(new Size(10, 12));
		t3LT().set_SizeMode((PictureBoxSizeMode)4);
		t3LT().set_TabIndex(730);
		t3LT().set_TabStop(false);
		((Control)j7F3()).set_Location(new Point(94, 318));
		((Control)j7F3()).set_Name("PictureBox117");
		((Control)j7F3()).set_Size(new Size(10, 12));
		j7F3().set_SizeMode((PictureBoxSizeMode)4);
		j7F3().set_TabIndex(729);
		j7F3().set_TabStop(false);
		((Control)Hj6b()).set_Location(new Point(78, 318));
		((Control)Hj6b()).set_Name("PictureBox118");
		((Control)Hj6b()).set_Size(new Size(10, 12));
		Hj6b().set_SizeMode((PictureBoxSizeMode)4);
		Hj6b().set_TabIndex(728);
		Hj6b().set_TabStop(false);
		((Control)As2c()).set_Location(new Point(62, 318));
		((Control)As2c()).set_Name("PictureBox119");
		((Control)As2c()).set_Size(new Size(10, 12));
		As2c().set_SizeMode((PictureBoxSizeMode)4);
		As2c().set_TabIndex(727);
		As2c().set_TabStop(false);
		((Control)Yg79()).set_Location(new Point(48, 318));
		((Control)Yg79()).set_Name("PictureBox120");
		((Control)Yg79()).set_Size(new Size(10, 12));
		Yg79().set_SizeMode((PictureBoxSizeMode)4);
		Yg79().set_TabIndex(726);
		Yg79().set_TabStop(false);
		((Control)q4RP()).set_Location(new Point(372, 299));
		((Control)q4RP()).set_Name("PictureBox81");
		((Control)q4RP()).set_Size(new Size(10, 12));
		q4RP().set_SizeMode((PictureBoxSizeMode)4);
		q4RP().set_TabIndex(725);
		q4RP().set_TabStop(false);
		((Control)w0K8()).set_Location(new Point(352, 299));
		((Control)w0K8()).set_Name("PictureBox82");
		((Control)w0K8()).set_Size(new Size(10, 12));
		w0K8().set_SizeMode((PictureBoxSizeMode)4);
		w0K8().set_TabIndex(724);
		w0K8().set_TabStop(false);
		((Control)r5YJ()).set_Location(new Point(333, 299));
		((Control)r5YJ()).set_Name("PictureBox83");
		((Control)r5YJ()).set_Size(new Size(10, 12));
		r5YJ().set_SizeMode((PictureBoxSizeMode)4);
		r5YJ().set_TabIndex(723);
		r5YJ().set_TabStop(false);
		((Control)t6G4()).set_Location(new Point(314, 299));
		((Control)t6G4()).set_Name("PictureBox84");
		((Control)t6G4()).set_Size(new Size(10, 12));
		t6G4().set_SizeMode((PictureBoxSizeMode)4);
		t6G4().set_TabIndex(722);
		t6G4().set_TabStop(false);
		((Control)Ze0q()).set_Location(new Point(296, 299));
		((Control)Ze0q()).set_Name("PictureBox85");
		((Control)Ze0q()).set_Size(new Size(10, 12));
		Ze0q().set_SizeMode((PictureBoxSizeMode)4);
		Ze0q().set_TabIndex(721);
		Ze0q().set_TabStop(false);
		((Control)Dn2c()).set_Location(new Point(279, 299));
		((Control)Dn2c()).set_Name("PictureBox86");
		((Control)Dn2c()).set_Size(new Size(10, 12));
		Dn2c().set_SizeMode((PictureBoxSizeMode)4);
		Dn2c().set_TabIndex(720);
		Dn2c().set_TabStop(false);
		((Control)z2F1()).set_Location(new Point(261, 299));
		((Control)z2F1()).set_Name("PictureBox87");
		((Control)z2F1()).set_Size(new Size(10, 12));
		z2F1().set_SizeMode((PictureBoxSizeMode)4);
		z2F1().set_TabIndex(719);
		z2F1().set_TabStop(false);
		((Control)y5E8()).set_Location(new Point(245, 299));
		((Control)y5E8()).set_Name("PictureBox88");
		((Control)y5E8()).set_Size(new Size(10, 12));
		y5E8().set_SizeMode((PictureBoxSizeMode)4);
		y5E8().set_TabIndex(718);
		y5E8().set_TabStop(false);
		((Control)Rg38()).set_Location(new Point(227, 299));
		((Control)Rg38()).set_Name("PictureBox89");
		((Control)Rg38()).set_Size(new Size(10, 12));
		Rg38().set_SizeMode((PictureBoxSizeMode)4);
		Rg38().set_TabIndex(717);
		Rg38().set_TabStop(false);
		((Control)y2D7()).set_Location(new Point(208, 299));
		((Control)y2D7()).set_Name("PictureBox90");
		((Control)y2D7()).set_Size(new Size(10, 12));
		y2D7().set_SizeMode((PictureBoxSizeMode)4);
		y2D7().set_TabIndex(716);
		y2D7().set_TabStop(false);
		((Control)r5RZ()).set_Location(new Point(190, 299));
		((Control)r5RZ()).set_Name("PictureBox91");
		((Control)r5RZ()).set_Size(new Size(10, 12));
		r5RZ().set_SizeMode((PictureBoxSizeMode)4);
		r5RZ().set_TabIndex(715);
		r5RZ().set_TabStop(false);
		((Control)Zr8t()).set_Location(new Point(174, 299));
		((Control)Zr8t()).set_Name("PictureBox92");
		((Control)Zr8t()).set_Size(new Size(10, 12));
		Zr8t().set_SizeMode((PictureBoxSizeMode)4);
		Zr8t().set_TabIndex(714);
		Zr8t().set_TabStop(false);
		((Control)q8NZ()).set_Location(new Point(158, 299));
		((Control)q8NZ()).set_Name("PictureBox93");
		((Control)q8NZ()).set_Size(new Size(10, 12));
		q8NZ().set_SizeMode((PictureBoxSizeMode)4);
		q8NZ().set_TabIndex(713);
		q8NZ().set_TabStop(false);
		((Control)Jj6n()).set_Location(new Point(142, 299));
		((Control)Jj6n()).set_Name("PictureBox94");
		((Control)Jj6n()).set_Size(new Size(10, 12));
		Jj6n().set_SizeMode((PictureBoxSizeMode)4);
		Jj6n().set_TabIndex(712);
		Jj6n().set_TabStop(false);
		((Control)Xj97()).set_Location(new Point(126, 299));
		((Control)Xj97()).set_Name("PictureBox95");
		((Control)Xj97()).set_Size(new Size(10, 12));
		Xj97().set_SizeMode((PictureBoxSizeMode)4);
		Xj97().set_TabIndex(711);
		Xj97().set_TabStop(false);
		((Control)s2CQ()).set_Location(new Point(110, 299));
		((Control)s2CQ()).set_Name("PictureBox96");
		((Control)s2CQ()).set_Size(new Size(10, 12));
		s2CQ().set_SizeMode((PictureBoxSizeMode)4);
		s2CQ().set_TabIndex(710);
		s2CQ().set_TabStop(false);
		((Control)Dt82()).set_Location(new Point(94, 299));
		((Control)Dt82()).set_Name("PictureBox97");
		((Control)Dt82()).set_Size(new Size(10, 12));
		Dt82().set_SizeMode((PictureBoxSizeMode)4);
		Dt82().set_TabIndex(709);
		Dt82().set_TabStop(false);
		((Control)y8YQ()).set_Location(new Point(78, 299));
		((Control)y8YQ()).set_Name("PictureBox98");
		((Control)y8YQ()).set_Size(new Size(10, 12));
		y8YQ().set_SizeMode((PictureBoxSizeMode)4);
		y8YQ().set_TabIndex(708);
		y8YQ().set_TabStop(false);
		((Control)k9M8()).set_Location(new Point(62, 299));
		((Control)k9M8()).set_Name("PictureBox99");
		((Control)k9M8()).set_Size(new Size(10, 12));
		k9M8().set_SizeMode((PictureBoxSizeMode)4);
		k9M8().set_TabIndex(707);
		k9M8().set_TabStop(false);
		((Control)Hi94()).set_Location(new Point(48, 299));
		((Control)Hi94()).set_Name("PictureBox100");
		((Control)Hi94()).set_Size(new Size(10, 12));
		Hi94().set_SizeMode((PictureBoxSizeMode)4);
		Hi94().set_TabIndex(706);
		Hi94().set_TabStop(false);
		((Control)y8KZ()).get_Controls().Add((Control)(object)Lo7g());
		((Control)y8KZ()).get_Controls().Add((Control)(object)a5Y8());
		((Control)y8KZ()).get_Controls().Add((Control)(object)k2GR());
		((Control)y8KZ()).get_Controls().Add((Control)(object)Nx8w());
		((Control)y8KZ()).get_Controls().Add((Control)(object)q0H1());
		((Control)y8KZ()).get_Controls().Add((Control)(object)Pk6s());
		((Control)y8KZ()).get_Controls().Add((Control)(object)Gs39());
		((Control)y8KZ()).get_Controls().Add((Control)(object)m2QP());
		((Control)y8KZ()).get_Controls().Add((Control)(object)j6Y1());
		((Control)y8KZ()).get_Controls().Add((Control)(object)Bj75());
		((Control)y8KZ()).set_ForeColor(SystemColors.ControlLight);
		((Control)y8KZ()).set_Location(new Point(689, 188));
		((Control)y8KZ()).set_Name("GroupBox4");
		((Control)y8KZ()).set_Size(new Size(211, 231));
		((Control)y8KZ()).set_TabIndex(786);
		y8KZ().set_TabStop(false);
		y8KZ().set_Text("Billing INFO");
		((ButtonBase)Lo7g()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Lo7g()).set_FlatStyle((FlatStyle)0);
		((Control)Lo7g()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Lo7g()).set_Location(new Point(72, 184));
		((Control)Lo7g()).set_Name("btnSave");
		((Control)Lo7g()).set_Size(new Size(133, 23));
		((Control)Lo7g()).set_TabIndex(40);
		((ButtonBase)Lo7g()).set_Text("Save / Receipt Preview");
		((ButtonBase)Lo7g()).set_UseVisualStyleBackColor(true);
		((ButtonBase)a5Y8()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)a5Y8()).set_FlatStyle((FlatStyle)0);
		((Control)a5Y8()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)a5Y8()).set_Location(new Point(103, 155));
		((Control)a5Y8()).set_Name("btnCalculateChange");
		((Control)a5Y8()).set_Size(new Size(101, 23));
		((Control)a5Y8()).set_TabIndex(39);
		((ButtonBase)a5Y8()).set_Text("Calculate Change");
		((ButtonBase)a5Y8()).set_UseVisualStyleBackColor(true);
		((Control)k2GR()).set_Location(new Point(95, 123));
		((Control)k2GR()).set_Name("txtChange");
		((Control)k2GR()).set_Size(new Size(110, 20));
		((Control)k2GR()).set_TabIndex(34);
		((Control)Nx8w()).set_Location(new Point(95, 91));
		((Control)Nx8w()).set_Name("txtTotalPayment");
		((Control)Nx8w()).set_Size(new Size(110, 20));
		((Control)Nx8w()).set_TabIndex(33);
		((Control)q0H1()).set_Location(new Point(96, 58));
		((Control)q0H1()).set_Name("txtTotalCost");
		((Control)q0H1()).set_Size(new Size(109, 20));
		((Control)q0H1()).set_TabIndex(32);
		((Control)Pk6s()).set_Location(new Point(122, 24));
		((Control)Pk6s()).set_Name("txtSeats");
		((Control)Pk6s()).set_Size(new Size(83, 20));
		((Control)Pk6s()).set_TabIndex(31);
		Gs39().set_AutoSize(true);
		((Control)Gs39()).set_BackColor(Color.Transparent);
		((Control)Gs39()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Gs39()).set_Location(new Point(8, 62));
		((Control)Gs39()).set_Name("Label63");
		((Control)Gs39()).set_Size(new Size(66, 13));
		((Control)Gs39()).set_TabIndex(16);
		Gs39().set_Text("Total Costs :");
		m2QP().set_AutoSize(true);
		((Control)m2QP()).set_BackColor(Color.Transparent);
		((Control)m2QP()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)m2QP()).set_Location(new Point(8, 27));
		((Control)m2QP()).set_Name("Label64");
		((Control)m2QP()).set_Size(new Size(106, 13));
		((Control)m2QP()).set_TabIndex(15);
		m2QP().set_Text("Seats to be booked :");
		j6Y1().set_AutoSize(true);
		((Control)j6Y1()).set_BackColor(Color.Transparent);
		((Control)j6Y1()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)j6Y1()).set_Location(new Point(8, 121));
		((Control)j6Y1()).set_Name("Label61");
		((Control)j6Y1()).set_Size(new Size(50, 13));
		((Control)j6Y1()).set_TabIndex(14);
		j6Y1().set_Text("Change :");
		Bj75().set_AutoSize(true);
		((Control)Bj75()).set_BackColor(Color.Transparent);
		((Control)Bj75()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Bj75()).set_Location(new Point(8, 91));
		((Control)Bj75()).set_Name("Label62");
		((Control)Bj75()).set_Size(new Size(81, 13));
		((Control)Bj75()).set_TabIndex(13);
		Bj75().set_Text("Total Payment :");
		((Control)Nd20()).get_Controls().Add((Control)(object)Ez65());
		((Control)Nd20()).get_Controls().Add((Control)(object)Li31());
		((Control)Nd20()).get_Controls().Add((Control)(object)i2KA());
		((Control)Nd20()).get_Controls().Add((Control)(object)Qf6r());
		((Control)Nd20()).get_Controls().Add((Control)(object)j4E1());
		((Control)Nd20()).get_Controls().Add((Control)(object)r5KR());
		((Control)Nd20()).get_Controls().Add((Control)(object)Cg4i());
		((Control)Nd20()).set_ForeColor(SystemColors.ControlLight);
		((Control)Nd20()).set_Location(new Point(700, 49));
		((Control)Nd20()).set_Name("GroupBox2");
		((Control)Nd20()).set_Size(new Size(200, 129));
		((Control)Nd20()).set_TabIndex(785);
		Nd20().set_TabStop(false);
		Nd20().set_Text("Customer");
		((ButtonBase)Ez65()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ez65()).set_FlatStyle((FlatStyle)0);
		((Control)Ez65()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ez65()).set_Location(new Point(70, 90));
		((Control)Ez65()).set_Name("btnNew");
		((Control)Ez65()).set_Size(new Size(54, 23));
		((Control)Ez65()).set_TabIndex(39);
		((ButtonBase)Ez65()).set_Text("New");
		((ButtonBase)Ez65()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Li31()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Li31()).set_FlatStyle((FlatStyle)0);
		((Control)Li31()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Li31()).set_Location(new Point(130, 90));
		((Control)Li31()).set_Name("btnReset");
		((Control)Li31()).set_Size(new Size(54, 23));
		((Control)Li31()).set_TabIndex(38);
		((ButtonBase)Li31()).set_Text("Reset");
		((ButtonBase)Li31()).set_UseVisualStyleBackColor(true);
		((ButtonBase)i2KA()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)i2KA()).set_FlatStyle((FlatStyle)0);
		((Control)i2KA()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)i2KA()).set_Location(new Point(10, 90));
		((Control)i2KA()).set_Name("btnExisting");
		((Control)i2KA()).set_Size(new Size(54, 23));
		((Control)i2KA()).set_TabIndex(37);
		((ButtonBase)i2KA()).set_Text("Existing");
		((ButtonBase)i2KA()).set_UseVisualStyleBackColor(true);
		((Control)Qf6r()).set_Location(new Point(94, 57));
		((Control)Qf6r()).set_Name("txtFirstName");
		((Control)Qf6r()).set_Size(new Size(103, 20));
		((Control)Qf6r()).set_TabIndex(30);
		((Control)j4E1()).set_Location(new Point(94, 31));
		((Control)j4E1()).set_Name("txtID");
		((Control)j4E1()).set_Size(new Size(103, 20));
		((Control)j4E1()).set_TabIndex(29);
		r5KR().set_AutoSize(true);
		((Control)r5KR()).set_BackColor(Color.Transparent);
		((Control)r5KR()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)r5KR()).set_Location(new Point(6, 58));
		((Control)r5KR()).set_Name("Label60");
		((Control)r5KR()).set_Size(new Size(57, 13));
		((Control)r5KR()).set_TabIndex(12);
		r5KR().set_Text("First Name");
		Cg4i().set_AutoSize(true);
		((Control)Cg4i()).set_BackColor(Color.Transparent);
		((Control)Cg4i()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Cg4i()).set_Location(new Point(6, 34));
		((Control)Cg4i()).set_Name("Label59");
		((Control)Cg4i()).set_Size(new Size(65, 13));
		((Control)Cg4i()).set_TabIndex(11);
		Cg4i().set_Text("Customer ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)y8KZ());
		((Control)this).get_Controls().Add((Control)(object)Nd20());
		((Control)this).get_Controls().Add((Control)(object)f1ZW());
		((Control)this).get_Controls().Add((Control)(object)r8Q7());
		((Control)this).get_Controls().Add((Control)(object)q7YT());
		((Control)this).get_Controls().Add((Control)(object)p4WR());
		((Control)this).get_Controls().Add((Control)(object)Bd86());
		((Control)this).get_Controls().Add((Control)(object)q9JR());
		((Control)this).get_Controls().Add((Control)(object)x1G0());
		((Control)this).get_Controls().Add((Control)(object)Yy83());
		((Control)this).get_Controls().Add((Control)(object)Xa0n());
		((Control)this).get_Controls().Add((Control)(object)d1GJ());
		((Control)this).get_Controls().Add((Control)(object)Hj2p());
		((Control)this).get_Controls().Add((Control)(object)r3PB());
		((Control)this).get_Controls().Add((Control)(object)Ea54());
		((Control)this).get_Controls().Add((Control)(object)Sf2i());
		((Control)this).get_Controls().Add((Control)(object)y0AN());
		((Control)this).get_Controls().Add((Control)(object)Cr53());
		((Control)this).get_Controls().Add((Control)(object)Wi9s());
		((Control)this).get_Controls().Add((Control)(object)d3KB());
		((Control)this).get_Controls().Add((Control)(object)Bm6o());
		((Control)this).get_Controls().Add((Control)(object)Se02());
		((Control)this).get_Controls().Add((Control)(object)r2E1());
		((Control)this).get_Controls().Add((Control)(object)x3Y6());
		((Control)this).get_Controls().Add((Control)(object)Fe1p());
		((Control)this).get_Controls().Add((Control)(object)n6D9());
		((Control)this).get_Controls().Add((Control)(object)d0L4());
		((Control)this).get_Controls().Add((Control)(object)a2D8());
		((Control)this).get_Controls().Add((Control)(object)i0F7());
		((Control)this).get_Controls().Add((Control)(object)Lg7n());
		((Control)this).get_Controls().Add((Control)(object)Zw16());
		((Control)this).get_Controls().Add((Control)(object)g3CA());
		((Control)this).get_Controls().Add((Control)(object)Wi6f());
		((Control)this).get_Controls().Add((Control)(object)w2B4());
		((Control)this).get_Controls().Add((Control)(object)g0Y6());
		((Control)this).get_Controls().Add((Control)(object)Ga96());
		((Control)this).get_Controls().Add((Control)(object)o6Q5());
		((Control)this).get_Controls().Add((Control)(object)d9QL());
		((Control)this).get_Controls().Add((Control)(object)r0J1());
		((Control)this).get_Controls().Add((Control)(object)Ag82());
		((Control)this).get_Controls().Add((Control)(object)Ro36());
		((Control)this).get_Controls().Add((Control)(object)s6A9());
		((Control)this).get_Controls().Add((Control)(object)Ss20());
		((Control)this).get_Controls().Add((Control)(object)a2N0());
		((Control)this).get_Controls().Add((Control)(object)s4W5());
		((Control)this).get_Controls().Add((Control)(object)Qj5i());
		((Control)this).get_Controls().Add((Control)(object)Eb6g());
		((Control)this).get_Controls().Add((Control)(object)k9EQ());
		((Control)this).get_Controls().Add((Control)(object)r2AW());
		((Control)this).get_Controls().Add((Control)(object)k5H2());
		((Control)this).get_Controls().Add((Control)(object)Nj0y());
		((Control)this).get_Controls().Add((Control)(object)Ma60());
		((Control)this).get_Controls().Add((Control)(object)Gx6s());
		((Control)this).get_Controls().Add((Control)(object)g7C5());
		((Control)this).get_Controls().Add((Control)(object)e9EH());
		((Control)this).get_Controls().Add((Control)(object)s0L7());
		((Control)this).get_Controls().Add((Control)(object)t3LT());
		((Control)this).get_Controls().Add((Control)(object)j7F3());
		((Control)this).get_Controls().Add((Control)(object)Hj6b());
		((Control)this).get_Controls().Add((Control)(object)As2c());
		((Control)this).get_Controls().Add((Control)(object)Yg79());
		((Control)this).get_Controls().Add((Control)(object)q4RP());
		((Control)this).get_Controls().Add((Control)(object)w0K8());
		((Control)this).get_Controls().Add((Control)(object)r5YJ());
		((Control)this).get_Controls().Add((Control)(object)t6G4());
		((Control)this).get_Controls().Add((Control)(object)Ze0q());
		((Control)this).get_Controls().Add((Control)(object)Dn2c());
		((Control)this).get_Controls().Add((Control)(object)z2F1());
		((Control)this).get_Controls().Add((Control)(object)y5E8());
		((Control)this).get_Controls().Add((Control)(object)Rg38());
		((Control)this).get_Controls().Add((Control)(object)y2D7());
		((Control)this).get_Controls().Add((Control)(object)r5RZ());
		((Control)this).get_Controls().Add((Control)(object)Zr8t());
		((Control)this).get_Controls().Add((Control)(object)q8NZ());
		((Control)this).get_Controls().Add((Control)(object)Jj6n());
		((Control)this).get_Controls().Add((Control)(object)Xj97());
		((Control)this).get_Controls().Add((Control)(object)s2CQ());
		((Control)this).get_Controls().Add((Control)(object)Dt82());
		((Control)this).get_Controls().Add((Control)(object)y8YQ());
		((Control)this).get_Controls().Add((Control)(object)k9M8());
		((Control)this).get_Controls().Add((Control)(object)Hi94());
		((Control)this).get_Controls().Add((Control)(object)j8QP());
		((Control)this).get_Controls().Add((Control)(object)Jy9i());
		((Control)this).get_Controls().Add((Control)(object)d8KN());
		((Control)this).get_Controls().Add((Control)(object)Ey9d());
		((Control)this).get_Controls().Add((Control)(object)Zk9t());
		((Control)this).get_Controls().Add((Control)(object)Ai15());
		((Control)this).get_Controls().Add((Control)(object)Zf24());
		((Control)this).get_Controls().Add((Control)(object)o7S9());
		((Control)this).get_Controls().Add((Control)(object)r0KS());
		((Control)this).get_Controls().Add((Control)(object)j9DQ());
		((Control)this).get_Controls().Add((Control)(object)z2NB());
		((Control)this).get_Controls().Add((Control)(object)My5t());
		((Control)this).get_Controls().Add((Control)(object)Rn82());
		((Control)this).get_Controls().Add((Control)(object)a7D5());
		((Control)this).get_Controls().Add((Control)(object)Wz9d());
		((Control)this).get_Controls().Add((Control)(object)r2HZ());
		((Control)this).get_Controls().Add((Control)(object)Qa0f());
		((Control)this).get_Controls().Add((Control)(object)Ym4q());
		((Control)this).get_Controls().Add((Control)(object)z0X3());
		((Control)this).get_Controls().Add((Control)(object)k0T5());
		((Control)this).get_Controls().Add((Control)(object)Sf7s());
		((Control)this).get_Controls().Add((Control)(object)a8QE());
		((Control)this).get_Controls().Add((Control)(object)Ks2x());
		((Control)this).get_Controls().Add((Control)(object)Te8a());
		((Control)this).get_Controls().Add((Control)(object)a1SC());
		((Control)this).get_Controls().Add((Control)(object)Xf0g());
		((Control)this).get_Controls().Add((Control)(object)x3S4());
		((Control)this).get_Controls().Add((Control)(object)Gi31());
		((Control)this).get_Controls().Add((Control)(object)e6SY());
		((Control)this).get_Controls().Add((Control)(object)i2Q1());
		((Control)this).get_Controls().Add((Control)(object)x2CF());
		((Control)this).get_Controls().Add((Control)(object)q2QG());
		((Control)this).get_Controls().Add((Control)(object)Gr97());
		((Control)this).get_Controls().Add((Control)(object)a3C0());
		((Control)this).get_Controls().Add((Control)(object)f3SD());
		((Control)this).get_Controls().Add((Control)(object)g7AM());
		((Control)this).get_Controls().Add((Control)(object)Js1f());
		((Control)this).get_Controls().Add((Control)(object)p7D3());
		((Control)this).get_Controls().Add((Control)(object)i7QH());
		((Control)this).get_Controls().Add((Control)(object)n3BM());
		((Control)this).get_Controls().Add((Control)(object)Fg0k());
		((Control)this).get_Controls().Add((Control)(object)Ss1a());
		((Control)this).get_Controls().Add((Control)(object)i2FT());
		((Control)this).get_Controls().Add((Control)(object)f1F0());
		((Control)this).get_Controls().Add((Control)(object)Ab13());
		((Control)this).get_Controls().Add((Control)(object)Rn4s());
		((Control)this).get_Controls().Add((Control)(object)s1Z6());
		((Control)this).get_Controls().Add((Control)(object)e2MD());
		((Control)this).get_Controls().Add((Control)(object)p5F1());
		((Control)this).get_Controls().Add((Control)(object)y2NM());
		((Control)this).get_Controls().Add((Control)(object)Ac58());
		((Control)this).get_Controls().Add((Control)(object)p4RZ());
		((Control)this).get_Controls().Add((Control)(object)g0HD());
		((Control)this).get_Controls().Add((Control)(object)x4TK());
		((Control)this).get_Controls().Add((Control)(object)i6BG());
		((Control)this).get_Controls().Add((Control)(object)Fq80());
		((Control)this).get_Controls().Add((Control)(object)m9L0());
		((Control)this).get_Controls().Add((Control)(object)k1XN());
		((Control)this).get_Controls().Add((Control)(object)Zp5z());
		((Control)this).get_Controls().Add((Control)(object)Nb42());
		((Control)this).get_Controls().Add((Control)(object)w7LK());
		((Control)this).get_Controls().Add((Control)(object)t6TB());
		((Control)this).get_Controls().Add((Control)(object)p2N5());
		((Control)this).get_Controls().Add((Control)(object)Rd14());
		((Control)this).get_Controls().Add((Control)(object)q0T1());
		((Control)this).get_Controls().Add((Control)(object)Ni9n());
		((Control)this).get_Controls().Add((Control)(object)Zp76());
		((Control)this).get_Controls().Add((Control)(object)c6P2());
		((Control)this).get_Controls().Add((Control)(object)s2MZ());
		((Control)this).get_Controls().Add((Control)(object)Cp3s());
		((Control)this).get_Controls().Add((Control)(object)Ym7o());
		((Control)this).get_Controls().Add((Control)(object)r9XE());
		((Control)this).get_Controls().Add((Control)(object)Pp62());
		((Control)this).get_Controls().Add((Control)(object)Tb8k());
		((Control)this).get_Controls().Add((Control)(object)o5J1());
		((Control)this).get_Controls().Add((Control)(object)Yg8w());
		((Control)this).get_Controls().Add((Control)(object)Sx87());
		((Control)this).get_Controls().Add((Control)(object)Tg86());
		((Control)this).get_Controls().Add((Control)(object)So92());
		((Control)this).get_Controls().Add((Control)(object)Ji46());
		((Control)this).get_Controls().Add((Control)(object)Yn64());
		((Control)this).get_Controls().Add((Control)(object)q0E3());
		((Control)this).get_Controls().Add((Control)(object)j8AM());
		((Control)this).get_Controls().Add((Control)(object)Cd76());
		((Control)this).get_Controls().Add((Control)(object)f4DB());
		((Control)this).get_Controls().Add((Control)(object)c3GP());
		((Control)this).get_Controls().Add((Control)(object)t8C5());
		((Control)this).get_Controls().Add((Control)(object)g3H6());
		((Control)this).get_Controls().Add((Control)(object)Si95());
		((Control)this).get_Controls().Add((Control)(object)r6L0());
		((Control)this).get_Controls().Add((Control)(object)c9NT());
		((Control)this).get_Controls().Add((Control)(object)Wm1f());
		((Control)this).get_Controls().Add((Control)(object)j1F2());
		((Control)this).get_Controls().Add((Control)(object)p5GY());
		((Control)this).get_Controls().Add((Control)(object)g5K9());
		((Control)this).get_Controls().Add((Control)(object)p0JX());
		((Control)this).get_Controls().Add((Control)(object)f2T8());
		((Control)this).get_Controls().Add((Control)(object)s1L4());
		((Control)this).get_Controls().Add((Control)(object)Ao60());
		((Control)this).get_Controls().Add((Control)(object)e3X8());
		((Control)this).get_Controls().Add((Control)(object)Ho49());
		((Control)this).get_Controls().Add((Control)(object)f4RP());
		((Control)this).get_Controls().Add((Control)(object)Xg2j());
		((Control)this).get_Controls().Add((Control)(object)q1BK());
		((Control)this).get_Controls().Add((Control)(object)Tc64());
		((Control)this).get_Controls().Add((Control)(object)Kp05());
		((Control)this).get_Controls().Add((Control)(object)Nc12());
		((Control)this).get_Controls().Add((Control)(object)Fy53());
		((Control)this).get_Controls().Add((Control)(object)So91());
		((Control)this).get_Controls().Add((Control)(object)j1K7());
		((Control)this).get_Controls().Add((Control)(object)Et4x());
		((Control)this).get_Controls().Add((Control)(object)f9C7());
		((Control)this).get_Controls().Add((Control)(object)f9G5());
		((Control)this).get_Controls().Add((Control)(object)Hc81());
		((Control)this).get_Controls().Add((Control)(object)Hq43());
		((Control)this).get_Controls().Add((Control)(object)Qp5o());
		((Control)this).get_Controls().Add((Control)(object)Dj1s());
		((Control)this).get_Controls().Add((Control)(object)Yt19());
		((Control)this).get_Controls().Add((Control)(object)s2K5());
		((Control)this).get_Controls().Add((Control)(object)Xi08());
		((Control)this).get_Controls().Add((Control)(object)r7J9());
		((Control)this).get_Controls().Add((Control)(object)p2B5());
		((Control)this).get_Controls().Add((Control)(object)Yj3i());
		((Control)this).get_Controls().Add((Control)(object)Nr2m());
		((Control)this).get_Controls().Add((Control)(object)Hz16());
		((Control)this).get_Controls().Add((Control)(object)a1BZ());
		((Control)this).get_Controls().Add((Control)(object)k9H2());
		((Control)this).get_Controls().Add((Control)(object)n2K8());
		((Control)this).get_Controls().Add((Control)(object)Yo75());
		((Control)this).get_Controls().Add((Control)(object)Aq93());
		((Control)this).get_Controls().Add((Control)(object)j3GN());
		((Control)this).get_Controls().Add((Control)(object)f3P9());
		((Control)this).get_Controls().Add((Control)(object)Bn64());
		((Control)this).get_Controls().Add((Control)(object)Xx69());
		((Control)this).get_Controls().Add((Control)(object)q1LD());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 2");
		((ISupportInitialize)b9NA()).EndInit();
		((ISupportInitialize)t8ZK()).EndInit();
		((ISupportInitialize)Et20()).EndInit();
		((ISupportInitialize)i4P1()).EndInit();
		((Control)j3GN()).ResumeLayout(false);
		((Control)f3P9()).ResumeLayout(false);
		((Control)f3P9()).PerformLayout();
		((ISupportInitialize)Xx69()).EndInit();
		((ISupportInitialize)q1LD()).EndInit();
		((ISupportInitialize)j8QP()).EndInit();
		((ISupportInitialize)Jy9i()).EndInit();
		((ISupportInitialize)d8KN()).EndInit();
		((ISupportInitialize)Ey9d()).EndInit();
		((ISupportInitialize)Zk9t()).EndInit();
		((ISupportInitialize)Ai15()).EndInit();
		((ISupportInitialize)Zf24()).EndInit();
		((ISupportInitialize)o7S9()).EndInit();
		((ISupportInitialize)r0KS()).EndInit();
		((ISupportInitialize)j9DQ()).EndInit();
		((ISupportInitialize)z2NB()).EndInit();
		((ISupportInitialize)My5t()).EndInit();
		((ISupportInitialize)Rn82()).EndInit();
		((ISupportInitialize)a7D5()).EndInit();
		((ISupportInitialize)Wz9d()).EndInit();
		((ISupportInitialize)r2HZ()).EndInit();
		((ISupportInitialize)Qa0f()).EndInit();
		((ISupportInitialize)Ym4q()).EndInit();
		((ISupportInitialize)z0X3()).EndInit();
		((ISupportInitialize)k0T5()).EndInit();
		((ISupportInitialize)Sf7s()).EndInit();
		((ISupportInitialize)a8QE()).EndInit();
		((ISupportInitialize)Ks2x()).EndInit();
		((ISupportInitialize)Te8a()).EndInit();
		((ISupportInitialize)a1SC()).EndInit();
		((ISupportInitialize)Xf0g()).EndInit();
		((ISupportInitialize)x3S4()).EndInit();
		((ISupportInitialize)Gi31()).EndInit();
		((ISupportInitialize)e6SY()).EndInit();
		((ISupportInitialize)i2Q1()).EndInit();
		((ISupportInitialize)x2CF()).EndInit();
		((ISupportInitialize)q2QG()).EndInit();
		((ISupportInitialize)Gr97()).EndInit();
		((ISupportInitialize)a3C0()).EndInit();
		((ISupportInitialize)f3SD()).EndInit();
		((ISupportInitialize)g7AM()).EndInit();
		((ISupportInitialize)Js1f()).EndInit();
		((ISupportInitialize)p7D3()).EndInit();
		((ISupportInitialize)i7QH()).EndInit();
		((ISupportInitialize)n3BM()).EndInit();
		((ISupportInitialize)Fg0k()).EndInit();
		((ISupportInitialize)Ss1a()).EndInit();
		((ISupportInitialize)i2FT()).EndInit();
		((ISupportInitialize)f1F0()).EndInit();
		((ISupportInitialize)Ab13()).EndInit();
		((ISupportInitialize)Rn4s()).EndInit();
		((ISupportInitialize)s1Z6()).EndInit();
		((ISupportInitialize)e2MD()).EndInit();
		((ISupportInitialize)p5F1()).EndInit();
		((ISupportInitialize)y2NM()).EndInit();
		((ISupportInitialize)Ac58()).EndInit();
		((ISupportInitialize)p4RZ()).EndInit();
		((ISupportInitialize)g0HD()).EndInit();
		((ISupportInitialize)x4TK()).EndInit();
		((ISupportInitialize)i6BG()).EndInit();
		((ISupportInitialize)Fq80()).EndInit();
		((ISupportInitialize)m9L0()).EndInit();
		((ISupportInitialize)k1XN()).EndInit();
		((ISupportInitialize)Zp5z()).EndInit();
		((ISupportInitialize)Nb42()).EndInit();
		((ISupportInitialize)w7LK()).EndInit();
		((ISupportInitialize)t6TB()).EndInit();
		((ISupportInitialize)p2N5()).EndInit();
		((ISupportInitialize)Rd14()).EndInit();
		((ISupportInitialize)q0T1()).EndInit();
		((ISupportInitialize)Ni9n()).EndInit();
		((ISupportInitialize)Zp76()).EndInit();
		((ISupportInitialize)c6P2()).EndInit();
		((ISupportInitialize)s2MZ()).EndInit();
		((ISupportInitialize)Cp3s()).EndInit();
		((ISupportInitialize)Ym7o()).EndInit();
		((ISupportInitialize)r9XE()).EndInit();
		((ISupportInitialize)Pp62()).EndInit();
		((ISupportInitialize)Tb8k()).EndInit();
		((ISupportInitialize)o5J1()).EndInit();
		((ISupportInitialize)Yg8w()).EndInit();
		((ISupportInitialize)Sx87()).EndInit();
		((ISupportInitialize)Tg86()).EndInit();
		((ISupportInitialize)So92()).EndInit();
		((ISupportInitialize)Ji46()).EndInit();
		((ISupportInitialize)f1ZW()).EndInit();
		((ISupportInitialize)r8Q7()).EndInit();
		((ISupportInitialize)q7YT()).EndInit();
		((ISupportInitialize)p4WR()).EndInit();
		((ISupportInitialize)Bd86()).EndInit();
		((ISupportInitialize)q9JR()).EndInit();
		((ISupportInitialize)x1G0()).EndInit();
		((ISupportInitialize)Yy83()).EndInit();
		((ISupportInitialize)Xa0n()).EndInit();
		((ISupportInitialize)d1GJ()).EndInit();
		((ISupportInitialize)Hj2p()).EndInit();
		((ISupportInitialize)r3PB()).EndInit();
		((ISupportInitialize)Ea54()).EndInit();
		((ISupportInitialize)Sf2i()).EndInit();
		((ISupportInitialize)y0AN()).EndInit();
		((ISupportInitialize)Cr53()).EndInit();
		((ISupportInitialize)Wi9s()).EndInit();
		((ISupportInitialize)d3KB()).EndInit();
		((ISupportInitialize)Bm6o()).EndInit();
		((ISupportInitialize)Se02()).EndInit();
		((ISupportInitialize)r2E1()).EndInit();
		((ISupportInitialize)x3Y6()).EndInit();
		((ISupportInitialize)Fe1p()).EndInit();
		((ISupportInitialize)n6D9()).EndInit();
		((ISupportInitialize)d0L4()).EndInit();
		((ISupportInitialize)a2D8()).EndInit();
		((ISupportInitialize)i0F7()).EndInit();
		((ISupportInitialize)Lg7n()).EndInit();
		((ISupportInitialize)Zw16()).EndInit();
		((ISupportInitialize)g3CA()).EndInit();
		((ISupportInitialize)Wi6f()).EndInit();
		((ISupportInitialize)w2B4()).EndInit();
		((ISupportInitialize)g0Y6()).EndInit();
		((ISupportInitialize)Ga96()).EndInit();
		((ISupportInitialize)o6Q5()).EndInit();
		((ISupportInitialize)d9QL()).EndInit();
		((ISupportInitialize)r0J1()).EndInit();
		((ISupportInitialize)Ag82()).EndInit();
		((ISupportInitialize)Ro36()).EndInit();
		((ISupportInitialize)s6A9()).EndInit();
		((ISupportInitialize)Ss20()).EndInit();
		((ISupportInitialize)a2N0()).EndInit();
		((ISupportInitialize)s4W5()).EndInit();
		((ISupportInitialize)Qj5i()).EndInit();
		((ISupportInitialize)Eb6g()).EndInit();
		((ISupportInitialize)k9EQ()).EndInit();
		((ISupportInitialize)r2AW()).EndInit();
		((ISupportInitialize)k5H2()).EndInit();
		((ISupportInitialize)Nj0y()).EndInit();
		((ISupportInitialize)Ma60()).EndInit();
		((ISupportInitialize)Gx6s()).EndInit();
		((ISupportInitialize)g7C5()).EndInit();
		((ISupportInitialize)e9EH()).EndInit();
		((ISupportInitialize)s0L7()).EndInit();
		((ISupportInitialize)t3LT()).EndInit();
		((ISupportInitialize)j7F3()).EndInit();
		((ISupportInitialize)Hj6b()).EndInit();
		((ISupportInitialize)As2c()).EndInit();
		((ISupportInitialize)Yg79()).EndInit();
		((ISupportInitialize)q4RP()).EndInit();
		((ISupportInitialize)w0K8()).EndInit();
		((ISupportInitialize)r5YJ()).EndInit();
		((ISupportInitialize)t6G4()).EndInit();
		((ISupportInitialize)Ze0q()).EndInit();
		((ISupportInitialize)Dn2c()).EndInit();
		((ISupportInitialize)z2F1()).EndInit();
		((ISupportInitialize)y5E8()).EndInit();
		((ISupportInitialize)Rg38()).EndInit();
		((ISupportInitialize)y2D7()).EndInit();
		((ISupportInitialize)r5RZ()).EndInit();
		((ISupportInitialize)Zr8t()).EndInit();
		((ISupportInitialize)q8NZ()).EndInit();
		((ISupportInitialize)Jj6n()).EndInit();
		((ISupportInitialize)Xj97()).EndInit();
		((ISupportInitialize)s2CQ()).EndInit();
		((ISupportInitialize)Dt82()).EndInit();
		((ISupportInitialize)y8YQ()).EndInit();
		((ISupportInitialize)k9M8()).EndInit();
		((ISupportInitialize)Hi94()).EndInit();
		((Control)y8KZ()).ResumeLayout(false);
		((Control)y8KZ()).PerformLayout();
		((Control)Nd20()).ResumeLayout(false);
		((Control)Nd20()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Yn64()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qr4x(Label Fj29)
	{
		Label val = (d = Fj29);
	}

	[SpecialName]
	internal virtual Label q0E3()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bz95(Label k5XD)
	{
		Label val = (I = k5XD);
	}

	[SpecialName]
	internal virtual Label j8AM()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj21(Label Az1n)
	{
		Label val = (V = Az1n);
	}

	[SpecialName]
	internal virtual Label Cd76()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Se78(Label Dx5q)
	{
		Label val = (C = Dx5q);
	}

	[SpecialName]
	internal virtual Label f4DB()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fy40(Label Sd10)
	{
		Label val = (Y = Sd10);
	}

	[SpecialName]
	internal virtual Label c3GP()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd8s(Label Ti8r)
	{
		Label val = (e = Ti8r);
	}

	[SpecialName]
	internal virtual Label t8C5()
	{
		return _Label38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0X5(Label Pk5j)
	{
		_Label38 = Pk5j;
	}

	[SpecialName]
	internal virtual Label g3H6()
	{
		return _Label39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb6p(Label i2RT)
	{
		_Label39 = i2RT;
	}

	[SpecialName]
	internal virtual Label Si95()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5JZ(Label z0R5)
	{
		_Label40 = z0R5;
	}

	[SpecialName]
	internal virtual Label r6L0()
	{
		return _Label41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5HN(Label j8SX)
	{
		_Label41 = j8SX;
	}

	[SpecialName]
	internal virtual Label c9NT()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le5x(Label Zf0r)
	{
		Label val = (x = Zf0r);
	}

	[SpecialName]
	internal virtual Label Wm1f()
	{
		return _Label43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0TN(Label d4C2)
	{
		_Label43 = d4C2;
	}

	[SpecialName]
	internal virtual Label j1F2()
	{
		return _Label44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3MH(Label r2Q0)
	{
		_Label44 = r2Q0;
	}

	[SpecialName]
	internal virtual Label p5GY()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4PT(Label Pj60)
	{
		Label val = (M = Pj60);
	}

	[SpecialName]
	internal virtual Label g5K9()
	{
		return _Label46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ro7j(Label Xk5b)
	{
		_Label46 = Xk5b;
	}

	[SpecialName]
	internal virtual Label p0JX()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6CQ(Label Xt52)
	{
		Label val = (u = Xt52);
	}

	[SpecialName]
	internal virtual Label f2T8()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7T3(Label a6H8)
	{
		Label val = (n = a6H8);
	}

	[SpecialName]
	internal virtual TextBox Rg32()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4LZ(TextBox r9HG)
	{
		TextBox val = (B = r9HG);
	}

	[SpecialName]
	internal virtual TextBox d8HZ()
	{
		return _txtAvailable;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn95(TextBox Dj7y)
	{
		_txtAvailable = Dj7y;
	}

	[SpecialName]
	internal virtual PictureBox b9NA()
	{
		return _Booked;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7BA(PictureBox e6YD)
	{
		_Booked = e6YD;
	}

	[SpecialName]
	internal virtual PictureBox t8ZK()
	{
		return _Provisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lx5g(PictureBox y9EF)
	{
		_Provisional = y9EF;
	}

	[SpecialName]
	internal virtual PictureBox Et20()
	{
		return _Available;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am64(PictureBox Yi5s)
	{
		_Available = Yi5s;
	}

	[SpecialName]
	internal virtual Label y2H9()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fp24(Label a4P5)
	{
		_Label3 = a4P5;
	}

	[SpecialName]
	internal virtual Label w8Z6()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji1w(Label j1KZ)
	{
		_Label1 = j1KZ;
	}

	[SpecialName]
	internal virtual Label Lq62()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3Z4(Label f3HJ)
	{
		Label val = (S = f3HJ);
	}

	[SpecialName]
	internal virtual PictureBox i4P1()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj18(PictureBox p5CN)
	{
		PictureBox val = (r = p5CN);
	}

	[SpecialName]
	internal virtual Label s1L4()
	{
		return _Label49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2HT(Label Js1r)
	{
		_Label49 = Js1r;
	}

	[SpecialName]
	internal virtual TextBox Me34()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1QF(TextBox b8SN)
	{
		TextBox val = (H = b8SN);
	}

	[SpecialName]
	internal virtual Label Ao60()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tg72(Label Af1q)
	{
		Label val = (L = Af1q);
	}

	[SpecialName]
	internal virtual Label e3X8()
	{
		return _Label51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6K2(Label Jw9z)
	{
		_Label51 = Jw9z;
	}

	[SpecialName]
	internal virtual Label Ho49()
	{
		return _Label54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9D5(Label q0GD)
	{
		_Label54 = q0GD;
	}

	[SpecialName]
	internal virtual Label f4RP()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4R5(Label e7L5)
	{
		_Label55 = e7L5;
	}

	[SpecialName]
	internal virtual Label Xg2j()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8XC(Label Xq87)
	{
		Label val = (T = Xq87);
	}

	[SpecialName]
	internal virtual Label q1BK()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7CX(Label Ee36)
	{
		Label val = (q = Ee36);
	}

	[SpecialName]
	internal virtual Label Tc64()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9SM(Label Bo3k)
	{
		Label val = (o = Bo3k);
	}

	[SpecialName]
	internal virtual Label Kp05()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8JZ(Label Xf3c)
	{
		Label val = (P = Xf3c);
	}

	[SpecialName]
	internal virtual Label Nc12()
	{
		return _Label28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1J4(Label Mm8a)
	{
		_Label28 = Mm8a;
	}

	[SpecialName]
	internal virtual Label Fy53()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx7t(Label Xs4q)
	{
		Label val = (f = Xs4q);
	}

	[SpecialName]
	internal virtual Label So91()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec6g(Label w6CF)
	{
		Label val = (a = w6CF);
	}

	[SpecialName]
	internal virtual Label j1K7()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ay74(Label b0DX)
	{
		Label val = (W = b0DX);
	}

	[SpecialName]
	internal virtual Label Et4x()
	{
		return _Label24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gb7g(Label r4A3)
	{
		_Label24 = r4A3;
	}

	[SpecialName]
	internal virtual Label f9C7()
	{
		return _Label23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn2z(Label j3YS)
	{
		_Label23 = j3YS;
	}

	[SpecialName]
	internal virtual Label f9G5()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey21(Label a9NE)
	{
		Label val = (G = a9NE);
	}

	[SpecialName]
	internal virtual Label Hc81()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9B3(Label Wt74)
	{
		Label val = (k = Wt74);
	}

	[SpecialName]
	internal virtual Label Hq43()
	{
		return _Label20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yf32(Label Hn20)
	{
		_Label20 = Hn20;
	}

	[SpecialName]
	internal virtual Label Qp5o()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3JW(Label p8ML)
	{
		_Label19 = p8ML;
	}

	[SpecialName]
	internal virtual Label Dj1s()
	{
		return _Label18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kz05(Label Wo41)
	{
		_Label18 = Wo41;
	}

	[SpecialName]
	internal virtual Label Yt19()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk7n(Label o8N4)
	{
		Label val = (z = o8N4);
	}

	[SpecialName]
	internal virtual Label s2K5()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gg5c(Label Aq0a)
	{
		_Label16 = Aq0a;
	}

	[SpecialName]
	internal virtual Label Xi08()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7SN(Label Dg3i)
	{
		_Label15 = Dg3i;
	}

	[SpecialName]
	internal virtual Label r7J9()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6E8(Label Qf2x)
	{
		_Label14 = Qf2x;
	}

	[SpecialName]
	internal virtual Label p2B5()
	{
		return dJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7W4(Label Ss8x)
	{
		Label val = (dJ = Ss8x);
	}

	[SpecialName]
	internal virtual Label Yj3i()
	{
		return _Label12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj1a(Label Ct48)
	{
		_Label12 = Ct48;
	}

	[SpecialName]
	internal virtual Label Nr2m()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5FK(Label Sm81)
	{
		_Label11 = Sm81;
	}

	[SpecialName]
	internal virtual Label Hz16()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0S2(Label Rr68)
	{
		_Label10 = Rr68;
	}

	[SpecialName]
	internal virtual Label a1BZ()
	{
		return dd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2J3(Label d0JM)
	{
		Label val = (dd = d0JM);
	}

	[SpecialName]
	internal virtual Label k9H2()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj68(Label Ty46)
	{
		_Label8 = Ty46;
	}

	[SpecialName]
	internal virtual Label n2K8()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf08(Label s2G7)
	{
		_Label7 = s2G7;
	}

	[SpecialName]
	internal virtual Label Yo75()
	{
		return dI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9FZ(Label j4KG)
	{
		Label val = (dI = j4KG);
	}

	[SpecialName]
	internal virtual Label Aq93()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lq14(Label i3Z9)
	{
		_Label4 = i3Z9;
	}

	[SpecialName]
	internal virtual GroupBox j3GN()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cc1w(GroupBox Mf64)
	{
		_GroupBox3 = Mf64;
	}

	[SpecialName]
	internal virtual GroupBox f3P9()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4EL(GroupBox Xp32)
	{
		_GroupBox1 = Xp32;
	}

	[SpecialName]
	internal virtual Label Bn64()
	{
		return dV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7QX(Label b5D8)
	{
		Label val = (dV = b5D8);
	}

	[SpecialName]
	internal virtual PictureBox Xx69()
	{
		return dC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7NH(PictureBox d9JN)
	{
		PictureBox val = (dC = d9JN);
	}

	[SpecialName]
	internal virtual PictureBox q1LD()
	{
		return _NameBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xr29(PictureBox Qt2a)
	{
		_NameBox = Qt2a;
	}

	[SpecialName]
	internal virtual PictureBox j8QP()
	{
		return _PictureBox61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4F3(PictureBox Ky9c)
	{
		_PictureBox61 = Ky9c;
	}

	[SpecialName]
	internal virtual PictureBox Jy9i()
	{
		return _PictureBox62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9S7(PictureBox w9NP)
	{
		_PictureBox62 = w9NP;
	}

	[SpecialName]
	internal virtual PictureBox d8KN()
	{
		return dY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5CW(PictureBox Dn08)
	{
		PictureBox val = (dY = Dn08);
	}

	[SpecialName]
	internal virtual PictureBox Ey9d()
	{
		return _PictureBox64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pz3s(PictureBox x8S9)
	{
		_PictureBox64 = x8S9;
	}

	[SpecialName]
	internal virtual PictureBox Zk9t()
	{
		return de;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4XZ(PictureBox d3JF)
	{
		PictureBox val = (de = d3JF);
	}

	[SpecialName]
	internal virtual PictureBox Ai15()
	{
		return _PictureBox66;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk3j(PictureBox Px58)
	{
		_PictureBox66 = Px58;
	}

	[SpecialName]
	internal virtual PictureBox Zf24()
	{
		return dx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xg3a(PictureBox Fo8s)
	{
		PictureBox val = (dx = Fo8s);
	}

	[SpecialName]
	internal virtual PictureBox o7S9()
	{
		return dM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9NT(PictureBox z2N0)
	{
		PictureBox val = (dM = z2N0);
	}

	[SpecialName]
	internal virtual PictureBox r0KS()
	{
		return du;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1YH(PictureBox k8RW)
	{
		PictureBox val = (du = k8RW);
	}

	[SpecialName]
	internal virtual PictureBox j9DQ()
	{
		return _PictureBox70;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp48(PictureBox x6CK)
	{
		_PictureBox70 = x6CK;
	}

	[SpecialName]
	internal virtual PictureBox z2NB()
	{
		return _PictureBox71;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wt26(PictureBox Ne3d)
	{
		_PictureBox71 = Ne3d;
	}

	[SpecialName]
	internal virtual PictureBox My5t()
	{
		return _PictureBox72;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy57(PictureBox w3LB)
	{
		_PictureBox72 = w3LB;
	}

	[SpecialName]
	internal virtual PictureBox Rn82()
	{
		return dn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa53(PictureBox Eo4a)
	{
		PictureBox val = (dn = Eo4a);
	}

	[SpecialName]
	internal virtual PictureBox a7D5()
	{
		return _PictureBox74;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8T1(PictureBox m5R7)
	{
		_PictureBox74 = m5R7;
	}

	[SpecialName]
	internal virtual PictureBox Wz9d()
	{
		return dB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1JQ(PictureBox Ps2a)
	{
		PictureBox val = (dB = Ps2a);
	}

	[SpecialName]
	internal virtual PictureBox r2HZ()
	{
		return dS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8W6(PictureBox n4TK)
	{
		PictureBox val = (dS = n4TK);
	}

	[SpecialName]
	internal virtual PictureBox Qa0f()
	{
		return dr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2GJ(PictureBox k2S5)
	{
		PictureBox val = (dr = k2S5);
	}

	[SpecialName]
	internal virtual PictureBox Ym4q()
	{
		return _PictureBox78;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7TP(PictureBox Hq41)
	{
		_PictureBox78 = Hq41;
	}

	[SpecialName]
	internal virtual PictureBox z0X3()
	{
		return _PictureBox79;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6BW(PictureBox w2Z1)
	{
		_PictureBox79 = w2Z1;
	}

	[SpecialName]
	internal virtual PictureBox k0T5()
	{
		return _PictureBox80;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2J1(PictureBox Xw2p)
	{
		_PictureBox80 = Xw2p;
	}

	[SpecialName]
	internal virtual PictureBox Sf7s()
	{
		return dH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yd87(PictureBox Mj63)
	{
		PictureBox val = (dH = Mj63);
	}

	[SpecialName]
	internal virtual PictureBox a8QE()
	{
		return _PictureBox42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lg43(PictureBox Dr47)
	{
		_PictureBox42 = Dr47;
	}

	[SpecialName]
	internal virtual PictureBox Ks2x()
	{
		return dL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3M5(PictureBox w4T0)
	{
		PictureBox val = (dL = w4T0);
	}

	[SpecialName]
	internal virtual PictureBox Te8a()
	{
		return _PictureBox44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tg3t(PictureBox s7N0)
	{
		_PictureBox44 = s7N0;
	}

	[SpecialName]
	internal virtual PictureBox a1SC()
	{
		return _PictureBox45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zo6z(PictureBox Ha2f)
	{
		_PictureBox45 = Ha2f;
	}

	[SpecialName]
	internal virtual PictureBox Xf0g()
	{
		return _PictureBox46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5A2(PictureBox No2s)
	{
		_PictureBox46 = No2s;
	}

	[SpecialName]
	internal virtual PictureBox x3S4()
	{
		return dT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2N9(PictureBox g6Y1)
	{
		PictureBox val = (dT = g6Y1);
	}

	[SpecialName]
	internal virtual PictureBox Gi31()
	{
		return _PictureBox48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qb5e(PictureBox Tb9x)
	{
		_PictureBox48 = Tb9x;
	}

	[SpecialName]
	internal virtual PictureBox e6SY()
	{
		return dq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6W5(PictureBox n5K0)
	{
		PictureBox val = (dq = n5K0);
	}

	[SpecialName]
	internal virtual PictureBox i2Q1()
	{
		return _PictureBox50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ai01(PictureBox k1HL)
	{
		_PictureBox50 = k1HL;
	}

	[SpecialName]
	internal virtual PictureBox x2CF()
	{
		return @do;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sj50(PictureBox w8N6)
	{
		PictureBox val = (@do = w8N6);
	}

	[SpecialName]
	internal virtual PictureBox q2QG()
	{
		return dP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6PX(PictureBox Pk97)
	{
		PictureBox val = (dP = Pk97);
	}

	[SpecialName]
	internal virtual PictureBox Gr97()
	{
		return _PictureBox53;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6H3(PictureBox x1XT)
	{
		_PictureBox53 = x1XT;
	}

	[SpecialName]
	internal virtual PictureBox a3C0()
	{
		return df;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1L7(PictureBox t9WX)
	{
		PictureBox val = (df = t9WX);
	}

	[SpecialName]
	internal virtual PictureBox f3SD()
	{
		return da;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji8r(PictureBox q8T1)
	{
		PictureBox val = (da = q8T1);
	}

	[SpecialName]
	internal virtual PictureBox g7AM()
	{
		return dW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5RG(PictureBox i6K5)
	{
		PictureBox val = (dW = i6K5);
	}

	[SpecialName]
	internal virtual PictureBox Js1f()
	{
		return _PictureBox57;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6N1(PictureBox c7ZB)
	{
		_PictureBox57 = c7ZB;
	}

	[SpecialName]
	internal virtual PictureBox p7D3()
	{
		return dG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0WC(PictureBox Fx1c)
	{
		PictureBox val = (dG = Fx1c);
	}

	[SpecialName]
	internal virtual PictureBox i7QH()
	{
		return dk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dg75(PictureBox t3K1)
	{
		PictureBox val = (dk = t3K1);
	}

	[SpecialName]
	internal virtual PictureBox n3BM()
	{
		return dz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void An0k(PictureBox Xq71)
	{
		PictureBox val = (dz = Xq71);
	}

	[SpecialName]
	internal virtual PictureBox Fg0k()
	{
		return _PictureBox21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hg5j(PictureBox b2TK)
	{
		_PictureBox21 = b2TK;
	}

	[SpecialName]
	internal virtual PictureBox Ss1a()
	{
		return IJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7HT(PictureBox Le64)
	{
		PictureBox val = (IJ = Le64);
	}

	[SpecialName]
	internal virtual PictureBox i2FT()
	{
		return _PictureBox23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx02(PictureBox r1X8)
	{
		_PictureBox23 = r1X8;
	}

	[SpecialName]
	internal virtual PictureBox f1F0()
	{
		return Id;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5N4(PictureBox p7C9)
	{
		PictureBox val = (Id = p7C9);
	}

	[SpecialName]
	internal virtual PictureBox Ab13()
	{
		return _PictureBox25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2KF(PictureBox f8RF)
	{
		_PictureBox25 = f8RF;
	}

	[SpecialName]
	internal virtual PictureBox Rn4s()
	{
		return II;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gg90(PictureBox Bb09)
	{
		PictureBox val = (II = Bb09);
	}

	[SpecialName]
	internal virtual PictureBox s1Z6()
	{
		return IV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t4HE(PictureBox Jn7p)
	{
		PictureBox val = (IV = Jn7p);
	}

	[SpecialName]
	internal virtual PictureBox e2MD()
	{
		return _PictureBox28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9M6(PictureBox Ge45)
	{
		_PictureBox28 = Ge45;
	}

	[SpecialName]
	internal virtual PictureBox p5F1()
	{
		return IC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r7HS(PictureBox Jw10)
	{
		PictureBox val = (IC = Jw10);
	}

	[SpecialName]
	internal virtual PictureBox y2NM()
	{
		return _PictureBox30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3YE(PictureBox n4H1)
	{
		_PictureBox30 = n4H1;
	}

	[SpecialName]
	internal virtual PictureBox Ac58()
	{
		return IY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2CY(PictureBox q6K0)
	{
		PictureBox val = (IY = q6K0);
	}

	[SpecialName]
	internal virtual PictureBox p4RZ()
	{
		return _PictureBox32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci53(PictureBox t5E6)
	{
		_PictureBox32 = t5E6;
	}

	[SpecialName]
	internal virtual PictureBox g0HD()
	{
		return _PictureBox33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9C7(PictureBox q4S7)
	{
		_PictureBox33 = q4S7;
	}

	[SpecialName]
	internal virtual PictureBox x4TK()
	{
		return Ie;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt83(PictureBox a3GF)
	{
		PictureBox val = (Ie = a3GF);
	}

	[SpecialName]
	internal virtual PictureBox i6BG()
	{
		return _PictureBox35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr0y(PictureBox Ey7k)
	{
		_PictureBox35 = Ey7k;
	}

	[SpecialName]
	internal virtual PictureBox Fq80()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Go5a(PictureBox y0RE)
	{
		_PictureBox36 = y0RE;
	}

	[SpecialName]
	internal virtual PictureBox m9L0()
	{
		return _PictureBox37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3NC(PictureBox b0CJ)
	{
		_PictureBox37 = b0CJ;
	}

	[SpecialName]
	internal virtual PictureBox k1XN()
	{
		return _PictureBox38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6CQ(PictureBox z0QK)
	{
		_PictureBox38 = z0QK;
	}

	[SpecialName]
	internal virtual PictureBox Zp5z()
	{
		return _PictureBox39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy24(PictureBox Di1m)
	{
		_PictureBox39 = Di1m;
	}

	[SpecialName]
	internal virtual PictureBox Nb42()
	{
		return _PictureBox40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4FA(PictureBox Lt17)
	{
		_PictureBox40 = Lt17;
	}

	[SpecialName]
	internal virtual PictureBox w7LK()
	{
		return Ix;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft60(PictureBox Lm2g)
	{
		PictureBox val = (Ix = Lm2g);
	}

	[SpecialName]
	internal virtual PictureBox t6TB()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ff2p(PictureBox Cd34)
	{
		_PictureBox19 = Cd34;
	}

	[SpecialName]
	internal virtual PictureBox p2N5()
	{
		return IM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7LQ(PictureBox Dn7b)
	{
		PictureBox val = (IM = Dn7b);
	}

	[SpecialName]
	internal virtual PictureBox Rd14()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5SJ(PictureBox e6H5)
	{
		_PictureBox17 = e6H5;
	}

	[SpecialName]
	internal virtual PictureBox q0T1()
	{
		return Iu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5H2(PictureBox Wg0c)
	{
		PictureBox val = (Iu = Wg0c);
	}

	[SpecialName]
	internal virtual PictureBox Ni9n()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd5g(PictureBox Hq7e)
	{
		_PictureBox15 = Hq7e;
	}

	[SpecialName]
	internal virtual PictureBox Zp76()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3M4(PictureBox Ds18)
	{
		_PictureBox14 = Ds18;
	}

	[SpecialName]
	internal virtual PictureBox c6P2()
	{
		return In;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Br9c(PictureBox Px98)
	{
		PictureBox val = (In = Px98);
	}

	[SpecialName]
	internal virtual PictureBox s2MZ()
	{
		return IB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5G4(PictureBox Yf1w)
	{
		PictureBox val = (IB = Yf1w);
	}

	[SpecialName]
	internal virtual PictureBox Cp3s()
	{
		return IS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6M5(PictureBox Fi6k)
	{
		PictureBox val = (IS = Fi6k);
	}

	[SpecialName]
	internal virtual PictureBox Ym7o()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo7s(PictureBox Wy1e)
	{
		_PictureBox10 = Wy1e;
	}

	[SpecialName]
	internal virtual PictureBox r9XE()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz92(PictureBox Em8t)
	{
		_PictureBox9 = Em8t;
	}

	[SpecialName]
	internal virtual PictureBox Pp62()
	{
		return Ir;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp6a(PictureBox Mx0a)
	{
		PictureBox val = (Ir = Mx0a);
	}

	[SpecialName]
	internal virtual PictureBox Tb8k()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2SE(PictureBox Pc3g)
	{
		_PictureBox7 = Pc3g;
	}

	[SpecialName]
	internal virtual PictureBox o5J1()
	{
		return IH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fr70(PictureBox k7CQ)
	{
		PictureBox val = (IH = k7CQ);
	}

	[SpecialName]
	internal virtual PictureBox Yg8w()
	{
		return IL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0CR(PictureBox y6WA)
	{
		PictureBox val = (IL = y6WA);
	}

	[SpecialName]
	internal virtual PictureBox Sx87()
	{
		return IT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn5p(PictureBox m0JW)
	{
		PictureBox val = (IT = m0JW);
	}

	[SpecialName]
	internal virtual PictureBox Tg86()
	{
		return Iq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7GC(PictureBox Fz7i)
	{
		PictureBox val = (Iq = Fz7i);
	}

	[SpecialName]
	internal virtual PictureBox So92()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jq6c(PictureBox Do1x)
	{
		_PictureBox2 = Do1x;
	}

	[SpecialName]
	internal virtual PictureBox Ji46()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2F4(PictureBox Tp16)
	{
		_PictureBox1 = Tp16;
	}

	[SpecialName]
	internal virtual PictureBox f1ZW()
	{
		return _PictureBox142;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8RA(PictureBox r2H9)
	{
		_PictureBox142 = r2H9;
	}

	[SpecialName]
	internal virtual PictureBox r8Q7()
	{
		return _PictureBox143;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4SY(PictureBox Co61)
	{
		_PictureBox143 = Co61;
	}

	[SpecialName]
	internal virtual PictureBox q7YT()
	{
		return Io;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le59(PictureBox Hz16)
	{
		PictureBox val = (Io = Hz16);
	}

	[SpecialName]
	internal virtual PictureBox p4WR()
	{
		return _PictureBox145;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yf1m(PictureBox Lk5g)
	{
		_PictureBox145 = Lk5g;
	}

	[SpecialName]
	internal virtual PictureBox Bd86()
	{
		return IP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8X2(PictureBox Po34)
	{
		PictureBox val = (IP = Po34);
	}

	[SpecialName]
	internal virtual PictureBox q9JR()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez3r(PictureBox n4H7)
	{
		_PictureBox147 = n4H7;
	}

	[SpecialName]
	internal virtual PictureBox x1G0()
	{
		return _PictureBox148;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4Q7(PictureBox c5NJ)
	{
		_PictureBox148 = c5NJ;
	}

	[SpecialName]
	internal virtual PictureBox Yy83()
	{
		return _PictureBox149;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6J0(PictureBox i0P3)
	{
		_PictureBox149 = i0P3;
	}

	[SpecialName]
	internal virtual PictureBox Xa0n()
	{
		return _PictureBox150;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void La9o(PictureBox b1Q0)
	{
		_PictureBox150 = b1Q0;
	}

	[SpecialName]
	internal virtual PictureBox d1GJ()
	{
		return _PictureBox151;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w8YB(PictureBox Xk93)
	{
		_PictureBox151 = Xk93;
	}

	[SpecialName]
	internal virtual PictureBox Hj2p()
	{
		return _PictureBox152;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5P8(PictureBox Nc27)
	{
		_PictureBox152 = Nc27;
	}

	[SpecialName]
	internal virtual PictureBox r3PB()
	{
		return _PictureBox153;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar0x(PictureBox s0SZ)
	{
		_PictureBox153 = s0SZ;
	}

	[SpecialName]
	internal virtual PictureBox Ea54()
	{
		return If;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sn10(PictureBox o0FL)
	{
		PictureBox val = (If = o0FL);
	}

	[SpecialName]
	internal virtual PictureBox Sf2i()
	{
		return _PictureBox155;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ky2e(PictureBox e0E7)
	{
		_PictureBox155 = e0E7;
	}

	[SpecialName]
	internal virtual PictureBox y0AN()
	{
		return _PictureBox156;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1TG(PictureBox Fi6o)
	{
		_PictureBox156 = Fi6o;
	}

	[SpecialName]
	internal virtual PictureBox Cr53()
	{
		return Ia;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5ZB(PictureBox k3M8)
	{
		PictureBox val = (Ia = k3M8);
	}

	[SpecialName]
	internal virtual PictureBox Wi9s()
	{
		return IW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0QM(PictureBox Rf49)
	{
		PictureBox val = (IW = Rf49);
	}

	[SpecialName]
	internal virtual PictureBox d3KB()
	{
		return _PictureBox159;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3WR(PictureBox Ec8o)
	{
		_PictureBox159 = Ec8o;
	}

	[SpecialName]
	internal virtual PictureBox Bm6o()
	{
		return _PictureBox160;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tz79(PictureBox Tz9x)
	{
		_PictureBox160 = Tz9x;
	}

	[SpecialName]
	internal virtual PictureBox Se02()
	{
		return IG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3TD(PictureBox Qe1k)
	{
		PictureBox val = (IG = Qe1k);
	}

	[SpecialName]
	internal virtual PictureBox r2E1()
	{
		return Ik;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pt48(PictureBox j6F0)
	{
		PictureBox val = (Ik = j6F0);
	}

	[SpecialName]
	internal virtual PictureBox x3Y6()
	{
		return Iz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r0Z6(PictureBox s3TG)
	{
		PictureBox val = (Iz = s3TG);
	}

	[SpecialName]
	internal virtual PictureBox Fe1p()
	{
		return VJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9E6(PictureBox t1HM)
	{
		PictureBox val = (VJ = t1HM);
	}

	[SpecialName]
	internal virtual PictureBox n6D9()
	{
		return Vd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex4r(PictureBox n7MZ)
	{
		PictureBox val = (Vd = n7MZ);
	}

	[SpecialName]
	internal virtual PictureBox d0L4()
	{
		return VI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ha5j(PictureBox a0HX)
	{
		PictureBox val = (VI = a0HX);
	}

	[SpecialName]
	internal virtual PictureBox a2D8()
	{
		return _PictureBox127;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3FW(PictureBox z4Y0)
	{
		_PictureBox127 = z4Y0;
	}

	[SpecialName]
	internal virtual PictureBox i0F7()
	{
		return VV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mg38(PictureBox r5AF)
	{
		PictureBox val = (VV = r5AF);
	}

	[SpecialName]
	internal virtual PictureBox Lg7n()
	{
		return VC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4HT(PictureBox g3JM)
	{
		PictureBox val = (VC = g3JM);
	}

	[SpecialName]
	internal virtual PictureBox Zw16()
	{
		return VY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zi5g(PictureBox r7Z3)
	{
		PictureBox val = (VY = r7Z3);
	}

	[SpecialName]
	internal virtual PictureBox g3CA()
	{
		return _PictureBox131;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn2o(PictureBox k7L8)
	{
		_PictureBox131 = k7L8;
	}

	[SpecialName]
	internal virtual PictureBox Wi6f()
	{
		return Ve;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8P5(PictureBox Kg7p)
	{
		PictureBox val = (Ve = Kg7p);
	}

	[SpecialName]
	internal virtual PictureBox w2B4()
	{
		return _PictureBox133;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5ZT(PictureBox Xq0e)
	{
		_PictureBox133 = Xq0e;
	}

	[SpecialName]
	internal virtual PictureBox g0Y6()
	{
		return _PictureBox134;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5Q0(PictureBox Je4k)
	{
		_PictureBox134 = Je4k;
	}

	[SpecialName]
	internal virtual PictureBox Ga96()
	{
		return Vx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0CT(PictureBox i8Q2)
	{
		PictureBox val = (Vx = i8Q2);
	}

	[SpecialName]
	internal virtual PictureBox o6Q5()
	{
		return _PictureBox136;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk36(PictureBox Mf4q)
	{
		_PictureBox136 = Mf4q;
	}

	[SpecialName]
	internal virtual PictureBox d9QL()
	{
		return _PictureBox137;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0B3(PictureBox k1SF)
	{
		_PictureBox137 = k1SF;
	}

	[SpecialName]
	internal virtual PictureBox r0J1()
	{
		return VM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9N3(PictureBox b0Y5)
	{
		PictureBox val = (VM = b0Y5);
	}

	[SpecialName]
	internal virtual PictureBox Ag82()
	{
		return Vu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm7b(PictureBox t4LG)
	{
		PictureBox val = (Vu = t4LG);
	}

	[SpecialName]
	internal virtual PictureBox Ro36()
	{
		return _PictureBox140;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa8p(PictureBox Nb72)
	{
		_PictureBox140 = Nb72;
	}

	[SpecialName]
	internal virtual PictureBox s6A9()
	{
		return _PictureBox101;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ct6d(PictureBox i3K8)
	{
		_PictureBox101 = i3K8;
	}

	[SpecialName]
	internal virtual PictureBox Ss20()
	{
		return Vn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6QE(PictureBox g3FY)
	{
		PictureBox val = (Vn = g3FY);
	}

	[SpecialName]
	internal virtual PictureBox a2N0()
	{
		return VB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3Z2(PictureBox Gz03)
	{
		PictureBox val = (VB = Gz03);
	}

	[SpecialName]
	internal virtual PictureBox s4W5()
	{
		return VS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8T0(PictureBox Mx0b)
	{
		PictureBox val = (VS = Mx0b);
	}

	[SpecialName]
	internal virtual PictureBox Qj5i()
	{
		return _PictureBox105;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5RL(PictureBox b1YS)
	{
		_PictureBox105 = b1YS;
	}

	[SpecialName]
	internal virtual PictureBox Eb6g()
	{
		return Vr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2A7(PictureBox g8BN)
	{
		PictureBox val = (Vr = g8BN);
	}

	[SpecialName]
	internal virtual PictureBox k9EQ()
	{
		return _PictureBox107;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4AG(PictureBox k6WB)
	{
		_PictureBox107 = k6WB;
	}

	[SpecialName]
	internal virtual PictureBox r2AW()
	{
		return VH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1DB(PictureBox Pi3m)
	{
		PictureBox val = (VH = Pi3m);
	}

	[SpecialName]
	internal virtual PictureBox k5H2()
	{
		return _PictureBox109;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No92(PictureBox Jx8t)
	{
		_PictureBox109 = Jx8t;
	}

	[SpecialName]
	internal virtual PictureBox Nj0y()
	{
		return _PictureBox110;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ly28(PictureBox p4ZL)
	{
		_PictureBox110 = p4ZL;
	}

	[SpecialName]
	internal virtual PictureBox Ma60()
	{
		return VL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9Z1(PictureBox Fc12)
	{
		PictureBox val = (VL = Fc12);
	}

	[SpecialName]
	internal virtual PictureBox Gx6s()
	{
		return _PictureBox112;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ti74(PictureBox n8S3)
	{
		_PictureBox112 = n8S3;
	}

	[SpecialName]
	internal virtual PictureBox g7C5()
	{
		return _PictureBox113;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7KN(PictureBox Kd5c)
	{
		_PictureBox113 = Kd5c;
	}

	[SpecialName]
	internal virtual PictureBox e9EH()
	{
		return VT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je3q(PictureBox t0FL)
	{
		PictureBox val = (VT = t0FL);
	}

	[SpecialName]
	internal virtual PictureBox s0L7()
	{
		return _PictureBox115;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y2F1(PictureBox z3G1)
	{
		_PictureBox115 = z3G1;
	}

	[SpecialName]
	internal virtual PictureBox t3LT()
	{
		return Vq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps04(PictureBox e1KR)
	{
		PictureBox val = (Vq = e1KR);
	}

	[SpecialName]
	internal virtual PictureBox j7F3()
	{
		return _PictureBox117;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kx32(PictureBox f8DC)
	{
		_PictureBox117 = f8DC;
	}

	[SpecialName]
	internal virtual PictureBox Hj6b()
	{
		return Vo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lx74(PictureBox j6KZ)
	{
		PictureBox val = (Vo = j6KZ);
	}

	[SpecialName]
	internal virtual PictureBox As2c()
	{
		return VP;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8Q3(PictureBox Xb0i)
	{
		PictureBox val = (VP = Xb0i);
	}

	[SpecialName]
	internal virtual PictureBox Yg79()
	{
		return Vf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3AP(PictureBox c9Z1)
	{
		PictureBox val = (Vf = c9Z1);
	}

	[SpecialName]
	internal virtual PictureBox q4RP()
	{
		return Va;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4YA(PictureBox x5NM)
	{
		PictureBox val = (Va = x5NM);
	}

	[SpecialName]
	internal virtual PictureBox w0K8()
	{
		return VW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf42(PictureBox Wk6x)
	{
		PictureBox val = (VW = Wk6x);
	}

	[SpecialName]
	internal virtual PictureBox r5YJ()
	{
		return VG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tb14(PictureBox p8Q5)
	{
		PictureBox val = (VG = p8Q5);
	}

	[SpecialName]
	internal virtual PictureBox t6G4()
	{
		return _PictureBox84;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nz69(PictureBox c0X9)
	{
		_PictureBox84 = c0X9;
	}

	[SpecialName]
	internal virtual PictureBox Ze0q()
	{
		return _PictureBox85;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ne50(PictureBox n0GC)
	{
		_PictureBox85 = n0GC;
	}

	[SpecialName]
	internal virtual PictureBox Dn2c()
	{
		return Vk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cc40(PictureBox a2JR)
	{
		PictureBox val = (Vk = a2JR);
	}

	[SpecialName]
	internal virtual PictureBox z2F1()
	{
		return Vz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No3r(PictureBox e7SZ)
	{
		PictureBox val = (Vz = e7SZ);
	}

	[SpecialName]
	internal virtual PictureBox y5E8()
	{
		return CJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp83(PictureBox Co1b)
	{
		PictureBox val = (CJ = Co1b);
	}

	[SpecialName]
	internal virtual PictureBox Rg38()
	{
		return Cd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf9a(PictureBox Dt09)
	{
		PictureBox val = (Cd = Dt09);
	}

	[SpecialName]
	internal virtual PictureBox y2D7()
	{
		return CI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Df40(PictureBox Ji7b)
	{
		PictureBox val = (CI = Ji7b);
	}

	[SpecialName]
	internal virtual PictureBox r5RZ()
	{
		return CV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8W4(PictureBox Bd93)
	{
		PictureBox val = (CV = Bd93);
	}

	[SpecialName]
	internal virtual PictureBox Zr8t()
	{
		return CC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0S1(PictureBox j5FG)
	{
		PictureBox val = (CC = j5FG);
	}

	[SpecialName]
	internal virtual PictureBox q8NZ()
	{
		return _PictureBox93;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn31(PictureBox b7J2)
	{
		_PictureBox93 = b7J2;
	}

	[SpecialName]
	internal virtual PictureBox Jj6n()
	{
		return _PictureBox94;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns49(PictureBox Rj4x)
	{
		_PictureBox94 = Rj4x;
	}

	[SpecialName]
	internal virtual PictureBox Xj97()
	{
		return _PictureBox95;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6W8(PictureBox e6LZ)
	{
		_PictureBox95 = e6LZ;
	}

	[SpecialName]
	internal virtual PictureBox s2CQ()
	{
		return _PictureBox96;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0FE(PictureBox m4JN)
	{
		_PictureBox96 = m4JN;
	}

	[SpecialName]
	internal virtual PictureBox Dt82()
	{
		return CY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tx0j(PictureBox Rd45)
	{
		PictureBox val = (CY = Rd45);
	}

	[SpecialName]
	internal virtual PictureBox y8YQ()
	{
		return _PictureBox98;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ej5f(PictureBox Tq67)
	{
		_PictureBox98 = Tq67;
	}

	[SpecialName]
	internal virtual PictureBox k9M8()
	{
		return Ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5L3(PictureBox t4E2)
	{
		PictureBox val = (Ce = t4E2);
	}

	[SpecialName]
	internal virtual PictureBox Hi94()
	{
		return _PictureBox100;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gn9r(PictureBox Fs4e)
	{
		_PictureBox100 = Fs4e;
	}

	[SpecialName]
	internal virtual Button m7B9()
	{
		return Cx;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2QJ(Button Xx1a)
	{
		EventHandler eventHandler = Zq8n;
		Button cx = Cx;
		if (cx != null)
		{
			((Control)cx).remove_Click(eventHandler);
		}
		Button val = (Cx = Xx1a);
		cx = Cx;
		if (cx != null)
		{
			((Control)cx).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox y8KZ()
	{
		return CM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1C9(GroupBox e7A0)
	{
		GroupBox val = (CM = e7A0);
	}

	[SpecialName]
	internal virtual Button Lo7g()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je0p(Button b3Y0)
	{
		EventHandler eventHandler = Ff59;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = b3Y0;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button a5Y8()
	{
		return Cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aj62(Button Xg28)
	{
		EventHandler eventHandler = By63;
		Button cu = Cu;
		if (cu != null)
		{
			((Control)cu).remove_Click(eventHandler);
		}
		Button val = (Cu = Xg28);
		cu = Cu;
		if (cu != null)
		{
			((Control)cu).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox k2GR()
	{
		return _txtChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5L1(TextBox Tg26)
	{
		_txtChange = Tg26;
	}

	[SpecialName]
	internal virtual TextBox Nx8w()
	{
		return _txtTotalPayment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He9t(TextBox Gr83)
	{
		_txtTotalPayment = Gr83;
	}

	[SpecialName]
	internal virtual TextBox q0H1()
	{
		return _txtTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb09(TextBox g7MS)
	{
		_txtTotalCost = g7MS;
	}

	[SpecialName]
	internal virtual TextBox Pk6s()
	{
		return Cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ka21(TextBox Jj1w)
	{
		TextBox val = (Cn = Jj1w);
	}

	[SpecialName]
	internal virtual Label Gs39()
	{
		return _Label63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kd42(Label f4WX)
	{
		_Label63 = f4WX;
	}

	[SpecialName]
	internal virtual Label m2QP()
	{
		return _Label64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp6e(Label Ei9k)
	{
		_Label64 = Ei9k;
	}

	[SpecialName]
	internal virtual Label j6Y1()
	{
		return _Label61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4BK(Label a3C7)
	{
		_Label61 = a3C7;
	}

	[SpecialName]
	internal virtual Label Bj75()
	{
		return CB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4W6(Label Ya63)
	{
		Label val = (CB = Ya63);
	}

	[SpecialName]
	internal virtual GroupBox Nd20()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7L5(GroupBox Jc06)
	{
		_GroupBox2 = Jc06;
	}

	[SpecialName]
	internal virtual Button Ez65()
	{
		return CS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2WR(Button Lg9z)
	{
		EventHandler eventHandler = y4M1;
		Button cS = CS;
		if (cS != null)
		{
			((Control)cS).remove_Click(eventHandler);
		}
		Button val = (CS = Lg9z);
		cS = CS;
		if (cS != null)
		{
			((Control)cS).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Li31()
	{
		return Cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md9k(Button Ay9f)
	{
		Button val = (Cr = Ay9f);
	}

	[SpecialName]
	internal virtual Button i2KA()
	{
		return _btnExisting;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec6x(Button Fz47)
	{
		EventHandler eventHandler = Wo34;
		Button btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).remove_Click(eventHandler);
		}
		_btnExisting = Fz47;
		btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Qf6r()
	{
		return _txtFirstName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mq93(TextBox z0W4)
	{
		_txtFirstName = z0W4;
	}

	[SpecialName]
	internal virtual TextBox j4E1()
	{
		return _txtID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8F9(TextBox o4R7)
	{
		_txtID = o4R7;
	}

	[SpecialName]
	internal virtual Label r5KR()
	{
		return _Label60;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yt69(Label e7Y5)
	{
		_Label60 = e7Y5;
	}

	[SpecialName]
	internal virtual Label Cg4i()
	{
		return _Label59;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk68(Label n1D3)
	{
		_Label59 = n1D3;
	}

	private void Ff59(object sender, EventArgs e)
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
				if (val != null && val.get_Image() == CL)
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
		string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 2.accdb";
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
				if (val != null && val.get_Image() == CL)
				{
					int num = Conversions.ToInteger(Strings.Mid(((Control)val).get_Name(), 11));
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + j4E1().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = j4E1().get_Text();
		firstName = Qf6r().get_Text();
		val2.Close();
		j7H6();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void By63(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(Nx8w().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			k2GR().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)Nx8w()).Clear();
		}
	}

	private void c1D7(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((Control)this).get_Controls().GetEnumerator();
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				if (val is PictureBox && !((Operators.CompareString(val.get_Name(), "NameBox", false) == 0) | (Operators.CompareString(val.get_Name(), "Background", false) == 0)))
				{
					((PictureBox)val).set_Image((Image)CH);
					val.add_Click((EventHandler)Eq4s);
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
		Cq = 0;
		Co = 0;
		j7H6();
	}

	private void Zq8n(object sender, EventArgs e)
	{
	}

	private void Wo34(object sender, EventArgs e)
	{
	}

	private void y4M1(object sender, EventArgs e)
	{
	}

	internal static byte[] a7H0(int[] i9AS, int Ts1e)
	{
		checked
		{
			byte[] array = new byte[Ts1e + 1];
			int num = i9AS.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)i9AS[i];
			}
			return array;
		}
	}

	public void j7H6()
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
			availableSeats = 160 - Cq;
			Co = 0;
			string commandText = "SELECT * FROM tblBookings";
			string connectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.get_StartupPath() + "\\Cinema 2.accdb";
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
					((PictureBox)NewLateBinding.LateGet((object)((Control)this).get_Controls(), (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"PictureBox", dataRow[2]) }, (string[])null, (Type[])null, (bool[])null)).set_Image((Image)CT);
					Cq++;
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
			Rg32().set_Text(Conversions.ToString(Cq));
			d8HZ().set_Text(Conversions.ToString(availableSeats));
			Me34().set_Text(Conversions.ToString(Co));
			Ln84();
		}
	}

	private void Eq4s(object sender, EventArgs e)
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
			if (((PictureBox)sender).get_Image() == CH)
			{
				((PictureBox)sender).set_Image((Image)CL);
				Co++;
				availableSeats--;
			}
			else if (((PictureBox)sender).get_Image() == CL)
			{
				((PictureBox)sender).set_Image((Image)CH);
				Co--;
				availableSeats++;
			}
			d8HZ().set_Text(Conversions.ToString(availableSeats));
			Me34().set_Text(Conversions.ToString(Co));
			seats = Co;
			Pk6s().set_Text(Conversions.ToString(seats));
			totalCost = Co * 5;
			q0H1().set_Text("$" + totalCost);
		}
	}

	public void Ln84()
	{
		((TextBoxBase)Nx8w()).Clear();
		((TextBoxBase)Qf6r()).Clear();
		((TextBoxBase)q0H1()).Clear();
		((TextBoxBase)k2GR()).Clear();
		((TextBoxBase)Pk6s()).Clear();
		((TextBoxBase)j4E1()).Clear();
	}
}
