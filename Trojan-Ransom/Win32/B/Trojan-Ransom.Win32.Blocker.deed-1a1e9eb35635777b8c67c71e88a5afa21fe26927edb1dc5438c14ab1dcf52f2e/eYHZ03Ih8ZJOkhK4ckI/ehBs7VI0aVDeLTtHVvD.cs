using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using eC98jAqdnPLlDITmK6;
using ehk9wbIn9KPgnTW5hn8;
using etKNQTu9kgqwCqmIAv;

namespace eYHZ03Ih8ZJOkhK4ckI;

internal class ehBs7VI0aVDeLTtHVvD : Control
{
	private int e9jslfSvk;

	private readonly Bitmap eeN1kpseb;

	private readonly Bitmap elN6Gg9Qb;

	private readonly Timer eKyrTQhVp;

	private float euXHswL8F;

	private float eo2Gig6Qf;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk e8AuvEGCG;

	protected override void OnVisibleChanged(EventArgs e)
	{
		emB998ErdOyttYrQ8gR();
		if (eu1DXYENZYnkgt4BnKk())
		{
		}
		e86dpDEmJ6erKrCYvZ6(this, e);
		if (!eiiy28EnhcR1tl5Sqym(this))
		{
			eulODlten(e3gNI9EPfkQTycXHOxn(this));
		}
	}

	private void eulODlten(bool bool_0)
	{
		eIipVhEx3fYQZaM9ybM(eKyrTQhVp, bool_0);
		e9jslfSvk = 0;
		ePrdeCEzAVvckxtxDKQ(this);
	}

	protected override void OnResize(EventArgs e)
	{
		ehKJnyY9cSQ2wMbj5q9(this, new Size(eqlomeY7WWe1QBgJxDI(250f * euXHswL8F), eqlomeY7WWe1QBgJxDI(42f * eo2Gig6Qf)));
		e6tFKdYkGSK3OHE3BKW(this, e);
		if (!eu1DXYENZYnkgt4BnKk())
		{
		}
	}

	protected override void ScaleCore(float x, float y)
	{
		emB998ErdOyttYrQ8gR();
		if (eu1DXYENZYnkgt4BnKk())
		{
		}
		euXHswL8F = x;
		eo2Gig6Qf = y;
		eOA91QYQ62vSAwxeZ6R(this, x, y);
		elO8PXYLaxmD7roqhhK(this, EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (eu1DXYENZYnkgt4BnKk())
		{
		}
		if (disposing)
		{
			if (eeN1kpseb != null)
			{
				eu1DXYENZYnkgt4BnKk();
				if (emB998ErdOyttYrQ8gR())
				{
					return;
				}
				e0NYnZYJSZCPpPZbTbE(eeN1kpseb);
			}
			eVYeX0YjdaQDUucgduX(eKyrTQhVp);
		}
		eOo1g9Y5yTRTWAaytPw(this, disposing);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		while (true)
		{
			e25WBZYZZy8gJnBPKyJ(this, e);
			if (elN6Gg9Qb != null)
			{
				eSS8QXYggmI35FyGDY4(e0PoxnYCQaSJPqUNfit(e), elN6Gg9Qb, new Rectangle(0, 0, eqlomeY7WWe1QBgJxDI(250f * euXHswL8F), eqlomeY7WWe1QBgJxDI(42f * eo2Gig6Qf)), new Rectangle(0, 0, 250, 42), (GraphicsUnit)2);
			}
			if (eeN1kpseb == null)
			{
				break;
			}
			if (!eu1DXYENZYnkgt4BnKk())
			{
				continue;
			}
			if (e9jslfSvk > 0)
			{
				e85fs1Y2LptIvAnuCjW(e0PoxnYCQaSJPqUNfit(e), new Rectangle(eqlomeY7WWe1QBgJxDI(46f * euXHswL8F), 0, eqlomeY7WWe1QBgJxDI(165f * euXHswL8F), eqlomeY7WWe1QBgJxDI(34f * eo2Gig6Qf)));
				eNkypGYibkaW6XFSJXj(e0PoxnYCQaSJPqUNfit(e), eeN1kpseb, new Rectangle(eqlomeY7WWe1QBgJxDI((float)(e9jslfSvk - 6) * euXHswL8F), eqlomeY7WWe1QBgJxDI(16f * eo2Gig6Qf), eqlomeY7WWe1QBgJxDI(40f * euXHswL8F), eqlomeY7WWe1QBgJxDI(12f * eo2Gig6Qf)), 0, 0, 40, 12, (GraphicsUnit)2);
			}
			break;
		}
	}

	private void ecs0D1Zdd(object sender, EventArgs e)
	{
		e9jslfSvk += 11;
		if (e9jslfSvk > 198)
		{
			e9jslfSvk = 0;
		}
		ePrdeCEzAVvckxtxDKQ(this);
	}

	public ehBs7VI0aVDeLTtHVvD()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		_ = 0;
		if (eu1DXYENZYnkgt4BnKk() || emB998ErdOyttYrQ8gR())
		{
			e9jslfSvk = 99;
			eeN1kpseb = (Bitmap)eNa44AYEF4OUaRtI1kx(e8AuvEGCG(25163));
			goto IL_0035;
		}
		goto IL_007d;
		IL_0035:
		elN6Gg9Qb = (Bitmap)eNa44AYEF4OUaRtI1kx(e8AuvEGCG(25172));
		eKyrTQhVp = new Timer();
		euXHswL8F = 1f;
		do
		{
			eo2Gig6Qf = 1f;
		}
		while (!eu1DXYENZYnkgt4BnKk());
		e7XQdbYYpoHa4KqdGne(this);
		goto IL_007d;
		IL_007d:
		e047g2YfwvkSeFLeNZO(eKyrTQhVp, 85);
		eMk7x5Yo67GQnjRRxeJ(eKyrTQhVp, new EventHandler(ecs0D1Zdd));
		ehKJnyY9cSQ2wMbj5q9(this, new Size(250, 42));
		ehWRlyYXNuIEXliyQZO(this, bool_0: false);
		e85xegY6dZ2U52eWy52(this, (ControlStyles)75794, bool_0: true);
		if (eu1DXYENZYnkgt4BnKk())
		{
			return;
		}
		goto IL_0035;
	}

