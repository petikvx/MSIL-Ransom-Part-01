using System.IO;
using System.Threading;
using LuminousForts_AutoUpdate_Shared;

namespace LuminousForts_AutoUpdate_Service;

public class UpdateService
{
	private Logger logger;

	private SVNProcess svn;

	public UpdateService(Logger logger, Config config)
	{
		this.logger = logger;
		svn = new SVNProcess(config);
	}

	public void OnStart(string[] args)
	{
		Config config = new Config();
		try
		{
			config.LoadConfig();
		}
		catch (IOException)
		{
			logger.WriteEntry("[LuminousForts-AutoUpdate]Failure to read Configuration file");
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

	public void OnStop()
	{
		if (!svn.HasExited)
		{
			svn.Stop();
		}
	}
}
