using System.IO;
using System.ServiceProcess;
using System.Threading;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts_AutoUpdate_Service;

public class Service : ServiceBase
{
	private SVNProcess svn = null;

	protected override void OnStart(string[] args)
	{
		Config config = new Config();
		svn = new SVNProcess(config);
		try
		{
			config.LoadConfig();
		}
		catch (IOException)
		{
			((ServiceBase)this).get_EventLog().WriteEntry("[LuminousForts-AutoUpdate]Failure to read Configuration file");
		}
		while (true)
		{
			if (svn.HasExited)
			{
				svn.Update();
			}
			Thread.Sleep(30);
		}
	}

	protected override void OnStop()
	{
		if (svn != null && !svn.HasExited)
		{
			svn.Stop();
		}
	}
}
