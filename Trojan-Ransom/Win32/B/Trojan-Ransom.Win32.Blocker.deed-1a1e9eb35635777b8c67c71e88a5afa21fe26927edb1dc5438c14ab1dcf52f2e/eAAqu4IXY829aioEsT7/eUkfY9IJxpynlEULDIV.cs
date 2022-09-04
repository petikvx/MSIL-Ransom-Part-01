using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using eC98jAqdnPLlDITmK6;
using ehk9wbIn9KPgnTW5hn8;
using etKNQTu9kgqwCqmIAv;

namespace eAAqu4IXY829aioEsT7;

internal class eUkfY9IJxpynlEULDIV : Control
{
	private readonly Label eKyrTQhVp;

	private Image euXHswL8F;

	private bool eo2Gig6Qf;

	private readonly Timer e8AuvEGCG;

	private bool eb1x595Bx;

	private string ep2oBURlk;

	private float eSmVD9nBi;

	private float ePK4VF7eF;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eirmvo2dG;

	public override string Text
	{
		get
		{
			return (string)eRwwwji2AowGExx2Acu(this);
		}
		set
		{
			eORQoCiidPtcjxesFcV(this, value);
			eqBOijiExckQQfTDEbn(this);
		}
	}

	public void eulODlten()
	{
		eVVS4OiYyiZW2UAuDWS(e8AuvEGCG, bool_0: false);
		euXHswL8F = null;
		e835pLig7PjUlfeUbt4();
		if (!eAteH2iZtYr5I2HQYPF() || !eAteH2iZtYr5I2HQYPF())
		{
		}
		eo2Gig6Qf = false;
		ep2oBURlk = string.Empty;
		eqBOijiExckQQfTDEbn(this);
		eU4rxKifOEKZjg4kNJh(this, 16);
	}

	public void ecs0D1Zdd()
	{
		if (!e835pLig7PjUlfeUbt4())
		{
			eVVS4OiYyiZW2UAuDWS(e8AuvEGCG, bool_0: true);
			euXHswL8F = (Image)e03qM6ios5OxLOCaZlK(eirmvo2dG(24790));
		}
		eo2Gig6Qf = true;
		eqBOijiExckQQfTDEbn(this);
	}

	public void e9jslfSvk()
	{
		eeN1kpseb(string.Empty);
	}

	public void eeN1kpseb(string string_0)
	{
		ep2oBURlk = string_0;
		if (eAteH2iZtYr5I2HQYPF())
		{
			eVVS4OiYyiZW2UAuDWS(e8AuvEGCG, bool_0: false);
			euXHswL8F = (Image)e03qM6ios5OxLOCaZlK((evlTByiXvhgkYF6cZ8N(string_0) > 0) ? eirmvo2dG(24808) : eirmvo2dG(24803));
			eb1x595Bx = true;
			_ = 0;
			if (!eAteH2iZtYr5I2HQYPF())
			{
			}
		}
		eo2Gig6Qf = true;
		if (evlTByiXvhgkYF6cZ8N(string_0) > 0)
		{
			eU4rxKifOEKZjg4kNJh(this, 100);
		}
		eqBOijiExckQQfTDEbn(this);
	}

	protected override void OnResize(EventArgs e)
	{
		if (!e835pLig7PjUlfeUbt4())
		{
			eo9wPMiygPbd95cWAgJ(eKyrTQhVp, e6Dk0ri6wM82YNJXSEX(22f * eSmVD9nBi), e6Dk0ri6wM82YNJXSEX(ePK4VF7eF), eh6HtfideTDIlsWKE5b(this) - e6Dk0ri6wM82YNJXSEX(22f * eSmVD9nBi), eLxLWFiaLYC6DDJeOm9(this) - e6Dk0ri6wM82YNJXSEX(ePK4VF7eF));
			_ = 1;
			if (e835pLig7PjUlfeUbt4())
			{
				return;
			}
			if (!e835pLig7PjUlfeUbt4())
			{
			}
		}
		eP49ELiM9Zmp9wxAEwl(this, e);
	}

