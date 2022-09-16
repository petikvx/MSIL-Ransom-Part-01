using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace XW;

public class B5 : Form
{
	private Gp RK;

	private Timer tT;

	private rC Ez;

	private object[] YW3;

	private ListViewItem KWW;

	private IContainer VWL;

	private static object XWi;

	private ToolStripMenuItem KWa;

	private ToolStripMenuItem vWq;

	private NotifyIcon qWF;

	private ToolStripMenuItem qW2;

	private MenuStrip MWS;

	private ListView VWt;

	private ColumnHeader nWD;

	private ColumnHeader hW7;

	private ToolStripMenuItem dWj;

	private ToolStripMenuItem YWs;

	private ToolStripMenuItem zWh;

	private ToolStripMenuItem hWH;

	internal static B5 tj;

	public B5()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		G3.nJ(G3.By);
		RK = null;
		YW3 = new object[3] { "6D4361424944", "627762", "CimexUtility" };
		KWW = null;
		VWL = null;
		((Form)this)._002Ector();
		Su.nJ(this, Su.sJm);
		pJr.nJ(jJ1.nJ("System.Activator", jJ1.cJY), "CreateInstance", BindingFlags.InvokeMethod, null, null, new object[2]
		{
			(Type)XWi,
			YW3
		}, pJr.fJK);
		tT = new Timer();
		RK = new Gp();
		Ez = new rC(RK, qWF);
		PJf.nJ(qWF, qn, PJf.VJg);
		JJO.nJ(this, bool_0: false, JJO.lJD);
		Su.nJ(this, Su.DJb);
	}

	private void Reload()
	{
		Su.nJ(this, Su.hJ4);
		Su.nJ(tT, Su.aJG);
		TJw.nJ(tT, IJa.nJ(RK, IJa.lJA) * 1000, TJw.nJv);
		PJf.nJ(tT, Dd, PJf.zJH);
		Su.nJ(tT, Su.qJn);
		int num = 0;
		if (O9() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void qn(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)FJo.nJ(this, FJo.gJe) != 1)
		{
			FJE.nJ(this, (FormWindowState)1, FJE.KJs);
		}
		else
		{
			FJE.nJ(this, (FormWindowState)0, FJE.KJs);
		}
	}

	public void hX()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		Su.nJ(RK, Su.GP);
		Su.nJ(VWt.get_Items(), Su.eJV);
		foreach (KeyValuePair<string, string> item in BJ6.nJ(RK, BJ6.YJF))
		{
			zJN.nJ(s5(VWt), new ListViewItem(new string[2] { item.Key, item.Value }), zJN.NJW);
		}
	}

	private void ib(object sender, EventArgs e)
	{
		Su.nJ(this, Su.DJb);
	}

	private void dc(object sender, EventArgs e)
	{
		Su.nJ(Ez, Su.yJU);
	}

	private void Tg(object sender, EventArgs e)
	{
		G3.nJ(G3.rJj);
	}

	private void b0(object sender, EventArgs e)
	{
		if (IJa.nJ(VWt.get_SelectedItems(), IJa.BJ8) > 0)
		{
			KWW = cJT.nJ(VWt.get_SelectedItems(), 0, cJT.WJ5);
		}
	}

	private void Jl(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Invalid comparison between Unknown and I4
		o1 object_;
		DialogResult val;
		int num;
		if (KWW != null)
		{
			object_ = new o1();
			string string_ = Xi.nJ(((ListViewSubItemCollection)bu(KWW)).get_Item(0), Xi.YJl);
			string string_2 = Xi.nJ(KWW.get_SubItems().get_Item(1), Xi.YJl);
			Ew.nJ(object_, string_, Ew.LJC);
			Ew.nJ(object_, string_2, Ew.RJL);
			val = mJ2.nJ(object_, mJ2.kJS);
			num = 0;
			if (O9() != null)
			{
				goto IL_0131;
			}
			goto IL_013a;
		}
		return;
		IL_008e:
		BJ6.nJ(RK, BJ6.YJF)[Xi.nJ(object_, Xi.E3J)] = Xi.nJ(object_, Xi.CJz);
		Su.nJ(RK, Su.f33);
		TJw.nJ(tT, IJa.nJ(RK, IJa.lJA), TJw.nJv);
		Su.nJ(this, Su.DJb);
		num = 1;
		if (O9() != null)
		{
			goto IL_0131;
		}
		goto IL_013a;
		IL_013a:
		switch (num)
		{
		case 2:
			break;
		default:
			goto IL_0131;
		case 1:
			return;
		}
		goto IL_008e;
		IL_0131:
		if ((int)val == 1)
		{
			Ew.nJ(KWW.get_SubItems().get_Item(1), Xi.nJ(object_, Xi.CJz), Ew.M3O);
			goto IL_008e;
		}
	}

	private void Dd(object sender, EventArgs e)
	{
		try
		{
			Su.nJ(Ez, Su.yJU);
		}
		catch (Exception)
		{
		}
	}

	public virtual void xOD()
	{
		P3y.nJ("", P3y.r3X);
	}

	private static string eV(string string_0)
	{
		int num = 1;
		byte[] array = default(byte[]);
		Bitmap val = default(Bitmap);
		int num4 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = 0;
			int num3 = 0;
			if (O9() != null)
			{
				num3 = num;
			}
			switch (num3)
			{
			case 1:
				break;
			default:
				array = new byte[62464];
				val = O3c.nJ(O3c.a3u);
				num4 = 0;
				goto IL_0063;
			case 2:
				num2++;
				num4++;
				goto IL_0063;
			case 3:
				num5 = 0;
				goto IL_0071;
			case 4:
				{
					Color color_ = D3p.nJ(val, num4, num5, D3p.w3w);
					int num6 = D3h.nJ(color_, D3h.X3M);
					array[num2] = (byte)num6;
					num5++;
					goto IL_0071;
				}
				IL_0063:
				if (num4 >= 62464)
				{
					XWi = w3d.nJ(l37.nJ(P3I.nJ(array, P3I.f3f), l37.h3k), w3d.Y3Q)[1];
					return string_0;
				}
				goto case 3;
				IL_0071:
				if (num5 >= 1)
				{
					goto case 2;
				}
				P3P.nJ(val, num4, num5, P3P.n3t);
				goto case 4;
			}
		}
	}

	private static Color MR(Bitmap bitmap_0, int int_0, int int_1)
	{
		return D3p.nJ(bitmap_0, int_0, int_1, D3p.w3w);
	}

	private static Assembly dO(object object_0)
	{
		return (Assembly)object_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			bool flag = VWL != null;
			int num = 0;
			if (O9() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			}
			if (flag)
			{
				Su.nJ(VWL, Su.D4);
			}
		}
		JJO.nJ(this, disposing, JJO.IJJ);
	}

	private void gM()
	{
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
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0655: Expected O, but got Unknown
		//IL_0732: Unknown result type (might be due to invalid IL or missing references)
		//IL_0741: Expected O, but got Unknown
		//IL_07e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		VWL = new Container();
		ComponentResourceManager object_ = new ComponentResourceManager(aG.nJ(typeof(B5).TypeHandle, aG.ta));
		MWS = new MenuStrip();
		hWH = new ToolStripMenuItem();
		qW2 = new ToolStripMenuItem();
		zWh = new ToolStripMenuItem();
		vWq = new ToolStripMenuItem();
		KWa = new ToolStripMenuItem();
		YWs = new ToolStripMenuItem();
		dWj = new ToolStripMenuItem();
		VWt = new ListView();
		hW7 = new ColumnHeader();
		nWD = new ColumnHeader();
		int num2 = default(int);
		while (true)
		{
			qWF = new NotifyIcon(VWL);
			Su.nJ(MWS, Su.R3q);
			Su.nJ(this, Su.FJ3);
			uJt.nJ(MWS, new Size(40, 40), uJt.y39);
			g3x.nJ(i3Z.nJ(MWS, i3Z.P3B), (ToolStripItem[])(object)new ToolStripItem[3]
			{
				(ToolStripItem)hWH,
				(ToolStripItem)vWq,
				(ToolStripItem)YWs
			}, g3x.g3R);
			oJy.nJ(MWS, new Point(0, 0), oJy.vJX);
			int num = 8;
			if (O9() != null)
			{
				goto IL_00d5;
			}
			goto IL_05f2;
			IL_05f2:
			while (true)
			{
				switch (num)
				{
				case 16:
					TJw.nJ(MWS, 0, TJw.XJh);
					Ew.nJ(MWS, "menuStrip1", Ew.yz);
					num = 3;
					if (FG())
					{
						continue;
					}
					goto IL_00d5;
				case 15:
					JJO.nJ(VWt, bool_0: true, JJO.U34);
					JJO.nJ(VWt, bool_0: false, JJO.Y3G);
					oJy.nJ(VWt, new Point(0, 53), oJy.vJX);
					mJc.nJ(VWt, new Padding(6, 6, 6, 6), mJc.GJu);
					Ew.nJ(VWt, "configTable", Ew.xJP);
					uJt.nJ(VWt, new Size(1456, 778), uJt.lJp);
					TJw.nJ(VWt, 1, TJw.XJh);
					JJO.nJ(VWt, bool_0: false, JJO.L3a);
					W3A.nJ(VWt, (View)1, W3A.P3v);
					PJf.nJ(VWt, b0, PJf.z3H);
					PJf.nJ(VWt, Jl, PJf.k3n);
					Ew.nJ(hW7, "Key", Ew.T3o);
					TJw.nJ(hW7, 240, TJw.Y3e);
					num = 0;
					if (O9() != null)
					{
						continue;
					}
					goto case 1;
				case 14:
					Ew.nJ(qW2, "Reload", Ew.p3Y);
					PJf.nJ(qW2, ib, PJf.c3r);
					Ew.nJ(zWh, "exitToolStripMenuItem", Ew.v3m);
					uJt.nJ(zWh, new Size(223, 46), uJt.t31);
					Ew.nJ(zWh, "Exit", Ew.p3Y);
					PJf.nJ(zWh, Tg, PJf.c3r);
					goto case 6;
				case 6:
					g3x.nJ(i3Z.nJ(vWq, i3Z.n30), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)KWa }, g3x.g3R);
					Ew.nJ(vWq, "toolsToolStripMenuItem", Ew.v3m);
					uJt.nJ(vWq, new Size(99, 45), uJt.t31);
					Ew.nJ(vWq, "Tools", Ew.p3Y);
					Ew.nJ(KWa, "forceUpdateToolStripMenuItem", Ew.v3m);
					goto case 5;
				case 5:
					uJt.nJ(KWa, new Size(311, 46), uJt.t31);
					Ew.nJ(KWa, "Force Update", Ew.p3Y);
					PJf.nJ(KWa, dc, PJf.c3r);
					g3x.nJ(i3Z.nJ(YWs, i3Z.n30), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)dWj }, g3x.g3R);
					Ew.nJ(YWs, "aboutToolStripMenuItem", Ew.v3m);
					uJt.nJ(YWs, new Size(112, 45), uJt.t31);
					Ew.nJ(YWs, "About", Ew.p3Y);
					Ew.nJ(dWj, "helpToolStripMenuItem", Ew.v3m);
					num = 2;
					if (O9() == null)
					{
						continue;
					}
					goto IL_00d5;
				case 12:
					Ew.nJ(dWj, "Help", Ew.p3Y);
					w3K.nJ(VWt.get_Columns(), (ColumnHeader[])(object)new ColumnHeader[2] { hW7, nWD }, w3K.f3g);
					g3D.nJ(VWt, (DockStyle)5, g3D.E3b);
					num = 15;
					if (!FG())
					{
						continue;
					}
					goto case 15;
				case 11:
					uJt.nJ(MWS, new Size(1456, 53), uJt.lJp);
					num = 14;
					if (O9() != null)
					{
						continue;
					}
					goto case 16;
				case 9:
					Ew.nJ(hWH, "fileToolStripMenuItem", Ew.v3m);
					num = 0;
					if (O9() == null)
					{
						continue;
					}
					goto IL_00d5;
				case 8:
					Ew.nJ(MWS, "menuStrip", Ew.xJP);
					mJc.nJ(MWS, new Padding(12, 4, 0, 4), mJc.z3i);
					num = 11;
					if (O9() == null)
					{
						continue;
					}
					goto IL_00d5;
				case 3:
					g3x.nJ(i3Z.nJ(hWH, i3Z.n30), (ToolStripItem[])(object)new ToolStripItem[2]
					{
						(ToolStripItem)qW2,
						(ToolStripItem)zWh
					}, g3x.g3R);
					num = 9;
					if (O9() == null)
					{
						continue;
					}
					goto case 5;
				case 2:
					uJt.nJ(dWj, new Size(194, 46), uJt.t31);
					num = 12;
					if (O9() == null)
					{
						continue;
					}
					goto IL_00d5;
				default:
					uJt.nJ(hWH, new Size(75, 45), uJt.t31);
					Ew.nJ(hWH, "File", Ew.p3Y);
					Ew.nJ(qW2, "reloadToolStripMenuItem", Ew.v3m);
					uJt.nJ(qW2, new Size(223, 46), uJt.t31);
					num = 14;
					if (O9() == null)
					{
						continue;
					}
					goto IL_00d5;
				case 10:
					break;
				case 1:
					Ew.nJ(nWD, "Value", Ew.T3o);
					TJw.nJ(nWD, 450, TJw.Y3e);
					a3V.nJ(qWF, (Icon)o3E.nJ(object_, "icon.Icon", o3E.z3s), a3V.i36);
					goto case 7;
				case 7:
					Ew.nJ(qWF, "icon", Ew.u3F);
					JJO.nJ(qWF, bool_0: true, JJO.R3N);
					goto case 13;
				case 13:
					TJk.nJ(this, new SizeF(16f, 31f), TJk.GJd);
					SJQ.nJ(this, (AutoScaleMode)1, SJQ.jJq);
					uJt.nJ(this, new Size(1456, 831), uJt.dJ9);
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)VWt, CJZ.bJB);
					goto case 4;
				case 4:
					CJZ.nJ(Ch(this), (Control)(object)MWS, CJZ.bJB);
					a3V.nJ(this, (Icon)o3E.nJ(object_, "$this.Icon", o3E.z3s), a3V.f3W);
					v3U.nJ(this, MWS, v3U.M3j);
					mJc.nJ(this, new Padding(6, 6, 6, 6), mJc.zJx);
					Ew.nJ(this, "MainForm", Ew.wJR);
					Ew.nJ(this, "CimexUtility AutoUpdater", Ew.yz);
					goto case 17;
				case 17:
					JJO.nJ(MWS, bool_0: false, JJO.g38);
					Su.nJ(MWS, Su.L3T);
					JJO.nJ(this, bool_0: false, JJO.tJi);
					Su.nJ(this, Su.n35);
					return;
				}
				break;
			}
			continue;
			IL_00d5:
			num = num2;
			goto IL_05f2;
		}
	}

	internal static bool FG()
	{
		return tj == null;
	}

	internal static B5 O9()
	{
		return tj;
	}

	internal static object s5(object object_0)
	{
		return ((ListView)object_0).get_Items();
	}

	internal static object bu(object object_0)
	{
		return ((ListViewItem)object_0).get_SubItems();
	}

	internal static object Ch(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}
}
