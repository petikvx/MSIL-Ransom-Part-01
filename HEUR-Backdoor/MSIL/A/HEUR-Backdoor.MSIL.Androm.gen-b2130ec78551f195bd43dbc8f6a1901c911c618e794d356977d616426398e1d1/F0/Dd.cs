using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace F0;

public class Dd : Window, IComponentConnector
{
	[CompilerGenerated]
	private sealed class su
	{
		public Dd MnW;

		public yO Gnd;

		public Action ynP;

		internal static su wc8;

		public su()
		{
			Rg.XRF6rz();
			base._002Ector();
		}

		internal void dnR()
		{
			((Panel)MnW.SomeWhere).get_Children().Add((UIElement)NcQ(Gnd));
		}

		internal void xnq()
		{
			Canvas.SetTop((UIElement)(object)Gnd.Cb(), -30.0);
		}

		internal void fnS()
		{
			Canvas.SetLeft((UIElement)(object)Gnd.Cb(), -30.0);
		}

		internal void Gnf()
		{
			Tcw(((Panel)MnW.SomeWhere).get_Children(), Gnd.Cb());
		}

		internal static bool pct()
		{
			return wc8 == null;
		}

		internal static su IcG()
		{
			return wc8;
		}

		internal static object NcQ(object object_0)
		{
			return ((yO)object_0).Cb();
		}

		internal static void Tcw(object object_0, object object_1)
		{
			((UIElementCollection)object_0).Remove((UIElement)object_1);
		}
	}

	[CompilerGenerated]
	private sealed class FL
	{
		public yO Mnx;

		internal static FL QcY;

		public FL()
		{
			Rg.XRF6rz();
			base._002Ector();
		}

		internal static bool scK()
		{
			return QcY == null;
		}

		internal static FL AcX()
		{
			return QcY;
		}
	}

	[CompilerGenerated]
	private sealed class Nh
	{
		public sA dny;

		public FL jnG;

		internal static Nh FcP;

		public Nh()
		{
			Rg.XRF6rz();
			base._002Ector();
		}

		internal void en5()
		{
			VcZ(jnG.Mnx.Cb(), dny.zi());
		}

		internal void Nn4()
		{
			Canvas.SetLeft((UIElement)(object)jnG.Mnx.Cb(), (double)dny.ET());
		}

		internal static bool gcp()
		{
			return FcP == null;
		}

		internal static Nh qcm()
		{
			return FcP;
		}

		internal static void VcZ(object object_0, double double_0)
		{
			Canvas.SetTop((UIElement)object_0, double_0);
		}
	}

	[CompilerGenerated]
	private sealed class cc
	{
		public yO NnH;

		private static cc uc9;

		public cc()
		{
			Rg.XRF6rz();
			base._002Ector();
		}

		internal void Vno()
		{
			Canvas.SetTop((UIElement)icW(NnH), -30.0);
		}

		internal void Bnm()
		{
			Canvas.SetLeft((UIElement)(object)NnH.Cb(), -30.0);
		}

		internal static bool JcL()
		{
			return uc9 == null;
		}

		internal static cc ucd()
		{
			return uc9;
		}

		internal static object icW(object object_0)
		{
			return ((yO)object_0).Cb();
		}
	}

	private int Rgf;

	private List<yO> ggW;

	private dp Lgd;

	private int UgP;

	private int zgx;

	private int mg5;

	private int eg4;

	private int ggy;

	private int YgG;

	private int pgo;

	private int Mgm;

	private readonly object WgH;

	private int Dga;

	internal Canvas SomeWhere;

	internal Ellipse light1;

	internal Ellipse light2;

	internal Ellipse light3;

	internal Ellipse light4;

	internal Ellipse light5;

	internal Ellipse light6;

	internal Ellipse light7;

	internal Ellipse light8;

	internal Ellipse light9;

	internal Ellipse light10;

	internal Ellipse light11;

	internal Ellipse light12;

	internal Ellipse light13;

	internal Ellipse light14;

	internal Ellipse light15;

	internal Ellipse light16;

