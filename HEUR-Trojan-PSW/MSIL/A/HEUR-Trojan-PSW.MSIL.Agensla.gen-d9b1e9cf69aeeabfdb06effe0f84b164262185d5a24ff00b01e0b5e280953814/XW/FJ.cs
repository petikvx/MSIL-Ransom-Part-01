using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XW;

public class FJ : Form
{
	private IContainer OWI;

	private Label bW1;

	private Label kW5;

	private TextBox sWJ;

	private TextBox AW9;

	private Label oWp;

	private Label uWZ;

	private Button oWu;

	private Button EWe;

	private Button dWA;

	internal static FJ lC;

	public FJ()
	{
		G3.nJ(G3.By);
		OWI = null;
		((Form)this)._002Ector();
		Su.nJ(this, Su.u3l);
	}

	private void cWv(object sender, EventArgs e)
	{
		Su.nJ(this, Su.b2);
	}

	private void YW4(object sender, EventArgs e)
	{
		decimal decimal_ = G3C.nJ(Xi.nJ(sWJ, Xi.CS), G3C.V3L);
		decimal decimal_2 = G3C.nJ(Xi.nJ(AW9, Xi.CS), G3C.V3L);
		decimal_2 = H32.nJ(decimal_2, 100m, H32.a3S);
		decimal decimal_3 = H32.nJ(decimal_, decimal_2, H32.q3z);
		decimal decimal_4 = H32.nJ(decimal_, decimal_3, H32.pyO);
		Ew.nJ(uWZ, JyJ.nJ(ref decimal_4, "c", JyJ.ey3), Ew.yz);
		if (!RJ())
		{
			switch (0)
			{
			}
		}
	}

