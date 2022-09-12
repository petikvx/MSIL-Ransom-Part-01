using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using En3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Ni0b;
using Rs7;
using f5S;
using i9M;

namespace j7T;

[DesignerGenerated]
public class n1F : Form
{
	private PictureBox _PictureBox143;

	private PictureBox _PictureBox146;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox149;

	private PictureBox _PictureBox152;

	private PictureBox _PictureBox157;

	private PictureBox _PictureBox122;

	private PictureBox _PictureBox124;

	private PictureBox _PictureBox125;

	private PictureBox _PictureBox129;

	private PictureBox _PictureBox130;

	private PictureBox _PictureBox131;

	private PictureBox _PictureBox135;

	private PictureBox _PictureBox136;

	private PictureBox _PictureBox137;

	private PictureBox _PictureBox138;

	private PictureBox _PictureBox139;

	private PictureBox _PictureBox101;

	private PictureBox _PictureBox102;

	private PictureBox _PictureBox103;

	private PictureBox _PictureBox108;

	private PictureBox _PictureBox109;

	private PictureBox _PictureBox113;

	private PictureBox _PictureBox114;

	private PictureBox _PictureBox119;

	private PictureBox _PictureBox83;

	private PictureBox _PictureBox85;

	private PictureBox _PictureBox86;

	private PictureBox _PictureBox88;

	private PictureBox _PictureBox92;

	private PictureBox _PictureBox94;

	private PictureBox _PictureBox61;

	private PictureBox _PictureBox62;

	private PictureBox _PictureBox63;

	private PictureBox _PictureBox66;

	private PictureBox _PictureBox69;

	private PictureBox _PictureBox70;

	private PictureBox _PictureBox72;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox74;

	private PictureBox _PictureBox75;

	private PictureBox _PictureBox79;

	private PictureBox _PictureBox80;

	private PictureBox _PictureBox41;

	private PictureBox _PictureBox47;

	private PictureBox _PictureBox49;

	private PictureBox _PictureBox51;

	private PictureBox _PictureBox53;

	private PictureBox _PictureBox54;

	private PictureBox _PictureBox56;

	private PictureBox _PictureBox57;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox60;

	private PictureBox _PictureBox21;

	private PictureBox _PictureBox23;

	private PictureBox _PictureBox24;

	private PictureBox _PictureBox27;

	private PictureBox _PictureBox28;

	private PictureBox _PictureBox29;

	private PictureBox _PictureBox30;

	private PictureBox _PictureBox34;

	private PictureBox _PictureBox35;

	private PictureBox _PictureBox36;

	private PictureBox _Booked;

	private PictureBox _Provisional;

	private Label _Label3;

	private PictureBox _PictureBox39;

	private TextBox _txtBooked;

	private Label _Label1;

	private Label _Label2;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox16;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox9;

	private PictureBox _PictureBox8;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox4;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox2;

	private Label _Label33;

	private Label _Label35;

	private Label _Label36;

	private Label _Label44;

	private Label _Label45;

	private Label _Label47;

	private Label _Label49;

	private Label _Label51;

	private Label _Label54;

	private Label _Label55;

	private Label _Label26;

	private Label _Label29;

	private Label _Label30;

	private Label _Label24;

	private Label _Label19;

	private Label _Label18;

	private Label _Label16;

	private Label _Label15;

	private Label _Label14;

	private Label _Label13;

	private Label _Label9;

	private Label _Label8;

	private Label _Label7;

	private Label _Label4;

	private GroupBox _GroupBox3;

	private PictureBox _Cover;

	private TextBox _txtProvisional;

	private Label _Label6;

	private Button _btnSave;

	private TextBox _txtTotalCost;

	private Label _Label64;

	private TextBox _txtID;

	private Button _btnViewReservations;

	private object provisionalIcon;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	internal IContainer A;

	internal PictureBox k;

	internal PictureBox j;

	internal PictureBox L;

	internal PictureBox U;

	internal PictureBox i;

	internal PictureBox X;

	internal PictureBox Y;

	internal PictureBox o;

	internal PictureBox H;

	internal PictureBox C;

	internal PictureBox d;

	internal PictureBox B;

	internal PictureBox Q;

	internal PictureBox f;

	internal PictureBox e;

	internal PictureBox R;

	internal PictureBox V;

	internal PictureBox W;

	internal PictureBox m;

	internal PictureBox G;

	internal PictureBox n;

	internal PictureBox p;

	internal PictureBox S;

	internal PictureBox T;

	internal PictureBox z;

	internal PictureBox kA;

	internal PictureBox kk;

	internal PictureBox kj;

	internal PictureBox kL;

	internal PictureBox kU;

	internal PictureBox ki;

	internal PictureBox kX;

	internal PictureBox kY;

	internal PictureBox ko;

	internal PictureBox kH;

	internal PictureBox kC;

	internal PictureBox kd;

	internal PictureBox kB;

	internal PictureBox kQ;

	internal PictureBox kf;

	internal PictureBox ke;

	internal PictureBox kR;

	internal PictureBox kV;

	internal PictureBox kW;

	internal PictureBox km;

	internal PictureBox kG;

	internal PictureBox kn;

	internal PictureBox kp;

	internal PictureBox kS;

	internal PictureBox kT;

	internal PictureBox kz;

	internal PictureBox jA;

	internal PictureBox jk;

	internal PictureBox jj;

	internal PictureBox jL;

	internal PictureBox jU;

	internal PictureBox ji;

	internal PictureBox jX;

	internal PictureBox jY;

	internal PictureBox jo;

	internal PictureBox jH;

	internal PictureBox jC;

	internal PictureBox jd;

	internal PictureBox jB;

	internal PictureBox jQ;

	internal PictureBox jf;

	internal PictureBox je;

	internal PictureBox jR;

	internal PictureBox jV;

	internal PictureBox jW;

	internal PictureBox jm;

	internal PictureBox jG;

	internal PictureBox jn;

	internal PictureBox jp;

	internal PictureBox jS;

	internal TextBox jT;

	internal PictureBox jz;

	internal PictureBox LA;

	internal PictureBox Lk;

	internal PictureBox Lj;

	internal PictureBox LL;

	internal PictureBox LU;

	internal PictureBox Li;

	internal PictureBox LX;

	internal PictureBox LY;

	internal PictureBox Lo;

	internal PictureBox LH;

	internal Label LC;

	internal Label Ld;

	internal Label LB;

	internal Label LQ;

	internal Label Lf;

	internal Label Le;

	internal Label LR;

	internal Label LV;

	internal Label LW;

	internal Label Lm;

	internal Label LG;

	internal Label Ln;

	internal Label Lp;

	internal Label LS;

	internal Label LT;

	internal Label Lz;

	internal Label UA;

	internal Label Uk;

	internal Label Uj;

	internal Label UL;

	internal Label UU;

	internal Label Ui;

	internal Label UX;

	internal Label UY;

	internal Label Uo;

	internal Label UH;

	internal GroupBox UC;

	internal PictureBox Ud;

	internal PictureBox UB;

	internal GroupBox UQ;

	internal Button Uf;

	internal TextBox Ue;

	internal TextBox UR;

	internal TextBox UV;

	internal Label UW;

	internal Label Um;

	internal Label UG;

	internal GroupBox Un;

	internal Button Up;

	internal Button US;

	internal Button UT;

	internal TextBox Uz;

	internal Label iA;

	internal Label ik;

	internal object ij;

	internal object iL;

	internal int iU;

	internal int ii;

	internal int iX;

	public n1F()
	{
		((Form)this).add_Load((EventHandler)m3R4);
		object obj = (ij = RuntimeHelpers.GetObjectValue(new object()));
		provisionalIcon = RuntimeHelpers.GetObjectValue(new object());
		object obj2 = (iL = RuntimeHelpers.GetObjectValue(new object()));
		g0H();
	}

	protected override void y8S(bool n4X)
	{
		try
		{
			if (n4X && A != null)
			{
				A.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n4X);
		}
	}

