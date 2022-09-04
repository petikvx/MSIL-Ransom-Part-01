using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using eC98jAqdnPLlDITmK6;
using ehk9wbIn9KPgnTW5hn8;
using etKNQTu9kgqwCqmIAv;

namespace eijnOrIQLiET0sDviq5;

internal class eyvL4XIRqRFvuAWAOq5 : Control
{
	private Label ecs0D1Zdd;

	private PictureBox e9jslfSvk;

	private ToolTip eeN1kpseb;

	private float elN6Gg9Qb;

	private float eKyrTQhVp;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk euXHswL8F;

	protected override void OnResize(EventArgs e)
	{
		if (!eOqRoeEDBhUVHWFkwwq())
		{
		}
		emv57VE8xhpoNepM3Yf(this, new Size(emJsS7EvdheJjDV0jGC(112f * elN6Gg9Qb), emJsS7EvdheJjDV0jGC(32f * eKyrTQhVp)));
		eSuXFHEw6wu86UesG8j(this, e);
	}

	protected override void ScaleCore(float x, float y)
	{
		elN6Gg9Qb = x;
		eKyrTQhVp = y;
		eOqRoeEDBhUVHWFkwwq();
		if (eq9imFESDiSrnAXseOn())
		{
			eVaSuGE4V4tthrgOVgC(this, x, y);
		}
		etRTTqEp8ZpjFTDjFlW(this, EventArgs.Empty);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing)
		{
			_ = 1;
			if (!eOqRoeEDBhUVHWFkwwq())
			{
				if (eeN1kpseb != null)
				{
					e4K6xXEVRAKWpEQIbhg(eeN1kpseb);
				}
				if (e9jslfSvk == null)
				{
					goto IL_0035;
				}
			}
			e4K6xXEVRAKWpEQIbhg(e9jslfSvk);
		}
		goto IL_0035;
		IL_0035:
		eyny17ETKB3V3u2k3oE(this, disposing);
	}

	private void eulODlten(object sender, EventArgs e)
	{
		try
		{
			eVEnV3EGB2FI5yYDLxT(euXHswL8F(24871));
		}
		catch
		{
		}
	}

	public eyvL4XIRqRFvuAWAOq5()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		eq9imFESDiSrnAXseOn();
		if (!eOqRoeEDBhUVHWFkwwq())
		{
			ecs0D1Zdd = new Label();
			e9jslfSvk = new PictureBox();
			eeN1kpseb = new ToolTip();
			elN6Gg9Qb = 1f;
			eKyrTQhVp = 1f;
			e3N1g2EtRGtfgLKTrCY(this);
			ejp9ayE1XnJ5iN1obKT(this);
			if (eOqRoeEDBhUVHWFkwwq())
			{
				goto IL_013c;
			}
			eD3bOuERSUwFFWGUsJq(ecs0D1Zdd, (FlatStyle)3);
			e647gEEqdiJOM6ZYB3u(ecs0D1Zdd, new Point(0, 10));
		}
		erqMScEOGgP11dgO9Rj(ecs0D1Zdd, new Size(62, 24));
		efjLTfE3uQjvRcsnygv(ecs0D1Zdd, euXHswL8F(25097));
		eyk11WEeFO678t35uyW(e9jslfSvk, eBXpidEFVPFgAlf3BFG(euXHswL8F(25114)));
		e647gEEqdiJOM6ZYB3u(e9jslfSvk, new Point(72, 0));
		erqMScEOGgP11dgO9Rj(e9jslfSvk, new Size(32, 32));
		eWRXuhEKAUjGJqS1bKc(e9jslfSvk, (PictureBoxSizeMode)1);
		enJLC5EsIvpaXcauGIu(ecs0D1Zdd, new EventHandler(eulODlten));
		enJLC5EsIvpaXcauGIu(e9jslfSvk, new EventHandler(eulODlten));
		eWUl1AEI7ALbRxLYAdr(this, new EventHandler(eulODlten));
		goto IL_013c;
		IL_013c:
		eC7kmJEhAowiCPTvkpD(this, elFP55E0bgTMjHBWvjf());
		eJ5OsQEAdf4k3FxnOvH(this, bool_0: false);
		emv57VE8xhpoNepM3Yf(this, new Size(112, 32));
		eEWfJVEHgvFBom9eMOT(emgHnXEBvXgpcrkbX4f(this), new Control[2]
		{
			(Control)e9jslfSvk,
			(Control)ecs0D1Zdd
		});
		eHXTRPEWG6ukh4rvwKS(eeN1kpseb, this, euXHswL8F(25123));
		eHXTRPEWG6ukh4rvwKS(eeN1kpseb, ecs0D1Zdd, euXHswL8F(25123));
		eHXTRPEWG6ukh4rvwKS(eeN1kpseb, e9jslfSvk, euXHswL8F(25123));
		e41I1lEcgSrBS6kTq83(this, bool_0: true);
	}

	static eyvL4XIRqRFvuAWAOq5()
	{
		eTZNUCElaABc4vcCUIQ(e6V63VEUFLePJlguVYs(typeof(eyvL4XIRqRFvuAWAOq5).TypeHandle));
	}

	internal static int emJsS7EvdheJjDV0jGC(float float_0)
	{
		return Convert.ToInt32(float_0);
	}

	internal static void emv57VE8xhpoNepM3Yf(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void eSuXFHEw6wu86UesG8j(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static bool eq9imFESDiSrnAXseOn()
	{
		return true;
	}

	internal static bool eOqRoeEDBhUVHWFkwwq()
	{
		return false;
	}

	internal static void eVaSuGE4V4tthrgOVgC(object object_0, float float_0, float float_1)
	{
		((Control)object_0).ScaleCore(float_0, float_1);
	}

	internal static void etRTTqEp8ZpjFTDjFlW(object object_0, object object_1)
	{
		((Control)object_0).OnResize((EventArgs)object_1);
	}

	internal static void e4K6xXEVRAKWpEQIbhg(object object_0)
	{
		((Component)object_0).Dispose();
	}

	internal static void eyny17ETKB3V3u2k3oE(object object_0, bool bool_0)
	{
		((Control)object_0).Dispose(bool_0);
	}

	internal static object eVEnV3EGB2FI5yYDLxT(object object_0)
	{
		return Process.Start((string)object_0);
	}

	internal static void e3N1g2EtRGtfgLKTrCY(object object_0)
	{
		((Control)object_0)._002Ector();
	}

	internal static void ejp9ayE1XnJ5iN1obKT(object object_0)
	{
		((Control)object_0).SuspendLayout();
	}

	internal static void eD3bOuERSUwFFWGUsJq(object object_0, FlatStyle flatStyle_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((Label)object_0).set_FlatStyle(flatStyle_0);
	}

	internal static void e647gEEqdiJOM6ZYB3u(object object_0, Point point_0)
	{
		((Control)object_0).set_Location(point_0);
	}

	internal static void erqMScEOGgP11dgO9Rj(object object_0, Size size_0)
	{
		((Control)object_0).set_Size(size_0);
	}

	internal static void efjLTfE3uQjvRcsnygv(object object_0, object object_1)
	{
		((Control)object_0).set_Text((string)object_1);
	}

	internal static object eBXpidEFVPFgAlf3BFG(object object_0)
	{
		return eRfn8RIiZZHJMAiKnX6.eulODlten((string)object_0);
	}

	internal static void eyk11WEeFO678t35uyW(object object_0, object object_1)
	{
		((PictureBox)object_0).set_Image((Image)object_1);
	}

	internal static void eWRXuhEKAUjGJqS1bKc(object object_0, PictureBoxSizeMode pictureBoxSizeMode_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((PictureBox)object_0).set_SizeMode(pictureBoxSizeMode_0);
	}

	internal static void enJLC5EsIvpaXcauGIu(object object_0, object object_1)
	{
		((Control)object_0).add_Click((EventHandler)object_1);
	}

	internal static void eWUl1AEI7ALbRxLYAdr(object object_0, object object_1)
	{
		((Control)object_0).add_Click((EventHandler)object_1);
	}

	internal static object elFP55E0bgTMjHBWvjf()
	{
		return Cursors.get_Hand();
	}

	internal static void eC7kmJEhAowiCPTvkpD(object object_0, object object_1)
	{
		((Control)object_0).set_Cursor((Cursor)object_1);
	}

	internal static void eJ5OsQEAdf4k3FxnOvH(object object_0, bool bool_0)
	{
		((Control)object_0).set_TabStop(bool_0);
	}

	internal static object emgHnXEBvXgpcrkbX4f(object object_0)
	{
		return ((Control)object_0).get_Controls();
	}

	internal static void eEWfJVEHgvFBom9eMOT(object object_0, object object_1)
	{
		((ControlCollection)object_0).AddRange((Control[])object_1);
	}

	internal static void eHXTRPEWG6ukh4rvwKS(object object_0, object object_1, object object_2)
	{
		((ToolTip)object_0).SetToolTip((Control)object_1, (string)object_2);
	}

	internal static void e41I1lEcgSrBS6kTq83(object object_0, bool bool_0)
	{
		((Control)object_0).ResumeLayout(bool_0);
	}

	internal static Type e6V63VEUFLePJlguVYs(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void eTZNUCElaABc4vcCUIQ(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