	private void jWU(object sender, EventArgs e)
	{
		Su.nJ(sWJ, Su.Jyy);
		Su.nJ(AW9, Su.Jyy);
		Ew.nJ(uWZ, "", Ew.yz);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && OWI != null)
		{
			Su.nJ(OWI, Su.D4);
		}
		JJO.nJ(this, disposing, JJO.IJJ);
	}

	private void OWG()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0689: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Expected O, but got Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dd: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f3: Expected O, but got Unknown
		//IL_0888: Unknown result type (might be due to invalid IL or missing references)
		//IL_0897: Expected O, but got Unknown
		//IL_089c: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager object_ = new ComponentResourceManager(aG.nJ(typeof(FJ).TypeHandle, aG.ta));
		bW1 = new Label();
		kW5 = new Label();
		sWJ = new TextBox();
		AW9 = new TextBox();
		int num2 = default(int);
		while (true)
		{
			oWp = new Label();
			uWZ = new Label();
			oWu = new Button();
			EWe = new Button();
			int num = 8;
			if (FN() != null)
			{
				goto IL_0165;
			}
			goto IL_076d;
			IL_076d:
			while (true)
			{
				switch (num)
				{
				case 19:
					uJt.nJ(oWu, new Size(200, 100), uJt.lJp);
					num = 1;
					if (FN() != null)
					{
						continue;
					}
					goto case 3;
				case 3:
					TJw.nJ(oWu, 6, TJw.XJh);
					Ew.nJ(oWu, "&Calculate Set Price", Ew.yz);
					JJO.nJ(oWu, bool_0: true, JJO.aJI);
					PJf.nJ(oWu, YW4, PJf.mJ7);
					oJy.nJ(EWe, new Point(589, 346), oJy.vJX);
					mJc.nJ(EWe, new Padding(8, 7, 8, 7), mJc.GJu);
					Ew.nJ(EWe, "exitButton", Ew.xJP);
					uJt.nJ(EWe, new Size(200, 100), uJt.lJp);
					TJw.nJ(EWe, 7, TJw.XJh);
					Ew.nJ(EWe, "&Exit", Ew.yz);
					num = 0;
					if (RJ())
					{
						continue;
					}
					goto IL_0165;
				case 18:
					Dyc.nJ(uWZ, (BorderStyle)1, Dyc.Xyu);
					oJy.nJ(uWZ, new Point(459, 248), oJy.vJX);
					num = 2;
					if (FN() != null)
					{
						continue;
					}
					goto case 2;
				case 2:
					mJc.nJ(uWZ, new Padding(8, 0, 8, 0), mJc.GJu);
					Ew.nJ(uWZ, "salePriceLabel", Ew.xJP);
					uJt.nJ(uWZ, new Size(373, 52), uJt.lJp);
					TJw.nJ(uWZ, 5, TJw.XJh);
					EyP.nJ(uWZ, (ContentAlignment)32, EyP.ayt);
					num = 16;
					if (RJ())
					{
						continue;
					}
					goto IL_0165;
				case 17:
					mJc.nJ(kW5, new Padding(8, 0, 8, 0), mJc.GJu);
					Ew.nJ(kW5, "label2", Ew.xJP);
					goto case 9;
				case 9:
					uJt.nJ(kW5, new Size(402, 32), uJt.lJp);
					num = 11;
					if (FN() == null)
					{
						continue;
					}
					goto IL_0165;
				case 16:
					oJy.nJ(oWu, new Point(101, 346), oJy.vJX);
					mJc.nJ(oWu, new Padding(8, 7, 8, 7), mJc.GJu);
					Ew.nJ(oWu, "calculateButton", Ew.xJP);
					goto case 19;
				case 15:
					mJc.nJ(oWp, new Padding(8, 0, 8, 0), mJc.GJu);
					Ew.nJ(oWp, "label3", Ew.xJP);
					uJt.nJ(oWp, new Size(153, 32), uJt.lJp);
					TJw.nJ(oWp, 4, TJw.XJh);
					goto case 13;
				case 13:
					Ew.nJ(oWp, "Sale Price:", Ew.yz);
					num2 = 18;
					goto case 18;
				case 14:
					zyp.nJ(this, (IButtonControl)(object)oWu, zyp.ryw);
					TJk.nJ(this, new SizeF(16f, 31f), TJk.GJd);
					SJQ.nJ(this, (AutoScaleMode)1, SJQ.jJq);
					uJt.nJ(this, new Size(891, 501), uJt.dJ9);
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)dWA, CJZ.bJB);
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)EWe, CJZ.bJB);
					goto case 10;
				case 10:
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)oWu, CJZ.bJB);
					goto case 6;
				case 6:
					CJZ.nJ(pa(this), (Control)(object)uWZ, CJZ.bJB);
					num = 1;
					if (RJ())
					{
						continue;
					}
					goto IL_0165;
				case 12:
					mJc.nJ(dWA, new Padding(8, 7, 8, 7), mJc.GJu);
					Ew.nJ(dWA, "clearButton", Ew.xJP);
					uJt.nJ(dWA, new Size(200, 100), uJt.lJp);
					TJw.nJ(dWA, 8, TJw.XJh);
					Ew.nJ(dWA, "&Reset", Ew.yz);
					JJO.nJ(dWA, bool_0: true, JJO.aJI);
					PJf.nJ(dWA, jWU, PJf.mJ7);
					goto case 14;
				case 11:
					TJw.nJ(kW5, 1, TJw.XJh);
					Ew.nJ(kW5, "Enter the discount percentage:", Ew.yz);
					oJy.nJ(sWJ, new Point(459, 72), oJy.vJX);
					mJc.nJ(sWJ, new Padding(8, 7, 8, 7), mJc.GJu);
					Ew.nJ(sWJ, "originalPriceTextbox", Ew.xJP);
					num = 4;
					if (FN() == null)
					{
						continue;
					}
					goto IL_0165;
				case 8:
					dWA = new Button();
					Su.nJ(this, Su.FJ3);
					JJO.nJ(bW1, bool_0: true, JJO.EyX);
					oJy.nJ(bW1, new Point(59, 79), oJy.vJX);
					mJc.nJ(bW1, new Padding(8, 0, 8, 0), mJc.GJu);
					Ew.nJ(bW1, "label1", Ew.xJP);
					uJt.nJ(bW1, new Size(388, 32), uJt.lJp);
					TJw.nJ(bW1, 0, TJw.XJh);
					Ew.nJ(bW1, "Enter the item's original price:", Ew.yz);
					JJO.nJ(kW5, bool_0: true, JJO.EyX);
					oJy.nJ(kW5, new Point(35, 148), oJy.vJX);
					num = 17;
					if (RJ())
					{
						continue;
					}
					goto IL_0165;
				case 4:
					uJt.nJ(sWJ, new Size(393, 38), uJt.lJp);
					TJw.nJ(sWJ, 2, TJw.XJh);
					oJy.nJ(AW9, new Point(459, 141), oJy.vJX);
					mJc.nJ(AW9, new Padding(8, 7, 8, 7), mJc.GJu);
					Ew.nJ(AW9, "discountPercentageTextBox", Ew.xJP);
					uJt.nJ(AW9, new Size(393, 38), uJt.lJp);
					TJw.nJ(AW9, 3, TJw.XJh);
					JJO.nJ(oWp, bool_0: true, JJO.EyX);
					oJy.nJ(oWp, new Point(288, 248), oJy.vJX);
					goto case 15;
				default:
					JJO.nJ(EWe, bool_0: true, JJO.aJI);
					PJf.nJ(EWe, cWv, PJf.mJ7);
					oJy.nJ(dWA, new Point(344, 346), oJy.vJX);
					num = 9;
					if (FN() != null)
					{
						continue;
					}
					goto case 12;
				case 7:
					break;
				case 1:
					CJZ.nJ(pa(this), (Control)(object)oWp, CJZ.bJB);
					CJZ.nJ(pa(this), (Control)(object)AW9, CJZ.bJB);
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)sWJ, CJZ.bJB);
					goto case 5;
				case 5:
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)kW5, CJZ.bJB);
					CJZ.nJ(((Control)this).get_Controls(), (Control)(object)bW1, CJZ.bJB);
					a3V.nJ(this, (Icon)o3E.nJ(object_, "$this.Icon", o3E.z3s), a3V.f3W);
					mJc.nJ(this, new Padding(8, 7, 8, 7), mJc.zJx);
					Ew.nJ(this, "Form1", Ew.wJR);
					gyh.nJ(this, (FormStartPosition)1, gyh.HyM);
					Ew.nJ(this, "Sale Price Calculator", Ew.yz);
					JJO.nJ(this, bool_0: false, JJO.tJi);
					Su.nJ(this, Su.lJ0);
					return;
				}
				break;
			}
			continue;
			IL_0165:
			num = num2;
			goto IL_076d;
		}
	}

	internal static bool RJ()
	{
		return lC == null;
	}

	internal static FJ FN()
	{
		return lC;
	}

	internal static object pa(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}
}
