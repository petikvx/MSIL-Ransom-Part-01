using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using eBl9ZK3324M2L6fGA2Z;
using eC98jAqdnPLlDITmK6;
using ehQfPXIwy8Brv4wrAvv;
using ehk9wbIn9KPgnTW5hn8;
using etKNQTu9kgqwCqmIAv;

namespace eBTQk2Isy6kCKhlrwkc;

internal class e8u1B2I6ki2jtqky8Fn : Control
{
	private Label eulODlten = new Label();

	private Image ecs0D1Zdd;

	private Icon e9jslfSvk;

	private Bitmap eeN1kpseb;

	private ejfQ10I1Bg4kStEHvsn elN6Gg9Qb;

	private float eKyrTQhVp;

	private float euXHswL8F;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eo2Gig6Qf;

	public override string Text
	{
		get
		{
			return (string)eEbiD2iBSCuNmBsN3Oj(eulODlten);
		}
		set
		{
			ed5PDuiHkn7dkD6Krr1(eulODlten, value);
		}
	}

	[SpecialName]
	public void method_0(ejfQ10I1Bg4kStEHvsn ejfQ10I1Bg4kStEHvsn_0)
	{
		if (elN6Gg9Qb != ejfQ10I1Bg4kStEHvsn_0)
		{
			eHcU5liIZTDuUFHm4jm();
			ejfQ10I1Bg4kStEHvsn ejfQ10I1Bg4kStEHvsn = default(ejfQ10I1Bg4kStEHvsn);
			if (!ee8XMdi00AfN8u6bCKj())
			{
				elN6Gg9Qb = ejfQ10I1Bg4kStEHvsn_0;
				ejfQ10I1Bg4kStEHvsn = elN6Gg9Qb;
			}
			switch (ejfQ10I1Bg4kStEHvsn)
			{
			default:
				eeN1kpseb = null;
				break;
			case (ejfQ10I1Bg4kStEHvsn)1:
				eeN1kpseb = (Bitmap)ea3mu2ihwEOvUafanoJ(eo2Gig6Qf(24835));
				break;
			case (ejfQ10I1Bg4kStEHvsn)2:
				eeN1kpseb = (Bitmap)ea3mu2ihwEOvUafanoJ(eo2Gig6Qf(24848));
				break;
			}
			eTrqCPiABQGwmXUQw6s(this);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			if (e9jslfSvk != null)
			{
				ee8XMdi00AfN8u6bCKj();
				if (!eHcU5liIZTDuUFHm4jm())
				{
					goto IL_0051;
				}
				e1giLSiWo0DahL4IHFP(e9jslfSvk);
				e9jslfSvk = null;
			}
			if (ecs0D1Zdd != null)
			{
				ea6nqbiccxFeltt68P1(ecs0D1Zdd);
				ecs0D1Zdd = null;
			}
			if (eeN1kpseb != null)
			{
				goto IL_0051;
			}
		}
		goto IL_0063;
		IL_0051:
		ea6nqbiccxFeltt68P1(eeN1kpseb);
		eeN1kpseb = null;
		goto IL_0063;
		IL_0063:
		elx3w7iUUXnyTsupk0E(this, disposing);
	}

	protected override void OnResize(EventArgs e)
	{
		e6qYUZinByfOpB1hax6(eulODlten, eSH3e5ilpDCYhgxMLGh(13f * eKyrTQhVp), eSH3e5ilpDCYhgxMLGh(15f * euXHswL8F), eqtoxmiNtA5xNdrZVJA(this) - eSH3e5ilpDCYhgxMLGh(69f * eKyrTQhVp), eTDpxuirl09ArWvq4Yk(this) - eSH3e5ilpDCYhgxMLGh(18f * euXHswL8F));
		emGSStiPISEhHOcydPL(this, e);
	}

