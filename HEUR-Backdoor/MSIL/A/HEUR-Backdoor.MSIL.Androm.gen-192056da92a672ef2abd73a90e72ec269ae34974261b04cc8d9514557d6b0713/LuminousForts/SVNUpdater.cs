using System;
using System.ComponentModel;
using System.Windows.Forms;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts;

public class SVNUpdater
{
	private SVNProcess svn;

	private HLDSProcess hlds;

	private BackgroundWorker svnWorker;

	private Config config;

	private NotifyIcon icon;

	public SVNUpdater(Config config, NotifyIcon icon)
	{
		this.icon = icon;
		this.config = config;
		svn = new SVNProcess(config);
		hlds = new HLDSProcess(config);
		InitializeWorker();
	}

	private void InitializeWorker()
	{
		svnWorker = new BackgroundWorker();
		svnWorker.DoWork += svnWorker_DoWork;
		svnWorker.ProgressChanged += svnWorker_ProgressChanged;
		svnWorker.RunWorkerCompleted += svnWorker_RunWorkerCompleted;
		svnWorker.WorkerReportsProgress = true;
		svnWorker.WorkerSupportsCancellation = true;
	}

	public void Update()
	{
		svnWorker.RunWorkerAsync();
	}

	private void svnWorker_DoWork(object sender, DoWorkEventArgs e)
	{
		svnWorker.ReportProgress(0);
		if (svn.Update())
		{
			svnWorker.ReportProgress(100);
			e.Result = true;
		}
		else
		{
			svnWorker.ReportProgress(1);
			e.Result = false;
		}
	}

	private void svnWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		if (e.ProgressPercentage == 1)
		{
			icon.ShowBalloonTip(5, "Failure", "No Update Found...", (ToolTipIcon)1);
		}
		else if (e.ProgressPercentage < 100)
		{
			icon.ShowBalloonTip(5, "Updating", "Updating to Latest Version of LuminousForts from SVN", (ToolTipIcon)1);
		}
		else
		{
			icon.ShowBalloonTip(5, "Updated", "Update complete", (ToolTipIcon)1);
		}
	}

	private void svnWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if ((bool)e.Result)
		{
			try
			{
				hlds.Stop();
				hlds.Start();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Failed to run HLDS");
			}
		}
	}
}
