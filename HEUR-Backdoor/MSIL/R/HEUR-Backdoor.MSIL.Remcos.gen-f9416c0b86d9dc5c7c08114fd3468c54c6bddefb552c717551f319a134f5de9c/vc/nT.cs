using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace vc;

public class nT
{
	private RH ocQ;

	private If Tct;

	private BackgroundWorker UcC;

	private Sn GcJ;

	private NotifyIcon ucb;

	private static nT M6;

	public nT(Sn sn_0, NotifyIcon notifyIcon_0)
	{
		OZ.kN(OZ.Ou);
		base._002Ector();
		ucb = notifyIcon_0;
		GcJ = sn_0;
		ocQ = new RH(sn_0);
		Tct = new If(sn_0);
		FZi.kN(this, FZi.qu2);
	}

	private void rcj()
	{
		UcC = new BackgroundWorker();
		Xu7.kN(UcC, fc4, Xu7.Cu5);
		xuP.kN(UcC, QcM, xuP.iup);
		uuF.kN(UcC, scm, uuF.zue);
		int num = 0;
		if (!x5())
		{
			int num2 = default(int);
			num = num2;
		}
		switch (num)
		{
		}
		vA.kN(UcC, bool_0: true, vA.OuA);
		vA.kN(UcC, bool_0: true, vA.Dug);
	}

	public void UcA()
	{
		FZi.kN(UcC, FZi.luT);
	}

	private void fc4(object sender, DoWorkEventArgs e)
	{
		while (true)
		{
			TN5.kN(UcC, 0, TN5.YuO);
			if (Sc() != null)
			{
				switch (0)
				{
				case 1:
					continue;
				}
			}
			break;
		}
		if (Wb.kN(ocQ, Wb.YNw))
		{
			TN5.kN(UcC, 100, TN5.YuO);
			puC.kN(e, true, puC.Bu1);
		}
		else
		{
			TN5.kN(UcC, 1, TN5.YuO);
			puC.kN(e, false, puC.Bu1);
		}
	}

	private void QcM(object sender, ProgressChangedEventArgs e)
	{
		int num;
		if (wk.kN(e, wk.zuB) != 1)
		{
			if (wk.kN(e, wk.zuB) < 100)
			{
				Buk.kN(ucb, 5, "Updating", "Updating to Latest Version of LuminousForts from SVN", (ToolTipIcon)1, Buk.quX);
				return;
			}
			Buk.kN(ucb, 5, "Updated", "Update complete", (ToolTipIcon)1, Buk.quX);
			num = 0;
			if (Sc() == null)
			{
				return;
			}
		}
		else
		{
			Buk.kN(ucb, 5, "Failure", "No Update Found...", (ToolTipIcon)1, Buk.quX);
			num = 1;
			if (!x5())
			{
				int num2 = default(int);
				num = num2;
			}
		}
		switch (num)
		{
		}
	}

	private void scm(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if ((bool)bub.kN(e, bub.buj))
		{
			try
			{
				FZi.kN(Tct, FZi.yuV);
				Wb.kN(Tct, Wb.Bum);
			}
			catch (Exception object_)
			{
				suy.kN(Xv.kN(object_, Xv.Nus), "Failed to run HLDS", suy.XuH);
			}
		}
	}

	internal static bool x5()
	{
		return M6 == null;
	}

	internal static nT Sc()
	{
		return M6;
	}
}
