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

namespace c5R;

[DesignerGenerated]
public class n7F : Form
{
	private Label _Label32;

	private Label _Label33;

	private Label _Label37;

	private Label _Label39;

	private Label _Label40;

	private Label _Label42;

	private Label _Label45;

	private Label _Label46;

	private PictureBox _Booked;

	private PictureBox _Available;

	private Label _Label1;

	private Label _Label2;

	private PictureBox _Cover;

	private Label _Label49;

	private TextBox _txtProvisional;

	private Label _Label50;

	private Label _Label55;

	private Label _Label27;

	private Label _Label28;

	private Label _Label25;

	private Label _Label21;

	private Label _Label19;

	private Label _Label18;

	private Label _Label17;

	private Label _Label16;

	private Label _Label15;

	private Label _Label12;

	private Label _Label11;

	private Label _Label10;

	private Label _Label8;

	private Label _Label7;

	private Label _Label5;

	private Label _Label4;

	private GroupBox _GroupBox3;

	private Label _Label6;

	private PictureBox _NameBox;

	private PictureBox _PictureBox62;

	private PictureBox _PictureBox63;

	private PictureBox _PictureBox65;

	private PictureBox _PictureBox67;

	private PictureBox _PictureBox69;

	private PictureBox _PictureBox70;

	private PictureBox _PictureBox72;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox75;

	private PictureBox _PictureBox76;

	private PictureBox _PictureBox79;

	private PictureBox _PictureBox80;

	private PictureBox _PictureBox41;

	private PictureBox _PictureBox43;

	private PictureBox _PictureBox44;

	private PictureBox _PictureBox48;

	private PictureBox _PictureBox50;

	private PictureBox _PictureBox51;

	private PictureBox _PictureBox53;

	private PictureBox _PictureBox54;

	private PictureBox _PictureBox56;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox24;

	private PictureBox _PictureBox26;

	private PictureBox _PictureBox27;

	private PictureBox _PictureBox29;

	private PictureBox _PictureBox30;

	private PictureBox _PictureBox34;

	private PictureBox _PictureBox35;

	private PictureBox _PictureBox36;

	private PictureBox _PictureBox38;

	private PictureBox _PictureBox39;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox16;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox10;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox144;

	private PictureBox _PictureBox145;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox148;

	private PictureBox _PictureBox149;

	private PictureBox _PictureBox150;

	private PictureBox _PictureBox152;

	private PictureBox _PictureBox154;

	private PictureBox _PictureBox155;

	private PictureBox _PictureBox158;

	private PictureBox _PictureBox160;

	private PictureBox _PictureBox122;

	private PictureBox _PictureBox124;

	private PictureBox _PictureBox125;

	private PictureBox _PictureBox129;

	private PictureBox _PictureBox132;

	private PictureBox _PictureBox134;

	private PictureBox _PictureBox135;

	private PictureBox _PictureBox136;

	private PictureBox _PictureBox138;

	private PictureBox _PictureBox104;

	private PictureBox _PictureBox106;

	private PictureBox _PictureBox112;

	private PictureBox _PictureBox113;

	private PictureBox _PictureBox116;

	private PictureBox _PictureBox119;

	private PictureBox _PictureBox84;

	private PictureBox _PictureBox85;

	private PictureBox _PictureBox88;

	private PictureBox _PictureBox90;

	private PictureBox _PictureBox92;

	private PictureBox _PictureBox93;

	private PictureBox _PictureBox94;

	private PictureBox _PictureBox96;

	private PictureBox _PictureBox97;

	private PictureBox _PictureBox98;

	private Button _btnViewReservations;

	private Button _btnSave;

	private Button _btnCalculateChange;

	private TextBox _txtTotalPayment;

	private Label _Label64;

	private Label _Label61;

	private Label _Label62;

	private GroupBox _GroupBox2;

	private Button _btnNew;

	private Button _btnExisting;

	private object provisionalIcon;

	private int bookedSeats;

	private int availableSeats;

	private int provisionalSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal IContainer D;

	internal Label v;

	internal Label k;

	internal Label c;

	internal Label r;

	internal Label a;

	internal Label f;

	internal Label L;

	internal Label q;

	internal Label w;

	internal TextBox b;

	internal TextBox u;

	internal PictureBox i;

	internal Label n;

	internal Label e;

	internal Label h;

	internal Label o;

	internal Label y;

	internal Label p;

	internal Label X;

	internal Label S;

	internal Label T;

	internal Label j;

	internal Label g;

	internal Label M;

	internal Label z;

	internal Label vD;

	internal Label vv;

	internal GroupBox vk;

	internal PictureBox vc;

	internal PictureBox vr;

	internal PictureBox va;

	internal PictureBox vf;

	internal PictureBox vL;

	internal PictureBox vq;

	internal PictureBox vw;

	internal PictureBox vb;

	internal PictureBox vu;

	internal PictureBox vi;

	internal PictureBox vn;

	internal PictureBox ve;

	internal PictureBox vh;

	internal PictureBox vo;

	internal PictureBox vy;

	internal PictureBox vp;

	internal PictureBox vX;

	internal PictureBox vS;

	internal PictureBox vT;

	internal PictureBox vj;

	internal PictureBox vg;

	internal PictureBox vM;

	internal PictureBox vz;

	internal PictureBox kD;

	internal PictureBox kv;

	internal PictureBox kk;

	internal PictureBox kc;

	internal PictureBox kr;

	internal PictureBox ka;

	internal PictureBox kf;

	internal PictureBox kL;

	internal PictureBox kq;

	internal PictureBox kw;

	internal PictureBox kb;

	internal PictureBox ku;

	internal PictureBox ki;

	internal PictureBox kn;

	internal PictureBox ke;

	internal PictureBox kh;

	internal PictureBox ko;

	internal PictureBox ky;

	internal PictureBox kp;

	internal PictureBox kX;

	internal PictureBox kS;

	internal PictureBox kT;

	internal PictureBox kj;

	internal PictureBox kg;

	internal PictureBox kM;

	internal PictureBox kz;

	internal PictureBox cD;

	internal PictureBox cv;

	internal PictureBox ck;

	internal PictureBox cc;

	internal PictureBox cr;

	internal PictureBox ca;

	internal PictureBox cf;

	internal PictureBox cL;

	internal PictureBox cq;

	internal PictureBox cw;

	internal PictureBox cb;

	internal PictureBox cu;

	internal PictureBox ci;

	internal PictureBox cn;

	internal PictureBox ce;

	internal PictureBox ch;

	internal PictureBox co;

	internal PictureBox cy;

	internal PictureBox cp;

	internal PictureBox cX;

	internal PictureBox cS;

	internal PictureBox cT;

	internal PictureBox cj;

	internal PictureBox cg;

	internal PictureBox cM;

	internal PictureBox cz;

	internal PictureBox rD;

	internal PictureBox rv;

	internal PictureBox rk;

	internal PictureBox rc;

	internal PictureBox rr;

	internal PictureBox ra;

	internal PictureBox rf;

	internal PictureBox rL;

	internal GroupBox rq;

	internal TextBox rw;

	internal TextBox rb;

	internal TextBox ru;

	internal Label ri;

	internal Button rn;

	internal TextBox re;

	internal TextBox rh;

	internal Label ro;

	internal Label ry;

	internal object rp;

	internal object rX;

	public n7F()
	{
		((Form)this).add_Load((EventHandler)Py3);
		object obj = (rp = RuntimeHelpers.GetObjectValue(new object()));
		provisionalIcon = RuntimeHelpers.GetObjectValue(new object());
		object obj2 = (rX = RuntimeHelpers.GetObjectValue(new object()));
		z5B();
	}