	static ehBs7VI0aVDeLTtHVvD()
	{
		eOsrSrYaZmuXnC9Ihi9(e6JkUAYdGIIECoGvHjs(typeof(ehBs7VI0aVDeLTtHVvD).TypeHandle));
	}

	internal static bool eiiy28EnhcR1tl5Sqym(object object_0)
	{
		return ((Component)object_0).DesignMode;
	}

	internal static bool e3gNI9EPfkQTycXHOxn(object object_0)
	{
		return ((Control)object_0).get_Visible();
	}

	internal static void e86dpDEmJ6erKrCYvZ6(object object_0, object object_1)
	{
		((Control)object_0).OnVisibleChanged((EventArgs)object_1);
	}

	internal static bool eu1DXYENZYnkgt4BnKk()
	{
		return true;
	}

	internal static bool emB998ErdOyttYrQ8gR()
	{
		return false;
	}

	internal static void eIipVhEx3fYQZaM9ybM(object object_0, bool bool_0)
	{
		((Timer)object_0).set_Enabled(bool_0);
	}

	internal static void ePrdeCEzAVvckxtxDKQ(object object_0)
	{
		((Control)object_0).Refresh();
	}

	internal static int eqlomeY7WWe1QBgJxDI(float float_0)
	{
		return Convert.ToInt32(float_0);
	}

	internal static void ehKJnyY9cSQ2wMbj5q9(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void e6tFKdYkGSK3OHE3BKW(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static void eOA91QYQ62vSAwxeZ6R(object object_0, float float_0, float float_1)
	{
		((Control)object_0).ScaleCore(float_0, float_1);
	}

	internal static void elO8PXYLaxmD7roqhhK(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static void e0NYnZYJSZCPpPZbTbE(object object_0)
	{
		((Image)object_0).Dispose();
	}

	internal static void eVYeX0YjdaQDUucgduX(object object_0)
	{
		((Component)object_0).Dispose();
	}

	internal static void eOo1g9Y5yTRTWAaytPw(object object_0, bool bool_0)
	{
		((Control)object_0).Dispose(bool_0);
	}

	internal static object e0PoxnYCQaSJPqUNfit(object object_0)
	{
		return ((PaintEventArgs)object_0).get_Graphics();
	}

	internal static void e25WBZYZZy8gJnBPKyJ(object object_0, object object_1)
	{
		((Control)object_0).OnPaint((PaintEventArgs)object_1);
	}

	internal static void eSS8QXYggmI35FyGDY4(object object_0, object object_1, Rectangle rectangle_0, Rectangle rectangle_1, GraphicsUnit graphicsUnit_0)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		((Graphics)object_0).DrawImage((Image)object_1, rectangle_0, rectangle_1, graphicsUnit_0);
	}

	internal static void e85fs1Y2LptIvAnuCjW(object object_0, Rectangle rectangle_0)
	{
		((Graphics)object_0).SetClip(rectangle_0);
	}

	internal static void eNkypGYibkaW6XFSJXj(object object_0, object object_1, Rectangle rectangle_0, int int_0, int int_1, int int_2, int int_3, GraphicsUnit graphicsUnit_0)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		((Graphics)object_0).DrawImage((Image)object_1, rectangle_0, int_0, int_1, int_2, int_3, graphicsUnit_0);
	}

	internal static object eNa44AYEF4OUaRtI1kx(object object_0)
	{
		return eRfn8RIiZZHJMAiKnX6.eulODlten((string)object_0);
	}

	internal static void e7XQdbYYpoHa4KqdGne(object object_0)
	{
		((Control)object_0)._002Ector();
	}

	internal static void e047g2YfwvkSeFLeNZO(object object_0, int int_0)
	{
		((Timer)object_0).set_Interval(int_0);
	}

	internal static void eMk7x5Yo67GQnjRRxeJ(object object_0, object object_1)
	{
		((Timer)object_0).add_Tick((EventHandler)object_1);
	}

	internal static void ehWRlyYXNuIEXliyQZO(object object_0, bool bool_0)
	{
		((Control)object_0).set_TabStop(bool_0);
	}

	internal static void e85xegY6dZ2U52eWy52(object object_0, ControlStyles controlStyles_0, bool bool_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Control)object_0).SetStyle(controlStyles_0, bool_0);
	}

	internal static Type e6JkUAYdGIIECoGvHjs(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eOsrSrYaZmuXnC9Ihi9(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
