using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace XW;

public class o1 : Form
{
	private IContainer fk;

	private Button mf;

	private Button Qr;

	private TextBox Ty;

	private TextBox Gx;

	private Label AY;

	private Label X8;

	private static o1 h1;

	public string Key
	{
		get
		{
			return Xi.nJ(Gx, Xi.CS);
		}
		set
		{
			Ew.nJ(Gx, value, Ew.yz);
		}
	}

	public string Value
	{
		get
		{
			return Xi.nJ(Ty, Xi.CS);
		}
		set
		{
			Ew.nJ(Ty, value, Ew.yz);
		}
	}

	public o1()
	{
		G3.nJ(G3.By);
		fk = null;
		((Form)this)._002Ector();
		Su.nJ(this, Su.Yl);
	}

	private void s6(object sender, EventArgs e)
	{
		gC.nJ(this, (DialogResult)1, gC.qL);
		Su.nJ(this, Su.b2);
	}

	private void QP(object sender, EventArgs e)
	{
		gC.nJ(this, (DialogResult)2, gC.qL);
		Su.nJ(this, Su.b2);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && fk != null)
		{
			Su.nJ(fk, Su.D4);
			if (!D0())
			{
				switch (0)
				{
				}
			}
		}
		JJO.nJ(this, disposing, JJO.IJJ);
	}

	private void BQ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		X8 = new Label();
		AY = new Label();
		int num = 1;
		int num2 = default(int);
		if (SW() == null)
		{
			while (true)
			{
				switch (num)
				{
				case 11:
					Qr = new Button();
					mf = new Button();
					Su.nJ(this, Su.FJ3);
					goto case 2;
				case 2:
					oJy.nJ(X8, new Point(24, 17), oJy.vJX);
					mJc.nJ(X8, new Padding(6, 0, 6, 0), mJc.GJu);
					Ew.nJ(X8, "keyLabel", Ew.xJP);
					uJt.nJ(X8, new Size(200, 45), uJt.lJp);
					TJw.nJ(X8, 0, TJw.XJh);
					Ew.nJ(X8, "Key", Ew.yz);
					oJy.nJ(AY, new Point(24, 87), oJy.vJX);
					num = 3;
					if (D0())
					{
						continue;
					}
					goto IL_00fb;
				case 6:
					Ew.nJ(AY, "valueLabel", Ew.xJP);
					num = 0;
					if (SW() != null)
					{
						continue;
					}
					break;
				case 3:
					mJc.nJ(AY, new Padding(6, 0, 6, 0), mJc.GJu);
					num = 6;
					if (SW() == null)
					{
						continue;
					}
					goto IL_00fb;
				case 1:
					Gx = new TextBox();
					Ty = new TextBox();
					num = 11;
					if (SW() == null)
					{
						continue;
					}
					goto IL_00fb;
				case 12:
					goto IL_01d5;
				case 5:
					goto IL_0228;
				case 10:
					goto IL_02d0;
				case 8:
					goto IL_0392;
				case 9:
					goto IL_04b8;
				case 4:
					goto IL_04e4;
				case 7:
					return;
					IL_00fb:
					num = num2;
					continue;
				}
				break;
			}
		}
		uJt.nJ(AY, new Size(200, 45), uJt.lJp);
		num2 = 12;
		goto IL_01d5;
		IL_01d5:
		TJw.nJ(AY, 1, TJw.XJh);
		Ew.nJ(AY, "Value", Ew.yz);
		JJO.nJ(Gx, bool_0: false, JJO.BJM);
		oJy.nJ(Gx, new Point(236, 23), oJy.vJX);
		goto IL_0228;
		IL_02d0:
		uJt.nJ(Ty, new Size(500, 38), uJt.lJp);
		TJw.nJ(Ty, 3, TJw.XJh);
		oJy.nJ(Qr, new Point(414, 198), oJy.vJX);
		mJc.nJ(Qr, new Padding(6), mJc.GJu);
		Ew.nJ(Qr, "okay", Ew.xJP);
		uJt.nJ(Qr, new Size(178, 66), uJt.lJp);
		TJw.nJ(Qr, 4, TJw.XJh);
		Ew.nJ(Qr, "&OK", Ew.yz);
		num2 = 8;
		goto IL_0392;
		IL_0392:
		JJO.nJ(Qr, bool_0: true, JJO.aJI);
		PJf.nJ(Qr, s6, PJf.mJ7);
		oJy.nJ(mf, new Point(604, 198), oJy.vJX);
		mJc.nJ(mf, new Padding(6), mJc.GJu);
		Ew.nJ(mf, "cancel", Ew.xJP);
		uJt.nJ(mf, new Size(178, 66), uJt.lJp);
		TJw.nJ(mf, 5, TJw.XJh);
		Ew.nJ(mf, "&Cancel", Ew.yz);
		JJO.nJ(mf, bool_0: true, JJO.aJI);
		PJf.nJ(mf, QP, PJf.mJ7);
		TJk.nJ(this, new SizeF(16f, 31f), TJk.GJd);
		SJQ.nJ(this, (AutoScaleMode)1, SJQ.jJq);
		uJt.nJ(this, new Size(806, 287), uJt.dJ9);
		goto IL_04b8;
		IL_04b8:
		CJZ.nJ(((Control)this).get_Controls(), (Control)(object)mf, CJZ.bJB);
		CJZ.nJ(((Control)this).get_Controls(), (Control)(object)Qr, CJZ.bJB);
		goto IL_04e4;
		IL_0228:
		mJc.nJ(Gx, new Padding(6), mJc.GJu);
		Ew.nJ(Gx, "key", Ew.xJP);
		uJt.nJ(Gx, new Size(500, 38), uJt.lJp);
		TJw.nJ(Gx, 2, TJw.XJh);
		oJy.nJ(Ty, new Point(236, 89), oJy.vJX);
		mJc.nJ(Ty, new Padding(6), mJc.GJu);
		Ew.nJ(Ty, "value", Ew.xJP);
		num2 = 10;
		goto IL_02d0;
		IL_04e4:
		CJZ.nJ(((Control)this).get_Controls(), (Control)(object)Ty, CJZ.bJB);
		CJZ.nJ(Vs(this), (Control)(object)Gx, CJZ.bJB);
		CJZ.nJ(((Control)this).get_Controls(), (Control)(object)AY, CJZ.bJB);
		CJZ.nJ(((Control)this).get_Controls(), (Control)(object)X8, CJZ.bJB);
		mJc.nJ(this, new Padding(6), mJc.zJx);
		Ew.nJ(this, "EditItem", Ew.wJR);
		Ew.nJ(this, "Edit Item", Ew.yz);
		JJO.nJ(this, bool_0: false, JJO.tJi);
		Su.nJ(this, Su.lJ0);
	}

	internal static bool D0()
	{
		return h1 == null;
	}

	internal static o1 SW()
	{
		return h1;
	}

	internal static object Vs(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}
}