	protected override void ScaleCore(float x, float y)
	{
		e835pLig7PjUlfeUbt4();
		if (eAteH2iZtYr5I2HQYPF())
		{
			eSmVD9nBi = x;
			ePK4VF7eF = y;
		}
		e7ZjsZiuruyGQdxRb3W(this, x, y);
		eBtsuiibH4OpsMEFPGs(this, EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ewIuAgi8K5wslMPPVaT(this, e);
		if (edNaToiS7ORNyRUV5AI(this))
		{
			euXHswL8F = (Image)e03qM6ios5OxLOCaZlK(eirmvo2dG(24790));
			_ = 0;
			if (eAteH2iZtYr5I2HQYPF())
			{
				eo2Gig6Qf = true;
			}
		}
		if (euXHswL8F != null && eb1x595Bx)
		{
			exfMfTiwQJvFrGmUqFT(e1fK2KiDs7OwCIyFKOX(e), euXHswL8F, new Rectangle(0, 0, e6Dk0ri6wM82YNJXSEX(16f * eSmVD9nBi), e6Dk0ri6wM82YNJXSEX(16f * ePK4VF7eF)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
		if (eo2Gig6Qf)
		{
			ea2FbJi49GdpX1AVdpk(eKyrTQhVp, (evlTByiXvhgkYF6cZ8N(ep2oBURlk) > 0) ? egahdLivQBkREZKhXSS(eRwwwji2AowGExx2Acu(this), eirmvo2dG(24817), ep2oBURlk, eirmvo2dG(24822)) : eRwwwji2AowGExx2Acu(this));
		}
		else
		{
			ea2FbJi49GdpX1AVdpk(eKyrTQhVp, string.Empty);
		}
	}

	public eUkfY9IJxpynlEULDIV()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		int num = 10;
		while (true)
		{
			eKyrTQhVp = new Label();
			num = 7;
			if (eAteH2iZtYr5I2HQYPF())
			{
				goto IL_002c;
			}
			goto IL_0109;
			IL_0109:
			ep2oBURlk = string.Empty;
			num = 1;
			goto IL_00df;
			IL_00df:
			eSmVD9nBi = 1f;
			num = 5;
			goto IL_00d2;
			IL_00d2:
			ePK4VF7eF = 1f;
			goto IL_00ca;
			IL_00ca:
			eA2xVKipFnEgW6HHo0I(this);
			goto IL_007e;
			IL_007e:
			eEtBxoiVCRe4PTNSWQF(e8AuvEGCG, 250);
			num = 8;
			if (e835pLig7PjUlfeUbt4())
			{
				goto IL_000e;
			}
			goto IL_002c;
			IL_000e:
			e8AuvEGCG = new Timer();
			num = 6;
			if (!e835pLig7PjUlfeUbt4())
			{
				goto IL_002c;
			}
			goto IL_00f5;
			IL_002c:
			switch (num)
			{
			case 7:
				break;
			default:
				num = 9;
				goto IL_007e;
			case 9:
				goto IL_007e;
			case 8:
				eha5E2iTKpdBKQkRj0w(e8AuvEGCG, new EventHandler(elN6Gg9Qb));
				num = 13;
				if (e835pLig7PjUlfeUbt4())
				{
					goto IL_00ca;
				}
				goto case 13;
			case 2:
				goto IL_00ca;
			case 5:
				goto IL_00d2;
			case 1:
				goto IL_00df;
			case 6:
				goto IL_00f5;
			case 3:
			case 12:
				goto IL_0109;
			case 10:
				continue;
			case 13:
				ebv1Z9iGtUT6c59Q9ms(eKyrTQhVp, (FlatStyle)3);
				num = 0;
				goto case 0;
			case 0:
				enfg1Ti1023GZN4sLHV(eu038AitYwcoJQlYl4d(this), eKyrTQhVp);
				goto IL_0171;
			case 4:
			case 11:
				goto IL_0171;
			case 14:
				goto end_IL_011f;
			case 15:
				return;
			}
			goto IL_000e;
			IL_00f5:
			eb1x595Bx = true;
			eAteH2iZtYr5I2HQYPF();
			if (!e835pLig7PjUlfeUbt4())
			{
				goto IL_0109;
			}
			num = 4;
			goto IL_0171;
			IL_0171:
			ekY7gliR30qQxlQI4cr(this, (ControlStyles)75794, bool_0: true);
			num = 14;
			break;
			continue;
			end_IL_011f:
			break;
		}
		eaNMXgiqwDxrt5YkRjX(this, bool_0: false);
	}

	public eUkfY9IJxpynlEULDIV(string string_0)
		: this()
	{
		eORQoCiidPtcjxesFcV(this, e9K9AViO4XiICexTnqM(eirmvo2dG(22184), string_0));
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (euXHswL8F != null)
			{
				_ = 0;
				if (!eAteH2iZtYr5I2HQYPF())
				{
					return;
				}
				egHK5ri38UwXxEDGPnN(euXHswL8F);
			}
			eFN3H4iFjRuC0bdbEaj(e8AuvEGCG);
		}
		efmMDPiePGRQPCZ0ywe(this, disposing);
	}

	private void elN6Gg9Qb(object sender, EventArgs e)
	{
		eb1x595Bx = !eb1x595Bx;
		eqBOijiExckQQfTDEbn(this);
	}

	static eUkfY9IJxpynlEULDIV()
	{
		ec5XasiseANMHNLQEfp(ete03IiKfrr3ldIUgHv(typeof(eUkfY9IJxpynlEULDIV).TypeHandle));
	}

	internal static object eRwwwji2AowGExx2Acu(object object_0)
	{
		return ((Control)object_0).get_Text();
	}

	internal static void eORQoCiidPtcjxesFcV(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void eqBOijiExckQQfTDEbn(object object_0)
	{
		((Control)object_0).Refresh();
	}

	internal static bool eAteH2iZtYr5I2HQYPF()
	{
		return true;
	}

	internal static bool e835pLig7PjUlfeUbt4()
	{
		return false;
	}

	internal static void eVVS4OiYyiZW2UAuDWS(object object_0, bool bool_0)
	{
		((Timer)object_0).set_Enabled(bool_0);
	}

	internal static void eU4rxKifOEKZjg4kNJh(object object_0, int int_0)
	{
		((Control)object_0).set_Height(int_0);
	}

	internal static object e03qM6ios5OxLOCaZlK(object object_0)
	{
		return eRfn8RIiZZHJMAiKnX6.eulODlten((string)object_0);
	}

	internal static int evlTByiXvhgkYF6cZ8N(object object_0)
	{
		return ((string)object_0).Length;
	}

	internal static int e6Dk0ri6wM82YNJXSEX(float float_0)
	{
		return Convert.ToInt32(float_0);
	}

	internal static int eh6HtfideTDIlsWKE5b(object object_0)
	{
		return ((Control)object_0).get_Width();
	}

	internal static int eLxLWFiaLYC6DDJeOm9(object object_0)
	{
		return ((Control)object_0).get_Height();
	}

	internal static void eo9wPMiygPbd95cWAgJ(object object_0, int int_0, int int_1, int int_2, int int_3)
	{
		((Control)object_0).SetBounds(int_0, int_1, int_2, int_3);
	}

	internal static void eP49ELiM9Zmp9wxAEwl(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static void e7ZjsZiuruyGQdxRb3W(object object_0, float float_0, float float_1)
	{
		((Control)object_0).ScaleCore(float_0, float_1);
	}

	internal static void eBtsuiibH4OpsMEFPGs(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static bool edNaToiS7ORNyRUV5AI(object object_0)
	{
		return ((Component)object_0).DesignMode;
	}

	internal static object e1fK2KiDs7OwCIyFKOX(object object_0)
	{
		return ((PaintEventArgs)object_0).get_Graphics();
	}

	internal static object egahdLivQBkREZKhXSS(object object_0, object object_1, object object_2, object object_3)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2 + (string?)object_3;
	}

	internal static void ewIuAgi8K5wslMPPVaT(object object_0, object object_1)
	{
		((Control)object_0).OnPaint((PaintEventArgs)object_1);
	}

	internal static void exfMfTiwQJvFrGmUqFT(object object_0, object object_1, Rectangle rectangle_0, Rectangle rectangle_1, GraphicsUnit graphicsUnit_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		((Graphics)object_0).DrawImage((Image)object_1, rectangle_0, rectangle_1, graphicsUnit_0);
	}

	internal static void ea2FbJi49GdpX1AVdpk(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void eA2xVKipFnEgW6HHo0I(object object_0)
	{
		((Control)object_0)._002Ector();
	}

	internal static void eEtBxoiVCRe4PTNSWQF(object object_0, int int_0)
	{
		((Timer)object_0).set_Interval(int_0);
	}

	internal static void eha5E2iTKpdBKQkRj0w(object object_0, object object_1)
	{
		((Timer)object_0).add_Tick((EventHandler)object_1);
	}

	internal static void ebv1Z9iGtUT6c59Q9ms(object object_0, FlatStyle flatStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Label)object_0).set_FlatStyle(flatStyle_0);
	}

	internal static object eu038AitYwcoJQlYl4d(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void enfg1Ti1023GZN4sLHV(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static void ekY7gliR30qQxlQI4cr(object object_0, ControlStyles controlStyles_0, bool bool_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).SetStyle(controlStyles_0, bool_0);
	}

	internal static void eaNMXgiqwDxrt5YkRjX(object object_0, bool bool_0)
	{
		((Control)object_0).set_TabStop(bool_0);
	}

	internal static object e9K9AViO4XiICexTnqM(object object_0, object object_1)
	{
		return (string?)object_0 + (string?)object_1;
	}

	internal static void egHK5ri38UwXxEDGPnN(object object_0)
	{
		((Image)object_0).Dispose();
	}

	internal static void eFN3H4iFjRuC0bdbEaj(object object_0)
	{
		((Component)object_0).Dispose();
	}

	internal static void efmMDPiePGRQPCZ0ywe(object object_0, bool bool_0)
	{
		((Control)object_0).Dispose(bool_0);
	}

	internal static Type ete03IiKfrr3ldIUgHv(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void ec5XasiseANMHNLQEfp(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