	internal Ellipse light17;

	internal Ellipse light18;

	internal Ellipse light19;

	internal Ellipse light20;

	internal Ellipse light21;

	internal Ellipse light22;

	internal Ellipse light23;

	internal Ellipse light24;

	internal Ellipse light25;

	private bool ngD;

	internal static Dd zn;

	public Dd(int int_0)
	{
		Rg.XRF6rz();
		ggW = new List<yO>();
		Lgd = new dp();
		UgP = 200;
		zgx = 150;
		mg5 = 150;
		eg4 = 150;
		ggy = 4000;
		YgG = 800;
		pgo = 800;
		Mgm = 800;
		WgH = new object();
		Dga = 0;
		((Window)this)._002Ector();
		InitializeComponent();
		Rgf = int_0;
		Thread thread = new Thread(rg7);
		thread.IsBackground = true;
		thread.Start();
	}

	private void rg7()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (Dga == Rgf)
			{
				Eo(sE.znu(66));
				((Dispatcher)vq(this)).BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
				{
					((Window)this).Close();
				});
			}
			Thread.Sleep(2000);
			if (wb() != null)
			{
				switch (0)
				{
				}
			}
		}
	}

	private void QgB(object sender, RoutedEventArgs e)
	{
		S3.lv();
		Dg9();
		Lgd.Im(this);
		zgQ();
	}

	private void Dg9()
	{
		Random random = new Random();
		int num = 0;
		int num4 = default(int);
		while (true)
		{
			int num3;
			if (num < Rgf)
			{
				int num2 = random.Next(1, 5);
				if (1 == num2)
				{
					num3 = 0;
					if (iN())
					{
						goto IL_0095;
					}
				}
				else
				{
					if (2 == num2)
					{
						num4 = 4;
						goto IL_00d7;
					}
					if (3 != num2)
					{
						ggW.Add(new yO(num, sE.znu(236)));
						b2.PgJ.Add(new ni(num));
						goto IL_0133;
					}
					ggW.Add(new yO(num, sE.znu(200)));
					num3 = 1;
					if (!iN())
					{
						num3 = num4;
					}
				}
			}
			else
			{
				num3 = 3;
				if (!iN())
				{
					break;
				}
			}
			switch (num3)
			{
			case 1:
				goto IL_00c4;
			case 4:
				goto IL_00d7;
			case 2:
				goto IL_00f3;
			case 3:
				return;
			}
			goto IL_0095;
			IL_0095:
			ggW.Add(new yO(num, sE.znu(120)));
			b2.PgJ.Add(new ni(num));
			goto IL_0133;
			IL_0133:
			num++;
			continue;
			IL_00c4:
			b2.PgJ.Add(new ni(num));
			goto IL_0133;
			IL_00d7:
			ggW.Add(new yO(num, sE.znu(158)));
			goto IL_00f3;
			IL_00f3:
			b2.PgJ.Add(new ni(num));
			goto IL_0133;
		}
	}

	private void zgQ()
	{
		int num = 0;
		Thread thread = default(Thread);
		while (true)
		{
			bool flag = num < Rgf;
			int num2 = 1;
			if (!iN())
			{
				goto IL_0005;
			}
			goto IL_0028;
			IL_0028:
			switch (num2)
			{
			case 1:
				break;
			default:
				goto IL_0038;
			}
			goto IL_0005;
			IL_0005:
			if (flag)
			{
				thread = new Thread(pgp);
				num2 = 0;
				if (wb() == null)
				{
					goto IL_0038;
				}
				goto IL_0028;
			}
			break;
			IL_0038:
			thread.IsBackground = true;
			thread.Name = num.ToString();
			thread.Start(num);
			num++;
		}
	}

	private void pgp(object object_0)
	{
		su CS_0024_003C_003E8__locals0 = new su();
		CS_0024_003C_003E8__locals0.MnW = this;
		int num2 = default(int);
		List<sA> list_ = default(List<sA>);
		object wgH = default(object);
		bool lockTaken = default(bool);
		Random random = default(Random);
		bool flag = default(bool);
		bool flag2 = default(bool);
		int num3 = default(int);
		while (true)
		{
			IL_0b33:
			CS_0024_003C_003E8__locals0.Gnd = ggW[(int)object_0];
			int num = 22;
			if (!iN())
			{
				goto IL_07fd;
			}
			goto IL_0a85;
			IL_0a85:
			while (true)
			{
				switch (num)
				{
				case 40:
					if (num2 == 1)
					{
						b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)21);
						list_ = S3.b2r();
						break;
					}
					b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)18);
					goto case 2;
				case 2:
					list_ = S3.n2J();
					break;
				case 4:
				case 6:
				case 9:
				case 10:
				case 13:
				case 14:
				case 20:
				case 27:
				case 29:
					break;
				case 38:
					goto IL_009b;
				case 37:
					list_ = S3.IIZ();
					break;
				case 36:
					goto IL_00ca;
				case 35:
					list_ = null;
					break;
				case 34:
					goto IL_00d8;
				case 16:
				case 33:
					goto IL_00e1;
				case 12:
					goto IL_01ba;
				case 1:
					goto IL_0308;
				case 31:
					goto IL_0368;
				case 30:
					goto IL_03a1;
				case 32:
					goto IL_0580;
				case 26:
					goto IL_058b;
				case 24:
					goto IL_0592;
				case 28:
					goto IL_0630;
				case 11:
					goto IL_07cb;
				default:
					goto IL_07f9;
				case 15:
					goto IL_07fd;
				case 5:
					goto IL_0823;
				case 7:
					goto IL_08fe;
				case 25:
					try
					{
						Monitor.Enter(wgH, ref lockTaken);
						list_ = Ugw(pg(CS_0024_003C_003E8__locals0.Gnd));
						RgY(CS_0024_003C_003E8__locals0.Gnd);
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(wgH);
						}
					}
					break;
				case 23:
					((DispatcherObject)this).get_Dispatcher().BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
					{
						((Panel)CS_0024_003C_003E8__locals0.MnW.SomeWhere).get_Children().Add((UIElement)su.NcQ(CS_0024_003C_003E8__locals0.Gnd));
					});
					((DispatcherObject)this).get_Dispatcher().BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
					{
						Canvas.SetTop((UIElement)(object)CS_0024_003C_003E8__locals0.Gnd.Cb(), -30.0);
					});
					((Dispatcher)vq(this)).BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
					{
						Canvas.SetLeft((UIElement)(object)CS_0024_003C_003E8__locals0.Gnd.Cb(), -30.0);
					});
					goto IL_00e1;
				case 22:
					random = new Random();
					list_ = null;
					num2 = 0;
					goto case 23;
				case 21:
					list_ = S3.iIY();
					break;
				case 19:
					ggN(CS_0024_003C_003E8__locals0.Gnd, list_);
					XgR(CS_0024_003C_003E8__locals0.Gnd);
					goto IL_00e1;
				case 18:
					list_ = S3.F2K();
					break;
				case 17:
					if (flag)
					{
						num = 19;
						if (iN())
						{
							continue;
						}
						goto case 2;
					}
					goto IL_00e1;
				case 39:
					goto IL_0b33;
				case 3:
					throw new Exception(sE.znu(270));
				case 8:
					goto IL_0b70;
				}
				break;
				IL_00e1:
				switch (b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].RQ())
				{
				case (iF)3:
					break;
				default:
					goto IL_01a5;
				case (iF)0:
					goto IL_01ba;
				case (iF)1:
					goto IL_01e3;
				case (iF)2:
					goto IL_020b;
				case (iF)4:
					goto IL_023d;
				case (iF)5:
					goto IL_0279;
				case (iF)6:
					goto IL_02b6;
				case (iF)7:
					goto IL_02df;
				case (iF)8:
					goto IL_0308;
				case (iF)9:
					goto IL_0331;
				case (iF)10:
					goto IL_0356;
				case (iF)11:
					goto IL_03ca;
				case (iF)12:
					goto IL_03f3;
				case (iF)13:
					goto IL_041c;
				case (iF)14:
					goto IL_0445;
				case (iF)15:
					goto IL_046a;
				case (iF)16:
					goto IL_049f;
				case (iF)17:
					goto IL_04c8;
				case (iF)18:
					goto IL_04e8;
				case (iF)19:
					goto IL_0511;
				case (iF)20:
					goto IL_0533;
				case (iF)21:
					goto IL_0558;
				case (iF)22:
					goto IL_0580;
				case (iF)23:
					goto IL_05f4;
				case (iF)24:
					goto IL_0630;
				case (iF)25:
					goto IL_0659;
				case (iF)26:
					goto IL_06cf;
				case (iF)27:
					goto IL_06f8;
				case (iF)28:
					goto IL_0734;
				case (iF)29:
					goto IL_075d;
				case (iF)30:
					goto IL_0786;
				case (iF)31:
					goto IL_07af;
				case (iF)32:
					goto IL_07d7;
				case (iF)33:
					goto IL_085f;
				case (iF)34:
					goto IL_0891;
				case (iF)35:
					goto IL_08b9;
				case (iF)36:
					goto IL_094f;
				case (iF)37:
					goto IL_0971;
				case (iF)38:
					goto IL_0b70;
				}
				goto IL_009b;
				IL_0b70:
				KO(((DispatcherObject)this).get_Dispatcher(), (DispatcherPriority)4, (Action)delegate
				{
					su.Tcw(((Panel)CS_0024_003C_003E8__locals0.MnW.SomeWhere).get_Children(), CS_0024_003C_003E8__locals0.Gnd.Cb());
				});
				Dga++;
				return;
				IL_00ca:
				list_ = S3.VIQ();
				break;
				IL_00d8:
				list_ = S3.x2t();
				break;
				IL_0971:
				wgH = WgH;
				lockTaken = false;
				num = 25;
				if (wb() == null)
				{
					continue;
				}
				goto IL_098c;
				IL_094f:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)30);
				goto IL_00ca;
				IL_08b9:
				num2 = random.Next(1, 3);
				if (num2 == 1)
				{
					b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)8);
					list_ = S3.I2c();
					num = 9;
					if (iN())
					{
						continue;
					}
					goto IL_08fe;
				}
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)27);
				list_ = S3.pIg();
				break;
				IL_020b:
				af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)38);
				num = 35;
				if (wb() == null)
				{
					continue;
				}
				goto IL_098c;
				IL_01e3:
				b2.PgJ[pg(CS_0024_003C_003E8__locals0.Gnd)].Kp((iF)2);
				list_ = S3.c8();
				break;
				IL_0891:
				af(b2.PgJ[pg(CS_0024_003C_003E8__locals0.Gnd)], (iF)1);
				list_ = S3.g3();
				break;
				IL_085f:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)19);
				num = 18;
				if (iN())
				{
					continue;
				}
				goto IL_098c;
				IL_07d7:
				num2 = random.Next(1, 3);
				flag2 = num2 == 1;
				num = 0;
				if (wb() == null)
				{
					continue;
				}
				goto IL_07f9;
				IL_07f9:
				if (!flag2)
				{
					goto IL_07fd;
				}
				goto IL_0823;
				IL_0823:
				af(b2.PgJ[pg(CS_0024_003C_003E8__locals0.Gnd)], (iF)28);
				list_ = S3.pIE();
				goto IL_0847;
				IL_07af:
				b2.PgJ[pg(CS_0024_003C_003E8__locals0.Gnd)].Kp((iF)1);
				goto IL_07cb;
				IL_07cb:
				list_ = S3.g3();
				break;
				IL_0786:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)35);
				list_ = S3.qIy();
				break;
				IL_075d:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)34);
				list_ = S3.IIx();
				break;
				IL_0734:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)13);
				list_ = S3.F2P();
				break;
				IL_06f8:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)33);
				list_ = S3.CIW();
				Dgq(CS_0024_003C_003E8__locals0.Gnd, YgG);
				break;
				IL_06cf:
				b2.PgJ[pg(CS_0024_003C_003E8__locals0.Gnd)].Kp((iF)32);
				list_ = S3.nIq();
				break;
				IL_0659:
				num2 = random.Next(1, 3);
				if (1 == num2)
				{
					b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)31);
					num = 21;
					if (iN())
					{
						continue;
					}
				}
				else
				{
					b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)26);
					num = 37;
					if (iN())
					{
						continue;
					}
				}
				goto IL_098c;
				IL_01ba:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)24);
				list_ = S3.F2h();
				break;
				IL_01a5:
				num = 3;
				if (wb() == null)
				{
					continue;
				}
				goto IL_098c;
				IL_0630:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)30);
				list_ = S3.VIQ();
				break;
				IL_05f4:
				af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)29);
				list_ = S3.sI7();
				Dgq(CS_0024_003C_003E8__locals0.Gnd, pgo);
				break;
				IL_0580:
				num2 = xD(random, 1, 3);
				goto IL_058b;
				IL_058b:
				if (1 != num2)
				{
					goto IL_0592;
				}
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)28);
				list_ = S3.pIE();
				goto IL_05dc;
				IL_0592:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)36);
				list_ = S3.SIm();
				goto IL_05dc;
				IL_009b:
				af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)14);
				list_ = S3.a24();
				break;
				IL_05dc:
				Dgq(CS_0024_003C_003E8__locals0.Gnd, Mgm);
				break;
				IL_0558:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)2);
				list_ = S3.c8();
				break;
				IL_0533:
				af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)38);
				list_ = null;
				break;
				IL_0511:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)20);
				goto IL_00d8;
				IL_04e8:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)22);
				list_ = S3.n2V();
				break;
				IL_04c8:
				num2 = random.Next(1, 3);
				num = 40;
				if (iN())
				{
					continue;
				}
				goto IL_098c;
				IL_049f:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)9);
				list_ = S3.O29();
				break;
				IL_046a:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)38);
				list_ = null;
				num = 14;
				if (iN())
				{
					continue;
				}
				goto IL_098c;
				IL_0445:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)38);
				list_ = null;
				break;
				IL_041c:
				b2.PgJ[pg(CS_0024_003C_003E8__locals0.Gnd)].Kp((iF)14);
				list_ = S3.a24();
				break;
				IL_03f3:
				af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)23);
				list_ = S3.k2j();
				break;
				IL_03ca:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)27);
				list_ = S3.pIg();
				break;
				IL_0356:
				num2 = xD(random, 1, 3);
				if (num2 == 1)
				{
					goto IL_0368;
				}
				goto IL_03a1;
				IL_0368:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)16);
				list_ = S3.G2a();
				num = 10;
				if (iN())
				{
					continue;
				}
				goto IL_098c;
				IL_03a1:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)11);
				list_ = S3.Q2R();
				break;
				IL_0331:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)38);
				list_ = null;
				break;
				IL_0308:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)9);
				list_ = S3.O29();
				break;
				IL_02df:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)20);
				list_ = S3.x2t();
				break;
				IL_02b6:
				af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)25);
				list_ = S3.t2U();
				break;
				IL_0279:
				num2 = xD(random, 1, 3);
				if (num2 == 1)
				{
					b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)6);
					list_ = S3.v2I();
					break;
				}
				goto IL_08fe;
				IL_098c:
				num = num3;
				continue;
				IL_08fe:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)7);
				list_ = S3.s2n();
				break;
				IL_023d:
				b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].Kp((iF)15);
				list_ = S3.e2o();
				Dgq(CS_0024_003C_003E8__locals0.Gnd, ggy);
				break;
			}
			goto IL_0065;
			IL_07fd:
			af(b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()], (iF)36);
			list_ = S3.SIm();
			goto IL_0847;
			IL_0847:
			Dgq(CS_0024_003C_003E8__locals0.Gnd, Mgm);
			goto IL_0065;
			IL_0065:
			do
			{
				flag = b2.PgJ[CS_0024_003C_003E8__locals0.Gnd.l2()].RQ() != (iF)38;
				num = 17;
			}
			while (wb() != null);
			goto IL_0a85;
		}
	}

	private List<sA> Ugw(int int_0)
	{
		Random random = new Random();
		int num = random.Next(1, 8);
		if (1 == num)
		{
			b2.PgJ[int_0].Kp((iF)17);
			return S3.T2k();
		}
		if (2 == num)
		{
			b2.PgJ[int_0].Kp((iF)12);
			return S3.m2f();
		}
		if (3 == num)
		{
			b2.PgJ[int_0].Kp((iF)10);
			return S3.R2w();
		}
		if (4 == num)
		{
			b2.PgJ[int_0].Kp((iF)5);
			return S3.bz();
		}
		if (5 == num)
		{
			b2.PgJ[int_0].Kp((iF)4);
			return S3.zC();
		}
		if (6 == num)
		{
			b2.PgJ[int_0].Kp((iF)0);
			return S3.DL();
		}
		b2.PgJ[int_0].Kp((iF)3);
		return S3.UO();
	}

	private void RgY(yO yO_0)
	{
		while (!kU(yO_0.l2(), b2.PgJ[yO_0.l2()].RQ()))
		{
			Thread.Sleep(mg5);
		}
	}

	private void ggN(yO yO_0, List<sA> list_0)
	{
		FL fL = new FL();
		fL.Mnx = yO_0;
		int num = 0;
		using List<sA>.Enumerator enumerator = list_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Nh CS_0024_003C_003E8__locals0 = new Nh();
			CS_0024_003C_003E8__locals0.jnG = fL;
			CS_0024_003C_003E8__locals0.dny = enumerator.Current;
			while (!b2.QgF(CS_0024_003C_003E8__locals0.jnG.Mnx.l2(), b2.PgJ[CS_0024_003C_003E8__locals0.jnG.Mnx.l2()].RQ()))
			{
				Thread.Sleep(zgx);
			}
			Thread.Sleep(UgP);
			((DispatcherObject)this).get_Dispatcher().BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
			{
				Nh.VcZ(CS_0024_003C_003E8__locals0.jnG.Mnx.Cb(), CS_0024_003C_003E8__locals0.dny.zi());
			});
			((DispatcherObject)this).get_Dispatcher().BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
			{
				Canvas.SetLeft((UIElement)(object)CS_0024_003C_003E8__locals0.jnG.Mnx.Cb(), (double)CS_0024_003C_003E8__locals0.dny.ET());
			});
			num++;
			b2.PgJ[CS_0024_003C_003E8__locals0.jnG.Mnx.l2()].vN(num);
		}
	}

	private void XgR(yO yO_0)
	{
		while (!b2.igk(yO_0.l2(), this))
		{
			Thread.Sleep(eg4);
		}
	}

	private void Dgq(yO yO_0, int int_0)
	{
		cc CS_0024_003C_003E8__locals0;
		while (true)
		{
			CS_0024_003C_003E8__locals0 = new cc();
			if (wb() == null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		CS_0024_003C_003E8__locals0.NnH = yO_0;
		((DispatcherObject)this).get_Dispatcher().BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
		{
			Canvas.SetTop((UIElement)cc.icW(CS_0024_003C_003E8__locals0.NnH), -30.0);
		});
		((DispatcherObject)this).get_Dispatcher().BeginInvoke((DispatcherPriority)4, (Delegate)(Action)delegate
		{
			Canvas.SetLeft((UIElement)(object)CS_0024_003C_003E8__locals0.NnH.Cb(), -30.0);
		});
		Thread.Sleep(int_0);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	public void InitializeComponent()
	{
		int num = 1;
		while (true)
		{
			bool flag = ngD;
			int num2 = 0;
			if (wb() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			if (!flag)
			{
				ngD = true;
				Uri uri = new Uri(sE.znu(278), UriKind.Relative);
				Application.LoadComponent((object)this, uri);
			}
			return;
		}
	}

	[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
	[DebuggerNonUserCode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	void IComponentConnector.Connect(int connectionId, object target)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_017a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Expected O, but got Unknown
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_028e: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected O, but got Unknown
		int num;
		switch (connectionId)
		{
		case 1:
		{
			((FrameworkElement)(Dd)target).add_Loaded(new RoutedEventHandler(QgB));
			int num2 = 9;
			break;
		}
		case 3:
			light1 = (Ellipse)target;
			break;
		case 4:
			light2 = (Ellipse)target;
			break;
		case 5:
			light3 = (Ellipse)target;
			break;
		case 6:
			light4 = (Ellipse)target;
			break;
		case 7:
			light5 = (Ellipse)target;
			break;
		case 8:
			light6 = (Ellipse)target;
			break;
		case 10:
			light8 = (Ellipse)target;
			break;
		case 12:
			light10 = (Ellipse)target;
			break;
		case 13:
			light11 = (Ellipse)target;
			break;
		case 14:
			light12 = (Ellipse)target;
			num = 5;
			if (!iN())
			{
				int num2 = default(int);
				num = num2;
			}
			goto IL_01bc;
		case 16:
		{
			light14 = (Ellipse)target;
			int num2 = 11;
			break;
		}
		case 17:
			light15 = (Ellipse)target;
			break;
		case 18:
			light16 = (Ellipse)target;
			num = 8;
			if (iN())
			{
				goto IL_01bc;
			}
			goto IL_01fa;
		case 2:
			SomeWhere = (Canvas)target;
			num = 0;
			if (!iN())
			{
				break;
			}
			goto IL_01bc;
		case 11:
			goto IL_01fa;
		case 15:
			goto IL_020b;
		default:
			goto IL_0222;
		case 9:
			goto IL_022e;
		case 19:
			light17 = (Ellipse)target;
			break;
		case 20:
			light18 = (Ellipse)target;
			break;
		case 21:
			light19 = (Ellipse)target;
			break;
		case 22:
			light20 = (Ellipse)target;
			break;
		case 23:
			light21 = (Ellipse)target;
			break;
		case 24:
			light22 = (Ellipse)target;
			break;
		case 25:
			light23 = (Ellipse)target;
			break;
		case 26:
			light24 = (Ellipse)target;
			break;
		case 27:
			{
				light25 = (Ellipse)target;
				break;
			}
			IL_01bc:
			switch (num)
			{
			case 6:
				break;
			default:
				return;
			case 1:
				goto IL_01fa;
			case 2:
				goto IL_020b;
			case 10:
				goto IL_0222;
			case 12:
				goto IL_022e;
			case 0:
			case 3:
			case 4:
			case 5:
			case 7:
			case 8:
			case 9:
			case 11:
				return;
			}
			goto case 2;
			IL_022e:
			light7 = (Ellipse)target;
			break;
			IL_0222:
			ngD = true;
			break;
			IL_020b:
			light13 = (Ellipse)target;
			break;
			IL_01fa:
			light9 = (Ellipse)target;
			break;
		}
	}

	[CompilerGenerated]
	private void QgS()
	{
		((Window)this).Close();
	}

	internal static bool iN()
	{
		return zn == null;
	}

	internal static Dd wb()
	{
		return zn;
	}

	internal static MessageBoxResult Eo(object object_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return MessageBox.Show((string)object_0);
	}

	internal static object vq(object object_0)
	{
		return ((DispatcherObject)object_0).get_Dispatcher();
	}

	internal static int pg(object object_0)
	{
		return ((yO)object_0).l2();
	}

	internal static void af(object object_0, iF iF_0)
	{
		((ni)object_0).Kp(iF_0);
	}

	internal static int xD(object object_0, int int_0, int int_1)
	{
		return ((Random)object_0).Next(int_0, int_1);
	}

	internal static object KO(object object_0, DispatcherPriority dispatcherPriority_0, object object_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((Dispatcher)object_0).BeginInvoke(dispatcherPriority_0, (Delegate)object_1);
	}

	internal static bool kU(int int_0, iF iF_0)
	{
		return b2.egi(int_0, iF_0);
	}
}
