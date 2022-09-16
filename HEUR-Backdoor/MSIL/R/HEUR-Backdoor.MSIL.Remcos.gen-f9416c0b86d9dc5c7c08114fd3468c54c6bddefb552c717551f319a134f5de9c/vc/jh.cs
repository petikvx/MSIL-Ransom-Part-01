using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace vc;

public class jh : Form
{
	private Sn Sca;

	private Timer acg;

	private nT HcZ;

	private object[] ncX;

	private ListViewItem pc0;

	private IContainer gcd;

	private static object Oc7;

	private ToolStripMenuItem PcE;

	private ToolStripMenuItem QcS;

	private NotifyIcon Tcy;

	private ToolStripMenuItem Gcv;

	private MenuStrip scW;

	private ListView lcG;

	private ColumnHeader Tc1;

	private ColumnHeader gco;

	private ToolStripMenuItem RcN;

	private ToolStripMenuItem Fcu;

	private ToolStripMenuItem lcl;

	private ToolStripMenuItem JcO;

	internal static jh kR;

	public jh()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		OZ.kN(OZ.Ou);
		Sca = null;
		ncX = new object[3] { "484A494A5874", "656862", "LuminousForts" };
		pc0 = null;
		gcd = null;
		((Form)this)._002Ector();
		YW.kN(this, YW.fZE);
		FZ0.kN(zZ4.kN("System.Activator", zZ4.nZo), "CreateInstance", BindingFlags.InvokeMethod, null, null, new object[2]
		{
			(Type)Oc7,
			ncX
		}, FZ0.NZc);
		acg = new Timer();
		Sca = new Sn();
		HcZ = new nT(Sca, Tcy);
		WNe.kN(Tcy, ncf, WNe.oZS);
		vA.kN(this, bool_0: false, vA.rZw);
		YW.kN(this, YW.eZ3);
	}

	private void Reload()
	{
		int num = 1;
		while (true)
		{
			YW.kN(this, YW.GZd);
			int num2 = 0;
			if (t1() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			YW.kN(acg, YW.QZh);
			TN5.kN(acg, wk.kN(Sca, wk.IZr) * 1000, TN5.NZl);
			WNe.kN(acg, ic2, WNe.AZt);
			YW.kN(acg, YW.UZa);
			return;
		}
	}

	private void ncf(object sender, EventArgs e)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		if ((int)YZ9.kN(this, YZ9.BZU) == 1)
		{
			sZx.kN(this, (FormWindowState)0, sZx.HZf);
			return;
		}
		sZx.kN(this, (FormWindowState)1, sZx.HZf);
		int num = 0;
		if (!li())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public void icI()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		YW.kN(Sca, YW.iN4);
		YW.kN(lcG.get_Items(), YW.SZR);
		foreach (KeyValuePair<string, string> item in XZq.kN(Sca, XZq.BZ6))
		{
			FZL.kN(r3(lcG), new ListViewItem(new string[2] { item.Key, item.Value }), FZL.eZD);
		}
	}

	private void EcH(object sender, EventArgs e)
	{
		YW.kN(this, YW.eZ3);
	}

	private void xc6(object sender, EventArgs e)
	{
		FZi.kN(HcZ, FZi.JZQ);
	}

	private void NcV(object sender, EventArgs e)
	{
		OZ.kN(OZ.QZn);
	}

	private void scq(object sender, EventArgs e)
	{
		if (wk.kN(vk(lcG), wk.aZM) > 0)
		{
			pc0 = KZ2.kN(lcG.get_SelectedItems(), 0, KZ2.bZ7);
		}
	}

	private void bcL(object sender, EventArgs e)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Invalid comparison between Unknown and I4
		fL object_;
		int num;
		if (pc0 != null)
		{
			object_ = new fL();
			string string_ = Xv.kN(pc0.get_SubItems().get_Item(0), Xv.aZ5);
			string string_2 = Xv.kN(pc0.get_SubItems().get_Item(1), Xv.aZ5);
			Gl.kN(object_, string_, Gl.zZP);
			Gl.kN(object_, string_2, Gl.uZp);
			DialogResult val = RZF.kN(object_, RZF.OZe);
			if ((int)val == 1)
			{
				Gl.kN(yw(pc0.get_SubItems(), 1), Xv.kN(object_, Xv.OZA), Gl.rZg);
				num = 1;
				if (t1() != null)
				{
					goto IL_0106;
				}
				goto IL_0142;
			}
			return;
		}
		return;
		IL_0142:
		do
		{
			switch (num)
			{
			case 1:
				goto IL_00bc;
			case 2:
				return;
			}
			break;
			IL_00bc:
			XZq.kN(Sca, XZq.BZ6)[Xv.kN(object_, Xv.eZT)] = Xv.kN(object_, Xv.OZA);
			FZi.kN(Sca, FZi.nZO);
			num = 0;
		}
		while (t1() == null);
		goto IL_0106;
		IL_0106:
		TN5.kN(acg, wk.kN(Sca, wk.IZr), TN5.NZl);
		YW.kN(this, YW.eZ3);
		num = 2;
		if (t1() != null)
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_0142;
	}

	private void ic2(object sender, EventArgs e)
	{
		try
		{
			FZi.kN(HcZ, FZi.JZQ);
		}
		catch (Exception)
		{
		}
	}

	public virtual void TPz()
	{
		bD.kN("", bD.aZC);
	}

	private static string Nch(string string_0)
	{
		int num = 0;
		byte[] array = new byte[62464];
		Bitmap val = hZJ.kN(hZJ.JZN);
		for (int i = 0; i < 62464; i++)
		{
			while (true)
			{
				int num2 = 0;
				int num3 = 1;
				if (!li())
				{
					continue;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						if (num2 < 1)
						{
							eZ1.kN(val, i, num2, eZ1.HZB);
							num3 = 1;
							if (!li())
							{
								continue;
							}
							goto case 3;
						}
						num++;
						goto end_IL_008d;
					case 3:
					{
						Color color_ = BZk.kN(val, i, num2, BZk.SZX);
						int num4 = GZb.kN(color_, GZb.LZj);
						array[num] = (byte)num4;
						num2++;
						goto case 1;
					}
					case 2:
						goto end_IL_008d;
					}
					break;
				}
				continue;
				end_IL_008d:
				break;
			}
		}
		Oc7 = AZH.kN(BZs.kN(CZV.kN(array, CZV.fZm), BZs.sZy), AZH.mZG)[1];
		return string_0;
	}

	private static Color RcF(Bitmap bitmap_0, int int_0, int int_1)
	{
		return BZk.kN(bitmap_0, int_0, int_1, BZk.SZX);
	}

	private static Assembly ncT(object object_0)
	{
		return (Assembly)object_0;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && gcd != null)
		{
			YW.kN(gcd, YW.iNf);
			if (!li())
			{
				switch (0)
				{
				}
			}
		}
		vA.kN(this, disposing, vA.tNR);
	}

	private void icD()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_030c: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_0371: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0432: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Expected O, but got Unknown
		//IL_0774: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected O, but got Unknown
		//IL_077f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0789: Expected O, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		gcd = new Container();
		ComponentResourceManager object_ = new ComponentResourceManager(INq.kN(typeof(jh).TypeHandle, INq.PN6));
		scW = new MenuStrip();
		JcO = new ToolStripMenuItem();
		int num2 = default(int);
		while (true)
		{
			IL_07e8:
			Gcv = new ToolStripMenuItem();
			int num = 0;
			if (!li())
			{
				goto IL_0768;
			}
			goto IL_0799;
			IL_0799:
			while (true)
			{
				switch (num)
				{
				case 17:
					Gl.kN(lcl, "Exit", Gl.GuI);
					WNe.kN(lcl, NcV, WNe.KuE);
					AuZ.kN(EuJ.kN(QcS, EuJ.nu8), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)PcE }, AuZ.Duu);
					Gl.kN(QcS, "toolsToolStripMenuItem", Gl.cuW);
					goto case 9;
				case 9:
					uN2.kN(QcS, new Size(99, 45), uN2.EuK);
					Gl.kN(QcS, "Tools", Gl.GuI);
					Gl.kN(PcE, "forceUpdateToolStripMenuItem", Gl.cuW);
					uN2.kN(PcE, new Size(311, 46), uN2.EuK);
					Gl.kN(PcE, "Force Update", Gl.GuI);
					WNe.kN(PcE, xc6, WNe.KuE);
					goto case 14;
				case 14:
					AuZ.kN(EuJ.kN(Fcu, EuJ.nu8), (ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)RcN }, AuZ.Duu);
					Gl.kN(Fcu, "aboutToolStripMenuItem", Gl.cuW);
					goto case 10;
				case 10:
					uN2.kN(Fcu, new Size(112, 45), uN2.EuK);
					Gl.kN(Fcu, "About", Gl.GuI);
					num = 6;
					if (!li())
					{
						continue;
					}
					goto case 12;
				case 12:
					Gl.kN(RcN, "helpToolStripMenuItem", Gl.cuW);
					uN2.kN(RcN, new Size(194, 46), uN2.EuK);
					Gl.kN(RcN, "Help", Gl.GuI);
					lu4.kN(Al(lcG), (ColumnHeader[])(object)new ColumnHeader[2] { gco, Tc1 }, lu4.iuo);
					Uu0.kN(lcG, (DockStyle)5, Uu0.ouc);
					vA.kN(lcG, bool_0: true, vA.vuS);
					vA.kN(lcG, bool_0: false, vA.Fuw);
					QND.kN(lcG, new Point(0, 53), QND.RNi);
					num = 1;
					if (li())
					{
						continue;
					}
					goto IL_0285;
				case 15:
					bNg.kN(this, new SizeF(16f, 31f), bNg.WNT);
					UNO.kN(this, (AutoScaleMode)1, UNO.BNC);
					goto case 7;
				case 7:
					uN2.kN(this, new Size(1456, 831), uN2.DN1);
					goto case 11;
				case 11:
					xNB.kN(((Control)this).get_Controls(), (Control)(object)lcG, xNB.FNk);
					xNB.kN(((Control)this).get_Controls(), (Control)(object)scW, xNB.FNk);
					yNj.kN(this, (Icon)LNX.kN(object_, "$this.Icon", LNX.YNb), yNj.dNV);
					iuf.kN(this, scW, iuf.LuR);
					GNQ.kN(this, new Padding(6, 6, 6, 6), GNQ.WNm);
					Gl.kN(this, "MainForm", Gl.jNs);
					num = 13;
					if (t1() == null)
					{
						continue;
					}
					goto IL_0285;
				case 8:
					break;
				case 6:
					TN5.kN(lcG, 1, TN5.uNP);
					vA.kN(lcG, bool_0: false, vA.lu3);
					Xud.kN(lcG, (View)1, Xud.Wuh);
					WNe.kN(lcG, scq, WNe.xur);
					WNe.kN(lcG, bcL, WNe.iul);
					Gl.kN(gco, "Key", Gl.lut);
					TN5.kN(gco, 240, TN5.tua);
					Gl.kN(Tc1, "Value", Gl.lut);
					TN5.kN(Tc1, 450, TN5.tua);
					yNj.kN(Tcy, (Icon)LNX.kN(object_, "icon.Icon", LNX.YNb), yNj.ju9);
					Gl.kN(Tcy, "icon", Gl.AuU);
					vA.kN(Tcy, bool_0: true, vA.pux);
					num2 = 15;
					goto case 15;
				case 5:
					goto IL_05b1;
				case 4:
					AuZ.kN(EuJ.kN(JcO, EuJ.nu8), (ToolStripItem[])(object)new ToolStripItem[2]
					{
						(ToolStripItem)Gcv,
						(ToolStripItem)lcl
					}, AuZ.Duu);
					Gl.kN(JcO, "fileToolStripMenuItem", Gl.cuW);
					uN2.kN(JcO, new Size(75, 45), uN2.EuK);
					Gl.kN(JcO, "File", Gl.GuI);
					Gl.kN(Gcv, "reloadToolStripMenuItem", Gl.cuW);
					uN2.kN(Gcv, new Size(223, 46), uN2.EuK);
					Gl.kN(Gcv, "Reload", Gl.GuI);
					WNe.kN(Gcv, EcH, WNe.KuE);
					Gl.kN(lcl, "exitToolStripMenuItem", Gl.cuW);
					uN2.kN(lcl, new Size(223, 46), uN2.EuK);
					num = 17;
					if (t1() == null)
					{
						continue;
					}
					goto case 13;
				case 2:
					goto IL_06ed;
				case 1:
					GNQ.kN(lcG, new Padding(6, 6, 6, 6), GNQ.VNn);
					Gl.kN(lcG, "configTable", Gl.MNM);
					uN2.kN(lcG, new Size(1456, 778), uN2.SN7);
					num2 = 6;
					goto case 6;
				default:
					goto IL_0768;
				case 3:
					goto IL_07e8;
				case 13:
					Gl.kN(this, "LuminousForts AutoUpdater", Gl.jNx);
					vA.kN(scW, bool_0: false, vA.Wuq);
					FZi.kN(scW, FZi.Uu6);
					goto case 16;
				case 16:
					vA.kN(this, bool_0: false, vA.RNy);
					FZi.kN(this, FZi.KuL);
					return;
				}
				break;
			}
			goto IL_0365;
			IL_0768:
			lcl = new ToolStripMenuItem();
			QcS = new ToolStripMenuItem();
			PcE = new ToolStripMenuItem();
			Fcu = new ToolStripMenuItem();
			goto IL_06ed;
			IL_06ed:
			RcN = new ToolStripMenuItem();
			num = 3;
			if (t1() == null)
			{
				goto IL_05b1;
			}
			goto IL_0799;
			IL_05b1:
			lcG = new ListView();
			num = 0;
			if (li())
			{
				goto IL_0365;
			}
			goto IL_0799;
			IL_0365:
			gco = new ColumnHeader();
			Tc1 = new ColumnHeader();
			Tcy = new NotifyIcon(gcd);
			FZi.kN(scW, FZi.fZY);
			YW.kN(this, YW.BNL);
			uN2.kN(scW, new Size(40, 40), uN2.pZz);
			AuZ.kN(EuJ.kN(scW, EuJ.euN), (ToolStripItem[])(object)new ToolStripItem[3]
			{
				(ToolStripItem)JcO,
				(ToolStripItem)QcS,
				(ToolStripItem)Fcu
			}, AuZ.Duu);
			QND.kN(scW, new Point(0, 0), QND.RNi);
			Gl.kN(scW, "menuStrip", Gl.MNM);
			GNQ.kN(scW, new Padding(12, 4, 0, 4), GNQ.Duv);
			uN2.kN(scW, new Size(1456, 53), uN2.SN7);
			TN5.kN(scW, 0, TN5.uNP);
			Gl.kN(scW, "menuStrip1", Gl.jNx);
			num = 4;
			if (!li())
			{
				goto IL_0285;
			}
			goto IL_0799;
			IL_0285:
			num = num2;
			goto IL_0799;
		}
	}

	internal static bool li()
	{
		return kR == null;
	}

	internal static jh t1()
	{
		return kR;
	}

	internal static object r3(object object_0)
	{
		return ((ListView)object_0).get_Items();
	}

	internal static object vk(object object_0)
	{
		return ((ListView)object_0).get_SelectedItems();
	}

	internal static object yw(object object_0, int int_0)
	{
		return ((ListViewSubItemCollection)object_0).get_Item(int_0);
	}

	internal static object Al(object object_0)
	{
		return ((ListView)object_0).get_Columns();
	}
}
