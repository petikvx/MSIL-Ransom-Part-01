using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace vc;

public class fL : Form
{
	private IContainer Ek;

	private Button rp;

	private Button hB;

	private TextBox Pi;

	private TextBox pe;

	private Label Pr;

	private Label ew;

	internal static fL No;

	public string Key
	{
		get
		{
			return Xv.kN(pe, Xv.RNU);
		}
		set
		{
			Gl.kN(pe, value, Gl.jNx);
		}
	}

	public string Value
	{
		get
		{
			return Xv.kN(Pi, Xv.RNU);
		}
		set
		{
			Gl.kN(Pi, value, Gl.jNx);
		}
	}

	public fL()
	{
		OZ.kN(OZ.Ou);
		Ek = null;
		((Form)this)._002Ector();
		YW.kN(this, YW.lNl);
	}

	private void nt(object sender, EventArgs e)
	{
		HNt.kN(this, (DialogResult)1, HNt.FNa);
		YW.kN(this, YW.PN9);
	}

	private void AC(object sender, EventArgs e)
	{
		HNt.kN(this, (DialogResult)2, HNt.FNa);
		YW.kN(this, YW.PN9);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && Ek != null)
		{
			YW.kN(Ek, YW.iNf);
		}
		vA.kN(this, disposing, vA.tNR);
		int num = 0;
		if (!C8())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	private void GJ()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0346: Expected O, but got Unknown
		//IL_0347: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05af: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		ComponentResourceManager object_ = new ComponentResourceManager(INq.kN(typeof(fL).TypeHandle, INq.PN6));
		ew = new Label();
		Pr = new Label();
		pe = new TextBox();
		int num = 1;
		if (r0() == null)
		{
			goto IL_033b;
		}
		goto IL_05d0;
		IL_05d0:
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			case 12:
				break;
			case 10:
				QND.kN(rp, new Point(604, 198), QND.RNi);
				GNQ.kN(rp, new Padding(6, 6, 6, 6), GNQ.VNn);
				Gl.kN(rp, "cancel", Gl.MNM);
				uN2.kN(rp, new Size(178, 66), uN2.SN7);
				goto case 2;
			case 2:
				TN5.kN(rp, 5, TN5.uNP);
				Gl.kN(rp, "&Cancel", Gl.jNx);
				vA.kN(rp, bool_0: true, vA.ONF);
				WNe.kN(rp, AC, WNe.mNA);
				num = 12;
				if (C8())
				{
					continue;
				}
				goto IL_0082;
			case 9:
				goto end_IL_05d0;
			case 7:
				goto IL_01d0;
			case 8:
				goto IL_030b;
			case 6:
				vA.kN(this, bool_0: false, vA.RNy);
				num = 9;
				if (!C8())
				{
					continue;
				}
				goto case 11;
			case 5:
				goto IL_033b;
			case 4:
				GNQ.kN(this, new Padding(6, 6, 6, 6), GNQ.WNm);
				Gl.kN(this, "EditItem", Gl.jNs);
				Gl.kN(this, "Edit Item", Gl.jNx);
				num2 = 6;
				goto case 6;
			case 3:
				GNQ.kN(hB, new Padding(6, 6, 6, 6), GNQ.VNn);
				Gl.kN(hB, "okay", Gl.MNM);
				uN2.kN(hB, new Size(178, 66), uN2.SN7);
				TN5.kN(hB, 4, TN5.uNP);
				Gl.kN(hB, "&OK", Gl.jNx);
				vA.kN(hB, bool_0: true, vA.ONF);
				WNe.kN(hB, nt, WNe.mNA);
				num2 = 10;
				goto case 10;
			case 1:
				QND.kN(Pi, new Point(236, 89), QND.RNi);
				GNQ.kN(Pi, new Padding(6, 6, 6, 6), GNQ.VNn);
				Gl.kN(Pi, "value", Gl.MNM);
				uN2.kN(Pi, new Size(500, 38), uN2.SN7);
				TN5.kN(Pi, 3, TN5.uNP);
				QND.kN(hB, new Point(414, 198), QND.RNi);
				num = 3;
				if (r0() == null)
				{
					continue;
				}
				goto IL_0082;
			default:
				uN2.kN(this, new Size(806, 287), uN2.DN1);
				xNB.kN(((Control)this).get_Controls(), (Control)(object)rp, xNB.FNk);
				xNB.kN(LZ(this), (Control)(object)hB, xNB.FNk);
				xNB.kN(((Control)this).get_Controls(), (Control)(object)Pi, xNB.FNk);
				xNB.kN(((Control)this).get_Controls(), (Control)(object)pe, xNB.FNk);
				xNB.kN(((Control)this).get_Controls(), (Control)(object)Pr, xNB.FNk);
				xNB.kN(LZ(this), (Control)(object)ew, xNB.FNk);
				yNj.kN(this, (Icon)LNX.kN(object_, "$this.Icon", LNX.YNb), yNj.dNV);
				num = 4;
				if (r0() == null)
				{
					continue;
				}
				goto IL_0082;
			case 11:
				YW.kN(this, YW.wNH);
				return;
			}
			bNg.kN(this, new SizeF(16f, 31f), bNg.WNT);
			UNO.kN(this, (AutoScaleMode)1, UNO.BNC);
			num = 0;
			if (r0() == null)
			{
				continue;
			}
			goto IL_0082;
			continue;
			end_IL_05d0:
			break;
		}
		goto IL_015c;
		IL_0082:
		num = num2;
		goto IL_05d0;
		IL_033b:
		Pi = new TextBox();
		hB = new Button();
		rp = new Button();
		num2 = 8;
		goto IL_030b;
		IL_030b:
		YW.kN(this, YW.BNL);
		goto IL_015c;
		IL_015c:
		QND.kN(ew, new Point(24, 17), QND.RNi);
		GNQ.kN(ew, new Padding(6, 0, 6, 0), GNQ.VNn);
		Gl.kN(ew, "keyLabel", Gl.MNM);
		uN2.kN(ew, new Size(200, 45), uN2.SN7);
		TN5.kN(ew, 0, TN5.uNP);
		goto IL_01d0;
		IL_01d0:
		Gl.kN(ew, "Key", Gl.jNx);
		QND.kN(Pr, new Point(24, 87), QND.RNi);
		GNQ.kN(Pr, new Padding(6, 0, 6, 0), GNQ.VNn);
		Gl.kN(Pr, "valueLabel", Gl.MNM);
		uN2.kN(Pr, new Size(200, 45), uN2.SN7);
		TN5.kN(Pr, 1, TN5.uNP);
		Gl.kN(Pr, "Value", Gl.jNx);
		vA.kN(pe, bool_0: false, vA.YNp);
		QND.kN(pe, new Point(236, 23), QND.RNi);
		GNQ.kN(pe, new Padding(6, 6, 6, 6), GNQ.VNn);
		Gl.kN(pe, "key", Gl.MNM);
		uN2.kN(pe, new Size(500, 38), uN2.SN7);
		TN5.kN(pe, 2, TN5.uNP);
		num = 1;
		if (!C8())
		{
			goto IL_0082;
		}
		goto IL_05d0;
	}

	internal static bool C8()
	{
		return No == null;
	}

	internal static fL r0()
	{
		return No;
	}

	internal static object LZ(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}
}
