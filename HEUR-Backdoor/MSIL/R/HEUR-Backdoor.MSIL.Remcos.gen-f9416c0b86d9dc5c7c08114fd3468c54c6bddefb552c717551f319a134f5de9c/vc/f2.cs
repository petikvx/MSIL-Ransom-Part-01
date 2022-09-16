using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace vc;

public class f2 : Form
{
	private IContainer HU;

	private PictureBox gz;

	private PictureBox dc5;

	private Button fcc;

	private Button Kcn;

	private Button TcP;

	internal static f2 EB;

	public f2()
	{
		OZ.kN(OZ.Ou);
		HU = null;
		((Form)this)._002Ector();
		YW.kN(this, YW.GNG);
	}

	private void Cx(object sender, EventArgs e)
	{
		vA.kN(gz, bool_0: true, vA.TNY);
		vA.kN(dc5, bool_0: false, vA.TNY);
	}

	private void b8(object sender, EventArgs e)
	{
		vA.kN(gz, bool_0: false, vA.TNY);
		vA.kN(dc5, bool_0: true, vA.TNY);
	}

	private void jR(object sender, EventArgs e)
	{
		YW.kN(this, YW.PN9);
	}

	protected override void Dispose(bool disposing)
	{
		while (disposing)
		{
			if (wW() != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			if (HU != null)
			{
				YW.kN(HU, YW.iNf);
			}
			break;
		}
		vA.kN(this, disposing, vA.tNR);
	}

	private void xs()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_0561: Unknown result type (might be due to invalid IL or missing references)
		//IL_056b: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0576: Expected O, but got Unknown
		//IL_05d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05e9: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager object_ = new ComponentResourceManager(INq.kN(typeof(f2).TypeHandle, INq.PN6));
		dc5 = new PictureBox();
		int num = 0;
		if (wW() != null)
		{
			goto IL_0069;
		}
		goto IL_0584;
		IL_0584:
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 13:
				TN5.kN(fcc, 2, TN5.uNP);
				Gl.kN(fcc, "Show &Heads", Gl.jNx);
				num = 1;
				if (IJ())
				{
					continue;
				}
				break;
			case 12:
				QND.kN(fcc, new Point(141, 465), QND.RNi);
				GNQ.kN(fcc, new Padding(8, 7, 8, 7), GNQ.VNn);
				Gl.kN(fcc, "headButton", Gl.MNM);
				uN2.kN(fcc, new Size(200, 100), uN2.SN7);
				goto case 13;
			case 10:
				xNB.kN(lQ(this), (Control)(object)fcc, xNB.FNk);
				xNB.kN(lQ(this), (Control)(object)dc5, xNB.FNk);
				xNB.kN(lQ(this), (Control)(object)gz, xNB.FNk);
				num = 2;
				if (IJ())
				{
					continue;
				}
				break;
			case 9:
				Gl.kN(dc5, "tailPictureBox", Gl.MNM);
				uN2.kN(dc5, new Size(416, 365), uN2.SN7);
				VZv.kN(dc5, (PictureBoxSizeMode)4, VZv.CZ8);
				TN5.kN(dc5, 1, TN5.tZW);
				vA.kN(dc5, bool_0: false, vA.dZK);
				vA.kN(dc5, bool_0: false, vA.TNY);
				uZZ.kN(gz, (Image)(object)hZJ.kN(hZJ.JZN), uZZ.AZu);
				QND.kN(gz, new Point(35, 31), QND.RNi);
				GNQ.kN(gz, new Padding(8, 7, 8, 7), GNQ.VNn);
				Gl.kN(gz, "headPictureBox", Gl.MNM);
				uN2.kN(gz, new Size(413, 365), uN2.SN7);
				VZv.kN(gz, (PictureBoxSizeMode)4, VZv.CZ8);
				TN5.kN(gz, 0, TN5.tZW);
				vA.kN(gz, bool_0: false, vA.dZK);
				vA.kN(gz, bool_0: false, vA.TNY);
				num2 = 12;
				goto case 12;
			case 8:
				GNQ.kN(Kcn, new Padding(8, 7, 8, 7), GNQ.VNn);
				num = 6;
				if (!IJ())
				{
					continue;
				}
				goto case 6;
			case 6:
				Gl.kN(Kcn, "tailButton", Gl.MNM);
				uN2.kN(Kcn, new Size(200, 100), uN2.SN7);
				TN5.kN(Kcn, 3, TN5.uNP);
				Gl.kN(Kcn, "Show &Tails", Gl.jNx);
				vA.kN(Kcn, bool_0: true, vA.ONF);
				WNe.kN(Kcn, b8, WNe.mNA);
				QND.kN(TcP, new Point(843, 465), QND.RNi);
				GNQ.kN(TcP, new Padding(8, 7, 8, 7), GNQ.VNn);
				Gl.kN(TcP, "exitButton", Gl.MNM);
				uN2.kN(TcP, new Size(200, 100), uN2.SN7);
				TN5.kN(TcP, 4, TN5.uNP);
				Gl.kN(TcP, "&Exit", Gl.jNx);
				num = 3;
				if (IJ())
				{
					continue;
				}
				break;
			case 7:
				YW.kN(dc5, YW.CNz);
				YW.kN(gz, YW.CNz);
				YW.kN(this, YW.BNL);
				uZZ.kN(dc5, (Image)(object)hZJ.kN(hZJ.JZN), uZZ.AZu);
				QND.kN(dc5, new Point(723, 31), QND.RNi);
				GNQ.kN(dc5, new Padding(8, 7, 8, 7), GNQ.VNn);
				goto case 9;
			case 5:
				WNe.kN(fcc, Cx, WNe.mNA);
				QND.kN(Kcn, new Point(483, 465), QND.RNi);
				goto case 8;
			case 4:
				Kcn = new Button();
				TcP = new Button();
				goto case 7;
			case 3:
				vA.kN(TcP, bool_0: true, vA.ONF);
				WNe.kN(TcP, jR, WNe.mNA);
				bNg.kN(this, new SizeF(16f, 31f), bNg.WNT);
				UNO.kN(this, (AutoScaleMode)1, UNO.BNC);
				uN2.kN(this, new Size(1141, 625), uN2.DN1);
				xNB.kN(((Control)this).get_Controls(), (Control)(object)TcP, xNB.FNk);
				xNB.kN(((Control)this).get_Controls(), (Control)(object)Kcn, xNB.FNk);
				goto case 10;
			case 1:
				vA.kN(fcc, bool_0: true, vA.ONF);
				goto case 5;
			default:
				gz = new PictureBox();
				fcc = new Button();
				num2 = 4;
				goto case 4;
			case 2:
				yNj.kN(this, (Icon)LNX.kN(object_, "$this.Icon", LNX.YNb), yNj.dNV);
				GNQ.kN(this, new Padding(8, 7, 8, 7), GNQ.WNm);
				Gl.kN(this, "Form1", Gl.jNs);
				Gl.kN(this, "Heads or Tails", Gl.jNx);
				YW.kN(dc5, YW.IZI);
				goto case 11;
			case 11:
				YW.kN(gz, YW.IZI);
				vA.kN(this, bool_0: false, vA.RNy);
				return;
			}
			break;
		}
		goto IL_0069;
		IL_0069:
		num = num2;
		goto IL_0584;
	}

	internal static bool IJ()
	{
		return EB == null;
	}

	internal static f2 wW()
	{
		return EB;
	}

	internal static object lQ(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}
}
