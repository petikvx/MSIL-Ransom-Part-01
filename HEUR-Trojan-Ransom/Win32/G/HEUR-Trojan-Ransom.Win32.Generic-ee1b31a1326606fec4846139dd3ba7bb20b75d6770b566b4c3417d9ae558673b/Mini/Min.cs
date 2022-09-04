using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using t7PUcDsYsBK8LirnmT;

namespace Mini;

[DesignerGenerated]
public class Min : Form
{
	private static List<WeakReference> zaGXn1bX3 = new List<WeakReference>();

	private IContainer JMkcFETNj;

	[AccessedThroughProperty("CheckBox1")]
	private CheckBox IQduZdiON;

	[AccessedThroughProperty("CheckBox2")]
	private CheckBox C4SmjSsid;

	[AccessedThroughProperty("Button1")]
	private Button WwMqxArvN;

	[AccessedThroughProperty("Button2")]
	private Button aEB5Kjo7b;

	[AccessedThroughProperty("Label1")]
	private Label mlx8cqvUT;

	[AccessedThroughProperty("Label2")]
	private Label vuyiP0Rk1;

	[AccessedThroughProperty("LinkLabel1")]
	private LinkLabel ygMes6CVS;

	[AccessedThroughProperty("PictureBox1")]
	private PictureBox DwdhigxE9;

	[AccessedThroughProperty("PictureBox2")]
	private PictureBox coENW0v0o;

	[AccessedThroughProperty("RadioButton1")]
	private RadioButton x3fBoN6Ag;

	[AccessedThroughProperty("RadioButton2")]
	private RadioButton vx2kiut82;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar aUOoHUryB;

	[AccessedThroughProperty("TextBox1")]
	private TextBox ShffQ4cWp;

	[DebuggerNonUserCode]
	public Min()
	{
		while (true)
		{
			C1y66hl6kV23N0gKfq(this);
			rB1CyosopGxhZwmnH3();
			if (wn05gNtAx9NQNMHSoq())
			{
				goto IL_005e;
			}
			goto IL_004b;
			IL_004b:
			((Form)this).add_Load((EventHandler)goLUIIFrq);
			goto IL_005e;
			IL_005e:
			while (true)
			{
				IL_005e_2:
				mw6vq1mquPFUj0UUv7(this);
				while (true)
				{
					M5gLGLT8htnNrOUtjQ(this);
					if (!wn05gNtAx9NQNMHSoq())
					{
						switch (6)
						{
						case 3:
							break;
						default:
							continue;
						case 0:
						case 1:
							goto IL_004b;
						case 2:
						case 5:
							goto IL_005e_2;
						case 6:
							return;
						}
					}
					break;
				}
				break;
			}
		}
	}

