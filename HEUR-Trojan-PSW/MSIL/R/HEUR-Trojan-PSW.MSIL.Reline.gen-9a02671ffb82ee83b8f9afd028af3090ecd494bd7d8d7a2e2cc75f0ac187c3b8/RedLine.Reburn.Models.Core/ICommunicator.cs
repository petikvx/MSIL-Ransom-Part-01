using System;
using System.Collections.Generic;
using RedLine.Reburn.Models.Info;

namespace RedLine.Reburn.Models.Core;

public interface ICommunicator : IDisposable
{
	bool InitConnection(string address);

	bool TryGetSettings(out ClientSettings settings);

	bool TrySendLog(UserLog user);

	bool TryGetTasks(UserLog user, out IList<RemoteTask> remoteTasks);

	bool TryCompleteTask(UserLog user, int taskId);
}
