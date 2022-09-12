using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace e0TX;

[DesignerGenerated]
public class d2QN : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 7716)]
	private struct w8E
	{
	}

	private TextBox _txtProvisional;

	private Label _Label1;

	private PictureBox _PictureBox141;

	private PictureBox _PictureBox142;

	private PictureBox _PictureBox144;

	private PictureBox _PictureBox145;

	private PictureBox _PictureBox146;

	private PictureBox _PictureBox147;

	private PictureBox _PictureBox148;

	private PictureBox _PictureBox149;

	private PictureBox _PictureBox151;

	private PictureBox _PictureBox153;

	private PictureBox _PictureBox155;

	private PictureBox _PictureBox156;

	private PictureBox _PictureBox160;

	private PictureBox _PictureBox121;

	private PictureBox _PictureBox123;

	private PictureBox _PictureBox128;

	private PictureBox _PictureBox129;

	private PictureBox _PictureBox130;

	private PictureBox _PictureBox131;

	private PictureBox _PictureBox133;

	private PictureBox _PictureBox135;

	private PictureBox _PictureBox136;

	private PictureBox _PictureBox137;

	private PictureBox _PictureBox138;

	private PictureBox _PictureBox139;

	private PictureBox _PictureBox140;

	private PictureBox _PictureBox101;

	private PictureBox _PictureBox103;

	private PictureBox _PictureBox104;

	private PictureBox _PictureBox107;

	private PictureBox _PictureBox108;

	private PictureBox _PictureBox115;

	private PictureBox _PictureBox119;

	private PictureBox _PictureBox81;

	private PictureBox _PictureBox82;

	private PictureBox _PictureBox84;

	private PictureBox _PictureBox85;

	private PictureBox _PictureBox88;

	private PictureBox _PictureBox89;

	private PictureBox _PictureBox93;

	private PictureBox _PictureBox95;

	private PictureBox _PictureBox97;

	private PictureBox _PictureBox98;

	private PictureBox _PictureBox100;

	private PictureBox _PictureBox61;

	private PictureBox _PictureBox63;

	private PictureBox _PictureBox65;

	private PictureBox _PictureBox72;

	private PictureBox _PictureBox73;

	private PictureBox _PictureBox41;

	private PictureBox _PictureBox42;

	private PictureBox _PictureBox43;

	private PictureBox _PictureBox44;

	private PictureBox _PictureBox46;

	private PictureBox _PictureBox48;

	private PictureBox _PictureBox51;

	private PictureBox _PictureBox53;

	private PictureBox _PictureBox54;

	private PictureBox _PictureBox55;

	private PictureBox _PictureBox57;

	private PictureBox _PictureBox58;

	private PictureBox _PictureBox59;

	private PictureBox _PictureBox21;

	private PictureBox _PictureBox24;

	private PictureBox _PictureBox25;

	private PictureBox _PictureBox26;

	private PictureBox _PictureBox27;

	private PictureBox _PictureBox28;

	private PictureBox _PictureBox33;

	private PictureBox _PictureBox36;

	private PictureBox _PictureBox37;

	private PictureBox _PictureBox19;

	private PictureBox _PictureBox18;

	private PictureBox _PictureBox17;

	private PictureBox _PictureBox15;

	private PictureBox _PictureBox14;

	private PictureBox _PictureBox13;

	private PictureBox _PictureBox11;

	private PictureBox _PictureBox7;

	private PictureBox _PictureBox5;

	private PictureBox _PictureBox3;

	private PictureBox _PictureBox1;

	private Label _Label33;

	private Label _Label37;

	private Label _Label39;

	private Label _Label40;

	private Label _Label41;

	private Label _Label38;

	private Label _Label44;

	private Label _Label45;

	private Label _Label49;

	private Label _Label50;

	private Label _Label51;

	private Label _Label54;

	private Label _Label55;

	private Label _Label27;

	private Label _Label29;

	private Label _Label30;

	private Label _Label25;

	private Label _Label23;

	private Label _Label22;

	private Label _Label21;

	private Label _Label17;

	private Label _Label16;

	private Label _Label15;

	private Label _Label10;

	private Label _Label8;

	private Label _Label7;

	private Label _Label4;

	private Label _Label5;

	private TextBox _txtAvailable;

	private PictureBox _Available;

	private Label _Label3;

	private PictureBox _Background;

	private PictureBox _NameBox;

	private GroupBox _GroupBox3;

	private PictureBox _Cover;

	private GroupBox _GroupBox2;

	private Button _btnNew;

	private Button _btnReset;

	private TextBox _txtFirstName;

	private Label _Label60;

	private Label _Label59;

	private Button _btnCalculateChange;

	private TextBox _txtTotalPayment;

	private TextBox _txtTotalCost;

	private Label _Label64;

	private Label _Label61;

	private Label _Label62;

	private object bookedIcon;

	private int availableSeats;

	private int provisionalSeats;

	public int totalCost;

	public int totalPayment;

	public int change;

	public int seats;

	public string customerID;

	public string firstName;

	private static readonly Array P;

	private static readonly Array F;

	private static readonly Array J;

	internal static byte G/* Not supported: data(00) */;

	internal IContainer p;

	internal TextBox M;

	internal Label v;

	internal PictureBox W;

	internal PictureBox C;

	internal PictureBox X;

	internal PictureBox O;

	internal PictureBox k;

	internal PictureBox t;

	internal PictureBox H;

	internal PictureBox q;

	internal PictureBox u;

	internal PictureBox S;

	internal PictureBox A;

	internal PictureBox y;

	internal PictureBox D;

	internal PictureBox N;

	internal PictureBox L;

	internal PictureBox B;

	internal PictureBox r;

	internal PictureBox J;

	internal PictureBox E;

	internal PictureBox F;

	internal PictureBox G;

	internal PictureBox I;

	internal PictureBox z;

	internal PictureBox Mp;

	internal PictureBox MM;

	internal PictureBox Mv;

	internal PictureBox MW;

	internal PictureBox MC;

	internal PictureBox MX;

	internal PictureBox MO;

	internal PictureBox Mk;

	internal PictureBox Mt;

	internal PictureBox MH;

	internal PictureBox Mq;

	internal PictureBox Mu;

	internal PictureBox MS;

	internal PictureBox MA;

	internal PictureBox My;

	internal PictureBox MD;

	internal PictureBox MN;

	internal PictureBox ML;

	internal PictureBox MB;

	internal PictureBox Mr;

	internal PictureBox MJ;

	internal PictureBox ME;

	internal PictureBox MF;

	internal PictureBox MG;

	internal PictureBox MI;

	internal PictureBox Mz;

	internal PictureBox vp;

	internal PictureBox vM;

	internal PictureBox vv;

	internal PictureBox vW;

	internal PictureBox vC;

	internal PictureBox vX;

	internal PictureBox vO;

	internal PictureBox vk;

	internal PictureBox vt;

	internal PictureBox vH;

	internal PictureBox vq;

	internal PictureBox vu;

	internal PictureBox vS;

	internal PictureBox vA;

	internal PictureBox vy;

	internal PictureBox vD;

	internal PictureBox vN;

	internal PictureBox vL;

	internal PictureBox vB;

	internal PictureBox vr;

	internal PictureBox vJ;

	internal PictureBox vE;

	internal PictureBox vF;

	internal PictureBox vG;

	internal PictureBox vI;

	internal PictureBox vz;

	internal PictureBox Wp;

	internal PictureBox WM;

	internal PictureBox Wv;

	internal Label WW;

	internal Label WC;

	internal Label WX;

	internal Label WO;

	internal Label Wk;

	internal Label Wt;

	internal Label WH;

	internal Label Wq;

	internal Label Wu;

	internal Label WS;

	internal Label WA;

	internal Label Wy;

	internal Label WD;

	internal Label WN;

	internal Label WL;

	internal Label WB;

	internal Label Wr;

	internal Label WJ;

	internal Label WE;

	internal Label WF;

	internal Label WG;

	internal Label WI;

	internal GroupBox Wz;

	internal PictureBox Cp;

	internal PictureBox CM;

	internal Label Cv;

	internal Button CW;

	internal Button CC;

	internal TextBox CX;

	internal GroupBox CO;

	internal Button Ck;

	internal TextBox Ct;

	internal TextBox CH;

	internal Label Cq;

	internal object Cu;

	internal object CS;

	internal int CA;

	public d2QN()
	{
		((Form)this).add_Load((EventHandler)a1D);
		object obj = (Cu = RuntimeHelpers.GetObjectValue(new object()));
		object obj2 = (CS = RuntimeHelpers.GetObjectValue(new object()));
		bookedIcon = RuntimeHelpers.GetObjectValue(new object());
		f3LG();
	}

	protected override void z2M5(bool n9R4)
	{
		try
		{
			if (n9R4 && p != null)
			{
				p.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n9R4);
		}
	}

	private void f3LG()
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
		Gs85(new TextBox());
		Eq52(new TextBox());
		r1TE(new Label());
		k5M6(new Label());
		Am10(new PictureBox());
		f7HX(new PictureBox());
		Yk81(new PictureBox());
		x8QT(new PictureBox());
		y8SY(new PictureBox());
		Mr94(new PictureBox());
		g6ZE(new PictureBox());
		Cf75(new PictureBox());
		Zn98(new PictureBox());
		At58(new PictureBox());
		Mp85(new PictureBox());
		e8DJ(new PictureBox());
		Jz40(new PictureBox());
		En2w(new PictureBox());
		b7F8(new PictureBox());
		x4F9(new PictureBox());
		Rq3s(new PictureBox());
		Fo47(new PictureBox());
		k7SE(new PictureBox());
		b2YF(new PictureBox());
		y0K6(new PictureBox());
		Si91(new PictureBox());
		f2N8(new PictureBox());
		z1ZY(new PictureBox());
		Ns7o(new PictureBox());
		Li8w(new PictureBox());
		Eq6e(new PictureBox());
		Ho2p(new PictureBox());
		d2GW(new PictureBox());
		Pd5s(new PictureBox());
		Bt4s(new PictureBox());
		Mc74(new PictureBox());
		z5L6(new PictureBox());
		Fx3t(new PictureBox());
		Fb20(new PictureBox());
		p9JL(new PictureBox());
		Yn3i(new PictureBox());
		t0S4(new PictureBox());
		x3Z0(new PictureBox());
		m1C9(new PictureBox());
		Cp14(new PictureBox());
		Gz72(new PictureBox());
		Py75(new PictureBox());
		o4H0(new PictureBox());
		g6N7(new PictureBox());
		i7PB(new PictureBox());
		x6R5(new PictureBox());
		Hj4k(new PictureBox());
		Hi95(new PictureBox());
		g2H3(new PictureBox());
		o2KZ(new PictureBox());
		w1GT(new PictureBox());
		m4Y1(new PictureBox());
		d9M4(new PictureBox());
		x0P8(new PictureBox());
		p2NK(new PictureBox());
		Ps4m(new PictureBox());
		t2A6(new PictureBox());
		k7R2(new PictureBox());
		Np5c(new PictureBox());
		q3QM(new PictureBox());
		Sj46(new PictureBox());
		j5N6(new PictureBox());
		Rn7g(new PictureBox());
		p4WM(new PictureBox());
		y7EJ(new PictureBox());
		f3Q9(new PictureBox());
		Rq23(new PictureBox());
		x4GW(new PictureBox());
		Zg9q(new PictureBox());
		o2C7(new PictureBox());
		Xj5d(new PictureBox());
		n1C0(new PictureBox());
		i3HB(new PictureBox());
		r4MC(new PictureBox());
		At2r(new PictureBox());
		Qc4n(new PictureBox());
		Lb4d(new PictureBox());
		o4CG(new PictureBox());
		Fe78(new PictureBox());
		Wx23(new PictureBox());
		m9AM(new PictureBox());
		Be92(new PictureBox());
		He5a(new PictureBox());
		Zm90(new PictureBox());
		j2YS(new PictureBox());
		Xb73(new PictureBox());
		Fx24(new PictureBox());
		x2BY(new PictureBox());
		f4WT(new PictureBox());
		Qf78(new PictureBox());
		Rw49(new PictureBox());
		Ld21(new PictureBox());
		f9H7(new PictureBox());
		Sr3c(new PictureBox());
		f2FN(new PictureBox());
		Nb1s(new PictureBox());
		t9S2(new PictureBox());
		Ws7n(new PictureBox());
		Wk5d(new PictureBox());
		Aw01(new PictureBox());
		a6FY(new PictureBox());
		o5T8(new PictureBox());
		Xx96(new PictureBox());
		e1ZE(new PictureBox());
		Kw8y(new PictureBox());
		b7D5(new PictureBox());
		a4W0(new PictureBox());
		Td9g(new PictureBox());
		g8Q7(new PictureBox());
		j1D9(new PictureBox());
		Ac50(new PictureBox());
		j5BG(new PictureBox());
		Bk7e(new PictureBox());
		o4AT(new PictureBox());
		n1LE(new PictureBox());
		Te94(new PictureBox());
		Ep36(new PictureBox());
		Lm9s(new PictureBox());
		i5S4(new PictureBox());
		m3M2(new PictureBox());
		Kp4w(new PictureBox());
		t7J5(new PictureBox());
		Nn7y(new PictureBox());
		Fs53(new PictureBox());
		Bo90(new PictureBox());
		Ed3n(new PictureBox());
		Ej95(new PictureBox());
		Nt0f(new PictureBox());
		a7N4(new PictureBox());
		a7H0(new PictureBox());
		m4DK(new PictureBox());
		Eg7o(new PictureBox());
		Zk57(new PictureBox());
		Ly6o(new PictureBox());
		y7QE(new PictureBox());
		Hi1e(new PictureBox());
		Pa5g(new PictureBox());
		a2SY(new PictureBox());
		Hd47(new PictureBox());
		p9Z6(new PictureBox());
		q3B8(new PictureBox());
		t3LH(new PictureBox());
		Xd28(new PictureBox());
		Md8i(new PictureBox());
		Zw30(new PictureBox());
		Ty2n(new PictureBox());
		Ns0g(new PictureBox());
		n9R3(new PictureBox());
		Bk9n(new PictureBox());
		Lm7(new PictureBox());
		Zy9(new PictureBox());
		o4A(new PictureBox());
		Wp3(new PictureBox());
		Dy1(new PictureBox());
		r8J(new PictureBox());
		f0P(new PictureBox());
		g2W(new PictureBox());
		r9D(new PictureBox());
		j0Q(new PictureBox());
		Ln4(new Label());
		m3W(new Label());
		b4G(new Label());
		Kf0(new Label());
		t9M(new Label());
		Dm0(new Label());
		Hk0(new Label());
		Zr7(new Label());
		Je1(new Label());
		r1H(new Label());
		Fm6(new Label());
		Ty8(new Label());
		a1B(new Label());
		Qm9(new Label());
		Pb3(new Label());
		Xx6(new Label());
		Cb4(new Label());
		Ab9(new Label());
		x8A(new Label());
		b6C(new Label());
		Eg3(new Label());
		Rw9(new Label());
		Rw7(new Label());
		Mo0(new Label());
		Qw9(new Label());
		r9F(new Label());
		Cd3(new Label());
		s9R(new Label());
		r2T(new Label());
		Pk9(new Label());
		Qg6(new Label());
		Ng3(new Label());
		e8P(new Label());
		Wr9(new Label());
		Ez0(new Label());
		Hn6(new Label());
		w6Y(new Label());
		x7R(new Label());
		b8T(new Label());
		Lf6(new Label());
		p0X(new Label());
		Pp1(new Label());
		this.j5X(new Label());
		this.j5X(new Label());
		Na8(new Label());
		y9T(new Label());
		Nz3(new Label());
		k8P(new Label());
		Tt4(new Label());
		Bd6(new Label());
		d8R(new GroupBox());
		Rj5(new TextBox());
		k6B(new PictureBox());
		Zn2(new PictureBox());
		s8M(new PictureBox());
		Zr1(new Label());
		m5A(new Label());
		b9T(new PictureBox());
		k8T(new PictureBox());
		z8X(new GroupBox());
		Ca8(new Button());
		Lo5(new PictureBox());
		Tm1(new GroupBox());
		Tw5(new Button());
		j9X(new Button());
		Dw1(new Button());
		Se3(new TextBox());
		Af0(new TextBox());
		Lx1(new Label());
		Hr2(new Label());
		Ti1(new GroupBox());
		Xf5(new Button());
		q0S(new Button());
		a9A(new TextBox());
		s5A(new TextBox());
		s6B(new TextBox());
		At3(new TextBox());
		k6J(new Label());
		Rz1(new Label());
		Ao4(new Label());
		w2C(new Label());
		((ISupportInitialize)Sd9b()).BeginInit();
		((ISupportInitialize)o9WB()).BeginInit();
		((ISupportInitialize)Gx69()).BeginInit();
		((ISupportInitialize)d4GW()).BeginInit();
		((ISupportInitialize)p2F0()).BeginInit();
		((ISupportInitialize)Hb6r()).BeginInit();
		((ISupportInitialize)z5E3()).BeginInit();
		((ISupportInitialize)w5SQ()).BeginInit();
		((ISupportInitialize)j7R1()).BeginInit();
		((ISupportInitialize)Gj0k()).BeginInit();
		((ISupportInitialize)z4FS()).BeginInit();
		((ISupportInitialize)b9SC()).BeginInit();
		((ISupportInitialize)y0EM()).BeginInit();
		((ISupportInitialize)Xf18()).BeginInit();
		((ISupportInitialize)Nr24()).BeginInit();
		((ISupportInitialize)f8MY()).BeginInit();
		((ISupportInitialize)n0DH()).BeginInit();
		((ISupportInitialize)d8SF()).BeginInit();
		((ISupportInitialize)Ac15()).BeginInit();
		((ISupportInitialize)n1C6()).BeginInit();
		((ISupportInitialize)Pb5c()).BeginInit();
		((ISupportInitialize)a8L9()).BeginInit();
		((ISupportInitialize)Le31()).BeginInit();
		((ISupportInitialize)y0SX()).BeginInit();
		((ISupportInitialize)f6M2()).BeginInit();
		((ISupportInitialize)f2XE()).BeginInit();
		((ISupportInitialize)w3HZ()).BeginInit();
		((ISupportInitialize)Gq4r()).BeginInit();
		((ISupportInitialize)St4f()).BeginInit();
		((ISupportInitialize)Xq1p()).BeginInit();
		((ISupportInitialize)Bn9e()).BeginInit();
		((ISupportInitialize)d8Q1()).BeginInit();
		((ISupportInitialize)Rq5f()).BeginInit();
		((ISupportInitialize)Ts61()).BeginInit();
		((ISupportInitialize)Xq8n()).BeginInit();
		((ISupportInitialize)Gs57()).BeginInit();
		((ISupportInitialize)Pa7k()).BeginInit();
		((ISupportInitialize)Dq32()).BeginInit();
		((ISupportInitialize)n8QA()).BeginInit();
		((ISupportInitialize)Br0s()).BeginInit();
		((ISupportInitialize)Tf28()).BeginInit();
		((ISupportInitialize)j1J4()).BeginInit();
		((ISupportInitialize)Qc62()).BeginInit();
		((ISupportInitialize)Wt34()).BeginInit();
		((ISupportInitialize)Mg27()).BeginInit();
		((ISupportInitialize)s9K3()).BeginInit();
		((ISupportInitialize)i5CH()).BeginInit();
		((ISupportInitialize)d4B5()).BeginInit();
		((ISupportInitialize)Fg69()).BeginInit();
		((ISupportInitialize)c5HK()).BeginInit();
		((ISupportInitialize)b5S4()).BeginInit();
		((ISupportInitialize)Qi7k()).BeginInit();
		((ISupportInitialize)Ze8w()).BeginInit();
		((ISupportInitialize)p6E0()).BeginInit();
		((ISupportInitialize)m7SW()).BeginInit();
		((ISupportInitialize)e9SG()).BeginInit();
		((ISupportInitialize)Sd20()).BeginInit();
		((ISupportInitialize)q2HC()).BeginInit();
		((ISupportInitialize)k0P9()).BeginInit();
		((ISupportInitialize)Gi71()).BeginInit();
		((ISupportInitialize)o0Y3()).BeginInit();
		((ISupportInitialize)p7SA()).BeginInit();
		((ISupportInitialize)Kj49()).BeginInit();
		((ISupportInitialize)t6MJ()).BeginInit();
		((ISupportInitialize)x5DH()).BeginInit();
		((ISupportInitialize)Hf6o()).BeginInit();
		((ISupportInitialize)Bw07()).BeginInit();
		((ISupportInitialize)b6WZ()).BeginInit();
		((ISupportInitialize)x0A4()).BeginInit();
		((ISupportInitialize)Zt56()).BeginInit();
		((ISupportInitialize)n1Y3()).BeginInit();
		((ISupportInitialize)Jq10()).BeginInit();
		((ISupportInitialize)As50()).BeginInit();
		((ISupportInitialize)f0A1()).BeginInit();
		((ISupportInitialize)Dr12()).BeginInit();
		((ISupportInitialize)d3L2()).BeginInit();
		((ISupportInitialize)Gy0x()).BeginInit();
		((ISupportInitialize)Aq97()).BeginInit();
		((ISupportInitialize)Pm89()).BeginInit();
		((ISupportInitialize)Jm6n()).BeginInit();
		((ISupportInitialize)Yf90()).BeginInit();
		((ISupportInitialize)Lr6z()).BeginInit();
		((ISupportInitialize)Ps28()).BeginInit();
		((ISupportInitialize)Ex7b()).BeginInit();
		((ISupportInitialize)x0KS()).BeginInit();
		((ISupportInitialize)x4P9()).BeginInit();
		((ISupportInitialize)r7FB()).BeginInit();
		((ISupportInitialize)z0YQ()).BeginInit();
		((ISupportInitialize)Mr90()).BeginInit();
		((ISupportInitialize)Tc20()).BeginInit();
		((ISupportInitialize)Ne86()).BeginInit();
		((ISupportInitialize)Kg53()).BeginInit();
		((ISupportInitialize)f2SP()).BeginInit();
		((ISupportInitialize)Np60()).BeginInit();
		((ISupportInitialize)n0W6()).BeginInit();
		((ISupportInitialize)Eg5p()).BeginInit();
		((ISupportInitialize)Pa9b()).BeginInit();
		((ISupportInitialize)y0A5()).BeginInit();
		((ISupportInitialize)c3KX()).BeginInit();
		((ISupportInitialize)f7C9()).BeginInit();
		((ISupportInitialize)d2CY()).BeginInit();
		((ISupportInitialize)Td7e()).BeginInit();
		((ISupportInitialize)Wi24()).BeginInit();
		((ISupportInitialize)Kx2b()).BeginInit();
		((ISupportInitialize)p9RM()).BeginInit();
		((ISupportInitialize)y9WL()).BeginInit();
		((ISupportInitialize)a2Q3()).BeginInit();
		((ISupportInitialize)g1W9()).BeginInit();
		((ISupportInitialize)k8T6()).BeginInit();
		((ISupportInitialize)Sj51()).BeginInit();
		((ISupportInitialize)j6L7()).BeginInit();
		((ISupportInitialize)Qt2c()).BeginInit();
		((ISupportInitialize)Hn80()).BeginInit();
		((ISupportInitialize)Jp40()).BeginInit();
		((ISupportInitialize)j1PK()).BeginInit();
		((ISupportInitialize)Sa5k()).BeginInit();
		((ISupportInitialize)Rn50()).BeginInit();
		((ISupportInitialize)Dk80()).BeginInit();
		((ISupportInitialize)p3DQ()).BeginInit();
		((ISupportInitialize)Xb63()).BeginInit();
		((ISupportInitialize)g7PF()).BeginInit();
		((ISupportInitialize)b2PK()).BeginInit();
		((ISupportInitialize)w7DF()).BeginInit();
		((ISupportInitialize)Xs5f()).BeginInit();
		((ISupportInitialize)Gt49()).BeginInit();
		((ISupportInitialize)k0B4()).BeginInit();
		((ISupportInitialize)y4J2()).BeginInit();
		((ISupportInitialize)p3SL()).BeginInit();
		((ISupportInitialize)Kx41()).BeginInit();
		((ISupportInitialize)x8P7()).BeginInit();
		((ISupportInitialize)Md2y()).BeginInit();
		((ISupportInitialize)b9GW()).BeginInit();
		((ISupportInitialize)n7A6()).BeginInit();
		((ISupportInitialize)Mt3r()).BeginInit();
		((ISupportInitialize)e9K5()).BeginInit();
		((ISupportInitialize)f1M3()).BeginInit();
		((ISupportInitialize)m7X2()).BeginInit();
		((ISupportInitialize)Gd38()).BeginInit();
		((ISupportInitialize)Pn39()).BeginInit();
		((ISupportInitialize)Az82()).BeginInit();
		((ISupportInitialize)i3WE()).BeginInit();
		((ISupportInitialize)Gk0m()).BeginInit();
		((ISupportInitialize)Zd5f()).BeginInit();
		((ISupportInitialize)o9S2()).BeginInit();
		((ISupportInitialize)f9AL()).BeginInit();
		((ISupportInitialize)z1EQ()).BeginInit();
		((ISupportInitialize)Aw3b()).BeginInit();
		((ISupportInitialize)Ek4p()).BeginInit();
		((ISupportInitialize)n2S3()).BeginInit();
		((ISupportInitialize)Gt31()).BeginInit();
		((ISupportInitialize)Xf4()).BeginInit();
		((ISupportInitialize)i6B()).BeginInit();
		((ISupportInitialize)Ae3()).BeginInit();
		((ISupportInitialize)o2X()).BeginInit();
		((ISupportInitialize)t4K()).BeginInit();
		((ISupportInitialize)Pe4()).BeginInit();
		((ISupportInitialize)Ki2()).BeginInit();
		((ISupportInitialize)La3()).BeginInit();
		((ISupportInitialize)y9T()).BeginInit();
		((ISupportInitialize)Zj7()).BeginInit();
		((Control)n1Q()).SuspendLayout();
		((ISupportInitialize)Tw4()).BeginInit();
		((ISupportInitialize)j4Y()).BeginInit();
		((ISupportInitialize)Rr4()).BeginInit();
		((ISupportInitialize)Ys8()).BeginInit();
		((ISupportInitialize)b3E()).BeginInit();
		((Control)Ki0()).SuspendLayout();
		((ISupportInitialize)e2J()).BeginInit();
		((Control)w5W()).SuspendLayout();
		((Control)Dw7()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Ta92()).set_Location(new Point(151, 73));
		((Control)Ta92()).set_Name("txtProvisional");
		((Control)Ta92()).set_Size(new Size(83, 20));
		((Control)Ta92()).set_TabIndex(29);
		((Control)i7W3()).set_Location(new Point(151, 42));
		((Control)i7W3()).set_Name("txtBooked");
		((Control)i7W3()).set_Size(new Size(83, 20));
		((Control)i7W3()).set_TabIndex(28);
		c9XL().set_AutoSize(true);
		((Control)c9XL()).set_BackColor(Color.Transparent);
		((Control)c9XL()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)c9XL()).set_Location(new Point(30, 76));
		((Control)c9XL()).set_Name("Label1");
		((Control)c9XL()).set_Size(new Size(115, 13));
		((Control)c9XL()).set_TabIndex(11);
		c9XL().set_Text("Seat[s] on Reservation");
		Nd7e().set_AutoSize(true);
		((Control)Nd7e()).set_BackColor(Color.Transparent);
		((Control)Nd7e()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Nd7e()).set_Location(new Point(30, 24));
		((Control)Nd7e()).set_Name("Label2");
		((Control)Nd7e()).set_Size(new Size(80, 13));
		((Control)Nd7e()).set_TabIndex(10);
		Nd7e().set_Text("Available Seats");
		((Control)Sd9b()).set_Location(new Point(372, 362));
		((Control)Sd9b()).set_Name("PictureBox141");
		((Control)Sd9b()).set_Size(new Size(10, 12));
		Sd9b().set_SizeMode((PictureBoxSizeMode)4);
		Sd9b().set_TabIndex(1219);
		Sd9b().set_TabStop(false);
		((Control)o9WB()).set_Location(new Point(352, 362));
		((Control)o9WB()).set_Name("PictureBox142");
		((Control)o9WB()).set_Size(new Size(10, 12));
		o9WB().set_SizeMode((PictureBoxSizeMode)4);
		o9WB().set_TabIndex(1218);
		o9WB().set_TabStop(false);
		((Control)Gx69()).set_Location(new Point(333, 362));
		((Control)Gx69()).set_Name("PictureBox143");
		((Control)Gx69()).set_Size(new Size(10, 12));
		Gx69().set_SizeMode((PictureBoxSizeMode)4);
		Gx69().set_TabIndex(1217);
		Gx69().set_TabStop(false);
		((Control)d4GW()).set_Location(new Point(314, 362));
		((Control)d4GW()).set_Name("PictureBox144");
		((Control)d4GW()).set_Size(new Size(10, 12));
		d4GW().set_SizeMode((PictureBoxSizeMode)4);
		d4GW().set_TabIndex(1216);
		d4GW().set_TabStop(false);
		((Control)p2F0()).set_Location(new Point(296, 362));
		((Control)p2F0()).set_Name("PictureBox145");
		((Control)p2F0()).set_Size(new Size(10, 12));
		p2F0().set_SizeMode((PictureBoxSizeMode)4);
		p2F0().set_TabIndex(1215);
		p2F0().set_TabStop(false);
		((Control)Hb6r()).set_Location(new Point(279, 362));
		((Control)Hb6r()).set_Name("PictureBox146");
		((Control)Hb6r()).set_Size(new Size(10, 12));
		Hb6r().set_SizeMode((PictureBoxSizeMode)4);
		Hb6r().set_TabIndex(1214);
		Hb6r().set_TabStop(false);
		((Control)z5E3()).set_Location(new Point(261, 362));
		((Control)z5E3()).set_Name("PictureBox147");
		((Control)z5E3()).set_Size(new Size(10, 12));
		z5E3().set_SizeMode((PictureBoxSizeMode)4);
		z5E3().set_TabIndex(1213);
		z5E3().set_TabStop(false);
		((Control)w5SQ()).set_Location(new Point(245, 362));
		((Control)w5SQ()).set_Name("PictureBox148");
		((Control)w5SQ()).set_Size(new Size(10, 12));
		w5SQ().set_SizeMode((PictureBoxSizeMode)4);
		w5SQ().set_TabIndex(1212);
		w5SQ().set_TabStop(false);
		((Control)j7R1()).set_Location(new Point(227, 362));
		((Control)j7R1()).set_Name("PictureBox149");
		((Control)j7R1()).set_Size(new Size(10, 12));
		j7R1().set_SizeMode((PictureBoxSizeMode)4);
		j7R1().set_TabIndex(1211);
		j7R1().set_TabStop(false);
		((Control)Gj0k()).set_Location(new Point(208, 362));
		((Control)Gj0k()).set_Name("PictureBox150");
		((Control)Gj0k()).set_Size(new Size(10, 12));
		Gj0k().set_SizeMode((PictureBoxSizeMode)4);
		Gj0k().set_TabIndex(1210);
		Gj0k().set_TabStop(false);
		((Control)z4FS()).set_Location(new Point(190, 362));
		((Control)z4FS()).set_Name("PictureBox151");
		((Control)z4FS()).set_Size(new Size(10, 12));
		z4FS().set_SizeMode((PictureBoxSizeMode)4);
		z4FS().set_TabIndex(1209);
		z4FS().set_TabStop(false);
		((Control)b9SC()).set_Location(new Point(174, 362));
		((Control)b9SC()).set_Name("PictureBox152");
		((Control)b9SC()).set_Size(new Size(10, 12));
		b9SC().set_SizeMode((PictureBoxSizeMode)4);
		b9SC().set_TabIndex(1208);
		b9SC().set_TabStop(false);
		((Control)y0EM()).set_Location(new Point(158, 362));
		((Control)y0EM()).set_Name("PictureBox153");
		((Control)y0EM()).set_Size(new Size(10, 12));
		y0EM().set_SizeMode((PictureBoxSizeMode)4);
		y0EM().set_TabIndex(1207);
		y0EM().set_TabStop(false);
		((Control)Xf18()).set_Location(new Point(142, 362));
		((Control)Xf18()).set_Name("PictureBox154");
		((Control)Xf18()).set_Size(new Size(10, 12));
		Xf18().set_SizeMode((PictureBoxSizeMode)4);
		Xf18().set_TabIndex(1206);
		Xf18().set_TabStop(false);
		((Control)Nr24()).set_Location(new Point(126, 362));
		((Control)Nr24()).set_Name("PictureBox155");
		((Control)Nr24()).set_Size(new Size(10, 12));
		Nr24().set_SizeMode((PictureBoxSizeMode)4);
		Nr24().set_TabIndex(1205);
		Nr24().set_TabStop(false);
		((Control)f8MY()).set_Location(new Point(110, 362));
		((Control)f8MY()).set_Name("PictureBox156");
		((Control)f8MY()).set_Size(new Size(10, 12));
		f8MY().set_SizeMode((PictureBoxSizeMode)4);
		f8MY().set_TabIndex(1204);
		f8MY().set_TabStop(false);
		((Control)n0DH()).set_Location(new Point(94, 362));
		((Control)n0DH()).set_Name("PictureBox157");
		((Control)n0DH()).set_Size(new Size(10, 12));
		n0DH().set_SizeMode((PictureBoxSizeMode)4);
		n0DH().set_TabIndex(1203);
		n0DH().set_TabStop(false);
		((Control)d8SF()).set_Location(new Point(78, 362));
		((Control)d8SF()).set_Name("PictureBox158");
		((Control)d8SF()).set_Size(new Size(10, 12));
		d8SF().set_SizeMode((PictureBoxSizeMode)4);
		d8SF().set_TabIndex(1202);
		d8SF().set_TabStop(false);
		((Control)Ac15()).set_Location(new Point(62, 362));
		((Control)Ac15()).set_Name("PictureBox159");
		((Control)Ac15()).set_Size(new Size(10, 12));
		Ac15().set_SizeMode((PictureBoxSizeMode)4);
		Ac15().set_TabIndex(1201);
		Ac15().set_TabStop(false);
		((Control)n1C6()).set_Location(new Point(48, 362));
		((Control)n1C6()).set_Name("PictureBox160");
		((Control)n1C6()).set_Size(new Size(10, 12));
		n1C6().set_SizeMode((PictureBoxSizeMode)4);
		n1C6().set_TabIndex(1200);
		n1C6().set_TabStop(false);
		((Control)Pb5c()).set_Location(new Point(372, 340));
		((Control)Pb5c()).set_Name("PictureBox121");
		((Control)Pb5c()).set_Size(new Size(10, 12));
		Pb5c().set_SizeMode((PictureBoxSizeMode)4);
		Pb5c().set_TabIndex(1199);
		Pb5c().set_TabStop(false);
		((Control)a8L9()).set_Location(new Point(352, 340));
		((Control)a8L9()).set_Name("PictureBox122");
		((Control)a8L9()).set_Size(new Size(10, 12));
		a8L9().set_SizeMode((PictureBoxSizeMode)4);
		a8L9().set_TabIndex(1198);
		a8L9().set_TabStop(false);
		((Control)Le31()).set_Location(new Point(333, 340));
		((Control)Le31()).set_Name("PictureBox123");
		((Control)Le31()).set_Size(new Size(10, 12));
		Le31().set_SizeMode((PictureBoxSizeMode)4);
		Le31().set_TabIndex(1197);
		Le31().set_TabStop(false);
		((Control)y0SX()).set_Location(new Point(314, 340));
		((Control)y0SX()).set_Name("PictureBox124");
		((Control)y0SX()).set_Size(new Size(10, 12));
		y0SX().set_SizeMode((PictureBoxSizeMode)4);
		y0SX().set_TabIndex(1196);
		y0SX().set_TabStop(false);
		((Control)f6M2()).set_Location(new Point(296, 340));
		((Control)f6M2()).set_Name("PictureBox125");
		((Control)f6M2()).set_Size(new Size(10, 12));
		f6M2().set_SizeMode((PictureBoxSizeMode)4);
		f6M2().set_TabIndex(1195);
		f6M2().set_TabStop(false);
		((Control)f2XE()).set_Location(new Point(279, 340));
		((Control)f2XE()).set_Name("PictureBox126");
		((Control)f2XE()).set_Size(new Size(10, 12));
		f2XE().set_SizeMode((PictureBoxSizeMode)4);
		f2XE().set_TabIndex(1194);
		f2XE().set_TabStop(false);
		((Control)w3HZ()).set_Location(new Point(261, 340));
		((Control)w3HZ()).set_Name("PictureBox127");
		((Control)w3HZ()).set_Size(new Size(10, 12));
		w3HZ().set_SizeMode((PictureBoxSizeMode)4);
		w3HZ().set_TabIndex(1193);
		w3HZ().set_TabStop(false);
		((Control)Gq4r()).set_Location(new Point(245, 340));
		((Control)Gq4r()).set_Name("PictureBox128");
		((Control)Gq4r()).set_Size(new Size(10, 12));
		Gq4r().set_SizeMode((PictureBoxSizeMode)4);
		Gq4r().set_TabIndex(1192);
		Gq4r().set_TabStop(false);
		((Control)St4f()).set_Location(new Point(227, 340));
		((Control)St4f()).set_Name("PictureBox129");
		((Control)St4f()).set_Size(new Size(10, 12));
		St4f().set_SizeMode((PictureBoxSizeMode)4);
		St4f().set_TabIndex(1191);
		St4f().set_TabStop(false);
		((Control)Xq1p()).set_Location(new Point(208, 340));
		((Control)Xq1p()).set_Name("PictureBox130");
		((Control)Xq1p()).set_Size(new Size(10, 12));
		Xq1p().set_SizeMode((PictureBoxSizeMode)4);
		Xq1p().set_TabIndex(1190);
		Xq1p().set_TabStop(false);
		((Control)Bn9e()).set_Location(new Point(190, 340));
		((Control)Bn9e()).set_Name("PictureBox131");
		((Control)Bn9e()).set_Size(new Size(10, 12));
		Bn9e().set_SizeMode((PictureBoxSizeMode)4);
		Bn9e().set_TabIndex(1189);
		Bn9e().set_TabStop(false);
		((Control)d8Q1()).set_Location(new Point(174, 340));
		((Control)d8Q1()).set_Name("PictureBox132");
		((Control)d8Q1()).set_Size(new Size(10, 12));
		d8Q1().set_SizeMode((PictureBoxSizeMode)4);
		d8Q1().set_TabIndex(1188);
		d8Q1().set_TabStop(false);
		((Control)Rq5f()).set_Location(new Point(158, 340));
		((Control)Rq5f()).set_Name("PictureBox133");
		((Control)Rq5f()).set_Size(new Size(10, 12));
		Rq5f().set_SizeMode((PictureBoxSizeMode)4);
		Rq5f().set_TabIndex(1187);
		Rq5f().set_TabStop(false);
		((Control)Ts61()).set_Location(new Point(142, 340));
		((Control)Ts61()).set_Name("PictureBox134");
		((Control)Ts61()).set_Size(new Size(10, 12));
		Ts61().set_SizeMode((PictureBoxSizeMode)4);
		Ts61().set_TabIndex(1186);
		Ts61().set_TabStop(false);
		((Control)Xq8n()).set_Location(new Point(126, 340));
		((Control)Xq8n()).set_Name("PictureBox135");
		((Control)Xq8n()).set_Size(new Size(10, 12));
		Xq8n().set_SizeMode((PictureBoxSizeMode)4);
		Xq8n().set_TabIndex(1185);
		Xq8n().set_TabStop(false);
		((Control)Gs57()).set_Location(new Point(110, 340));
		((Control)Gs57()).set_Name("PictureBox136");
		((Control)Gs57()).set_Size(new Size(10, 12));
		Gs57().set_SizeMode((PictureBoxSizeMode)4);
		Gs57().set_TabIndex(1184);
		Gs57().set_TabStop(false);
		((Control)Pa7k()).set_Location(new Point(94, 340));
		((Control)Pa7k()).set_Name("PictureBox137");
		((Control)Pa7k()).set_Size(new Size(10, 12));
		Pa7k().set_SizeMode((PictureBoxSizeMode)4);
		Pa7k().set_TabIndex(1183);
		Pa7k().set_TabStop(false);
		((Control)Dq32()).set_Location(new Point(78, 340));
		((Control)Dq32()).set_Name("PictureBox138");
		((Control)Dq32()).set_Size(new Size(10, 12));
		Dq32().set_SizeMode((PictureBoxSizeMode)4);
		Dq32().set_TabIndex(1182);
		Dq32().set_TabStop(false);
		((Control)n8QA()).set_Location(new Point(62, 340));
		((Control)n8QA()).set_Name("PictureBox139");
		((Control)n8QA()).set_Size(new Size(10, 12));
		n8QA().set_SizeMode((PictureBoxSizeMode)4);
		n8QA().set_TabIndex(1181);
		n8QA().set_TabStop(false);
		((Control)Br0s()).set_Location(new Point(48, 340));
		((Control)Br0s()).set_Name("PictureBox140");
		((Control)Br0s()).set_Size(new Size(10, 12));
		Br0s().set_SizeMode((PictureBoxSizeMode)4);
		Br0s().set_TabIndex(1180);
		Br0s().set_TabStop(false);
		((Control)Tf28()).set_Location(new Point(372, 318));
		((Control)Tf28()).set_Name("PictureBox101");
		((Control)Tf28()).set_Size(new Size(10, 12));
		Tf28().set_SizeMode((PictureBoxSizeMode)4);
		Tf28().set_TabIndex(1179);
		Tf28().set_TabStop(false);
		((Control)j1J4()).set_Location(new Point(352, 318));
		((Control)j1J4()).set_Name("PictureBox102");
		((Control)j1J4()).set_Size(new Size(10, 12));
		j1J4().set_SizeMode((PictureBoxSizeMode)4);
		j1J4().set_TabIndex(1178);
		j1J4().set_TabStop(false);
		((Control)Qc62()).set_Location(new Point(333, 318));
		((Control)Qc62()).set_Name("PictureBox103");
		((Control)Qc62()).set_Size(new Size(10, 12));
		Qc62().set_SizeMode((PictureBoxSizeMode)4);
		Qc62().set_TabIndex(1177);
		Qc62().set_TabStop(false);
		((Control)Wt34()).set_Location(new Point(314, 318));
		((Control)Wt34()).set_Name("PictureBox104");
		((Control)Wt34()).set_Size(new Size(10, 12));
		Wt34().set_SizeMode((PictureBoxSizeMode)4);
		Wt34().set_TabIndex(1176);
		Wt34().set_TabStop(false);
		((Control)Mg27()).set_Location(new Point(296, 318));
		((Control)Mg27()).set_Name("PictureBox105");
		((Control)Mg27()).set_Size(new Size(10, 12));
		Mg27().set_SizeMode((PictureBoxSizeMode)4);
		Mg27().set_TabIndex(1175);
		Mg27().set_TabStop(false);
		((Control)s9K3()).set_Location(new Point(279, 318));
		((Control)s9K3()).set_Name("PictureBox106");
		((Control)s9K3()).set_Size(new Size(10, 12));
		s9K3().set_SizeMode((PictureBoxSizeMode)4);
		s9K3().set_TabIndex(1174);
		s9K3().set_TabStop(false);
		((Control)i5CH()).set_Location(new Point(261, 318));
		((Control)i5CH()).set_Name("PictureBox107");
		((Control)i5CH()).set_Size(new Size(10, 12));
		i5CH().set_SizeMode((PictureBoxSizeMode)4);
		i5CH().set_TabIndex(1173);
		i5CH().set_TabStop(false);
		((Control)d4B5()).set_Location(new Point(245, 318));
		((Control)d4B5()).set_Name("PictureBox108");
		((Control)d4B5()).set_Size(new Size(10, 12));
		d4B5().set_SizeMode((PictureBoxSizeMode)4);
		d4B5().set_TabIndex(1172);
		d4B5().set_TabStop(false);
		((Control)Fg69()).set_Location(new Point(227, 318));
		((Control)Fg69()).set_Name("PictureBox109");
		((Control)Fg69()).set_Size(new Size(10, 12));
		Fg69().set_SizeMode((PictureBoxSizeMode)4);
		Fg69().set_TabIndex(1171);
		Fg69().set_TabStop(false);
		((Control)c5HK()).set_Location(new Point(208, 318));
		((Control)c5HK()).set_Name("PictureBox110");
		((Control)c5HK()).set_Size(new Size(10, 12));
		c5HK().set_SizeMode((PictureBoxSizeMode)4);
		c5HK().set_TabIndex(1170);
		c5HK().set_TabStop(false);
		((Control)b5S4()).set_Location(new Point(190, 318));
		((Control)b5S4()).set_Name("PictureBox111");
		((Control)b5S4()).set_Size(new Size(10, 12));
		b5S4().set_SizeMode((PictureBoxSizeMode)4);
		b5S4().set_TabIndex(1169);
		b5S4().set_TabStop(false);
		((Control)Qi7k()).set_Location(new Point(174, 318));
		((Control)Qi7k()).set_Name("PictureBox112");
		((Control)Qi7k()).set_Size(new Size(10, 12));
		Qi7k().set_SizeMode((PictureBoxSizeMode)4);
		Qi7k().set_TabIndex(1168);
		Qi7k().set_TabStop(false);
		((Control)Ze8w()).set_Location(new Point(158, 318));
		((Control)Ze8w()).set_Name("PictureBox113");
		((Control)Ze8w()).set_Size(new Size(10, 12));
		Ze8w().set_SizeMode((PictureBoxSizeMode)4);
		Ze8w().set_TabIndex(1167);
		Ze8w().set_TabStop(false);
		((Control)p6E0()).set_Location(new Point(142, 318));
		((Control)p6E0()).set_Name("PictureBox114");
		((Control)p6E0()).set_Size(new Size(10, 12));
		p6E0().set_SizeMode((PictureBoxSizeMode)4);
		p6E0().set_TabIndex(1166);
		p6E0().set_TabStop(false);
		((Control)m7SW()).set_Location(new Point(126, 318));
		((Control)m7SW()).set_Name("PictureBox115");
		((Control)m7SW()).set_Size(new Size(10, 12));
		m7SW().set_SizeMode((PictureBoxSizeMode)4);
		m7SW().set_TabIndex(1165);
		m7SW().set_TabStop(false);
		((Control)e9SG()).set_Location(new Point(110, 318));
		((Control)e9SG()).set_Name("PictureBox116");
		((Control)e9SG()).set_Size(new Size(10, 12));
		e9SG().set_SizeMode((PictureBoxSizeMode)4);
		e9SG().set_TabIndex(1164);
		e9SG().set_TabStop(false);
		((Control)Sd20()).set_Location(new Point(94, 318));
		((Control)Sd20()).set_Name("PictureBox117");
		((Control)Sd20()).set_Size(new Size(10, 12));
		Sd20().set_SizeMode((PictureBoxSizeMode)4);
		Sd20().set_TabIndex(1163);
		Sd20().set_TabStop(false);
		((Control)q2HC()).set_Location(new Point(78, 318));
		((Control)q2HC()).set_Name("PictureBox118");
		((Control)q2HC()).set_Size(new Size(10, 12));
		q2HC().set_SizeMode((PictureBoxSizeMode)4);
		q2HC().set_TabIndex(1162);
		q2HC().set_TabStop(false);
		((Control)k0P9()).set_Location(new Point(62, 318));
		((Control)k0P9()).set_Name("PictureBox119");
		((Control)k0P9()).set_Size(new Size(10, 12));
		k0P9().set_SizeMode((PictureBoxSizeMode)4);
		k0P9().set_TabIndex(1161);
		k0P9().set_TabStop(false);
		((Control)Gi71()).set_Location(new Point(48, 318));
		((Control)Gi71()).set_Name("PictureBox120");
		((Control)Gi71()).set_Size(new Size(10, 12));
		Gi71().set_SizeMode((PictureBoxSizeMode)4);
		Gi71().set_TabIndex(1160);
		Gi71().set_TabStop(false);
		((Control)o0Y3()).set_Location(new Point(372, 299));
		((Control)o0Y3()).set_Name("PictureBox81");
		((Control)o0Y3()).set_Size(new Size(10, 12));
		o0Y3().set_SizeMode((PictureBoxSizeMode)4);
		o0Y3().set_TabIndex(1159);
		o0Y3().set_TabStop(false);
		((Control)p7SA()).set_Location(new Point(352, 299));
		((Control)p7SA()).set_Name("PictureBox82");
		((Control)p7SA()).set_Size(new Size(10, 12));
		p7SA().set_SizeMode((PictureBoxSizeMode)4);
		p7SA().set_TabIndex(1158);
		p7SA().set_TabStop(false);
		((Control)Kj49()).set_Location(new Point(333, 299));
		((Control)Kj49()).set_Name("PictureBox83");
		((Control)Kj49()).set_Size(new Size(10, 12));
		Kj49().set_SizeMode((PictureBoxSizeMode)4);
		Kj49().set_TabIndex(1157);
		Kj49().set_TabStop(false);
		((Control)t6MJ()).set_Location(new Point(314, 299));
		((Control)t6MJ()).set_Name("PictureBox84");
		((Control)t6MJ()).set_Size(new Size(10, 12));
		t6MJ().set_SizeMode((PictureBoxSizeMode)4);
		t6MJ().set_TabIndex(1156);
		t6MJ().set_TabStop(false);
		((Control)x5DH()).set_Location(new Point(296, 299));
		((Control)x5DH()).set_Name("PictureBox85");
		((Control)x5DH()).set_Size(new Size(10, 12));
		x5DH().set_SizeMode((PictureBoxSizeMode)4);
		x5DH().set_TabIndex(1155);
		x5DH().set_TabStop(false);
		((Control)Hf6o()).set_Location(new Point(279, 299));
		((Control)Hf6o()).set_Name("PictureBox86");
		((Control)Hf6o()).set_Size(new Size(10, 12));
		Hf6o().set_SizeMode((PictureBoxSizeMode)4);
		Hf6o().set_TabIndex(1154);
		Hf6o().set_TabStop(false);
		((Control)Bw07()).set_Location(new Point(261, 299));
		((Control)Bw07()).set_Name("PictureBox87");
		((Control)Bw07()).set_Size(new Size(10, 12));
		Bw07().set_SizeMode((PictureBoxSizeMode)4);
		Bw07().set_TabIndex(1153);
		Bw07().set_TabStop(false);
		((Control)b6WZ()).set_Location(new Point(245, 299));
		((Control)b6WZ()).set_Name("PictureBox88");
		((Control)b6WZ()).set_Size(new Size(10, 12));
		b6WZ().set_SizeMode((PictureBoxSizeMode)4);
		b6WZ().set_TabIndex(1152);
		b6WZ().set_TabStop(false);
		((Control)x0A4()).set_Location(new Point(227, 299));
		((Control)x0A4()).set_Name("PictureBox89");
		((Control)x0A4()).set_Size(new Size(10, 12));
		x0A4().set_SizeMode((PictureBoxSizeMode)4);
		x0A4().set_TabIndex(1151);
		x0A4().set_TabStop(false);
		((Control)Zt56()).set_Location(new Point(208, 299));
		((Control)Zt56()).set_Name("PictureBox90");
		((Control)Zt56()).set_Size(new Size(10, 12));
		Zt56().set_SizeMode((PictureBoxSizeMode)4);
		Zt56().set_TabIndex(1150);
		Zt56().set_TabStop(false);
		((Control)n1Y3()).set_Location(new Point(190, 299));
		((Control)n1Y3()).set_Name("PictureBox91");
		((Control)n1Y3()).set_Size(new Size(10, 12));
		n1Y3().set_SizeMode((PictureBoxSizeMode)4);
		n1Y3().set_TabIndex(1149);
		n1Y3().set_TabStop(false);
		((Control)Jq10()).set_Location(new Point(174, 299));
		((Control)Jq10()).set_Name("PictureBox92");
		((Control)Jq10()).set_Size(new Size(10, 12));
		Jq10().set_SizeMode((PictureBoxSizeMode)4);
		Jq10().set_TabIndex(1148);
		Jq10().set_TabStop(false);
		((Control)As50()).set_Location(new Point(158, 299));
		((Control)As50()).set_Name("PictureBox93");
		((Control)As50()).set_Size(new Size(10, 12));
		As50().set_SizeMode((PictureBoxSizeMode)4);
		As50().set_TabIndex(1147);
		As50().set_TabStop(false);
		((Control)f0A1()).set_Location(new Point(142, 299));
		((Control)f0A1()).set_Name("PictureBox94");
		((Control)f0A1()).set_Size(new Size(10, 12));
		f0A1().set_SizeMode((PictureBoxSizeMode)4);
		f0A1().set_TabIndex(1146);
		f0A1().set_TabStop(false);
		((Control)Dr12()).set_Location(new Point(126, 299));
		((Control)Dr12()).set_Name("PictureBox95");
		((Control)Dr12()).set_Size(new Size(10, 12));
		Dr12().set_SizeMode((PictureBoxSizeMode)4);
		Dr12().set_TabIndex(1145);
		Dr12().set_TabStop(false);
		((Control)d3L2()).set_Location(new Point(110, 299));
		((Control)d3L2()).set_Name("PictureBox96");
		((Control)d3L2()).set_Size(new Size(10, 12));
		d3L2().set_SizeMode((PictureBoxSizeMode)4);
		d3L2().set_TabIndex(1144);
		d3L2().set_TabStop(false);
		((Control)Gy0x()).set_Location(new Point(94, 299));
		((Control)Gy0x()).set_Name("PictureBox97");
		((Control)Gy0x()).set_Size(new Size(10, 12));
		Gy0x().set_SizeMode((PictureBoxSizeMode)4);
		Gy0x().set_TabIndex(1143);
		Gy0x().set_TabStop(false);
		((Control)Aq97()).set_Location(new Point(78, 299));
		((Control)Aq97()).set_Name("PictureBox98");
		((Control)Aq97()).set_Size(new Size(10, 12));
		Aq97().set_SizeMode((PictureBoxSizeMode)4);
		Aq97().set_TabIndex(1142);
		Aq97().set_TabStop(false);
		((Control)Pm89()).set_Location(new Point(62, 299));
		((Control)Pm89()).set_Name("PictureBox99");
		((Control)Pm89()).set_Size(new Size(10, 12));
		Pm89().set_SizeMode((PictureBoxSizeMode)4);
		Pm89().set_TabIndex(1141);
		Pm89().set_TabStop(false);
		((Control)Jm6n()).set_Location(new Point(48, 299));
		((Control)Jm6n()).set_Name("PictureBox100");
		((Control)Jm6n()).set_Size(new Size(10, 12));
		Jm6n().set_SizeMode((PictureBoxSizeMode)4);
		Jm6n().set_TabIndex(1140);
		Jm6n().set_TabStop(false);
		((Control)Yf90()).set_Location(new Point(372, 187));
		((Control)Yf90()).set_Name("PictureBox61");
		((Control)Yf90()).set_Size(new Size(10, 10));
		Yf90().set_SizeMode((PictureBoxSizeMode)4);
		Yf90().set_TabIndex(1139);
		Yf90().set_TabStop(false);
		((Control)Lr6z()).set_Location(new Point(352, 187));
		((Control)Lr6z()).set_Name("PictureBox62");
		((Control)Lr6z()).set_Size(new Size(10, 10));
		Lr6z().set_SizeMode((PictureBoxSizeMode)4);
		Lr6z().set_TabIndex(1138);
		Lr6z().set_TabStop(false);
		((Control)Ps28()).set_Location(new Point(333, 187));
		((Control)Ps28()).set_Name("PictureBox63");
		((Control)Ps28()).set_Size(new Size(10, 10));
		Ps28().set_SizeMode((PictureBoxSizeMode)4);
		Ps28().set_TabIndex(1137);
		Ps28().set_TabStop(false);
		((Control)Ex7b()).set_Location(new Point(314, 187));
		((Control)Ex7b()).set_Name("PictureBox64");
		((Control)Ex7b()).set_Size(new Size(10, 10));
		Ex7b().set_SizeMode((PictureBoxSizeMode)4);
		Ex7b().set_TabIndex(1136);
		Ex7b().set_TabStop(false);
		((Control)x0KS()).set_Location(new Point(296, 187));
		((Control)x0KS()).set_Name("PictureBox65");
		((Control)x0KS()).set_Size(new Size(10, 10));
		x0KS().set_SizeMode((PictureBoxSizeMode)4);
		x0KS().set_TabIndex(1135);
		x0KS().set_TabStop(false);
		((Control)x4P9()).set_Location(new Point(279, 187));
		((Control)x4P9()).set_Name("PictureBox66");
		((Control)x4P9()).set_Size(new Size(10, 10));
		x4P9().set_SizeMode((PictureBoxSizeMode)4);
		x4P9().set_TabIndex(1134);
		x4P9().set_TabStop(false);
		((Control)r7FB()).set_Location(new Point(261, 187));
		((Control)r7FB()).set_Name("PictureBox67");
		((Control)r7FB()).set_Size(new Size(10, 10));
		r7FB().set_SizeMode((PictureBoxSizeMode)4);
		r7FB().set_TabIndex(1133);
		r7FB().set_TabStop(false);
		((Control)z0YQ()).set_Location(new Point(245, 187));
		((Control)z0YQ()).set_Name("PictureBox68");
		((Control)z0YQ()).set_Size(new Size(10, 10));
		z0YQ().set_SizeMode((PictureBoxSizeMode)4);
		z0YQ().set_TabIndex(1132);
		z0YQ().set_TabStop(false);
		((Control)Mr90()).set_Location(new Point(227, 187));
		((Control)Mr90()).set_Name("PictureBox69");
		((Control)Mr90()).set_Size(new Size(10, 10));
		Mr90().set_SizeMode((PictureBoxSizeMode)4);
		Mr90().set_TabIndex(1131);
		Mr90().set_TabStop(false);
		((Control)Tc20()).set_Location(new Point(208, 187));
		((Control)Tc20()).set_Name("PictureBox70");
		((Control)Tc20()).set_Size(new Size(10, 10));
		Tc20().set_SizeMode((PictureBoxSizeMode)4);
		Tc20().set_TabIndex(1130);
		Tc20().set_TabStop(false);
		((Control)Ne86()).set_Location(new Point(190, 187));
		((Control)Ne86()).set_Name("PictureBox71");
		((Control)Ne86()).set_Size(new Size(10, 10));
		Ne86().set_SizeMode((PictureBoxSizeMode)4);
		Ne86().set_TabIndex(1129);
		Ne86().set_TabStop(false);
		((Control)Kg53()).set_Location(new Point(174, 187));
		((Control)Kg53()).set_Name("PictureBox72");
		((Control)Kg53()).set_Size(new Size(10, 10));
		Kg53().set_SizeMode((PictureBoxSizeMode)4);
		Kg53().set_TabIndex(1128);
		Kg53().set_TabStop(false);
		((Control)f2SP()).set_Location(new Point(158, 187));
		((Control)f2SP()).set_Name("PictureBox73");
		((Control)f2SP()).set_Size(new Size(10, 10));
		f2SP().set_SizeMode((PictureBoxSizeMode)4);
		f2SP().set_TabIndex(1127);
		f2SP().set_TabStop(false);
		((Control)Np60()).set_Location(new Point(142, 187));
		((Control)Np60()).set_Name("PictureBox74");
		((Control)Np60()).set_Size(new Size(10, 10));
		Np60().set_SizeMode((PictureBoxSizeMode)4);
		Np60().set_TabIndex(1126);
		Np60().set_TabStop(false);
		((Control)n0W6()).set_Location(new Point(126, 187));
		((Control)n0W6()).set_Name("PictureBox75");
		((Control)n0W6()).set_Size(new Size(10, 10));
		n0W6().set_SizeMode((PictureBoxSizeMode)4);
		n0W6().set_TabIndex(1125);
		n0W6().set_TabStop(false);
		((Control)Eg5p()).set_Location(new Point(110, 187));
		((Control)Eg5p()).set_Name("PictureBox76");
		((Control)Eg5p()).set_Size(new Size(10, 10));
		Eg5p().set_SizeMode((PictureBoxSizeMode)4);
		Eg5p().set_TabIndex(1124);
		Eg5p().set_TabStop(false);
		((Control)Pa9b()).set_Location(new Point(94, 187));
		((Control)Pa9b()).set_Name("PictureBox77");
		((Control)Pa9b()).set_Size(new Size(10, 10));
		Pa9b().set_SizeMode((PictureBoxSizeMode)4);
		Pa9b().set_TabIndex(1123);
		Pa9b().set_TabStop(false);
		((Control)y0A5()).set_Location(new Point(78, 187));
		((Control)y0A5()).set_Name("PictureBox78");
		((Control)y0A5()).set_Size(new Size(10, 10));
		y0A5().set_SizeMode((PictureBoxSizeMode)4);
		y0A5().set_TabIndex(1122);
		y0A5().set_TabStop(false);
		((Control)c3KX()).set_Location(new Point(62, 187));
		((Control)c3KX()).set_Name("PictureBox79");
		((Control)c3KX()).set_Size(new Size(10, 10));
		c3KX().set_SizeMode((PictureBoxSizeMode)4);
		c3KX().set_TabIndex(1121);
		c3KX().set_TabStop(false);
		((Control)f7C9()).set_Location(new Point(48, 187));
		((Control)f7C9()).set_Name("PictureBox80");
		((Control)f7C9()).set_Size(new Size(10, 10));
		f7C9().set_SizeMode((PictureBoxSizeMode)4);
		f7C9().set_TabIndex(1120);
		f7C9().set_TabStop(false);
		((Control)d2CY()).set_Location(new Point(372, 165));
		((Control)d2CY()).set_Name("PictureBox41");
		((Control)d2CY()).set_Size(new Size(10, 10));
		d2CY().set_SizeMode((PictureBoxSizeMode)4);
		d2CY().set_TabIndex(1119);
		d2CY().set_TabStop(false);
		((Control)Td7e()).set_Location(new Point(352, 165));
		((Control)Td7e()).set_Name("PictureBox42");
		((Control)Td7e()).set_Size(new Size(10, 10));
		Td7e().set_SizeMode((PictureBoxSizeMode)4);
		Td7e().set_TabIndex(1118);
		Td7e().set_TabStop(false);
		((Control)Wi24()).set_Location(new Point(333, 165));
		((Control)Wi24()).set_Name("PictureBox43");
		((Control)Wi24()).set_Size(new Size(10, 10));
		Wi24().set_SizeMode((PictureBoxSizeMode)4);
		Wi24().set_TabIndex(1117);
		Wi24().set_TabStop(false);
		((Control)Kx2b()).set_Location(new Point(314, 165));
		((Control)Kx2b()).set_Name("PictureBox44");
		((Control)Kx2b()).set_Size(new Size(10, 10));
		Kx2b().set_SizeMode((PictureBoxSizeMode)4);
		Kx2b().set_TabIndex(1116);
		Kx2b().set_TabStop(false);
		((Control)p9RM()).set_Location(new Point(296, 165));
		((Control)p9RM()).set_Name("PictureBox45");
		((Control)p9RM()).set_Size(new Size(10, 10));
		p9RM().set_SizeMode((PictureBoxSizeMode)4);
		p9RM().set_TabIndex(1115);
		p9RM().set_TabStop(false);
		((Control)y9WL()).set_Location(new Point(279, 165));
		((Control)y9WL()).set_Name("PictureBox46");
		((Control)y9WL()).set_Size(new Size(10, 10));
		y9WL().set_SizeMode((PictureBoxSizeMode)4);
		y9WL().set_TabIndex(1114);
		y9WL().set_TabStop(false);
		((Control)a2Q3()).set_Location(new Point(261, 165));
		((Control)a2Q3()).set_Name("PictureBox47");
		((Control)a2Q3()).set_Size(new Size(10, 10));
		a2Q3().set_SizeMode((PictureBoxSizeMode)4);
		a2Q3().set_TabIndex(1113);
		a2Q3().set_TabStop(false);
		((Control)g1W9()).set_Location(new Point(245, 165));
		((Control)g1W9()).set_Name("PictureBox48");
		((Control)g1W9()).set_Size(new Size(10, 10));
		g1W9().set_SizeMode((PictureBoxSizeMode)4);
		g1W9().set_TabIndex(1112);
		g1W9().set_TabStop(false);
		((Control)k8T6()).set_Location(new Point(227, 165));
		((Control)k8T6()).set_Name("PictureBox49");
		((Control)k8T6()).set_Size(new Size(10, 10));
		k8T6().set_SizeMode((PictureBoxSizeMode)4);
		k8T6().set_TabIndex(1111);
		k8T6().set_TabStop(false);
		((Control)Sj51()).set_Location(new Point(208, 165));
		((Control)Sj51()).set_Name("PictureBox50");
		((Control)Sj51()).set_Size(new Size(10, 10));
		Sj51().set_SizeMode((PictureBoxSizeMode)4);
		Sj51().set_TabIndex(1110);
		Sj51().set_TabStop(false);
		((Control)j6L7()).set_Location(new Point(190, 165));
		((Control)j6L7()).set_Name("PictureBox51");
		((Control)j6L7()).set_Size(new Size(10, 10));
		j6L7().set_SizeMode((PictureBoxSizeMode)4);
		j6L7().set_TabIndex(1109);
		j6L7().set_TabStop(false);
		((Control)Qt2c()).set_Location(new Point(174, 165));
		((Control)Qt2c()).set_Name("PictureBox52");
		((Control)Qt2c()).set_Size(new Size(10, 10));
		Qt2c().set_SizeMode((PictureBoxSizeMode)4);
		Qt2c().set_TabIndex(1108);
		Qt2c().set_TabStop(false);
		((Control)Hn80()).set_Location(new Point(158, 165));
		((Control)Hn80()).set_Name("PictureBox53");
		((Control)Hn80()).set_Size(new Size(10, 10));
		Hn80().set_SizeMode((PictureBoxSizeMode)4);
		Hn80().set_TabIndex(1107);
		Hn80().set_TabStop(false);
		((Control)Jp40()).set_Location(new Point(142, 165));
		((Control)Jp40()).set_Name("PictureBox54");
		((Control)Jp40()).set_Size(new Size(10, 10));
		Jp40().set_SizeMode((PictureBoxSizeMode)4);
		Jp40().set_TabIndex(1106);
		Jp40().set_TabStop(false);
		((Control)j1PK()).set_Location(new Point(126, 165));
		((Control)j1PK()).set_Name("PictureBox55");
		((Control)j1PK()).set_Size(new Size(10, 10));
		j1PK().set_SizeMode((PictureBoxSizeMode)4);
		j1PK().set_TabIndex(1105);
		j1PK().set_TabStop(false);
		((Control)Sa5k()).set_Location(new Point(110, 165));
		((Control)Sa5k()).set_Name("PictureBox56");
		((Control)Sa5k()).set_Size(new Size(10, 10));
		Sa5k().set_SizeMode((PictureBoxSizeMode)4);
		Sa5k().set_TabIndex(1104);
		Sa5k().set_TabStop(false);
		((Control)Rn50()).set_Location(new Point(94, 165));
		((Control)Rn50()).set_Name("PictureBox57");
		((Control)Rn50()).set_Size(new Size(10, 10));
		Rn50().set_SizeMode((PictureBoxSizeMode)4);
		Rn50().set_TabIndex(1103);
		Rn50().set_TabStop(false);
		((Control)Dk80()).set_Location(new Point(78, 165));
		((Control)Dk80()).set_Name("PictureBox58");
		((Control)Dk80()).set_Size(new Size(10, 10));
		Dk80().set_SizeMode((PictureBoxSizeMode)4);
		Dk80().set_TabIndex(1102);
		Dk80().set_TabStop(false);
		((Control)p3DQ()).set_Location(new Point(62, 165));
		((Control)p3DQ()).set_Name("PictureBox59");
		((Control)p3DQ()).set_Size(new Size(10, 10));
		p3DQ().set_SizeMode((PictureBoxSizeMode)4);
		p3DQ().set_TabIndex(1101);
		p3DQ().set_TabStop(false);
		((Control)Xb63()).set_Location(new Point(48, 165));
		((Control)Xb63()).set_Name("PictureBox60");
		((Control)Xb63()).set_Size(new Size(10, 10));
		Xb63().set_SizeMode((PictureBoxSizeMode)4);
		Xb63().set_TabIndex(1100);
		Xb63().set_TabStop(false);
		((Control)g7PF()).set_Location(new Point(372, 143));
		((Control)g7PF()).set_Name("PictureBox21");
		((Control)g7PF()).set_Size(new Size(10, 10));
		g7PF().set_SizeMode((PictureBoxSizeMode)4);
		g7PF().set_TabIndex(1099);
		g7PF().set_TabStop(false);
		((Control)b2PK()).set_Location(new Point(352, 143));
		((Control)b2PK()).set_Name("PictureBox22");
		((Control)b2PK()).set_Size(new Size(10, 10));
		b2PK().set_SizeMode((PictureBoxSizeMode)4);
		b2PK().set_TabIndex(1098);
		b2PK().set_TabStop(false);
		((Control)w7DF()).set_Location(new Point(333, 143));
		((Control)w7DF()).set_Name("PictureBox23");
		((Control)w7DF()).set_Size(new Size(10, 10));
		w7DF().set_SizeMode((PictureBoxSizeMode)4);
		w7DF().set_TabIndex(1097);
		w7DF().set_TabStop(false);
		((Control)Xs5f()).set_Location(new Point(314, 143));
		((Control)Xs5f()).set_Name("PictureBox24");
		((Control)Xs5f()).set_Size(new Size(10, 10));
		Xs5f().set_SizeMode((PictureBoxSizeMode)4);
		Xs5f().set_TabIndex(1096);
		Xs5f().set_TabStop(false);
		((Control)Gt49()).set_Location(new Point(296, 143));
		((Control)Gt49()).set_Name("PictureBox25");
		((Control)Gt49()).set_Size(new Size(10, 10));
		Gt49().set_SizeMode((PictureBoxSizeMode)4);
		Gt49().set_TabIndex(1095);
		Gt49().set_TabStop(false);
		((Control)k0B4()).set_Location(new Point(279, 143));
		((Control)k0B4()).set_Name("PictureBox26");
		((Control)k0B4()).set_Size(new Size(10, 10));
		k0B4().set_SizeMode((PictureBoxSizeMode)4);
		k0B4().set_TabIndex(1094);
		k0B4().set_TabStop(false);
		((Control)y4J2()).set_Location(new Point(261, 143));
		((Control)y4J2()).set_Name("PictureBox27");
		((Control)y4J2()).set_Size(new Size(10, 10));
		y4J2().set_SizeMode((PictureBoxSizeMode)4);
		y4J2().set_TabIndex(1093);
		y4J2().set_TabStop(false);
		((Control)p3SL()).set_Location(new Point(245, 143));
		((Control)p3SL()).set_Name("PictureBox28");
		((Control)p3SL()).set_Size(new Size(10, 10));
		p3SL().set_SizeMode((PictureBoxSizeMode)4);
		p3SL().set_TabIndex(1092);
		p3SL().set_TabStop(false);
		((Control)Kx41()).set_Location(new Point(227, 143));
		((Control)Kx41()).set_Name("PictureBox29");
		((Control)Kx41()).set_Size(new Size(10, 10));
		Kx41().set_SizeMode((PictureBoxSizeMode)4);
		Kx41().set_TabIndex(1091);
		Kx41().set_TabStop(false);
		((Control)x8P7()).set_Location(new Point(208, 143));
		((Control)x8P7()).set_Name("PictureBox30");
		((Control)x8P7()).set_Size(new Size(10, 10));
		x8P7().set_SizeMode((PictureBoxSizeMode)4);
		x8P7().set_TabIndex(1090);
		x8P7().set_TabStop(false);
		((Control)Md2y()).set_Location(new Point(190, 143));
		((Control)Md2y()).set_Name("PictureBox31");
		((Control)Md2y()).set_Size(new Size(10, 10));
		Md2y().set_SizeMode((PictureBoxSizeMode)4);
		Md2y().set_TabIndex(1089);
		Md2y().set_TabStop(false);
		((Control)b9GW()).set_Location(new Point(174, 143));
		((Control)b9GW()).set_Name("PictureBox32");
		((Control)b9GW()).set_Size(new Size(10, 10));
		b9GW().set_SizeMode((PictureBoxSizeMode)4);
		b9GW().set_TabIndex(1088);
		b9GW().set_TabStop(false);
		((Control)n7A6()).set_Location(new Point(158, 143));
		((Control)n7A6()).set_Name("PictureBox33");
		((Control)n7A6()).set_Size(new Size(10, 10));
		n7A6().set_SizeMode((PictureBoxSizeMode)4);
		n7A6().set_TabIndex(1087);
		n7A6().set_TabStop(false);
		((Control)Mt3r()).set_Location(new Point(142, 143));
		((Control)Mt3r()).set_Name("PictureBox34");
		((Control)Mt3r()).set_Size(new Size(10, 10));
		Mt3r().set_SizeMode((PictureBoxSizeMode)4);
		Mt3r().set_TabIndex(1086);
		Mt3r().set_TabStop(false);
		((Control)e9K5()).set_Location(new Point(126, 143));
		((Control)e9K5()).set_Name("PictureBox35");
		((Control)e9K5()).set_Size(new Size(10, 10));
		e9K5().set_SizeMode((PictureBoxSizeMode)4);
		e9K5().set_TabIndex(1085);
		e9K5().set_TabStop(false);
		((Control)f1M3()).set_Location(new Point(110, 143));
		((Control)f1M3()).set_Name("PictureBox36");
		((Control)f1M3()).set_Size(new Size(10, 10));
		f1M3().set_SizeMode((PictureBoxSizeMode)4);
		f1M3().set_TabIndex(1084);
		f1M3().set_TabStop(false);
		((Control)m7X2()).set_Location(new Point(94, 143));
		((Control)m7X2()).set_Name("PictureBox37");
		((Control)m7X2()).set_Size(new Size(10, 10));
		m7X2().set_SizeMode((PictureBoxSizeMode)4);
		m7X2().set_TabIndex(1083);
		m7X2().set_TabStop(false);
		((Control)Gd38()).set_Location(new Point(78, 143));
		((Control)Gd38()).set_Name("PictureBox38");
		((Control)Gd38()).set_Size(new Size(10, 10));
		Gd38().set_SizeMode((PictureBoxSizeMode)4);
		Gd38().set_TabIndex(1082);
		Gd38().set_TabStop(false);
		((Control)Pn39()).set_Location(new Point(62, 143));
		((Control)Pn39()).set_Name("PictureBox39");
		((Control)Pn39()).set_Size(new Size(10, 10));
		Pn39().set_SizeMode((PictureBoxSizeMode)4);
		Pn39().set_TabIndex(1081);
		Pn39().set_TabStop(false);
		((Control)Az82()).set_Location(new Point(48, 143));
		((Control)Az82()).set_Name("PictureBox40");
		((Control)Az82()).set_Size(new Size(10, 10));
		Az82().set_SizeMode((PictureBoxSizeMode)4);
		Az82().set_TabIndex(1080);
		Az82().set_TabStop(false);
		((Control)i3WE()).set_Location(new Point(372, 121));
		((Control)i3WE()).set_Name("PictureBox20");
		((Control)i3WE()).set_Size(new Size(10, 10));
		i3WE().set_SizeMode((PictureBoxSizeMode)4);
		i3WE().set_TabIndex(1079);
		i3WE().set_TabStop(false);
		((Control)Gk0m()).set_Location(new Point(352, 121));
		((Control)Gk0m()).set_Name("PictureBox19");
		((Control)Gk0m()).set_Size(new Size(10, 10));
		Gk0m().set_SizeMode((PictureBoxSizeMode)4);
		Gk0m().set_TabIndex(1078);
		Gk0m().set_TabStop(false);
		((Control)Zd5f()).set_Location(new Point(333, 121));
		((Control)Zd5f()).set_Name("PictureBox18");
		((Control)Zd5f()).set_Size(new Size(10, 10));
		Zd5f().set_SizeMode((PictureBoxSizeMode)4);
		Zd5f().set_TabIndex(1077);
		Zd5f().set_TabStop(false);
		((Control)o9S2()).set_Location(new Point(314, 121));
		((Control)o9S2()).set_Name("PictureBox17");
		((Control)o9S2()).set_Size(new Size(10, 10));
		o9S2().set_SizeMode((PictureBoxSizeMode)4);
		o9S2().set_TabIndex(1076);
		o9S2().set_TabStop(false);
		((Control)f9AL()).set_Location(new Point(296, 121));
		((Control)f9AL()).set_Name("PictureBox16");
		((Control)f9AL()).set_Size(new Size(10, 10));
		f9AL().set_SizeMode((PictureBoxSizeMode)4);
		f9AL().set_TabIndex(1075);
		f9AL().set_TabStop(false);
		((Control)z1EQ()).set_Location(new Point(279, 121));
		((Control)z1EQ()).set_Name("PictureBox15");
		((Control)z1EQ()).set_Size(new Size(10, 10));
		z1EQ().set_SizeMode((PictureBoxSizeMode)4);
		z1EQ().set_TabIndex(1074);
		z1EQ().set_TabStop(false);
		((Control)Aw3b()).set_Location(new Point(261, 121));
		((Control)Aw3b()).set_Name("PictureBox14");
		((Control)Aw3b()).set_Size(new Size(10, 10));
		Aw3b().set_SizeMode((PictureBoxSizeMode)4);
		Aw3b().set_TabIndex(1073);
		Aw3b().set_TabStop(false);
		((Control)Ek4p()).set_Location(new Point(245, 121));
		((Control)Ek4p()).set_Name("PictureBox13");
		((Control)Ek4p()).set_Size(new Size(10, 10));
		Ek4p().set_SizeMode((PictureBoxSizeMode)4);
		Ek4p().set_TabIndex(1072);
		Ek4p().set_TabStop(false);
		((Control)n2S3()).set_Location(new Point(227, 121));
		((Control)n2S3()).set_Name("PictureBox12");
		((Control)n2S3()).set_Size(new Size(10, 10));
		n2S3().set_SizeMode((PictureBoxSizeMode)4);
		n2S3().set_TabIndex(1071);
		n2S3().set_TabStop(false);
		((Control)Gt31()).set_Location(new Point(208, 121));
		((Control)Gt31()).set_Name("PictureBox11");
		((Control)Gt31()).set_Size(new Size(10, 10));
		Gt31().set_SizeMode((PictureBoxSizeMode)4);
		Gt31().set_TabIndex(1070);
		Gt31().set_TabStop(false);
		((Control)Xf4()).set_Location(new Point(190, 121));
		((Control)Xf4()).set_Name("PictureBox10");
		((Control)Xf4()).set_Size(new Size(10, 10));
		Xf4().set_SizeMode((PictureBoxSizeMode)4);
		Xf4().set_TabIndex(1069);
		Xf4().set_TabStop(false);
		((Control)i6B()).set_Location(new Point(174, 121));
		((Control)i6B()).set_Name("PictureBox9");
		((Control)i6B()).set_Size(new Size(10, 10));
		i6B().set_SizeMode((PictureBoxSizeMode)4);
		i6B().set_TabIndex(1068);
		i6B().set_TabStop(false);
		((Control)Ae3()).set_Location(new Point(158, 121));
		((Control)Ae3()).set_Name("PictureBox8");
		((Control)Ae3()).set_Size(new Size(10, 10));
		Ae3().set_SizeMode((PictureBoxSizeMode)4);
		Ae3().set_TabIndex(1067);
		Ae3().set_TabStop(false);
		((Control)o2X()).set_Location(new Point(142, 121));
		((Control)o2X()).set_Name("PictureBox7");
		((Control)o2X()).set_Size(new Size(10, 10));
		o2X().set_SizeMode((PictureBoxSizeMode)4);
		o2X().set_TabIndex(1066);
		o2X().set_TabStop(false);
		((Control)t4K()).set_Location(new Point(126, 121));
		((Control)t4K()).set_Name("PictureBox6");
		((Control)t4K()).set_Size(new Size(10, 10));
		t4K().set_SizeMode((PictureBoxSizeMode)4);
		t4K().set_TabIndex(1065);
		t4K().set_TabStop(false);
		((Control)Pe4()).set_Location(new Point(110, 121));
		((Control)Pe4()).set_Name("PictureBox5");
		((Control)Pe4()).set_Size(new Size(10, 10));
		Pe4().set_SizeMode((PictureBoxSizeMode)4);
		Pe4().set_TabIndex(1064);
		Pe4().set_TabStop(false);
		((Control)Ki2()).set_Location(new Point(94, 121));
		((Control)Ki2()).set_Name("PictureBox4");
		((Control)Ki2()).set_Size(new Size(10, 10));
		Ki2().set_SizeMode((PictureBoxSizeMode)4);
		Ki2().set_TabIndex(1063);
		Ki2().set_TabStop(false);
		((Control)La3()).set_Location(new Point(78, 121));
		((Control)La3()).set_Name("PictureBox3");
		((Control)La3()).set_Size(new Size(10, 10));
		La3().set_SizeMode((PictureBoxSizeMode)4);
		La3().set_TabIndex(1062);
		La3().set_TabStop(false);
		((Control)y9T()).set_Location(new Point(62, 121));
		((Control)y9T()).set_Name("PictureBox2");
		((Control)y9T()).set_Size(new Size(10, 10));
		y9T().set_SizeMode((PictureBoxSizeMode)4);
		y9T().set_TabIndex(1061);
		y9T().set_TabStop(false);
		((Control)Zj7()).set_Location(new Point(48, 121));
		((Control)Zj7()).set_Name("PictureBox1");
		((Control)Zj7()).set_Size(new Size(10, 10));
		Zj7().set_SizeMode((PictureBoxSizeMode)4);
		Zj7().set_TabIndex(1060);
		Zj7().set_TabStop(false);
		m8C().set_AutoSize(true);
		((Control)m8C()).set_Location(new Point(367, 256));
		((Control)m8C()).set_Name("Label32");
		((Control)m8C()).set_Size(new Size(19, 13));
		((Control)m8C()).set_TabIndex(1059);
		m8C().set_Text("20");
		e1R().set_AutoSize(true);
		((Control)e1R()).set_Location(new Point(274, 256));
		((Control)e1R()).set_Name("Label33");
		((Control)e1R()).set_Size(new Size(19, 13));
		((Control)e1R()).set_TabIndex(1058);
		e1R().set_Text("15");
		d6C().set_AutoSize(true);
		((Control)d6C()).set_Location(new Point(309, 256));
		((Control)d6C()).set_Name("Label34");
		((Control)d6C()).set_Size(new Size(19, 13));
		((Control)d6C()).set_TabIndex(1057);
		d6C().set_Text("17");
		z0H().set_AutoSize(true);
		((Control)z0H()).set_Location(new Point(328, 256));
		((Control)z0H()).set_Name("Label35");
		((Control)z0H()).set_Size(new Size(19, 13));
		((Control)z0H()).set_TabIndex(1056);
		z0H().set_Text("18");
		b5Z().set_AutoSize(true);
		((Control)b5Z()).set_Location(new Point(347, 256));
		((Control)b5Z()).set_Name("Label36");
		((Control)b5Z()).set_Size(new Size(19, 13));
		((Control)b5Z()).set_TabIndex(1055);
		b5Z().set_Text("19");
		b1K().set_AutoSize(true);
		((Control)b1K()).set_Location(new Point(222, 256));
		((Control)b1K()).set_Name("Label37");
		((Control)b1K()).set_Size(new Size(19, 13));
		((Control)b1K()).set_TabIndex(1054);
		b1K().set_Text("12");
		o4Q().set_AutoSize(true);
		((Control)o4Q()).set_Location(new Point(240, 256));
		((Control)o4Q()).set_Name("Label39");
		((Control)o4Q()).set_Size(new Size(19, 13));
		((Control)o4Q()).set_TabIndex(1052);
		o4Q().set_Text("13");
		e3C().set_AutoSize(true);
		((Control)e3C()).set_Location(new Point(291, 256));
		((Control)e3C()).set_Name("Label40");
		((Control)e3C()).set_Size(new Size(19, 13));
		((Control)e3C()).set_TabIndex(1051);
		e3C().set_Text("16");
		z4C().set_AutoSize(true);
		((Control)z4C()).set_Location(new Point(205, 256));
		((Control)z4C()).set_Name("Label41");
		((Control)z4C()).set_Size(new Size(19, 13));
		((Control)z4C()).set_TabIndex(1050);
		z4C().set_Text("11");
		a5C().set_AutoSize(true);
		((Control)a5C()).set_Location(new Point(256, 256));
		((Control)a5C()).set_Name("Label42");
		((Control)a5C()).set_Size(new Size(19, 13));
		((Control)a5C()).set_TabIndex(1049);
		a5C().set_Text("14");
		t4H().set_AutoSize(true);
		((Control)t4H()).set_Location(new Point(155, 256));
		((Control)t4H()).set_Name("Label43");
		((Control)t4H()).set_Size(new Size(13, 13));
		((Control)t4H()).set_TabIndex(1048);
		t4H().set_Text("8");
		i2Y().set_AutoSize(true);
		((Control)i2Y()).set_Location(new Point(91, 256));
		((Control)i2Y()).set_Name("Label38");
		((Control)i2Y()).set_Size(new Size(13, 13));
		((Control)i2Y()).set_TabIndex(1053);
		i2Y().set_Text("4");
		r7H().set_AutoSize(true);
		((Control)r7H()).set_Location(new Point(187, 256));
		((Control)r7H()).set_Name("Label44");
		((Control)r7H()).set_Size(new Size(19, 13));
		((Control)r7H()).set_TabIndex(1047);
		r7H().set_Text("10");
		Ni6().set_AutoSize(true);
		((Control)Ni6()).set_Location(new Point(171, 256));
		((Control)Ni6()).set_Name("Label45");
		((Control)Ni6()).set_Size(new Size(13, 13));
		((Control)Ni6()).set_TabIndex(1046);
		Ni6().set_Text("9");
		n0W().set_AutoSize(true);
		((Control)n0W()).set_Location(new Point(139, 256));
		((Control)n0W()).set_Name("Label46");
		((Control)n0W()).set_Size(new Size(13, 13));
		((Control)n0W()).set_TabIndex(1045);
		n0W().set_Text("7");
		x5L().set_AutoSize(true);
		((Control)x5L()).set_Location(new Point(123, 256));
		((Control)x5L()).set_Name("Label47");
		((Control)x5L()).set_Size(new Size(13, 13));
		((Control)x5L()).set_TabIndex(1044);
		x5L().set_Text("6");
		o0T().set_AutoSize(true);
		((Control)o0T()).set_Location(new Point(107, 256));
		((Control)o0T()).set_Name("Label48");
		((Control)o0T()).set_Size(new Size(13, 13));
		((Control)o0T()).set_TabIndex(1043);
		o0T().set_Text("5");
		d6F().set_AutoSize(true);
		((Control)d6F()).set_Location(new Point(75, 256));
		((Control)d6F()).set_Name("Label49");
		((Control)d6F()).set_Size(new Size(13, 13));
		((Control)d6F()).set_TabIndex(1042);
		d6F().set_Text("3");
		Dj2().set_AutoSize(true);
		((Control)Dj2()).set_Location(new Point(59, 256));
		((Control)Dj2()).set_Name("Label50");
		((Control)Dj2()).set_Size(new Size(13, 13));
		((Control)Dj2()).set_TabIndex(1041);
		Dj2().set_Text("2");
		o8T().set_AutoSize(true);
		((Control)o8T()).set_Location(new Point(43, 256));
		((Control)o8T()).set_Name("Label51");
		((Control)o8T()).set_Size(new Size(13, 13));
		((Control)o8T()).set_TabIndex(1040);
		o8T().set_Text("1");
		Cj9().set_AutoSize(true);
		((Control)Cj9()).set_Location(new Point(29, 362));
		((Control)Cj9()).set_Name("Label54");
		((Control)Cj9()).set_Size(new Size(15, 13));
		((Control)Cj9()).set_TabIndex(1039);
		Cj9().set_Text("H");
		Jt3().set_AutoSize(true);
		((Control)Jt3()).set_Location(new Point(29, 340));
		((Control)Jt3()).set_Name("Label55");
		((Control)Jt3()).set_Size(new Size(15, 13));
		((Control)Jt3()).set_TabIndex(1038);
		Jt3().set_Text("G");
		Az2().set_AutoSize(true);
		((Control)Az2()).set_Location(new Point(29, 318));
		((Control)Az2()).set_Name("Label56");
		((Control)Az2()).set_Size(new Size(13, 13));
		((Control)Az2()).set_TabIndex(1037);
		Az2().set_Text("F");
		s3Z().set_AutoSize(true);
		((Control)s3Z()).set_Location(new Point(176, 222));
		((Control)s3Z()).set_Name("Label31");
		((Control)s3Z()).set_Size(new Size(72, 13));
		((Control)s3Z()).set_TabIndex(1036);
		s3Z().set_Text("LOWER BOX");
		Bt7().set_AutoSize(true);
		((Control)Bt7()).set_Location(new Point(28, 299));
		((Control)Bt7()).set_Name("Label26");
		((Control)Bt7()).set_Size(new Size(14, 13));
		((Control)Bt7()).set_TabIndex(1035);
		Bt7().set_Text("E");
		Fx8().set_AutoSize(true);
		((Control)Fx8()).set_Location(new Point(28, 187));
		((Control)Fx8()).set_Name("Label27");
		((Control)Fx8()).set_Size(new Size(15, 13));
		((Control)Fx8()).set_TabIndex(1034);
		Fx8().set_Text("D");
		k8W().set_AutoSize(true);
		((Control)k8W()).set_Location(new Point(28, 165));
		((Control)k8W()).set_Name("Label28");
		((Control)k8W()).set_Size(new Size(14, 13));
		((Control)k8W()).set_TabIndex(1033);
		k8W().set_Text("C");
		p3Y().set_AutoSize(true);
		((Control)p3Y()).set_Location(new Point(28, 143));
		((Control)p3Y()).set_Name("Label29");
		((Control)p3Y()).set_Size(new Size(14, 13));
		((Control)p3Y()).set_TabIndex(1032);
		p3Y().set_Text("B");
		w9S().set_AutoSize(true);
		((Control)w9S()).set_Location(new Point(28, 121));
		((Control)w9S()).set_Name("Label30");
		((Control)w9S()).set_Size(new Size(14, 13));
		((Control)w9S()).set_TabIndex(1031);
		w9S().set_Text("A");
		m6S().set_AutoSize(true);
		((Control)m6S()).set_Location(new Point(367, 75));
		((Control)m6S()).set_Name("Label25");
		((Control)m6S()).set_Size(new Size(19, 13));
		((Control)m6S()).set_TabIndex(1030);
		m6S().set_Text("20");
		Zb6().set_AutoSize(true);
		((Control)Zb6()).set_Location(new Point(274, 75));
		((Control)Zb6()).set_Name("Label24");
		((Control)Zb6()).set_Size(new Size(19, 13));
		((Control)Zb6()).set_TabIndex(1029);
		Zb6().set_Text("15");
		Rp8().set_AutoSize(true);
		((Control)Rp8()).set_Location(new Point(309, 75));
		((Control)Rp8()).set_Name("Label23");
		((Control)Rp8()).set_Size(new Size(19, 13));
		((Control)Rp8()).set_TabIndex(1028);
		Rp8().set_Text("17");
		o4E().set_AutoSize(true);
		((Control)o4E()).set_Location(new Point(328, 75));
		((Control)o4E()).set_Name("Label22");
		((Control)o4E()).set_Size(new Size(19, 13));
		((Control)o4E()).set_TabIndex(1027);
		o4E().set_Text("18");
		i4Z().set_AutoSize(true);
		((Control)i4Z()).set_Location(new Point(347, 75));
		((Control)i4Z()).set_Name("Label21");
		((Control)i4Z()).set_Size(new Size(19, 13));
		((Control)i4Z()).set_TabIndex(1026);
		i4Z().set_Text("19");
		St4().set_AutoSize(true);
		((Control)St4()).set_Location(new Point(222, 75));
		((Control)St4()).set_Name("Label20");
		((Control)St4()).set_Size(new Size(19, 13));
		((Control)St4()).set_TabIndex(1025);
		St4().set_Text("12");
		k2L().set_AutoSize(true);
		((Control)k2L()).set_Location(new Point(91, 75));
		((Control)k2L()).set_Name("Label19");
		((Control)k2L()).set_Size(new Size(13, 13));
		((Control)k2L()).set_TabIndex(1024);
		k2L().set_Text("4");
		g9Y().set_AutoSize(true);
		((Control)g9Y()).set_Location(new Point(240, 75));
		((Control)g9Y()).set_Name("Label18");
		((Control)g9Y()).set_Size(new Size(19, 13));
		((Control)g9Y()).set_TabIndex(1023);
		g9Y().set_Text("13");
		Fb3().set_AutoSize(true);
		((Control)Fb3()).set_Location(new Point(291, 75));
		((Control)Fb3()).set_Name("Label17");
		((Control)Fb3()).set_Size(new Size(19, 13));
		((Control)Fb3()).set_TabIndex(1022);
		Fb3().set_Text("16");
		Gf5().set_AutoSize(true);
		((Control)Gf5()).set_Location(new Point(205, 75));
		((Control)Gf5()).set_Name("Label16");
		((Control)Gf5()).set_Size(new Size(19, 13));
		((Control)Gf5()).set_TabIndex(1021);
		Gf5().set_Text("11");
		g3Q().set_AutoSize(true);
		((Control)g3Q()).set_Location(new Point(256, 75));
		((Control)g3Q()).set_Name("Label15");
		((Control)g3Q()).set_Size(new Size(19, 13));
		((Control)g3Q()).set_TabIndex(1020);
		g3Q().set_Text("14");
		a5H().set_AutoSize(true);
		((Control)a5H()).set_Location(new Point(155, 75));
		((Control)a5H()).set_Name("Label14");
		((Control)a5H()).set_Size(new Size(13, 13));
		((Control)a5H()).set_TabIndex(1019);
		a5H().set_Text("8");
		o1E().set_AutoSize(true);
		((Control)o1E()).set_Location(new Point(187, 75));
		((Control)o1E()).set_Name("Label13");
		((Control)o1E()).set_Size(new Size(19, 13));
		((Control)o1E()).set_TabIndex(1018);
		o1E().set_Text("10");
		o8A().set_AutoSize(true);
		((Control)o8A()).set_Location(new Point(171, 75));
		((Control)o8A()).set_Name("Label12");
		((Control)o8A()).set_Size(new Size(13, 13));
		((Control)o8A()).set_TabIndex(1017);
		o8A().set_Text("9");
		Pw0().set_AutoSize(true);
		((Control)Pw0()).set_Location(new Point(139, 75));
		((Control)Pw0()).set_Name("Label11");
		((Control)Pw0()).set_Size(new Size(13, 13));
		((Control)Pw0()).set_TabIndex(1016);
		Pw0().set_Text("7");
		Ce3().set_AutoSize(true);
		((Control)Ce3()).set_Location(new Point(123, 75));
		((Control)Ce3()).set_Name("Label10");
		((Control)Ce3()).set_Size(new Size(13, 13));
		((Control)Ce3()).set_TabIndex(1015);
		Ce3().set_Text("6");
		Zz3().set_AutoSize(true);
		((Control)Zz3()).set_Location(new Point(107, 75));
		((Control)Zz3()).set_Name("Label9");
		((Control)Zz3()).set_Size(new Size(13, 13));
		((Control)Zz3()).set_TabIndex(1014);
		Zz3().set_Text("5");
		w6C().set_AutoSize(true);
		((Control)w6C()).set_Location(new Point(75, 75));
		((Control)w6C()).set_Name("Label8");
		((Control)w6C()).set_Size(new Size(13, 13));
		((Control)w6C()).set_TabIndex(1013);
		w6C().set_Text("3");
		c1G().set_AutoSize(true);
		((Control)c1G()).set_Location(new Point(59, 75));
		((Control)c1G()).set_Name("Label7");
		((Control)c1G()).set_Size(new Size(13, 13));
		((Control)c1G()).set_TabIndex(1012);
		c1G().set_Text("2");
		Gc9().set_AutoSize(true);
		((Control)Gc9()).set_Location(new Point(176, 48));
		((Control)Gc9()).set_Name("Label4");
		((Control)Gc9()).set_Size(new Size(69, 13));
		((Control)Gc9()).set_TabIndex(1010);
		Gc9().set_Text("UPPER BOX");
		d6B().set_AutoSize(true);
		((Control)d6B()).set_Location(new Point(43, 75));
		((Control)d6B()).set_Name("Label5");
		((Control)d6B()).set_Size(new Size(13, 13));
		((Control)d6B()).set_TabIndex(1011);
		d6B().set_Text("1");
		((Control)n1Q()).get_Controls().Add((Control)(object)Ta92());
		((Control)n1Q()).get_Controls().Add((Control)(object)i7W3());
		((Control)n1Q()).get_Controls().Add((Control)(object)Lf3());
		((Control)n1Q()).get_Controls().Add((Control)(object)Tw4());
		((Control)n1Q()).get_Controls().Add((Control)(object)j4Y());
		((Control)n1Q()).get_Controls().Add((Control)(object)Rr4());
		((Control)n1Q()).get_Controls().Add((Control)(object)z7B());
		((Control)n1Q()).get_Controls().Add((Control)(object)c9XL());
		((Control)n1Q()).get_Controls().Add((Control)(object)Nd7e());
		((Control)n1Q()).set_ForeColor(SystemColors.ControlLight);
		((Control)n1Q()).set_Location(new Point(454, 48));
		((Control)n1Q()).set_Name("GroupBox1");
		((Control)n1Q()).set_Size(new Size(240, 100));
		((Control)n1Q()).set_TabIndex(1006);
		n1Q().set_TabStop(false);
		n1Q().set_Text("Statistics");
		((Control)Lf3()).set_Location(new Point(151, 16));
		((Control)Lf3()).set_Name("txtAvailable");
		((Control)Lf3()).set_Size(new Size(83, 20));
		((Control)Lf3()).set_TabIndex(25);
		((Control)Tw4()).set_BackColor(Color.Transparent);
		((Control)Tw4()).set_Location(new Point(5, 47));
		((Control)Tw4()).set_Name("Booked");
		((Control)Tw4()).set_Size(new Size(23, 18));
		Tw4().set_SizeMode((PictureBoxSizeMode)4);
		Tw4().set_TabIndex(27);
		Tw4().set_TabStop(false);
		((Control)j4Y()).set_BackColor(Color.Transparent);
		((Control)j4Y()).set_Location(new Point(6, 74));
		((Control)j4Y()).set_Name("Provisional");
		((Control)j4Y()).set_Size(new Size(23, 17));
		j4Y().set_SizeMode((PictureBoxSizeMode)4);
		j4Y().set_TabIndex(26);
		j4Y().set_TabStop(false);
		((Control)Rr4()).set_BackColor(Color.Transparent);
		((Control)Rr4()).set_Location(new Point(5, 23));
		((Control)Rr4()).set_Name("Available");
		((Control)Rr4()).set_Size(new Size(23, 17));
		Rr4().set_SizeMode((PictureBoxSizeMode)4);
		Rr4().set_TabIndex(25);
		Rr4().set_TabStop(false);
		z7B().set_AutoSize(true);
		((Control)z7B()).set_BackColor(Color.Transparent);
		((Control)z7B()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)z7B()).set_Location(new Point(30, 49));
		((Control)z7B()).set_Name("Label3");
		((Control)z7B()).set_Size(new Size(74, 13));
		((Control)z7B()).set_TabIndex(12);
		z7B().set_Text("Booked Seats");
		Fe8().set_AutoSize(true);
		((Control)Fe8()).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Fe8()).set_ForeColor(SystemColors.ControlLight);
		((Control)Fe8()).set_Location(new Point(28, 6));
		((Control)Fe8()).set_Name("Label6");
		((Control)Fe8()).set_Size(new Size(106, 24));
		((Control)Fe8()).set_TabIndex(1005);
		Fe8().set_Text("CINEMA 4");
		((Control)Ys8()).set_Location(new Point(435, 40));
		((Control)Ys8()).set_Name("Background");
		((Control)Ys8()).set_Size(new Size(474, 396));
		Ys8().set_SizeMode((PictureBoxSizeMode)1);
		Ys8().set_TabIndex(1004);
		Ys8().set_TabStop(false);
		((Control)b3E()).set_BackColor(Color.Transparent);
		((Control)b3E()).set_Location(new Point(-2, -3));
		((Control)b3E()).set_Name("NameBox");
		((Control)b3E()).set_Size(new Size(914, 45));
		b3E().set_SizeMode((PictureBoxSizeMode)1);
		b3E().set_TabIndex(1003);
		b3E().set_TabStop(false);
		((Control)Ki0()).get_Controls().Add((Control)(object)Bx0());
		((Control)Ki0()).get_Controls().Add((Control)(object)e2J());
		((Control)Ki0()).set_ForeColor(SystemColors.ControlLight);
		((Control)Ki0()).set_Location(new Point(471, 170));
		((Control)Ki0()).set_Name("GroupBox3");
		((Control)Ki0()).set_Size(new Size(200, 251));
		((Control)Ki0()).set_TabIndex(1220);
		Ki0().set_TabStop(false);
		Ki0().set_Text("Movie On Display");
		((ButtonBase)Bx0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Bx0()).set_FlatStyle((FlatStyle)0);
		((Control)Bx0()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Bx0()).set_Location(new Point(48, 214));
		((Control)Bx0()).set_Name("btnViewReservations");
		((Control)Bx0()).set_Size(new Size(117, 23));
		((Control)Bx0()).set_TabIndex(41);
		((ButtonBase)Bx0()).set_Text("View Reservations");
		((ButtonBase)Bx0()).set_UseVisualStyleBackColor(true);
		((Control)e2J()).set_BackColor(Color.Transparent);
		((Control)e2J()).set_Location(new Point(39, 21));
		((Control)e2J()).set_Name("Cover");
		((Control)e2J()).set_Size(new Size(129, 187));
		e2J().set_SizeMode((PictureBoxSizeMode)4);
		e2J().set_TabIndex(25);
		e2J().set_TabStop(false);
		((Control)w5W()).get_Controls().Add((Control)(object)Dk5());
		((Control)w5W()).get_Controls().Add((Control)(object)Cs0());
		((Control)w5W()).get_Controls().Add((Control)(object)Yx3());
		((Control)w5W()).get_Controls().Add((Control)(object)Rw4());
		((Control)w5W()).get_Controls().Add((Control)(object)Qe1());
		((Control)w5W()).get_Controls().Add((Control)(object)m1K());
		((Control)w5W()).get_Controls().Add((Control)(object)a0G());
		((Control)w5W()).set_ForeColor(SystemColors.ControlLight);
		((Control)w5W()).set_Location(new Point(704, 51));
		((Control)w5W()).set_Name("GroupBox2");
		((Control)w5W()).set_Size(new Size(200, 129));
		((Control)w5W()).set_TabIndex(1221);
		w5W().set_TabStop(false);
		w5W().set_Text("Customer");
		((ButtonBase)Dk5()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Dk5()).set_FlatStyle((FlatStyle)0);
		((Control)Dk5()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Dk5()).set_Location(new Point(70, 90));
		((Control)Dk5()).set_Name("btnNew");
		((Control)Dk5()).set_Size(new Size(54, 23));
		((Control)Dk5()).set_TabIndex(39);
		((ButtonBase)Dk5()).set_Text("New");
		((ButtonBase)Dk5()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Cs0()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Cs0()).set_FlatStyle((FlatStyle)0);
		((Control)Cs0()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Cs0()).set_Location(new Point(130, 90));
		((Control)Cs0()).set_Name("btnReset");
		((Control)Cs0()).set_Size(new Size(54, 23));
		((Control)Cs0()).set_TabIndex(38);
		((ButtonBase)Cs0()).set_Text("Reset");
		((ButtonBase)Cs0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Yx3()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Yx3()).set_FlatStyle((FlatStyle)0);
		((Control)Yx3()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Yx3()).set_Location(new Point(10, 90));
		((Control)Yx3()).set_Name("btnExisting");
		((Control)Yx3()).set_Size(new Size(54, 23));
		((Control)Yx3()).set_TabIndex(37);
		((ButtonBase)Yx3()).set_Text("Existing");
		((ButtonBase)Yx3()).set_UseVisualStyleBackColor(true);
		((Control)Rw4()).set_Location(new Point(94, 57));
		((Control)Rw4()).set_Name("txtFirstName");
		((Control)Rw4()).set_Size(new Size(103, 20));
		((Control)Rw4()).set_TabIndex(30);
		((Control)Qe1()).set_Location(new Point(94, 31));
		((Control)Qe1()).set_Name("txtID");
		((Control)Qe1()).set_Size(new Size(103, 20));
		((Control)Qe1()).set_TabIndex(29);
		m1K().set_AutoSize(true);
		((Control)m1K()).set_BackColor(Color.Transparent);
		((Control)m1K()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)m1K()).set_Location(new Point(6, 58));
		((Control)m1K()).set_Name("Label60");
		((Control)m1K()).set_Size(new Size(57, 13));
		((Control)m1K()).set_TabIndex(12);
		m1K().set_Text("First Name");
		a0G().set_AutoSize(true);
		((Control)a0G()).set_BackColor(Color.Transparent);
		((Control)a0G()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)a0G()).set_Location(new Point(6, 34));
		((Control)a0G()).set_Name("Label59");
		((Control)a0G()).set_Size(new Size(65, 13));
		((Control)a0G()).set_TabIndex(11);
		a0G().set_Text("Customer ID");
		((Control)Dw7()).get_Controls().Add((Control)(object)k3C());
		((Control)Dw7()).get_Controls().Add((Control)(object)Ai1());
		((Control)Dw7()).get_Controls().Add((Control)(object)Dm0());
		((Control)Dw7()).get_Controls().Add((Control)(object)Mj9());
		((Control)Dw7()).get_Controls().Add((Control)(object)r1Q());
		((Control)Dw7()).get_Controls().Add((Control)(object)i5W());
		((Control)Dw7()).get_Controls().Add((Control)(object)b0K());
		((Control)Dw7()).get_Controls().Add((Control)(object)y3H());
		((Control)Dw7()).get_Controls().Add((Control)(object)t2Z());
		((Control)Dw7()).get_Controls().Add((Control)(object)o0R());
		((Control)Dw7()).set_ForeColor(SystemColors.ControlLight);
		((Control)Dw7()).set_Location(new Point(687, 185));
		((Control)Dw7()).set_Name("GroupBox4");
		((Control)Dw7()).set_Size(new Size(211, 231));
		((Control)Dw7()).set_TabIndex(1222);
		Dw7().set_TabStop(false);
		Dw7().set_Text("Billing INFO");
		((ButtonBase)k3C()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)k3C()).set_FlatStyle((FlatStyle)0);
		((Control)k3C()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)k3C()).set_Location(new Point(72, 184));
		((Control)k3C()).set_Name("btnSave");
		((Control)k3C()).set_Size(new Size(133, 23));
		((Control)k3C()).set_TabIndex(40);
		((ButtonBase)k3C()).set_Text("Save / Receipt Preview");
		((ButtonBase)k3C()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Ai1()).get_FlatAppearance().set_BorderColor(Color.Black);
		((ButtonBase)Ai1()).set_FlatStyle((FlatStyle)0);
		((Control)Ai1()).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Ai1()).set_Location(new Point(103, 155));
		((Control)Ai1()).set_Name("btnCalculateChange");
		((Control)Ai1()).set_Size(new Size(101, 23));
		((Control)Ai1()).set_TabIndex(39);
		((ButtonBase)Ai1()).set_Text("Calculate Change");
		((ButtonBase)Ai1()).set_UseVisualStyleBackColor(true);
		((Control)Dm0()).set_Location(new Point(95, 123));
		((Control)Dm0()).set_Name("txtChange");
		((Control)Dm0()).set_Size(new Size(110, 20));
		((Control)Dm0()).set_TabIndex(34);
		((Control)Mj9()).set_Location(new Point(95, 91));
		((Control)Mj9()).set_Name("txtTotalPayment");
		((Control)Mj9()).set_Size(new Size(110, 20));
		((Control)Mj9()).set_TabIndex(33);
		((Control)r1Q()).set_Location(new Point(96, 58));
		((Control)r1Q()).set_Name("txtTotalCost");
		((Control)r1Q()).set_Size(new Size(109, 20));
		((Control)r1Q()).set_TabIndex(32);
		((Control)i5W()).set_Location(new Point(122, 24));
		((Control)i5W()).set_Name("txtSeats");
		((Control)i5W()).set_Size(new Size(83, 20));
		((Control)i5W()).set_TabIndex(31);
		b0K().set_AutoSize(true);
		((Control)b0K()).set_BackColor(Color.Transparent);
		((Control)b0K()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)b0K()).set_Location(new Point(8, 62));
		((Control)b0K()).set_Name("Label63");
		((Control)b0K()).set_Size(new Size(66, 13));
		((Control)b0K()).set_TabIndex(16);
		b0K().set_Text("Total Costs :");
		y3H().set_AutoSize(true);
		((Control)y3H()).set_BackColor(Color.Transparent);
		((Control)y3H()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)y3H()).set_Location(new Point(8, 27));
		((Control)y3H()).set_Name("Label64");
		((Control)y3H()).set_Size(new Size(106, 13));
		((Control)y3H()).set_TabIndex(15);
		y3H().set_Text("Seats to be booked :");
		t2Z().set_AutoSize(true);
		((Control)t2Z()).set_BackColor(Color.Transparent);
		((Control)t2Z()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)t2Z()).set_Location(new Point(8, 121));
		((Control)t2Z()).set_Name("Label61");
		((Control)t2Z()).set_Size(new Size(50, 13));
		((Control)t2Z()).set_TabIndex(14);
		t2Z().set_Text("Change :");
		o0R().set_AutoSize(true);
		((Control)o0R()).set_BackColor(Color.Transparent);
		((Control)o0R()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)o0R()).set_Location(new Point(8, 91));
		((Control)o0R()).set_Name("Label62");
		((Control)o0R()).set_Size(new Size(81, 13));
		((Control)o0R()).set_TabIndex(13);
		o0R().set_Text("Total Payment :");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 433));
		((Control)this).get_Controls().Add((Control)(object)Dw7());
		((Control)this).get_Controls().Add((Control)(object)w5W());
		((Control)this).get_Controls().Add((Control)(object)Ki0());
		((Control)this).get_Controls().Add((Control)(object)Sd9b());
		((Control)this).get_Controls().Add((Control)(object)o9WB());
		((Control)this).get_Controls().Add((Control)(object)Gx69());
		((Control)this).get_Controls().Add((Control)(object)d4GW());
		((Control)this).get_Controls().Add((Control)(object)p2F0());
		((Control)this).get_Controls().Add((Control)(object)Hb6r());
		((Control)this).get_Controls().Add((Control)(object)z5E3());
		((Control)this).get_Controls().Add((Control)(object)w5SQ());
		((Control)this).get_Controls().Add((Control)(object)j7R1());
		((Control)this).get_Controls().Add((Control)(object)Gj0k());
		((Control)this).get_Controls().Add((Control)(object)z4FS());
		((Control)this).get_Controls().Add((Control)(object)b9SC());
		((Control)this).get_Controls().Add((Control)(object)y0EM());
		((Control)this).get_Controls().Add((Control)(object)Xf18());
		((Control)this).get_Controls().Add((Control)(object)Nr24());
		((Control)this).get_Controls().Add((Control)(object)f8MY());
		((Control)this).get_Controls().Add((Control)(object)n0DH());
		((Control)this).get_Controls().Add((Control)(object)d8SF());
		((Control)this).get_Controls().Add((Control)(object)Ac15());
		((Control)this).get_Controls().Add((Control)(object)n1C6());
		((Control)this).get_Controls().Add((Control)(object)Pb5c());
		((Control)this).get_Controls().Add((Control)(object)a8L9());
		((Control)this).get_Controls().Add((Control)(object)Le31());
		((Control)this).get_Controls().Add((Control)(object)y0SX());
		((Control)this).get_Controls().Add((Control)(object)f6M2());
		((Control)this).get_Controls().Add((Control)(object)f2XE());
		((Control)this).get_Controls().Add((Control)(object)w3HZ());
		((Control)this).get_Controls().Add((Control)(object)Gq4r());
		((Control)this).get_Controls().Add((Control)(object)St4f());
		((Control)this).get_Controls().Add((Control)(object)Xq1p());
		((Control)this).get_Controls().Add((Control)(object)Bn9e());
		((Control)this).get_Controls().Add((Control)(object)d8Q1());
		((Control)this).get_Controls().Add((Control)(object)Rq5f());
		((Control)this).get_Controls().Add((Control)(object)Ts61());
		((Control)this).get_Controls().Add((Control)(object)Xq8n());
		((Control)this).get_Controls().Add((Control)(object)Gs57());
		((Control)this).get_Controls().Add((Control)(object)Pa7k());
		((Control)this).get_Controls().Add((Control)(object)Dq32());
		((Control)this).get_Controls().Add((Control)(object)n8QA());
		((Control)this).get_Controls().Add((Control)(object)Br0s());
		((Control)this).get_Controls().Add((Control)(object)Tf28());
		((Control)this).get_Controls().Add((Control)(object)j1J4());
		((Control)this).get_Controls().Add((Control)(object)Qc62());
		((Control)this).get_Controls().Add((Control)(object)Wt34());
		((Control)this).get_Controls().Add((Control)(object)Mg27());
		((Control)this).get_Controls().Add((Control)(object)s9K3());
		((Control)this).get_Controls().Add((Control)(object)i5CH());
		((Control)this).get_Controls().Add((Control)(object)d4B5());
		((Control)this).get_Controls().Add((Control)(object)Fg69());
		((Control)this).get_Controls().Add((Control)(object)c5HK());
		((Control)this).get_Controls().Add((Control)(object)b5S4());
		((Control)this).get_Controls().Add((Control)(object)Qi7k());
		((Control)this).get_Controls().Add((Control)(object)Ze8w());
		((Control)this).get_Controls().Add((Control)(object)p6E0());
		((Control)this).get_Controls().Add((Control)(object)m7SW());
		((Control)this).get_Controls().Add((Control)(object)e9SG());
		((Control)this).get_Controls().Add((Control)(object)Sd20());
		((Control)this).get_Controls().Add((Control)(object)q2HC());
		((Control)this).get_Controls().Add((Control)(object)k0P9());
		((Control)this).get_Controls().Add((Control)(object)Gi71());
		((Control)this).get_Controls().Add((Control)(object)o0Y3());
		((Control)this).get_Controls().Add((Control)(object)p7SA());
		((Control)this).get_Controls().Add((Control)(object)Kj49());
		((Control)this).get_Controls().Add((Control)(object)t6MJ());
		((Control)this).get_Controls().Add((Control)(object)x5DH());
		((Control)this).get_Controls().Add((Control)(object)Hf6o());
		((Control)this).get_Controls().Add((Control)(object)Bw07());
		((Control)this).get_Controls().Add((Control)(object)b6WZ());
		((Control)this).get_Controls().Add((Control)(object)x0A4());
		((Control)this).get_Controls().Add((Control)(object)Zt56());
		((Control)this).get_Controls().Add((Control)(object)n1Y3());
		((Control)this).get_Controls().Add((Control)(object)Jq10());
		((Control)this).get_Controls().Add((Control)(object)As50());
		((Control)this).get_Controls().Add((Control)(object)f0A1());
		((Control)this).get_Controls().Add((Control)(object)Dr12());
		((Control)this).get_Controls().Add((Control)(object)d3L2());
		((Control)this).get_Controls().Add((Control)(object)Gy0x());
		((Control)this).get_Controls().Add((Control)(object)Aq97());
		((Control)this).get_Controls().Add((Control)(object)Pm89());
		((Control)this).get_Controls().Add((Control)(object)Jm6n());
		((Control)this).get_Controls().Add((Control)(object)Yf90());
		((Control)this).get_Controls().Add((Control)(object)Lr6z());
		((Control)this).get_Controls().Add((Control)(object)Ps28());
		((Control)this).get_Controls().Add((Control)(object)Ex7b());
		((Control)this).get_Controls().Add((Control)(object)x0KS());
		((Control)this).get_Controls().Add((Control)(object)x4P9());
		((Control)this).get_Controls().Add((Control)(object)r7FB());
		((Control)this).get_Controls().Add((Control)(object)z0YQ());
		((Control)this).get_Controls().Add((Control)(object)Mr90());
		((Control)this).get_Controls().Add((Control)(object)Tc20());
		((Control)this).get_Controls().Add((Control)(object)Ne86());
		((Control)this).get_Controls().Add((Control)(object)Kg53());
		((Control)this).get_Controls().Add((Control)(object)f2SP());
		((Control)this).get_Controls().Add((Control)(object)Np60());
		((Control)this).get_Controls().Add((Control)(object)n0W6());
		((Control)this).get_Controls().Add((Control)(object)Eg5p());
		((Control)this).get_Controls().Add((Control)(object)Pa9b());
		((Control)this).get_Controls().Add((Control)(object)y0A5());
		((Control)this).get_Controls().Add((Control)(object)c3KX());
		((Control)this).get_Controls().Add((Control)(object)f7C9());
		((Control)this).get_Controls().Add((Control)(object)d2CY());
		((Control)this).get_Controls().Add((Control)(object)Td7e());
		((Control)this).get_Controls().Add((Control)(object)Wi24());
		((Control)this).get_Controls().Add((Control)(object)Kx2b());
		((Control)this).get_Controls().Add((Control)(object)p9RM());
		((Control)this).get_Controls().Add((Control)(object)y9WL());
		((Control)this).get_Controls().Add((Control)(object)a2Q3());
		((Control)this).get_Controls().Add((Control)(object)g1W9());
		((Control)this).get_Controls().Add((Control)(object)k8T6());
		((Control)this).get_Controls().Add((Control)(object)Sj51());
		((Control)this).get_Controls().Add((Control)(object)j6L7());
		((Control)this).get_Controls().Add((Control)(object)Qt2c());
		((Control)this).get_Controls().Add((Control)(object)Hn80());
		((Control)this).get_Controls().Add((Control)(object)Jp40());
		((Control)this).get_Controls().Add((Control)(object)j1PK());
		((Control)this).get_Controls().Add((Control)(object)Sa5k());
		((Control)this).get_Controls().Add((Control)(object)Rn50());
		((Control)this).get_Controls().Add((Control)(object)Dk80());
		((Control)this).get_Controls().Add((Control)(object)p3DQ());
		((Control)this).get_Controls().Add((Control)(object)Xb63());
		((Control)this).get_Controls().Add((Control)(object)g7PF());
		((Control)this).get_Controls().Add((Control)(object)b2PK());
		((Control)this).get_Controls().Add((Control)(object)w7DF());
		((Control)this).get_Controls().Add((Control)(object)Xs5f());
		((Control)this).get_Controls().Add((Control)(object)Gt49());
		((Control)this).get_Controls().Add((Control)(object)k0B4());
		((Control)this).get_Controls().Add((Control)(object)y4J2());
		((Control)this).get_Controls().Add((Control)(object)p3SL());
		((Control)this).get_Controls().Add((Control)(object)Kx41());
		((Control)this).get_Controls().Add((Control)(object)x8P7());
		((Control)this).get_Controls().Add((Control)(object)Md2y());
		((Control)this).get_Controls().Add((Control)(object)b9GW());
		((Control)this).get_Controls().Add((Control)(object)n7A6());
		((Control)this).get_Controls().Add((Control)(object)Mt3r());
		((Control)this).get_Controls().Add((Control)(object)e9K5());
		((Control)this).get_Controls().Add((Control)(object)f1M3());
		((Control)this).get_Controls().Add((Control)(object)m7X2());
		((Control)this).get_Controls().Add((Control)(object)Gd38());
		((Control)this).get_Controls().Add((Control)(object)Pn39());
		((Control)this).get_Controls().Add((Control)(object)Az82());
		((Control)this).get_Controls().Add((Control)(object)i3WE());
		((Control)this).get_Controls().Add((Control)(object)Gk0m());
		((Control)this).get_Controls().Add((Control)(object)Zd5f());
		((Control)this).get_Controls().Add((Control)(object)o9S2());
		((Control)this).get_Controls().Add((Control)(object)f9AL());
		((Control)this).get_Controls().Add((Control)(object)z1EQ());
		((Control)this).get_Controls().Add((Control)(object)Aw3b());
		((Control)this).get_Controls().Add((Control)(object)Ek4p());
		((Control)this).get_Controls().Add((Control)(object)n2S3());
		((Control)this).get_Controls().Add((Control)(object)Gt31());
		((Control)this).get_Controls().Add((Control)(object)Xf4());
		((Control)this).get_Controls().Add((Control)(object)i6B());
		((Control)this).get_Controls().Add((Control)(object)Ae3());
		((Control)this).get_Controls().Add((Control)(object)o2X());
		((Control)this).get_Controls().Add((Control)(object)t4K());
		((Control)this).get_Controls().Add((Control)(object)Pe4());
		((Control)this).get_Controls().Add((Control)(object)Ki2());
		((Control)this).get_Controls().Add((Control)(object)La3());
		((Control)this).get_Controls().Add((Control)(object)y9T());
		((Control)this).get_Controls().Add((Control)(object)Zj7());
		((Control)this).get_Controls().Add((Control)(object)m8C());
		((Control)this).get_Controls().Add((Control)(object)e1R());
		((Control)this).get_Controls().Add((Control)(object)d6C());
		((Control)this).get_Controls().Add((Control)(object)z0H());
		((Control)this).get_Controls().Add((Control)(object)b5Z());
		((Control)this).get_Controls().Add((Control)(object)b1K());
		((Control)this).get_Controls().Add((Control)(object)o4Q());
		((Control)this).get_Controls().Add((Control)(object)e3C());
		((Control)this).get_Controls().Add((Control)(object)z4C());
		((Control)this).get_Controls().Add((Control)(object)a5C());
		((Control)this).get_Controls().Add((Control)(object)t4H());
		((Control)this).get_Controls().Add((Control)(object)i2Y());
		((Control)this).get_Controls().Add((Control)(object)r7H());
		((Control)this).get_Controls().Add((Control)(object)Ni6());
		((Control)this).get_Controls().Add((Control)(object)n0W());
		((Control)this).get_Controls().Add((Control)(object)x5L());
		((Control)this).get_Controls().Add((Control)(object)o0T());
		((Control)this).get_Controls().Add((Control)(object)d6F());
		((Control)this).get_Controls().Add((Control)(object)Dj2());
		((Control)this).get_Controls().Add((Control)(object)o8T());
		((Control)this).get_Controls().Add((Control)(object)Cj9());
		((Control)this).get_Controls().Add((Control)(object)Jt3());
		((Control)this).get_Controls().Add((Control)(object)Az2());
		((Control)this).get_Controls().Add((Control)(object)s3Z());
		((Control)this).get_Controls().Add((Control)(object)Bt7());
		((Control)this).get_Controls().Add((Control)(object)Fx8());
		((Control)this).get_Controls().Add((Control)(object)k8W());
		((Control)this).get_Controls().Add((Control)(object)p3Y());
		((Control)this).get_Controls().Add((Control)(object)w9S());
		((Control)this).get_Controls().Add((Control)(object)m6S());
		((Control)this).get_Controls().Add((Control)(object)Zb6());
		((Control)this).get_Controls().Add((Control)(object)Rp8());
		((Control)this).get_Controls().Add((Control)(object)o4E());
		((Control)this).get_Controls().Add((Control)(object)i4Z());
		((Control)this).get_Controls().Add((Control)(object)St4());
		((Control)this).get_Controls().Add((Control)(object)k2L());
		((Control)this).get_Controls().Add((Control)(object)g9Y());
		((Control)this).get_Controls().Add((Control)(object)Fb3());
		((Control)this).get_Controls().Add((Control)(object)Gf5());
		((Control)this).get_Controls().Add((Control)(object)g3Q());
		((Control)this).get_Controls().Add((Control)(object)a5H());
		((Control)this).get_Controls().Add((Control)(object)o1E());
		((Control)this).get_Controls().Add((Control)(object)o8A());
		((Control)this).get_Controls().Add((Control)(object)Pw0());
		((Control)this).get_Controls().Add((Control)(object)Ce3());
		((Control)this).get_Controls().Add((Control)(object)Zz3());
		((Control)this).get_Controls().Add((Control)(object)w6C());
		((Control)this).get_Controls().Add((Control)(object)c1G());
		((Control)this).get_Controls().Add((Control)(object)Gc9());
		((Control)this).get_Controls().Add((Control)(object)d6B());
		((Control)this).get_Controls().Add((Control)(object)n1Q());
		((Control)this).get_Controls().Add((Control)(object)Fe8());
		((Control)this).get_Controls().Add((Control)(object)Ys8());
		((Control)this).get_Controls().Add((Control)(object)b3E());
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Cinema4");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("CINEMA 4");
		((ISupportInitialize)Sd9b()).EndInit();
		((ISupportInitialize)o9WB()).EndInit();
		((ISupportInitialize)Gx69()).EndInit();
		((ISupportInitialize)d4GW()).EndInit();
		((ISupportInitialize)p2F0()).EndInit();
		((ISupportInitialize)Hb6r()).EndInit();
		((ISupportInitialize)z5E3()).EndInit();
		((ISupportInitialize)w5SQ()).EndInit();
		((ISupportInitialize)j7R1()).EndInit();
		((ISupportInitialize)Gj0k()).EndInit();
		((ISupportInitialize)z4FS()).EndInit();
		((ISupportInitialize)b9SC()).EndInit();
		((ISupportInitialize)y0EM()).EndInit();
		((ISupportInitialize)Xf18()).EndInit();
		((ISupportInitialize)Nr24()).EndInit();
		((ISupportInitialize)f8MY()).EndInit();
		((ISupportInitialize)n0DH()).EndInit();
		((ISupportInitialize)d8SF()).EndInit();
		((ISupportInitialize)Ac15()).EndInit();
		((ISupportInitialize)n1C6()).EndInit();
		((ISupportInitialize)Pb5c()).EndInit();
		((ISupportInitialize)a8L9()).EndInit();
		((ISupportInitialize)Le31()).EndInit();
		((ISupportInitialize)y0SX()).EndInit();
		((ISupportInitialize)f6M2()).EndInit();
		((ISupportInitialize)f2XE()).EndInit();
		((ISupportInitialize)w3HZ()).EndInit();
		((ISupportInitialize)Gq4r()).EndInit();
		((ISupportInitialize)St4f()).EndInit();
		((ISupportInitialize)Xq1p()).EndInit();
		((ISupportInitialize)Bn9e()).EndInit();
		((ISupportInitialize)d8Q1()).EndInit();
		((ISupportInitialize)Rq5f()).EndInit();
		((ISupportInitialize)Ts61()).EndInit();
		((ISupportInitialize)Xq8n()).EndInit();
		((ISupportInitialize)Gs57()).EndInit();
		((ISupportInitialize)Pa7k()).EndInit();
		((ISupportInitialize)Dq32()).EndInit();
		((ISupportInitialize)n8QA()).EndInit();
		((ISupportInitialize)Br0s()).EndInit();
		((ISupportInitialize)Tf28()).EndInit();
		((ISupportInitialize)j1J4()).EndInit();
		((ISupportInitialize)Qc62()).EndInit();
		((ISupportInitialize)Wt34()).EndInit();
		((ISupportInitialize)Mg27()).EndInit();
		((ISupportInitialize)s9K3()).EndInit();
		((ISupportInitialize)i5CH()).EndInit();
		((ISupportInitialize)d4B5()).EndInit();
		((ISupportInitialize)Fg69()).EndInit();
		((ISupportInitialize)c5HK()).EndInit();
		((ISupportInitialize)b5S4()).EndInit();
		((ISupportInitialize)Qi7k()).EndInit();
		((ISupportInitialize)Ze8w()).EndInit();
		((ISupportInitialize)p6E0()).EndInit();
		((ISupportInitialize)m7SW()).EndInit();
		((ISupportInitialize)e9SG()).EndInit();
		((ISupportInitialize)Sd20()).EndInit();
		((ISupportInitialize)q2HC()).EndInit();
		((ISupportInitialize)k0P9()).EndInit();
		((ISupportInitialize)Gi71()).EndInit();
		((ISupportInitialize)o0Y3()).EndInit();
		((ISupportInitialize)p7SA()).EndInit();
		((ISupportInitialize)Kj49()).EndInit();
		((ISupportInitialize)t6MJ()).EndInit();
		((ISupportInitialize)x5DH()).EndInit();
		((ISupportInitialize)Hf6o()).EndInit();
		((ISupportInitialize)Bw07()).EndInit();
		((ISupportInitialize)b6WZ()).EndInit();
		((ISupportInitialize)x0A4()).EndInit();
		((ISupportInitialize)Zt56()).EndInit();
		((ISupportInitialize)n1Y3()).EndInit();
		((ISupportInitialize)Jq10()).EndInit();
		((ISupportInitialize)As50()).EndInit();
		((ISupportInitialize)f0A1()).EndInit();
		((ISupportInitialize)Dr12()).EndInit();
		((ISupportInitialize)d3L2()).EndInit();
		((ISupportInitialize)Gy0x()).EndInit();
		((ISupportInitialize)Aq97()).EndInit();
		((ISupportInitialize)Pm89()).EndInit();
		((ISupportInitialize)Jm6n()).EndInit();
		((ISupportInitialize)Yf90()).EndInit();
		((ISupportInitialize)Lr6z()).EndInit();
		((ISupportInitialize)Ps28()).EndInit();
		((ISupportInitialize)Ex7b()).EndInit();
		((ISupportInitialize)x0KS()).EndInit();
		((ISupportInitialize)x4P9()).EndInit();
		((ISupportInitialize)r7FB()).EndInit();
		((ISupportInitialize)z0YQ()).EndInit();
		((ISupportInitialize)Mr90()).EndInit();
		((ISupportInitialize)Tc20()).EndInit();
		((ISupportInitialize)Ne86()).EndInit();
		((ISupportInitialize)Kg53()).EndInit();
		((ISupportInitialize)f2SP()).EndInit();
		((ISupportInitialize)Np60()).EndInit();
		((ISupportInitialize)n0W6()).EndInit();
		((ISupportInitialize)Eg5p()).EndInit();
		((ISupportInitialize)Pa9b()).EndInit();
		((ISupportInitialize)y0A5()).EndInit();
		((ISupportInitialize)c3KX()).EndInit();
		((ISupportInitialize)f7C9()).EndInit();
		((ISupportInitialize)d2CY()).EndInit();
		((ISupportInitialize)Td7e()).EndInit();
		((ISupportInitialize)Wi24()).EndInit();
		((ISupportInitialize)Kx2b()).EndInit();
		((ISupportInitialize)p9RM()).EndInit();
		((ISupportInitialize)y9WL()).EndInit();
		((ISupportInitialize)a2Q3()).EndInit();
		((ISupportInitialize)g1W9()).EndInit();
		((ISupportInitialize)k8T6()).EndInit();
		((ISupportInitialize)Sj51()).EndInit();
		((ISupportInitialize)j6L7()).EndInit();
		((ISupportInitialize)Qt2c()).EndInit();
		((ISupportInitialize)Hn80()).EndInit();
		((ISupportInitialize)Jp40()).EndInit();
		((ISupportInitialize)j1PK()).EndInit();
		((ISupportInitialize)Sa5k()).EndInit();
		((ISupportInitialize)Rn50()).EndInit();
		((ISupportInitialize)Dk80()).EndInit();
		((ISupportInitialize)p3DQ()).EndInit();
		((ISupportInitialize)Xb63()).EndInit();
		((ISupportInitialize)g7PF()).EndInit();
		((ISupportInitialize)b2PK()).EndInit();
		((ISupportInitialize)w7DF()).EndInit();
		((ISupportInitialize)Xs5f()).EndInit();
		((ISupportInitialize)Gt49()).EndInit();
		((ISupportInitialize)k0B4()).EndInit();
		((ISupportInitialize)y4J2()).EndInit();
		((ISupportInitialize)p3SL()).EndInit();
		((ISupportInitialize)Kx41()).EndInit();
		((ISupportInitialize)x8P7()).EndInit();
		((ISupportInitialize)Md2y()).EndInit();
		((ISupportInitialize)b9GW()).EndInit();
		((ISupportInitialize)n7A6()).EndInit();
		((ISupportInitialize)Mt3r()).EndInit();
		((ISupportInitialize)e9K5()).EndInit();
		((ISupportInitialize)f1M3()).EndInit();
		((ISupportInitialize)m7X2()).EndInit();
		((ISupportInitialize)Gd38()).EndInit();
		((ISupportInitialize)Pn39()).EndInit();
		((ISupportInitialize)Az82()).EndInit();
		((ISupportInitialize)i3WE()).EndInit();
		((ISupportInitialize)Gk0m()).EndInit();
		((ISupportInitialize)Zd5f()).EndInit();
		((ISupportInitialize)o9S2()).EndInit();
		((ISupportInitialize)f9AL()).EndInit();
		((ISupportInitialize)z1EQ()).EndInit();
		((ISupportInitialize)Aw3b()).EndInit();
		((ISupportInitialize)Ek4p()).EndInit();
		((ISupportInitialize)n2S3()).EndInit();
		((ISupportInitialize)Gt31()).EndInit();
		((ISupportInitialize)Xf4()).EndInit();
		((ISupportInitialize)i6B()).EndInit();
		((ISupportInitialize)Ae3()).EndInit();
		((ISupportInitialize)o2X()).EndInit();
		((ISupportInitialize)t4K()).EndInit();
		((ISupportInitialize)Pe4()).EndInit();
		((ISupportInitialize)Ki2()).EndInit();
		((ISupportInitialize)La3()).EndInit();
		((ISupportInitialize)y9T()).EndInit();
		((ISupportInitialize)Zj7()).EndInit();
		((Control)n1Q()).ResumeLayout(false);
		((Control)n1Q()).PerformLayout();
		((ISupportInitialize)Tw4()).EndInit();
		((ISupportInitialize)j4Y()).EndInit();
		((ISupportInitialize)Rr4()).EndInit();
		((ISupportInitialize)Ys8()).EndInit();
		((ISupportInitialize)b3E()).EndInit();
		((Control)Ki0()).ResumeLayout(false);
		((ISupportInitialize)e2J()).EndInit();
		((Control)w5W()).ResumeLayout(false);
		((Control)w5W()).PerformLayout();
		((Control)Dw7()).ResumeLayout(false);
		((Control)Dw7()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual TextBox Ta92()
	{
		return _txtProvisional;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gs85(TextBox Tf90)
	{
		_txtProvisional = Tf90;
	}

	[SpecialName]
	internal virtual TextBox i7W3()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq52(TextBox d3GF)
	{
		TextBox val = (M = d3GF);
	}

	[SpecialName]
	internal virtual Label c9XL()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1TE(Label r6BX)
	{
		_Label1 = r6BX;
	}

	[SpecialName]
	internal virtual Label Nd7e()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k5M6(Label o7E4)
	{
		Label val = (v = o7E4);
	}

	[SpecialName]
	internal virtual PictureBox Sd9b()
	{
		return _PictureBox141;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am10(PictureBox Yt50)
	{
		_PictureBox141 = Yt50;
	}

	[SpecialName]
	internal virtual PictureBox o9WB()
	{
		return _PictureBox142;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f7HX(PictureBox y6Q7)
	{
		_PictureBox142 = y6Q7;
	}

	[SpecialName]
	internal virtual PictureBox Gx69()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yk81(PictureBox n1DJ)
	{
		PictureBox val = (W = n1DJ);
	}

	[SpecialName]
	internal virtual PictureBox d4GW()
	{
		return _PictureBox144;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8QT(PictureBox m0N2)
	{
		_PictureBox144 = m0N2;
	}

	[SpecialName]
	internal virtual PictureBox p2F0()
	{
		return _PictureBox145;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8SY(PictureBox Cd19)
	{
		_PictureBox145 = Cd19;
	}

	[SpecialName]
	internal virtual PictureBox Hb6r()
	{
		return _PictureBox146;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mr94(PictureBox Sd3i)
	{
		_PictureBox146 = Sd3i;
	}

	[SpecialName]
	internal virtual PictureBox z5E3()
	{
		return _PictureBox147;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6ZE(PictureBox x7CH)
	{
		_PictureBox147 = x7CH;
	}

	[SpecialName]
	internal virtual PictureBox w5SQ()
	{
		return _PictureBox148;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cf75(PictureBox c3M1)
	{
		_PictureBox148 = c3M1;
	}

	[SpecialName]
	internal virtual PictureBox j7R1()
	{
		return _PictureBox149;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn98(PictureBox e5W7)
	{
		_PictureBox149 = e5W7;
	}

	[SpecialName]
	internal virtual PictureBox Gj0k()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At58(PictureBox x2EW)
	{
		PictureBox val = (C = x2EW);
	}

	[SpecialName]
	internal virtual PictureBox z4FS()
	{
		return _PictureBox151;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mp85(PictureBox z4T3)
	{
		_PictureBox151 = z4T3;
	}

	[SpecialName]
	internal virtual PictureBox b9SC()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8DJ(PictureBox q6LX)
	{
		PictureBox val = (X = q6LX);
	}

	[SpecialName]
	internal virtual PictureBox y0EM()
	{
		return _PictureBox153;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz40(PictureBox Zo65)
	{
		_PictureBox153 = Zo65;
	}

	[SpecialName]
	internal virtual PictureBox Xf18()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void En2w(PictureBox m8FS)
	{
		PictureBox val = (O = m8FS);
	}

	[SpecialName]
	internal virtual PictureBox Nr24()
	{
		return _PictureBox155;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7F8(PictureBox Hb87)
	{
		_PictureBox155 = Hb87;
	}

	[SpecialName]
	internal virtual PictureBox f8MY()
	{
		return _PictureBox156;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4F9(PictureBox d9LP)
	{
		_PictureBox156 = d9LP;
	}

	[SpecialName]
	internal virtual PictureBox n0DH()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rq3s(PictureBox Zn47)
	{
		PictureBox val = (k = Zn47);
	}

	[SpecialName]
	internal virtual PictureBox d8SF()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo47(PictureBox Ts85)
	{
		PictureBox val = (t = Ts85);
	}

	[SpecialName]
	internal virtual PictureBox Ac15()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7SE(PictureBox g7GD)
	{
		PictureBox val = (H = g7GD);
	}

	[SpecialName]
	internal virtual PictureBox n1C6()
	{
		return _PictureBox160;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2YF(PictureBox x9HR)
	{
		_PictureBox160 = x9HR;
	}

	[SpecialName]
	internal virtual PictureBox Pb5c()
	{
		return _PictureBox121;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y0K6(PictureBox y9J6)
	{
		_PictureBox121 = y9J6;
	}

	[SpecialName]
	internal virtual PictureBox a8L9()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Si91(PictureBox i0QF)
	{
		PictureBox val = (q = i0QF);
	}

	[SpecialName]
	internal virtual PictureBox Le31()
	{
		return _PictureBox123;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2N8(PictureBox Sr76)
	{
		_PictureBox123 = Sr76;
	}

	[SpecialName]
	internal virtual PictureBox y0SX()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1ZY(PictureBox Xf2m)
	{
		PictureBox val = (u = Xf2m);
	}

	[SpecialName]
	internal virtual PictureBox f6M2()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns7o(PictureBox w3EY)
	{
		PictureBox val = (S = w3EY);
	}

	[SpecialName]
	internal virtual PictureBox f2XE()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Li8w(PictureBox f4ZF)
	{
		PictureBox val = (A = f4ZF);
	}

	[SpecialName]
	internal virtual PictureBox w3HZ()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eq6e(PictureBox j0AT)
	{
		PictureBox val = (y = j0AT);
	}

	[SpecialName]
	internal virtual PictureBox Gq4r()
	{
		return _PictureBox128;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ho2p(PictureBox Fj8d)
	{
		_PictureBox128 = Fj8d;
	}

	[SpecialName]
	internal virtual PictureBox St4f()
	{
		return _PictureBox129;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d2GW(PictureBox Xp4x)
	{
		_PictureBox129 = Xp4x;
	}

	[SpecialName]
	internal virtual PictureBox Xq1p()
	{
		return _PictureBox130;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pd5s(PictureBox c8R4)
	{
		_PictureBox130 = c8R4;
	}

	[SpecialName]
	internal virtual PictureBox Bn9e()
	{
		return _PictureBox131;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt4s(PictureBox Dx52)
	{
		_PictureBox131 = Dx52;
	}

	[SpecialName]
	internal virtual PictureBox d8Q1()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc74(PictureBox s4BR)
	{
		PictureBox val = (D = s4BR);
	}

	[SpecialName]
	internal virtual PictureBox Rq5f()
	{
		return _PictureBox133;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z5L6(PictureBox Zk6f)
	{
		_PictureBox133 = Zk6f;
	}

	[SpecialName]
	internal virtual PictureBox Ts61()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fx3t(PictureBox Ti1w)
	{
		PictureBox val = (N = Ti1w);
	}

	[SpecialName]
	internal virtual PictureBox Xq8n()
	{
		return _PictureBox135;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fb20(PictureBox i1M0)
	{
		_PictureBox135 = i1M0;
	}

	[SpecialName]
	internal virtual PictureBox Gs57()
	{
		return _PictureBox136;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9JL(PictureBox Aj4m)
	{
		_PictureBox136 = Aj4m;
	}

	[SpecialName]
	internal virtual PictureBox Pa7k()
	{
		return _PictureBox137;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yn3i(PictureBox Bs6q)
	{
		_PictureBox137 = Bs6q;
	}

	[SpecialName]
	internal virtual PictureBox Dq32()
	{
		return _PictureBox138;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0S4(PictureBox p6A1)
	{
		_PictureBox138 = p6A1;
	}

	[SpecialName]
	internal virtual PictureBox n8QA()
	{
		return _PictureBox139;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3Z0(PictureBox d4KM)
	{
		_PictureBox139 = d4KM;
	}

	[SpecialName]
	internal virtual PictureBox Br0s()
	{
		return _PictureBox140;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m1C9(PictureBox t0K3)
	{
		_PictureBox140 = t0K3;
	}

	[SpecialName]
	internal virtual PictureBox Tf28()
	{
		return _PictureBox101;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cp14(PictureBox Gw6q)
	{
		_PictureBox101 = Gw6q;
	}

	[SpecialName]
	internal virtual PictureBox j1J4()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gz72(PictureBox d7C6)
	{
		PictureBox val = (L = d7C6);
	}

	[SpecialName]
	internal virtual PictureBox Qc62()
	{
		return _PictureBox103;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Py75(PictureBox Hj7w)
	{
		_PictureBox103 = Hj7w;
	}

	[SpecialName]
	internal virtual PictureBox Wt34()
	{
		return _PictureBox104;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4H0(PictureBox x8KW)
	{
		_PictureBox104 = x8KW;
	}

	[SpecialName]
	internal virtual PictureBox Mg27()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6N7(PictureBox q1L9)
	{
		PictureBox val = (B = q1L9);
	}

	[SpecialName]
	internal virtual PictureBox s9K3()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7PB(PictureBox d1ZX)
	{
		PictureBox val = (r = d1ZX);
	}

	[SpecialName]
	internal virtual PictureBox i5CH()
	{
		return _PictureBox107;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x6R5(PictureBox Rz25)
	{
		_PictureBox107 = Rz25;
	}

	[SpecialName]
	internal virtual PictureBox d4B5()
	{
		return _PictureBox108;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hj4k(PictureBox d3S0)
	{
		_PictureBox108 = d3S0;
	}

	[SpecialName]
	internal virtual PictureBox Fg69()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi95(PictureBox z3XA)
	{
		PictureBox val = (J = z3XA);
	}

	[SpecialName]
	internal virtual PictureBox c5HK()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2H3(PictureBox e8C9)
	{
		PictureBox val = (E = e8C9);
	}

	[SpecialName]
	internal virtual PictureBox b5S4()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2KZ(PictureBox Tm2x)
	{
		PictureBox val = (F = Tm2x);
	}

	[SpecialName]
	internal virtual PictureBox Qi7k()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1GT(PictureBox Xw56)
	{
		PictureBox val = (G = Xw56);
	}

	[SpecialName]
	internal virtual PictureBox Ze8w()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4Y1(PictureBox Gy2w)
	{
		PictureBox val = (I = Gy2w);
	}

	[SpecialName]
	internal virtual PictureBox p6E0()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d9M4(PictureBox Bd24)
	{
		PictureBox val = (z = Bd24);
	}

	[SpecialName]
	internal virtual PictureBox m7SW()
	{
		return _PictureBox115;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0P8(PictureBox z9R3)
	{
		_PictureBox115 = z9R3;
	}

	[SpecialName]
	internal virtual PictureBox e9SG()
	{
		return Mp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2NK(PictureBox Sj4z)
	{
		PictureBox val = (Mp = Sj4z);
	}

	[SpecialName]
	internal virtual PictureBox Sd20()
	{
		return MM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps4m(PictureBox f0SW)
	{
		PictureBox val = (MM = f0SW);
	}

	[SpecialName]
	internal virtual PictureBox q2HC()
	{
		return Mv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2A6(PictureBox Mb4r)
	{
		PictureBox val = (Mv = Mb4r);
	}

	[SpecialName]
	internal virtual PictureBox k0P9()
	{
		return _PictureBox119;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7R2(PictureBox m5GZ)
	{
		_PictureBox119 = m5GZ;
	}

	[SpecialName]
	internal virtual PictureBox Gi71()
	{
		return MW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np5c(PictureBox q9A0)
	{
		PictureBox val = (MW = q9A0);
	}

	[SpecialName]
	internal virtual PictureBox o0Y3()
	{
		return _PictureBox81;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3QM(PictureBox Ke65)
	{
		_PictureBox81 = Ke65;
	}

	[SpecialName]
	internal virtual PictureBox p7SA()
	{
		return _PictureBox82;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sj46(PictureBox Zm9s)
	{
		_PictureBox82 = Zm9s;
	}

	[SpecialName]
	internal virtual PictureBox Kj49()
	{
		return MC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5N6(PictureBox r3LE)
	{
		PictureBox val = (MC = r3LE);
	}

	[SpecialName]
	internal virtual PictureBox t6MJ()
	{
		return _PictureBox84;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rn7g(PictureBox e1L4)
	{
		_PictureBox84 = e1L4;
	}

	[SpecialName]
	internal virtual PictureBox x5DH()
	{
		return _PictureBox85;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4WM(PictureBox Pc41)
	{
		_PictureBox85 = Pc41;
	}

	[SpecialName]
	internal virtual PictureBox Hf6o()
	{
		return MX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7EJ(PictureBox Xm12)
	{
		PictureBox val = (MX = Xm12);
	}

	[SpecialName]
	internal virtual PictureBox Bw07()
	{
		return MO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f3Q9(PictureBox Ji1o)
	{
		PictureBox val = (MO = Ji1o);
	}

	[SpecialName]
	internal virtual PictureBox b6WZ()
	{
		return _PictureBox88;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rq23(PictureBox Mc30)
	{
		_PictureBox88 = Mc30;
	}

	[SpecialName]
	internal virtual PictureBox x0A4()
	{
		return _PictureBox89;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4GW(PictureBox r2YC)
	{
		_PictureBox89 = r2YC;
	}

	[SpecialName]
	internal virtual PictureBox Zt56()
	{
		return Mk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg9q(PictureBox Te25)
	{
		PictureBox val = (Mk = Te25);
	}

	[SpecialName]
	internal virtual PictureBox n1Y3()
	{
		return Mt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o2C7(PictureBox c2JL)
	{
		PictureBox val = (Mt = c2JL);
	}

	[SpecialName]
	internal virtual PictureBox Jq10()
	{
		return MH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj5d(PictureBox Xd13)
	{
		PictureBox val = (MH = Xd13);
	}

	[SpecialName]
	internal virtual PictureBox As50()
	{
		return _PictureBox93;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1C0(PictureBox Gw6j)
	{
		_PictureBox93 = Gw6j;
	}

	[SpecialName]
	internal virtual PictureBox f0A1()
	{
		return Mq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3HB(PictureBox t0P6)
	{
		PictureBox val = (Mq = t0P6);
	}

	[SpecialName]
	internal virtual PictureBox Dr12()
	{
		return _PictureBox95;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r4MC(PictureBox y2E1)
	{
		_PictureBox95 = y2E1;
	}

	[SpecialName]
	internal virtual PictureBox d3L2()
	{
		return Mu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At2r(PictureBox Yk9s)
	{
		PictureBox val = (Mu = Yk9s);
	}

	[SpecialName]
	internal virtual PictureBox Gy0x()
	{
		return _PictureBox97;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc4n(PictureBox c9S4)
	{
		_PictureBox97 = c9S4;
	}

	[SpecialName]
	internal virtual PictureBox Aq97()
	{
		return _PictureBox98;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lb4d(PictureBox s8HB)
	{
		_PictureBox98 = s8HB;
	}

	[SpecialName]
	internal virtual PictureBox Pm89()
	{
		return MS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4CG(PictureBox z2F9)
	{
		PictureBox val = (MS = z2F9);
	}

	[SpecialName]
	internal virtual PictureBox Jm6n()
	{
		return _PictureBox100;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fe78(PictureBox p9QD)
	{
		_PictureBox100 = p9QD;
	}

	[SpecialName]
	internal virtual PictureBox Yf90()
	{
		return _PictureBox61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wx23(PictureBox Ao3e)
	{
		_PictureBox61 = Ao3e;
	}

	[SpecialName]
	internal virtual PictureBox Lr6z()
	{
		return MA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9AM(PictureBox f3P2)
	{
		PictureBox val = (MA = f3P2);
	}

	[SpecialName]
	internal virtual PictureBox Ps28()
	{
		return _PictureBox63;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Be92(PictureBox b2PS)
	{
		_PictureBox63 = b2PS;
	}

	[SpecialName]
	internal virtual PictureBox Ex7b()
	{
		return My;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He5a(PictureBox Ga1e)
	{
		PictureBox val = (My = Ga1e);
	}

	[SpecialName]
	internal virtual PictureBox x0KS()
	{
		return _PictureBox65;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zm90(PictureBox o3H8)
	{
		_PictureBox65 = o3H8;
	}

	[SpecialName]
	internal virtual PictureBox x4P9()
	{
		return MD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j2YS(PictureBox Li30)
	{
		PictureBox val = (MD = Li30);
	}

	[SpecialName]
	internal virtual PictureBox r7FB()
	{
		return MN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xb73(PictureBox o7B9)
	{
		PictureBox val = (MN = o7B9);
	}

	[SpecialName]
	internal virtual PictureBox z0YQ()
	{
		return ML;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fx24(PictureBox k5Z7)
	{
		PictureBox val = (ML = k5Z7);
	}

	[SpecialName]
	internal virtual PictureBox Mr90()
	{
		return MB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2BY(PictureBox Gy0k)
	{
		PictureBox val = (MB = Gy0k);
	}

	[SpecialName]
	internal virtual PictureBox Tc20()
	{
		return Mr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f4WT(PictureBox Po94)
	{
		PictureBox val = (Mr = Po94);
	}

	[SpecialName]
	internal virtual PictureBox Ne86()
	{
		return MJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qf78(PictureBox Nn60)
	{
		PictureBox val = (MJ = Nn60);
	}

	[SpecialName]
	internal virtual PictureBox Kg53()
	{
		return _PictureBox72;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw49(PictureBox Xn3x)
	{
		_PictureBox72 = Xn3x;
	}

	[SpecialName]
	internal virtual PictureBox f2SP()
	{
		return _PictureBox73;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ld21(PictureBox Nj14)
	{
		_PictureBox73 = Nj14;
	}

	[SpecialName]
	internal virtual PictureBox Np60()
	{
		return ME;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f9H7(PictureBox Ke58)
	{
		PictureBox val = (ME = Ke58);
	}

	[SpecialName]
	internal virtual PictureBox n0W6()
	{
		return MF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sr3c(PictureBox Mp9s)
	{
		PictureBox val = (MF = Mp9s);
	}

	[SpecialName]
	internal virtual PictureBox Eg5p()
	{
		return MG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2FN(PictureBox c4R5)
	{
		PictureBox val = (MG = c4R5);
	}

	[SpecialName]
	internal virtual PictureBox Pa9b()
	{
		return MI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nb1s(PictureBox Fn47)
	{
		PictureBox val = (MI = Fn47);
	}

	[SpecialName]
	internal virtual PictureBox y0A5()
	{
		return Mz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9S2(PictureBox Jk76)
	{
		PictureBox val = (Mz = Jk76);
	}

	[SpecialName]
	internal virtual PictureBox c3KX()
	{
		return vp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ws7n(PictureBox a0N6)
	{
		PictureBox val = (vp = a0N6);
	}

	[SpecialName]
	internal virtual PictureBox f7C9()
	{
		return vM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wk5d(PictureBox s8LA)
	{
		PictureBox val = (vM = s8LA);
	}

	[SpecialName]
	internal virtual PictureBox d2CY()
	{
		return _PictureBox41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw01(PictureBox f8J9)
	{
		_PictureBox41 = f8J9;
	}

	[SpecialName]
	internal virtual PictureBox Td7e()
	{
		return _PictureBox42;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6FY(PictureBox Yp0b)
	{
		_PictureBox42 = Yp0b;
	}

	[SpecialName]
	internal virtual PictureBox Wi24()
	{
		return _PictureBox43;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o5T8(PictureBox d6SP)
	{
		_PictureBox43 = d6SP;
	}

	[SpecialName]
	internal virtual PictureBox Kx2b()
	{
		return _PictureBox44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xx96(PictureBox Yc1x)
	{
		_PictureBox44 = Yc1x;
	}

	[SpecialName]
	internal virtual PictureBox p9RM()
	{
		return vv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1ZE(PictureBox f0BH)
	{
		PictureBox val = (vv = f0BH);
	}

	[SpecialName]
	internal virtual PictureBox y9WL()
	{
		return _PictureBox46;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kw8y(PictureBox s5ML)
	{
		_PictureBox46 = s5ML;
	}

	[SpecialName]
	internal virtual PictureBox a2Q3()
	{
		return vW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7D5(PictureBox Fr2d)
	{
		PictureBox val = (vW = Fr2d);
	}

	[SpecialName]
	internal virtual PictureBox g1W9()
	{
		return _PictureBox48;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4W0(PictureBox t3LR)
	{
		_PictureBox48 = t3LR;
	}

	[SpecialName]
	internal virtual PictureBox k8T6()
	{
		return vC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Td9g(PictureBox t9QF)
	{
		PictureBox val = (vC = t9QF);
	}

	[SpecialName]
	internal virtual PictureBox Sj51()
	{
		return vX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8Q7(PictureBox Hx1f)
	{
		PictureBox val = (vX = Hx1f);
	}

	[SpecialName]
	internal virtual PictureBox j6L7()
	{
		return _PictureBox51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1D9(PictureBox Fp4t)
	{
		_PictureBox51 = Fp4t;
	}

	[SpecialName]
	internal virtual PictureBox Qt2c()
	{
		return vO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ac50(PictureBox Jc08)
	{
		PictureBox val = (vO = Jc08);
	}

	[SpecialName]
	internal virtual PictureBox Hn80()
	{
		return _PictureBox53;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5BG(PictureBox Nt29)
	{
		_PictureBox53 = Nt29;
	}

	[SpecialName]
	internal virtual PictureBox Jp40()
	{
		return _PictureBox54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk7e(PictureBox e2PL)
	{
		_PictureBox54 = e2PL;
	}

	[SpecialName]
	internal virtual PictureBox j1PK()
	{
		return _PictureBox55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4AT(PictureBox Qw31)
	{
		_PictureBox55 = Qw31;
	}

	[SpecialName]
	internal virtual PictureBox Sa5k()
	{
		return vk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1LE(PictureBox o7Q9)
	{
		PictureBox val = (vk = o7Q9);
	}

	[SpecialName]
	internal virtual PictureBox Rn50()
	{
		return _PictureBox57;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te94(PictureBox w9SN)
	{
		_PictureBox57 = w9SN;
	}

	[SpecialName]
	internal virtual PictureBox Dk80()
	{
		return _PictureBox58;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep36(PictureBox m9W4)
	{
		_PictureBox58 = m9W4;
	}

	[SpecialName]
	internal virtual PictureBox p3DQ()
	{
		return _PictureBox59;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm9s(PictureBox Ag3e)
	{
		_PictureBox59 = Ag3e;
	}

	[SpecialName]
	internal virtual PictureBox Xb63()
	{
		return vt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i5S4(PictureBox Zi8g)
	{
		PictureBox val = (vt = Zi8g);
	}

	[SpecialName]
	internal virtual PictureBox g7PF()
	{
		return _PictureBox21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3M2(PictureBox p4W3)
	{
		_PictureBox21 = p4W3;
	}

	[SpecialName]
	internal virtual PictureBox b2PK()
	{
		return vH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kp4w(PictureBox Xm84)
	{
		PictureBox val = (vH = Xm84);
	}

	[SpecialName]
	internal virtual PictureBox w7DF()
	{
		return vq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7J5(PictureBox c8SZ)
	{
		PictureBox val = (vq = c8SZ);
	}

	[SpecialName]
	internal virtual PictureBox Xs5f()
	{
		return _PictureBox24;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nn7y(PictureBox z2MK)
	{
		_PictureBox24 = z2MK;
	}

	[SpecialName]
	internal virtual PictureBox Gt49()
	{
		return _PictureBox25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fs53(PictureBox Ln6i)
	{
		_PictureBox25 = Ln6i;
	}

	[SpecialName]
	internal virtual PictureBox k0B4()
	{
		return _PictureBox26;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bo90(PictureBox Nc84)
	{
		_PictureBox26 = Nc84;
	}

	[SpecialName]
	internal virtual PictureBox y4J2()
	{
		return _PictureBox27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ed3n(PictureBox Tt2p)
	{
		_PictureBox27 = Tt2p;
	}

	[SpecialName]
	internal virtual PictureBox p3SL()
	{
		return _PictureBox28;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ej95(PictureBox e1MN)
	{
		_PictureBox28 = e1MN;
	}

	[SpecialName]
	internal virtual PictureBox Kx41()
	{
		return vu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nt0f(PictureBox o0WR)
	{
		PictureBox val = (vu = o0WR);
	}

	[SpecialName]
	internal virtual PictureBox x8P7()
	{
		return vS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7N4(PictureBox Ym5w)
	{
		PictureBox val = (vS = Ym5w);
	}

	[SpecialName]
	internal virtual PictureBox Md2y()
	{
		return vA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7H0(PictureBox m1Q2)
	{
		PictureBox val = (vA = m1Q2);
	}

	[SpecialName]
	internal virtual PictureBox b9GW()
	{
		return vy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m4DK(PictureBox Gd94)
	{
		PictureBox val = (vy = Gd94);
	}

	[SpecialName]
	internal virtual PictureBox n7A6()
	{
		return _PictureBox33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eg7o(PictureBox s1E0)
	{
		_PictureBox33 = s1E0;
	}

	[SpecialName]
	internal virtual PictureBox Mt3r()
	{
		return vD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zk57(PictureBox t6L8)
	{
		PictureBox val = (vD = t6L8);
	}

	[SpecialName]
	internal virtual PictureBox e9K5()
	{
		return vN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ly6o(PictureBox My61)
	{
		PictureBox val = (vN = My61);
	}

	[SpecialName]
	internal virtual PictureBox f1M3()
	{
		return _PictureBox36;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y7QE(PictureBox x9N3)
	{
		_PictureBox36 = x9N3;
	}

	[SpecialName]
	internal virtual PictureBox m7X2()
	{
		return _PictureBox37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hi1e(PictureBox e2Y8)
	{
		_PictureBox37 = e2Y8;
	}

	[SpecialName]
	internal virtual PictureBox Gd38()
	{
		return vL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pa5g(PictureBox Hc03)
	{
		PictureBox val = (vL = Hc03);
	}

	[SpecialName]
	internal virtual PictureBox Pn39()
	{
		return vB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2SY(PictureBox Rb32)
	{
		PictureBox val = (vB = Rb32);
	}

	[SpecialName]
	internal virtual PictureBox Az82()
	{
		return vr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd47(PictureBox s0SJ)
	{
		PictureBox val = (vr = s0SJ);
	}

	[SpecialName]
	internal virtual PictureBox i3WE()
	{
		return vJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9Z6(PictureBox Rb7x)
	{
		PictureBox val = (vJ = Rb7x);
	}

	[SpecialName]
	internal virtual PictureBox Gk0m()
	{
		return _PictureBox19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3B8(PictureBox o7L5)
	{
		_PictureBox19 = o7L5;
	}

	[SpecialName]
	internal virtual PictureBox Zd5f()
	{
		return _PictureBox18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3LH(PictureBox Xs34)
	{
		_PictureBox18 = Xs34;
	}

	[SpecialName]
	internal virtual PictureBox o9S2()
	{
		return _PictureBox17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd28(PictureBox x2A8)
	{
		_PictureBox17 = x2A8;
	}

	[SpecialName]
	internal virtual PictureBox f9AL()
	{
		return vE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Md8i(PictureBox Lt34)
	{
		PictureBox val = (vE = Lt34);
	}

	[SpecialName]
	internal virtual PictureBox z1EQ()
	{
		return _PictureBox15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zw30(PictureBox Kj38)
	{
		_PictureBox15 = Kj38;
	}

	[SpecialName]
	internal virtual PictureBox Aw3b()
	{
		return _PictureBox14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ty2n(PictureBox j3K9)
	{
		_PictureBox14 = j3K9;
	}

	[SpecialName]
	internal virtual PictureBox Ek4p()
	{
		return _PictureBox13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns0g(PictureBox x2P5)
	{
		_PictureBox13 = x2P5;
	}

	[SpecialName]
	internal virtual PictureBox n2S3()
	{
		return vF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n9R3(PictureBox o8A4)
	{
		PictureBox val = (vF = o8A4);
	}

	[SpecialName]
	internal virtual PictureBox Gt31()
	{
		return _PictureBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk9n(PictureBox Ja7)
	{
		_PictureBox11 = Ja7;
	}

	[SpecialName]
	internal virtual PictureBox Xf4()
	{
		return vG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm7(PictureBox Nk2)
	{
		PictureBox val = (vG = Nk2);
	}

	[SpecialName]
	internal virtual PictureBox i6B()
	{
		return vI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zy9(PictureBox g5Q)
	{
		PictureBox val = (vI = g5Q);
	}

	[SpecialName]
	internal virtual PictureBox Ae3()
	{
		return vz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4A(PictureBox c6G)
	{
		PictureBox val = (vz = c6G);
	}

	[SpecialName]
	internal virtual PictureBox o2X()
	{
		return _PictureBox7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp3(PictureBox Jd1)
	{
		_PictureBox7 = Jd1;
	}

	[SpecialName]
	internal virtual PictureBox t4K()
	{
		return Wp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dy1(PictureBox t2A)
	{
		PictureBox val = (Wp = t2A);
	}

	[SpecialName]
	internal virtual PictureBox Pe4()
	{
		return _PictureBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8J(PictureBox z3C)
	{
		_PictureBox5 = z3C;
	}

	[SpecialName]
	internal virtual PictureBox Ki2()
	{
		return WM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0P(PictureBox q8Y)
	{
		PictureBox val = (WM = q8Y);
	}

	[SpecialName]
	internal virtual PictureBox La3()
	{
		return _PictureBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g2W(PictureBox s9L)
	{
		_PictureBox3 = s9L;
	}

	[SpecialName]
	internal virtual PictureBox y9T()
	{
		return Wv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9D(PictureBox w8C)
	{
		PictureBox val = (Wv = w8C);
	}

	[SpecialName]
	internal virtual PictureBox Zj7()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0Q(PictureBox i6A)
	{
		_PictureBox1 = i6A;
	}

	[SpecialName]
	internal virtual Label m8C()
	{
		return WW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ln4(Label Ap6)
	{
		Label val = (WW = Ap6);
	}

	[SpecialName]
	internal virtual Label e1R()
	{
		return _Label33;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3W(Label Sk9)
	{
		_Label33 = Sk9;
	}

	[SpecialName]
	internal virtual Label d6C()
	{
		return WC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b4G(Label s9R)
	{
		Label val = (WC = s9R);
	}

	[SpecialName]
	internal virtual Label z0H()
	{
		return WX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kf0(Label Tx4)
	{
		Label val = (WX = Tx4);
	}

	[SpecialName]
	internal virtual Label b5Z()
	{
		return WO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t9M(Label q9M)
	{
		Label val = (WO = q9M);
	}

	[SpecialName]
	internal virtual Label b1K()
	{
		return _Label37;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dm0(Label Sr8)
	{
		_Label37 = Sr8;
	}

	[SpecialName]
	internal virtual Label o4Q()
	{
		return _Label39;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hk0(Label y8F)
	{
		_Label39 = y8F;
	}

	[SpecialName]
	internal virtual Label e3C()
	{
		return _Label40;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zr7(Label De6)
	{
		_Label40 = De6;
	}

	[SpecialName]
	internal virtual Label z4C()
	{
		return _Label41;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je1(Label Rz1)
	{
		_Label41 = Rz1;
	}

	[SpecialName]
	internal virtual Label a5C()
	{
		return Wk;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1H(Label Jg9)
	{
		Label val = (Wk = Jg9);
	}

	[SpecialName]
	internal virtual Label t4H()
	{
		return Wt;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm6(Label s0D)
	{
		Label val = (Wt = s0D);
	}

	[SpecialName]
	internal virtual Label i2Y()
	{
		return _Label38;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ty8(Label Cr9)
	{
		_Label38 = Cr9;
	}

	[SpecialName]
	internal virtual Label r7H()
	{
		return _Label44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1B(Label c0X)
	{
		_Label44 = c0X;
	}

	[SpecialName]
	internal virtual Label Ni6()
	{
		return _Label45;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm9(Label n0N)
	{
		_Label45 = n0N;
	}

	[SpecialName]
	internal virtual Label n0W()
	{
		return WH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pb3(Label Dk3)
	{
		Label val = (WH = Dk3);
	}

	[SpecialName]
	internal virtual Label x5L()
	{
		return Wq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xx6(Label Yr9)
	{
		Label val = (Wq = Yr9);
	}

	[SpecialName]
	internal virtual Label o0T()
	{
		return Wu;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb4(Label i7Y)
	{
		Label val = (Wu = i7Y);
	}

	[SpecialName]
	internal virtual Label d6F()
	{
		return _Label49;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ab9(Label Xq7)
	{
		_Label49 = Xq7;
	}

	[SpecialName]
	internal virtual Label Dj2()
	{
		return _Label50;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8A(Label t9S)
	{
		_Label50 = t9S;
	}

	[SpecialName]
	internal virtual Label o8T()
	{
		return _Label51;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6C(Label Ef0)
	{
		_Label51 = Ef0;
	}

	[SpecialName]
	internal virtual Label Cj9()
	{
		return _Label54;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eg3(Label Sr3)
	{
		_Label54 = Sr3;
	}

	[SpecialName]
	internal virtual Label Jt3()
	{
		return _Label55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw9(Label Tc2)
	{
		_Label55 = Tc2;
	}

	[SpecialName]
	internal virtual Label Az2()
	{
		return WS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rw7(Label z6G)
	{
		Label val = (WS = z6G);
	}

	[SpecialName]
	internal virtual Label s3Z()
	{
		return WA;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mo0(Label Fq8)
	{
		Label val = (WA = Fq8);
	}

	[SpecialName]
	internal virtual Label Bt7()
	{
		return Wy;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qw9(Label x3Z)
	{
		Label val = (Wy = x3Z);
	}

	[SpecialName]
	internal virtual Label Fx8()
	{
		return _Label27;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9F(Label d6M)
	{
		_Label27 = d6M;
	}

	[SpecialName]
	internal virtual Label k8W()
	{
		return WD;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd3(Label k9R)
	{
		Label val = (WD = k9R);
	}

	[SpecialName]
	internal virtual Label p3Y()
	{
		return _Label29;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s9R(Label n4W)
	{
		_Label29 = n4W;
	}

	[SpecialName]
	internal virtual Label w9S()
	{
		return _Label30;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2T(Label d4G)
	{
		_Label30 = d4G;
	}

	[SpecialName]
	internal virtual Label m6S()
	{
		return _Label25;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pk9(Label p7C)
	{
		_Label25 = p7C;
	}

	[SpecialName]
	internal virtual Label Zb6()
	{
		return WN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qg6(Label Px9)
	{
		Label val = (WN = Px9);
	}

	[SpecialName]
	internal virtual Label Rp8()
	{
		return _Label23;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng3(Label w9R)
	{
		_Label23 = w9R;
	}

	[SpecialName]
	internal virtual Label o4E()
	{
		return _Label22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8P(Label p7G)
	{
		_Label22 = p7G;
	}

	[SpecialName]
	internal virtual Label i4Z()
	{
		return _Label21;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wr9(Label s5Q)
	{
		_Label21 = s5Q;
	}

	[SpecialName]
	internal virtual Label St4()
	{
		return WL;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ez0(Label Nj8)
	{
		Label val = (WL = Nj8);
	}

	[SpecialName]
	internal virtual Label k2L()
	{
		return WB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hn6(Label y5G)
	{
		Label val = (WB = y5G);
	}

	[SpecialName]
	internal virtual Label g9Y()
	{
		return Wr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6Y(Label q0K)
	{
		Label val = (Wr = q0K);
	}

	[SpecialName]
	internal virtual Label Fb3()
	{
		return _Label17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7R(Label Dk2)
	{
		_Label17 = Dk2;
	}

	[SpecialName]
	internal virtual Label Gf5()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b8T(Label Xc4)
	{
		_Label16 = Xc4;
	}

	[SpecialName]
	internal virtual Label g3Q()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lf6(Label Kq9)
	{
		_Label15 = Kq9;
	}

	[SpecialName]
	internal virtual Label a5H()
	{
		return WJ;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0X(Label t9E)
	{
		Label val = (WJ = t9E);
	}

	[SpecialName]
	internal virtual Label o1E()
	{
		return WE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pp1(Label n9J)
	{
		Label val = (WE = n9J);
	}

	[SpecialName]
	internal virtual Label o8A()
	{
		return WF;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5X(Label q7D)
	{
		Label val = (WF = q7D);
	}

	[SpecialName]
	internal virtual Label Pw0()
	{
		return WG;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5X(Label d0H)
	{
		Label val = (WG = d0H);
	}

	[SpecialName]
	internal virtual Label Ce3()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Na8(Label q3P)
	{
		_Label10 = q3P;
	}

	[SpecialName]
	internal virtual Label Zz3()
	{
		return WI;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9T(Label w2R)
	{
		Label val = (WI = w2R);
	}

	[SpecialName]
	internal virtual Label w6C()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nz3(Label x8X)
	{
		_Label8 = x8X;
	}

	[SpecialName]
	internal virtual Label c1G()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8P(Label Sb2)
	{
		_Label7 = Sb2;
	}

	[SpecialName]
	internal virtual Label Gc9()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt4(Label w2X)
	{
		_Label4 = w2X;
	}

	[SpecialName]
	internal virtual Label d6B()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd6(Label o1C)
	{
		_Label5 = o1C;
	}

	[SpecialName]
	internal virtual GroupBox n1Q()
	{
		return Wz;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8R(GroupBox Xr7)
	{
		GroupBox val = (Wz = Xr7);
	}

	[SpecialName]
	internal virtual TextBox Lf3()
	{
		return _txtAvailable;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rj5(TextBox Tk1)
	{
		_txtAvailable = Tk1;
	}

	[SpecialName]
	internal virtual PictureBox Tw4()
	{
		return Cp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6B(PictureBox Nd9)
	{
		PictureBox val = (Cp = Nd9);
	}

	[SpecialName]
	internal virtual PictureBox j4Y()
	{
		return CM;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn2(PictureBox w0C)
	{
		PictureBox val = (CM = w0C);
	}

	[SpecialName]
	internal virtual PictureBox Rr4()
	{
		return _Available;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s8M(PictureBox q9H)
	{
		_Available = q9H;
	}

	[SpecialName]
	internal virtual Label z7B()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zr1(Label Gy0)
	{
		_Label3 = Gy0;
	}

	[SpecialName]
	internal virtual Label Fe8()
	{
		return Cv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m5A(Label Fj8)
	{
		Label val = (Cv = Fj8);
	}

	[SpecialName]
	internal virtual PictureBox Ys8()
	{
		return _Background;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b9T(PictureBox n7E)
	{
		_Background = n7E;
	}

	[SpecialName]
	internal virtual PictureBox b3E()
	{
		return _NameBox;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k8T(PictureBox k7T)
	{
		_NameBox = k7T;
	}

	[SpecialName]
	internal virtual GroupBox Ki0()
	{
		return _GroupBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8X(GroupBox Lx7)
	{
		_GroupBox3 = Lx7;
	}

	[SpecialName]
	internal virtual Button Bx0()
	{
		return CW;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ca8(Button Lk2)
	{
		EventHandler eventHandler = n7D;
		Button cW = CW;
		if (cW != null)
		{
			((Control)cW).remove_Click(eventHandler);
		}
		Button val = (CW = Lk2);
		cW = CW;
		if (cW != null)
		{
			((Control)cW).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox e2J()
	{
		return _Cover;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lo5(PictureBox b4B)
	{
		_Cover = b4B;
	}

	[SpecialName]
	internal virtual GroupBox w5W()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tm1(GroupBox f7T)
	{
		_GroupBox2 = f7T;
	}

	[SpecialName]
	internal virtual Button Dk5()
	{
		return _btnNew;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw5(Button z0G)
	{
		EventHandler eventHandler = f3P;
		Button btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).remove_Click(eventHandler);
		}
		_btnNew = z0G;
		btnNew = _btnNew;
		if (btnNew != null)
		{
			((Control)btnNew).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Cs0()
	{
		return _btnReset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9X(Button m9A)
	{
		_btnReset = m9A;
	}

	[SpecialName]
	internal virtual Button Yx3()
	{
		return CC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dw1(Button j3T)
	{
		EventHandler eventHandler = Nr0;
		Button cC = CC;
		if (cC != null)
		{
			((Control)cC).remove_Click(eventHandler);
		}
		Button val = (CC = j3T);
		cC = CC;
		if (cC != null)
		{
			((Control)cC).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Rw4()
	{
		return _txtFirstName;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Se3(TextBox j7E)
	{
		_txtFirstName = j7E;
	}

	[SpecialName]
	internal virtual TextBox Qe1()
	{
		return CX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Af0(TextBox f5G)
	{
		TextBox val = (CX = f5G);
	}

	[SpecialName]
	internal virtual Label m1K()
	{
		return _Label60;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lx1(Label Yi3)
	{
		_Label60 = Yi3;
	}

	[SpecialName]
	internal virtual Label a0G()
	{
		return _Label59;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hr2(Label q8A)
	{
		_Label59 = q8A;
	}

	[SpecialName]
	internal virtual GroupBox Dw7()
	{
		return CO;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ti1(GroupBox Jb7)
	{
		GroupBox val = (CO = Jb7);
	}

	[SpecialName]
	internal virtual Button k3C()
	{
		return Ck;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf5(Button d5J)
	{
		EventHandler eventHandler = m8T;
		Button ck = Ck;
		if (ck != null)
		{
			((Control)ck).remove_Click(eventHandler);
		}
		Button val = (Ck = d5J);
		ck = Ck;
		if (ck != null)
		{
			((Control)ck).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ai1()
	{
		return _btnCalculateChange;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q0S(Button Pp5)
	{
		EventHandler eventHandler = Sw6;
		Button btnCalculateChange = _btnCalculateChange;
		if (btnCalculateChange != null)
		{
			((Control)btnCalculateChange).remove_Click(eventHandler);
		}
		_btnCalculateChange = Pp5;
		btnCalculateChange = _btnCalculateChange;
		if (btnCalculateChange != null)
		{
			((Control)btnCalculateChange).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Dm0()
	{
		return Ct;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9A(TextBox Ks9)
	{
		TextBox val = (Ct = Ks9);
	}

	[SpecialName]
	internal virtual TextBox Mj9()
	{
		return _txtTotalPayment;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5A(TextBox Bn3)
	{
		_txtTotalPayment = Bn3;
	}

	[SpecialName]
	internal virtual TextBox r1Q()
	{
		return _txtTotalCost;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6B(TextBox Zd0)
	{
		_txtTotalCost = Zd0;
	}

	[SpecialName]
	internal virtual TextBox i5W()
	{
		return CH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void At3(TextBox Rk7)
	{
		TextBox val = (CH = Rk7);
	}

	[SpecialName]
	internal virtual Label b0K()
	{
		return Cq;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6J(Label z8D)
	{
		Label val = (Cq = z8D);
	}

	[SpecialName]
	internal virtual Label y3H()
	{
		return _Label64;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz1(Label Ed2)
	{
		_Label64 = Ed2;
	}

	[SpecialName]
	internal virtual Label t2Z()
	{
		return _Label61;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ao4(Label Cr7)
	{
		_Label61 = Cr7;
	}

	[SpecialName]
	internal virtual Label o0R()
	{
		return _Label62;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2C(Label Jg9)
	{
		_Label62 = Jg9;
	}

	private void m8T(object sender, EventArgs e)
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
				if (val != null && val.get_Image() == CS)
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
				if (val != null && val.get_Image() == CS)
				{
					int num = Conversions.ToInteger(Strings.Mid(((Control)val).get_Name(), 11));
					string commandText = "INSERT INTO tblBookings (Customer, Seat) VALUES ('" + Qe1().get_Text() + "'," + Conversions.ToString(num) + " )";
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
		customerID = Qe1().get_Text();
		firstName = Rw4().get_Text();
		val2.Close();
		Mt0();
		MessageBox.Show("The Booking Was Successfull!", "Success", (MessageBoxButtons)0, (MessageBoxIcon)64);
	}

	private void Sw6(object sender, EventArgs e)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		totalPayment = Conversions.ToInteger(Mj9().get_Text());
		if (totalPayment >= totalCost)
		{
			change = checked(totalPayment - totalCost);
			Dm0().set_Text("$" + change);
		}
		else
		{
			MessageBox.Show("Please make enough payment to proceed", "Error", (MessageBoxButtons)0, (MessageBoxIcon)48);
			((TextBoxBase)Mj9()).Clear();
		}
	}

	private void a1D(object sender, EventArgs e)
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
					((PictureBox)val).set_Image((Image)Cu);
					val.add_Click((EventHandler)No7);
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
		CA = 0;
		provisionalSeats = 0;
		Mt0();
	}

	private void n7D(object sender, EventArgs e)
	{
	}

	private void Nr0(object sender, EventArgs e)
	{
	}

	private void f3P(object sender, EventArgs e)
	{
	}

	public void Mt0()
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
			availableSeats = 160 - CA;
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
					CA++;
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
			i7W3().set_Text(Conversions.ToString(CA));
			Lf3().set_Text(Conversions.ToString(availableSeats));
			Ta92().set_Text(Conversions.ToString(provisionalSeats));
			z8Y();
		}
	}

	internal static byte[] g0J(byte[] Gk5, byte[] Pr0, int e0B, int Ht4)
	{
		int num = checked(Gk5.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			Gk5[i] = (byte)(Gk5[i] ^ checked((byte)(Pr0[unchecked(i % Pr0.Length)] ^ ((i + unchecked(e0B % Pr0.Length)) & e0B))));
		}
		return Gk5;
	}

	private void No7(object sender, EventArgs e)
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
			if (((PictureBox)sender).get_Image() == Cu)
			{
				((PictureBox)sender).set_Image((Image)CS);
				provisionalSeats++;
				availableSeats--;
			}
			else if (((PictureBox)sender).get_Image() == CS)
			{
				((PictureBox)sender).set_Image((Image)Cu);
				provisionalSeats--;
				availableSeats++;
			}
			Lf3().set_Text(Conversions.ToString(availableSeats));
			Ta92().set_Text(Conversions.ToString(provisionalSeats));
			seats = provisionalSeats;
			i5W().set_Text(Conversions.ToString(seats));
			totalCost = provisionalSeats * 5;
			r1Q().set_Text("$" + totalCost);
		}
	}

	public void z8Y()
	{
		((TextBoxBase)Mj9()).Clear();
		((TextBoxBase)Rw4()).Clear();
		((TextBoxBase)r1Q()).Clear();
		((TextBoxBase)Dm0()).Clear();
		((TextBoxBase)i5W()).Clear();
		((TextBoxBase)Qe1()).Clear();
	}

	static d2QN()
	{
		d2QN.F = new char[3858];
		char[] array = new char[8];
		array[6] = '\u1b3d';
		array[3] = 'ᧈ';
		array[5] = '\u1b3e';
		array[0] = '\u09e5';
		array[4] = '?';
		array[1] = '㙲';
		array[7] = '⪹';
		array[2] = '᭹';
		d2QN.J = new string[295];
		P = array;
	}
}