	protected override void Ps1(bool m8L)
	{
		try
		{
			if (m8L && D != null)
			{
				D.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(m8L);
		}
	}

	private void z5B()
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
		s1J(new Label());
		n0D(new Label());
		this.s6P(new Label());
		j9G(new Label());
		r4C(new Label());
		Tt0(new Label());
		Dn9(new Label());
		n7Z(new Label());
		i5L(new Label());
		Hg0(new Label());
		q3D(new Label());
		Hi3(new Label());
		e2K(new Label());
		a0A(new Label());
		t6L(new Label());
		Fm7(new Label());
		Ew9(new Label());
		k1Q(new TextBox());
		n6M(new TextBox());
		this.Ds8(new PictureBox());
		Fp9(new PictureBox());
		s8S(new PictureBox());
		Sg8(new Label());
		Zc1(new Label());
		Qy3(new Label());
		Pi5(new PictureBox());
		r2D(new Label());
		Yk7(new TextBox());
		y4H(new Label());
		Bn8(new Label());
		n9N(new Label());
		g1A(new Label());
		y3G(new Label());
		f3B(new Label());
		b5E(new Label());
		q5Q(new Label());
		Rg3(new Label());
		Ny6(new Label());
		b0R(new Label());
		y1T(new Label());
		f2B(new Label());
		Dk6(new Label());
		Cx2(new Label());
		Ea4(new Label());
		Wb1(new Label());
		m9H(new Label());
		Lo9(new Label());
		Jd2(new Label());
		Gg6(new Label());
		j3G(new Label());
		Nc5(new Label());
		g8G(new Label());
		i9Z(new Label());
		e8Y(new Label());
		Bo2(new Label());
		Do9(new Label());
		Zj7(new Label());
		Lt9(new Label());
		p4S(new Label());
		Qs2(new Label());
		b1A(new GroupBox());
		Bs4(new Button());
		Wo8(new GroupBox());
		y8S(new Label());
		Py8(new PictureBox());
		Do0(new PictureBox());
		Et7(new PictureBox());
		Xy0(new PictureBox());
		f9G(new PictureBox());
		Mn5(new PictureBox());
		Kp7(new PictureBox());
		s1S(new PictureBox());
		Jn3(new PictureBox());
		p7Q(new PictureBox());
		Ed3(new PictureBox());
		Dz9(new PictureBox());
		Sm6(new PictureBox());
		t7S(new PictureBox());
		Co6(new PictureBox());
		z2L(new PictureBox());
		Tw9(new PictureBox());
		Hg1(new PictureBox());
		Fo0(new PictureBox());
		p9F(new PictureBox());
		Fz0(new PictureBox());
		j5C(new PictureBox());
		s8K(new PictureBox());
		Wj9(new PictureBox());
		Xn1(new PictureBox());
		n7F(new PictureBox());
		n2X(new PictureBox());
		b5T(new PictureBox());
		Pa8(new PictureBox());
		Ea6(new PictureBox());
		t1Y(new PictureBox());
		Nw0(new PictureBox());
		c3A(new PictureBox());
		o5E(new PictureBox());
		n8L(new PictureBox());
		s0H(new PictureBox());
		At1(new PictureBox());
		z2K(new PictureBox());
		d5Y(new PictureBox());
		m5R(new PictureBox());
		Zz8(new PictureBox());
		this.s6P(new PictureBox());
		Hm5(new PictureBox());
		o4S(new PictureBox());
		e1F(new PictureBox());
		n8J(new PictureBox());
		Dr7(new PictureBox());
		Tp4(new PictureBox());
		Mp3(new PictureBox());
		g7B(new PictureBox());
		Ag0(new PictureBox());
		Qj6(new PictureBox());
		Rw1(new PictureBox());
		p5S(new PictureBox());
		z9S(new PictureBox());
		t9A(new PictureBox());
		Ts5(new PictureBox());
		Mw4(new PictureBox());
		Ed6(new PictureBox());
		s4B(new PictureBox());
		f0W(new PictureBox());
		n5L(new PictureBox());
		this.Fs7(new PictureBox());
		Tt7(new PictureBox());
		Rb6(new PictureBox());
		Lm6(new PictureBox());
		f0B(new PictureBox());
		q2H(new PictureBox());
		j7J(new PictureBox());
		Hq0(new PictureBox());
		Js8(new PictureBox());
		s2C(new PictureBox());
		Gd5(new PictureBox());
		this.Kp4(new PictureBox());
		j8Y(new PictureBox());
		t5X(new PictureBox());
		this.Fs7(new PictureBox());
		m1P(new PictureBox());
		Fs1(new PictureBox());
		Hf3(new PictureBox());
		x7T(new PictureBox());
		Xg7(new PictureBox());
		o0S(new PictureBox());
		c2L(new PictureBox());
		Lf3(new PictureBox());
		d1H(new PictureBox());
		x5B(new PictureBox());
		o8Z(new PictureBox());
		Ln8(new PictureBox());
		f6P(new PictureBox());
		x6H(new PictureBox());
		Tx8(new PictureBox());
		Kn9(new PictureBox());
		g7G(new PictureBox());
		Jr6(new PictureBox());
		t0P(new PictureBox());
		d3K(new PictureBox());
		So3(new PictureBox());
		r6B(new PictureBox());
		Qi4(new PictureBox());
		c2Z(new PictureBox());
		b3H(new PictureBox());
		Ln5(new PictureBox());
		Zk3(new PictureBox());
		t8H(new PictureBox());
		Bo5(new PictureBox());
		z6E(new PictureBox());
		n7M(new PictureBox());
		n9Y(new PictureBox());
		s4S(new PictureBox());
		t9T(new PictureBox());
		Lk1(new PictureBox());
		f5M(new PictureBox());
		Hs5(new PictureBox());
		Mw6(new PictureBox());
		As2(new PictureBox());
		g1Z(new PictureBox());
		k0L(new PictureBox());
		Xg6(new PictureBox());
		n1P(new PictureBox());
		Lg2(new PictureBox());
		p7W(new PictureBox());
		m2Q(new PictureBox());
		Ln6(new PictureBox());
		y9Z(new PictureBox());
		Hp6(new PictureBox());
		b5G(new PictureBox());
		this.Ds8(new PictureBox());
		r6L(new PictureBox());
		i7E(new PictureBox());
		Ad4(new PictureBox());
		Xb8(new PictureBox());
		Ps5(new PictureBox());
		a0R(new PictureBox());
		By4(new PictureBox());
		y6X(new PictureBox());
		d5S(new PictureBox());
		Zf7(new PictureBox());
		Lp0(new PictureBox());
		p2M(new PictureBox());
		y8N(new PictureBox());
		x7B(new PictureBox());
		q8Z(new PictureBox());
		o4Z(new PictureBox());
		p7Y(new PictureBox());
		e3R(new PictureBox());
		k2M(new PictureBox());
		this.Kp4(new PictureBox());
		j3Z(new PictureBox());
		Xi2(new PictureBox());
		Wk5(new PictureBox());
		Na1(new PictureBox());
		Mq4(new PictureBox());
		z1R(new PictureBox());
		p7C(new PictureBox());
		i5N(new PictureBox());
		Gs6(new PictureBox());
		j9E(new PictureBox());
		Xb0(new PictureBox());
		a3G(new PictureBox());
		d7T(new PictureBox());
		Ck8(new GroupBox());
		g0M(new Button());
		Wq9(new Button());
		c2Y(new TextBox());
		Sy5(new TextBox());
		Dd1(new TextBox());
		q5K(new TextBox());
		Ya2(new Label());
		Hz0(new Label());
		Ns5(new Label());
		e4Q(new Label());
		e8M(new GroupBox());
		q1B(new Button());
		Sw6(new Button());
		He1(new Button());
		Yi5(new TextBox());
		Bx7(new TextBox());
		s1C(new Label());
		s4A(new Label());
		((ISupportInitialize)Wa1()).BeginInit();
		((ISupportInitialize)a0F()).BeginInit();
		((ISupportInitialize)Gb5()).BeginInit();
		((ISupportInitialize)Nr0()).BeginInit();
		((Control)this.Ey7()).SuspendLayout();
		((Control)q3J()).SuspendLayout();
		((ISupportInitialize)e6A()).BeginInit();
		((ISupportInitialize)d8G()).BeginInit();
		((ISupportInitialize)Ri6()).BeginInit();
		((ISupportInitialize)r3W()).BeginInit();
		((ISupportInitialize)Rq5()).BeginInit();
		((ISupportInitialize)z2P()).BeginInit();
		((ISupportInitialize)Tg1()).BeginInit();
		((ISupportInitialize)Gs2()).BeginInit();
		((ISupportInitialize)Xx0()).BeginInit();
		((ISupportInitialize)Wt5()).BeginInit();
		((ISupportInitialize)b9J()).BeginInit();
		((ISupportInitialize)c6T()).BeginInit();
		((ISupportInitialize)Qj6()).BeginInit();
		((ISupportInitialize)k6C()).BeginInit();
		((ISupportInitialize)Ba0()).BeginInit();
		((ISupportInitialize)Fp6()).BeginInit();
		((ISupportInitialize)b4B()).BeginInit();
		((ISupportInitialize)r4X()).BeginInit();
		((ISupportInitialize)Ba1()).BeginInit();
		((ISupportInitialize)w1M()).BeginInit();
		((ISupportInitialize)k1X()).BeginInit();
		((ISupportInitialize)q2Y()).BeginInit();
		((ISupportInitialize)Tc9()).BeginInit();
		((ISupportInitialize)Wz2()).BeginInit();
		((ISupportInitialize)Qd2()).BeginInit();
		((ISupportInitialize)Ac4()).BeginInit();
		((ISupportInitialize)s0T()).BeginInit();
		((ISupportInitialize)f6M()).BeginInit();
		((ISupportInitialize)f2L()).BeginInit();
		((ISupportInitialize)Bf9()).BeginInit();
		((ISupportInitialize)i1G()).BeginInit();
		((ISupportInitialize)f9R()).BeginInit();
		((ISupportInitialize)Pq4()).BeginInit();
		((ISupportInitialize)d4H()).BeginInit();
		((ISupportInitialize)Rj7()).BeginInit();
		((ISupportInitialize)Nr6()).BeginInit();
		((ISupportInitialize)k7H()).BeginInit();
		((ISupportInitialize)r5Z()).BeginInit();
		((ISupportInitialize)Nd5()).BeginInit();
		((ISupportInitialize)s5F()).BeginInit();
		((ISupportInitialize)Qn8()).BeginInit();
		((ISupportInitialize)Qd7()).BeginInit();
		((ISupportInitialize)At6()).BeginInit();
		((ISupportInitialize)Gw9()).BeginInit();
		((ISupportInitialize)Qc8()).BeginInit();
		((ISupportInitialize)Mw1()).BeginInit();
		((ISupportInitialize)Yp2()).BeginInit();
		((ISupportInitialize)Mb7()).BeginInit();
		((ISupportInitialize)c6L()).BeginInit();
		((ISupportInitialize)Nc1()).BeginInit();
		((ISupportInitialize)Gd9()).BeginInit();
		((ISupportInitialize)Ja2()).BeginInit();
		((ISupportInitialize)Bs0()).BeginInit();
		((ISupportInitialize)w1Y()).BeginInit();
		((ISupportInitialize)this.Me0()).BeginInit();
		((ISupportInitialize)g1X()).BeginInit();
		((ISupportInitialize)a6J()).BeginInit();
		((ISupportInitialize)e0Q()).BeginInit();
		((ISupportInitialize)this.t7A()).BeginInit();
		((ISupportInitialize)Zr9()).BeginInit();
		((ISupportInitialize)Ra2()).BeginInit();
		((ISupportInitialize)Qk4()).BeginInit();
		((ISupportInitialize)d3A()).BeginInit();
		((ISupportInitialize)e3C()).BeginInit();
		((ISupportInitialize)Sw8()).BeginInit();
		((ISupportInitialize)q0Y()).BeginInit();
		((ISupportInitialize)Qi1()).BeginInit();
		((ISupportInitialize)s0S()).BeginInit();
		((ISupportInitialize)Ne6()).BeginInit();
		((ISupportInitialize)b5Z()).BeginInit();
		((ISupportInitialize)j5T()).BeginInit();
		((ISupportInitialize)Si2()).BeginInit();
		((ISupportInitialize)Ng5()).BeginInit();
		((ISupportInitialize)this.a8R()).BeginInit();
		((ISupportInitialize)Di9()).BeginInit();
		((ISupportInitialize)Wz4()).BeginInit();
		((ISupportInitialize)Go2()).BeginInit();
		((ISupportInitialize)Md7()).BeginInit();
		((ISupportInitialize)f4S()).BeginInit();
		((ISupportInitialize)k0Y()).BeginInit();
		((ISupportInitialize)Jr7()).BeginInit();
		((ISupportInitialize)k0T()).BeginInit();
		((ISupportInitialize)k2F()).BeginInit();
		((ISupportInitialize)Pg9()).BeginInit();
		((ISupportInitialize)k9K()).BeginInit();
		((ISupportInitialize)Pq9()).BeginInit();
		((ISupportInitialize)k0W()).BeginInit();
		((ISupportInitialize)a5F()).BeginInit();
		((ISupportInitialize)Nj7()).BeginInit();
		((ISupportInitialize)b0X()).BeginInit();
		((ISupportInitialize)r8W()).BeginInit();
		((ISupportInitialize)Pt3()).BeginInit();
		((ISupportInitialize)b0S()).BeginInit();
		((ISupportInitialize)Sg3()).BeginInit();
		((ISupportInitialize)Zg0()).BeginInit();
		((ISupportInitialize)Ez2()).BeginInit();
		((ISupportInitialize)t6M()).BeginInit();
		((ISupportInitialize)c0K()).BeginInit();
		((ISupportInitialize)Pz4()).BeginInit();
		((ISupportInitialize)Aa1()).BeginInit();
		((ISupportInitialize)Pk8()).BeginInit();
		((ISupportInitialize)Hr8()).BeginInit();
		((ISupportInitialize)Qi3()).BeginInit();
		((ISupportInitialize)Cn3()).BeginInit();
		((ISupportInitialize)z2D()).BeginInit();
		((ISupportInitialize)k4W()).BeginInit();
		((ISupportInitialize)g8R()).BeginInit();
		((ISupportInitialize)a7G()).BeginInit();
		((ISupportInitialize)Nr8()).BeginInit();
		((ISupportInitialize)g1Y()).BeginInit();
		((ISupportInitialize)q1E()).BeginInit();
		((ISupportInitialize)m5Q()).BeginInit();
		((ISupportInitialize)Ef6()).BeginInit();
		((ISupportInitialize)Tk2()).BeginInit();
		((ISupportInitialize)Wj2()).BeginInit();
		((ISupportInitialize)Mc2()).BeginInit();
		((ISupportInitialize)Xm7()).BeginInit();
		((ISupportInitialize)Nf0()).BeginInit();
		((ISupportInitialize)Yp1()).BeginInit();
		((ISupportInitialize)Mk7()).BeginInit();
		((ISupportInitialize)Ap7()).BeginInit();
		((ISupportInitialize)Jp6()).BeginInit();
		((ISupportInitialize)i4C()).BeginInit();
		((ISupportInitialize)y7T()).BeginInit();
		((ISupportInitialize)i0N()).BeginInit();
		((ISupportInitialize)Hj9()).BeginInit();
		((ISupportInitialize)m9L()).BeginInit();
		((ISupportInitialize)Gz0()).BeginInit();
		((ISupportInitialize)o0N()).BeginInit();
		((ISupportInitialize)Ps7()).BeginInit();
		((ISupportInitialize)c9C()).BeginInit();
		((ISupportInitialize)y3M()).BeginInit();
		((ISupportInitialize)d9C()).BeginInit();
		((ISupportInitialize)q0S()).BeginInit();
		((ISupportInitialize)j0B()).BeginInit();
		((ISupportInitialize)Wo5()).BeginInit();
		((ISupportInitialize)q4R()).BeginInit();
		((ISupportInitialize)y0C()).BeginInit();
		((ISupportInitialize)this.Me0()).BeginInit();
		((ISupportInitialize)a1P()).BeginInit();
		((ISupportInitialize)m3R()).BeginInit();
		((ISupportInitialize)m6B()).BeginInit();
		((ISupportInitialize)this.a8R()).BeginInit();
		((ISupportInitialize)x2H()).BeginInit();
		((ISupportInitialize)Ct4()).BeginInit();
		((ISupportInitialize)m9W()).BeginInit();
		((ISupportInitialize)f6E()).BeginInit();
		((ISupportInitialize)e8K()).BeginInit();
		((ISupportInitialize)i2Q()).BeginInit();
		((ISupportInitialize)Wg2()).BeginInit();
		((ISupportInitialize)x2J()).BeginInit();
		((ISupportInitialize)Hb4()).BeginInit();
		((ISupportInitialize)Qm4()).BeginInit();
		((ISupportInitialize)p2T()).BeginInit();
		((ISupportInitialize)Mi4()).BeginInit();
		((ISupportInitialize)De1()).BeginInit();
		((ISupportInitialize)o1K()).BeginInit();
		((ISupportInitialize)p9J()).BeginInit();
		((ISupportInitialize)g4M()).BeginInit();
		((ISupportInitialize)c1P()).BeginInit();
		((ISupportInitialize)f4D()).BeginInit();
		((Control)Kc4()).SuspendLayout();
		((Control)Ro1()).SuspendLayout();
		((Control)this).SuspendLayout();
		Xe9().set_AutoSize(true);
		((Control)Xe9()).set_Location(new Point(367, 256));
		((Control)Xe9()).set_Name("Label32");
		((Control)Xe9()).set_Size(new Size(19, 13));
		((Control)Xe9()).set_TabIndex(625);
		Xe9().set_Text("20");
		k7R().set_AutoSize(true);
		((Control)k7R()).set_Location(new Point(274, 256));
		((Control)k7R()).set_Name("Label33");
		((Control)k7R()).set_Size(new Size(19, 13));
		((Control)k7R()).set_TabIndex(624);
		k7R().set_Text("15");
		r7C().set_AutoSize(true);
		((Control)r7C()).set_Location(new Point(309, 256));
		((Control)r7C()).set_Name("Label34");
		((Control)r7C()).set_Size(new Size(19, 13));
		((Control)r7C()).set_TabIndex(623);
		r7C().set_Text("17");
		c0C().set_AutoSize(true);
		((Control)c0C()).set_Location(new Point(328, 256));
		((Control)c0C()).set_Name("Label35");
		((Control)c0C()).set_Size(new Size(19, 13));
		((Control)c0C()).set_TabIndex(622);
		c0C().set_Text("18");
		Ff3().set_AutoSize(true);
		((Control)Ff3()).set_Location(new Point(347, 256));
		((Control)Ff3()).set_Name("Label36");
		((Control)Ff3()).set_Size(new Size(19, 13));
		((Control)Ff3()).set_TabIndex(621);
		Ff3().set_Text("19");
		r0W().set_AutoSize(true);
		((Control)r0W()).set_Location(new Point(222, 256));
		((Control)r0W()).set_Name("Label37");
		((Control)r0W()).set_Size(new Size(19, 13));
		((Control)r0W()).set_TabIndex(620);
		r0W().set_Text("12");
		Rd4().set_AutoSize(true);
		((Control)Rd4()).set_Location(new Point(91, 256));
		((Control)Rd4()).set_Name("Label38");
		((Control)Rd4()).set_Size(new Size(13, 13));
		((Control)Rd4()).set_TabIndex(619);
		Rd4().set_Text("4");
		Jr6().set_AutoSize(true);
		((Control)Jr6()).set_Location(new Point(240, 256));
		((Control)Jr6()).set_Name("Label39");
		((Control)Jr6()).set_Size(new Size(19, 13));
		((Control)Jr6()).set_TabIndex(618);
		Jr6().set_Text("13");
		j3B().set_AutoSize(true);
		((Control)j3B()).set_Location(new Point(291, 256));
		((Control)j3B()).set_Name("Label40");
		((Control)j3B()).set_Size(new Size(19, 13));
		((Control)j3B()).set_TabIndex(617);
		j3B().set_Text("16");
		this.Ag0().set_AutoSize(true);
		((Control)this.Ag0()).set_Location(new Point(205, 256));
		((Control)this.Ag0()).set_Name("Label41");
		((Control)this.Ag0()).set_Size(new Size(19, 13));
		((Control)this.Ag0()).set_TabIndex(616);
		this.Ag0().set_Text("11");
		d6C().set_AutoSize(true);
		((Control)d6C()).set_Location(new Point(256, 256));
		((Control)d6C()).set_Name("Label42");
		((Control)d6C()).set_Size(new Size(19, 13));
		((Control)d6C()).set_TabIndex(615);
		d6C().set_Text("14");
		this.Ey7().set_AutoSize(true);
		((Control)this.Ey7()).set_Location(new Point(155, 256));
		((Control)this.Ey7()).set_Name("Label43");
		((Control)this.Ey7()).set_Size(new Size(13, 13));
		((Control)this.Ey7()).set_TabIndex(614);
		this.Ey7().set_Text("8");
		Pi3().set_AutoSize(true);
		((Control)Pi3()).set_Location(new Point(187, 256));
		((Control)Pi3()).set_Name("Label44");
		((Control)Pi3()).set_Size(new Size(19, 13));
		((Control)Pi3()).set_TabIndex(613);
		Pi3().set_Text("10");
		Sy9().set_AutoSize(true);
		((Control)Sy9()).set_Location(new Point(171, 256));
		((Control)Sy9()).set_Name("Label45");
		((Control)Sy9()).set_Size(new Size(13, 13));
		((Control)Sy9()).set_TabIndex(612);
		Sy9().set_Text("9");
		o5H().set_AutoSize(true);
		((Control)o5H()).set_Location(new Point(139, 256));
		((Control)o5H()).set_Name("Label46");
		((Control)o5H()).set_Size(new Size(13, 13));
		((Control)o5H()).set_TabIndex(611);
		o5H().set_Text("7");
		this.Ag0().set_AutoSize(true);
		((Control)this.Ag0()).set_Location(new Point(123, 256));
		((Control)this.Ag0()).set_Name("Label47");
		((Control)this.Ag0()).set_Size(new Size(13, 13));
		((Control)this.Ag0()).set_TabIndex(610);
		this.Ag0().set_Text("6");
		Xc6().set_AutoSize(true);
		((Control)Xc6()).set_Location(new Point(107, 256));
		((Control)Xc6()).set_Name("Label48");
		((Control)Xc6()).set_Size(new Size(13, 13));
		((Control)Xc6()).set_TabIndex(609);
		Xc6().set_Text("5");
		((Control)Am6()).set_Location(new Point(151, 42));
		((Control)Am6()).set_Name("txtBooked");
		((Control)Am6()).set_Size(new Size(83, 20));
		((Control)Am6()).set_TabIndex(28);
		((Control)Ap2()).set_Location(new Point(151, 16));
		((Control)Ap2()).set_Name("txtAvailable");
		((Control)Ap2()).set_Size(new Size(83, 20));
		((Control)Ap2()).set_TabIndex(25);
		((Control)Wa1()).set_BackColor(Color.Transparent);
		((Control)Wa1()).set_Location(new Point(5, 47));
		((Control)Wa1()).set_Name("Booked");
		((Control)Wa1()).set_Size(new Size(23, 18));
		Wa1().set_SizeMode((PictureBoxSizeMode)4);
		Wa1().set_TabIndex(27);
		Wa1().set_TabStop(false);
		((Control)a0F()).set_BackColor(Color.Transparent);
		((Control)a0F()).set_Location(new Point(6, 74));
		((Control)a0F()).set_Name("Provisional");
		((Control)a0F()).set_Size(new Size(23, 17));
		a0F().set_SizeMode((PictureBoxSizeMode)4);
		a0F().set_TabIndex(26);
		a0F().set_TabStop(false);
		((Control)Gb5()).set_BackColor(Color.Transparent);
		((Control)Gb5()).set_Location(new Point(5, 23));
		((Control)Gb5()).set_Name("Available");
		((Control)Gb5()).set_Size(new Size(23, 17));
		Gb5().set_SizeMode((PictureBoxSizeMode)4);
		Gb5().set_TabIndex(25);
		Gb5().set_TabStop(false);
		Mw7().set_AutoSize(true);
		((Control)Mw7()).set_BackColor(Color.Transparent);
		((Control)Mw7()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mw7()).set_Location(new Point(30, 49));
		((Control)Mw7()).set_Name("Label3");
		((Control)Mw7()).set_Size(new Size(74, 13));
		((Control)Mw7()).set_TabIndex(12);
		Mw7().set_Text("Booked Seats");
		Mc6().set_AutoSize(true);
		((Control)Mc6()).set_BackColor(Color.Transparent);
		((Control)Mc6()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mc6()).set_Location(new Point(30, 76));
		((Control)Mc6()).set_Name("Label1");
		((Control)Mc6()).set_Size(new Size(115, 13));
		((Control)Mc6()).set_TabIndex(11);
		Mc6().set_Text("Seat[s] on Reservation");
		Rn6().set_AutoSize(true);
		((Control)Rn6()).set_BackColor(Color.Transparent);
		((Control)Rn6()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Rn6()).set_Location(new Point(30, 24));
		((Control)Rn6()).set_Name("Label2");
		((Control)Rn6()).set_Size(new Size(80, 13));
		((Control)Rn6()).set_TabIndex(10);
		Rn6().set_Text("Available Seats");
		((Control)Nr0()).set_BackColor(Color.Transparent);
		((Control)Nr0()).set_Location(new Point(39, 21));
		((Control)Nr0()).set_Name("Cover");
		((Control)Nr0()).set_Size(new Size(129, 187));
		Nr0().set_SizeMode((PictureBoxSizeMode)4);
		Nr0().set_TabIndex(25);
		Nr0().set_TabStop(false);
		Px8().set_AutoSize(true);
		((Control)Px8()).set_Location(new Point(75, 256));
		((Control)Px8()).set_Name("Label49");
		((Control)Px8()).set_Size(new Size(13, 13));
		((Control)Px8()).set_TabIndex(608);
		Px8().set_Text("3");
		((Control)k9L()).set_Location(new Point(151, 73));
		((Control)k9L()).set_Name("txtProvisional");
		((Control)k9L()).set_Size(new Size(83, 20));
		((Control)k9L()).set_TabIndex(29);
		Qz8().set_AutoSize(true);
		((Control)Qz8()).set_Location(new Point(59, 256));
		((Control)Qz8()).set_Name("Label50");
		((Control)Qz8()).set_Size(new Size(13, 13));
		((Control)Qz8()).set_TabIndex(607);
		Qz8().set_Text("2");
		Ts8().set_AutoSize(true);
		((Control)Ts8()).set_Location(new Point(43, 256));
		((Control)Ts8()).set_Name("Label51");
		((Control)Ts8()).set_Size(new Size(13, 13));
		((Control)Ts8()).set_TabIndex(606);
		Ts8().set_Text("1");
		n5K().set_AutoSize(true);
		((Control)n5K()).set_Location(new Point(29, 362));
		((Control)n5K()).set_Name("Label54");
		((Control)n5K()).set_Size(new Size(15, 13));
		((Control)n5K()).set_TabIndex(565);
		n5K().set_Text("H");
		m3G().set_AutoSize(true);
		((Control)m3G()).set_Location(new Point(29, 340));
		((Control)m3G()).set_Name("Label55");
		((Control)m3G()).set_Size(new Size(15, 13));
		((Control)m3G()).set_TabIndex(564);
		m3G().set_Text("G");
		Qz7().set_AutoSize(true);
		((Control)Qz7()).set_Location(new Point(29, 318));
		((Control)Qz7()).set_Name("Label56");
		((Control)Qz7()).set_Size(new Size(13, 13));
		((Control)Qz7()).set_TabIndex(563);
		Qz7().set_Text("F");
		i6N().set_AutoSize(true);
		((Control)i6N()).set_Location(new Point(176, 222));
		((Control)i6N()).set_Name("Label31");
		((Control)i6N()).set_Size(new Size(72, 13));
		((Control)i6N()).set_TabIndex(562);
		i6N().set_Text("LOWER BOX");
		Tg9().set_AutoSize(true);
		((Control)Tg9()).set_Location(new Point(28, 299));
		((Control)Tg9()).set_Name("Label26");
		((Control)Tg9()).set_Size(new Size(14, 13));
		((Control)Tg9()).set_TabIndex(561);
		Tg9().set_Text("E");
		z7C().set_AutoSize(true);
		((Control)z7C()).set_Location(new Point(28, 187));
		((Control)z7C()).set_Name("Label27");
		((Control)z7C()).set_Size(new Size(15, 13));
		((Control)z7C()).set_TabIndex(560);
		z7C().set_Text("D");
		z8Q().set_AutoSize(true);
		((Control)z8Q()).set_Location(new Point(28, 165));
		((Control)z8Q()).set_Name("Label28");
		((Control)z8Q()).set_Size(new Size(14, 13));
		((Control)z8Q()).set_TabIndex(559);
		z8Q().set_Text("C");
		Cm5().set_AutoSize(true);
		((Control)Cm5()).set_Location(new Point(28, 143));
		((Control)Cm5()).set_Name("Label29");
		((Control)Cm5()).set_Size(new Size(14, 13));
		((Control)Cm5()).set_TabIndex(558);
		Cm5().set_Text("B");
		Qt9().set_AutoSize(true);
		((Control)Qt9()).set_Location(new Point(28, 121));
		((Control)Qt9()).set_Name("Label30");
		((Control)Qt9()).set_Size(new Size(14, 13));
		((Control)Qt9()).set_TabIndex(557);
		Qt9().set_Text("A");
		As3().set_AutoSize(true);
		((Control)As3()).set_Location(new Point(367, 75));
		((Control)As3()).set_Name("Label25");
		((Control)As3()).set_Size(new Size(19, 13));
		((Control)As3()).set_TabIndex(556);
		As3().set_Text("20");
		x3P().set_AutoSize(true);
		((Control)x3P()).set_Location(new Point(274, 75));
		((Control)x3P()).set_Name("Label24");
		((Control)x3P()).set_Size(new Size(19, 13));
		((Control)x3P()).set_TabIndex(555);
		x3P().set_Text("15");
		t1K().set_AutoSize(true);
		((Control)t1K()).set_Location(new Point(309, 75));
		((Control)t1K()).set_Name("Label23");
		((Control)t1K()).set_Size(new Size(19, 13));
		((Control)t1K()).set_TabIndex(554);
		t1K().set_Text("17");
		Zb7().set_AutoSize(true);
		((Control)Zb7()).set_Location(new Point(328, 75));
		((Control)Zb7()).set_Name("Label22");
		((Control)Zb7()).set_Size(new Size(19, 13));
		((Control)Zb7()).set_TabIndex(553);
		Zb7().set_Text("18");
		z0A().set_AutoSize(true);
		((Control)z0A()).set_Location(new Point(347, 75));
		((Control)z0A()).set_Name("Label21");
		((Control)z0A()).set_Size(new Size(19, 13));
		((Control)z0A()).set_TabIndex(552);
		z0A().set_Text("19");
		o5K().set_AutoSize(true);
		((Control)o5K()).set_Location(new Point(222, 75));
		((Control)o5K()).set_Name("Label20");
		((Control)o5K()).set_Size(new Size(19, 13));
		((Control)o5K()).set_TabIndex(551);
		o5K().set_Text("12");
		Jy9().set_AutoSize(true);
		((Control)Jy9()).set_Location(new Point(91, 75));
		((Control)Jy9()).set_Name("Label19");
		((Control)Jy9()).set_Size(new Size(13, 13));
		((Control)Jy9()).set_TabIndex(550);
		Jy9().set_Text("4");
		s0D().set_AutoSize(true);
		((Control)s0D()).set_Location(new Point(240, 75));
		((Control)s0D()).set_Name("Label18");
		((Control)s0D()).set_Size(new Size(19, 13));
		((Control)s0D()).set_TabIndex(549);
		s0D().set_Text("13");
		Wg7().set_AutoSize(true);
		((Control)Wg7()).set_Location(new Point(291, 75));
		((Control)Wg7()).set_Name("Label17");
		((Control)Wg7()).set_Size(new Size(19, 13));
		((Control)Wg7()).set_TabIndex(548);
		Wg7().set_Text("16");
		Dk3().set_AutoSize(true);
		((Control)Dk3()).set_Location(new Point(205, 75));
		((Control)Dk3()).set_Name("Label16");
		((Control)Dk3()).set_Size(new Size(19, 13));
		((Control)Dk3()).set_TabIndex(547);
		Dk3().set_Text("11");
		Nn0().set_AutoSize(true);
		((Control)Nn0()).set_Location(new Point(256, 75));
		((Control)Nn0()).set_Name("Label15");
		((Control)Nn0()).set_Size(new Size(19, 13));
		((Control)Nn0()).set_TabIndex(546);
		Nn0().set_Text("14");
		Es2().set_AutoSize(true);
		((Control)Es2()).set_Location(new Point(155, 75));
		((Control)Es2()).set_Name("Label14");
		((Control)Es2()).set_Size(new Size(13, 13));
		((Control)Es2()).set_TabIndex(545);
		Es2().set_Text("8");
		g7J().set_AutoSize(true);
		((Control)g7J()).set_Location(new Point(187, 75));
		((Control)g7J()).set_Name("Label13");
		((Control)g7J()).set_Size(new Size(19, 13));
		((Control)g7J()).set_TabIndex(544);
		g7J().set_Text("10");
		Jn7().set_AutoSize(true);
		((Control)Jn7()).set_Location(new Point(171, 75));
		((Control)Jn7()).set_Name("Label12");
		((Control)Jn7()).set_Size(new Size(13, 13));
		((Control)Jn7()).set_TabIndex(543);
		Jn7().set_Text("9");
		Rp8().set_AutoSize(true);
		((Control)Rp8()).set_Location(new Point(139, 75));
		((Control)Rp8()).set_Name("Label11");
		((Control)Rp8()).set_Size(new Size(13, 13));
		((Control)Rp8()).set_TabIndex(542);
		Rp8().set_Text("7");
		p7B().set_AutoSize(true);
		((Control)p7B()).set_Location(new Point(123, 75));
		((Control)p7B()).set_Name("Label10");
		((Control)p7B()).set_Size(new Size(13, 13));
		((Control)p7B()).set_TabIndex(541);
		p7B().set_Text("6");
		Lg6().set_AutoSize(true);
		((Control)Lg6()).set_Location(new Point(107, 75));
		((Control)Lg6()).set_Name("Label9");
		((Control)Lg6()).set_Size(new Size(13, 13));
		((Control)Lg6()).set_TabIndex(540);
		Lg6().set_Text("5");
		k1G().set_AutoSize(true);
		((Control)k1G()).set_Location(new Point(75, 75));
		((Control)k1G()).set_Name("Label8");
		((Control)k1G()).set_Size(new Size(13, 13));
		((Control)k1G()).set_TabIndex(539);
		k1G().set_Text("3");
		d4X().set_AutoSize(true);
		((Control)d4X()).set_Location(new Point(59, 75));
		((Control)d4X()).set_Name("Label7");
		((Control)d4X()).set_Size(new Size(13, 13));
		((Control)d4X()).set_TabIndex(538);
		d4X().set_Text("2");
		Jw8().set_AutoSize(true);
		((Control)Jw8()).set_Location(new Point(43, 75));
		((Control)Jw8()).set_Name("Label5");
		((Control)Jw8()).set_Size(new Size(13, 13));
		((Control)Jw8()).set_TabIndex(537);
		Jw8().set_Text("1");
		Nj2().set_AutoSize(true);
		((Control)Nj2()).set_Location(new Point(176, 48));
		((Control)Nj2()).set_Name("Label4");
		((Control)Nj2()).set_Size(new Size(69, 13));
		((Control)Nj2()).set_TabIndex(536);
		Nj2().set_Text("UPPER BOX");
		((Control)this.Ey7()).get_Controls().Add((Control)(object)k6Q());
		((Control)this.Ey7()).get_Controls().Add((Control)(object)Nr0());
		((Control)this.Ey7()).set_ForeColor(SystemColors.ControlLight);
		((Control)this.Ey7()).set_Location(new Point(471, 167));
		((Control)this.Ey7()).set_Name("GroupBox3");
		((Control)this.Ey7()).set_Size(new Size(200, 251));
		((Control)this.Ey7()).set_TabIndex(534);
		this.Ey7().set_TabStop(false);
		this.Ey7().set_Text("Movie On Display");
		((ButtonBase)k6Q()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)k6Q()).set_FlatStyle((FlatStyle)0);
		((Control)k6Q()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)k6Q()).set_Location(new Point(48, 214));
		((Control)k6Q()).set_Name("btnViewReservations");
		((Control)k6Q()).set_Size(new Size(117, 23));
		((Control)k6Q()).set_TabIndex(41);
		((ButtonBase)k6Q()).set_Text("View Reservations");
		((ButtonBase)k6Q()).set_UseVisualStyleBackColor(true);
		((Control)q3J()).get_Controls().Add((Control)(object)k9L());
		((Control)q3J()).get_Controls().Add((Control)(object)Am6());
		((Control)q3J()).get_Controls().Add((Control)(object)Ap2());
		((Control)q3J()).get_Controls().Add((Control)(object)Wa1());
		((Control)q3J()).get_Controls().Add((Control)(object)a0F());
		((Control)q3J()).get_Controls().Add((Control)(object)Gb5());
		((Control)q3J()).get_Controls().Add((Control)(object)Mw7());
		((Control)q3J()).get_Controls().Add((Control)(object)Mc6());
		((Control)q3J()).get_Controls().Add((Control)(object)Rn6());
		((Control)q3J()).set_ForeColor(SystemColors.ControlLight);
		((Control)q3J()).set_Location(new Point(454, 48));
		((Control)q3J()).set_Name("GroupBox1");
		((Control)q3J()).set_Size(new Size(240, 100));
		((Control)q3J()).set_TabIndex(532);
		q3J().set_TabStop(false);
		q3J().set_Text("Statistics");
		Ao1().set_AutoSize(true);
		((Control)Ao1()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ao1()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ao1()).set_Location(new Point(28, 6));
		((Control)Ao1()).set_Name("Label6");
		((Control)Ao1()).set_Size(new Size(106, 24));
		((Control)Ao1()).set_TabIndex(531);
		Ao1().set_Text("CINEMA 2");
		((Control)e6A()).set_Location(new Point(435, 40));
		((Control)e6A()).set_Name("Background");
		((Control)e6A()).set_Size(new Size(474, 396));
		e6A().set_SizeMode((PictureBoxSizeMode)1);
		e6A().set_TabIndex(530);
		e6A().set_TabStop(false);
		((Control)d8G()).set_BackColor(Color.Transparent);
		((Control)d8G()).set_Location(new Point(-2, -3));
		((Control)d8G()).set_Name("NameBox");
		((Control)d8G()).set_Size(new Size(914, 45));
		d8G().set_SizeMode((PictureBoxSizeMode)1);
		d8G().set_TabIndex(529);
		d8G().set_TabStop(false);
		((Control)Ri6()).set_Location(new Point(372, 187));
		((Control)Ri6()).set_Name("PictureBox61");
		((Control)Ri6()).set_Size(new Size(10, 10));
		Ri6().set_SizeMode((PictureBoxSizeMode)4);
		Ri6().set_TabIndex(705);
		Ri6().set_TabStop(false);
		((Control)r3W()).set_Location(new Point(352, 187));
		((Control)r3W()).set_Name("PictureBox62");
		((Control)r3W()).set_Size(new Size(10, 10));
		r3W().set_SizeMode((PictureBoxSizeMode)4);
		r3W().set_TabIndex(704);
		r3W().set_TabStop(false);
		((Control)Rq5()).set_Location(new Point(333, 187));
		((Control)Rq5()).set_Name("PictureBox63");
		((Control)Rq5()).set_Size(new Size(10, 10));
		Rq5().set_SizeMode((PictureBoxSizeMode)4);
		Rq5().set_TabIndex(703);
		Rq5().set_TabStop(false);
		((Control)z2P()).set_Location(new Point(314, 187));
		((Control)z2P()).set_Name("PictureBox64");
		((Control)z2P()).set_Size(new Size(10, 10));
		z2P().set_SizeMode((PictureBoxSizeMode)4);
		z2P().set_TabIndex(702);
		z2P().set_TabStop(false);
		((Control)Tg1()).set_Location(new Point(296, 187));
		((Control)Tg1()).set_Name("PictureBox65");
		((Control)Tg1()).set_Size(new Size(10, 10));
		Tg1().set_SizeMode((PictureBoxSizeMode)4);
		Tg1().set_TabIndex(701);
		Tg1().set_TabStop(false);
		((Control)Gs2()).set_Location(new Point(279, 187));
		((Control)Gs2()).set_Name("PictureBox66");
		((Control)Gs2()).set_Size(new Size(10, 10));
		Gs2().set_SizeMode((PictureBoxSizeMode)4);
		Gs2().set_TabIndex(700);
		Gs2().set_TabStop(false);
		((Control)Xx0()).set_Location(new Point(261, 187));
		((Control)Xx0()).set_Name("PictureBox67");
		((Control)Xx0()).set_Size(new Size(10, 10));
		Xx0().set_SizeMode((PictureBoxSizeMode)4);
		Xx0().set_TabIndex(699);
		Xx0().set_TabStop(false);
		((Control)Wt5()).set_Location(new Point(245, 187));
		((Control)Wt5()).set_Name("PictureBox68");
		((Control)Wt5()).set_Size(new Size(10, 10));
		Wt5().set_SizeMode((PictureBoxSizeMode)4);
		Wt5().set_TabIndex(698);
		Wt5().set_TabStop(false);
		((Control)b9J()).set_Location(new Point(227, 187));
		((Control)b9J()).set_Name("PictureBox69");
		((Control)b9J()).set_Size(new Size(10, 10));
		b9J().set_SizeMode((PictureBoxSizeMode)4);
		b9J().set_TabIndex(697);
		b9J().set_TabStop(false);
		((Control)c6T()).set_Location(new Point(208, 187));
		((Control)c6T()).set_Name("PictureBox70");
		((Control)c6T()).set_Size(new Size(10, 10));
		c6T().set_SizeMode((PictureBoxSizeMode)4);
		c6T().set_TabIndex(696);
		c6T().set_TabStop(false);
		((Control)Qj6()).set_Location(new Point(190, 187));
		((Control)Qj6()).set_Name("PictureBox71");
		((Control)Qj6()).set_Size(new Size(10, 10));
		Qj6().set_SizeMode((PictureBoxSizeMode)4);
		Qj6().set_TabIndex(695);
		Qj6().set_TabStop(false);
		((Control)k6C()).set_Location(new Point(174, 187));
		((Control)k6C()).set_Name("PictureBox72");
		((Control)k6C()).set_Size(new Size(10, 10));
		k6C().set_SizeMode((PictureBoxSizeMode)4);
		k6C().set_TabIndex(694);
		k6C().set_TabStop(false);
		((Control)Ba0()).set_Location(new Point(158, 187));
		((Control)Ba0()).set_Name("PictureBox73");
		((Control)Ba0()).set_Size(new Size(10, 10));
		Ba0().set_SizeMode((PictureBoxSizeMode)4);
		Ba0().set_TabIndex(693);
		Ba0().set_TabStop(false);
		((Control)Fp6()).set_Location(new Point(142, 187));
		((Control)Fp6()).set_Name("PictureBox74");
		((Control)Fp6()).set_Size(new Size(10, 10));
		Fp6().set_SizeMode((PictureBoxSizeMode)4);
		Fp6().set_TabIndex(692);
		Fp6().set_TabStop(false);
		((Control)b4B()).set_Location(new Point(126, 187));
		((Control)b4B()).set_Name("PictureBox75");
		((Control)b4B()).set_Size(new Size(10, 10));
		b4B().set_SizeMode((PictureBoxSizeMode)4);
		b4B().set_TabIndex(691);
		b4B().set_TabStop(false);
		((Control)r4X()).set_Location(new Point(110, 187));
		((Control)r4X()).set_Name("PictureBox76");
		((Control)r4X()).set_Size(new Size(10, 10));
		r4X().set_SizeMode((PictureBoxSizeMode)4);
		r4X().set_TabIndex(690);
		r4X().set_TabStop(false);
		((Control)Ba1()).set_Location(new Point(94, 187));
		((Control)Ba1()).set_Name("PictureBox77");
		((Control)Ba1()).set_Size(new Size(10, 10));
		Ba1().set_SizeMode((PictureBoxSizeMode)4);
		Ba1().set_TabIndex(689);
		Ba1().set_TabStop(false);
		((Control)w1M()).set_Location(new Point(78, 187));
		((Control)w1M()).set_Name("PictureBox78");
		((Control)w1M()).set_Size(new Size(10, 10));
		w1M().set_SizeMode((PictureBoxSizeMode)4);
		w1M().set_TabIndex(688);
		w1M().set_TabStop(false);
		((Control)k1X()).set_Location(new Point(62, 187));
		((Control)k1X()).set_Name("PictureBox79");
		((Control)k1X()).set_Size(new Size(10, 10));
		k1X().set_SizeMode((PictureBoxSizeMode)4);
		k1X().set_TabIndex(687);
		k1X().set_TabStop(false);
		((Control)q2Y()).set_Location(new Point(48, 187));
		((Control)q2Y()).set_Name("PictureBox80");
		((Control)q2Y()).set_Size(new Size(10, 10));
		q2Y().set_SizeMode((PictureBoxSizeMode)4);
		q2Y().set_TabIndex(686);
		q2Y().set_TabStop(false);
		((Control)Tc9()).set_Location(new Point(372, 165));
		((Control)Tc9()).set_Name("PictureBox41");
		((Control)Tc9()).set_Size(new Size(10, 10));
		Tc9().set_SizeMode((PictureBoxSizeMode)4);
		Tc9().set_TabIndex(685);
		Tc9().set_TabStop(false);
		((Control)Wz2()).set_Location(new Point(352, 165));
		((Control)Wz2()).set_Name("PictureBox42");
		((Control)Wz2()).set_Size(new Size(10, 10));
		Wz2().set_SizeMode((PictureBoxSizeMode)4);
		Wz2().set_TabIndex(684);
		Wz2().set_TabStop(false);
		((Control)Qd2()).set_Location(new Point(333, 165));
		((Control)Qd2()).set_Name("PictureBox43");
		((Control)Qd2()).set_Size(new Size(10, 10));
		Qd2().set_SizeMode((PictureBoxSizeMode)4);
		Qd2().set_TabIndex(683);
		Qd2().set_TabStop(false);
		((Control)Ac4()).set_Location(new Point(314, 165));
		((Control)Ac4()).set_Name("PictureBox44");
		((Control)Ac4()).set_Size(new Size(10, 10));
		Ac4().set_SizeMode((PictureBoxSizeMode)4);
		Ac4().set_TabIndex(682);
		Ac4().set_TabStop(false);
		((Control)s0T()).set_Location(new Point(296, 165));
		((Control)s0T()).set_Name("PictureBox45");
		((Control)s0T()).set_Size(new Size(10, 10));
		s0T().set_SizeMode((PictureBoxSizeMode)4);
		s0T().set_TabIndex(681);
		s0T().set_TabStop(false);
		((Control)f6M()).set_Location(new Point(279, 165));
		((Control)f6M()).set_Name("PictureBox46");
		((Control)f6M()).set_Size(new Size(10, 10));
		f6M().set_SizeMode((PictureBoxSizeMode)4);
		f6M().set_TabIndex(680);
		f6M().set_TabStop(false);
		((Control)f2L()).set_Location(new Point(261, 165));
		((Control)f2L()).set_Name("PictureBox47");
		((Control)f2L()).set_Size(new Size(10, 10));
		f2L().set_SizeMode((PictureBoxSizeMode)4);
		f2L().set_TabIndex(679);
		f2L().set_TabStop(false);
		((Control)Bf9()).set_Location(new Point(245, 165));
		((Control)Bf9()).set_Name("PictureBox48");
		((Control)Bf9()).set_Size(new Size(10, 10));
		Bf9().set_SizeMode((PictureBoxSizeMode)4);
		Bf9().set_TabIndex(678);
		Bf9().set_TabStop(false);
		((Control)i1G()).set_Location(new Point(227, 165));
		((Control)i1G()).set_Name("PictureBox49");
		((Control)i1G()).set_Size(new Size(10, 10));
		i1G().set_SizeMode((PictureBoxSizeMode)4);
		i1G().set_TabIndex(677);
		i1G().set_TabStop(false);
		((Control)f9R()).set_Location(new Point(208, 165));
		((Control)f9R()).set_Name("PictureBox50");
		((Control)f9R()).set_Size(new Size(10, 10));
		f9R().set_SizeMode((PictureBoxSizeMode)4);
		f9R().set_TabIndex(676);
		f9R().set_TabStop(false);
		((Control)Pq4()).set_Location(new Point(190, 165));
		((Control)Pq4()).set_Name("PictureBox51");
		((Control)Pq4()).set_Size(new Size(10, 10));
		Pq4().set_SizeMode((PictureBoxSizeMode)4);
		Pq4().set_TabIndex(675);
		Pq4().set_TabStop(false);
		((Control)d4H()).set_Location(new Point(174, 165));
		((Control)d4H()).set_Name("PictureBox52");
		((Control)d4H()).set_Size(new Size(10, 10));
		d4H().set_SizeMode((PictureBoxSizeMode)4);
		d4H().set_TabIndex(674);
		d4H().set_TabStop(false);
		((Control)Rj7()).set_Location(new Point(158, 165));
		((Control)Rj7()).set_Name("PictureBox53");
		((Control)Rj7()).set_Size(new Size(10, 10));
		Rj7().set_SizeMode((PictureBoxSizeMode)4);
		Rj7().set_TabIndex(673);
		Rj7().set_TabStop(false);
		((Control)Nr6()).set_Location(new Point(142, 165));
		((Control)Nr6()).set_Name("PictureBox54");
		((Control)Nr6()).set_Size(new Size(10, 10));
		Nr6().set_SizeMode((PictureBoxSizeMode)4);
		Nr6().set_TabIndex(672);
		Nr6().set_TabStop(false);
		((Control)k7H()).set_Location(new Point(126, 165));
		((Control)k7H()).set_Name("PictureBox55");
		((Control)k7H()).set_Size(new Size(10, 10));
		k7H().set_SizeMode((PictureBoxSizeMode)4);
		k7H().set_TabIndex(671);
		k7H().set_TabStop(false);
		((Control)r5Z()).set_Location(new Point(110, 165));
		((Control)r5Z()).set_Name("PictureBox56");
		((Control)r5Z()).set_Size(new Size(10, 10));
		r5Z().set_SizeMode((PictureBoxSizeMode)4);
		r5Z().set_TabIndex(670);
		r5Z().set_TabStop(false);
		((Control)Nd5()).set_Location(new Point(94, 165));
		((Control)Nd5()).set_Name("PictureBox57");
		((Control)Nd5()).set_Size(new Size(10, 10));
		Nd5().set_SizeMode((PictureBoxSizeMode)4);
		Nd5().set_TabIndex(669);
		Nd5().set_TabStop(false);
		((Control)s5F()).set_Location(new Point(78, 165));
		((Control)s5F()).set_Name("PictureBox58");
		((Control)s5F()).set_Size(new Size(10, 10));
		s5F().set_SizeMode((PictureBoxSizeMode)4);
		s5F().set_TabIndex(668);
		s5F().set_TabStop(false);
		((Control)Qn8()).set_Location(new Point(62, 165));
		((Control)Qn8()).set_Name("PictureBox59");
		((Control)Qn8()).set_Size(new Size(10, 10));
		Qn8().set_SizeMode((PictureBoxSizeMode)4);
		Qn8().set_TabIndex(667);
		Qn8().set_TabStop(false);
		((Control)Qd7()).set_Location(new Point(48, 165));
		((Control)Qd7()).set_Name("PictureBox60");
		((Control)Qd7()).set_Size(new Size(10, 10));
		Qd7().set_SizeMode((PictureBoxSizeMode)4);
		Qd7().set_TabIndex(666);
		Qd7().set_TabStop(false);
		((Control)At6()).set_Location(new Point(372, 143));
		((Control)At6()).set_Name("PictureBox21");
		((Control)At6()).set_Size(new Size(10, 10));
		At6().set_SizeMode((PictureBoxSizeMode)4);
		At6().set_TabIndex(665);
		At6().set_TabStop(false);
		((Control)Gw9()).set_Location(new Point(352, 143));
		((Control)Gw9()).set_Name("PictureBox22");
		((Control)Gw9()).set_Size(new Size(10, 10));
		Gw9().set_SizeMode((PictureBoxSizeMode)4);
		Gw9().set_TabIndex(664);
		Gw9().set_TabStop(false);
		((Control)Qc8()).set_Location(new Point(333, 143));
		((Control)Qc8()).set_Name("PictureBox23");
		((Control)Qc8()).set_Size(new Size(10, 10));
		Qc8().set_SizeMode((PictureBoxSizeMode)4);
		Qc8().set_TabIndex(663);
		Qc8().set_TabStop(false);
		((Control)Mw1()).set_Location(new Point(314, 143));
		((Control)Mw1()).set_Name("PictureBox24");
		((Control)Mw1()).set_Size(new Size(10, 10));
		Mw1().set_SizeMode((PictureBoxSizeMode)4);
		Mw1().set_TabIndex(662);
		Mw1().set_TabStop(false);
		((Control)Yp2()).set_Location(new Point(296, 143));
		((Control)Yp2()).set_Name("PictureBox25");
		((Control)Yp2()).set_Size(new Size(10, 10));
		Yp2().set_SizeMode((PictureBoxSizeMode)4);
		Yp2().set_TabIndex(661);
		Yp2().set_TabStop(false);
		((Control)Mb7()).set_Location(new Point(279, 143));
		((Control)Mb7()).set_Name("PictureBox26");
		((Control)Mb7()).set_Size(new Size(10, 10));
		Mb7().set_SizeMode((PictureBoxSizeMode)4);
		Mb7().set_TabIndex(660);
		Mb7().set_TabStop(false);
		((Control)c6L()).set_Location(new Point(261, 143));
		((Control)c6L()).set_Name("PictureBox27");
		((Control)c6L()).set_Size(new Size(10, 10));
		c6L().set_SizeMode((PictureBoxSizeMode)4);
		c6L().set_TabIndex(659);
		c6L().set_TabStop(false);
		((Control)Nc1()).set_Location(new Point(245, 143));
		((Control)Nc1()).set_Name("PictureBox28");
		((Control)Nc1()).set_Size(new Size(10, 10));
		Nc1().set_SizeMode((PictureBoxSizeMode)4);
		Nc1().set_TabIndex(658);
		Nc1().set_TabStop(false);
		((Control)Gd9()).set_Location(new Point(227, 143));
		((Control)Gd9()).set_Name("PictureBox29");
		((Control)Gd9()).set_Size(new Size(10, 10));
		Gd9().set_SizeMode((PictureBoxSizeMode)4);
		Gd9().set_TabIndex(657);
		Gd9().set_TabStop(false);
		((Control)Ja2()).set_Location(new Point(208, 143));
		((Control)Ja2()).set_Name("PictureBox30");
		((Control)Ja2()).set_Size(new Size(10, 10));
		Ja2().set_SizeMode((PictureBoxSizeMode)4);
		Ja2().set_TabIndex(656);
		Ja2().set_TabStop(false);
		((Control)Bs0()).set_Location(new Point(190, 143));
		((Control)Bs0()).set_Name("PictureBox31");
		((Control)Bs0()).set_Size(new Size(10, 10));
		Bs0().set_SizeMode((PictureBoxSizeMode)4);
		Bs0().set_TabIndex(655);
		Bs0().set_TabStop(false);
		((Control)w1Y()).set_Location(new Point(174, 143));
		((Control)w1Y()).set_Name("PictureBox32");
		((Control)w1Y()).set_Size(new Size(10, 10));
		w1Y().set_SizeMode((PictureBoxSizeMode)4);
		w1Y().set_TabIndex(654);
		w1Y().set_TabStop(false);
		((Control)this.Me0()).set_Location(new Point(158, 143));
		((Control)this.Me0()).set_Name("PictureBox33");
		((Control)this.Me0()).set_Size(new Size(10, 10));
		this.Me0().set_SizeMode((PictureBoxSizeMode)4);
		this.Me0().set_TabIndex(653);
		this.Me0().set_TabStop(false);
		((Control)g1X()).set_Location(new Point(142, 143));
		((Control)g1X()).set_Name("PictureBox34");
		((Control)g1X()).set_Size(new Size(10, 10));
		g1X().set_SizeMode((PictureBoxSizeMode)4);
		g1X().set_TabIndex(652);
		g1X().set_TabStop(false);
		((Control)a6J()).set_Location(new Point(126, 143));
		((Control)a6J()).set_Name("PictureBox35");
		((Control)a6J()).set_Size(new Size(10, 10));
		a6J().set_SizeMode((PictureBoxSizeMode)4);
		a6J().set_TabIndex(651);
		a6J().set_TabStop(false);
		((Control)e0Q()).set_Location(new Point(110, 143));
		((Control)e0Q()).set_Name("PictureBox36");
		((Control)e0Q()).set_Size(new Size(10, 10));
		e0Q().set_SizeMode((PictureBoxSizeMode)4);
		e0Q().set_TabIndex(650);
		e0Q().set_TabStop(false);
		((Control)this.t7A()).set_Location(new Point(94, 143));
		((Control)this.t7A()).set_Name("PictureBox37");
		((Control)this.t7A()).set_Size(new Size(10, 10));
		this.t7A().set_SizeMode((PictureBoxSizeMode)4);
		this.t7A().set_TabIndex(649);
		this.t7A().set_TabStop(false);
		((Control)Zr9()).set_Location(new Point(78, 143));
		((Control)Zr9()).set_Name("PictureBox38");
		((Control)Zr9()).set_Size(new Size(10, 10));
		Zr9().set_SizeMode((PictureBoxSizeMode)4);
		Zr9().set_TabIndex(648);
		Zr9().set_TabStop(false);
		((Control)Ra2()).set_Location(new Point(62, 143));
		((Control)Ra2()).set_Name("PictureBox39");
		((Control)Ra2()).set_Size(new Size(10, 10));
		Ra2().set_SizeMode((PictureBoxSizeMode)4);
		Ra2().set_TabIndex(647);
		Ra2().set_TabStop(false);
		((Control)Qk4()).set_Location(new Point(48, 143));
		((Control)Qk4()).set_Name("PictureBox40");
		((Control)Qk4()).set_Size(new Size(10, 10));
		Qk4().set_SizeMode((PictureBoxSizeMode)4);
		Qk4().set_TabIndex(646);
		Qk4().set_TabStop(false);
		((Control)d3A()).set_Location(new Point(372, 121));
		((Control)d3A()).set_Name("PictureBox20");
		((Control)d3A()).set_Size(new Size(10, 10));
		d3A().set_SizeMode((PictureBoxSizeMode)4);
		d3A().set_TabIndex(645);
		d3A().set_TabStop(false);
		((Control)e3C()).set_Location(new Point(352, 121));
		((Control)e3C()).set_Name("PictureBox19");
		((Control)e3C()).set_Size(new Size(10, 10));
		e3C().set_SizeMode((PictureBoxSizeMode)4);
		e3C().set_TabIndex(644);
		e3C().set_TabStop(false);
		((Control)Sw8()).set_Location(new Point(333, 121));
		((Control)Sw8()).set_Name("PictureBox18");
		((Control)Sw8()).set_Size(new Size(10, 10));
		Sw8().set_SizeMode((PictureBoxSizeMode)4);
		Sw8().set_TabIndex(643);
		Sw8().set_TabStop(false);
		((Control)q0Y()).set_Location(new Point(314, 121));
		((Control)q0Y()).set_Name("PictureBox17");
		((Control)q0Y()).set_Size(new Size(10, 10));
		q0Y().set_SizeMode((PictureBoxSizeMode)4);
		q0Y().set_TabIndex(642);
		q0Y().set_TabStop(false);
		((Control)Qi1()).set_Location(new Point(296, 121));
		((Control)Qi1()).set_Name("PictureBox16");
		((Control)Qi1()).set_Size(new Size(10, 10));
		Qi1().set_SizeMode((PictureBoxSizeMode)4);
		Qi1().set_TabIndex(641);
		Qi1().set_TabStop(false);
		((Control)s0S()).set_Location(new Point(279, 121));
		((Control)s0S()).set_Name("PictureBox15");
		((Control)s0S()).set_Size(new Size(10, 10));
		s0S().set_SizeMode((PictureBoxSizeMode)4);
		s0S().set_TabIndex(640);
		s0S().set_TabStop(false);
		((Control)Ne6()).set_Location(new Point(261, 121));
		((Control)Ne6()).set_Name("PictureBox14");
		((Control)Ne6()).set_Size(new Size(10, 10));
		Ne6().set_SizeMode((PictureBoxSizeMode)4);
		Ne6().set_TabIndex(639);
		Ne6().set_TabStop(false);
		((Control)b5Z()).set_Location(new Point(245, 121));
		((Control)b5Z()).set_Name("PictureBox13");
		((Control)b5Z()).set_Size(new Size(10, 10));
		b5Z().set_SizeMode((PictureBoxSizeMode)4);
		b5Z().set_TabIndex(638);
		b5Z().set_TabStop(false);
		((Control)j5T()).set_Location(new Point(227, 121));
		((Control)j5T()).set_Name("PictureBox12");
		((Control)j5T()).set_Size(new Size(10, 10));
		j5T().set_SizeMode((PictureBoxSizeMode)4);
		j5T().set_TabIndex(637);
		j5T().set_TabStop(false);
		((Control)Si2()).set_Location(new Point(208, 121));
		((Control)Si2()).set_Name("PictureBox11");
		((Control)Si2()).set_Size(new Size(10, 10));
		Si2().set_SizeMode((PictureBoxSizeMode)4);
		Si2().set_TabIndex(636);
		Si2().set_TabStop(false);
		((Control)Ng5()).set_Location(new Point(190, 121));
		((Control)Ng5()).set_Name("PictureBox10");
		((Control)Ng5()).set_Size(new Size(10, 10));
		Ng5().set_SizeMode((PictureBoxSizeMode)4);
		Ng5().set_TabIndex(635);
		Ng5().set_TabStop(false);
		((Control)this.a8R()).set_Location(new Point(174, 121));
		((Control)this.a8R()).set_Name("PictureBox9");
		((Control)this.a8R()).set_Size(new Size(10, 10));
		this.a8R().set_SizeMode((PictureBoxSizeMode)4);
		this.a8R().set_TabIndex(634);
		this.a8R().set_TabStop(false);
		((Control)Di9()).set_Location(new Point(158, 121));
		((Control)Di9()).set_Name("PictureBox8");
		((Control)Di9()).set_Size(new Size(10, 10));
		Di9().set_SizeMode((PictureBoxSizeMode)4);
		Di9().set_TabIndex(633);
		Di9().set_TabStop(false);
		((Control)Wz4()).set_Location(new Point(142, 121));
		((Control)Wz4()).set_Name("PictureBox7");
		((Control)Wz4()).set_Size(new Size(10, 10));
		Wz4().set_SizeMode((PictureBoxSizeMode)4);
		Wz4().set_TabIndex(632);
		Wz4().set_TabStop(false);
		((Control)Go2()).set_Location(new Point(126, 121));
		((Control)Go2()).set_Name("PictureBox6");
		((Control)Go2()).set_Size(new Size(10, 10));
		Go2().set_SizeMode((PictureBoxSizeMode)4);
		Go2().set_TabIndex(631);
		Go2().set_TabStop(false);
		((Control)Md7()).set_Location(new Point(110, 121));
		((Control)Md7()).set_Name("PictureBox5");
		((Control)Md7()).set_Size(new Size(10, 10));
		Md7().set_SizeMode((PictureBoxSizeMode)4);
		Md7().set_TabIndex(630);
		Md7().set_TabStop(false);
		((Control)f4S()).set_Location(new Point(94, 121));
		((Control)f4S()).set_Name("PictureBox4");
		((Control)f4S()).set_Size(new Size(10, 10));
		f4S().set_SizeMode((PictureBoxSizeMode)4);
		f4S().set_TabIndex(629);
		f4S().set_TabStop(false);
		((Control)k0Y()).set_Location(new Point(78, 121));
		((Control)k0Y()).set_Name("PictureBox3");
		((Control)k0Y()).set_Size(new Size(10, 10));
		k0Y().set_SizeMode((PictureBoxSizeMode)4);
		k0Y().set_TabIndex(628);
		k0Y().set_TabStop(false);
		((Control)Jr7()).set_Location(new Point(62, 121));
		((Control)Jr7()).set_Name("PictureBox2");
		((Control)Jr7()).set_Size(new Size(10, 10));
		Jr7().set_SizeMode((PictureBoxSizeMode)4);
		Jr7().set_TabIndex(627);
		Jr7().set_TabStop(false);
		((Control)k0T()).set_Location(new Point(48, 121));
		((Control)k0T()).set_Name("PictureBox1");
		((Control)k0T()).set_Size(new Size(10, 10));
		k0T().set_SizeMode((PictureBoxSizeMode)4);
		k0T().set_TabIndex(626);
		k0T().set_TabStop(false);
		((Control)k2F()).set_Location(new Point(352, 362));
		((Control)k2F()).set_Name("PictureBox142");
		((Control)k2F()).set_Size(new Size(10, 12));
		k2F().set_SizeMode((PictureBoxSizeMode)4);
		k2F().set_TabIndex(784);
		k2F().set_TabStop(false);
		((Control)Pg9()).set_Location(new Point(333, 362));
		((Control)Pg9()).set_Name("PictureBox143");
		((Control)Pg9()).set_Size(new Size(10, 12));
		Pg9().set_SizeMode((PictureBoxSizeMode)4);
		Pg9().set_TabIndex(783);
		Pg9().set_TabStop(false);
		((Control)k9K()).set_Location(new Point(314, 362));
		((Control)k9K()).set_Name("PictureBox144");
		((Control)k9K()).set_Size(new Size(10, 12));
		k9K().set_SizeMode((PictureBoxSizeMode)4);
		k9K().set_TabIndex(782);
		k9K().set_TabStop(false);
		((Control)Pq9()).set_Location(new Point(296, 362));
		((Control)Pq9()).set_Name("PictureBox145");
		((Control)Pq9()).set_Size(new Size(10, 12));
		Pq9().set_SizeMode((PictureBoxSizeMode)4);
		Pq9().set_TabIndex(781);
		Pq9().set_TabStop(false);
		((Control)k0W()).set_Location(new Point(279, 362));
		((Control)k0W()).set_Name("PictureBox146");
		((Control)k0W()).set_Size(new Size(10, 12));
		k0W().set_SizeMode((PictureBoxSizeMode)4);
		k0W().set_TabIndex(780);
		k0W().set_TabStop(false);
		((Control)a5F()).set_Location(new Point(261, 362));
		((Control)a5F()).set_Name("PictureBox147");
		((Control)a5F()).set_Size(new Size(10, 12));
		a5F().set_SizeMode((PictureBoxSizeMode)4);
		a5F().set_TabIndex(779);
		a5F().set_TabStop(false);
		((Control)Nj7()).set_Location(new Point(245, 362));
		((Control)Nj7()).set_Name("PictureBox148");
		((Control)Nj7()).set_Size(new Size(10, 12));
		Nj7().set_SizeMode((PictureBoxSizeMode)4);
		Nj7().set_TabIndex(778);
		Nj7().set_TabStop(false);
		((Control)b0X()).set_Location(new Point(227, 362));
		((Control)b0X()).set_Name("PictureBox149");
		((Control)b0X()).set_Size(new Size(10, 12));
		b0X().set_SizeMode((PictureBoxSizeMode)4);
		b0X().set_TabIndex(777);
		b0X().set_TabStop(false);
		((Control)r8W()).set_Location(new Point(208, 362));
		((Control)r8W()).set_Name("PictureBox150");
		((Control)r8W()).set_Size(new Size(10, 12));
		r8W().set_SizeMode((PictureBoxSizeMode)4);
		r8W().set_TabIndex(776);
		r8W().set_TabStop(false);
		((Control)Pt3()).set_Location(new Point(190, 362));
		((Control)Pt3()).set_Name("PictureBox151");
		((Control)Pt3()).set_Size(new Size(10, 12));
		Pt3().set_SizeMode((PictureBoxSizeMode)4);
		Pt3().set_TabIndex(775);
		Pt3().set_TabStop(false);
		((Control)b0S()).set_Location(new Point(174, 362));
		((Control)b0S()).set_Name("PictureBox152");
		((Control)b0S()).set_Size(new Size(10, 12));
		b0S().set_SizeMode((PictureBoxSizeMode)4);
		b0S().set_TabIndex(774);
		b0S().set_TabStop(false);
		((Control)Sg3()).set_Location(new Point(158, 362));
		((Control)Sg3()).set_Name("PictureBox153");
		((Control)Sg3()).set_Size(new Size(10, 12));
		Sg3().set_SizeMode((PictureBoxSizeMode)4);
		Sg3().set_TabIndex(773);
		Sg3().set_TabStop(false);
		((Control)Zg0()).set_Location(new Point(142, 362));
		((Control)Zg0()).set_Name("PictureBox154");
		((Control)Zg0()).set_Size(new Size(10, 12));
		Zg0().set_SizeMode((PictureBoxSizeMode)4);
		Zg0().set_TabIndex(772);
		Zg0().set_TabStop(false);
		((Control)Ez2()).set_Location(new Point(126, 362));
		((Control)Ez2()).set_Name("PictureBox155");
		((Control)Ez2()).set_Size(new Size(10, 12));
		Ez2().set_SizeMode((PictureBoxSizeMode)4);
		Ez2().set_TabIndex(771);
		Ez2().set_TabStop(false);
		((Control)t6M()).set_Location(new Point(110, 362));
		((Control)t6M()).set_Name("PictureBox156");
		((Control)t6M()).set_Size(new Size(10, 12));
		t6M().set_SizeMode((PictureBoxSizeMode)4);
		t6M().set_TabIndex(770);
		t6M().set_TabStop(false);
		((Control)c0K()).set_Location(new Point(94, 362));
		((Control)c0K()).set_Name("PictureBox157");
		((Control)c0K()).set_Size(new Size(10, 12));
		c0K().set_SizeMode((PictureBoxSizeMode)4);
		c0K().set_TabIndex(769);
		c0K().set_TabStop(false);
		((Control)Pz4()).set_Location(new Point(78, 362));
		((Control)Pz4()).set_Name("PictureBox158");
		((Control)Pz4()).set_Size(new Size(10, 12));
		Pz4().set_SizeMode((PictureBoxSizeMode)4);
		Pz4().set_TabIndex(768);
		Pz4().set_TabStop(false);
		((Control)Aa1()).set_Location(new Point(62, 362));
		((Control)Aa1()).set_Name("PictureBox159");
		((Control)Aa1()).set_Size(new Size(10, 12));
		Aa1().set_SizeMode((PictureBoxSizeMode)4);
		Aa1().set_TabIndex(767);
		Aa1().set_TabStop(false);
		((Control)Pk8()).set_Location(new Point(48, 362));
		((Control)Pk8()).set_Name("PictureBox160");
		((Control)Pk8()).set_Size(new Size(10, 12));
		Pk8().set_SizeMode((PictureBoxSizeMode)4);
		Pk8().set_TabIndex(766);
		Pk8().set_TabStop(false);
		((Control)Hr8()).set_Location(new Point(372, 340));
		((Control)Hr8()).set_Name("PictureBox121");
		((Control)Hr8()).set_Size(new Size(10, 12));
		Hr8().set_SizeMode((PictureBoxSizeMode)4);
		Hr8().set_TabIndex(765);
		Hr8().set_TabStop(false);
		((Control)Qi3()).set_Location(new Point(352, 340));
		((Control)Qi3()).set_Name("PictureBox122");
		((Control)Qi3()).set_Size(new Size(10, 12));
		Qi3().set_SizeMode((PictureBoxSizeMode)4);
		Qi3().set_TabIndex(764);
		Qi3().set_TabStop(false);
		((Control)Cn3()).set_Location(new Point(333, 340));
		((Control)Cn3()).set_Name("PictureBox123");
		((Control)Cn3()).set_Size(new Size(10, 12));
		Cn3().set_SizeMode((PictureBoxSizeMode)4);
		Cn3().set_TabIndex(763);
		Cn3().set_TabStop(false);
		((Control)z2D()).set_Location(new Point(314, 340));
		((Control)z2D()).set_Name("PictureBox124");
		((Control)z2D()).set_Size(new Size(10, 12));
		z2D().set_SizeMode((PictureBoxSizeMode)4);
		z2D().set_TabIndex(762);
		z2D().set_TabStop(false);
		((Control)k4W()).set_Location(new Point(296, 340));
		((Control)k4W()).set_Name("PictureBox125");
		((Control)k4W()).set_Size(new Size(10, 12));
		k4W().set_SizeMode((PictureBoxSizeMode)4);
		k4W().set_TabIndex(761);
		k4W().set_TabStop(false);
		((Control)g8R()).set_Location(new Point(279, 340));
		((Control)g8R()).set_Name("PictureBox126");
		((Control)g8R()).set_Size(new Size(10, 12));
		g8R().set_SizeMode((PictureBoxSizeMode)4);
		g8R().set_TabIndex(760);
		g8R().set_TabStop(false);
		((Control)a7G()).set_Location(new Point(261, 340));
		((Control)a7G()).set_Name("PictureBox127");
		((Control)a7G()).set_Size(new Size(10, 12));
		a7G().set_SizeMode((PictureBoxSizeMode)4);
		a7G().set_TabIndex(759);
		a7G().set_TabStop(false);
		((Control)Nr8()).set_Location(new Point(245, 340));
		((Control)Nr8()).set_Name("PictureBox128");
		((Control)Nr8()).set_Size(new Size(10, 12));
		Nr8().set_SizeMode((PictureBoxSizeMode)4);
		Nr8().set_TabIndex(758);
		Nr8().set_TabStop(false);
		((Control)g1Y()).set_Location(new Point(227, 340));
		((Control)g1Y()).set_Name("PictureBox129");
		((Control)g1Y()).set_Size(new Size(10, 12));
		g1Y().set_SizeMode((PictureBoxSizeMode)4);
		g1Y().set_TabIndex(757);
		g1Y().set_TabStop(false);
		((Control)q1E()).set_Location(new Point(208, 340));
		((Control)q1E()).set_Name("PictureBox130");
		((Control)q1E()).set_Size(new Size(10, 12));
		q1E().set_SizeMode((PictureBoxSizeMode)4);
		q1E().set_TabIndex(756);
		q1E().set_TabStop(false);
		((Control)m5Q()).set_Location(new Point(190, 340));
		((Control)m5Q()).set_Name("PictureBox131");
		((Control)m5Q()).set_Size(new Size(10, 12));
		m5Q().set_SizeMode((PictureBoxSizeMode)4);
		m5Q().set_TabIndex(755);
		m5Q().set_TabStop(false);
		((Control)Ef6()).set_Location(new Point(174, 340));
		((Control)Ef6()).set_Name("PictureBox132");
		((Control)Ef6()).set_Size(new Size(10, 12));
		Ef6().set_SizeMode((PictureBoxSizeMode)4);
		Ef6().set_TabIndex(754);
		Ef6().set_TabStop(false);
		((Control)Tk2()).set_Location(new Point(158, 340));
		((Control)Tk2()).set_Name("PictureBox133");
		((Control)Tk2()).set_Size(new Size(10, 12));
		Tk2().set_SizeMode((PictureBoxSizeMode)4);
		Tk2().set_TabIndex(753);
		Tk2().set_TabStop(false);
		((Control)Wj2()).set_Location(new Point(142, 340));
		((Control)Wj2()).set_Name("PictureBox134");
		((Control)Wj2()).set_Size(new Size(10, 12));
		Wj2().set_SizeMode((PictureBoxSizeMode)4);
		Wj2().set_TabIndex(752);
		Wj2().set_TabStop(false);
		((Control)Mc2()).set_Location(new Point(126, 340));
		((Control)Mc2()).set_Name("PictureBox135");
		((Control)Mc2()).set_Size(new Size(10, 12));
		Mc2().set_SizeMode((PictureBoxSizeMode)4);
		Mc2().set_TabIndex(751);
		Mc2().set_TabStop(false);
		((Control)Xm7()).set_Location(new Point(110, 340));
		((Control)Xm7()).set_Name("PictureBox136");
		((Control)Xm7()).set_Size(new Size(10, 12));
		Xm7().set_SizeMode((PictureBoxSizeMode)4);
		Xm7().set_TabIndex(750);
		Xm7().set_TabStop(false);
		((Control)Nf0()).set_Location(new Point(94, 340));
		((Control)Nf0()).set_Name("PictureBox137");
		((Control)Nf0()).set_Size(new Size(10, 12));
		Nf0().set_SizeMode((PictureBoxSizeMode)4);
		Nf0().set_TabIndex(749);
		Nf0().set_TabStop(false);
		((Control)Yp1()).set_Location(new Point(78, 340));
		((Control)Yp1()).set_Name("PictureBox138");
		((Control)Yp1()).set_Size(new Size(10, 12));
		Yp1().set_SizeMode((PictureBoxSizeMode)4);
		Yp1().set_TabIndex(748);
		Yp1().set_TabStop(false);
		((Control)Mk7()).set_Location(new Point(62, 340));
		((Control)Mk7()).set_Name("PictureBox139");
		((Control)Mk7()).set_Size(new Size(10, 12));
		Mk7().set_SizeMode((PictureBoxSizeMode)4);
		Mk7().set_TabIndex(747);
		Mk7().set_TabStop(false);
		((Control)Ap7()).set_Location(new Point(48, 340));
		((Control)Ap7()).set_Name("PictureBox140");
		((Control)Ap7()).set_Size(new Size(10, 12));
		Ap7().set_SizeMode((PictureBoxSizeMode)4);
		Ap7().set_TabIndex(746);
		Ap7().set_TabStop(false);
		((Control)Jp6()).set_Location(new Point(372, 318));
		((Control)Jp6()).set_Name("PictureBox101");
		((Control)Jp6()).set_Size(new Size(10, 12));
		Jp6().set_SizeMode((PictureBoxSizeMode)4);
		Jp6().set_TabIndex(745);
		Jp6().set_TabStop(false);
		((Control)i4C()).set_Location(new Point(352, 318));
		((Control)i4C()).set_Name("PictureBox102");
		((Control)i4C()).set_Size(new Size(10, 12));
		i4C().set_SizeMode((PictureBoxSizeMode)4);
		i4C().set_TabIndex(744);
		i4C().set_TabStop(false);
		((Control)y7T()).set_Location(new Point(333, 318));
		((Control)y7T()).set_Name("PictureBox103");
		((Control)y7T()).set_Size(new Size(10, 12));
		y7T().set_SizeMode((PictureBoxSizeMode)4);
		y7T().set_TabIndex(743);
		y7T().set_TabStop(false);
		((Control)i0N()).set_Location(new Point(314, 318));
		((Control)i0N()).set_Name("PictureBox104");
		((Control)i0N()).set_Size(new Size(10, 12));
		i0N().set_SizeMode((PictureBoxSizeMode)4);
		i0N().set_TabIndex(742);
		i0N().set_TabStop(false);
		((Control)Hj9()).set_Location(new Point(296, 318));
		((Control)Hj9()).set_Name("PictureBox105");
		((Control)Hj9()).set_Size(new Size(10, 12));
		Hj9().set_SizeMode((PictureBoxSizeMode)4);
		Hj9().set_TabIndex(741);
		Hj9().set_TabStop(false);
		((Control)m9L()).set_Location(new Point(279, 318));
		((Control)m9L()).set_Name("PictureBox106");
		((Control)m9L()).set_Size(new Size(10, 12));
		m9L().set_SizeMode((PictureBoxSizeMode)4);
		m9L().set_TabIndex(740);
		m9L().set_TabStop(false);
		((Control)Gz0()).set_Location(new Point(261, 318));
		((Control)Gz0()).set_Name("PictureBox107");
		((Control)Gz0()).set_Size(new Size(10, 12));
		Gz0().set_SizeMode((PictureBoxSizeMode)4);
		Gz0().set_TabIndex(739);
		Gz0().set_TabStop(false);
		((Control)o0N()).set_Location(new Point(245, 318));
		((Control)o0N()).set_Name("PictureBox108");
		((Control)o0N()).set_Size(new Size(10, 12));
		o0N().set_SizeMode((PictureBoxSizeMode)4);
		o0N().set_TabIndex(738);
		o0N().set_TabStop(false);
		((Control)Ps7()).set_Location(new Point(227, 318));
		((Control)Ps7()).set_Name("PictureBox109");
		((Control)Ps7()).set_Size(new Size(10, 12));
		Ps7().set_SizeMode((PictureBoxSizeMode)4);
		Ps7().set_TabIndex(737);
		Ps7().set_TabStop(false);
		((Control)c9C()).set_Location(new Point(208, 318));
		((Control)c9C()).set_Name("PictureBox110");
		((Control)c9C()).set_Size(new Size(10, 12));
		c9C().set_SizeMode((PictureBoxSizeMode)4);
		c9C().set_TabIndex(736);
		c9C().set_TabStop(false);
		((Control)y3M()).set_Location(new Point(190, 318));
		((Control)y3M()).set_Name("PictureBox111");
		((Control)y3M()).set_Size(new Size(10, 12));
		y3M().set_SizeMode((PictureBoxSizeMode)4);
		y3M().set_TabIndex(735);
		y3M().set_TabStop(false);
		((Control)d9C()).set_Location(new Point(174, 318));
		((Control)d9C()).set_Name("PictureBox112");
		((Control)d9C()).set_Size(new Size(10, 12));
		d9C().set_SizeMode((PictureBoxSizeMode)4);
		d9C().set_TabIndex(734);
		d9C().set_TabStop(false);
		((Control)q0S()).set_Location(new Point(158, 318));
		((Control)q0S()).set_Name("PictureBox113");
		((Control)q0S()).set_Size(new Size(10, 12));
		q0S().set_SizeMode((PictureBoxSizeMode)4);
		q0S().set_TabIndex(733);
		q0S().set_TabStop(false);
		((Control)j0B()).set_Location(new Point(142, 318));
		((Control)j0B()).set_Name("PictureBox114");
		((Control)j0B()).set_Size(new Size(10, 12));
		j0B().set_SizeMode((PictureBoxSizeMode)4);
		j0B().set_TabIndex(732);
		j0B().set_TabStop(false);
		((Control)Wo5()).set_Location(new Point(126, 318));
		((Control)Wo5()).set_Name("PictureBox115");
		((Control)Wo5()).set_Size(new Size(10, 12));
		Wo5().set_SizeMode((PictureBoxSizeMode)4);
		Wo5().set_TabIndex(731);
		Wo5().set_TabStop(false);
		((Control)q4R()).set_Location(new Point(110, 318));
		((Control)q4R()).set_Name("PictureBox116");
		((Control)q4R()).set_Size(new Size(10, 12));
		q4R().set_SizeMode((PictureBoxSizeMode)4);
		q4R().set_TabIndex(730);
		q4R().set_TabStop(false);
		((Control)y0C()).set_Location(new Point(94, 318));
		((Control)y0C()).set_Name("PictureBox117");
		((Control)y0C()).set_Size(new Size(10, 12));
		y0C().set_SizeMode((PictureBoxSizeMode)4);
		y0C().set_TabIndex(729);
		y0C().set_TabStop(false);
		((Control)this.Me0()).set_Location(new Point(78, 318));
		((Control)this.Me0()).set_Name("PictureBox118");
		((Control)this.Me0()).set_Size(new Size(10, 12));
		this.Me0().set_SizeMode((PictureBoxSizeMode)4);
		this.Me0().set_TabIndex(728);
		this.Me0().set_TabStop(false);
		((Control)a1P()).set_Location(new Point(62, 318));
		((Control)a1P()).set_Name("PictureBox119");
		((Control)a1P()).set_Size(new Size(10, 12));
		a1P().set_SizeMode((PictureBoxSizeMode)4);
		a1P().set_TabIndex(727);
		a1P().set_TabStop(false);
		((Control)m3R()).set_Location(new Point(48, 318));
		((Control)m3R()).set_Name("PictureBox120");
		((Control)m3R()).set_Size(new Size(10, 12));
		m3R().set_SizeMode((PictureBoxSizeMode)4);
		m3R().set_TabIndex(726);
		m3R().set_TabStop(false);
		((Control)m6B()).set_Location(new Point(372, 299));
		((Control)m6B()).set_Name("PictureBox81");
		((Control)m6B()).set_Size(new Size(10, 12));
		m6B().set_SizeMode((PictureBoxSizeMode)4);
		m6B().set_TabIndex(725);
		m6B().set_TabStop(false);
		((Control)this.a8R()).set_Location(new Point(352, 299));
		((Control)this.a8R()).set_Name("PictureBox82");
		((Control)this.a8R()).set_Size(new Size(10, 12));
		this.a8R().set_SizeMode((PictureBoxSizeMode)4);
		this.a8R().set_TabIndex(724);
		this.a8R().set_TabStop(false);
		((Control)x2H()).set_Location(new Point(333, 299));
		((Control)x2H()).set_Name("PictureBox83");
		((Control)x2H()).set_Size(new Size(10, 12));
		x2H().set_SizeMode((PictureBoxSizeMode)4);
		x2H().set_TabIndex(723);
		x2H().set_TabStop(false);
		((Control)Ct4()).set_Location(new Point(314, 299));
		((Control)Ct4()).set_Name("PictureBox84");
		((Control)Ct4()).set_Size(new Size(10, 12));
		Ct4().set_SizeMode((PictureBoxSizeMode)4);
		Ct4().set_TabIndex(722);
		Ct4().set_TabStop(false);
		((Control)m9W()).set_Location(new Point(296, 299));
		((Control)m9W()).set_Name("PictureBox85");
		((Control)m9W()).set_Size(new Size(10, 12));
		m9W().set_SizeMode((PictureBoxSizeMode)4);
		m9W().set_TabIndex(721);
		m9W().set_TabStop(false);
		((Control)f6E()).set_Location(new Point(279, 299));
		((Control)f6E()).set_Name("PictureBox86");
		((Control)f6E()).set_Size(new Size(10, 12));
		f6E().set_SizeMode((PictureBoxSizeMode)4);
		f6E().set_TabIndex(720);
		f6E().set_TabStop(false);
		((Control)e8K()).set_Location(new Point(261, 299));
		((Control)e8K()).set_Name("PictureBox87");
		((Control)e8K()).set_Size(new Size(10, 12));
		e8K().set_SizeMode((PictureBoxSizeMode)4);
		e8K().set_TabIndex(719);
		e8K().set_TabStop(false);
		((Control)i2Q()).set_Location(new Point(245, 299));
		((Control)i2Q()).set_Name("PictureBox88");
		((Control)i2Q()).set_Size(new Size(10, 12));
		i2Q().set_SizeMode((PictureBoxSizeMode)4);
		i2Q().set_TabIndex(718);
		i2Q().set_TabStop(false);
		((Control)Wg2()).set_Location(new Point(227, 299));
		((Control)Wg2()).set_Name("PictureBox89");
		((Control)Wg2()).set_Size(new Size(10, 12));
		Wg2().set_SizeMode((PictureBoxSizeMode)4);
		Wg2().set_TabIndex(717);
		Wg2().set_TabStop(false);
		((Control)x2J()).set_Location(new Point(208, 299));
		((Control)x2J()).set_Name("PictureBox90");
		((Control)x2J()).set_Size(new Size(10, 12));
		x2J().set_SizeMode((PictureBoxSizeMode)4);
		x2J().set_TabIndex(716);
		x2J().set_TabStop(false);
		((Control)Hb4()).set_Location(new Point(190, 299));
		((Control)Hb4()).set_Name("PictureBox91");
		((Control)Hb4()).set_Size(new Size(10, 12));
		Hb4().set_SizeMode((PictureBoxSizeMode)4);
		Hb4().set_TabIndex(715);
		Hb4().set_TabStop(false);
		((Control)Qm4()).set_Location(new Point(174, 299));
		((Control)Qm4()).set_Name("PictureBox92");
		((Control)Qm4()).set_Size(new Size(10, 12));
		Qm4().set_SizeMode((PictureBoxSizeMode)4);
		Qm4().set_TabIndex(714);
		Qm4().set_TabStop(false);
		((Control)p2T()).set_Location(new Point(158, 299));
		((Control)p2T()).set_Name("PictureBox93");
		((Control)p2T()).set_Size(new Size(10, 12));
		p2T().set_SizeMode((PictureBoxSizeMode)4);
		p2T().set_TabIndex(713);
		p2T().set_TabStop(false);
		((Control)Mi4()).set_Location(new Point(142, 299));
		((Control)Mi4()).set_Name("PictureBox94");
		((Control)Mi4()).set_Size(new Size(10, 12));
		Mi4().set_SizeMode((PictureBoxSizeMode)4);
		Mi4().set_TabIndex(712);
		Mi4().set_TabStop(false);
		((Control)De1()).set_Location(new Point(126, 299));
		((Control)De1()).set_Name("PictureBox95");
		((Control)De1()).set_Size(new Size(10, 12));
		De1().set_SizeMode((PictureBoxSizeMode)4);
		De1().set_TabIndex(711);
		De1().set_TabStop(false);
		((Control)o1K()).set_Location(new Point(110, 299));
		((Control)o1K()).set_Name("PictureBox96");
		((Control)o1K()).set_Size(new Size(10, 12));
		o1K().set_SizeMode((PictureBoxSizeMode)4);
		o1K().set_TabIndex(710);
		o1K().set_TabStop(false);
		((Control)p9J()).set_Location(new Point(94, 299));
		((Control)p9J()).set_Name("PictureBox97");
		((Control)p9J()).set_Size(new Size(10, 12));
		p9J().set_SizeMode((PictureBoxSizeMode)4);
		p9J().set_TabIndex(709);
		p9J().set_TabStop(false);
		((Control)g4M()).set_Location(new Point(78, 299));
		((Control)g4M()).set_Name("PictureBox98");
		((Control)g4M()).set_Size(new Size(10, 12));
		g4M().set_SizeMode((PictureBoxSizeMode)4);
		g4M().set_TabIndex(708);
		g4M().set_TabStop(false);
		((Control)c1P()).set_Location(new Point(62, 299));
		((Control)c1P()).set_Name("PictureBox99");
		((Control)c1P()).set_Size(new Size(10, 12));
		c1P().set_SizeMode((PictureBoxSizeMode)4);
		c1P().set_TabIndex(707);
		c1P().set_TabStop(false);
		((Control)f4D()).set_Location(new Point(48, 299));
		((Control)f4D()).set_Name("PictureBox100");
		((Control)f4D()).set_Size(new Size(10, 12));
		f4D().set_SizeMode((PictureBoxSizeMode)4);
		f4D().set_TabIndex(706);
		f4D().set_TabStop(false);
		((Control)Kc4()).get_Controls().Add((Control)(object)Qe8());
		((Control)Kc4()).get_Controls().Add((Control)(object)Ek6());
		((Control)Kc4()).get_Controls().Add((Control)(object)x8H());
		((Control)Kc4()).get_Controls().Add((Control)(object)k6Y());
		((Control)Kc4()).get_Controls().Add((Control)(object)p6F());
		((Control)Kc4()).get_Controls().Add((Control)(object)Ca2());
		((Control)Kc4()).get_Controls().Add((Control)(object)p8Q());
		((Control)Kc4()).get_Controls().Add((Control)(object)c2A());
		((Control)Kc4()).get_Controls().Add((Control)(object)k6P());
		((Control)Kc4()).get_Controls().Add((Control)(object)Cz8());
		((Control)Kc4()).set_ForeColor(SystemColors.ControlLight);
		((Control)Kc4()).set_Location(new Point(689, 188));
		((Control)Kc4()).set_Name("GroupBox4");
		((Control)Kc4()).set_Size(new Size(211, 231));
		((Control)Kc4()).set_TabIndex(786);
		Kc4().set_TabStop(false);
		Kc4().set_Text("Billing INFO");
		((ButtonBase)Qe8()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Qe8()).set_FlatStyle((FlatStyle)0);
		((Control)Qe8()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Qe8()).set_Location(new Point(72, 184));
		((Control)Qe8()).set_Name("btnSave");
		((Control)Qe8()).set_Size(new Size(133, 23));
		((Control)Qe8()).set_TabIndex(40);
		((ButtonBase)Qe8()).set_Text("Save / Receipt Preview");
		((ButtonBase)Qe8()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Ek6()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ek6()).set_FlatStyle((FlatStyle)0);
		((Control)Ek6()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ek6()).set_Location(new Point(103, 155));
		((Control)Ek6()).set_Name("btnCalculateChange");
		((Control)Ek6()).set_Size(new Size(101, 23));
		((Control)Ek6()).set_TabIndex(39);
		((ButtonBase)Ek6()).set_Text("Calculate Change");
		((ButtonBase)Ek6()).set_UseVisualStyleBackColor(true);
		((Control)x8H()).set_Location(new Point(95, 123));
		((Control)x8H()).set_Name("txtChange");
		((Control)x8H()).set_Size(new Size(110, 20));
		((Control)x8H()).set_TabIndex(34);
		((Control)k6Y()).set_Location(new Point(95, 91));
		((Control)k6Y()).set_Name("txtTotalPayment");
		((Control)k6Y()).set_Size(new Size(110, 20));
		((Control)k6Y()).set_TabIndex(33);
		((Control)p6F()).set_Location(new Point(96, 58));
		((Control)p6F()).set_Name("txtTotalCost");
		((Control)p6F()).set_Size(new Size(109, 20));
		((Control)p6F()).set_TabIndex(32);
		((Control)Ca2()).set_Location(new Point(122, 24));
		((Control)Ca2()).set_Name("txtSeats");
		((Control)Ca2()).set_Size(new Size(83, 20));
		((Control)Ca2()).set_TabIndex(31);
		p8Q().set_AutoSize(true);
		((Control)p8Q()).set_BackColor(Color.Transparent);
		((Control)p8Q()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)p8Q()).set_Location(new Point(8, 62));
		((Control)p8Q()).set_Name("Label63");
		((Control)p8Q()).set_Size(new Size(66, 13));
		((Control)p8Q()).set_TabIndex(16);
		p8Q().set_Text("Total Costs :");
		c2A().set_AutoSize(true);
		((Control)c2A()).set_BackColor(Color.Transparent);
		((Control)c2A()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)c2A()).set_Location(new Point(8, 27));
		((Control)c2A()).set_Name("Label64");
		((Control)c2A()).set_Size(new Size(106, 13));
		((Control)c2A()).set_TabIndex(15);
		c2A().set_Text("Seats to be booked :");
		k6P().set_AutoSize(true);
		((Control)k6P()).set_BackColor(Color.Transparent);
		((Control)k6P()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)k6P()).set_Location(new Point(8, 121));
		((Control)k6P()).set_Name("Label61");
		((Control)k6P()).set_Size(new Size(50, 13));
		((Control)k6P()).set_TabIndex(14);
		k6P().set_Text("Change :");
		Cz8().set_AutoSize(true);
		((Control)Cz8()).set_BackColor(Color.Transparent);
		((Control)Cz8()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Cz8()).set_Location(new Point(8, 91));
		((Control)Cz8()).set_Name("Label62");
		((Control)Cz8()).set_Size(new Size(81, 13));
		((Control)Cz8()).set_TabIndex(13);
		Cz8().set_Text("Total Payment :");
		((Control)Ro1()).get_Controls().Add((Control)(object)Hs0());
		((Control)Ro1()).get_Controls().Add((Control)(object)g7P());
		((Control)Ro1()).get_Controls().Add((Control)(object)Bi3());
		((Control)Ro1()).get_Controls().Add((Control)(object)Ta9());
		((Control)Ro1()).get_Controls().Add((Control)(object)Mz9());
		((Control)Ro1()).get_Controls().Add((Control)(object)this.t7A());
		((Control)Ro1()).get_Controls().Add((Control)(object)z3D());
		((Control)Ro1()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ro1()).set_Location(new Point(700, 49));
		((Control)Ro1()).set_Name("GroupBox2");
		((Control)Ro1()).set_Size(new Size(200, 129));
		((Control)Ro1()).set_TabIndex(785);
		Ro1().set_TabStop(false);
		Ro1().set_Text("Customer");
		((ButtonBase)Hs0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Hs0()).set_FlatStyle((FlatStyle)0);
		((Control)Hs0()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Hs0()).set_Location(new Point(70, 90));
		((Control)Hs0()).set_Name("btnNew");
		((Control)Hs0()).set_Size(new Size(54, 23));
		((Control)Hs0()).set_TabIndex(39);
		((ButtonBase)Hs0()).set_Text("New");
		((ButtonBase)Hs0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)g7P()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)g7P()).set_FlatStyle((FlatStyle)0);
		((Control)g7P()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)g7P()).set_Location(new Point(130, 90));
		((Control)g7P()).set_Name("btnReset");
		((Control)g7P()).set_Size(new Size(54, 23));
		((Control)g7P()).set_TabIndex(38);
		((ButtonBase)g7P()).set_Text("Reset");
		((ButtonBase)g7P()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Bi3()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Bi3()).set_FlatStyle((FlatStyle)0);
		((Control)Bi3()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Bi3()).set_Location(new Point(10, 90));
		((Control)Bi3()).set_Name("btnExisting");
		((Control)Bi3()).set_Size(new Size(54, 23));
		((Control)Bi3()).set_TabIndex(37);
		((ButtonBase)Bi3()).set_Text("Existing");
		((ButtonBase)Bi3()).set_UseVisualStyleBackColor(true);
		((Control)Ta9()).set_Location(new Point(94, 57));
		((Control)Ta9()).set_Name("txtFirstName");
		((Control)Ta9()).set_Size(new Size(103, 20));
		((Control)Ta9()).set_TabIndex(30);
		((Control)Mz9()).set_Location(new Point(94, 31));
		((Control)Mz9()).set_Name("txtID");
		((Control)Mz9()).set_Size(new Size(103, 20));
		((Control)Mz9()).set_TabIndex(29);
		this.t7A().set_AutoSize(true);
		((Control)this.t7A()).set_BackColor(Color.Transparent);
		((Control)this.t7A()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)this.t7A()).set_Location(new Point(6, 58));
		((Control)this.t7A()).set_Name("Label60");
		((Control)this.t7A()).set_Size(new Size(57, 13));
		((Control)this.t7A()).set_TabIndex(12);
		this.t7A().set_Text("First Name");
		z3D().set_AutoSize(true);
		((Control)z3D()).set_BackColor(Color.Transparent);
		((Control)z3D()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)z3D()).set_Location(new Point(6, 34));
		((Control)z3D()).set_Name("Label59");
		((Control)z3D()).set_Size(new Size(65, 13));
		((Control)z3D()).set_TabIndex(11);
		z3D().set_Text("Customer ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)Kc4());
		((Control)this).get_Controls().Add((Control)(object)Ro1());
		((Control)this).get_Controls().Add((Control)(object)k2F());
		((Control)this).get_Controls().Add((Control)(object)Pg9());
		((Control)this).get_Controls().Add((Control)(object)k9K());
		((Control)this).get_Controls().Add((Control)(object)Pq9());
		((Control)this).get_Controls().Add((Control)(object)k0W());
		((Control)this).get_Controls().Add((Control)(object)a5F());
		((Control)this).get_Controls().Add((Control)(object)Nj7());
		((Control)this).get_Controls().Add((Control)(object)b0X());
		((Control)this).get_Controls().Add((Control)(object)r8W());
		((Control)this).get_Controls().Add((Control)(object)Pt3());
		((Control)this).get_Controls().Add((Control)(object)b0S());
		((Control)this).get_Controls().Add((Control)(object)Sg3());
		((Control)this).get_Controls().Add((Control)(object)Zg0());
		((Control)this).get_Controls().Add((Control)(object)Ez2());
		((Control)this).get_Controls().Add((Control)(object)t6M());
		((Control)this).get_Controls().Add((Control)(object)c0K());
		((Control)this).get_Controls().Add((Control)(object)Pz4());
		((Control)this).get_Controls().Add((Control)(object)Aa1());
		((Control)this).get_Controls().Add((Control)(object)Pk8());
		((Control)this).get_Controls().Add((Control)(object)Hr8());
		((Control)this).get_Controls().Add((Control)(object)Qi3());
		((Control)this).get_Controls().Add((Control)(object)Cn3());
		((Control)this).get_Controls().Add((Control)(object)z2D());
		((Control)this).get_Controls().Add((Control)(object)k4W());
		((Control)this).get_Controls().Add((Control)(object)g8R());
		((Control)this).get_Controls().Add((Control)(object)a7G());
		((Control)this).get_Controls().Add((Control)(object)Nr8());
		((Control)this).get_Controls().Add((Control)(object)g1Y());
		((Control)this).get_Controls().Add((Control)(object)q1E());
		((Control)this).get_Controls().Add((Control)(object)m5Q());
		((Control)this).get_Controls().Add((Control)(object)Ef6());
		((Control)this).get_Controls().Add((Control)(object)Tk2());
		((Control)this).get_Controls().Add((Control)(object)Wj2());
		((Control)this).get_Controls().Add((Control)(object)Mc2());
		((Control)this).get_Controls().Add((Control)(object)Xm7());
		((Control)this).get_Controls().Add((Control)(object)Nf0());
		((Control)this).get_Controls().Add((Control)(object)Yp1());
		((Control)this).get_Controls().Add((Control)(object)Mk7());
		((Control)this).get_Controls().Add((Control)(object)Ap7());
		((Control)this).get_Controls().Add((Control)(object)Jp6());
		((Control)this).get_Controls().Add((Control)(object)i4C());
		((Control)this).get_Controls().Add((Control)(object)y7T());
		((Control)this).get_Controls().Add((Control)(object)i0N());
		((Control)this).get_Controls().Add((Control)(object)Hj9());
		((Control)this).get_Controls().Add((Control)(object)m9L());
		((Control)this).get_Controls().Add((Control)(object)Gz0());
		((Control)this).get_Controls().Add((Control)(object)o0N());
		((Control)this).get_Controls().Add((Control)(object)Ps7());
		((Control)this).get_Controls().Add((Control)(object)c9C());
		((Control)this).get_Controls().Add((Control)(object)y3M());
		((Control)this).get_Controls().Add((Control)(object)d9C());
		((Control)this).get_Controls().Add((Control)(object)q0S());
		((Control)this).get_Controls().Add((Control)(object)j0B());
		((Control)this).get_Controls().Add((Control)(object)Wo5());
		((Control)this).get_Controls().Add((Control)(object)q4R());
		((Control)this).get_Controls().Add((Control)(object)y0C());
		((Control)this).get_Controls().Add((Control)(object)this.Me0());
		((Control)this).get_Controls().Add((Control)(object)a1P());
		((Control)this).get_Controls().Add((Control)(object)m3R());
		((Control)this).get_Controls().Add((Control)(object)m6B());
		((Control)this).get_Controls().Add((Control)(object)this.a8R());
		((Control)this).get_Controls().Add((Control)(object)x2H());
		((Control)this).get_Controls().Add((Control)(object)Ct4());
		((Control)this).get_Controls().Add((Control)(object)m9W());
		((Control)this).get_Controls().Add((Control)(object)f6E());
		((Control)this).get_Controls().Add((Control)(object)e8K());
		((Control)this).get_Controls().Add((Control)(object)i2Q());
		((Control)this).get_Controls().Add((Control)(object)Wg2());
		((Control)this).get_Controls().Add((Control)(object)x2J());
		((Control)this).get_Controls().Add((Control)(object)Hb4());
		((Control)this).get_Controls().Add((Control)(object)Qm4());
		((Control)this).get_Controls().Add((Control)(object)p2T());
		((Control)this).get_Controls().Add((Control)(object)Mi4());
		((Control)this).get_Controls().Add((Control)(object)De1());
		((Control)this).get_Controls().Add((Control)(object)o1K());
		((Control)this).get_Controls().Add((Control)(object)p9J());
		((Control)this).get_Controls().Add((Control)(object)g4M());
		((Control)this).get_Controls().Add((Control)(object)c1P());
		((Control)this).get_Controls().Add((Control)(object)f4D());
		((Control)this).get_Controls().Add((Control)(object)Ri6());
		((Control)this).get_Controls().Add((Control)(object)r3W());
		((Control)this).get_Controls().Add((Control)(object)Rq5());
		((Control)this).get_Controls().Add((Control)(object)z2P());
		((Control)this).get_Controls().Add((Control)(object)Tg1());
		((Control)this).get_Controls().Add((Control)(object)Gs2());
		((Control)this).get_Controls().Add((Control)(object)Xx0());
		((Control)this).get_Controls().Add((Control)(object)Wt5());
		((Control)this).get_Controls().Add((Control)(object)b9J());
		((Control)this).get_Controls().Add((Control)(object)c6T());
		((Control)this).get_Controls().Add((Control)(object)Qj6());
		((Control)this).get_Controls().Add((Control)(object)k6C());
		((Control)this).get_Controls().Add((Control)(object)Ba0());
		((Control)this).get_Controls().Add((Control)(object)Fp6());
		((Control)this).get_Controls().Add((Control)(object)b4B());
		((Control)this).get_Controls().Add((Control)(object)r4X());
		((Control)this).get_Controls().Add((Control)(object)Ba1());
		((Control)this).get_Controls().Add((Control)(object)w1M());
		((Control)this).get_Controls().Add((Control)(object)k1X());
		((Control)this).get_Controls().Add((Control)(object)q2Y());
		((Control)this).get_Controls().Add((Control)(object)Tc9());
		((Control)this).get_Controls().Add((Control)(object)Wz2());
		((Control)this).get_Controls().Add((Control)(object)Qd2());
		((Control)this).get_Controls().Add((Control)(object)Ac4());
		((Control)this).get_Controls().Add((Control)(object)s0T());
		((Control)this).get_Controls().Add((Control)(object)f6M());
		((Control)this).get_Controls().Add((Control)(object)f2L());
		((Control)this).get_Controls().Add((Control)(object)Bf9());
		((Control)this).get_Controls().Add((Control)(object)i1G());
		((Control)this).get_Controls().Add((Control)(object)f9R());
		((Control)this).get_Controls().Add((Control)(object)Pq4());
		((Control)this).get_Controls().Add((Control)(object)d4H());
		((Control)this).get_Controls().Add((Control)(object)Rj7());
		((Control)this).get_Controls().Add((Control)(object)Nr6());
		((Control)this).get_Controls().Add((Control)(object)k7H());
		((Control)this).get_Controls().Add((Control)(object)r5Z());
		((Control)this).get_Controls().Add((Control)(object)Nd5());
		((Control)this).get_Controls().Add((Control)(object)s5F());
		((Control)this).get_Controls().Add((Control)(object)Qn8());
		((Control)this).get_Controls().Add((Control)(object)Qd7());
		((Control)this).get_Controls().Add((Control)(object)At6());
		((Control)this).get_Controls().Add((Control)(object)Gw9());
		((Control)this).get_Controls().Add((Control)(object)Qc8());
		((Control)this).get_Controls().Add((Control)(object)Mw1());
		((Control)this).get_Controls().Add((Control)(object)Yp2());
		((Control)this).get_Controls().Add((Control)(object)Mb7());
		((Control)this).get_Controls().Add((Control)(object)c6L());
		((Control)this).get_Controls().Add((Control)(object)Nc1());
		((Control)this).get_Controls().Add((Control)(object)Gd9());
		((Control)this).get_Controls().Add((Control)(object)Ja2());
		((Control)this).get_Controls().Add((Control)(object)Bs0());
		((Control)this).get_Controls().Add((Control)(object)w1Y());
		((Control)this).get_Controls().Add((Control)(object)this.Me0());
		((Control)this).get_Controls().Add((Control)(object)g1X());
		((Control)this).get_Controls().Add((Control)(object)a6J());
		((Control)this).get_Controls().Add((Control)(object)e0Q());
		((Control)this).get_Controls().Add((Control)(object)this.t7A());
		((Control)this).get_Controls().Add((Control)(object)Zr9());
		((Control)this).get_Controls().Add((Control)(object)Ra2());
		((Control)this).get_Controls().Add((Control)(object)Qk4());
		((Control)this).get_Controls().Add((Control)(object)d3A());
		((Control)this).get_Controls().Add((Control)(object)e3C());
		((Control)this).get_Controls().Add((Control)(object)Sw8());
		((Control)this).get_Controls().Add((Control)(object)q0Y());
		((Control)this).get_Controls().Add((Control)(object)Qi1());
		((Control)this).get_Controls().Add((Control)(object)s0S());
		((Control)this).get_Controls().Add((Control)(object)Ne6());
		((Control)this).get_Controls().Add((Control)(object)b5Z());
		((Control)this).get_Controls().Add((Control)(object)j5T());
		((Control)this).get_Controls().Add((Control)(object)Si2());
		((Control)this).get_Controls().Add((Control)(object)Ng5());
		((Control)this).get_Controls().Add((Control)(object)this.a8R());
		((Control)this).get_Controls().Add((Control)(object)Di9());
		((Control)this).get_Controls().Add((Control)(object)Wz4());
		((Control)this).get_Controls().Add((Control)(object)Go2());
		((Control)this).get_Controls().Add((Control)(object)Md7());
		((Control)this).get_Controls().Add((Control)(object)f4S());
		((Control)this).get_Controls().Add((Control)(object)k0Y());
		((Control)this).get_Controls().Add((Control)(object)Jr7());
		((Control)this).get_Controls().Add((Control)(object)k0T());
		((Control)this).get_Controls().Add((Control)(object)Xe9());
		((Control)this).get_Controls().Add((Control)(object)k7R());
		((Control)this).get_Controls().Add((Control)(object)r7C());
		((Control)this).get_Controls().Add((Control)(object)c0C());
		((Control)this).get_Controls().Add((Control)(object)Ff3());
		((Control)this).get_Controls().Add((Control)(object)r0W());
		((Control)this).get_Controls().Add((Control)(object)Rd4());
		((Control)this).get_Controls().Add((Control)(object)Jr6());
		((Control)this).get_Controls().Add((Control)(object)j3B());
		((Control)this).get_Controls().Add((Control)(object)this.Ag0());
		((Control)this).get_Controls().Add((Control)(object)d6C());
		((Control)this).get_Controls().Add((Control)(object)this.Ey7());
		((Control)this).get_Controls().Add((Control)(object)Pi3());
		((Control)this).get_Controls().Add((Control)(object)Sy9());
		((Control)this).get_Controls().Add((Control)(object)o5H());
		((Control)this).get_Controls().Add((Control)(object)this.Ag0());
		((Control)this).get_Controls().Add((Control)(object)Xc6());
		((Control)this).get_Controls().Add((Control)(object)Px8());
		((Control)this).get_Controls().Add((Control)(object)Qz8());
		((Control)this).get_Controls().Add((Control)(object)Ts8());
		((Control)this).get_Controls().Add((Control)(object)n5K());
		((Control)this).get_Controls().Add((Control)(object)m3G());
		((Control)this).get_Controls().Add((Control)(object)Qz7());
		((Control)this).get_Controls().Add((Control)(object)i6N());
		((Control)this).get_Controls().Add((Control)(object)Tg9());
		((Control)this).get_Controls().Add((Control)(object)z7C());
		((Control)this).get_Controls().Add((Control)(object)z8Q());
		((Control)this).get_Controls().Add((Control)(object)Cm5());
		((Control)this).get_Controls().Add((Control)(object)Qt9());
		((Control)this).get_Controls().Add((Control)(object)As3());
		((Control)this).get_Controls().Add((Control)(object)x3P());
		((Control)this).get_Controls().Add((Control)(object)t1K());
		((Control)this).get_Controls().Add((Control)(object)Zb7());
		((Control)this).get_Controls().Add((Control)(object)z0A());
		((Control)this).get_Controls().Add((Control)(object)o5K());
		((Control)this).get_Controls().Add((Control)(object)Jy9());
		((Control)this).get_Controls().Add((Control)(object)s0D());
		((Control)this).get_Controls().Add((Control)(object)Wg7());
		((Control)this).get_Controls().Add((Control)(object)Dk3());
		((Control)this).get_Controls().Add((Control)(object)Nn0());
		((Control)this).get_Controls().Add((Control)(object)Es2());
		((Control)this).get_Controls().Add((Control)(object)g7J());
		((Control)this).get_Controls().Add((Control)(object)Jn7());
		((Control)this).get_Controls().Add((Control)(object)Rp8());
		((Control)this).get_Controls().Add((Control)(object)p7B());
		((Control)this).get_Controls().Add((Control)(object)Lg6());
		((Control)this).get_Controls().Add((Control)(object)k1G());
		((Control)this).get_Controls().Add((Control)(object)d4X());
		((Control)this).get_Controls().Add((Control)(object)Jw8());
		((Control)this).get_Controls().Add((Control)(object)Nj2());
		((Control)this).get_Controls().Add((Control)(object)this.Ey7());
		((Control)this).get_Controls().Add((Control)(object)q3J());
		((Control)this).get_Controls().Add((Control)(object)Ao1());
		((Control)this).get_Controls().Add((Control)(object)e6A());
		((Control)this).get_Controls().Add((Control)(object)d8G());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 2");
		((ISupportInitialize)Wa1()).EndInit();
		((ISupportInitialize)a0F()).EndInit();
		((ISupportInitialize)Gb5()).EndInit();
		((ISupportInitialize)Nr0()).EndInit();
		((Control)this.Ey7()).ResumeLayout(false);
		((Control)q3J()).ResumeLayout(false);
		((Control)q3J()).PerformLayout();
		((ISupportInitialize)e6A()).EndInit();
		((ISupportInitialize)d8G()).EndInit();
		((ISupportInitialize)Ri6()).EndInit();
		((ISupportInitialize)r3W()).EndInit();
		((ISupportInitialize)Rq5()).EndInit();
		((ISupportInitialize)z2P()).EndInit();
		((ISupportInitialize)Tg1()).EndInit();
		((ISupportInitialize)Gs2()).EndInit();
		((ISupportInitialize)Xx0()).EndInit();
		((ISupportInitialize)Wt5()).EndInit();
		((ISupportInitialize)b9J()).EndInit();
		((ISupportInitialize)c6T()).EndInit();
		((ISupportInitialize)Qj6()).EndInit();
		((ISupportInitialize)k6C()).EndInit();
		((ISupportInitialize)Ba0()).EndInit();
		((ISupportInitialize)Fp6()).EndInit();
		((ISupportInitialize)b4B()).EndInit();
		((ISupportInitialize)r4X()).EndInit();
		((ISupportInitialize)Ba1()).EndInit();
		((ISupportInitialize)w1M()).EndInit();
		((ISupportInitialize)k1X()).EndInit();
		((ISupportInitialize)q2Y()).EndInit();
		((ISupportInitialize)Tc9()).EndInit();
		((ISupportInitialize)Wz2()).EndInit();
		((ISupportInitialize)Qd2()).EndInit();
		((ISupportInitialize)Ac4()).EndInit();
		((ISupportInitialize)s0T()).EndInit();
		((ISupportInitialize)f6M()).EndInit();
		((ISupportInitialize)f2L()).EndInit();
		((ISupportInitialize)Bf9()).EndInit();
		((ISupportInitialize)i1G()).EndInit();
		((ISupportInitialize)f9R()).EndInit();
		((ISupportInitialize)Pq4()).EndInit();
		((ISupportInitialize)d4H()).EndInit();
		((ISupportInitialize)Rj7()).EndInit();
		((ISupportInitialize)Nr6()).EndInit();
		((ISupportInitialize)k7H()).EndInit();
		((ISupportInitialize)r5Z()).EndInit();
		((ISupportInitialize)Nd5()).EndInit();
		((ISupportInitialize)s5F()).EndInit();
		((ISupportInitialize)Qn8()).EndInit();
		((ISupportInitialize)Qd7()).EndInit();
		((ISupportInitialize)At6()).EndInit();
		((ISupportInitialize)Gw9()).EndInit();
		((ISupportInitialize)Qc8()).EndInit();
		((ISupportInitialize)Mw1()).EndInit();
		((ISupportInitialize)Yp2()).EndInit();
		((ISupportInitialize)Mb7()).EndInit();
		((ISupportInitialize)c6L()).EndInit();
		((ISupportInitialize)Nc1()).EndInit();
		((ISupportInitialize)Gd9()).EndInit();
		((ISupportInitialize)Ja2()).EndInit();
		((ISupportInitialize)Bs0()).EndInit();
		((ISupportInitialize)w1Y()).EndInit();
		((ISupportInitialize)this.Me0()).EndInit();
		((ISupportInitialize)g1X()).EndInit();
		((ISupportInitialize)a6J()).EndInit();
		((ISupportInitialize)e0Q()).EndInit();
		((ISupportInitialize)this.t7A()).EndInit();
		((ISupportInitialize)Zr9()).EndInit();
		((ISupportInitialize)Ra2()).EndInit();
		((ISupportInitialize)Qk4()).EndInit();
		((ISupportInitialize)d3A()).EndInit();
		((ISupportInitialize)e3C()).EndInit();
		((ISupportInitialize)Sw8()).EndInit();
		((ISupportInitialize)q0Y()).EndInit();
		((ISupportInitialize)Qi1()).EndInit();
		((ISupportInitialize)s0S()).EndInit();
		((ISupportInitialize)Ne6()).EndInit();
		((ISupportInitialize)b5Z()).EndInit();
		((ISupportInitialize)j5T()).EndInit();
		((ISupportInitialize)Si2()).EndInit();
		((ISupportInitialize)Ng5()).EndInit();
		((ISupportInitialize)this.a8R()).EndInit();
		((ISupportInitialize)Di9()).EndInit();
		((ISupportInitialize)Wz4()).EndInit();
		((ISupportInitialize)Go2()).EndInit();
		((ISupportInitialize)Md7()).EndInit();
		((ISupportInitialize)f4S()).EndInit();
		((ISupportInitialize)k0Y()).EndInit();
		((ISupportInitialize)Jr7()).EndInit();
		((ISupportInitialize)k0T()).EndInit();
		((ISupportInitialize)k2F()).EndInit();
		((ISupportInitialize)Pg9()).EndInit();
		((ISupportInitialize)k9K()).EndInit();
		((ISupportInitialize)Pq9()).EndInit();
		((ISupportInitialize)k0W()).EndInit();
		((ISupportInitialize)a5F()).EndInit();
		((ISupportInitialize)Nj7()).EndInit();
		((ISupportInitialize)b0X()).EndInit();
		((ISupportInitialize)r8W()).EndInit();
		((ISupportInitialize)Pt3()).EndInit();
		((ISupportInitialize)b0S()).EndInit();
		((ISupportInitialize)Sg3()).EndInit();
		((ISupportInitialize)Zg0()).EndInit();
		((ISupportInitialize)Ez2()).EndInit();
		((ISupportInitialize)t6M()).EndInit();
		((ISupportInitialize)c0K()).EndInit();
		((ISupportInitialize)Pz4()).EndInit();
		((ISupportInitialize)Aa1()).EndInit();
		((ISupportInitialize)Pk8()).EndInit();
		((ISupportInitialize)Hr8()).EndInit();
		((ISupportInitialize)Qi3()).EndInit();
		((ISupportInitialize)Cn3()).EndInit();
		((ISupportInitialize)z2D()).EndInit();
		((ISupportInitialize)k4W()).EndInit();
		((ISupportInitialize)g8R()).EndInit();
		((ISupportInitialize)a7G()).EndInit();
		((ISupportInitialize)Nr8()).EndInit();
		((ISupportInitialize)g1Y()).EndInit();
		((ISupportInitialize)q1E()).EndInit();
		((ISupportInitialize)m5Q()).EndInit();
		((ISupportInitialize)Ef6()).EndInit();
		((ISupportInitialize)Tk2()).EndInit();
		((ISupportInitialize)Wj2()).EndInit();
		((ISupportInitialize)Mc2()).EndInit();
		((ISupportInitialize)Xm7()).EndInit();
		((ISupportInitialize)Nf0()).EndInit();
		((ISupportInitialize)Yp1()).EndInit();
		((ISupportInitialize)Mk7()).EndInit();
		((ISupportInitialize)Ap7()).EndInit();
		((ISupportInitialize)Jp6()).EndInit();
		((ISupportInitialize)i4C()).EndInit();
		((ISupportInitialize)y7T()).EndInit();
		((ISupportInitialize)i0N()).EndInit();
		((ISupportInitialize)Hj9()).EndInit();
		((ISupportInitialize)m9L()).EndInit();
		((ISupportInitialize)Gz0()).EndInit();
		((ISupportInitialize)o0N()).EndInit();
		((ISupportInitialize)Ps7()).EndInit();
		((ISupportInitialize)c9C()).EndInit();
		((ISupportInitialize)y3M()).EndInit();
		((ISupportInitialize)d9C()).EndInit();
		((ISupportInitialize)q0S()).EndInit();
		((ISupportInitialize)j0B()).EndInit();
		((ISupportInitialize)Wo5()).EndInit();
		((ISupportInitialize)q4R()).EndInit();
		((ISupportInitialize)y0C()).EndInit();
		((ISupportInitialize)this.Me0()).EndInit();
		((ISupportInitialize)a1P()).EndInit();
		((ISupportInitialize)m3R()).EndInit();
		((ISupportInitialize)m6B()).EndInit();
		((ISupportInitialize)this.a8R()).EndInit();
		((ISupportInitialize)x2H()).EndInit();
		((ISupportInitialize)Ct4()).EndInit();
		((ISupportInitialize)m9W()).EndInit();
		((ISupportInitialize)f6E()).EndInit();
		((ISupportInitialize)e8K()).EndInit();
		((ISupportInitialize)i2Q()).EndInit();
		((ISupportInitialize)Wg2()).EndInit();
		((ISupportInitialize)x2J()).EndInit();
		((ISupportInitialize)Hb4()).EndInit();
		((ISupportInitialize)Qm4()).EndInit();
		((ISupportInitialize)p2T()).EndInit();
		((ISupportInitialize)Mi4()).EndInit();
		((ISupportInitialize)De1()).EndInit();
		((ISupportInitialize)o1K()).EndInit();
		((ISupportInitialize)p9J()).EndInit();
		((ISupportInitialize)g4M()).EndInit();
		((ISupportInitialize)c1P()).EndInit();
		((ISupportInitialize)f4D()).EndInit();
		((Control)Kc4()).ResumeLayout(false);
		((Control)Kc4()).PerformLayout();
		((Control)Ro1()).ResumeLayout(false);
		((Control)Ro1()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Xe9()
	{
		return _Label32;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1J(Label w5P)
	{
		_Label32 = w5P;
	}

	[SpecialName]
	internal virtual Label k7R()
	{
		return _Label33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0D(Label x5A)
	{
		_Label33 = x5A;
	}

	[SpecialName]
	internal virtual Label r7C()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6P(Label Ei4)
	{
		Label val = (v = Ei4);
	}

	[SpecialName]
	internal virtual Label c0C()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9G(Label k2X)
	{
		Label val = (k = k2X);
	}

	[SpecialName]
	internal virtual Label Ff3()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4C(Label Mi8)
	{
		Label val = (c = Mi8);
	}

	[SpecialName]
	internal virtual Label r0W()
	{
		return _Label37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt0(Label g5K)
	{
		_Label37 = g5K;
	}

	[SpecialName]
	internal virtual Label Rd4()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dn9(Label Nj7)
	{
		Label val = (r = Nj7);
	}

	[SpecialName]
	internal virtual Label Jr6()
	{
		return _Label39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7Z(Label n0S)
	{
		_Label39 = n0S;
	}

	[SpecialName]
	internal virtual Label j3B()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5L(Label Dg4)
	{
		_Label40 = Dg4;
	}

	[SpecialName]
	internal virtual Label Ag0()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hg0(Label Qt0)
	{
		Label val = (a = Qt0);
	}

	[SpecialName]
	internal virtual Label d6C()
	{
		return _Label42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3D(Label Xs6)
	{
		_Label42 = Xs6;
	}

	[SpecialName]
	internal virtual Label Ey7()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi3(Label b7W)
	{
		Label val = (f = b7W);
	}

	[SpecialName]
	internal virtual Label Pi3()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2K(Label k7J)
	{
		Label val = (L = k7J);
	}

	[SpecialName]
	internal virtual Label Sy9()
	{
		return _Label45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0A(Label f5X)
	{
		_Label45 = f5X;
	}

	[SpecialName]
	internal virtual Label o5H()
	{
		return _Label46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6L(Label Xi8)
	{
		_Label46 = Xi8;
	}

	[SpecialName]
	internal virtual Label Ag0()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm7(Label Mx1)
	{
		Label val = (q = Mx1);
	}

	[SpecialName]
	internal virtual Label Xc6()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ew9(Label x0Z)
	{
		Label val = (w = x0Z);
	}

	[SpecialName]
	internal virtual TextBox Am6()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1Q(TextBox w6F)
	{
		TextBox val = (b = w6F);
	}

	[SpecialName]
	internal virtual TextBox Ap2()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6M(TextBox e2F)
	{
		TextBox val = (u = e2F);
	}

	[SpecialName]
	internal virtual PictureBox Wa1()
	{
		return _Booked;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ds8(PictureBox Bw3)
	{
		_Booked = Bw3;
	}

	[SpecialName]
	internal virtual PictureBox a0F()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fp9(PictureBox Bd5)
	{
		PictureBox val = (i = Bd5);
	}

	[SpecialName]
	internal virtual PictureBox Gb5()
	{
		return _Available;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s8S(PictureBox m0X)
	{
		_Available = m0X;
	}

	[SpecialName]
	internal virtual Label Mw7()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg8(Label b9R)
	{
		Label val = (n = b9R);
	}

	[SpecialName]
	internal virtual Label Mc6()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc1(Label k4H)
	{
		_Label1 = k4H;
	}

	[SpecialName]
	internal virtual Label Rn6()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qy3(Label Zd0)
	{
		_Label2 = Zd0;
	}

	[SpecialName]
	internal virtual PictureBox Nr0()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pi5(PictureBox Xa2)
	{
		_Cover = Xa2;
	}

	[SpecialName]
	internal virtual Label Px8()
	{
		return _Label49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2D(Label r3T)
	{
		_Label49 = r3T;
	}

	[SpecialName]
	internal virtual TextBox k9L()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yk7(TextBox m2Y)
	{
		_txtProvisional = m2Y;
	}

	[SpecialName]
	internal virtual Label Qz8()
	{
		return _Label50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4H(Label Cw4)
	{
		_Label50 = Cw4;
	}

	[SpecialName]
	internal virtual Label Ts8()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn8(Label i2J)
	{
		Label val = (e = i2J);
	}

	[SpecialName]
	internal virtual Label n5K()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9N(Label e2A)
	{
		Label val = (h = e2A);
	}

	[SpecialName]
	internal virtual Label m3G()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1A(Label o0E)
	{
		_Label55 = o0E;
	}

	[SpecialName]
	internal virtual Label Qz7()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3G(Label e1A)
	{
		Label val = (o = e1A);
	}

	[SpecialName]
	internal virtual Label i6N()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3B(Label Tp9)
	{
		Label val = (y = Tp9);
	}

	[SpecialName]
	internal virtual Label Tg9()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5E(Label Bn3)
	{
		Label val = (p = Bn3);
	}

	[SpecialName]
	internal virtual Label z7C()
	{
		return _Label27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5Q(Label Ms0)
	{
		_Label27 = Ms0;
	}

	[SpecialName]
	internal virtual Label z8Q()
	{
		return _Label28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rg3(Label t0H)
	{
		_Label28 = t0H;
	}

	[SpecialName]
	internal virtual Label Cm5()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ny6(Label z9H)
	{
		Label val = (X = z9H);
	}

	[SpecialName]
	internal virtual Label Qt9()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0R(Label k1P)
	{
		Label val = (S = k1P);
	}

	[SpecialName]
	internal virtual Label As3()
	{
		return _Label25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1T(Label b2F)
	{
		_Label25 = b2F;
	}

	[SpecialName]
	internal virtual Label x3P()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2B(Label Fi9)
	{
		Label val = (T = Fi9);
	}

	[SpecialName]
	internal virtual Label t1K()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dk6(Label q5F)
	{
		Label val = (j = q5F);
	}

	[SpecialName]
	internal virtual Label Zb7()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cx2(Label o6F)
	{
		Label val = (g = o6F);
	}

	[SpecialName]
	internal virtual Label z0A()
	{
		return _Label21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ea4(Label t8D)
	{
		_Label21 = t8D;
	}

	[SpecialName]
	internal virtual Label o5K()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wb1(Label z0H)
	{
		Label val = (M = z0H);
	}

	[SpecialName]
	internal virtual Label Jy9()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9H(Label Ba1)
	{
		_Label19 = Ba1;
	}

	[SpecialName]
	internal virtual Label s0D()
	{
		return _Label18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo9(Label i6G)
	{
		_Label18 = i6G;
	}

	[SpecialName]
	internal virtual Label Wg7()
	{
		return _Label17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jd2(Label Bd7)
	{
		_Label17 = Bd7;
	}

	[SpecialName]
	internal virtual Label Dk3()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gg6(Label Sc4)
	{
		_Label16 = Sc4;
	}

	[SpecialName]
	internal virtual Label Nn0()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3G(Label p7X)
	{
		_Label15 = p7X;
	}

	[SpecialName]
	internal virtual Label Es2()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nc5(Label c4Z)
	{
		Label val = (z = c4Z);
	}

	[SpecialName]
	internal virtual Label g7J()
	{
		return vD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8G(Label o6A)
	{
		Label val = (vD = o6A);
	}

	[SpecialName]
	internal virtual Label Jn7()
	{
		return _Label12;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i9Z(Label x7L)
	{
		_Label12 = x7L;
	}

	[SpecialName]
	internal virtual Label Rp8()
	{
		return _Label11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8Y(Label Mm5)
	{
		_Label11 = Mm5;
	}

	[SpecialName]
	internal virtual Label p7B()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo2(Label w0Y)
	{
		_Label10 = w0Y;
	}

	[SpecialName]
	internal virtual Label Lg6()
	{
		return vv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Do9(Label Bs3)
	{
		Label val = (vv = Bs3);
	}

	[SpecialName]
	internal virtual Label k1G()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zj7(Label Td6)
	{
		_Label8 = Td6;
	}

	[SpecialName]
	internal virtual Label d4X()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt9(Label q8N)
	{
		_Label7 = q8N;
	}

	[SpecialName]
	internal virtual Label Jw8()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4S(Label i6C)
	{
		_Label5 = i6C;
	}

	[SpecialName]
	internal virtual Label Nj2()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qs2(Label Kz3)
	{
		_Label4 = Kz3;
	}

	[SpecialName]
	internal virtual GroupBox Ey7()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1A(GroupBox y4T)
	{
		_GroupBox3 = y4T;
	}

	[SpecialName]
	internal virtual GroupBox q3J()
	{
		return vk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wo8(GroupBox d0D)
	{
		GroupBox val = (vk = d0D);
	}

	[SpecialName]
	internal virtual Label Ao1()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8S(Label Gi0)
	{
		_Label6 = Gi0;
	}

	[SpecialName]
	internal virtual PictureBox e6A()
	{
		return vc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Py8(PictureBox Mx7)
	{
		PictureBox val = (vc = Mx7);
	}

	[SpecialName]
	internal virtual PictureBox d8G()
	{
		return _NameBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Do0(PictureBox Td5)
	{
		_NameBox = Td5;
	}

	[SpecialName]
	internal virtual PictureBox Ri6()
	{
		return vr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et7(PictureBox Gw9)
	{
		PictureBox val = (vr = Gw9);
	}

	[SpecialName]
	internal virtual PictureBox r3W()
	{
		return _PictureBox62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xy0(PictureBox Hf3)
	{
		_PictureBox62 = Hf3;
	}

	[SpecialName]
	internal virtual PictureBox Rq5()
	{
		return _PictureBox63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9G(PictureBox t4S)
	{
		_PictureBox63 = t4S;
	}

	[SpecialName]
	internal virtual PictureBox z2P()
	{
		return va;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mn5(PictureBox Bj6)
	{
		PictureBox val = (va = Bj6);
	}

	[SpecialName]
	internal virtual PictureBox Tg1()
	{
		return _PictureBox65;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kp7(PictureBox Ct4)
	{
		_PictureBox65 = Ct4;
	}

	[SpecialName]
	internal virtual PictureBox Gs2()
	{
		return vf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1S(PictureBox y2C)
	{
		PictureBox val = (vf = y2C);
	}

	[SpecialName]
	internal virtual PictureBox Xx0()
	{
		return _PictureBox67;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn3(PictureBox j5W)
	{
		_PictureBox67 = j5W;
	}

	[SpecialName]
	internal virtual PictureBox Wt5()
	{
		return vL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7Q(PictureBox o8Q)
	{
		PictureBox val = (vL = o8Q);
	}

	[SpecialName]
	internal virtual PictureBox b9J()
	{
		return _PictureBox69;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed3(PictureBox z2C)
	{
		_PictureBox69 = z2C;
	}

	[SpecialName]
	internal virtual PictureBox c6T()
	{
		return _PictureBox70;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz9(PictureBox As8)
	{
		_PictureBox70 = As8;
	}

	[SpecialName]
	internal virtual PictureBox Qj6()
	{
		return vq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sm6(PictureBox i3R)
	{
		PictureBox val = (vq = i3R);
	}

	[SpecialName]
	internal virtual PictureBox k6C()
	{
		return _PictureBox72;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7S(PictureBox t2K)
	{
		_PictureBox72 = t2K;
	}

	[SpecialName]
	internal virtual PictureBox Ba0()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Co6(PictureBox i5M)
	{
		_PictureBox73 = i5M;
	}

	[SpecialName]
	internal virtual PictureBox Fp6()
	{
		return vw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2L(PictureBox s8M)
	{
		PictureBox val = (vw = s8M);
	}

	[SpecialName]
	internal virtual PictureBox b4B()
	{
		return _PictureBox75;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw9(PictureBox s1T)
	{
		_PictureBox75 = s1T;
	}

	[SpecialName]
	internal virtual PictureBox r4X()
	{
		return _PictureBox76;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hg1(PictureBox Pa5)
	{
		_PictureBox76 = Pa5;
	}

	[SpecialName]
	internal virtual PictureBox Ba1()
	{
		return vb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo0(PictureBox Fj4)
	{
		PictureBox val = (vb = Fj4);
	}

	[SpecialName]
	internal virtual PictureBox w1M()
	{
		return vu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9F(PictureBox o8N)
	{
		PictureBox val = (vu = o8N);
	}

	[SpecialName]
	internal virtual PictureBox k1X()
	{
		return _PictureBox79;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fz0(PictureBox p6G)
	{
		_PictureBox79 = p6G;
	}

	[SpecialName]
	internal virtual PictureBox q2Y()
	{
		return _PictureBox80;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5C(PictureBox Kf2)
	{
		_PictureBox80 = Kf2;
	}

	[SpecialName]
	internal virtual PictureBox Tc9()
	{
		return _PictureBox41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s8K(PictureBox Po8)
	{
		_PictureBox41 = Po8;
	}

	[SpecialName]
	internal virtual PictureBox Wz2()
	{
		return vi;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wj9(PictureBox Sj3)
	{
		PictureBox val = (vi = Sj3);
	}

	[SpecialName]
	internal virtual PictureBox Qd2()
	{
		return _PictureBox43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xn1(PictureBox Yk4)
	{
		_PictureBox43 = Yk4;
	}

	[SpecialName]
	internal virtual PictureBox Ac4()
	{
		return _PictureBox44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7F(PictureBox x6A)
	{
		_PictureBox44 = x6A;
	}

	[SpecialName]
	internal virtual PictureBox s0T()
	{
		return vn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2X(PictureBox Dj2)
	{
		PictureBox val = (vn = Dj2);
	}

	[SpecialName]
	internal virtual PictureBox f6M()
	{
		return ve;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5T(PictureBox Tz4)
	{
		PictureBox val = (ve = Tz4);
	}

	[SpecialName]
	internal virtual PictureBox f2L()
	{
		return vh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pa8(PictureBox e5F)
	{
		PictureBox val = (vh = e5F);
	}

	[SpecialName]
	internal virtual PictureBox Bf9()
	{
		return _PictureBox48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ea6(PictureBox Pc9)
	{
		_PictureBox48 = Pc9;
	}

	[SpecialName]
	internal virtual PictureBox i1G()
	{
		return vo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t1Y(PictureBox Mf2)
	{
		PictureBox val = (vo = Mf2);
	}

	[SpecialName]
	internal virtual PictureBox f9R()
	{
		return _PictureBox50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nw0(PictureBox Wc3)
	{
		_PictureBox50 = Wc3;
	}

	[SpecialName]
	internal virtual PictureBox Pq4()
	{
		return _PictureBox51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c3A(PictureBox j6W)
	{
		_PictureBox51 = j6W;
	}

	[SpecialName]
	internal virtual PictureBox d4H()
	{
		return vy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5E(PictureBox Mq1)
	{
		PictureBox val = (vy = Mq1);
	}

	[SpecialName]
	internal virtual PictureBox Rj7()
	{
		return _PictureBox53;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8L(PictureBox w1A)
	{
		_PictureBox53 = w1A;
	}

	[SpecialName]
	internal virtual PictureBox Nr6()
	{
		return _PictureBox54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0H(PictureBox Ck4)
	{
		_PictureBox54 = Ck4;
	}

	[SpecialName]
	internal virtual PictureBox k7H()
	{
		return vp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At1(PictureBox Dq9)
	{
		PictureBox val = (vp = Dq9);
	}

	[SpecialName]
	internal virtual PictureBox r5Z()
	{
		return _PictureBox56;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z2K(PictureBox t5R)
	{
		_PictureBox56 = t5R;
	}

	[SpecialName]
	internal virtual PictureBox Nd5()
	{
		return vX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5Y(PictureBox Bs8)
	{
		PictureBox val = (vX = Bs8);
	}

	[SpecialName]
	internal virtual PictureBox s5F()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5R(PictureBox y0M)
	{
		_PictureBox58 = y0M;
	}

	[SpecialName]
	internal virtual PictureBox Qn8()
	{
		return vS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zz8(PictureBox e9E)
	{
		PictureBox val = (vS = e9E);
	}

	[SpecialName]
	internal virtual PictureBox Qd7()
	{
		return vT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6P(PictureBox Ne4)
	{
		PictureBox val = (vT = Ne4);
	}

	[SpecialName]
	internal virtual PictureBox At6()
	{
		return vj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm5(PictureBox Kr1)
	{
		PictureBox val = (vj = Kr1);
	}

	[SpecialName]
	internal virtual PictureBox Gw9()
	{
		return vg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4S(PictureBox f6B)
	{
		PictureBox val = (vg = f6B);
	}

	[SpecialName]
	internal virtual PictureBox Qc8()
	{
		return vM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1F(PictureBox n7P)
	{
		PictureBox val = (vM = n7P);
	}

	[SpecialName]
	internal virtual PictureBox Mw1()
	{
		return _PictureBox24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8J(PictureBox d5X)
	{
		_PictureBox24 = d5X;
	}

	[SpecialName]
	internal virtual PictureBox Yp2()
	{
		return vz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dr7(PictureBox Jc5)
	{
		PictureBox val = (vz = Jc5);
	}

	[SpecialName]
	internal virtual PictureBox Mb7()
	{
		return _PictureBox26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tp4(PictureBox m4N)
	{
		_PictureBox26 = m4N;
	}

	[SpecialName]
	internal virtual PictureBox c6L()
	{
		return _PictureBox27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp3(PictureBox p0F)
	{
		_PictureBox27 = p0F;
	}

	[SpecialName]
	internal virtual PictureBox Nc1()
	{
		return kD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7B(PictureBox r1K)
	{
		PictureBox val = (kD = r1K);
	}

	[SpecialName]
	internal virtual PictureBox Gd9()
	{
		return _PictureBox29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ag0(PictureBox Pt2)
	{
		_PictureBox29 = Pt2;
	}

	[SpecialName]
	internal virtual PictureBox Ja2()
	{
		return _PictureBox30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qj6(PictureBox p8Y)
	{
		_PictureBox30 = p8Y;
	}

	[SpecialName]
	internal virtual PictureBox Bs0()
	{
		return kv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw1(PictureBox t4E)
	{
		PictureBox val = (kv = t4E);
	}

	[SpecialName]
	internal virtual PictureBox w1Y()
	{
		return kk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5S(PictureBox f7X)
	{
		PictureBox val = (kk = f7X);
	}

	[SpecialName]
	internal virtual PictureBox Me0()
	{
		return kc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9S(PictureBox Po8)
	{
		PictureBox val = (kc = Po8);
	}

	[SpecialName]
	internal virtual PictureBox g1X()
	{
		return _PictureBox34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9A(PictureBox Px8)
	{
		_PictureBox34 = Px8;
	}

	[SpecialName]
	internal virtual PictureBox a6J()
	{
		return _PictureBox35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts5(PictureBox m8J)
	{
		_PictureBox35 = m8J;
	}

	[SpecialName]
	internal virtual PictureBox e0Q()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mw4(PictureBox Ld3)
	{
		_PictureBox36 = Ld3;
	}

	[SpecialName]
	internal virtual PictureBox t7A()
	{
		return kr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed6(PictureBox Fs2)
	{
		PictureBox val = (kr = Fs2);
	}

	[SpecialName]
	internal virtual PictureBox Zr9()
	{
		return _PictureBox38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4B(PictureBox Zk9)
	{
		_PictureBox38 = Zk9;
	}

	[SpecialName]
	internal virtual PictureBox Ra2()
	{
		return _PictureBox39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0W(PictureBox c9P)
	{
		_PictureBox39 = c9P;
	}

	[SpecialName]
	internal virtual PictureBox Qk4()
	{
		return ka;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5L(PictureBox e3K)
	{
		PictureBox val = (ka = e3K);
	}

	[SpecialName]
	internal virtual PictureBox d3A()
	{
		return kf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs7(PictureBox r8D)
	{
		PictureBox val = (kf = r8D);
	}

	[SpecialName]
	internal virtual PictureBox e3C()
	{
		return kL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt7(PictureBox d7Q)
	{
		PictureBox val = (kL = d7Q);
	}

	[SpecialName]
	internal virtual PictureBox Sw8()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rb6(PictureBox Zd2)
	{
		_PictureBox18 = Zd2;
	}

	[SpecialName]
	internal virtual PictureBox q0Y()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm6(PictureBox a8N)
	{
		_PictureBox17 = a8N;
	}

	[SpecialName]
	internal virtual PictureBox Qi1()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0B(PictureBox q9J)
	{
		_PictureBox16 = q9J;
	}

	[SpecialName]
	internal virtual PictureBox s0S()
	{
		return kq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2H(PictureBox Rk0)
	{
		PictureBox val = (kq = Rk0);
	}

	[SpecialName]
	internal virtual PictureBox Ne6()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7J(PictureBox d1Z)
	{
		_PictureBox14 = d1Z;
	}

	[SpecialName]
	internal virtual PictureBox b5Z()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq0(PictureBox Eo4)
	{
		_PictureBox13 = Eo4;
	}

	[SpecialName]
	internal virtual PictureBox j5T()
	{
		return kw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Js8(PictureBox Br0)
	{
		PictureBox val = (kw = Br0);
	}

	[SpecialName]
	internal virtual PictureBox Si2()
	{
		return kb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2C(PictureBox j2Q)
	{
		PictureBox val = (kb = j2Q);
	}

	[SpecialName]
	internal virtual PictureBox Ng5()
	{
		return _PictureBox10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gd5(PictureBox p7E)
	{
		_PictureBox10 = p7E;
	}

	[SpecialName]
	internal virtual PictureBox a8R()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kp4(PictureBox s7P)
	{
		_PictureBox9 = s7P;
	}

	[SpecialName]
	internal virtual PictureBox Di9()
	{
		return ku;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8Y(PictureBox Fr6)
	{
		PictureBox val = (ku = Fr6);
	}

	[SpecialName]
	internal virtual PictureBox Wz4()
	{
		return ki;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5X(PictureBox y1R)
	{
		PictureBox val = (ki = y1R);
	}

	[SpecialName]
	internal virtual PictureBox Go2()
	{
		return kn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs7(PictureBox Li4)
	{
		PictureBox val = (kn = Li4);
	}

	[SpecialName]
	internal virtual PictureBox Md7()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1P(PictureBox Qr5)
	{
		_PictureBox5 = Qr5;
	}

	[SpecialName]
	internal virtual PictureBox f4S()
	{
		return ke;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs1(PictureBox Ft3)
	{
		PictureBox val = (ke = Ft3);
	}

	[SpecialName]
	internal virtual PictureBox k0Y()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hf3(PictureBox m5W)
	{
		_PictureBox3 = m5W;
	}

	[SpecialName]
	internal virtual PictureBox Jr7()
	{
		return kh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7T(PictureBox Xs5)
	{
		PictureBox val = (kh = Xs5);
	}

	[SpecialName]
	internal virtual PictureBox k0T()
	{
		return ko;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xg7(PictureBox w4K)
	{
		PictureBox val = (ko = w4K);
	}

	[SpecialName]
	internal virtual PictureBox k2F()
	{
		return ky;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0S(PictureBox Ef6)
	{
		PictureBox val = (ky = Ef6);
	}

	[SpecialName]
	internal virtual PictureBox Pg9()
	{
		return kp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2L(PictureBox z4G)
	{
		PictureBox val = (kp = z4G);
	}

	[SpecialName]
	internal virtual PictureBox k9K()
	{
		return _PictureBox144;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf3(PictureBox b8H)
	{
		_PictureBox144 = b8H;
	}

	[SpecialName]
	internal virtual PictureBox Pq9()
	{
		return _PictureBox145;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1H(PictureBox Yo5)
	{
		_PictureBox145 = Yo5;
	}

	[SpecialName]
	internal virtual PictureBox k0W()
	{
		return kX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5B(PictureBox t2L)
	{
		PictureBox val = (kX = t2L);
	}

	[SpecialName]
	internal virtual PictureBox a5F()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8Z(PictureBox b5N)
	{
		_PictureBox147 = b5N;
	}

	[SpecialName]
	internal virtual PictureBox Nj7()
	{
		return _PictureBox148;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln8(PictureBox y6A)
	{
		_PictureBox148 = y6A;
	}

	[SpecialName]
	internal virtual PictureBox b0X()
	{
		return _PictureBox149;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6P(PictureBox Eo7)
	{
		_PictureBox149 = Eo7;
	}

	[SpecialName]
	internal virtual PictureBox r8W()
	{
		return _PictureBox150;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6H(PictureBox Gi7)
	{
		_PictureBox150 = Gi7;
	}

	[SpecialName]
	internal virtual PictureBox Pt3()
	{
		return kS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tx8(PictureBox g5Q)
	{
		PictureBox val = (kS = g5Q);
	}

	[SpecialName]
	internal virtual PictureBox b0S()
	{
		return _PictureBox152;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn9(PictureBox Pn8)
	{
		_PictureBox152 = Pn8;
	}

	[SpecialName]
	internal virtual PictureBox Sg3()
	{
		return kT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7G(PictureBox Ms0)
	{
		PictureBox val = (kT = Ms0);
	}

	[SpecialName]
	internal virtual PictureBox Zg0()
	{
		return _PictureBox154;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jr6(PictureBox Zd7)
	{
		_PictureBox154 = Zd7;
	}

	[SpecialName]
	internal virtual PictureBox Ez2()
	{
		return _PictureBox155;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0P(PictureBox q7Q)
	{
		_PictureBox155 = q7Q;
	}

	[SpecialName]
	internal virtual PictureBox t6M()
	{
		return kj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3K(PictureBox Cb5)
	{
		PictureBox val = (kj = Cb5);
	}

	[SpecialName]
	internal virtual PictureBox c0K()
	{
		return kg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So3(PictureBox Zg7)
	{
		PictureBox val = (kg = Zg7);
	}

	[SpecialName]
	internal virtual PictureBox Pz4()
	{
		return _PictureBox158;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6B(PictureBox i8P)
	{
		_PictureBox158 = i8P;
	}

	[SpecialName]
	internal virtual PictureBox Aa1()
	{
		return kM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qi4(PictureBox o9S)
	{
		PictureBox val = (kM = o9S);
	}

	[SpecialName]
	internal virtual PictureBox Pk8()
	{
		return _PictureBox160;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2Z(PictureBox Hc0)
	{
		_PictureBox160 = Hc0;
	}

	[SpecialName]
	internal virtual PictureBox Hr8()
	{
		return kz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3H(PictureBox o2J)
	{
		PictureBox val = (kz = o2J);
	}

	[SpecialName]
	internal virtual PictureBox Qi3()
	{
		return _PictureBox122;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln5(PictureBox b6M)
	{
		_PictureBox122 = b6M;
	}

	[SpecialName]
	internal virtual PictureBox Cn3()
	{
		return cD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk3(PictureBox t5L)
	{
		PictureBox val = (cD = t5L);
	}

	[SpecialName]
	internal virtual PictureBox z2D()
	{
		return _PictureBox124;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8H(PictureBox Yg5)
	{
		_PictureBox124 = Yg5;
	}

	[SpecialName]
	internal virtual PictureBox k4W()
	{
		return _PictureBox125;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo5(PictureBox g6B)
	{
		_PictureBox125 = g6B;
	}

	[SpecialName]
	internal virtual PictureBox g8R()
	{
		return cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6E(PictureBox Nb3)
	{
		PictureBox val = (cv = Nb3);
	}

	[SpecialName]
	internal virtual PictureBox a7G()
	{
		return ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7M(PictureBox r0Q)
	{
		PictureBox val = (ck = r0Q);
	}

	[SpecialName]
	internal virtual PictureBox Nr8()
	{
		return cc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9Y(PictureBox z5B)
	{
		PictureBox val = (cc = z5B);
	}

	[SpecialName]
	internal virtual PictureBox g1Y()
	{
		return _PictureBox129;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4S(PictureBox Wr3)
	{
		_PictureBox129 = Wr3;
	}

	[SpecialName]
	internal virtual PictureBox q1E()
	{
		return cr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9T(PictureBox Rz0)
	{
		PictureBox val = (cr = Rz0);
	}

	[SpecialName]
	internal virtual PictureBox m5Q()
	{
		return ca;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lk1(PictureBox Kx1)
	{
		PictureBox val = (ca = Kx1);
	}

	[SpecialName]
	internal virtual PictureBox Ef6()
	{
		return _PictureBox132;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5M(PictureBox Ci8)
	{
		_PictureBox132 = Ci8;
	}

	[SpecialName]
	internal virtual PictureBox Tk2()
	{
		return cf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hs5(PictureBox m2S)
	{
		PictureBox val = (cf = m2S);
	}

	[SpecialName]
	internal virtual PictureBox Wj2()
	{
		return _PictureBox134;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mw6(PictureBox Qd4)
	{
		_PictureBox134 = Qd4;
	}

	[SpecialName]
	internal virtual PictureBox Mc2()
	{
		return _PictureBox135;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void As2(PictureBox Dy7)
	{
		_PictureBox135 = Dy7;
	}

	[SpecialName]
	internal virtual PictureBox Xm7()
	{
		return _PictureBox136;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1Z(PictureBox a0Q)
	{
		_PictureBox136 = a0Q;
	}

	[SpecialName]
	internal virtual PictureBox Nf0()
	{
		return cL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0L(PictureBox g0F)
	{
		PictureBox val = (cL = g0F);
	}

	[SpecialName]
	internal virtual PictureBox Yp1()
	{
		return _PictureBox138;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xg6(PictureBox c7Q)
	{
		_PictureBox138 = c7Q;
	}

	[SpecialName]
	internal virtual PictureBox Mk7()
	{
		return cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1P(PictureBox f7G)
	{
		PictureBox val = (cq = f7G);
	}

	[SpecialName]
	internal virtual PictureBox Ap7()
	{
		return cw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lg2(PictureBox Ee0)
	{
		PictureBox val = (cw = Ee0);
	}

	[SpecialName]
	internal virtual PictureBox Jp6()
	{
		return cb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7W(PictureBox En2)
	{
		PictureBox val = (cb = En2);
	}

	[SpecialName]
	internal virtual PictureBox i4C()
	{
		return cu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2Q(PictureBox b8T)
	{
		PictureBox val = (cu = b8T);
	}

	[SpecialName]
	internal virtual PictureBox y7T()
	{
		return ci;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln6(PictureBox b2H)
	{
		PictureBox val = (ci = b2H);
	}

	[SpecialName]
	internal virtual PictureBox i0N()
	{
		return _PictureBox104;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9Z(PictureBox w0E)
	{
		_PictureBox104 = w0E;
	}

	[SpecialName]
	internal virtual PictureBox Hj9()
	{
		return cn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp6(PictureBox Ln2)
	{
		PictureBox val = (cn = Ln2);
	}

	[SpecialName]
	internal virtual PictureBox m9L()
	{
		return _PictureBox106;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5G(PictureBox q0H)
	{
		_PictureBox106 = q0H;
	}

	[SpecialName]
	internal virtual PictureBox Gz0()
	{
		return ce;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ds8(PictureBox Np4)
	{
		PictureBox val = (ce = Np4);
	}

	[SpecialName]
	internal virtual PictureBox o0N()
	{
		return ch;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6L(PictureBox Pi0)
	{
		PictureBox val = (ch = Pi0);
	}

	[SpecialName]
	internal virtual PictureBox Ps7()
	{
		return co;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7E(PictureBox Xq4)
	{
		PictureBox val = (co = Xq4);
	}

	[SpecialName]
	internal virtual PictureBox c9C()
	{
		return cy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ad4(PictureBox Pt2)
	{
		PictureBox val = (cy = Pt2);
	}

	[SpecialName]
	internal virtual PictureBox y3M()
	{
		return cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb8(PictureBox Fk2)
	{
		PictureBox val = (cp = Fk2);
	}

	[SpecialName]
	internal virtual PictureBox d9C()
	{
		return _PictureBox112;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps5(PictureBox z3G)
	{
		_PictureBox112 = z3G;
	}

	[SpecialName]
	internal virtual PictureBox q0S()
	{
		return _PictureBox113;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0R(PictureBox Ys9)
	{
		_PictureBox113 = Ys9;
	}

	[SpecialName]
	internal virtual PictureBox j0B()
	{
		return cX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void By4(PictureBox Ha6)
	{
		PictureBox val = (cX = Ha6);
	}

	[SpecialName]
	internal virtual PictureBox Wo5()
	{
		return cS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6X(PictureBox Yf8)
	{
		PictureBox val = (cS = Yf8);
	}

	[SpecialName]
	internal virtual PictureBox q4R()
	{
		return _PictureBox116;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5S(PictureBox p4H)
	{
		_PictureBox116 = p4H;
	}

	[SpecialName]
	internal virtual PictureBox y0C()
	{
		return cT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zf7(PictureBox d2F)
	{
		PictureBox val = (cT = d2F);
	}

	[SpecialName]
	internal virtual PictureBox Me0()
	{
		return cj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp0(PictureBox Ty2)
	{
		PictureBox val = (cj = Ty2);
	}

	[SpecialName]
	internal virtual PictureBox a1P()
	{
		return _PictureBox119;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2M(PictureBox i2S)
	{
		_PictureBox119 = i2S;
	}

	[SpecialName]
	internal virtual PictureBox m3R()
	{
		return cg;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8N(PictureBox j0W)
	{
		PictureBox val = (cg = j0W);
	}

	[SpecialName]
	internal virtual PictureBox m6B()
	{
		return cM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7B(PictureBox e3R)
	{
		PictureBox val = (cM = e3R);
	}

	[SpecialName]
	internal virtual PictureBox a8R()
	{
		return cz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8Z(PictureBox p9A)
	{
		PictureBox val = (cz = p9A);
	}

	[SpecialName]
	internal virtual PictureBox x2H()
	{
		return rD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4Z(PictureBox Lk7)
	{
		PictureBox val = (rD = Lk7);
	}

	[SpecialName]
	internal virtual PictureBox Ct4()
	{
		return _PictureBox84;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7Y(PictureBox Ec8)
	{
		_PictureBox84 = Ec8;
	}

	[SpecialName]
	internal virtual PictureBox m9W()
	{
		return _PictureBox85;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3R(PictureBox Wb2)
	{
		_PictureBox85 = Wb2;
	}

	[SpecialName]
	internal virtual PictureBox f6E()
	{
		return rv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2M(PictureBox Ly1)
	{
		PictureBox val = (rv = Ly1);
	}

	[SpecialName]
	internal virtual PictureBox e8K()
	{
		return rk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kp4(PictureBox q9X)
	{
		PictureBox val = (rk = q9X);
	}

	[SpecialName]
	internal virtual PictureBox i2Q()
	{
		return _PictureBox88;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j3Z(PictureBox z3P)
	{
		_PictureBox88 = z3P;
	}

	[SpecialName]
	internal virtual PictureBox Wg2()
	{
		return rc;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xi2(PictureBox c7K)
	{
		PictureBox val = (rc = c7K);
	}

	[SpecialName]
	internal virtual PictureBox x2J()
	{
		return _PictureBox90;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wk5(PictureBox Cg7)
	{
		_PictureBox90 = Cg7;
	}

	[SpecialName]
	internal virtual PictureBox Hb4()
	{
		return rr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Na1(PictureBox Hq3)
	{
		PictureBox val = (rr = Hq3);
	}

	[SpecialName]
	internal virtual PictureBox Qm4()
	{
		return _PictureBox92;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mq4(PictureBox m6X)
	{
		_PictureBox92 = m6X;
	}

	[SpecialName]
	internal virtual PictureBox p2T()
	{
		return _PictureBox93;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1R(PictureBox Qo9)
	{
		_PictureBox93 = Qo9;
	}

	[SpecialName]
	internal virtual PictureBox Mi4()
	{
		return _PictureBox94;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7C(PictureBox Ab1)
	{
		_PictureBox94 = Ab1;
	}

	[SpecialName]
	internal virtual PictureBox De1()
	{
		return ra;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5N(PictureBox z6N)
	{
		PictureBox val = (ra = z6N);
	}

	[SpecialName]
	internal virtual PictureBox o1K()
	{
		return _PictureBox96;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gs6(PictureBox c6R)
	{
		_PictureBox96 = c6R;
	}

	[SpecialName]
	internal virtual PictureBox p9J()
	{
		return _PictureBox97;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9E(PictureBox q4Z)
	{
		_PictureBox97 = q4Z;
	}

	[SpecialName]
	internal virtual PictureBox g4M()
	{
		return _PictureBox98;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb0(PictureBox Mr1)
	{
		_PictureBox98 = Mr1;
	}

	[SpecialName]
	internal virtual PictureBox c1P()
	{
		return rf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3G(PictureBox Ct4)
	{
		PictureBox val = (rf = Ct4);
	}

	[SpecialName]
	internal virtual PictureBox f4D()
	{
		return rL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7T(PictureBox j5R)
	{
		PictureBox val = (rL = j5R);
	}

	[SpecialName]
	internal virtual Button k6Q()
	{
		return _btnViewReservations;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bs4(Button x7G)
	{
		EventHandler eventHandler = d0K;
		Button btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).remove_Click(eventHandler);
		}
		_btnViewReservations = x7G;
		btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual GroupBox Kc4()
	{
		return rq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ck8(GroupBox w4Q)
	{
		GroupBox val = (rq = w4Q);
	}

	[SpecialName]
	internal virtual Button Qe8()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g0M(Button Ae9)
	{
		EventHandler eventHandler = x8T;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = Ae9;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ek6()
	{
		return _btnCalculateChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wq9(Button y3N)
	{
		EventHandler eventHandler = Jz2;
		Button btnCalculateChange = _btnCalculateChange;
		if (btnCalculateChange != null)
		{
			((Control)btnCalculateChange).remove_Click(eventHandler);
		}
		_btnCalculateChange = y3N;
		btnCalculateChange = _btnCalculateChange;
		if (btnCalculateChange != null)
		{
			((Control)btnCalculateChange).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox x8H()
	{
		return rw;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2Y(TextBox p3A)
	{
		TextBox val = (rw = p3A);
	}

	[SpecialName]
	internal virtual TextBox k6Y()
	{
		return _txtTotalPayment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sy5(TextBox z9J)
	{
		_txtTotalPayment = z9J;
	}

	[SpecialName]
	internal virtual TextBox p6F()
	{
		return rb;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd1(TextBox d4Q)
	{
		TextBox val = (rb = d4Q);
	}

	[SpecialName]
	internal virtual TextBox Ca2()
	{
		return ru;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q5K(TextBox r3S)
	{
		TextBox val = (ru = r3S);
	}

	[SpecialName]
	internal virtual Label p8Q()
	{
		return ri;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ya2(Label Yb7)
	{
		Label val = (ri = Yb7);
	}

	[SpecialName]
	internal virtual Label c2A()
	{
		return _Label64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hz0(Label s0J)
	{
		_Label64 = s0J;
	}

	[SpecialName]
	internal virtual Label k6P()
	{
		return _Label61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns5(Label k7D)
	{
		_Label61 = k7D;
	}

	[SpecialName]
	internal virtual Label Cz8()
	{
		return _Label62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4Q(Label k3B)
	{
		_Label62 = k3B;
	}

	[SpecialName]
	internal virtual GroupBox Ro1()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8M(GroupBox w2K)
	{
		_GroupBox2 = w2K;
	}

	[SpecialName]
	internal virtual Button Hs0()
	{
		return _btnNew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1B(Button Bs4)
	{
		EventHandler eventHandler = a6F;
		Button btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).remove_Click(eventHandler);
		}
		_btnNew = Bs4;
		btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button g7P()
	{
		return rn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sw6(Button n9W)
	{
		Button val = (rn = n9W);
	}

	[SpecialName]
	internal virtual Button Bi3()
	{
		return _btnExisting;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He1(Button r9J)
	{
		EventHandler eventHandler = d0D;
		Button btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).remove_Click(eventHandler);
		}
		_btnExisting = r9J;
		btnExisting = _btnExisting;
		if (btnExisting != null)
		{
			((Control)btnExisting).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ta9()
	{
		return re;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yi5(TextBox w1Q)
	{
		TextBox val = (re = w1Q);
	}

	[SpecialName]
	internal virtual TextBox Mz9()
	{
		return rh;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bx7(TextBox e5M)
	{
		TextBox val = (rh = e5M);
	}

	[SpecialName]
	internal virtual Label t7A()
	{
		return ro;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s1C(Label Ge9)
	{
		Label val = (ro = Ge9);
	}

	[SpecialName]
	internal virtual Label z3D()
	{
		return ry;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4A(Label Hc0)
	{
		Label val = (ry = Hc0);
	}

	private void x8T(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
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
				if (val != null && val.get_Image() == provisionalIcon)
				{
					int num = Conversions.ToInteger(Strings.Mid(((Control)val).get_Name(), 11));
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Mz9().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = Mz9().get_Text();
		firstName = Ta9().get_Text();
		val2.Close();
		q5F();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Jz2(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(k6Y().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			x8H().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)k6Y()).Clear();
		}
	}

	private void Py3(object sender, EventArgs e)
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
					((PictureBox)val).set_Image((Image)rp);
					val.add_Click((EventHandler)j5P);
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
		bookedSeats = 0;
		provisionalSeats = 0;
		q5F();
	}

	private void d0K(object sender, EventArgs e)
	{
	}

	private void d0D(object sender, EventArgs e)
	{
	}

	private void a6F(object sender, EventArgs e)
	{
	}

	internal static byte[] Gx4(int[] f6G, int e5D)
	{
		checked
		{
			byte[] array = new byte[e5D + 1];
			int num = f6G.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)f6G[i];
			}
			return array;
		}
	}

	public void q5F()
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
			availableSeats = 160 - bookedSeats;
			provisionalSeats = 0;
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
					((PictureBox)NewLateBinding.LateGet((object)((Control)this).get_Controls(), (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"PictureBox", dataRow[2]) }, (string[])null, (Type[])null, (bool[])null)).set_Image((Image)rX);
					bookedSeats++;
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
			Am6().set_Text(Conversions.ToString(bookedSeats));
			Ap2().set_Text(Conversions.ToString(availableSeats));
			k9L().set_Text(Conversions.ToString(provisionalSeats));
			Xg7();
		}
	}

	private void j5P(object sender, EventArgs e)
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
			if (((PictureBox)sender).get_Image() == rp)
			{
				((PictureBox)sender).set_Image((Image)provisionalIcon);
				provisionalSeats++;
				availableSeats--;
			}
			else if (((PictureBox)sender).get_Image() == provisionalIcon)
			{
				((PictureBox)sender).set_Image((Image)rp);
				provisionalSeats--;
				availableSeats++;
			}
			Ap2().set_Text(Conversions.ToString(availableSeats));
			k9L().set_Text(Conversions.ToString(provisionalSeats));
			seats = provisionalSeats;
			Ca2().set_Text(Conversions.ToString(seats));
			totalCost = provisionalSeats * 5;
			p6F().set_Text("$" + totalCost);
		}
	}

	public void Xg7()
	{
		((TextBoxBase)k6Y()).Clear();
		((TextBoxBase)Ta9()).Clear();
		((TextBoxBase)p6F()).Clear();
		((TextBoxBase)x8H()).Clear();
		((TextBoxBase)Ca2()).Clear();
		((TextBoxBase)Mz9()).Clear();
	}
}
