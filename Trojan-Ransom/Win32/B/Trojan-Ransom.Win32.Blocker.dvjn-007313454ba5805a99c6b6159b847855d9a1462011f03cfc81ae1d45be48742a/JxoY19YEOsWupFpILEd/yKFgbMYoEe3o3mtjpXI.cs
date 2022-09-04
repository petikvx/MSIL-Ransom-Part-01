using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using B43f3cMmUbTdiovLVhZ;
using DmD7ZdYq9A63tmZUP6p;
using KMYuQwYr9ylKSf89qY4;
using N5n40dM8NkUQdRhLW59;
using ProwxkN4F4ab5Fc8FL;
using UiEhBsY6XRSY1vZqRAw;
using lX2Q3LM2UyxwFwlqnc5;

namespace JxoY19YEOsWupFpILEd;

internal sealed class yKFgbMYoEe3o3mtjpXI : obNUo3YHqk3Q5hwqpRV
{
	protected override void vmethod_2(LWbQMtMlFuKHH87WKxp lwbQMtMlFuKHH87WKxp_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		P0wqovYSmZ5pEr7obbD p0wqovYSmZ5pEr7obbD = new P0wqovYSmZ5pEr7obbD(lwbQMtMlFuKHH87WKxp_0);
		try
		{
			((Form)p0wqovYSmZ5pEr7obbD).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)p0wqovYSmZ5pEr7obbD)?.Dispose();
		}
	}

	protected override void vmethod_0(Iun4mxMs3HspeLXRTIp iun4mxMs3HspeLXRTIp_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		rQjEHXYCCZyZkGXnNZY rQjEHXYCCZyZkGXnNZY = new rQjEHXYCCZyZkGXnNZY(this, iun4mxMs3HspeLXRTIp_0);
		try
		{
			((Form)rQjEHXYCCZyZkGXnNZY).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)rQjEHXYCCZyZkGXnNZY)?.Dispose();
		}
	}

	protected override void vmethod_1(eShMauMILksMTN7ckoh eShMauMILksMTN7ckoh_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(eShMauMILksMTN7ckoh_0.method_0().ToString(), string.Format(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(683555), DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(682453)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool VBMU2eVssp()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			obNUo3YHqk3Q5hwqpRV.wANAMjdaVR(new yKFgbMYoEe3o3mtjpXI());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(683584), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string string_ = string.Format(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(683609), DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(682453));
				P0wqovYSmZ5pEr7obbD p0wqovYSmZ5pEr7obbD = new P0wqovYSmZ5pEr7obbD(new LWbQMtMlFuKHH87WKxp(string_, bool_0: false));
				((Form)p0wqovYSmZ5pEr7obbD).set_ShowInTaskbar(true);
				((Form)p0wqovYSmZ5pEr7obbD).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format(DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(683555), DvpNOnmtA3NHWcIMFu.VGXYlx2PBu(682453)), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}

	internal static bool h2jHhECc12C3Hr6Bt47()
	{
		return true;
	}

	internal static bool uedhs1C0MIcqdCc3fPK()
	{
		return false;
	}
}
