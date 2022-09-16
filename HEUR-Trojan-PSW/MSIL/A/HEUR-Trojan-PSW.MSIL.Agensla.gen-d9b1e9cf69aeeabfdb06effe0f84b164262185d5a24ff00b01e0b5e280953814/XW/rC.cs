using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace XW;

public class rC
{
	private lA rLD;

	private Ru EL7;

	private BackgroundWorker wLj;

	private Gp tLs;

	private NotifyIcon NLh;

	internal static rC iP;

	public rC(Gp gp_0, NotifyIcon notifyIcon_0)
	{
		G3.nJ(G3.By);
		base._002Ector();
		NLh = notifyIcon_0;
		tLs = gp_0;
		rLD = new lA(gp_0);
		EL7 = new Ru(gp_0);
		Pyq.nJ(this, Pyq.uXd);
	}

	private void WLq()
	{
		wLj = new BackgroundWorker();
		WXQ.nJ(wLj, HL2, WXQ.VXq);
		GX9.nJ(wLj, nLS, GX9.gXZ);
		vXB.nJ(wLj, xLt, vXB.AXx);
		JJO.nJ(wLj, bool_0: true, JJO.PXR);
		JJO.nJ(wLj, bool_0: true, JJO.uXi);
		int num = 0;
		if (!mp())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
	}

	public void pLF()
	{
		Pyq.nJ(wLj, Pyq.NX0);
	}

	private void HL2(object sender, DoWorkEventArgs e)
	{
		TJw.nJ(wLj, 0, TJw.YXm);
		if (WM.nJ(rLD, WM.kf))
		{
			TJw.nJ(wLj, 100, TJw.YXm);
			gX1.nJ(e, true, gX1.AXY);
		}
		else
		{
			TJw.nJ(wLj, 1, TJw.YXm);
			gX1.nJ(e, false, gX1.AXY);
		}
	}

	private void nLS(object sender, ProgressChangedEventArgs e)
	{
		if (IJa.nJ(e, IJa.aXr) == 1)
		{
			nXK.nJ(NLh, 5, "Failure", "No Update Found...", (ToolTipIcon)1, nXK.FXg);
			return;
		}
		if (IJa.nJ(e, IJa.aXr) < 100)
		{
			int num = 0;
			if (f8() != null)
			{
				int num2 = default(int);
				num = num2;
			}
			switch (num)
			{
			default:
				nXK.nJ(NLh, 5, "Updating", "Updating to Latest Version of CimexUtility from SVN", (ToolTipIcon)1, nXK.FXg);
				return;
			case 1:
				break;
			}
		}
		nXK.nJ(NLh, 5, "Updated", "Update complete", (ToolTipIcon)1, nXK.FXg);
	}

	private void xLt(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if ((bool)nZ.nJ(e, nZ.QXD))
		{
			try
			{
				Pyq.nJ(EL7, Pyq.dXb);
				WM.nJ(EL7, WM.YX4);
			}
			catch (Exception object_)
			{
				LXa.nJ(Xi.nJ(object_, Xi.wXG), "Failed to run HLDS", LXa.nXA);
			}
		}
	}

	internal static bool mp()
	{
		return iP == null;
	}

	internal static rC f8()
	{
		return iP;
	}
}