	protected override void ScaleCore(float x, float y)
	{
		eKyrTQhVp = x;
		ee8XMdi00AfN8u6bCKj();
		if (eHcU5liIZTDuUFHm4jm())
		{
		}
		euXHswL8F = y;
		eIqbbUimuehdwUZ6VWu(this, x, y);
		e5ypQAixTM3eUs37VV2(this, EventArgs.Empty);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Rectangle rectangle_ = default(Rectangle);
		if (!ee8XMdi00AfN8u6bCKj())
		{
			do
			{
				e7UixUEjAGLAfbGNj0l(this, e);
				eWlFkTEQO20W7C8QWR3(eF4nRAizo6ZM2QZDZWD(e), eGOiLdE7A7kHArC52P7(), 0, etn785E9EflWhvfjA3F(this).Height - 2, etn785E9EflWhvfjA3F(this).Width, etn785E9EflWhvfjA3F(this).Height - 2);
				eWlFkTEQO20W7C8QWR3(eF4nRAizo6ZM2QZDZWD(e), eAwRpJEkeuPmLeGn0Yh(), 0, etn785E9EflWhvfjA3F(this).Height - 1, etn785E9EflWhvfjA3F(this).Width, etn785E9EflWhvfjA3F(this).Height - 1);
			}
			while (ee8XMdi00AfN8u6bCKj());
			rectangle_ = new Rectangle(etn785E9EflWhvfjA3F(this).Width - eSH3e5ilpDCYhgxMLGh(48f * eKyrTQhVp), eSH3e5ilpDCYhgxMLGh(11f * euXHswL8F), eSH3e5ilpDCYhgxMLGh(32f * eKyrTQhVp), eSH3e5ilpDCYhgxMLGh(32f * euXHswL8F));
			if (ecs0D1Zdd != null)
			{
				eNoBKkELSHlN8R1cpfQ(eF4nRAizo6ZM2QZDZWD(e), ecs0D1Zdd, rectangle_, new Rectangle(0, 0, 32, 32), (GraphicsUnit)2);
				_ = 0;
				if (eHcU5liIZTDuUFHm4jm())
				{
					return;
				}
			}
			else
			{
				if (e9jslfSvk == null)
				{
					return;
				}
				efkSFiEJOGr2RbtQKoO(eF4nRAizo6ZM2QZDZWD(e), e9jslfSvk, rectangle_);
			}
		}
		if (eeN1kpseb != null)
		{
			eNoBKkELSHlN8R1cpfQ(eF4nRAizo6ZM2QZDZWD(e), eeN1kpseb, new Rectangle(rectangle_.Right - eSH3e5ilpDCYhgxMLGh(12f * eKyrTQhVp), rectangle_.Bottom - eSH3e5ilpDCYhgxMLGh(12f * euXHswL8F), eSH3e5ilpDCYhgxMLGh(16f * eKyrTQhVp), eSH3e5ilpDCYhgxMLGh(16f * euXHswL8F)), new Rectangle(0, 0, 16, 16), (GraphicsUnit)2);
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		try
		{
			et8XFYECSlZQT8Jl3jd(eulODlten, (object)new Font((Font)el5tSwE5JmbEkh916O5(this), (FontStyle)1));
			en5mRgEZnU1FPEQHQ7m(this, e);
		}
		catch
		{
		}
	}

	public e8u1B2I6ki2jtqky8Fn()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		while (true)
		{
			eKyrTQhVp = 1f;
			while (true)
			{
				euXHswL8F = 1f;
				ersA0WEgsNyRW1AA2f7(this);
				ee8XMdi00AfN8u6bCKj();
				if (eHcU5liIZTDuUFHm4jm())
				{
					try
					{
						eW1InEE25rR8uBPbwFr(eulODlten, (FlatStyle)3);
						_ = 1;
						if (!ee8XMdi00AfN8u6bCKj())
						{
							et8XFYECSlZQT8Jl3jd(eulODlten, (object)new Font((Font)el5tSwE5JmbEkh916O5(this), (FontStyle)1));
						}
					}
					catch
					{
					}
					eIOrYLEE6ew1Et5raHA(e2R9RREiXlibuQ44xAs(this), eulODlten);
					ecA4lyEffVqhEbH4wt1(this, esbVZeEYLxcEvta85Fb());
					eAA7JxEoAt6ZY8NtBCE(this, bool_0: false);
					edmM4UEXnYjTi0c64wM(this, (DockStyle)1);
					if (ee8XMdi00AfN8u6bCKj())
					{
						continue;
					}
					enlE8dE6XS80VUxTYEQ(this, 58);
					e8wp3vEdyg8Fs9SpD6g(this, (ControlStyles)75794, bool_0: true);
					if (!eHcU5liIZTDuUFHm4jm())
					{
						break;
					}
					e9jslfSvk = (Icon)eFInQMEagLFfWVX1ZQZ();
				}
				e5ypQAixTM3eUs37VV2(this, EventArgs.Empty);
				return;
			}
		}
	}

	public e8u1B2I6ki2jtqky8Fn(string string_0)
		: this()
	{
		ed5PDuiHkn7dkD6Krr1(eulODlten, string_0);
	}

	static e8u1B2I6ki2jtqky8Fn()
	{
		eoRlYpEMZ9BZHqpWQdO(esuo41EypsqtBANJ3Nu(typeof(e8u1B2I6ki2jtqky8Fn).TypeHandle));
	}

	internal static object ea3mu2ihwEOvUafanoJ(object object_0)
	{
		return eRfn8RIiZZHJMAiKnX6.eulODlten((string)object_0);
	}

	internal static void eTrqCPiABQGwmXUQw6s(object object_0)
	{
		((Control)object_0).Refresh();
	}

	internal static bool eHcU5liIZTDuUFHm4jm()
	{
		return true;
	}

	internal static bool ee8XMdi00AfN8u6bCKj()
	{
		return false;
	}

	internal static object eEbiD2iBSCuNmBsN3Oj(object object_0)
	{
		return ((Control)object_0).get_Text();
	}