	[DebuggerNonUserCode]
	private static void akt41ZTJV(object object_0)
	{
		rB1CyosopGxhZwmnH3();
		List<WeakReference> list = default(List<WeakReference>);
		if (!wn05gNtAx9NQNMHSoq())
		{
			list = zaGXn1bX3;
		}
		rgnAkQEr35lTWqjP7r(list);
		checked
		{
			try
			{
				bool flag = jFx9xS8TZ8MFaR3n9A(zaGXn1bX3) == MVQGWl9ofQQRFbrQui(zaGXn1bX3);
				_ = 1;
				if (wn05gNtAx9NQNMHSoq())
				{
					if (wn05gNtAx9NQNMHSoq())
					{
					}
					switch (6)
					{
					case 0:
					case 2:
						break;
					case 5:
						goto IL_008e;
					case 7:
						goto IL_0090;
					case 10:
						goto IL_00a2;
					default:
						goto IL_00ab;
					case 3:
					case 6:
					case 9:
						goto IL_00e6;
					case 11:
						goto IL_00ef;
					case 1:
						goto IL_0106;
					case 4:
						goto IL_011a;
					case 12:
						return;
					}
				}
				if (flag)
				{
					goto IL_008e;
				}
				goto IL_011a;
				IL_011a:
				zaGXn1bX3.Add(new WeakReference(PsI3KKLgx9qqT5P6Of(object_0)));
				return;
				IL_00ab:
				int num = num + 1;
				goto IL_00af;
				IL_00a2:
				int num2 = default(int);
				if (num2 != num)
				{
					zaGXn1bX3[num] = zaGXn1bX3[num2];
				}
				goto IL_00ab;
				IL_008e:
				num = 0;
				goto IL_0090;
				IL_0090:
				int num3 = jFx9xS8TZ8MFaR3n9A(zaGXn1bX3) - 1;
				num2 = 0;
				goto IL_00e6;
				IL_00e6:
				int num4 = num2;
				int num5 = num3;
				if (num4 <= num5)
				{
					WeakReference object_ = zaGXn1bX3[num2];
					if (flag = pWO40R44MZOIV3f0k2(object_))
					{
						goto IL_00a2;
					}
					goto IL_00af;
				}
				goto IL_00ef;
				IL_00ef:
				zaGXn1bX3.RemoveRange(num, jFx9xS8TZ8MFaR3n9A(zaGXn1bX3) - num);
				goto IL_0106;
				IL_0106:
				zaGXn1bX3.Capacity = zaGXn1bX3.Count;
				goto IL_011a;
				IL_00af:
				num2++;
				goto IL_00e6;
			}
			finally
			{
				Monitor.Exit(list);
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			int num;
			if (disposing)
			{
				if (JMkcFETNj != null)
				{
					num = 1;
					goto IL_003e;
				}
				if (wn05gNtAx9NQNMHSoq())
				{
					goto IL_0052;
				}
				switch (4)
				{
				case 4:
					break;
				case 1:
				case 3:
					goto IL_004c;
				default:
					goto IL_0052;
				case 5:
					return;
				}
			}
			num = 0;
			goto IL_003e;
			IL_004c:
			bool flag = default(bool);
			if (flag)
			{
				goto IL_0052;
			}
			return;
			IL_003e:
			flag = (byte)num != 0;
			wn05gNtAx9NQNMHSoq();
			if (rB1CyosopGxhZwmnH3())
			{
				goto IL_004c;
			}
			goto IL_0052;
			IL_0052:
			JMkcFETNj.Dispose();
		}
		finally
		{
			Pptb6PBEyItasEjLIZ(this, disposing);
		}
	}

	[DebuggerStepThrough]
	private void vfMrd1o8a()
	{
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Expected O, but got Unknown
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Expected O, but got Unknown
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Expected O, but got Unknown
		//IL_067f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_07e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f2: Expected O, but got Unknown
		//IL_07f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_07fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Expected O, but got Unknown
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_0813: Expected O, but got Unknown
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_0833: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		while (true)
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(RyEZO2NJ8jPoI1fOdh(typeof(Min).TypeHandle));
			rB1CyosopGxhZwmnH3();
			if (!wn05gNtAx9NQNMHSoq())
			{
				while (true)
				{
					IL_083f:
					q9LlHJCuUw(new CheckBox());
					while (true)
					{
						IL_0832:
						yqpnMuX94IsCQQV6d2(this, (object)new CheckBox());
						while (true)
						{
							IL_07dc:
							xQYwGdbwUM3kc61KMp(this, (object)new Button());
							zVmmSx5fZNLGwvyM8M(this, (object)new Button());
							jev7rEgKmj5INQOR8Q(this, (object)new Label());
							i1Hlnq1NciFjHKesja(this, (object)new Label());
							YjTj3XAxbfM7C5ik6a(this, (object)new LinkLabel());
							QcryK8WuIyIne3oksG(this, (object)new PictureBox());
							int num = 10;
							if (!wn05gNtAx9NQNMHSoq())
							{
							}
							while (true)
							{
								switch (num)
								{
								case 45:
									break;
								case 70:
								{
									object obj8 = wPhJwbcqeDrjTmEk41v(this);
									Size clientSize = new Size(90, 17);
									((Control)obj8).set_Size(clientSize);
									((Control)wPhJwbcqeDrjTmEk41v(this)).set_TabIndex(9);
									wO9R7pcVtNJnLnTXUeE(wPhJwbcqeDrjTmEk41v(this), bool_0: true);
									goto case 20;
								}
								case 20:
									uxCPYUcUX5IeTsu3ILI(wPhJwbcqeDrjTmEk41v(this), "RadioButton1");
									((ButtonBase)qtelQEbo1D()).set_UseVisualStyleBackColor(true);
									goto case 11;
								case 11:
									((ButtonBase)cnUlxIcY36()).set_AutoSize(true);
									goto case 2;
								case 2:
								{
									object object_17 = hyESG3cv1akgFfflB24(this);
									Point point_ = new Point(182, 273);
									UE5jaGcfuOMGE9L9lX9(object_17, point_);
									jJ2n84cOKJmtfB5o2Zi(cnUlxIcY36(), "RadioButton2");
									goto case 18;
								}
								case 18:
								{
									object object_18 = hyESG3cv1akgFfflB24(this);
									Size clientSize = new Size(90, 17);
									amoCSAcjykEBIl5lZsN(object_18, clientSize);
									goto case 40;
								}
								case 40:
									t3vUvwcK7eZIgXCbVsL(hyESG3cv1akgFfflB24(this), 10);
									goto case 65;
								case 65:
									wO9R7pcVtNJnLnTXUeE(cnUlxIcY36(), bool_0: true);
									((ButtonBase)hyESG3cv1akgFfflB24(this)).set_Text("RadioButton2");
									num = 41;
									if (!wn05gNtAx9NQNMHSoq())
									{
										continue;
									}
									goto case 41;
								case 41:
									((ButtonBase)hyESG3cv1akgFfflB24(this)).set_UseVisualStyleBackColor(true);
									num = 49;
									if (wn05gNtAx9NQNMHSoq())
									{
									}
									continue;
								case 69:
									((ButtonBase)B9L40ocC82WVEvQ00xc(this)).set_UseVisualStyleBackColor(true);
									goto case 43;
								case 43:
									Q3AlN76YmR().set_AutoSize(true);
									goto case 23;
								case 23:
								{
									Label object_9 = Q3AlN76YmR();
									Point point_ = new Point(172, 97);
									UE5jaGcfuOMGE9L9lX9(object_9, point_);
									((Control)Q3AlN76YmR()).set_Name("Label1");
									object obj2 = jkesg4co50Cpn08sD4Q(this);
									Size clientSize = new Size(39, 13);
									((Control)obj2).set_Size(clientSize);
									goto case 5;
								}
								case 5:
									t3vUvwcK7eZIgXCbVsL(jkesg4co50Cpn08sD4Q(this), 4);
									goto case 16;
								case 16:
									nwROrtchiUf2y9kR63M(jkesg4co50Cpn08sD4Q(this), "Label1");
									goto case 66;
								case 66:
									kcYJPdc78agJOdbhWaw(nPOMxJcQRh6LxdH1Fs6(this), bool_0: true);
									goto case 47;
								case 47:
								{
									Label obj3 = i2hl3nDBei();
									Point point_ = new Point(60, 202);
									((Control)obj3).set_Location(point_);
									jJ2n84cOKJmtfB5o2Zi(nPOMxJcQRh6LxdH1Fs6(this), "Label2");
									object object_10 = nPOMxJcQRh6LxdH1Fs6(this);
									Size clientSize = new Size(39, 13);
									amoCSAcjykEBIl5lZsN(object_10, clientSize);
									t3vUvwcK7eZIgXCbVsL(nPOMxJcQRh6LxdH1Fs6(this), 5);
									nwROrtchiUf2y9kR63M(nPOMxJcQRh6LxdH1Fs6(this), "Label2");
									goto case 62;
								}
								case 62:
								{
									kcYJPdc78agJOdbhWaw(xrdlkk3KLr(), bool_0: true);
									LinkLabel object_11 = xrdlkk3KLr();
									Point point_ = new Point(113, 133);
									UE5jaGcfuOMGE9L9lX9(object_11, point_);
									jJ2n84cOKJmtfB5o2Zi(V5PQDOcxRIhysvE0pih(this), "LinkLabel1");
									object object_12 = V5PQDOcxRIhysvE0pih(this);
									Size clientSize = new Size(59, 13);
									amoCSAcjykEBIl5lZsN(object_12, clientSize);
									goto case 60;
								}
								case 60:
								{
									t3vUvwcK7eZIgXCbVsL(V5PQDOcxRIhysvE0pih(this), 6);
									((Label)V5PQDOcxRIhysvE0pih(this)).set_TabStop(true);
									UYdeoQcD892CUEBTn04(V5PQDOcxRIhysvE0pih(this), "LinkLabel1");
									PictureBox object_13 = OITlbhxC39();
									Point point_ = new Point(48, 110);
									UE5jaGcfuOMGE9L9lX9(object_13, point_);
									jJ2n84cOKJmtfB5o2Zi(hBMbDjzLvRiyP2x5ZG(this), "PictureBox1");
									goto case 31;
								}
								case 31:
								{
									object object_14 = hBMbDjzLvRiyP2x5ZG(this);
									Size clientSize = new Size(100, 50);
									amoCSAcjykEBIl5lZsN(object_14, clientSize);
									goto case 42;
								}
								case 42:
									UKb4xxcFVQJcRg46ej2(hBMbDjzLvRiyP2x5ZG(this), 7);
									goto case 25;
								case 25:
								{
									((PictureBox)hBMbDjzLvRiyP2x5ZG(this)).set_TabStop(false);
									PictureBox obj4 = IYplrYbhi1();
									Point point_ = new Point(47, 247);
									((Control)obj4).set_Location(point_);
									num = 4;
									if (rB1CyosopGxhZwmnH3())
									{
										continue;
									}
									goto case 54;
								}
								case 54:
								{
									PictureBox obj5 = IYplrYbhi1();
									Size clientSize = new Size(100, 50);
									((Control)obj5).set_Size(clientSize);
									((PictureBox)GhjxqCccxiF6BiIiEoL(this)).set_TabIndex(8);
									((PictureBox)GhjxqCccxiF6BiIiEoL(this)).set_TabStop(false);
									TcTeHlc2I0jWbTBw40U(wPhJwbcqeDrjTmEk41v(this), bool_0: true);
									goto default;
								}
								default:
								{
									object obj6 = wPhJwbcqeDrjTmEk41v(this);
									Point point_ = new Point(183, 292);
									((Control)obj6).set_Location(point_);
									goto case 8;
								}
								case 8:
									jJ2n84cOKJmtfB5o2Zi(wPhJwbcqeDrjTmEk41v(this), "RadioButton1");
									num = 70;
									if (!wn05gNtAx9NQNMHSoq())
									{
										continue;
									}
									goto case 53;
								case 53:
									jJ2n84cOKJmtfB5o2Zi(yrHlgosgus(), "Button1");
									goto case 33;
								case 33:
								{
									Button obj7 = yrHlgosgus();
									Size clientSize = new Size(75, 23);
									((Control)obj7).set_Size(clientSize);
									((Control)gvPECScRvmnHgITofaT(this)).set_TabIndex(2);
									uxCPYUcUX5IeTsu3ILI(gvPECScRvmnHgITofaT(this), "Button1");
									QS3HLccki08i8eRayyA(yrHlgosgus(), bool_0: true);
									object object_15 = B9L40ocC82WVEvQ00xc(this);
									Point point_ = new Point(310, 191);
									UE5jaGcfuOMGE9L9lX9(object_15, point_);
									goto case 24;
								}
								case 24:
									jJ2n84cOKJmtfB5o2Zi(B9L40ocC82WVEvQ00xc(this), "Button2");
									goto case 59;
								case 59:
								{
									Button object_16 = sN9lAbF8Cq();
									Size clientSize = new Size(75, 23);
									amoCSAcjykEBIl5lZsN(object_16, clientSize);
									goto case 9;
								}
								case 9:
									t3vUvwcK7eZIgXCbVsL(B9L40ocC82WVEvQ00xc(this), 3);
									goto case 37;
								case 37:
									uxCPYUcUX5IeTsu3ILI(B9L40ocC82WVEvQ00xc(this), "Button2");
									num = 69;
									if (wn05gNtAx9NQNMHSoq())
									{
									}
									continue;
								case 56:
									t3vUvwcK7eZIgXCbVsL(gEdro2cGMDHdRhLjJ4Q(this), 0);
									goto case 48;
								case 38:
								{
									CheckBox object_7 = GA9lOInlER();
									Point point_ = new Point(305, 97);
									UE5jaGcfuOMGE9L9lX9(object_7, point_);
									goto case 21;
								}
								case 21:
									((Control)LWqiE2cJALauOQIjv9K(this)).set_Name("CheckBox2");
									goto case 50;
								case 50:
								{
									CheckBox object_8 = GA9lOInlER();
									Size clientSize = new Size(81, 17);
									amoCSAcjykEBIl5lZsN(object_8, clientSize);
									((Control)GA9lOInlER()).set_TabIndex(1);
									goto case 35;
								}
								case 35:
								{
									((ButtonBase)GA9lOInlER()).set_Text("CheckBox2");
									((ButtonBase)LWqiE2cJALauOQIjv9K(this)).set_UseVisualStyleBackColor(true);
									Button obj = yrHlgosgus();
									Point point_ = new Point(305, 144);
									((Control)obj).set_Location(point_);
									num = 53;
									if (rB1CyosopGxhZwmnH3())
									{
										continue;
									}
									goto case 48;
								}
								case 48:
									uxCPYUcUX5IeTsu3ILI(gEdro2cGMDHdRhLjJ4Q(this), "CheckBox1");
									((ButtonBase)NhSlMAI08i()).set_UseVisualStyleBackColor(true);
									TcTeHlc2I0jWbTBw40U(GA9lOInlER(), bool_0: true);
									goto case 38;
								case 49:
								{
									object object_3 = N8tB4Yc3oPUyq424w5h(this);
									Point point_ = new Point(168, 257);
									UE5jaGcfuOMGE9L9lX9(object_3, point_);
									jJ2n84cOKJmtfB5o2Zi(N8tB4Yc3oPUyq424w5h(this), "ProgressBar1");
									goto case 7;
								}
								case 7:
								{
									object object_4 = N8tB4Yc3oPUyq424w5h(this);
									Size clientSize = new Size(289, 14);
									amoCSAcjykEBIl5lZsN(object_4, clientSize);
									goto case 6;
								}
								case 6:
								{
									((Control)g1FlLVHen4()).set_TabIndex(11);
									TextBox object_5 = iCrlJ5T0Bj();
									Point point_ = new Point(225, 220);
									UE5jaGcfuOMGE9L9lX9(object_5, point_);
									hj2uZRcaVusRvn72Ojg(WQ8we5cdU5JNUDydajW(this), bool_0: true);
									goto case 28;
								}
								case 28:
								{
									((Control)iCrlJ5T0Bj()).set_Name("TextBox1");
									object object_6 = WQ8we5cdU5JNUDydajW(this);
									Size clientSize = new Size(209, 31);
									amoCSAcjykEBIl5lZsN(object_6, clientSize);
									num = 26;
									if (rB1CyosopGxhZwmnH3())
									{
										continue;
									}
									goto case 71;
								}
								case 34:
									H6IBWIPFM1dTiOLt2q(this, (object)new RadioButton());
									iOqgtwyWFBWHQnvPFX(this, (object)new ProgressBar());
									wEBo93elkSBo1bob4B(this, (object)new TextBox());
									num = 14;
									if (rB1CyosopGxhZwmnH3())
									{
										continue;
									}
									goto IL_093c;
								case 29:
								{
									UXxZ0Zciu1g5xvFTDtB(GhjxqCccxiF6BiIiEoL(this));
									gNElQvcwrXLa3g9GHDi(this);
									TcTeHlc2I0jWbTBw40U(NhSlMAI08i(), bool_0: true);
									CheckBox object_2 = NhSlMAI08i();
									Point point_ = new Point(306, 54);
									UE5jaGcfuOMGE9L9lX9(object_2, point_);
									num = 27;
									if (rB1CyosopGxhZwmnH3())
									{
										continue;
									}
									goto IL_096f;
								}
								case 27:
									jJ2n84cOKJmtfB5o2Zi(gEdro2cGMDHdRhLjJ4Q(this), "CheckBox1");
									goto case 0;
								case 0:
								{
									CheckBox object_ = NhSlMAI08i();
									Size clientSize = new Size(81, 17);
									amoCSAcjykEBIl5lZsN(object_, clientSize);
									goto case 56;
								}
								case 14:
									UXxZ0Zciu1g5xvFTDtB(hBMbDjzLvRiyP2x5ZG(this));
									goto case 29;
								case 10:
									IswYb5p1vBRuNss8T7(this, (object)new PictureBox());
									QWElKGCr41(new RadioButton());
									goto case 34;
								case 4:
									jJ2n84cOKJmtfB5o2Zi(IYplrYbhi1(), "PictureBox2");
									goto case 54;
								case 64:
									goto IL_07dc;
								case 15:
									goto IL_0832;
								case 1:
								case 46:
									goto IL_083f;
								case 26:
									t3vUvwcK7eZIgXCbVsL(WQ8we5cdU5JNUDydajW(this), 12);
									goto case 52;
								case 52:
								{
									SizeF sizeF_ = new SizeF(6f, 13f);
									a0ALC8c0DeLkBlv9b1T(this, sizeF_);
									goto case 19;
								}
								case 19:
									WQGsIkcYVMqASI5RHyx(this, (AutoScaleMode)1);
									goto case 36;
								case 36:
								{
									Size clientSize = new Size(294, 39);
									((Form)this).set_ClientSize(clientSize);
									goto case 58;
								}
								case 58:
									YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), WQ8we5cdU5JNUDydajW(this));
									goto case 13;
								case 13:
									((ControlCollection)qW9pqXcIauNc6tPAdbi(this)).Add((Control)N8tB4Yc3oPUyq424w5h(this));
									goto case 71;
								case 71:
									YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), cnUlxIcY36());
									goto IL_08d6;
								case 12:
								case 57:
									goto IL_08d6;
								case 32:
									goto IL_08e7;
								case 44:
									goto IL_0909;
								case 63:
									goto IL_091a;
								case 30:
									goto IL_093c;
								case 61:
									goto IL_094d;
								case 39:
									goto IL_096f;
								case 68:
									goto IL_0996;
								case 3:
									goto IL_09a1;
								case 55:
									goto IL_09b7;
								case 51:
									goto IL_09be;
								case 17:
									goto IL_09d4;
								case 22:
									goto end_IL_0001;
								case 72:
									return;
								}
								break;
							}
							break;
						}
						break;
					}
					break;
				}
				continue;
			}
			goto IL_08d6;
			IL_09d4:
			((Control)this).ResumeLayout(false);
			break;
			IL_08d6:
			YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), qtelQEbo1D());
			goto IL_08e7;
			IL_08e7:
			YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), GhjxqCccxiF6BiIiEoL(this));
			YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), hBMbDjzLvRiyP2x5ZG(this));
			goto IL_0909;
			IL_0909:
			YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), V5PQDOcxRIhysvE0pih(this));
			goto IL_091a;
			IL_091a:
			YGUSjZcn5hB7jQy9TsP(((Control)this).get_Controls(), i2hl3nDBei());
			YGUSjZcn5hB7jQy9TsP(qW9pqXcIauNc6tPAdbi(this), jkesg4co50Cpn08sD4Q(this));
			goto IL_093c;
			IL_093c:
			((Control)this).get_Controls().Add((Control)B9L40ocC82WVEvQ00xc(this));
			goto IL_094d;
			IL_094d:
			((ControlCollection)qW9pqXcIauNc6tPAdbi(this)).Add((Control)gvPECScRvmnHgITofaT(this));
			YGUSjZcn5hB7jQy9TsP(((Control)this).get_Controls(), GA9lOInlER());
			goto IL_096f;
			IL_096f:
			((ControlCollection)qW9pqXcIauNc6tPAdbi(this)).Add((Control)gEdro2cGMDHdRhLjJ4Q(this));
			((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
			goto IL_0996;
			IL_0996:
			((Control)this).set_Name("Min");
			goto IL_09a1;
			IL_09a1:
			cT1cnkcr1e5rQQxMdUI(this, 0.01);
			((Form)this).set_ShowInTaskbar(false);
			goto IL_09b7;
			IL_09b7:
			((Form)this).set_WindowState((FormWindowState)1);
			goto IL_09be;
			IL_09be:
			PRMJqfc65w5NO3tC8cO(OITlbhxC39());
			PRMJqfc65w5NO3tC8cO(IYplrYbhi1());
			goto IL_09d4;
			continue;
			end_IL_0001:
			break;
		}
		((Control)this).PerformLayout();
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual CheckBox NhSlMAI08i()
	{
		return IQduZdiON;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void q9LlHJCuUw(CheckBox WithEventsValue)
	{
		IQduZdiON = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual CheckBox GA9lOInlER()
	{
		return C4SmjSsid;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void pmJldYnhoO(CheckBox WithEventsValue)
	{
		C4SmjSsid = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Button yrHlgosgus()
	{
		return WwMqxArvN;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void xM9lUHdc5l(Button WithEventsValue)
	{
		WwMqxArvN = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Button sN9lAbF8Cq()
	{
		return aEB5Kjo7b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void ohsl6cXRld(Button WithEventsValue)
	{
		aEB5Kjo7b = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label Q3AlN76YmR()
	{
		return mlx8cqvUT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void wOnluFN98t(Label WithEventsValue)
	{
		mlx8cqvUT = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual Label i2hl3nDBei()
	{
		return vuyiP0Rk1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vLBlTpDrVU(Label WithEventsValue)
	{
		vuyiP0Rk1 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual LinkLabel xrdlkk3KLr()
	{
		return ygMes6CVS;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void lvBl16PQRU(LinkLabel WithEventsValue)
	{
		ygMes6CVS = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual PictureBox OITlbhxC39()
	{
		return DwdhigxE9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void hDxlXuLUg7(PictureBox WithEventsValue)
	{
		DwdhigxE9 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual PictureBox IYplrYbhi1()
	{
		return coENW0v0o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void zi9l8j9YLK(PictureBox WithEventsValue)
	{
		coENW0v0o = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual RadioButton qtelQEbo1D()
	{
		return x3fBoN6Ag;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void QWElKGCr41(RadioButton WithEventsValue)
	{
		x3fBoN6Ag = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual RadioButton cnUlxIcY36()
	{
		return vx2kiut82;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void QN4ls8etBr(RadioButton WithEventsValue)
	{
		vx2kiut82 = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual ProgressBar g1FlLVHen4()
	{
		return aUOoHUryB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void FJolaEKXe1(ProgressBar WithEventsValue)
	{
		aUOoHUryB = WithEventsValue;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox iCrlJ5T0Bj()
	{
		return ShffQ4cWp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void dJolPPop3y(TextBox WithEventsValue)
	{
		ShffQ4cWp = WithEventsValue;
	}

	private void goLUIIFrq(object sender, EventArgs e)
	{
		jUEn8WcSm69aHvAJcMC();
	}

	internal static bool rB1CyosopGxhZwmnH3()
	{
		return true;
	}

	internal static bool wn05gNtAx9NQNMHSoq()
	{
		return false;
	}

	internal static void C1y66hl6kV23N0gKfq(object object_0)
	{
		((Form)object_0)._002Ector();
	}

	internal static void mw6vq1mquPFUj0UUv7(object object_0)
	{
		akt41ZTJV(object_0);
	}

	internal static void M5gLGLT8htnNrOUtjQ(object object_0)
	{
		((Min)object_0).vfMrd1o8a();
	}

	internal static void rgnAkQEr35lTWqjP7r(object object_0)
	{
		Monitor.Enter(object_0);
	}

	internal static int jFx9xS8TZ8MFaR3n9A(object object_0)
	{
		return ((List<WeakReference>)object_0).Count;
	}

	internal static int MVQGWl9ofQQRFbrQui(object object_0)
	{
		return ((List<WeakReference>)object_0).Capacity;
	}

	internal static bool pWO40R44MZOIV3f0k2(object object_0)
	{
		return ((WeakReference)object_0).IsAlive;
	}

	internal static object PsI3KKLgx9qqT5P6Of(object object_0)
	{
		return RuntimeHelpers.GetObjectValue(object_0);
	}

	internal static void Pptb6PBEyItasEjLIZ(object object_0, bool bool_0)
	{
		((Form)object_0).Dispose(bool_0);
	}

	internal static Type RyEZO2NJ8jPoI1fOdh(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void yqpnMuX94IsCQQV6d2(object object_0, object object_1)
	{
		((Min)object_0).pmJldYnhoO((CheckBox)object_1);
	}

	internal static void xQYwGdbwUM3kc61KMp(object object_0, object object_1)
	{
		((Min)object_0).xM9lUHdc5l((Button)object_1);
	}

	internal static void zVmmSx5fZNLGwvyM8M(object object_0, object object_1)
	{
		((Min)object_0).ohsl6cXRld((Button)object_1);
	}

	internal static void jev7rEgKmj5INQOR8Q(object object_0, object object_1)
	{
		((Min)object_0).wOnluFN98t((Label)object_1);
	}

	internal static void i1Hlnq1NciFjHKesja(object object_0, object object_1)
	{
		((Min)object_0).vLBlTpDrVU((Label)object_1);
	}

	internal static void YjTj3XAxbfM7C5ik6a(object object_0, object object_1)
	{
		((Min)object_0).lvBl16PQRU((LinkLabel)object_1);
	}

	internal static void QcryK8WuIyIne3oksG(object object_0, object object_1)
	{
		((Min)object_0).hDxlXuLUg7((PictureBox)object_1);
	}

	internal static void IswYb5p1vBRuNss8T7(object object_0, object object_1)
	{
		((Min)object_0).zi9l8j9YLK((PictureBox)object_1);
	}

	internal static void H6IBWIPFM1dTiOLt2q(object object_0, object object_1)
	{
		((Min)object_0).QN4ls8etBr((RadioButton)object_1);
	}

	internal static void iOqgtwyWFBWHQnvPFX(object object_0, object object_1)
	{
		((Min)object_0).FJolaEKXe1((ProgressBar)object_1);
	}

	internal static void wEBo93elkSBo1bob4B(object object_0, object object_1)
	{
		((Min)object_0).dJolPPop3y((TextBox)object_1);
	}

	internal static object hBMbDjzLvRiyP2x5ZG(object object_0)
	{
		return ((Min)object_0).OITlbhxC39();
	}

	internal static void UXxZ0Zciu1g5xvFTDtB(object object_0)
	{
		((ISupportInitialize)object_0).BeginInit();
	}

	internal static object GhjxqCccxiF6BiIiEoL(object object_0)
	{
		return ((Min)object_0).IYplrYbhi1();
	}

	internal static void gNElQvcwrXLa3g9GHDi(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static void TcTeHlc2I0jWbTBw40U(object object_0, bool bool_0)
	{
		((ButtonBase)object_0).set_AutoSize(bool_0);
	}

	internal static void UE5jaGcfuOMGE9L9lX9(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static object gEdro2cGMDHdRhLjJ4Q(object object_0)
	{
		return ((Min)object_0).NhSlMAI08i();
	}

	internal static void jJ2n84cOKJmtfB5o2Zi(object object_0, object object_1)
	{
		((Control)object_0).set_Name((string)object_1);
	}

	internal static void amoCSAcjykEBIl5lZsN(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void t3vUvwcK7eZIgXCbVsL(object object_0, int int_0)
	{
		((Control)object_0).set_TabIndex(int_0);
	}

	internal static void uxCPYUcUX5IeTsu3ILI(object object_0, object object_1)
	{
		((ButtonBase)object_0).set_Text((string)object_1);
	}

	internal static object LWqiE2cJALauOQIjv9K(object object_0)
	{
		return ((Min)object_0).GA9lOInlER();
	}

	internal static object gvPECScRvmnHgITofaT(object object_0)
	{
		return ((Min)object_0).yrHlgosgus();
	}

	internal static void QS3HLccki08i8eRayyA(object object_0, bool bool_0)
	{
		((ButtonBase)object_0).set_UseVisualStyleBackColor(bool_0);
	}

	internal static object B9L40ocC82WVEvQ00xc(object object_0)
	{
		return ((Min)object_0).sN9lAbF8Cq();
	}

	internal static object jkesg4co50Cpn08sD4Q(object object_0)
	{
		return ((Min)object_0).Q3AlN76YmR();
	}

	internal static void nwROrtchiUf2y9kR63M(object object_0, object object_1)
	{
		((Label)object_0).set_Text((string)object_1);
	}

	internal static object nPOMxJcQRh6LxdH1Fs6(object object_0)
	{
		return ((Min)object_0).i2hl3nDBei();
	}

	internal static void kcYJPdc78agJOdbhWaw(object object_0, bool bool_0)
	{
		((Label)object_0).set_AutoSize(bool_0);
	}

	internal static object V5PQDOcxRIhysvE0pih(object object_0)
	{
		return ((Min)object_0).xrdlkk3KLr();
	}

	internal static void UYdeoQcD892CUEBTn04(object object_0, object object_1)
	{
		((LinkLabel)object_0).set_Text((string)object_1);
	}

	internal static void UKb4xxcFVQJcRg46ej2(object object_0, int int_0)
	{
		((PictureBox)object_0).set_TabIndex(int_0);
	}

	internal static object wPhJwbcqeDrjTmEk41v(object object_0)
	{
		return ((Min)object_0).qtelQEbo1D();
	}

	internal static void wO9R7pcVtNJnLnTXUeE(object object_0, bool bool_0)
	{
		((RadioButton)object_0).set_TabStop(bool_0);
	}

	internal static object hyESG3cv1akgFfflB24(object object_0)
	{
		return ((Min)object_0).cnUlxIcY36();
	}

	internal static object N8tB4Yc3oPUyq424w5h(object object_0)
	{
		return ((Min)object_0).g1FlLVHen4();
	}

	internal static object WQ8we5cdU5JNUDydajW(object object_0)
	{
		return ((Min)object_0).iCrlJ5T0Bj();
	}

	internal static void hj2uZRcaVusRvn72Ojg(object object_0, bool bool_0)
	{
		((TextBox)object_0).set_Multiline(bool_0);
	}

	internal static void a0ALC8c0DeLkBlv9b1T(object object_0, SizeF sizeF_0)
	{
		((ContainerControl)object_0).set_AutoScaleDimensions(sizeF_0);
	}

	internal static void WQGsIkcYVMqASI5RHyx(object object_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ContainerControl)object_0).set_AutoScaleMode(autoScaleMode_0);
	}

	internal static object qW9pqXcIauNc6tPAdbi(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void YGUSjZcn5hB7jQy9TsP(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void cT1cnkcr1e5rQQxMdUI(object object_0, double double_0)
	{
		((Form)object_0).set_Opacity(double_0);
	}

	internal static void PRMJqfc65w5NO3tC8cO(object object_0)
	{
		((ISupportInitialize)object_0).EndInit();
	}

	internal static void jUEn8WcSm69aHvAJcMC()
	{
		Wi01fDI80Xb2rD7ho1.FXBTLLtRG();
	}
}