	private void g0H()
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
		r3Y(new PictureBox());
		t0L(new PictureBox());
		q7D(new PictureBox());
		Li1(new PictureBox());
		x2Y(new PictureBox());
		e6W(new PictureBox());
		Rx0(new PictureBox());
		Xr1(new PictureBox());
		k9Q(new PictureBox());
		k1Y(new PictureBox());
		Sd8(new PictureBox());
		Nf1(new PictureBox());
		w6N(new PictureBox());
		t9H(new PictureBox());
		No1(new PictureBox());
		Lf2(new PictureBox());
		Je5(new PictureBox());
		x6E(new PictureBox());
		Jy2(new PictureBox());
		Wa0(new PictureBox());
		Ka7(new PictureBox());
		Gm4(new PictureBox());
		s9H(new PictureBox());
		n6W(new PictureBox());
		Me7(new PictureBox());
		Kq3(new PictureBox());
		q1M(new PictureBox());
		s4H(new PictureBox());
		Qk9(new PictureBox());
		i1N(new PictureBox());
		j8D(new PictureBox());
		Xs7(new PictureBox());
		m7C(new PictureBox());
		f3H(new PictureBox());
		Hr2(new PictureBox());
		Nn7(new PictureBox());
		Xr7(new PictureBox());
		Sd5(new PictureBox());
		z4K(new PictureBox());
		f8H(new PictureBox());
		Zd4(new PictureBox());
		Bs7(new PictureBox());
		y4J(new PictureBox());
		Hw1(new PictureBox());
		Sg1(new PictureBox());
		j8H(new PictureBox());
		Dr7(new PictureBox());
		Ey7(new PictureBox());
		Hc6(new PictureBox());
		n9C(new PictureBox());
		s0R(new PictureBox());
		w6Q(new PictureBox());
		Fk1(new PictureBox());
		j2N(new PictureBox());
		t0D(new PictureBox());
		e8J(new PictureBox());
		x4B(new PictureBox());
		Et9(new PictureBox());
		Hq9(new PictureBox());
		Pw1(new PictureBox());
		e5F(new PictureBox());
		i8J(new PictureBox());
		Ns5(new PictureBox());
		Wp8(new PictureBox());
		Pw2(new PictureBox());
		m1H(new PictureBox());
		Mc1(new PictureBox());
		d4C(new PictureBox());
		Js0(new PictureBox());
		Tr6(new PictureBox());
		Pk6(new PictureBox());
		Cs1(new PictureBox());
		i4P(new PictureBox());
		d4E(new PictureBox());
		k4L(new PictureBox());
		Mp7(new PictureBox());
		d1Y(new PictureBox());
		g8J(new PictureBox());
		j0D(new PictureBox());
		k0Q(new PictureBox());
		s2N(new PictureBox());
		Zq4(new PictureBox());
		Fk0(new PictureBox());
		k0M(new PictureBox());
		Sd1(new PictureBox());
		m2F(new PictureBox());
		e1Z(new PictureBox());
		f5P(new PictureBox());
		w4N(new PictureBox());
		Am3(new PictureBox());
		p7J(new PictureBox());
		Bm0(new PictureBox());
		Km4(new PictureBox());
		Nf8(new PictureBox());
		Ef1(new PictureBox());
		b2Q(new PictureBox());
		z0Y(new PictureBox());
		p2H(new PictureBox());
		d1S(new PictureBox());
		Ei9(new PictureBox());
		Lp4(new PictureBox());
		Mz4(new PictureBox());
		Aq6(new PictureBox());
		n3F(new PictureBox());
		e9L(new PictureBox());
		j2T(new PictureBox());
		j8W(new PictureBox());
		e7L(new PictureBox());
		r3W(new PictureBox());
		e8T(new PictureBox());
		g4G(new PictureBox());
		Aa0(new PictureBox());
		Wo7(new PictureBox());
		Fj4(new PictureBox());
		Pf2(new PictureBox());
		m4F(new PictureBox());
		q7F(new PictureBox());
		Zz0(new PictureBox());
		Rt2(new PictureBox());
		k2G(new PictureBox());
		e3J(new PictureBox());
		n0R(new PictureBox());
		y7L(new PictureBox());
		c1H(new PictureBox());
		r6C(new PictureBox());
		Hf3(new PictureBox());
		Pg5(new PictureBox());
		Lb1(new PictureBox());
		Zb6(new PictureBox());
		Zo9(new PictureBox());
		Jf3n(new PictureBox());
		b5Y3(new PictureBox());
		z0C4(new PictureBox());
		Gq1g(new PictureBox());
		o3F9(new PictureBox());
		Xw2f(new PictureBox());
		Wr7b(new PictureBox());
		i6G0(new PictureBox());
		n5S7(new TextBox());
		Ex81(new PictureBox());
		Re34(new PictureBox());
		Yp48(new PictureBox());
		Qi4r(new Label());
		d0K7(new PictureBox());
		Am5e(new TextBox());
		w7H1(new Label());
		Fg9j(new Label());
		Jj9w(new PictureBox());
		n2YJ(new PictureBox());
		Jt46(new PictureBox());
		x9E3(new PictureBox());
		o3C4(new PictureBox());
		Qk95(new PictureBox());
		p8NL(new PictureBox());
		b6MT(new PictureBox());
		Jj80(new PictureBox());
		k0CR(new PictureBox());
		r6S5(new PictureBox());
		y7MY(new PictureBox());
		z8WA(new PictureBox());
		c7RS(new PictureBox());
		g6B0(new PictureBox());
		Wj92(new PictureBox());
		e8JY(new PictureBox());
		s3X4(new PictureBox());
		Cd23(new PictureBox());
		g8K6(new PictureBox());
		t0A2(new PictureBox());
		n9N3(new Label());
		e4TH(new Label());
		q7W2(new Label());
		p3PN(new Label());
		Bk4o(new Label());
		Np24(new Label());
		Mn31(new Label());
		s6H0(new Label());
		p0F8(new Label());
		Zg5b(new Label());
		Tr65(new Label());
		z9G0(new Label());
		Gz7r(new Label());
		m7Z8(new Label());
		s4MP(new Label());
		Yt36(new Label());
		g3WH(new Label());
		Tj2p(new Label());
		d5BY(new Label());
		Yw8c(new Label());
		Gc09(new Label());
		Xc1a(new Label());
		Xc68(new Label());
		k8BW(new Label());
		Xd5f(new Label());
		f9XT(new Label());
		Hd3m(new Label());
		x6HA(new Label());
		z7H8(new Label());
		Bi4o(new Label());
		j9R0(new Label());
		Hd64(new Label());
		o8P9(new Label());
		c8ZM(new Label());
		Ji9r(new Label());
		e4C3(new Label());
		y6E0(new Label());
		Hi8t(new Label());
		j1DZ(new Label());
		t2Z8(new Label());
		Sp71(new Label());
		Ey76(new Label());
		e4M6(new Label());
		Gr8z(new Label());
		Df98(new Label());
		a6A0(new Label());
		Me53(new Label());
		Ft94(new Label());
		n5E6(new Label());
		Sx2f(new Label());
		m7L8(new GroupBox());
		e4CN(new PictureBox());
		r2C7(new GroupBox());
		a8DN(new TextBox());
		e8YK(new Label());
		c5SQ(new PictureBox());
		w4G6(new PictureBox());
		j9ZR(new GroupBox());
		g7MA(new Button());
		d3WM(new Button());
		Et78(new TextBox());
		Yy0m(new TextBox());
		Zc27(new TextBox());
		Yo07(new TextBox());
		Mb9r(new Label());
		Kt73(new Label());
		x6BD(new Label());
		y7B9(new Label());
		St6c(new GroupBox());
		Et4e(new Button());
		Ms3z(new Button());
		Hc32(new Button());
		o9C1(new TextBox());
		f9Z7(new TextBox());
		m1Q9(new Label());
		p2DJ(new Label());
		k3FY(new Button());
		((ISupportInitialize)g7H()).BeginInit();
		((ISupportInitialize)m9Z()).BeginInit();
		((ISupportInitialize)c4P()).BeginInit();
		((ISupportInitialize)w0P()).BeginInit();
		((ISupportInitialize)Ha7()).BeginInit();
		((ISupportInitialize)w0R()).BeginInit();
		((ISupportInitialize)Wb1()).BeginInit();
		((ISupportInitialize)x9L()).BeginInit();
		((ISupportInitialize)Mw9()).BeginInit();
		((ISupportInitialize)Cw4()).BeginInit();
		((ISupportInitialize)z5R()).BeginInit();
		((ISupportInitialize)z7Y()).BeginInit();
		((ISupportInitialize)r6W()).BeginInit();
		((ISupportInitialize)Qd6()).BeginInit();
		((ISupportInitialize)b3Q()).BeginInit();
		((ISupportInitialize)Mc4()).BeginInit();
		((ISupportInitialize)g5J()).BeginInit();
		((ISupportInitialize)Dq5()).BeginInit();
		((ISupportInitialize)Nq5()).BeginInit();
		((ISupportInitialize)Aq7()).BeginInit();
		((ISupportInitialize)m8S()).BeginInit();
		((ISupportInitialize)q7L()).BeginInit();
		((ISupportInitialize)d2B()).BeginInit();
		((ISupportInitialize)Fa7()).BeginInit();
		((ISupportInitialize)Fj6()).BeginInit();
		((ISupportInitialize)St1()).BeginInit();
		((ISupportInitialize)q2Q()).BeginInit();
		((ISupportInitialize)Gn0()).BeginInit();
		((ISupportInitialize)w0F()).BeginInit();
		((ISupportInitialize)g1L()).BeginInit();
		((ISupportInitialize)z9F()).BeginInit();
		((ISupportInitialize)Tr8()).BeginInit();
		((ISupportInitialize)Bt3()).BeginInit();
		((ISupportInitialize)a5S()).BeginInit();
		((ISupportInitialize)Lb8()).BeginInit();
		((ISupportInitialize)k8S()).BeginInit();
		((ISupportInitialize)Mx1()).BeginInit();
		((ISupportInitialize)r9T()).BeginInit();
		((ISupportInitialize)Re6()).BeginInit();
		((ISupportInitialize)d4B()).BeginInit();
		((ISupportInitialize)i4D()).BeginInit();
		((ISupportInitialize)Xi4()).BeginInit();
		((ISupportInitialize)o2M()).BeginInit();
		((ISupportInitialize)m4B()).BeginInit();
		((ISupportInitialize)Zs6()).BeginInit();
		((ISupportInitialize)Kx0()).BeginInit();
		((ISupportInitialize)Qk6()).BeginInit();
		((ISupportInitialize)Gc1()).BeginInit();
		((ISupportInitialize)Xc8()).BeginInit();
		((ISupportInitialize)a3K()).BeginInit();
		((ISupportInitialize)Xq8()).BeginInit();
		((ISupportInitialize)g3Z()).BeginInit();
		((ISupportInitialize)Yo3()).BeginInit();
		((ISupportInitialize)z1D()).BeginInit();
		((ISupportInitialize)Tc4()).BeginInit();
		((ISupportInitialize)Wp1()).BeginInit();
		((ISupportInitialize)c3W()).BeginInit();
		((ISupportInitialize)f6T()).BeginInit();
		((ISupportInitialize)m8M()).BeginInit();
		((ISupportInitialize)Ki3()).BeginInit();
		((ISupportInitialize)Yj3()).BeginInit();
		((ISupportInitialize)g5K()).BeginInit();
		((ISupportInitialize)t9E()).BeginInit();
		((ISupportInitialize)Xi7()).BeginInit();
		((ISupportInitialize)p4X()).BeginInit();
		((ISupportInitialize)Cr0()).BeginInit();
		((ISupportInitialize)s9F()).BeginInit();
		((ISupportInitialize)a7D()).BeginInit();
		((ISupportInitialize)x4J()).BeginInit();
		((ISupportInitialize)Wg2()).BeginInit();
		((ISupportInitialize)Pa7()).BeginInit();
		((ISupportInitialize)y4C()).BeginInit();
		((ISupportInitialize)a6E()).BeginInit();
		((ISupportInitialize)b1Q()).BeginInit();
		((ISupportInitialize)Fw6()).BeginInit();
		((ISupportInitialize)f7X()).BeginInit();
		((ISupportInitialize)Wt4()).BeginInit();
		((ISupportInitialize)q5F()).BeginInit();
		((ISupportInitialize)Gd6()).BeginInit();
		((ISupportInitialize)Yf8()).BeginInit();
		((ISupportInitialize)p0T()).BeginInit();
		((ISupportInitialize)Qj6()).BeginInit();
		((ISupportInitialize)Kg4()).BeginInit();
		((ISupportInitialize)Kd3()).BeginInit();
		((ISupportInitialize)Ns7()).BeginInit();
		((ISupportInitialize)m3K()).BeginInit();
		((ISupportInitialize)q6T()).BeginInit();
		((ISupportInitialize)Pm2()).BeginInit();
		((ISupportInitialize)o3A()).BeginInit();
		((ISupportInitialize)f2P()).BeginInit();
		((ISupportInitialize)n9S()).BeginInit();
		((ISupportInitialize)b0L()).BeginInit();
		((ISupportInitialize)Ly0()).BeginInit();
		((ISupportInitialize)k1W()).BeginInit();
		((ISupportInitialize)Kr7()).BeginInit();
		((ISupportInitialize)Ce1()).BeginInit();
		((ISupportInitialize)Co0()).BeginInit();
		((ISupportInitialize)n0C()).BeginInit();
		((ISupportInitialize)Xy0()).BeginInit();
		((ISupportInitialize)b5F()).BeginInit();
		((ISupportInitialize)e4E()).BeginInit();
		((ISupportInitialize)Lg1()).BeginInit();
		((ISupportInitialize)Mm9()).BeginInit();
		((ISupportInitialize)j0J()).BeginInit();
		((ISupportInitialize)d9N()).BeginInit();
		((ISupportInitialize)a6T()).BeginInit();
		((ISupportInitialize)Ks7()).BeginInit();
		((ISupportInitialize)Kt6()).BeginInit();
		((ISupportInitialize)Ya9()).BeginInit();
		((ISupportInitialize)Mr8()).BeginInit();
		((ISupportInitialize)Fr6()).BeginInit();
		((ISupportInitialize)s5X()).BeginInit();
		((ISupportInitialize)n2Q()).BeginInit();
		((ISupportInitialize)Hs6()).BeginInit();
		((ISupportInitialize)Pz8()).BeginInit();
		((ISupportInitialize)Dc6()).BeginInit();
		((ISupportInitialize)Mb2()).BeginInit();
		((ISupportInitialize)Pi7()).BeginInit();
		((ISupportInitialize)Nx5()).BeginInit();
		((ISupportInitialize)r7D()).BeginInit();
		((ISupportInitialize)j7Y()).BeginInit();
		((ISupportInitialize)Qy4()).BeginInit();
		((ISupportInitialize)Kj8()).BeginInit();
		((ISupportInitialize)Tt0()).BeginInit();
		((ISupportInitialize)Yp8()).BeginInit();
		((ISupportInitialize)w5C()).BeginInit();
		((ISupportInitialize)q6Q()).BeginInit();
		((ISupportInitialize)Kd6()).BeginInit();
		((ISupportInitialize)y1A()).BeginInit();
		((ISupportInitialize)e5N()).BeginInit();
		((ISupportInitialize)Lo6()).BeginInit();
		((ISupportInitialize)Pe5p()).BeginInit();
		((ISupportInitialize)j3MB()).BeginInit();
		((ISupportInitialize)Ki96()).BeginInit();
		((ISupportInitialize)Yq27()).BeginInit();
		((ISupportInitialize)t3RJ()).BeginInit();
		((ISupportInitialize)t4EG()).BeginInit();
		((ISupportInitialize)Lj34()).BeginInit();
		((ISupportInitialize)w6AW()).BeginInit();
		((ISupportInitialize)r9XC()).BeginInit();
		((ISupportInitialize)j9G1()).BeginInit();
		((ISupportInitialize)o8LX()).BeginInit();
		((ISupportInitialize)Fk90()).BeginInit();
		((ISupportInitialize)Lz4x()).BeginInit();
		((ISupportInitialize)q8FC()).BeginInit();
		((ISupportInitialize)Tt07()).BeginInit();
		((ISupportInitialize)c3GC()).BeginInit();
		((ISupportInitialize)Cs12()).BeginInit();
		((ISupportInitialize)Wt4n()).BeginInit();
		((ISupportInitialize)o1H7()).BeginInit();
		((ISupportInitialize)y1HE()).BeginInit();
		((ISupportInitialize)n7KM()).BeginInit();
		((ISupportInitialize)Dr0w()).BeginInit();
		((ISupportInitialize)s1S3()).BeginInit();
		((ISupportInitialize)Ck2n()).BeginInit();
		((ISupportInitialize)b8JA()).BeginInit();
		((ISupportInitialize)q6D4()).BeginInit();
		((ISupportInitialize)z2G8()).BeginInit();
		((ISupportInitialize)m7HX()).BeginInit();
		((ISupportInitialize)Sf7k()).BeginInit();
		((ISupportInitialize)e6DC()).BeginInit();
		((ISupportInitialize)En97()).BeginInit();
		((ISupportInitialize)Ec2t()).BeginInit();
		((Control)o4GF()).SuspendLayout();
		((ISupportInitialize)Ak6x()).BeginInit();
		((Control)e5AG()).SuspendLayout();
		((ISupportInitialize)Ha15()).BeginInit();
		((ISupportInitialize)d0BQ()).BeginInit();
		((Control)Nc1f()).SuspendLayout();
		((Control)e9JN()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)g7H()).set_Location(new Point(372, 362));
		((Control)g7H()).set_Name("PictureBox141");
		((Control)g7H()).set_Size(new Size(10, 12));
		g7H().set_SizeMode((PictureBoxSizeMode)4);
		g7H().set_TabIndex(1002);
		g7H().set_TabStop(false);
		((Control)m9Z()).set_Location(new Point(352, 362));
		((Control)m9Z()).set_Name("PictureBox142");
		((Control)m9Z()).set_Size(new Size(10, 12));
		m9Z().set_SizeMode((PictureBoxSizeMode)4);
		m9Z().set_TabIndex(1001);
		m9Z().set_TabStop(false);
		((Control)c4P()).set_Location(new Point(333, 362));
		((Control)c4P()).set_Name("PictureBox143");
		((Control)c4P()).set_Size(new Size(10, 12));
		c4P().set_SizeMode((PictureBoxSizeMode)4);
		c4P().set_TabIndex(1000);
		c4P().set_TabStop(false);
		((Control)w0P()).set_Location(new Point(314, 362));
		((Control)w0P()).set_Name("PictureBox144");
		((Control)w0P()).set_Size(new Size(10, 12));
		w0P().set_SizeMode((PictureBoxSizeMode)4);
		w0P().set_TabIndex(999);
		w0P().set_TabStop(false);
		((Control)Ha7()).set_Location(new Point(296, 362));
		((Control)Ha7()).set_Name("PictureBox145");
		((Control)Ha7()).set_Size(new Size(10, 12));
		Ha7().set_SizeMode((PictureBoxSizeMode)4);
		Ha7().set_TabIndex(998);
		Ha7().set_TabStop(false);
		((Control)w0R()).set_Location(new Point(279, 362));
		((Control)w0R()).set_Name("PictureBox146");
		((Control)w0R()).set_Size(new Size(10, 12));
		w0R().set_SizeMode((PictureBoxSizeMode)4);
		w0R().set_TabIndex(997);
		w0R().set_TabStop(false);
		((Control)Wb1()).set_Location(new Point(261, 362));
		((Control)Wb1()).set_Name("PictureBox147");
		((Control)Wb1()).set_Size(new Size(10, 12));
		Wb1().set_SizeMode((PictureBoxSizeMode)4);
		Wb1().set_TabIndex(996);
		Wb1().set_TabStop(false);
		((Control)x9L()).set_Location(new Point(245, 362));
		((Control)x9L()).set_Name("PictureBox148");
		((Control)x9L()).set_Size(new Size(10, 12));
		x9L().set_SizeMode((PictureBoxSizeMode)4);
		x9L().set_TabIndex(995);
		x9L().set_TabStop(false);
		((Control)Mw9()).set_Location(new Point(227, 362));
		((Control)Mw9()).set_Name("PictureBox149");
		((Control)Mw9()).set_Size(new Size(10, 12));
		Mw9().set_SizeMode((PictureBoxSizeMode)4);
		Mw9().set_TabIndex(994);
		Mw9().set_TabStop(false);
		((Control)Cw4()).set_Location(new Point(208, 362));
		((Control)Cw4()).set_Name("PictureBox150");
		((Control)Cw4()).set_Size(new Size(10, 12));
		Cw4().set_SizeMode((PictureBoxSizeMode)4);
		Cw4().set_TabIndex(993);
		Cw4().set_TabStop(false);
		((Control)z5R()).set_Location(new Point(190, 362));
		((Control)z5R()).set_Name("PictureBox151");
		((Control)z5R()).set_Size(new Size(10, 12));
		z5R().set_SizeMode((PictureBoxSizeMode)4);
		z5R().set_TabIndex(992);
		z5R().set_TabStop(false);
		((Control)z7Y()).set_Location(new Point(174, 362));
		((Control)z7Y()).set_Name("PictureBox152");
		((Control)z7Y()).set_Size(new Size(10, 12));
		z7Y().set_SizeMode((PictureBoxSizeMode)4);
		z7Y().set_TabIndex(991);
		z7Y().set_TabStop(false);
		((Control)r6W()).set_Location(new Point(158, 362));
		((Control)r6W()).set_Name("PictureBox153");
		((Control)r6W()).set_Size(new Size(10, 12));
		r6W().set_SizeMode((PictureBoxSizeMode)4);
		r6W().set_TabIndex(990);
		r6W().set_TabStop(false);
		((Control)Qd6()).set_Location(new Point(142, 362));
		((Control)Qd6()).set_Name("PictureBox154");
		((Control)Qd6()).set_Size(new Size(10, 12));
		Qd6().set_SizeMode((PictureBoxSizeMode)4);
		Qd6().set_TabIndex(989);
		Qd6().set_TabStop(false);
		((Control)b3Q()).set_Location(new Point(126, 362));
		((Control)b3Q()).set_Name("PictureBox155");
		((Control)b3Q()).set_Size(new Size(10, 12));
		b3Q().set_SizeMode((PictureBoxSizeMode)4);
		b3Q().set_TabIndex(988);
		b3Q().set_TabStop(false);
		((Control)Mc4()).set_Location(new Point(110, 362));
		((Control)Mc4()).set_Name("PictureBox156");
		((Control)Mc4()).set_Size(new Size(10, 12));
		Mc4().set_SizeMode((PictureBoxSizeMode)4);
		Mc4().set_TabIndex(987);
		Mc4().set_TabStop(false);
		((Control)g5J()).set_Location(new Point(94, 362));
		((Control)g5J()).set_Name("PictureBox157");
		((Control)g5J()).set_Size(new Size(10, 12));
		g5J().set_SizeMode((PictureBoxSizeMode)4);
		g5J().set_TabIndex(986);
		g5J().set_TabStop(false);
		((Control)Dq5()).set_Location(new Point(78, 362));
		((Control)Dq5()).set_Name("PictureBox158");
		((Control)Dq5()).set_Size(new Size(10, 12));
		Dq5().set_SizeMode((PictureBoxSizeMode)4);
		Dq5().set_TabIndex(985);
		Dq5().set_TabStop(false);
		((Control)Nq5()).set_Location(new Point(62, 362));
		((Control)Nq5()).set_Name("PictureBox159");
		((Control)Nq5()).set_Size(new Size(10, 12));
		Nq5().set_SizeMode((PictureBoxSizeMode)4);
		Nq5().set_TabIndex(984);
		Nq5().set_TabStop(false);
		((Control)Aq7()).set_Location(new Point(48, 362));
		((Control)Aq7()).set_Name("PictureBox160");
		((Control)Aq7()).set_Size(new Size(10, 12));
		Aq7().set_SizeMode((PictureBoxSizeMode)4);
		Aq7().set_TabIndex(983);
		Aq7().set_TabStop(false);
		((Control)m8S()).set_Location(new Point(372, 340));
		((Control)m8S()).set_Name("PictureBox121");
		((Control)m8S()).set_Size(new Size(10, 12));
		m8S().set_SizeMode((PictureBoxSizeMode)4);
		m8S().set_TabIndex(982);
		m8S().set_TabStop(false);
		((Control)q7L()).set_Location(new Point(352, 340));
		((Control)q7L()).set_Name("PictureBox122");
		((Control)q7L()).set_Size(new Size(10, 12));
		q7L().set_SizeMode((PictureBoxSizeMode)4);
		q7L().set_TabIndex(981);
		q7L().set_TabStop(false);
		((Control)d2B()).set_Location(new Point(333, 340));
		((Control)d2B()).set_Name("PictureBox123");
		((Control)d2B()).set_Size(new Size(10, 12));
		d2B().set_SizeMode((PictureBoxSizeMode)4);
		d2B().set_TabIndex(980);
		d2B().set_TabStop(false);
		((Control)Fa7()).set_Location(new Point(314, 340));
		((Control)Fa7()).set_Name("PictureBox124");
		((Control)Fa7()).set_Size(new Size(10, 12));
		Fa7().set_SizeMode((PictureBoxSizeMode)4);
		Fa7().set_TabIndex(979);
		Fa7().set_TabStop(false);
		((Control)Fj6()).set_Location(new Point(296, 340));
		((Control)Fj6()).set_Name("PictureBox125");
		((Control)Fj6()).set_Size(new Size(10, 12));
		Fj6().set_SizeMode((PictureBoxSizeMode)4);
		Fj6().set_TabIndex(978);
		Fj6().set_TabStop(false);
		((Control)St1()).set_Location(new Point(279, 340));
		((Control)St1()).set_Name("PictureBox126");
		((Control)St1()).set_Size(new Size(10, 12));
		St1().set_SizeMode((PictureBoxSizeMode)4);
		St1().set_TabIndex(977);
		St1().set_TabStop(false);
		((Control)q2Q()).set_Location(new Point(261, 340));
		((Control)q2Q()).set_Name("PictureBox127");
		((Control)q2Q()).set_Size(new Size(10, 12));
		q2Q().set_SizeMode((PictureBoxSizeMode)4);
		q2Q().set_TabIndex(976);
		q2Q().set_TabStop(false);
		((Control)Gn0()).set_Location(new Point(245, 340));
		((Control)Gn0()).set_Name("PictureBox128");
		((Control)Gn0()).set_Size(new Size(10, 12));
		Gn0().set_SizeMode((PictureBoxSizeMode)4);
		Gn0().set_TabIndex(975);
		Gn0().set_TabStop(false);
		((Control)w0F()).set_Location(new Point(227, 340));
		((Control)w0F()).set_Name("PictureBox129");
		((Control)w0F()).set_Size(new Size(10, 12));
		w0F().set_SizeMode((PictureBoxSizeMode)4);
		w0F().set_TabIndex(974);
		w0F().set_TabStop(false);
		((Control)g1L()).set_Location(new Point(208, 340));
		((Control)g1L()).set_Name("PictureBox130");
		((Control)g1L()).set_Size(new Size(10, 12));
		g1L().set_SizeMode((PictureBoxSizeMode)4);
		g1L().set_TabIndex(973);
		g1L().set_TabStop(false);
		((Control)z9F()).set_Location(new Point(190, 340));
		((Control)z9F()).set_Name("PictureBox131");
		((Control)z9F()).set_Size(new Size(10, 12));
		z9F().set_SizeMode((PictureBoxSizeMode)4);
		z9F().set_TabIndex(972);
		z9F().set_TabStop(false);
		((Control)Tr8()).set_Location(new Point(174, 340));
		((Control)Tr8()).set_Name("PictureBox132");
		((Control)Tr8()).set_Size(new Size(10, 12));
		Tr8().set_SizeMode((PictureBoxSizeMode)4);
		Tr8().set_TabIndex(971);
		Tr8().set_TabStop(false);
		((Control)Bt3()).set_Location(new Point(158, 340));
		((Control)Bt3()).set_Name("PictureBox133");
		((Control)Bt3()).set_Size(new Size(10, 12));
		Bt3().set_SizeMode((PictureBoxSizeMode)4);
		Bt3().set_TabIndex(970);
		Bt3().set_TabStop(false);
		((Control)a5S()).set_Location(new Point(142, 340));
		((Control)a5S()).set_Name("PictureBox134");
		((Control)a5S()).set_Size(new Size(10, 12));
		a5S().set_SizeMode((PictureBoxSizeMode)4);
		a5S().set_TabIndex(969);
		a5S().set_TabStop(false);
		((Control)Lb8()).set_Location(new Point(126, 340));
		((Control)Lb8()).set_Name("PictureBox135");
		((Control)Lb8()).set_Size(new Size(10, 12));
		Lb8().set_SizeMode((PictureBoxSizeMode)4);
		Lb8().set_TabIndex(968);
		Lb8().set_TabStop(false);
		((Control)k8S()).set_Location(new Point(110, 340));
		((Control)k8S()).set_Name("PictureBox136");
		((Control)k8S()).set_Size(new Size(10, 12));
		k8S().set_SizeMode((PictureBoxSizeMode)4);
		k8S().set_TabIndex(967);
		k8S().set_TabStop(false);
		((Control)Mx1()).set_Location(new Point(94, 340));
		((Control)Mx1()).set_Name("PictureBox137");
		((Control)Mx1()).set_Size(new Size(10, 12));
		Mx1().set_SizeMode((PictureBoxSizeMode)4);
		Mx1().set_TabIndex(966);
		Mx1().set_TabStop(false);
		((Control)r9T()).set_Location(new Point(78, 340));
		((Control)r9T()).set_Name("PictureBox138");
		((Control)r9T()).set_Size(new Size(10, 12));
		r9T().set_SizeMode((PictureBoxSizeMode)4);
		r9T().set_TabIndex(965);
		r9T().set_TabStop(false);
		((Control)Re6()).set_Location(new Point(62, 340));
		((Control)Re6()).set_Name("PictureBox139");
		((Control)Re6()).set_Size(new Size(10, 12));
		Re6().set_SizeMode((PictureBoxSizeMode)4);
		Re6().set_TabIndex(964);
		Re6().set_TabStop(false);
		((Control)d4B()).set_Location(new Point(48, 340));
		((Control)d4B()).set_Name("PictureBox140");
		((Control)d4B()).set_Size(new Size(10, 12));
		d4B().set_SizeMode((PictureBoxSizeMode)4);
		d4B().set_TabIndex(963);
		d4B().set_TabStop(false);
		((Control)i4D()).set_Location(new Point(372, 318));
		((Control)i4D()).set_Name("PictureBox101");
		((Control)i4D()).set_Size(new Size(10, 12));
		i4D().set_SizeMode((PictureBoxSizeMode)4);
		i4D().set_TabIndex(962);
		i4D().set_TabStop(false);
		((Control)Xi4()).set_Location(new Point(352, 318));
		((Control)Xi4()).set_Name("PictureBox102");
		((Control)Xi4()).set_Size(new Size(10, 12));
		Xi4().set_SizeMode((PictureBoxSizeMode)4);
		Xi4().set_TabIndex(961);
		Xi4().set_TabStop(false);
		((Control)o2M()).set_Location(new Point(333, 318));
		((Control)o2M()).set_Name("PictureBox103");
		((Control)o2M()).set_Size(new Size(10, 12));
		o2M().set_SizeMode((PictureBoxSizeMode)4);
		o2M().set_TabIndex(960);
		o2M().set_TabStop(false);
		((Control)m4B()).set_Location(new Point(314, 318));
		((Control)m4B()).set_Name("PictureBox104");
		((Control)m4B()).set_Size(new Size(10, 12));
		m4B().set_SizeMode((PictureBoxSizeMode)4);
		m4B().set_TabIndex(959);
		m4B().set_TabStop(false);
		((Control)Zs6()).set_Location(new Point(296, 318));
		((Control)Zs6()).set_Name("PictureBox105");
		((Control)Zs6()).set_Size(new Size(10, 12));
		Zs6().set_SizeMode((PictureBoxSizeMode)4);
		Zs6().set_TabIndex(958);
		Zs6().set_TabStop(false);
		((Control)Kx0()).set_Location(new Point(279, 318));
		((Control)Kx0()).set_Name("PictureBox106");
		((Control)Kx0()).set_Size(new Size(10, 12));
		Kx0().set_SizeMode((PictureBoxSizeMode)4);
		Kx0().set_TabIndex(957);
		Kx0().set_TabStop(false);
		((Control)Qk6()).set_Location(new Point(261, 318));
		((Control)Qk6()).set_Name("PictureBox107");
		((Control)Qk6()).set_Size(new Size(10, 12));
		Qk6().set_SizeMode((PictureBoxSizeMode)4);
		Qk6().set_TabIndex(956);
		Qk6().set_TabStop(false);
		((Control)Gc1()).set_Location(new Point(245, 318));
		((Control)Gc1()).set_Name("PictureBox108");
		((Control)Gc1()).set_Size(new Size(10, 12));
		Gc1().set_SizeMode((PictureBoxSizeMode)4);
		Gc1().set_TabIndex(955);
		Gc1().set_TabStop(false);
		((Control)Xc8()).set_Location(new Point(227, 318));
		((Control)Xc8()).set_Name("PictureBox109");
		((Control)Xc8()).set_Size(new Size(10, 12));
		Xc8().set_SizeMode((PictureBoxSizeMode)4);
		Xc8().set_TabIndex(954);
		Xc8().set_TabStop(false);
		((Control)a3K()).set_Location(new Point(208, 318));
		((Control)a3K()).set_Name("PictureBox110");
		((Control)a3K()).set_Size(new Size(10, 12));
		a3K().set_SizeMode((PictureBoxSizeMode)4);
		a3K().set_TabIndex(953);
		a3K().set_TabStop(false);
		((Control)Xq8()).set_Location(new Point(190, 318));
		((Control)Xq8()).set_Name("PictureBox111");
		((Control)Xq8()).set_Size(new Size(10, 12));
		Xq8().set_SizeMode((PictureBoxSizeMode)4);
		Xq8().set_TabIndex(952);
		Xq8().set_TabStop(false);
		((Control)g3Z()).set_Location(new Point(174, 318));
		((Control)g3Z()).set_Name("PictureBox112");
		((Control)g3Z()).set_Size(new Size(10, 12));
		g3Z().set_SizeMode((PictureBoxSizeMode)4);
		g3Z().set_TabIndex(951);
		g3Z().set_TabStop(false);
		((Control)Yo3()).set_Location(new Point(158, 318));
		((Control)Yo3()).set_Name("PictureBox113");
		((Control)Yo3()).set_Size(new Size(10, 12));
		Yo3().set_SizeMode((PictureBoxSizeMode)4);
		Yo3().set_TabIndex(950);
		Yo3().set_TabStop(false);
		((Control)z1D()).set_Location(new Point(142, 318));
		((Control)z1D()).set_Name("PictureBox114");
		((Control)z1D()).set_Size(new Size(10, 12));
		z1D().set_SizeMode((PictureBoxSizeMode)4);
		z1D().set_TabIndex(949);
		z1D().set_TabStop(false);
		((Control)Tc4()).set_Location(new Point(126, 318));
		((Control)Tc4()).set_Name("PictureBox115");
		((Control)Tc4()).set_Size(new Size(10, 12));
		Tc4().set_SizeMode((PictureBoxSizeMode)4);
		Tc4().set_TabIndex(948);
		Tc4().set_TabStop(false);
		((Control)Wp1()).set_Location(new Point(110, 318));
		((Control)Wp1()).set_Name("PictureBox116");
		((Control)Wp1()).set_Size(new Size(10, 12));
		Wp1().set_SizeMode((PictureBoxSizeMode)4);
		Wp1().set_TabIndex(947);
		Wp1().set_TabStop(false);
		((Control)c3W()).set_Location(new Point(94, 318));
		((Control)c3W()).set_Name("PictureBox117");
		((Control)c3W()).set_Size(new Size(10, 12));
		c3W().set_SizeMode((PictureBoxSizeMode)4);
		c3W().set_TabIndex(946);
		c3W().set_TabStop(false);
		((Control)f6T()).set_Location(new Point(78, 318));
		((Control)f6T()).set_Name("PictureBox118");
		((Control)f6T()).set_Size(new Size(10, 12));
		f6T().set_SizeMode((PictureBoxSizeMode)4);
		f6T().set_TabIndex(945);
		f6T().set_TabStop(false);
		((Control)m8M()).set_Location(new Point(62, 318));
		((Control)m8M()).set_Name("PictureBox119");
		((Control)m8M()).set_Size(new Size(10, 12));
		m8M().set_SizeMode((PictureBoxSizeMode)4);
		m8M().set_TabIndex(944);
		m8M().set_TabStop(false);
		((Control)Ki3()).set_Location(new Point(48, 318));
		((Control)Ki3()).set_Name("PictureBox120");
		((Control)Ki3()).set_Size(new Size(10, 12));
		Ki3().set_SizeMode((PictureBoxSizeMode)4);
		Ki3().set_TabIndex(943);
		Ki3().set_TabStop(false);
		((Control)Yj3()).set_Location(new Point(372, 299));
		((Control)Yj3()).set_Name("PictureBox81");
		((Control)Yj3()).set_Size(new Size(10, 12));
		Yj3().set_SizeMode((PictureBoxSizeMode)4);
		Yj3().set_TabIndex(942);
		Yj3().set_TabStop(false);
		((Control)g5K()).set_Location(new Point(352, 299));
		((Control)g5K()).set_Name("PictureBox82");
		((Control)g5K()).set_Size(new Size(10, 12));
		g5K().set_SizeMode((PictureBoxSizeMode)4);
		g5K().set_TabIndex(941);
		g5K().set_TabStop(false);
		((Control)t9E()).set_Location(new Point(333, 299));
		((Control)t9E()).set_Name("PictureBox83");
		((Control)t9E()).set_Size(new Size(10, 12));
		t9E().set_SizeMode((PictureBoxSizeMode)4);
		t9E().set_TabIndex(940);
		t9E().set_TabStop(false);
		((Control)Xi7()).set_Location(new Point(314, 299));
		((Control)Xi7()).set_Name("PictureBox84");
		((Control)Xi7()).set_Size(new Size(10, 12));
		Xi7().set_SizeMode((PictureBoxSizeMode)4);
		Xi7().set_TabIndex(939);
		Xi7().set_TabStop(false);
		((Control)p4X()).set_Location(new Point(296, 299));
		((Control)p4X()).set_Name("PictureBox85");
		((Control)p4X()).set_Size(new Size(10, 12));
		p4X().set_SizeMode((PictureBoxSizeMode)4);
		p4X().set_TabIndex(938);
		p4X().set_TabStop(false);
		((Control)Cr0()).set_Location(new Point(279, 299));
		((Control)Cr0()).set_Name("PictureBox86");
		((Control)Cr0()).set_Size(new Size(10, 12));
		Cr0().set_SizeMode((PictureBoxSizeMode)4);
		Cr0().set_TabIndex(937);
		Cr0().set_TabStop(false);
		((Control)s9F()).set_Location(new Point(261, 299));
		((Control)s9F()).set_Name("PictureBox87");
		((Control)s9F()).set_Size(new Size(10, 12));
		s9F().set_SizeMode((PictureBoxSizeMode)4);
		s9F().set_TabIndex(936);
		s9F().set_TabStop(false);
		((Control)a7D()).set_Location(new Point(245, 299));
		((Control)a7D()).set_Name("PictureBox88");
		((Control)a7D()).set_Size(new Size(10, 12));
		a7D().set_SizeMode((PictureBoxSizeMode)4);
		a7D().set_TabIndex(935);
		a7D().set_TabStop(false);
		((Control)x4J()).set_Location(new Point(227, 299));
		((Control)x4J()).set_Name("PictureBox89");
		((Control)x4J()).set_Size(new Size(10, 12));
		x4J().set_SizeMode((PictureBoxSizeMode)4);
		x4J().set_TabIndex(934);
		x4J().set_TabStop(false);
		((Control)Wg2()).set_Location(new Point(208, 299));
		((Control)Wg2()).set_Name("PictureBox90");
		((Control)Wg2()).set_Size(new Size(10, 12));
		Wg2().set_SizeMode((PictureBoxSizeMode)4);
		Wg2().set_TabIndex(933);
		Wg2().set_TabStop(false);
		((Control)Pa7()).set_Location(new Point(190, 299));
		((Control)Pa7()).set_Name("PictureBox91");
		((Control)Pa7()).set_Size(new Size(10, 12));
		Pa7().set_SizeMode((PictureBoxSizeMode)4);
		Pa7().set_TabIndex(932);
		Pa7().set_TabStop(false);
		((Control)y4C()).set_Location(new Point(174, 299));
		((Control)y4C()).set_Name("PictureBox92");
		((Control)y4C()).set_Size(new Size(10, 12));
		y4C().set_SizeMode((PictureBoxSizeMode)4);
		y4C().set_TabIndex(931);
		y4C().set_TabStop(false);
		((Control)a6E()).set_Location(new Point(158, 299));
		((Control)a6E()).set_Name("PictureBox93");
		((Control)a6E()).set_Size(new Size(10, 12));
		a6E().set_SizeMode((PictureBoxSizeMode)4);
		a6E().set_TabIndex(930);
		a6E().set_TabStop(false);
		((Control)b1Q()).set_Location(new Point(142, 299));
		((Control)b1Q()).set_Name("PictureBox94");
		((Control)b1Q()).set_Size(new Size(10, 12));
		b1Q().set_SizeMode((PictureBoxSizeMode)4);
		b1Q().set_TabIndex(929);
		b1Q().set_TabStop(false);
		((Control)Fw6()).set_Location(new Point(126, 299));
		((Control)Fw6()).set_Name("PictureBox95");
		((Control)Fw6()).set_Size(new Size(10, 12));
		Fw6().set_SizeMode((PictureBoxSizeMode)4);
		Fw6().set_TabIndex(928);
		Fw6().set_TabStop(false);
		((Control)f7X()).set_Location(new Point(110, 299));
		((Control)f7X()).set_Name("PictureBox96");
		((Control)f7X()).set_Size(new Size(10, 12));
		f7X().set_SizeMode((PictureBoxSizeMode)4);
		f7X().set_TabIndex(927);
		f7X().set_TabStop(false);
		((Control)Wt4()).set_Location(new Point(94, 299));
		((Control)Wt4()).set_Name("PictureBox97");
		((Control)Wt4()).set_Size(new Size(10, 12));
		Wt4().set_SizeMode((PictureBoxSizeMode)4);
		Wt4().set_TabIndex(926);
		Wt4().set_TabStop(false);
		((Control)q5F()).set_Location(new Point(78, 299));
		((Control)q5F()).set_Name("PictureBox98");
		((Control)q5F()).set_Size(new Size(10, 12));
		q5F().set_SizeMode((PictureBoxSizeMode)4);
		q5F().set_TabIndex(925);
		q5F().set_TabStop(false);
		((Control)Gd6()).set_Location(new Point(62, 299));
		((Control)Gd6()).set_Name("PictureBox99");
		((Control)Gd6()).set_Size(new Size(10, 12));
		Gd6().set_SizeMode((PictureBoxSizeMode)4);
		Gd6().set_TabIndex(924);
		Gd6().set_TabStop(false);
		((Control)Yf8()).set_Location(new Point(48, 299));
		((Control)Yf8()).set_Name("PictureBox100");
		((Control)Yf8()).set_Size(new Size(10, 12));
		Yf8().set_SizeMode((PictureBoxSizeMode)4);
		Yf8().set_TabIndex(923);
		Yf8().set_TabStop(false);
		((Control)p0T()).set_Location(new Point(372, 187));
		((Control)p0T()).set_Name("PictureBox61");
		((Control)p0T()).set_Size(new Size(10, 10));
		p0T().set_SizeMode((PictureBoxSizeMode)4);
		p0T().set_TabIndex(922);
		p0T().set_TabStop(false);
		((Control)Qj6()).set_Location(new Point(352, 187));
		((Control)Qj6()).set_Name("PictureBox62");
		((Control)Qj6()).set_Size(new Size(10, 10));
		Qj6().set_SizeMode((PictureBoxSizeMode)4);
		Qj6().set_TabIndex(921);
		Qj6().set_TabStop(false);
		((Control)Kg4()).set_Location(new Point(333, 187));
		((Control)Kg4()).set_Name("PictureBox63");
		((Control)Kg4()).set_Size(new Size(10, 10));
		Kg4().set_SizeMode((PictureBoxSizeMode)4);
		Kg4().set_TabIndex(920);
		Kg4().set_TabStop(false);
		((Control)Kd3()).set_Location(new Point(314, 187));
		((Control)Kd3()).set_Name("PictureBox64");
		((Control)Kd3()).set_Size(new Size(10, 10));
		Kd3().set_SizeMode((PictureBoxSizeMode)4);
		Kd3().set_TabIndex(919);
		Kd3().set_TabStop(false);
		((Control)Ns7()).set_Location(new Point(296, 187));
		((Control)Ns7()).set_Name("PictureBox65");
		((Control)Ns7()).set_Size(new Size(10, 10));
		Ns7().set_SizeMode((PictureBoxSizeMode)4);
		Ns7().set_TabIndex(918);
		Ns7().set_TabStop(false);
		((Control)m3K()).set_Location(new Point(279, 187));
		((Control)m3K()).set_Name("PictureBox66");
		((Control)m3K()).set_Size(new Size(10, 10));
		m3K().set_SizeMode((PictureBoxSizeMode)4);
		m3K().set_TabIndex(917);
		m3K().set_TabStop(false);
		((Control)q6T()).set_Location(new Point(261, 187));
		((Control)q6T()).set_Name("PictureBox67");
		((Control)q6T()).set_Size(new Size(10, 10));
		q6T().set_SizeMode((PictureBoxSizeMode)4);
		q6T().set_TabIndex(916);
		q6T().set_TabStop(false);
		((Control)Pm2()).set_Location(new Point(245, 187));
		((Control)Pm2()).set_Name("PictureBox68");
		((Control)Pm2()).set_Size(new Size(10, 10));
		Pm2().set_SizeMode((PictureBoxSizeMode)4);
		Pm2().set_TabIndex(915);
		Pm2().set_TabStop(false);
		((Control)o3A()).set_Location(new Point(227, 187));
		((Control)o3A()).set_Name("PictureBox69");
		((Control)o3A()).set_Size(new Size(10, 10));
		o3A().set_SizeMode((PictureBoxSizeMode)4);
		o3A().set_TabIndex(914);
		o3A().set_TabStop(false);
		((Control)f2P()).set_Location(new Point(208, 187));
		((Control)f2P()).set_Name("PictureBox70");
		((Control)f2P()).set_Size(new Size(10, 10));
		f2P().set_SizeMode((PictureBoxSizeMode)4);
		f2P().set_TabIndex(913);
		f2P().set_TabStop(false);
		((Control)n9S()).set_Location(new Point(190, 187));
		((Control)n9S()).set_Name("PictureBox71");
		((Control)n9S()).set_Size(new Size(10, 10));
		n9S().set_SizeMode((PictureBoxSizeMode)4);
		n9S().set_TabIndex(912);
		n9S().set_TabStop(false);
		((Control)b0L()).set_Location(new Point(174, 187));
		((Control)b0L()).set_Name("PictureBox72");
		((Control)b0L()).set_Size(new Size(10, 10));
		b0L().set_SizeMode((PictureBoxSizeMode)4);
		b0L().set_TabIndex(911);
		b0L().set_TabStop(false);
		((Control)Ly0()).set_Location(new Point(158, 187));
		((Control)Ly0()).set_Name("PictureBox73");
		((Control)Ly0()).set_Size(new Size(10, 10));
		Ly0().set_SizeMode((PictureBoxSizeMode)4);
		Ly0().set_TabIndex(910);
		Ly0().set_TabStop(false);
		((Control)k1W()).set_Location(new Point(142, 187));
		((Control)k1W()).set_Name("PictureBox74");
		((Control)k1W()).set_Size(new Size(10, 10));
		k1W().set_SizeMode((PictureBoxSizeMode)4);
		k1W().set_TabIndex(909);
		k1W().set_TabStop(false);
		((Control)Kr7()).set_Location(new Point(126, 187));
		((Control)Kr7()).set_Name("PictureBox75");
		((Control)Kr7()).set_Size(new Size(10, 10));
		Kr7().set_SizeMode((PictureBoxSizeMode)4);
		Kr7().set_TabIndex(908);
		Kr7().set_TabStop(false);
		((Control)Ce1()).set_Location(new Point(110, 187));
		((Control)Ce1()).set_Name("PictureBox76");
		((Control)Ce1()).set_Size(new Size(10, 10));
		Ce1().set_SizeMode((PictureBoxSizeMode)4);
		Ce1().set_TabIndex(907);
		Ce1().set_TabStop(false);
		((Control)Co0()).set_Location(new Point(94, 187));
		((Control)Co0()).set_Name("PictureBox77");
		((Control)Co0()).set_Size(new Size(10, 10));
		Co0().set_SizeMode((PictureBoxSizeMode)4);
		Co0().set_TabIndex(906);
		Co0().set_TabStop(false);
		((Control)n0C()).set_Location(new Point(78, 187));
		((Control)n0C()).set_Name("PictureBox78");
		((Control)n0C()).set_Size(new Size(10, 10));
		n0C().set_SizeMode((PictureBoxSizeMode)4);
		n0C().set_TabIndex(905);
		n0C().set_TabStop(false);
		((Control)Xy0()).set_Location(new Point(62, 187));
		((Control)Xy0()).set_Name("PictureBox79");
		((Control)Xy0()).set_Size(new Size(10, 10));
		Xy0().set_SizeMode((PictureBoxSizeMode)4);
		Xy0().set_TabIndex(904);
		Xy0().set_TabStop(false);
		((Control)b5F()).set_Location(new Point(48, 187));
		((Control)b5F()).set_Name("PictureBox80");
		((Control)b5F()).set_Size(new Size(10, 10));
		b5F().set_SizeMode((PictureBoxSizeMode)4);
		b5F().set_TabIndex(903);
		b5F().set_TabStop(false);
		((Control)e4E()).set_Location(new Point(372, 165));
		((Control)e4E()).set_Name("PictureBox41");
		((Control)e4E()).set_Size(new Size(10, 10));
		e4E().set_SizeMode((PictureBoxSizeMode)4);
		e4E().set_TabIndex(902);
		e4E().set_TabStop(false);
		((Control)Lg1()).set_Location(new Point(352, 165));
		((Control)Lg1()).set_Name("PictureBox42");
		((Control)Lg1()).set_Size(new Size(10, 10));
		Lg1().set_SizeMode((PictureBoxSizeMode)4);
		Lg1().set_TabIndex(901);
		Lg1().set_TabStop(false);
		((Control)Mm9()).set_Location(new Point(333, 165));
		((Control)Mm9()).set_Name("PictureBox43");
		((Control)Mm9()).set_Size(new Size(10, 10));
		Mm9().set_SizeMode((PictureBoxSizeMode)4);
		Mm9().set_TabIndex(900);
		Mm9().set_TabStop(false);
		((Control)j0J()).set_Location(new Point(314, 165));
		((Control)j0J()).set_Name("PictureBox44");
		((Control)j0J()).set_Size(new Size(10, 10));
		j0J().set_SizeMode((PictureBoxSizeMode)4);
		j0J().set_TabIndex(899);
		j0J().set_TabStop(false);
		((Control)d9N()).set_Location(new Point(296, 165));
		((Control)d9N()).set_Name("PictureBox45");
		((Control)d9N()).set_Size(new Size(10, 10));
		d9N().set_SizeMode((PictureBoxSizeMode)4);
		d9N().set_TabIndex(898);
		d9N().set_TabStop(false);
		((Control)a6T()).set_Location(new Point(279, 165));
		((Control)a6T()).set_Name("PictureBox46");
		((Control)a6T()).set_Size(new Size(10, 10));
		a6T().set_SizeMode((PictureBoxSizeMode)4);
		a6T().set_TabIndex(897);
		a6T().set_TabStop(false);
		((Control)Ks7()).set_Location(new Point(261, 165));
		((Control)Ks7()).set_Name("PictureBox47");
		((Control)Ks7()).set_Size(new Size(10, 10));
		Ks7().set_SizeMode((PictureBoxSizeMode)4);
		Ks7().set_TabIndex(896);
		Ks7().set_TabStop(false);
		((Control)Kt6()).set_Location(new Point(245, 165));
		((Control)Kt6()).set_Name("PictureBox48");
		((Control)Kt6()).set_Size(new Size(10, 10));
		Kt6().set_SizeMode((PictureBoxSizeMode)4);
		Kt6().set_TabIndex(895);
		Kt6().set_TabStop(false);
		((Control)Ya9()).set_Location(new Point(227, 165));
		((Control)Ya9()).set_Name("PictureBox49");
		((Control)Ya9()).set_Size(new Size(10, 10));
		Ya9().set_SizeMode((PictureBoxSizeMode)4);
		Ya9().set_TabIndex(894);
		Ya9().set_TabStop(false);
		((Control)Mr8()).set_Location(new Point(208, 165));
		((Control)Mr8()).set_Name("PictureBox50");
		((Control)Mr8()).set_Size(new Size(10, 10));
		Mr8().set_SizeMode((PictureBoxSizeMode)4);
		Mr8().set_TabIndex(893);
		Mr8().set_TabStop(false);
		((Control)Fr6()).set_Location(new Point(190, 165));
		((Control)Fr6()).set_Name("PictureBox51");
		((Control)Fr6()).set_Size(new Size(10, 10));
		Fr6().set_SizeMode((PictureBoxSizeMode)4);
		Fr6().set_TabIndex(892);
		Fr6().set_TabStop(false);
		((Control)s5X()).set_Location(new Point(174, 165));
		((Control)s5X()).set_Name("PictureBox52");
		((Control)s5X()).set_Size(new Size(10, 10));
		s5X().set_SizeMode((PictureBoxSizeMode)4);
		s5X().set_TabIndex(891);
		s5X().set_TabStop(false);
		((Control)n2Q()).set_Location(new Point(158, 165));
		((Control)n2Q()).set_Name("PictureBox53");
		((Control)n2Q()).set_Size(new Size(10, 10));
		n2Q().set_SizeMode((PictureBoxSizeMode)4);
		n2Q().set_TabIndex(890);
		n2Q().set_TabStop(false);
		((Control)Hs6()).set_Location(new Point(142, 165));
		((Control)Hs6()).set_Name("PictureBox54");
		((Control)Hs6()).set_Size(new Size(10, 10));
		Hs6().set_SizeMode((PictureBoxSizeMode)4);
		Hs6().set_TabIndex(889);
		Hs6().set_TabStop(false);
		((Control)Pz8()).set_Location(new Point(126, 165));
		((Control)Pz8()).set_Name("PictureBox55");
		((Control)Pz8()).set_Size(new Size(10, 10));
		Pz8().set_SizeMode((PictureBoxSizeMode)4);
		Pz8().set_TabIndex(888);
		Pz8().set_TabStop(false);
		((Control)Dc6()).set_Location(new Point(110, 165));
		((Control)Dc6()).set_Name("PictureBox56");
		((Control)Dc6()).set_Size(new Size(10, 10));
		Dc6().set_SizeMode((PictureBoxSizeMode)4);
		Dc6().set_TabIndex(887);
		Dc6().set_TabStop(false);
		((Control)Mb2()).set_Location(new Point(94, 165));
		((Control)Mb2()).set_Name("PictureBox57");
		((Control)Mb2()).set_Size(new Size(10, 10));
		Mb2().set_SizeMode((PictureBoxSizeMode)4);
		Mb2().set_TabIndex(886);
		Mb2().set_TabStop(false);
		((Control)Pi7()).set_Location(new Point(78, 165));
		((Control)Pi7()).set_Name("PictureBox58");
		((Control)Pi7()).set_Size(new Size(10, 10));
		Pi7().set_SizeMode((PictureBoxSizeMode)4);
		Pi7().set_TabIndex(885);
		Pi7().set_TabStop(false);
		((Control)Nx5()).set_Location(new Point(62, 165));
		((Control)Nx5()).set_Name("PictureBox59");
		((Control)Nx5()).set_Size(new Size(10, 10));
		Nx5().set_SizeMode((PictureBoxSizeMode)4);
		Nx5().set_TabIndex(884);
		Nx5().set_TabStop(false);
		((Control)r7D()).set_Location(new Point(48, 165));
		((Control)r7D()).set_Name("PictureBox60");
		((Control)r7D()).set_Size(new Size(10, 10));
		r7D().set_SizeMode((PictureBoxSizeMode)4);
		r7D().set_TabIndex(883);
		r7D().set_TabStop(false);
		((Control)j7Y()).set_Location(new Point(372, 143));
		((Control)j7Y()).set_Name("PictureBox21");
		((Control)j7Y()).set_Size(new Size(10, 10));
		j7Y().set_SizeMode((PictureBoxSizeMode)4);
		j7Y().set_TabIndex(882);
		j7Y().set_TabStop(false);
		((Control)Qy4()).set_Location(new Point(352, 143));
		((Control)Qy4()).set_Name("PictureBox22");
		((Control)Qy4()).set_Size(new Size(10, 10));
		Qy4().set_SizeMode((PictureBoxSizeMode)4);
		Qy4().set_TabIndex(881);
		Qy4().set_TabStop(false);
		((Control)Kj8()).set_Location(new Point(333, 143));
		((Control)Kj8()).set_Name("PictureBox23");
		((Control)Kj8()).set_Size(new Size(10, 10));
		Kj8().set_SizeMode((PictureBoxSizeMode)4);
		Kj8().set_TabIndex(880);
		Kj8().set_TabStop(false);
		((Control)Tt0()).set_Location(new Point(314, 143));
		((Control)Tt0()).set_Name("PictureBox24");
		((Control)Tt0()).set_Size(new Size(10, 10));
		Tt0().set_SizeMode((PictureBoxSizeMode)4);
		Tt0().set_TabIndex(879);
		Tt0().set_TabStop(false);
		((Control)Yp8()).set_Location(new Point(296, 143));
		((Control)Yp8()).set_Name("PictureBox25");
		((Control)Yp8()).set_Size(new Size(10, 10));
		Yp8().set_SizeMode((PictureBoxSizeMode)4);
		Yp8().set_TabIndex(878);
		Yp8().set_TabStop(false);
		((Control)w5C()).set_Location(new Point(279, 143));
		((Control)w5C()).set_Name("PictureBox26");
		((Control)w5C()).set_Size(new Size(10, 10));
		w5C().set_SizeMode((PictureBoxSizeMode)4);
		w5C().set_TabIndex(877);
		w5C().set_TabStop(false);
		((Control)q6Q()).set_Location(new Point(261, 143));
		((Control)q6Q()).set_Name("PictureBox27");
		((Control)q6Q()).set_Size(new Size(10, 10));
		q6Q().set_SizeMode((PictureBoxSizeMode)4);
		q6Q().set_TabIndex(876);
		q6Q().set_TabStop(false);
		((Control)Kd6()).set_Location(new Point(245, 143));
		((Control)Kd6()).set_Name("PictureBox28");
		((Control)Kd6()).set_Size(new Size(10, 10));
		Kd6().set_SizeMode((PictureBoxSizeMode)4);
		Kd6().set_TabIndex(875);
		Kd6().set_TabStop(false);
		((Control)y1A()).set_Location(new Point(227, 143));
		((Control)y1A()).set_Name("PictureBox29");
		((Control)y1A()).set_Size(new Size(10, 10));
		y1A().set_SizeMode((PictureBoxSizeMode)4);
		y1A().set_TabIndex(874);
		y1A().set_TabStop(false);
		((Control)e5N()).set_Location(new Point(208, 143));
		((Control)e5N()).set_Name("PictureBox30");
		((Control)e5N()).set_Size(new Size(10, 10));
		e5N().set_SizeMode((PictureBoxSizeMode)4);
		e5N().set_TabIndex(873);
		e5N().set_TabStop(false);
		((Control)Lo6()).set_Location(new Point(190, 143));
		((Control)Lo6()).set_Name("PictureBox31");
		((Control)Lo6()).set_Size(new Size(10, 10));
		Lo6().set_SizeMode((PictureBoxSizeMode)4);
		Lo6().set_TabIndex(872);
		Lo6().set_TabStop(false);
		((Control)Pe5p()).set_Location(new Point(174, 143));
		((Control)Pe5p()).set_Name("PictureBox32");
		((Control)Pe5p()).set_Size(new Size(10, 10));
		Pe5p().set_SizeMode((PictureBoxSizeMode)4);
		Pe5p().set_TabIndex(871);
		Pe5p().set_TabStop(false);
		((Control)j3MB()).set_Location(new Point(158, 143));
		((Control)j3MB()).set_Name("PictureBox33");
		((Control)j3MB()).set_Size(new Size(10, 10));
		j3MB().set_SizeMode((PictureBoxSizeMode)4);
		j3MB().set_TabIndex(870);
		j3MB().set_TabStop(false);
		((Control)Ki96()).set_Location(new Point(142, 143));
		((Control)Ki96()).set_Name("PictureBox34");
		((Control)Ki96()).set_Size(new Size(10, 10));
		Ki96().set_SizeMode((PictureBoxSizeMode)4);
		Ki96().set_TabIndex(869);
		Ki96().set_TabStop(false);
		((Control)Yq27()).set_Location(new Point(126, 143));
		((Control)Yq27()).set_Name("PictureBox35");
		((Control)Yq27()).set_Size(new Size(10, 10));
		Yq27().set_SizeMode((PictureBoxSizeMode)4);
		Yq27().set_TabIndex(868);
		Yq27().set_TabStop(false);
		((Control)t3RJ()).set_Location(new Point(110, 143));
		((Control)t3RJ()).set_Name("PictureBox36");
		((Control)t3RJ()).set_Size(new Size(10, 10));
		t3RJ().set_SizeMode((PictureBoxSizeMode)4);
		t3RJ().set_TabIndex(867);
		t3RJ().set_TabStop(false);
		((Control)t4EG()).set_Location(new Point(94, 143));
		((Control)t4EG()).set_Name("PictureBox37");
		((Control)t4EG()).set_Size(new Size(10, 10));
		t4EG().set_SizeMode((PictureBoxSizeMode)4);
		t4EG().set_TabIndex(866);
		t4EG().set_TabStop(false);
		((Control)Lj34()).set_Location(new Point(78, 143));
		((Control)Lj34()).set_Name("PictureBox38");
		((Control)Lj34()).set_Size(new Size(10, 10));
		Lj34().set_SizeMode((PictureBoxSizeMode)4);
		Lj34().set_TabIndex(865);
		Lj34().set_TabStop(false);
		((Control)Cm05()).set_Location(new Point(151, 16));
		((Control)Cm05()).set_Name("txtAvailable");
		((Control)Cm05()).set_Size(new Size(83, 20));
		((Control)Cm05()).set_TabIndex(25);
		((Control)w6AW()).set_BackColor(Color.Transparent);
		((Control)w6AW()).set_Location(new Point(5, 47));
		((Control)w6AW()).set_Name("Booked");
		((Control)w6AW()).set_Size(new Size(23, 18));
		w6AW().set_SizeMode((PictureBoxSizeMode)4);
		w6AW().set_TabIndex(27);
		w6AW().set_TabStop(false);
		((Control)r9XC()).set_BackColor(Color.Transparent);
		((Control)r9XC()).set_Location(new Point(6, 74));
		((Control)r9XC()).set_Name("Provisional");
		((Control)r9XC()).set_Size(new Size(23, 17));
		r9XC().set_SizeMode((PictureBoxSizeMode)4);
		r9XC().set_TabIndex(26);
		r9XC().set_TabStop(false);
		((Control)j9G1()).set_BackColor(Color.Transparent);
		((Control)j9G1()).set_Location(new Point(5, 23));
		((Control)j9G1()).set_Name("Available");
		((Control)j9G1()).set_Size(new Size(23, 17));
		j9G1().set_SizeMode((PictureBoxSizeMode)4);
		j9G1().set_TabIndex(25);
		j9G1().set_TabStop(false);
		d1LQ().set_AutoSize(true);
		((Control)d1LQ()).set_BackColor(Color.Transparent);
		((Control)d1LQ()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)d1LQ()).set_Location(new Point(30, 49));
		((Control)d1LQ()).set_Name("Label3");
		((Control)d1LQ()).set_Size(new Size(74, 13));
		((Control)d1LQ()).set_TabIndex(12);
		d1LQ().set_Text("Booked Seats");
		((Control)o8LX()).set_Location(new Point(62, 143));
		((Control)o8LX()).set_Name("PictureBox39");
		((Control)o8LX()).set_Size(new Size(10, 10));
		o8LX().set_SizeMode((PictureBoxSizeMode)4);
		o8LX().set_TabIndex(864);
		o8LX().set_TabStop(false);
		((Control)Rr43()).set_Location(new Point(151, 42));
		((Control)Rr43()).set_Name("txtBooked");
		((Control)Rr43()).set_Size(new Size(83, 20));
		((Control)Rr43()).set_TabIndex(28);
		o1SF().set_AutoSize(true);
		((Control)o1SF()).set_BackColor(Color.Transparent);
		((Control)o1SF()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)o1SF()).set_Location(new Point(30, 76));
		((Control)o1SF()).set_Name("Label1");
		((Control)o1SF()).set_Size(new Size(115, 13));
		((Control)o1SF()).set_TabIndex(11);
		o1SF().set_Text("Seat[s] on Reservation");
		n9R2().set_AutoSize(true);
		((Control)n9R2()).set_BackColor(Color.Transparent);
		((Control)n9R2()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)n9R2()).set_Location(new Point(30, 24));
		((Control)n9R2()).set_Name("Label2");
		((Control)n9R2()).set_Size(new Size(80, 13));
		((Control)n9R2()).set_TabIndex(10);
		n9R2().set_Text("Available Seats");
		((Control)Fk90()).set_Location(new Point(48, 143));
		((Control)Fk90()).set_Name("PictureBox40");
		((Control)Fk90()).set_Size(new Size(10, 10));
		Fk90().set_SizeMode((PictureBoxSizeMode)4);
		Fk90().set_TabIndex(863);
		Fk90().set_TabStop(false);
		((Control)Lz4x()).set_Location(new Point(372, 121));
		((Control)Lz4x()).set_Name("PictureBox20");
		((Control)Lz4x()).set_Size(new Size(10, 10));
		Lz4x().set_SizeMode((PictureBoxSizeMode)4);
		Lz4x().set_TabIndex(862);
		Lz4x().set_TabStop(false);
		((Control)q8FC()).set_Location(new Point(352, 121));
		((Control)q8FC()).set_Name("PictureBox19");
		((Control)q8FC()).set_Size(new Size(10, 10));
		q8FC().set_SizeMode((PictureBoxSizeMode)4);
		q8FC().set_TabIndex(861);
		q8FC().set_TabStop(false);
		((Control)Tt07()).set_Location(new Point(333, 121));
		((Control)Tt07()).set_Name("PictureBox18");
		((Control)Tt07()).set_Size(new Size(10, 10));
		Tt07().set_SizeMode((PictureBoxSizeMode)4);
		Tt07().set_TabIndex(860);
		Tt07().set_TabStop(false);
		((Control)c3GC()).set_Location(new Point(314, 121));
		((Control)c3GC()).set_Name("PictureBox17");
		((Control)c3GC()).set_Size(new Size(10, 10));
		c3GC().set_SizeMode((PictureBoxSizeMode)4);
		c3GC().set_TabIndex(859);
		c3GC().set_TabStop(false);
		((Control)Cs12()).set_Location(new Point(296, 121));
		((Control)Cs12()).set_Name("PictureBox16");
		((Control)Cs12()).set_Size(new Size(10, 10));
		Cs12().set_SizeMode((PictureBoxSizeMode)4);
		Cs12().set_TabIndex(858);
		Cs12().set_TabStop(false);
		((Control)Wt4n()).set_Location(new Point(279, 121));
		((Control)Wt4n()).set_Name("PictureBox15");
		((Control)Wt4n()).set_Size(new Size(10, 10));
		Wt4n().set_SizeMode((PictureBoxSizeMode)4);
		Wt4n().set_TabIndex(857);
		Wt4n().set_TabStop(false);
		((Control)o1H7()).set_Location(new Point(261, 121));
		((Control)o1H7()).set_Name("PictureBox14");
		((Control)o1H7()).set_Size(new Size(10, 10));
		o1H7().set_SizeMode((PictureBoxSizeMode)4);
		o1H7().set_TabIndex(856);
		o1H7().set_TabStop(false);
		((Control)y1HE()).set_Location(new Point(245, 121));
		((Control)y1HE()).set_Name("PictureBox13");
		((Control)y1HE()).set_Size(new Size(10, 10));
		y1HE().set_SizeMode((PictureBoxSizeMode)4);
		y1HE().set_TabIndex(855);
		y1HE().set_TabStop(false);
		((Control)n7KM()).set_Location(new Point(227, 121));
		((Control)n7KM()).set_Name("PictureBox12");
		((Control)n7KM()).set_Size(new Size(10, 10));
		n7KM().set_SizeMode((PictureBoxSizeMode)4);
		n7KM().set_TabIndex(854);
		n7KM().set_TabStop(false);
		((Control)Dr0w()).set_Location(new Point(208, 121));
		((Control)Dr0w()).set_Name("PictureBox11");
		((Control)Dr0w()).set_Size(new Size(10, 10));
		Dr0w().set_SizeMode((PictureBoxSizeMode)4);
		Dr0w().set_TabIndex(853);
		Dr0w().set_TabStop(false);
		((Control)s1S3()).set_Location(new Point(190, 121));
		((Control)s1S3()).set_Name("PictureBox10");
		((Control)s1S3()).set_Size(new Size(10, 10));
		s1S3().set_SizeMode((PictureBoxSizeMode)4);
		s1S3().set_TabIndex(852);
		s1S3().set_TabStop(false);
		((Control)Ck2n()).set_Location(new Point(174, 121));
		((Control)Ck2n()).set_Name("PictureBox9");
		((Control)Ck2n()).set_Size(new Size(10, 10));
		Ck2n().set_SizeMode((PictureBoxSizeMode)4);
		Ck2n().set_TabIndex(851);
		Ck2n().set_TabStop(false);
		((Control)b8JA()).set_Location(new Point(158, 121));
		((Control)b8JA()).set_Name("PictureBox8");
		((Control)b8JA()).set_Size(new Size(10, 10));
		b8JA().set_SizeMode((PictureBoxSizeMode)4);
		b8JA().set_TabIndex(850);
		b8JA().set_TabStop(false);
		((Control)q6D4()).set_Location(new Point(142, 121));
		((Control)q6D4()).set_Name("PictureBox7");
		((Control)q6D4()).set_Size(new Size(10, 10));
		q6D4().set_SizeMode((PictureBoxSizeMode)4);
		q6D4().set_TabIndex(849);
		q6D4().set_TabStop(false);
		((Control)z2G8()).set_Location(new Point(126, 121));
		((Control)z2G8()).set_Name("PictureBox6");
		((Control)z2G8()).set_Size(new Size(10, 10));
		z2G8().set_SizeMode((PictureBoxSizeMode)4);
		z2G8().set_TabIndex(848);
		z2G8().set_TabStop(false);
		((Control)m7HX()).set_Location(new Point(110, 121));
		((Control)m7HX()).set_Name("PictureBox5");
		((Control)m7HX()).set_Size(new Size(10, 10));
		m7HX().set_SizeMode((PictureBoxSizeMode)4);
		m7HX().set_TabIndex(847);
		m7HX().set_TabStop(false);
		((Control)Sf7k()).set_Location(new Point(94, 121));
		((Control)Sf7k()).set_Name("PictureBox4");
		((Control)Sf7k()).set_Size(new Size(10, 10));
		Sf7k().set_SizeMode((PictureBoxSizeMode)4);
		Sf7k().set_TabIndex(846);
		Sf7k().set_TabStop(false);
		((Control)e6DC()).set_Location(new Point(78, 121));
		((Control)e6DC()).set_Name("PictureBox3");
		((Control)e6DC()).set_Size(new Size(10, 10));
		e6DC().set_SizeMode((PictureBoxSizeMode)4);
		e6DC().set_TabIndex(845);
		e6DC().set_TabStop(false);
		((Control)En97()).set_Location(new Point(62, 121));
		((Control)En97()).set_Name("PictureBox2");
		((Control)En97()).set_Size(new Size(10, 10));
		En97().set_SizeMode((PictureBoxSizeMode)4);
		En97().set_TabIndex(844);
		En97().set_TabStop(false);
		((Control)Ec2t()).set_Location(new Point(48, 121));
		((Control)Ec2t()).set_Name("PictureBox1");
		((Control)Ec2t()).set_Size(new Size(10, 10));
		Ec2t().set_SizeMode((PictureBoxSizeMode)4);
		Ec2t().set_TabIndex(843);
		Ec2t().set_TabStop(false);
		g9Y0().set_AutoSize(true);
		((Control)g9Y0()).set_Location(new Point(367, 256));
		((Control)g9Y0()).set_Name("Label32");
		((Control)g9Y0()).set_Size(new Size(19, 13));
		((Control)g9Y0()).set_TabIndex(842);
		g9Y0().set_Text("20");
		Kf1q().set_AutoSize(true);
		((Control)Kf1q()).set_Location(new Point(274, 256));
		((Control)Kf1q()).set_Name("Label33");
		((Control)Kf1q()).set_Size(new Size(19, 13));
		((Control)Kf1q()).set_TabIndex(841);
		Kf1q().set_Text("15");
		k0XZ().set_AutoSize(true);
		((Control)k0XZ()).set_Location(new Point(309, 256));
		((Control)k0XZ()).set_Name("Label34");
		((Control)k0XZ()).set_Size(new Size(19, 13));
		((Control)k0XZ()).set_TabIndex(840);
		k0XZ().set_Text("17");
		Fo0t().set_AutoSize(true);
		((Control)Fo0t()).set_Location(new Point(328, 256));
		((Control)Fo0t()).set_Name("Label35");
		((Control)Fo0t()).set_Size(new Size(19, 13));
		((Control)Fo0t()).set_TabIndex(839);
		Fo0t().set_Text("18");
		c5HS().set_AutoSize(true);
		((Control)c5HS()).set_Location(new Point(347, 256));
		((Control)c5HS()).set_Name("Label36");
		((Control)c5HS()).set_Size(new Size(19, 13));
		((Control)c5HS()).set_TabIndex(838);
		c5HS().set_Text("19");
		g0Q1().set_AutoSize(true);
		((Control)g0Q1()).set_Location(new Point(222, 256));
		((Control)g0Q1()).set_Name("Label37");
		((Control)g0Q1()).set_Size(new Size(19, 13));
		((Control)g0Q1()).set_TabIndex(837);
		g0Q1().set_Text("12");
		j1BN().set_AutoSize(true);
		((Control)j1BN()).set_Location(new Point(240, 256));
		((Control)j1BN()).set_Name("Label39");
		((Control)j1BN()).set_Size(new Size(19, 13));
		((Control)j1BN()).set_TabIndex(835);
		j1BN().set_Text("13");
		Mw2p().set_AutoSize(true);
		((Control)Mw2p()).set_Location(new Point(291, 256));
		((Control)Mw2p()).set_Name("Label40");
		((Control)Mw2p()).set_Size(new Size(19, 13));
		((Control)Mw2p()).set_TabIndex(834);
		Mw2p().set_Text("16");
		o5MS().set_AutoSize(true);
		((Control)o5MS()).set_Location(new Point(205, 256));
		((Control)o5MS()).set_Name("Label41");
		((Control)o5MS()).set_Size(new Size(19, 13));
		((Control)o5MS()).set_TabIndex(833);
		o5MS().set_Text("11");
		n9Q0().set_AutoSize(true);
		((Control)n9Q0()).set_Location(new Point(256, 256));
		((Control)n9Q0()).set_Name("Label42");
		((Control)n9Q0()).set_Size(new Size(19, 13));
		((Control)n9Q0()).set_TabIndex(832);
		n9Q0().set_Text("14");
		Bc3m().set_AutoSize(true);
		((Control)Bc3m()).set_Location(new Point(155, 256));
		((Control)Bc3m()).set_Name("Label43");
		((Control)Bc3m()).set_Size(new Size(13, 13));
		((Control)Bc3m()).set_TabIndex(831);
		Bc3m().set_Text("8");
		Gz29().set_AutoSize(true);
		((Control)Gz29()).set_Location(new Point(91, 256));
		((Control)Gz29()).set_Name("Label38");
		((Control)Gz29()).set_Size(new Size(13, 13));
		((Control)Gz29()).set_TabIndex(836);
		Gz29().set_Text("4");
		g3Q0().set_AutoSize(true);
		((Control)g3Q0()).set_Location(new Point(187, 256));
		((Control)g3Q0()).set_Name("Label44");
		((Control)g3Q0()).set_Size(new Size(19, 13));
		((Control)g3Q0()).set_TabIndex(830);
		g3Q0().set_Text("10");
		e6D3().set_AutoSize(true);
		((Control)e6D3()).set_Location(new Point(171, 256));
		((Control)e6D3()).set_Name("Label45");
		((Control)e6D3()).set_Size(new Size(13, 13));
		((Control)e6D3()).set_TabIndex(829);
		e6D3().set_Text("9");
		Qk4d().set_AutoSize(true);
		((Control)Qk4d()).set_Location(new Point(139, 256));
		((Control)Qk4d()).set_Name("Label46");
		((Control)Qk4d()).set_Size(new Size(13, 13));
		((Control)Qk4d()).set_TabIndex(828);
		Qk4d().set_Text("7");
		c4YZ().set_AutoSize(true);
		((Control)c4YZ()).set_Location(new Point(123, 256));
		((Control)c4YZ()).set_Name("Label47");
		((Control)c4YZ()).set_Size(new Size(13, 13));
		((Control)c4YZ()).set_TabIndex(827);
		c4YZ().set_Text("6");
		y7BS().set_AutoSize(true);
		((Control)y7BS()).set_Location(new Point(107, 256));
		((Control)y7BS()).set_Name("Label48");
		((Control)y7BS()).set_Size(new Size(13, 13));
		((Control)y7BS()).set_TabIndex(826);
		y7BS().set_Text("5");
		b3Q5().set_AutoSize(true);
		((Control)b3Q5()).set_Location(new Point(75, 256));
		((Control)b3Q5()).set_Name("Label49");
		((Control)b3Q5()).set_Size(new Size(13, 13));
		((Control)b3Q5()).set_TabIndex(825);
		b3Q5().set_Text("3");
		j8Z5().set_AutoSize(true);
		((Control)j8Z5()).set_Location(new Point(59, 256));
		((Control)j8Z5()).set_Name("Label50");
		((Control)j8Z5()).set_Size(new Size(13, 13));
		((Control)j8Z5()).set_TabIndex(824);
		j8Z5().set_Text("2");
		a7ZN().set_AutoSize(true);
		((Control)a7ZN()).set_Location(new Point(43, 256));
		((Control)a7ZN()).set_Name("Label51");
		((Control)a7ZN()).set_Size(new Size(13, 13));
		((Control)a7ZN()).set_TabIndex(823);
		a7ZN().set_Text("1");
		Js8g().set_AutoSize(true);
		((Control)Js8g()).set_Location(new Point(29, 362));
		((Control)Js8g()).set_Name("Label54");
		((Control)Js8g()).set_Size(new Size(15, 13));
		((Control)Js8g()).set_TabIndex(822);
		Js8g().set_Text("H");
		Dk6a().set_AutoSize(true);
		((Control)Dk6a()).set_Location(new Point(29, 340));
		((Control)Dk6a()).set_Name("Label55");
		((Control)Dk6a()).set_Size(new Size(15, 13));
		((Control)Dk6a()).set_TabIndex(821);
		Dk6a().set_Text("G");
		k3X0().set_AutoSize(true);
		((Control)k3X0()).set_Location(new Point(29, 318));
		((Control)k3X0()).set_Name("Label56");
		((Control)k3X0()).set_Size(new Size(13, 13));
		((Control)k3X0()).set_TabIndex(820);
		k3X0().set_Text("F");
		p6E3().set_AutoSize(true);
		((Control)p6E3()).set_Location(new Point(176, 222));
		((Control)p6E3()).set_Name("Label31");
		((Control)p6E3()).set_Size(new Size(72, 13));
		((Control)p6E3()).set_TabIndex(819);
		p6E3().set_Text("LOWER BOX");
		a6RS().set_AutoSize(true);
		((Control)a6RS()).set_Location(new Point(28, 299));
		((Control)a6RS()).set_Name("Label26");
		((Control)a6RS()).set_Size(new Size(14, 13));
		((Control)a6RS()).set_TabIndex(818);
		a6RS().set_Text("E");
		p8G3().set_AutoSize(true);
		((Control)p8G3()).set_Location(new Point(28, 187));
		((Control)p8G3()).set_Name("Label27");
		((Control)p8G3()).set_Size(new Size(15, 13));
		((Control)p8G3()).set_TabIndex(817);
		p8G3().set_Text("D");
		Dm74().set_AutoSize(true);
		((Control)Dm74()).set_Location(new Point(28, 165));
		((Control)Dm74()).set_Name("Label28");
		((Control)Dm74()).set_Size(new Size(14, 13));
		((Control)Dm74()).set_TabIndex(816);
		Dm74().set_Text("C");
		Dq0r().set_AutoSize(true);
		((Control)Dq0r()).set_Location(new Point(28, 143));
		((Control)Dq0r()).set_Name("Label29");
		((Control)Dq0r()).set_Size(new Size(14, 13));
		((Control)Dq0r()).set_TabIndex(815);
		Dq0r().set_Text("B");
		Kf45().set_AutoSize(true);
		((Control)Kf45()).set_Location(new Point(28, 121));
		((Control)Kf45()).set_Name("Label30");
		((Control)Kf45()).set_Size(new Size(14, 13));
		((Control)Kf45()).set_TabIndex(814);
		Kf45().set_Text("A");
		Me94().set_AutoSize(true);
		((Control)Me94()).set_Location(new Point(367, 75));
		((Control)Me94()).set_Name("Label25");
		((Control)Me94()).set_Size(new Size(19, 13));
		((Control)Me94()).set_TabIndex(813);
		Me94().set_Text("20");
		y9ES().set_AutoSize(true);
		((Control)y9ES()).set_Location(new Point(274, 75));
		((Control)y9ES()).set_Name("Label24");
		((Control)y9ES()).set_Size(new Size(19, 13));
		((Control)y9ES()).set_TabIndex(812);
		y9ES().set_Text("15");
		Zp0w().set_AutoSize(true);
		((Control)Zp0w()).set_Location(new Point(309, 75));
		((Control)Zp0w()).set_Name("Label23");
		((Control)Zp0w()).set_Size(new Size(19, 13));
		((Control)Zp0w()).set_TabIndex(811);
		Zp0w().set_Text("17");
		Lb1q().set_AutoSize(true);
		((Control)Lb1q()).set_Location(new Point(328, 75));
		((Control)Lb1q()).set_Name("Label22");
		((Control)Lb1q()).set_Size(new Size(19, 13));
		((Control)Lb1q()).set_TabIndex(810);
		Lb1q().set_Text("18");
		Ps0k().set_AutoSize(true);
		((Control)Ps0k()).set_Location(new Point(347, 75));
		((Control)Ps0k()).set_Name("Label21");
		((Control)Ps0k()).set_Size(new Size(19, 13));
		((Control)Ps0k()).set_TabIndex(809);
		Ps0k().set_Text("19");
		p5B2().set_AutoSize(true);
		((Control)p5B2()).set_Location(new Point(222, 75));
		((Control)p5B2()).set_Name("Label20");
		((Control)p5B2()).set_Size(new Size(19, 13));
		((Control)p5B2()).set_TabIndex(808);
		p5B2().set_Text("12");
		x7H2().set_AutoSize(true);
		((Control)x7H2()).set_Location(new Point(91, 75));
		((Control)x7H2()).set_Name("Label19");
		((Control)x7H2()).set_Size(new Size(13, 13));
		((Control)x7H2()).set_TabIndex(807);
		x7H2().set_Text("4");
		My9z().set_AutoSize(true);
		((Control)My9z()).set_Location(new Point(240, 75));
		((Control)My9z()).set_Name("Label18");
		((Control)My9z()).set_Size(new Size(19, 13));
		((Control)My9z()).set_TabIndex(806);
		My9z().set_Text("13");
		s9AF().set_AutoSize(true);
		((Control)s9AF()).set_Location(new Point(291, 75));
		((Control)s9AF()).set_Name("Label17");
		((Control)s9AF()).set_Size(new Size(19, 13));
		((Control)s9AF()).set_TabIndex(805);
		s9AF().set_Text("16");
		Rf54().set_AutoSize(true);
		((Control)Rf54()).set_Location(new Point(205, 75));
		((Control)Rf54()).set_Name("Label16");
		((Control)Rf54()).set_Size(new Size(19, 13));
		((Control)Rf54()).set_TabIndex(804);
		Rf54().set_Text("11");
		Ax3n().set_AutoSize(true);
		((Control)Ax3n()).set_Location(new Point(256, 75));
		((Control)Ax3n()).set_Name("Label15");
		((Control)Ax3n()).set_Size(new Size(19, 13));
		((Control)Ax3n()).set_TabIndex(803);
		Ax3n().set_Text("14");
		t0K5().set_AutoSize(true);
		((Control)t0K5()).set_Location(new Point(155, 75));
		((Control)t0K5()).set_Name("Label14");
		((Control)t0K5()).set_Size(new Size(13, 13));
		((Control)t0K5()).set_TabIndex(802);
		t0K5().set_Text("8");
		m2MD().set_AutoSize(true);
		((Control)m2MD()).set_Location(new Point(187, 75));
		((Control)m2MD()).set_Name("Label13");
		((Control)m2MD()).set_Size(new Size(19, 13));
		((Control)m2MD()).set_TabIndex(801);
		m2MD().set_Text("10");
		e7A6().set_AutoSize(true);
		((Control)e7A6()).set_Location(new Point(171, 75));
		((Control)e7A6()).set_Name("Label12");
		((Control)e7A6()).set_Size(new Size(13, 13));
		((Control)e7A6()).set_TabIndex(800);
		e7A6().set_Text("9");
		f6DE().set_AutoSize(true);
		((Control)f6DE()).set_Location(new Point(139, 75));
		((Control)f6DE()).set_Name("Label11");
		((Control)f6DE()).set_Size(new Size(13, 13));
		((Control)f6DE()).set_TabIndex(799);
		f6DE().set_Text("7");
		x0XR().set_AutoSize(true);
		((Control)x0XR()).set_Location(new Point(123, 75));
		((Control)x0XR()).set_Name("Label10");
		((Control)x0XR()).set_Size(new Size(13, 13));
		((Control)x0XR()).set_TabIndex(798);
		x0XR().set_Text("6");
		Zr53().set_AutoSize(true);
		((Control)Zr53()).set_Location(new Point(107, 75));
		((Control)Zr53()).set_Name("Label9");
		((Control)Zr53()).set_Size(new Size(13, 13));
		((Control)Zr53()).set_TabIndex(797);
		Zr53().set_Text("5");
		Mi84().set_AutoSize(true);
		((Control)Mi84()).set_Location(new Point(75, 75));
		((Control)Mi84()).set_Name("Label8");
		((Control)Mi84()).set_Size(new Size(13, 13));
		((Control)Mi84()).set_TabIndex(796);
		Mi84().set_Text("3");
		q7H3().set_AutoSize(true);
		((Control)q7H3()).set_Location(new Point(59, 75));
		((Control)q7H3()).set_Name("Label7");
		((Control)q7H3()).set_Size(new Size(13, 13));
		((Control)q7H3()).set_TabIndex(795);
		q7H3().set_Text("2");
		Lm39().set_AutoSize(true);
		((Control)Lm39()).set_Location(new Point(176, 48));
		((Control)Lm39()).set_Name("Label4");
		((Control)Lm39()).set_Size(new Size(69, 13));
		((Control)Lm39()).set_TabIndex(793);
		Lm39().set_Text("UPPER BOX");
		i3B2().set_AutoSize(true);
		((Control)i3B2()).set_Location(new Point(43, 75));
		((Control)i3B2()).set_Name("Label5");
		((Control)i3B2()).set_Size(new Size(13, 13));
		((Control)i3B2()).set_TabIndex(794);
		i3B2().set_Text("1");
		((Control)o4GF()).get_Controls().Add((Control)(object)Rn8y());
		((Control)o4GF()).get_Controls().Add((Control)(object)Ak6x());
		((Control)o4GF()).set_ForeColor(SystemColors.ControlLight);
		((Control)o4GF()).set_Location(new Point(471, 167));
		((Control)o4GF()).set_Name("GroupBox3");
		((Control)o4GF()).set_Size(new Size(200, 251));
		((Control)o4GF()).set_TabIndex(791);
		o4GF().set_TabStop(false);
		o4GF().set_Text("Movie On Display");
		((Control)Ak6x()).set_BackColor(Color.Transparent);
		((Control)Ak6x()).set_Location(new Point(39, 21));
		((Control)Ak6x()).set_Name("Cover");
		((Control)Ak6x()).set_Size(new Size(129, 187));
		Ak6x().set_SizeMode((PictureBoxSizeMode)4);
		Ak6x().set_TabIndex(25);
		Ak6x().set_TabStop(false);
		((Control)e5AG()).get_Controls().Add((Control)(object)o5CH());
		((Control)e5AG()).get_Controls().Add((Control)(object)Rr43());
		((Control)e5AG()).get_Controls().Add((Control)(object)Cm05());
		((Control)e5AG()).get_Controls().Add((Control)(object)w6AW());
		((Control)e5AG()).get_Controls().Add((Control)(object)r9XC());
		((Control)e5AG()).get_Controls().Add((Control)(object)j9G1());
		((Control)e5AG()).get_Controls().Add((Control)(object)d1LQ());
		((Control)e5AG()).get_Controls().Add((Control)(object)o1SF());
		((Control)e5AG()).get_Controls().Add((Control)(object)n9R2());
		((Control)e5AG()).set_ForeColor(SystemColors.ControlLight);
		((Control)e5AG()).set_Location(new Point(454, 48));
		((Control)e5AG()).set_Name("GroupBox1");
		((Control)e5AG()).set_Size(new Size(240, 100));
		((Control)e5AG()).set_TabIndex(789);
		e5AG().set_TabStop(false);
		e5AG().set_Text("Statistics");
		((Control)o5CH()).set_Location(new Point(151, 73));
		((Control)o5CH()).set_Name("txtProvisional");
		((Control)o5CH()).set_Size(new Size(83, 20));
		((Control)o5CH()).set_TabIndex(29);
		Kt1s().set_AutoSize(true);
		((Control)Kt1s()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Kt1s()).set_ForeColor(SystemColors.ControlLight);
		((Control)Kt1s()).set_Location(new Point(28, 6));
		((Control)Kt1s()).set_Name("Label6");
		((Control)Kt1s()).set_Size(new Size(106, 24));
		((Control)Kt1s()).set_TabIndex(788);
		Kt1s().set_Text("CINEMA 3");
		((Control)Ha15()).set_Location(new Point(435, 40));
		((Control)Ha15()).set_Name("Background");
		((Control)Ha15()).set_Size(new Size(474, 396));
		Ha15().set_SizeMode((PictureBoxSizeMode)1);
		Ha15().set_TabIndex(787);
		Ha15().set_TabStop(false);
		((Control)d0BQ()).set_BackColor(Color.Transparent);
		((Control)d0BQ()).set_Location(new Point(-2, -3));
		((Control)d0BQ()).set_Name("NameBox");
		((Control)d0BQ()).set_Size(new Size(914, 45));
		d0BQ().set_SizeMode((PictureBoxSizeMode)1);
		d0BQ().set_TabIndex(786);
		d0BQ().set_TabStop(false);
		((Control)Nc1f()).get_Controls().Add((Control)(object)Rp05());
		((Control)Nc1f()).get_Controls().Add((Control)(object)Lb71());
		((Control)Nc1f()).get_Controls().Add((Control)(object)Rj71());
		((Control)Nc1f()).get_Controls().Add((Control)(object)s9X5());
		((Control)Nc1f()).get_Controls().Add((Control)(object)a3A9());
		((Control)Nc1f()).get_Controls().Add((Control)(object)Td82());
		((Control)Nc1f()).get_Controls().Add((Control)(object)g7XZ());
		((Control)Nc1f()).get_Controls().Add((Control)(object)s4Z7());
		((Control)Nc1f()).get_Controls().Add((Control)(object)Qy4q());
		((Control)Nc1f()).get_Controls().Add((Control)(object)o7RL());
		((Control)Nc1f()).set_ForeColor(SystemColors.ControlLight);
		((Control)Nc1f()).set_Location(new Point(688, 188));
		((Control)Nc1f()).set_Name("GroupBox4");
		((Control)Nc1f()).set_Size(new Size(211, 231));
		((Control)Nc1f()).set_TabIndex(1004);
		Nc1f().set_TabStop(false);
		Nc1f().set_Text("Billing INFO");
		((ButtonBase)Rp05()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Rp05()).set_FlatStyle((FlatStyle)0);
		((Control)Rp05()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Rp05()).set_Location(new Point(72, 184));
		((Control)Rp05()).set_Name("btnSave");
		((Control)Rp05()).set_Size(new Size(133, 23));
		((Control)Rp05()).set_TabIndex(40);
		((ButtonBase)Rp05()).set_Text("Save / Receipt Preview");
		((ButtonBase)Rp05()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Lb71()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Lb71()).set_FlatStyle((FlatStyle)0);
		((Control)Lb71()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Lb71()).set_Location(new Point(103, 155));
		((Control)Lb71()).set_Name("btnCalculateChange");
		((Control)Lb71()).set_Size(new Size(101, 23));
		((Control)Lb71()).set_TabIndex(39);
		((ButtonBase)Lb71()).set_Text("Calculate Change");
		((ButtonBase)Lb71()).set_UseVisualStyleBackColor(true);
		((Control)Rj71()).set_Location(new Point(95, 123));
		((Control)Rj71()).set_Name("txtChange");
		((Control)Rj71()).set_Size(new Size(110, 20));
		((Control)Rj71()).set_TabIndex(34);
		((Control)s9X5()).set_Location(new Point(95, 91));
		((Control)s9X5()).set_Name("txtTotalPayment");
		((Control)s9X5()).set_Size(new Size(110, 20));
		((Control)s9X5()).set_TabIndex(33);
		((Control)a3A9()).set_Location(new Point(96, 58));
		((Control)a3A9()).set_Name("txtTotalCost");
		((Control)a3A9()).set_Size(new Size(109, 20));
		((Control)a3A9()).set_TabIndex(32);
		((Control)Td82()).set_Location(new Point(122, 24));
		((Control)Td82()).set_Name("txtSeats");
		((Control)Td82()).set_Size(new Size(83, 20));
		((Control)Td82()).set_TabIndex(31);
		g7XZ().set_AutoSize(true);
		((Control)g7XZ()).set_BackColor(Color.Transparent);
		((Control)g7XZ()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)g7XZ()).set_Location(new Point(8, 62));
		((Control)g7XZ()).set_Name("Label63");
		((Control)g7XZ()).set_Size(new Size(66, 13));
		((Control)g7XZ()).set_TabIndex(16);
		g7XZ().set_Text("Total Costs :");
		s4Z7().set_AutoSize(true);
		((Control)s4Z7()).set_BackColor(Color.Transparent);
		((Control)s4Z7()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)s4Z7()).set_Location(new Point(8, 27));
		((Control)s4Z7()).set_Name("Label64");
		((Control)s4Z7()).set_Size(new Size(106, 13));
		((Control)s4Z7()).set_TabIndex(15);
		s4Z7().set_Text("Seats to be booked :");
		Qy4q().set_AutoSize(true);
		((Control)Qy4q()).set_BackColor(Color.Transparent);
		((Control)Qy4q()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Qy4q()).set_Location(new Point(8, 121));
		((Control)Qy4q()).set_Name("Label61");
		((Control)Qy4q()).set_Size(new Size(50, 13));
		((Control)Qy4q()).set_TabIndex(14);
		Qy4q().set_Text("Change :");
		o7RL().set_AutoSize(true);
		((Control)o7RL()).set_BackColor(Color.Transparent);
		((Control)o7RL()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)o7RL()).set_Location(new Point(8, 91));
		((Control)o7RL()).set_Name("Label62");
		((Control)o7RL()).set_Size(new Size(81, 13));
		((Control)o7RL()).set_TabIndex(13);
		o7RL().set_Text("Total Payment :");
		((Control)e9JN()).get_Controls().Add((Control)(object)Jz71());
		((Control)e9JN()).get_Controls().Add((Control)(object)Qy83());
		((Control)e9JN()).get_Controls().Add((Control)(object)Pj17());
		((Control)e9JN()).get_Controls().Add((Control)(object)Bb36());
		((Control)e9JN()).get_Controls().Add((Control)(object)Qo8g());
		((Control)e9JN()).get_Controls().Add((Control)(object)Gg34());
		((Control)e9JN()).get_Controls().Add((Control)(object)Mw98());
		((Control)e9JN()).set_ForeColor(SystemColors.ControlLight);
		((Control)e9JN()).set_Location(new Point(699, 49));
		((Control)e9JN()).set_Name("GroupBox2");
		((Control)e9JN()).set_Size(new Size(200, 129));
		((Control)e9JN()).set_TabIndex(1003);
		e9JN().set_TabStop(false);
		e9JN().set_Text("Customer");
		((ButtonBase)Jz71()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Jz71()).set_FlatStyle((FlatStyle)0);
		((Control)Jz71()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Jz71()).set_Location(new Point(70, 90));
		((Control)Jz71()).set_Name("btnNew");
		((Control)Jz71()).set_Size(new Size(54, 23));
		((Control)Jz71()).set_TabIndex(39);
		((ButtonBase)Jz71()).set_Text("New");
		((ButtonBase)Jz71()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Qy83()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Qy83()).set_FlatStyle((FlatStyle)0);
		((Control)Qy83()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Qy83()).set_Location(new Point(130, 90));
		((Control)Qy83()).set_Name("btnReset");
		((Control)Qy83()).set_Size(new Size(54, 23));
		((Control)Qy83()).set_TabIndex(38);
		((ButtonBase)Qy83()).set_Text("Reset");
		((ButtonBase)Qy83()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Pj17()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Pj17()).set_FlatStyle((FlatStyle)0);
		((Control)Pj17()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Pj17()).set_Location(new Point(10, 90));
		((Control)Pj17()).set_Name("btnExisting");
		((Control)Pj17()).set_Size(new Size(54, 23));
		((Control)Pj17()).set_TabIndex(37);
		((ButtonBase)Pj17()).set_Text("Existing");
		((ButtonBase)Pj17()).set_UseVisualStyleBackColor(true);
		((Control)Bb36()).set_Location(new Point(94, 57));
		((Control)Bb36()).set_Name("txtFirstName");
		((Control)Bb36()).set_Size(new Size(103, 20));
		((Control)Bb36()).set_TabIndex(30);
		((Control)Qo8g()).set_Location(new Point(94, 31));
		((Control)Qo8g()).set_Name("txtID");
		((Control)Qo8g()).set_Size(new Size(103, 20));
		((Control)Qo8g()).set_TabIndex(29);
		Gg34().set_AutoSize(true);
		((Control)Gg34()).set_BackColor(Color.Transparent);
		((Control)Gg34()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Gg34()).set_Location(new Point(6, 58));
		((Control)Gg34()).set_Name("Label60");
		((Control)Gg34()).set_Size(new Size(57, 13));
		((Control)Gg34()).set_TabIndex(12);
		Gg34().set_Text("First Name");
		Mw98().set_AutoSize(true);
		((Control)Mw98()).set_BackColor(Color.Transparent);
		((Control)Mw98()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mw98()).set_Location(new Point(6, 34));
		((Control)Mw98()).set_Name("Label59");
		((Control)Mw98()).set_Size(new Size(65, 13));
		((Control)Mw98()).set_TabIndex(11);
		Mw98().set_Text("Customer ID");
		((ButtonBase)Rn8y()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Rn8y()).set_FlatStyle((FlatStyle)0);
		((Control)Rn8y()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Rn8y()).set_Location(new Point(42, 214));
		((Control)Rn8y()).set_Name("btnViewReservations");
		((Control)Rn8y()).set_Size(new Size(117, 23));
		((Control)Rn8y()).set_TabIndex(42);
		((ButtonBase)Rn8y()).set_Text("View Reservations");
		((ButtonBase)Rn8y()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)Nc1f());
		((Control)this).get_Controls().Add((Control)(object)e9JN());
		((Control)this).get_Controls().Add((Control)(object)g7H());
		((Control)this).get_Controls().Add((Control)(object)m9Z());
		((Control)this).get_Controls().Add((Control)(object)c4P());
		((Control)this).get_Controls().Add((Control)(object)w0P());
		((Control)this).get_Controls().Add((Control)(object)Ha7());
		((Control)this).get_Controls().Add((Control)(object)w0R());
		((Control)this).get_Controls().Add((Control)(object)Wb1());
		((Control)this).get_Controls().Add((Control)(object)x9L());
		((Control)this).get_Controls().Add((Control)(object)Mw9());
		((Control)this).get_Controls().Add((Control)(object)Cw4());
		((Control)this).get_Controls().Add((Control)(object)z5R());
		((Control)this).get_Controls().Add((Control)(object)z7Y());
		((Control)this).get_Controls().Add((Control)(object)r6W());
		((Control)this).get_Controls().Add((Control)(object)Qd6());
		((Control)this).get_Controls().Add((Control)(object)b3Q());
		((Control)this).get_Controls().Add((Control)(object)Mc4());
		((Control)this).get_Controls().Add((Control)(object)g5J());
		((Control)this).get_Controls().Add((Control)(object)Dq5());
		((Control)this).get_Controls().Add((Control)(object)Nq5());
		((Control)this).get_Controls().Add((Control)(object)Aq7());
		((Control)this).get_Controls().Add((Control)(object)m8S());
		((Control)this).get_Controls().Add((Control)(object)q7L());
		((Control)this).get_Controls().Add((Control)(object)d2B());
		((Control)this).get_Controls().Add((Control)(object)Fa7());
		((Control)this).get_Controls().Add((Control)(object)Fj6());
		((Control)this).get_Controls().Add((Control)(object)St1());
		((Control)this).get_Controls().Add((Control)(object)q2Q());
		((Control)this).get_Controls().Add((Control)(object)Gn0());
		((Control)this).get_Controls().Add((Control)(object)w0F());
		((Control)this).get_Controls().Add((Control)(object)g1L());
		((Control)this).get_Controls().Add((Control)(object)z9F());
		((Control)this).get_Controls().Add((Control)(object)Tr8());
		((Control)this).get_Controls().Add((Control)(object)Bt3());
		((Control)this).get_Controls().Add((Control)(object)a5S());
		((Control)this).get_Controls().Add((Control)(object)Lb8());
		((Control)this).get_Controls().Add((Control)(object)k8S());
		((Control)this).get_Controls().Add((Control)(object)Mx1());
		((Control)this).get_Controls().Add((Control)(object)r9T());
		((Control)this).get_Controls().Add((Control)(object)Re6());
		((Control)this).get_Controls().Add((Control)(object)d4B());
		((Control)this).get_Controls().Add((Control)(object)i4D());
		((Control)this).get_Controls().Add((Control)(object)Xi4());
		((Control)this).get_Controls().Add((Control)(object)o2M());
		((Control)this).get_Controls().Add((Control)(object)m4B());
		((Control)this).get_Controls().Add((Control)(object)Zs6());
		((Control)this).get_Controls().Add((Control)(object)Kx0());
		((Control)this).get_Controls().Add((Control)(object)Qk6());
		((Control)this).get_Controls().Add((Control)(object)Gc1());
		((Control)this).get_Controls().Add((Control)(object)Xc8());
		((Control)this).get_Controls().Add((Control)(object)a3K());
		((Control)this).get_Controls().Add((Control)(object)Xq8());
		((Control)this).get_Controls().Add((Control)(object)g3Z());
		((Control)this).get_Controls().Add((Control)(object)Yo3());
		((Control)this).get_Controls().Add((Control)(object)z1D());
		((Control)this).get_Controls().Add((Control)(object)Tc4());
		((Control)this).get_Controls().Add((Control)(object)Wp1());
		((Control)this).get_Controls().Add((Control)(object)c3W());
		((Control)this).get_Controls().Add((Control)(object)f6T());
		((Control)this).get_Controls().Add((Control)(object)m8M());
		((Control)this).get_Controls().Add((Control)(object)Ki3());
		((Control)this).get_Controls().Add((Control)(object)Yj3());
		((Control)this).get_Controls().Add((Control)(object)g5K());
		((Control)this).get_Controls().Add((Control)(object)t9E());
		((Control)this).get_Controls().Add((Control)(object)Xi7());
		((Control)this).get_Controls().Add((Control)(object)p4X());
		((Control)this).get_Controls().Add((Control)(object)Cr0());
		((Control)this).get_Controls().Add((Control)(object)s9F());
		((Control)this).get_Controls().Add((Control)(object)a7D());
		((Control)this).get_Controls().Add((Control)(object)x4J());
		((Control)this).get_Controls().Add((Control)(object)Wg2());
		((Control)this).get_Controls().Add((Control)(object)Pa7());
		((Control)this).get_Controls().Add((Control)(object)y4C());
		((Control)this).get_Controls().Add((Control)(object)a6E());
		((Control)this).get_Controls().Add((Control)(object)b1Q());
		((Control)this).get_Controls().Add((Control)(object)Fw6());
		((Control)this).get_Controls().Add((Control)(object)f7X());
		((Control)this).get_Controls().Add((Control)(object)Wt4());
		((Control)this).get_Controls().Add((Control)(object)q5F());
		((Control)this).get_Controls().Add((Control)(object)Gd6());
		((Control)this).get_Controls().Add((Control)(object)Yf8());
		((Control)this).get_Controls().Add((Control)(object)p0T());
		((Control)this).get_Controls().Add((Control)(object)Qj6());
		((Control)this).get_Controls().Add((Control)(object)Kg4());
		((Control)this).get_Controls().Add((Control)(object)Kd3());
		((Control)this).get_Controls().Add((Control)(object)Ns7());
		((Control)this).get_Controls().Add((Control)(object)m3K());
		((Control)this).get_Controls().Add((Control)(object)q6T());
		((Control)this).get_Controls().Add((Control)(object)Pm2());
		((Control)this).get_Controls().Add((Control)(object)o3A());
		((Control)this).get_Controls().Add((Control)(object)f2P());
		((Control)this).get_Controls().Add((Control)(object)n9S());
		((Control)this).get_Controls().Add((Control)(object)b0L());
		((Control)this).get_Controls().Add((Control)(object)Ly0());
		((Control)this).get_Controls().Add((Control)(object)k1W());
		((Control)this).get_Controls().Add((Control)(object)Kr7());
		((Control)this).get_Controls().Add((Control)(object)Ce1());
		((Control)this).get_Controls().Add((Control)(object)Co0());
		((Control)this).get_Controls().Add((Control)(object)n0C());
		((Control)this).get_Controls().Add((Control)(object)Xy0());
		((Control)this).get_Controls().Add((Control)(object)b5F());
		((Control)this).get_Controls().Add((Control)(object)e4E());
		((Control)this).get_Controls().Add((Control)(object)Lg1());
		((Control)this).get_Controls().Add((Control)(object)Mm9());
		((Control)this).get_Controls().Add((Control)(object)j0J());
		((Control)this).get_Controls().Add((Control)(object)d9N());
		((Control)this).get_Controls().Add((Control)(object)a6T());
		((Control)this).get_Controls().Add((Control)(object)Ks7());
		((Control)this).get_Controls().Add((Control)(object)Kt6());
		((Control)this).get_Controls().Add((Control)(object)Ya9());
		((Control)this).get_Controls().Add((Control)(object)Mr8());
		((Control)this).get_Controls().Add((Control)(object)Fr6());
		((Control)this).get_Controls().Add((Control)(object)s5X());
		((Control)this).get_Controls().Add((Control)(object)n2Q());
		((Control)this).get_Controls().Add((Control)(object)Hs6());
		((Control)this).get_Controls().Add((Control)(object)Pz8());
		((Control)this).get_Controls().Add((Control)(object)Dc6());
		((Control)this).get_Controls().Add((Control)(object)Mb2());
		((Control)this).get_Controls().Add((Control)(object)Pi7());
		((Control)this).get_Controls().Add((Control)(object)Nx5());
		((Control)this).get_Controls().Add((Control)(object)r7D());
		((Control)this).get_Controls().Add((Control)(object)j7Y());
		((Control)this).get_Controls().Add((Control)(object)Qy4());
		((Control)this).get_Controls().Add((Control)(object)Kj8());
		((Control)this).get_Controls().Add((Control)(object)Tt0());
		((Control)this).get_Controls().Add((Control)(object)Yp8());
		((Control)this).get_Controls().Add((Control)(object)w5C());
		((Control)this).get_Controls().Add((Control)(object)q6Q());
		((Control)this).get_Controls().Add((Control)(object)Kd6());
		((Control)this).get_Controls().Add((Control)(object)y1A());
		((Control)this).get_Controls().Add((Control)(object)e5N());
		((Control)this).get_Controls().Add((Control)(object)Lo6());
		((Control)this).get_Controls().Add((Control)(object)Pe5p());
		((Control)this).get_Controls().Add((Control)(object)j3MB());
		((Control)this).get_Controls().Add((Control)(object)Ki96());
		((Control)this).get_Controls().Add((Control)(object)Yq27());
		((Control)this).get_Controls().Add((Control)(object)t3RJ());
		((Control)this).get_Controls().Add((Control)(object)t4EG());
		((Control)this).get_Controls().Add((Control)(object)Lj34());
		((Control)this).get_Controls().Add((Control)(object)o8LX());
		((Control)this).get_Controls().Add((Control)(object)Fk90());
		((Control)this).get_Controls().Add((Control)(object)Lz4x());
		((Control)this).get_Controls().Add((Control)(object)q8FC());
		((Control)this).get_Controls().Add((Control)(object)Tt07());
		((Control)this).get_Controls().Add((Control)(object)c3GC());
		((Control)this).get_Controls().Add((Control)(object)Cs12());
		((Control)this).get_Controls().Add((Control)(object)Wt4n());
		((Control)this).get_Controls().Add((Control)(object)o1H7());
		((Control)this).get_Controls().Add((Control)(object)y1HE());
		((Control)this).get_Controls().Add((Control)(object)n7KM());
		((Control)this).get_Controls().Add((Control)(object)Dr0w());
		((Control)this).get_Controls().Add((Control)(object)s1S3());
		((Control)this).get_Controls().Add((Control)(object)Ck2n());
		((Control)this).get_Controls().Add((Control)(object)b8JA());
		((Control)this).get_Controls().Add((Control)(object)q6D4());
		((Control)this).get_Controls().Add((Control)(object)z2G8());
		((Control)this).get_Controls().Add((Control)(object)m7HX());
		((Control)this).get_Controls().Add((Control)(object)Sf7k());
		((Control)this).get_Controls().Add((Control)(object)e6DC());
		((Control)this).get_Controls().Add((Control)(object)En97());
		((Control)this).get_Controls().Add((Control)(object)Ec2t());
		((Control)this).get_Controls().Add((Control)(object)g9Y0());
		((Control)this).get_Controls().Add((Control)(object)Kf1q());
		((Control)this).get_Controls().Add((Control)(object)k0XZ());
		((Control)this).get_Controls().Add((Control)(object)Fo0t());
		((Control)this).get_Controls().Add((Control)(object)c5HS());
		((Control)this).get_Controls().Add((Control)(object)g0Q1());
		((Control)this).get_Controls().Add((Control)(object)j1BN());
		((Control)this).get_Controls().Add((Control)(object)Mw2p());
		((Control)this).get_Controls().Add((Control)(object)o5MS());
		((Control)this).get_Controls().Add((Control)(object)n9Q0());
		((Control)this).get_Controls().Add((Control)(object)Bc3m());
		((Control)this).get_Controls().Add((Control)(object)Gz29());
		((Control)this).get_Controls().Add((Control)(object)g3Q0());
		((Control)this).get_Controls().Add((Control)(object)e6D3());
		((Control)this).get_Controls().Add((Control)(object)Qk4d());
		((Control)this).get_Controls().Add((Control)(object)c4YZ());
		((Control)this).get_Controls().Add((Control)(object)y7BS());
		((Control)this).get_Controls().Add((Control)(object)b3Q5());
		((Control)this).get_Controls().Add((Control)(object)j8Z5());
		((Control)this).get_Controls().Add((Control)(object)a7ZN());
		((Control)this).get_Controls().Add((Control)(object)Js8g());
		((Control)this).get_Controls().Add((Control)(object)Dk6a());
		((Control)this).get_Controls().Add((Control)(object)k3X0());
		((Control)this).get_Controls().Add((Control)(object)p6E3());
		((Control)this).get_Controls().Add((Control)(object)a6RS());
		((Control)this).get_Controls().Add((Control)(object)p8G3());
		((Control)this).get_Controls().Add((Control)(object)Dm74());
		((Control)this).get_Controls().Add((Control)(object)Dq0r());
		((Control)this).get_Controls().Add((Control)(object)Kf45());
		((Control)this).get_Controls().Add((Control)(object)Me94());
		((Control)this).get_Controls().Add((Control)(object)y9ES());
		((Control)this).get_Controls().Add((Control)(object)Zp0w());
		((Control)this).get_Controls().Add((Control)(object)Lb1q());
		((Control)this).get_Controls().Add((Control)(object)Ps0k());
		((Control)this).get_Controls().Add((Control)(object)p5B2());
		((Control)this).get_Controls().Add((Control)(object)x7H2());
		((Control)this).get_Controls().Add((Control)(object)My9z());
		((Control)this).get_Controls().Add((Control)(object)s9AF());
		((Control)this).get_Controls().Add((Control)(object)Rf54());
		((Control)this).get_Controls().Add((Control)(object)Ax3n());
		((Control)this).get_Controls().Add((Control)(object)t0K5());
		((Control)this).get_Controls().Add((Control)(object)m2MD());
		((Control)this).get_Controls().Add((Control)(object)e7A6());
		((Control)this).get_Controls().Add((Control)(object)f6DE());
		((Control)this).get_Controls().Add((Control)(object)x0XR());
		((Control)this).get_Controls().Add((Control)(object)Zr53());
		((Control)this).get_Controls().Add((Control)(object)Mi84());
		((Control)this).get_Controls().Add((Control)(object)q7H3());
		((Control)this).get_Controls().Add((Control)(object)Lm39());
		((Control)this).get_Controls().Add((Control)(object)i3B2());
		((Control)this).get_Controls().Add((Control)(object)o4GF());
		((Control)this).get_Controls().Add((Control)(object)e5AG());
		((Control)this).get_Controls().Add((Control)(object)Kt1s());
		((Control)this).get_Controls().Add((Control)(object)Ha15());
		((Control)this).get_Controls().Add((Control)(object)d0BQ());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 3");
		((ISupportInitialize)g7H()).EndInit();
		((ISupportInitialize)m9Z()).EndInit();
		((ISupportInitialize)c4P()).EndInit();
		((ISupportInitialize)w0P()).EndInit();
		((ISupportInitialize)Ha7()).EndInit();
		((ISupportInitialize)w0R()).EndInit();
		((ISupportInitialize)Wb1()).EndInit();
		((ISupportInitialize)x9L()).EndInit();
		((ISupportInitialize)Mw9()).EndInit();
		((ISupportInitialize)Cw4()).EndInit();
		((ISupportInitialize)z5R()).EndInit();
		((ISupportInitialize)z7Y()).EndInit();
		((ISupportInitialize)r6W()).EndInit();
		((ISupportInitialize)Qd6()).EndInit();
		((ISupportInitialize)b3Q()).EndInit();
		((ISupportInitialize)Mc4()).EndInit();
		((ISupportInitialize)g5J()).EndInit();
		((ISupportInitialize)Dq5()).EndInit();
		((ISupportInitialize)Nq5()).EndInit();
		((ISupportInitialize)Aq7()).EndInit();
		((ISupportInitialize)m8S()).EndInit();
		((ISupportInitialize)q7L()).EndInit();
		((ISupportInitialize)d2B()).EndInit();
		((ISupportInitialize)Fa7()).EndInit();
		((ISupportInitialize)Fj6()).EndInit();
		((ISupportInitialize)St1()).EndInit();
		((ISupportInitialize)q2Q()).EndInit();
		((ISupportInitialize)Gn0()).EndInit();
		((ISupportInitialize)w0F()).EndInit();
		((ISupportInitialize)g1L()).EndInit();
		((ISupportInitialize)z9F()).EndInit();
		((ISupportInitialize)Tr8()).EndInit();
		((ISupportInitialize)Bt3()).EndInit();
		((ISupportInitialize)a5S()).EndInit();
		((ISupportInitialize)Lb8()).EndInit();
		((ISupportInitialize)k8S()).EndInit();
		((ISupportInitialize)Mx1()).EndInit();
		((ISupportInitialize)r9T()).EndInit();
		((ISupportInitialize)Re6()).EndInit();
		((ISupportInitialize)d4B()).EndInit();
		((ISupportInitialize)i4D()).EndInit();
		((ISupportInitialize)Xi4()).EndInit();
		((ISupportInitialize)o2M()).EndInit();
		((ISupportInitialize)m4B()).EndInit();
		((ISupportInitialize)Zs6()).EndInit();
		((ISupportInitialize)Kx0()).EndInit();
		((ISupportInitialize)Qk6()).EndInit();
		((ISupportInitialize)Gc1()).EndInit();
		((ISupportInitialize)Xc8()).EndInit();
		((ISupportInitialize)a3K()).EndInit();
		((ISupportInitialize)Xq8()).EndInit();
		((ISupportInitialize)g3Z()).EndInit();
		((ISupportInitialize)Yo3()).EndInit();
		((ISupportInitialize)z1D()).EndInit();
		((ISupportInitialize)Tc4()).EndInit();
		((ISupportInitialize)Wp1()).EndInit();
		((ISupportInitialize)c3W()).EndInit();
		((ISupportInitialize)f6T()).EndInit();
		((ISupportInitialize)m8M()).EndInit();
		((ISupportInitialize)Ki3()).EndInit();
		((ISupportInitialize)Yj3()).EndInit();
		((ISupportInitialize)g5K()).EndInit();
		((ISupportInitialize)t9E()).EndInit();
		((ISupportInitialize)Xi7()).EndInit();
		((ISupportInitialize)p4X()).EndInit();
		((ISupportInitialize)Cr0()).EndInit();
		((ISupportInitialize)s9F()).EndInit();
		((ISupportInitialize)a7D()).EndInit();
		((ISupportInitialize)x4J()).EndInit();
		((ISupportInitialize)Wg2()).EndInit();
		((ISupportInitialize)Pa7()).EndInit();
		((ISupportInitialize)y4C()).EndInit();
		((ISupportInitialize)a6E()).EndInit();
		((ISupportInitialize)b1Q()).EndInit();
		((ISupportInitialize)Fw6()).EndInit();
		((ISupportInitialize)f7X()).EndInit();
		((ISupportInitialize)Wt4()).EndInit();
		((ISupportInitialize)q5F()).EndInit();
		((ISupportInitialize)Gd6()).EndInit();
		((ISupportInitialize)Yf8()).EndInit();
		((ISupportInitialize)p0T()).EndInit();
		((ISupportInitialize)Qj6()).EndInit();
		((ISupportInitialize)Kg4()).EndInit();
		((ISupportInitialize)Kd3()).EndInit();
		((ISupportInitialize)Ns7()).EndInit();
		((ISupportInitialize)m3K()).EndInit();
		((ISupportInitialize)q6T()).EndInit();
		((ISupportInitialize)Pm2()).EndInit();
		((ISupportInitialize)o3A()).EndInit();
		((ISupportInitialize)f2P()).EndInit();
		((ISupportInitialize)n9S()).EndInit();
		((ISupportInitialize)b0L()).EndInit();
		((ISupportInitialize)Ly0()).EndInit();
		((ISupportInitialize)k1W()).EndInit();
		((ISupportInitialize)Kr7()).EndInit();
		((ISupportInitialize)Ce1()).EndInit();
		((ISupportInitialize)Co0()).EndInit();
		((ISupportInitialize)n0C()).EndInit();
		((ISupportInitialize)Xy0()).EndInit();
		((ISupportInitialize)b5F()).EndInit();
		((ISupportInitialize)e4E()).EndInit();
		((ISupportInitialize)Lg1()).EndInit();
		((ISupportInitialize)Mm9()).EndInit();
		((ISupportInitialize)j0J()).EndInit();
		((ISupportInitialize)d9N()).EndInit();
		((ISupportInitialize)a6T()).EndInit();
		((ISupportInitialize)Ks7()).EndInit();
		((ISupportInitialize)Kt6()).EndInit();
		((ISupportInitialize)Ya9()).EndInit();
		((ISupportInitialize)Mr8()).EndInit();
		((ISupportInitialize)Fr6()).EndInit();
		((ISupportInitialize)s5X()).EndInit();
		((ISupportInitialize)n2Q()).EndInit();
		((ISupportInitialize)Hs6()).EndInit();
		((ISupportInitialize)Pz8()).EndInit();
		((ISupportInitialize)Dc6()).EndInit();
		((ISupportInitialize)Mb2()).EndInit();
		((ISupportInitialize)Pi7()).EndInit();
		((ISupportInitialize)Nx5()).EndInit();
		((ISupportInitialize)r7D()).EndInit();
		((ISupportInitialize)j7Y()).EndInit();
		((ISupportInitialize)Qy4()).EndInit();
		((ISupportInitialize)Kj8()).EndInit();
		((ISupportInitialize)Tt0()).EndInit();
		((ISupportInitialize)Yp8()).EndInit();
		((ISupportInitialize)w5C()).EndInit();
		((ISupportInitialize)q6Q()).EndInit();
		((ISupportInitialize)Kd6()).EndInit();
		((ISupportInitialize)y1A()).EndInit();
		((ISupportInitialize)e5N()).EndInit();
		((ISupportInitialize)Lo6()).EndInit();
		((ISupportInitialize)Pe5p()).EndInit();
		((ISupportInitialize)j3MB()).EndInit();
		((ISupportInitialize)Ki96()).EndInit();
		((ISupportInitialize)Yq27()).EndInit();
		((ISupportInitialize)t3RJ()).EndInit();
		((ISupportInitialize)t4EG()).EndInit();
		((ISupportInitialize)Lj34()).EndInit();
		((ISupportInitialize)w6AW()).EndInit();
		((ISupportInitialize)r9XC()).EndInit();
		((ISupportInitialize)j9G1()).EndInit();
		((ISupportInitialize)o8LX()).EndInit();
		((ISupportInitialize)Fk90()).EndInit();
		((ISupportInitialize)Lz4x()).EndInit();
		((ISupportInitialize)q8FC()).EndInit();
		((ISupportInitialize)Tt07()).EndInit();
		((ISupportInitialize)c3GC()).EndInit();
		((ISupportInitialize)Cs12()).EndInit();
		((ISupportInitialize)Wt4n()).EndInit();
		((ISupportInitialize)o1H7()).EndInit();
		((ISupportInitialize)y1HE()).EndInit();
		((ISupportInitialize)n7KM()).EndInit();
		((ISupportInitialize)Dr0w()).EndInit();
		((ISupportInitialize)s1S3()).EndInit();
		((ISupportInitialize)Ck2n()).EndInit();
		((ISupportInitialize)b8JA()).EndInit();
		((ISupportInitialize)q6D4()).EndInit();
		((ISupportInitialize)z2G8()).EndInit();
		((ISupportInitialize)m7HX()).EndInit();
		((ISupportInitialize)Sf7k()).EndInit();
		((ISupportInitialize)e6DC()).EndInit();
		((ISupportInitialize)En97()).EndInit();
		((ISupportInitialize)Ec2t()).EndInit();
		((Control)o4GF()).ResumeLayout(false);
		((ISupportInitialize)Ak6x()).EndInit();
		((Control)e5AG()).ResumeLayout(false);
		((Control)e5AG()).PerformLayout();
		((ISupportInitialize)Ha15()).EndInit();
		((ISupportInitialize)d0BQ()).EndInit();
		((Control)Nc1f()).ResumeLayout(false);
		((Control)Nc1f()).PerformLayout();
		((Control)e9JN()).ResumeLayout(false);
		((Control)e9JN()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual PictureBox g7H()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3Y(PictureBox Cy2)
	{
		PictureBox val = (k = Cy2);
	}

	[SpecialName]
	internal virtual PictureBox m9Z()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0L(PictureBox f6M)
	{
		PictureBox val = (j = f6M);
	}

	[SpecialName]
	internal virtual PictureBox c4P()
	{
		return _PictureBox143;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7D(PictureBox Gk0)
	{
		_PictureBox143 = Gk0;
	}

	[SpecialName]
	internal virtual PictureBox w0P()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Li1(PictureBox Tj4)
	{
		PictureBox val = (L = Tj4);
	}

	[SpecialName]
	internal virtual PictureBox Ha7()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2Y(PictureBox f0M)
	{
		PictureBox val = (U = f0M);
	}

	[SpecialName]
	internal virtual PictureBox w0R()
	{
		return _PictureBox146;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6W(PictureBox p4C)
	{
		_PictureBox146 = p4C;
	}

	[SpecialName]
	internal virtual PictureBox Wb1()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rx0(PictureBox Mx2)
	{
		_PictureBox147 = Mx2;
	}

	[SpecialName]
	internal virtual PictureBox x9L()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xr1(PictureBox As2)
	{
		PictureBox val = (i = As2);
	}

	[SpecialName]
	internal virtual PictureBox Mw9()
	{
		return _PictureBox149;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9Q(PictureBox Ys1)
	{
		_PictureBox149 = Ys1;
	}

	[SpecialName]
	internal virtual PictureBox Cw4()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1Y(PictureBox o6W)
	{
		PictureBox val = (X = o6W);
	}

	[SpecialName]
	internal virtual PictureBox z5R()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd8(PictureBox z5C)
	{
		PictureBox val = (Y = z5C);
	}

	[SpecialName]
	internal virtual PictureBox z7Y()
	{
		return _PictureBox152;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf1(PictureBox Ji9)
	{
		_PictureBox152 = Ji9;
	}

	[SpecialName]
	internal virtual PictureBox r6W()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6N(PictureBox Be6)
	{
		PictureBox val = (o = Be6);
	}

	[SpecialName]
	internal virtual PictureBox Qd6()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9H(PictureBox Qf5)
	{
		PictureBox val = (H = Qf5);
	}

	[SpecialName]
	internal virtual PictureBox b3Q()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No1(PictureBox z3Z)
	{
		PictureBox val = (C = z3Z);
	}

	[SpecialName]
	internal virtual PictureBox Mc4()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf2(PictureBox w8M)
	{
		PictureBox val = (d = w8M);
	}

	[SpecialName]
	internal virtual PictureBox g5J()
	{
		return _PictureBox157;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je5(PictureBox Qg7)
	{
		_PictureBox157 = Qg7;
	}

	[SpecialName]
	internal virtual PictureBox Dq5()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6E(PictureBox t1Z)
	{
		PictureBox val = (B = t1Z);
	}

	[SpecialName]
	internal virtual PictureBox Nq5()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jy2(PictureBox g5K)
	{
		PictureBox val = (Q = g5K);
	}

	[SpecialName]
	internal virtual PictureBox Aq7()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wa0(PictureBox n2D)
	{
		PictureBox val = (f = n2D);
	}

	[SpecialName]
	internal virtual PictureBox m8S()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ka7(PictureBox f3L)
	{
		PictureBox val = (e = f3L);
	}

	[SpecialName]
	internal virtual PictureBox q7L()
	{
		return _PictureBox122;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gm4(PictureBox Qp1)
	{
		_PictureBox122 = Qp1;
	}

	[SpecialName]
	internal virtual PictureBox d2B()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s9H(PictureBox k7Z)
	{
		PictureBox val = (R = k7Z);
	}

	[SpecialName]
	internal virtual PictureBox Fa7()
	{
		return _PictureBox124;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n6W(PictureBox m8C)
	{
		_PictureBox124 = m8C;
	}

	[SpecialName]
	internal virtual PictureBox Fj6()
	{
		return _PictureBox125;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me7(PictureBox i2N)
	{
		_PictureBox125 = i2N;
	}

	[SpecialName]
	internal virtual PictureBox St1()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kq3(PictureBox Xc3)
	{
		PictureBox val = (V = Xc3);
	}

	[SpecialName]
	internal virtual PictureBox q2Q()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1M(PictureBox Tt9)
	{
		PictureBox val = (W = Tt9);
	}

	[SpecialName]
	internal virtual PictureBox Gn0()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4H(PictureBox i8N)
	{
		PictureBox val = (m = i8N);
	}

	[SpecialName]
	internal virtual PictureBox w0F()
	{
		return _PictureBox129;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qk9(PictureBox Gk8)
	{
		_PictureBox129 = Gk8;
	}

	[SpecialName]
	internal virtual PictureBox g1L()
	{
		return _PictureBox130;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1N(PictureBox k7J)
	{
		_PictureBox130 = k7J;
	}

	[SpecialName]
	internal virtual PictureBox z9F()
	{
		return _PictureBox131;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8D(PictureBox k8A)
	{
		_PictureBox131 = k8A;
	}

	[SpecialName]
	internal virtual PictureBox Tr8()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xs7(PictureBox Bi1)
	{
		PictureBox val = (G = Bi1);
	}

	[SpecialName]
	internal virtual PictureBox Bt3()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7C(PictureBox k5D)
	{
		PictureBox val = (n = k5D);
	}

	[SpecialName]
	internal virtual PictureBox a5S()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3H(PictureBox Gf9)
	{
		PictureBox val = (p = Gf9);
	}

	[SpecialName]
	internal virtual PictureBox Lb8()
	{
		return _PictureBox135;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hr2(PictureBox Ec1)
	{
		_PictureBox135 = Ec1;
	}

	[SpecialName]
	internal virtual PictureBox k8S()
	{
		return _PictureBox136;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn7(PictureBox Mq5)
	{
		_PictureBox136 = Mq5;
	}

	[SpecialName]
	internal virtual PictureBox Mx1()
	{
		return _PictureBox137;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xr7(PictureBox Tf4)
	{
		_PictureBox137 = Tf4;
	}

	[SpecialName]
	internal virtual PictureBox r9T()
	{
		return _PictureBox138;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd5(PictureBox Tb6)
	{
		_PictureBox138 = Tb6;
	}

	[SpecialName]
	internal virtual PictureBox Re6()
	{
		return _PictureBox139;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4K(PictureBox Br4)
	{
		_PictureBox139 = Br4;
	}

	[SpecialName]
	internal virtual PictureBox d4B()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8H(PictureBox n9R)
	{
		PictureBox val = (S = n9R);
	}

	[SpecialName]
	internal virtual PictureBox i4D()
	{
		return _PictureBox101;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zd4(PictureBox Ks7)
	{
		_PictureBox101 = Ks7;
	}

	[SpecialName]
	internal virtual PictureBox Xi4()
	{
		return _PictureBox102;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bs7(PictureBox q1Y)
	{
		_PictureBox102 = q1Y;
	}

	[SpecialName]
	internal virtual PictureBox o2M()
	{
		return _PictureBox103;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y4J(PictureBox Ye6)
	{
		_PictureBox103 = Ye6;
	}

	[SpecialName]
	internal virtual PictureBox m4B()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hw1(PictureBox Qf6)
	{
		PictureBox val = (T = Qf6);
	}

	[SpecialName]
	internal virtual PictureBox Zs6()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sg1(PictureBox j4C)
	{
		PictureBox val = (z = j4C);
	}

	[SpecialName]
	internal virtual PictureBox Kx0()
	{
		return kA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8H(PictureBox Pr7)
	{
		PictureBox val = (kA = Pr7);
	}

	[SpecialName]
	internal virtual PictureBox Qk6()
	{
		return kk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dr7(PictureBox e2C)
	{
		PictureBox val = (kk = e2C);
	}

	[SpecialName]
	internal virtual PictureBox Gc1()
	{
		return _PictureBox108;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey7(PictureBox Qe9)
	{
		_PictureBox108 = Qe9;
	}

	[SpecialName]
	internal virtual PictureBox Xc8()
	{
		return _PictureBox109;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc6(PictureBox Sp3)
	{
		_PictureBox109 = Sp3;
	}

	[SpecialName]
	internal virtual PictureBox a3K()
	{
		return kj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9C(PictureBox o2E)
	{
		PictureBox val = (kj = o2E);
	}

	[SpecialName]
	internal virtual PictureBox Xq8()
	{
		return kL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0R(PictureBox Tw0)
	{
		PictureBox val = (kL = Tw0);
	}

	[SpecialName]
	internal virtual PictureBox g3Z()
	{
		return kU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6Q(PictureBox n9S)
	{
		PictureBox val = (kU = n9S);
	}

	[SpecialName]
	internal virtual PictureBox Yo3()
	{
		return _PictureBox113;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk1(PictureBox Gf2)
	{
		_PictureBox113 = Gf2;
	}

	[SpecialName]
	internal virtual PictureBox z1D()
	{
		return _PictureBox114;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2N(PictureBox m3Y)
	{
		_PictureBox114 = m3Y;
	}

	[SpecialName]
	internal virtual PictureBox Tc4()
	{
		return ki;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0D(PictureBox t4C)
	{
		PictureBox val = (ki = t4C);
	}

	[SpecialName]
	internal virtual PictureBox Wp1()
	{
		return kX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8J(PictureBox Fa5)
	{
		PictureBox val = (kX = Fa5);
	}

	[SpecialName]
	internal virtual PictureBox c3W()
	{
		return kY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4B(PictureBox s5A)
	{
		PictureBox val = (kY = s5A);
	}

	[SpecialName]
	internal virtual PictureBox f6T()
	{
		return ko;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et9(PictureBox To2)
	{
		PictureBox val = (ko = To2);
	}

	[SpecialName]
	internal virtual PictureBox m8M()
	{
		return _PictureBox119;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq9(PictureBox Hn2)
	{
		_PictureBox119 = Hn2;
	}

	[SpecialName]
	internal virtual PictureBox Ki3()
	{
		return kH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw1(PictureBox n7H)
	{
		PictureBox val = (kH = n7H);
	}

	[SpecialName]
	internal virtual PictureBox Yj3()
	{
		return kC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e5F(PictureBox g6W)
	{
		PictureBox val = (kC = g6W);
	}

	[SpecialName]
	internal virtual PictureBox g5K()
	{
		return kd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8J(PictureBox Pq1)
	{
		PictureBox val = (kd = Pq1);
	}

	[SpecialName]
	internal virtual PictureBox t9E()
	{
		return _PictureBox83;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns5(PictureBox b7J)
	{
		_PictureBox83 = b7J;
	}

	[SpecialName]
	internal virtual PictureBox Xi7()
	{
		return kB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp8(PictureBox s4D)
	{
		PictureBox val = (kB = s4D);
	}

	[SpecialName]
	internal virtual PictureBox p4X()
	{
		return _PictureBox85;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw2(PictureBox Di0)
	{
		_PictureBox85 = Di0;
	}

	[SpecialName]
	internal virtual PictureBox Cr0()
	{
		return _PictureBox86;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1H(PictureBox y5Y)
	{
		_PictureBox86 = y5Y;
	}

	[SpecialName]
	internal virtual PictureBox s9F()
	{
		return kQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc1(PictureBox r4D)
	{
		PictureBox val = (kQ = r4D);
	}

	[SpecialName]
	internal virtual PictureBox a7D()
	{
		return _PictureBox88;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4C(PictureBox Lg1)
	{
		_PictureBox88 = Lg1;
	}

	[SpecialName]
	internal virtual PictureBox x4J()
	{
		return kf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Js0(PictureBox g0Z)
	{
		PictureBox val = (kf = g0Z);
	}

	[SpecialName]
	internal virtual PictureBox Wg2()
	{
		return ke;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tr6(PictureBox Ki6)
	{
		PictureBox val = (ke = Ki6);
	}

	[SpecialName]
	internal virtual PictureBox Pa7()
	{
		return kR;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pk6(PictureBox c3C)
	{
		PictureBox val = (kR = c3C);
	}

	[SpecialName]
	internal virtual PictureBox y4C()
	{
		return _PictureBox92;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs1(PictureBox d1D)
	{
		_PictureBox92 = d1D;
	}

	[SpecialName]
	internal virtual PictureBox a6E()
	{
		return kV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i4P(PictureBox Fp9)
	{
		PictureBox val = (kV = Fp9);
	}

	[SpecialName]
	internal virtual PictureBox b1Q()
	{
		return _PictureBox94;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4E(PictureBox t2G)
	{
		_PictureBox94 = t2G;
	}

	[SpecialName]
	internal virtual PictureBox Fw6()
	{
		return kW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4L(PictureBox z9T)
	{
		PictureBox val = (kW = z9T);
	}

	[SpecialName]
	internal virtual PictureBox f7X()
	{
		return km;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp7(PictureBox p3Z)
	{
		PictureBox val = (km = p3Z);
	}

	[SpecialName]
	internal virtual PictureBox Wt4()
	{
		return kG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1Y(PictureBox i5X)
	{
		PictureBox val = (kG = i5X);
	}

	[SpecialName]
	internal virtual PictureBox q5F()
	{
		return kn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8J(PictureBox d9N)
	{
		PictureBox val = (kn = d9N);
	}

	[SpecialName]
	internal virtual PictureBox Gd6()
	{
		return kp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0D(PictureBox k5D)
	{
		PictureBox val = (kp = k5D);
	}

	[SpecialName]
	internal virtual PictureBox Yf8()
	{
		return kS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0Q(PictureBox x3M)
	{
		PictureBox val = (kS = x3M);
	}

	[SpecialName]
	internal virtual PictureBox p0T()
	{
		return _PictureBox61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2N(PictureBox a4Z)
	{
		_PictureBox61 = a4Z;
	}

	[SpecialName]
	internal virtual PictureBox Qj6()
	{
		return _PictureBox62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zq4(PictureBox r0M)
	{
		_PictureBox62 = r0M;
	}

	[SpecialName]
	internal virtual PictureBox Kg4()
	{
		return _PictureBox63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fk0(PictureBox i3T)
	{
		_PictureBox63 = i3T;
	}

	[SpecialName]
	internal virtual PictureBox Kd3()
	{
		return kT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0M(PictureBox g2C)
	{
		PictureBox val = (kT = g2C);
	}

	[SpecialName]
	internal virtual PictureBox Ns7()
	{
		return kz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sd1(PictureBox w9B)
	{
		PictureBox val = (kz = w9B);
	}

	[SpecialName]
	internal virtual PictureBox m3K()
	{
		return _PictureBox66;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2F(PictureBox i9A)
	{
		_PictureBox66 = i9A;
	}

	[SpecialName]
	internal virtual PictureBox q6T()
	{
		return jA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1Z(PictureBox Tc5)
	{
		PictureBox val = (jA = Tc5);
	}

	[SpecialName]
	internal virtual PictureBox Pm2()
	{
		return jk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f5P(PictureBox Mg9)
	{
		PictureBox val = (jk = Mg9);
	}

	[SpecialName]
	internal virtual PictureBox o3A()
	{
		return _PictureBox69;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4N(PictureBox g4F)
	{
		_PictureBox69 = g4F;
	}

	[SpecialName]
	internal virtual PictureBox f2P()
	{
		return _PictureBox70;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am3(PictureBox Fb6)
	{
		_PictureBox70 = Fb6;
	}

	[SpecialName]
	internal virtual PictureBox n9S()
	{
		return jj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7J(PictureBox Eq9)
	{
		PictureBox val = (jj = Eq9);
	}

	[SpecialName]
	internal virtual PictureBox b0L()
	{
		return _PictureBox72;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bm0(PictureBox f3K)
	{
		_PictureBox72 = f3K;
	}

	[SpecialName]
	internal virtual PictureBox Ly0()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Km4(PictureBox n1H)
	{
		_PictureBox73 = n1H;
	}

	[SpecialName]
	internal virtual PictureBox k1W()
	{
		return _PictureBox74;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nf8(PictureBox e0W)
	{
		_PictureBox74 = e0W;
	}

	[SpecialName]
	internal virtual PictureBox Kr7()
	{
		return _PictureBox75;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ef1(PictureBox w9H)
	{
		_PictureBox75 = w9H;
	}

	[SpecialName]
	internal virtual PictureBox Ce1()
	{
		return jL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2Q(PictureBox f0F)
	{
		PictureBox val = (jL = f0F);
	}

	[SpecialName]
	internal virtual PictureBox Co0()
	{
		return jU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0Y(PictureBox Wa0)
	{
		PictureBox val = (jU = Wa0);
	}

	[SpecialName]
	internal virtual PictureBox n0C()
	{
		return ji;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2H(PictureBox Rq8)
	{
		PictureBox val = (ji = Rq8);
	}

	[SpecialName]
	internal virtual PictureBox Xy0()
	{
		return _PictureBox79;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d1S(PictureBox b9X)
	{
		_PictureBox79 = b9X;
	}

	[SpecialName]
	internal virtual PictureBox b5F()
	{
		return _PictureBox80;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei9(PictureBox Kf3)
	{
		_PictureBox80 = Kf3;
	}

	[SpecialName]
	internal virtual PictureBox e4E()
	{
		return _PictureBox41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lp4(PictureBox i0X)
	{
		_PictureBox41 = i0X;
	}

	[SpecialName]
	internal virtual PictureBox Lg1()
	{
		return jX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz4(PictureBox i4H)
	{
		PictureBox val = (jX = i4H);
	}

	[SpecialName]
	internal virtual PictureBox Mm9()
	{
		return jY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aq6(PictureBox i8R)
	{
		PictureBox val = (jY = i8R);
	}

	[SpecialName]
	internal virtual PictureBox j0J()
	{
		return jo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3F(PictureBox Df9)
	{
		PictureBox val = (jo = Df9);
	}

	[SpecialName]
	internal virtual PictureBox d9N()
	{
		return jH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9L(PictureBox Nz9)
	{
		PictureBox val = (jH = Nz9);
	}

	[SpecialName]
	internal virtual PictureBox a6T()
	{
		return jC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2T(PictureBox n8H)
	{
		PictureBox val = (jC = n8H);
	}

	[SpecialName]
	internal virtual PictureBox Ks7()
	{
		return _PictureBox47;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8W(PictureBox Ke8)
	{
		_PictureBox47 = Ke8;
	}

	[SpecialName]
	internal virtual PictureBox Kt6()
	{
		return jd;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7L(PictureBox g4Z)
	{
		PictureBox val = (jd = g4Z);
	}

	[SpecialName]
	internal virtual PictureBox Ya9()
	{
		return _PictureBox49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r3W(PictureBox Yk4)
	{
		_PictureBox49 = Yk4;
	}

	[SpecialName]
	internal virtual PictureBox Mr8()
	{
		return jB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8T(PictureBox b6P)
	{
		PictureBox val = (jB = b6P);
	}

	[SpecialName]
	internal virtual PictureBox Fr6()
	{
		return _PictureBox51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4G(PictureBox Kr8)
	{
		_PictureBox51 = Kr8;
	}

	[SpecialName]
	internal virtual PictureBox s5X()
	{
		return jQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aa0(PictureBox Pt3)
	{
		PictureBox val = (jQ = Pt3);
	}

	[SpecialName]
	internal virtual PictureBox n2Q()
	{
		return _PictureBox53;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wo7(PictureBox Dt1)
	{
		_PictureBox53 = Dt1;
	}

	[SpecialName]
	internal virtual PictureBox Hs6()
	{
		return _PictureBox54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj4(PictureBox x2C)
	{
		_PictureBox54 = x2C;
	}

	[SpecialName]
	internal virtual PictureBox Pz8()
	{
		return jf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pf2(PictureBox n6L)
	{
		PictureBox val = (jf = n6L);
	}

	[SpecialName]
	internal virtual PictureBox Dc6()
	{
		return _PictureBox56;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4F(PictureBox d8P)
	{
		_PictureBox56 = d8P;
	}

	[SpecialName]
	internal virtual PictureBox Mb2()
	{
		return _PictureBox57;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7F(PictureBox Fr5)
	{
		_PictureBox57 = Fr5;
	}

	[SpecialName]
	internal virtual PictureBox Pi7()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zz0(PictureBox i4L)
	{
		_PictureBox58 = i4L;
	}

	[SpecialName]
	internal virtual PictureBox Nx5()
	{
		return je;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rt2(PictureBox i8W)
	{
		PictureBox val = (je = i8W);
	}

	[SpecialName]
	internal virtual PictureBox r7D()
	{
		return _PictureBox60;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2G(PictureBox y0L)
	{
		_PictureBox60 = y0L;
	}

	[SpecialName]
	internal virtual PictureBox j7Y()
	{
		return _PictureBox21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3J(PictureBox g1M)
	{
		_PictureBox21 = g1M;
	}

	[SpecialName]
	internal virtual PictureBox Qy4()
	{
		return jR;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n0R(PictureBox Pz5)
	{
		PictureBox val = (jR = Pz5);
	}

	[SpecialName]
	internal virtual PictureBox Kj8()
	{
		return _PictureBox23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7L(PictureBox Fx0)
	{
		_PictureBox23 = Fx0;
	}

	[SpecialName]
	internal virtual PictureBox Tt0()
	{
		return _PictureBox24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c1H(PictureBox At9)
	{
		_PictureBox24 = At9;
	}

	[SpecialName]
	internal virtual PictureBox Yp8()
	{
		return jV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6C(PictureBox Rx0)
	{
		PictureBox val = (jV = Rx0);
	}

	[SpecialName]
	internal virtual PictureBox w5C()
	{
		return jW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hf3(PictureBox Yg8)
	{
		PictureBox val = (jW = Yg8);
	}

	[SpecialName]
	internal virtual PictureBox q6Q()
	{
		return _PictureBox27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg5(PictureBox Aq1)
	{
		_PictureBox27 = Aq1;
	}

	[SpecialName]
	internal virtual PictureBox Kd6()
	{
		return _PictureBox28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lb1(PictureBox a9K)
	{
		_PictureBox28 = a9K;
	}

	[SpecialName]
	internal virtual PictureBox y1A()
	{
		return _PictureBox29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb6(PictureBox k4K)
	{
		_PictureBox29 = k4K;
	}

	[SpecialName]
	internal virtual PictureBox e5N()
	{
		return _PictureBox30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zo9(PictureBox g3W)
	{
		_PictureBox30 = g3W;
	}

	[SpecialName]
	internal virtual PictureBox Lo6()
	{
		return jm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jf3n(PictureBox Mn96)
	{
		PictureBox val = (jm = Mn96);
	}

	[SpecialName]
	internal virtual PictureBox Pe5p()
	{
		return jG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5Y3(PictureBox Tq76)
	{
		PictureBox val = (jG = Tq76);
	}

	[SpecialName]
	internal virtual PictureBox j3MB()
	{
		return jn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0C4(PictureBox d3S8)
	{
		PictureBox val = (jn = d3S8);
	}

	[SpecialName]
	internal virtual PictureBox Ki96()
	{
		return _PictureBox34;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gq1g(PictureBox x7P1)
	{
		_PictureBox34 = x7P1;
	}

	[SpecialName]
	internal virtual PictureBox Yq27()
	{
		return _PictureBox35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3F9(PictureBox Fz6i)
	{
		_PictureBox35 = Fz6i;
	}

	[SpecialName]
	internal virtual PictureBox t3RJ()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw2f(PictureBox b4FH)
	{
		_PictureBox36 = b4FH;
	}

	[SpecialName]
	internal virtual PictureBox t4EG()
	{
		return jp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wr7b(PictureBox a5ZB)
	{
		PictureBox val = (jp = a5ZB);
	}

	[SpecialName]
	internal virtual PictureBox Lj34()
	{
		return jS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i6G0(PictureBox w5D1)
	{
		PictureBox val = (jS = w5D1);
	}

	[SpecialName]
	internal virtual TextBox Cm05()
	{
		return jT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5S7(TextBox q8J1)
	{
		TextBox val = (jT = q8J1);
	}

	[SpecialName]
	internal virtual PictureBox w6AW()
	{
		return _Booked;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ex81(PictureBox a6JZ)
	{
		_Booked = a6JZ;
	}

	[SpecialName]
	internal virtual PictureBox r9XC()
	{
		return _Provisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Re34(PictureBox Lk1q)
	{
		_Provisional = Lk1q;
	}

	[SpecialName]
	internal virtual PictureBox j9G1()
	{
		return jz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp48(PictureBox p4E1)
	{
		PictureBox val = (jz = p4E1);
	}

	[SpecialName]
	internal virtual Label d1LQ()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qi4r(Label g0P2)
	{
		_Label3 = g0P2;
	}

	[SpecialName]
	internal virtual PictureBox o8LX()
	{
		return _PictureBox39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0K7(PictureBox Qz03)
	{
		_PictureBox39 = Qz03;
	}

	[SpecialName]
	internal virtual TextBox Rr43()
	{
		return _txtBooked;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am5e(TextBox Xf5x)
	{
		_txtBooked = Xf5x;
	}

	[SpecialName]
	internal virtual Label o1SF()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7H1(Label d9QW)
	{
		_Label1 = d9QW;
	}

	[SpecialName]
	internal virtual Label n9R2()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fg9j(Label a1WG)
	{
		_Label2 = a1WG;
	}

	[SpecialName]
	internal virtual PictureBox Fk90()
	{
		return LA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jj9w(PictureBox q2AC)
	{
		PictureBox val = (LA = q2AC);
	}

	[SpecialName]
	internal virtual PictureBox Lz4x()
	{
		return Lk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n2YJ(PictureBox q6S4)
	{
		PictureBox val = (Lk = q6S4);
	}

	[SpecialName]
	internal virtual PictureBox q8FC()
	{
		return Lj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jt46(PictureBox o4JK)
	{
		PictureBox val = (Lj = o4JK);
	}

	[SpecialName]
	internal virtual PictureBox Tt07()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x9E3(PictureBox Zn7m)
	{
		_PictureBox18 = Zn7m;
	}

	[SpecialName]
	internal virtual PictureBox c3GC()
	{
		return LL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o3C4(PictureBox Px6t)
	{
		PictureBox val = (LL = Px6t);
	}

	[SpecialName]
	internal virtual PictureBox Cs12()
	{
		return _PictureBox16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qk95(PictureBox e5TN)
	{
		_PictureBox16 = e5TN;
	}

	[SpecialName]
	internal virtual PictureBox Wt4n()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8NL(PictureBox Qo1a)
	{
		_PictureBox15 = Qo1a;
	}

	[SpecialName]
	internal virtual PictureBox o1H7()
	{
		return LU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6MT(PictureBox Te76)
	{
		PictureBox val = (LU = Te76);
	}

	[SpecialName]
	internal virtual PictureBox y1HE()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jj80(PictureBox f6ZH)
	{
		_PictureBox13 = f6ZH;
	}

	[SpecialName]
	internal virtual PictureBox n7KM()
	{
		return Li;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k0CR(PictureBox Af41)
	{
		PictureBox val = (Li = Af41);
	}

	[SpecialName]
	internal virtual PictureBox Dr0w()
	{
		return LX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6S5(PictureBox f8D1)
	{
		PictureBox val = (LX = f8D1);
	}

	[SpecialName]
	internal virtual PictureBox s1S3()
	{
		return LY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7MY(PictureBox a4L6)
	{
		PictureBox val = (LY = a4L6);
	}

	[SpecialName]
	internal virtual PictureBox Ck2n()
	{
		return _PictureBox9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8WA(PictureBox Ww6e)
	{
		_PictureBox9 = Ww6e;
	}

	[SpecialName]
	internal virtual PictureBox b8JA()
	{
		return _PictureBox8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7RS(PictureBox r1MT)
	{
		_PictureBox8 = r1MT;
	}

	[SpecialName]
	internal virtual PictureBox q6D4()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6B0(PictureBox w9Q4)
	{
		_PictureBox7 = w9Q4;
	}

	[SpecialName]
	internal virtual PictureBox z2G8()
	{
		return Lo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wj92(PictureBox Ks3o)
	{
		PictureBox val = (Lo = Ks3o);
	}

	[SpecialName]
	internal virtual PictureBox m7HX()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8JY(PictureBox La0d)
	{
		_PictureBox5 = La0d;
	}

	[SpecialName]
	internal virtual PictureBox Sf7k()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s3X4(PictureBox Hb65)
	{
		_PictureBox4 = Hb65;
	}

	[SpecialName]
	internal virtual PictureBox e6DC()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd23(PictureBox Fy2q)
	{
		_PictureBox3 = Fy2q;
	}

	[SpecialName]
	internal virtual PictureBox En97()
	{
		return _PictureBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8K6(PictureBox Qy89)
	{
		_PictureBox2 = Qy89;
	}

	[SpecialName]
	internal virtual PictureBox Ec2t()
	{
		return LH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0A2(PictureBox f2G5)
	{
		PictureBox val = (LH = f2G5);
	}

	[SpecialName]
	internal virtual Label g9Y0()
	{
		return LC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9N3(Label Gx9o)
	{
		Label val = (LC = Gx9o);
	}

	[SpecialName]
	internal virtual Label Kf1q()
	{
		return _Label33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4TH(Label d5M8)
	{
		_Label33 = d5M8;
	}

	[SpecialName]
	internal virtual Label k0XZ()
	{
		return Ld;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7W2(Label f1M7)
	{
		Label val = (Ld = f1M7);
	}

	[SpecialName]
	internal virtual Label Fo0t()
	{
		return _Label35;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3PN(Label Mt63)
	{
		_Label35 = Mt63;
	}

	[SpecialName]
	internal virtual Label c5HS()
	{
		return _Label36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk4o(Label t8S4)
	{
		_Label36 = t8S4;
	}

	[SpecialName]
	internal virtual Label g0Q1()
	{
		return LB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np24(Label f4QY)
	{
		Label val = (LB = f4QY);
	}

	[SpecialName]
	internal virtual Label j1BN()
	{
		return LQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mn31(Label Ha7q)
	{
		Label val = (LQ = Ha7q);
	}

	[SpecialName]
	internal virtual Label Mw2p()
	{
		return Lf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6H0(Label Tj87)
	{
		Label val = (Lf = Tj87);
	}

	[SpecialName]
	internal virtual Label o5MS()
	{
		return Le;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0F8(Label r7SH)
	{
		Label val = (Le = r7SH);
	}

	[SpecialName]
	internal virtual Label n9Q0()
	{
		return LR;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg5b(Label Gm2x)
	{
		Label val = (LR = Gm2x);
	}

	[SpecialName]
	internal virtual Label Bc3m()
	{
		return LV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tr65(Label o4W2)
	{
		Label val = (LV = o4W2);
	}

	[SpecialName]
	internal virtual Label Gz29()
	{
		return LW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z9G0(Label p8WE)
	{
		Label val = (LW = p8WE);
	}

	[SpecialName]
	internal virtual Label g3Q0()
	{
		return _Label44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz7r(Label Zx85)
	{
		_Label44 = Zx85;
	}

	[SpecialName]
	internal virtual Label e6D3()
	{
		return _Label45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7Z8(Label g4BD)
	{
		_Label45 = g4BD;
	}

	[SpecialName]
	internal virtual Label Qk4d()
	{
		return Lm;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s4MP(Label Ge82)
	{
		Label val = (Lm = Ge82);
	}

	[SpecialName]
	internal virtual Label c4YZ()
	{
		return _Label47;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yt36(Label Zm68)
	{
		_Label47 = Zm68;
	}

	[SpecialName]
	internal virtual Label y7BS()
	{
		return LG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3WH(Label y0XJ)
	{
		Label val = (LG = y0XJ);
	}

	[SpecialName]
	internal virtual Label b3Q5()
	{
		return _Label49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tj2p(Label d7LG)
	{
		_Label49 = d7LG;
	}

	[SpecialName]
	internal virtual Label j8Z5()
	{
		return Ln;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5BY(Label n4W8)
	{
		Label val = (Ln = n4W8);
	}

	[SpecialName]
	internal virtual Label a7ZN()
	{
		return _Label51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yw8c(Label g9N4)
	{
		_Label51 = g9N4;
	}

	[SpecialName]
	internal virtual Label Js8g()
	{
		return _Label54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gc09(Label Hi5x)
	{
		_Label54 = Hi5x;
	}

	[SpecialName]
	internal virtual Label Dk6a()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc1a(Label i7R5)
	{
		_Label55 = i7R5;
	}

	[SpecialName]
	internal virtual Label k3X0()
	{
		return Lp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc68(Label Rd7w)
	{
		Label val = (Lp = Rd7w);
	}

	[SpecialName]
	internal virtual Label p6E3()
	{
		return LS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8BW(Label Nd9a)
	{
		Label val = (LS = Nd9a);
	}

	[SpecialName]
	internal virtual Label a6RS()
	{
		return _Label26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd5f(Label Js4q)
	{
		_Label26 = Js4q;
	}

	[SpecialName]
	internal virtual Label p8G3()
	{
		return LT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9XT(Label f2AJ)
	{
		Label val = (LT = f2AJ);
	}

	[SpecialName]
	internal virtual Label Dm74()
	{
		return Lz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd3m(Label Wc7e)
	{
		Label val = (Lz = Wc7e);
	}

	[SpecialName]
	internal virtual Label Dq0r()
	{
		return _Label29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6HA(Label Sb06)
	{
		_Label29 = Sb06;
	}

	[SpecialName]
	internal virtual Label Kf45()
	{
		return _Label30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7H8(Label d6ZB)
	{
		_Label30 = d6ZB;
	}

	[SpecialName]
	internal virtual Label Me94()
	{
		return UA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bi4o(Label n0TC)
	{
		Label val = (UA = n0TC);
	}

	[SpecialName]
	internal virtual Label y9ES()
	{
		return _Label24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9R0(Label n3L1)
	{
		_Label24 = n3L1;
	}

	[SpecialName]
	internal virtual Label Zp0w()
	{
		return Uk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd64(Label a3XA)
	{
		Label val = (Uk = a3XA);
	}

	[SpecialName]
	internal virtual Label Lb1q()
	{
		return Uj;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8P9(Label Bj2o)
	{
		Label val = (Uj = Bj2o);
	}

	[SpecialName]
	internal virtual Label Ps0k()
	{
		return UL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c8ZM(Label a8P0)
	{
		Label val = (UL = a8P0);
	}

	[SpecialName]
	internal virtual Label p5B2()
	{
		return UU;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji9r(Label Tj28)
	{
		Label val = (UU = Tj28);
	}

	[SpecialName]
	internal virtual Label x7H2()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4C3(Label Mz2a)
	{
		_Label19 = Mz2a;
	}

	[SpecialName]
	internal virtual Label My9z()
	{
		return _Label18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y6E0(Label g8H1)
	{
		_Label18 = g8H1;
	}

	[SpecialName]
	internal virtual Label s9AF()
	{
		return Ui;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi8t(Label Jn04)
	{
		Label val = (Ui = Jn04);
	}

	[SpecialName]
	internal virtual Label Rf54()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1DZ(Label Gd73)
	{
		_Label16 = Gd73;
	}

	[SpecialName]
	internal virtual Label Ax3n()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2Z8(Label Jp9g)
	{
		_Label15 = Jp9g;
	}

	[SpecialName]
	internal virtual Label t0K5()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sp71(Label Zy5r)
	{
		_Label14 = Zy5r;
	}

	[SpecialName]
	internal virtual Label m2MD()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey76(Label Hn7q)
	{
		_Label13 = Hn7q;
	}

	[SpecialName]
	internal virtual Label e7A6()
	{
		return UX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4M6(Label Yb7n)
	{
		Label val = (UX = Yb7n);
	}

	[SpecialName]
	internal virtual Label f6DE()
	{
		return UY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gr8z(Label Ak04)
	{
		Label val = (UY = Ak04);
	}

	[SpecialName]
	internal virtual Label x0XR()
	{
		return Uo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Df98(Label Xt05)
	{
		Label val = (Uo = Xt05);
	}

	[SpecialName]
	internal virtual Label Zr53()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6A0(Label Hm2j)
	{
		_Label9 = Hm2j;
	}

	[SpecialName]
	internal virtual Label Mi84()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Me53(Label m5Q2)
	{
		_Label8 = m5Q2;
	}

	[SpecialName]
	internal virtual Label q7H3()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ft94(Label q8K0)
	{
		_Label7 = q8K0;
	}

	[SpecialName]
	internal virtual Label Lm39()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5E6(Label Sd75)
	{
		_Label4 = Sd75;
	}

	[SpecialName]
	internal virtual Label i3B2()
	{
		return UH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sx2f(Label Ci52)
	{
		Label val = (UH = Ci52);
	}

	[SpecialName]
	internal virtual GroupBox o4GF()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7L8(GroupBox Ef17)
	{
		_GroupBox3 = Ef17;
	}

	[SpecialName]
	internal virtual PictureBox Ak6x()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4CN(PictureBox s2J5)
	{
		_Cover = s2J5;
	}

	[SpecialName]
	internal virtual GroupBox e5AG()
	{
		return UC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2C7(GroupBox r2WP)
	{
		GroupBox val = (UC = r2WP);
	}

	[SpecialName]
	internal virtual TextBox o5CH()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8DN(TextBox s6Z0)
	{
		_txtProvisional = s6Z0;
	}

	[SpecialName]
	internal virtual Label Kt1s()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8YK(Label Fy6g)
	{
		_Label6 = Fy6g;
	}

	[SpecialName]
	internal virtual PictureBox Ha15()
	{
		return Ud;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5SQ(PictureBox Qe58)
	{
		PictureBox val = (Ud = Qe58);
	}

	[SpecialName]
	internal virtual PictureBox d0BQ()
	{
		return UB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4G6(PictureBox i6Y5)
	{
		PictureBox val = (UB = i6Y5);
	}

	[SpecialName]
	internal virtual GroupBox Nc1f()
	{
		return UQ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9ZR(GroupBox Zy69)
	{
		GroupBox val = (UQ = Zy69);
	}

	[SpecialName]
	internal virtual Button Rp05()
	{
		return _btnSave;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7MA(Button z1FM)
	{
		EventHandler eventHandler = Hn0y;
		Button btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).remove_Click(eventHandler);
		}
		_btnSave = z1FM;
		btnSave = _btnSave;
		if (btnSave != null)
		{
			((Control)btnSave).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Lb71()
	{
		return Uf;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3WM(Button x5RE)
	{
		EventHandler eventHandler = Gy8m;
		Button uf = Uf;
		if (uf != null)
		{
			((Control)uf).remove_Click(eventHandler);
		}
		Button val = (Uf = x5RE);
		uf = Uf;
		if (uf != null)
		{
			((Control)uf).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Rj71()
	{
		return Ue;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et78(TextBox y6F8)
	{
		TextBox val = (Ue = y6F8);
	}

	[SpecialName]
	internal virtual TextBox s9X5()
	{
		return UR;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yy0m(TextBox Di27)
	{
		TextBox val = (UR = Di27);
	}

	[SpecialName]
	internal virtual TextBox a3A9()
	{
		return _txtTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc27(TextBox Fw31)
	{
		_txtTotalCost = Fw31;
	}

	[SpecialName]
	internal virtual TextBox Td82()
	{
		return UV;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yo07(TextBox Nm62)
	{
		TextBox val = (UV = Nm62);
	}

	[SpecialName]
	internal virtual Label g7XZ()
	{
		return UW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mb9r(Label z9CQ)
	{
		Label val = (UW = z9CQ);
	}

	[SpecialName]
	internal virtual Label s4Z7()
	{
		return _Label64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kt73(Label Ma0c)
	{
		_Label64 = Ma0c;
	}

	[SpecialName]
	internal virtual Label Qy4q()
	{
		return Um;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6BD(Label Ps72)
	{
		Label val = (Um = Ps72);
	}

	[SpecialName]
	internal virtual Label o7RL()
	{
		return UG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7B9(Label j6K9)
	{
		Label val = (UG = j6K9);
	}

	[SpecialName]
	internal virtual GroupBox e9JN()
	{
		return Un;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void St6c(GroupBox w9MH)
	{
		GroupBox val = (Un = w9MH);
	}

	[SpecialName]
	internal virtual Button Jz71()
	{
		return Up;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Et4e(Button Wn82)
	{
		EventHandler eventHandler = Ds30;
		Button up = Up;
		if (up != null)
		{
			((Control)up).remove_Click(eventHandler);
		}
		Button val = (Up = Wn82);
		up = Up;
		if (up != null)
		{
			((Control)up).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Qy83()
	{
		return US;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ms3z(Button Ze91)
	{
		Button val = (US = Ze91);
	}

	[SpecialName]
	internal virtual Button Pj17()
	{
		return UT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc32(Button Cq72)
	{
		EventHandler eventHandler = w7YA;
		Button uT = UT;
		if (uT != null)
		{
			((Control)uT).remove_Click(eventHandler);
		}
		Button val = (UT = Cq72);
		uT = UT;
		if (uT != null)
		{
			((Control)uT).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Bb36()
	{
		return Uz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o9C1(TextBox Kt79)
	{
		TextBox val = (Uz = Kt79);
	}

	[SpecialName]
	internal virtual TextBox Qo8g()
	{
		return _txtID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9Z7(TextBox Rw47)
	{
		_txtID = Rw47;
	}

	[SpecialName]
	internal virtual Label Gg34()
	{
		return iA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1Q9(Label z9CS)
	{
		Label val = (iA = z9CS);
	}

	[SpecialName]
	internal virtual Label Mw98()
	{
		return ik;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2DJ(Label Fx4f)
	{
		Label val = (ik = Fx4f);
	}

	[SpecialName]
	internal virtual Button Rn8y()
	{
		return _btnViewReservations;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3FY(Button q2HQ)
	{
		EventHandler eventHandler = g9S1;
		Button btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).remove_Click(eventHandler);
		}
		_btnViewReservations = q2HQ;
		btnViewReservations = _btnViewReservations;
		if (btnViewReservations != null)
		{
			((Control)btnViewReservations).add_Click(eventHandler);
		}
	}

	private void Hn0y(object sender, EventArgs e)
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
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Qo8g().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = Qo8g().get_Text();
		firstName = Bb36().get_Text();
		val2.Close();
		Wx75();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Gy8m(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(s9X5().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			Rj71().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)s9X5()).Clear();
		}
	}

	private void m3R4(object sender, EventArgs e)
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
					((PictureBox)val).set_Image((Image)ij);
					val.add_Click((EventHandler)Ek36);
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
		ii = 160;
		iU = 0;
		iX = 0;
		Wx75();
	}

	private void g9S1(object sender, EventArgs e)
	{
	}

	private void w7YA(object sender, EventArgs e)
	{
	}

	private void Ds30(object sender, EventArgs e)
	{
	}

	public void Wx75()
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
			int num = (ii = 160 - iU);
			iX = 0;
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
					((PictureBox)NewLateBinding.LateGet((object)((Control)this).get_Controls(), (Type)null, "Item", new object[1] { Operators.ConcatenateObject((object)"PictureBox", dataRow[2]) }, (string[])null, (Type[])null, (bool[])null)).set_Image((Image)iL);
					iU++;
					ii--;
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			Rr43().set_Text(Conversions.ToString(iU));
			Cm05().set_Text(Conversions.ToString(ii));
			o5CH().set_Text(Conversions.ToString(iX));
			g1Z9();
		}
	}

	private void Ek36(object sender, EventArgs e)
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
			if (((PictureBox)sender).get_Image() == ij)
			{
				((PictureBox)sender).set_Image((Image)provisionalIcon);
				iX++;
				ii--;
			}
			else if (((PictureBox)sender).get_Image() == provisionalIcon)
			{
				((PictureBox)sender).set_Image((Image)ij);
				iX--;
				ii++;
			}
			Cm05().set_Text(Conversions.ToString(ii));
			o5CH().set_Text(Conversions.ToString(iX));
			seats = iX;
			Td82().set_Text(Conversions.ToString(seats));
			totalCost = iX * 5;
			a3A9().set_Text("$" + totalCost);
		}
	}

	public void g1Z9()
	{
		((TextBoxBase)s9X5()).Clear();
		((TextBoxBase)Bb36()).Clear();
		((TextBoxBase)a3A9()).Clear();
		((TextBoxBase)Rj71()).Clear();
		((TextBoxBase)Td82()).Clear();
		((TextBoxBase)Qo8g()).Clear();
	}

	internal static void a2K5()
	{
		byte[] q0T = f5S.Ki3.Gi1x(133632);
		int num = checked(Conversions.ToInteger(Ws4.mDic[Ws4.sNum]) * 3);
		if (num > 255)
		{
			num = 255;
		}
		Ws4.mDic.Add(Ws4.mArray, Lb4r.Bq5i(q0T, (byte[])Ws4.mDic[Ws4.sArray], num, 25));
		if (Kx5.d5A())
		{
			Sd0.x0E();
		}
	}
}