	internal static void ed5PDuiHkn7dkD6Krr1(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static void e1giLSiWo0DahL4IHFP(object object_0)
	{
		((Icon)object_0).Dispose();
	}

	internal static void ea6nqbiccxFeltt68P1(object object_0)
	{
		((Image)object_0).Dispose();
	}

	internal static void elx3w7iUUXnyTsupk0E(object object_0, bool bool_0)
	{
		((Control)object_0).Dispose(bool_0);
	}

	internal static int eSH3e5ilpDCYhgxMLGh(float float_0)
	{
		return Convert.ToInt32(float_0);
	}

	internal static int eqtoxmiNtA5xNdrZVJA(object object_0)
	{
		return ((Control)object_0).get_Width();
	}

	internal static int eTDpxuirl09ArWvq4Yk(object object_0)
	{
		return ((Control)object_0).get_Height();
	}

	internal static void e6qYUZinByfOpB1hax6(object object_0, int int_0, int int_1, int int_2, int int_3)
	{
		((Control)object_0).SetBounds(int_0, int_1, int_2, int_3);
	}

	internal static void emGSStiPISEhHOcydPL(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static void eIqbbUimuehdwUZ6VWu(object object_0, float float_0, float float_1)
	{
		((Control)object_0).ScaleCore(float_0, float_1);
	}

	internal static void e5ypQAixTM3eUs37VV2(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static object eF4nRAizo6ZM2QZDZWD(object object_0)
	{
		return ((PaintEventArgs)object_0).get_Graphics();
	}

	internal static object eGOiLdE7A7kHArC52P7()
	{
		return SystemPens.get_ControlDark();
	}

	internal static Size etn785E9EflWhvfjA3F(object object_0)
	{
		return ((Control)object_0).get_ClientSize();
	}

	internal static object eAwRpJEkeuPmLeGn0Yh()
	{
		return SystemPens.get_ControlLightLight();
	}

	internal static void eWlFkTEQO20W7C8QWR3(object object_0, object object_1, int int_0, int int_1, int int_2, int int_3)
	{
		((Graphics)object_0).DrawLine((Pen)object_1, int_0, int_1, int_2, int_3);
	}

	internal static void eNoBKkELSHlN8R1cpfQ(object object_0, object object_1, Rectangle rectangle_0, Rectangle rectangle_1, GraphicsUnit graphicsUnit_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		((Graphics)object_0).DrawImage((Image)object_1, rectangle_0, rectangle_1, graphicsUnit_0);
	}

	internal static void efkSFiEJOGr2RbtQKoO(object object_0, object object_1, Rectangle rectangle_0)
	{
		((Graphics)object_0).DrawIcon((Icon)object_1, rectangle_0);
	}

	internal static void e7UixUEjAGLAfbGNj0l(object object_0, object object_1)
	{
		((Control)object_0).OnPaint((PaintEventArgs)object_1);
	}

	internal static object el5tSwE5JmbEkh916O5(object object_0)
	{
		return ((Control)object_0).get_Font();
	}

	internal static void et8XFYECSlZQT8Jl3jd(object object_0, object object_1)
	{
		((Control)object_0).set_Font((Font)object_1);
	}

	internal static void en5mRgEZnU1FPEQHQ7m(object object_0, object object_1)
	{
		((Control)object_0).OnFontChanged((EventArgs)object_1);
	}

	internal static void ersA0WEgsNyRW1AA2f7(object object_0)
	{
		((Control)object_0)._002Ector();
	}

	internal static void eW1InEE25rR8uBPbwFr(object object_0, FlatStyle flatStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Label)object_0).set_FlatStyle(flatStyle_0);
	}

	internal static object e2R9RREiXlibuQ44xAs(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void eIOrYLEE6ew1Et5raHA(object object_0, object object_1)
	{
		((ControlCollection)object_0).Add((Control)object_1);
	}

	internal static Color esbVZeEYLxcEvta85Fb()
	{
		return SystemColors.Window;
	}

	internal static void ecA4lyEffVqhEbH4wt1(object object_0, Color color_0)
	{
		((Control)object_0).set_BackColor(color_0);
	}

	internal static void eAA7JxEoAt6ZY8NtBCE(object object_0, bool bool_0)
	{
		((Control)object_0).set_TabStop(bool_0);
	}

	internal static void edmM4UEXnYjTi0c64wM(object object_0, DockStyle dockStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).set_Dock(dockStyle_0);
	}

	internal static void enlE8dE6XS80VUxTYEQ(object object_0, int int_0)
	{
		((Control)object_0).set_Height(int_0);
	}

	internal static void e8wp3vEdyg8Fs9SpD6g(object object_0, ControlStyles controlStyles_0, bool bool_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).SetStyle(controlStyles_0, bool_0);
	}

	internal static object eFInQMEagLFfWVX1ZQZ()
	{
		return eTUgIV3IyA0FU9PXyfp.euXHswL8F();
	}

	internal static Type esuo41EypsqtBANJ3Nu(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eoRlYpEMZ9BZHqpWQdO(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
